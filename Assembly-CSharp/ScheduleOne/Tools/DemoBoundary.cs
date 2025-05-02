using System;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000852 RID: 2130
	public class DemoBoundary : MonoBehaviour
	{
		// Token: 0x06003A62 RID: 14946 RVA: 0x000F6A9B File Offset: 0x000F4C9B
		private void OnValidate()
		{
			if (this.Collider == null)
			{
				this.Collider = base.GetComponent<Collider>();
			}
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x000F6AB7 File Offset: 0x000F4CB7
		private void Start()
		{
			base.InvokeRepeating("UpdateBoundary", 0f, 0.25f);
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x000F6AD0 File Offset: 0x000F4CD0
		private void UpdateBoundary()
		{
			if (Player.Local == null)
			{
				return;
			}
			Vector3 vector = this.Collider.transform.InverseTransformPoint(Player.Local.transform.position);
			this.Collider.enabled = (vector.x > 0f);
		}

		// Token: 0x04002A0B RID: 10763
		public Collider Collider;
	}
}
