using System;
using ScheduleOne.Packaging;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BBB RID: 3003
	public class BrickPressContainer : MonoBehaviour
	{
		// Token: 0x06005162 RID: 20834 RVA: 0x00156D70 File Offset: 0x00154F70
		public void SetContents(ProductItemInstance product, float fillLevel)
		{
			fillLevel = Mathf.Clamp01(fillLevel);
			if (product == null || fillLevel == 0f)
			{
				this.ContentsContainer.gameObject.SetActive(false);
				return;
			}
			product.SetupPackagingVisuals(this.Visuals);
			this.ContentsContainer.localPosition = Vector3.Lerp(this.Contents_Min.localPosition, this.Contents_Max.localPosition, fillLevel);
			this.ContentsContainer.gameObject.SetActive(true);
		}

		// Token: 0x04003D0B RID: 15627
		public FilledPackagingVisuals Visuals;

		// Token: 0x04003D0C RID: 15628
		public Transform ContentsContainer;

		// Token: 0x04003D0D RID: 15629
		public Transform Contents_Min;

		// Token: 0x04003D0E RID: 15630
		public Transform Contents_Max;
	}
}
