using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Property
{
	// Token: 0x0200080F RID: 2063
	public class BusinessManager : Singleton<BusinessManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06003808 RID: 14344 RVA: 0x000EDBC3 File Offset: 0x000EBDC3
		public string SaveFolderName
		{
			get
			{
				return "Businesses";
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06003809 RID: 14345 RVA: 0x000EDBC3 File Offset: 0x000EBDC3
		public string SaveFileName
		{
			get
			{
				return "Businesses";
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x0600380A RID: 14346 RVA: 0x000EDBCA File Offset: 0x000EBDCA
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x0600380B RID: 14347 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x0600380C RID: 14348 RVA: 0x000EDBD2 File Offset: 0x000EBDD2
		// (set) Token: 0x0600380D RID: 14349 RVA: 0x000EDBDA File Offset: 0x000EBDDA
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x0600380E RID: 14350 RVA: 0x000EDBE3 File Offset: 0x000EBDE3
		// (set) Token: 0x0600380F RID: 14351 RVA: 0x000EDBEB File Offset: 0x000EBDEB
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06003810 RID: 14352 RVA: 0x000EDBF4 File Offset: 0x000EBDF4
		// (set) Token: 0x06003811 RID: 14353 RVA: 0x000EDBFC File Offset: 0x000EBDFC
		public bool HasChanged { get; set; }

		// Token: 0x06003812 RID: 14354 RVA: 0x000EDC05 File Offset: 0x000EBE05
		protected override void Awake()
		{
			base.Awake();
			this.InitializeSaveable();
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x0003CEED File Offset: 0x0003B0ED
		public virtual string GetSaveString()
		{
			return string.Empty;
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x000EDC14 File Offset: 0x000EBE14
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			string containerFolder = ((ISaveable)this).GetContainerFolder(parentFolderPath);
			for (int i = 0; i < Business.UnownedBusinesses.Count; i++)
			{
				new SaveRequest(Business.UnownedBusinesses[i], containerFolder);
				list.Add(Business.UnownedBusinesses[i].SaveFolderName);
			}
			for (int j = 0; j < Business.OwnedBusinesses.Count; j++)
			{
				new SaveRequest(Business.OwnedBusinesses[j], containerFolder);
				list.Add(Business.OwnedBusinesses[j].SaveFolderName);
			}
			return list;
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x000EDCAC File Offset: 0x000EBEAC
		public void LoadBusiness(BusinessData businessData, string containerPath)
		{
			Business business = Business.Businesses.FirstOrDefault((Business p) => p.PropertyCode == businessData.PropertyCode);
			if (business == null)
			{
				business = Business.Businesses.FirstOrDefault((Business p) => p.PropertyCode == businessData.PropertyCode);
			}
			if (business == null)
			{
				Debug.LogWarning("Business not found: " + businessData.PropertyCode);
				return;
			}
			business.Load(businessData, containerPath);
		}

		// Token: 0x040028D1 RID: 10449
		private BusinessesLoader loader = new BusinessesLoader();
	}
}
