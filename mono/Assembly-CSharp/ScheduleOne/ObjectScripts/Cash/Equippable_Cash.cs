using System;
using System.Collections.Generic;
using ScheduleOne.Building;
using ScheduleOne.DevUtilities;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.Cash
{
	// Token: 0x02000C04 RID: 3076
	public class Equippable_Cash : Equippable_Viewmodel
	{
		// Token: 0x06005689 RID: 22153 RVA: 0x0016BDF9 File Offset: 0x00169FF9
		protected override void Update()
		{
			base.Update();
			if (!this.lookingAtStorageObject && GameInput.GetButtonDown(GameInput.ButtonCode.SecondaryClick))
			{
				this.amountIndex++;
			}
		}

		// Token: 0x0600568A RID: 22154 RVA: 0x0016BE1F File Offset: 0x0016A01F
		protected override void StartBuildingStoredItem()
		{
			this.isBuildingStoredItem = true;
			Singleton<BuildManager>.Instance.StartPlacingCash(this.itemInstance);
		}

		// Token: 0x0600568B RID: 22155 RVA: 0x0016BE38 File Offset: 0x0016A038
		protected override void StopBuildingStoredItem()
		{
			this.isBuildingStoredItem = false;
			Singleton<BuildManager>.Instance.StopBuilding();
		}

		// Token: 0x0600568C RID: 22156 RVA: 0x0016BE4B File Offset: 0x0016A04B
		public override void Equip(ItemInstance item)
		{
			base.Equip(item);
			item.onDataChanged = (Action)Delegate.Combine(item.onDataChanged, new Action(this.UpdateCashVisuals));
			this.UpdateCashVisuals();
		}

		// Token: 0x0600568D RID: 22157 RVA: 0x0016BE7C File Offset: 0x0016A07C
		public override void Unequip()
		{
			base.Unequip();
			ItemInstance itemInstance = this.itemInstance;
			itemInstance.onDataChanged = (Action)Delegate.Remove(itemInstance.onDataChanged, new Action(this.UpdateCashVisuals));
		}

		// Token: 0x0600568E RID: 22158 RVA: 0x0016BEAC File Offset: 0x0016A0AC
		private void UpdateCashVisuals()
		{
			CashInstance cashInstance = this.itemInstance as CashInstance;
			if (cashInstance == null)
			{
				this.Container_100_300.gameObject.SetActive(false);
				this.Container_300Plus.gameObject.SetActive(false);
				this.Container_Under100.gameObject.SetActive(false);
				return;
			}
			float num = cashInstance.Balance;
			if (num < 100f)
			{
				num = Mathf.Round(num / 10f) * 10f;
				int num2 = Mathf.Clamp(Mathf.RoundToInt(num / 10f), 0, 10);
				if (num > 0f)
				{
					num2 = Mathf.Max(1, num2);
				}
				this.Container_100_300.gameObject.SetActive(false);
				this.Container_300Plus.gameObject.SetActive(false);
				this.Container_Under100.gameObject.SetActive(true);
				for (int i = 0; i < this.SingleNotes.Count; i++)
				{
					if (i < num2)
					{
						this.SingleNotes[i].gameObject.SetActive(true);
					}
					else
					{
						this.SingleNotes[i].gameObject.SetActive(false);
					}
				}
				return;
			}
			num = Mathf.Floor(num / 100f) * 100f;
			this.Container_Under100.gameObject.SetActive(false);
			if (num < 400f)
			{
				this.Container_300Plus.gameObject.SetActive(false);
				this.Container_100_300.gameObject.SetActive(true);
				for (int j = 0; j < this.Under300Stacks.Count; j++)
				{
					if ((float)j < num / 100f)
					{
						this.Under300Stacks[j].gameObject.SetActive(true);
					}
					else
					{
						this.Under300Stacks[j].gameObject.SetActive(false);
					}
				}
				return;
			}
			this.Container_100_300.gameObject.SetActive(false);
			this.Container_300Plus.gameObject.SetActive(true);
			for (int k = 0; k < this.PlusStacks.Count; k++)
			{
				if ((float)k < num / 100f)
				{
					this.PlusStacks[k].gameObject.SetActive(true);
				}
				else
				{
					this.PlusStacks[k].gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x04003FE9 RID: 16361
		private int amountIndex;

		// Token: 0x04003FEA RID: 16362
		[Header("References")]
		public Transform Container_Under100;

		// Token: 0x04003FEB RID: 16363
		public List<Transform> SingleNotes;

		// Token: 0x04003FEC RID: 16364
		public Transform Container_100_300;

		// Token: 0x04003FED RID: 16365
		public List<Transform> Under300Stacks;

		// Token: 0x04003FEE RID: 16366
		public Transform Container_300Plus;

		// Token: 0x04003FEF RID: 16367
		public List<Transform> PlusStacks;
	}
}
