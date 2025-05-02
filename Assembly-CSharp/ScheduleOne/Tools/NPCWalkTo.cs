using System;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000867 RID: 2151
	[RequireComponent(typeof(NPCMovement))]
	public class NPCWalkTo : MonoBehaviour
	{
		// Token: 0x06003AA8 RID: 15016 RVA: 0x000F71C8 File Offset: 0x000F53C8
		private void Update()
		{
			this.timeSinceLastPath += Time.deltaTime;
			if (this.timeSinceLastPath >= this.RepathRate)
			{
				this.timeSinceLastPath = 0f;
				base.GetComponent<NPCMovement>().SetDestination(this.Target.position);
			}
		}

		// Token: 0x04002A35 RID: 10805
		public Transform Target;

		// Token: 0x04002A36 RID: 10806
		public float RepathRate = 0.5f;

		// Token: 0x04002A37 RID: 10807
		private float timeSinceLastPath;
	}
}
