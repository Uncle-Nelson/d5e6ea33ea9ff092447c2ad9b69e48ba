using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000309 RID: 777
	[CreateAssetMenu(fileName = "BrightEyed", menuName = "Properties/BrightEyed Property")]
	public class BrightEyed : Property
	{
		// Token: 0x06001134 RID: 4404 RVA: 0x0004C5A5 File Offset: 0x0004A7A5
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Effects.OverrideEyeColor(this.EyeColor, this.Emission, true);
			npc.Avatar.Effects.SetEyeLightEmission(this.LightIntensity, this.EyeColor, true);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0004C5E1 File Offset: 0x0004A7E1
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Effects.OverrideEyeColor(this.EyeColor, this.Emission, true);
			player.Avatar.Effects.SetEyeLightEmission(this.LightIntensity, this.EyeColor, true);
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x0004C61D File Offset: 0x0004A81D
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Effects.ResetEyeColor(true);
			npc.Avatar.Effects.SetEyeLightEmission(0f, this.EyeColor, true);
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x0004C64C File Offset: 0x0004A84C
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Effects.ResetEyeColor(true);
			player.Avatar.Effects.SetEyeLightEmission(0f, this.EyeColor, true);
		}

		// Token: 0x0400113C RID: 4412
		public Color EyeColor;

		// Token: 0x0400113D RID: 4413
		public float Emission = 0.5f;

		// Token: 0x0400113E RID: 4414
		public float LightIntensity = 1f;
	}
}
