using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000135 RID: 309
	public class PlatformHelper
	{
		// Token: 0x0600053E RID: 1342 RVA: 0x000196EF File Offset: 0x000178EF
		public static string GetCurrentPlatformSuffix()
		{
			return PlatformHelper.GetPlatformSuffix(Application.platform);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000196FB File Offset: 0x000178FB
		private static string GetPlatformSuffix(RuntimePlatform platform)
		{
			return platform.ToString();
		}
	}
}
