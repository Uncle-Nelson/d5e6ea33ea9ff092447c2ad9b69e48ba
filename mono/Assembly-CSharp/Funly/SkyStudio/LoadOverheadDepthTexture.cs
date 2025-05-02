using System;
using UnityEngine;
using UnityEngine.UI;

namespace Funly.SkyStudio
{
	// Token: 0x020001CF RID: 463
	[RequireComponent(typeof(RawImage))]
	public class LoadOverheadDepthTexture : MonoBehaviour
	{
		// Token: 0x06000A28 RID: 2600 RVA: 0x0002D65F File Offset: 0x0002B85F
		private void Start()
		{
			this.m_RainCamera = Object.FindObjectOfType<WeatherDepthCamera>();
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x000045B1 File Offset: 0x000027B1
		private void Update()
		{
		}

		// Token: 0x04000B3C RID: 2876
		private WeatherDepthCamera m_RainCamera;
	}
}
