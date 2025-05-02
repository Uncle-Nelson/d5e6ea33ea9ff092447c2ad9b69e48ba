using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200009D RID: 157
	public class FPSCharacter : MonoBehaviour
	{
		// Token: 0x06000594 RID: 1428 RVA: 0x000262A2 File Offset: 0x000244A2
		private void Start()
		{
			this.animator = base.GetComponent<Animator>();
			this.FPSAiming = base.GetComponent<FPSAiming>();
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000262BC File Offset: 0x000244BC
		private void Update()
		{
			this.FPSAiming.sightWeight = Mathf.SmoothDamp(this.FPSAiming.sightWeight, Input.GetMouseButton(1) ? 1f : 0f, ref this.sVel, 0.1f);
			if (this.FPSAiming.sightWeight < 0.001f)
			{
				this.FPSAiming.sightWeight = 0f;
			}
			if (this.FPSAiming.sightWeight > 0.999f)
			{
				this.FPSAiming.sightWeight = 1f;
			}
			this.animator.SetFloat("Speed", this.walkSpeed);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0002635D File Offset: 0x0002455D
		private void OnGUI()
		{
			GUI.Label(new Rect((float)(Screen.width - 210), 10f, 200f, 25f), "Hold RMB to aim down the sight");
		}

		// Token: 0x040004AA RID: 1194
		[Range(0f, 1f)]
		public float walkSpeed = 0.5f;

		// Token: 0x040004AB RID: 1195
		private float sVel;

		// Token: 0x040004AC RID: 1196
		private Animator animator;

		// Token: 0x040004AD RID: 1197
		private FPSAiming FPSAiming;
	}
}
