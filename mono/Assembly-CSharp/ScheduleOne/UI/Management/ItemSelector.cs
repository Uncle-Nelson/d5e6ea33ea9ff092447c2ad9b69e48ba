using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AF7 RID: 2807
	public class ItemSelector : ClipboardScreen
	{
		// Token: 0x06004B0A RID: 19210 RVA: 0x0013B45C File Offset: 0x0013965C
		public void Initialize(string selectionTitle, List<ItemSelector.Option> _options, ItemSelector.Option _selectedOption = null, Action<ItemSelector.Option> _optionCallback = null)
		{
			this.TitleLabel.text = selectionTitle;
			this.options = new List<ItemSelector.Option>();
			this.options.AddRange(_options);
			this.selectedOption = _selectedOption;
			this.optionCallback = _optionCallback;
			this.DeleteOptions();
			this.CreateOptions(this.options);
			this.HoveredItemLabel.enabled = false;
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x0013B4B9 File Offset: 0x001396B9
		public override void Open()
		{
			base.Open();
			Singleton<ManagementInterface>.Instance.MainScreen.Close();
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x0013B4D0 File Offset: 0x001396D0
		public override void Close()
		{
			base.Close();
			this.HoveredItemLabel.enabled = false;
			Singleton<ManagementInterface>.Instance.MainScreen.Open();
		}

		// Token: 0x06004B0D RID: 19213 RVA: 0x0013B4F3 File Offset: 0x001396F3
		private void ButtonClicked(ItemSelector.Option option)
		{
			if (this.optionCallback != null)
			{
				this.optionCallback(option);
			}
			this.Close();
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x0013B510 File Offset: 0x00139710
		private void ButtonHovered(ItemSelector.Option option)
		{
			this.HoveredItemLabel.text = option.Title;
			this.HoveredItemLabel.enabled = true;
			this.HoveredItemLabel.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -140f - Mathf.Ceil((float)this.optionButtons.Count / 5f) * this.optionButtons[0].sizeDelta.y);
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x0013B588 File Offset: 0x00139788
		private void ButtonHoverEnd(ItemSelector.Option option)
		{
			this.HoveredItemLabel.enabled = false;
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x0013B598 File Offset: 0x00139798
		private void CreateOptions(List<ItemSelector.Option> options)
		{
			for (int i = 0; i < options.Count; i++)
			{
				Button component = Object.Instantiate<GameObject>(this.OptionPrefab, this.OptionContainer).GetComponent<Button>();
				if (options[i].Item != null)
				{
					component.transform.Find("None").gameObject.SetActive(false);
					component.transform.Find("Icon").gameObject.GetComponent<Image>().sprite = options[i].Item.Icon;
					component.transform.Find("Icon").gameObject.SetActive(true);
				}
				else
				{
					component.transform.Find("None").gameObject.SetActive(true);
					component.transform.Find("Icon").gameObject.SetActive(false);
				}
				if (options[i] == this.selectedOption)
				{
					component.transform.Find("Outline").gameObject.GetComponent<Image>().color = new Color32(90, 90, 90, byte.MaxValue);
				}
				ItemSelector.Option opt = options[i];
				component.onClick.AddListener(new UnityAction(delegate()
				{
					this.ButtonClicked(opt);
				}));
				EventTrigger.Entry entry = new EventTrigger.Entry();
				entry.eventID = 0;
				entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
				{
					this.ButtonHovered(opt);
				}));
				component.GetComponent<EventTrigger>().triggers.Add(entry);
				entry = new EventTrigger.Entry();
				entry.eventID = 1;
				entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
				{
					this.ButtonHoverEnd(opt);
				}));
				component.GetComponent<EventTrigger>().triggers.Add(entry);
				this.optionButtons.Add(component.GetComponent<RectTransform>());
			}
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x0013B774 File Offset: 0x00139974
		private void DeleteOptions()
		{
			for (int i = 0; i < this.optionButtons.Count; i++)
			{
				Object.Destroy(this.optionButtons[i].gameObject);
			}
			this.optionButtons.Clear();
		}

		// Token: 0x04003845 RID: 14405
		[Header("References")]
		public RectTransform OptionContainer;

		// Token: 0x04003846 RID: 14406
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04003847 RID: 14407
		public TextMeshProUGUI HoveredItemLabel;

		// Token: 0x04003848 RID: 14408
		public GameObject OptionPrefab;

		// Token: 0x04003849 RID: 14409
		[Header("Settings")]
		public Sprite EmptyOptionSprite;

		// Token: 0x0400384A RID: 14410
		private Coroutine lerpRoutine;

		// Token: 0x0400384B RID: 14411
		private List<ItemSelector.Option> options = new List<ItemSelector.Option>();

		// Token: 0x0400384C RID: 14412
		private ItemSelector.Option selectedOption;

		// Token: 0x0400384D RID: 14413
		private List<RectTransform> optionButtons = new List<RectTransform>();

		// Token: 0x0400384E RID: 14414
		private Action<ItemSelector.Option> optionCallback;

		// Token: 0x02000AF8 RID: 2808
		[Serializable]
		public class Option
		{
			// Token: 0x06004B13 RID: 19219 RVA: 0x0013B7D6 File Offset: 0x001399D6
			public Option(string title, ItemDefinition item)
			{
				this.Title = title;
				this.Item = item;
			}

			// Token: 0x0400384F RID: 14415
			public string Title;

			// Token: 0x04003850 RID: 14416
			public ItemDefinition Item;
		}
	}
}
