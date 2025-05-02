using System;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000957 RID: 2391
	[CreateAssetMenu(fileName = "StorableItemDefinition", menuName = "ScriptableObjects/QualityItemDefinition", order = 1)]
	[Serializable]
	public class QualityItemDefinition : StorableItemDefinition
	{
		// Token: 0x060040CA RID: 16586 RVA: 0x00110054 File Offset: 0x0010E254
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return new QualityItemInstance(this, quantity, this.DefaultQuality);
		}

		// Token: 0x04002E66 RID: 11878
		[Header("Quality")]
		public EQuality DefaultQuality = EQuality.Standard;
	}
}
