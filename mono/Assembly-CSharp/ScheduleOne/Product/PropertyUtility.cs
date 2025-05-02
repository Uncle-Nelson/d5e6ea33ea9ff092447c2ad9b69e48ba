using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Properties;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000904 RID: 2308
	public class PropertyUtility : Singleton<PropertyUtility>
	{
		// Token: 0x06003EB2 RID: 16050 RVA: 0x00108A88 File Offset: 0x00106C88
		protected override void Awake()
		{
			base.Awake();
			foreach (Property property in this.AllProperties)
			{
				this.PropertiesDict.Add(property.ID, property);
			}
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x00108AEC File Offset: 0x00106CEC
		protected override void Start()
		{
			base.Start();
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x00108AF4 File Offset: 0x00106CF4
		public List<Property> GetProperties(int tier)
		{
			bool excludePostMixingRework = false;
			if (SaveManager.GetVersionNumber(Singleton<MetadataManager>.Instance.CreationVersion) < 27f)
			{
				excludePostMixingRework = true;
			}
			return this.AllProperties.FindAll((Property x) => x.Tier == tier && (!excludePostMixingRework || x.ImplementedPriorMixingRework));
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x00108B4C File Offset: 0x00106D4C
		public List<Property> GetProperties(List<string> ids)
		{
			List<Property> list = new List<Property>();
			using (List<string>.Enumerator enumerator = ids.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string id = enumerator.Current;
					if (this.AllProperties.FirstOrDefault((Property x) => x.ID == id) == null)
					{
						Console.LogWarning("PropertyUtility: Property ID '" + id + "' not found!", null);
					}
					else
					{
						list.Add(this.PropertiesDict[id]);
					}
				}
			}
			return this.AllProperties.FindAll((Property x) => ids.Contains(x.ID));
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x00108C20 File Offset: 0x00106E20
		public static PropertyUtility.PropertyData GetPropertyData(EProperty property)
		{
			return Singleton<PropertyUtility>.Instance.PropertyDatas.Find((PropertyUtility.PropertyData x) => x.Property == property);
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x00108C58 File Offset: 0x00106E58
		public static PropertyUtility.DrugTypeData GetDrugTypeData(EDrugType drugType)
		{
			return Singleton<PropertyUtility>.Instance.DrugTypeDatas.Find((PropertyUtility.DrugTypeData x) => x.DrugType == drugType);
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x00108C90 File Offset: 0x00106E90
		public static List<Color32> GetOrderedPropertyColors(List<Property> properties)
		{
			properties.Sort((Property x, Property y) => x.Tier.CompareTo(y.Tier));
			List<Color32> list = new List<Color32>();
			foreach (Property property in properties)
			{
				list.Add(property.ProductColor);
			}
			return list;
		}

		// Token: 0x04002CE9 RID: 11497
		public List<PropertyUtility.PropertyData> PropertyDatas = new List<PropertyUtility.PropertyData>();

		// Token: 0x04002CEA RID: 11498
		public List<PropertyUtility.DrugTypeData> DrugTypeDatas = new List<PropertyUtility.DrugTypeData>();

		// Token: 0x04002CEB RID: 11499
		public List<Property> AllProperties = new List<Property>();

		// Token: 0x04002CEC RID: 11500
		[Header("Test Mixing")]
		public List<ProductDefinition> Products = new List<ProductDefinition>();

		// Token: 0x04002CED RID: 11501
		public List<PropertyItemDefinition> Properties = new List<PropertyItemDefinition>();

		// Token: 0x04002CEE RID: 11502
		private Dictionary<string, Property> PropertiesDict = new Dictionary<string, Property>();

		// Token: 0x02000905 RID: 2309
		[Serializable]
		public class PropertyData
		{
			// Token: 0x04002CEF RID: 11503
			public EProperty Property;

			// Token: 0x04002CF0 RID: 11504
			public string Name;

			// Token: 0x04002CF1 RID: 11505
			public string Description;

			// Token: 0x04002CF2 RID: 11506
			public Color Color;
		}

		// Token: 0x02000906 RID: 2310
		[Serializable]
		public class DrugTypeData
		{
			// Token: 0x04002CF3 RID: 11507
			public EDrugType DrugType;

			// Token: 0x04002CF4 RID: 11508
			public string Name;

			// Token: 0x04002CF5 RID: 11509
			public Color Color;
		}
	}
}
