using System;
using FishNet;
using ScheduleOne.Combat;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Employees
{
	// Token: 0x02000651 RID: 1617
	public class NPCResponses_Employee : NPCResponses
	{
		// Token: 0x06002BC0 RID: 11200 RVA: 0x000B3E4E File Offset: 0x000B204E
		protected override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
			base.RespondToFirstNonLethalAttack(perpetrator, impact);
			this.Ow(perpetrator);
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x000B3E5F File Offset: 0x000B205F
		protected override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
			base.RespondToLethalAttack(perpetrator, impact);
			this.Ow(perpetrator);
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x000B3E70 File Offset: 0x000B2070
		protected override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
			base.RespondToRepeatedNonLethalAttack(perpetrator, impact);
			this.Ow(perpetrator);
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x000B3E84 File Offset: 0x000B2084
		private void Ow(Player perpetrator)
		{
			base.npc.dialogueHandler.PlayReaction("hurt", 2.5f, false);
			base.npc.Avatar.EmotionManager.AddEmotionOverride("Annoyed", "hurt", 20f, 3);
			if (InstanceFinder.IsServer)
			{
				base.npc.behaviour.FacePlayerBehaviour.SetTarget(perpetrator.NetworkObject, 5f);
				base.npc.behaviour.FacePlayerBehaviour.Enable_Networked(null);
			}
		}
	}
}
