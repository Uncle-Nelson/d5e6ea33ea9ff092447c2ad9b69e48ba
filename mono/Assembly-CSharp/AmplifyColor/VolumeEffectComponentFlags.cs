using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace AmplifyColor
{
	// Token: 0x02000C53 RID: 3155
	[Serializable]
	public class VolumeEffectComponentFlags
	{
		// Token: 0x06005868 RID: 22632 RVA: 0x00172EB5 File Offset: 0x001710B5
		public VolumeEffectComponentFlags(string name)
		{
			this.componentName = name;
			this.componentFields = new List<VolumeEffectFieldFlags>();
		}

		// Token: 0x06005869 RID: 22633 RVA: 0x00172ED0 File Offset: 0x001710D0
		public VolumeEffectComponentFlags(VolumeEffectComponent comp) : this(comp.componentName)
		{
			this.blendFlag = true;
			foreach (VolumeEffectField volumeEffectField in comp.fields)
			{
				if (VolumeEffectField.IsValidType(volumeEffectField.fieldType))
				{
					this.componentFields.Add(new VolumeEffectFieldFlags(volumeEffectField));
				}
			}
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x00172F50 File Offset: 0x00171150
		public VolumeEffectComponentFlags(Component c)
		{
			Type type = c.GetType();
			this..ctor(((type != null) ? type.ToString() : null) ?? "");
			foreach (FieldInfo fieldInfo in c.GetType().GetFields())
			{
				if (VolumeEffectField.IsValidType(fieldInfo.FieldType.FullName))
				{
					this.componentFields.Add(new VolumeEffectFieldFlags(fieldInfo));
				}
			}
		}

		// Token: 0x0600586B RID: 22635 RVA: 0x00172FC0 File Offset: 0x001711C0
		public void UpdateComponentFlags(VolumeEffectComponent comp)
		{
			using (List<VolumeEffectField>.Enumerator enumerator = comp.fields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectField field = enumerator.Current;
					if (this.componentFields.Find((VolumeEffectFieldFlags s) => s.fieldName == field.fieldName) == null && VolumeEffectField.IsValidType(field.fieldType))
					{
						this.componentFields.Add(new VolumeEffectFieldFlags(field));
					}
				}
			}
		}

		// Token: 0x0600586C RID: 22636 RVA: 0x00173058 File Offset: 0x00171258
		public void UpdateComponentFlags(Component c)
		{
			FieldInfo[] fields = c.GetType().GetFields();
			for (int i = 0; i < fields.Length; i++)
			{
				FieldInfo pi = fields[i];
				if (!this.componentFields.Exists((VolumeEffectFieldFlags s) => s.fieldName == pi.Name) && VolumeEffectField.IsValidType(pi.FieldType.FullName))
				{
					this.componentFields.Add(new VolumeEffectFieldFlags(pi));
				}
			}
		}

		// Token: 0x0600586D RID: 22637 RVA: 0x001730D4 File Offset: 0x001712D4
		public string[] GetFieldNames()
		{
			return (from r in this.componentFields
			where r.blendFlag
			select r.fieldName).ToArray<string>();
		}

		// Token: 0x04004173 RID: 16755
		public string componentName;

		// Token: 0x04004174 RID: 16756
		public List<VolumeEffectFieldFlags> componentFields;

		// Token: 0x04004175 RID: 16757
		public bool blendFlag;
	}
}
