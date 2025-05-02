using System;
using System.Collections.Generic;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200051F RID: 1311
	public class PatrolGroup
	{
		// Token: 0x06001F59 RID: 8025 RVA: 0x0008058D File Offset: 0x0007E78D
		public PatrolGroup(FootPatrolRoute route)
		{
			this.Route = route;
			this.CurrentWaypoint = route.StartWaypointIndex;
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x000805B4 File Offset: 0x0007E7B4
		public Vector3 GetDestination(NPC member)
		{
			if (!this.Members.Contains(member))
			{
				Console.LogWarning(member.name + " is not a member of this patrol group!", null);
				return member.transform.position;
			}
			return this.Route.Waypoints[this.CurrentWaypoint].TransformPoint(this.GetMemberOffset(member));
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00080610 File Offset: 0x0007E810
		public void DisbandGroup()
		{
			foreach (NPC npc in new List<NPC>(this.Members))
			{
				(npc as PoliceOfficer).FootPatrolBehaviour.Disable_Networked(null);
				(npc as PoliceOfficer).FootPatrolBehaviour.End_Networked(null);
			}
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00080684 File Offset: 0x0007E884
		public void AdvanceGroup()
		{
			this.CurrentWaypoint++;
			if (this.CurrentWaypoint == this.Route.Waypoints.Length)
			{
				this.CurrentWaypoint = 0;
			}
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x000806B0 File Offset: 0x0007E8B0
		private Vector3 GetMemberOffset(NPC member)
		{
			if (!this.Members.Contains(member))
			{
				Console.LogWarning(member.name + " is not a member of this patrol group!", null);
				return Vector3.zero;
			}
			int num = this.Members.IndexOf(member);
			Vector3 zero = Vector3.zero;
			zero.z -= (float)num * 1f;
			zero.x += ((num % 2 == 0) ? 0.6f : -0.6f);
			return zero;
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x0008072C File Offset: 0x0007E92C
		public bool IsGroupReadyToAdvance()
		{
			for (int i = 0; i < this.Members.Count; i++)
			{
				if (!(this.Members[i] as PoliceOfficer).FootPatrolBehaviour.IsReadyToAdvance())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x00080770 File Offset: 0x0007E970
		public bool IsPaused()
		{
			for (int i = 0; i < this.Members.Count; i++)
			{
				if (this.Members[i].behaviour.activeBehaviour == null || this.Members[i].behaviour.activeBehaviour.GetType() != typeof(FootPatrolBehaviour))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0400187B RID: 6267
		public List<NPC> Members = new List<NPC>();

		// Token: 0x0400187C RID: 6268
		public FootPatrolRoute Route;

		// Token: 0x0400187D RID: 6269
		public int CurrentWaypoint;
	}
}
