using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000B8 RID: 184
	public class VRController : MonoBehaviour
	{
		// Token: 0x060005F8 RID: 1528 RVA: 0x000283D8 File Offset: 0x000265D8
		private void Update()
		{
			Vector3 vector = this.GetInput();
			vector *= this.ik.solver.scale;
			bool flag = Vector3.Dot(vector, Vector3.forward) > 0f;
			float num = this.walkSpeed;
			if (Input.GetKey(KeyCode.LeftShift))
			{
				num = this.runSpeed;
				if (flag)
				{
					num *= this.runForwardSpeedMlp;
				}
			}
			else if (flag)
			{
				num *= this.walkForwardSpeedMlp;
			}
			this.smoothInput = Vector3.SmoothDamp(this.smoothInput, vector * num, ref this.smoothInputV, 0.1f);
			Vector3 forward = this.centerEyeAnchor.forward;
			forward.y = 0f;
			Quaternion rotation = Quaternion.LookRotation(forward);
			base.transform.position += rotation * this.smoothInput * Time.deltaTime;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000284BC File Offset: 0x000266BC
		private Vector3 GetInput()
		{
			VRController.InputMode inputMode = this.inputMode;
			if (inputMode != VRController.InputMode.Input)
			{
				if (inputMode != VRController.InputMode.WASDOnly)
				{
					return Vector3.zero;
				}
				Vector3 a = Vector3.zero;
				if (Input.GetKey(KeyCode.W))
				{
					a += Vector3.forward;
				}
				if (Input.GetKey(KeyCode.S))
				{
					a += Vector3.back;
				}
				if (Input.GetKey(KeyCode.A))
				{
					a += Vector3.left;
				}
				if (Input.GetKey(KeyCode.D))
				{
					a += Vector3.right;
				}
				return a.normalized;
			}
			else
			{
				Vector3 vector = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
				if (vector.sqrMagnitude < 0.3f)
				{
					return Vector3.zero;
				}
				return vector.normalized;
			}
		}

		// Token: 0x0400052B RID: 1323
		public VRController.InputMode inputMode;

		// Token: 0x0400052C RID: 1324
		public VRIK ik;

		// Token: 0x0400052D RID: 1325
		public Transform centerEyeAnchor;

		// Token: 0x0400052E RID: 1326
		public float walkSpeed = 1f;

		// Token: 0x0400052F RID: 1327
		public float runSpeed = 3f;

		// Token: 0x04000530 RID: 1328
		public float walkForwardSpeedMlp = 1f;

		// Token: 0x04000531 RID: 1329
		public float runForwardSpeedMlp = 1f;

		// Token: 0x04000532 RID: 1330
		private Vector3 smoothInput;

		// Token: 0x04000533 RID: 1331
		private Vector3 smoothInputV;

		// Token: 0x02000129 RID: 297
		[Serializable]
		public enum InputMode
		{
			// Token: 0x04000885 RID: 2181
			Input,
			// Token: 0x04000886 RID: 2182
			WASDOnly
		}
	}
}
