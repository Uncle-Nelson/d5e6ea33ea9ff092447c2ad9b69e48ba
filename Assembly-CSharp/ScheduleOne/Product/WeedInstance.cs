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
	// Token: 0x02000910 RID: 2320
	[Serializable]
	public class WeedInstance : ProductItemInstance
	{
		// Token: 0x06003ED4 RID: 16084 RVA: 0x00101E73 File Offset: 0x00100073
		public WeedInstance()
		{
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x00101E7B File Offset: 0x0010007B
		public WeedInstance(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition packaging = null) : base(definition, quantity, quality, packaging)
		{
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x00109160 File Offset: 0x00107360
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			int quantity = this.Quantity;
			if (overrideQuantity != -1)
			{
				quantity = overrideQuantity;
			}
			return new WeedInstance(base.Definition, quantity, this.Quality, base.AppliedPackaging);
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x00109194 File Offset: 0x00107394
		public override void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
			base.SetupPackagingVisuals(visuals);
			if (visuals == null)
			{
				Console.LogError("WeedInstance: visuals is null!", null);
				return;
			}
			WeedDefinition weedDefinition = base.Definition as WeedDefinition;
			if (weedDefinition == null)
			{
				string str = "WeedInstance: definition is null! Type: ";
				ItemDefinition definition = base.Definition;
				Console.LogError(str + ((definition != null) ? definition.ToString() : null), null);
				return;
			}
			foreach (FilledPackagingVisuals.MeshIndexPair meshIndexPair in visuals.weedVisuals.MainMeshes)
			{
				Material[] materials = meshIndexPair.Mesh.materials;
				materials[meshIndexPair.MaterialIndex] = weedDefinition.MainMat;
				meshIndexPair.Mesh.materials = materials;
			}
			foreach (FilledPackagingVisuals.MeshIndexPair meshIndexPair2 in visuals.weedVisuals.SecondaryMeshes)
			{
				Material[] materials2 = meshIndexPair2.Mesh.materials;
				materials2[meshIndexPair2.MaterialIndex] = weedDefinition.SecondaryMat;
				meshIndexPair2.Mesh.materials = materials2;
			}
			foreach (FilledPackagingVisuals.MeshIndexPair meshIndexPair3 in visuals.weedVisuals.LeafMeshes)
			{
				Material[] materials3 = meshIndexPair3.Mesh.materials;
				materials3[meshIndexPair3.MaterialIndex] = weedDefinition.LeafMat;
				meshIndexPair3.Mesh.materials = materials3;
			}
			foreach (FilledPackagingVisuals.MeshIndexPair meshIndexPair4 in visuals.weedVisuals.StemMeshes)
			{
				Material[] materials4 = meshIndexPair4.Mesh.materials;
				materials4[meshIndexPair4.MaterialIndex] = weedDefinition.StemMat;
				meshIndexPair4.Mesh.materials = materials4;
			}
			visuals.weedVisuals.Container.gameObject.SetActive(true);
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x00109333 File Offset: 0x00107533
		public override ItemData GetItemData()
		{
			return new WeedData(base.Definition.ID, this.Quantity, this.Quality.ToString(), this.PackagingID);
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x00109364 File Offset: 0x00107564
		public override void ApplyEffectsToNPC(NPC npc)
		{
			npc.Avatar.Eyes.OverrideEyeballTint(new Color32(byte.MaxValue, 170, 170, byte.MaxValue));
			npc.Avatar.Eyes.OverrideEyeLids(new Eye.EyeLidConfiguration
			{
				bottomLidOpen = 0.3f,
				topLidOpen = 0.3f
			});
			npc.Avatar.Eyes.ForceBlink();
			base.ApplyEffectsToNPC(npc);
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x001093E7 File Offset: 0x001075E7
		public override void ClearEffectsFromNPC(NPC npc)
		{
			npc.Avatar.Eyes.ResetEyeballTint();
			npc.Avatar.Eyes.ResetEyeLids();
			npc.Avatar.Eyes.ForceBlink();
			base.ClearEffectsFromNPC(npc);
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x00109420 File Offset: 0x00107620
		public override void ApplyEffectsToPlayer(Player player)
		{
			player.Avatar.Eyes.OverrideEyeballTint(new Color32(byte.MaxValue, 170, 170, byte.MaxValue));
			player.Avatar.Eyes.OverrideEyeLids(new Eye.EyeLidConfiguration
			{
				bottomLidOpen = 0.3f,
				topLidOpen = 0.3f
			});
			if (player.IsOwner)
			{
				Singleton<PostProcessingManager>.Instance.ChromaticAberrationController.AddOverride(0.2f, 5, "weed");
				Singleton<PostProcessingManager>.Instance.SaturationController.AddOverride(70f, 5, "weed");
				Singleton<PostProcessingManager>.Instance.BloomController.AddOverride(3f, 5, "weed");
				Singleton<MusicPlayer>.Instance.SetMusicDistorted(true, 5f);
				Singleton<AudioManager>.Instance.SetDistorted(true, 5f);
			}
			base.ApplyEffectsToPlayer(player);
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x0010950C File Offset: 0x0010770C
		public override void ClearEffectsFromPlayer(Player Player)
		{
			Player.Avatar.Eyes.ResetEyeballTint();
			Player.Avatar.Eyes.ResetEyeLids();
			Player.Avatar.Eyes.ForceBlink();
			if (Player.IsOwner)
			{
				Singleton<PostProcessingManager>.Instance.ChromaticAberrationController.RemoveOverride("weed");
				Singleton<PostProcessingManager>.Instance.SaturationController.RemoveOverride("weed");
				Singleton<PostProcessingManager>.Instance.BloomController.RemoveOverride("weed");
				Singleton<MusicPlayer>.Instance.SetMusicDistorted(false, 5f);
				Singleton<AudioManager>.Instance.SetDistorted(false, 5f);
			}
			base.ClearEffectsFromPlayer(Player);
		}
	}
}
