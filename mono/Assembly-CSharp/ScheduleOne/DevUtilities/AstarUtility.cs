using System;
using Pathfinding;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006D5 RID: 1749
	public class AstarUtility : MonoBehaviour
	{
		// Token: 0x06002FB0 RID: 12208 RVA: 0x000C6B5C File Offset: 0x000C4D5C
		public static Vector3 GetClosestPointOnGraph(Vector3 point, string GraphName)
		{
			NNConstraint nnconstraint = new NNConstraint();
			nnconstraint.graphMask = GraphMask.FromGraphName(GraphName);
			return AstarPath.active.GetNearest(point, nnconstraint).position;
		}
	}
}
