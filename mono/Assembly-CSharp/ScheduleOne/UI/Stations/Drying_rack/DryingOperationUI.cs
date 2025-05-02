using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using ScheduleOne.UI.Tooltips;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations.Drying_rack
{
	// Token: 0x02000A73 RID: 2675
	public class DryingOperationUI : MonoBehaviour
	{
		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06004823 RID: 18467 RVA: 0x0012F3F4 File Offset: 0x0012D5F4
		// (set) Token: 0x06004824 RID: 18468 RVA: 0x0012F3FC File Offset: 0x0012D5FC
		public DryingOperation AssignedOperation { get; protected set; }

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06004825 RID: 18469 RVA: 0x0012F405 File Offset: 0x0012D605
		// (set) Token: 0x06004826 RID: 18470 RVA: 0x0012F40D File Offset: 0x0012D60D
		public RectTransform Alignment { get; private set; }

		// Token: 0x06004827 RID: 18471 RVA: 0x0012F416 File Offset: 0x0012D616
		public void SetOperation(DryingOperation operation)
		{
			this.AssignedOperation = operation;
			this.Icon.sprite = Registry.GetItem(operation.ItemID).Icon;
			this.RefreshQuantity();
			this.UpdatePosition();
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x0012F446 File Offset: 0x0012D646
		public void SetAlignment(RectTransform alignment)
		{
			this.Alignment = alignment;
			base.transform.SetParent(alignment);
			this.UpdatePosition();
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x0012F461 File Offset: 0x0012D661
		public void RefreshQuantity()
		{
			this.QuantityLabel.text = this.AssignedOperation.Quantity.ToString() + "x";
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x0012F488 File Offset: 0x0012D688
		public void Start()
		{
			this.Button.onClick.AddListener(new UnityAction(delegate()
			{
				this.Clicked();
			}));
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x0012F4A8 File Offset: 0x0012D6A8
		public void UpdatePosition()
		{
			float t = Mathf.Clamp01((float)this.AssignedOperation.Time / 720f);
			int num = Mathf.Clamp(720 - this.AssignedOperation.Time, 0, 720);
			int num2 = num / 60;
			int num3 = num % 60;
			this.Tooltip.text = num2.ToString() + "h " + num3.ToString() + "m until next tier";
			float num4 = -62.5f;
			float b = -num4;
			this.Rect.anchoredPosition = new Vector2(Mathf.Lerp(num4, b, t), 0f);
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x0012F544 File Offset: 0x0012D744
		private void Clicked()
		{
			Singleton<DryingRackCanvas>.Instance.Rack.TryEndOperation(Singleton<DryingRackCanvas>.Instance.Rack.DryingOperations.IndexOf(this.AssignedOperation), true, this.AssignedOperation.GetQuality(), Random.Range(int.MinValue, int.MaxValue));
		}

		// Token: 0x04003586 RID: 13702
		[Header("References")]
		public RectTransform Rect;

		// Token: 0x04003587 RID: 13703
		public Image Icon;

		// Token: 0x04003588 RID: 13704
		public TextMeshProUGUI QuantityLabel;

		// Token: 0x04003589 RID: 13705
		public Button Button;

		// Token: 0x0400358A RID: 13706
		public Tooltip Tooltip;
	}
}
