using System;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200086C RID: 2156
	public class PlayAnimation : MonoBehaviour
	{
		// Token: 0x06003AC0 RID: 15040 RVA: 0x000F74F4 File Offset: 0x000F56F4
		[Button]
		public void Play()
		{
			base.GetComponent<Animation>().Play();
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x000F7502 File Offset: 0x000F5702
		public void Play(string animationName)
		{
			base.GetComponent<Animation>().Play(animationName);
		}
	}
}
