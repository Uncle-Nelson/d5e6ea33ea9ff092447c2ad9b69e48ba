using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000310 RID: 784
	[CreateAssetMenu(fileName = "Foggy", menuName = "Properties/Foggy Property")]
	public class Foggy : Property
	{
		// Token: 0x06001157 RID: 4439 RVA: 0x0004CBEE File Offset: 0x0004ADEE
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.SetFoggy(true, true);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0004CC02 File Offset: 0x0004AE02
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.SetFoggy(true, true);
			if (player.IsLocalPlayer)
			{
				Singleton<EnvironmentFX>.Instance.FogEndDistanceController.AddOverride(0.1f, this.Tier, base.name);
			}
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x0004CC3E File Offset: 0x0004AE3E
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.SetFoggy(false, true);
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x0004CC52 File Offset: 0x0004AE52
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.SetFoggy(false, true);
			if (player.IsLocalPlayer)
			{
				Singleton<EnvironmentFX>.Instance.FogEndDistanceController.RemoveOverride(base.name);
			}
		}
	}
}
