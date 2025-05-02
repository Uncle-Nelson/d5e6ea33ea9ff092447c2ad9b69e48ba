using System;
using TMPro;
using UnityEngine.Events;

namespace ScheduleOne.ExtendedComponents
{
	// Token: 0x02000626 RID: 1574
	public class GameInputField : TMP_InputField
	{
		// Token: 0x0600293B RID: 10555 RVA: 0x000AA095 File Offset: 0x000A8295
		protected override void Awake()
		{
			base.Awake();
			base.onSelect.AddListener(new UnityAction<string>(this.EditStart));
			base.onEndEdit.AddListener(new UnityAction<string>(this.EndEdit));
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x000AA0CB File Offset: 0x000A82CB
		private void EditStart(string newVal)
		{
			GameInput.IsTyping = true;
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x000AA0D3 File Offset: 0x000A82D3
		private void EndEdit(string newVal)
		{
			GameInput.IsTyping = false;
		}
	}
}
