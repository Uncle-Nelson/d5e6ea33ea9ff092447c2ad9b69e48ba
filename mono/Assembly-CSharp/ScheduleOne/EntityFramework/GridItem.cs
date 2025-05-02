using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x0200062A RID: 1578
	public class GridItem : BuildableItem
	{
		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x0600298A RID: 10634 RVA: 0x000AB927 File Offset: 0x000A9B27
		public FootprintTile OriginFootprint
		{
			get
			{
				return this.CoordinateFootprintTilePairs[0].footprintTile;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600298B RID: 10635 RVA: 0x000AB93A File Offset: 0x000A9B3A
		public int FootprintX
		{
			get
			{
				return (from c in this.CoordinateFootprintTilePairs
				orderby c.coord.x descending
				select c).FirstOrDefault<CoordinateFootprintTilePair>().coord.x + 1;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x0600298C RID: 10636 RVA: 0x000AB977 File Offset: 0x000A9B77
		public int FootprintY
		{
			get
			{
				return (from c in this.CoordinateFootprintTilePairs
				orderby c.coord.y descending
				select c).FirstOrDefault<CoordinateFootprintTilePair>().coord.y + 1;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x0600298D RID: 10637 RVA: 0x000AB9B4 File Offset: 0x000A9BB4
		// (set) Token: 0x0600298E RID: 10638 RVA: 0x000AB9BC File Offset: 0x000A9BBC
		public Grid OwnerGrid { get; protected set; }

		// Token: 0x0600298F RID: 10639 RVA: 0x000AB9C5 File Offset: 0x000A9BC5
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.EntityFramework.GridItem_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x000AB9D9 File Offset: 0x000A9BD9
		public override void OnStartClient()
		{
			base.OnStartClient();
			if (base.Initialized && base.LocallyBuilt)
			{
				base.StartCoroutine(this.<OnStartClient>g__WaitForDataSend|18_0());
			}
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x000ABA00 File Offset: 0x000A9C00
		protected override void SendInitToClient(NetworkConnection conn)
		{
			this.InitializeGridItem(conn, base.ItemInstance, this.OwnerGridGUID.ToString(), this.OriginCoordinate, this.Rotation, base.GUID.ToString());
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x000ABA4B File Offset: 0x000A9C4B
		[ServerRpc(RequireOwnership = false)]
		public void SendGridItemData(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			this.RpcWriter___Server_SendGridItemData_2821640832(instance, gridGUID, originCoordinate, rotation, GUID);
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x000ABA68 File Offset: 0x000A9C68
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public virtual void InitializeGridItem(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_InitializeGridItem_1883577149(conn, instance, gridGUID, originCoordinate, rotation, GUID);
				this.RpcLogic___InitializeGridItem_1883577149(conn, instance, gridGUID, originCoordinate, rotation, GUID);
			}
			else
			{
				this.RpcWriter___Target_InitializeGridItem_1883577149(conn, instance, gridGUID, originCoordinate, rotation, GUID);
			}
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x000ABAD9 File Offset: 0x000A9CD9
		public virtual void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			if (base.Initialized)
			{
				return;
			}
			base.InitializeBuildableItem(instance, GUID, this.GetProperty(grid.transform).PropertyCode);
			this.SetGridData(grid.GUID, originCoordinate, rotation);
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000ABB10 File Offset: 0x000A9D10
		protected void SetGridData(Guid gridGUID, Vector2 originCoordinate, int rotation)
		{
			Grid @object = GUIDManager.GetObject<Grid>(gridGUID);
			if (@object == null)
			{
				Console.LogError("InitializeConstructable_GridBased: grid is null", null);
				this.DestroyItem(true);
				return;
			}
			this.OwnerGridGUID = gridGUID;
			this.OwnerGrid = @object;
			this.OriginCoordinate = originCoordinate;
			this.Rotation = this.ValidateRotation(rotation);
			this.ProcessGridData();
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000ABB68 File Offset: 0x000A9D68
		private int ValidateRotation(int rotation)
		{
			if (float.IsNaN((float)rotation) || float.IsInfinity((float)rotation))
			{
				Console.LogWarning("Invalid rotation value: " + rotation.ToString() + " resetting to 0", null);
				return 0;
			}
			if (rotation != 0 && rotation != 90 && rotation != 180 && rotation != 270)
			{
				Console.LogWarning("Invalid rotation value: " + rotation.ToString() + ". Rounding to nearest 90 degrees", null);
				return Mathf.RoundToInt((float)(rotation / 90)) * 90;
			}
			return rotation;
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000ABBE8 File Offset: 0x000A9DE8
		private void ProcessGridData()
		{
			this.OwnerGrid = GUIDManager.GetObject<Grid>(this.OwnerGridGUID);
			if (this.OwnerGrid == null)
			{
				Console.LogWarning("GridItem OwnerGrid is null", null);
				return;
			}
			base.ParentProperty = this.GetProperty(this.OwnerGrid.transform);
			if (base.NetworkObject.IsSpawned)
			{
				base.transform.SetParent(this.OwnerGrid.Container);
			}
			else
			{
				base.StartCoroutine(this.<ProcessGridData>g__Routine|25_0());
			}
			List<CoordinatePair> list = Coordinate.BuildCoordinateMatches(new Coordinate(this.OriginCoordinate), this.FootprintX, this.FootprintY, (float)this.Rotation);
			for (int i = 0; i < list.Count; i++)
			{
				if (this.OwnerGrid.GetTile(list[i].coord2) == null)
				{
					string str = "ReceiveData: grid does not contain tile at ";
					Coordinate coord = list[i].coord2;
					Console.LogError(str + ((coord != null) ? coord.ToString() : null), null);
					this.DestroyItem(true);
					return;
				}
			}
			this.ClearPositionData();
			this.CoordinatePairs.AddRange(list);
			this.RefreshTransform();
			for (int j = 0; j < this.CoordinatePairs.Count; j++)
			{
				this.OwnerGrid.GetTile(this.CoordinatePairs[j].coord2).AddOccupant(this, this.GetFootprintTile(this.CoordinatePairs[j].coord1));
				this.GetFootprintTile(this.CoordinatePairs[j].coord1).Initialize(this.OwnerGrid.GetTile(this.CoordinatePairs[j].coord2));
			}
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000ABD90 File Offset: 0x000A9F90
		private void RefreshTransform()
		{
			base.transform.rotation = this.OwnerGrid.transform.rotation * (Quaternion.Inverse(this.BuildPoint.transform.rotation) * base.transform.rotation);
			base.transform.Rotate(this.BuildPoint.up, (float)this.Rotation);
			base.transform.position = this.OwnerGrid.GetTile(this.CoordinatePairs[0].coord2).transform.position - (this.OriginFootprint.transform.position - base.transform.position);
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x000ABE58 File Offset: 0x000AA058
		private void ClearPositionData()
		{
			if (this.OwnerGrid != null)
			{
				for (int i = 0; i < this.CoordinatePairs.Count; i++)
				{
					this.OwnerGrid.GetTile(this.CoordinatePairs[i].coord2).RemoveOccupant(this, this.GetFootprintTile(this.CoordinatePairs[i].coord1));
				}
			}
			this.CoordinatePairs.Clear();
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000ABECD File Offset: 0x000AA0CD
		public override void DestroyItem(bool callOnServer = true)
		{
			this.ClearPositionData();
			base.DestroyItem(callOnServer);
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x000ABEDC File Offset: 0x000AA0DC
		public virtual void CalculateFootprintTileIntersections()
		{
			for (int i = 0; i < this.CoordinateFootprintTilePairs.Count; i++)
			{
				this.CoordinateFootprintTilePairs[i].footprintTile.tileDetector.CheckIntersections(true);
			}
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x000ABF1C File Offset: 0x000AA11C
		public void SetFootprintTileVisiblity(bool visible)
		{
			for (int i = 0; i < this.CoordinateFootprintTilePairs.Count; i++)
			{
				this.CoordinateFootprintTilePairs[i].footprintTile.tileAppearance.SetVisible(visible);
			}
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x000ABF5C File Offset: 0x000AA15C
		public FootprintTile GetFootprintTile(Coordinate coord)
		{
			for (int i = 0; i < this.CoordinateFootprintTilePairs.Count; i++)
			{
				if (this.CoordinateFootprintTilePairs[i].coord.Equals(coord))
				{
					return this.CoordinateFootprintTilePairs[i].footprintTile;
				}
			}
			return null;
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x000ABFAC File Offset: 0x000AA1AC
		public Tile GetParentTileAtFootprintCoordinate(Coordinate footprintCoord)
		{
			return this.OwnerGrid.GetTile(this.CoordinatePairs.Find((CoordinatePair x) => x.coord1 == footprintCoord).coord2);
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x000ABFF0 File Offset: 0x000AA1F0
		public virtual bool CanShareTileWith(List<GridItem> obstacles)
		{
			for (int i = 0; i < obstacles.Count; i++)
			{
				if (!(obstacles[i] is FloorRack))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x000AC01F File Offset: 0x000AA21F
		public override string GetSaveString()
		{
			return new GridItemData(base.GUID, base.ItemInstance, 0, this.OwnerGrid, this.OriginCoordinate, this.Rotation).GetJson(true);
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x000AC069 File Offset: 0x000AA269
		[CompilerGenerated]
		private IEnumerator <OnStartClient>g__WaitForDataSend|18_0()
		{
			yield return new WaitUntil(() => base.NetworkObject.IsSpawned);
			this.SendGridItemData(base.ItemInstance, this.OwnerGridGUID.ToString(), this.OriginCoordinate, this.Rotation, base.GUID.ToString());
			yield break;
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x000AC085 File Offset: 0x000AA285
		[CompilerGenerated]
		private IEnumerator <ProcessGridData>g__Routine|25_0()
		{
			yield return new WaitUntil(() => base.NetworkObject.IsSpawned);
			base.transform.SetParent(this.OwnerGrid.Container);
			yield break;
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x000AC094 File Offset: 0x000AA294
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.EntityFramework.GridItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.EntityFramework.GridItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(5U, new ServerRpcDelegate(this.RpcReader___Server_SendGridItemData_2821640832));
			base.RegisterTargetRpc(6U, new ClientRpcDelegate(this.RpcReader___Target_InitializeGridItem_1883577149));
			base.RegisterObserversRpc(7U, new ClientRpcDelegate(this.RpcReader___Observers_InitializeGridItem_1883577149));
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x000AC0FD File Offset: 0x000AA2FD
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.EntityFramework.GridItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.EntityFramework.GridItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x000AC116 File Offset: 0x000AA316
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x000AC124 File Offset: 0x000AA324
		private void RpcWriter___Server_SendGridItemData_2821640832(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteItemInstance(instance);
			writer.WriteString(gridGUID);
			writer.WriteVector2(originCoordinate);
			writer.WriteInt32(rotation, AutoPackType.Packed);
			writer.WriteString(GUID);
			base.SendServerRpc(5U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x000AC204 File Offset: 0x000AA404
		public void RpcLogic___SendGridItemData_2821640832(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			this.InitializeGridItem(null, instance, gridGUID, originCoordinate, rotation, GUID);
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x000AC214 File Offset: 0x000AA414
		private void RpcReader___Server_SendGridItemData_2821640832(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			ItemInstance instance = PooledReader0.ReadItemInstance();
			string gridGUID = PooledReader0.ReadString();
			Vector2 originCoordinate = PooledReader0.ReadVector2();
			int rotation = PooledReader0.ReadInt32(AutoPackType.Packed);
			string guid = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendGridItemData_2821640832(instance, gridGUID, originCoordinate, rotation, guid);
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x000AC290 File Offset: 0x000AA490
		private void RpcWriter___Target_InitializeGridItem_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteItemInstance(instance);
			writer.WriteString(gridGUID);
			writer.WriteVector2(originCoordinate);
			writer.WriteInt32(rotation, AutoPackType.Packed);
			writer.WriteString(GUID);
			base.SendTargetRpc(6U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x000AC37E File Offset: 0x000AA57E
		public virtual void RpcLogic___InitializeGridItem_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			this.InitializeGridItem(instance, GUIDManager.GetObject<Grid>(new Guid(gridGUID)), originCoordinate, rotation, GUID);
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x000AC398 File Offset: 0x000AA598
		private void RpcReader___Target_InitializeGridItem_1883577149(PooledReader PooledReader0, Channel channel)
		{
			ItemInstance instance = PooledReader0.ReadItemInstance();
			string gridGUID = PooledReader0.ReadString();
			Vector2 originCoordinate = PooledReader0.ReadVector2();
			int rotation = PooledReader0.ReadInt32(AutoPackType.Packed);
			string guid = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___InitializeGridItem_1883577149(base.LocalConnection, instance, gridGUID, originCoordinate, rotation, guid);
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x000AC418 File Offset: 0x000AA618
		private void RpcWriter___Observers_InitializeGridItem_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteItemInstance(instance);
			writer.WriteString(gridGUID);
			writer.WriteVector2(originCoordinate);
			writer.WriteInt32(rotation, AutoPackType.Packed);
			writer.WriteString(GUID);
			base.SendObserversRpc(7U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x000AC508 File Offset: 0x000AA708
		private void RpcReader___Observers_InitializeGridItem_1883577149(PooledReader PooledReader0, Channel channel)
		{
			ItemInstance instance = PooledReader0.ReadItemInstance();
			string gridGUID = PooledReader0.ReadString();
			Vector2 originCoordinate = PooledReader0.ReadVector2();
			int rotation = PooledReader0.ReadInt32(AutoPackType.Packed);
			string guid = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___InitializeGridItem_1883577149(null, instance, gridGUID, originCoordinate, rotation, guid);
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x000AC58D File Offset: 0x000AA78D
		protected virtual void dll()
		{
			base.Awake();
			this.BoundingCollider.isTrigger = true;
			this.BoundingCollider.gameObject.layer = LayerMask.NameToLayer("Invisible");
			this.SetFootprintTileVisiblity(false);
		}

		// Token: 0x04001E92 RID: 7826
		[Header("Grid item data")]
		public List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs = new List<CoordinateFootprintTilePair>();

		// Token: 0x04001E93 RID: 7827
		public GridItem.EGridType GridType;

		// Token: 0x04001E95 RID: 7829
		public Guid OwnerGridGUID;

		// Token: 0x04001E96 RID: 7830
		public Vector2 OriginCoordinate;

		// Token: 0x04001E97 RID: 7831
		public int Rotation;

		// Token: 0x04001E98 RID: 7832
		public List<CoordinatePair> CoordinatePairs = new List<CoordinatePair>();

		// Token: 0x04001E99 RID: 7833
		private bool dll_Excuted;

		// Token: 0x04001E9A RID: 7834
		private bool dll_Excuted;

		// Token: 0x0200062B RID: 1579
		public enum EGridType
		{
			// Token: 0x04001E9C RID: 7836
			All,
			// Token: 0x04001E9D RID: 7837
			IndoorOnly,
			// Token: 0x04001E9E RID: 7838
			OutdoorOnly
		}
	}
}
