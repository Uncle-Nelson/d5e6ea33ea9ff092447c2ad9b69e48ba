using System;
using UnityEngine;

namespace StylizedGrassDemo
{
	// Token: 0x02000165 RID: 357
	public class MoveInCircle : MonoBehaviour
	{
		// Token: 0x060006D5 RID: 1749 RVA: 0x0001F1B2 File Offset: 0x0001D3B2
		private void Update()
		{
			this.Move();
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0001F1BC File Offset: 0x0001D3BC
		private void Move()
		{
			float x = Mathf.Sin(Time.realtimeSinceStartup * this.speed) * this.radius + this.offset.x;
			float y = base.transform.position.y + this.offset.y;
			float z = Mathf.Cos(Time.realtimeSinceStartup * this.speed) * this.radius + this.offset.z;
			base.transform.localPosition = new Vector3(x, y, z);
		}

		// Token: 0x040007B2 RID: 1970
		public float radius = 1f;

		// Token: 0x040007B3 RID: 1971
		public float speed = 1f;

		// Token: 0x040007B4 RID: 1972
		public Vector3 offset;
	}
}
