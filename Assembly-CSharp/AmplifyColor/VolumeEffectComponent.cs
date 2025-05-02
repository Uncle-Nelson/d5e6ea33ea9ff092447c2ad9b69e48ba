using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace AmplifyColor
{
	// Token: 0x02000C4B RID: 3147
	[Serializable]
	public class VolumeEffectComponent
	{
		// Token: 0x06005840 RID: 22592 RVA: 0x00172084 File Offset: 0x00170284
		public VolumeEffectComponent(string name)
		{
			this.componentName = name;
			this.fields = new List<VolumeEffectField>();
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x0017209E File Offset: 0x0017029E
		public VolumeEffectField AddField(FieldInfo pi, Component c)
		{
			return this.AddField(pi, c, -1);
		}

		// Token: 0x06005842 RID: 22594 RVA: 0x001720AC File Offset: 0x001702AC
		public VolumeEffectField AddField(FieldInfo pi, Component c, int position)
		{
			VolumeEffectField volumeEffectField = VolumeEffectField.IsValidType(pi.FieldType.FullName) ? new VolumeEffectField(pi, c) : null;
			if (volumeEffectField != null)
			{
				if (position < 0 || position >= this.fields.Count)
				{
					this.fields.Add(volumeEffectField);
				}
				else
				{
					this.fields.Insert(position, volumeEffectField);
				}
			}
			return volumeEffectField;
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x00172107 File Offset: 0x00170307
		public void RemoveEffectField(VolumeEffectField field)
		{
			this.fields.Remove(field);
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x00172118 File Offset: 0x00170318
		public VolumeEffectComponent(Component c, VolumeEffectComponentFlags compFlags) : this(compFlags.componentName)
		{
			foreach (VolumeEffectFieldFlags volumeEffectFieldFlags in compFlags.componentFields)
			{
				if (volumeEffectFieldFlags.blendFlag)
				{
					FieldInfo field = c.GetType().GetField(volumeEffectFieldFlags.fieldName);
					VolumeEffectField volumeEffectField = VolumeEffectField.IsValidType(field.FieldType.FullName) ? new VolumeEffectField(field, c) : null;
					if (volumeEffectField != null)
					{
						this.fields.Add(volumeEffectField);
					}
				}
			}
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x001721B8 File Offset: 0x001703B8
		public void UpdateComponent(Component c, VolumeEffectComponentFlags compFlags)
		{
			using (List<VolumeEffectFieldFlags>.Enumerator enumerator = compFlags.componentFields.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectFieldFlags fieldFlags = enumerator.Current;
					if (fieldFlags.blendFlag && !this.fields.Exists((VolumeEffectField s) => s.fieldName == fieldFlags.fieldName))
					{
						FieldInfo field = c.GetType().GetField(fieldFlags.fieldName);
						VolumeEffectField volumeEffectField = VolumeEffectField.IsValidType(field.FieldType.FullName) ? new VolumeEffectField(field, c) : null;
						if (volumeEffectField != null)
						{
							this.fields.Add(volumeEffectField);
						}
					}
				}
			}
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x0017227C File Offset: 0x0017047C
		public VolumeEffectField FindEffectField(string fieldName)
		{
			for (int i = 0; i < this.fields.Count; i++)
			{
				if (this.fields[i].fieldName == fieldName)
				{
					return this.fields[i];
				}
			}
			return null;
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x001722C8 File Offset: 0x001704C8
		public static FieldInfo[] ListAcceptableFields(Component c)
		{
			if (c == null)
			{
				return new FieldInfo[0];
			}
			return (from f in c.GetType().GetFields()
			where VolumeEffectField.IsValidType(f.FieldType.FullName)
			select f).ToArray<FieldInfo>();
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x00172319 File Offset: 0x00170519
		public string[] GetFieldNames()
		{
			return (from r in this.fields
			select r.fieldName).ToArray<string>();
		}

		// Token: 0x04004162 RID: 16738
		public string componentName;

		// Token: 0x04004163 RID: 16739
		public List<VolumeEffectField> fields;
	}
}
