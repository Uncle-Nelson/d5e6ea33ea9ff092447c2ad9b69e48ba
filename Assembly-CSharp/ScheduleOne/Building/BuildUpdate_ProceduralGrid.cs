using System;
using System.Collections.Generic;
using FishNet.Object;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x0200078F RID: 1935
	public class BuildUpdate_ProceduralGrid : BuildUpdate_Base
	{
		// Token: 0x060034B7 RID: 13495 RVA: 0x000DCD60 File Offset: 0x000DAF60
		protected virtual void Update()
		{
			this.CheckRotation();
			if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick) && this.validPosition)
			{
				this.Place();
			}
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x000DCD80 File Offset: 0x000DAF80
		protected virtual void LateUpdate()
		{
			this.validPosition = false;
			this.GhostModel.transform.up = Vector3.up;
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(this.detectionRange, out raycastHit, this.detectionMask, true, 0f))
			{
				this.GhostModel.transform.position = raycastHit.point - this.GhostModel.transform.InverseTransformPoint(this.ItemClass.BuildPoint.transform.position);
			}
			else
			{
				this.GhostModel.transform.position = PlayerSingleton<PlayerCamera>.Instance.transform.position + PlayerSingleton<PlayerCamera>.Instance.transform.forward * this.ItemClass.HoldDistance;
				if (this.ItemClass.MidAirCenterPoint != null)
				{
					this.GhostModel.transform.position += -this.GhostModel.transform.InverseTransformPoint(this.ItemClass.MidAirCenterPoint.transform.position);
				}
			}
			this.ApplyRotation();
			this.CheckGridIntersections();
			this.UpdateMaterials();
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x000DCEBC File Offset: 0x000DB0BC
		protected void CheckRotation()
		{
			if (GameInput.GetButtonDown(GameInput.ButtonCode.RotateLeft) && !GameInput.IsTyping)
			{
				this.currentRotation -= 90f;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.RotateRight) && !GameInput.IsTyping)
			{
				this.currentRotation += 90f;
			}
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x000DCF10 File Offset: 0x000DB110
		protected void ApplyRotation()
		{
			this.GhostModel.transform.rotation = Quaternion.Inverse(this.ItemClass.BuildPoint.transform.rotation) * this.GhostModel.transform.rotation;
			ProceduralTile nearbyProcTile = this.GetNearbyProcTile();
			float num = this.currentRotation;
			if (nearbyProcTile != null)
			{
				num += nearbyProcTile.transform.eulerAngles.y;
			}
			this.GhostModel.transform.Rotate(this.ItemClass.BuildPoint.up, num);
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x000DCFA8 File Offset: 0x000DB1A8
		protected virtual void CheckGridIntersections()
		{
			this.ItemClass.CalculateFootprintTileIntersections();
			List<BuildUpdate_ProceduralGrid.Intersection> list = new List<BuildUpdate_ProceduralGrid.Intersection>();
			for (int i = 0; i < this.ItemClass.CoordinateFootprintTilePairs.Count; i++)
			{
				for (int j = 0; j < this.ItemClass.CoordinateFootprintTilePairs[i].footprintTile.tileDetector.intersectedProceduralTiles.Count; j++)
				{
					list.Add(new BuildUpdate_ProceduralGrid.Intersection
					{
						footprintTile = this.ItemClass.CoordinateFootprintTilePairs[i].footprintTile,
						procTile = this.ItemClass.CoordinateFootprintTilePairs[i].footprintTile.tileDetector.intersectedProceduralTiles[j]
					});
				}
			}
			if (list.Count == 0)
			{
				this.ItemClass.SetFootprintTileVisiblity(false);
				return;
			}
			this.ItemClass.SetFootprintTileVisiblity(true);
			float num = 100f;
			this.bestIntersection = null;
			for (int k = 0; k < list.Count; k++)
			{
				if (Vector3.Distance(list[k].footprintTile.transform.position, list[k].procTile.transform.position) < num)
				{
					num = Vector3.Distance(list[k].footprintTile.transform.position, list[k].procTile.transform.position);
					this.bestIntersection = list[k];
				}
			}
			this.validPosition = true;
			this.GhostModel.transform.position = this.bestIntersection.procTile.transform.position - (this.bestIntersection.footprintTile.transform.position - this.GhostModel.transform.position);
			this.ItemClass.CalculateFootprintTileIntersections();
			for (int l = 0; l < this.ItemClass.CoordinateFootprintTilePairs.Count; l++)
			{
				bool flag = false;
				ProceduralTile closestProceduralTile = this.ItemClass.CoordinateFootprintTilePairs[l].footprintTile.tileDetector.GetClosestProceduralTile();
				if (this.IsMatchValid(this.ItemClass.CoordinateFootprintTilePairs[l].footprintTile, closestProceduralTile))
				{
					flag = true;
				}
				if (flag)
				{
					this.ItemClass.CoordinateFootprintTilePairs[l].footprintTile.tileAppearance.SetColor(ETileColor.White);
				}
				else
				{
					this.validPosition = false;
					this.ItemClass.CoordinateFootprintTilePairs[l].footprintTile.tileAppearance.SetColor(ETileColor.Red);
				}
			}
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x000DD258 File Offset: 0x000DB458
		protected void UpdateMaterials()
		{
			Material material = Singleton<BuildManager>.Instance.ghostMaterial_White;
			if (!this.validPosition)
			{
				material = Singleton<BuildManager>.Instance.ghostMaterial_Red;
			}
			if (this.currentGhostMaterial != material)
			{
				this.currentGhostMaterial = material;
				Singleton<BuildManager>.Instance.ApplyMaterial(this.GhostModel, material, true);
			}
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x000DD2AC File Offset: 0x000DB4AC
		private bool IsMatchValid(FootprintTile footprintTile, ProceduralTile matchedTile)
		{
			return !(footprintTile == null) && !(matchedTile == null) && (Vector3.Distance(matchedTile.transform.position, footprintTile.transform.position) < 0.01f && matchedTile.Occupants.Count == 0 && matchedTile.TileType == this.ItemClass.ProceduralTileType);
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x000DD314 File Offset: 0x000DB514
		protected void Place()
		{
			List<CoordinateProceduralTilePair> list = new List<CoordinateProceduralTilePair>();
			for (int i = 0; i < this.ItemClass.CoordinateFootprintTilePairs.Count; i++)
			{
				bool flag = false;
				ProceduralTile closestProceduralTile = this.ItemClass.CoordinateFootprintTilePairs[i].footprintTile.tileDetector.GetClosestProceduralTile();
				if (this.IsMatchValid(this.ItemClass.CoordinateFootprintTilePairs[i].footprintTile, closestProceduralTile))
				{
					flag = true;
				}
				if (!flag)
				{
					Console.LogWarning("Invalid placement!", null);
					return;
				}
				NetworkObject networkObject = closestProceduralTile.ParentBuildableItem.NetworkObject;
				int tileIndex = (closestProceduralTile.ParentBuildableItem as IProceduralTileContainer).ProceduralTiles.IndexOf(closestProceduralTile);
				list.Add(new CoordinateProceduralTilePair
				{
					coord = this.ItemClass.CoordinateFootprintTilePairs[i].coord,
					tileParent = networkObject,
					tileIndex = tileIndex
				});
			}
			float f = Vector3.SignedAngle(list[0].tile.transform.forward, this.GhostModel.transform.forward, list[0].tile.transform.up);
			Singleton<BuildManager>.Instance.CreateProceduralGridItem(this.ItemInstance.GetCopy(1), Mathf.RoundToInt(f), list, "");
			PlayerSingleton<PlayerInventory>.Instance.equippedSlot.ChangeQuantity(-1, false);
			Singleton<BuildManager>.Instance.PlayBuildSound((this.ItemInstance.Definition as BuildableItemDefinition).BuildSoundType, this.GhostModel.transform.position);
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x000DD4B4 File Offset: 0x000DB6B4
		private ProceduralTile GetNearbyProcTile()
		{
			Collider[] array = Physics.OverlapSphere(this.GhostModel.transform.position, 1f, this.detectionMask);
			for (int i = 0; i < array.Length; i++)
			{
				ProceduralTile component = array[i].GetComponent<ProceduralTile>();
				if (component != null)
				{
					return component;
				}
			}
			return null;
		}

		// Token: 0x0400259B RID: 9627
		public GameObject GhostModel;

		// Token: 0x0400259C RID: 9628
		public ProceduralGridItem ItemClass;

		// Token: 0x0400259D RID: 9629
		public ItemInstance ItemInstance;

		// Token: 0x0400259E RID: 9630
		[Header("Settings")]
		public float detectionRange = 6f;

		// Token: 0x0400259F RID: 9631
		public LayerMask detectionMask;

		// Token: 0x040025A0 RID: 9632
		public float rotation_Smoothing = 5f;

		// Token: 0x040025A1 RID: 9633
		protected float currentRotation;

		// Token: 0x040025A2 RID: 9634
		protected bool validPosition;

		// Token: 0x040025A3 RID: 9635
		protected Material currentGhostMaterial;

		// Token: 0x040025A4 RID: 9636
		protected BuildUpdate_ProceduralGrid.Intersection bestIntersection;

		// Token: 0x02000790 RID: 1936
		public class Intersection
		{
			// Token: 0x040025A5 RID: 9637
			public FootprintTile footprintTile;

			// Token: 0x040025A6 RID: 9638
			public ProceduralTile procTile;
		}
	}
}
