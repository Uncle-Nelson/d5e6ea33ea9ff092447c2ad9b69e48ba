using System;
using System.Collections.Generic;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003D9 RID: 985
	[Serializable]
	public class GenericSaveData : SaveData
	{
		// Token: 0x06001540 RID: 5440 RVA: 0x0005F64C File Offset: 0x0005D84C
		public GenericSaveData(string guid)
		{
			this.GUID = guid;
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x0005F69D File Offset: 0x0005D89D
		public void Add(string key, bool value)
		{
			this.boolValues.Add(new GenericSaveData.BoolValue
			{
				key = key,
				value = value
			});
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0005F6BD File Offset: 0x0005D8BD
		public void Add(string key, float value)
		{
			this.floatValues.Add(new GenericSaveData.FloatValue
			{
				key = key,
				value = value
			});
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0005F6DD File Offset: 0x0005D8DD
		public void Add(string key, int value)
		{
			this.intValues.Add(new GenericSaveData.IntValue
			{
				key = key,
				value = value
			});
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0005F6FD File Offset: 0x0005D8FD
		public void Add(string key, string value)
		{
			this.stringValues.Add(new GenericSaveData.StringValue
			{
				key = key,
				value = value
			});
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0005F720 File Offset: 0x0005D920
		public bool GetBool(string key, bool defaultValue = false)
		{
			GenericSaveData.BoolValue boolValue = this.boolValues.Find((GenericSaveData.BoolValue x) => x.key == key);
			if (boolValue != null)
			{
				return boolValue.value;
			}
			return defaultValue;
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0005F760 File Offset: 0x0005D960
		public float GetFloat(string key, float defaultValue = 0f)
		{
			GenericSaveData.FloatValue floatValue = this.floatValues.Find((GenericSaveData.FloatValue x) => x.key == key);
			if (floatValue != null)
			{
				return floatValue.value;
			}
			return defaultValue;
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0005F7A0 File Offset: 0x0005D9A0
		public int GetInt(string key, int defaultValue = 0)
		{
			GenericSaveData.IntValue intValue = this.intValues.Find((GenericSaveData.IntValue x) => x.key == key);
			if (intValue != null)
			{
				return intValue.value;
			}
			return defaultValue;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0005F7E0 File Offset: 0x0005D9E0
		public string GetString(string key, string defaultValue = "")
		{
			GenericSaveData.StringValue stringValue = this.stringValues.Find((GenericSaveData.StringValue x) => x.key == key);
			if (stringValue != null)
			{
				return stringValue.value;
			}
			return defaultValue;
		}

		// Token: 0x04001389 RID: 5001
		public string GUID = string.Empty;

		// Token: 0x0400138A RID: 5002
		public List<GenericSaveData.BoolValue> boolValues = new List<GenericSaveData.BoolValue>();

		// Token: 0x0400138B RID: 5003
		public List<GenericSaveData.FloatValue> floatValues = new List<GenericSaveData.FloatValue>();

		// Token: 0x0400138C RID: 5004
		public List<GenericSaveData.IntValue> intValues = new List<GenericSaveData.IntValue>();

		// Token: 0x0400138D RID: 5005
		public List<GenericSaveData.StringValue> stringValues = new List<GenericSaveData.StringValue>();

		// Token: 0x020003DA RID: 986
		[Serializable]
		public class BoolValue
		{
			// Token: 0x0400138E RID: 5006
			public string key;

			// Token: 0x0400138F RID: 5007
			public bool value;
		}

		// Token: 0x020003DB RID: 987
		[Serializable]
		public class FloatValue
		{
			// Token: 0x04001390 RID: 5008
			public string key;

			// Token: 0x04001391 RID: 5009
			public float value;
		}

		// Token: 0x020003DC RID: 988
		[Serializable]
		public class IntValue
		{
			// Token: 0x04001392 RID: 5010
			public string key;

			// Token: 0x04001393 RID: 5011
			public int value;
		}

		// Token: 0x020003DD RID: 989
		[Serializable]
		public class StringValue
		{
			// Token: 0x04001394 RID: 5012
			public string key;

			// Token: 0x04001395 RID: 5013
			public string value;
		}
	}
}
