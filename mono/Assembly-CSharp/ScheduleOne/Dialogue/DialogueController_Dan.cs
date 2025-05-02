using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200069F RID: 1695
	public class DialogueController_Dan : DialogueController
	{
		// Token: 0x06002EE5 RID: 12005 RVA: 0x000C442A File Offset: 0x000C262A
		protected override void Start()
		{
			base.Start();
			if (this.ItemToGive == null)
			{
				Debug.LogWarning("ItemToGive is not set in the inspector.");
			}
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x000C444A File Offset: 0x000C264A
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			if (dialogueLabel == "GIVE_ITEM" && this.ItemToGive != null)
			{
				PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(this.ItemToGive.GetDefaultInstance(1));
			}
			return base.ModifyDialogueText(dialogueLabel, dialogueText);
		}

		// Token: 0x0400214F RID: 8527
		public ItemDefinition ItemToGive;
	}
}
