using System;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000521 RID: 1313
	public class HeavyFlinchBehaviour : Behaviour
	{
		// Token: 0x06001F73 RID: 8051 RVA: 0x00080C70 File Offset: 0x0007EE70
		public override void BehaviourUpdate()
		{
			base.BehaviourUpdate();
			if (this.remainingFlinchTime > 0f)
			{
				this.remainingFlinchTime = Mathf.Clamp(this.remainingFlinchTime -= Time.deltaTime, 0f, 1.25f);
			}
			if (this.remainingFlinchTime <= 0f)
			{
				base.Disable_Networked(null);
			}
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00077708 File Offset: 0x00075908
		public override void Disable()
		{
			base.Disable();
			this.End();
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00080CCE File Offset: 0x0007EECE
		public void Flinch()
		{
			this.remainingFlinchTime += 1.25f;
			if (!base.Enabled)
			{
				base.Enable_Networked(null);
			}
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x00080CF1 File Offset: 0x0007EEF1
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.HeavyFlinchBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.HeavyFlinchBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00080D0A File Offset: 0x0007EF0A
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.HeavyFlinchBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.HeavyFlinchBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00080D23 File Offset: 0x0007EF23
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00080D31 File Offset: 0x0007EF31
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001881 RID: 6273
		public const float FLINCH_DURATION = 1.25f;

		// Token: 0x04001882 RID: 6274
		private float remainingFlinchTime;

		// Token: 0x04001883 RID: 6275
		private bool dll_Excuted;

		// Token: 0x04001884 RID: 6276
		private bool dll_Excuted;
	}
}
