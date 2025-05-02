using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Misc;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Police
{
	// Token: 0x02000337 RID: 823
	public class RoadCheckpoint : NetworkBehaviour
	{
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x000501E6 File Offset: 0x0004E3E6
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x000501EE File Offset: 0x0004E3EE
		public RoadCheckpoint.ECheckpointState ActivationState { get; protected set; }

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x000501F7 File Offset: 0x0004E3F7
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x000501FF File Offset: 0x0004E3FF
		public bool Gate1Open
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<Gate1Open>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.sync___set_value_<Gate1Open>k__BackingField(value, true);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00050209 File Offset: 0x0004E409
		// (set) Token: 0x06001253 RID: 4691 RVA: 0x00050211 File Offset: 0x0004E411
		public bool Gate2Open
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<Gate2Open>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.sync___set_value_<Gate2Open>k__BackingField(value, true);
			}
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x0005021C File Offset: 0x0004E41C
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Police.RoadCheckpoint_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0005023C File Offset: 0x0004E43C
		protected virtual void Update()
		{
			if (this.ActivationState != RoadCheckpoint.ECheckpointState.Disabled)
			{
				this.VehicleObstacle1.gameObject.SetActive(!this.Gate1Open);
				this.VehicleObstacle2.gameObject.SetActive(!this.Gate2Open);
				this.Stopper1.isActive = !this.Gate1Open;
				this.Stopper2.isActive = !this.Gate2Open;
			}
			if (this.ActivationState != this.appliedState)
			{
				this.ApplyState();
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.OpenForNPCs)
			{
				if (this.NPCVehicleDetectionArea1.closestVehicle != null && this.NPCVehicleDetectionArea1.closestVehicle.OccupantNPCs[0] != null)
				{
					if (!this.Gate1Open)
					{
						this.SetGate1Open(true);
					}
					if (!this.Gate2Open)
					{
						this.SetGate2Open(true);
					}
				}
				if (this.NPCVehicleDetectionArea2.closestVehicle != null && this.NPCVehicleDetectionArea2.closestVehicle.OccupantNPCs[0] != null)
				{
					if (!this.Gate1Open)
					{
						this.SetGate1Open(true);
					}
					if (!this.Gate2Open)
					{
						this.SetGate2Open(true);
					}
				}
			}
			if (this.ActivationState != RoadCheckpoint.ECheckpointState.Disabled)
			{
				if (this.Gate1Open)
				{
					this.timeSinceGate1Open += Time.deltaTime;
					if (this.ImmediateVehicleDetector.vehicles.Count > 0)
					{
						this.vehicleDetectedSinceGate1Open = true;
					}
					if (this.timeSinceGate1Open > 15f || (this.vehicleDetectedSinceGate1Open && this.ImmediateVehicleDetector.vehicles.Count == 0))
					{
						this.SetGate1Open(false);
					}
				}
				else
				{
					this.timeSinceGate1Open = 0f;
					this.vehicleDetectedSinceGate1Open = false;
				}
				if (!this.Gate2Open)
				{
					this.timeSinceGate2Open = 0f;
					this.vehicleDetectedSinceGate2Open = false;
					return;
				}
				this.timeSinceGate2Open += Time.deltaTime;
				if (this.ImmediateVehicleDetector.vehicles.Count > 0)
				{
					this.vehicleDetectedSinceGate2Open = true;
				}
				if (this.timeSinceGate2Open > 15f || (this.vehicleDetectedSinceGate2Open && this.ImmediateVehicleDetector.vehicles.Count == 0))
				{
					this.SetGate2Open(false);
					return;
				}
			}
			else
			{
				this.timeSinceGate1Open = 0f;
				this.vehicleDetectedSinceGate1Open = false;
				this.timeSinceGate2Open = 0f;
				this.vehicleDetectedSinceGate2Open = false;
			}
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00050483 File Offset: 0x0004E683
		protected virtual void ApplyState()
		{
			this.appliedState = this.ActivationState;
			if (this.ActivationState == RoadCheckpoint.ECheckpointState.Disabled)
			{
				this.container.SetActive(false);
				return;
			}
			this.container.SetActive(true);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x000504B2 File Offset: 0x0004E6B2
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Enable(NetworkConnection conn)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_Enable_328543758(conn);
				this.RpcLogic___Enable_328543758(conn);
			}
			else
			{
				this.RpcWriter___Target_Enable_328543758(conn);
			}
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x000504DC File Offset: 0x0004E6DC
		[ObserversRpc(RunLocally = true)]
		public void Disable()
		{
			this.RpcWriter___Observers_Disable_2166136261();
			this.RpcLogic___Disable_2166136261();
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x000504F5 File Offset: 0x0004E6F5
		public void SetGate1Open(bool o)
		{
			this.Gate1Open = o;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x000504FE File Offset: 0x0004E6FE
		public void SetGate2Open(bool o)
		{
			this.Gate2Open = o;
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00050508 File Offset: 0x0004E708
		private void ResetTrafficCones()
		{
			if (this.trafficConeOriginalTransforms.Count == 0)
			{
				return;
			}
			for (int i = 0; i < this.TrafficCones.Length; i++)
			{
				this.TrafficCones[i].transform.position = this.trafficConeOriginalTransforms[this.TrafficCones[i]].Item1;
				this.TrafficCones[i].transform.rotation = this.trafficConeOriginalTransforms[this.TrafficCones[i]].Item2;
			}
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0005058A File Offset: 0x0004E78A
		public void PlayerDetected(Player player)
		{
			if (this.onPlayerWalkThrough != null)
			{
				this.onPlayerWalkThrough.Invoke(player);
			}
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x000505C8 File Offset: 0x0004E7C8
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<Gate2Open>k__BackingField = new SyncVar<bool>(this, 1U, WritePermission.ServerOnly, ReadPermission.Observers, 0.25f, Channel.Reliable, this.<Gate2Open>k__BackingField);
			this.syncVar___<Gate1Open>k__BackingField = new SyncVar<bool>(this, 0U, WritePermission.ServerOnly, ReadPermission.Observers, 0.25f, Channel.Reliable, this.<Gate1Open>k__BackingField);
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_Enable_328543758));
			base.RegisterTargetRpc(1U, new ClientRpcDelegate(this.RpcReader___Target_Enable_328543758));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_Disable_2166136261));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Police.RoadCheckpoint));
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00050693 File Offset: 0x0004E893
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<Gate2Open>k__BackingField.SetRegistered();
			this.syncVar___<Gate1Open>k__BackingField.SetRegistered();
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000506BC File Offset: 0x0004E8BC
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000506CC File Offset: 0x0004E8CC
		private void RpcWriter___Observers_Enable_328543758(NetworkConnection conn)
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
			base.SendObserversRpc(0U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00050775 File Offset: 0x0004E975
		public void RpcLogic___Enable_328543758(NetworkConnection conn)
		{
			this.ResetTrafficCones();
			this.ActivationState = RoadCheckpoint.ECheckpointState.Enabled;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00050784 File Offset: 0x0004E984
		private void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Enable_328543758(null);
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x000507B0 File Offset: 0x0004E9B0
		private void RpcWriter___Target_Enable_328543758(NetworkConnection conn)
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
			base.SendTargetRpc(1U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00050858 File Offset: 0x0004EA58
		private void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Enable_328543758(base.LocalConnection);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00050880 File Offset: 0x0004EA80
		private void RpcWriter___Observers_Disable_2166136261()
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
			base.SendObserversRpc(2U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x0005092C File Offset: 0x0004EB2C
		public void RpcLogic___Disable_2166136261()
		{
			this.ActivationState = RoadCheckpoint.ECheckpointState.Disabled;
			if (InstanceFinder.IsServer)
			{
				for (int i = 0; i < this.AssignedNPCs.Count; i++)
				{
					(this.AssignedNPCs[i] as PoliceOfficer).UnassignFromCheckpoint();
				}
			}
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00050974 File Offset: 0x0004EB74
		private void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Disable_2166136261();
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x0005099E File Offset: 0x0004EB9E
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x000509A6 File Offset: 0x0004EBA6
		public bool SyncAccessor_<Gate1Open>k__BackingField
		{
			get
			{
				return this.<Gate1Open>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<Gate1Open>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<Gate1Open>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x000509E4 File Offset: 0x0004EBE4
		public virtual bool RoadCheckpoint(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 1U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<Gate2Open>k__BackingField(this.syncVar___<Gate2Open>k__BackingField.GetValue(true), true);
					return true;
				}
				bool value = PooledReader0.ReadBoolean();
				this.sync___set_value_<Gate2Open>k__BackingField(value, Boolean2);
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
					this.sync___set_value_<Gate1Open>k__BackingField(this.syncVar___<Gate1Open>k__BackingField.GetValue(true), true);
					return true;
				}
				bool value2 = PooledReader0.ReadBoolean();
				this.sync___set_value_<Gate1Open>k__BackingField(value2, Boolean2);
				return true;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x00050A7A File Offset: 0x0004EC7A
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x00050A82 File Offset: 0x0004EC82
		public bool SyncAccessor_<Gate2Open>k__BackingField
		{
			get
			{
				return this.<Gate2Open>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<Gate2Open>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<Gate2Open>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00050AC0 File Offset: 0x0004ECC0
		protected virtual void dll()
		{
			if (this.EnabledOnStart)
			{
				this.ActivationState = RoadCheckpoint.ECheckpointState.Enabled;
			}
			this.ApplyState();
			if (this.trafficConeOriginalTransforms.Count == 0)
			{
				for (int i = 0; i < this.TrafficCones.Length; i++)
				{
					this.trafficConeOriginalTransforms.Add(this.TrafficCones[i], new Tuple<Vector3, Quaternion>(this.TrafficCones[i].transform.position, this.TrafficCones[i].transform.rotation));
				}
			}
		}

		// Token: 0x040011A5 RID: 4517
		public const float MAX_TIME_OPEN = 15f;

		// Token: 0x040011A7 RID: 4519
		protected RoadCheckpoint.ECheckpointState appliedState;

		// Token: 0x040011AA RID: 4522
		public List<NPC> AssignedNPCs = new List<NPC>();

		// Token: 0x040011AB RID: 4523
		[Header("Settings")]
		public EStealthLevel MaxStealthLevel;

		// Token: 0x040011AC RID: 4524
		public bool OpenForNPCs = true;

		// Token: 0x040011AD RID: 4525
		public bool EnabledOnStart;

		// Token: 0x040011AE RID: 4526
		[Header("References")]
		[SerializeField]
		protected GameObject container;

		// Token: 0x040011AF RID: 4527
		public CarStopper Stopper1;

		// Token: 0x040011B0 RID: 4528
		public CarStopper Stopper2;

		// Token: 0x040011B1 RID: 4529
		public VehicleDetector SearchArea1;

		// Token: 0x040011B2 RID: 4530
		public VehicleDetector SearchArea2;

		// Token: 0x040011B3 RID: 4531
		public VehicleObstacle VehicleObstacle1;

		// Token: 0x040011B4 RID: 4532
		public VehicleObstacle VehicleObstacle2;

		// Token: 0x040011B5 RID: 4533
		public VehicleDetector NPCVehicleDetectionArea1;

		// Token: 0x040011B6 RID: 4534
		public VehicleDetector NPCVehicleDetectionArea2;

		// Token: 0x040011B7 RID: 4535
		public VehicleDetector ImmediateVehicleDetector;

		// Token: 0x040011B8 RID: 4536
		public Rigidbody[] TrafficCones;

		// Token: 0x040011B9 RID: 4537
		public Transform[] StandPoints;

		// Token: 0x040011BA RID: 4538
		protected Dictionary<Rigidbody, Tuple<Vector3, Quaternion>> trafficConeOriginalTransforms = new Dictionary<Rigidbody, Tuple<Vector3, Quaternion>>();

		// Token: 0x040011BB RID: 4539
		private float timeSinceGate1Open;

		// Token: 0x040011BC RID: 4540
		private bool vehicleDetectedSinceGate1Open;

		// Token: 0x040011BD RID: 4541
		private float timeSinceGate2Open;

		// Token: 0x040011BE RID: 4542
		private bool vehicleDetectedSinceGate2Open;

		// Token: 0x040011BF RID: 4543
		public UnityEvent<Player> onPlayerWalkThrough;

		// Token: 0x040011C0 RID: 4544
		public SyncVar<bool> syncVar___<Gate1Open>k__BackingField;

		// Token: 0x040011C1 RID: 4545
		public SyncVar<bool> syncVar___<Gate2Open>k__BackingField;

		// Token: 0x040011C2 RID: 4546
		private bool dll_Excuted;

		// Token: 0x040011C3 RID: 4547
		private bool dll_Excuted;

		// Token: 0x02000338 RID: 824
		public enum ECheckpointState
		{
			// Token: 0x040011C5 RID: 4549
			Disabled,
			// Token: 0x040011C6 RID: 4550
			Enabled
		}
	}
}
