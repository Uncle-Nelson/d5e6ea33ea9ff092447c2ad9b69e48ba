using System;
using UnityEngine;

namespace Beautify.Universal
{
	// Token: 0x020001F2 RID: 498
	public class SphereAnimator : MonoBehaviour
	{
		// Token: 0x06000AF6 RID: 2806 RVA: 0x0003059C File Offset: 0x0002E79C
		private void Start()
		{
			this.rb = base.GetComponent<Rigidbody>();
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x000305AC File Offset: 0x0002E7AC
		private void FixedUpdate()
		{
			if (base.transform.position.z < 2.5f)
			{
				this.rb.AddForce(Vector3.forward * 200f * Time.fixedDeltaTime);
				return;
			}
			if (base.transform.position.z > 8f)
			{
				this.rb.AddForce(Vector3.back * 200f * Time.fixedDeltaTime);
			}
		}

		// Token: 0x04000BCC RID: 3020
		private Rigidbody rb;
	}
}
