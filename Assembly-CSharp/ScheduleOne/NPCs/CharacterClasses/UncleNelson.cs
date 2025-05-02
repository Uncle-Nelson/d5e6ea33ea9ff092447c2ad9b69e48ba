using System;
using System.Collections.Generic;
using ScheduleOne.UI.Phone.Messages;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004DE RID: 1246
	public class UncleNelson : NPC
	{
		// Token: 0x06001BAF RID: 7087 RVA: 0x00073094 File Offset: 0x00071294
		public void SendInitialMessage()
		{
			if (base.MSGConversation.messageChainHistory.Count > 0 || base.MSGConversation.messageHistory.Count > 0)
			{
				return;
			}
			base.MSGConversation.SetIsKnown(false);
			base.MSGConversation.SendMessageChain(new MessageChain
			{
				Messages = new List<string>
				{
					this.InitialMessage
				}
			}, 0f, false, true);
			base.MSGConversation.SetRead(false);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0007312C File Offset: 0x0007132C
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.UncleNelsonAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.UncleNelsonAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00073145 File Offset: 0x00071345
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.UncleNelsonAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.UncleNelsonAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0007315E File Offset: 0x0007135E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0007316C File Offset: 0x0007136C
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400171B RID: 5915
		public string InitialMessage_Demo = "I’ve heard you’re in some trouble. Best not to talk over your mobile phone. Go find a payphone.\n- U.N.";

		// Token: 0x0400171C RID: 5916
		public string InitialMessage = "You get out alright? Best not to talk over your mobile phone. Go find a payphone.\n- U.N.";

		// Token: 0x0400171D RID: 5917
		private bool dll_Excuted;

		// Token: 0x0400171E RID: 5918
		private bool dll_Excuted;
	}
}
