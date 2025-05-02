using System;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Shop;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004AF RID: 1199
	public class Herbert : NPC
	{
		// Token: 0x06001A90 RID: 6800 RVA: 0x000714F4 File Offset: 0x0006F6F4
		protected override void Start()
		{
			base.Start();
			this.ShopInterface.onOrderCompleted.AddListener(new UnityAction(this.OrderCompleted));
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00071518 File Offset: 0x0006F718
		private void OrderCompleted()
		{
			base.PlayVO(EVOLineType.Thanks);
			string text = this.OrderCompletedLines[Random.Range(0, this.OrderCompletedLines.Length)];
			text = text.Replace("formal_address", Player.Local.Avatar.GetFormalAddress(true));
			this.dialogueHandler.ShowWorldspaceDialogue(text, 5f);
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x0007156F File Offset: 0x0006F76F
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.HerbertAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.HerbertAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00071588 File Offset: 0x0006F788
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.HerbertAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.HerbertAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x000715A1 File Offset: 0x0006F7A1
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x000715AF File Offset: 0x0006F7AF
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001699 RID: 5785
		public ShopInterface ShopInterface;

		// Token: 0x0400169A RID: 5786
		[Header("Settings")]
		public string[] OrderCompletedLines;

		// Token: 0x0400169B RID: 5787
		private bool dll_Excuted;

		// Token: 0x0400169C RID: 5788
		private bool dll_Excuted;
	}
}
