using System;
using FishNet;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000522 RID: 1314
	public class IdleBehaviour : Behaviour
	{
		// Token: 0x06001F7B RID: 8059 RVA: 0x00080D45 File Offset: 0x0007EF45
		protected override void Begin()
		{
			base.Begin();
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x00080D4D File Offset: 0x0007EF4D
		protected override void Resume()
		{
			base.Resume();
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x00080D58 File Offset: 0x0007EF58
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.IdlePoint == null)
			{
				return;
			}
			if (!base.Npc.Movement.IsMoving)
			{
				if (!base.Npc.Movement.IsAsCloseAsPossible(this.IdlePoint.position, 0.5f))
				{
					this.facingDir = false;
					base.Npc.Movement.SetDestination(this.IdlePoint.position);
					return;
				}
				if (!this.facingDir)
				{
					this.facingDir = true;
					base.Npc.Movement.FaceDirection(this.IdlePoint.forward, 0.5f);
					return;
				}
			}
			else
			{
				this.facingDir = false;
			}
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x00080E10 File Offset: 0x0007F010
		protected override void Pause()
		{
			base.Pause();
			this.facingDir = false;
			if (InstanceFinder.IsServer)
			{
				base.Npc.Movement.Stop();
			}
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00080E36 File Offset: 0x0007F036
		protected override void End()
		{
			base.End();
			this.facingDir = false;
			if (InstanceFinder.IsServer)
			{
				base.Npc.Movement.Stop();
			}
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x00080E5C File Offset: 0x0007F05C
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.IdleBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.IdleBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00080E75 File Offset: 0x0007F075
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.IdleBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.IdleBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x00080E8E File Offset: 0x0007F08E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x00080E9C File Offset: 0x0007F09C
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001885 RID: 6277
		public Transform IdlePoint;

		// Token: 0x04001886 RID: 6278
		private bool facingDir;

		// Token: 0x04001887 RID: 6279
		private bool dll_Excuted;

		// Token: 0x04001888 RID: 6280
		private bool dll_Excuted;
	}
}
