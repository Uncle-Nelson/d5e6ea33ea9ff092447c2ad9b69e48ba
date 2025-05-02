using System;
using FishNet.Object;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Animation;
using ScheduleOne.Tools;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000458 RID: 1112
	public class NPCAnimation : NetworkBehaviour
	{
		// Token: 0x060016EE RID: 5870 RVA: 0x00065337 File Offset: 0x00063537
		private void Start()
		{
			this.npc = base.GetComponent<NPC>();
			NPC npc = this.npc;
			npc.onExitVehicle = (Action<LandVehicle>)Delegate.Combine(npc.onExitVehicle, new Action<LandVehicle>(delegate(LandVehicle <p0>)
			{
				this.ResetVelocityCalculations();
			}));
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x0006536C File Offset: 0x0006356C
		protected virtual void LateUpdate()
		{
			if (this.anim.enabled && !this.anim.IsAvatarCulled && this.npc.isVisible)
			{
				this.UpdateMovementAnimation();
			}
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x0006539C File Offset: 0x0006359C
		protected virtual void UpdateMovementAnimation()
		{
			Vector3 vector = this.Avatar.transform.InverseTransformVector(this.velocityCalculator.Velocity) / 8f;
			this.anim.SetDirection(this.WalkMapCurve.Evaluate(Mathf.Abs(vector.z)) * Mathf.Sign(vector.z));
			this.anim.SetStrafe(this.WalkMapCurve.Evaluate(Mathf.Abs(vector.x)) * Mathf.Sign(vector.x));
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00065429 File Offset: 0x00063629
		public virtual void SetRagdollActive(bool active)
		{
			this.Avatar.SetRagdollPhysicsEnabled(active, true);
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00065438 File Offset: 0x00063638
		public void ResetVelocityCalculations()
		{
			this.velocityCalculator.FlushBuffer();
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00065445 File Offset: 0x00063645
		public void StandupStart()
		{
			this.movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("ragdollstandup", 100, 0f));
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00065468 File Offset: 0x00063668
		public void StandupDone()
		{
			this.movement.SpeedController.RemoveSpeedControl("ragdollstandup");
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0006548F File Offset: 0x0006368F
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.NPCAnimationAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.NPCAnimationAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x000654A2 File Offset: 0x000636A2
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.NPCAnimationAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.NPCAnimationAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x000654B5 File Offset: 0x000636B5
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x000654B5 File Offset: 0x000636B5
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040014DE RID: 5342
		[Header("References")]
		public Avatar Avatar;

		// Token: 0x040014DF RID: 5343
		[SerializeField]
		protected AvatarAnimation anim;

		// Token: 0x040014E0 RID: 5344
		[SerializeField]
		protected NPCMovement movement;

		// Token: 0x040014E1 RID: 5345
		protected NPC npc;

		// Token: 0x040014E2 RID: 5346
		[SerializeField]
		protected SmoothedVelocityCalculator velocityCalculator;

		// Token: 0x040014E3 RID: 5347
		[Header("Settings")]
		public AnimationCurve WalkMapCurve;

		// Token: 0x040014E4 RID: 5348
		private bool dll_Excuted;

		// Token: 0x040014E5 RID: 5349
		private bool dll_Excuted;
	}
}
