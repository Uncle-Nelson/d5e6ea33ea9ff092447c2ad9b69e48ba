using System;
using Beautify.Universal;
using UnityEngine;

namespace Beautify.Demos
{
	// Token: 0x020001EE RID: 494
	public class ToggleDoF : MonoBehaviour
	{
		// Token: 0x06000AEB RID: 2795 RVA: 0x0003037C File Offset: 0x0002E57C
		private void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				bool value = BeautifySettings.settings.depthOfField.value;
				BeautifySettings.settings.depthOfField.Override(!value);
			}
		}
	}
}
