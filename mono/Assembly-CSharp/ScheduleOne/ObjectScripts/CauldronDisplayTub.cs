using System;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BC3 RID: 3011
	public class CauldronDisplayTub : MonoBehaviour
	{
		// Token: 0x060051FC RID: 20988 RVA: 0x00159858 File Offset: 0x00157A58
		public void Configure(CauldronDisplayTub.EContents contentsType, float fillLevel)
		{
			this.CocaLeafContainer.gameObject.SetActive(false);
			Transform transform = null;
			if (contentsType == CauldronDisplayTub.EContents.CocaLeaf)
			{
				transform = this.CocaLeafContainer;
			}
			if (transform != null)
			{
				transform.transform.localPosition = Vector3.Lerp(this.Container_Min.localPosition, this.Container_Max.localPosition, fillLevel);
				transform.gameObject.SetActive(fillLevel > 0f);
			}
		}

		// Token: 0x04003D60 RID: 15712
		public Transform CocaLeafContainer;

		// Token: 0x04003D61 RID: 15713
		public Transform Container_Min;

		// Token: 0x04003D62 RID: 15714
		public Transform Container_Max;

		// Token: 0x02000BC4 RID: 3012
		public enum EContents
		{
			// Token: 0x04003D64 RID: 15716
			None,
			// Token: 0x04003D65 RID: 15717
			CocaLeaf
		}
	}
}
