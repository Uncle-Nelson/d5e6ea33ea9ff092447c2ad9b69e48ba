using System;
using System.Collections.Generic;
using ScheduleOne.Building;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Construction;
using UnityEngine;

namespace ScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x02000733 RID: 1843
	public class ConstructUpdate_OutdoorGrid : ConstructUpdate_Base
	{
		// Token: 0x060031D7 RID: 12759 RVA: 0x000CE2A8 File Offset: 0x000CC4A8
		protected virtual void Start()
		{
			this.listingPrice = Singleton<ConstructionMenu>.Instance.GetListingPrice(this.ConstructableClass.PrefabID);
			if (this.MovedConstructable == null)
			{
				this.currentRotation = Singleton<ConstructionManager>.Instance.currentProperty.DefaultRotation;
			}
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x000CE2E8 File Offset: 0x000CC4E8
		protected override void Update()
		{
			base.Update();
			this.CheckRotation();
			if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick) && this.validPosition && this.AreMetaReqsMet() && !Singleton<ConstructionMenu>.Instance.IsHoveringUI())
			{
				if (base.isMoving)
				{
					this.FinalizeMoveConstructable();
					return;
				}
				this.PlaceNewConstructable();
			}
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x000CE33C File Offset: 0x000CC53C
		protected override void LateUpdate()
		{
			base.LateUpdate();
			this.validPosition = false;
			this.GhostModel.transform.up = Vector3.up;
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.MouseRaycast(500f, out raycastHit, this.detectionMask, true, 0f))
			{
				this.GhostModel.transform.position = raycastHit.point - this.GhostModel.transform.InverseTransformPoint(this.ConstructableClass.buildPoint.transform.position);
			}
			this.ApplyRotation();
			this.ConstructableClass.CalculateFootprintTileIntersections();
			this.CheckTileIntersections();
			this.UpdateMaterials();
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x000CE3E8 File Offset: 0x000CC5E8
		protected void CheckRotation()
		{
			if (GameInput.GetButtonDown(GameInput.ButtonCode.RotateLeft))
			{
				this.currentRotation -= 90f;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.RotateRight))
			{
				this.currentRotation += 90f;
			}
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x000CE420 File Offset: 0x000CC620
		protected void ApplyRotation()
		{
			this.GhostModel.transform.rotation = Quaternion.Inverse(this.ConstructableClass.buildPoint.transform.rotation) * this.GhostModel.transform.rotation;
			this.GhostModel.transform.Rotate(this.ConstructableClass.buildPoint.up, this.currentRotation);
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x000CE494 File Offset: 0x000CC694
		protected virtual void CheckTileIntersections()
		{
			List<ConstructionManager.WorldIntersection> list = new List<ConstructionManager.WorldIntersection>();
			for (int i = 0; i < this.ConstructableClass.CoordinateFootprintTilePairs.Count; i++)
			{
				for (int j = 0; j < this.ConstructableClass.CoordinateFootprintTilePairs[i].footprintTile.tileDetector.intersectedOutdoorTiles.Count; j++)
				{
					list.Add(new ConstructionManager.WorldIntersection
					{
						footprint = this.ConstructableClass.CoordinateFootprintTilePairs[i].footprintTile,
						tile = this.ConstructableClass.CoordinateFootprintTilePairs[i].footprintTile.tileDetector.intersectedOutdoorTiles[j]
					});
				}
			}
			if (list.Count == 0)
			{
				this.ConstructableClass.SetFootprintTileVisiblity(false);
				return;
			}
			this.ConstructableClass.SetFootprintTileVisiblity(true);
			ConstructionManager.WorldIntersection worldIntersection = this.closestIntersection;
			float num = 100f;
			this.closestIntersection = null;
			for (int k = 0; k < list.Count; k++)
			{
				if (Vector3.Distance(list[k].footprint.transform.position, list[k].tile.transform.position) < num)
				{
					num = Vector3.Distance(list[k].footprint.transform.position, list[k].tile.transform.position);
					this.closestIntersection = list[k];
				}
			}
			List<Vector2> list2 = new List<Vector2>();
			this.GhostModel.transform.position = this.closestIntersection.tile.transform.position + (this.GhostModel.transform.position - this.closestIntersection.footprint.transform.position);
			if (base.isMoving)
			{
				Constructable_GridBased movedConstructable = this.MovedConstructable;
			}
			this.validPosition = true;
			for (int l = 0; l < this.ConstructableClass.CoordinateFootprintTilePairs.Count; l++)
			{
				Coordinate matchedCoordinate = this.closestIntersection.tile.OwnerGrid.GetMatchedCoordinate(this.ConstructableClass.CoordinateFootprintTilePairs[l].footprintTile);
				this.ConstructableClass.CoordinateFootprintTilePairs[l].footprintTile.tileAppearance.SetColor(ETileColor.Red);
				if (this.closestIntersection.tile.OwnerGrid.GetTile(matchedCoordinate) == null)
				{
					this.validPosition = false;
				}
				else
				{
					list2.Add(new Vector2((float)matchedCoordinate.x, (float)matchedCoordinate.y));
					if (this.closestIntersection.tile.OwnerGrid.IsTileValidAtCoordinate(matchedCoordinate, this.ConstructableClass.CoordinateFootprintTilePairs[l].footprintTile, this.MovedConstructable))
					{
						this.ConstructableClass.CoordinateFootprintTilePairs[l].footprintTile.tileAppearance.SetColor(ETileColor.White);
					}
					else
					{
						this.validPosition = false;
					}
				}
			}
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x000CE7A8 File Offset: 0x000CC9A8
		protected void UpdateMaterials()
		{
			Material material = Singleton<BuildManager>.Instance.ghostMaterial_White;
			if (!this.validPosition || !this.AreMetaReqsMet())
			{
				material = Singleton<BuildManager>.Instance.ghostMaterial_Red;
			}
			if (this.currentGhostMaterial != material)
			{
				this.currentGhostMaterial = material;
				Singleton<BuildManager>.Instance.ApplyMaterial(this.GhostModel.gameObject, material, true);
			}
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x000CE807 File Offset: 0x000CCA07
		private bool AreMetaReqsMet()
		{
			return base.isMoving || NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance >= this.listingPrice;
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x000CE828 File Offset: 0x000CCA28
		protected virtual Constructable_GridBased PlaceNewConstructable()
		{
			Constructable_GridBased constructable_GridBased = Singleton<ConstructionManager>.Instance.CreateConstructable_GridBased(this.ConstructableClass.PrefabID, this.closestIntersection.tile.OwnerGrid, this.GetOriginCoordinate(), this.currentRotation);
			NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction(this.ConstructableClass.ConstructableName, -this.listingPrice, 1f, string.Empty);
			if (Singleton<ConstructionManager>.Instance.onNewConstructableBuilt != null)
			{
				Singleton<ConstructionManager>.Instance.onNewConstructableBuilt(constructable_GridBased);
			}
			if (!Input.GetKey(KeyCode.LeftShift))
			{
				Singleton<ConstructionMenu>.Instance.ClearSelectedListing();
			}
			return constructable_GridBased;
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x000CE8C0 File Offset: 0x000CCAC0
		protected virtual void FinalizeMoveConstructable()
		{
			this.MovedConstructable.RepositionConstructable(this.closestIntersection.tile.OwnerGrid.GUID, this.GetOriginCoordinate(), this.currentRotation);
			Constructable_GridBased movedConstructable = this.MovedConstructable;
			Singleton<ConstructionManager>.Instance.StopMovingConstructable();
			if (Singleton<ConstructionManager>.Instance.onConstructableMoved != null)
			{
				Singleton<ConstructionManager>.Instance.onConstructableMoved(movedConstructable);
			}
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x000CE928 File Offset: 0x000CCB28
		private Vector2 GetOriginCoordinate()
		{
			this.ConstructableClass.OriginFootprint.tileDetector.CheckIntersections(true);
			return new Vector2((float)this.ConstructableClass.OriginFootprint.tileDetector.intersectedOutdoorTiles[0].x, (float)this.ConstructableClass.OriginFootprint.tileDetector.intersectedOutdoorTiles[0].y);
		}

		// Token: 0x04002372 RID: 9074
		[Header("Settings")]
		public LayerMask detectionMask;

		// Token: 0x04002373 RID: 9075
		public Constructable_GridBased ConstructableClass;

		// Token: 0x04002374 RID: 9076
		public Transform GhostModel;

		// Token: 0x04002375 RID: 9077
		protected bool validPosition;

		// Token: 0x04002376 RID: 9078
		public float currentRotation;

		// Token: 0x04002377 RID: 9079
		protected Material currentGhostMaterial;

		// Token: 0x04002378 RID: 9080
		protected ConstructionManager.WorldIntersection closestIntersection;

		// Token: 0x04002379 RID: 9081
		private float listingPrice;
	}
}
