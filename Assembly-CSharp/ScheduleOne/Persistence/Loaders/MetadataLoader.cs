using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200038A RID: 906
	public class MetadataLoader : Loader
	{
		// Token: 0x06001483 RID: 5251 RVA: 0x0005BA04 File Offset: 0x00059C04
		public override void Load(string mainPath)
		{
			string text;
			if (base.TryLoadFile(mainPath, out text, true))
			{
				MetaData metaData = JsonUtility.FromJson<MetaData>(text);
				if (metaData != null)
				{
					Singleton<MetadataManager>.Instance.Load(metaData);
				}
			}
		}
	}
}
