using System;
using UnityEngine;
using VLB;

namespace VLB_Samples
{
	// Token: 0x02000160 RID: 352
	public class LightGenerator : MonoBehaviour
	{
		// Token: 0x060006C8 RID: 1736 RVA: 0x0001E85C File Offset: 0x0001CA5C
		public void Generate()
		{
			for (int i = 0; i < this.CountX; i++)
			{
				for (int j = 0; j < this.CountY; j++)
				{
					GameObject gameObject;
					if (this.AddLight)
					{
						gameObject = new GameObject("Light_" + i.ToString() + "_" + j.ToString(), new Type[]
						{
							typeof(Light),
							typeof(VolumetricLightBeamSD),
							typeof(Rotater)
						});
					}
					else
					{
						gameObject = new GameObject("Light_" + i.ToString() + "_" + j.ToString(), new Type[]
						{
							typeof(VolumetricLightBeamSD),
							typeof(Rotater)
						});
					}
					gameObject.transform.SetPositionAndRotation(new Vector3((float)i * this.OffsetUnits, this.PositionY, (float)j * this.OffsetUnits), Quaternion.Euler((float)Random.Range(-45, 45) + 90f, (float)Random.Range(0, 360), 0f));
					VolumetricLightBeamSD component = gameObject.GetComponent<VolumetricLightBeamSD>();
					if (this.AddLight)
					{
						Light component2 = gameObject.GetComponent<Light>();
						component2.type = LightType.Spot;
						component2.color = new Color(Random.value, Random.value, Random.value, 1f);
						component2.range = Random.Range(3f, 8f);
						component2.intensity = Random.Range(0.2f, 5f);
						component2.spotAngle = Random.Range(10f, 90f);
						if (Config.Instance.geometryOverrideLayer)
						{
							component2.cullingMask = ~(1 << Config.Instance.geometryLayerID);
						}
					}
					else
					{
						component.color = new Color(Random.value, Random.value, Random.value, 1f);
						component.fallOffEnd = Random.Range(3f, 8f);
						component.spotAngle = Random.Range(10f, 90f);
					}
					component.coneRadiusStart = Random.Range(0f, 0.1f);
					component.geomCustomSides = Random.Range(12, 36);
					component.fresnelPow = Random.Range(1f, 7.5f);
					component.noiseMode = (this.NoiseEnabled ? NoiseMode.WorldSpace : NoiseMode.Disabled);
					gameObject.GetComponent<Rotater>().EulerSpeed = new Vector3(0f, (float)Random.Range(-500, 500), 0f);
				}
			}
		}

		// Token: 0x0400078C RID: 1932
		[Range(1f, 100f)]
		[SerializeField]
		private int CountX = 10;

		// Token: 0x0400078D RID: 1933
		[Range(1f, 100f)]
		[SerializeField]
		private int CountY = 10;

		// Token: 0x0400078E RID: 1934
		[SerializeField]
		private float OffsetUnits = 1f;

		// Token: 0x0400078F RID: 1935
		[SerializeField]
		private float PositionY = 1f;

		// Token: 0x04000790 RID: 1936
		[SerializeField]
		private bool NoiseEnabled;

		// Token: 0x04000791 RID: 1937
		[SerializeField]
		private bool AddLight = true;
	}
}
