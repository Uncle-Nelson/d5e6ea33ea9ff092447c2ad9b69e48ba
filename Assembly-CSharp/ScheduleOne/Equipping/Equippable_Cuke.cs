using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000915 RID: 2325
	public class Equippable_Cuke : Equippable_Viewmodel
	{
		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06003EF2 RID: 16114 RVA: 0x00109B89 File Offset: 0x00107D89
		// (set) Token: 0x06003EF3 RID: 16115 RVA: 0x00109B91 File Offset: 0x00107D91
		public bool IsDrinking { get; protected set; }

		// Token: 0x06003EF4 RID: 16116 RVA: 0x00109B9A File Offset: 0x00107D9A
		protected override void Update()
		{
			base.Update();
			if (this.IsDrinking)
			{
				return;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick) && !GameInput.IsTyping && PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount == 0)
			{
				this.Drink();
			}
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x00109BCC File Offset: 0x00107DCC
		public void Drink()
		{
			this.IsDrinking = true;
			base.StartCoroutine(this.<Drink>g__DrinkRoutine|16_0());
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x00109BE4 File Offset: 0x00107DE4
		public void ApplyEffects()
		{
			float num = Mathf.Pow(this.ConsecutiveReduction, (float)Player.Local.Energy.EnergyDrinksConsumed);
			float num2 = Mathf.Clamp(this.BaseEnergyGain * num, this.MinEnergyGain, this.BaseEnergyGain);
			Player.Local.Energy.SetEnergy(Player.Local.Energy.CurrentEnergy + num2);
			PlayerSingleton<PlayerMovement>.Instance.SetStamina(PlayerMovement.StaminaReserveMax, true);
			if (this.HealthGain > 0f)
			{
				Player.Local.Health.RecoverHealth(this.HealthGain);
			}
			Player.Local.Energy.IncrementEnergyDrinks();
			if (this.ClearDrugEffects && Player.Local.ConsumedProduct != null)
			{
				Player.Local.ClearProduct();
			}
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x00109CDA File Offset: 0x00107EDA
		[CompilerGenerated]
		private IEnumerator <Drink>g__DrinkRoutine|16_0()
		{
			this.OpenAnim.Play();
			this.DrinkAnim.Play();
			this.OpenSound.Play();
			this.SlurpSound.Play();
			yield return new WaitForSeconds(this.AnimationDuration);
			this.ApplyEffects();
			this.TrashPrefab = NetworkSingleton<TrashManager>.Instance.CreateTrashItem(this.TrashPrefab.ID, PlayerSingleton<PlayerCamera>.Instance.transform.position - PlayerSingleton<PlayerCamera>.Instance.transform.up * 0.3f, PlayerSingleton<PlayerCamera>.Instance.transform.rotation, PlayerSingleton<PlayerMovement>.Instance.Controller.velocity + (PlayerSingleton<PlayerCamera>.Instance.transform.forward + PlayerSingleton<PlayerCamera>.Instance.transform.up * 0.25f) * 4f, "", false);
			this.itemInstance.ChangeQuantity(-1);
			if (this.itemInstance.Quantity > 0)
			{
				PlayerSingleton<PlayerInventory>.Instance.Reequip();
			}
			yield break;
		}

		// Token: 0x04002D25 RID: 11557
		[Header("Settings")]
		public float BaseEnergyGain = 100f;

		// Token: 0x04002D26 RID: 11558
		public float MinEnergyGain = 2.5f;

		// Token: 0x04002D27 RID: 11559
		public float ConsecutiveReduction = 0.5f;

		// Token: 0x04002D28 RID: 11560
		public float HealthGain;

		// Token: 0x04002D29 RID: 11561
		public float AnimationDuration = 2f;

		// Token: 0x04002D2A RID: 11562
		public bool ClearDrugEffects;

		// Token: 0x04002D2B RID: 11563
		[Header("References")]
		public Animation OpenAnim;

		// Token: 0x04002D2C RID: 11564
		public Animation DrinkAnim;

		// Token: 0x04002D2D RID: 11565
		public AudioSourceController OpenSound;

		// Token: 0x04002D2E RID: 11566
		public AudioSourceController SlurpSound;

		// Token: 0x04002D2F RID: 11567
		public TrashItem TrashPrefab;
	}
}
