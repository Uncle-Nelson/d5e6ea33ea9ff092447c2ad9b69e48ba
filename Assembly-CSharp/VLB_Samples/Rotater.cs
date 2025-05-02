using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB_Samples
{
	// Token: 0x02000161 RID: 353
	public class Rotater : MonoBehaviour
	{
		// Token: 0x060006CA RID: 1738 RVA: 0x0001EB20 File Offset: 0x0001CD20
		private void Update()
		{
			Vector3 vector = base.transform.rotation.eulerAngles;
			vector += this.EulerSpeed * Time.deltaTime;
			base.transform.rotation = Quaternion.Euler(vector);
		}

		// Token: 0x04000792 RID: 1938
		[FormerlySerializedAs("m_EulerSpeed")]
		public Vector3 EulerSpeed = Vector3.zero;
	}
}
