using System;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200099E RID: 2462
	public class PoliceBelt : Accessory
	{
		// Token: 0x060042BA RID: 17082 RVA: 0x001180BA File Offset: 0x001162BA
		public void SetBatonVisible(bool vis)
		{
			this.BatonObject.gameObject.SetActive(vis);
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x001180CD File Offset: 0x001162CD
		public void SetTaserVisible(bool vis)
		{
			this.TaserObject.gameObject.SetActive(vis);
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x001180E0 File Offset: 0x001162E0
		public void SetGunVisible(bool vis)
		{
			this.GunObject.gameObject.SetActive(vis);
		}

		// Token: 0x04003069 RID: 12393
		[Header("References")]
		[SerializeField]
		protected GameObject BatonObject;

		// Token: 0x0400306A RID: 12394
		[SerializeField]
		protected GameObject TaserObject;

		// Token: 0x0400306B RID: 12395
		[SerializeField]
		protected GameObject GunObject;
	}
}
