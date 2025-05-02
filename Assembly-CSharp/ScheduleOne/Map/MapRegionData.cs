using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.Levelling;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C1A RID: 3098
	[Serializable]
	public class MapRegionData
	{
		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06005707 RID: 22279 RVA: 0x0016DDDB File Offset: 0x0016BFDB
		public bool IsUnlocked
		{
			get
			{
				return NetworkSingleton<LevelManager>.InstanceExists && NetworkSingleton<LevelManager>.Instance.GetFullRank() >= this.RankRequirement;
			}
		}

		// Token: 0x06005708 RID: 22280 RVA: 0x0016DDFC File Offset: 0x0016BFFC
		public DeliveryLocation GetRandomUnscheduledDeliveryLocation()
		{
			List<DeliveryLocation> list = (from x in this.RegionDeliveryLocations
			where x.ScheduledContracts.Count == 0
			select x).ToList<DeliveryLocation>();
			if (list.Count == 0)
			{
				Console.LogWarning("No unscheduled delivery locations found for " + this.Region.ToString(), null);
				return null;
			}
			return list[Random.Range(0, list.Count)];
		}

		// Token: 0x06005709 RID: 22281 RVA: 0x0016DE78 File Offset: 0x0016C078
		public void SetUnlocked()
		{
			foreach (NPC npc in this.StartingNPCs)
			{
				if (!npc.RelationData.Unlocked)
				{
					npc.RelationData.Unlock(NPCRelationData.EUnlockType.DirectApproach, false);
				}
			}
		}

		// Token: 0x0400405D RID: 16477
		public EMapRegion Region;

		// Token: 0x0400405E RID: 16478
		public string Name;

		// Token: 0x0400405F RID: 16479
		public FullRank RankRequirement;

		// Token: 0x04004060 RID: 16480
		public NPC[] StartingNPCs;

		// Token: 0x04004061 RID: 16481
		public Sprite RegionSprite;

		// Token: 0x04004062 RID: 16482
		public DeliveryLocation[] RegionDeliveryLocations;
	}
}
