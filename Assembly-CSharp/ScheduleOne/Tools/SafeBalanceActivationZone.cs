using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Storage;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000873 RID: 2163
	public class SafeBalanceActivationZone : MonoBehaviour
	{
		// Token: 0x06003ADA RID: 15066 RVA: 0x000F7B26 File Offset: 0x000F5D26
		private void Awake()
		{
			this.colliders = base.GetComponentsInChildren<Collider>();
			base.InvokeRepeating("UpdateCollider", 0f, 1f);
			base.InvokeRepeating("Activate", 0f, 0.25f);
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x000F7B60 File Offset: 0x000F5D60
		private void UpdateCollider()
		{
			float num;
			Player.GetClosestPlayer(base.transform.position, out num, null);
			Collider[] array = this.colliders;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].enabled = (num < 30f);
			}
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x000F7BA6 File Offset: 0x000F5DA6
		private void Activate()
		{
			this.active = true;
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x000F7BB0 File Offset: 0x000F5DB0
		private void OnTriggerStay(Collider other)
		{
			if (!this.active)
			{
				return;
			}
			this.active = true;
			if (this.exclude.Contains(other))
			{
				return;
			}
			Player componentInParent = other.GetComponentInParent<Player>();
			if (componentInParent != null && componentInParent.IsOwner)
			{
				Singleton<HUD>.Instance.SafeBalanceDisplay.SetBalance(this.Safe.GetCash());
				Singleton<HUD>.Instance.SafeBalanceDisplay.Show();
				return;
			}
			this.exclude.Add(other);
		}

		// Token: 0x04002A57 RID: 10839
		public const float ActivationDistance = 30f;

		// Token: 0x04002A58 RID: 10840
		public Safe Safe;

		// Token: 0x04002A59 RID: 10841
		private List<Collider> exclude = new List<Collider>();

		// Token: 0x04002A5A RID: 10842
		private Collider[] colliders;

		// Token: 0x04002A5B RID: 10843
		private bool active;
	}
}
