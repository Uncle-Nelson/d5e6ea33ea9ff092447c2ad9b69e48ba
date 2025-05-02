using System;
using UnityEngine;

namespace EasyButtons.Example
{
	// Token: 0x020001EB RID: 491
	public class CustomEditorButtonsExample : MonoBehaviour
	{
		// Token: 0x06000AE0 RID: 2784 RVA: 0x000300CB File Offset: 0x0002E2CB
		[Button("Custom Editor Example")]
		private void SayHello()
		{
			Debug.Log("Hello from custom editor");
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000300D7 File Offset: 0x0002E2D7
		[Button]
		private void SecondButton()
		{
			Debug.Log("Second button of the custom editor.");
		}
	}
}
