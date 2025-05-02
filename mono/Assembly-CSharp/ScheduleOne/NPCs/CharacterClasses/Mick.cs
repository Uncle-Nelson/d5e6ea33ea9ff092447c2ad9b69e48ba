using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.Variables;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004CC RID: 1228
	public class Mick : NPC
	{
		// Token: 0x06001B33 RID: 6963 RVA: 0x00072323 File Offset: 0x00070523
		protected override void Start()
		{
			base.Start();
			this.dialogueHandler.GetComponent<DialogueController>().Choices[0].isValidCheck = new DialogueController.DialogueChoice.IsChoiceValid(this.CanPawn);
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x00072352 File Offset: 0x00070552
		private bool CanPawn(out string reason)
		{
			reason = string.Empty;
			if (NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>("PawnShopAngeredToday"))
			{
				reason = "Mick doesn't want to do business with you right now.";
				return false;
			}
			return true;
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00072376 File Offset: 0x00070576
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MickAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MickAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0007238F File Offset: 0x0007058F
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MickAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MickAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x000723A8 File Offset: 0x000705A8
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x000723B6 File Offset: 0x000705B6
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016E0 RID: 5856
		private bool dll_Excuted;

		// Token: 0x040016E1 RID: 5857
		private bool dll_Excuted;
	}
}
