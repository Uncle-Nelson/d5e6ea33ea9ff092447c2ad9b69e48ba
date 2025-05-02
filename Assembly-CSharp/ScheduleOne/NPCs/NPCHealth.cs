using System;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence.Datas;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x0200045A RID: 1114
	[RequireComponent(typeof(NPCHealth))]
	[DisallowMultipleComponent]
	public class NPCHealth : NetworkBehaviour
	{
		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x00065880 File Offset: 0x00063A80
		// (set) Token: 0x06001702 RID: 5890 RVA: 0x00065888 File Offset: 0x00063A88
		public float Health
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<Health>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.sync___set_value_<Health>k__BackingField(value, true);
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x00065892 File Offset: 0x00063A92
		// (set) Token: 0x06001704 RID: 5892 RVA: 0x0006589A File Offset: 0x00063A9A
		public bool IsDead { get; private set; }

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x000658A3 File Offset: 0x00063AA3
		// (set) Token: 0x06001706 RID: 5894 RVA: 0x000658AB File Offset: 0x00063AAB
		public bool IsKnockedOut { get; private set; }

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x000658B4 File Offset: 0x00063AB4
		// (set) Token: 0x06001708 RID: 5896 RVA: 0x000658BC File Offset: 0x00063ABC
		public int DaysPassedSinceDeath { get; private set; }

		// Token: 0x06001709 RID: 5897 RVA: 0x000658C8 File Offset: 0x00063AC8
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.NPCHealth_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x000658E7 File Offset: 0x00063AE7
		private void OnDestroy()
		{
			ScheduleOne.GameTime.TimeManager.onSleepStart = (Action)Delegate.Remove(ScheduleOne.GameTime.TimeManager.onSleepStart, new Action(this.SleepStart));
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x00065909 File Offset: 0x00063B09
		public override void OnStartServer()
		{
			base.OnStartServer();
			this.Health = this.MaxHealth;
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x0006591D File Offset: 0x00063B1D
		public void Load(NPCHealthData healthData)
		{
			this.Health = healthData.Health;
			this.DaysPassedSinceDeath = healthData.DaysPassedSinceDeath;
			if (this.IsDead)
			{
				this.Die();
				return;
			}
			if (this.Health == 0f)
			{
				this.KnockOut();
			}
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00065959 File Offset: 0x00063B59
		private void Update()
		{
			if (!this.IsDead && this.AfflictedWithLethalEffect)
			{
				this.TakeDamage(15f * Time.deltaTime, true);
			}
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x0006597D File Offset: 0x00063B7D
		public void SetAfflictedWithLethalEffect(bool value)
		{
			this.AfflictedWithLethalEffect = value;
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00065988 File Offset: 0x00063B88
		public void SleepStart()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.npc.IsConscious)
			{
				Console.Log(this.npc.fullName + " Dead: " + this.IsDead.ToString(), null);
				if (this.IsDead)
				{
					int daysPassedSinceDeath = this.DaysPassedSinceDeath;
					this.DaysPassedSinceDeath = daysPassedSinceDeath + 1;
					if (this.DaysPassedSinceDeath >= 3 || this.npc.IsImportant)
					{
						this.Revive();
					}
				}
				else
				{
					this.Revive();
				}
			}
			if (this.npc.IsConscious)
			{
				this.Health = this.MaxHealth;
			}
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00065A28 File Offset: 0x00063C28
		public void TakeDamage(float damage, bool isLethal = true)
		{
			if (this.IsDead)
			{
				return;
			}
			Console.Log(this.npc.fullName + " has taken " + damage.ToString() + " damage.", null);
			this.Health -= damage;
			if (this.Health <= 0f)
			{
				this.Health = 0f;
				if (!this.Invincible)
				{
					if (isLethal)
					{
						if (!this.IsDead)
						{
							this.Die();
							return;
						}
					}
					else if (!this.IsKnockedOut)
					{
						this.KnockOut();
					}
				}
			}
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00065AB4 File Offset: 0x00063CB4
		public virtual void Die()
		{
			if (this.Invincible)
			{
				return;
			}
			Console.Log(this.npc.fullName + " has died.", null);
			this.IsDead = true;
			this.npc.behaviour.DeadBehaviour.Enable_Networked(null);
			if (this.onDie != null)
			{
				this.onDie.Invoke();
			}
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00065B18 File Offset: 0x00063D18
		public virtual void KnockOut()
		{
			if (this.Invincible)
			{
				return;
			}
			Console.Log(this.npc.fullName + " has been knocked out.", null);
			this.IsKnockedOut = true;
			this.npc.behaviour.UnconsciousBehaviour.Enable_Networked(null);
			if (this.onKnockedOut != null)
			{
				this.onKnockedOut.Invoke();
			}
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00065B7C File Offset: 0x00063D7C
		public virtual void Revive()
		{
			Console.Log(this.npc.fullName + " has been revived.", null);
			this.IsDead = false;
			this.IsKnockedOut = false;
			this.Health = this.MaxHealth;
			this.npc.behaviour.DeadBehaviour.SendDisable();
			this.npc.behaviour.UnconsciousBehaviour.SendDisable();
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x00065BFC File Offset: 0x00063DFC
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<Health>k__BackingField = new SyncVar<float>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<Health>k__BackingField);
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.NPCs.NPCHealth));
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00065C57 File Offset: 0x00063E57
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<Health>k__BackingField.SetRegistered();
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00065C75 File Offset: 0x00063E75
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x00065C83 File Offset: 0x00063E83
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x00065C8B File Offset: 0x00063E8B
		public float SyncAccessor_<Health>k__BackingField
		{
			get
			{
				return this.<Health>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<Health>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<Health>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00065CC8 File Offset: 0x00063EC8
		public virtual bool NPCHealth(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 != 0U)
			{
				return false;
			}
			if (PooledReader0 == null)
			{
				this.sync___set_value_<Health>k__BackingField(this.syncVar___<Health>k__BackingField.GetValue(true), true);
				return true;
			}
			float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			this.sync___set_value_<Health>k__BackingField(value, Boolean2);
			return true;
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00065D20 File Offset: 0x00063F20
		protected virtual void dll()
		{
			this.npc = base.GetComponent<NPC>();
			ScheduleOne.GameTime.TimeManager.onSleepStart = (Action)Delegate.Remove(ScheduleOne.GameTime.TimeManager.onSleepStart, new Action(this.SleepStart));
			ScheduleOne.GameTime.TimeManager.onSleepStart = (Action)Delegate.Combine(ScheduleOne.GameTime.TimeManager.onSleepStart, new Action(this.SleepStart));
		}

		// Token: 0x040014F3 RID: 5363
		public const int REVIVE_DAYS = 3;

		// Token: 0x040014F8 RID: 5368
		[Header("Settings")]
		public bool Invincible;

		// Token: 0x040014F9 RID: 5369
		public float MaxHealth = 100f;

		// Token: 0x040014FA RID: 5370
		private NPC npc;

		// Token: 0x040014FB RID: 5371
		public UnityEvent onDie;

		// Token: 0x040014FC RID: 5372
		public UnityEvent onKnockedOut;

		// Token: 0x040014FD RID: 5373
		private bool AfflictedWithLethalEffect;

		// Token: 0x040014FE RID: 5374
		public SyncVar<float> syncVar___<Health>k__BackingField;

		// Token: 0x040014FF RID: 5375
		private bool dll_Excuted;

		// Token: 0x04001500 RID: 5376
		private bool dll_Excuted;
	}
}
