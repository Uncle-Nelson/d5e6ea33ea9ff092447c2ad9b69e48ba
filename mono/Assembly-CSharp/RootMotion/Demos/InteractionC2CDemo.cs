using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000A0 RID: 160
	public class InteractionC2CDemo : MonoBehaviour
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x00026648 File Offset: 0x00024848
		private void OnGUI()
		{
			if (GUILayout.Button("Shake Hands", Array.Empty<GUILayoutOption>()))
			{
				this.character1.StartInteraction(FullBodyBipedEffector.RightHand, this.handShake, true);
				this.character2.StartInteraction(FullBodyBipedEffector.RightHand, this.handShake, true);
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00026684 File Offset: 0x00024884
		private void LateUpdate()
		{
			Vector3 position = Vector3.Lerp(this.character1.ik.solver.rightHandEffector.bone.position, this.character2.ik.solver.rightHandEffector.bone.position, 0.5f);
			this.handShake.transform.position = position;
		}

		// Token: 0x040004B9 RID: 1209
		public InteractionSystem character1;

		// Token: 0x040004BA RID: 1210
		public InteractionSystem character2;

		// Token: 0x040004BB RID: 1211
		public InteractionObject handShake;
	}
}
