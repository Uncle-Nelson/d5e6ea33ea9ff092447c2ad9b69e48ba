using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020009A8 RID: 2472
	public class ACWindow : MonoBehaviour
	{
		// Token: 0x060042DB RID: 17115 RVA: 0x00118554 File Offset: 0x00116754
		private void Start()
		{
			this.TitleText.text = this.WindowTitle;
			if (this.Predecessor != null)
			{
				this.BackButton.onClick.AddListener(new UnityAction(this.Close));
				this.BackButton.gameObject.SetActive(true);
			}
			else
			{
				this.BackButton.gameObject.SetActive(false);
			}
			if (this.Predecessor != null)
			{
				base.gameObject.SetActive(false);
			}
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x000C0C9B File Offset: 0x000BEE9B
		public void Open()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x001185DA File Offset: 0x001167DA
		public void Close()
		{
			base.gameObject.SetActive(false);
			if (this.Predecessor != null)
			{
				this.Predecessor.Open();
			}
		}

		// Token: 0x0400307B RID: 12411
		[Header("Settings")]
		public string WindowTitle;

		// Token: 0x0400307C RID: 12412
		public ACWindow Predecessor;

		// Token: 0x0400307D RID: 12413
		[Header("References")]
		public TextMeshProUGUI TitleText;

		// Token: 0x0400307E RID: 12414
		public Button BackButton;
	}
}
