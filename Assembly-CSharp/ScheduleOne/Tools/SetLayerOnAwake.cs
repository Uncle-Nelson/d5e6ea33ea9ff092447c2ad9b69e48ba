using System;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000874 RID: 2164
	public class SetLayerOnAwake : MonoBehaviour
	{
		// Token: 0x06003ADF RID: 15071 RVA: 0x000F7C3D File Offset: 0x000F5E3D
		private void Awake()
		{
			base.gameObject.layer = this.Layer.value;
		}

		// Token: 0x04002A5C RID: 10844
		public LayerMask Layer;
	}
}
