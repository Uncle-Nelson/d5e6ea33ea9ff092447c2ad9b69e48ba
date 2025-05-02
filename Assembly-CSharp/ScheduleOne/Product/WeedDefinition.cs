using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Properties;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x0200090E RID: 2318
	[CreateAssetMenu(fileName = "WeedDefinition", menuName = "ScriptableObjects/Item Definitions/WeedDefinition", order = 1)]
	[Serializable]
	public class WeedDefinition : ProductDefinition
	{
		// Token: 0x06003ECC RID: 16076 RVA: 0x00108E6D File Offset: 0x0010706D
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return new WeedInstance(this, quantity, EQuality.Standard, null);
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x00108E78 File Offset: 0x00107078
		public void Initialize(List<Property> properties, List<EDrugType> drugTypes, WeedAppearanceSettings _appearance)
		{
			base.Initialize(properties, drugTypes);
			if (_appearance == null || _appearance.IsUnintialized())
			{
				Console.LogWarning("Weed definition " + this.Name + " has no or uninitialized appearance settings! Generating new", null);
				_appearance = WeedDefinition.GetAppearanceSettings(properties);
			}
			this.appearance = _appearance;
			this.MainMat = new Material(this.MainMat);
			this.MainMat.color = this.appearance.MainColor;
			this.SecondaryMat = new Material(this.SecondaryMat);
			this.SecondaryMat.color = this.appearance.SecondaryColor;
			this.LeafMat = new Material(this.LeafMat);
			this.LeafMat.color = this.appearance.LeafColor;
			this.StemMat = new Material(this.StemMat);
			this.StemMat.color = this.appearance.StemColor;
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x00108F74 File Offset: 0x00107174
		public override string GetSaveString()
		{
			string[] array = new string[this.Properties.Count];
			for (int i = 0; i < this.Properties.Count; i++)
			{
				array[i] = this.Properties[i].ID;
			}
			return new WeedProductData(this.Name, this.ID, this.DrugTypes[0].DrugType, array, this.appearance).GetJson(true);
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x00108FEC File Offset: 0x001071EC
		public static WeedAppearanceSettings GetAppearanceSettings(List<Property> properties)
		{
			properties.Sort((Property x, Property y) => x.Tier.CompareTo(y.Tier));
			List<Color32> list = new List<Color32>();
			foreach (Property property in properties)
			{
				list.Add(property.ProductColor);
			}
			if (list.Count == 1)
			{
				list.Add(list[0]);
			}
			Color32 a = new Color32(90, 100, 70, byte.MaxValue);
			Color32 a2 = new Color32(120, 120, 80, byte.MaxValue);
			Color32 color = Color32.Lerp(a, list[0], (float)properties[0].Tier * 0.15f);
			Color32 color2 = Color32.Lerp(a2, Color32.Lerp(list[0], list[1], 0.5f), (properties.Count > 1) ? ((float)properties[1].Tier * 0.2f) : 0.5f);
			Color32 a3 = new Color32(0, 0, 0, byte.MaxValue);
			return new WeedAppearanceSettings
			{
				MainColor = color,
				SecondaryColor = color2,
				LeafColor = Color32.Lerp(color, color2, 0.5f),
				StemColor = Color32.Lerp(a3, color, 0.8f)
			};
		}

		// Token: 0x04002D02 RID: 11522
		[Header("Weed Materials")]
		public Material MainMat;

		// Token: 0x04002D03 RID: 11523
		public Material SecondaryMat;

		// Token: 0x04002D04 RID: 11524
		public Material LeafMat;

		// Token: 0x04002D05 RID: 11525
		public Material StemMat;

		// Token: 0x04002D06 RID: 11526
		private WeedAppearanceSettings appearance;
	}
}
