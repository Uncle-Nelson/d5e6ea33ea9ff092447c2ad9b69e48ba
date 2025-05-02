using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Property
{
	// Token: 0x0200081B RID: 2075
	public class PropertyManager : Singleton<PropertyManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06003881 RID: 14465 RVA: 0x000EF414 File Offset: 0x000ED614
		public string SaveFolderName
		{
			get
			{
				return "Properties";
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06003882 RID: 14466 RVA: 0x000EF414 File Offset: 0x000ED614
		public string SaveFileName
		{
			get
			{
				return "Properties";
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06003883 RID: 14467 RVA: 0x000EF41B File Offset: 0x000ED61B
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06003884 RID: 14468 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06003885 RID: 14469 RVA: 0x000EF423 File Offset: 0x000ED623
		// (set) Token: 0x06003886 RID: 14470 RVA: 0x000EF42B File Offset: 0x000ED62B
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06003887 RID: 14471 RVA: 0x000EF434 File Offset: 0x000ED634
		// (set) Token: 0x06003888 RID: 14472 RVA: 0x000EF43C File Offset: 0x000ED63C
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06003889 RID: 14473 RVA: 0x000EF445 File Offset: 0x000ED645
		// (set) Token: 0x0600388A RID: 14474 RVA: 0x000EF44D File Offset: 0x000ED64D
		public bool HasChanged { get; set; }

		// Token: 0x0600388B RID: 14475 RVA: 0x000EF456 File Offset: 0x000ED656
		protected override void Awake()
		{
			base.Awake();
			this.InitializeSaveable();
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x0003CEED File Offset: 0x0003B0ED
		public virtual string GetSaveString()
		{
			return string.Empty;
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x000EF464 File Offset: 0x000ED664
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			string containerFolder = ((ISaveable)this).GetContainerFolder(parentFolderPath);
			for (int i = 0; i < Property.OwnedProperties.Count; i++)
			{
				try
				{
					if (Property.OwnedProperties[i].ShouldSave())
					{
						new SaveRequest(Property.OwnedProperties[i], containerFolder);
						list.Add(Property.OwnedProperties[i].SaveFolderName);
					}
				}
				catch (Exception ex)
				{
					Console.LogError("Error saving property: " + Property.OwnedProperties[i].PropertyCode + " - " + ex.Message, null);
					SaveManager.ReportSaveError();
				}
			}
			for (int j = 0; j < Property.UnownedProperties.Count; j++)
			{
				try
				{
					if (Property.UnownedProperties[j].ShouldSave())
					{
						new SaveRequest(Property.UnownedProperties[j], containerFolder);
						list.Add(Property.UnownedProperties[j].SaveFolderName);
					}
				}
				catch (Exception ex2)
				{
					Console.LogError("Error saving property: " + Property.OwnedProperties[j].PropertyCode + " - " + ex2.Message, null);
					SaveManager.ReportSaveError();
				}
			}
			return list;
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x000EF5BC File Offset: 0x000ED7BC
		public void LoadProperty(PropertyData propertyData, string containerPath)
		{
			Property property = Property.UnownedProperties.FirstOrDefault((Property p) => p.PropertyCode == propertyData.PropertyCode);
			if (property == null)
			{
				property = Property.OwnedProperties.FirstOrDefault((Property p) => p.PropertyCode == propertyData.PropertyCode);
			}
			if (property == null)
			{
				property = Business.UnownedBusinesses.FirstOrDefault((Business p) => p.PropertyCode == propertyData.PropertyCode);
			}
			if (property == null)
			{
				property = Business.OwnedBusinesses.FirstOrDefault((Business p) => p.PropertyCode == propertyData.PropertyCode);
			}
			if (property == null)
			{
				Console.LogWarning("Property not found for data: " + propertyData.PropertyCode, null);
				return;
			}
			property.Load(propertyData, containerPath);
		}

		// Token: 0x06003890 RID: 14480 RVA: 0x000EF680 File Offset: 0x000ED880
		public Property GetProperty(string code)
		{
			Property property = Property.UnownedProperties.FirstOrDefault((Property p) => p.PropertyCode == code);
			if (property == null)
			{
				property = Property.OwnedProperties.FirstOrDefault((Property p) => p.PropertyCode == code);
			}
			return property;
		}

		// Token: 0x04002916 RID: 10518
		private PropertiesLoader loader = new PropertiesLoader();
	}
}
