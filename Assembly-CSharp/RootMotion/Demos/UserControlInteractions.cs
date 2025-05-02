using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000B2 RID: 178
	public class UserControlInteractions : UserControlThirdPerson
	{
		// Token: 0x060005E4 RID: 1508 RVA: 0x00027EC0 File Offset: 0x000260C0
		protected override void Update()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.inInteraction || this.interactionSystem.IsPaused()))
			{
				float minActiveProgress = this.interactionSystem.GetMinActiveProgress();
				if (minActiveProgress > 0f && minActiveProgress < this.enableInputAtProgress)
				{
					this.state.move = Vector3.zero;
					this.state.jump = false;
					return;
				}
			}
			base.Update();
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00027F40 File Offset: 0x00026140
		private void OnGUI()
		{
			if (!this.character.onGround)
			{
				return;
			}
			if (this.interactionSystem.IsPaused() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("Press E to resume interaction", Array.Empty<GUILayoutOption>());
				if (Input.GetKey(KeyCode.E))
				{
					this.interactionSystem.ResumeAll();
				}
				return;
			}
			int closestTriggerIndex = this.interactionSystem.GetClosestTriggerIndex();
			if (closestTriggerIndex == -1)
			{
				return;
			}
			if (!this.interactionSystem.TriggerEffectorsReady(closestTriggerIndex))
			{
				return;
			}
			GUILayout.Label("Press E to start interaction", Array.Empty<GUILayoutOption>());
			if (Input.GetKey(KeyCode.E))
			{
				this.interactionSystem.TriggerInteraction(closestTriggerIndex, false);
			}
		}

		// Token: 0x04000513 RID: 1299
		public CharacterThirdPerson character;

		// Token: 0x04000514 RID: 1300
		public InteractionSystem interactionSystem;

		// Token: 0x04000515 RID: 1301
		public bool disableInputInInteraction = true;

		// Token: 0x04000516 RID: 1302
		public float enableInputAtProgress = 0.8f;
	}
}
