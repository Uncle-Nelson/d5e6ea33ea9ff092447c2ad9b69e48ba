using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Packaging;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.UI;
using ScheduleOne.UI.Stations;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000354 RID: 852
	public class UseBrickPress : Task
	{
		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x000552A3 File Offset: 0x000534A3
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x000552AB File Offset: 0x000534AB
		public override string TaskName { get; protected set; } = "Use brick press";

		// Token: 0x06001334 RID: 4916 RVA: 0x000552B4 File Offset: 0x000534B4
		public UseBrickPress(BrickPress _press, ProductItemInstance _product)
		{
			if (_press == null)
			{
				Console.LogError("Press is null!", null);
				return;
			}
			if (_press.GetState() != PackagingStation.EState.CanBegin)
			{
				Console.LogError("Press not ready to begin packaging!", null);
				return;
			}
			this.press = _press;
			this.product = _product;
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.press.CameraPosition_Pouring.position, this.press.CameraPosition_Pouring.rotation, 0.2f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(70f, 0.2f);
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			Singleton<InputPromptsCanvas>.Instance.LoadModule("packaging");
			this.press.Container1.gameObject.SetActive(false);
			this.container = this.press.CreateFunctionalContainer(this.product, 0.75f, out this.products);
			base.CurrentInstruction = "Pour product into mould (0/20)";
			this.press.StartCoroutine(this.<.ctor>g__CheckMould|11_0());
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x000553C7 File Offset: 0x000535C7
		public override void Update()
		{
			base.Update();
			if (this.currentStep == UseBrickPress.EStep.Pressing && this.press.Handle.CurrentPosition >= 1f)
			{
				this.FinishPress();
			}
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x000553F8 File Offset: 0x000535F8
		public override void StopTask()
		{
			base.StopTask();
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			if (this.container != null)
			{
				Object.Destroy(this.container.gameObject);
			}
			for (int i = 0; i < this.products.Count; i++)
			{
				Object.Destroy(this.products[i].gameObject);
			}
			this.press.Container1.gameObject.SetActive(true);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.press.CameraPosition.position, this.press.CameraPosition.rotation, 0.2f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(65f, 0.2f);
			Singleton<BrickPressCanvas>.Instance.SetIsOpen(this.press, true, true);
			this.press.Handle.Locked = false;
			this.press.Handle.SetInteractable(false);
			if (this.currentStep == UseBrickPress.EStep.Complete)
			{
				this.press.CompletePress(this.product);
			}
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00055508 File Offset: 0x00053708
		private void CheckMould()
		{
			if (this.currentStep != UseBrickPress.EStep.Pouring)
			{
				return;
			}
			List<FunctionalProduct> productInMould = this.press.GetProductInMould();
			base.CurrentInstruction = "Pour product into mould (" + productInMould.Count.ToString() + "/20)";
			if (productInMould.Count >= 20)
			{
				this.BeginPress();
			}
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00055560 File Offset: 0x00053760
		private void BeginPress()
		{
			this.currentStep = UseBrickPress.EStep.Pressing;
			this.press.Handle.SetInteractable(true);
			this.container.ClickableEnabled = false;
			this.container.Rb.AddForce((this.press.transform.right + this.press.transform.up) * 2f, 2);
			base.CurrentInstruction = "Rotate handle quickly to press product";
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(70f, 0.3f);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.press.CameraPosition_Raising.position, this.press.CameraPosition_Raising.rotation, 0.3f, false);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00055620 File Offset: 0x00053820
		private void FinishPress()
		{
			this.press.SlamSound.Play();
			this.currentStep = UseBrickPress.EStep.Complete;
			this.press.Handle.Locked = true;
			this.press.Handle.SetInteractable(false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(60f, 0.1f);
			PlayerSingleton<PlayerCamera>.Instance.StartCameraShake(0.25f, 0.2f, true);
			this.press.StartCoroutine(this.<FinishPress>g__Wait|16_0());
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x000556A1 File Offset: 0x000538A1
		[CompilerGenerated]
		private IEnumerator <.ctor>g__CheckMould|11_0()
		{
			while (base.TaskActive)
			{
				this.CheckMould();
				yield return new WaitForSeconds(0.2f);
			}
			yield break;
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x000556B0 File Offset: 0x000538B0
		[CompilerGenerated]
		private IEnumerator <FinishPress>g__Wait|16_0()
		{
			yield return new WaitForSeconds(0.8f);
			this.StopTask();
			yield break;
		}

		// Token: 0x04001278 RID: 4728
		public const float PRODUCT_SCALE = 0.75f;

		// Token: 0x0400127A RID: 4730
		protected UseBrickPress.EStep currentStep;

		// Token: 0x0400127B RID: 4731
		protected BrickPress press;

		// Token: 0x0400127C RID: 4732
		protected ProductItemInstance product;

		// Token: 0x0400127D RID: 4733
		protected List<FunctionalProduct> products = new List<FunctionalProduct>();

		// Token: 0x0400127E RID: 4734
		protected Draggable container;

		// Token: 0x02000355 RID: 853
		public enum EStep
		{
			// Token: 0x04001280 RID: 4736
			Pouring,
			// Token: 0x04001281 RID: 4737
			Pressing,
			// Token: 0x04001282 RID: 4738
			Complete
		}
	}
}
