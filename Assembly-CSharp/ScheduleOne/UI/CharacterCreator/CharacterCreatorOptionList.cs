using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.Clothing;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000B46 RID: 2886
	public class CharacterCreatorOptionList : CharacterCreatorField<string>
	{
		// Token: 0x06004CC3 RID: 19651 RVA: 0x00143B20 File Offset: 0x00141D20
		protected override void Awake()
		{
			base.Awake();
			if (this.CanSelectNone)
			{
				this.Options.Insert(0, new CharacterCreatorOptionList.Option
				{
					AssetPath = "",
					Label = "None"
				});
			}
			for (int i = 0; i < this.Options.Count; i++)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.OptionPrefab, this.OptionContainer);
				gameObject.transform.Find("Text").GetComponent<TextMeshProUGUI>().text = this.Options[i].Label;
				string option = this.Options[i].AssetPath;
				gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(delegate()
				{
					this.OptionClicked(option);
				}));
				this.optionButtons.Add(gameObject.GetComponent<Button>());
			}
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x00143C0C File Offset: 0x00141E0C
		public override void ApplyValue()
		{
			base.ApplyValue();
			Button button = null;
			int i = 0;
			while (i < this.Options.Count)
			{
				if (base.value == this.Options[i].AssetPath)
				{
					this.selectedClothingDefinition = this.Options[i].ClothingItemEquivalent;
					if (this.optionButtons.Count > i)
					{
						button = this.optionButtons[i];
						break;
					}
					break;
				}
				else
				{
					i++;
				}
			}
			if (this.selectedButton != null)
			{
				this.selectedButton.interactable = true;
			}
			this.selectedButton = button;
			if (this.selectedButton != null)
			{
				this.selectedButton.interactable = false;
			}
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x00143CC4 File Offset: 0x00141EC4
		public void OptionClicked(string option)
		{
			base.value = option;
			CharacterCreatorOptionList.Option option2 = this.Options.FirstOrDefault((CharacterCreatorOptionList.Option o) => o.AssetPath == option);
			if (option2 != null)
			{
				this.selectedClothingDefinition = option2.ClothingItemEquivalent;
			}
			else
			{
				this.selectedClothingDefinition = null;
			}
			this.WriteValue(true);
		}

		// Token: 0x040039D4 RID: 14804
		[Header("References")]
		public RectTransform OptionContainer;

		// Token: 0x040039D5 RID: 14805
		[Header("Settings")]
		public bool CanSelectNone = true;

		// Token: 0x040039D6 RID: 14806
		public List<CharacterCreatorOptionList.Option> Options;

		// Token: 0x040039D7 RID: 14807
		public GameObject OptionPrefab;

		// Token: 0x040039D8 RID: 14808
		private List<Button> optionButtons = new List<Button>();

		// Token: 0x040039D9 RID: 14809
		private Button selectedButton;

		// Token: 0x02000B47 RID: 2887
		[Serializable]
		public class Option
		{
			// Token: 0x040039DA RID: 14810
			public string Label;

			// Token: 0x040039DB RID: 14811
			public string AssetPath;

			// Token: 0x040039DC RID: 14812
			public ClothingDefinition ClothingItemEquivalent;
		}
	}
}
