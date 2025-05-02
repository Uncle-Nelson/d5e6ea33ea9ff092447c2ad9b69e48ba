using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000A2 RID: 162
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		// Token: 0x060005A3 RID: 1443 RVA: 0x000268F0 File Offset: 0x00024AF0
		private void Awake()
		{
			this.interactionSystem = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00026900 File Offset: 0x00024B00
		private void OnGUI()
		{
			if (this.interactionSystem == null)
			{
				return;
			}
			if (GUILayout.Button("Start Interaction With " + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("Please select the effectors to interact with.");
				}
				foreach (FullBodyBipedEffector effectorType in this.effectors)
				{
					this.interactionSystem.StartInteraction(effectorType, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.interactionSystem.IsPaused(this.effectors[0]) && GUILayout.Button("Resume Interaction With " + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.interactionSystem.ResumeAll();
			}
		}

		// Token: 0x040004C5 RID: 1221
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		// Token: 0x040004C6 RID: 1222
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		// Token: 0x040004C7 RID: 1223
		private InteractionSystem interactionSystem;
	}
}
