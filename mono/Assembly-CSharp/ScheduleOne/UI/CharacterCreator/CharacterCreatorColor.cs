using System;
using System.Collections.Generic;
using ScheduleOne.Clothing;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000B41 RID: 2881
	public class CharacterCreatorColor : CharacterCreatorField<Color>
	{
		// Token: 0x06004CAE RID: 19630 RVA: 0x001437BC File Offset: 0x001419BC
		protected override void Awake()
		{
			base.Awake();
			if (this.UseClothingColors)
			{
				this.Colors = new List<Color>();
				foreach (EClothingColor color in CharacterCreatorColor.ClothingColorsToUse)
				{
					this.Colors.Add(color.GetActualColor());
				}
			}
			for (int j = 0; j < this.Colors.Count; j++)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.OptionPrefab, this.OptionContainer);
				gameObject.transform.Find("Color").GetComponent<Image>().color = this.Colors[j];
				Color col = this.Colors[j];
				gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(delegate()
				{
					this.OptionClicked(col);
				}));
				this.optionButtons.Add(gameObject.GetComponent<Button>());
			}
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x001438B4 File Offset: 0x00141AB4
		public override void ApplyValue()
		{
			base.ApplyValue();
			Button button = null;
			for (int i = 0; i < this.Colors.Count; i++)
			{
				if (ClothingColorExtensions.ColorEquals(base.value, this.Colors[i], 0.004f) && i < this.optionButtons.Count)
				{
					button = this.optionButtons[i];
					break;
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

		// Token: 0x06004CB0 RID: 19632 RVA: 0x00143955 File Offset: 0x00141B55
		public void OptionClicked(Color color)
		{
			base.value = color;
			this.WriteValue(true);
		}

		// Token: 0x040039C1 RID: 14785
		public static EClothingColor[] ClothingColorsToUse = new EClothingColor[]
		{
			EClothingColor.White,
			EClothingColor.LightGrey,
			EClothingColor.DarkGrey,
			EClothingColor.Charcoal,
			EClothingColor.Black,
			EClothingColor.Red,
			EClothingColor.Crimson,
			EClothingColor.Orange,
			EClothingColor.Tan,
			EClothingColor.Brown,
			EClothingColor.Yellow,
			EClothingColor.Lime,
			EClothingColor.DarkGreen,
			EClothingColor.Cyan,
			EClothingColor.SkyBlue,
			EClothingColor.Blue,
			EClothingColor.Navy,
			EClothingColor.Purple,
			EClothingColor.Magenta,
			EClothingColor.BrightPink
		};

		// Token: 0x040039C2 RID: 14786
		[Header("References")]
		public RectTransform OptionContainer;

		// Token: 0x040039C3 RID: 14787
		[Header("Settings")]
		public bool UseClothingColors;

		// Token: 0x040039C4 RID: 14788
		public List<Color> Colors;

		// Token: 0x040039C5 RID: 14789
		public GameObject OptionPrefab;

		// Token: 0x040039C6 RID: 14790
		private List<Button> optionButtons = new List<Button>();

		// Token: 0x040039C7 RID: 14791
		private Button selectedButton;
	}
}
