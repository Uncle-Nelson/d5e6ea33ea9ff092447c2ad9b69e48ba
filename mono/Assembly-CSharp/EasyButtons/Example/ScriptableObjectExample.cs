using System;
using UnityEngine;

namespace EasyButtons.Example
{
	// Token: 0x020001EC RID: 492
	[CreateAssetMenu(fileName = "ScriptableObjectExample.asset", menuName = "EasyButtons/ScriptableObjectExample")]
	public class ScriptableObjectExample : ScriptableObject
	{
		// Token: 0x06000AE3 RID: 2787 RVA: 0x000300E3 File Offset: 0x0002E2E3
		[Button]
		public void SayHello()
		{
			Debug.Log("Hello");
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00030063 File Offset: 0x0002E263
		[Button(Mode = 2)]
		public void SayHelloEditor()
		{
			Debug.Log("Hello from edit mode");
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0003006F File Offset: 0x0002E26F
		[Button(Mode = 1)]
		public void SayHelloPlayMode()
		{
			Debug.Log("Hello from play mode");
		}
	}
}
