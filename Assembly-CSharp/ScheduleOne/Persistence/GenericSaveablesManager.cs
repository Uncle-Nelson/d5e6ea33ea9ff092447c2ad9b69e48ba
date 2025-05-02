using System;
using System.Collections.Generic;
using System.IO;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Persistence
{
	// Token: 0x02000360 RID: 864
	public class GenericSaveablesManager : Singleton<GenericSaveablesManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0005767B File Offset: 0x0005587B
		public string SaveFolderName
		{
			get
			{
				return "GenericSaveables";
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x0005767B File Offset: 0x0005587B
		public string SaveFileName
		{
			get
			{
				return "GenericSaveables";
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x00057682 File Offset: 0x00055882
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x0005768A File Offset: 0x0005588A
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x00057692 File Offset: 0x00055892
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x0005769B File Offset: 0x0005589B
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x000576A3 File Offset: 0x000558A3
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x000576AC File Offset: 0x000558AC
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x000576B4 File Offset: 0x000558B4
		public bool HasChanged { get; set; }

		// Token: 0x06001393 RID: 5011 RVA: 0x000576BD File Offset: 0x000558BD
		protected override void Awake()
		{
			base.Awake();
			this.InitializeSaveable();
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x000576CB File Offset: 0x000558CB
		public void RegisterSaveable(IGenericSaveable saveable)
		{
			if (this.Saveables.Contains(saveable))
			{
				return;
			}
			this.Saveables.Add(saveable);
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0003CEED File Offset: 0x0003B0ED
		public virtual string GetSaveString()
		{
			return string.Empty;
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x000576E8 File Offset: 0x000558E8
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			string containerFolder = ((ISaveable)this).GetContainerFolder(parentFolderPath);
			for (int i = 0; i < this.Saveables.Count; i++)
			{
				if (this.Saveables[i] != null)
				{
					string json = this.Saveables[i].GetSaveData().GetJson(true);
					string text = this.Saveables[i].GUID.ToString().Substring(0, 6) + ".json";
					list.Add(text);
					string text2 = Path.Combine(containerFolder, text);
					try
					{
						File.WriteAllText(text2, json);
					}
					catch (Exception ex)
					{
						Console.LogWarning("Failed to write generic saveable file: " + text2 + " - " + ex.Message, null);
					}
				}
			}
			return list;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x000577CC File Offset: 0x000559CC
		public void LoadSaveable(GenericSaveData data)
		{
			if (!GUIDManager.IsGUIDValid(data.GUID))
			{
				Console.LogWarning("Invalid GUID found in generic save data: " + data.GUID, null);
				return;
			}
			Guid guid = new Guid(data.GUID);
			IGenericSaveable genericSaveable = this.Saveables.Find((IGenericSaveable x) => x.GUID == guid);
			if (genericSaveable == null)
			{
				string str = "No saveable found with GUID: ";
				Guid guid2 = guid;
				Console.LogWarning(str + guid2.ToString(), null);
				return;
			}
			genericSaveable.Load(data);
		}

		// Token: 0x040012B1 RID: 4785
		protected List<IGenericSaveable> Saveables = new List<IGenericSaveable>();

		// Token: 0x040012B2 RID: 4786
		private GenericSaveablesLoader loader = new GenericSaveablesLoader();
	}
}
