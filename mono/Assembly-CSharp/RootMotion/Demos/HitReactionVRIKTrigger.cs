using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000B7 RID: 183
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		// Token: 0x060005F5 RID: 1525 RVA: 0x0002830C File Offset: 0x0002650C
		private void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 100f))
				{
					this.hitReaction.Hit(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.colliderName = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00028385 File Offset: 0x00026585
		private void OnGUI()
		{
			GUILayout.Label("LMB to shoot the Dummy, RMB to rotate the camera.", Array.Empty<GUILayoutOption>());
			if (this.colliderName != string.Empty)
			{
				GUILayout.Label("Last Bone Hit: " + this.colliderName, Array.Empty<GUILayoutOption>());
			}
		}

		// Token: 0x04000528 RID: 1320
		public HitReactionVRIK hitReaction;

		// Token: 0x04000529 RID: 1321
		public float hitForce = 1f;

		// Token: 0x0400052A RID: 1322
		private string colliderName;
	}
}
