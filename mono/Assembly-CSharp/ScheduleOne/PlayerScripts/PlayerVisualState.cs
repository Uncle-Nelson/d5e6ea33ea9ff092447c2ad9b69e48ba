using System;
using System.Collections.Generic;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Law;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x02000603 RID: 1539
	public class PlayerVisualState : NetworkBehaviour
	{
		// Token: 0x06002830 RID: 10288 RVA: 0x000A5390 File Offset: 0x000A3590
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.PlayerScripts.PlayerVisualState_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x000A53A4 File Offset: 0x000A35A4
		private void Update()
		{
			if (NetworkSingleton<CurfewManager>.InstanceExists && NetworkSingleton<CurfewManager>.Instance.IsCurrentlyActiveWithTolerance && this.player.CurrentProperty == null && this.player.CurrentBusiness == null)
			{
				if (this.GetState("DisobeyingCurfew") == null)
				{
					this.ApplyState("DisobeyingCurfew", PlayerVisualState.EVisualState.DisobeyingCurfew, 0f);
				}
			}
			else if (this.GetState("DisobeyingCurfew") != null)
			{
				this.RemoveState("DisobeyingCurfew", 0f);
			}
			this.UpdateSuspiciousness();
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x000A5430 File Offset: 0x000A3630
		[ServerRpc(RunLocally = true)]
		public void ApplyState(string label, PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
		{
			this.RpcWriter___Server_ApplyState_868472085(label, state, autoRemoveAfter);
			this.RpcLogic___ApplyState_868472085(label, state, autoRemoveAfter);
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x000A5464 File Offset: 0x000A3664
		[ServerRpc(RunLocally = true)]
		public void RemoveState(string label, float delay = 0f)
		{
			this.RpcWriter___Server_RemoveState_606697822(label, delay);
			this.RpcLogic___RemoveState_606697822(label, delay);
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x000A5490 File Offset: 0x000A3690
		public PlayerVisualState.VisualState GetState(string label)
		{
			return this.visualStates.Find((PlayerVisualState.VisualState x) => x.label == label);
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x000A54C4 File Offset: 0x000A36C4
		public void ClearStates()
		{
			PlayerVisualState.VisualState[] array = this.visualStates.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				if (!(array[i].label == "Visible"))
				{
					this.RemoveState(array[i].label, 0f);
				}
			}
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x000A5514 File Offset: 0x000A3714
		private void UpdateSuspiciousness()
		{
			this.Suspiciousness = 0f;
			if (this.player.Avatar.Anim.IsCrouched)
			{
				this.Suspiciousness += 0.3f;
			}
			if (this.player.Avatar.CurrentEquippable != null)
			{
				this.Suspiciousness += this.player.Avatar.CurrentEquippable.Suspiciousness;
			}
			if (this.player.VelocityCalculator.Velocity.magnitude > PlayerMovement.WalkSpeed)
			{
				this.Suspiciousness += 0.3f * Mathf.InverseLerp(PlayerMovement.WalkSpeed, PlayerMovement.WalkSpeed * PlayerMovement.SprintMultiplier, this.player.VelocityCalculator.Velocity.magnitude);
			}
			this.Suspiciousness = Mathf.Clamp01(this.Suspiciousness);
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x000A5620 File Offset: 0x000A3820
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerVisualStateAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerVisualStateAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_ApplyState_868472085));
			base.RegisterServerRpc(1U, new ServerRpcDelegate(this.RpcReader___Server_RemoveState_606697822));
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x000A566C File Offset: 0x000A386C
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerVisualStateAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerVisualStateAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x000A567F File Offset: 0x000A387F
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x000A5690 File Offset: 0x000A3890
		private void RpcWriter___Server_ApplyState_868472085(string label, PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
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
			writer.WriteString(label);
			writer.Write___ScheduleOne.PlayerScripts.PlayerVisualState/EVisualStateFishNet.Serializing.Generated(state);
			writer.WriteSingle(autoRemoveAfter, AutoPackType.Unpacked);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x000A57B0 File Offset: 0x000A39B0
		public void RpcLogic___ApplyState_868472085(string label, PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
		{
			PlayerVisualState.VisualState visualState = this.GetState(label);
			if (visualState == null)
			{
				visualState = new PlayerVisualState.VisualState();
				visualState.label = label;
				this.visualStates.Add(visualState);
			}
			visualState.state = state;
			if (this.removalRoutinesDict.ContainsKey(label))
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.removalRoutinesDict[label]);
				this.removalRoutinesDict.Remove(label);
			}
			if (autoRemoveAfter > 0f)
			{
				this.RemoveState(label, autoRemoveAfter);
			}
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x000A582C File Offset: 0x000A3A2C
		private void RpcReader___Server_ApplyState_868472085(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string label = PooledReader0.ReadString();
			PlayerVisualState.EVisualState state = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.PlayerScripts.PlayerVisualState/EVisualStateFishNet.Serializing.Generateds(PooledReader0);
			float autoRemoveAfter = PooledReader0.ReadSingle(AutoPackType.Unpacked);
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
			this.RpcLogic___ApplyState_868472085(label, state, autoRemoveAfter);
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x000A58A4 File Offset: 0x000A3AA4
		private void RpcWriter___Server_RemoveState_606697822(string label, float delay = 0f)
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
			writer.WriteString(label);
			writer.WriteSingle(delay, AutoPackType.Unpacked);
			base.SendServerRpc(1U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x000A59B8 File Offset: 0x000A3BB8
		public void RpcLogic___RemoveState_606697822(string label, float delay = 0f)
		{
			PlayerVisualState.<>c__DisplayClass9_0 CS$<>8__locals1 = new PlayerVisualState.<>c__DisplayClass9_0();
			CS$<>8__locals1.delay = delay;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.label = label;
			CS$<>8__locals1.newState = this.GetState(CS$<>8__locals1.label);
			if (CS$<>8__locals1.newState == null)
			{
				return;
			}
			if (CS$<>8__locals1.delay > 0f)
			{
				if (this.removalRoutinesDict.ContainsKey(CS$<>8__locals1.label))
				{
					Singleton<CoroutineService>.Instance.StopCoroutine(this.removalRoutinesDict[CS$<>8__locals1.label]);
					this.removalRoutinesDict.Remove(CS$<>8__locals1.label);
				}
				this.removalRoutinesDict.Add(CS$<>8__locals1.label, Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<RemoveState>g__DelayedRemove|0()));
				return;
			}
			CS$<>8__locals1.<RemoveState>g__Destroy|1();
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x000A5A70 File Offset: 0x000A3C70
		private void RpcReader___Server_RemoveState_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string label = PooledReader0.ReadString();
			float delay = PooledReader0.ReadSingle(AutoPackType.Unpacked);
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
			this.RpcLogic___RemoveState_606697822(label, delay);
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x000A5AD5 File Offset: 0x000A3CD5
		private void dll()
		{
			this.player = base.GetComponent<Player>();
			this.player.Health.onDie.AddListener(new UnityAction(delegate()
			{
				this.ClearStates();
			}));
			this.ApplyState("Visible", PlayerVisualState.EVisualState.Visible, 0f);
		}

		// Token: 0x04001D42 RID: 7490
		public float Suspiciousness;

		// Token: 0x04001D43 RID: 7491
		public List<PlayerVisualState.VisualState> visualStates = new List<PlayerVisualState.VisualState>();

		// Token: 0x04001D44 RID: 7492
		private Player player;

		// Token: 0x04001D45 RID: 7493
		private Dictionary<string, Coroutine> removalRoutinesDict = new Dictionary<string, Coroutine>();

		// Token: 0x04001D46 RID: 7494
		private bool dll_Excuted;

		// Token: 0x04001D47 RID: 7495
		private bool dll_Excuted;

		// Token: 0x02000604 RID: 1540
		public enum EVisualState
		{
			// Token: 0x04001D49 RID: 7497
			Visible,
			// Token: 0x04001D4A RID: 7498
			Suspicious,
			// Token: 0x04001D4B RID: 7499
			DisobeyingCurfew,
			// Token: 0x04001D4C RID: 7500
			Vandalizing,
			// Token: 0x04001D4D RID: 7501
			PettyCrime,
			// Token: 0x04001D4E RID: 7502
			DrugDealing,
			// Token: 0x04001D4F RID: 7503
			SearchedFor,
			// Token: 0x04001D50 RID: 7504
			Wanted,
			// Token: 0x04001D51 RID: 7505
			Pickpocketing,
			// Token: 0x04001D52 RID: 7506
			DischargingWeapon,
			// Token: 0x04001D53 RID: 7507
			Brandishing
		}

		// Token: 0x02000605 RID: 1541
		[Serializable]
		public class VisualState
		{
			// Token: 0x04001D54 RID: 7508
			public PlayerVisualState.EVisualState state;

			// Token: 0x04001D55 RID: 7509
			public string label;

			// Token: 0x04001D56 RID: 7510
			public Action stateDestroyed;
		}
	}
}
