using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.Persistence;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Vehicles;
using UnityEngine.Events;

namespace ScheduleOne.Law
{
	// Token: 0x020005CD RID: 1485
	public class LawManager : Singleton<LawManager>
	{
		// Token: 0x060024CE RID: 9422 RVA: 0x000943FC File Offset: 0x000925FC
		protected override void Start()
		{
			base.Start();
			Singleton<LoadManager>.Instance.onPreSceneChange.AddListener(new UnityAction(delegate()
			{
				PoliceOfficer.Officers.Clear();
			}));
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00094434 File Offset: 0x00092634
		public void PoliceCalled(Player target, Crime crime)
		{
			if (NetworkSingleton<GameManager>.Instance.IsTutorial)
			{
				return;
			}
			Console.Log("Police called on " + target.PlayerName, null);
			PoliceStation closestPoliceStation = PoliceStation.GetClosestPoliceStation(target.CrimeData.LastKnownPosition);
			target.CrimeData.RecordLastKnownPosition(false);
			closestPoliceStation.Dispatch(2, target, PoliceStation.EDispatchType.Auto, false);
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x0009448C File Offset: 0x0009268C
		public PatrolGroup StartFootpatrol(FootPatrolRoute route, int requestedMembers)
		{
			PoliceStation closestPoliceStation = PoliceStation.GetClosestPoliceStation(route.Waypoints[route.StartWaypointIndex].position);
			if (closestPoliceStation.OfficerPool.Count == 0)
			{
				Console.LogWarning(closestPoliceStation.name + " has no officers in its pool!", null);
				return null;
			}
			PatrolGroup patrolGroup = new PatrolGroup(route);
			List<PoliceOfficer> list = new List<PoliceOfficer>();
			int num = 0;
			while (num < requestedMembers && closestPoliceStation.OfficerPool.Count != 0)
			{
				list.Add(closestPoliceStation.PullOfficer());
				num++;
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].StartFootPatrol(patrolGroup, false);
			}
			return patrolGroup;
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00094530 File Offset: 0x00092730
		public PoliceOfficer StartVehiclePatrol(VehiclePatrolRoute route)
		{
			PoliceStation closestPoliceStation = PoliceStation.GetClosestPoliceStation(route.Waypoints[route.StartWaypointIndex].position);
			if (closestPoliceStation.OfficerPool.Count == 0)
			{
				Console.LogWarning(closestPoliceStation.name + " has no officers in its pool!", null);
				return null;
			}
			LandVehicle landVehicle = closestPoliceStation.CreateVehicle();
			PoliceOfficer policeOfficer = closestPoliceStation.PullOfficer();
			policeOfficer.AssignedVehicle = landVehicle;
			policeOfficer.EnterVehicle(null, landVehicle);
			policeOfficer.StartVehiclePatrol(route, landVehicle);
			return policeOfficer;
		}

		// Token: 0x04001B56 RID: 6998
		public const int DISPATCH_OFFICER_COUNT = 2;

		// Token: 0x04001B57 RID: 6999
		public static float DISPATCH_VEHICLE_USE_THRESHOLD = 25f;
	}
}
