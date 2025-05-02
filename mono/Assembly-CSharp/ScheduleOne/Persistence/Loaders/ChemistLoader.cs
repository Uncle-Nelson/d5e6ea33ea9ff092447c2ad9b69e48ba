using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Employees;
using ScheduleOne.Persistence.Datas;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003A6 RID: 934
	public class ChemistLoader : EmployeeLoader
	{
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x0005CFD3 File Offset: 0x0005B1D3
		public override string NPCType
		{
			get
			{
				return typeof(ChemistData).Name;
			}
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0005CFE4 File Offset: 0x0005B1E4
		public override void Load(string mainPath)
		{
			ChemistLoader.<>c__DisplayClass3_0 CS$<>8__locals1 = new ChemistLoader.<>c__DisplayClass3_0();
			Employee employee = base.LoadAndCreateEmployee(mainPath);
			if (employee == null)
			{
				return;
			}
			CS$<>8__locals1.chemist = (employee as Chemist);
			if (CS$<>8__locals1.chemist == null)
			{
				Console.LogWarning("Failed to cast employee to chemist", null);
				return;
			}
			string text;
			if (base.TryLoadFile(mainPath, "Configuration", out text))
			{
				ChemistLoader.<>c__DisplayClass3_1 CS$<>8__locals2 = new ChemistLoader.<>c__DisplayClass3_1();
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				CS$<>8__locals2.configData = JsonUtility.FromJson<ChemistConfigurationData>(text);
				if (CS$<>8__locals2.configData != null)
				{
					Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(CS$<>8__locals2.<Load>g__LoadConfiguration|0));
				}
			}
			string text2;
			if (base.TryLoadFile(mainPath, "NPC", out text2))
			{
				ChemistLoader.<>c__DisplayClass3_2 CS$<>8__locals3 = new ChemistLoader.<>c__DisplayClass3_2();
				CS$<>8__locals3.CS$<>8__locals2 = CS$<>8__locals1;
				CS$<>8__locals3.data = null;
				try
				{
					CS$<>8__locals3.data = JsonUtility.FromJson<ChemistData>(text2);
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
					Console.LogWarning("Failed to load chemist data", null);
					return;
				}
				Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(CS$<>8__locals3.<Load>g__LoadConfiguration|1));
			}
		}
	}
}
