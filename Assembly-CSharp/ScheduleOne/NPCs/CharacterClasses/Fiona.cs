using System;
using ScheduleOne.Dialogue;
using ScheduleOne.UI.Shop;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004A7 RID: 1191
	public class Fiona : NPC
	{
		// Token: 0x06001A60 RID: 6752 RVA: 0x00071088 File Offset: 0x0006F288
		protected override void Start()
		{
			base.Start();
			this.ShopInterface.onOrderCompleted.AddListener(new UnityAction(this.OrderCompleted));
			this.dialogueHandler.GetComponent<DialogueController>().Choices[0].isValidCheck = new DialogueController.DialogueChoice.IsChoiceValid(this.ShopChoiceValid);
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x000710DE File Offset: 0x0006F2DE
		private void OrderCompleted()
		{
			base.PlayVO(EVOLineType.Thanks);
			this.dialogueHandler.ShowWorldspaceDialogue(this.OrderCompletedLines[Random.Range(0, this.OrderCompletedLines.Length)], 5f);
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00070B96 File Offset: 0x0006ED96
		public bool ShopChoiceValid(out string reason)
		{
			reason = string.Empty;
			return true;
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x0007110C File Offset: 0x0006F30C
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.FionaAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.FionaAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00071125 File Offset: 0x0006F325
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.FionaAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.FionaAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0007113E File Offset: 0x0006F33E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x0007114C File Offset: 0x0006F34C
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001681 RID: 5761
		public ShopInterface ShopInterface;

		// Token: 0x04001682 RID: 5762
		[Header("Settings")]
		public string[] OrderCompletedLines;

		// Token: 0x04001683 RID: 5763
		private bool dll_Excuted;

		// Token: 0x04001684 RID: 5764
		private bool dll_Excuted;
	}
}
