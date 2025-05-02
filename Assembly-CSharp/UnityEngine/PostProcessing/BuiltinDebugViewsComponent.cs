using System;
using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000072 RID: 114
	public sealed class BuiltinDebugViewsComponent : PostProcessingComponentCommandBuffer<BuiltinDebugViewsModel>
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000DCDB File Offset: 0x0000BEDB
		public override bool active
		{
			get
			{
				return base.model.IsModeActive(BuiltinDebugViewsModel.Mode.Depth) || base.model.IsModeActive(BuiltinDebugViewsModel.Mode.Normals) || base.model.IsModeActive(BuiltinDebugViewsModel.Mode.MotionVectors);
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000DD08 File Offset: 0x0000BF08
		public override DepthTextureMode GetCameraFlags()
		{
			BuiltinDebugViewsModel.Mode mode = base.model.settings.mode;
			DepthTextureMode depthTextureMode = DepthTextureMode.None;
			switch (mode)
			{
			case BuiltinDebugViewsModel.Mode.Depth:
				depthTextureMode |= DepthTextureMode.Depth;
				break;
			case BuiltinDebugViewsModel.Mode.Normals:
				depthTextureMode |= DepthTextureMode.DepthNormals;
				break;
			case BuiltinDebugViewsModel.Mode.MotionVectors:
				depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.MotionVectors);
				break;
			}
			return depthTextureMode;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000DD4F File Offset: 0x0000BF4F
		public override CameraEvent GetCameraEvent()
		{
			if (base.model.settings.mode != BuiltinDebugViewsModel.Mode.MotionVectors)
			{
				return CameraEvent.BeforeImageEffectsOpaque;
			}
			return CameraEvent.BeforeImageEffects;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000DD69 File Offset: 0x0000BF69
		public override string GetName()
		{
			return "Builtin Debug Views";
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000DD70 File Offset: 0x0000BF70
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
			ref BuiltinDebugViewsModel.Settings settings = base.model.settings;
			Material material = this.context.materialFactory.Get("Hidden/Post FX/Builtin Debug Views");
			material.shaderKeywords = null;
			if (this.context.isGBufferAvailable)
			{
				material.EnableKeyword("SOURCE_GBUFFER");
			}
			switch (settings.mode)
			{
			case BuiltinDebugViewsModel.Mode.Depth:
				this.DepthPass(cb);
				break;
			case BuiltinDebugViewsModel.Mode.Normals:
				this.DepthNormalsPass(cb);
				break;
			case BuiltinDebugViewsModel.Mode.MotionVectors:
				this.MotionVectorsPass(cb);
				break;
			}
			this.context.Interrupt();
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000DE00 File Offset: 0x0000C000
		private void DepthPass(CommandBuffer cb)
		{
			Material mat = this.context.materialFactory.Get("Hidden/Post FX/Builtin Debug Views");
			BuiltinDebugViewsModel.DepthSettings depth = base.model.settings.depth;
			cb.SetGlobalFloat(BuiltinDebugViewsComponent.Uniforms._DepthScale, 1f / depth.scale);
			cb.Blit(null, BuiltinRenderTextureType.CameraTarget, mat, 0);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000DE5C File Offset: 0x0000C05C
		private void DepthNormalsPass(CommandBuffer cb)
		{
			Material mat = this.context.materialFactory.Get("Hidden/Post FX/Builtin Debug Views");
			cb.Blit(null, BuiltinRenderTextureType.CameraTarget, mat, 1);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000DE90 File Offset: 0x0000C090
		private void MotionVectorsPass(CommandBuffer cb)
		{
			Material material = this.context.materialFactory.Get("Hidden/Post FX/Builtin Debug Views");
			BuiltinDebugViewsModel.MotionVectorsSettings motionVectors = base.model.settings.motionVectors;
			int nameID = BuiltinDebugViewsComponent.Uniforms._TempRT;
			cb.GetTemporaryRT(nameID, this.context.width, this.context.height, 0, FilterMode.Bilinear);
			cb.SetGlobalFloat(BuiltinDebugViewsComponent.Uniforms._Opacity, motionVectors.sourceOpacity);
			cb.SetGlobalTexture(BuiltinDebugViewsComponent.Uniforms._MainTex, BuiltinRenderTextureType.CameraTarget);
			cb.Blit(BuiltinRenderTextureType.CameraTarget, nameID, material, 2);
			if (motionVectors.motionImageOpacity > 0f && motionVectors.motionImageAmplitude > 0f)
			{
				int tempRT = BuiltinDebugViewsComponent.Uniforms._TempRT2;
				cb.GetTemporaryRT(tempRT, this.context.width, this.context.height, 0, FilterMode.Bilinear);
				cb.SetGlobalFloat(BuiltinDebugViewsComponent.Uniforms._Opacity, motionVectors.motionImageOpacity);
				cb.SetGlobalFloat(BuiltinDebugViewsComponent.Uniforms._Amplitude, motionVectors.motionImageAmplitude);
				cb.SetGlobalTexture(BuiltinDebugViewsComponent.Uniforms._MainTex, nameID);
				cb.Blit(nameID, tempRT, material, 3);
				cb.ReleaseTemporaryRT(nameID);
				nameID = tempRT;
			}
			if (motionVectors.motionVectorsOpacity > 0f && motionVectors.motionVectorsAmplitude > 0f)
			{
				this.PrepareArrows();
				float num = 1f / (float)motionVectors.motionVectorsResolution;
				float x = num * (float)this.context.height / (float)this.context.width;
				cb.SetGlobalVector(BuiltinDebugViewsComponent.Uniforms._Scale, new Vector2(x, num));
				cb.SetGlobalFloat(BuiltinDebugViewsComponent.Uniforms._Opacity, motionVectors.motionVectorsOpacity);
				cb.SetGlobalFloat(BuiltinDebugViewsComponent.Uniforms._Amplitude, motionVectors.motionVectorsAmplitude);
				cb.DrawMesh(this.m_Arrows.mesh, Matrix4x4.identity, material, 0, 4);
			}
			cb.SetGlobalTexture(BuiltinDebugViewsComponent.Uniforms._MainTex, nameID);
			cb.Blit(nameID, BuiltinRenderTextureType.CameraTarget);
			cb.ReleaseTemporaryRT(nameID);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000E084 File Offset: 0x0000C284
		private void PrepareArrows()
		{
			int motionVectorsResolution = base.model.settings.motionVectors.motionVectorsResolution;
			int num = motionVectorsResolution * Screen.width / Screen.height;
			if (this.m_Arrows == null)
			{
				this.m_Arrows = new BuiltinDebugViewsComponent.ArrowArray();
			}
			if (this.m_Arrows.columnCount != num || this.m_Arrows.rowCount != motionVectorsResolution)
			{
				this.m_Arrows.Release();
				this.m_Arrows.BuildMesh(num, motionVectorsResolution);
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000E0FC File Offset: 0x0000C2FC
		public override void OnDisable()
		{
			if (this.m_Arrows != null)
			{
				this.m_Arrows.Release();
			}
			this.m_Arrows = null;
		}

		// Token: 0x0400029E RID: 670
		private const string k_ShaderString = "Hidden/Post FX/Builtin Debug Views";

		// Token: 0x0400029F RID: 671
		private BuiltinDebugViewsComponent.ArrowArray m_Arrows;

		// Token: 0x02000073 RID: 115
		private static class Uniforms
		{
			// Token: 0x040002A0 RID: 672
			internal static readonly int _DepthScale = Shader.PropertyToID("_DepthScale");

			// Token: 0x040002A1 RID: 673
			internal static readonly int _TempRT = Shader.PropertyToID("_TempRT");

			// Token: 0x040002A2 RID: 674
			internal static readonly int _Opacity = Shader.PropertyToID("_Opacity");

			// Token: 0x040002A3 RID: 675
			internal static readonly int _MainTex = Shader.PropertyToID("_MainTex");

			// Token: 0x040002A4 RID: 676
			internal static readonly int _TempRT2 = Shader.PropertyToID("_TempRT2");

			// Token: 0x040002A5 RID: 677
			internal static readonly int _Amplitude = Shader.PropertyToID("_Amplitude");

			// Token: 0x040002A6 RID: 678
			internal static readonly int _Scale = Shader.PropertyToID("_Scale");
		}

		// Token: 0x02000074 RID: 116
		private enum Pass
		{
			// Token: 0x040002A8 RID: 680
			Depth,
			// Token: 0x040002A9 RID: 681
			Normals,
			// Token: 0x040002AA RID: 682
			MovecOpacity,
			// Token: 0x040002AB RID: 683
			MovecImaging,
			// Token: 0x040002AC RID: 684
			MovecArrows
		}

		// Token: 0x02000075 RID: 117
		private class ArrowArray
		{
			// Token: 0x17000035 RID: 53
			// (get) Token: 0x0600025C RID: 604 RVA: 0x0000E196 File Offset: 0x0000C396
			// (set) Token: 0x0600025D RID: 605 RVA: 0x0000E19E File Offset: 0x0000C39E
			public Mesh mesh { get; private set; }

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x0600025E RID: 606 RVA: 0x0000E1A7 File Offset: 0x0000C3A7
			// (set) Token: 0x0600025F RID: 607 RVA: 0x0000E1AF File Offset: 0x0000C3AF
			public int columnCount { get; private set; }

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000260 RID: 608 RVA: 0x0000E1B8 File Offset: 0x0000C3B8
			// (set) Token: 0x06000261 RID: 609 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
			public int rowCount { get; private set; }

			// Token: 0x06000262 RID: 610 RVA: 0x0000E1CC File Offset: 0x0000C3CC
			public void BuildMesh(int columns, int rows)
			{
				Vector3[] array = new Vector3[]
				{
					new Vector3(0f, 0f, 0f),
					new Vector3(0f, 1f, 0f),
					new Vector3(0f, 1f, 0f),
					new Vector3(-1f, 1f, 0f),
					new Vector3(0f, 1f, 0f),
					new Vector3(1f, 1f, 0f)
				};
				int num = 6 * columns * rows;
				List<Vector3> list = new List<Vector3>(num);
				List<Vector2> list2 = new List<Vector2>(num);
				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < columns; j++)
					{
						Vector2 item = new Vector2((0.5f + (float)j) / (float)columns, (0.5f + (float)i) / (float)rows);
						for (int k = 0; k < 6; k++)
						{
							list.Add(array[k]);
							list2.Add(item);
						}
					}
				}
				int[] array2 = new int[num];
				for (int l = 0; l < num; l++)
				{
					array2[l] = l;
				}
				this.mesh = new Mesh
				{
					hideFlags = HideFlags.DontSave
				};
				this.mesh.SetVertices(list);
				this.mesh.SetUVs(0, list2);
				this.mesh.SetIndices(array2, MeshTopology.Lines, 0);
				this.mesh.UploadMeshData(true);
				this.columnCount = columns;
				this.rowCount = rows;
			}

			// Token: 0x06000263 RID: 611 RVA: 0x0000E36F File Offset: 0x0000C56F
			public void Release()
			{
				GraphicsUtils.Destroy(this.mesh);
				this.mesh = null;
			}
		}
	}
}
