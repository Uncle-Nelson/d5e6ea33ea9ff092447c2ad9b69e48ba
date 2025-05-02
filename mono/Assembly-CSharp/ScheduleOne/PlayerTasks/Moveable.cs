using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200033D RID: 829
	public class Moveable : Clickable
	{
		// Token: 0x06001292 RID: 4754 RVA: 0x00051284 File Offset: 0x0004F484
		public override void StartClick(RaycastHit hit)
		{
			base.StartClick(hit);
			this.clickDist = Vector3.Distance(base.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position);
			this.clickOffset = base.transform.position - PlayerSingleton<PlayerCamera>.Instance.Camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, this.clickDist));
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00051304 File Offset: 0x0004F504
		protected virtual void Update()
		{
			if (base.IsHeld)
			{
				base.transform.position = Vector3.Lerp(base.transform.position, PlayerSingleton<PlayerCamera>.Instance.Camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, this.clickDist)) + this.clickOffset, Time.deltaTime * 10f);
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, Mathf.Clamp(base.transform.localPosition.y, this.yMin, this.yMax), base.transform.localPosition.z);
			}
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x000513CC File Offset: 0x0004F5CC
		public override void EndClick()
		{
			base.EndClick();
		}

		// Token: 0x040011EC RID: 4588
		protected Vector3 clickOffset = Vector3.zero;

		// Token: 0x040011ED RID: 4589
		protected float clickDist;

		// Token: 0x040011EE RID: 4590
		[Header("Bounds")]
		[SerializeField]
		protected float yMax = 10f;

		// Token: 0x040011EF RID: 4591
		[SerializeField]
		protected float yMin = -10f;
	}
}
