using System;
using UnityEngine;
using VLB;

namespace VLB_Samples
{
	// Token: 0x0200015E RID: 350
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x0001E555 File Offset: 0x0001C755
		private void Start()
		{
			if (!Noise3D.isSupported)
			{
				Debug.LogWarning(Noise3D.isNotSupportedString);
			}
		}
	}
}
