using System;

namespace VLB
{
	// Token: 0x02000157 RID: 343
	public static class Version
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x0001DA3D File Offset: 0x0001BC3D
		public static string CurrentAsString
		{
			get
			{
				return Version.GetVersionAsString(20100);
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0001DA4C File Offset: 0x0001BC4C
		private static string GetVersionAsString(int version)
		{
			int num = version / 10000;
			int num2 = (version - num * 10000) / 100;
			int num3 = (version - num * 10000 - num2 * 100) / 1;
			return string.Format("{0}.{1}.{2}", num, num2, num3);
		}

		// Token: 0x04000760 RID: 1888
		public const int Current = 20100;
	}
}
