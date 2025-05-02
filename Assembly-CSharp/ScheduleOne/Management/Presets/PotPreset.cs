using System;
using ScheduleOne.Management.Presets.Options;
using UnityEngine;

namespace ScheduleOne.Management.Presets
{
	// Token: 0x02000599 RID: 1433
	public class PotPreset : Preset
	{
		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x000912F8 File Offset: 0x0008F4F8
		// (set) Token: 0x06002399 RID: 9113 RVA: 0x000912FF File Offset: 0x0008F4FF
		protected static PotPreset DefaultPreset { get; set; }

		// Token: 0x0600239A RID: 9114 RVA: 0x00091308 File Offset: 0x0008F508
		public override Preset GetCopy()
		{
			PotPreset potPreset = new PotPreset();
			this.CopyTo(potPreset);
			return potPreset;
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00091324 File Offset: 0x0008F524
		public override void CopyTo(Preset other)
		{
			base.CopyTo(other);
			if (other is PotPreset)
			{
				PotPreset potPreset = other as PotPreset;
				this.Seeds.CopyTo(potPreset.Seeds);
				this.Additives.CopyTo(potPreset.Additives);
			}
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x0009136C File Offset: 0x0008F56C
		public override void InitializeOptions()
		{
			this.Seeds = new ItemList("Seed Types", ManagementUtilities.WeedSeedAssetPaths, true, true);
			this.Seeds.All = true;
			this.Additives = new ItemList("Additives", ManagementUtilities.AdditiveAssetPaths, true, true);
			this.Seeds.None = true;
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x000913C0 File Offset: 0x0008F5C0
		public static PotPreset GetDefaultPreset()
		{
			if (PotPreset.DefaultPreset == null)
			{
				PotPreset.DefaultPreset = new PotPreset
				{
					PresetName = "Default",
					ObjectType = ManageableObjectType.Pot,
					PresetColor = new Color32(180, 180, 180, byte.MaxValue)
				};
			}
			return PotPreset.DefaultPreset;
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x00091414 File Offset: 0x0008F614
		public static PotPreset GetNewBlankPreset()
		{
			PotPreset potPreset = PotPreset.GetDefaultPreset().GetCopy() as PotPreset;
			potPreset.PresetName = "New Preset";
			return potPreset;
		}

		// Token: 0x04001A95 RID: 6805
		public ItemList Seeds;

		// Token: 0x04001A96 RID: 6806
		public ItemList Additives;
	}
}
