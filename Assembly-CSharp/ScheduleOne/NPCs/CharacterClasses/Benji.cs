using System;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.Product;
using ScheduleOne.Variables;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004E1 RID: 1249
	public class Benji : Dealer
	{
		// Token: 0x06001BBF RID: 7103 RVA: 0x00073228 File Offset: 0x00071428
		protected override void MinPass()
		{
			base.MinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Benji_Recommended", base.HasBeenRecommended.ToString(), true);
			int num = 0;
			for (int i = 0; i < base.Inventory.ItemSlots.Count; i++)
			{
				if (base.Inventory.ItemSlots[i].Quantity != 0 && base.Inventory.ItemSlots[i].ItemInstance is WeedInstance)
				{
					num += (base.Inventory.ItemSlots[i].ItemInstance as WeedInstance).Amount * base.Inventory.ItemSlots[i].Quantity;
				}
			}
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Benji_WeedCount", num.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Benji_CashAmount", base.Cash.ToString(), true);
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00073328 File Offset: 0x00071528
		protected override void AddCustomer(Customer customer)
		{
			base.AddCustomer(customer);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Benji_CustomerCount", this.AssignedCustomers.Count.ToString(), true);
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x00073360 File Offset: 0x00071560
		public override void RemoveCustomer(Customer customer)
		{
			base.RemoveCustomer(customer);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Benji_CustomerCount", this.AssignedCustomers.Count.ToString(), true);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00073397 File Offset: 0x00071597
		protected override void RecruitmentRequested()
		{
			base.RecruitmentRequested();
			if (this.onRecruitmentRequested != null)
			{
				this.onRecruitmentRequested.Invoke();
			}
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x000733B2 File Offset: 0x000715B2
		protected override void UpdatePotentialDealerPoI()
		{
			base.UpdatePotentialDealerPoI();
			base.potentialDealerPoI.enabled = false;
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x000733C6 File Offset: 0x000715C6
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.BenjiAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.BenjiAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x000733DF File Offset: 0x000715DF
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.BenjiAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.BenjiAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000733F8 File Offset: 0x000715F8
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00073406 File Offset: 0x00071606
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001723 RID: 5923
		public UnityEvent onRecruitmentRequested;

		// Token: 0x04001724 RID: 5924
		private bool dll_Excuted;

		// Token: 0x04001725 RID: 5925
		private bool dll_Excuted;
	}
}
