using System;
using System.Collections.Generic;

namespace ScheduleOne.Management.Presets.Options
{
	// Token: 0x0200059E RID: 1438
	public class ItemList : Option
	{
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x000914E3 File Offset: 0x0008F6E3
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x000914EB File Offset: 0x0008F6EB
		public bool CanBeAll { get; protected set; } = true;

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x000914F4 File Offset: 0x0008F6F4
		// (set) Token: 0x060023B3 RID: 9139 RVA: 0x000914FC File Offset: 0x0008F6FC
		public bool CanBeNone { get; protected set; } = true;

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x00091505 File Offset: 0x0008F705
		// (set) Token: 0x060023B5 RID: 9141 RVA: 0x0009150D File Offset: 0x0008F70D
		public List<string> OptionList { get; protected set; } = new List<string>();

		// Token: 0x060023B6 RID: 9142 RVA: 0x00091518 File Offset: 0x0008F718
		public ItemList(string name, List<string> optionList, bool canBeAll, bool canBeNone) : base(name)
		{
			this.OptionList.AddRange(optionList);
			this.CanBeAll = canBeAll;
			this.CanBeNone = canBeNone;
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x0009156C File Offset: 0x0008F76C
		public override void CopyTo(Option other)
		{
			base.CopyTo(other);
			ItemList itemList = other as ItemList;
			itemList.All = this.All;
			itemList.None = this.None;
			itemList.Selection = new List<string>(this.Selection);
			itemList.CanBeAll = this.CanBeAll;
			itemList.CanBeNone = this.CanBeNone;
			itemList.OptionList = new List<string>(this.OptionList);
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x000915D8 File Offset: 0x0008F7D8
		public override string GetDisplayString()
		{
			if (this.All)
			{
				return "All";
			}
			if (this.None || this.Selection.Count == 0)
			{
				return "None";
			}
			List<string> list = new List<string>();
			for (int i = 0; i < this.Selection.Count; i++)
			{
				list.Add(Registry.GetItem(this.Selection[i]).Name);
			}
			return string.Join(", ", list);
		}

		// Token: 0x04001A9F RID: 6815
		public bool All;

		// Token: 0x04001AA0 RID: 6816
		public bool None;

		// Token: 0x04001AA1 RID: 6817
		public List<string> Selection = new List<string>();
	}
}
