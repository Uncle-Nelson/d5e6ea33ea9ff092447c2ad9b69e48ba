using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x02000791 RID: 1937
	public class BuildUpdate_StoredItem : BuildUpdate_Base
	{
		// Token: 0x060034C2 RID: 13506 RVA: 0x000DD528 File Offset: 0x000DB728
		protected virtual void Update()
		{
			this.CheckRotation();
			if (!GameInput.GetButton(GameInput.ButtonCode.PrimaryClick))
			{
				this.mouseUpSinceStart = true;
				this.mouseUpSincePlace = true;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick) && this.validPosition && this.mouseUpSinceStart)
			{
				this.Place();
			}
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x000DD564 File Offset: 0x000DB764
		protected virtual void LateUpdate()
		{
			this.validPosition = false;
			this.ghostModel.transform.up = Vector3.up;
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(this.detectionRange, out raycastHit, this.detectionMask, false, 0f))
			{
				this.ghostModel.transform.position = raycastHit.point - this.ghostModel.transform.InverseTransformPoint(this.storedItemClass.buildPoint.transform.position);
			}
			else
			{
				this.ghostModel.transform.position = PlayerSingleton<PlayerCamera>.Instance.transform.position + PlayerSingleton<PlayerCamera>.Instance.transform.forward * this.storedItemHoldDistance;
			}
			this.ApplyRotation();
			this.storedItemClass.CalculateFootprintTileIntersections();
			this.CheckGridIntersections();
			if (this.validPosition)
			{
				this.positionDuringLastValidPosition = this.ghostModel.transform.position;
			}
			else if (this.mouseUpSincePlace)
			{
				Vector3 position = this.ghostModel.transform.position;
				float d = 0.0625f;
				this.ghostModel.transform.position = position + this.ghostModel.transform.right * d;
				this.storedItemClass.CalculateFootprintTileIntersections();
				this.CheckGridIntersections();
				if (!this.validPosition)
				{
					this.ghostModel.transform.position = position - this.ghostModel.transform.right * d;
					this.storedItemClass.CalculateFootprintTileIntersections();
					this.CheckGridIntersections();
					if (!this.validPosition)
					{
						this.ghostModel.transform.position = position + this.ghostModel.transform.forward * d;
						this.storedItemClass.CalculateFootprintTileIntersections();
						this.CheckGridIntersections();
						if (!this.validPosition)
						{
							this.ghostModel.transform.position = position - this.ghostModel.transform.forward * d;
							this.storedItemClass.CalculateFootprintTileIntersections();
							this.CheckGridIntersections();
							if (!this.validPosition)
							{
								this.ghostModel.transform.position = position;
								this.storedItemClass.CalculateFootprintTileIntersections();
								this.CheckGridIntersections();
							}
						}
					}
				}
			}
			this.UpdateMaterials();
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x000DD7CC File Offset: 0x000DB9CC
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

		// Token: 0x060034C5 RID: 13509 RVA: 0x000DD804 File Offset: 0x000DBA04
		protected void ApplyRotation()
		{
			this.ghostModel.transform.rotation = Quaternion.Inverse(this.storedItemClass.buildPoint.transform.rotation) * this.ghostModel.transform.rotation;
			this.ghostModel.transform.Rotate(this.storedItemClass.buildPoint.up, this.currentRotation);
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x000DD878 File Offset: 0x000DBA78
		protected virtual void CheckGridIntersections()
		{
			List<BuildUpdate_StoredItem.StorageTileIntersection> list = new List<BuildUpdate_StoredItem.StorageTileIntersection>();
			for (int i = 0; i < this.storedItemClass.CoordinateFootprintTilePairs.Count; i++)
			{
				for (int j = 0; j < this.storedItemClass.CoordinateFootprintTilePairs[i].tile.tileDetector.intersectedStorageTiles.Count; j++)
				{
					list.Add(new BuildUpdate_StoredItem.StorageTileIntersection
					{
						footprintTile = this.storedItemClass.CoordinateFootprintTilePairs[i].tile,
						storageTile = this.storedItemClass.CoordinateFootprintTilePairs[i].tile.tileDetector.intersectedStorageTiles[j]
					});
				}
			}
			if (list.Count == 0)
			{
				this.storedItemClass.SetFootprintTileVisiblity(false);
				this.bestIntersection = null;
				return;
			}
			this.storedItemClass.SetFootprintTileVisiblity(true);
			float num = 100f;
			this.bestIntersection = null;
			for (int k = 0; k < list.Count; k++)
			{
				if (this.bestIntersection == null || Vector3.Distance(list[k].footprintTile.transform.position, list[k].storageTile.transform.position) < num)
				{
					num = Vector3.Distance(list[k].footprintTile.transform.position, list[k].storageTile.transform.position);
					this.bestIntersection = list[k];
				}
			}
			if (this.bestIntersection != null && this.bestIntersection.storageTile.GetComponentInParent<Pallet>())
			{
				Vector3 vector = this.bestIntersection.storageTile.transform.forward;
				if (Vector3.Angle(base.transform.forward, -this.bestIntersection.storageTile.transform.forward) < Vector3.Angle(base.transform.forward, vector))
				{
					vector = -this.bestIntersection.storageTile.transform.forward;
				}
				if (Vector3.Angle(base.transform.forward, this.bestIntersection.storageTile.transform.right) < Vector3.Angle(base.transform.forward, vector))
				{
					vector = this.bestIntersection.storageTile.transform.right;
				}
				if (Vector3.Angle(base.transform.forward, -this.bestIntersection.storageTile.transform.right) < Vector3.Angle(base.transform.forward, vector))
				{
					vector = -this.bestIntersection.storageTile.transform.right;
				}
				this.ghostModel.transform.rotation = Quaternion.LookRotation(vector, Vector3.up);
				this.ghostModel.transform.Rotate(this.storedItemClass.buildPoint.up, this.currentRotation);
			}
			this.ghostModel.transform.position = this.bestIntersection.storageTile.transform.position - (this.bestIntersection.footprintTile.transform.position - this.ghostModel.transform.position);
			this.validPosition = this.bestIntersection.storageTile.ownerGrid.IsItemPositionValid(this.bestIntersection.storageTile, this.bestIntersection.footprintTile, this.storedItemClass);
			for (int l = 0; l < this.storedItemClass.CoordinateFootprintTilePairs.Count; l++)
			{
				Coordinate matchedCoordinate = this.bestIntersection.storageTile.ownerGrid.GetMatchedCoordinate(this.storedItemClass.CoordinateFootprintTilePairs[l].tile);
				CoordinateStorageFootprintTilePair coordinateStorageFootprintTilePair = this.storedItemClass.CoordinateFootprintTilePairs[l];
				if (this.bestIntersection.storageTile.ownerGrid.IsGridPositionValid(matchedCoordinate, this.storedItemClass.CoordinateFootprintTilePairs[l].tile))
				{
					this.storedItemClass.CoordinateFootprintTilePairs[l].tile.tileAppearance.SetColor(ETileColor.White);
				}
				else
				{
					this.storedItemClass.CoordinateFootprintTilePairs[l].tile.tileAppearance.SetColor(ETileColor.Red);
				}
			}
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x000DDCF4 File Offset: 0x000DBEF4
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
				Singleton<BuildManager>.Instance.ApplyMaterial(this.ghostModel, material, true);
			}
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x000DDD48 File Offset: 0x000DBF48
		protected virtual void Place()
		{
			float rotation = Vector3.SignedAngle(this.bestIntersection.storageTile.ownerGrid.transform.forward, this.storedItemClass.buildPoint.forward, this.bestIntersection.storageTile.ownerGrid.transform.up);
			StorableItemInstance item = this.itemInstance.GetCopy(1) as StorableItemInstance;
			Singleton<BuildManager>.Instance.CreateStoredItem(item, this.bestIntersection.storageTile.ownerGrid.GetComponentInParent<IStorageEntity>(), this.bestIntersection.storageTile.ownerGrid, this.GetOriginCoordinate(), rotation);
			this.mouseUpSincePlace = false;
			this.PostPlace();
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x000DDDF5 File Offset: 0x000DBFF5
		protected virtual void PostPlace()
		{
			PlayerSingleton<PlayerInventory>.Instance.equippedSlot.ChangeQuantity(-1, false);
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x000DDE08 File Offset: 0x000DC008
		protected Vector2 GetOriginCoordinate()
		{
			this.storedItemClass.OriginFootprint.tileDetector.CheckIntersections(true);
			return new Vector2((float)this.storedItemClass.OriginFootprint.tileDetector.intersectedStorageTiles[0].x, (float)this.storedItemClass.OriginFootprint.tileDetector.intersectedStorageTiles[0].y);
		}

		// Token: 0x040025A7 RID: 9639
		public StorableItemInstance itemInstance;

		// Token: 0x040025A8 RID: 9640
		public GameObject ghostModel;

		// Token: 0x040025A9 RID: 9641
		public StoredItem storedItemClass;

		// Token: 0x040025AA RID: 9642
		protected BuildUpdate_StoredItem.StorageTileIntersection bestIntersection;

		// Token: 0x040025AB RID: 9643
		[Header("Settings")]
		public float detectionRange = 6f;

		// Token: 0x040025AC RID: 9644
		public LayerMask detectionMask;

		// Token: 0x040025AD RID: 9645
		public float storedItemHoldDistance = 2f;

		// Token: 0x040025AE RID: 9646
		public float currentRotation;

		// Token: 0x040025AF RID: 9647
		protected bool validPosition;

		// Token: 0x040025B0 RID: 9648
		protected Material currentGhostMaterial;

		// Token: 0x040025B1 RID: 9649
		protected bool mouseUpSinceStart;

		// Token: 0x040025B2 RID: 9650
		protected bool mouseUpSincePlace = true;

		// Token: 0x040025B3 RID: 9651
		private Vector3 positionDuringLastValidPosition = Vector3.zero;

		// Token: 0x02000792 RID: 1938
		public class StorageTileIntersection
		{
			// Token: 0x040025B4 RID: 9652
			public FootprintTile footprintTile;

			// Token: 0x040025B5 RID: 9653
			public StorageTile storageTile;
		}
	}
}
