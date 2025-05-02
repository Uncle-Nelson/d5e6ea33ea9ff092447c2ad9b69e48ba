using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.Persistence;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004A8 RID: 1192
	public class Fixer : NPC
	{
		// Token: 0x06001A68 RID: 6760 RVA: 0x00071160 File Offset: 0x0006F360
		protected override void Start()
		{
			base.Start();
			Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(this.Loaded));
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00071183 File Offset: 0x0006F383
		private void Loaded()
		{
			Singleton<LoadManager>.Instance.onLoadComplete.RemoveListener(new UnityAction(this.Loaded));
			if (!NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>(this.GreetedVariable))
			{
				this.EnableGreeting();
			}
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x000711B8 File Offset: 0x0006F3B8
		private void EnableGreeting()
		{
			this.dialogueHandler.GetComponent<DialogueController>().OverrideContainer = this.GreetingDialogue;
			this.dialogueHandler.onConversationStart.AddListener(new UnityAction(this.SetGreeted));
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x000711EC File Offset: 0x0006F3EC
		private void SetGreeted()
		{
			this.dialogueHandler.onConversationStart.RemoveListener(new UnityAction(this.SetGreeted));
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue(this.GreetedVariable, true.ToString(), true);
			this.dialogueHandler.GetComponent<DialogueController>().OverrideContainer = null;
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00071240 File Offset: 0x0006F440
		public static float GetAdditionalSigningFee()
		{
			int num = Mathf.RoundToInt(NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("LifetimeEmployeesRecruited"));
			float num2 = 0f;
			for (int i = 0; i < num; i++)
			{
				if (i <= 5)
				{
					num2 += 100f;
				}
				else
				{
					num2 += 250f;
				}
			}
			return Mathf.Min(num2, 500f);
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x000712A8 File Offset: 0x0006F4A8
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x000712C1 File Offset: 0x0006F4C1
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x000712DA File Offset: 0x0006F4DA
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x000712E8 File Offset: 0x0006F4E8
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001685 RID: 5765
		public const int ADDITIONAL_SIGNING_FEE_1 = 100;

		// Token: 0x04001686 RID: 5766
		public const int ADDITIONAL_SIGNING_FEE_2 = 250;

		// Token: 0x04001687 RID: 5767
		public const int MAX_SIGNING_FEE = 500;

		// Token: 0x04001688 RID: 5768
		public const int ADDITIONAL_FEE_THRESHOLD = 5;

		// Token: 0x04001689 RID: 5769
		public DialogueContainer GreetingDialogue;

		// Token: 0x0400168A RID: 5770
		public string GreetedVariable = "FixerGreeted";

		// Token: 0x0400168B RID: 5771
		private bool dll_Excuted;

		// Token: 0x0400168C RID: 5772
		private bool dll_Excuted;
	}
}
