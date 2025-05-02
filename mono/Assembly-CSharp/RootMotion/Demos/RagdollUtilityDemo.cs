using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000AB RID: 171
	public class RagdollUtilityDemo : MonoBehaviour
	{
		// Token: 0x060005CA RID: 1482 RVA: 0x000278E2 File Offset: 0x00025AE2
		private void OnGUI()
		{
			GUILayout.Label(" Press R to switch to ragdoll. \n Weigh in one of the FBBIK effectors to make kinematic changes to the ragdoll pose.\n A to blend back to animation", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000278F4 File Offset: 0x00025AF4
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.R))
			{
				this.ragdollUtility.EnableRagdoll();
			}
			if (Input.GetKeyDown(KeyCode.A))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.DisableRagdoll();
			}
		}

		// Token: 0x040004FA RID: 1274
		public RagdollUtility ragdollUtility;

		// Token: 0x040004FB RID: 1275
		public Transform root;

		// Token: 0x040004FC RID: 1276
		public Rigidbody pelvis;
	}
}
