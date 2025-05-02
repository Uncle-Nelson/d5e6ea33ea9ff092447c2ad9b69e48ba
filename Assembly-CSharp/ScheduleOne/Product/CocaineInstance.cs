using System;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.Packaging;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product.Packaging;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008DE RID: 2270
	[Serializable]
	public class CocaineInstance : ProductItemInstance
	{
		// Token: 0x06003D74 RID: 15732 RVA: 0x00101E73 File Offset: 0x00100073
		public CocaineInstance()
		{
		}

		// Token: 0x06003D75 RID: 15733 RVA: 0x00101E7B File Offset: 0x0010007B
		public CocaineInstance(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition packaging = null) : base(definition, quantity, quality, packaging)
		{
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x00101E88 File Offset: 0x00100088
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			int quantity = this.Quantity;
			if (overrideQuantity != -1)
			{
				quantity = overrideQuantity;
			}
			return new CocaineInstance(base.Definition, quantity, this.Quality, base.AppliedPackaging);
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x00101EBC File Offset: 0x001000BC
		public override void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
			base.SetupPackagingVisuals(visuals);
			if (visuals == null)
			{
				Console.LogError("CocaineInstance: visuals is null!", null);
				return;
			}
			CocaineDefinition cocaineDefinition = base.Definition as CocaineDefinition;
			if (cocaineDefinition == null)
			{
				string str = "CocaineInstance: definition is null! Type: ";
				ItemDefinition definition = base.Definition;
				Console.LogError(str + ((definition != null) ? definition.ToString() : null), null);
				return;
			}
			MeshRenderer[] rockMeshes = visuals.cocaineVisuals.RockMeshes;
			for (int i = 0; i < rockMeshes.Length; i++)
			{
				rockMeshes[i].material = cocaineDefinition.RockMaterial;
			}
			visuals.cocaineVisuals.Container.gameObject.SetActive(true);
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x00101F5B File Offset: 0x0010015B
		public override ItemData GetItemData()
		{
			return new CocaineData(base.Definition.ID, this.Quantity, this.Quality.ToString(), this.PackagingID);
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x00101F8C File Offset: 0x0010018C
		public override void ApplyEffectsToNPC(NPC npc)
		{
			npc.Avatar.EmotionManager.AddEmotionOverride("Cocaine", this.Name, 0f, 0);
			npc.Avatar.Eyes.OverrideEyeballTint(new Color32(200, 240, byte.MaxValue, byte.MaxValue));
			npc.Avatar.Eyes.SetPupilDilation(1f, false);
			npc.Avatar.Eyes.ForceBlink();
			npc.Movement.MoveSpeedMultiplier = 1.25f;
			npc.Avatar.LookController.LookLerpSpeed = 10f;
			base.ApplyEffectsToNPC(npc);
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x0010203C File Offset: 0x0010023C
		public override void ClearEffectsFromNPC(NPC npc)
		{
			npc.Avatar.EmotionManager.RemoveEmotionOverride(this.Name);
			npc.Avatar.Eyes.ResetEyeballTint();
			npc.Avatar.Eyes.ResetEyeLids();
			npc.Avatar.Eyes.ResetPupilDilation();
			npc.Avatar.Eyes.ForceBlink();
			npc.Movement.MoveSpeedMultiplier = 1f;
			npc.Avatar.LookController.LookLerpSpeed = 3f;
			base.ClearEffectsFromNPC(npc);
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x001020CC File Offset: 0x001002CC
		public override void ApplyEffectsToPlayer(Player player)
		{
			player.Avatar.EmotionManager.AddEmotionOverride("Cocaine", this.Name, 0f, 0);
			player.Avatar.Eyes.OverrideEyeballTint(new Color32(200, 240, byte.MaxValue, byte.MaxValue));
			player.Avatar.Eyes.SetPupilDilation(1f, false);
			player.Avatar.Eyes.ForceBlink();
			player.Avatar.LookController.LookLerpSpeed = 10f;
			if (player.IsOwner)
			{
				PlayerSingleton<PlayerCamera>.Instance.CocaineVisuals = true;
				PlayerSingleton<PlayerCamera>.Instance.FoVChangeSmoother.AddOverride(10f, 6, "Cocaine");
				Singleton<MusicPlayer>.Instance.SetMusicDistorted(true, 5f);
				Singleton<AudioManager>.Instance.SetDistorted(true, 5f);
			}
			base.ApplyEffectsToPlayer(player);
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x001021B8 File Offset: 0x001003B8
		public override void ClearEffectsFromPlayer(Player Player)
		{
			Player.Avatar.EmotionManager.RemoveEmotionOverride(this.Name);
			Player.Avatar.Eyes.ResetEyeballTint();
			Player.Avatar.Eyes.ResetEyeLids();
			Player.Avatar.Eyes.ResetPupilDilation();
			Player.Avatar.Eyes.ForceBlink();
			Player.Avatar.LookController.LookLerpSpeed = 3f;
			if (Player.IsOwner)
			{
				PlayerSingleton<PlayerCamera>.Instance.CocaineVisuals = false;
				PlayerSingleton<PlayerCamera>.Instance.FoVChangeSmoother.RemoveOverride("Cocaine");
				Singleton<MusicPlayer>.Instance.SetMusicDistorted(false, 5f);
				Singleton<AudioManager>.Instance.SetDistorted(false, 5f);
			}
			base.ClearEffectsFromPlayer(Player);
		}
	}
}
