using System;
using ScheduleOne.UI.Shop;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004DA RID: 1242
	public class Steve : NPC
	{
		// Token: 0x06001B8B RID: 7051 RVA: 0x00072BED File Offset: 0x00070DED
		protected override void Start()
		{
			base.Start();
			this.ShopInterface.onOrderCompleted.AddListener(new UnityAction(this.OrderCompleted));
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00072C11 File Offset: 0x00070E11
		private void OrderCompleted()
		{
			base.PlayVO(EVOLineType.Thanks);
			this.dialogueHandler.ShowWorldspaceDialogue(this.OrderCompletedLines[Random.Range(0, this.OrderCompletedLines.Length)], 5f);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00072C3F File Offset: 0x00070E3F
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SteveAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SteveAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x00072C58 File Offset: 0x00070E58
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SteveAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SteveAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x00072C71 File Offset: 0x00070E71
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x00072C7F File Offset: 0x00070E7F
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400170A RID: 5898
		public ShopInterface ShopInterface;

		// Token: 0x0400170B RID: 5899
		[Header("Settings")]
		public string[] OrderCompletedLines;

		// Token: 0x0400170C RID: 5900
		private bool dll_Excuted;

		// Token: 0x0400170D RID: 5901
		private bool dll_Excuted;
	}
}
