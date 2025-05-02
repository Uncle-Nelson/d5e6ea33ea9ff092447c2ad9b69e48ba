using System;
using UnityEngine;

namespace VolumetricFogAndMist2.Demos
{
	// Token: 0x02000162 RID: 354
	public class CapsuleController : MonoBehaviour
	{
		// Token: 0x060006CC RID: 1740 RVA: 0x0001EB7C File Offset: 0x0001CD7C
		private void Update()
		{
			float num = Time.deltaTime * this.moveSpeed;
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				base.transform.Translate(-num, 0f, 0f);
			}
			else if (Input.GetKey(KeyCode.RightArrow))
			{
				base.transform.Translate(num, 0f, 0f);
			}
			if (Input.GetKey(KeyCode.UpArrow))
			{
				base.transform.Translate(0f, 0f, num);
			}
			else if (Input.GetKey(KeyCode.DownArrow))
			{
				base.transform.Translate(0f, 0f, -num);
			}
			if ((base.transform.position - this.lastPos).magnitude > this.distanceCheck)
			{
				this.lastPos = base.transform.position;
				this.fogVolume.SetFogOfWarAlpha(base.transform.position, this.fogHoleRadius, 0f, this.clearDuration);
			}
		}

		// Token: 0x04000793 RID: 1939
		public VolumetricFog fogVolume;

		// Token: 0x04000794 RID: 1940
		public float moveSpeed = 10f;

		// Token: 0x04000795 RID: 1941
		public float fogHoleRadius = 8f;

		// Token: 0x04000796 RID: 1942
		public float clearDuration = 0.2f;

		// Token: 0x04000797 RID: 1943
		public float distanceCheck = 1f;

		// Token: 0x04000798 RID: 1944
		private Vector3 lastPos = new Vector3(float.MaxValue, 0f, 0f);
	}
}
