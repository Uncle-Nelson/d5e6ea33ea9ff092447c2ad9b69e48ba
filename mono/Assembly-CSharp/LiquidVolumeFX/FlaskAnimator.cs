using System;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x02000171 RID: 369
	public class FlaskAnimator : MonoBehaviour
	{
		// Token: 0x060006FB RID: 1787 RVA: 0x0002000B File Offset: 0x0001E20B
		private void Awake()
		{
			this.liquid = base.GetComponent<LiquidVolume>();
			this.level = this.liquid.level;
			this.liquid.alpha = 0f;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0002003C File Offset: 0x0001E23C
		private void Update()
		{
			float num = (this.duration > 0f) ? ((Time.time - this.delay) / this.duration) : 1f;
			if (num >= 1f)
			{
				this.level += this.direction * this.speed;
				if (this.level < this.minRange || this.level > this.maxRange)
				{
					this.direction *= -1f;
				}
				this.direction += Mathf.Sign(0.5f - this.level) * this.acceleration;
				this.level = Mathf.Clamp(this.level, this.minRange, this.maxRange);
				this.liquid.level = this.level;
				num = ((this.alphaDuration > 0f) ? Mathf.Clamp01((Time.time - this.duration - this.delay) / this.alphaDuration) : 1f);
				this.liquid.alpha = num;
				this.liquid.blurIntensity = num * this.finalRefractionBlur;
			}
			else if (this.initialPosition != this.finalPosition)
			{
				base.transform.position = Vector3.Lerp(this.initialPosition, this.finalPosition, num);
			}
			base.transform.Rotate(Vector3.up * Time.deltaTime * this.rotationSpeed * 57.29578f, Space.Self);
		}

		// Token: 0x040007ED RID: 2029
		public float speed = 0.01f;

		// Token: 0x040007EE RID: 2030
		public Vector3 initialPosition = Vector3.down * 4f;

		// Token: 0x040007EF RID: 2031
		public Vector3 finalPosition = Vector3.zero;

		// Token: 0x040007F0 RID: 2032
		public float duration = 5f;

		// Token: 0x040007F1 RID: 2033
		public float delay = 6f;

		// Token: 0x040007F2 RID: 2034
		[Range(0f, 1f)]
		public float level;

		// Token: 0x040007F3 RID: 2035
		[Range(0f, 1f)]
		public float minRange = 0.05f;

		// Token: 0x040007F4 RID: 2036
		[Range(0f, 1f)]
		public float maxRange = 0.95f;

		// Token: 0x040007F5 RID: 2037
		[Range(0f, 1f)]
		public float acceleration = 0.04f;

		// Token: 0x040007F6 RID: 2038
		[Range(0f, 1f)]
		public float rotationSpeed = 0.25f;

		// Token: 0x040007F7 RID: 2039
		[Range(0f, 2f)]
		public float alphaDuration = 2f;

		// Token: 0x040007F8 RID: 2040
		[Range(0f, 1f)]
		public float finalRefractionBlur = 0.75f;

		// Token: 0x040007F9 RID: 2041
		private LiquidVolume liquid;

		// Token: 0x040007FA RID: 2042
		private float direction = 1f;
	}
}
