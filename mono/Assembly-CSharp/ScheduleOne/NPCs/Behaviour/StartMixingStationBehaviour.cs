using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Employees;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000516 RID: 1302
	public class StartMixingStationBehaviour : Behaviour
	{
		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x0007E999 File Offset: 0x0007CB99
		// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x0007E9A1 File Offset: 0x0007CBA1
		public MixingStation targetStation { get; private set; }

		// Token: 0x06001ED9 RID: 7897 RVA: 0x0007E9AA File Offset: 0x0007CBAA
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Behaviour.StartMixingStationBehaviour_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x0007E9BE File Offset: 0x0007CBBE
		public void AssignStation(MixingStation station)
		{
			this.targetStation = station;
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x0007E9C7 File Offset: 0x0007CBC7
		protected override void End()
		{
			base.End();
			if (this.startRoutine != null)
			{
				this.StopCook();
			}
			if (this.targetStation != null)
			{
				this.targetStation.SetNPCUser(null);
			}
			this.Disable();
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x0007E9FD File Offset: 0x0007CBFD
		protected override void Pause()
		{
			base.Pause();
			if (this.targetStation != null)
			{
				this.targetStation.SetNPCUser(null);
			}
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x0007EA20 File Offset: 0x0007CC20
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (this.startRoutine != null)
			{
				base.Npc.Avatar.LookController.OverrideLookTarget(this.targetStation.UIPoint.position, 5, false);
				return;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!base.Npc.Movement.IsMoving)
			{
				if (this.IsAtStation())
				{
					this.StartCook();
					return;
				}
				base.SetDestination(this.GetStationAccessPoint(), true);
			}
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x0007EA99 File Offset: 0x0007CC99
		[ObserversRpc(RunLocally = true)]
		private void StartCook()
		{
			this.RpcWriter___Observers_StartCook_2166136261();
			this.RpcLogic___StartCook_2166136261();
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x0007EAA8 File Offset: 0x0007CCA8
		private bool CanCookStart()
		{
			if (this.targetStation == null)
			{
				return false;
			}
			if (((IUsable)this.targetStation).IsInUse && ((IUsable)this.targetStation).NPCUserObject != base.Npc.NetworkObject)
			{
				return false;
			}
			MixingStationConfiguration mixingStationConfiguration = this.targetStation.Configuration as MixingStationConfiguration;
			return (float)this.targetStation.GetMixQuantity() >= mixingStationConfiguration.StartThrehold.Value;
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x0007EB20 File Offset: 0x0007CD20
		private void StopCook()
		{
			if (this.targetStation != null)
			{
				this.targetStation.SetNPCUser(null);
			}
			base.Npc.SetAnimationBool_Networked(null, "UseChemistryStation", false);
			if (this.startRoutine != null)
			{
				base.StopCoroutine(this.startRoutine);
				this.startRoutine = null;
			}
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0007EB74 File Offset: 0x0007CD74
		private Vector3 GetStationAccessPoint()
		{
			if (this.targetStation == null)
			{
				return base.Npc.transform.position;
			}
			return ((ITransitEntity)this.targetStation).AccessPoints[0].position;
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x0007EBA7 File Offset: 0x0007CDA7
		private bool IsAtStation()
		{
			return !(this.targetStation == null) && Vector3.Distance(base.Npc.transform.position, this.GetStationAccessPoint()) < 1f;
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x0007EBDB File Offset: 0x0007CDDB
		[CompilerGenerated]
		private IEnumerator <StartCook>g__CookRoutine|12_0()
		{
			base.Npc.Movement.FacePoint(this.targetStation.transform.position, 0.5f);
			yield return new WaitForSeconds(0.5f);
			if (!this.CanCookStart())
			{
				this.StopCook();
				base.End_Networked(null);
				yield break;
			}
			this.targetStation.SetNPCUser(base.Npc.NetworkObject);
			base.Npc.SetAnimationBool_Networked(null, "UseChemistryStation", true);
			QualityItemInstance product = this.targetStation.ProductSlot.ItemInstance as QualityItemInstance;
			ItemInstance mixer = this.targetStation.MixerSlot.ItemInstance;
			int mixQuantity = this.targetStation.GetMixQuantity();
			int num;
			for (int i = 0; i < mixQuantity; i = num + 1)
			{
				yield return new WaitForSeconds(1f);
				num = i;
			}
			if (InstanceFinder.IsServer)
			{
				this.targetStation.ProductSlot.ChangeQuantity(-mixQuantity, false);
				this.targetStation.MixerSlot.ChangeQuantity(-mixQuantity, false);
				MixOperation operation = new MixOperation(product.ID, product.Quality, mixer.ID, mixQuantity);
				this.targetStation.SendMixingOperation(operation, 0);
			}
			this.StopCook();
			base.End_Networked(null);
			yield break;
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x0007EBEA File Offset: 0x0007CDEA
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartMixingStationBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartMixingStationBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_StartCook_2166136261));
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x0007EC1A File Offset: 0x0007CE1A
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartMixingStationBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartMixingStationBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x0007EC33 File Offset: 0x0007CE33
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x0007EC44 File Offset: 0x0007CE44
		private void RpcWriter___Observers_StartCook_2166136261()
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
			base.SendObserversRpc(15U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x0007ECED File Offset: 0x0007CEED
		private void RpcLogic___StartCook_2166136261()
		{
			if (this.startRoutine != null)
			{
				return;
			}
			if (this.targetStation == null)
			{
				return;
			}
			this.startRoutine = base.StartCoroutine(this.<StartCook>g__CookRoutine|12_0());
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x0007ED1C File Offset: 0x0007CF1C
		private void RpcReader___Observers_StartCook_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___StartCook_2166136261();
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0007ED46 File Offset: 0x0007CF46
		protected virtual void dll()
		{
			base.Awake();
			this.chemist = (base.Npc as Chemist);
		}

		// Token: 0x04001847 RID: 6215
		public const float INSERT_INGREDIENT_BASE_TIME = 1f;

		// Token: 0x04001849 RID: 6217
		private Chemist chemist;

		// Token: 0x0400184A RID: 6218
		private Coroutine startRoutine;

		// Token: 0x0400184B RID: 6219
		private bool dll_Excuted;

		// Token: 0x0400184C RID: 6220
		private bool dll_Excuted;
	}
}
