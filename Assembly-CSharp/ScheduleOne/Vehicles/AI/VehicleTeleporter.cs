using System;
using Pathfinding;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x0200080A RID: 2058
	[RequireComponent(typeof(LandVehicle))]
	public class VehicleTeleporter : MonoBehaviour
	{
		// Token: 0x060037D5 RID: 14293 RVA: 0x000ECF2C File Offset: 0x000EB12C
		public void MoveToGraph(bool resetRotation = true)
		{
			NNConstraint nnconstraint = new NNConstraint();
			nnconstraint.graphMask = GraphMask.FromGraphName("General Vehicle Graph");
			NNInfo nearest = AstarPath.active.GetNearest(base.transform.position, nnconstraint);
			base.transform.position = nearest.position + base.transform.up * base.GetComponent<LandVehicle>().boundingBoxDimensions.y / 2f;
			if (resetRotation)
			{
				base.transform.rotation = Quaternion.identity;
			}
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x000ECFBC File Offset: 0x000EB1BC
		public void MoveToRoadNetwork(bool resetRotation = true)
		{
			NNConstraint nnconstraint = new NNConstraint();
			nnconstraint.graphMask = GraphMask.FromGraphName("Road Nodes");
			NNInfo nearest = AstarPath.active.GetNearest(base.transform.position, nnconstraint);
			base.transform.position = nearest.position + base.transform.up * base.GetComponent<LandVehicle>().boundingBoxDimensions.y / 2f;
			if (resetRotation)
			{
				base.transform.rotation = Quaternion.identity;
			}
		}
	}
}
