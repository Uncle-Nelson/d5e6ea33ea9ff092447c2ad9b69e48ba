using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000C6 RID: 198
	public class ApplicationQuit : MonoBehaviour
	{
		// Token: 0x0600064B RID: 1611 RVA: 0x0002ACFB File Offset: 0x00028EFB
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Escape))
			{
				Application.Quit();
			}
		}
	}
}
