using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000383 RID: 899
	public class BusinessLoader : PropertyLoader
	{
		// Token: 0x06001471 RID: 5233 RVA: 0x0005B590 File Offset: 0x00059790
		public override void Load(string mainPath)
		{
			base.Load(mainPath);
			string text;
			if (base.TryLoadFile(mainPath, "Business", out text))
			{
				BusinessData businessData = null;
				try
				{
					businessData = JsonUtility.FromJson<BusinessData>(text);
				}
				catch (Exception ex)
				{
					Type type = base.GetType();
					string str = (type != null) ? type.ToString() : null;
					string str2 = " error reading data: ";
					Exception ex2 = ex;
					Console.LogError(str + str2 + ((ex2 != null) ? ex2.ToString() : null), null);
				}
				if (businessData != null)
				{
					Singleton<BusinessManager>.Instance.LoadBusiness(businessData, mainPath);
				}
			}
		}
	}
}
