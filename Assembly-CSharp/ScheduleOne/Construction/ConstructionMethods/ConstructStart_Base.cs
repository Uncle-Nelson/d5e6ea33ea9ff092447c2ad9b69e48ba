using System;
using ScheduleOne.ConstructableScripts;
using UnityEngine;

namespace ScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x0200072E RID: 1838
	public abstract class ConstructStart_Base : MonoBehaviour
	{
		// Token: 0x060031CA RID: 12746 RVA: 0x000CE0EB File Offset: 0x000CC2EB
		public virtual void StartConstruction(string constructableID, Constructable_GridBased movedConstructable = null)
		{
			if (movedConstructable != null)
			{
				base.gameObject.GetComponent<ConstructUpdate_Base>().MovedConstructable = movedConstructable;
				movedConstructable.SetInvisible();
			}
		}
	}
}
