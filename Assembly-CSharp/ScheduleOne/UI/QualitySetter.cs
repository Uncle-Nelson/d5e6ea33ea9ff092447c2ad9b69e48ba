using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x020009BA RID: 2490
	public class QualitySetter : MonoBehaviour
	{
		// Token: 0x0600432F RID: 17199 RVA: 0x00119AD5 File Offset: 0x00117CD5
		private void Awake()
		{
			base.GetComponent<TMP_Dropdown>().onValueChanged.AddListener(new UnityAction<int>(delegate(int x)
			{
				this.SetQuality(x);
			}));
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x00119AF3 File Offset: 0x00117CF3
		private void SetQuality(int quality)
		{
			Console.Log("Setting quality to " + quality.ToString(), null);
			QualitySettings.SetQualityLevel(quality);
		}
	}
}
