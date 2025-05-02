using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000B3 RID: 179
	public class GrounderDemo : MonoBehaviour
	{
		// Token: 0x060005E7 RID: 1511 RVA: 0x00027FFC File Offset: 0x000261FC
		private void OnGUI()
		{
			if (GUILayout.Button("Biped", Array.Empty<GUILayoutOption>()))
			{
				this.Activate(0);
			}
			if (GUILayout.Button("Quadruped", Array.Empty<GUILayoutOption>()))
			{
				this.Activate(1);
			}
			if (GUILayout.Button("Mech", Array.Empty<GUILayoutOption>()))
			{
				this.Activate(2);
			}
			if (GUILayout.Button("Bot", Array.Empty<GUILayoutOption>()))
			{
				this.Activate(3);
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0002806C File Offset: 0x0002626C
		public void Activate(int index)
		{
			for (int i = 0; i < this.characters.Length; i++)
			{
				this.characters[i].SetActive(i == index);
			}
		}

		// Token: 0x04000517 RID: 1303
		public GameObject[] characters;
	}
}
