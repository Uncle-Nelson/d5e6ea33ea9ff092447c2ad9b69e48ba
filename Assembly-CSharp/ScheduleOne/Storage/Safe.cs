using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008A7 RID: 2215
	public class Safe : StorageEntity
	{
		// Token: 0x06003C02 RID: 15362 RVA: 0x000FCAA8 File Offset: 0x000FACA8
		public float GetCash()
		{
			float num = 0f;
			for (int i = 0; i < base.ItemSlots.Count; i++)
			{
				if (base.ItemSlots[i].ItemInstance != null && base.ItemSlots[i].ItemInstance is CashInstance)
				{
					CashInstance cashInstance = base.ItemSlots[i].ItemInstance as CashInstance;
					num += cashInstance.Balance;
				}
			}
			return num;
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x000FCB20 File Offset: 0x000FAD20
		public void RemoveCash(float amount)
		{
			amount = Mathf.Abs(amount);
			float num = amount;
			for (int i = 0; i < base.ItemSlots.Count; i++)
			{
				if (base.ItemSlots[i].ItemInstance != null && base.ItemSlots[i].ItemInstance is CashInstance)
				{
					CashInstance cashInstance = base.ItemSlots[i].ItemInstance as CashInstance;
					float num2 = Mathf.Min(cashInstance.Balance, num);
					cashInstance.ChangeBalance(-num2);
					num -= num2;
				}
				if (num <= 0f)
				{
					break;
				}
			}
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x000FCBAE File Offset: 0x000FADAE
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Storage.SafeAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Storage.SafeAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x000FCBC7 File Offset: 0x000FADC7
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Storage.SafeAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Storage.SafeAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x000FCBE0 File Offset: 0x000FADE0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x000FCBEE File Offset: 0x000FADEE
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04002B53 RID: 11091
		private bool dll_Excuted;

		// Token: 0x04002B54 RID: 11092
		private bool dll_Excuted;
	}
}
