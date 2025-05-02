using System;
using System.IO;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000387 RID: 903
	public class GenericSaveablesLoader : Loader
	{
		// Token: 0x0600147A RID: 5242 RVA: 0x0005B840 File Offset: 0x00059A40
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
					GenericSaveData genericSaveData = null;
					try
					{
						genericSaveData = JsonUtility.FromJson<GenericSaveData>(text);
					}
					catch (Exception ex)
					{
						Debug.LogError("Error loading generic save data: " + ex.Message);
					}
					if (genericSaveData != null)
					{
						Singleton<GenericSaveablesManager>.Instance.LoadSaveable(genericSaveData);
					}
				}
			}
		}
	}
}
