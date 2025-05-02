using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace RadiantGI.Universal
{
	// Token: 0x02000168 RID: 360
	public class ToggleEffect : MonoBehaviour
	{
		// Token: 0x060006DF RID: 1759 RVA: 0x0001F67C File Offset: 0x0001D87C
		private void Start()
		{
			this.profile.TryGet<RadiantGlobalIllumination>(ref this.radiant);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0001F690 File Offset: 0x0001D890
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				this.radiant.active = !this.radiant.active;
			}
		}

		// Token: 0x040007C8 RID: 1992
		public VolumeProfile profile;

		// Token: 0x040007C9 RID: 1993
		private RadiantGlobalIllumination radiant;
	}
}
