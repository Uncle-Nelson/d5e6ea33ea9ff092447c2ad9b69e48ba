using System;
using UnityEngine;
using UnityEngine.UI;

namespace ItemIconCreator
{
	// Token: 0x02000223 RID: 547
	public class IconCreatorCanvas : MonoBehaviour
	{
		// Token: 0x06000BA8 RID: 2984 RVA: 0x0003650F File Offset: 0x0003470F
		private void Awake()
		{
			IconCreatorCanvas.instance = this;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00036518 File Offset: 0x00034718
		public void SetInfo(int totalItens, int currentItem, string itemName, bool isRecording, KeyCode key)
		{
			this.borders.gameObject.SetActive(isRecording);
			if (!isRecording)
			{
				this.textLabel.text = "Go to your icon builder in hierarchy and press 'Build icons'";
				return;
			}
			this.textLabel.text = string.Concat(new string[]
			{
				currentItem.ToString(),
				" / ",
				totalItens.ToString(),
				" - ",
				itemName,
				"   |   Press <b>",
				key.ToString(),
				"</b> to continue"
			});
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x000365AA File Offset: 0x000347AA
		public void SetTakingPicture()
		{
			this.textLabel.text = "Generating icon...";
		}

		// Token: 0x04000D1B RID: 3355
		public Text textLabel;

		// Token: 0x04000D1C RID: 3356
		public GameObject borders;

		// Token: 0x04000D1D RID: 3357
		public static IconCreatorCanvas instance;
	}
}
