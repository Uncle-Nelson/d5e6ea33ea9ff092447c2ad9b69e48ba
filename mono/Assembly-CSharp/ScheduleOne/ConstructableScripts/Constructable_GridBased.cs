using System;
using System.Collections;
using System.Collections.Generic;
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
using ScheduleOne.Property.Utilities.Power;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.ConstructableScripts
{
	// Token: 0x02000930 RID: 2352
	public class Constructable_GridBased : Constructable
	{
		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06003FC8 RID: 16328 RVA: 0x0010CF9C File Offset: 0x0010B19C
		public FootprintTile OriginFootprint
		{
			get
			{
				return this.CoordinateFootprintTilePairs[0].footprintTile;
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06003FC9 RID: 16329 RVA: 0x0010CFAF File Offset: 0x0010B1AF
		public int FootprintX
		{
			get
			{
				return this.CoordinateFootprintTilePairs[this.CoordinateFootprintTilePairs.Count - 1].coord.x + 1;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06003FCA RID: 16330 RVA: 0x0010CFD5 File Offset: 0x0010B1D5
		public int FootprintY
		{
			get
			{
				return this.CoordinateFootprintTilePairs[this.CoordinateFootprintTilePairs.Count - 1].coord.y + 1;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06003FCB RID: 16331 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool hasWaterSupply
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06003FCC RID: 16332 RVA: 0x0010CFFB File Offset: 0x0010B1FB
		public PowerNode PowerNode
		{
			get
			{
				return this.powerNode;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06003FCD RID: 16333 RVA: 0x0010D003 File Offset: 0x0010B203
		public bool isPowered
		{
			get
			{
				return this.AlwaysPowered || this.powerNode.isConnectedToPower;
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06003FCE RID: 16334 RVA: 0x0010D01A File Offset: 0x0010B21A
		// (set) Token: 0x06003FCF RID: 16335 RVA: 0x0010D022 File Offset: 0x0010B222
		public Grid OwnerGrid { get; protected set; }

		// Token: 0x06003FD0 RID: 16336 RVA: 0x0010D02C File Offset: 0x0010B22C
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ConstructableScripts.Constructable_GridBased_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x0010D04B File Offset: 0x0010B24B
		public override void OnStartServer()
		{
			base.OnStartServer();
			Console.Log("On start server", null);
			this.GenerateGridGUIDs();
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x0010D064 File Offset: 0x0010B264
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			Console.Log("On spawn server", null);
			if (!connection.IsLocalClient)
			{
				Console.Log("Sending thingys", null);
				this.SetGridGUIDs(connection, this.GetGridGUIDs());
			}
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x0010D098 File Offset: 0x0010B298
		public override void OnStartNetwork()
		{
			base.OnStartNetwork();
			Console.Log("OnStartNetwork", null);
			this.ReceiveData();
		}

		// Token: 0x06003FD4 RID: 16340 RVA: 0x0010D0B1 File Offset: 0x0010B2B1
		public virtual void InitializeConstructable_GridBased(Grid grid, Vector2 originCoordinate, float rotation)
		{
			this.SetData(grid.GUID, originCoordinate, rotation);
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x0010D0C4 File Offset: 0x0010B2C4
		private void ReceiveData()
		{
			if (base.IsStatic)
			{
				return;
			}
			Console.Log("Constructable received data", null);
			this.OwnerGrid = GUIDManager.GetObject<Grid>(this.SyncAccessor_OwnerGridGUID);
			bool flag = false;
			if (base.NetworkObject.IsSpawned)
			{
				this.SetParent(this.OwnerGrid.Container);
				flag = true;
			}
			List<CoordinatePair> list = Coordinate.BuildCoordinateMatches(new Coordinate(this.SyncAccessor_OriginCoordinate), this.FootprintX, this.FootprintY, this.SyncAccessor_Rotation);
			for (int i = 0; i < list.Count; i++)
			{
				if (this.OwnerGrid.GetTile(list[i].coord2) == null)
				{
					string str = "InitializeConstructable_GridBased: grid does not contain tile at ";
					Coordinate coord = list[i].coord2;
					Console.LogError(str + ((coord != null) ? coord.ToString() : null), null);
					this.DestroyConstructable(true);
					return;
				}
			}
			this.ClearPositionData();
			this.coordinatePairs.AddRange(list);
			this.RefreshTransform();
			for (int j = 0; j < this.coordinatePairs.Count; j++)
			{
				this.OwnerGrid.GetTile(this.coordinatePairs[j].coord2).AddOccupant(this, this.GetFootprintTile(this.coordinatePairs[j].coord1));
			}
			if (!flag)
			{
				base.StartCoroutine(this.<ReceiveData>g__Routine|36_0());
			}
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x0010D212 File Offset: 0x0010B412
		private void SetParent(Transform parent)
		{
			base.transform.SetParent(parent);
			this.ContentContainer.SetParent(parent);
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x0010D22C File Offset: 0x0010B42C
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected virtual void SetData(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			this.RpcWriter___Server_SetData_810381718(gridGUID, originCoordinate, rotation);
			this.RpcLogic___SetData_810381718(gridGUID, originCoordinate, rotation);
		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x0010D25D File Offset: 0x0010B45D
		public virtual void RepositionConstructable(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			this.SetData(gridGUID, originCoordinate, rotation);
		}

		// Token: 0x06003FD9 RID: 16345 RVA: 0x0010D268 File Offset: 0x0010B468
		private void RefreshTransform()
		{
			base.transform.rotation = this.OwnerGrid.transform.rotation * (Quaternion.Inverse(this.buildPoint.transform.rotation) * base.transform.rotation);
			base.transform.Rotate(this.buildPoint.up, this.SyncAccessor_Rotation);
			base.transform.position = this.OwnerGrid.GetTile(this.coordinatePairs[0].coord2).transform.position - (this.OriginFootprint.transform.position - base.transform.position);
			this.ContentContainer.transform.position = base.transform.position;
			this.ContentContainer.transform.rotation = base.transform.rotation;
		}

		// Token: 0x06003FDA RID: 16346 RVA: 0x0010D364 File Offset: 0x0010B564
		private void ClearPositionData()
		{
			for (int i = 0; i < this.coordinatePairs.Count; i++)
			{
				this.OwnerGrid.GetTile(this.coordinatePairs[i].coord2).RemoveOccupant(this, this.GetFootprintTile(this.coordinatePairs[i].coord1));
			}
			this.coordinatePairs.Clear();
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x0010D3CC File Offset: 0x0010B5CC
		public override void DestroyConstructable(bool callOnServer = true)
		{
			Grid[] componentsInChildren = base.gameObject.GetComponentsInChildren<Grid>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].DestroyGrid();
			}
			for (int j = 0; j < this.coordinatePairs.Count; j++)
			{
				this.OwnerGrid.GetTile(this.coordinatePairs[j].coord2).RemoveOccupant(this, this.GetFootprintTile(this.coordinatePairs[j].coord1));
			}
			base.DestroyConstructable(callOnServer);
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x0010D454 File Offset: 0x0010B654
		private void GenerateGridGUIDs()
		{
			for (int i = 0; i < this.Grids.Length; i++)
			{
				((IGUIDRegisterable)this.Grids[i]).SetGUID(GUIDManager.GenerateUniqueGUID());
				Console.LogError("Generated GRID GUID: " + this.Grids[i].GUID.ToString(), null);
			}
			Console.Log("Sending GRID GUIDs", null);
			this.SetGridGUIDs(null, this.GetGridGUIDs());
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x0010D4CC File Offset: 0x0010B6CC
		private string[] GetGridGUIDs()
		{
			string[] array = new string[this.Grids.Length];
			for (int i = 0; i < this.Grids.Length; i++)
			{
				array[i] = this.Grids[i].GUID.ToString();
			}
			return array;
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x0010D51C File Offset: 0x0010B71C
		[ObserversRpc]
		[TargetRpc]
		protected void SetGridGUIDs(NetworkConnection target, string[] guids)
		{
			if (target == null)
			{
				this.RpcWriter___Observers_SetGridGUIDs_2890081366(target, guids);
			}
			else
			{
				this.RpcWriter___Target_SetGridGUIDs_2890081366(target, guids);
			}
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x0010D550 File Offset: 0x0010B750
		public override void SetInvisible()
		{
			base.SetInvisible();
			if (this.PowerNode != null)
			{
				for (int i = 0; i < this.PowerNode.connections.Count; i++)
				{
					this.PowerNode.connections[i].SetVisible(false);
				}
			}
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x0010D5A4 File Offset: 0x0010B7A4
		public override void RestoreVisibility()
		{
			base.RestoreVisibility();
			if (this.PowerNode != null)
			{
				for (int i = 0; i < this.PowerNode.connections.Count; i++)
				{
					this.PowerNode.connections[i].SetVisible(true);
				}
			}
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x0010D5F8 File Offset: 0x0010B7F8
		public virtual void SetRoofVisible(bool vis)
		{
			if (this.roofVisible == vis)
			{
				return;
			}
			this.roofVisible = vis;
			if (this.roofVisible)
			{
				using (List<GameObject>.Enumerator enumerator = this.roofObjectsForVisibility.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						GameObject gameObject = enumerator.Current;
						if (this.originalRoofLayers.ContainsKey(gameObject))
						{
							gameObject.layer = this.originalRoofLayers[gameObject];
						}
						else
						{
							gameObject.layer = LayerMask.NameToLayer("Default");
						}
					}
					return;
				}
			}
			foreach (GameObject gameObject2 in this.roofObjectsForVisibility)
			{
				if (gameObject2.gameObject.layer != LayerMask.NameToLayer("Default"))
				{
					if (this.originalRoofLayers.ContainsKey(gameObject2))
					{
						this.originalRoofLayers[gameObject2] = gameObject2.layer;
					}
					else
					{
						this.originalRoofLayers.Add(gameObject2, gameObject2.layer);
					}
				}
				gameObject2.layer = LayerMask.NameToLayer("Invisible");
			}
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x0010D738 File Offset: 0x0010B938
		public void CalculateFootprintTileIntersections()
		{
			for (int i = 0; i < this.CoordinateFootprintTilePairs.Count; i++)
			{
				this.CoordinateFootprintTilePairs[i].footprintTile.tileDetector.CheckIntersections(true);
			}
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x0010D778 File Offset: 0x0010B978
		public void SetFootprintTileVisiblity(bool visible)
		{
			for (int i = 0; i < this.CoordinateFootprintTilePairs.Count; i++)
			{
				this.CoordinateFootprintTilePairs[i].footprintTile.tileAppearance.SetVisible(visible);
			}
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x0010D7B8 File Offset: 0x0010B9B8
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

		// Token: 0x06003FE5 RID: 16357 RVA: 0x0010D808 File Offset: 0x0010BA08
		public List<FootprintTile> GetFootprintTiles()
		{
			List<FootprintTile> list = new List<FootprintTile>();
			for (int i = 0; i < this.CoordinateFootprintTilePairs.Count; i++)
			{
				list.Add(this.CoordinateFootprintTilePairs[i].footprintTile);
			}
			return list;
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x0010D884 File Offset: 0x0010BA84
		[CompilerGenerated]
		private IEnumerator <ReceiveData>g__Routine|36_0()
		{
			yield return new WaitUntil(() => base.NetworkObject.IsSpawned);
			this.SetParent(this.OwnerGrid.Container);
			yield break;
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x0010D894 File Offset: 0x0010BA94
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ConstructableScripts.Constructable_GridBasedAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ConstructableScripts.Constructable_GridBasedAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___Rotation = new SyncVar<float>(this, 2U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.Rotation);
			this.syncVar___OriginCoordinate = new SyncVar<Vector2>(this, 1U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.OriginCoordinate);
			this.syncVar___OwnerGridGUID = new SyncVar<Guid>(this, 0U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.OwnerGridGUID);
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_SetData_810381718));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_SetGridGUIDs_2890081366));
			base.RegisterTargetRpc(4U, new ClientRpcDelegate(this.RpcReader___Target_SetGridGUIDs_2890081366));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.ConstructableScripts.Constructable_GridBased));
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x0010D990 File Offset: 0x0010BB90
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ConstructableScripts.Constructable_GridBasedAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ConstructableScripts.Constructable_GridBasedAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___Rotation.SetRegistered();
			this.syncVar___OriginCoordinate.SetRegistered();
			this.syncVar___OwnerGridGUID.SetRegistered();
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x0010D9CA File Offset: 0x0010BBCA
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x0010D9D8 File Offset: 0x0010BBD8
		private void RpcWriter___Server_SetData_810381718(Guid gridGUID, Vector2 originCoordinate, float rotation)
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
			writer.WriteGuidAllocated(gridGUID);
			writer.WriteVector2(originCoordinate);
			writer.WriteSingle(rotation, AutoPackType.Unpacked);
			base.SendServerRpc(2U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x0010DAA0 File Offset: 0x0010BCA0
		protected virtual void RpcLogic___SetData_810381718(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			Console.Log("SetData", null);
			Grid @object = GUIDManager.GetObject<Grid>(gridGUID);
			if (@object == null)
			{
				Console.LogError("InitializeConstructable_GridBased: grid is null", null);
				this.DestroyConstructable(true);
				return;
			}
			this.sync___set_value_OwnerGridGUID(gridGUID, true);
			this.OwnerGrid = @object;
			this.sync___set_value_OriginCoordinate(originCoordinate, true);
			this.sync___set_value_Rotation(rotation, true);
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x0010DAFC File Offset: 0x0010BCFC
		private void RpcReader___Server_SetData_810381718(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			Guid gridGUID = PooledReader0.ReadGuid();
			Vector2 originCoordinate = PooledReader0.ReadVector2();
			float rotation = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetData_810381718(gridGUID, originCoordinate, rotation);
		}

		// Token: 0x06003FEF RID: 16367 RVA: 0x0010DB64 File Offset: 0x0010BD64
		private void RpcWriter___Observers_SetGridGUIDs_2890081366(NetworkConnection target, string[] guids)
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
			writer.Write___System.String[]FishNet.Serializing.Generated(guids);
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x0010DC1C File Offset: 0x0010BE1C
		protected void RpcLogic___SetGridGUIDs_2890081366(NetworkConnection target, string[] guids)
		{
			Console.Log("Setting GRID GUIDs", null);
			for (int i = 0; i < guids.Length; i++)
			{
				((IGUIDRegisterable)this.Grids[i]).SetGUID(new Guid(guids[i]));
			}
		}

		// Token: 0x06003FF1 RID: 16369 RVA: 0x0010DC58 File Offset: 0x0010BE58
		private void RpcReader___Observers_SetGridGUIDs_2890081366(PooledReader PooledReader0, Channel channel)
		{
			string[] guids = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.String[]FishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetGridGUIDs_2890081366(null, guids);
		}

		// Token: 0x06003FF2 RID: 16370 RVA: 0x0010DC8C File Offset: 0x0010BE8C
		private void RpcWriter___Target_SetGridGUIDs_2890081366(NetworkConnection target, string[] guids)
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
			writer.Write___System.String[]FishNet.Serializing.Generated(guids);
			base.SendTargetRpc(4U, writer, channel, DataOrderType.Default, target, false, true);
			writer.Store();
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x0010DD44 File Offset: 0x0010BF44
		private void RpcReader___Target_SetGridGUIDs_2890081366(PooledReader PooledReader0, Channel channel)
		{
			string[] guids = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.String[]FishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetGridGUIDs_2890081366(base.LocalConnection, guids);
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06003FF4 RID: 16372 RVA: 0x0010DD7B File Offset: 0x0010BF7B
		// (set) Token: 0x06003FF5 RID: 16373 RVA: 0x0010DD83 File Offset: 0x0010BF83
		public Guid SyncAccessor_OwnerGridGUID
		{
			get
			{
				return this.OwnerGridGUID;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.OwnerGridGUID = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___OwnerGridGUID.SetValue(value, value);
				}
			}
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x0010DDC0 File Offset: 0x0010BFC0
		public virtual bool Constructable_GridBased(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 2U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_Rotation(this.syncVar___Rotation.GetValue(true), true);
					return true;
				}
				float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
				this.sync___set_value_Rotation(value, Boolean2);
				return true;
			}
			else if (UInt321 == 1U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_OriginCoordinate(this.syncVar___OriginCoordinate.GetValue(true), true);
					return true;
				}
				Vector2 value2 = PooledReader0.ReadVector2();
				this.sync___set_value_OriginCoordinate(value2, Boolean2);
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
					this.sync___set_value_OwnerGridGUID(this.syncVar___OwnerGridGUID.GetValue(true), true);
					return true;
				}
				Guid value3 = PooledReader0.ReadGuid();
				this.sync___set_value_OwnerGridGUID(value3, Boolean2);
				return true;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06003FF7 RID: 16375 RVA: 0x0010DE9F File Offset: 0x0010C09F
		// (set) Token: 0x06003FF8 RID: 16376 RVA: 0x0010DEA7 File Offset: 0x0010C0A7
		public Vector2 SyncAccessor_OriginCoordinate
		{
			get
			{
				return this.OriginCoordinate;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.OriginCoordinate = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___OriginCoordinate.SetValue(value, value);
				}
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06003FF9 RID: 16377 RVA: 0x0010DEE3 File Offset: 0x0010C0E3
		// (set) Token: 0x06003FFA RID: 16378 RVA: 0x0010DEEB File Offset: 0x0010C0EB
		public float SyncAccessor_Rotation
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

		// Token: 0x06003FFB RID: 16379 RVA: 0x0010DF28 File Offset: 0x0010C128
		protected virtual void dll()
		{
			base.Awake();
			bool isStatic = base.IsStatic;
			if (this.Grids.Length != base.GetComponentsInChildren<Grid>().Length)
			{
				Console.LogWarning(string.Concat(new string[]
				{
					base.gameObject.name,
					": Grids array length does not match number of child grids! (Grids array length: ",
					this.Grids.Length.ToString(),
					", child grids: ",
					base.GetComponentsInChildren<Grid>().Length.ToString(),
					")"
				}), null);
			}
		}

		// Token: 0x04002DDB RID: 11739
		[Header("Grid Based Constructable References")]
		public Transform buildPoint;

		// Token: 0x04002DDC RID: 11740
		public List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs = new List<CoordinateFootprintTilePair>();

		// Token: 0x04002DDD RID: 11741
		public Transform ContentContainer;

		// Token: 0x04002DDE RID: 11742
		public Grid[] Grids;

		// Token: 0x04002DDF RID: 11743
		public List<GameObject> roofObjectsForVisibility = new List<GameObject>();

		// Token: 0x04002DE0 RID: 11744
		[Header("Power")]
		[SerializeField]
		protected bool AlwaysPowered;

		// Token: 0x04002DE1 RID: 11745
		[SerializeField]
		protected PowerNode powerNode;

		// Token: 0x04002DE2 RID: 11746
		[HideInInspector]
		public bool isGhost;

		// Token: 0x04002DE3 RID: 11747
		protected bool dataChangedThisFrame;

		// Token: 0x04002DE5 RID: 11749
		[SyncVar]
		public Guid OwnerGridGUID;

		// Token: 0x04002DE6 RID: 11750
		[SyncVar]
		public Vector2 OriginCoordinate;

		// Token: 0x04002DE7 RID: 11751
		[SyncVar]
		public float Rotation;

		// Token: 0x04002DE8 RID: 11752
		public List<CoordinatePair> coordinatePairs = new List<CoordinatePair>();

		// Token: 0x04002DE9 RID: 11753
		private Dictionary<GameObject, LayerMask> originalRoofLayers = new Dictionary<GameObject, LayerMask>();

		// Token: 0x04002DEA RID: 11754
		protected bool roofVisible = true;

		// Token: 0x04002DEB RID: 11755
		public SyncVar<Guid> syncVar___OwnerGridGUID;

		// Token: 0x04002DEC RID: 11756
		public SyncVar<Vector2> syncVar___OriginCoordinate;

		// Token: 0x04002DED RID: 11757
		public SyncVar<float> syncVar___Rotation;

		// Token: 0x04002DEE RID: 11758
		private bool dll_Excuted;

		// Token: 0x04002DEF RID: 11759
		private bool dll_Excuted;
	}
}
