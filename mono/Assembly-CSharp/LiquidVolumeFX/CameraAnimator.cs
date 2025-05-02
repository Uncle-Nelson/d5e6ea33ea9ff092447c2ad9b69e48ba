using System;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x0200016E RID: 366
	public class CameraAnimator : MonoBehaviour
	{
		// Token: 0x060006F4 RID: 1780 RVA: 0x0001FC11 File Offset: 0x0001DE11
		private void Start()
		{
			this.y = base.transform.position.y;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0001FC2C File Offset: 0x0001DE2C
		private void Update()
		{
			base.transform.RotateAround(this.lookAt, Vector3.up, Time.deltaTime * this.speedX);
			this.y += this.dy;
			this.dy -= (base.transform.position.y - this.baseHeight) * Time.deltaTime * this.speedY;
			base.transform.position = new Vector3(base.transform.position.x, this.y, base.transform.position.z);
			Quaternion rotation = base.transform.rotation;
			base.transform.LookAt(this.lookAt);
			base.transform.rotation = Quaternion.Lerp(rotation, base.transform.rotation, 0.2f);
			base.transform.position += base.transform.forward * this.distSum;
			this.distSum += this.distSpeed;
			this.distDirection = ((this.distSum < 0f) ? 1f : -1f);
			this.distSpeed += Time.deltaTime * this.distDirection * this.distAcceleration;
		}

		// Token: 0x040007DE RID: 2014
		public float baseHeight = 0.6f;

		// Token: 0x040007DF RID: 2015
		public float speedY = 0.005f;

		// Token: 0x040007E0 RID: 2016
		public float speedX = 5f;

		// Token: 0x040007E1 RID: 2017
		public float distAcceleration = 0.0002f;

		// Token: 0x040007E2 RID: 2018
		public float distSpeed = 0.0001f;

		// Token: 0x040007E3 RID: 2019
		public Vector3 lookAt;

		// Token: 0x040007E4 RID: 2020
		private float y;

		// Token: 0x040007E5 RID: 2021
		private float dy;

		// Token: 0x040007E6 RID: 2022
		private float distDirection = 1f;

		// Token: 0x040007E7 RID: 2023
		private float distSum;
	}
}
