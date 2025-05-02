using System;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000319 RID: 793
	[CreateAssetMenu(fileName = "Schizophrenic", menuName = "Properties/Schizophrenic Property")]
	public class Schizophrenic : Property
	{
		// Token: 0x06001185 RID: 4485 RVA: 0x0004D104 File Offset: 0x0004B304
		public override void ApplyToNPC(NPC npc)
		{
			npc.Avatar.Eyes.SetPupilDilation(0.1f, false);
			npc.Avatar.EmotionManager.AddEmotionOverride("Scared", "Schizophrenic", 0f, this.Tier);
			npc.PlayVO(EVOLineType.Concerned);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0004D154 File Offset: 0x0004B354
		public override void ApplyToPlayer(Player player)
		{
			player.Avatar.Eyes.SetPupilDilation(0.1f, false);
			player.Avatar.EmotionManager.AddEmotionOverride("Scared", "Schizophrenic", 0f, this.Tier);
			player.Schizophrenic = true;
			if (player.IsLocalPlayer)
			{
				Singleton<MusicPlayer>.Instance.SetMusicDistorted(true, 5f);
				Singleton<MusicPlayer>.Instance.SetTrackEnabled("Schizo music", true);
				Singleton<AudioManager>.Instance.SetDistorted(true, 5f);
				Singleton<PostProcessingManager>.Instance.SaturationController.AddOverride(110f, 7, "Schizophrenic");
				Singleton<EyelidOverlay>.Instance.OpenMultiplier.AddOverride(0.7f, 6, "sedating");
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0004D20F File Offset: 0x0004B40F
		public override void ClearFromNPC(NPC npc)
		{
			npc.Avatar.Eyes.ResetPupilDilation();
			npc.Avatar.EmotionManager.RemoveEmotionOverride("Schizophrenic");
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0004D238 File Offset: 0x0004B438
		public override void ClearFromPlayer(Player player)
		{
			player.Avatar.Eyes.ResetPupilDilation();
			player.Avatar.EmotionManager.RemoveEmotionOverride("Schizophrenic");
			player.Schizophrenic = false;
			if (player.IsLocalPlayer)
			{
				Singleton<MusicPlayer>.Instance.SetMusicDistorted(false, 5f);
				Singleton<MusicPlayer>.Instance.SetTrackEnabled("Schizo music", false);
				Singleton<AudioManager>.Instance.SetDistorted(false, 5f);
				Singleton<PostProcessingManager>.Instance.SaturationController.RemoveOverride("Schizophrenic");
				Singleton<EyelidOverlay>.Instance.OpenMultiplier.RemoveOverride("sedating");
			}
		}
	}
}
