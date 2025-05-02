using System;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007C0 RID: 1984
	public class Forklift : LandVehicle
	{
		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060035B2 RID: 13746 RVA: 0x000E1928 File Offset: 0x000DFB28
		// (set) Token: 0x060035B3 RID: 13747 RVA: 0x000E1930 File Offset: 0x000DFB30
		public float targetForkHeight
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<targetForkHeight>k__BackingField;
			}
			[CompilerGenerated]
			[ServerRpc(RunLocally = true)]
			protected set
			{
				this.RpcWriter___Server_set_targetForkHeight_431000436(value);
				this.RpcLogic___set_targetForkHeight_431000436(value);
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060035B4 RID: 13748 RVA: 0x000E1946 File Offset: 0x000DFB46
		// (set) Token: 0x060035B5 RID: 13749 RVA: 0x000E194E File Offset: 0x000DFB4E
		public float actualForkHeight
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<actualForkHeight>k__BackingField;
			}
			[CompilerGenerated]
			[ServerRpc(RunLocally = true)]
			protected set
			{
				this.RpcWriter___Server_set_actualForkHeight_431000436(value);
				this.RpcLogic___set_actualForkHeight_431000436(value);
			}
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x000E1964 File Offset: 0x000DFB64
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Vehicles.Forklift_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x000E1984 File Offset: 0x000DFB84
		protected override void Update()
		{
			base.Update();
			if (base.localPlayerIsDriver)
			{
				this.targetForkHeight = this.lastFrameTargetForkHeight;
				int num = 0;
				if (Input.GetKey(KeyCode.UpArrow))
				{
					num++;
				}
				if (Input.GetKey(KeyCode.DownArrow))
				{
					num--;
				}
				this.targetForkHeight = Mathf.Clamp(this.targetForkHeight + (float)num * Time.deltaTime * this.liftMoveRate, 0f, 1f);
			}
			this.lastFrameTargetForkHeight = this.targetForkHeight;
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x000E1A04 File Offset: 0x000DFC04
		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (base.IsOwner || (base.OwnerId == -1 && InstanceFinder.IsHost))
			{
				this.forkRb.isKinematic = false;
				this.joint.targetPosition = new Vector3(0f, Mathf.Lerp(this.lift_MinY, this.lift_MaxY, this.targetForkHeight), 0f);
				Vector3 vector = this.forkRb.transform.position - base.transform.TransformPoint(this.joint.connectedAnchor);
				vector = base.transform.InverseTransformVector(vector);
				this.actualForkHeight = 1f - Mathf.InverseLerp(this.lift_MinY, this.lift_MaxY, vector.y);
			}
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x000E1AD0 File Offset: 0x000DFCD0
		protected new virtual void LateUpdate()
		{
			if (!base.localPlayerIsDriver && (!InstanceFinder.IsHost || base.CurrentPlayerOccupancy > 0))
			{
				this.forkRb.isKinematic = true;
				this.forkRb.transform.position = base.transform.TransformPoint(this.joint.connectedAnchor + new Vector3(0f, -Mathf.Lerp(this.lift_MinY, this.lift_MaxY, this.actualForkHeight), 0f));
				this.forkRb.transform.rotation = base.transform.rotation;
			}
			this.steeringWheel.localEulerAngles = new Vector3(0f, base.SyncAccessor_currentSteerAngle * this.steeringWheelAngleMultiplier, 0f);
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x000E1BB8 File Offset: 0x000DFDB8
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Vehicles.ForkliftAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Vehicles.ForkliftAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<actualForkHeight>k__BackingField = new SyncVar<float>(this, 4U, WritePermission.ServerOnly, ReadPermission.Observers, 0.04f, Channel.Unreliable, this.<actualForkHeight>k__BackingField);
			this.syncVar___<targetForkHeight>k__BackingField = new SyncVar<float>(this, 3U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Unreliable, this.<targetForkHeight>k__BackingField);
			base.RegisterServerRpc(17U, new ServerRpcDelegate(this.RpcReader___Server_set_targetForkHeight_431000436));
			base.RegisterServerRpc(18U, new ServerRpcDelegate(this.RpcReader___Server_set_actualForkHeight_431000436));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Vehicles.Forklift));
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x000E1C72 File Offset: 0x000DFE72
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Vehicles.ForkliftAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Vehicles.ForkliftAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<actualForkHeight>k__BackingField.SetRegistered();
			this.syncVar___<targetForkHeight>k__BackingField.SetRegistered();
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x000E1CA1 File Offset: 0x000DFEA1
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x000E1CB0 File Offset: 0x000DFEB0
		private void RpcWriter___Server_set_targetForkHeight_431000436(float value)
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
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				if (networkManager2 == null)
				{
					networkManager2 = InstanceFinder.NetworkManager;
				}
				if (networkManager2 != null)
				{
					networkManager2.LogWarning("Cannot complete action because you are not the owner of this object. .");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because you are not the owner of this object. .");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteSingle(value, AutoPackType.Unpacked);
			base.SendServerRpc(17U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x000E1DB6 File Offset: 0x000DFFB6
		protected void RpcLogic___set_targetForkHeight_431000436(float value)
		{
			this.sync___set_value_<targetForkHeight>k__BackingField(value, true);
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x000E1DC0 File Offset: 0x000DFFC0
		private void RpcReader___Server_set_targetForkHeight_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(conn))
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___set_targetForkHeight_431000436(value);
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x000E1E14 File Offset: 0x000E0014
		private void RpcWriter___Server_set_actualForkHeight_431000436(float value)
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
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				if (networkManager2 == null)
				{
					networkManager2 = InstanceFinder.NetworkManager;
				}
				if (networkManager2 != null)
				{
					networkManager2.LogWarning("Cannot complete action because you are not the owner of this object. .");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because you are not the owner of this object. .");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteSingle(value, AutoPackType.Unpacked);
			base.SendServerRpc(18U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x000E1F1A File Offset: 0x000E011A
		protected void RpcLogic___set_actualForkHeight_431000436(float value)
		{
			this.sync___set_value_<actualForkHeight>k__BackingField(value, true);
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x000E1F24 File Offset: 0x000E0124
		private void RpcReader___Server_set_actualForkHeight_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(conn))
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___set_actualForkHeight_431000436(value);
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060035C4 RID: 13764 RVA: 0x000E1F78 File Offset: 0x000E0178
		// (set) Token: 0x060035C5 RID: 13765 RVA: 0x000E1F80 File Offset: 0x000E0180
		public float SyncAccessor_<targetForkHeight>k__BackingField
		{
			get
			{
				return this.<targetForkHeight>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<targetForkHeight>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<targetForkHeight>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x000E1FBC File Offset: 0x000E01BC
		public virtual bool Forklift(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 4U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<actualForkHeight>k__BackingField(this.syncVar___<actualForkHeight>k__BackingField.GetValue(true), true);
					return true;
				}
				float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
				this.sync___set_value_<actualForkHeight>k__BackingField(value, Boolean2);
				return true;
			}
			else
			{
				if (UInt321 != 3U)
				{
					return false;
				}
				if (PooledReader0 == null)
				{
					this.sync___set_value_<targetForkHeight>k__BackingField(this.syncVar___<targetForkHeight>k__BackingField.GetValue(true), true);
					return true;
				}
				float value2 = PooledReader0.ReadSingle(AutoPackType.Unpacked);
				this.sync___set_value_<targetForkHeight>k__BackingField(value2, Boolean2);
				return true;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060035C7 RID: 13767 RVA: 0x000E205C File Offset: 0x000E025C
		// (set) Token: 0x060035C8 RID: 13768 RVA: 0x000E2064 File Offset: 0x000E0264
		public float SyncAccessor_<actualForkHeight>k__BackingField
		{
			get
			{
				return this.<actualForkHeight>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<actualForkHeight>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<actualForkHeight>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x000E20A0 File Offset: 0x000E02A0
		protected virtual void dll()
		{
			base.Awake();
			Vector3 position = this.forkRb.transform.position;
			Quaternion rotation = this.forkRb.transform.rotation;
			this.forkRb.transform.SetParent(null);
			this.forkRb.transform.position = position;
			this.forkRb.transform.rotation = rotation;
		}

		// Token: 0x0400269D RID: 9885
		[Header("Forklift References")]
		[SerializeField]
		protected Transform steeringWheel;

		// Token: 0x0400269E RID: 9886
		[SerializeField]
		protected Rigidbody forkRb;

		// Token: 0x0400269F RID: 9887
		[SerializeField]
		protected ConfigurableJoint joint;

		// Token: 0x040026A0 RID: 9888
		[Header("Forklift settings")]
		[SerializeField]
		protected float steeringWheelAngleMultiplier = 2f;

		// Token: 0x040026A1 RID: 9889
		[SerializeField]
		protected float lift_MinY;

		// Token: 0x040026A2 RID: 9890
		[SerializeField]
		protected float lift_MaxY;

		// Token: 0x040026A3 RID: 9891
		[SerializeField]
		protected float liftMoveRate = 0.5f;

		// Token: 0x040026A5 RID: 9893
		private float lastFrameTargetForkHeight;

		// Token: 0x040026A7 RID: 9895
		public SyncVar<float> syncVar___<targetForkHeight>k__BackingField;

		// Token: 0x040026A8 RID: 9896
		public SyncVar<float> syncVar___<actualForkHeight>k__BackingField;

		// Token: 0x040026A9 RID: 9897
		private bool dll_Excuted;

		// Token: 0x040026AA RID: 9898
		private bool dll_Excuted;
	}
}
