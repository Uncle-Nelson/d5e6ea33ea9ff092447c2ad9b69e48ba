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
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x02000632 RID: 1586
	public class ProceduralGridItem : BuildableItem
	{
		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060029DA RID: 10714 RVA: 0x000ACBD7 File Offset: 0x000AADD7
		public int FootprintXSize
		{
			get
			{
				return (from c in this.CoordinateFootprintTilePairs
				orderby c.coord.x descending
				select c).FirstOrDefault<CoordinateFootprintTilePair>().coord.x + 1;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x000ACC14 File Offset: 0x000AAE14
		public int FootprintYSize
		{
			get
			{
				return (from c in this.CoordinateFootprintTilePairs
				orderby c.coord.y descending
				select c).FirstOrDefault<CoordinateFootprintTilePair>().coord.y + 1;
			}
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x000ACC51 File Offset: 0x000AAE51
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.EntityFramework.ProceduralGridItem_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x000ACC65 File Offset: 0x000AAE65
		public override void OnStartClient()
		{
			base.OnStartClient();
			if (base.Initialized && base.LocallyBuilt)
			{
				base.StartCoroutine(this.<OnStartClient>g__WaitForDataSend|10_0());
			}
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000ACC8C File Offset: 0x000AAE8C
		protected override void SendInitToClient(NetworkConnection conn)
		{
			this.InitializeProceduralGridItem(conn, base.ItemInstance, this.SyncAccessor_Rotation, this.SyncAccessor_footprintTileMatches, base.GUID.ToString());
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x000ACCC6 File Offset: 0x000AAEC6
		[ServerRpc(RequireOwnership = false)]
		public void SendProceduralGridItemData(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			this.RpcWriter___Server_SendProceduralGridItemData_638911643(instance, _rotation, _footprintTileMatches, GUID);
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x000ACCE0 File Offset: 0x000AAEE0
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public virtual void InitializeProceduralGridItem(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_InitializeProceduralGridItem_3164718044(conn, instance, _rotation, _footprintTileMatches, GUID);
				this.RpcLogic___InitializeProceduralGridItem_3164718044(conn, instance, _rotation, _footprintTileMatches, GUID);
			}
			else
			{
				this.RpcWriter___Target_InitializeProceduralGridItem_3164718044(conn, instance, _rotation, _footprintTileMatches, GUID);
			}
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x000ACD48 File Offset: 0x000AAF48
		public virtual void InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			if (_footprintTileMatches.Count == 0)
			{
				Console.LogError(base.gameObject.name + " initialized with zero footprint tile matches!", null);
				return;
			}
			this.SetProceduralGridData(_rotation, _footprintTileMatches);
			NetworkObject tileParent = _footprintTileMatches[0].tileParent;
			if (tileParent == null)
			{
				Console.LogError("Base object is null for " + base.gameObject.name, null);
				return;
			}
			Property property = this.GetProperty(tileParent.transform);
			if (property == null)
			{
				Console.LogError("Failed to find property from base " + tileParent.gameObject.name, null);
				return;
			}
			base.InitializeBuildableItem(instance, GUID, property.PropertyCode);
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x000ACDF4 File Offset: 0x000AAFF4
		protected virtual void SetProceduralGridData(int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches)
		{
			this.sync___set_value_Rotation(_rotation, true);
			this.sync___set_value_footprintTileMatches(_footprintTileMatches, true);
			for (int i = 0; i < this.SyncAccessor_footprintTileMatches.Count; i++)
			{
				_footprintTileMatches[i].tile.AddOccupant(this.GetFootprintTile(this.SyncAccessor_footprintTileMatches[i].coord), this);
			}
			if (base.NetworkObject.IsSpawned)
			{
				base.transform.SetParent(this.SyncAccessor_footprintTileMatches[0].tile.ParentBuildableItem.transform.parent);
				this.RefreshTransform();
				return;
			}
			base.StartCoroutine(this.<SetProceduralGridData>g__Routine|15_0());
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x000ACEA4 File Offset: 0x000AB0A4
		private void RefreshTransform()
		{
			ProceduralTile tile = this.SyncAccessor_footprintTileMatches[0].tile;
			base.transform.forward = tile.transform.forward;
			base.transform.Rotate(tile.transform.up, (float)this.SyncAccessor_Rotation);
			base.transform.position = tile.transform.position - (this.GetFootprintTile(this.SyncAccessor_footprintTileMatches[0].coord).transform.position - base.transform.position);
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x000ACF48 File Offset: 0x000AB148
		private void ClearPositionData()
		{
			for (int i = 0; i < this.SyncAccessor_footprintTileMatches.Count; i++)
			{
				this.SyncAccessor_footprintTileMatches[i].tile.RemoveOccupant(this.GetFootprintTile(this.SyncAccessor_footprintTileMatches[i].coord), this);
			}
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x000ACF9C File Offset: 0x000AB19C
		public override void DestroyItem(bool callOnServer = true)
		{
			this.ClearPositionData();
			base.DestroyItem(callOnServer);
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x000ACFAB File Offset: 0x000AB1AB
		protected override Property GetProperty(Transform searchTransform = null)
		{
			if (searchTransform != null && searchTransform.GetComponent<GridItem>() != null)
			{
				return searchTransform.GetComponent<GridItem>().ParentProperty;
			}
			return base.GetProperty(searchTransform);
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x000ACFD8 File Offset: 0x000AB1D8
		public virtual void CalculateFootprintTileIntersections()
		{
			for (int i = 0; i < this.CoordinateFootprintTilePairs.Count; i++)
			{
				this.CoordinateFootprintTilePairs[i].footprintTile.tileDetector.CheckIntersections(true);
			}
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x000AD018 File Offset: 0x000AB218
		public void SetFootprintTileVisiblity(bool visible)
		{
			for (int i = 0; i < this.CoordinateFootprintTilePairs.Count; i++)
			{
				this.CoordinateFootprintTilePairs[i].footprintTile.tileAppearance.SetVisible(visible);
			}
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x000AD058 File Offset: 0x000AB258
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

		// Token: 0x060029EA RID: 10730 RVA: 0x000AD0A8 File Offset: 0x000AB2A8
		public override string GetSaveString()
		{
			FootprintMatchData[] array = new FootprintMatchData[this.SyncAccessor_footprintTileMatches.Count];
			for (int i = 0; i < this.SyncAccessor_footprintTileMatches.Count; i++)
			{
				string tileOwnerGUID = ((IGUIDRegisterable)this.SyncAccessor_footprintTileMatches[i].tileParent.GetComponent<BuildableItem>()).GUID.ToString();
				int tileIndex = this.SyncAccessor_footprintTileMatches[i].tileIndex;
				Vector2 footprintCoordinate = new Vector2((float)this.SyncAccessor_footprintTileMatches[i].coord.x, (float)this.SyncAccessor_footprintTileMatches[i].coord.y);
				array[i] = new FootprintMatchData(tileOwnerGUID, tileIndex, footprintCoordinate);
			}
			return new ProceduralGridItemData(base.GUID, base.ItemInstance, 50, this.SyncAccessor_Rotation, array).GetJson(true);
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x000AD19E File Offset: 0x000AB39E
		[CompilerGenerated]
		private IEnumerator <OnStartClient>g__WaitForDataSend|10_0()
		{
			yield return new WaitUntil(() => base.NetworkObject.IsSpawned);
			this.SendProceduralGridItemData(base.ItemInstance, this.SyncAccessor_Rotation, this.SyncAccessor_footprintTileMatches, base.GUID.ToString());
			yield break;
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x000AD1AD File Offset: 0x000AB3AD
		[CompilerGenerated]
		private IEnumerator <SetProceduralGridData>g__Routine|15_0()
		{
			yield return new WaitUntil(() => base.NetworkObject.IsSpawned);
			base.transform.SetParent(this.SyncAccessor_footprintTileMatches[0].tile.ParentBuildableItem.transform.parent);
			this.RefreshTransform();
			yield break;
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x000AD1BC File Offset: 0x000AB3BC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___footprintTileMatches = new SyncVar<List<CoordinateProceduralTilePair>>(this, 1U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.footprintTileMatches);
			this.syncVar___Rotation = new SyncVar<int>(this, 0U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.Rotation);
			base.RegisterServerRpc(5U, new ServerRpcDelegate(this.RpcReader___Server_SendProceduralGridItemData_638911643));
			base.RegisterTargetRpc(6U, new ClientRpcDelegate(this.RpcReader___Target_InitializeProceduralGridItem_3164718044));
			base.RegisterObserversRpc(7U, new ClientRpcDelegate(this.RpcReader___Observers_InitializeProceduralGridItem_3164718044));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.EntityFramework.ProceduralGridItem));
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x000AD28D File Offset: 0x000AB48D
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___footprintTileMatches.SetRegistered();
			this.syncVar___Rotation.SetRegistered();
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x000AD2BC File Offset: 0x000AB4BC
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x000AD2CC File Offset: 0x000AB4CC
		private void RpcWriter___Server_SendProceduralGridItemData_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
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
			writer.WriteInt32(_rotation, AutoPackType.Packed);
			writer.Write___System.Collections.Generic.List`1<ScheduleOne.Tiles.CoordinateProceduralTilePair>FishNet.Serializing.Generated(_footprintTileMatches);
			writer.WriteString(GUID);
			base.SendServerRpc(5U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x000AD39F File Offset: 0x000AB59F
		public void RpcLogic___SendProceduralGridItemData_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			this.InitializeProceduralGridItem(null, instance, _rotation, _footprintTileMatches, GUID);
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x000AD3B0 File Offset: 0x000AB5B0
		private void RpcReader___Server_SendProceduralGridItemData_638911643(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			ItemInstance instance = PooledReader0.ReadItemInstance();
			int rotation = PooledReader0.ReadInt32(AutoPackType.Packed);
			List<CoordinateProceduralTilePair> list = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.Tiles.CoordinateProceduralTilePair>FishNet.Serializing.Generateds(PooledReader0);
			string guid = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendProceduralGridItemData_638911643(instance, rotation, list, guid);
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x000AD41C File Offset: 0x000AB61C
		private void RpcWriter___Target_InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
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
			writer.WriteInt32(_rotation, AutoPackType.Packed);
			writer.Write___System.Collections.Generic.List`1<ScheduleOne.Tiles.CoordinateProceduralTilePair>FishNet.Serializing.Generated(_footprintTileMatches);
			writer.WriteString(GUID);
			base.SendTargetRpc(6U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000AD4FD File Offset: 0x000AB6FD
		public virtual void RpcLogic___InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			this.InitializeProceduralGridItem(instance, _rotation, _footprintTileMatches, GUID);
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x000AD50C File Offset: 0x000AB70C
		private void RpcReader___Target_InitializeProceduralGridItem_3164718044(PooledReader PooledReader0, Channel channel)
		{
			ItemInstance instance = PooledReader0.ReadItemInstance();
			int rotation = PooledReader0.ReadInt32(AutoPackType.Packed);
			List<CoordinateProceduralTilePair> list = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.Tiles.CoordinateProceduralTilePair>FishNet.Serializing.Generateds(PooledReader0);
			string guid = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___InitializeProceduralGridItem_3164718044(base.LocalConnection, instance, rotation, list, guid);
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x000AD57C File Offset: 0x000AB77C
		private void RpcWriter___Observers_InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
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
			writer.WriteInt32(_rotation, AutoPackType.Packed);
			writer.Write___System.Collections.Generic.List`1<ScheduleOne.Tiles.CoordinateProceduralTilePair>FishNet.Serializing.Generated(_footprintTileMatches);
			writer.WriteString(GUID);
			base.SendObserversRpc(7U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x000AD660 File Offset: 0x000AB860
		private void RpcReader___Observers_InitializeProceduralGridItem_3164718044(PooledReader PooledReader0, Channel channel)
		{
			ItemInstance instance = PooledReader0.ReadItemInstance();
			int rotation = PooledReader0.ReadInt32(AutoPackType.Packed);
			List<CoordinateProceduralTilePair> list = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.Tiles.CoordinateProceduralTilePair>FishNet.Serializing.Generateds(PooledReader0);
			string guid = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___InitializeProceduralGridItem_3164718044(null, instance, rotation, list, guid);
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x000AD6D4 File Offset: 0x000AB8D4
		// (set) Token: 0x060029FC RID: 10748 RVA: 0x000AD6DC File Offset: 0x000AB8DC
		public int SyncAccessor_Rotation
		{
			get
			{
				return this.Rotation;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.Rotation = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___Rotation.SetValue(value, value);
				}
			}
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x000AD718 File Offset: 0x000AB918
		public virtual bool ProceduralGridItem(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 1U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_footprintTileMatches(this.syncVar___footprintTileMatches.GetValue(true), true);
					return true;
				}
				List<CoordinateProceduralTilePair> value = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.Tiles.CoordinateProceduralTilePair>FishNet.Serializing.Generateds(PooledReader0);
				this.sync___set_value_footprintTileMatches(value, Boolean2);
				return true;
			}
			else
			{
				if (UInt321 != 0U)
				{
					return false;
				}
				if (PooledReader0 == null)
				{
					this.sync___set_value_Rotation(this.syncVar___Rotation.GetValue(true), true);
					return true;
				}
				int value2 = PooledReader0.ReadInt32(AutoPackType.Packed);
				this.sync___set_value_Rotation(value2, Boolean2);
				return true;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x000AD7B3 File Offset: 0x000AB9B3
		// (set) Token: 0x060029FF RID: 10751 RVA: 0x000AD7BB File Offset: 0x000AB9BB
		public List<CoordinateProceduralTilePair> SyncAccessor_footprintTileMatches
		{
			get
			{
				return this.footprintTileMatches;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.footprintTileMatches = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___footprintTileMatches.SetValue(value, value);
				}
			}
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x000AD7F7 File Offset: 0x000AB9F7
		protected virtual void dll()
		{
			base.Awake();
			this.SetFootprintTileVisiblity(false);
		}

		// Token: 0x04001EAE RID: 7854
		[Header("Grid item data")]
		public List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs = new List<CoordinateFootprintTilePair>();

		// Token: 0x04001EAF RID: 7855
		public ProceduralTile.EProceduralTileType ProceduralTileType;

		// Token: 0x04001EB0 RID: 7856
		[SyncVar]
		[HideInInspector]
		public int Rotation;

		// Token: 0x04001EB1 RID: 7857
		[SyncVar]
		[HideInInspector]
		public List<CoordinateProceduralTilePair> footprintTileMatches = new List<CoordinateProceduralTilePair>();

		// Token: 0x04001EB2 RID: 7858
		public SyncVar<int> syncVar___Rotation;

		// Token: 0x04001EB3 RID: 7859
		public SyncVar<List<CoordinateProceduralTilePair>> syncVar___footprintTileMatches;

		// Token: 0x04001EB4 RID: 7860
		private bool dll_Excuted;

		// Token: 0x04001EB5 RID: 7861
		private bool dll_Excuted;

		// Token: 0x02000633 RID: 1587
		public class FootprintTileMatch
		{
			// Token: 0x04001EB6 RID: 7862
			public FootprintTile footprint;

			// Token: 0x04001EB7 RID: 7863
			public ProceduralTile matchedTile;
		}
	}
}
