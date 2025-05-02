using System;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x0200068C RID: 1676
	public class Peephole : MonoBehaviour
	{
		// Token: 0x06002E7B RID: 11899 RVA: 0x000C3041 File Offset: 0x000C1241
		public void Open()
		{
			this.DoorAnim.Play("Peephole open");
			this.OpenSound.Play();
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x000C305F File Offset: 0x000C125F
		public void Close()
		{
			this.DoorAnim.Play("Peephole close");
			this.CloseSound.Play();
		}

		// Token: 0x040020FA RID: 8442
		public Animation DoorAnim;

		// Token: 0x040020FB RID: 8443
		public AudioSourceController OpenSound;

		// Token: 0x040020FC RID: 8444
		public AudioSourceController CloseSound;
	}
}
