using System;
using System.Reflection;

namespace AmplifyColor
{
	// Token: 0x02000C52 RID: 3154
	[Serializable]
	public class VolumeEffectFieldFlags
	{
		// Token: 0x06005866 RID: 22630 RVA: 0x00172E69 File Offset: 0x00171069
		public VolumeEffectFieldFlags(FieldInfo pi)
		{
			this.fieldName = pi.Name;
			this.fieldType = pi.FieldType.FullName;
		}

		// Token: 0x06005867 RID: 22631 RVA: 0x00172E8E File Offset: 0x0017108E
		public VolumeEffectFieldFlags(VolumeEffectField field)
		{
			this.fieldName = field.fieldName;
			this.fieldType = field.fieldType;
			this.blendFlag = true;
		}

		// Token: 0x04004170 RID: 16752
		public string fieldName;

		// Token: 0x04004171 RID: 16753
		public string fieldType;

		// Token: 0x04004172 RID: 16754
		public bool blendFlag;
	}
}
