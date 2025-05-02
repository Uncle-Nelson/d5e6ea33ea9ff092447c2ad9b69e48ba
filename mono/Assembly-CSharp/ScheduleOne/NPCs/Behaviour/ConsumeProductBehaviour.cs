using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x020004EB RID: 1259
	public class ConsumeProductBehaviour : Behaviour
	{
		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x00076CDE File Offset: 0x00074EDE
		// (set) Token: 0x06001C96 RID: 7318 RVA: 0x00076CE6 File Offset: 0x00074EE6
		public ProductItemInstance ConsumedProduct { get; private set; }

		// Token: 0x06001C97 RID: 7319 RVA: 0x00076CF0 File Offset: 0x00074EF0
		protected virtual void Start()
		{
			ScheduleOne.GameTime.TimeManager.onSleepEnd = (Action<int>)Delegate.Remove(ScheduleOne.GameTime.TimeManager.onSleepEnd, new Action<int>(this.DayPass));
			ScheduleOne.GameTime.TimeManager.onSleepEnd = (Action<int>)Delegate.Combine(ScheduleOne.GameTime.TimeManager.onSleepEnd, new Action<int>(this.DayPass));
			if (this.TestProduct != null && Application.isEditor)
			{
				this.product = (this.TestProduct.GetDefaultInstance(1) as ProductItemInstance);
			}
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00076D69 File Offset: 0x00074F69
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendProduct(ProductItemInstance _product)
		{
			this.RpcWriter___Server_SendProduct_2622925554(_product);
			this.RpcLogic___SendProduct_2622925554(_product);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00076D7F File Offset: 0x00074F7F
		[ObserversRpc(RunLocally = true)]
		public void SetProduct(ProductItemInstance _product)
		{
			this.RpcWriter___Observers_SetProduct_2622925554(_product);
			this.RpcLogic___SetProduct_2622925554(_product);
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00076D95 File Offset: 0x00074F95
		[ObserversRpc(RunLocally = true)]
		public void ClearEffects()
		{
			this.RpcWriter___Observers_ClearEffects_2166136261();
			this.RpcLogic___ClearEffects_2166136261();
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00076DA3 File Offset: 0x00074FA3
		protected override void Begin()
		{
			base.Begin();
			this.TryConsume();
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00076DB1 File Offset: 0x00074FB1
		protected override void Resume()
		{
			base.Resume();
			this.TryConsume();
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00076DC0 File Offset: 0x00074FC0
		private void TryConsume()
		{
			if (this.product == null)
			{
				Console.LogError("No product to consume", null);
				this.Disable();
				return;
			}
			switch ((this.product.Definition as ProductDefinition).DrugType)
			{
			case EDrugType.Marijuana:
				this.ConsumeWeed();
				return;
			case EDrugType.Methamphetamine:
				this.ConsumeMeth();
				return;
			case EDrugType.Cocaine:
				this.ConsumeCocaine();
				return;
			default:
				return;
			}
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00076E24 File Offset: 0x00075024
		public override void Disable()
		{
			base.Disable();
			this.Clear();
			this.End();
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00076E38 File Offset: 0x00075038
		protected override void End()
		{
			base.End();
			if (this.consumeRoutine != null)
			{
				base.StopCoroutine(this.consumeRoutine);
				this.consumeRoutine = null;
			}
			base.Npc.SetEquippable_Return(string.Empty);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00076E6C File Offset: 0x0007506C
		private void ConsumeWeed()
		{
			this.consumeRoutine = base.StartCoroutine(this.<ConsumeWeed>g__ConsumeWeedRoutine|23_0());
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00076E80 File Offset: 0x00075080
		private void ConsumeMeth()
		{
			this.consumeRoutine = base.StartCoroutine(this.<ConsumeMeth>g__ConsumeWeedRoutine|24_0());
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00076E94 File Offset: 0x00075094
		private void ConsumeCocaine()
		{
			this.consumeRoutine = base.StartCoroutine(this.<ConsumeCocaine>g__ConsumeWeedRoutine|25_0());
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00076EA8 File Offset: 0x000750A8
		[ObserversRpc]
		private void ApplyEffects()
		{
			this.RpcWriter___Observers_ApplyEffects_2166136261();
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00076EB0 File Offset: 0x000750B0
		private void Clear()
		{
			base.Npc.Avatar.Anim.SetBool("Smoking", false);
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00076ECD File Offset: 0x000750CD
		private void DayPass(int minsSlept)
		{
			if (this.ConsumedProduct != null)
			{
				this.ClearEffects();
			}
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00076EDD File Offset: 0x000750DD
		[CompilerGenerated]
		private IEnumerator <ConsumeWeed>g__ConsumeWeedRoutine|23_0()
		{
			base.Npc.SetEquippable_Return(this.JointPrefab.AssetPath);
			base.Npc.Avatar.Anim.SetBool("Smoking", true);
			this.WeedConsumeSound.Play();
			yield return new WaitForSeconds(3f);
			this.SmokeExhaleParticles.Play();
			yield return new WaitForSeconds(1.5f);
			base.Npc.Avatar.Anim.SetBool("Smoking", false);
			if (InstanceFinder.IsServer)
			{
				this.ApplyEffects();
				base.Disable_Networked(null);
			}
			if (this.onConsumeDone != null)
			{
				this.onConsumeDone.Invoke();
			}
			yield break;
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00076EEC File Offset: 0x000750EC
		[CompilerGenerated]
		private IEnumerator <ConsumeMeth>g__ConsumeWeedRoutine|24_0()
		{
			base.Npc.SetEquippable_Return(this.PipePrefab.AssetPath);
			base.Npc.Avatar.Anim.SetBool("Smoking", true);
			this.MethConsumeSound.Play();
			yield return new WaitForSeconds(3f);
			this.SmokeExhaleParticles.Play();
			yield return new WaitForSeconds(1.5f);
			base.Npc.Avatar.Anim.SetBool("Smoking", false);
			if (InstanceFinder.IsServer)
			{
				this.ApplyEffects();
				base.Disable_Networked(null);
			}
			if (this.onConsumeDone != null)
			{
				this.onConsumeDone.Invoke();
			}
			yield break;
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00076EFB File Offset: 0x000750FB
		[CompilerGenerated]
		private IEnumerator <ConsumeCocaine>g__ConsumeWeedRoutine|25_0()
		{
			base.Npc.Avatar.Anim.SetTrigger("Snort");
			yield return new WaitForSeconds(0.8f);
			this.SnortSound.Play();
			yield return new WaitForSeconds(1f);
			if (InstanceFinder.IsServer)
			{
				this.ApplyEffects();
				base.Disable_Networked(null);
			}
			if (this.onConsumeDone != null)
			{
				this.onConsumeDone.Invoke();
			}
			yield break;
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00076F0C File Offset: 0x0007510C
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.ConsumeProductBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.ConsumeProductBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(15U, new ServerRpcDelegate(this.RpcReader___Server_SendProduct_2622925554));
			base.RegisterObserversRpc(16U, new ClientRpcDelegate(this.RpcReader___Observers_SetProduct_2622925554));
			base.RegisterObserversRpc(17U, new ClientRpcDelegate(this.RpcReader___Observers_ClearEffects_2166136261));
			base.RegisterObserversRpc(18U, new ClientRpcDelegate(this.RpcReader___Observers_ApplyEffects_2166136261));
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00076F8C File Offset: 0x0007518C
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.ConsumeProductBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.ConsumeProductBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00076FA5 File Offset: 0x000751A5
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00076FB4 File Offset: 0x000751B4
		private void RpcWriter___Server_SendProduct_2622925554(ProductItemInstance _product)
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
			writer.WriteProductItemInstance(_product);
			base.SendServerRpc(15U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x0007705B File Offset: 0x0007525B
		public void RpcLogic___SendProduct_2622925554(ProductItemInstance _product)
		{
			this.SetProduct(_product);
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x00077064 File Offset: 0x00075264
		private void RpcReader___Server_SendProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			ProductItemInstance productItemInstance = PooledReader0.ReadProductItemInstance();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendProduct_2622925554(productItemInstance);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x000770A4 File Offset: 0x000752A4
		private void RpcWriter___Observers_SetProduct_2622925554(ProductItemInstance _product)
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
			writer.WriteProductItemInstance(_product);
			base.SendObserversRpc(16U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x0007715A File Offset: 0x0007535A
		public void RpcLogic___SetProduct_2622925554(ProductItemInstance _product)
		{
			this.product = _product;
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x00077164 File Offset: 0x00075364
		private void RpcReader___Observers_SetProduct_2622925554(PooledReader PooledReader0, Channel channel)
		{
			ProductItemInstance productItemInstance = PooledReader0.ReadProductItemInstance();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetProduct_2622925554(productItemInstance);
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x000771A0 File Offset: 0x000753A0
		private void RpcWriter___Observers_ClearEffects_2166136261()
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
			base.SendObserversRpc(17U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00077249 File Offset: 0x00075449
		public void RpcLogic___ClearEffects_2166136261()
		{
			if (this.ConsumedProduct == null)
			{
				return;
			}
			this.ConsumedProduct.ClearEffectsFromNPC(base.Npc);
			this.ConsumedProduct = null;
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0007726C File Offset: 0x0007546C
		private void RpcReader___Observers_ClearEffects_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ClearEffects_2166136261();
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00077298 File Offset: 0x00075498
		private void RpcWriter___Observers_ApplyEffects_2166136261()
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
			base.SendObserversRpc(18U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00077341 File Offset: 0x00075541
		private void RpcLogic___ApplyEffects_2166136261()
		{
			if (this.ConsumedProduct != null)
			{
				this.ClearEffects();
			}
			this.ConsumedProduct = this.product;
			if (this.product != null)
			{
				this.product.ApplyEffectsToNPC(base.Npc);
			}
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x00077378 File Offset: 0x00075578
		private void RpcReader___Observers_ApplyEffects_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ApplyEffects_2166136261();
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00077398 File Offset: 0x00075598
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001769 RID: 5993
		public AvatarEquippable JointPrefab;

		// Token: 0x0400176A RID: 5994
		public AvatarEquippable PipePrefab;

		// Token: 0x0400176C RID: 5996
		private ProductItemInstance product;

		// Token: 0x0400176D RID: 5997
		private Coroutine consumeRoutine;

		// Token: 0x0400176E RID: 5998
		public AudioSourceController WeedConsumeSound;

		// Token: 0x0400176F RID: 5999
		public AudioSourceController MethConsumeSound;

		// Token: 0x04001770 RID: 6000
		public AudioSourceController SnortSound;

		// Token: 0x04001771 RID: 6001
		public ParticleSystem SmokeExhaleParticles;

		// Token: 0x04001772 RID: 6002
		[Header("Debug")]
		public ProductDefinition TestProduct;

		// Token: 0x04001773 RID: 6003
		public UnityEvent onConsumeDone;

		// Token: 0x04001774 RID: 6004
		private bool dll_Excuted;

		// Token: 0x04001775 RID: 6005
		private bool dll_Excuted;
	}
}
