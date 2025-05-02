using System;

namespace LiquidVolumeFX
{
	// Token: 0x0200017B RID: 379
	public static class DetailExtensions
	{
		// Token: 0x06000710 RID: 1808 RVA: 0x00020B0C File Offset: 0x0001ED0C
		public static bool allowsRefraction(this DETAIL detail)
		{
			return detail != DETAIL.DefaultNoFlask;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00020B16 File Offset: 0x0001ED16
		public static bool usesFlask(this DETAIL detail)
		{
			return detail == DETAIL.Simple || detail == DETAIL.Default;
		}
	}
}
