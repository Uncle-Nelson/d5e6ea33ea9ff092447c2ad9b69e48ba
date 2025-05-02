using System;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000958 RID: 2392
	[Serializable]
	public class QualityItemInstance : StorableItemInstance
	{
		// Token: 0x060040CC RID: 16588 RVA: 0x00110072 File Offset: 0x0010E272
		public QualityItemInstance()
		{
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x00110081 File Offset: 0x0010E281
		public QualityItemInstance(ItemDefinition definition, int quantity, EQuality quality) : base(definition, quantity)
		{
			this.definition = definition;
			this.Quantity = quantity;
			this.ID = definition.ID;
			this.Quality = quality;
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x001100B4 File Offset: 0x0010E2B4
		public override bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			QualityItemInstance qualityItemInstance = other as QualityItemInstance;
			return qualityItemInstance != null && qualityItemInstance.Quality == this.Quality && base.CanStackWith(other, checkQuantities);
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x001100E4 File Offset: 0x0010E2E4
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			int quantity = this.Quantity;
			if (overrideQuantity != -1)
			{
				quantity = overrideQuantity;
			}
			return new QualityItemInstance(base.Definition, quantity, this.Quality);
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x00110110 File Offset: 0x0010E310
		public override ItemData GetItemData()
		{
			return new QualityItemData(this.ID, this.Quantity, this.Quality.ToString());
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x00110134 File Offset: 0x0010E334
		public void SetQuality(EQuality quality)
		{
			this.Quality = quality;
			if (this.onDataChanged != null)
			{
				this.onDataChanged();
			}
		}

		// Token: 0x04002E67 RID: 11879
		public EQuality Quality = EQuality.Standard;
	}
}
