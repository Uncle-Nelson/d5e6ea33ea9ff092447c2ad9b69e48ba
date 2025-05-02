using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001CC RID: 460
	[ExecuteInEditMode]
	public class FollowCamera : MonoBehaviour
	{
		// Token: 0x06000A24 RID: 2596 RVA: 0x0002D5FC File Offset: 0x0002B7FC
		private void Update()
		{
			Camera main;
			if (this.followCamera != null)
			{
				main = this.followCamera;
			}
			else
			{
				main = Camera.main;
			}
			if (main == null)
			{
				return;
			}
			base.transform.position = main.transform.TransformPoint(this.offset);
		}

		// Token: 0x04000B3A RID: 2874
		public Camera followCamera;

		// Token: 0x04000B3B RID: 2875
		public Vector3 offset = Vector3.zero;
	}
}
