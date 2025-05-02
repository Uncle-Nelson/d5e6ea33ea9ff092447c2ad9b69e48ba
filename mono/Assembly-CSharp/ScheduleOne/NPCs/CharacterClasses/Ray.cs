using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.Levelling;
using ScheduleOne.Persistence;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004D7 RID: 1239
	public class Ray : NPC
	{
		// Token: 0x06001B73 RID: 7027 RVA: 0x0007286E File Offset: 0x00070A6E
		protected override void Start()
		{
			base.Start();
			Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(this.Loaded));
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00072891 File Offset: 0x00070A91
		private void Loaded()
		{
			Singleton<LoadManager>.Instance.onLoadComplete.RemoveListener(new UnityAction(this.Loaded));
			if (!NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>(this.GreetedVariable))
			{
				this.EnableGreeting();
			}
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x000728C6 File Offset: 0x00070AC6
		private void EnableGreeting()
		{
			this.dialogueHandler.GetComponent<DialogueController>().OverrideContainer = this.GreetingDialogue;
			this.dialogueHandler.onConversationStart.AddListener(new UnityAction(this.SetGreeted));
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x000728FC File Offset: 0x00070AFC
		private void SetGreeted()
		{
			this.dialogueHandler.onConversationStart.RemoveListener(new UnityAction(this.SetGreeted));
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue(this.GreetedVariable, true.ToString(), true);
			this.dialogueHandler.GetComponent<DialogueController>().OverrideContainer = null;
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00072981 File Offset: 0x00070B81
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.RayAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.RayAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0007299A File Offset: 0x00070B9A
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.RayAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.RayAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x000729B3 File Offset: 0x00070BB3
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x000729C1 File Offset: 0x00070BC1
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016FC RID: 5884
		public DialogueContainer GreetingDialogue;

		// Token: 0x040016FD RID: 5885
		public string GreetedVariable = "RayGreeted";

		// Token: 0x040016FE RID: 5886
		public string IntroductionMessage;

		// Token: 0x040016FF RID: 5887
		public string IntroSentVariable = "RayIntroSent";

		// Token: 0x04001700 RID: 5888
		[Header("Intro message conditions")]
		public FullRank IntroRank;

		// Token: 0x04001701 RID: 5889
		public int IntroDaysPlayed = 21;

		// Token: 0x04001702 RID: 5890
		public float IntroNetworth = 15000f;

		// Token: 0x04001703 RID: 5891
		private bool dll_Excuted;

		// Token: 0x04001704 RID: 5892
		private bool dll_Excuted;
	}
}
