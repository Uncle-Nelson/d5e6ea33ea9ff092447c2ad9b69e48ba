using System;
using System.Reflection;
using UnityEngine;

namespace AmplifyColor
{
	// Token: 0x02000C4A RID: 3146
	[Serializable]
	public class VolumeEffectField
	{
		// Token: 0x0600583C RID: 22588 RVA: 0x00171F29 File Offset: 0x00170129
		public VolumeEffectField(string fieldName, string fieldType)
		{
			this.fieldName = fieldName;
			this.fieldType = fieldType;
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x00171F40 File Offset: 0x00170140
		public VolumeEffectField(FieldInfo pi, Component c) : this(pi.Name, pi.FieldType.FullName)
		{
			object value = pi.GetValue(c);
			this.UpdateValue(value);
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x00171F74 File Offset: 0x00170174
		public static bool IsValidType(string type)
		{
			return type == "System.Single" || type == "System.Boolean" || type == "UnityEngine.Color" || type == "UnityEngine.Vector2" || type == "UnityEngine.Vector3" || type == "UnityEngine.Vector4";
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x00171FD4 File Offset: 0x001701D4
		public void UpdateValue(object val)
		{
			string a = this.fieldType;
			if (a == "System.Single")
			{
				this.valueSingle = (float)val;
				return;
			}
			if (a == "System.Boolean")
			{
				this.valueBoolean = (bool)val;
				return;
			}
			if (a == "UnityEngine.Color")
			{
				this.valueColor = (Color)val;
				return;
			}
			if (a == "UnityEngine.Vector2")
			{
				this.valueVector2 = (Vector2)val;
				return;
			}
			if (a == "UnityEngine.Vector3")
			{
				this.valueVector3 = (Vector3)val;
				return;
			}
			if (!(a == "UnityEngine.Vector4"))
			{
				return;
			}
			this.valueVector4 = (Vector4)val;
		}

		// Token: 0x0400415A RID: 16730
		public string fieldName;

		// Token: 0x0400415B RID: 16731
		public string fieldType;

		// Token: 0x0400415C RID: 16732
		public float valueSingle;

		// Token: 0x0400415D RID: 16733
		public Color valueColor;

		// Token: 0x0400415E RID: 16734
		public bool valueBoolean;

		// Token: 0x0400415F RID: 16735
		public Vector2 valueVector2;

		// Token: 0x04004160 RID: 16736
		public Vector3 valueVector3;

		// Token: 0x04004161 RID: 16737
		public Vector4 valueVector4;
	}
}
