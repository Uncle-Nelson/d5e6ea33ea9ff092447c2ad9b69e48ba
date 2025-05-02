using System;

namespace ScheduleOne.Management.Presets.Options
{
	// Token: 0x0200059F RID: 1439
	public abstract class Option
	{
		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x00091651 File Offset: 0x0008F851
		// (set) Token: 0x060023BA RID: 9146 RVA: 0x00091659 File Offset: 0x0008F859
		public string Name { get; protected set; } = "OptionName";

		// Token: 0x060023BB RID: 9147 RVA: 0x00091662 File Offset: 0x0008F862
		public Option(string name)
		{
			this.Name = name;
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x0009167C File Offset: 0x0008F87C
		public virtual void CopyTo(Option other)
		{
			other.Name = this.Name;
		}

		// Token: 0x060023BD RID: 9149
		public abstract string GetDisplayString();
	}
}
