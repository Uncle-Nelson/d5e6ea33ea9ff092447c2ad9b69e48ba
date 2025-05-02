using System;
using System.Collections;
using ScheduleOne.Clothing;
using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000B5C RID: 2908
	public class ShopColorPicker : MonoBehaviour
	{
		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06004D75 RID: 19829 RVA: 0x0013E2E2 File Offset: 0x0013C4E2
		public bool IsOpen
		{
			get
			{
				return base.gameObject.activeSelf;
			}
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x00146694 File Offset: 0x00144894
		public void Start()
		{
			using (IEnumerator enumerator = Enum.GetValues(typeof(EClothingColor)).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					EClothingColor color = (EClothingColor)enumerator.Current;
					GameObject gameObject = Object.Instantiate<GameObject>(this.ColorButtonPrefab, this.ColorButtonParent);
					gameObject.transform.Find("Color").GetComponent<Image>().color = color.GetActualColor();
					gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(delegate()
					{
						this.ColorPicked(color);
					}));
					EventTrigger eventTrigger = gameObject.AddComponent<EventTrigger>();
					EventTrigger.Entry entry = new EventTrigger.Entry();
					entry.eventID = 0;
					entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
					{
						this.ColorHovered(color);
					}));
					eventTrigger.triggers.Add(entry);
				}
			}
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x0014679C File Offset: 0x0014499C
		private void ColorPicked(EClothingColor color)
		{
			if (this.onColorPicked != null)
			{
				this.onColorPicked.Invoke(color);
			}
			this.Close();
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x001467B8 File Offset: 0x001449B8
		public void Open(ItemDefinition item)
		{
			this.AssetIconImage.sprite = item.Icon;
			this.ColorHovered(EClothingColor.White);
			base.gameObject.SetActive(true);
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x000C0CA9 File Offset: 0x000BEEA9
		public void Close()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x001467DE File Offset: 0x001449DE
		private void ColorHovered(EClothingColor color)
		{
			this.AssetIconImage.color = color.GetActualColor();
			this.ColorLabel.text = color.GetLabel();
		}

		// Token: 0x04003A61 RID: 14945
		public Image AssetIconImage;

		// Token: 0x04003A62 RID: 14946
		public TextMeshProUGUI ColorLabel;

		// Token: 0x04003A63 RID: 14947
		public RectTransform ColorButtonParent;

		// Token: 0x04003A64 RID: 14948
		public GameObject ColorButtonPrefab;

		// Token: 0x04003A65 RID: 14949
		public UnityEvent<EClothingColor> onColorPicked = new UnityEvent<EClothingColor>();
	}
}
