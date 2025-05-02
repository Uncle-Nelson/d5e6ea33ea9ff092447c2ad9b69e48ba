using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Handover
{
	// Token: 0x02000B32 RID: 2866
	public class HandoverScreenPriceSelector : MonoBehaviour
	{
		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06004C42 RID: 19522 RVA: 0x00141F68 File Offset: 0x00140168
		// (set) Token: 0x06004C43 RID: 19523 RVA: 0x00141F70 File Offset: 0x00140170
		public float Price { get; private set; } = 1f;

		// Token: 0x06004C44 RID: 19524 RVA: 0x00141F7C File Offset: 0x0014017C
		public void SetPrice(float price)
		{
			this.Price = Mathf.Clamp(price, 1f, 9999f);
			this.InputField.SetTextWithoutNotify(this.Price.ToString());
			if (this.onPriceChanged != null)
			{
				this.onPriceChanged.Invoke();
			}
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x00141FCB File Offset: 0x001401CB
		public void RefreshPrice()
		{
			this.OnPriceInputChanged(this.InputField.text);
		}

		// Token: 0x06004C46 RID: 19526 RVA: 0x00141FE0 File Offset: 0x001401E0
		public void OnPriceInputChanged(string value)
		{
			float value2;
			if (float.TryParse(value, out value2))
			{
				this.Price = Mathf.Clamp(value2, 1f, 9999f);
			}
			this.InputField.SetTextWithoutNotify(this.Price.ToString());
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x00142026 File Offset: 0x00140226
		public void ChangeAmount(float change)
		{
			this.SetPrice(this.Price + change);
		}

		// Token: 0x0400395C RID: 14684
		public const float MinPrice = 1f;

		// Token: 0x0400395D RID: 14685
		public const float MaxPrice = 9999f;

		// Token: 0x0400395E RID: 14686
		public InputField InputField;

		// Token: 0x04003960 RID: 14688
		public UnityEvent onPriceChanged;
	}
}
