using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200008B RID: 139
	public class TerrainOffset : MonoBehaviour
	{
		// Token: 0x06000540 RID: 1344 RVA: 0x000234BC File Offset: 0x000216BC
		private void LateUpdate()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 groundHeightOffset = this.GetGroundHeightOffset(base.transform.position + vector);
			this.offset = Vector3.Lerp(this.offset, groundHeightOffset, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 0f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.offset;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00023570 File Offset: 0x00021770
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			Debug.DrawRay(worldPosition, Vector3.down * this.raycastOffset.y * 2f, Color.green);
			if (Physics.Raycast(worldPosition, Vector3.down, out this.hit, this.raycastOffset.y * 2f))
			{
				return Mathf.Clamp(this.hit.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0400040A RID: 1034
		public AimIK aimIK;

		// Token: 0x0400040B RID: 1035
		public Vector3 raycastOffset = new Vector3(0f, 2f, 1.5f);

		// Token: 0x0400040C RID: 1036
		public LayerMask raycastLayers;

		// Token: 0x0400040D RID: 1037
		public float min = -2f;

		// Token: 0x0400040E RID: 1038
		public float max = 2f;

		// Token: 0x0400040F RID: 1039
		public float lerpSpeed = 10f;

		// Token: 0x04000410 RID: 1040
		private RaycastHit hit;

		// Token: 0x04000411 RID: 1041
		private Vector3 offset;
	}
}
