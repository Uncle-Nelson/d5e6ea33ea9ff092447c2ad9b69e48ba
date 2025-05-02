using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x020000F7 RID: 247
	[HelpURL("http://saladgamer.com/vlb-doc/comp-effect-from-profile/")]
	public class EffectFromProfile : MonoBehaviour
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00016173 File Offset: 0x00014373
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x0001617B File Offset: 0x0001437B
		public EffectAbstractBase effectProfile
		{
			get
			{
				return this.m_EffectProfile;
			}
			set
			{
				this.m_EffectProfile = value;
				this.InitInstanceFromProfile();
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0001618A File Offset: 0x0001438A
		public void InitInstanceFromProfile()
		{
			if (this.m_EffectInstance)
			{
				if (this.m_EffectProfile)
				{
					this.m_EffectInstance.InitFrom(this.m_EffectProfile);
					return;
				}
				this.m_EffectInstance.enabled = false;
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000161C4 File Offset: 0x000143C4
		private void OnEnable()
		{
			if (this.m_EffectInstance)
			{
				this.m_EffectInstance.enabled = true;
				return;
			}
			if (this.m_EffectProfile)
			{
				this.m_EffectInstance = (base.gameObject.AddComponent(this.m_EffectProfile.GetType()) as EffectAbstractBase);
				this.InitInstanceFromProfile();
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0001621F File Offset: 0x0001441F
		private void OnDisable()
		{
			if (this.m_EffectInstance)
			{
				this.m_EffectInstance.enabled = false;
			}
		}

		// Token: 0x0400057A RID: 1402
		public const string ClassName = "EffectFromProfile";

		// Token: 0x0400057B RID: 1403
		[SerializeField]
		private EffectAbstractBase m_EffectProfile;

		// Token: 0x0400057C RID: 1404
		private EffectAbstractBase m_EffectInstance;
	}
}
