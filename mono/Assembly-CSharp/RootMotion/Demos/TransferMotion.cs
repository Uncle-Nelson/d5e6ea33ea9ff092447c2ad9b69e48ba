using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000B0 RID: 176
	public class TransferMotion : MonoBehaviour
	{
		// Token: 0x060005DC RID: 1500 RVA: 0x00027B79 File Offset: 0x00025D79
		private void OnEnable()
		{
			this.lastPosition = base.transform.position;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00027B8C File Offset: 0x00025D8C
		private void Update()
		{
			Vector3 a = base.transform.position - this.lastPosition;
			this.to.position += a * this.transferMotion;
			this.lastPosition = base.transform.position;
		}

		// Token: 0x04000509 RID: 1289
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		// Token: 0x0400050A RID: 1290
		[Tooltip("The amount of motion to transfer.")]
		[Range(0f, 1f)]
		public float transferMotion = 0.9f;

		// Token: 0x0400050B RID: 1291
		private Vector3 lastPosition;
	}
}
