using System;
using System.Collections.Generic;
using ScheduleOne.Building;
using ScheduleOne.EntityFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000B9E RID: 2974
	public class FloorRack : GridItem, IProceduralTileContainer
	{
		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06004FB5 RID: 20405 RVA: 0x0014FF90 File Offset: 0x0014E190
		public List<ProceduralTile> ProceduralTiles
		{
			get
			{
				return this.procTiles;
			}
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x0014FF98 File Offset: 0x0014E198
		public virtual void UpdateLegVisibility()
		{
			this.CockAndBalls(this.leg_BottomLeft.gameObject, this.obs_BottomLeft, -1, -1);
			this.CockAndBalls(this.leg_BottomRight.gameObject, this.obs_BottomRight, 1, -1);
			this.CockAndBalls(this.leg_TopLeft.gameObject, this.obs_TopLeft, -1, 1);
			this.CockAndBalls(this.leg_TopRight.gameObject, this.obs_TopRight, 1, 1);
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x0015000C File Offset: 0x0014E20C
		protected void CockAndBalls(GameObject leg, CornerObstacle obs, int xOffset, int yOffset)
		{
			FloorRack x = null;
			FloorRack x2 = null;
			FloorRack x3 = null;
			Coordinate coord = new Coordinate(this.CoordinatePairs[0].coord2.x + xOffset, this.CoordinatePairs[0].coord2.y + yOffset);
			if (base.OwnerGrid.GetTile(coord) != null && this.GetFloorRackFromOccupants(base.OwnerGrid.GetTile(coord).BuildableOccupants) != null)
			{
				x = this.GetFloorRackFromOccupants(base.OwnerGrid.GetTile(coord).BuildableOccupants);
			}
			Coordinate coord2 = new Coordinate(this.CoordinatePairs[0].coord2.x + xOffset, this.CoordinatePairs[0].coord2.y);
			if (base.OwnerGrid.GetTile(coord2) != null && this.GetFloorRackFromOccupants(base.OwnerGrid.GetTile(coord2).BuildableOccupants) != null)
			{
				x2 = this.GetFloorRackFromOccupants(base.OwnerGrid.GetTile(coord2).BuildableOccupants);
			}
			Coordinate coord3 = new Coordinate(this.CoordinatePairs[0].coord2.x, this.CoordinatePairs[0].coord2.y + yOffset);
			if (base.OwnerGrid.GetTile(coord3) != null && this.GetFloorRackFromOccupants(base.OwnerGrid.GetTile(coord3).BuildableOccupants) != null)
			{
				x3 = this.GetFloorRackFromOccupants(base.OwnerGrid.GetTile(coord3).BuildableOccupants);
			}
			bool flag = true;
			if ((!(x2 != null) || !(x3 != null) || !(x != null)) && x == null && (!(x2 != null) || !(x3 == null)) && x2 == null)
			{
				x3 != null;
			}
			leg.gameObject.SetActive(flag);
			obs.obstacleEnabled = flag;
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x00150208 File Offset: 0x0014E408
		private FloorRack GetFloorRackFromOccupants(List<GridItem> occs)
		{
			for (int i = 0; i < occs.Count; i++)
			{
				if (occs[i] is FloorRack)
				{
					return occs[i] as FloorRack;
				}
			}
			return null;
		}

		// Token: 0x06004FB9 RID: 20409 RVA: 0x00150244 File Offset: 0x0014E444
		public List<FloorRack> GetSurroundingRacks()
		{
			List<FloorRack> list = new List<FloorRack>();
			for (int i = -1; i < 2; i++)
			{
				for (int j = -1; j < 2; j++)
				{
					if (i != 0 || j != 0)
					{
						Coordinate coord = new Coordinate(this.CoordinatePairs[0].coord2.x + i, this.CoordinatePairs[0].coord2.y + j);
						if (base.OwnerGrid.GetTile(coord) != null && this.GetFloorRackFromOccupants(base.OwnerGrid.GetTile(coord).BuildableOccupants) != null)
						{
							list.Add(this.GetFloorRackFromOccupants(base.OwnerGrid.GetTile(coord).BuildableOccupants));
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06004FBA RID: 20410 RVA: 0x0015030C File Offset: 0x0014E50C
		public override bool CanShareTileWith(List<GridItem> obstacles)
		{
			for (int i = 0; i < obstacles.Count; i++)
			{
				if (obstacles[i] is FloorRack)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004FBB RID: 20411 RVA: 0x0015033C File Offset: 0x0014E53C
		public override bool CanBeDestroyed(out string reason)
		{
			bool flag = false;
			foreach (ProceduralTile proceduralTile in this.procTiles)
			{
				if (proceduralTile.Occupants.Count > 0 || proceduralTile.OccupantTiles.Count > 0)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				reason = base.ItemInstance.Name + " is supporting another item";
				return false;
			}
			return base.CanBeDestroyed(out reason);
		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x001503D0 File Offset: 0x0014E5D0
		public override void DestroyItem(bool callOnServer = true)
		{
			for (int i = 0; i < this.CoordinatePairs.Count; i++)
			{
				base.OwnerGrid.GetTile(this.CoordinatePairs[i].coord2).RemoveOccupant(this, base.GetFootprintTile(this.CoordinatePairs[i].coord1));
			}
			base.DestroyItem(callOnServer);
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x00150433 File Offset: 0x0014E633
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06004FBF RID: 20415 RVA: 0x0015044C File Offset: 0x0014E64C
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x00150465 File Offset: 0x0014E665
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x00150473 File Offset: 0x0014E673
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04003C1A RID: 15386
		[Header("References")]
		public Transform leg_BottomLeft;

		// Token: 0x04003C1B RID: 15387
		public Transform leg_BottomRight;

		// Token: 0x04003C1C RID: 15388
		public Transform leg_TopLeft;

		// Token: 0x04003C1D RID: 15389
		public Transform leg_TopRight;

		// Token: 0x04003C1E RID: 15390
		public CornerObstacle obs_BottomLeft;

		// Token: 0x04003C1F RID: 15391
		public CornerObstacle obs_BottomRight;

		// Token: 0x04003C20 RID: 15392
		public CornerObstacle obs_TopLeft;

		// Token: 0x04003C21 RID: 15393
		public CornerObstacle obs_TopRight;

		// Token: 0x04003C22 RID: 15394
		public List<ProceduralTile> procTiles;

		// Token: 0x04003C23 RID: 15395
		private bool dll_Excuted;

		// Token: 0x04003C24 RID: 15396
		private bool dll_Excuted;
	}
}
