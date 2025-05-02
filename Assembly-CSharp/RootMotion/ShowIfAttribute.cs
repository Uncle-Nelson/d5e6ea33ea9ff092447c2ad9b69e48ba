using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200001E RID: 30
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowIfAttribute : PropertyAttribute
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000072A0 File Offset: 0x000054A0
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000072A8 File Offset: 0x000054A8
		public string propName { get; protected set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000072B1 File Offset: 0x000054B1
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000072B9 File Offset: 0x000054B9
		public object propValue { get; protected set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000072C2 File Offset: 0x000054C2
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000072CA File Offset: 0x000054CA
		public object otherPropValue { get; protected set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000072D3 File Offset: 0x000054D3
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x000072DB File Offset: 0x000054DB
		public bool indent { get; private set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000072E4 File Offset: 0x000054E4
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x000072EC File Offset: 0x000054EC
		public ShowIfMode mode { get; protected set; }

		// Token: 0x060000F5 RID: 245 RVA: 0x000072F5 File Offset: 0x000054F5
		public ShowIfAttribute(string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
			this.propName = propertyName;
			this.propValue = propertyValue;
			this.otherPropValue = otherPropertyValue;
			this.indent = indent;
			this.mode = mode;
		}
	}
}
