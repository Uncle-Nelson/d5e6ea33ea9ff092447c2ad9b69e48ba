using System;
using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001E4 RID: 484
	public class WeatherEnclosureDetector : MonoBehaviour
	{
		// Token: 0x06000AC7 RID: 2759 RVA: 0x0002FDD1 File Offset: 0x0002DFD1
		private void Start()
		{
			this.ApplyEnclosure();
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0002FDD1 File Offset: 0x0002DFD1
		private void OnEnable()
		{
			this.ApplyEnclosure();
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0002FDDC File Offset: 0x0002DFDC
		private void OnTriggerEnter(Collider other)
		{
			WeatherEnclosure componentInChildren = other.gameObject.GetComponentInChildren<WeatherEnclosure>();
			if (!componentInChildren)
			{
				return;
			}
			if (this.triggeredEnclosures.Contains(componentInChildren))
			{
				this.triggeredEnclosures.Remove(componentInChildren);
			}
			this.triggeredEnclosures.Add(componentInChildren);
			this.ApplyEnclosure();
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0002FE2C File Offset: 0x0002E02C
		private void OnTriggerExit(Collider other)
		{
			WeatherEnclosure componentInChildren = other.gameObject.GetComponentInChildren<WeatherEnclosure>();
			if (!componentInChildren)
			{
				return;
			}
			if (!this.triggeredEnclosures.Contains(componentInChildren))
			{
				return;
			}
			this.triggeredEnclosures.Remove(componentInChildren);
			this.ApplyEnclosure();
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0002FE70 File Offset: 0x0002E070
		public void ApplyEnclosure()
		{
			WeatherEnclosure weatherEnclosure;
			if (this.triggeredEnclosures.Count > 0)
			{
				weatherEnclosure = this.triggeredEnclosures[this.triggeredEnclosures.Count - 1];
				if (!weatherEnclosure)
				{
					Debug.LogError("Failed to find mesh renderer on weather enclosure, using main enclosure instead.");
					weatherEnclosure = this.mainEnclosure;
				}
			}
			else
			{
				weatherEnclosure = this.mainEnclosure;
			}
			if (this.enclosureChangedCallback != null)
			{
				this.enclosureChangedCallback(weatherEnclosure);
			}
		}

		// Token: 0x04000BAC RID: 2988
		[Tooltip("Default enclosure used when not inside the trigger of another enclosure area.")]
		public WeatherEnclosure mainEnclosure;

		// Token: 0x04000BAD RID: 2989
		private List<WeatherEnclosure> triggeredEnclosures = new List<WeatherEnclosure>();

		// Token: 0x04000BAE RID: 2990
		public RainDownfallController rainController;

		// Token: 0x04000BAF RID: 2991
		public Action<WeatherEnclosure> enclosureChangedCallback;
	}
}
