using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Funly.SkyStudio
{
	// Token: 0x020001D7 RID: 471
	public abstract class BaseSpriteInstancedRenderer : MonoBehaviour
	{
		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0002E0A0 File Offset: 0x0002C2A0
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x0002E0A8 File Offset: 0x0002C2A8
		public int maxSprites { get; protected set; }

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0002E0B1 File Offset: 0x0002C2B1
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x0002E0B9 File Offset: 0x0002C2B9
		protected Camera m_ViewerCamera { get; set; }

		// Token: 0x06000A58 RID: 2648 RVA: 0x0002E0C2 File Offset: 0x0002C2C2
		private void Start()
		{
			if (!SystemInfo.supportsInstancing)
			{
				Debug.LogError("Can't render since GPU instancing isn't supported on this device");
				base.enabled = false;
				return;
			}
			this.m_ViewerCamera = Camera.main;
		}

		// Token: 0x06000A59 RID: 2649
		protected abstract Bounds CalculateMeshBounds();

		// Token: 0x06000A5A RID: 2650
		protected abstract BaseSpriteItemData CreateSpriteItemData();

		// Token: 0x06000A5B RID: 2651
		protected abstract bool IsRenderingEnabled();

		// Token: 0x06000A5C RID: 2652
		protected abstract int GetNextSpawnCount();

		// Token: 0x06000A5D RID: 2653
		protected abstract void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale);

		// Token: 0x06000A5E RID: 2654
		protected abstract void ConfigureSpriteItemData(BaseSpriteItemData data);

		// Token: 0x06000A5F RID: 2655
		protected abstract void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data);

		// Token: 0x06000A60 RID: 2656
		protected abstract void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock);

		// Token: 0x06000A61 RID: 2657 RVA: 0x0002E0E8 File Offset: 0x0002C2E8
		private BaseSpriteItemData DequeueNextSpriteItemData()
		{
			BaseSpriteItemData baseSpriteItemData;
			if (this.m_Available.Count == 0)
			{
				baseSpriteItemData = this.CreateSpriteItemData();
			}
			else
			{
				baseSpriteItemData = this.m_Available.Dequeue();
			}
			this.m_Active.Add(baseSpriteItemData);
			return baseSpriteItemData;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0002E127 File Offset: 0x0002C327
		private void ReturnSpriteItemData(BaseSpriteItemData splash)
		{
			splash.Reset();
			this.m_Active.Remove(splash);
			this.m_Available.Enqueue(splash);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0002E148 File Offset: 0x0002C348
		protected virtual void LateUpdate()
		{
			this.m_ViewerCamera = Camera.main;
			if (!this.IsRenderingEnabled())
			{
				return;
			}
			this.GenerateNewSprites();
			this.AdvanceAllSprites();
			this.RenderAllSprites();
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0002E170 File Offset: 0x0002C370
		private void GenerateNewSprites()
		{
			int nextSpawnCount = this.GetNextSpawnCount();
			for (int i = 0; i < nextSpawnCount; i++)
			{
				BaseSpriteItemData baseSpriteItemData = this.DequeueNextSpriteItemData();
				baseSpriteItemData.spriteSheetData = this.m_SpriteSheetLayout;
				this.ConfigureSpriteItemData(baseSpriteItemData);
				Vector3 worldPosition;
				Quaternion rotation;
				Vector3 scale;
				this.CalculateSpriteTRS(baseSpriteItemData, out worldPosition, out rotation, out scale);
				baseSpriteItemData.SetTRSMatrix(worldPosition, rotation, scale);
				baseSpriteItemData.Start();
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
		private void AdvanceAllSprites()
		{
			foreach (BaseSpriteItemData baseSpriteItemData in new HashSet<BaseSpriteItemData>(this.m_Active))
			{
				baseSpriteItemData.Continue();
				if (baseSpriteItemData.state == BaseSpriteItemData.SpriteState.Complete)
				{
					this.ReturnSpriteItemData(baseSpriteItemData);
				}
			}
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0002E238 File Offset: 0x0002C438
		private void RenderAllSprites()
		{
			if (this.m_Active.Count == 0)
			{
				return;
			}
			if (this.renderMaterial == null)
			{
				Debug.LogError("Can't render sprite without a material.");
				return;
			}
			if (this.m_PropertyBlock == null)
			{
				this.m_PropertyBlock = new MaterialPropertyBlock();
			}
			int num = 0;
			foreach (BaseSpriteItemData baseSpriteItemData in this.m_Active)
			{
				if (num >= 1000)
				{
					Debug.LogError("Can't render any more sprites...");
					break;
				}
				if (baseSpriteItemData.state == BaseSpriteItemData.SpriteState.Animating && baseSpriteItemData.startTime <= Time.time)
				{
					this.m_ModelMatrices[num] = baseSpriteItemData.modelMatrix;
					this.m_StartTimes[num] = baseSpriteItemData.startTime;
					this.m_EndTimes[num] = baseSpriteItemData.endTime;
					this.PrepareDataArraysForRendering(num, baseSpriteItemData);
					num++;
				}
			}
			if (num == 0)
			{
				return;
			}
			this.m_PropertyBlock.Clear();
			this.m_PropertyBlock.SetFloatArray("_StartTime", this.m_StartTimes);
			this.m_PropertyBlock.SetFloatArray("_EndTime", this.m_EndTimes);
			this.m_PropertyBlock.SetFloat("_SpriteColumnCount", (float)this.m_SpriteSheetLayout.columns);
			this.m_PropertyBlock.SetFloat("_SpriteRowCount", (float)this.m_SpriteSheetLayout.rows);
			this.m_PropertyBlock.SetFloat("_SpriteItemCount", (float)this.m_SpriteSheetLayout.frameCount);
			this.m_PropertyBlock.SetFloat("_AnimationSpeed", (float)this.m_SpriteSheetLayout.frameRate);
			this.m_PropertyBlock.SetVector("_TintColor", this.m_TintColor);
			this.PopulatePropertyBlockForRendering(ref this.m_PropertyBlock);
			Mesh mesh = this.GetMesh();
			mesh.bounds = this.CalculateMeshBounds();
			Graphics.DrawMeshInstanced(mesh, 0, this.renderMaterial, this.m_ModelMatrices, num, this.m_PropertyBlock, ShadowCastingMode.Off, false, LayerMask.NameToLayer("TransparentFX"));
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0002E430 File Offset: 0x0002C630
		protected Mesh GetMesh()
		{
			if (this.modelMesh)
			{
				return this.modelMesh;
			}
			if (this.m_DefaltModelMesh)
			{
				return this.m_DefaltModelMesh;
			}
			this.m_DefaltModelMesh = this.GenerateMesh();
			return this.m_DefaltModelMesh;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0002E46C File Offset: 0x0002C66C
		protected virtual Mesh GenerateMesh()
		{
			Mesh mesh = new Mesh();
			Vector3[] vertices = new Vector3[]
			{
				new Vector3(-1f, -1f, 0f),
				new Vector3(-1f, 1f, 0f),
				new Vector3(1f, 1f, 0f),
				new Vector3(1f, -1f, 0f)
			};
			Vector2[] uv = new Vector2[]
			{
				new Vector2(0f, 0f),
				new Vector2(0f, 1f),
				new Vector2(1f, 1f),
				new Vector2(1f, 0f)
			};
			int[] triangles = new int[]
			{
				0,
				1,
				2,
				0,
				2,
				3
			};
			mesh.vertices = vertices;
			mesh.uv = uv;
			mesh.triangles = triangles;
			mesh.bounds = new Bounds(Vector3.zero, new Vector3(500f, 500f, 500f));
			return mesh;
		}

		// Token: 0x04000B5A RID: 2906
		public const int kArrayMaxSprites = 1000;

		// Token: 0x04000B5C RID: 2908
		[Tooltip("Mesh used to render the instances onto. If empty, a quad will be used.")]
		public Mesh modelMesh;

		// Token: 0x04000B5D RID: 2909
		[Tooltip("Sky Studio sprite sheet animated shader material.")]
		public Material renderMaterial;

		// Token: 0x04000B5E RID: 2910
		protected Queue<BaseSpriteItemData> m_Available = new Queue<BaseSpriteItemData>();

		// Token: 0x04000B5F RID: 2911
		protected HashSet<BaseSpriteItemData> m_Active = new HashSet<BaseSpriteItemData>();

		// Token: 0x04000B60 RID: 2912
		private MaterialPropertyBlock m_PropertyBlock;

		// Token: 0x04000B61 RID: 2913
		private Matrix4x4[] m_ModelMatrices = new Matrix4x4[1000];

		// Token: 0x04000B62 RID: 2914
		private float[] m_StartTimes = new float[1000];

		// Token: 0x04000B63 RID: 2915
		private float[] m_EndTimes = new float[1000];

		// Token: 0x04000B64 RID: 2916
		protected SpriteSheetData m_SpriteSheetLayout = new SpriteSheetData();

		// Token: 0x04000B65 RID: 2917
		protected Texture m_SpriteTexture;

		// Token: 0x04000B66 RID: 2918
		protected Color m_TintColor = Color.white;

		// Token: 0x04000B68 RID: 2920
		protected Mesh m_DefaltModelMesh;
	}
}
