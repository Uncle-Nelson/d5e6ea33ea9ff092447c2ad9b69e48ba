using System;
using UnityEngine;

namespace ScheduleOne.Building.Doors
{
	// Token: 0x02000799 RID: 1945
	public class DoorKnocker : MonoBehaviour
	{
		// Token: 0x060034E7 RID: 13543 RVA: 0x000DE7ED File Offset: 0x000DC9ED
		public void Knock()
		{
			if (this.Anim.isPlaying)
			{
				this.Anim.Stop();
			}
			this.Anim.Play(this.KnockingSoundClipName);
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x000DE819 File Offset: 0x000DCA19
		public void PlayKnockingSound()
		{
			this.KnockingSound.Play();
		}

		// Token: 0x040025D0 RID: 9680
		[Header("References")]
		public Animation Anim;

		// Token: 0x040025D1 RID: 9681
		public string KnockingSoundClipName;

		// Token: 0x040025D2 RID: 9682
		public AudioSource KnockingSound;
	}
}
