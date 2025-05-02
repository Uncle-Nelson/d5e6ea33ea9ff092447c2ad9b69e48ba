using System;
using UnityEngine;
using UnityEngine.UI;

namespace VolumetricFogAndMist2.Demos
{
	// Token: 0x02000163 RID: 355
	public class DemoSceneControls : MonoBehaviour
	{
		// Token: 0x060006CE RID: 1742 RVA: 0x0001ECDD File Offset: 0x0001CEDD
		private void Start()
		{
			this.SetProfile(this.index);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0001ECEC File Offset: 0x0001CEEC
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.F))
			{
				this.index++;
				if (this.index >= this.profiles.Length)
				{
					this.index = 0;
				}
				this.SetProfile(this.index);
			}
			if (Input.GetKeyDown(KeyCode.T))
			{
				this.fogVolume.gameObject.SetActive(!this.fogVolume.gameObject.activeSelf);
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001ED60 File Offset: 0x0001CF60
		private void SetProfile(int profileIndex)
		{
			if (profileIndex < 2)
			{
				this.fogVolume.transform.position = Vector3.up * 25f;
			}
			else
			{
				this.fogVolume.transform.position = Vector3.zero;
			}
			this.fogVolume.profile = this.profiles[profileIndex];
			this.presetNameDisplay.text = "Current fog preset: " + this.profiles[profileIndex].name;
			this.fogVolume.UpdateMaterialPropertiesNow(false, false);
		}

		// Token: 0x04000799 RID: 1945
		public VolumetricFogProfile[] profiles;

		// Token: 0x0400079A RID: 1946
		public VolumetricFog fogVolume;

		// Token: 0x0400079B RID: 1947
		public Text presetNameDisplay;

		// Token: 0x0400079C RID: 1948
		private int index;
	}
}
