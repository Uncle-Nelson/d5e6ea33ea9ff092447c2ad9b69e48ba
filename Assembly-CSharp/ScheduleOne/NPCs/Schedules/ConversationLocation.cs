using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000471 RID: 1137
	public class ConversationLocation : MonoBehaviour
	{
		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x0006A560 File Offset: 0x00068760
		public bool NPCsReady
		{
			get
			{
				return (from npcReady in this.npcReady
				where npcReady.Value
				select npcReady).Count<KeyValuePair<NPC, bool>>() >= 2;
			}
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0006A598 File Offset: 0x00068798
		public void Awake()
		{
			if (this.StandPoints.Length < this.NPCs.Count)
			{
				Console.LogError("ConversationLocation has less StandPoints than NPCs", null);
			}
			foreach (NPC key in this.NPCs)
			{
				this.npcReady.Add(key, false);
			}
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x0006A614 File Offset: 0x00068814
		public Transform GetStandPoint(NPC npc)
		{
			if (!this.NPCs.Contains(npc))
			{
				Console.LogWarning("NPC is not part of this conversation", null);
				return this.StandPoints[0];
			}
			return this.StandPoints[this.NPCs.IndexOf(npc)];
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x0006A64B File Offset: 0x0006884B
		public void SetNPCReady(NPC npc, bool ready)
		{
			if (!this.NPCs.Contains(npc))
			{
				Console.LogWarning("NPC is not part of this conversation", null);
				return;
			}
			this.npcReady[npc] = ready;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x0006A674 File Offset: 0x00068874
		public NPC GetOtherNPC(NPC npc)
		{
			if (!this.NPCs.Contains(npc))
			{
				Console.LogWarning("NPC is not part of this conversation", null);
				return null;
			}
			return (from otherNPC in this.NPCs
			where otherNPC != npc
			select otherNPC).FirstOrDefault<NPC>();
		}

		// Token: 0x0400159B RID: 5531
		public Transform[] StandPoints;

		// Token: 0x0400159C RID: 5532
		[HideInInspector]
		public List<NPC> NPCs = new List<NPC>();

		// Token: 0x0400159D RID: 5533
		private Dictionary<NPC, bool> npcReady = new Dictionary<NPC, bool>();
	}
}
