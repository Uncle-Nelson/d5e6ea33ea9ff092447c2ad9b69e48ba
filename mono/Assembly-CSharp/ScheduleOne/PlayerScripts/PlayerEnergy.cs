using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.PlayerScripts.Health;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005F4 RID: 1524
	public class PlayerEnergy : MonoBehaviour
	{
		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x000A1FD9 File Offset: 0x000A01D9
		// (set) Token: 0x06002794 RID: 10132 RVA: 0x000A1FE1 File Offset: 0x000A01E1
		public float CurrentEnergy { get; protected set; } = 100f;

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x000A1FEA File Offset: 0x000A01EA
		// (set) Token: 0x06002796 RID: 10134 RVA: 0x000A1FF2 File Offset: 0x000A01F2
		public int EnergyDrinksConsumed { get; protected set; }

		// Token: 0x06002797 RID: 10135 RVA: 0x000A1FFC File Offset: 0x000A01FC
		protected virtual void Start()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
			Singleton<SleepCanvas>.Instance.onSleepFullyFaded.AddListener(new UnityAction(this.SleepEnd));
			base.GetComponent<PlayerHealth>().onRevive.AddListener(new UnityAction(this.ResetEnergyDrinks));
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x000A2068 File Offset: 0x000A0268
		private void MinPass()
		{
			if (this.DEBUG_DISABLE_ENERGY && (Debug.isDebugBuild || Application.isEditor))
			{
				return;
			}
			if (NetworkSingleton<TimeManager>.Instance.SleepInProgress)
			{
				return;
			}
			float num = -(1f / (this.EnergyDuration_Hours * 60f)) * 100f;
			if (PlayerSingleton<PlayerMovement>.Instance.isSprinting)
			{
				num *= 1.3f;
			}
			this.ChangeEnergy(num);
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x000A20CE File Offset: 0x000A02CE
		private void ChangeEnergy(float change)
		{
			this.SetEnergy(this.CurrentEnergy + change);
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x000A20E0 File Offset: 0x000A02E0
		public void SetEnergy(float newEnergy)
		{
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x000A20ED File Offset: 0x000A02ED
		public void RestoreEnergy()
		{
			this.SetEnergy(100f);
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x000A20FA File Offset: 0x000A02FA
		private void SleepEnd()
		{
			this.ResetEnergyDrinks();
			this.RestoreEnergy();
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x000A2108 File Offset: 0x000A0308
		public void IncrementEnergyDrinks()
		{
			int energyDrinksConsumed = this.EnergyDrinksConsumed;
			this.EnergyDrinksConsumed = energyDrinksConsumed + 1;
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x000A2125 File Offset: 0x000A0325
		private void ResetEnergyDrinks()
		{
			this.EnergyDrinksConsumed = 0;
		}

		// Token: 0x04001CB7 RID: 7351
		public const float CRITICAL_THRESHOLD = 20f;

		// Token: 0x04001CB8 RID: 7352
		public const float MAX_ENERGY = 100f;

		// Token: 0x04001CB9 RID: 7353
		public const float SPRINT_DRAIN_MULTIPLIER = 1.3f;

		// Token: 0x04001CBC RID: 7356
		public bool DEBUG_DISABLE_ENERGY;

		// Token: 0x04001CBD RID: 7357
		[Header("Settings")]
		public float EnergyDuration_Hours = 22f;

		// Token: 0x04001CBE RID: 7358
		public float EnergyRechargeTime_Hours = 6f;

		// Token: 0x04001CBF RID: 7359
		public UnityEvent onEnergyChanged;

		// Token: 0x04001CC0 RID: 7360
		public UnityEvent onEnergyDepleted;
	}
}
