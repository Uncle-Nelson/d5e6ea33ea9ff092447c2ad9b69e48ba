using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000095 RID: 149
	public class CharacterController3rdPerson : MonoBehaviour
	{
		// Token: 0x06000573 RID: 1395 RVA: 0x00025017 File Offset: 0x00023217
		private void Start()
		{
			this.animatorController = base.GetComponent<AnimatorController3rdPerson>();
			this.cam.enabled = false;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00025034 File Offset: 0x00023234
		private void LateUpdate()
		{
			this.cam.UpdateInput();
			this.cam.UpdateTransform();
			Vector3 inputVector = CharacterController3rdPerson.inputVector;
			bool isMoving = CharacterController3rdPerson.inputVector != Vector3.zero || CharacterController3rdPerson.inputVectorRaw != Vector3.zero;
			Vector3 forward = this.cam.transform.forward;
			Vector3 aimTarget = this.cam.transform.position + forward * 10f;
			this.animatorController.Move(inputVector, isMoving, forward, aimTarget);
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x000250C2 File Offset: 0x000232C2
		private static Vector3 inputVector
		{
			get
			{
				return new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x000250E2 File Offset: 0x000232E2
		private static Vector3 inputVectorRaw
		{
			get
			{
				return new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
			}
		}

		// Token: 0x0400046C RID: 1132
		public CameraController cam;

		// Token: 0x0400046D RID: 1133
		private AnimatorController3rdPerson animatorController;
	}
}
