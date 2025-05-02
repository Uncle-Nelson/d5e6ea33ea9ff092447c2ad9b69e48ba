using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Properties;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008E6 RID: 2278
	[CreateAssetMenu(fileName = "MethDefinition", menuName = "ScriptableObjects/Item Definitions/MethDefinition", order = 1)]
	[Serializable]
	public class MethDefinition : ProductDefinition
	{
		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06003D87 RID: 15751 RVA: 0x00102305 File Offset: 0x00100505
		// (set) Token: 0x06003D88 RID: 15752 RVA: 0x0010230D File Offset: 0x0010050D
		public MethAppearanceSettings AppearanceSettings { get; private set; }

		// Token: 0x06003D89 RID: 15753 RVA: 0x00102316 File Offset: 0x00100516
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			if (NetworkSingleton<ProductManager>.InstanceExists && !ProductManager.MethDiscovered)
			{
				NetworkSingleton<ProductManager>.Instance.SetMethDiscovered();
			}
			return new MethInstance(this, quantity, EQuality.Standard, null);
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x0010233C File Offset: 0x0010053C
		public void Initialize(List<Property> properties, List<EDrugType> drugTypes, MethAppearanceSettings _appearance)
		{
			base.Initialize(properties, drugTypes);
			if (_appearance == null || _appearance.IsUnintialized())
			{
				Console.LogWarning("Meth definition " + this.Name + " has no or uninitialized appearance settings! Generating new", null);
				_appearance = MethDefinition.GetAppearanceSettings(properties);
			}
			this.AppearanceSettings = _appearance;
			this.CrystalMaterial = new Material(this.CrystalMaterial);
			this.CrystalMaterial.color = this.AppearanceSettings.MainColor;
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x001023B4 File Offset: 0x001005B4
		public override string GetSaveString()
		{
			string[] array = new string[this.Properties.Count];
			for (int i = 0; i < this.Properties.Count; i++)
			{
				array[i] = this.Properties[i].ID;
			}
			return new MethProductData(this.Name, this.ID, this.DrugTypes[0].DrugType, array, this.AppearanceSettings).GetJson(true);
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x0010242C File Offset: 0x0010062C
		public static MethAppearanceSettings GetAppearanceSettings(List<Property> properties)
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
			Color32 a = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			Color32 a2 = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			Color32 mainColor = Color32.Lerp(a, list[0], (float)properties[0].Tier * 0.2f);
			Color32 secondaryColor = Color32.Lerp(a2, Color32.Lerp(list[0], list[1], 0.5f), (properties.Count > 1) ? ((float)properties[1].Tier * 0.2f) : 0.5f);
			return new MethAppearanceSettings
			{
				MainColor = mainColor,
				SecondaryColor = secondaryColor
			};
		}

		// Token: 0x04002C5E RID: 11358
		public Material CrystalMaterial;

		// Token: 0x04002C5F RID: 11359
		[ColorUsage(true, true)]
		[SerializeField]
		public Color TintColor = Color.white;
	}
}
