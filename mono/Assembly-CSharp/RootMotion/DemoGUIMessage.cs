using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000016 RID: 22
	public class DemoGUIMessage : MonoBehaviour
	{
		// Token: 0x060000AD RID: 173 RVA: 0x000063CA File Offset: 0x000045CA
		private void OnGUI()
		{
			GUI.color = this.color;
			GUILayout.Label(this.text, Array.Empty<GUILayoutOption>());
			GUI.color = Color.white;
		}

		// Token: 0x040000AB RID: 171
		public string text;

		// Token: 0x040000AC RID: 172
		public Color color = Color.white;
	}
}
