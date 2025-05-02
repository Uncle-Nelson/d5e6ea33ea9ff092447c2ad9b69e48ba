using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200085D RID: 2141
	public class ForcePlayerCrouch : MonoBehaviour
	{
		// Token: 0x06003A86 RID: 14982 RVA: 0x000F6E24 File Offset: 0x000F5024
		private void OnTriggerStay(Collider other)
		{
			if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
			{
				Player componentInParent = other.gameObject.GetComponentInParent<Player>();
				if (componentInParent != null && componentInParent.IsOwner && !PlayerSingleton<PlayerMovement>.Instance.isCrouched)
				{
					PlayerSingleton<PlayerMovement>.Instance.SetCrouched(true);
				}
			}
		}
	}
}
