using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.UI.Phone;
using ScheduleOne.Variables;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004E4 RID: 1252
	public class Shirley : Supplier
	{
		// Token: 0x06001BD3 RID: 7123 RVA: 0x000734CC File Offset: 0x000716CC
		protected override void DeaddropConfirmed(List<PhoneShopInterface.CartEntry> cart, float totalPrice)
		{
			base.DeaddropConfirmed(cart, totalPrice);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("ShirleyDeaddropOrders", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("ShirleyDeaddropOrders") + 1f).ToString(), true);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0007350E File Offset: 0x0007170E
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ShirleyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ShirleyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00073527 File Offset: 0x00071727
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ShirleyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ShirleyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00073540 File Offset: 0x00071740
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0007354E File Offset: 0x0007174E
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400172A RID: 5930
		private bool dll_Excuted;

		// Token: 0x0400172B RID: 5931
		private bool dll_Excuted;
	}
}
