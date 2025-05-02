using System;
using System.Collections;
using ScheduleOne.Misc;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005A3 RID: 1443
	[RequireComponent(typeof(ToggleableLight))]
	public class BlinkingLight : MonoBehaviour
	{
		// Token: 0x060023CA RID: 9162 RVA: 0x0009173D File Offset: 0x0008F93D
		private void Awake()
		{
			this.light = base.GetComponent<ToggleableLight>();
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x0009174B File Offset: 0x0008F94B
		private void Update()
		{
			if (this.IsOn && this.blinkRoutine == null)
			{
				this.blinkRoutine = base.StartCoroutine(this.Blink());
			}
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x0009176F File Offset: 0x0008F96F
		private IEnumerator Blink()
		{
			while (this.IsOn)
			{
				this.light.isOn = true;
				yield return new WaitForSeconds(this.OnTime);
				this.light.isOn = false;
				yield return new WaitForSeconds(this.OffTime);
			}
			this.blinkRoutine = null;
			yield break;
		}

		// Token: 0x04001AA7 RID: 6823
		public bool IsOn;

		// Token: 0x04001AA8 RID: 6824
		public float OnTime = 0.5f;

		// Token: 0x04001AA9 RID: 6825
		public float OffTime = 0.5f;

		// Token: 0x04001AAA RID: 6826
		private ToggleableLight light;

		// Token: 0x04001AAB RID: 6827
		private Coroutine blinkRoutine;
	}
}
