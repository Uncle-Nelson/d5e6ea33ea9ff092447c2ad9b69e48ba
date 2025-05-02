using System;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007CA RID: 1994
	public class LoanSharkCarVisuals : MonoBehaviour
	{
		// Token: 0x060036A0 RID: 13984 RVA: 0x000E5DF5 File Offset: 0x000E3FF5
		private void Awake()
		{
			this.Note.gameObject.SetActive(false);
			this.BulletHoleDecals.gameObject.SetActive(false);
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x000E5E19 File Offset: 0x000E4019
		public void Configure(bool enabled, bool noteVisible)
		{
			this.Note.SetActive(noteVisible);
			this.BulletHoleDecals.SetActive(enabled);
		}

		// Token: 0x0400271E RID: 10014
		public GameObject Note;

		// Token: 0x0400271F RID: 10015
		public GameObject BulletHoleDecals;
	}
}
