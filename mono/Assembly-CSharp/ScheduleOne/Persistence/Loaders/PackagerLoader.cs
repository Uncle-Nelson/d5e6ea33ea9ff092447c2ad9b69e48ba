using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Employees;
using ScheduleOne.Persistence.Datas;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003B1 RID: 945
	public class PackagerLoader : EmployeeLoader
	{
		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x0005D909 File Offset: 0x0005BB09
		public override string NPCType
		{
			get
			{
				return typeof(PackagerData).Name;
			}
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0005D91C File Offset: 0x0005BB1C
		public override void Load(string mainPath)
		{
			PackagerLoader.<>c__DisplayClass3_0 CS$<>8__locals1 = new PackagerLoader.<>c__DisplayClass3_0();
			Employee employee = base.LoadAndCreateEmployee(mainPath);
			if (employee == null)
			{
				return;
			}
			CS$<>8__locals1.packager = (employee as Packager);
			if (CS$<>8__locals1.packager == null)
			{
				Console.LogWarning("Failed to cast employee to packager", null);
				return;
			}
			string text;
			if (base.TryLoadFile(mainPath, "Configuration", out text))
			{
				PackagerLoader.<>c__DisplayClass3_1 CS$<>8__locals2 = new PackagerLoader.<>c__DisplayClass3_1();
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				CS$<>8__locals2.configData = JsonUtility.FromJson<PackagerConfigurationData>(text);
				if (CS$<>8__locals2.configData != null)
				{
					Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(CS$<>8__locals2.<Load>g__LoadConfiguration|0));
				}
			}
			string text2;
			if (base.TryLoadFile(mainPath, "NPC", out text2))
			{
				PackagerLoader.<>c__DisplayClass3_2 CS$<>8__locals3 = new PackagerLoader.<>c__DisplayClass3_2();
				CS$<>8__locals3.CS$<>8__locals2 = CS$<>8__locals1;
				CS$<>8__locals3.data = null;
				try
				{
					CS$<>8__locals3.data = JsonUtility.FromJson<PackagerData>(text2);
				}
				catch (Exception ex)
				{
					Type type = base.GetType();
					string str = (type != null) ? type.ToString() : null;
					string str2 = " error reading data: ";
					Exception ex2 = ex;
					Console.LogError(str + str2 + ((ex2 != null) ? ex2.ToString() : null), null);
				}
				if (CS$<>8__locals3.data == null)
				{
					Console.LogWarning("Failed to load packager data", null);
					return;
				}
				Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(CS$<>8__locals3.<Load>g__LoadConfiguration|1));
			}
		}
	}
}
