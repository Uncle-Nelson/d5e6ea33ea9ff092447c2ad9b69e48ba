using System;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x02000175 RID: 373
	public class RandomMove : MonoBehaviour
	{
		// Token: 0x06000706 RID: 1798 RVA: 0x00020568 File Offset: 0x0001E768
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.F))
			{
				this.flaskType++;
				if (this.flaskType >= 3)
				{
					this.flaskType = 0;
				}
				base.transform.Find("SphereFlask").gameObject.SetActive(this.flaskType == 0);
				base.transform.Find("CylinderFlask").gameObject.SetActive(this.flaskType == 1);
				base.transform.Find("CubeFlask").gameObject.SetActive(this.flaskType == 2);
			}
			Vector3 a = Vector3.zero;
			if (this.automatic)
			{
				if (Random.value > 0.99f)
				{
					a = Vector3.right * (this.speed + (Random.value - 0.5f) * this.randomSpeed);
				}
			}
			else
			{
				if (Input.GetKey(KeyCode.RightArrow))
				{
					a += Vector3.right * this.speed;
				}
				if (Input.GetKey(KeyCode.LeftArrow))
				{
					a += Vector3.left * this.speed;
				}
				if (Input.GetKey(KeyCode.UpArrow))
				{
					a += Vector3.forward * this.speed;
				}
				if (Input.GetKey(KeyCode.DownArrow))
				{
					a += Vector3.back * this.speed;
				}
			}
			float num = 60f * Time.deltaTime;
			this.velocity += a * num;
			float num2 = 0.005f * num;
			if (this.velocity.magnitude > num2)
			{
				this.velocity -= this.velocity.normalized * num2;
			}
			else
			{
				this.velocity = Vector3.zero;
			}
			base.transform.localPosition += this.velocity * num;
			if (Input.GetKey(KeyCode.W))
			{
				base.transform.Rotate(0f, 0f, this.rotationSpeed * num);
			}
			else if (Input.GetKey(KeyCode.S))
			{
				base.transform.Rotate(0f, 0f, -this.rotationSpeed * num);
			}
			if (base.transform.localPosition.x > this.right)
			{
				base.transform.localPosition = new Vector3(this.right, base.transform.localPosition.y, base.transform.localPosition.z);
				this.velocity.Set(0f, 0f, 0f);
			}
			if (base.transform.localPosition.x < this.left)
			{
				base.transform.localPosition = new Vector3(this.left, base.transform.localPosition.y, base.transform.localPosition.z);
				this.velocity.Set(0f, 0f, 0f);
			}
			if (base.transform.localPosition.z > this.back)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, base.transform.localPosition.y, this.back);
				this.velocity.Set(0f, 0f, 0f);
			}
			if (base.transform.localPosition.z < this.front)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, base.transform.localPosition.y, this.front);
				this.velocity.Set(0f, 0f, 0f);
			}
		}

		// Token: 0x0400080F RID: 2063
		[Range(-10f, 10f)]
		public float right = 2f;

		// Token: 0x04000810 RID: 2064
		[Range(-10f, 10f)]
		public float left = -2f;

		// Token: 0x04000811 RID: 2065
		[Range(-10f, 10f)]
		public float back = 2f;

		// Token: 0x04000812 RID: 2066
		[Range(-10f, 10f)]
		public float front = -1f;

		// Token: 0x04000813 RID: 2067
		[Range(0f, 0.2f)]
		public float speed = 0.5f;

		// Token: 0x04000814 RID: 2068
		[Range(0f, 2f)]
		public float rotationSpeed = 1f;

		// Token: 0x04000815 RID: 2069
		[Range(0.1f, 2f)]
		public float randomSpeed;

		// Token: 0x04000816 RID: 2070
		public bool automatic;

		// Token: 0x04000817 RID: 2071
		private Vector3 velocity = Vector3.zero;

		// Token: 0x04000818 RID: 2072
		private int flaskType;
	}
}
