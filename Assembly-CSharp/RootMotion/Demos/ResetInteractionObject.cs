using System;
using System.Collections;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000AD RID: 173
	public class ResetInteractionObject : MonoBehaviour
	{
		// Token: 0x060005D1 RID: 1489 RVA: 0x000279D8 File Offset: 0x00025BD8
		private void Start()
		{
			this.defaultPosition = base.transform.position;
			this.defaultRotation = base.transform.rotation;
			this.defaultParent = base.transform.parent;
			this.r = base.GetComponent<Rigidbody>();
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00027A24 File Offset: 0x00025C24
		private void OnPickUp(Transform t)
		{
			if (!base.enabled)
			{
				return;
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.ResetObject(Time.time + this.resetDelay));
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00027A4E File Offset: 0x00025C4E
		private IEnumerator ResetObject(float resetTime)
		{
			while (Time.time < resetTime)
			{
				yield return null;
			}
			Poser component = base.transform.parent.GetComponent<Poser>();
			if (component != null)
			{
				component.poseRoot = null;
				component.weight = 0f;
			}
			base.transform.parent = this.defaultParent;
			base.transform.position = this.defaultPosition;
			base.transform.rotation = this.defaultRotation;
			if (this.r != null)
			{
				this.r.isKinematic = false;
			}
			yield break;
		}

		// Token: 0x040004FF RID: 1279
		public float resetDelay = 1f;

		// Token: 0x04000500 RID: 1280
		private Vector3 defaultPosition;

		// Token: 0x04000501 RID: 1281
		private Quaternion defaultRotation;

		// Token: 0x04000502 RID: 1282
		private Transform defaultParent;

		// Token: 0x04000503 RID: 1283
		private Rigidbody r;
	}
}
