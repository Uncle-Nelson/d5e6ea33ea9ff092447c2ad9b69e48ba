using System;
using System.Collections.Generic;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006E8 RID: 1768
	public class MetadataManager : Singleton<MetadataManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06003012 RID: 12306 RVA: 0x000C82C0 File Offset: 0x000C64C0
		// (set) Token: 0x06003013 RID: 12307 RVA: 0x000C82C8 File Offset: 0x000C64C8
		public DateTime CreationDate { get; protected set; }

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x000C82D1 File Offset: 0x000C64D1
		// (set) Token: 0x06003015 RID: 12309 RVA: 0x000C82D9 File Offset: 0x000C64D9
		public string CreationVersion { get; protected set; } = string.Empty;

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06003016 RID: 12310 RVA: 0x000C82E2 File Offset: 0x000C64E2
		public string SaveFolderName
		{
			get
			{
				return "Metadata";
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06003017 RID: 12311 RVA: 0x000C82E2 File Offset: 0x000C64E2
		public string SaveFileName
		{
			get
			{
				return "Metadata";
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x000C82E9 File Offset: 0x000C64E9
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06003019 RID: 12313 RVA: 0x000141BA File Offset: 0x000123BA
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x000C82F1 File Offset: 0x000C64F1
		// (set) Token: 0x0600301B RID: 12315 RVA: 0x000C82F9 File Offset: 0x000C64F9
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600301C RID: 12316 RVA: 0x000C8302 File Offset: 0x000C6502
		// (set) Token: 0x0600301D RID: 12317 RVA: 0x000C830A File Offset: 0x000C650A
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600301E RID: 12318 RVA: 0x000C8313 File Offset: 0x000C6513
		// (set) Token: 0x0600301F RID: 12319 RVA: 0x000C831B File Offset: 0x000C651B
		public bool HasChanged { get; set; }

		// Token: 0x06003020 RID: 12320 RVA: 0x000C8324 File Offset: 0x000C6524
		protected override void Awake()
		{
			base.Awake();
			this.InitializeSaveable();
			if (this.CreationVersion == string.Empty)
			{
				this.CreationVersion = Application.version;
			}
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x000C8350 File Offset: 0x000C6550
		public virtual string GetSaveString()
		{
			DateTime now = DateTime.Now;
			return new MetaData(new DateTimeData(this.CreationDate), new DateTimeData(now), this.CreationVersion, Application.version, false).GetJson(true);
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x000C838B File Offset: 0x000C658B
		public void Load(MetaData data)
		{
			this.CreationDate = data.CreationDate.GetDateTime();
			this.CreationVersion = data.CreationVersion;
			this.HasChanged = true;
		}

		// Token: 0x0400222D RID: 8749
		private MetadataLoader loader = new MetadataLoader();
	}
}
