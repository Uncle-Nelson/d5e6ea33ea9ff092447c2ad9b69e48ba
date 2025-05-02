using System;
using FishNet;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Networking
{
	// Token: 0x0200053F RID: 1343
	public class NetworkConditionalObject : MonoBehaviour
	{
		// Token: 0x060020C5 RID: 8389 RVA: 0x00086C2C File Offset: 0x00084E2C
		private void Awake()
		{
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(this.Check));
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.Check));
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00086C7C File Offset: 0x00084E7C
		public void Check()
		{
			NetworkConditionalObject.ECondition econdition = this.condition;
			if (econdition != NetworkConditionalObject.ECondition.All && econdition == NetworkConditionalObject.ECondition.HostOnly && !InstanceFinder.IsHost)
			{
				base.gameObject.SetActive(false);
			}
		}

		// Token: 0x0400194F RID: 6479
		public NetworkConditionalObject.ECondition condition;

		// Token: 0x02000540 RID: 1344
		public enum ECondition
		{
			// Token: 0x04001951 RID: 6481
			All,
			// Token: 0x04001952 RID: 6482
			HostOnly
		}
	}
}
