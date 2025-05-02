using System;
using System.Collections.Generic;
using ScheduleOne.Economy;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.NPCs.Relation
{
	// Token: 0x0200048F RID: 1167
	[Serializable]
	public class NPCRelationData
	{
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x00070161 File Offset: 0x0006E361
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x00070169 File Offset: 0x0006E369
		public float RelationDelta { get; protected set; } = 2f;

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x00070172 File Offset: 0x0006E372
		public float NormalizedRelationDelta
		{
			get
			{
				return this.RelationDelta / 5f;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x00070180 File Offset: 0x0006E380
		// (set) Token: 0x060019D6 RID: 6614 RVA: 0x00070188 File Offset: 0x0006E388
		public bool Unlocked { get; protected set; }

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x00070191 File Offset: 0x0006E391
		// (set) Token: 0x060019D8 RID: 6616 RVA: 0x00070199 File Offset: 0x0006E399
		public NPCRelationData.EUnlockType UnlockType { get; protected set; }

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x000701A2 File Offset: 0x0006E3A2
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x000701AA File Offset: 0x0006E3AA
		public NPC NPC { get; protected set; }

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x000701B3 File Offset: 0x0006E3B3
		public List<NPC> Connections
		{
			get
			{
				return this.FullGameConnections;
			}
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x000701BB File Offset: 0x0006E3BB
		public void SetNPC(NPC npc)
		{
			this.NPC = npc;
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x000701C4 File Offset: 0x0006E3C4
		public void Init(NPC npc)
		{
			this.SetNPC(npc);
			for (int i = 0; i < this.Connections.Count; i++)
			{
				if (this.Connections[i] == null)
				{
					this.Connections.RemoveAt(i);
					i--;
				}
				else if (!this.Connections[i].RelationData.Connections.Contains(this.NPC))
				{
					this.Connections[i].RelationData.Connections.Add(this.NPC);
				}
			}
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00070258 File Offset: 0x0006E458
		public virtual void ChangeRelationship(float deltaChange, bool network = true)
		{
			float relationDelta = this.RelationDelta;
			this.RelationDelta = Mathf.Clamp(this.RelationDelta + deltaChange, 0f, 5f);
			if (this.RelationDelta - relationDelta != 0f && this.onRelationshipChange != null)
			{
				this.onRelationshipChange(this.RelationDelta - relationDelta);
			}
			if (network)
			{
				this.NPC.SendRelationship(this.RelationDelta);
			}
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x000702C8 File Offset: 0x0006E4C8
		public virtual void SetRelationship(float newDelta)
		{
			float relationDelta = this.RelationDelta;
			this.RelationDelta = Mathf.Clamp(newDelta, 0f, 5f);
			float relationDelta2 = this.RelationDelta;
			if (this.RelationDelta - relationDelta != 0f && this.onRelationshipChange != null)
			{
				this.onRelationshipChange(this.RelationDelta - relationDelta);
			}
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x00070329 File Offset: 0x0006E529
		public virtual void Unlock(NPCRelationData.EUnlockType type, bool notify = true)
		{
			if (this.Unlocked)
			{
				return;
			}
			this.Unlocked = true;
			this.UnlockType = type;
			if (this.onUnlocked != null)
			{
				this.onUnlocked(type, notify);
			}
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00070358 File Offset: 0x0006E558
		public virtual void UnlockConnections()
		{
			for (int i = 0; i < this.Connections.Count; i++)
			{
				if (!this.Connections[i].RelationData.Unlocked)
				{
					this.Connections[i].RelationData.Unlock(NPCRelationData.EUnlockType.Recommendation, true);
				}
			}
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x000703AB File Offset: 0x0006E5AB
		public RelationshipData GetSaveData()
		{
			return new RelationshipData(this.RelationDelta, this.Unlocked, this.UnlockType);
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x000703C4 File Offset: 0x0006E5C4
		public float GetAverageMutualRelationship()
		{
			float num = 0f;
			int num2 = 0;
			for (int i = 0; i < this.Connections.Count; i++)
			{
				if (this.Connections[i].RelationData.Unlocked)
				{
					num2++;
					num += this.Connections[i].RelationData.RelationDelta;
				}
			}
			if (num2 == 0)
			{
				return 0f;
			}
			return num / (float)num2;
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x00070431 File Offset: 0x0006E631
		public bool IsKnown()
		{
			return this.Unlocked || this.IsMutuallyKnown();
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00070444 File Offset: 0x0006E644
		public bool IsMutuallyKnown()
		{
			for (int i = 0; i < this.Connections.Count; i++)
			{
				if (!(this.Connections[i] == null) && this.Connections[i].RelationData.Unlocked)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00070498 File Offset: 0x0006E698
		public List<NPC> GetLockedConnections(bool excludeCustomers = false)
		{
			return this.Connections.FindAll((NPC x) => !x.RelationData.Unlocked && (!excludeCustomers || x.GetComponent<Customer>() == null));
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x000704CC File Offset: 0x0006E6CC
		public List<NPC> GetLockedDealers(bool excludeRecommended)
		{
			return this.Connections.FindAll((NPC x) => !x.RelationData.Unlocked && x is Dealer && (!excludeRecommended || !(x as Dealer).HasBeenRecommended));
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x000704FD File Offset: 0x0006E6FD
		public List<NPC> GetLockedSuppliers()
		{
			return this.Connections.FindAll((NPC x) => !x.RelationData.Unlocked && x is Supplier);
		}

		// Token: 0x04001640 RID: 5696
		public const float MinDelta = 0f;

		// Token: 0x04001641 RID: 5697
		public const float MaxDelta = 5f;

		// Token: 0x04001642 RID: 5698
		public const float DEFAULT_RELATION_DELTA = 2f;

		// Token: 0x04001647 RID: 5703
		[SerializeField]
		protected List<NPC> FullGameConnections = new List<NPC>();

		// Token: 0x04001648 RID: 5704
		[SerializeField]
		protected List<NPC> DemoConnections = new List<NPC>();

		// Token: 0x04001649 RID: 5705
		public Action<float> onRelationshipChange;

		// Token: 0x0400164A RID: 5706
		public Action<NPCRelationData.EUnlockType, bool> onUnlocked;

		// Token: 0x02000490 RID: 1168
		public enum EUnlockType
		{
			// Token: 0x0400164C RID: 5708
			Recommendation,
			// Token: 0x0400164D RID: 5709
			DirectApproach
		}
	}
}
