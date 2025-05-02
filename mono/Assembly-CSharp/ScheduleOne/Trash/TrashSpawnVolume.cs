using System;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Trash
{
	// Token: 0x0200083B RID: 2107
	public class TrashSpawnVolume : MonoBehaviour
	{
		// Token: 0x06003A05 RID: 14853 RVA: 0x000F5723 File Offset: 0x000F3923
		public void Awake()
		{
			NetworkSingleton<TimeManager>.Instance._onSleepStart.AddListener(new UnityAction(this.SleepStart));
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x000F5740 File Offset: 0x000F3940
		private void OnDestroy()
		{
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				NetworkSingleton<TimeManager>.Instance._onSleepStart.RemoveListener(new UnityAction(this.SleepStart));
			}
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x000F5764 File Offset: 0x000F3964
		public void SleepStart()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (Random.value > this.TrashSpawnChance)
			{
				return;
			}
			Collider[] array = Physics.OverlapBox(this.DetectionVolume.transform.TransformPoint(this.DetectionVolume.center), Vector3.Scale(this.DetectionVolume.size, this.DetectionVolume.transform.lossyScale) * 0.5f, this.DetectionVolume.transform.rotation, 1 << LayerMask.NameToLayer("Trash"), 2);
			int num = 0;
			foreach (Collider collider in array)
			{
				if (num >= this.TrashLimit)
				{
					break;
				}
				if (collider.GetComponentInParent<TrashItem>() != null)
				{
					num++;
				}
			}
			num = Mathf.Max(Random.Range(0, this.TrashLimit - num), 0);
			for (int j = num; j < this.TrashLimit; j++)
			{
				TrashItem randomGeneratableTrashPrefab = NetworkSingleton<TrashManager>.Instance.GetRandomGeneratableTrashPrefab();
				Vector3 posiiton = new Vector3(Random.Range(this.CreatonVolume.bounds.min.x, this.CreatonVolume.bounds.max.x), Random.Range(this.CreatonVolume.bounds.min.y, this.CreatonVolume.bounds.max.y), Random.Range(this.CreatonVolume.bounds.min.z, this.CreatonVolume.bounds.max.z));
				NetworkSingleton<TrashManager>.Instance.CreateTrashItem(randomGeneratableTrashPrefab.ID, posiiton, Random.rotation, default(Vector3), "", false).SetContinuousCollisionDetection();
			}
		}

		// Token: 0x040029BA RID: 10682
		public BoxCollider CreatonVolume;

		// Token: 0x040029BB RID: 10683
		public BoxCollider DetectionVolume;

		// Token: 0x040029BC RID: 10684
		public int TrashLimit = 10;

		// Token: 0x040029BD RID: 10685
		public float TrashSpawnChance = 1f;
	}
}
