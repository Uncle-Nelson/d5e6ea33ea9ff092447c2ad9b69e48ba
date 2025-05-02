using System;
using UnityEngine;

namespace StylizedGrassDemo
{
	// Token: 0x02000167 RID: 359
	public class PlayerController : MonoBehaviour
	{
		// Token: 0x060006DB RID: 1755 RVA: 0x0001F4E8 File Offset: 0x0001D6E8
		private void Start()
		{
			this.rb = base.GetComponent<Rigidbody>();
			if (!this.cam)
			{
				this.cam = Camera.main;
			}
			this.isGrounded = true;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0001F518 File Offset: 0x0001D718
		private void FixedUpdate()
		{
			Vector3 a = new Vector3(this.cam.transform.forward.x, 0f, this.cam.transform.forward.z);
			a *= Input.GetAxis("Vertical");
			a = a.normalized;
			this.rb.AddForce(a * this.speed);
			if (Input.GetKeyDown(KeyCode.Space) && this.isGrounded)
			{
				this.rb.AddForce(Vector3.up * this.jumpForce * this.rb.mass);
				this.isGrounded = false;
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0001F5D0 File Offset: 0x0001D7D0
		private void Update()
		{
			if (!this.isGrounded)
			{
				Physics.Raycast(base.transform.position, -Vector3.up, ref this.raycastHit, 0.5f);
				if (this.raycastHit.collider && this.raycastHit.collider.GetType() == typeof(TerrainCollider))
				{
					this.isGrounded = true;
					if (this.landBendEffect)
					{
						this.landBendEffect.Emit(1);
					}
				}
			}
		}

		// Token: 0x040007C1 RID: 1985
		public Camera cam;

		// Token: 0x040007C2 RID: 1986
		private float speed = 15f;

		// Token: 0x040007C3 RID: 1987
		private float jumpForce = 350f;

		// Token: 0x040007C4 RID: 1988
		private Rigidbody rb;

		// Token: 0x040007C5 RID: 1989
		private bool isGrounded;

		// Token: 0x040007C6 RID: 1990
		public ParticleSystem landBendEffect;

		// Token: 0x040007C7 RID: 1991
		private RaycastHit raycastHit;
	}
}
