using System;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x02000176 RID: 374
	public class LiquidLevelPouringSync : MonoBehaviour
	{
		// Token: 0x06000708 RID: 1800 RVA: 0x000209B4 File Offset: 0x0001EBB4
		private void Start()
		{
			this.rb = base.GetComponent<Rigidbody>();
			this.lv = base.transform.parent.GetComponent<LiquidVolume>();
			this.UpdateColliderPos();
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000209DE File Offset: 0x0001EBDE
		private void OnParticleCollision(GameObject other)
		{
			if (this.lv.level < 1f)
			{
				this.lv.level += this.fillSpeed;
			}
			this.UpdateColliderPos();
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00020A10 File Offset: 0x0001EC10
		private void UpdateColliderPos()
		{
			Vector3 position = new Vector3(base.transform.position.x, this.lv.liquidSurfaceYPosition - base.transform.localScale.y * 0.5f - this.sinkFactor, base.transform.position.z);
			this.rb.position = position;
			if (this.lv.level >= 1f)
			{
				base.transform.localRotation = Quaternion.Euler(Random.value * 30f - 15f, Random.value * 30f - 15f, Random.value * 30f - 15f);
				return;
			}
			base.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		}

		// Token: 0x04000819 RID: 2073
		public float fillSpeed = 0.01f;

		// Token: 0x0400081A RID: 2074
		public float sinkFactor = 0.1f;

		// Token: 0x0400081B RID: 2075
		private LiquidVolume lv;

		// Token: 0x0400081C RID: 2076
		private Rigidbody rb;
	}
}
