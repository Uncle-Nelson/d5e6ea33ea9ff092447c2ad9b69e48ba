using System;
using UnityEngine;

namespace ScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x02000731 RID: 1841
	public class ConstructStop_Base : MonoBehaviour
	{
		// Token: 0x060031D0 RID: 12752 RVA: 0x000CE267 File Offset: 0x000CC467
		public virtual void StopConstruction()
		{
			base.GetComponent<ConstructUpdate_Base>().ConstructionStop();
			Object.Destroy(base.gameObject);
		}
	}
}
