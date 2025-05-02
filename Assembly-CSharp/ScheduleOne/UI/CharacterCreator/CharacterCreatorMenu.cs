using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000B44 RID: 2884
	public class CharacterCreatorMenu : MonoBehaviour
	{
		// Token: 0x06004CBB RID: 19643 RVA: 0x00143A28 File Offset: 0x00141C28
		public void Start()
		{
			CharacterCreatorMenu.Window[] windows = this.Windows;
			for (int i = 0; i < windows.Length; i++)
			{
				windows[i].Close();
			}
			this.OpenWindow(0);
		}

		// Token: 0x06004CBC RID: 19644 RVA: 0x00143A5C File Offset: 0x00141C5C
		public void OpenWindow(int index)
		{
			if (this.openWindow != null)
			{
				this.openWindow.Close();
			}
			this.openWindowIndex = index;
			this.openWindow = this.Windows[index];
			this.openWindow.Open();
			this.CategoryLabel.text = this.openWindow.Name;
			this.BackButton.interactable = (index > 0);
			this.NextButton.interactable = (index < this.Windows.Length - 1);
		}

		// Token: 0x06004CBD RID: 19645 RVA: 0x00143AD9 File Offset: 0x00141CD9
		public void Back()
		{
			this.OpenWindow(this.openWindowIndex - 1);
		}

		// Token: 0x06004CBE RID: 19646 RVA: 0x00143AE9 File Offset: 0x00141CE9
		public void Next()
		{
			this.OpenWindow(this.openWindowIndex + 1);
		}

		// Token: 0x040039CC RID: 14796
		public CharacterCreatorMenu.Window[] Windows;

		// Token: 0x040039CD RID: 14797
		[Header("References")]
		public TextMeshProUGUI CategoryLabel;

		// Token: 0x040039CE RID: 14798
		public Button BackButton;

		// Token: 0x040039CF RID: 14799
		public Button NextButton;

		// Token: 0x040039D0 RID: 14800
		private int openWindowIndex;

		// Token: 0x040039D1 RID: 14801
		private CharacterCreatorMenu.Window openWindow;

		// Token: 0x02000B45 RID: 2885
		[Serializable]
		public class Window
		{
			// Token: 0x06004CC0 RID: 19648 RVA: 0x00143AF9 File Offset: 0x00141CF9
			public void Open()
			{
				this.Container.gameObject.SetActive(true);
			}

			// Token: 0x06004CC1 RID: 19649 RVA: 0x00143B0C File Offset: 0x00141D0C
			public void Close()
			{
				this.Container.gameObject.SetActive(false);
			}

			// Token: 0x040039D2 RID: 14802
			public string Name;

			// Token: 0x040039D3 RID: 14803
			public RectTransform Container;
		}
	}
}
