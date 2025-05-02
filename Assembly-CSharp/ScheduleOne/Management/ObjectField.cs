using System;
using System.Collections.Generic;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000577 RID: 1399
	public class ObjectField : ConfigField
	{
		// Token: 0x060022C8 RID: 8904 RVA: 0x0008F059 File Offset: 0x0008D259
		public ObjectField(EntityConfiguration parentConfig) : base(parentConfig)
		{
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x0008F078 File Offset: 0x0008D278
		public void SetObject(BuildableItem obj, bool network)
		{
			if (this.SelectedObject == obj)
			{
				return;
			}
			if (this.SelectedObject != null)
			{
				this.SelectedObject.onDestroyed.RemoveListener(new UnityAction(this.SelectedObjectDestroyed));
			}
			this.SelectedObject = obj;
			if (this.SelectedObject != null)
			{
				this.SelectedObject.onDestroyed.AddListener(new UnityAction(this.SelectedObjectDestroyed));
			}
			if (network)
			{
				base.ParentConfig.ReplicateField(this, null);
			}
			if (this.onObjectChanged != null)
			{
				this.onObjectChanged.Invoke(obj);
			}
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x0008F113 File Offset: 0x0008D313
		public override bool IsValueDefault()
		{
			return this.SelectedObject == null;
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x0008F121 File Offset: 0x0008D321
		private void SelectedObjectDestroyed()
		{
			this.SetObject(null, false);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x0008F12C File Offset: 0x0008D32C
		public void Load(ObjectFieldData data)
		{
			if (data != null && !string.IsNullOrEmpty(data.ObjectGUID))
			{
				BuildableItem @object = GUIDManager.GetObject<BuildableItem>(new Guid(data.ObjectGUID));
				if (@object != null)
				{
					this.SetObject(@object, true);
				}
			}
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x0008F16C File Offset: 0x0008D36C
		public ObjectFieldData GetData()
		{
			return new ObjectFieldData((this.SelectedObject != null) ? this.SelectedObject.GUID.ToString() : "");
		}

		// Token: 0x04001A34 RID: 6708
		public BuildableItem SelectedObject;

		// Token: 0x04001A35 RID: 6709
		public UnityEvent<BuildableItem> onObjectChanged = new UnityEvent<BuildableItem>();

		// Token: 0x04001A36 RID: 6710
		public ObjectSelector.ObjectFilter objectFilter;

		// Token: 0x04001A37 RID: 6711
		public List<Type> TypeRequirements = new List<Type>();

		// Token: 0x04001A38 RID: 6712
		public bool DrawTransitLine;
	}
}
