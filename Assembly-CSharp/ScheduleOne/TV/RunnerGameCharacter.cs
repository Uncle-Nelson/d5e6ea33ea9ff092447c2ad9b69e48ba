using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x0200029D RID: 669
	public class RunnerGameCharacter : MonoBehaviour
	{
		// Token: 0x06000DEB RID: 3563 RVA: 0x0003E5C4 File Offset: 0x0003C7C4
		public void OnTriggerEnter(Collider other)
		{
			if (other.gameObject.tag == "2DObstacle")
			{
				this.Game.PlayerCollided();
				if (this.onHit != null)
				{
					this.onHit.Invoke();
				}
			}
		}

		// Token: 0x04000E9F RID: 3743
		public RunnerGame Game;

		// Token: 0x04000EA0 RID: 3744
		public UnityEvent onHit;
	}
}
