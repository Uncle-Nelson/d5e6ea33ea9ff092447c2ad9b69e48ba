using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000B73 RID: 2931
	public class ItemInfoPanel : MonoBehaviour
	{
		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06004DFD RID: 19965 RVA: 0x0014831E File Offset: 0x0014651E
		// (set) Token: 0x06004DFE RID: 19966 RVA: 0x00148326 File Offset: 0x00146526
		public bool IsOpen { get; protected set; }

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06004DFF RID: 19967 RVA: 0x0014832F File Offset: 0x0014652F
		// (set) Token: 0x06004E00 RID: 19968 RVA: 0x00148337 File Offset: 0x00146537
		public ItemInstance CurrentItem { get; protected set; }

		// Token: 0x06004E01 RID: 19969 RVA: 0x00148340 File Offset: 0x00146540
		private void Awake()
		{
			this.Close();
		}

		// Token: 0x06004E02 RID: 19970 RVA: 0x00148348 File Offset: 0x00146548
		public void Open(ItemInstance item, RectTransform rect)
		{
			if (this.IsOpen)
			{
				this.Close();
			}
			if (item == null)
			{
				Console.LogWarning("Item is null!", null);
				return;
			}
			this.CurrentItem = item;
			if (item.Definition.CustomInfoContent != null)
			{
				this.content = Object.Instantiate<ItemInfoContent>(item.Definition.CustomInfoContent, this.ContentContainer);
				this.content.Initialize(item);
			}
			else
			{
				this.content = Object.Instantiate<ItemInfoContent>(this.DefaultContentPrefab, this.ContentContainer);
				this.content.Initialize(item);
			}
			this.Container.sizeDelta = new Vector2(this.Container.sizeDelta.x, this.content.Height);
			float num = (rect.sizeDelta.y + this.Container.sizeDelta.y) / 2f + this.Offset.y;
			num *= this.Canvas.scaleFactor;
			if (rect.position.y > 200f)
			{
				this.Container.position = rect.position - new Vector3(0f, num, 0f);
				this.TopArrow.SetActive(true);
				this.BottomArrow.SetActive(false);
			}
			else
			{
				this.Container.position = rect.position + new Vector3(0f, num, 0f);
				this.TopArrow.SetActive(false);
				this.BottomArrow.SetActive(true);
			}
			this.IsOpen = true;
			this.Container.gameObject.SetActive(true);
		}

		// Token: 0x06004E03 RID: 19971 RVA: 0x001484EC File Offset: 0x001466EC
		public void Open(ItemDefinition def, RectTransform rect)
		{
			if (this.IsOpen)
			{
				this.Close();
			}
			if (def == null)
			{
				Console.LogWarning("Item is null!", null);
				return;
			}
			this.CurrentItem = null;
			this.content = Object.Instantiate<ItemInfoContent>(this.DefaultContentPrefab, this.ContentContainer);
			this.content.Initialize(def);
			float num = (rect.sizeDelta.y + this.Container.sizeDelta.y) / 2f + this.Offset.y;
			num *= this.Canvas.scaleFactor;
			if (rect.position.y > 200f)
			{
				this.Container.position = rect.position - new Vector3(0f, num, 0f);
				this.TopArrow.SetActive(true);
				this.BottomArrow.SetActive(false);
			}
			else
			{
				this.Container.position = rect.position + new Vector3(0f, num, 0f);
				this.TopArrow.SetActive(false);
				this.BottomArrow.SetActive(true);
			}
			this.IsOpen = true;
			this.Container.gameObject.SetActive(true);
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x0014862B File Offset: 0x0014682B
		public void Close()
		{
			if (this.content != null)
			{
				Object.Destroy(this.content.gameObject);
			}
			this.IsOpen = false;
			this.CurrentItem = null;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x04003ACD RID: 15053
		public const float VERTICAL_THRESHOLD = 200f;

		// Token: 0x04003AD0 RID: 15056
		[Header("References")]
		public RectTransform Container;

		// Token: 0x04003AD1 RID: 15057
		public RectTransform ContentContainer;

		// Token: 0x04003AD2 RID: 15058
		public GameObject TopArrow;

		// Token: 0x04003AD3 RID: 15059
		public GameObject BottomArrow;

		// Token: 0x04003AD4 RID: 15060
		public Canvas Canvas;

		// Token: 0x04003AD5 RID: 15061
		[Header("Settings")]
		public Vector2 Offset = new Vector2(0f, 125f);

		// Token: 0x04003AD6 RID: 15062
		[Header("Prefabs")]
		public ItemInfoContent DefaultContentPrefab;

		// Token: 0x04003AD7 RID: 15063
		private ItemInfoContent content;
	}
}
