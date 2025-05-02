using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.Persistence;
using ScheduleOne.UI.Phone.Delivery;
using ScheduleOne.UI.Shop;
using ScheduleOne.Variables;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004CF RID: 1231
	public class Oscar : NPC
	{
		// Token: 0x06001B45 RID: 6981 RVA: 0x00072472 File Offset: 0x00070672
		protected override void Start()
		{
			base.Start();
			this.ShopInterface.onOrderCompleted.AddListener(new UnityAction(this.OrderCompleted));
			Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(this.Loaded));
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x000724B1 File Offset: 0x000706B1
		private void OrderCompleted()
		{
			base.PlayVO(EVOLineType.Thanks);
			this.dialogueHandler.ShowWorldspaceDialogue(this.OrderCompletedLines[Random.Range(0, this.OrderCompletedLines.Length)], 5f);
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x000724DF File Offset: 0x000706DF
		private void Loaded()
		{
			Singleton<LoadManager>.Instance.onLoadComplete.RemoveListener(new UnityAction(this.Loaded));
			if (!NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>(this.GreetedVariable))
			{
				this.EnableGreeting();
			}
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00072514 File Offset: 0x00070714
		private void EnableGreeting()
		{
			this.dialogueHandler.GetComponent<DialogueController>().OverrideContainer = this.GreetingDialogue;
			this.dialogueHandler.onConversationStart.AddListener(new UnityAction(this.SetGreeted));
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x00072548 File Offset: 0x00070748
		private void SetGreeted()
		{
			this.dialogueHandler.onConversationStart.RemoveListener(new UnityAction(this.SetGreeted));
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue(this.GreetedVariable, true.ToString(), true);
			this.dialogueHandler.GetComponent<DialogueController>().OverrideContainer = null;
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0007259C File Offset: 0x0007079C
		public void EnableDeliveries()
		{
			Singleton<CoroutineService>.Instance.StartCoroutine(this.<EnableDeliveries>g__Wait|9_0());
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x000725C2 File Offset: 0x000707C2
		[CompilerGenerated]
		private IEnumerator <EnableDeliveries>g__Wait|9_0()
		{
			yield return new WaitUntil(() => PlayerSingleton<DeliveryApp>.InstanceExists);
			PlayerSingleton<DeliveryApp>.Instance.GetShop(this.ShopInterface).SetIsAvailable();
			yield break;
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x000725D1 File Offset: 0x000707D1
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.OscarAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.OscarAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x000725EA File Offset: 0x000707EA
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.OscarAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.OscarAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00072603 File Offset: 0x00070803
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00072611 File Offset: 0x00070811
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016E7 RID: 5863
		public ShopInterface ShopInterface;

		// Token: 0x040016E8 RID: 5864
		[Header("Settings")]
		public string[] OrderCompletedLines;

		// Token: 0x040016E9 RID: 5865
		public DialogueContainer GreetingDialogue;

		// Token: 0x040016EA RID: 5866
		public string GreetedVariable = "OscarGreeted";

		// Token: 0x040016EB RID: 5867
		private bool dll_Excuted;

		// Token: 0x040016EC RID: 5868
		private bool dll_Excuted;
	}
}
