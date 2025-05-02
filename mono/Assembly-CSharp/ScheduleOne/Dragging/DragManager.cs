using System;
using System.Collections.Generic;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.Dragging
{
	// Token: 0x02000685 RID: 1669
	public class DragManager : NetworkSingleton<DragManager>
	{
		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002E26 RID: 11814 RVA: 0x000C1509 File Offset: 0x000BF709
		// (set) Token: 0x06002E27 RID: 11815 RVA: 0x000C1511 File Offset: 0x000BF711
		public Draggable CurrentDraggable { get; protected set; }

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06002E28 RID: 11816 RVA: 0x000C151A File Offset: 0x000BF71A
		public bool IsDragging
		{
			get
			{
				return this.CurrentDraggable != null;
			}
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x000C1528 File Offset: 0x000BF728
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			foreach (Draggable draggable in this.AllDraggables)
			{
				if (draggable.InitialReplicationMode != Draggable.EInitialReplicationMode.Off && (draggable.InitialReplicationMode == Draggable.EInitialReplicationMode.Full || Vector3.Distance(draggable.initialPosition, draggable.transform.position) > 1f))
				{
					this.SetDraggableTransformData(connection, draggable.GUID.ToString(), draggable.transform.position, draggable.transform.rotation, draggable.Rigidbody.velocity);
				}
			}
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x000C15E8 File Offset: 0x000BF7E8
		public void Update()
		{
			if (this.IsDragging)
			{
				bool flag = false;
				LayerMask mask = default(LayerMask);
				mask.value = 1 << LayerMask.NameToLayer("Default");
				mask.value |= 1 << LayerMask.NameToLayer("NPC");
				RaycastHit raycastHit;
				if (Physics.Raycast(PlayerSingleton<PlayerMovement>.Instance.transform.position - PlayerSingleton<PlayerMovement>.Instance.Controller.height * Vector3.up * 0.5f, Vector3.down, ref raycastHit, 0.5f, mask))
				{
					flag = (raycastHit.collider.GetComponentInParent<Draggable>() == this.CurrentDraggable);
				}
				if (GameInput.GetButtonDown(GameInput.ButtonCode.Interact) || !this.IsDraggingAllowed() || Vector3.Distance(this.GetTargetPosition(), this.CurrentDraggable.transform.position) > 1.5f || flag)
				{
					this.StopDragging(this.CurrentDraggable.Rigidbody.velocity);
					return;
				}
				if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick))
				{
					Vector3 a = PlayerSingleton<PlayerCamera>.Instance.transform.forward * this.ThrowForce;
					float d = Mathf.Lerp(1f, Mathf.Sqrt(this.CurrentDraggable.Rigidbody.mass), this.MassInfluence);
					Vector3 velocity = this.CurrentDraggable.Rigidbody.velocity + a / d;
					this.CurrentDraggable.Rigidbody.velocity = velocity;
					this.lastThrownDraggable = this.CurrentDraggable;
					this.ThrowSound.transform.position = this.lastThrownDraggable.transform.position;
					float value = Mathf.Sqrt(this.CurrentDraggable.Rigidbody.mass / 30f);
					this.ThrowSound.VolumeMultiplier = Mathf.Clamp(value, 0.4f, 1f);
					this.ThrowSound.PitchMultiplier = Mathf.Lerp(0.6f, 0.4f, Mathf.Clamp01(value));
					this.ThrowSound.Play();
					this.StopDragging(velocity);
				}
			}
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x000C1810 File Offset: 0x000BFA10
		public void FixedUpdate()
		{
			if (this.lastThrownDraggable != null)
			{
				this.ThrowSound.transform.position = this.lastThrownDraggable.transform.position;
			}
			if (this.IsDragging)
			{
				this.CurrentDraggable.ApplyDragForces(this.GetTargetPosition());
			}
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x000C1864 File Offset: 0x000BFA64
		public bool IsDraggingAllowed()
		{
			if (PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount > 0)
			{
				return false;
			}
			if (!Player.Local.Health.IsAlive)
			{
				return false;
			}
			if (Player.Local.IsSkating)
			{
				return false;
			}
			if (PlayerSingleton<PlayerInventory>.Instance.isAnythingEquipped)
			{
				if (PlayerSingleton<PlayerInventory>.Instance.equippedSlot.ItemInstance.ID == "trashgrabber")
				{
					return false;
				}
				if (PlayerSingleton<PlayerInventory>.Instance.equippedSlot.ItemInstance.ID == "trashbag" && TrashBag_Equippable.IsHoveringTrash)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x000C18F9 File Offset: 0x000BFAF9
		public void RegisterDraggable(Draggable draggable)
		{
			if (this.AllDraggables.Contains(draggable))
			{
				return;
			}
			this.AllDraggables.Add(draggable);
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x000C1916 File Offset: 0x000BFB16
		public void Deregister(Draggable draggable)
		{
			if (this.AllDraggables.Contains(draggable))
			{
				this.AllDraggables.Remove(draggable);
			}
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x000C1934 File Offset: 0x000BFB34
		public void StartDragging(Draggable draggable)
		{
			if (this.CurrentDraggable != null)
			{
				this.CurrentDraggable.StopDragging();
			}
			this.CurrentDraggable = draggable;
			this.lastHeldDraggable = draggable;
			draggable.StartDragging(Player.Local);
			this.SendDragger(draggable.GUID.ToString(), Player.Local.NetworkObject, draggable.transform.position);
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x000C19A2 File Offset: 0x000BFBA2
		[ServerRpc(RequireOwnership = false)]
		private void SendDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			this.RpcWriter___Server_SendDragger_807933219(draggableGUID, dragger, position);
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x000C19B8 File Offset: 0x000BFBB8
		[ObserversRpc]
		private void SetDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			this.RpcWriter___Observers_SetDragger_807933219(draggableGUID, dragger, position);
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x000C19D8 File Offset: 0x000BFBD8
		public void StopDragging(Vector3 velocity)
		{
			if (this.CurrentDraggable != null)
			{
				this.CurrentDraggable.StopDragging();
				this.SendDragger(this.CurrentDraggable.GUID.ToString(), null, this.CurrentDraggable.transform.position);
				this.SendDraggableTransformData(this.CurrentDraggable.GUID.ToString(), this.CurrentDraggable.transform.position, this.CurrentDraggable.transform.rotation, velocity);
				this.CurrentDraggable = null;
			}
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x000C1A78 File Offset: 0x000BFC78
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendDraggableTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			this.RpcWriter___Server_SendDraggableTransformData_4062762274(guid, position, rotation, velocity);
			this.RpcLogic___SendDraggableTransformData_4062762274(guid, position, rotation, velocity);
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x000C1AA8 File Offset: 0x000BFCA8
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetDraggableTransformData(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetDraggableTransformData_3831223955(conn, guid, position, rotation, velocity);
				this.RpcLogic___SetDraggableTransformData_3831223955(conn, guid, position, rotation, velocity);
			}
			else
			{
				this.RpcWriter___Target_SetDraggableTransformData_3831223955(conn, guid, position, rotation, velocity);
			}
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x000C1B0D File Offset: 0x000BFD0D
		private Vector3 GetTargetPosition()
		{
			return PlayerSingleton<PlayerCamera>.Instance.transform.position + PlayerSingleton<PlayerCamera>.Instance.transform.forward * 1.25f * this.CurrentDraggable.HoldDistanceMultiplier;
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x000C1BAC File Offset: 0x000BFDAC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendDragger_807933219));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_SetDragger_807933219));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_SendDraggableTransformData_4062762274));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_SetDraggableTransformData_3831223955));
			base.RegisterTargetRpc(4U, new ClientRpcDelegate(this.RpcReader___Target_SetDraggableTransformData_3831223955));
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x000C1C43 File Offset: 0x000BFE43
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x000C1C5C File Offset: 0x000BFE5C
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x000C1C6C File Offset: 0x000BFE6C
		private void RpcWriter___Server_SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
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
			writer.WriteString(draggableGUID);
			writer.WriteNetworkObject(dragger);
			writer.WriteVector3(position);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x000C1D2D File Offset: 0x000BFF2D
		private void RpcLogic___SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			this.SetDragger(draggableGUID, dragger, position);
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x000C1D38 File Offset: 0x000BFF38
		private void RpcReader___Server_SendDragger_807933219(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string draggableGUID = PooledReader0.ReadString();
			NetworkObject dragger = PooledReader0.ReadNetworkObject();
			Vector3 position = PooledReader0.ReadVector3();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendDragger_807933219(draggableGUID, dragger, position);
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x000C1D8C File Offset: 0x000BFF8C
		private void RpcWriter___Observers_SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
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
			writer.WriteString(draggableGUID);
			writer.WriteNetworkObject(dragger);
			writer.WriteVector3(position);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x000C1E5C File Offset: 0x000C005C
		private void RpcLogic___SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			Draggable @object = GUIDManager.GetObject<Draggable>(new Guid(draggableGUID));
			Player x = (dragger != null) ? dragger.GetComponent<Player>() : null;
			if (@object != null)
			{
				if (this.CurrentDraggable != @object && this.lastHeldDraggable != @object)
				{
					@object.Rigidbody.position = position;
				}
				if (dragger != null)
				{
					if (x != null)
					{
						@object.StartDragging(dragger.GetComponent<Player>());
						return;
					}
				}
				else
				{
					@object.StopDragging();
				}
			}
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x000C1EE0 File Offset: 0x000C00E0
		private void RpcReader___Observers_SetDragger_807933219(PooledReader PooledReader0, Channel channel)
		{
			string draggableGUID = PooledReader0.ReadString();
			NetworkObject dragger = PooledReader0.ReadNetworkObject();
			Vector3 position = PooledReader0.ReadVector3();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetDragger_807933219(draggableGUID, dragger, position);
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x000C1F34 File Offset: 0x000C0134
		private void RpcWriter___Server_SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
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
			writer.WriteString(guid);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.WriteVector3(velocity);
			base.SendServerRpc(2U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x000C2007 File Offset: 0x000C0207
		private void RpcLogic___SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			this.SetDraggableTransformData(null, guid, position, rotation, velocity);
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x000C2018 File Offset: 0x000C0218
		private void RpcReader___Server_SendDraggableTransformData_4062762274(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string guid = PooledReader0.ReadString();
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			Vector3 velocity = PooledReader0.ReadVector3();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendDraggableTransformData_4062762274(guid, position, rotation, velocity);
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x000C2090 File Offset: 0x000C0290
		private void RpcWriter___Observers_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
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
			writer.WriteString(guid);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.WriteVector3(velocity);
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x000C2174 File Offset: 0x000C0374
		private void RpcLogic___SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			Draggable @object = GUIDManager.GetObject<Draggable>(new Guid(guid));
			if (@object == null)
			{
				Console.LogWarning("Failed to find draggable with GUID " + guid, null);
			}
			if (@object == this.lastThrownDraggable)
			{
				return;
			}
			if (@object == this.lastHeldDraggable)
			{
				return;
			}
			if (@object != null)
			{
				@object.Rigidbody.position = position;
				@object.Rigidbody.rotation = rotation;
				@object.Rigidbody.velocity = velocity;
			}
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x000C21F4 File Offset: 0x000C03F4
		private void RpcReader___Observers_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
			string guid = PooledReader0.ReadString();
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			Vector3 velocity = PooledReader0.ReadVector3();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetDraggableTransformData_3831223955(null, guid, position, rotation, velocity);
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x000C2268 File Offset: 0x000C0468
		private void RpcWriter___Target_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
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
			writer.WriteString(guid);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.WriteVector3(velocity);
			base.SendTargetRpc(4U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x000C234C File Offset: 0x000C054C
		private void RpcReader___Target_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
			string guid = PooledReader0.ReadString();
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			Vector3 velocity = PooledReader0.ReadVector3();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetDraggableTransformData_3831223955(base.LocalConnection, guid, position, rotation, velocity);
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x000C23BB File Offset: 0x000C05BB
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040020C5 RID: 8389
		public const float DRAGGABLE_OFFSET = 1.25f;

		// Token: 0x040020C6 RID: 8390
		public AudioSourceController ThrowSound;

		// Token: 0x040020C7 RID: 8391
		[Header("Settings")]
		public float DragForce = 10f;

		// Token: 0x040020C8 RID: 8392
		public float DampingFactor = 0.5f;

		// Token: 0x040020C9 RID: 8393
		public float TorqueForce = 10f;

		// Token: 0x040020CA RID: 8394
		public float TorqueDampingFactor = 0.5f;

		// Token: 0x040020CB RID: 8395
		public float ThrowForce = 10f;

		// Token: 0x040020CC RID: 8396
		public float MassInfluence = 0.6f;

		// Token: 0x040020CE RID: 8398
		private List<Draggable> AllDraggables = new List<Draggable>();

		// Token: 0x040020CF RID: 8399
		private Draggable lastThrownDraggable;

		// Token: 0x040020D0 RID: 8400
		private Draggable lastHeldDraggable;

		// Token: 0x040020D1 RID: 8401
		private bool dll_Excuted;

		// Token: 0x040020D2 RID: 8402
		private bool dll_Excuted;
	}
}
