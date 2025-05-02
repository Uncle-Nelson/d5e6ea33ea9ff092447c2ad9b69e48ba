using System;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.Packaging;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product.Packaging;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008E8 RID: 2280
	[Serializable]
	public class MethInstance : ProductItemInstance
	{
		// Token: 0x06003D91 RID: 15761 RVA: 0x00101E73 File Offset: 0x00100073
		public MethInstance()
		{
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x00101E7B File Offset: 0x0010007B
		public MethInstance(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition packaging = null) : base(definition, quantity, quality, packaging)
		{
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x00102594 File Offset: 0x00100794
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			int quantity = this.Quantity;
			if (overrideQuantity != -1)
			{
				quantity = overrideQuantity;
			}
			return new MethInstance(base.Definition, quantity, this.Quality, base.AppliedPackaging);
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x001025C8 File Offset: 0x001007C8
		public override void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
			base.SetupPackagingVisuals(visuals);
			if (visuals == null)
			{
				Console.LogError("MethInstance: visuals is null!", null);
				return;
			}
			MethDefinition methDefinition = base.Definition as MethDefinition;
			if (methDefinition == null)
			{
				string str = "MethInstance: definition is null! Type: ";
				ItemDefinition definition = base.Definition;
				Console.LogError(str + ((definition != null) ? definition.ToString() : null), null);
				return;
			}
			MeshRenderer[] crystalMeshes = visuals.methVisuals.CrystalMeshes;
			for (int i = 0; i < crystalMeshes.Length; i++)
			{
				crystalMeshes[i].material = methDefinition.CrystalMaterial;
			}
			visuals.methVisuals.Container.gameObject.SetActive(true);
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x00102667 File Offset: 0x00100867
		public override ItemData GetItemData()
		{
			return new MethData(base.Definition.ID, this.Quantity, this.Quality.ToString(), this.PackagingID);
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x00102698 File Offset: 0x00100898
		public override void ApplyEffectsToNPC(NPC npc)
		{
			Console.Log("Applying meth effects to NPC: " + npc.fullName, null);
			npc.Avatar.EmotionManager.AddEmotionOverride("Meth", this.Name, 0f, 0);
			npc.Avatar.Eyes.OverrideEyeballTint(new Color32(165, 112, 86, byte.MaxValue));
			npc.Avatar.Eyes.OverrideEyeLids(new Eye.EyeLidConfiguration
			{
				bottomLidOpen = 0.5f,
				topLidOpen = 0.1f
			});
			npc.Avatar.Eyes.SetPupilDilation(0.1f, false);
			npc.Avatar.Eyes.ForceBlink();
			npc.OverrideAggression(1f);
			base.ApplyEffectsToNPC(npc);
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x00102770 File Offset: 0x00100970
		public override void ClearEffectsFromNPC(NPC npc)
		{
			npc.Avatar.EmotionManager.RemoveEmotionOverride(this.Name);
			npc.Avatar.Eyes.ResetEyeballTint();
			npc.Avatar.Eyes.ResetEyeLids();
			npc.Avatar.Eyes.ResetPupilDilation();
			npc.Avatar.Eyes.ForceBlink();
			npc.ResetAggression();
			base.ClearEffectsFromNPC(npc);
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x001027E0 File Offset: 0x001009E0
		public override void ApplyEffectsToPlayer(Player player)
		{
			player.Avatar.EmotionManager.AddEmotionOverride("Meth", this.Name, 0f, 0);
			player.Avatar.Eyes.OverrideEyeballTint(new Color32(165, 112, 86, byte.MaxValue));
			player.Avatar.Eyes.SetPupilDilation(0.1f, false);
			player.Avatar.Eyes.ForceBlink();
			if (player.IsOwner)
			{
				PlayerSingleton<PlayerCamera>.Instance.MethVisuals = true;
				Singleton<PostProcessingManager>.Instance.ColorFilterController.AddOverride((this.definition as MethDefinition).TintColor, 1, "Meth");
				Singleton<MusicPlayer>.Instance.SetMusicDistorted(true, 5f);
				Singleton<AudioManager>.Instance.SetDistorted(true, 5f);
			}
			base.ApplyEffectsToPlayer(player);
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x001028BC File Offset: 0x00100ABC
		public override void ClearEffectsFromPlayer(Player Player)
		{
			Player.Avatar.EmotionManager.RemoveEmotionOverride(this.Name);
			Player.Avatar.Eyes.ResetEyeballTint();
			Player.Avatar.Eyes.ResetEyeLids();
			Player.Avatar.Eyes.ResetPupilDilation();
			Player.Avatar.Eyes.ForceBlink();
			if (Player.IsOwner)
			{
				PlayerSingleton<PlayerCamera>.Instance.MethVisuals = false;
				Singleton<PostProcessingManager>.Instance.ColorFilterController.RemoveOverride("Meth");
				Singleton<MusicPlayer>.Instance.SetMusicDistorted(false, 5f);
				Singleton<AudioManager>.Instance.SetDistorted(false, 5f);
			}
			base.ClearEffectsFromPlayer(Player);
		}
	}
}
