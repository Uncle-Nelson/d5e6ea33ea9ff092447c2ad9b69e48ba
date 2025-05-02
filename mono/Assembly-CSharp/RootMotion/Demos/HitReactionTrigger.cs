using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200009E RID: 158
	public class HitReactionTrigger : MonoBehaviour
	{
		// Token: 0x06000598 RID: 1432 RVA: 0x0002639C File Offset: 0x0002459C
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

		// Token: 0x06000599 RID: 1433 RVA: 0x00026415 File Offset: 0x00024615
		private void OnGUI()
		{
			GUILayout.Label("LMB to shoot the Dummy, RMB to rotate the camera.", Array.Empty<GUILayoutOption>());
			if (this.colliderName != string.Empty)
			{
				GUILayout.Label("Last Bone Hit: " + this.colliderName, Array.Empty<GUILayoutOption>());
			}
		}

		// Token: 0x040004AE RID: 1198
		public HitReaction hitReaction;

		// Token: 0x040004AF RID: 1199
		public float hitForce = 1f;

		// Token: 0x040004B0 RID: 1200
		private string colliderName;
	}
}
