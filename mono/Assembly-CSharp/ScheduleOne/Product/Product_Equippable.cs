using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Product
{
	// Token: 0x020008FF RID: 2303
	public class Product_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06003E9D RID: 16029 RVA: 0x0010853C File Offset: 0x0010673C
		public override void Equip(ItemInstance item)
		{
			base.Equip(item);
			ProductItemInstance productItemInstance = item as ProductItemInstance;
			this.productAmount = productItemInstance.Amount;
			if (this.Consumable && this.productAmount == 1)
			{
				Singleton<InputPromptsCanvas>.Instance.LoadModule("consumable");
				Singleton<InputPromptsCanvas>.Instance.currentModule.gameObject.GetComponentsInChildren<Transform>().FirstOrDefault((Transform c) => c.gameObject.name == "Label").GetComponent<TextMeshProUGUI>().text = "(Hold) " + this.ConsumeDescription;
			}
			productItemInstance.SetupPackagingVisuals(this.Visuals);
			if (this.ModelContainer == null)
			{
				Console.LogWarning("Model container not set for equippable product: " + item.Name, null);
				this.ModelContainer = base.transform.GetChild(0);
			}
			this.defaultModelPosition = this.ModelContainer.localPosition;
		}

		// Token: 0x06003E9E RID: 16030 RVA: 0x00108628 File Offset: 0x00106828
		public override void Unequip()
		{
			if (this.Consumable)
			{
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			}
			if (base.transform.IsChildOf(Player.Local.transform))
			{
				if (!string.IsNullOrEmpty(this.ConsumeAnimationTrigger))
				{
					Player.Local.SendAnimationTrigger(this.ConsumeAnimationTrigger);
				}
				else if (!string.IsNullOrEmpty(this.ConsumeAnimationBool))
				{
					Player.Local.SendAnimationBool(this.ConsumeAnimationBool, false);
				}
			}
			if (this.consumingInProgress)
			{
				base.StopCoroutine(this.consumeRoutine);
			}
			base.Unequip();
		}

		// Token: 0x06003E9F RID: 16031 RVA: 0x001086B8 File Offset: 0x001068B8
		protected override void Update()
		{
			base.Update();
			Vector3 b = this.defaultModelPosition;
			if (this.Consumable && !this.consumingInProgress && GameInput.GetButton(GameInput.ButtonCode.PrimaryClick) && this.productAmount == 1 && !Singleton<PauseMenu>.Instance.IsPaused)
			{
				if (this.consumeTime == 0f && this.onConsumeInputStart != null)
				{
					this.onConsumeInputStart.Invoke();
				}
				this.consumeTime += Time.deltaTime;
				Singleton<HUD>.Instance.ShowRadialIndicator(this.consumeTime / this.ConsumeTime);
				if (this.consumeTime >= this.ConsumeTime)
				{
					this.Consume();
					if (this.onConsumeInputComplete != null)
					{
						this.onConsumeInputComplete.Invoke();
					}
				}
			}
			else
			{
				if (this.consumeTime > 0f && this.onConsumeInputCancel != null && !this.consumingInProgress)
				{
					this.onConsumeInputCancel.Invoke();
					if (base.transform.IsChildOf(Player.Local.transform) && !string.IsNullOrEmpty(this.ConsumeAnimationBool))
					{
						Player.Local.SendAnimationBool(this.ConsumeAnimationBool, false);
					}
				}
				this.consumeTime = 0f;
			}
			if (this.consumeTime > 0f || this.consumingInProgress)
			{
				b = this.defaultModelPosition - this.ModelContainer.transform.parent.InverseTransformDirection(PlayerSingleton<PlayerCamera>.Instance.transform.up) * 0.25f;
			}
			this.ModelContainer.transform.localPosition = Vector3.Lerp(this.ModelContainer.transform.localPosition, b, Time.deltaTime * 6f);
		}

		// Token: 0x06003EA0 RID: 16032 RVA: 0x00108868 File Offset: 0x00106A68
		protected virtual void Consume()
		{
			this.consumingInProgress = true;
			if (base.transform.IsChildOf(Player.Local.transform))
			{
				if (!string.IsNullOrEmpty(this.ConsumeAnimationTrigger))
				{
					Player.Local.SendAnimationTrigger(this.ConsumeAnimationTrigger);
				}
				else if (!string.IsNullOrEmpty(this.ConsumeAnimationBool))
				{
					Player.Local.SendAnimationBool(this.ConsumeAnimationBool, true);
				}
				if (this.ConsumeEquippableAssetPath != string.Empty)
				{
					Player.Local.SendEquippable_Networked(this.ConsumeEquippableAssetPath);
				}
			}
			this.consumeRoutine = base.StartCoroutine(this.<Consume>g__ConsumeRoutine|20_0());
		}

		// Token: 0x06003EA1 RID: 16033 RVA: 0x00108904 File Offset: 0x00106B04
		protected virtual void ApplyEffects()
		{
			Player.Local.ConsumeProduct(this.itemInstance as ProductItemInstance);
		}

		// Token: 0x06003EA3 RID: 16035 RVA: 0x0010898A File Offset: 0x00106B8A
		[CompilerGenerated]
		private IEnumerator <Consume>g__ConsumeRoutine|20_0()
		{
			yield return new WaitForSeconds(this.EffectsApplyDelay);
			this.consumingInProgress = false;
			this.ApplyEffects();
			this.itemInstance.ChangeQuantity(-1);
			yield break;
		}

		// Token: 0x04002CD1 RID: 11473
		[Header("References")]
		public FilledPackagingVisuals Visuals;

		// Token: 0x04002CD2 RID: 11474
		public Transform ModelContainer;

		// Token: 0x04002CD3 RID: 11475
		[Header("Settings")]
		public bool Consumable = true;

		// Token: 0x04002CD4 RID: 11476
		public string ConsumeDescription = "Smoke";

		// Token: 0x04002CD5 RID: 11477
		public float ConsumeTime = 1.5f;

		// Token: 0x04002CD6 RID: 11478
		public float EffectsApplyDelay = 2f;

		// Token: 0x04002CD7 RID: 11479
		public string ConsumeAnimationBool = string.Empty;

		// Token: 0x04002CD8 RID: 11480
		public string ConsumeAnimationTrigger = string.Empty;

		// Token: 0x04002CD9 RID: 11481
		public string ConsumeEquippableAssetPath = string.Empty;

		// Token: 0x04002CDA RID: 11482
		[Header("Events")]
		public UnityEvent onConsumeInputStart;

		// Token: 0x04002CDB RID: 11483
		public UnityEvent onConsumeInputComplete;

		// Token: 0x04002CDC RID: 11484
		public UnityEvent onConsumeInputCancel;

		// Token: 0x04002CDD RID: 11485
		private float consumeTime;

		// Token: 0x04002CDE RID: 11486
		private bool consumingInProgress;

		// Token: 0x04002CDF RID: 11487
		private Vector3 defaultModelPosition = Vector3.zero;

		// Token: 0x04002CE0 RID: 11488
		private int productAmount = 1;

		// Token: 0x04002CE1 RID: 11489
		private Coroutine consumeRoutine;
	}
}
