using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Property.Utilities.Power
{
	// Token: 0x02000827 RID: 2087
	public class PowerNode : MonoBehaviour
	{
		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06003919 RID: 14617 RVA: 0x000F1790 File Offset: 0x000EF990
		public Transform pConnectionPoint
		{
			get
			{
				return this.connectionPoint;
			}
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x000F1798 File Offset: 0x000EF998
		public bool IsConnectedTo(PowerNode node)
		{
			for (int i = 0; i < this.connections.Count; i++)
			{
				if (this.connections[i].nodeA == this)
				{
					if (this.connections[i].nodeB == node)
					{
						return true;
					}
				}
				else if (this.connections[i].nodeA == node)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x000F180C File Offset: 0x000EFA0C
		public void RecalculatePowerNetwork()
		{
			List<PowerNode> connectedNodes = this.GetConnectedNodes(new List<PowerNode>());
			bool flag = false;
			using (List<PowerNode>.Enumerator enumerator = connectedNodes.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.poweredNode)
					{
						flag = true;
					}
				}
			}
			foreach (PowerNode powerNode in connectedNodes)
			{
				if (flag)
				{
					powerNode.isConnectedToPower = true;
				}
				else
				{
					powerNode.isConnectedToPower = false;
				}
			}
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x000F18B4 File Offset: 0x000EFAB4
		public List<PowerNode> GetConnectedNodes(List<PowerNode> exclusions)
		{
			List<PowerNode> list = new List<PowerNode>();
			list.Add(this);
			exclusions.Add(this);
			for (int i = 0; i < this.connections.Count; i++)
			{
				if (!exclusions.Contains(this.connections[i].GetOtherNode(this)))
				{
					List<PowerNode> connectedNodes = this.connections[i].GetOtherNode(this).GetConnectedNodes(exclusions);
					exclusions.AddRange(connectedNodes);
					list.AddRange(connectedNodes);
				}
			}
			return list;
		}

		// Token: 0x04002959 RID: 10585
		public bool poweredNode;

		// Token: 0x0400295A RID: 10586
		public bool consumptionNode;

		// Token: 0x0400295B RID: 10587
		public bool isConnectedToPower;

		// Token: 0x0400295C RID: 10588
		[Header("References")]
		[SerializeField]
		protected Transform connectionPoint;

		// Token: 0x0400295D RID: 10589
		public List<PowerLine> connections = new List<PowerLine>();
	}
}
