using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.Money;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000939 RID: 2361
	public class CashPickup : ItemPickup
	{
		// Token: 0x06004010 RID: 16400 RVA: 0x0010E104 File Offset: 0x0010C304
		protected override void Hovered()
		{
			this.IntObj.SetMessage("Pick up " + MoneyManager.FormatAmount(this.Value, false, false));
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x000022C9 File Offset: 0x000004C9
		protected override bool CanPickup()
		{
			return true;
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x0010E134 File Offset: 0x0010C334
		protected override void Pickup()
		{
			NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(this.Value, true, false);
			base.Pickup();
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x0010E161 File Offset: 0x0010C361
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ItemFramework.CashPickupAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ItemFramework.CashPickupAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x0010E17A File Offset: 0x0010C37A
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ItemFramework.CashPickupAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ItemFramework.CashPickupAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x0010E193 File Offset: 0x0010C393
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x0010E1A1 File Offset: 0x0010C3A1
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04002E04 RID: 11780
		public float Value = 10f;

		// Token: 0x04002E05 RID: 11781
		private bool dll_Excuted;

		// Token: 0x04002E06 RID: 11782
		private bool dll_Excuted;
	}
}
