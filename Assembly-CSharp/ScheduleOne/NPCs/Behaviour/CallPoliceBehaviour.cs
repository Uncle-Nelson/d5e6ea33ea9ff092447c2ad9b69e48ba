using System;
using FishNet;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.DevUtilities;
using ScheduleOne.Law;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.WorldspacePopup;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x020004E8 RID: 1256
	public class CallPoliceBehaviour : Behaviour
	{
		// Token: 0x06001C50 RID: 7248 RVA: 0x000756B0 File Offset: 0x000738B0
		protected override void Begin()
		{
			base.Begin();
			if (!this.IsTargetValid())
			{
				this.End();
				this.Disable();
				return;
			}
			if (this.ReportedCrime == null)
			{
				Console.LogError("CallPoliceBehaviour doesn't have a crime set, disabling.", null);
				this.Disable();
				this.End();
				return;
			}
			Console.Log("CallPoliceBehaviour started on player " + this.Target.PlayerName, null);
			this.currentCallTime = 0f;
			this.RefreshIcon();
			if (this.Target.Owner.IsLocalClient)
			{
				this.PhoneCallPopup.enabled = true;
			}
			this.CallSound.Play();
			if (InstanceFinder.IsServer)
			{
				base.Npc.SetEquippable_Networked(null, this.PhonePrefab.AssetPath);
			}
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x000045B1 File Offset: 0x000027B1
		public void SetData(NetworkObject player, Crime crime)
		{
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0007576C File Offset: 0x0007396C
		protected override void Resume()
		{
			base.Resume();
			if (!this.IsTargetValid())
			{
				this.End();
				this.Disable();
				return;
			}
			this.currentCallTime = 0f;
			this.RefreshIcon();
			if (this.Target.Owner.IsLocalClient)
			{
				this.PhoneCallPopup.enabled = true;
			}
			this.CallSound.Play();
			if (InstanceFinder.IsServer)
			{
				base.Npc.SetEquippable_Networked(null, this.PhonePrefab.AssetPath);
			}
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x000757EC File Offset: 0x000739EC
		protected override void End()
		{
			base.End();
			this.currentCallTime = 0f;
			this.PhoneCallPopup.enabled = false;
			this.CallSound.Stop();
			if (InstanceFinder.IsServer)
			{
				base.Npc.SetEquippable_Networked(null, string.Empty);
			}
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0007583C File Offset: 0x00073A3C
		protected override void Pause()
		{
			base.Pause();
			this.currentCallTime = 0f;
			this.PhoneCallPopup.enabled = false;
			this.CallSound.Stop();
			if (InstanceFinder.IsServer)
			{
				base.Npc.SetEquippable_Networked(null, string.Empty);
			}
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x0007588C File Offset: 0x00073A8C
		public override void BehaviourUpdate()
		{
			base.BehaviourUpdate();
			this.currentCallTime += Time.deltaTime;
			this.RefreshIcon();
			base.Npc.Avatar.LookController.OverrideLookTarget(this.Target.EyePosition, 1, true);
			if (this.currentCallTime >= 4f && InstanceFinder.IsServer)
			{
				this.FinalizeCall();
			}
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x000758F3 File Offset: 0x00073AF3
		private void RefreshIcon()
		{
			this.PhoneCallPopup.CurrentFillLevel = this.currentCallTime / 4f;
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0007590C File Offset: 0x00073B0C
		[ObserversRpc(RunLocally = true)]
		private void FinalizeCall()
		{
			this.RpcWriter___Observers_FinalizeCall_2166136261();
			this.RpcLogic___FinalizeCall_2166136261();
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00075925 File Offset: 0x00073B25
		private bool IsTargetValid()
		{
			return !(this.Target == null) && this.Target.Health.IsAlive && !this.Target.IsArrested;
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x0007595B File Offset: 0x00073B5B
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_FinalizeCall_2166136261));
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0007598B File Offset: 0x00073B8B
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x000759A4 File Offset: 0x00073BA4
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x000759B4 File Offset: 0x00073BB4
		private void RpcWriter___Observers_FinalizeCall_2166136261()
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

		// Token: 0x06001C5E RID: 7262 RVA: 0x00075A60 File Offset: 0x00073C60
		private void RpcLogic___FinalizeCall_2166136261()
		{
			if (!base.Active)
			{
				return;
			}
			if (!this.IsTargetValid())
			{
				this.End();
				this.Disable();
				return;
			}
			Debug.Log("Call finalized on player " + this.Target.PlayerName);
			this.Target.CrimeData.RecordLastKnownPosition(true);
			this.Target.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Investigating);
			this.Target.CrimeData.AddCrime(this.ReportedCrime, 1);
			if (InstanceFinder.IsServer)
			{
				Singleton<LawManager>.Instance.PoliceCalled(this.Target, this.ReportedCrime);
			}
			this.End();
			this.Disable();
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x00075B08 File Offset: 0x00073D08
		private void RpcReader___Observers_FinalizeCall_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___FinalizeCall_2166136261();
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00075B32 File Offset: 0x00073D32
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001754 RID: 5972
		public const float CALL_POLICE_TIME = 4f;

		// Token: 0x04001755 RID: 5973
		[Header("References")]
		public WorldspacePopup PhoneCallPopup;

		// Token: 0x04001756 RID: 5974
		public AvatarEquippable PhonePrefab;

		// Token: 0x04001757 RID: 5975
		public AudioSourceController CallSound;

		// Token: 0x04001758 RID: 5976
		private float currentCallTime;

		// Token: 0x04001759 RID: 5977
		public Player Target;

		// Token: 0x0400175A RID: 5978
		public Crime ReportedCrime;

		// Token: 0x0400175B RID: 5979
		private bool dll_Excuted;

		// Token: 0x0400175C RID: 5980
		private bool dll_Excuted;
	}
}
