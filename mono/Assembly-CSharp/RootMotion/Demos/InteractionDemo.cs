using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000A1 RID: 161
	public class InteractionDemo : MonoBehaviour
	{
		// Token: 0x060005A1 RID: 1441 RVA: 0x000266F4 File Offset: 0x000248F4
		private void OnGUI()
		{
			this.interrupt = GUILayout.Toggle(this.interrupt, "Interrupt", Array.Empty<GUILayoutOption>());
			if (this.isSitting)
			{
				if (!this.interactionSystem.inInteraction && GUILayout.Button("Stand Up", Array.Empty<GUILayoutOption>()))
				{
					this.interactionSystem.ResumeAll();
					this.isSitting = false;
				}
				return;
			}
			if (GUILayout.Button("Pick Up Ball", Array.Empty<GUILayoutOption>()))
			{
				this.interactionSystem.StartInteraction(FullBodyBipedEffector.RightHand, this.ball, this.interrupt);
			}
			if (GUILayout.Button("Button Left Hand", Array.Empty<GUILayoutOption>()))
			{
				this.interactionSystem.StartInteraction(FullBodyBipedEffector.LeftHand, this.button, this.interrupt);
			}
			if (GUILayout.Button("Button Right Hand", Array.Empty<GUILayoutOption>()))
			{
				this.interactionSystem.StartInteraction(FullBodyBipedEffector.RightHand, this.button, this.interrupt);
			}
			if (GUILayout.Button("Put Out Cigarette", Array.Empty<GUILayoutOption>()))
			{
				this.interactionSystem.StartInteraction(FullBodyBipedEffector.RightFoot, this.cigarette, this.interrupt);
			}
			if (GUILayout.Button("Open Door", Array.Empty<GUILayoutOption>()))
			{
				this.interactionSystem.StartInteraction(FullBodyBipedEffector.LeftHand, this.door, this.interrupt);
			}
			if (!this.interactionSystem.inInteraction && GUILayout.Button("Sit Down", Array.Empty<GUILayoutOption>()))
			{
				this.interactionSystem.StartInteraction(FullBodyBipedEffector.Body, this.benchMain, this.interrupt);
				this.interactionSystem.StartInteraction(FullBodyBipedEffector.LeftThigh, this.benchMain, this.interrupt);
				this.interactionSystem.StartInteraction(FullBodyBipedEffector.RightThigh, this.benchMain, this.interrupt);
				this.interactionSystem.StartInteraction(FullBodyBipedEffector.LeftFoot, this.benchMain, this.interrupt);
				this.interactionSystem.StartInteraction(FullBodyBipedEffector.LeftHand, this.benchHands, this.interrupt);
				this.interactionSystem.StartInteraction(FullBodyBipedEffector.RightHand, this.benchHands, this.interrupt);
				this.isSitting = true;
			}
		}

		// Token: 0x040004BC RID: 1212
		public InteractionSystem interactionSystem;

		// Token: 0x040004BD RID: 1213
		public bool interrupt;

		// Token: 0x040004BE RID: 1214
		public InteractionObject ball;

		// Token: 0x040004BF RID: 1215
		public InteractionObject benchMain;

		// Token: 0x040004C0 RID: 1216
		public InteractionObject benchHands;

		// Token: 0x040004C1 RID: 1217
		public InteractionObject button;

		// Token: 0x040004C2 RID: 1218
		public InteractionObject cigarette;

		// Token: 0x040004C3 RID: 1219
		public InteractionObject door;

		// Token: 0x040004C4 RID: 1220
		private bool isSitting;
	}
}
