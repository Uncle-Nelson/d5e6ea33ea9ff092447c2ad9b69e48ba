using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000AE RID: 174
	public class SoccerDemo : MonoBehaviour
	{
		// Token: 0x060005D5 RID: 1493 RVA: 0x00027A77 File Offset: 0x00025C77
		private void Start()
		{
			this.animator = base.GetComponent<Animator>();
			this.defaultPosition = base.transform.position;
			this.defaultRotation = base.transform.rotation;
			base.StartCoroutine(this.ResetDelayed());
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00027AB4 File Offset: 0x00025CB4
		private IEnumerator ResetDelayed()
		{
			for (;;)
			{
				yield return new WaitForSeconds(3f);
				base.transform.position = this.defaultPosition;
				base.transform.rotation = this.defaultRotation;
				this.animator.CrossFade("SoccerKick", 0f, 0, 0f);
				yield return null;
			}
			yield break;
		}

		// Token: 0x04000504 RID: 1284
		private Animator animator;

		// Token: 0x04000505 RID: 1285
		private Vector3 defaultPosition;

		// Token: 0x04000506 RID: 1286
		private Quaternion defaultRotation;
	}
}
