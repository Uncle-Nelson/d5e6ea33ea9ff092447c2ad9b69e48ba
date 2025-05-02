using System;
using System.IO;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200039B RID: 923
	public class StorageLoader : Loader
	{
		// Token: 0x060014AA RID: 5290 RVA: 0x0005C76C File Offset: 0x0005A96C
		public override void Load(string mainPath)
		{
			if (!Directory.Exists(mainPath))
			{
				return;
			}
			string[] files = Directory.GetFiles(mainPath);
			for (int i = 0; i < files.Length; i++)
			{
				string text;
				if (base.TryLoadFile(files[i], out text, false))
				{
					WorldStorageEntityData worldStorageEntityData = null;
					try
					{
						worldStorageEntityData = JsonUtility.FromJson<WorldStorageEntityData>(text);
					}
					catch (Exception ex)
					{
						Debug.LogError("Error loading data: " + ex.Message);
					}
					if (worldStorageEntityData != null)
					{
						WorldStorageEntity @object = GUIDManager.GetObject<WorldStorageEntity>(new Guid(worldStorageEntityData.GUID));
						if (@object != null)
						{
							@object.Load(worldStorageEntityData);
						}
					}
				}
			}
		}
	}
}
