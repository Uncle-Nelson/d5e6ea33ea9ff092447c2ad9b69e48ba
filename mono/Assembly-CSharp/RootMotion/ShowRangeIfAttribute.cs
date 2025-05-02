using System;

namespace RootMotion
{
	// Token: 0x0200001F RID: 31
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowRangeIfAttribute : ShowIfAttribute
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00007322 File Offset: 0x00005522
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000732A File Offset: 0x0000552A
		public float min { get; private set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00007333 File Offset: 0x00005533
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000733B File Offset: 0x0000553B
		public float max { get; private set; }

		// Token: 0x060000FA RID: 250 RVA: 0x00007344 File Offset: 0x00005544
		public ShowRangeIfAttribute(float min, float max, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden) : base(propertyName, propertyValue, otherPropertyValue, indent, mode)
		{
			this.min = min;
			this.max = max;
		}
	}
}
