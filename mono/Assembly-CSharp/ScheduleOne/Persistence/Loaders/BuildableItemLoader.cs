using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003B7 RID: 951
	public class BuildableItemLoader : Loader
	{
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x0005DCA9 File Offset: 0x0005BEA9
		public virtual string ItemType
		{
			get
			{
				return typeof(BuildableItemData).Name;
			}
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0005DCBA File Offset: 0x0005BEBA
		public BuildableItemLoader()
		{
			Singleton<LoadManager>.Instance.ObjectLoaders.Add(this);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0005DCD4 File Offset: 0x0005BED4
		public override void Load(string mainPath)
		{
			BuildableItemData buildableItemData = this.GetBuildableItemData(mainPath);
			if (buildableItemData != null)
			{
				BuildableItemLoader objectLoader = Singleton<LoadManager>.Instance.GetObjectLoader(buildableItemData.DataType);
				if (objectLoader != null)
				{
					new LoadRequest(mainPath, objectLoader);
				}
			}
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0005DD08 File Offset: 0x0005BF08
		public BuildableItemData GetBuildableItemData(string mainPath)
		{
			return this.GetData<BuildableItemData>(mainPath);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0005DD14 File Offset: 0x0005BF14
		protected T GetData<T>(string mainPath) where T : BuildableItemData
		{
			string text;
			if (base.TryLoadFile(mainPath, "Data", out text))
			{
				T result = default(T);
				try
				{
					result = JsonUtility.FromJson<T>(text);
				}
				catch (Exception ex)
				{
					Type type = base.GetType();
					string str = (type != null) ? type.ToString() : null;
					string str2 = " error reading data: ";
					Exception ex2 = ex;
					Console.LogError(str + str2 + ((ex2 != null) ? ex2.ToString() : null), null);
				}
				return result;
			}
			return default(T);
		}
	}
}
