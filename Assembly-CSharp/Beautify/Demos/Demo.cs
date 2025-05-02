using System;
using Beautify.Universal;
using UnityEngine;
using UnityEngine.UI;

namespace Beautify.Demos
{
	// Token: 0x020001ED RID: 493
	public class Demo : MonoBehaviour
	{
		// Token: 0x06000AE7 RID: 2791 RVA: 0x000300EF File Offset: 0x0002E2EF
		private void Start()
		{
			this.UpdateText();
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x000300F8 File Offset: 0x0002E2F8
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.J))
			{
				BeautifySettings.settings.bloomIntensity.value += 0.1f;
			}
			if (Input.GetKeyDown(KeyCode.T) || Input.GetMouseButtonDown(0))
			{
				BeautifySettings.settings.disabled.value = !BeautifySettings.settings.disabled.value;
				this.UpdateText();
			}
			if (Input.GetKeyDown(KeyCode.B))
			{
				BeautifySettings.Blink(0.2f, 1f);
			}
			if (Input.GetKeyDown(KeyCode.C))
			{
				BeautifySettings.settings.compareMode.value = !BeautifySettings.settings.compareMode.value;
			}
			if (Input.GetKeyDown(KeyCode.N))
			{
				BeautifySettings.settings.nightVision.Override(!BeautifySettings.settings.nightVision.value);
			}
			if (Input.GetKeyDown(KeyCode.F))
			{
				if (BeautifySettings.settings.blurIntensity.overrideState)
				{
					BeautifySettings.settings.blurIntensity.overrideState = false;
				}
				else
				{
					BeautifySettings.settings.blurIntensity.Override(4f);
				}
			}
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				BeautifySettings.settings.brightness.Override(0.1f);
			}
			if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				BeautifySettings.settings.brightness.Override(0.5f);
			}
			if (Input.GetKeyDown(KeyCode.Alpha3))
			{
				BeautifySettings.settings.brightness.overrideState = false;
			}
			if (Input.GetKeyDown(KeyCode.Alpha4))
			{
				BeautifySettings.settings.outline.Override(true);
				BeautifySettings.settings.outlineColor.Override(Color.cyan);
				BeautifySettings.settings.outlineCustomize.Override(true);
				BeautifySettings.settings.outlineSpread.Override(1.5f);
			}
			if (Input.GetKeyDown(KeyCode.Alpha5))
			{
				BeautifySettings.settings.outline.overrideState = false;
			}
			if (Input.GetKeyDown(KeyCode.Alpha6))
			{
				BeautifySettings.settings.lut.Override(true);
				BeautifySettings.settings.lutIntensity.Override(1f);
				BeautifySettings.settings.lutTexture.Override(this.lutTexture);
			}
			if (Input.GetKeyDown(KeyCode.Alpha7))
			{
				BeautifySettings.settings.lut.Override(false);
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00030328 File Offset: 0x0002E528
		private void UpdateText()
		{
			if (BeautifySettings.settings.disabled.value)
			{
				GameObject.Find("Beautify").GetComponent<Text>().text = "Beautify OFF";
				return;
			}
			GameObject.Find("Beautify").GetComponent<Text>().text = "Beautify ON";
		}

		// Token: 0x04000BC0 RID: 3008
		public Texture lutTexture;
	}
}
