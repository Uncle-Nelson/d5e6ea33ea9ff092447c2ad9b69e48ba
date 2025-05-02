using System;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000B1C RID: 2844
	public class MainMenuPopup : Singleton<MainMenuPopup>
	{
		// Token: 0x06004BDD RID: 19421 RVA: 0x0013EA66 File Offset: 0x0013CC66
		public void Open(MainMenuPopup.Data data)
		{
			this.Open(data.Title, data.Description, data.IsBad);
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x0013EA80 File Offset: 0x0013CC80
		public void Open(string title, string description, bool isBad)
		{
			this.Title.color = (isBad ? new Color32(byte.MaxValue, 115, 115, byte.MaxValue) : Color.white);
			this.Title.text = title;
			this.Description.text = description;
			this.Screen.Open(false);
		}

		// Token: 0x040038DA RID: 14554
		public MainMenuScreen Screen;

		// Token: 0x040038DB RID: 14555
		public TextMeshProUGUI Title;

		// Token: 0x040038DC RID: 14556
		public TextMeshProUGUI Description;

		// Token: 0x02000B1D RID: 2845
		public class Data
		{
			// Token: 0x06004BE0 RID: 19424 RVA: 0x0013EAE6 File Offset: 0x0013CCE6
			public Data(string title, string description, bool isBad)
			{
				this.Title = title;
				this.Description = description;
				this.IsBad = isBad;
			}

			// Token: 0x040038DD RID: 14557
			public string Title;

			// Token: 0x040038DE RID: 14558
			public string Description;

			// Token: 0x040038DF RID: 14559
			public bool IsBad;
		}
	}
}
