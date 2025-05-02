using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000186 RID: 390
	public class RotateBody : MonoBehaviour
	{
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00025A21 File Offset: 0x00023C21
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x00025A29 File Offset: 0x00023C29
		public float SpinSpeed
		{
			get
			{
				return this.m_SpinSpeed;
			}
			set
			{
				this.m_SpinSpeed = value;
				this.UpdateOrbitBodyRotation();
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00025A38 File Offset: 0x00023C38
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x00025A40 File Offset: 0x00023C40
		public bool AllowSpinning
		{
			get
			{
				return this.m_AllowSpinning;
			}
			set
			{
				this.m_AllowSpinning = value;
				this.UpdateOrbitBodyRotation();
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00025A50 File Offset: 0x00023C50
		public void UpdateOrbitBodyRotation()
		{
			float num = (float)(this.m_AllowSpinning ? 1 : 0);
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			Vector3 euler = new Vector3(0f, -180f, (eulerAngles.z + -10f * this.SpinSpeed * Time.deltaTime) * num);
			base.transform.localRotation = Quaternion.Euler(euler);
		}

		// Token: 0x0400091F RID: 2335
		private float m_SpinSpeed;

		// Token: 0x04000920 RID: 2336
		private bool m_AllowSpinning;
	}
}
