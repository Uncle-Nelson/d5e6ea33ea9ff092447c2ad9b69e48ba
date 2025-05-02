using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000C5 RID: 197
	public class UserControlThirdPerson : MonoBehaviour
	{
		// Token: 0x06000648 RID: 1608 RVA: 0x0002AB89 File Offset: 0x00028D89
		protected virtual void Start()
		{
			this.cam = Camera.main.transform;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0002AB9C File Offset: 0x00028D9C
		protected virtual void Update()
		{
			this.state.crouch = (this.canCrouch && Input.GetKey(KeyCode.C));
			this.state.jump = (this.canJump && Input.GetButton("Jump"));
			float axisRaw = Input.GetAxisRaw("Horizontal");
			float axisRaw2 = Input.GetAxisRaw("Vertical");
			Vector3 vector = this.cam.rotation * new Vector3(axisRaw, 0f, axisRaw2).normalized;
			if (vector != Vector3.zero)
			{
				Vector3 up = base.transform.up;
				Vector3.OrthoNormalize(ref up, ref vector);
				this.state.move = vector;
			}
			else
			{
				this.state.move = Vector3.zero;
			}
			bool key = Input.GetKey(KeyCode.LeftShift);
			float d = this.walkByDefault ? (key ? 1f : 0.5f) : (key ? 0.5f : 1f);
			this.state.move = this.state.move * d;
			this.state.lookPos = base.transform.position + this.cam.forward * 100f;
		}

		// Token: 0x040005C4 RID: 1476
		public bool walkByDefault;

		// Token: 0x040005C5 RID: 1477
		public bool canCrouch = true;

		// Token: 0x040005C6 RID: 1478
		public bool canJump = true;

		// Token: 0x040005C7 RID: 1479
		public UserControlThirdPerson.State state;

		// Token: 0x040005C8 RID: 1480
		protected Transform cam;

		// Token: 0x0200012E RID: 302
		public struct State
		{
			// Token: 0x0400089A RID: 2202
			public Vector3 move;

			// Token: 0x0400089B RID: 2203
			public Vector3 lookPos;

			// Token: 0x0400089C RID: 2204
			public bool crouch;

			// Token: 0x0400089D RID: 2205
			public bool jump;

			// Token: 0x0400089E RID: 2206
			public int actionIndex;
		}
	}
}
