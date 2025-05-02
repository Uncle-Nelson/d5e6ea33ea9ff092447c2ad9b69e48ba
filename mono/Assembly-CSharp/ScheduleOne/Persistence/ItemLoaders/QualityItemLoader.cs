using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x02000448 RID: 1096
	public class QualityItemLoader : ItemLoader
	{
		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x00060B03 File Offset: 0x0005ED03
		public override string ItemType
		{
			get
			{
				return typeof(QualityItemData).Name;
			}
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00060B14 File Offset: 0x0005ED14
		public override ItemInstance LoadItem(string itemString)
		{
			QualityItemData qualityItemData = base.LoadData<QualityItemData>(itemString);
			if (qualityItemData == null)
			{
				Console.LogWarning("Failed loading item data from " + itemString, null);
				return null;
			}
			if (qualityItemData.ID == string.Empty)
			{
				return null;
			}
			ItemDefinition item = Registry.GetItem(qualityItemData.ID);
			if (item == null)
			{
				Console.LogWarning("Failed to find item definition for " + qualityItemData.ID, null);
				return null;
			}
			EQuality equality;
			EQuality quality = Enum.TryParse<EQuality>(qualityItemData.Quality, out equality) ? equality : EQuality.Standard;
			return new QualityItemInstance(item, qualityItemData.Quantity, quality);
		}
	}
}
