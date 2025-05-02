using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200030C RID: 780
	[CreateAssetMenu(fileName = "Disorienting", menuName = "Properties/Disorienting Property")]
	public class Disorienting : Property
	{
		// Token: 0x06001143 RID: 4419 RVA: 0x0004C7B4 File Offset: 0x0004A9B4
		public override void ApplyToNPC(NPC npc)
		{
			npc.Movement.Disoriented = true;
			npc.Avatar.Eyes.leftEye.AngleOffset = new Vector2(20f, 10f);
			npc.Avatar.EmotionManager.AddEmotionOverride("Concerned", "disoriented", 0f, 0);
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x0004C814 File Offset: 0x0004AA14
		public override void ApplyToPlayer(Player player)
		{
			player.Disoriented = true;
			player.Avatar.Eyes.leftEye.AngleOffset = new Vector2(20f, 10f);
			if (player.IsOwner)
			{
				PlayerSingleton<PlayerCamera>.Instance.SmoothLookSmoother.AddOverride(0.8f, this.Tier, "disoriented");
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0004C874 File Offset: 0x0004AA74
		public override void ClearFromNPC(NPC npc)
		{
			npc.Movement.Disoriented = false;
			npc.Avatar.Eyes.leftEye.AngleOffset = Vector2.zero;
			npc.Avatar.Eyes.rightEye.AngleOffset = Vector2.zero;
			npc.Avatar.EmotionManager.RemoveEmotionOverride("disoriented");
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x0004C8D8 File Offset: 0x0004AAD8
		public override void ClearFromPlayer(Player player)
		{
			player.Disoriented = false;
			player.Avatar.Eyes.leftEye.AngleOffset = Vector2.zero;
			player.Avatar.Eyes.rightEye.AngleOffset = Vector2.zero;
			if (player.IsOwner)
			{
				PlayerSingleton<PlayerCamera>.Instance.SmoothLookSmoother.RemoveOverride("disoriented");
			}
		}
	}
}
