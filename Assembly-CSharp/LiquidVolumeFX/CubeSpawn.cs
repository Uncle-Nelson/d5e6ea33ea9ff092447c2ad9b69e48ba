using System;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x0200016C RID: 364
	public class CubeSpawn : MonoBehaviour
	{
		// Token: 0x060006EF RID: 1775 RVA: 0x0001FA34 File Offset: 0x0001DC34
		private void Start()
		{
			for (int i = 1; i <= this.instances; i++)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject);
				gameObject.GetComponent<CubeSpawn>().enabled = false;
				gameObject.name = "Cube" + i.ToString();
				float f = (float)i / (float)this.instances * 3.1415927f * 2f * this.laps;
				float num = (float)i * this.expansion;
				float x = Mathf.Cos(f) * (this.radius + num);
				float z = Mathf.Sin(f) * (this.radius + num);
				Vector3 b = Random.insideUnitSphere * this.jitter;
				gameObject.transform.position = base.transform.position + new Vector3(x, 0f, z) + b;
				gameObject.transform.localScale *= 1f - Random.value * this.jitter;
			}
		}

		// Token: 0x040007D4 RID: 2004
		public int instances = 150;

		// Token: 0x040007D5 RID: 2005
		public float radius = 2f;

		// Token: 0x040007D6 RID: 2006
		public float jitter = 0.5f;

		// Token: 0x040007D7 RID: 2007
		public float expansion = 0.04f;

		// Token: 0x040007D8 RID: 2008
		public float laps = 2f;
	}
}
