using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Properties;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008DC RID: 2268
	[CreateAssetMenu(fileName = "CocaineDefinition", menuName = "ScriptableObjects/Item Definitions/CocaineDefinition", order = 1)]
	[Serializable]
	public class CocaineDefinition : ProductDefinition
	{
		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06003D6A RID: 15722 RVA: 0x00101BDE File Offset: 0x000FFDDE
		// (set) Token: 0x06003D6B RID: 15723 RVA: 0x00101BE6 File Offset: 0x000FFDE6
		public CocaineAppearanceSettings AppearanceSettings { get; private set; }

		// Token: 0x06003D6C RID: 15724 RVA: 0x00101BEF File Offset: 0x000FFDEF
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			if (NetworkSingleton<ProductManager>.InstanceExists && !ProductManager.CocaineDiscovered)
			{
				NetworkSingleton<ProductManager>.Instance.SetCocaineDiscovered();
			}
			return new CocaineInstance(this, quantity, EQuality.Standard, null);
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x00101C14 File Offset: 0x000FFE14
		public void Initialize(List<Property> properties, List<EDrugType> drugTypes, CocaineAppearanceSettings _appearance)
		{
			base.Initialize(properties, drugTypes);
			if (_appearance == null || _appearance.IsUnintialized())
			{
				Console.LogWarning("Coke definition " + this.Name + " has no or uninitialized appearance settings! Generating new", null);
				_appearance = CocaineDefinition.GetAppearanceSettings(properties);
			}
			this.AppearanceSettings = _appearance;
			this.RockMaterial = new Material(this.RockMaterial);
			this.RockMaterial.color = this.AppearanceSettings.MainColor;
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x00101C8C File Offset: 0x000FFE8C
		public override string GetSaveString()
		{
			string[] array = new string[this.Properties.Count];
			for (int i = 0; i < this.Properties.Count; i++)
			{
				array[i] = this.Properties[i].ID;
			}
			return new CocaineProductData(this.Name, this.ID, this.DrugTypes[0].DrugType, array, this.AppearanceSettings).GetJson(true);
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x00101D04 File Offset: 0x000FFF04
		public static CocaineAppearanceSettings GetAppearanceSettings(List<Property> properties)
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
			Color32 mainColor = Color32.Lerp(a, list[0], (float)properties[0].Tier * 0.13f);
			Color32 secondaryColor = Color32.Lerp(a2, Color32.Lerp(list[0], list[1], 0.5f), (properties.Count > 1) ? ((float)properties[1].Tier * 0.2f) : 0.5f);
			return new CocaineAppearanceSettings
			{
				MainColor = mainColor,
				SecondaryColor = secondaryColor
			};
		}

		// Token: 0x04002C3D RID: 11325
		[Header("Materials")]
		public Material RockMaterial;
	}
}
