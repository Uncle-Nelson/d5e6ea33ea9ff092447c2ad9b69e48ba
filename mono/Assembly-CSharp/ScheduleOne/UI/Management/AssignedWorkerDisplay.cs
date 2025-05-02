using System;
using ScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AD9 RID: 2777
	public class AssignedWorkerDisplay : MonoBehaviour
	{
		// Token: 0x06004A81 RID: 19073 RVA: 0x00138E09 File Offset: 0x00137009
		public void Set(NPC npc)
		{
			if (npc != null)
			{
				this.Icon.sprite = npc.MugshotSprite;
			}
			base.gameObject.SetActive(npc != null);
		}

		// Token: 0x040037D4 RID: 14292
		public Image Icon;
	}
}
