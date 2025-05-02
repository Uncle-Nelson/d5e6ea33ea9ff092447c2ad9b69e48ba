using System;
using System.Linq;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.Properties.MixMaps
{
	// Token: 0x0200032F RID: 815
	public class MixerMapGenerator : MonoBehaviour
	{
		// Token: 0x060011E2 RID: 4578 RVA: 0x0004DE48 File Offset: 0x0004C048
		private void OnValidate()
		{
			this.BasePlateMesh.localScale = Vector3.one * this.MapRadius * 2f * 0.01f;
			base.gameObject.name = this.MapName;
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0004DE98 File Offset: 0x0004C098
		[Button]
		public void CreateEffectPrefabs()
		{
			foreach (Property property in Resources.LoadAll<Property>("Properties"))
			{
				if (this.GetEffect(property) == null)
				{
					Effect effect = Object.Instantiate<Effect>(this.EffectPrefab, base.transform);
					effect.Property = property;
					effect.Radius = 0.5f;
					effect.transform.position = new Vector3(Random.Range(-this.MapRadius, this.MapRadius), 0.1f, Random.Range(-this.MapRadius, this.MapRadius));
				}
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0004DF2C File Offset: 0x0004C12C
		[Button]
		public Effect GetEffect(Property property)
		{
			return base.GetComponentsInChildren<Effect>().FirstOrDefault((Effect effect) => effect.Property == property);
		}

		// Token: 0x0400116E RID: 4462
		public float MapRadius = 5f;

		// Token: 0x0400116F RID: 4463
		public string MapName = "New Map";

		// Token: 0x04001170 RID: 4464
		public Transform BasePlateMesh;

		// Token: 0x04001171 RID: 4465
		public Effect EffectPrefab;
	}
}
