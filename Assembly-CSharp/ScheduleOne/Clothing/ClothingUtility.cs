using System;
using System.Collections;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Clothing
{
	// Token: 0x02000744 RID: 1860
	public class ClothingUtility : Singleton<ClothingUtility>
	{
		// Token: 0x06003279 RID: 12921 RVA: 0x000D1B10 File Offset: 0x000CFD10
		protected override void Awake()
		{
			base.Awake();
			using (IEnumerator enumerator = Enum.GetValues(typeof(EClothingColor)).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					EClothingColor color = (EClothingColor)enumerator.Current;
					if (this.ColorDataList.Find((ClothingUtility.ColorData x) => x.ColorType == color) == null)
					{
						Debug.LogError("Color " + color.ToString() + " is missing from the ColorDataList");
					}
				}
			}
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x000D1BBC File Offset: 0x000CFDBC
		private void OnValidate()
		{
			using (IEnumerator enumerator = Enum.GetValues(typeof(EClothingColor)).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					EClothingColor color = (EClothingColor)enumerator.Current;
					if (this.ColorDataList.Find((ClothingUtility.ColorData x) => x.ColorType == color) == null)
					{
						this.ColorDataList.Add(new ClothingUtility.ColorData
						{
							ColorType = color,
							ActualColor = Color.white,
							LabelColor = Color.white
						});
					}
				}
			}
			using (IEnumerator enumerator = Enum.GetValues(typeof(EClothingSlot)).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					EClothingSlot slot = (EClothingSlot)enumerator.Current;
					if (this.ClothingSlotDataList.Find((ClothingUtility.ClothingSlotData x) => x.Slot == slot) == null)
					{
						this.ClothingSlotDataList.Add(new ClothingUtility.ClothingSlotData
						{
							Slot = slot,
							Name = slot.ToString(),
							Icon = null
						});
					}
				}
			}
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x000D1D18 File Offset: 0x000CFF18
		public ClothingUtility.ColorData GetColorData(EClothingColor color)
		{
			return this.ColorDataList.Find((ClothingUtility.ColorData x) => x.ColorType == color);
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x000D1D4C File Offset: 0x000CFF4C
		public ClothingUtility.ClothingSlotData GetSlotData(EClothingSlot slot)
		{
			return this.ClothingSlotDataList.Find((ClothingUtility.ClothingSlotData x) => x.Slot == slot);
		}

		// Token: 0x040023F4 RID: 9204
		public List<ClothingUtility.ColorData> ColorDataList = new List<ClothingUtility.ColorData>();

		// Token: 0x040023F5 RID: 9205
		public List<ClothingUtility.ClothingSlotData> ClothingSlotDataList = new List<ClothingUtility.ClothingSlotData>();

		// Token: 0x02000745 RID: 1861
		[Serializable]
		public class ColorData
		{
			// Token: 0x040023F6 RID: 9206
			public EClothingColor ColorType;

			// Token: 0x040023F7 RID: 9207
			public Color ActualColor;

			// Token: 0x040023F8 RID: 9208
			public Color LabelColor;
		}

		// Token: 0x02000746 RID: 1862
		[Serializable]
		public class ClothingSlotData
		{
			// Token: 0x040023F9 RID: 9209
			public EClothingSlot Slot;

			// Token: 0x040023FA RID: 9210
			public string Name;

			// Token: 0x040023FB RID: 9211
			public Sprite Icon;
		}
	}
}
