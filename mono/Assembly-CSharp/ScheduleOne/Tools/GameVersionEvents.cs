using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x0200085E RID: 2142
	public class GameVersionEvents : MonoBehaviour
	{
		// Token: 0x06003A88 RID: 14984 RVA: 0x000F6E7C File Offset: 0x000F507C
		private void Start()
		{
			if (this.onFullGame != null)
			{
				this.onFullGame.Invoke();
			}
		}

		// Token: 0x04002A1F RID: 10783
		public UnityEvent onFullGame;

		// Token: 0x04002A20 RID: 10784
		public UnityEvent onDemoGame;
	}
}
