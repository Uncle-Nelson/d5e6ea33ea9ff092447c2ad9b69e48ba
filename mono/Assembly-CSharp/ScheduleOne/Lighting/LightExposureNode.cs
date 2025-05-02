using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005A6 RID: 1446
	public class LightExposureNode : MonoBehaviour
	{
		// Token: 0x060023D8 RID: 9176 RVA: 0x000919AC File Offset: 0x0008FBAC
		public float GetTotalExposure(out float growSpeedMultiplier)
		{
			float num = this.ambientExposure;
			int num2 = 0;
			growSpeedMultiplier = 0f;
			foreach (UsableLightSource usableLightSource in this.sources.Keys)
			{
				if (usableLightSource != null && usableLightSource.isEmitting)
				{
					num2++;
					num += this.sources[usableLightSource];
					growSpeedMultiplier += usableLightSource.GrowSpeedMultiplier;
				}
			}
			if (num2 > 0)
			{
				growSpeedMultiplier /= (float)num2;
			}
			return num;
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00091A48 File Offset: 0x0008FC48
		public void AddSource(UsableLightSource source, float lightAmount)
		{
			if (this.sources.ContainsKey(source))
			{
				this.sources[source] = lightAmount;
				return;
			}
			this.sources.Add(source, lightAmount);
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00091A73 File Offset: 0x0008FC73
		public void RemoveSource(UsableLightSource source)
		{
			this.sources.Remove(source);
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x00091A84 File Offset: 0x0008FC84
		private void OnDrawGizmos()
		{
			float num;
			float totalExposure = this.GetTotalExposure(out num);
			if (totalExposure > this.ambientExposure)
			{
				Gizmos.color = new Color(1f, 1f, 1f, totalExposure);
				Gizmos.DrawSphere(base.transform.position, 0.1f);
			}
		}

		// Token: 0x04001AB8 RID: 6840
		public float ambientExposure;

		// Token: 0x04001AB9 RID: 6841
		public Dictionary<UsableLightSource, float> sources = new Dictionary<UsableLightSource, float>();
	}
}
