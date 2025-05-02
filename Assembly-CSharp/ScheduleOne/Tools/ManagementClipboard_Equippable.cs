using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Equipping;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Misc;
using ScheduleOne.UI;
using ScheduleOne.UI.Management;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000840 RID: 2112
	public class ManagementClipboard_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06003A1F RID: 14879 RVA: 0x000F5E1C File Offset: 0x000F401C
		public override void Equip(ItemInstance item)
		{
			base.Equip(item);
			Singleton<ManagementWorldspaceCanvas>.Instance.Open();
			this.Clipboard.transform.position = this.LoweredPosition.position;
			this.OverrideText.gameObject.SetActive(false);
			this.SelectionInfo.gameObject.SetActive(true);
			Singleton<ManagementClipboard>.Instance.IsEquipped = true;
			Singleton<ManagementClipboard>.Instance.onOpened.AddListener(new UnityAction(this.FullscreenEnter));
			Singleton<ManagementClipboard>.Instance.onClosed.AddListener(new UnityAction(this.FullscreenExit));
			Singleton<InputPromptsCanvas>.Instance.LoadModule("clipboard");
			if (Singleton<ManagementClipboard>.Instance.onClipboardEquipped != null)
			{
				Singleton<ManagementClipboard>.Instance.onClipboardEquipped.Invoke();
			}
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x000F5EE4 File Offset: 0x000F40E4
		public override void Unequip()
		{
			base.Unequip();
			if (Singleton<ManagementClipboard>.Instance.IsOpen)
			{
				Singleton<ManagementClipboard>.Instance.Close(false);
			}
			Singleton<ManagementWorldspaceCanvas>.Instance.Close(false);
			Singleton<ManagementClipboard>.Instance.IsEquipped = false;
			if (Singleton<ManagementClipboard>.Instance.onClipboardUnequipped != null)
			{
				Singleton<ManagementClipboard>.Instance.onClipboardUnequipped.Invoke();
			}
			if (Singleton<InputPromptsCanvas>.Instance.currentModuleLabel == "clipboard")
			{
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			}
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x000F5F60 File Offset: 0x000F4160
		protected override void Update()
		{
			base.Update();
			if (GameInput.GetButtonDown(GameInput.ButtonCode.Interact) && !GameInput.IsTyping && Singleton<InteractionManager>.Instance.hoveredValidInteractableObject == null)
			{
				if (Singleton<ManagementClipboard>.Instance.IsOpen)
				{
					Singleton<ManagementClipboard>.Instance.Close(false);
					return;
				}
				List<IConfigurable> list = new List<IConfigurable>();
				list.AddRange(Singleton<ManagementWorldspaceCanvas>.Instance.SelectedConfigurables);
				if (Singleton<ManagementWorldspaceCanvas>.Instance.HoveredConfigurable != null && !list.Contains(Singleton<ManagementWorldspaceCanvas>.Instance.HoveredConfigurable))
				{
					list.Add(Singleton<ManagementWorldspaceCanvas>.Instance.HoveredConfigurable);
				}
				Singleton<ManagementClipboard>.Instance.Open(list, this);
			}
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x000F6000 File Offset: 0x000F4200
		private void FullscreenEnter()
		{
			Singleton<ManagementWorldspaceCanvas>.Instance.Close(true);
			this.Clipboard.gameObject.SetActive(false);
			if (Singleton<InputPromptsCanvas>.Instance.currentModuleLabel == "clipboard")
			{
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			}
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x000F6040 File Offset: 0x000F4240
		private void FullscreenExit()
		{
			this.Clipboard.gameObject.SetActive(true);
			if (!Singleton<ManagementClipboard>.Instance.IsOpen && !Singleton<ManagementClipboard>.Instance.StatePreserved)
			{
				Singleton<ManagementWorldspaceCanvas>.Instance.Open();
				Singleton<InputPromptsCanvas>.Instance.LoadModule("clipboard");
			}
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x000F608F File Offset: 0x000F428F
		public void OverrideClipboardText(string overriddenText)
		{
			this.OverrideText.text = overriddenText;
			this.OverrideText.gameObject.SetActive(true);
			this.SelectionInfo.gameObject.SetActive(false);
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x000F60BF File Offset: 0x000F42BF
		public void EndOverride()
		{
			this.OverrideText.gameObject.SetActive(false);
			this.SelectionInfo.gameObject.SetActive(true);
		}

		// Token: 0x040029D5 RID: 10709
		[Header("References")]
		public Transform Clipboard;

		// Token: 0x040029D6 RID: 10710
		public Transform LoweredPosition;

		// Token: 0x040029D7 RID: 10711
		public Transform RaisedPosition;

		// Token: 0x040029D8 RID: 10712
		public ToggleableLight Light;

		// Token: 0x040029D9 RID: 10713
		public SelectionInfoUI SelectionInfo;

		// Token: 0x040029DA RID: 10714
		public TextMeshProUGUI OverrideText;

		// Token: 0x040029DB RID: 10715
		private Coroutine moveRoutine;
	}
}
