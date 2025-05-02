using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.Law;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C36 RID: 3126
	public class PoliceStation : NPCEnterableBuilding
	{
		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06005794 RID: 22420 RVA: 0x0016F7CA File Offset: 0x0016D9CA
		// (set) Token: 0x06005795 RID: 22421 RVA: 0x0016F7D2 File Offset: 0x0016D9D2
		public float TimeSinceLastDispatch { get; private set; }

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06005796 RID: 22422 RVA: 0x0016F7DB File Offset: 0x0016D9DB
		private int deployedVehicleCount
		{
			get
			{
				return (from v in this.deployedVehicles
				where v != null
				select v).Count<LandVehicle>();
			}
		}

		// Token: 0x06005797 RID: 22423 RVA: 0x0016F80C File Offset: 0x0016DA0C
		protected override void Awake()
		{
			base.Awake();
			if (!PoliceStation.PoliceStations.Contains(this))
			{
				PoliceStation.PoliceStations.Add(this);
			}
			base.InvokeRepeating("CleanVehicleList", 0f, 5f);
		}

		// Token: 0x06005798 RID: 22424 RVA: 0x0016F841 File Offset: 0x0016DA41
		private void OnDestroy()
		{
			if (PoliceStation.PoliceStations.Contains(this))
			{
				PoliceStation.PoliceStations.Remove(this);
			}
		}

		// Token: 0x06005799 RID: 22425 RVA: 0x0016F85C File Offset: 0x0016DA5C
		private void Update()
		{
			this.TimeSinceLastDispatch += Time.deltaTime;
		}

		// Token: 0x0600579A RID: 22426 RVA: 0x0016F870 File Offset: 0x0016DA70
		private void CleanVehicleList()
		{
			for (int i = 0; i < this.deployedVehicles.Count; i++)
			{
				if (this.deployedVehicles[i] == null)
				{
					this.deployedVehicles.RemoveAt(i);
					i--;
				}
			}
		}

		// Token: 0x0600579B RID: 22427 RVA: 0x0016F8B8 File Offset: 0x0016DAB8
		public void Dispatch(int requestedOfficerCount, Player targetPlayer, PoliceStation.EDispatchType type = PoliceStation.EDispatchType.Auto, bool beginAsSighted = false)
		{
			if (!InstanceFinder.IsServer)
			{
				Console.LogWarning("Attempted to dispatch officers from a client, this is not allowed.", null);
				return;
			}
			if (requestedOfficerCount <= 0)
			{
				return;
			}
			if (requestedOfficerCount > 4)
			{
				Console.LogWarning("Attempted to dispatch more than 4 officers, this is not allowed.", null);
				return;
			}
			List<PoliceOfficer> list = new List<PoliceOfficer>();
			for (int i = 0; i < requestedOfficerCount; i++)
			{
				if (this.OfficerPool.Count > 0)
				{
					list.Add(this.PullOfficer());
				}
			}
			if (list.Count == 0)
			{
				Console.LogWarning("Attempted to dispatch officers, but there are no officers in the pool.", null);
				return;
			}
			bool flag = false;
			if (type == PoliceStation.EDispatchType.Auto)
			{
				flag = (Vector3.Distance(targetPlayer.CrimeData.LastKnownPosition, this.SpawnPoint.position) > LawManager.DISPATCH_VEHICLE_USE_THRESHOLD || targetPlayer.CurrentVehicle != null);
			}
			else if (type == PoliceStation.EDispatchType.UseVehicle)
			{
				flag = true;
			}
			if (flag && this.deployedVehicleCount < this.VehicleLimit)
			{
				LandVehicle landVehicle = this.CreateVehicle();
				list[0].AssignedVehicle = landVehicle;
				list[0].EnterVehicle(null, landVehicle);
				for (int j = 0; j < list.Count; j++)
				{
					list[j].BeginVehiclePursuit_Networked(targetPlayer.NetworkObject, landVehicle.NetworkObject, beginAsSighted);
				}
			}
			for (int k = 0; k < list.Count; k++)
			{
				list[k].BeginFootPursuit_Networked(targetPlayer.NetworkObject, true);
			}
			this.TimeSinceLastDispatch = 0f;
		}

		// Token: 0x0600579C RID: 22428 RVA: 0x0016FA04 File Offset: 0x0016DC04
		public PoliceOfficer PullOfficer()
		{
			if (this.OfficerPool.Count == 0)
			{
				Console.LogWarning("Attempted to pull an officer from the station, but there are no officers in the pool.", null);
				return null;
			}
			PoliceOfficer policeOfficer = this.OfficerPool[Random.Range(0, this.OfficerPool.Count)];
			this.OfficerPool.Remove(policeOfficer);
			policeOfficer.Activate();
			return policeOfficer;
		}

		// Token: 0x0600579D RID: 22429 RVA: 0x0016FA5C File Offset: 0x0016DC5C
		public LandVehicle CreateVehicle()
		{
			Transform target = this.VehicleSpawnPoints[0];
			for (int i = 0; i < this.VehicleSpawnPoints.Length; i++)
			{
				if (PoliceStation.<CreateVehicle>g__IsSpawnPointAvailable|21_0(this.VehicleSpawnPoints[i]))
				{
					target = this.VehicleSpawnPoints[i];
					break;
				}
			}
			LandVehicle landVehicle = this.PoliceVehiclePrefabs[Random.Range(0, this.PoliceVehiclePrefabs.Length)];
			Tuple<Vector3, Quaternion> alignmentTransform = landVehicle.GetAlignmentTransform(target, EParkingAlignment.RearToKerb);
			LandVehicle landVehicle2 = NetworkSingleton<VehicleManager>.Instance.SpawnAndReturnVehicle(landVehicle.VehicleCode, alignmentTransform.Item1, alignmentTransform.Item2, false);
			this.deployedVehicles.Add(landVehicle2);
			return landVehicle2;
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x0016FAEF File Offset: 0x0016DCEF
		public override void NPCEnteredBuilding(NPC npc)
		{
			base.NPCEnteredBuilding(npc);
			if (npc is PoliceOfficer && !this.OfficerPool.Contains(npc as PoliceOfficer))
			{
				this.OfficerPool.Add(npc as PoliceOfficer);
			}
		}

		// Token: 0x0600579F RID: 22431 RVA: 0x0016FB24 File Offset: 0x0016DD24
		public override void NPCExitedBuilding(NPC npc)
		{
			base.NPCExitedBuilding(npc);
			if (npc is PoliceOfficer)
			{
				this.OfficerPool.Remove(npc as PoliceOfficer);
			}
		}

		// Token: 0x060057A0 RID: 22432 RVA: 0x0016FB47 File Offset: 0x0016DD47
		public static PoliceStation GetClosestPoliceStation(Vector3 point)
		{
			return PoliceStation.PoliceStations[0];
		}

		// Token: 0x060057A3 RID: 22435 RVA: 0x0016FB88 File Offset: 0x0016DD88
		[CompilerGenerated]
		internal static bool <CreateVehicle>g__IsSpawnPointAvailable|21_0(Transform spawnPoint)
		{
			Collider[] array = Physics.OverlapSphere(spawnPoint.position, 2f, 1 << LayerMask.NameToLayer("Vehicle"));
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].GetComponentInParent<LandVehicle>() != null)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040040DE RID: 16606
		public static List<PoliceStation> PoliceStations = new List<PoliceStation>();

		// Token: 0x040040DF RID: 16607
		public int VehicleLimit = 5;

		// Token: 0x040040E0 RID: 16608
		[Header("References")]
		public Transform SpawnPoint;

		// Token: 0x040040E1 RID: 16609
		public Transform[] VehicleSpawnPoints;

		// Token: 0x040040E2 RID: 16610
		public Transform[] PossessedVehicleSpawnPoints;

		// Token: 0x040040E3 RID: 16611
		[Header("Prefabs")]
		public LandVehicle[] PoliceVehiclePrefabs;

		// Token: 0x040040E4 RID: 16612
		public List<PoliceOfficer> OfficerPool = new List<PoliceOfficer>();

		// Token: 0x040040E6 RID: 16614
		[SerializeField]
		private List<LandVehicle> deployedVehicles = new List<LandVehicle>();

		// Token: 0x02000C37 RID: 3127
		public enum EDispatchType
		{
			// Token: 0x040040E8 RID: 16616
			Auto,
			// Token: 0x040040E9 RID: 16617
			UseVehicle,
			// Token: 0x040040EA RID: 16618
			OnFoot
		}
	}
}
