using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.Persistence;
using ScheduleOne.Variables;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000452 RID: 1106
	public class Stan : NPC
	{
		// Token: 0x060015FE RID: 5630 RVA: 0x00060F9F File Offset: 0x0005F19F
		protected override void Start()
		{
			base.Start();
			Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(this.Loaded));
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00060FC2 File Offset: 0x0005F1C2
		private void Loaded()
		{
			Singleton<LoadManager>.Instance.onLoadComplete.RemoveListener(new UnityAction(this.Loaded));
			if (!NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>(this.GreetedVariable))
			{
				this.EnableGreeting();
			}
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00060FF7 File Offset: 0x0005F1F7
		private void EnableGreeting()
		{
			this.dialogueHandler.GetComponent<DialogueController>().OverrideContainer = this.GreetingDialogue;
			this.dialogueHandler.onConversationStart.AddListener(new UnityAction(this.SetGreeted));
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0006102C File Offset: 0x0005F22C
		private void SetGreeted()
		{
			this.dialogueHandler.onConversationStart.RemoveListener(new UnityAction(this.SetGreeted));
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue(this.GreetedVariable, true.ToString(), true);
			this.dialogueHandler.GetComponent<DialogueController>().OverrideContainer = null;
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00061093 File Offset: 0x0005F293
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.StanAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.StanAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000610AC File Offset: 0x0005F2AC
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.StanAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.StanAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x000610C5 File Offset: 0x0005F2C5
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x000610D3 File Offset: 0x0005F2D3
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001492 RID: 5266
		public DialogueContainer GreetingDialogue;

		// Token: 0x04001493 RID: 5267
		public string GreetedVariable = "StanGreeted";

		// Token: 0x04001494 RID: 5268
		private bool dll_Excuted;

		// Token: 0x04001495 RID: 5269
		private bool dll_Excuted;
	}
}
