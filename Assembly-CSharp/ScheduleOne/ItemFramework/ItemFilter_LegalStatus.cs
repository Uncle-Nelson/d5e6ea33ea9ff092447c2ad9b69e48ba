using System;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000942 RID: 2370
	public class ItemFilter_LegalStatus : ItemFilter
	{
		// Token: 0x06004029 RID: 16425 RVA: 0x0010E373 File Offset: 0x0010C573
		public ItemFilter_LegalStatus(ELegalStatus requiredLegalStatus)
		{
			this.RequiredLegalStatus = requiredLegalStatus;
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x0010E382 File Offset: 0x0010C582
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return instance != null && instance.Definition.legalStatus == this.RequiredLegalStatus && base.DoesItemMatchFilter(instance);
		}

		// Token: 0x04002E19 RID: 11801
		public ELegalStatus RequiredLegalStatus;
	}
}
