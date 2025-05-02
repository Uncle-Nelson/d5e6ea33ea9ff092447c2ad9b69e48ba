using System;
using UnityEngine;

namespace EasyButtons.Example
{
	// Token: 0x020001EA RID: 490
	public class ButtonsExample : MonoBehaviour
	{
		// Token: 0x06000AD6 RID: 2774 RVA: 0x00030056 File Offset: 0x0002E256
		[Button]
		public void SayMyName()
		{
			Debug.Log(base.name);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00030063 File Offset: 0x0002E263
		[Button(Mode = 2)]
		protected void SayHelloEditor()
		{
			Debug.Log("Hello from edit mode");
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0003006F File Offset: 0x0002E26F
		[Button(Mode = 1)]
		private void SayHelloInRuntime()
		{
			Debug.Log("Hello from play mode");
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0003007B File Offset: 0x0002E27B
		[Button("Special Name", Spacing = 1)]
		private void TestButtonName()
		{
			Debug.Log("Hello from special name button");
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00030087 File Offset: 0x0002E287
		[Button("Special Name Editor Only", Mode = 2)]
		private void TestButtonNameEditorOnly()
		{
			Debug.Log("Hello from special name button for editor only");
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00030093 File Offset: 0x0002E293
		[Button]
		private static void TestStaticMethod()
		{
			Debug.Log("Hello from static method");
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0003009F File Offset: 0x0002E29F
		[Button("Space Before and After", Spacing = 3)]
		private void TestButtonSpaceBoth()
		{
			Debug.Log("Hello from a button surround by spaces");
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x000300AB File Offset: 0x0002E2AB
		[Button("Button With Parameters")]
		private void TestButtonWithParams(string message, int number)
		{
			Debug.Log(string.Format("Your message #{0}: \"{1}\"", number, message));
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x000300C3 File Offset: 0x0002E2C3
		[Button("Expanded Button Example", Expanded = true)]
		private void TestExpandedButton(string message)
		{
			Debug.Log(message);
		}
	}
}
