using System;

namespace ScheduleOne.Management
{
	// Token: 0x02000573 RID: 1395
	public abstract class ConfigField
	{
		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x0008ED5F File Offset: 0x0008CF5F
		// (set) Token: 0x060022A8 RID: 8872 RVA: 0x0008ED67 File Offset: 0x0008CF67
		public EntityConfiguration ParentConfig { get; protected set; }

		// Token: 0x060022A9 RID: 8873 RVA: 0x0008ED70 File Offset: 0x0008CF70
		public ConfigField(EntityConfiguration parentConfig)
		{
			this.ParentConfig = parentConfig;
			this.ParentConfig.Fields.Add(this);
		}

		// Token: 0x060022AA RID: 8874
		public abstract bool IsValueDefault();
	}
}
