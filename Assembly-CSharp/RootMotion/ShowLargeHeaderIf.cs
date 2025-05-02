using System;

namespace RootMotion
{
	// Token: 0x02000020 RID: 32
	public class ShowLargeHeaderIf : ShowIfAttribute
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00007363 File Offset: 0x00005563
		public ShowLargeHeaderIf(string name, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden) : base(propertyName, propertyValue, otherPropertyValue, indent, mode)
		{
			this.name = name;
			this.color = "white";
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007390 File Offset: 0x00005590
		public ShowLargeHeaderIf(string name, string color, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden) : base(propertyName, propertyValue, otherPropertyValue, indent, mode)
		{
			this.name = name;
			this.color = color;
		}

		// Token: 0x040000D6 RID: 214
		public string name;

		// Token: 0x040000D7 RID: 215
		public string color = "white";
	}
}
