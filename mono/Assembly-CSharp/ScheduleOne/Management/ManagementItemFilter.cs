using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Management
{
	// Token: 0x0200058E RID: 1422
	public class ManagementItemFilter
	{
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x00090991 File Offset: 0x0008EB91
		// (set) Token: 0x06002363 RID: 9059 RVA: 0x00090999 File Offset: 0x0008EB99
		public ManagementItemFilter.EMode Mode { get; private set; } = ManagementItemFilter.EMode.Blacklist;

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x000909A2 File Offset: 0x0008EBA2
		// (set) Token: 0x06002365 RID: 9061 RVA: 0x000909AA File Offset: 0x0008EBAA
		public List<ItemDefinition> Items { get; private set; } = new List<ItemDefinition>();

		// Token: 0x06002366 RID: 9062 RVA: 0x000909B3 File Offset: 0x0008EBB3
		public ManagementItemFilter(ManagementItemFilter.EMode mode)
		{
			this.Mode = mode;
			this.Items = new List<ItemDefinition>();
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x000909DF File Offset: 0x0008EBDF
		public void SetMode(ManagementItemFilter.EMode mode)
		{
			this.Mode = mode;
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x000909E8 File Offset: 0x0008EBE8
		public void AddItem(ItemDefinition item)
		{
			this.Items.Add(item);
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x000909F6 File Offset: 0x0008EBF6
		public void RemoveItem(ItemDefinition item)
		{
			this.Items.Remove(item);
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x00090A05 File Offset: 0x0008EC05
		public bool Contains(ItemDefinition item)
		{
			return this.Items.Contains(item);
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x00090A13 File Offset: 0x0008EC13
		public bool DoesItemMeetFilter(ItemInstance item)
		{
			if (this.Mode != ManagementItemFilter.EMode.Whitelist)
			{
				return !this.Items.Contains(item.Definition);
			}
			return this.Items.Contains(item.Definition);
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00090A44 File Offset: 0x0008EC44
		public string GetDescription()
		{
			if (this.Mode == ManagementItemFilter.EMode.Blacklist)
			{
				if (this.Items.Count == 0)
				{
					return "All";
				}
				return this.Items.Count.ToString() + " blacklisted";
			}
			else
			{
				if (this.Items.Count == 0)
				{
					return "None";
				}
				return this.Items.Count.ToString() + " whitelisted";
			}
		}

		// Token: 0x0200058F RID: 1423
		public enum EMode
		{
			// Token: 0x04001A7E RID: 6782
			Whitelist,
			// Token: 0x04001A7F RID: 6783
			Blacklist
		}
	}
}
