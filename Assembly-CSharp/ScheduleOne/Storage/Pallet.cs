using System;
using System.Collections.Generic;
using FishNet;
using FishNet.Component.Transforming;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Employees;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tiles;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008A3 RID: 2211
	public class Pallet : NetworkBehaviour, IStorageEntity
	{
		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06003BB3 RID: 15283 RVA: 0x000FAF76 File Offset: 0x000F9176
		public bool isEmpty
		{
			get
			{
				return this._storedItemContainer.childCount == 0;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06003BB4 RID: 15284 RVA: 0x000FAF86 File Offset: 0x000F9186
		protected bool carriedByForklift
		{
			get
			{
				return this.forkliftsInContact.Count > 0;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06003BB5 RID: 15285 RVA: 0x000FAF96 File Offset: 0x000F9196
		public Transform storedItemContainer
		{
			get
			{
				return this._storedItemContainer;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06003BB6 RID: 15286 RVA: 0x000FAF9E File Offset: 0x000F919E
		public Dictionary<StoredItem, Employee> reservedItems
		{
			get
			{
				return this._reservedItems;
			}
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x000FAFA6 File Offset: 0x000F91A6
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Storage.Pallet_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x000FAFBA File Offset: 0x000F91BA
		public override void OnStartServer()
		{
			base.OnStartServer();
			if (this.currentSlot == null)
			{
				this.rb.isKinematic = false;
				this.rb.interpolation = 1;
			}
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x000FAFE8 File Offset: 0x000F91E8
		[ServerRpc(RequireOwnership = false)]
		protected virtual void SetOwner(NetworkConnection conn)
		{
			this.RpcWriter___Server_SetOwner_328543758(conn);
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x000FB000 File Offset: 0x000F9200
		public override void OnOwnershipClient(NetworkConnection prevOwner)
		{
			base.OnOwnershipClient(prevOwner);
			if (base.IsOwner || (base.OwnerId == -1 && InstanceFinder.IsHost))
			{
				if (this.rb != null)
				{
					this.rb.interpolation = 1;
					this.rb.collisionDetectionMode = 1;
					this.rb.isKinematic = false;
				}
				if (!Pallet.palletsOwnedByLocalPlayer.Contains(this))
				{
					Pallet.palletsOwnedByLocalPlayer.Add(this);
					return;
				}
			}
			else
			{
				if (this.rb != null)
				{
					this.rb.interpolation = 0;
					this.rb.isKinematic = true;
				}
				if (Pallet.palletsOwnedByLocalPlayer.Contains(this))
				{
					Pallet.palletsOwnedByLocalPlayer.Remove(this);
				}
			}
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x000FB0B6 File Offset: 0x000F92B6
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			this.SendItemsToClient(connection);
			if (this.currentSlot != null)
			{
				this.BindToSlot(connection, this.currentSlot.GUID);
			}
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x000FB0E8 File Offset: 0x000F92E8
		private void SendItemsToClient(NetworkConnection connection)
		{
			StoredItem[] componentsInChildren = this._storedItemContainer.GetComponentsInChildren<StoredItem>();
			List<StorageGrid> storageGrids = this.GetStorageGrids();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				this.CreateStoredItem(connection, componentsInChildren[i].item, storageGrids.IndexOf(componentsInChildren[i].parentGrid), componentsInChildren[i].CoordinatePairs[0].coord2, componentsInChildren[i].Rotation, "", false);
			}
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x000FB15C File Offset: 0x000F935C
		public virtual void DestroyPallet()
		{
			base.Despawn(null);
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x000FB178 File Offset: 0x000F9378
		protected virtual void Update()
		{
			this.timeSinceSlotCheck += Time.deltaTime;
			if (this.currentSlot == null)
			{
				this.timeBoundToSlot = 0f;
				return;
			}
			this.timeBoundToSlot += Time.deltaTime;
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x000FB1B8 File Offset: 0x000F93B8
		protected virtual void FixedUpdate()
		{
			if (base.IsOwner || (base.OwnerId == -1 && InstanceFinder.IsHost))
			{
				if (this.carriedByForklift)
				{
					if (this.currentSlot != null && this.timeBoundToSlot > 1f)
					{
						Console.Log("Exiting", null);
						this.ExitSlot_Server();
					}
				}
				else if (this.currentSlot == null && this.timeSinceSlotCheck >= 0.5f)
				{
					this.timeSinceSlotCheck = 0f;
					Collider[] array = Physics.OverlapSphere(base.transform.position, 0.3f, 1 << LayerMask.NameToLayer("Pallet"), 2);
					for (int i = 0; i < array.Length; i++)
					{
						PalletSlot componentInParent = array[i].gameObject.GetComponentInParent<PalletSlot>();
						if (componentInParent != null && componentInParent.occupant == null)
						{
							this.BindToSlot_Server(componentInParent.GUID);
							break;
						}
					}
				}
				if (base.transform.position.y < -20f && this.currentSlot == null)
				{
					if (this.rb != null)
					{
						this.rb.velocity = Vector3.zero;
						this.rb.angularVelocity = Vector3.zero;
					}
					float num = 0f;
					if (MapHeightSampler.Sample(base.transform.position.x, out num, base.transform.position.z))
					{
						this.SetPosition(new Vector3(base.transform.position.x, num + 3f, base.transform.position.z));
					}
					else
					{
						this.SetPosition(MapHeightSampler.ResetPosition);
					}
				}
			}
			this.UpdateOwnership();
			this.forkliftsInContact.Clear();
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x000FB387 File Offset: 0x000F9587
		private void SetPosition(Vector3 position)
		{
			base.transform.position = position;
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x000FB398 File Offset: 0x000F9598
		private void UpdateOwnership()
		{
			if (this.forkliftsInContact.Count == 0)
			{
				if (base.IsOwner && !InstanceFinder.IsHost)
				{
					base.NetworkObject.SetLocalOwnership(null);
					this.SetOwner(null);
					return;
				}
			}
			else
			{
				NetworkConnection owner = this.forkliftsInContact[0].Owner;
				if (base.Owner != owner && owner == Player.Local.Connection)
				{
					base.NetworkObject.SetLocalOwnership(Player.Local.Connection);
					this.SetOwner(Player.Local.Connection);
				}
			}
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x000FB42C File Offset: 0x000F962C
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void BindToSlot_Server(Guid slotGuid)
		{
			this.RpcWriter___Server_BindToSlot_Server_1272046255(slotGuid);
			this.RpcLogic___BindToSlot_Server_1272046255(slotGuid);
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x000FB444 File Offset: 0x000F9644
		[ObserversRpc]
		[TargetRpc]
		private void BindToSlot(NetworkConnection conn, Guid slotGuid)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_BindToSlot_454078614(conn, slotGuid);
			}
			else
			{
				this.RpcWriter___Target_BindToSlot_454078614(conn, slotGuid);
			}
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x000FB477 File Offset: 0x000F9677
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ExitSlot_Server()
		{
			this.RpcWriter___Server_ExitSlot_Server_2166136261();
			this.RpcLogic___ExitSlot_Server_2166136261();
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x000FB488 File Offset: 0x000F9688
		[ObserversRpc]
		private void ExitSlot()
		{
			this.RpcWriter___Observers_ExitSlot_2166136261();
		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x000FB49C File Offset: 0x000F969C
		public void TriggerStay(Collider other)
		{
			Forklift forklift = other.gameObject.GetComponentInParent<Forklift>();
			if (forklift == null)
			{
				ForkliftFork componentInParent = other.gameObject.GetComponentInParent<ForkliftFork>();
				if (componentInParent != null)
				{
					forklift = componentInParent.forklift;
				}
			}
			if (other.gameObject.layer == LayerMask.NameToLayer("Ignore Raycast"))
			{
				return;
			}
			if (forklift != null && !this.forkliftsInContact.Contains(forklift))
			{
				this.forkliftsInContact.Add(forklift);
			}
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x000FB515 File Offset: 0x000F9715
		public List<StoredItem> GetStoredItems()
		{
			return new List<StoredItem>(this.storedItemContainer.GetComponentsInChildren<StoredItem>());
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x000FB527 File Offset: 0x000F9727
		public List<StorageGrid> GetStorageGrids()
		{
			return new List<StorageGrid>
			{
				this.storageGrid
			};
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x000FB53C File Offset: 0x000F973C
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void CreateStoredItem(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_CreateStoredItem_913707843(conn, item, gridIndex, originCoord, rotation, jobID, network);
				this.RpcLogic___CreateStoredItem_913707843(conn, item, gridIndex, originCoord, rotation, jobID, network);
			}
			else
			{
				this.RpcWriter___Target_CreateStoredItem_913707843(conn, item, gridIndex, originCoord, rotation, jobID, network);
			}
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x000FB5B9 File Offset: 0x000F97B9
		[ServerRpc(RequireOwnership = false)]
		private void CreateStoredItem_Server(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
			this.RpcWriter___Server_CreateStoredItem_Server_1890711751(data, gridIndex, originCoord, rotation, jobID);
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x000FB5D8 File Offset: 0x000F97D8
		[ObserversRpc(RunLocally = true)]
		public void DestroyStoredItem(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			this.RpcWriter___Observers_DestroyStoredItem_3261517793(gridIndex, coord, jobID, network);
			this.RpcLogic___DestroyStoredItem_3261517793(gridIndex, coord, jobID, network);
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x000FB611 File Offset: 0x000F9811
		[ServerRpc(RequireOwnership = false)]
		private void DestroyStoredItem_Server(int gridIndex, Coordinate coord, string jobID)
		{
			this.RpcWriter___Server_DestroyStoredItem_Server_3952619116(gridIndex, coord, jobID);
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x000FB668 File Offset: 0x000F9868
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Storage.PalletAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Storage.PalletAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SetOwner_328543758));
			base.RegisterServerRpc(1U, new ServerRpcDelegate(this.RpcReader___Server_BindToSlot_Server_1272046255));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_BindToSlot_454078614));
			base.RegisterTargetRpc(3U, new ClientRpcDelegate(this.RpcReader___Target_BindToSlot_454078614));
			base.RegisterServerRpc(4U, new ServerRpcDelegate(this.RpcReader___Server_ExitSlot_Server_2166136261));
			base.RegisterObserversRpc(5U, new ClientRpcDelegate(this.RpcReader___Observers_ExitSlot_2166136261));
			base.RegisterObserversRpc(6U, new ClientRpcDelegate(this.RpcReader___Observers_CreateStoredItem_913707843));
			base.RegisterTargetRpc(7U, new ClientRpcDelegate(this.RpcReader___Target_CreateStoredItem_913707843));
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_CreateStoredItem_Server_1890711751));
			base.RegisterObserversRpc(9U, new ClientRpcDelegate(this.RpcReader___Observers_DestroyStoredItem_3261517793));
			base.RegisterServerRpc(10U, new ServerRpcDelegate(this.RpcReader___Server_DestroyStoredItem_Server_3952619116));
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x000FB783 File Offset: 0x000F9983
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Storage.PalletAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Storage.PalletAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x000FB796 File Offset: 0x000F9996
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x000FB7A4 File Offset: 0x000F99A4
		private void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn)
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
			writer.WriteNetworkConnection(conn);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x000FB84C File Offset: 0x000F9A4C
		protected virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn)
		{
			Console.Log("Setting pallet owner to: " + conn.ClientId.ToString(), null);
			if (base.Owner != null && Player.GetPlayer(base.Owner) != null)
			{
				Player.GetPlayer(base.Owner).objectsTemporarilyOwnedByPlayer.Remove(base.NetworkObject);
			}
			if (conn != null && Player.GetPlayer(conn) != null)
			{
				Player.GetPlayer(conn).objectsTemporarilyOwnedByPlayer.Add(base.NetworkObject);
			}
			base.NetworkObject.GiveOwnership(conn);
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x000FB8EC File Offset: 0x000F9AEC
		private void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkConnection conn2 = PooledReader0.ReadNetworkConnection();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SetOwner_328543758(conn2);
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x000FB920 File Offset: 0x000F9B20
		private void RpcWriter___Server_BindToSlot_Server_1272046255(Guid slotGuid)
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
			writer.WriteGuidAllocated(slotGuid);
			base.SendServerRpc(1U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x000FB9C7 File Offset: 0x000F9BC7
		public void RpcLogic___BindToSlot_Server_1272046255(Guid slotGuid)
		{
			this.BindToSlot(null, slotGuid);
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x000FB9D4 File Offset: 0x000F9BD4
		private void RpcReader___Server_BindToSlot_Server_1272046255(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			Guid slotGuid = PooledReader0.ReadGuid();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___BindToSlot_Server_1272046255(slotGuid);
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x000FBA14 File Offset: 0x000F9C14
		private void RpcWriter___Observers_BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
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
			writer.WriteGuidAllocated(slotGuid);
			base.SendObserversRpc(2U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x000FBACC File Offset: 0x000F9CCC
		private void RpcLogic___BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
		{
			this.currentSlotGUID = slotGuid;
			this.currentSlot = GUIDManager.GetObject<PalletSlot>(slotGuid);
			if (this.currentSlot == null)
			{
				this.currentSlotGUID = Guid.Empty;
				Console.LogWarning("BindToSlot called but slotGuid is not valid", null);
				return;
			}
			this.currentSlot.SetOccupant(this);
			this.networkTransform.enabled = false;
			Object.Destroy(this.rb);
			base.transform.SetParent(this.currentSlot.transform);
			base.transform.position = this.currentSlot.transform.position + this.currentSlot.transform.up * 0.1f;
			Vector3 vector = this.currentSlot.transform.forward;
			if (Vector3.Angle(base.transform.forward, -this.currentSlot.transform.forward) < Vector3.Angle(base.transform.forward, vector))
			{
				vector = -this.currentSlot.transform.forward;
			}
			if (Vector3.Angle(base.transform.forward, this.currentSlot.transform.right) < Vector3.Angle(base.transform.forward, vector))
			{
				vector = this.currentSlot.transform.right;
			}
			if (Vector3.Angle(base.transform.forward, -this.currentSlot.transform.right) < Vector3.Angle(base.transform.forward, vector))
			{
				vector = -this.currentSlot.transform.right;
			}
			base.transform.rotation = Quaternion.LookRotation(vector, Vector3.up);
			base.transform.localEulerAngles = new Vector3(0f, base.transform.localEulerAngles.y, 0f);
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x000FBCB8 File Offset: 0x000F9EB8
		private void RpcReader___Observers_BindToSlot_454078614(PooledReader PooledReader0, Channel channel)
		{
			Guid slotGuid = PooledReader0.ReadGuid();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___BindToSlot_454078614(null, slotGuid);
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x000FBCEC File Offset: 0x000F9EEC
		private void RpcWriter___Target_BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
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
			writer.WriteGuidAllocated(slotGuid);
			base.SendTargetRpc(3U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x000FBDA4 File Offset: 0x000F9FA4
		private void RpcReader___Target_BindToSlot_454078614(PooledReader PooledReader0, Channel channel)
		{
			Guid slotGuid = PooledReader0.ReadGuid();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___BindToSlot_454078614(base.LocalConnection, slotGuid);
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x000FBDDC File Offset: 0x000F9FDC
		private void RpcWriter___Server_ExitSlot_Server_2166136261()
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
			base.SendServerRpc(4U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x000FBE76 File Offset: 0x000FA076
		public void RpcLogic___ExitSlot_Server_2166136261()
		{
			this.ExitSlot();
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x000FBE80 File Offset: 0x000FA080
		private void RpcReader___Server_ExitSlot_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___ExitSlot_Server_2166136261();
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x000FBEB0 File Offset: 0x000FA0B0
		private void RpcWriter___Observers_ExitSlot_2166136261()
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
			base.SendObserversRpc(5U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x000FBF5C File Offset: 0x000FA15C
		private void RpcLogic___ExitSlot_2166136261()
		{
			if (this.currentSlot == null)
			{
				return;
			}
			this.currentSlot.SetOccupant(null);
			base.transform.SetParent(null);
			if (this.rb == null)
			{
				this.rb = base.gameObject.AddComponent<Rigidbody>();
			}
			this.rb.mass = this.rb_Mass;
			this.rb.drag = this.rb_Drag;
			this.rb.angularDrag = this.rb_AngularDrag;
			this.rb.interpolation = 1;
			if (base.IsOwner || (base.OwnerId == -1 && InstanceFinder.IsHost))
			{
				Console.Log("Exit slot, owner", null);
				this.rb.isKinematic = false;
				this.rb.collisionDetectionMode = 1;
			}
			else
			{
				Console.Log("Exit slot, not owner", null);
				this.rb.isKinematic = true;
				this.rb.interpolation = 0;
			}
			this.networkTransform.enabled = true;
			this.currentSlotGUID = default(Guid);
			this.currentSlot = null;
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x000FC070 File Offset: 0x000FA270
		private void RpcReader___Observers_ExitSlot_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ExitSlot_2166136261();
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x000FC090 File Offset: 0x000FA290
		private void RpcWriter___Observers_CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
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
			writer.WriteStorableItemInstance(item);
			writer.WriteInt32(gridIndex, AutoPackType.Packed);
			writer.WriteVector2(originCoord);
			writer.WriteSingle(rotation, AutoPackType.Unpacked);
			writer.WriteString(jobID);
			writer.WriteBoolean(network);
			base.SendObserversRpc(6U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x000FC194 File Offset: 0x000FA394
		public void RpcLogic___CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
			if (jobID != "")
			{
				if (this.completedJobs.Contains(jobID))
				{
					return;
				}
			}
			else
			{
				jobID = Guid.NewGuid().ToString();
			}
			this.completedJobs.Add(jobID);
			Object.Instantiate<StoredItem>(item.StoredItem, this.storedItemContainer).GetComponent<StoredItem>();
			if (network)
			{
				this.CreateStoredItem_Server(item, gridIndex, originCoord, rotation, jobID);
			}
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x000FC20C File Offset: 0x000FA40C
		private void RpcReader___Observers_CreateStoredItem_913707843(PooledReader PooledReader0, Channel channel)
		{
			StorableItemInstance item = PooledReader0.ReadStorableItemInstance();
			int gridIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			Vector2 originCoord = PooledReader0.ReadVector2();
			float rotation = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			string jobID = PooledReader0.ReadString();
			bool network = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___CreateStoredItem_913707843(null, item, gridIndex, originCoord, rotation, jobID, network);
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x000FC2A8 File Offset: 0x000FA4A8
		private void RpcWriter___Target_CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
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
			writer.WriteStorableItemInstance(item);
			writer.WriteInt32(gridIndex, AutoPackType.Packed);
			writer.WriteVector2(originCoord);
			writer.WriteSingle(rotation, AutoPackType.Unpacked);
			writer.WriteString(jobID);
			writer.WriteBoolean(network);
			base.SendTargetRpc(7U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x000FC3A8 File Offset: 0x000FA5A8
		private void RpcReader___Target_CreateStoredItem_913707843(PooledReader PooledReader0, Channel channel)
		{
			StorableItemInstance item = PooledReader0.ReadStorableItemInstance();
			int gridIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			Vector2 originCoord = PooledReader0.ReadVector2();
			float rotation = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			string jobID = PooledReader0.ReadString();
			bool network = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___CreateStoredItem_913707843(base.LocalConnection, item, gridIndex, originCoord, rotation, jobID, network);
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x000FC440 File Offset: 0x000FA640
		private void RpcWriter___Server_CreateStoredItem_Server_1890711751(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
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
			writer.WriteStorableItemInstance(data);
			writer.WriteInt32(gridIndex, AutoPackType.Packed);
			writer.WriteVector2(originCoord);
			writer.WriteSingle(rotation, AutoPackType.Unpacked);
			writer.WriteString(jobID);
			base.SendServerRpc(8U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x000FC525 File Offset: 0x000FA725
		private void RpcLogic___CreateStoredItem_Server_1890711751(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
			this.CreateStoredItem(null, data, gridIndex, originCoord, rotation, jobID, false);
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x000FC538 File Offset: 0x000FA738
		private void RpcReader___Server_CreateStoredItem_Server_1890711751(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			StorableItemInstance data = PooledReader0.ReadStorableItemInstance();
			int gridIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			Vector2 originCoord = PooledReader0.ReadVector2();
			float rotation = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			string jobID = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___CreateStoredItem_Server_1890711751(data, gridIndex, originCoord, rotation, jobID);
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x000FC5B8 File Offset: 0x000FA7B8
		private void RpcWriter___Observers_DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
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
			writer.WriteInt32(gridIndex, AutoPackType.Packed);
			writer.Write___ScheduleOne.Tiles.CoordinateFishNet.Serializing.Generated(coord);
			writer.WriteString(jobID);
			writer.WriteBoolean(network);
			base.SendObserversRpc(9U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x000FC69C File Offset: 0x000FA89C
		public void RpcLogic___DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			if (jobID != "")
			{
				if (this.completedJobs.Contains(jobID))
				{
					return;
				}
			}
			else
			{
				jobID = Guid.NewGuid().ToString();
			}
			this.completedJobs.Add(jobID);
			List<StorageGrid> storageGrids = this.GetStorageGrids();
			if (gridIndex > storageGrids.Count)
			{
				Console.LogError("DestroyStoredItem: grid index out of range", null);
				return;
			}
			if (storageGrids[gridIndex].GetTile(coord) == null)
			{
				Console.LogError("DestroyStoredItem: no tile found at " + ((coord != null) ? coord.ToString() : null), null);
				return;
			}
			storageGrids[gridIndex].GetTile(coord).occupant.Destroy_Internal();
			if (network)
			{
				this.DestroyStoredItem_Server(gridIndex, coord, jobID);
			}
		}

		// Token: 0x06003BED RID: 15341 RVA: 0x000FC75C File Offset: 0x000FA95C
		private void RpcReader___Observers_DestroyStoredItem_3261517793(PooledReader PooledReader0, Channel channel)
		{
			int gridIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			Coordinate coord = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Tiles.CoordinateFishNet.Serializing.Generateds(PooledReader0);
			string jobID = PooledReader0.ReadString();
			bool network = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___DestroyStoredItem_3261517793(gridIndex, coord, jobID, network);
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x000FC7D0 File Offset: 0x000FA9D0
		private void RpcWriter___Server_DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
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
			writer.WriteInt32(gridIndex, AutoPackType.Packed);
			writer.Write___ScheduleOne.Tiles.CoordinateFishNet.Serializing.Generated(coord);
			writer.WriteString(jobID);
			base.SendServerRpc(10U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003BEF RID: 15343 RVA: 0x000FC896 File Offset: 0x000FAA96
		private void RpcLogic___DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
			this.DestroyStoredItem(gridIndex, coord, jobID, false);
		}

		// Token: 0x06003BF0 RID: 15344 RVA: 0x000FC8A4 File Offset: 0x000FAAA4
		private void RpcReader___Server_DestroyStoredItem_Server_3952619116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int gridIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			Coordinate coord = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Tiles.CoordinateFishNet.Serializing.Generateds(PooledReader0);
			string jobID = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___DestroyStoredItem_Server_3952619116(gridIndex, coord, jobID);
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x000FC8FC File Offset: 0x000FAAFC
		protected virtual void dll()
		{
			this.rb_Mass = this.rb.mass;
			this.rb_Drag = this.rb.drag;
			this.rb_AngularDrag = this.rb.angularDrag;
		}

		// Token: 0x04002B38 RID: 11064
		public static List<Pallet> palletsOwnedByLocalPlayer = new List<Pallet>();

		// Token: 0x04002B39 RID: 11065
		public static int sizeX = 6;

		// Token: 0x04002B3A RID: 11066
		public static int sizeY = 6;

		// Token: 0x04002B3B RID: 11067
		[Header("Reference")]
		public Transform _storedItemContainer;

		// Token: 0x04002B3C RID: 11068
		public Rigidbody rb;

		// Token: 0x04002B3D RID: 11069
		public StorageGrid storageGrid;

		// Token: 0x04002B3E RID: 11070
		public NetworkTransform networkTransform;

		// Token: 0x04002B3F RID: 11071
		protected List<Forklift> forkliftsInContact = new List<Forklift>();

		// Token: 0x04002B40 RID: 11072
		public Guid currentSlotGUID;

		// Token: 0x04002B41 RID: 11073
		private PalletSlot currentSlot;

		// Token: 0x04002B42 RID: 11074
		private float timeSinceSlotCheck;

		// Token: 0x04002B43 RID: 11075
		private float timeBoundToSlot;

		// Token: 0x04002B44 RID: 11076
		private float rb_Mass;

		// Token: 0x04002B45 RID: 11077
		private float rb_Drag;

		// Token: 0x04002B46 RID: 11078
		private float rb_AngularDrag;

		// Token: 0x04002B47 RID: 11079
		protected Dictionary<StoredItem, Employee> _reservedItems = new Dictionary<StoredItem, Employee>();

		// Token: 0x04002B48 RID: 11080
		private List<string> completedJobs = new List<string>();

		// Token: 0x04002B49 RID: 11081
		private bool dll_Excuted;

		// Token: 0x04002B4A RID: 11082
		private bool dll_Excuted;
	}
}
