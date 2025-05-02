using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200031B RID: 795
	[CreateAssetMenu(fileName = "Seizure", menuName = "Properties/Seizure Property")]
	public class Seizure : Property
	{
		// Token: 0x0600118F RID: 4495 RVA: 0x0004D45C File Offset: 0x0004B65C
		public override void ApplyToNPC(NPC npc)
		{
			Seizure.<>c__DisplayClass3_0 CS$<>8__locals1 = new Seizure.<>c__DisplayClass3_0();
			CS$<>8__locals1.npc = npc;
			CS$<>8__locals1.npc.PlayVO(EVOLineType.Hurt);
			CS$<>8__locals1.npc.behaviour.RagdollBehaviour.Seizure = true;
			CS$<>8__locals1.npc.Movement.ActivateRagdoll_Server();
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<ApplyToNPC>g__Wait|0());
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0004D4BC File Offset: 0x0004B6BC
		public override void ApplyToPlayer(Player player)
		{
			Seizure.<>c__DisplayClass4_0 CS$<>8__locals1 = new Seizure.<>c__DisplayClass4_0();
			CS$<>8__locals1.player = player;
			CS$<>8__locals1.player.Seizure = true;
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<ApplyToPlayer>g__Wait|0());
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0004D4F3 File Offset: 0x0004B6F3
		public override void ClearFromNPC(NPC npc)
		{
			npc.behaviour.RagdollBehaviour.Seizure = false;
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0004D506 File Offset: 0x0004B706
		public override void ClearFromPlayer(Player player)
		{
			player.Seizure = false;
		}

		// Token: 0x04001145 RID: 4421
		public const float CAMERA_JITTER_INTENSITY = 1f;

		// Token: 0x04001146 RID: 4422
		public const float DURATION_NPC = 60f;

		// Token: 0x04001147 RID: 4423
		public const float DURATION_PLAYER = 30f;
	}
}
