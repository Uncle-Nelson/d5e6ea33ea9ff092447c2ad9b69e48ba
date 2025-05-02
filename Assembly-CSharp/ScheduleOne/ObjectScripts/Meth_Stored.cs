using System;
using ScheduleOne.Product;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BB4 RID: 2996
	public class Meth_Stored : StoredItem
	{
		// Token: 0x060050DE RID: 20702 RVA: 0x00154C18 File Offset: 0x00152E18
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			base.InitializeStoredItem(_item, grid, _originCoordinate, _rotation);
			MethInstance methInstance = _item as MethInstance;
			if (methInstance != null)
			{
				this.Visuals.Setup(methInstance.Definition as MethDefinition);
			}
		}

		// Token: 0x04003CD5 RID: 15573
		public MethVisuals Visuals;
	}
}
