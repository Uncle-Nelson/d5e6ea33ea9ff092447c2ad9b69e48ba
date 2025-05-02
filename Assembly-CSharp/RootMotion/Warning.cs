using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000028 RID: 40
	public static class Warning
	{
		// Token: 0x06000145 RID: 325 RVA: 0x000083EC File Offset: 0x000065EC
		public static void Log(string message, Warning.Logger logger, bool logInEditMode = false)
		{
			if (!logInEditMode && !Application.isPlaying)
			{
				return;
			}
			if (Warning.logged)
			{
				return;
			}
			if (logger != null)
			{
				logger(message);
			}
			Warning.logged = true;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00008411 File Offset: 0x00006611
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
			if (!logInEditMode && !Application.isPlaying)
			{
				return;
			}
			if (Warning.logged)
			{
				return;
			}
			Debug.LogWarning(message, context);
			Warning.logged = true;
		}

		// Token: 0x040000E2 RID: 226
		public static bool logged;

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x06000665 RID: 1637
		public delegate void Logger(string message);
	}
}
