using System;
using ScheduleOne.PlayerTasks;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008C6 RID: 2246
	public class IngredientModule : ItemModule
	{
		// Token: 0x06003D07 RID: 15623 RVA: 0x0010093C File Offset: 0x000FEB3C
		public override void ActivateModule(StationItem item)
		{
			base.ActivateModule(item);
			for (int i = 0; i < this.Pieces.Length; i++)
			{
				this.Pieces[i].GetComponent<DraggableConstraint>().SetContainer(item.transform.parent);
			}
		}

		// Token: 0x04002BDC RID: 11228
		public IngredientPiece[] Pieces;
	}
}
