using System;
using UnityEngine;

namespace ScheduleOne.Management.Presets
{
	// Token: 0x0200059A RID: 1434
	public abstract class Preset
	{
		// Token: 0x060023A0 RID: 9120 RVA: 0x00091438 File Offset: 0x0008F638
		public Preset()
		{
			this.InitializeOptions();
		}

		// Token: 0x060023A1 RID: 9121
		public abstract Preset GetCopy();

		// Token: 0x060023A2 RID: 9122 RVA: 0x00091470 File Offset: 0x0008F670
		public virtual void CopyTo(Preset other)
		{
			other.PresetName = this.PresetName;
			other.PresetColor = this.PresetColor;
		}

		// Token: 0x060023A3 RID: 9123
		public abstract void InitializeOptions();

		// Token: 0x060023A4 RID: 9124 RVA: 0x0009148A File Offset: 0x0008F68A
		public void SetName(string newName)
		{
			if (this.PresetName == newName)
			{
				return;
			}
			this.PresetName = newName;
			if (this.onNameChanged != null)
			{
				this.onNameChanged(newName);
			}
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x000914B6 File Offset: 0x0008F6B6
		public void DeletePreset(Preset replacement)
		{
			if (this.onDeleted != null)
			{
				this.onDeleted(replacement);
			}
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x000914CC File Offset: 0x0008F6CC
		public static Preset GetDefault(ManageableObjectType type)
		{
			if (type == ManageableObjectType.Pot)
			{
				return PotPreset.GetDefaultPreset();
			}
			Console.LogWarning("GetDefault: type not accounted for", null);
			return null;
		}

		// Token: 0x04001A97 RID: 6807
		public string PresetName = "Default";

		// Token: 0x04001A98 RID: 6808
		public Color32 PresetColor = new Color32(180, 180, 180, byte.MaxValue);

		// Token: 0x04001A99 RID: 6809
		public ManageableObjectType ObjectType;

		// Token: 0x04001A9A RID: 6810
		public Preset.NameChange onNameChanged;

		// Token: 0x04001A9B RID: 6811
		public Preset.PresetDeletion onDeleted;

		// Token: 0x0200059B RID: 1435
		// (Invoke) Token: 0x060023A8 RID: 9128
		public delegate void NameChange(string name);

		// Token: 0x0200059C RID: 1436
		// (Invoke) Token: 0x060023AC RID: 9132
		public delegate void PresetDeletion(Preset replacement);
	}
}
