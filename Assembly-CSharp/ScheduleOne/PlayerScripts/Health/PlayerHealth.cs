using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts.Health
{
	// Token: 0x0200060B RID: 1547
	public class PlayerHealth : NetworkBehaviour
	{
		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06002866 RID: 10342 RVA: 0x000A66A2 File Offset: 0x000A48A2
		// (set) Token: 0x06002867 RID: 10343 RVA: 0x000A66AA File Offset: 0x000A48AA
		public bool IsAlive { get; protected set; } = true;

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x000A66B3 File Offset: 0x000A48B3
		// (set) Token: 0x06002869 RID: 10345 RVA: 0x000A66BB File Offset: 0x000A48BB
		public float CurrentHealth { get; protected set; } = 100f;

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x000A66C4 File Offset: 0x000A48C4
		// (set) Token: 0x0600286B RID: 10347 RVA: 0x000A66CC File Offset: 0x000A48CC
		public float TimeSinceLastDamage { get; protected set; }

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600286C RID: 10348 RVA: 0x000A66D5 File Offset: 0x000A48D5
		public bool CanTakeDamage
		{
			get
			{
				return this.IsAlive && !Player.Local.IsArrested && !Player.Local.IsUnconscious;
			}
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x000A66FA File Offset: 0x000A48FA
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.PlayerScripts.Health.PlayerHealth_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x000A6710 File Offset: 0x000A4910
		private void Start()
		{
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance2.onMinutePass = (Action)Delegate.Combine(instance2.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x000A676C File Offset: 0x000A496C
		[ObserversRpc]
		public void TakeDamage(float damage, bool flinch = true, bool playBloodMist = true)
		{
			this.RpcWriter___Observers_TakeDamage_3505310624(damage, flinch, playBloodMist);
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x000A678B File Offset: 0x000A498B
		private void Update()
		{
			this.TimeSinceLastDamage += Time.deltaTime;
			if (this.IsAlive && this.AfflictedWithLethalEffect)
			{
				this.TakeDamage(15f * Time.deltaTime, false, false);
			}
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x000A67C2 File Offset: 0x000A49C2
		private void MinPass()
		{
			if (this.IsAlive && this.CurrentHealth < 100f && this.TimeSinceLastDamage > 30f)
			{
				this.RecoverHealth(0.5f);
			}
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x000A67F1 File Offset: 0x000A49F1
		public void SetAfflictedWithLethalEffect(bool value)
		{
			this.AfflictedWithLethalEffect = value;
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x000A67FC File Offset: 0x000A49FC
		public void RecoverHealth(float recovery)
		{
			if (this.CurrentHealth == 0f)
			{
				Console.LogWarning("RecoverHealth called on dead player. Use Revive() instead.", null);
				return;
			}
			this.CurrentHealth = Mathf.Clamp(this.CurrentHealth + recovery, 0f, 100f);
			if (this.onHealthChanged != null)
			{
				this.onHealthChanged.Invoke(this.CurrentHealth);
			}
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x000A6858 File Offset: 0x000A4A58
		public void SetHealth(float health)
		{
			this.CurrentHealth = Mathf.Clamp(health, 0f, 100f);
			if (this.onHealthChanged != null)
			{
				this.onHealthChanged.Invoke(this.CurrentHealth);
			}
			if (this.CurrentHealth <= 0f)
			{
				this.SendDie();
			}
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x000A68A7 File Offset: 0x000A4AA7
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendDie()
		{
			this.RpcWriter___Server_SendDie_2166136261();
			this.RpcLogic___SendDie_2166136261();
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x000A68B8 File Offset: 0x000A4AB8
		[ObserversRpc(RunLocally = true)]
		public void Die()
		{
			this.RpcWriter___Observers_Die_2166136261();
			this.RpcLogic___Die_2166136261();
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x000A68D1 File Offset: 0x000A4AD1
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendRevive(Vector3 position, Quaternion rotation)
		{
			this.RpcWriter___Server_SendRevive_3848837105(position, rotation);
			this.RpcLogic___SendRevive_3848837105(position, rotation);
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x000A68F0 File Offset: 0x000A4AF0
		[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public void Revive(Vector3 position, Quaternion rotation)
		{
			this.RpcWriter___Observers_Revive_3848837105(position, rotation);
			this.RpcLogic___Revive_3848837105(position, rotation);
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x000A6919 File Offset: 0x000A4B19
		[ObserversRpc]
		public void PlayBloodMist()
		{
			this.RpcWriter___Observers_PlayBloodMist_2166136261();
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x000A6948 File Offset: 0x000A4B48
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted = true;
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_TakeDamage_3505310624));
			base.RegisterServerRpc(1U, new ServerRpcDelegate(this.RpcReader___Server_SendDie_2166136261));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_Die_2166136261));
			base.RegisterServerRpc(3U, new ServerRpcDelegate(this.RpcReader___Server_SendRevive_3848837105));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_Revive_3848837105));
			base.RegisterObserversRpc(5U, new ClientRpcDelegate(this.RpcReader___Observers_PlayBloodMist_2166136261));
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x000A69F0 File Offset: 0x000A4BF0
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x000A6A03 File Offset: 0x000A4C03
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x000A6A14 File Offset: 0x000A4C14
		private void RpcWriter___Observers_TakeDamage_3505310624(float damage, bool flinch = true, bool playBloodMist = true)
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
			writer.WriteSingle(damage, AutoPackType.Unpacked);
			writer.WriteBoolean(flinch);
			writer.WriteBoolean(playBloodMist);
			base.SendObserversRpc(0U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x000A6AEC File Offset: 0x000A4CEC
		public void RpcLogic___TakeDamage_3505310624(float damage, bool flinch = true, bool playBloodMist = true)
		{
			if (!this.IsAlive)
			{
				return;
			}
			if (!this.CanTakeDamage)
			{
				Console.LogWarning("Player cannot take damage right now.", null);
				return;
			}
			this.CurrentHealth = Mathf.Clamp(this.CurrentHealth - damage, 0f, 100f);
			Console.Log(damage.ToString() + " damange taken. New health: " + this.CurrentHealth.ToString(), null);
			this.TimeSinceLastDamage = 0f;
			if (this.onHealthChanged != null)
			{
				this.onHealthChanged.Invoke(this.CurrentHealth);
			}
			if (this.Player.IsOwner)
			{
				if (flinch && PlayerSingleton<PlayerCamera>.InstanceExists)
				{
					PlayerSingleton<PlayerCamera>.Instance.JoltCamera();
				}
				if (this.CurrentHealth <= 0f)
				{
					this.SendDie();
				}
			}
			if (playBloodMist)
			{
				this.PlayBloodMist();
			}
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x000A6BBC File Offset: 0x000A4DBC
		private void RpcReader___Observers_TakeDamage_3505310624(PooledReader PooledReader0, Channel channel)
		{
			float damage = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			bool flinch = PooledReader0.ReadBoolean();
			bool playBloodMist = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___TakeDamage_3505310624(damage, flinch, playBloodMist);
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x000A6C14 File Offset: 0x000A4E14
		private void RpcWriter___Server_SendDie_2166136261()
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
			base.SendServerRpc(1U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x000A6CAE File Offset: 0x000A4EAE
		public void RpcLogic___SendDie_2166136261()
		{
			this.Die();
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x000A6CB8 File Offset: 0x000A4EB8
		private void RpcReader___Server_SendDie_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendDie_2166136261();
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x000A6CE8 File Offset: 0x000A4EE8
		private void RpcWriter___Observers_Die_2166136261()
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

		// Token: 0x06002886 RID: 10374 RVA: 0x000A6D94 File Offset: 0x000A4F94
		public void RpcLogic___Die_2166136261()
		{
			if (!this.IsAlive)
			{
				Console.LogWarning("Already dead!", null);
				return;
			}
			this.IsAlive = false;
			Player player = this.Player;
			Debug.Log(((player != null) ? player.ToString() : null) + " died.");
			if (this.onDie != null)
			{
				this.onDie.Invoke();
			}
			Debug.Log("Dead!");
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x000A6DFC File Offset: 0x000A4FFC
		private void RpcReader___Observers_Die_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Die_2166136261();
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x000A6E28 File Offset: 0x000A5028
		private void RpcWriter___Server_SendRevive_3848837105(Vector3 position, Quaternion rotation)
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
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			base.SendServerRpc(3U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x000A6EE1 File Offset: 0x000A50E1
		public void RpcLogic___SendRevive_3848837105(Vector3 position, Quaternion rotation)
		{
			this.Revive(position, rotation);
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x000A6EEC File Offset: 0x000A50EC
		private void RpcReader___Server_SendRevive_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendRevive_3848837105(position, rotation);
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x000A6F40 File Offset: 0x000A5140
		private void RpcWriter___Observers_Revive_3848837105(Vector3 position, Quaternion rotation)
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
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			base.SendObserversRpc(4U, writer, channel, DataOrderType.Default, false, false, true);
			writer.Store();
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x000A7008 File Offset: 0x000A5208
		public void RpcLogic___Revive_3848837105(Vector3 position, Quaternion rotation)
		{
			if (this.IsAlive)
			{
				Console.LogWarning("Revive called on living player. Use RecoverHealth() instead.", null);
				return;
			}
			this.CurrentHealth = 100f;
			this.IsAlive = true;
			if (this.onHealthChanged != null)
			{
				this.onHealthChanged.Invoke(this.CurrentHealth);
			}
			if (this.onRevive != null)
			{
				this.onRevive.Invoke();
			}
			if (base.IsOwner)
			{
				Singleton<HUD>.Instance.canvas.enabled = true;
				Player.Local.Energy.RestoreEnergy();
				PlayerSingleton<PlayerMovement>.Instance.Teleport(position);
				Player.Local.transform.rotation = rotation;
				PlayerSingleton<PlayerCamera>.Instance.ResetRotation();
			}
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x000A70B4 File Offset: 0x000A52B4
		private void RpcReader___Observers_Revive_3848837105(PooledReader PooledReader0, Channel channel)
		{
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Revive_3848837105(position, rotation);
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x000A7108 File Offset: 0x000A5308
		private void RpcWriter___Observers_PlayBloodMist_2166136261()
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

		// Token: 0x0600288F RID: 10383 RVA: 0x000A71B1 File Offset: 0x000A53B1
		public void RpcLogic___PlayBloodMist_2166136261()
		{
			LayerUtility.SetLayerRecursively(this.BloodParticles.gameObject, LayerMask.NameToLayer("Default"));
			this.BloodParticles.Play();
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x000A71D8 File Offset: 0x000A53D8
		private void RpcReader___Observers_PlayBloodMist_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___PlayBloodMist_2166136261();
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x000A71F8 File Offset: 0x000A53F8
		private void dll()
		{
			Singleton<SleepCanvas>.Instance.onSleepFullyFaded.AddListener(new UnityAction(delegate()
			{
				this.SetHealth(100f);
			}));
		}

		// Token: 0x04001D93 RID: 7571
		public const float MAX_HEALTH = 100f;

		// Token: 0x04001D94 RID: 7572
		public const float HEALTH_RECOVERY_PER_MINUTE = 0.5f;

		// Token: 0x04001D98 RID: 7576
		[Header("References")]
		public Player Player;

		// Token: 0x04001D99 RID: 7577
		public ParticleSystem BloodParticles;

		// Token: 0x04001D9A RID: 7578
		public UnityEvent<float> onHealthChanged;

		// Token: 0x04001D9B RID: 7579
		public UnityEvent onDie;

		// Token: 0x04001D9C RID: 7580
		public UnityEvent onRevive;

		// Token: 0x04001D9D RID: 7581
		private bool AfflictedWithLethalEffect;

		// Token: 0x04001D9E RID: 7582
		private bool dll_Excuted;

		// Token: 0x04001D9F RID: 7583
		private bool dll_Excuted;
	}
}
