using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000394 RID: 916
	public class PropertyLoader : Loader
	{
		// Token: 0x0600149C RID: 5276 RVA: 0x0005C0B0 File Offset: 0x0005A2B0
		public override void Load(string mainPath)
		{
			string text;
			if (base.TryLoadFile(mainPath, "Property", out text) || base.TryLoadFile(mainPath, "Business", out text))
			{
				PropertyData propertyData = null;
				try
				{
					propertyData = JsonUtility.FromJson<PropertyData>(text);
				}
				catch (Exception ex)
				{
					Type type = base.GetType();
					string str = (type != null) ? type.ToString() : null;
					string str2 = " error reading data: ";
					Exception ex2 = ex;
					Console.LogError(str + str2 + ((ex2 != null) ? ex2.ToString() : null), null);
				}
				if (propertyData != null)
				{
					Singleton<PropertyManager>.Instance.LoadProperty(propertyData, mainPath);
				}
			}
			string text2 = Path.Combine(mainPath, "Objects");
			if (Directory.Exists(text2))
			{
				List<string> list = new List<string>();
				Dictionary<string, int> objectPriorities = new Dictionary<string, int>();
				BuildableItemLoader buildableItemLoader = new BuildableItemLoader();
				List<DirectoryInfo> directories = base.GetDirectories(text2);
				for (int i = 0; i < directories.Count; i++)
				{
					BuildableItemData buildableItemData = buildableItemLoader.GetBuildableItemData(directories[i].FullName);
					if (buildableItemData != null)
					{
						list.Add(directories[i].FullName);
						objectPriorities.Add(directories[i].FullName, buildableItemData.LoadOrder);
					}
				}
				list = (from x in list
				orderby objectPriorities[x]
				select x).ToList<string>();
				for (int j = 0; j < list.Count; j++)
				{
					new LoadRequest(list[j], buildableItemLoader);
				}
			}
			string text3 = Path.Combine(mainPath, "Employees");
			if (Directory.Exists(text3))
			{
				List<DirectoryInfo> directories2 = base.GetDirectories(text3);
				for (int k = 0; k < directories2.Count; k++)
				{
					string text4;
					if (base.TryLoadFile(directories2[k].FullName, "NPC", out text4))
					{
						NPCData npcdata = null;
						try
						{
							npcdata = JsonUtility.FromJson<NPCData>(text4);
						}
						catch (Exception ex3)
						{
							string str3 = "Failed to load NPC data from ";
							string fullName = directories2[k].FullName;
							string str4 = "\n Exception: ";
							Exception ex4 = ex3;
							Console.LogWarning(str3 + fullName + str4 + ((ex4 != null) ? ex4.ToString() : null), null);
							goto IL_20D;
						}
						NPCLoader npcloader = Singleton<LoadManager>.Instance.GetNPCLoader(npcdata.DataType);
						if (npcloader != null)
						{
							new LoadRequest(directories2[k].FullName, npcloader);
						}
					}
					IL_20D:;
				}
			}
		}
	}
}
