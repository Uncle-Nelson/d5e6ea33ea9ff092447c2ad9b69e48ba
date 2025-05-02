using System;
using System.Collections.Generic;
using FishNet.Connection;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x0200056B RID: 1387
	public class EntityConfiguration
	{
		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x0008DA7E File Offset: 0x0008BC7E
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x0008DA86 File Offset: 0x0008BC86
		public ConfigurationReplicator Replicator { get; protected set; }

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x0008DA8F File Offset: 0x0008BC8F
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x0008DA97 File Offset: 0x0008BC97
		public IConfigurable Configurable { get; protected set; }

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x0008DAA0 File Offset: 0x0008BCA0
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x0008DAA8 File Offset: 0x0008BCA8
		public bool IsSelected { get; protected set; }

		// Token: 0x06002252 RID: 8786 RVA: 0x0008DAB1 File Offset: 0x0008BCB1
		public EntityConfiguration(ConfigurationReplicator replicator, IConfigurable configurable)
		{
			this.Replicator = replicator;
			this.Replicator.Configuration = this;
			this.Configurable = configurable;
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x0008DAE9 File Offset: 0x0008BCE9
		protected void InvokeChanged()
		{
			if (this.onChanged != null)
			{
				this.onChanged.Invoke();
			}
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x0008DAFE File Offset: 0x0008BCFE
		public void ReplicateField(ConfigField field, NetworkConnection conn = null)
		{
			this.Replicator.ReplicateField(field, conn);
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x0008DB10 File Offset: 0x0008BD10
		public void ReplicateAllFields(NetworkConnection conn = null, bool replicateDefaults = true)
		{
			foreach (ConfigField configField in this.Fields)
			{
				if (replicateDefaults || !configField.IsValueDefault())
				{
					this.ReplicateField(configField, conn);
				}
			}
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void Destroy()
		{
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x0008DB70 File Offset: 0x0008BD70
		public virtual void Selected()
		{
			this.IsSelected = true;
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x0008DB79 File Offset: 0x0008BD79
		public virtual void Deselected()
		{
			this.IsSelected = false;
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x000141BA File Offset: 0x000123BA
		public virtual bool ShouldSave()
		{
			return false;
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x0003CEED File Offset: 0x0003B0ED
		public virtual string GetSaveString()
		{
			return string.Empty;
		}

		// Token: 0x040019FB RID: 6651
		public List<ConfigField> Fields = new List<ConfigField>();

		// Token: 0x040019FC RID: 6652
		public UnityEvent onChanged = new UnityEvent();
	}
}
