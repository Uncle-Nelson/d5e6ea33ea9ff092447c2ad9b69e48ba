using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x020007A5 RID: 1957
	public class AudioZoneModifierVolume : MonoBehaviour
	{
		// Token: 0x0600353D RID: 13629 RVA: 0x000DFDEE File Offset: 0x000DDFEE
		private void Start()
		{
			base.InvokeRepeating("Refresh", 0f, 0.25f);
			this.colliders = base.GetComponentsInChildren<BoxCollider>();
			LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Invisible"));
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x000DFE28 File Offset: 0x000DE028
		private void Refresh()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			BoxCollider[] array = this.colliders;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].bounds.Contains(PlayerSingleton<PlayerCamera>.Instance.transform.position))
				{
					foreach (AudioZone audioZone in this.Zones)
					{
						audioZone.AddModifier(this, this.VolumeMultiplier);
					}
					return;
				}
			}
			foreach (AudioZone audioZone2 in this.Zones)
			{
				audioZone2.RemoveModifier(this);
			}
		}

		// Token: 0x04002635 RID: 9781
		public List<AudioZone> Zones = new List<AudioZone>();

		// Token: 0x04002636 RID: 9782
		public float VolumeMultiplier = 0.5f;

		// Token: 0x04002637 RID: 9783
		private BoxCollider[] colliders;
	}
}
