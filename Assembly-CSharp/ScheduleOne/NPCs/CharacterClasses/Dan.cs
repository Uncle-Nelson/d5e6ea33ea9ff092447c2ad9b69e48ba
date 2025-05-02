using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Shop;
using ScheduleOne.Variables;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004A2 RID: 1186
	public class Dan : NPC
	{
		// Token: 0x06001A43 RID: 6723 RVA: 0x00070E0F File Offset: 0x0006F00F
		protected override void Start()
		{
			base.Start();
			this.ShopInterface.onOrderCompleted.AddListener(new UnityAction(this.OrderCompleted));
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00070E34 File Offset: 0x0006F034
		private void OrderCompleted()
		{
			if (NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>("Dan_Greeting_Done"))
			{
				base.PlayVO(EVOLineType.Thanks);
				this.dialogueHandler.ShowWorldspaceDialogue(this.OrderCompletedLines[Random.Range(0, this.OrderCompletedLines.Length)], 5f);
				return;
			}
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Dan_Greeting_Done", true.ToString(), true);
			base.PlayVO(EVOLineType.Question);
			if (this.onGreeting != null)
			{
				this.onGreeting.Invoke();
			}
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00070EB2 File Offset: 0x0006F0B2
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.DanAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.DanAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00070ECB File Offset: 0x0006F0CB
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.DanAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.DanAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00070EE4 File Offset: 0x0006F0E4
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00070EF2 File Offset: 0x0006F0F2
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001674 RID: 5748
		public ShopInterface ShopInterface;

		// Token: 0x04001675 RID: 5749
		[Header("Settings")]
		public string[] OrderCompletedLines;

		// Token: 0x04001676 RID: 5750
		public UnityEvent onGreeting;

		// Token: 0x04001677 RID: 5751
		private bool dll_Excuted;

		// Token: 0x04001678 RID: 5752
		private bool dll_Excuted;
	}
}
