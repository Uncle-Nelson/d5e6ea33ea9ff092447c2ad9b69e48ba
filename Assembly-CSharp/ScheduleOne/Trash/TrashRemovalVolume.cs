using System;
using System.Collections.Generic;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Trash
{
	// Token: 0x0200083A RID: 2106
	[RequireComponent(typeof(BoxCollider))]
	public class TrashRemovalVolume : MonoBehaviour
	{
		// Token: 0x06003A00 RID: 14848 RVA: 0x000F55DD File Offset: 0x000F37DD
		public void Awake()
		{
			NetworkSingleton<TimeManager>.Instance._onSleepStart.AddListener(new UnityAction(this.SleepStart));
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x000F55FA File Offset: 0x000F37FA
		private void OnDestroy()
		{
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				NetworkSingleton<TimeManager>.Instance._onSleepStart.RemoveListener(new UnityAction(this.SleepStart));
			}
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x000F5620 File Offset: 0x000F3820
		private void SleepStart()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (Random.value > this.RemovalChance)
			{
				return;
			}
			TrashItem[] trash = this.GetTrash();
			for (int i = 0; i < trash.Length; i++)
			{
				trash[i].DestroyTrash();
			}
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x000F5660 File Offset: 0x000F3860
		private TrashItem[] GetTrash()
		{
			List<TrashItem> list = new List<TrashItem>();
			Vector3 vector = this.Collider.transform.TransformPoint(this.Collider.center);
			Vector3 vector2 = Vector3.Scale(this.Collider.size, this.Collider.transform.lossyScale) * 0.5f;
			Collider[] array = Physics.OverlapBox(vector, vector2, this.Collider.transform.rotation, 1 << LayerMask.NameToLayer("Trash"), 2);
			for (int i = 0; i < array.Length; i++)
			{
				TrashItem componentInParent = array[i].GetComponentInParent<TrashItem>();
				if (componentInParent != null)
				{
					list.Add(componentInParent);
				}
			}
			return list.ToArray();
		}

		// Token: 0x040029B8 RID: 10680
		public BoxCollider Collider;

		// Token: 0x040029B9 RID: 10681
		public float RemovalChance = 1f;
	}
}
