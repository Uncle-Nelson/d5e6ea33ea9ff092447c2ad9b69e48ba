using System;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006D7 RID: 1751
	public class AverageAcceleration : MonoBehaviour
	{
		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002FB4 RID: 12212 RVA: 0x000C6B8C File Offset: 0x000C4D8C
		// (set) Token: 0x06002FB5 RID: 12213 RVA: 0x000C6B94 File Offset: 0x000C4D94
		public Vector3 Acceleration { get; private set; } = Vector3.zero;

		// Token: 0x06002FB6 RID: 12214 RVA: 0x000C6BA0 File Offset: 0x000C4DA0
		private void Start()
		{
			if (this.Rb == null)
			{
				this.Rb = base.GetComponent<Rigidbody>();
			}
			this.accelerations = new Vector3[Mathf.CeilToInt(this.TimeWindow / Time.fixedDeltaTime)];
			for (int i = 0; i < this.accelerations.Length; i++)
			{
				this.accelerations[i] = Vector3.zero;
			}
			this.prevVelocity = this.Rb.velocity;
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x000C6C18 File Offset: 0x000C4E18
		private void FixedUpdate()
		{
			this.timer += Time.fixedDeltaTime;
			if (this.timer >= this.TimeWindow)
			{
				this.timer -= Time.fixedDeltaTime;
				this.accelerations[this.currentIndex] = Vector3.zero;
				this.currentIndex = (this.currentIndex + 1) % this.accelerations.Length;
			}
			Vector3 vector = (this.Rb.velocity - this.prevVelocity) / Time.fixedDeltaTime;
			this.accelerations[this.currentIndex] = vector;
			this.prevVelocity = this.Rb.velocity;
			Vector3 a = Vector3.zero;
			for (int i = 0; i < this.accelerations.Length; i++)
			{
				a += this.accelerations[i];
			}
			this.Acceleration = a / (float)this.accelerations.Length;
		}

		// Token: 0x040021D1 RID: 8657
		public Rigidbody Rb;

		// Token: 0x040021D2 RID: 8658
		public float TimeWindow = 0.5f;

		// Token: 0x040021D3 RID: 8659
		private Vector3[] accelerations;

		// Token: 0x040021D4 RID: 8660
		private int currentIndex;

		// Token: 0x040021D5 RID: 8661
		private float timer;

		// Token: 0x040021D6 RID: 8662
		private Vector3 prevVelocity;
	}
}
