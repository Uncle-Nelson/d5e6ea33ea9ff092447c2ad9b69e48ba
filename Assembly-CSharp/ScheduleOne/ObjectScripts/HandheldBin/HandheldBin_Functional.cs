using System;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.HandheldBin
{
	// Token: 0x02000BFC RID: 3068
	public class HandheldBin_Functional : MonoBehaviour
	{
		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06005664 RID: 22116 RVA: 0x0016B786 File Offset: 0x00169986
		// (set) Token: 0x06005665 RID: 22117 RVA: 0x0016B78E File Offset: 0x0016998E
		public float fillLevel { get; protected set; }

		// Token: 0x06005666 RID: 22118 RVA: 0x0016B797 File Offset: 0x00169997
		protected virtual void Awake()
		{
			this.UpdateTrashVisuals();
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x0016B797 File Offset: 0x00169997
		public void SetAmount(float amount)
		{
			this.UpdateTrashVisuals();
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x0016B79F File Offset: 0x0016999F
		protected virtual void UpdateTrashVisuals()
		{
			this.trash.gameObject.SetActive(this.fillLevel > 0f);
		}

		// Token: 0x04003FC5 RID: 16325
		[Header("References")]
		public Transform trash;

		// Token: 0x04003FC6 RID: 16326
		[Header("Settings")]
		public float trash_MinY;

		// Token: 0x04003FC7 RID: 16327
		public float trash_MaxY;
	}
}
