using System;
using ScheduleOne.ConstructableScripts;
using UnityEngine;

namespace ScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x02000732 RID: 1842
	public class ConstructUpdate_Base : MonoBehaviour
	{
		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x000CE27F File Offset: 0x000CC47F
		public bool isMoving
		{
			get
			{
				return this.MovedConstructable != null;
			}
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void Update()
		{
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x000CE28D File Offset: 0x000CC48D
		public virtual void ConstructionStop()
		{
			if (this.MovedConstructable != null)
			{
				this.MovedConstructable.RestoreVisibility();
			}
		}

		// Token: 0x04002371 RID: 9073
		public Constructable_GridBased MovedConstructable;
	}
}
