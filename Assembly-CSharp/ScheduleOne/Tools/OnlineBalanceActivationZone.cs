using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000868 RID: 2152
	public class OnlineBalanceActivationZone : MonoBehaviour
	{
		// Token: 0x06003AAA RID: 15018 RVA: 0x000F7229 File Offset: 0x000F5429
		private void Awake()
		{
			this.collider = base.GetComponent<Collider>();
			base.InvokeRepeating("UpdateCollider", 0f, 1f);
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x000F724C File Offset: 0x000F544C
		private void UpdateCollider()
		{
			float num;
			Player.GetClosestPlayer(base.transform.position, out num, null);
			this.collider.enabled = (num < 20f);
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x000F7280 File Offset: 0x000F5480
		private void OnTriggerStay(Collider other)
		{
			if (this.exclude.Contains(other))
			{
				return;
			}
			Player componentInParent = other.GetComponentInParent<Player>();
			if (componentInParent != null && componentInParent.IsOwner)
			{
				Singleton<HUD>.Instance.OnlineBalanceDisplay.Show();
				return;
			}
			this.exclude.Add(other);
		}

		// Token: 0x04002A38 RID: 10808
		public const float ActivationDistance = 20f;

		// Token: 0x04002A39 RID: 10809
		private List<Collider> exclude = new List<Collider>();

		// Token: 0x04002A3A RID: 10810
		private Collider collider;
	}
}
