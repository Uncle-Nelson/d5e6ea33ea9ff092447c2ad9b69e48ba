using System;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006E7 RID: 1767
	public class MapHeightSampler
	{
		// Token: 0x0600300F RID: 12303 RVA: 0x000C8220 File Offset: 0x000C6420
		public static bool Sample(float x, out float y, float z)
		{
			y = 0f;
			Vector3 vector = new Vector3(x, MapHeightSampler.SampleHeight, z);
			Debug.DrawRay(vector, Vector3.down * MapHeightSampler.SampleDistance, Color.red, 100f);
			RaycastHit raycastHit;
			if (Physics.Raycast(vector, Vector3.down, ref raycastHit, MapHeightSampler.SampleDistance, 1 << LayerMask.NameToLayer("Default"), 1))
			{
				y = raycastHit.point.y;
			}
			return false;
		}

		// Token: 0x04002228 RID: 8744
		private static float SampleHeight = 100f;

		// Token: 0x04002229 RID: 8745
		private static float SampleDistance = 200f;

		// Token: 0x0400222A RID: 8746
		public static Vector3 ResetPosition = new Vector3(-166.5f, 3f, -60f);
	}
}
