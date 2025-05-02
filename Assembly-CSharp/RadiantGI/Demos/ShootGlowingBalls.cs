using System;
using UnityEngine;

namespace RadiantGI.Demos
{
	// Token: 0x02000169 RID: 361
	public class ShootGlowingBalls : MonoBehaviour
	{
		// Token: 0x060006E2 RID: 1762 RVA: 0x0001F6B4 File Offset: 0x0001D8B4
		private void Start()
		{
			for (int i = 0; i < this.count; i++)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.glowingBall, this.center.position + Vector3.right * (float)Random.Range(-4, 4) + Vector3.up * (5f + (float)i), Quaternion.identity);
				Color color = Random.ColorHSV();
				float value = Random.value;
				if (value < 0.33f)
				{
					color.r *= 0.2f;
				}
				else if (value < 0.66f)
				{
					color.g *= 0.2f;
				}
				else
				{
					color.b *= 0.2f;
				}
				Renderer component = gameObject.GetComponent<Renderer>();
				component.transform.localScale = Vector3.one * Random.Range(0.65f, 1f);
				component.material.color = color;
				component.material.SetColor("_EmissionColor", color * 2f);
			}
		}

		// Token: 0x040007CA RID: 1994
		public int count;

		// Token: 0x040007CB RID: 1995
		public Transform center;

		// Token: 0x040007CC RID: 1996
		public GameObject glowingBall;
	}
}
