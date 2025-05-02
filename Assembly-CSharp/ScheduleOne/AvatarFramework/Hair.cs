using System;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000970 RID: 2416
	public class Hair : Accessory
	{
		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x060041C1 RID: 16833 RVA: 0x00114233 File Offset: 0x00112433
		// (set) Token: 0x060041C2 RID: 16834 RVA: 0x0011423B File Offset: 0x0011243B
		public bool BlockedByHat { get; protected set; }

		// Token: 0x060041C3 RID: 16835 RVA: 0x00114244 File Offset: 0x00112444
		public void SetBlockedByHat(bool blocked)
		{
			this.BlockedByHat = blocked;
			if (blocked)
			{
				this.BlockHair();
				return;
			}
			this.UnBlockHair();
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x00114260 File Offset: 0x00112460
		protected virtual void BlockHair()
		{
			GameObject[] array = this.hairToHide;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SetActive(false);
			}
		}

		// Token: 0x060041C5 RID: 16837 RVA: 0x0011428C File Offset: 0x0011248C
		protected virtual void UnBlockHair()
		{
			GameObject[] array = this.hairToHide;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SetActive(true);
			}
		}

		// Token: 0x04002F4B RID: 12107
		[SerializeField]
		private GameObject[] hairToHide;
	}
}
