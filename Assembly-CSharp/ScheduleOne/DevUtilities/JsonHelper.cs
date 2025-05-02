using System;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006E2 RID: 1762
	public static class JsonHelper
	{
		// Token: 0x06003000 RID: 12288 RVA: 0x000C7F7E File Offset: 0x000C617E
		public static T[] FromJson<T>(string json)
		{
			return JsonUtility.FromJson<JsonHelper.Wrapper<T>>(json).Items;
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x000C7F8B File Offset: 0x000C618B
		public static string ToJson<T>(T[] array)
		{
			return JsonUtility.ToJson(new JsonHelper.Wrapper<T>
			{
				Items = array
			});
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x000C7F9E File Offset: 0x000C619E
		public static string ToJson<T>(T[] array, bool prettyPrint)
		{
			return JsonUtility.ToJson(new JsonHelper.Wrapper<T>
			{
				Items = array
			}, prettyPrint);
		}

		// Token: 0x020006E3 RID: 1763
		[Serializable]
		private class Wrapper<T>
		{
			// Token: 0x04002221 RID: 8737
			public T[] Items;
		}
	}
}
