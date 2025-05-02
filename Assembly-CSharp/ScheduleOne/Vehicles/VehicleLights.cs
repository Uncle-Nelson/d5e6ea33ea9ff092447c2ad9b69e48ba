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
using ScheduleOne.Vehicles.AI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007D8 RID: 2008
	public class VehicleLights : NetworkBehaviour
	{
		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x000E6F19 File Offset: 0x000E5119
		// (set) Token: 0x060036DD RID: 14045 RVA: 0x000E6F21 File Offset: 0x000E5121
		public bool headLightsOn
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<headLightsOn>k__BackingField;
			}
			[CompilerGenerated]
			[ServerRpc(RunLocally = true, RequireOwnership = false)]
			set
			{
				this.RpcWriter___Server_set_headLightsOn_1140765316(value);
				this.RpcLogic___set_headLightsOn_1140765316(value);
			}
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x000E6F37 File Offset: 0x000E5137
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Vehicles.VehicleLights_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x000E6F4C File Offset: 0x000E514C
		protected virtual void Update()
		{
			if (this.vehicle.localPlayerIsDriver && this.hasHeadLights && GameInput.GetButtonDown(GameInput.ButtonCode.ToggleLights))
			{
				this.headLightsOn = !this.headLightsOn;
				if (this.headLightsOn)
				{
					if (this.onHeadlightsOn != null)
					{
						this.onHeadlightsOn.Invoke();
						return;
					}
				}
				else if (this.onHeadlightsOff != null)
				{
					this.onHeadlightsOff.Invoke();
				}
			}
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x000E6FB8 File Offset: 0x000E51B8
		protected virtual void FixedUpdate()
		{
			this.reverseLightsOn = this.vehicle.isReversing;
			if (this.agent == null || !this.agent.AutoDriving)
			{
				this.brakeLightsOn = this.vehicle.brakesApplied;
				return;
			}
			this.brakesAppliedHistory.Add(this.vehicle.brakesApplied);
			if (this.brakesAppliedHistory.Count > 60)
			{
				this.brakesAppliedHistory.RemoveAt(0);
			}
			int num = 0;
			for (int i = 0; i < this.brakesAppliedHistory.Count; i++)
			{
				if (this.brakesAppliedHistory[i])
				{
					num++;
				}
			}
			this.brakeLightsOn = ((float)num / (float)this.brakesAppliedHistory.Count > 0.2f);
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x000E707C File Offset: 0x000E527C
		protected virtual void LateUpdate()
		{
			if (this.hasHeadLights && this.headLightsOn != this.headLightsApplied)
			{
				if (this.headLightsOn)
				{
					this.headLightsApplied = true;
					for (int i = 0; i < this.headLightMeshes.Length; i++)
					{
						this.headLightMeshes[i].material = this.headlightMat_On;
					}
					for (int j = 0; j < this.headLightSources.Length; j++)
					{
						this.headLightSources[j].Enabled = true;
					}
				}
				else
				{
					this.headLightsApplied = false;
					for (int k = 0; k < this.headLightMeshes.Length; k++)
					{
						this.headLightMeshes[k].material = this.headLightMat_Off;
					}
					for (int l = 0; l < this.headLightSources.Length; l++)
					{
						this.headLightSources[l].Enabled = false;
					}
				}
			}
			if (this.hasBrakeLights && this.brakeLightsOn != this.brakeLightsApplied)
			{
				if (this.brakeLightsOn)
				{
					this.brakeLightsApplied = true;
					for (int m = 0; m < this.brakeLightMeshes.Length; m++)
					{
						this.brakeLightMeshes[m].material = this.brakeLightMat_On;
					}
					if (this.vehicle.localPlayerIsInVehicle)
					{
						for (int n = 0; n < this.brakeLightSources.Length; n++)
						{
							this.brakeLightSources[n].enabled = true;
						}
					}
				}
				else
				{
					this.brakeLightsApplied = false;
					for (int num = 0; num < this.brakeLightMeshes.Length; num++)
					{
						this.brakeLightMeshes[num].material = this.brakeLightMat_Off;
					}
					for (int num2 = 0; num2 < this.brakeLightSources.Length; num2++)
					{
						this.brakeLightSources[num2].enabled = false;
					}
				}
			}
			if (this.hasReverseLights && this.reverseLightsOn != this.reverseLightsApplied)
			{
				if (this.reverseLightsOn)
				{
					this.reverseLightsApplied = true;
					for (int num3 = 0; num3 < this.reverseLightMeshes.Length; num3++)
					{
						this.reverseLightMeshes[num3].material = this.reverseLightMat_On;
					}
					if (this.vehicle.localPlayerIsInVehicle)
					{
						for (int num4 = 0; num4 < this.reverseLightSources.Length; num4++)
						{
							this.reverseLightSources[num4].enabled = true;
						}
						return;
					}
				}
				else
				{
					this.reverseLightsApplied = false;
					for (int num5 = 0; num5 < this.reverseLightMeshes.Length; num5++)
					{
						this.reverseLightMeshes[num5].material = this.reverseLightMat_Off;
					}
					for (int num6 = 0; num6 < this.reverseLightSources.Length; num6++)
					{
						this.reverseLightSources[num6].enabled = false;
					}
				}
			}
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x000E7334 File Offset: 0x000E5534
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<headLightsOn>k__BackingField = new SyncVar<bool>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, 0.25f, Channel.Unreliable, this.<headLightsOn>k__BackingField);
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_set_headLightsOn_1140765316));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Vehicles.VehicleLights));
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x000E73A6 File Offset: 0x000E55A6
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<headLightsOn>k__BackingField.SetRegistered();
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x000E73C4 File Offset: 0x000E55C4
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x000E73D4 File Offset: 0x000E55D4
		private void RpcWriter___Server_set_headLightsOn_1140765316(bool value)
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
			writer.WriteBoolean(value);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x000E747B File Offset: 0x000E567B
		public void RpcLogic___set_headLightsOn_1140765316(bool value)
		{
			this.sync___set_value_<headLightsOn>k__BackingField(value, true);
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x000E7488 File Offset: 0x000E5688
		private void RpcReader___Server_set_headLightsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			bool value = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___set_headLightsOn_1140765316(value);
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060036E9 RID: 14057 RVA: 0x000E74C6 File Offset: 0x000E56C6
		// (set) Token: 0x060036EA RID: 14058 RVA: 0x000E74CE File Offset: 0x000E56CE
		public bool SyncAccessor_<headLightsOn>k__BackingField
		{
			get
			{
				return this.<headLightsOn>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<headLightsOn>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<headLightsOn>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x000E750C File Offset: 0x000E570C
		public virtual bool VehicleLights(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 != 0U)
			{
				return false;
			}
			if (PooledReader0 == null)
			{
				this.sync___set_value_<headLightsOn>k__BackingField(this.syncVar___<headLightsOn>k__BackingField.GetValue(true), true);
				return true;
			}
			bool value = PooledReader0.ReadBoolean();
			this.sync___set_value_<headLightsOn>k__BackingField(value, Boolean2);
			return true;
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x000E755E File Offset: 0x000E575E
		protected virtual void dll()
		{
			this.agent = base.GetComponent<VehicleAgent>();
		}

		// Token: 0x0400275B RID: 10075
		public LandVehicle vehicle;

		// Token: 0x0400275C RID: 10076
		[Header("Headlights")]
		public bool hasHeadLights;

		// Token: 0x0400275D RID: 10077
		public MeshRenderer[] headLightMeshes;

		// Token: 0x0400275E RID: 10078
		public OptimizedLight[] headLightSources;

		// Token: 0x0400275F RID: 10079
		public Material headlightMat_On;

		// Token: 0x04002760 RID: 10080
		public Material headLightMat_Off;

		// Token: 0x04002762 RID: 10082
		protected bool headLightsApplied;

		// Token: 0x04002763 RID: 10083
		[Header("Brake lights")]
		public bool hasBrakeLights;

		// Token: 0x04002764 RID: 10084
		public MeshRenderer[] brakeLightMeshes;

		// Token: 0x04002765 RID: 10085
		public Light[] brakeLightSources;

		// Token: 0x04002766 RID: 10086
		public Material brakeLightMat_On;

		// Token: 0x04002767 RID: 10087
		public Material brakeLightMat_Off;

		// Token: 0x04002768 RID: 10088
		public Material brakeLightMat_Ambient;

		// Token: 0x04002769 RID: 10089
		protected bool brakeLightsOn;

		// Token: 0x0400276A RID: 10090
		protected bool brakeLightsApplied = true;

		// Token: 0x0400276B RID: 10091
		[Header("Reverse lights")]
		public bool hasReverseLights;

		// Token: 0x0400276C RID: 10092
		public MeshRenderer[] reverseLightMeshes;

		// Token: 0x0400276D RID: 10093
		public Light[] reverseLightSources;

		// Token: 0x0400276E RID: 10094
		public Material reverseLightMat_On;

		// Token: 0x0400276F RID: 10095
		public Material reverseLightMat_Off;

		// Token: 0x04002770 RID: 10096
		protected bool reverseLightsOn;

		// Token: 0x04002771 RID: 10097
		protected bool reverseLightsApplied = true;

		// Token: 0x04002772 RID: 10098
		public UnityEvent onHeadlightsOn;

		// Token: 0x04002773 RID: 10099
		public UnityEvent onHeadlightsOff;

		// Token: 0x04002774 RID: 10100
		private List<bool> brakesAppliedHistory = new List<bool>();

		// Token: 0x04002775 RID: 10101
		private VehicleAgent agent;

		// Token: 0x04002776 RID: 10102
		public SyncVar<bool> syncVar___<headLightsOn>k__BackingField;

		// Token: 0x04002777 RID: 10103
		private bool dll_Excuted;

		// Token: 0x04002778 RID: 10104
		private bool dll_Excuted;
	}
}
