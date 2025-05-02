using System;
using System.IO;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200039E RID: 926
	public class VariablesLoader : Loader
	{
		// Token: 0x060014B0 RID: 5296 RVA: 0x0005CBE4 File Offset: 0x0005ADE4
		public override void Load(string mainPath)
		{
			if (!Directory.Exists(mainPath))
			{
				return;
			}
			Console.Log("Loading variables", null);
			string[] files = Directory.GetFiles(mainPath);
			for (int i = 0; i < files.Length; i++)
			{
				string text;
				if (base.TryLoadFile(files[i], out text, false))
				{
					VariableData variableData = null;
					try
					{
						variableData = JsonUtility.FromJson<VariableData>(text);
					}
					catch (Exception ex)
					{
						Debug.LogError("Error loading quest data: " + ex.Message);
					}
					if (variableData != null)
					{
						NetworkSingleton<VariableDatabase>.Instance.Load(variableData);
					}
				}
			}
		}
	}
}
