using System;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008C9 RID: 2249
	public abstract class ItemModule : MonoBehaviour
	{
		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06003D19 RID: 15641 RVA: 0x00100C2E File Offset: 0x000FEE2E
		// (set) Token: 0x06003D1A RID: 15642 RVA: 0x00100C36 File Offset: 0x000FEE36
		public StationItem Item { get; protected set; }

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06003D1B RID: 15643 RVA: 0x00100C3F File Offset: 0x000FEE3F
		// (set) Token: 0x06003D1C RID: 15644 RVA: 0x00100C47 File Offset: 0x000FEE47
		public bool IsModuleActive { get; protected set; }

		// Token: 0x06003D1D RID: 15645 RVA: 0x00100C50 File Offset: 0x000FEE50
		public virtual void ActivateModule(StationItem item)
		{
			this.IsModuleActive = true;
			this.Item = item;
		}
	}
}
