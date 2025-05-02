using System;
using System.Collections.Generic;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000569 RID: 1385
	public class CleanerConfiguration : EntityConfiguration
	{
		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x0008D55E File Offset: 0x0008B75E
		// (set) Token: 0x06002230 RID: 8752 RVA: 0x0008D566 File Offset: 0x0008B766
		public Cleaner cleaner { get; protected set; }

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06002231 RID: 8753 RVA: 0x0008D56F File Offset: 0x0008B76F
		// (set) Token: 0x06002232 RID: 8754 RVA: 0x0008D577 File Offset: 0x0008B777
		public List<TrashContainerItem> binItems { get; private set; } = new List<TrashContainerItem>();

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x0008D580 File Offset: 0x0008B780
		// (set) Token: 0x06002234 RID: 8756 RVA: 0x0008D588 File Offset: 0x0008B788
		public BedItem bedItem { get; private set; }

		// Token: 0x06002235 RID: 8757 RVA: 0x0008D594 File Offset: 0x0008B794
		public CleanerConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Cleaner _cleaner) : base(replicator, configurable)
		{
			this.cleaner = _cleaner;
			this.Bed = new ObjectField(this);
			this.Bed.TypeRequirements = new List<Type>
			{
				typeof(BedItem)
			};
			this.Bed.onObjectChanged.AddListener(new UnityAction<BuildableItem>(this.BedChanged));
			this.Bed.objectFilter = new ObjectSelector.ObjectFilter(BedItem.IsBedValid);
			this.Bins = new ObjectListField(this);
			this.Bins.MaxItems = 3;
			this.Bins.onListChanged.AddListener(new UnityAction<List<BuildableItem>>(delegate(List<BuildableItem> <p0>)
			{
				base.InvokeChanged();
			}));
			this.Bins.onListChanged.AddListener(new UnityAction<List<BuildableItem>>(this.AssignedBinsChanged));
			this.Bins.objectFilter = new ObjectSelector.ObjectFilter(this.IsObjValid);
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x0008D681 File Offset: 0x0008B881
		public override void Destroy()
		{
			base.Destroy();
			this.Bed.SetObject(null, false);
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x0008D698 File Offset: 0x0008B898
		private bool IsObjValid(BuildableItem obj, out string reason)
		{
			TrashContainerItem trashContainerItem = obj as TrashContainerItem;
			if (trashContainerItem == null)
			{
				reason = string.Empty;
				return false;
			}
			if (!trashContainerItem.UsableByCleaners)
			{
				reason = "This trash can is not usable by cleaners.";
				return false;
			}
			reason = string.Empty;
			return true;
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x0008D6D8 File Offset: 0x0008B8D8
		public void AssignedBinsChanged(List<BuildableItem> objects)
		{
			for (int i = 0; i < this.binItems.Count; i++)
			{
				if (!objects.Contains(this.binItems[i]))
				{
					this.binItems.RemoveAt(i);
					i--;
				}
			}
			for (int j = 0; j < objects.Count; j++)
			{
				if (!this.binItems.Contains(objects[j] as TrashContainerItem))
				{
					this.binItems.Add(objects[j] as TrashContainerItem);
				}
			}
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x0008D760 File Offset: 0x0008B960
		public override bool ShouldSave()
		{
			return this.Bed.SelectedObject != null || this.Bins.SelectedObjects.Count > 0 || base.ShouldSave();
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x0008D792 File Offset: 0x0008B992
		public override string GetSaveString()
		{
			return new CleanerConfigurationData(this.Bed.GetData(), this.Bins.GetData()).GetJson(true);
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x0008D7B8 File Offset: 0x0008B9B8
		private void BedChanged(BuildableItem newItem)
		{
			BedItem bedItem = this.bedItem;
			if (bedItem != null)
			{
				bedItem.Bed.SetAssignedEmployee(null);
			}
			this.bedItem = ((newItem != null) ? (newItem as BedItem) : null);
			if (this.bedItem != null)
			{
				this.bedItem.Bed.SetAssignedEmployee(this.cleaner);
			}
			base.InvokeChanged();
		}

		// Token: 0x040019EF RID: 6639
		public ObjectField Bed;

		// Token: 0x040019F0 RID: 6640
		public ObjectListField Bins;
	}
}
