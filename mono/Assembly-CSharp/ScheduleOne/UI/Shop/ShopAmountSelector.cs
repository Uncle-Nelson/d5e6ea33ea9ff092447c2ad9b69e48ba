using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000B5B RID: 2907
	public class ShopAmountSelector : MonoBehaviour
	{
		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06004D6B RID: 19819 RVA: 0x00146521 File Offset: 0x00144721
		// (set) Token: 0x06004D6C RID: 19820 RVA: 0x00146529 File Offset: 0x00144729
		public bool IsOpen { get; private set; }

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06004D6D RID: 19821 RVA: 0x00146532 File Offset: 0x00144732
		// (set) Token: 0x06004D6E RID: 19822 RVA: 0x0014653A File Offset: 0x0014473A
		public int SelectedAmount { get; private set; } = 1;

		// Token: 0x06004D6F RID: 19823 RVA: 0x00146544 File Offset: 0x00144744
		private void Awake()
		{
			this.Container.gameObject.SetActive(false);
			this.InputField.onSubmit.AddListener(new UnityAction<string>(this.OnSubmitted));
			this.InputField.onValueChanged.AddListener(new UnityAction<string>(this.OnValueChanged));
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x0014659A File Offset: 0x0014479A
		public void Open()
		{
			this.Container.gameObject.SetActive(true);
			this.Container.SetAsLastSibling();
			this.InputField.text = string.Empty;
			this.InputField.Select();
			this.IsOpen = true;
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x001465DA File Offset: 0x001447DA
		public void Close()
		{
			this.Container.gameObject.SetActive(false);
			this.IsOpen = false;
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x001465F4 File Offset: 0x001447F4
		private void OnSubmitted(string value)
		{
			if (!this.IsOpen)
			{
				return;
			}
			this.OnValueChanged(value);
			if (this.onSubmitted != null)
			{
				this.onSubmitted.Invoke(this.SelectedAmount);
			}
			this.Close();
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x00146628 File Offset: 0x00144828
		private void OnValueChanged(string value)
		{
			int value2;
			if (int.TryParse(value, out value2))
			{
				this.SelectedAmount = Mathf.Clamp(value2, 1, 999);
				this.InputField.SetTextWithoutNotify(this.SelectedAmount.ToString());
				return;
			}
			this.SelectedAmount = 1;
			this.InputField.SetTextWithoutNotify(string.Empty);
		}

		// Token: 0x04003A5E RID: 14942
		[Header("References")]
		public RectTransform Container;

		// Token: 0x04003A5F RID: 14943
		public TMP_InputField InputField;

		// Token: 0x04003A60 RID: 14944
		public UnityEvent<int> onSubmitted;
	}
}
