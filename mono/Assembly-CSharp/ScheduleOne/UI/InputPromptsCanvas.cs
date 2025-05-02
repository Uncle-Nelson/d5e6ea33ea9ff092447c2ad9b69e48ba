using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x020009F8 RID: 2552
	public class InputPromptsCanvas : Singleton<InputPromptsCanvas>
	{
		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x060044D3 RID: 17619 RVA: 0x0012038E File Offset: 0x0011E58E
		// (set) Token: 0x060044D4 RID: 17620 RVA: 0x00120396 File Offset: 0x0011E596
		public string currentModuleLabel { get; protected set; } = string.Empty;

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x060044D5 RID: 17621 RVA: 0x0012039F File Offset: 0x0011E59F
		// (set) Token: 0x060044D6 RID: 17622 RVA: 0x001203A7 File Offset: 0x0011E5A7
		public RectTransform currentModule { get; private set; }

		// Token: 0x060044D7 RID: 17623 RVA: 0x001203B0 File Offset: 0x0011E5B0
		public void LoadModule(string key)
		{
			GameObject module = this.Modules.Find((InputPromptsCanvas.Module x) => x.key.ToLower() == key.ToLower()).module;
			if (module == null)
			{
				Console.LogError("Input prompt module with key '" + key + "' not found!", null);
				return;
			}
			if (this.currentModule != null)
			{
				this.UnloadModule();
			}
			this.currentModuleLabel = key;
			this.currentModule = Object.Instantiate<GameObject>(module, this.InputPromptsContainer).GetComponent<RectTransform>();
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x00120443 File Offset: 0x0011E643
		public void UnloadModule()
		{
			this.currentModuleLabel = string.Empty;
			if (this.currentModule != null)
			{
				Object.Destroy(this.currentModule.gameObject);
			}
		}

		// Token: 0x0400325C RID: 12892
		public RectTransform InputPromptsContainer;

		// Token: 0x0400325D RID: 12893
		[Header("Input prompt modules")]
		public List<InputPromptsCanvas.Module> Modules = new List<InputPromptsCanvas.Module>();

		// Token: 0x020009F9 RID: 2553
		[Serializable]
		public class Module
		{
			// Token: 0x04003260 RID: 12896
			public string key;

			// Token: 0x04003261 RID: 12897
			public GameObject module;
		}
	}
}
