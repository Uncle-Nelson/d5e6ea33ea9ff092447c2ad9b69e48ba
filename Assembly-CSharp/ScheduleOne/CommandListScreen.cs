using System;
using System.Collections.Generic;
using ScheduleOne.UI.MainMenu;
using TMPro;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x02000273 RID: 627
	public class CommandListScreen : MainMenuScreen
	{
		// Token: 0x06000D1B RID: 3355 RVA: 0x0003A4F4 File Offset: 0x000386F4
		private void Start()
		{
			if (this.commandEntries.Count == 0)
			{
				foreach (Console.ConsoleCommand consoleCommand in Console.Commands)
				{
					RectTransform rectTransform = Object.Instantiate<RectTransform>(this.CommandEntryPrefab, this.CommandEntryContainer);
					rectTransform.Find("Command").GetComponent<TextMeshProUGUI>().text = consoleCommand.CommandWord;
					rectTransform.Find("Description").GetComponent<TextMeshProUGUI>().text = consoleCommand.CommandDescription;
					rectTransform.Find("Example").GetComponent<TextMeshProUGUI>().text = consoleCommand.ExampleUsage;
					this.commandEntries.Add(rectTransform);
				}
			}
			this.CommandEntryContainer.offsetMin = new Vector2(this.CommandEntryContainer.offsetMin.x, 0f);
			this.CommandEntryContainer.offsetMax = new Vector2(this.CommandEntryContainer.offsetMax.x, 0f);
		}

		// Token: 0x04000DA7 RID: 3495
		public RectTransform CommandEntryContainer;

		// Token: 0x04000DA8 RID: 3496
		public RectTransform CommandEntryPrefab;

		// Token: 0x04000DA9 RID: 3497
		private List<RectTransform> commandEntries = new List<RectTransform>();
	}
}
