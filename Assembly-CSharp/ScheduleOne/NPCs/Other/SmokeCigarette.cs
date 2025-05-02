using System;
using ScheduleOne.AvatarFramework.Animation;
using UnityEngine;

namespace ScheduleOne.NPCs.Other
{
	// Token: 0x02000497 RID: 1175
	public class SmokeCigarette : MonoBehaviour
	{
		// Token: 0x06001A00 RID: 6656 RVA: 0x0007077D File Offset: 0x0006E97D
		private void Awake()
		{
			if (this.Npc == null)
			{
				this.Npc = base.GetComponentInParent<NPC>();
			}
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0007079C File Offset: 0x0006E99C
		public void Begin()
		{
			this.Anim.SetBool("Smoking", true);
			this.cigarette = Object.Instantiate<GameObject>(this.CigarettePrefab, this.Anim.RightHandContainer);
			this.Npc.Avatar.LookController.OverrideIKWeight(0.3f);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x000707F0 File Offset: 0x0006E9F0
		public void End()
		{
			this.Anim.SetBool("Smoking", false);
			if (this.cigarette != null)
			{
				Object.Destroy(this.cigarette.gameObject);
				this.cigarette = null;
			}
			this.Npc.Avatar.LookController.OverrideIKWeight(0.2f);
		}

		// Token: 0x0400165A RID: 5722
		public NPC Npc;

		// Token: 0x0400165B RID: 5723
		public GameObject CigarettePrefab;

		// Token: 0x0400165C RID: 5724
		public AvatarAnimation Anim;

		// Token: 0x0400165D RID: 5725
		private GameObject cigarette;
	}
}
