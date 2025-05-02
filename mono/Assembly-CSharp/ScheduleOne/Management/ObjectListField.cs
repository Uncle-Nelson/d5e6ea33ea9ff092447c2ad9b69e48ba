using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000578 RID: 1400
	public class ObjectListField : ConfigField
	{
		// Token: 0x060022CE RID: 8910 RVA: 0x0008F1AC File Offset: 0x0008D3AC
		public ObjectListField(EntityConfiguration parentConfig) : base(parentConfig)
		{
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x0008F1E0 File Offset: 0x0008D3E0
		public void SetList(List<BuildableItem> list, bool network)
		{
			if (this.SelectedObjects.SequenceEqual(list))
			{
				return;
			}
			for (int i = 0; i < this.SelectedObjects.Count; i++)
			{
				if (!(this.SelectedObjects[i] == null))
				{
					BuildableItem buildableItem = this.SelectedObjects[i];
					buildableItem.onDestroyedWithParameter = (Action<BuildableItem>)Delegate.Remove(buildableItem.onDestroyedWithParameter, new Action<BuildableItem>(this.SelectedObjectDestroyed));
				}
			}
			this.SelectedObjects = new List<BuildableItem>();
			this.SelectedObjects.AddRange(list);
			for (int j = 0; j < this.SelectedObjects.Count; j++)
			{
				if (!(this.SelectedObjects[j] == null))
				{
					BuildableItem buildableItem2 = this.SelectedObjects[j];
					buildableItem2.onDestroyedWithParameter = (Action<BuildableItem>)Delegate.Combine(buildableItem2.onDestroyedWithParameter, new Action<BuildableItem>(this.SelectedObjectDestroyed));
				}
			}
			if (network)
			{
				base.ParentConfig.ReplicateField(this, null);
			}
			if (this.onListChanged != null)
			{
				this.onListChanged.Invoke(list);
			}
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x0008F2E8 File Offset: 0x0008D4E8
		public void AddItem(BuildableItem item)
		{
			if (this.SelectedObjects.Contains(item))
			{
				return;
			}
			if (this.SelectedObjects.Count >= this.MaxItems)
			{
				Console.LogWarning(item.ItemInstance.Name + " cannot be added to " + base.ParentConfig.GetType().Name + " because the maximum number of items has been reached", null);
				return;
			}
			this.SetList(new List<BuildableItem>(this.SelectedObjects)
			{
				item
			}, true);
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x0008F364 File Offset: 0x0008D564
		public void RemoveItem(BuildableItem item)
		{
			if (!this.SelectedObjects.Contains(item))
			{
				return;
			}
			List<BuildableItem> list = new List<BuildableItem>(this.SelectedObjects);
			list.Remove(item);
			this.SetList(list, true);
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x0008F39C File Offset: 0x0008D59C
		private void SelectedObjectDestroyed(BuildableItem item)
		{
			if (item == null)
			{
				return;
			}
			Console.Log("Removing destroyed object from " + base.ParentConfig.GetType().Name, null);
			this.RemoveItem(item);
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x0008F3CF File Offset: 0x0008D5CF
		public override bool IsValueDefault()
		{
			return this.SelectedObjects.Count == 0;
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x0008F3E0 File Offset: 0x0008D5E0
		public ObjectListFieldData GetData()
		{
			List<string> list = new List<string>();
			for (int i = 0; i < this.SelectedObjects.Count; i++)
			{
				list.Add(this.SelectedObjects[i].GUID.ToString());
			}
			return new ObjectListFieldData(list);
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x0008F434 File Offset: 0x0008D634
		public void Load(ObjectListFieldData data)
		{
			if (data != null)
			{
				List<BuildableItem> list = new List<BuildableItem>();
				for (int i = 0; i < data.ObjectGUIDs.Count; i++)
				{
					if (!string.IsNullOrEmpty(data.ObjectGUIDs[i]))
					{
						BuildableItem @object = GUIDManager.GetObject<BuildableItem>(new Guid(data.ObjectGUIDs[i]));
						if (@object != null)
						{
							list.Add(@object);
						}
					}
				}
				this.SetList(list, true);
			}
		}

		// Token: 0x04001A39 RID: 6713
		public List<BuildableItem> SelectedObjects = new List<BuildableItem>();

		// Token: 0x04001A3A RID: 6714
		public int MaxItems = 1;

		// Token: 0x04001A3B RID: 6715
		public ObjectSelector.ObjectFilter objectFilter;

		// Token: 0x04001A3C RID: 6716
		public List<Type> TypeRequirements = new List<Type>();

		// Token: 0x04001A3D RID: 6717
		public UnityEvent<List<BuildableItem>> onListChanged = new UnityEvent<List<BuildableItem>>();
	}
}
