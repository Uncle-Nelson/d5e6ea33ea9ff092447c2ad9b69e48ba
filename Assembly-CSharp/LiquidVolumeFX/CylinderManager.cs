using System;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x0200016F RID: 367
	public class CylinderManager : MonoBehaviour
	{
		// Token: 0x060006F7 RID: 1783 RVA: 0x0001FDEC File Offset: 0x0001DFEC
		private void Update()
		{
			if (Time.time < this.startingDelay)
			{
				return;
			}
			for (int i = 0; i < this.numCylinders; i++)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(Resources.Load<GameObject>("Prefabs/CylinderFlask"));
				gameObject.hideFlags = HideFlags.DontSave;
				gameObject.transform.SetParent(base.transform, false);
				gameObject.transform.localScale = new Vector3(this.scale, this.scale * this.heightMultiplier, this.scale);
				float x = Mathf.Cos((float)i / (float)this.numCylinders * 3.1415927f * 2f) * this.circleRadius;
				float z = Mathf.Sin((float)i / (float)this.numCylinders * 3.1415927f * 2f) * this.circleRadius;
				gameObject.transform.position = new Vector3(x, -2f, z);
				FlaskAnimator flaskAnimator = gameObject.AddComponent<FlaskAnimator>();
				flaskAnimator.initialPosition = gameObject.transform.position;
				flaskAnimator.finalPosition = gameObject.transform.position + Vector3.up;
				flaskAnimator.duration = 5f + (float)i * 0.5f;
				flaskAnimator.acceleration = 0.001f;
				flaskAnimator.delay = 4f;
				LiquidVolume component = gameObject.GetComponent<LiquidVolume>();
				component.liquidColor1 = new Color(Random.value, Random.value, Random.value, Random.value);
				component.liquidColor2 = new Color(Random.value, Random.value, Random.value, Random.value);
				component.turbulence2 = 0f;
				component.refractionBlur = false;
			}
			Object.Destroy(this);
		}

		// Token: 0x040007E8 RID: 2024
		public float startingDelay = 1f;

		// Token: 0x040007E9 RID: 2025
		public int numCylinders = 16;

		// Token: 0x040007EA RID: 2026
		public float scale = 0.2f;

		// Token: 0x040007EB RID: 2027
		public float heightMultiplier = 2f;

		// Token: 0x040007EC RID: 2028
		public float circleRadius = 1.75f;
	}
}
