using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using EPOOutline;
using FishNet;
using FishNet.Component.Ownership;
using FishNet.Component.Transforming;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using Pathfinding;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.GameTime;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.Money;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Storage;
using ScheduleOne.Tools;
using ScheduleOne.UI;
using ScheduleOne.Vehicles.AI;
using ScheduleOne.Vehicles.Modification;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007C4 RID: 1988
	[RequireComponent(typeof(VehicleCamera))]
	[RequireComponent(typeof(NetworkTransform))]
	[RequireComponent(typeof(PredictedOwner))]
	[RequireComponent(typeof(VehicleCollisionDetector))]
	[RequireComponent(typeof(PhysicsDamageable))]
	public class LandVehicle : NetworkBehaviour, IGUIDRegisterable, ISaveable
	{
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060035CE RID: 13774 RVA: 0x000E21B4 File Offset: 0x000E03B4
		public string VehicleName
		{
			get
			{
				return this.vehicleName;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x000E21BC File Offset: 0x000E03BC
		public string VehicleCode
		{
			get
			{
				return this.vehicleCode;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060035D0 RID: 13776 RVA: 0x000E21C4 File Offset: 0x000E03C4
		public float VehiclePrice
		{
			get
			{
				return this.vehiclePrice;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x000E21CC File Offset: 0x000E03CC
		// (set) Token: 0x060035D2 RID: 13778 RVA: 0x000E21D4 File Offset: 0x000E03D4
		public bool IsPlayerOwned { get; protected set; }

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060035D3 RID: 13779 RVA: 0x000E21DD File Offset: 0x000E03DD
		// (set) Token: 0x060035D4 RID: 13780 RVA: 0x000E21E5 File Offset: 0x000E03E5
		public bool IsVisible { get; protected set; } = true;

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x000E21EE File Offset: 0x000E03EE
		// (set) Token: 0x060035D6 RID: 13782 RVA: 0x000E21F6 File Offset: 0x000E03F6
		public Guid GUID { get; protected set; }

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060035D7 RID: 13783 RVA: 0x000E21FF File Offset: 0x000E03FF
		// (set) Token: 0x060035D8 RID: 13784 RVA: 0x000E2207 File Offset: 0x000E0407
		public float DistanceToLocalCamera { get; private set; }

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060035D9 RID: 13785 RVA: 0x000E2210 File Offset: 0x000E0410
		public Vector3 boundingBoxDimensions
		{
			get
			{
				return new Vector3(this.boundingBox.size.x * this.boundingBox.transform.localScale.x, this.boundingBox.size.y * this.boundingBox.transform.localScale.y, this.boundingBox.size.z * this.boundingBox.transform.localScale.z);
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060035DA RID: 13786 RVA: 0x000E2294 File Offset: 0x000E0494
		public Transform driverEntryPoint
		{
			get
			{
				return this.exitPoints[0];
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060035DB RID: 13787 RVA: 0x000E22A2 File Offset: 0x000E04A2
		public Rigidbody Rb
		{
			get
			{
				return this.rb;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060035DC RID: 13788 RVA: 0x000E22AA File Offset: 0x000E04AA
		public float ActualMaxSteeringAngle
		{
			get
			{
				if (!this.MaxSteerAngleOverridden)
				{
					return this.maxSteeringAngle;
				}
				return this.OverriddenMaxSteerAngle;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060035DD RID: 13789 RVA: 0x000E22C1 File Offset: 0x000E04C1
		// (set) Token: 0x060035DE RID: 13790 RVA: 0x000E22C9 File Offset: 0x000E04C9
		public bool MaxSteerAngleOverridden { get; private set; }

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060035DF RID: 13791 RVA: 0x000E22D2 File Offset: 0x000E04D2
		// (set) Token: 0x060035E0 RID: 13792 RVA: 0x000E22DA File Offset: 0x000E04DA
		public float OverriddenMaxSteerAngle { get; private set; }

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060035E1 RID: 13793 RVA: 0x000E22E3 File Offset: 0x000E04E3
		// (set) Token: 0x060035E2 RID: 13794 RVA: 0x000E22EB File Offset: 0x000E04EB
		public EVehicleColor OwnedColor { get; private set; } = EVehicleColor.White;

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060035E3 RID: 13795 RVA: 0x000E22F4 File Offset: 0x000E04F4
		public int Capacity
		{
			get
			{
				return this.Seats.Length;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060035E4 RID: 13796 RVA: 0x000E22FE File Offset: 0x000E04FE
		public int CurrentPlayerOccupancy
		{
			get
			{
				return this.Seats.Count((VehicleSeat s) => s.isOccupied);
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060035E5 RID: 13797 RVA: 0x000E232A File Offset: 0x000E052A
		// (set) Token: 0x060035E6 RID: 13798 RVA: 0x000E2332 File Offset: 0x000E0532
		public bool localPlayerIsDriver { get; protected set; }

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060035E7 RID: 13799 RVA: 0x000E233B File Offset: 0x000E053B
		// (set) Token: 0x060035E8 RID: 13800 RVA: 0x000E2343 File Offset: 0x000E0543
		public bool localPlayerIsInVehicle { get; protected set; }

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060035E9 RID: 13801 RVA: 0x000E234C File Offset: 0x000E054C
		// (set) Token: 0x060035EA RID: 13802 RVA: 0x000E2354 File Offset: 0x000E0554
		public bool isOccupied { get; private set; }

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060035EB RID: 13803 RVA: 0x000E235D File Offset: 0x000E055D
		public Player DriverPlayer
		{
			get
			{
				if (this.Seats[0].Occupant != null)
				{
					return this.Seats[0].Occupant;
				}
				return null;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060035EC RID: 13804 RVA: 0x000E2384 File Offset: 0x000E0584
		public List<Player> OccupantPlayers
		{
			get
			{
				return (from s in this.Seats
				where s.isOccupied
				select s.Occupant).ToList<Player>();
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060035ED RID: 13805 RVA: 0x000E23E4 File Offset: 0x000E05E4
		// (set) Token: 0x060035EE RID: 13806 RVA: 0x000E23EC File Offset: 0x000E05EC
		public NPC[] OccupantNPCs { get; protected set; } = new NPC[0];

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060035EF RID: 13807 RVA: 0x000E23F5 File Offset: 0x000E05F5
		// (set) Token: 0x060035F0 RID: 13808 RVA: 0x000E23FD File Offset: 0x000E05FD
		public float speed_Kmh { get; protected set; }

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060035F1 RID: 13809 RVA: 0x000E2406 File Offset: 0x000E0606
		public float speed_Ms
		{
			get
			{
				return this.speed_Kmh / 3.6f;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060035F2 RID: 13810 RVA: 0x000E2414 File Offset: 0x000E0614
		public float speed_Mph
		{
			get
			{
				return this.speed_Kmh * 0.621371f;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060035F3 RID: 13811 RVA: 0x000E2422 File Offset: 0x000E0622
		// (set) Token: 0x060035F4 RID: 13812 RVA: 0x000E242A File Offset: 0x000E062A
		public float currentThrottle { get; protected set; }

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060035F5 RID: 13813 RVA: 0x000E2433 File Offset: 0x000E0633
		// (set) Token: 0x060035F6 RID: 13814 RVA: 0x000E243B File Offset: 0x000E063B
		public bool brakesApplied
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<brakesApplied>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.sync___set_value_<brakesApplied>k__BackingField(value, true);
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060035F7 RID: 13815 RVA: 0x000E2445 File Offset: 0x000E0645
		// (set) Token: 0x060035F8 RID: 13816 RVA: 0x000E244D File Offset: 0x000E064D
		public bool isReversing
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<isReversing>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.sync___set_value_<isReversing>k__BackingField(value, true);
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060035F9 RID: 13817 RVA: 0x000E2457 File Offset: 0x000E0657
		// (set) Token: 0x060035FA RID: 13818 RVA: 0x000E245F File Offset: 0x000E065F
		public bool isStatic { get; protected set; }

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060035FB RID: 13819 RVA: 0x000E2468 File Offset: 0x000E0668
		// (set) Token: 0x060035FC RID: 13820 RVA: 0x000E2470 File Offset: 0x000E0670
		public bool handbrakeApplied { get; protected set; }

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060035FD RID: 13821 RVA: 0x000E2479 File Offset: 0x000E0679
		public float boundingBaseOffset
		{
			get
			{
				return base.transform.InverseTransformPoint(this.boundingBox.transform.position).y + this.boundingBox.size.y * 0.5f;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060035FE RID: 13822 RVA: 0x000E24B2 File Offset: 0x000E06B2
		public bool isParked
		{
			get
			{
				return this.CurrentParkingLot != null;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060035FF RID: 13823 RVA: 0x000E24C0 File Offset: 0x000E06C0
		// (set) Token: 0x06003600 RID: 13824 RVA: 0x000E24C8 File Offset: 0x000E06C8
		public ParkingLot CurrentParkingLot { get; protected set; }

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06003601 RID: 13825 RVA: 0x000E24D1 File Offset: 0x000E06D1
		// (set) Token: 0x06003602 RID: 13826 RVA: 0x000E24D9 File Offset: 0x000E06D9
		public ParkingSpot CurrentParkingSpot { get; protected set; }

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06003603 RID: 13827 RVA: 0x000E24E4 File Offset: 0x000E06E4
		public string SaveFolderName
		{
			get
			{
				return this.vehicleCode + "_" + this.GUID.ToString().Substring(0, 6);
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06003604 RID: 13828 RVA: 0x000E251C File Offset: 0x000E071C
		public string SaveFileName
		{
			get
			{
				return "Vehicle";
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x000E2523 File Offset: 0x000E0723
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06003606 RID: 13830 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06003607 RID: 13831 RVA: 0x000E252B File Offset: 0x000E072B
		// (set) Token: 0x06003608 RID: 13832 RVA: 0x000E2533 File Offset: 0x000E0733
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06003609 RID: 13833 RVA: 0x000E253C File Offset: 0x000E073C
		// (set) Token: 0x0600360A RID: 13834 RVA: 0x000E2544 File Offset: 0x000E0744
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x000E254D File Offset: 0x000E074D
		// (set) Token: 0x0600360C RID: 13836 RVA: 0x000E2555 File Offset: 0x000E0755
		public bool HasChanged { get; set; }

		// Token: 0x0600360D RID: 13837 RVA: 0x000E2560 File Offset: 0x000E0760
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Vehicles.LandVehicle_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x000E2580 File Offset: 0x000E0780
		public override void OnStartServer()
		{
			base.OnStartServer();
			base.NetworkObject.GiveOwnership(base.LocalConnection);
			this.rb.isKinematic = false;
			this.rb.interpolation = 1;
			if (this.SpawnAsPlayerOwned)
			{
				this.IsPlayerOwned = true;
				this.SetIsPlayerOwned(null, true);
			}
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x000E25D4 File Offset: 0x000E07D4
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (connection.IsHost)
			{
				return;
			}
			this.SetOwnedColor(connection, this.OwnedColor);
			for (int i = 0; i < this.Seats.Length; i++)
			{
				if (this.Seats[i].Occupant != null)
				{
					this.SetSeatOccupant(connection, i, this.Seats[i].Occupant.Connection);
				}
			}
			if (this.isParked)
			{
				this.Park_Networked(connection, this.CurrentParkData);
			}
			if (this.IsPlayerOwned)
			{
				this.SetIsPlayerOwned(connection, true);
			}
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x000E2665 File Offset: 0x000E0865
		public override void OnStartClient()
		{
			base.OnStartClient();
			this.rb.isKinematic = false;
			if (!base.IsOwner && !InstanceFinder.IsHost)
			{
				this.rb.isKinematic = true;
			}
			this.rb.interpolation = 1;
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x000E26A0 File Offset: 0x000E08A0
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetIsPlayerOwned(NetworkConnection conn, bool playerOwned)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetIsPlayerOwned_214505783(conn, playerOwned);
				this.RpcLogic___SetIsPlayerOwned_214505783(conn, playerOwned);
			}
			else
			{
				this.RpcWriter___Target_SetIsPlayerOwned_214505783(conn, playerOwned);
			}
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x000E26D8 File Offset: 0x000E08D8
		private void RefreshPoI()
		{
			if (this.POI != null)
			{
				if (this.IsPlayerOwned)
				{
					this.POI.SetMainText(string.Concat(new string[]
					{
						"Owned Vehicle\n(",
						Singleton<VehicleColors>.Instance.GetColorName(this.OwnedColor),
						" ",
						this.VehicleName,
						")"
					}));
					this.POI.enabled = true;
					return;
				}
				this.POI.enabled = false;
			}
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x000E275E File Offset: 0x000E095E
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x000E2770 File Offset: 0x000E0970
		protected virtual void Start()
		{
			this.intObj.onHovered.AddListener(new UnityAction(this.Hovered));
			this.intObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
			if (this.centerOfMass != null)
			{
				this.rb.centerOfMass = base.transform.InverseTransformPoint(this.centerOfMass.transform.position);
			}
			this.ApplyOwnedColor();
			if (this.GUID == Guid.Empty)
			{
				this.GUID = GUIDManager.GenerateUniqueGUID();
			}
			MoneyManager instance = NetworkSingleton<MoneyManager>.Instance;
			instance.onNetworthCalculation = (Action<MoneyManager.FloatContainer>)Delegate.Combine(instance.onNetworthCalculation, new Action<MoneyManager.FloatContainer>(this.GetNetworth));
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 0);
			if (this.UseHumanoidCollider)
			{
				this.HumanoidColliderContainer.vehicle = this;
				this.HumanoidColliderContainer.transform.SetParent(NetworkSingleton<GameManager>.Instance.Temp);
				Collider[] componentsInChildren = base.GetComponentsInChildren<Collider>(true);
				Collider[] componentsInChildren2 = this.HumanoidColliderContainer.GetComponentsInChildren<Collider>(true);
				foreach (Collider collider in componentsInChildren)
				{
					foreach (Collider collider2 in componentsInChildren2)
					{
						if (this.DEBUG)
						{
							Debug.Log("Ignoring collision between " + collider.name + " and " + collider2.name);
						}
						Physics.IgnoreCollision(collider, collider2, true);
					}
				}
			}
			else
			{
				this.HumanoidColliderContainer.gameObject.SetActive(false);
			}
			TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance2.onMinutePass = (Action)Delegate.Remove(instance2.onMinutePass, new Action(this.OnMinPass));
			TimeManager instance3 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance3.onMinutePass = (Action)Delegate.Combine(instance3.onMinutePass, new Action(this.OnMinPass));
			if (!NetworkSingleton<VehicleManager>.Instance.AllVehicles.Contains(this))
			{
				NetworkSingleton<VehicleManager>.Instance.AllVehicles.Add(this);
			}
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x000E296E File Offset: 0x000E0B6E
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (action.exitType != ExitType.Escape)
			{
				return;
			}
			if (this.localPlayerIsInVehicle)
			{
				action.used = true;
				this.ExitVehicle();
			}
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x000E2998 File Offset: 0x000E0B98
		protected virtual void OnDestroy()
		{
			if (NetworkSingleton<MoneyManager>.InstanceExists)
			{
				MoneyManager instance = NetworkSingleton<MoneyManager>.Instance;
				instance.onNetworthCalculation = (Action<MoneyManager.FloatContainer>)Delegate.Remove(instance.onNetworthCalculation, new Action<MoneyManager.FloatContainer>(this.GetNetworth));
			}
			if (this.HumanoidColliderContainer != null)
			{
				Object.Destroy(this.HumanoidColliderContainer.gameObject);
			}
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.InstanceExists)
			{
				TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance2.onMinutePass = (Action)Delegate.Remove(instance2.onMinutePass, new Action(this.OnMinPass));
			}
			if (NetworkSingleton<VehicleManager>.InstanceExists)
			{
				NetworkSingleton<VehicleManager>.Instance.AllVehicles.Remove(this);
			}
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x000E2A36 File Offset: 0x000E0C36
		private void GetNetworth(MoneyManager.FloatContainer container)
		{
			if (this.IsPlayerOwned)
			{
				container.ChangeValue(this.GetVehicleValue());
			}
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x000E2A4C File Offset: 0x000E0C4C
		protected virtual void Update()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			bool flag = this.localPlayerIsDriver || base.IsOwner || (base.OwnerId == -1 && InstanceFinder.IsHost);
			this.rb.interpolation = (flag ? 1 : 0);
			this.HasChanged = true;
			if (this.localPlayerIsInVehicle && GameInput.GetButtonDown(GameInput.ButtonCode.Interact) && !GameInput.IsTyping)
			{
				this.ExitVehicle();
			}
			if (this.IsPlayerOwned)
			{
				if (!this.localPlayerIsDriver && (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.SleepInProgress || Vector3.Distance(base.transform.position, PlayerSingleton<PlayerCamera>.Instance.Camera.transform.position) > 30f))
				{
					this.rb.isKinematic = true;
				}
				else if (base.NetworkObject.Owner == null || base.NetworkObject.OwnerId == -1 || base.NetworkObject.Owner == base.LocalConnection)
				{
					this.rb.isKinematic = false;
				}
			}
			if (this.overrideControls)
			{
				this.currentThrottle = this.throttleOverride;
				this.sync___set_value_currentSteerAngle(this.steerOverride * this.ActualMaxSteeringAngle, true);
			}
			else
			{
				this.UpdateThrottle();
				this.UpdateSteerAngle();
			}
			this.ApplySteerAngle();
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x000045B1 File Offset: 0x000027B1
		private void OnDrawGizmos()
		{
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x000E2B98 File Offset: 0x000E0D98
		protected virtual void FixedUpdate()
		{
			float item = base.transform.InverseTransformDirection(base.transform.position - this.lastFramePosition).z / Time.fixedDeltaTime * 3.6f;
			this.previousSpeeds.Add(item);
			if (this.previousSpeeds.Count > this.previousSpeedsSampleSize)
			{
				this.previousSpeeds.RemoveAt(0);
			}
			if (this.isStatic || !this.localPlayerIsDriver)
			{
				float num = 0f;
				foreach (float num2 in this.previousSpeeds)
				{
					num += num2;
				}
				float speed_Kmh = num / (float)this.previousSpeeds.Count;
				this.speed_Kmh = speed_Kmh;
			}
			else
			{
				this.speed_Kmh = base.transform.InverseTransformDirection(this.rb.velocity).z * 3.6f;
			}
			this.lastFramePosition = base.transform.position;
			if (!this.isStatic && !this.Rb.isKinematic)
			{
				this.ApplyThrottle();
				this.rb.AddForce(-base.transform.up * this.speed_Kmh * this.downforce);
			}
			else
			{
				if (this.brakesApplied)
				{
					this.brakesApplied = false;
				}
				this.sync___set_value_currentSteerAngle(0f, true);
			}
			if (!this.isStatic)
			{
				if ((base.IsOwner || (base.OwnerId == -1 && InstanceFinder.IsHost)) && base.transform.position.y < -20f)
				{
					if (this.rb != null)
					{
						this.rb.velocity = Vector3.zero;
						this.rb.angularVelocity = Vector3.zero;
					}
					float num3 = 0f;
					if (MapHeightSampler.Sample(base.transform.position.x, out num3, base.transform.position.z))
					{
						this.SetTransform(new Vector3(base.transform.position.x, num3 + 3f, base.transform.position.z), Quaternion.identity);
					}
					else
					{
						this.SetTransform(MapHeightSampler.ResetPosition, Quaternion.identity);
					}
				}
				if (this.localPlayerIsDriver && Mathf.Abs(this.speed_Kmh) < 5f)
				{
					int num4 = 0;
					for (int i = 0; i < this.wheels.Count; i++)
					{
						if (!this.wheels[i].IsWheelGrounded())
						{
							num4++;
						}
					}
					if (num4 >= 2)
					{
						this.rb.AddRelativeTorque(Vector3.forward * 8f * -Mathf.Clamp(this.SyncAccessor_currentSteerAngle / this.ActualMaxSteeringAngle, -1f, 1f), 5);
					}
				}
			}
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x000E2E98 File Offset: 0x000E1098
		protected virtual void OnMinPass()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists || this == null || base.transform == null)
			{
				this.DistanceToLocalCamera = 100000f;
				return;
			}
			this.DistanceToLocalCamera = Vector3.Distance(base.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position);
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x000E2EF4 File Offset: 0x000E10F4
		protected virtual void LateUpdate()
		{
			if (this.HumanoidColliderContainer != null)
			{
				this.HumanoidColliderContainer.transform.position = base.transform.position;
				this.HumanoidColliderContainer.transform.rotation = base.transform.rotation;
			}
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x000E2F45 File Offset: 0x000E1145
		private void OnCollisionEnter(Collision collision)
		{
			if (this.onCollision != null)
			{
				this.onCollision.Invoke(collision);
			}
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x000E2F5B File Offset: 0x000E115B
		[ServerRpc(RequireOwnership = false)]
		protected virtual void SetOwner(NetworkConnection conn)
		{
			this.RpcWriter___Server_SetOwner_328543758(conn);
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x000E2F68 File Offset: 0x000E1168
		[ObserversRpc]
		protected virtual void OnOwnerChanged()
		{
			this.RpcWriter___Observers_OnOwnerChanged_2166136261();
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x000E2F7B File Offset: 0x000E117B
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetTransform_Server(Vector3 pos, Quaternion rot)
		{
			this.RpcWriter___Server_SetTransform_Server_3848837105(pos, rot);
			this.RpcLogic___SetTransform_Server_3848837105(pos, rot);
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x000E2F99 File Offset: 0x000E1199
		[ObserversRpc(RunLocally = true)]
		public void SetTransform(Vector3 pos, Quaternion rot)
		{
			this.RpcWriter___Observers_SetTransform_3848837105(pos, rot);
			this.RpcLogic___SetTransform_3848837105(pos, rot);
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x000E2FB8 File Offset: 0x000E11B8
		public void DestroyVehicle()
		{
			if (!InstanceFinder.IsServer)
			{
				Console.LogWarning("DestroyVehicle called on client!", null);
				return;
			}
			if (this.isOccupied)
			{
				Console.LogError("Can't destroy vehicle while occupied.", base.gameObject);
				return;
			}
			if (this.isParked)
			{
				this.ExitPark_Networked(null, false);
			}
			if (this.HumanoidColliderContainer != null)
			{
				Object.Destroy(this.HumanoidColliderContainer.gameObject);
			}
			base.Despawn(null);
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x000E3030 File Offset: 0x000E1230
		protected virtual void UpdateThrottle()
		{
			this.currentThrottle = 0f;
			if (this.localPlayerIsDriver)
			{
				this.currentThrottle = GameInput.MotionAxis.y;
				if (this.DriverPlayer.IsTased)
				{
					this.currentThrottle = 0f;
				}
			}
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x000E3078 File Offset: 0x000E1278
		protected virtual void ApplyThrottle()
		{
			bool handbrakeApplied = this.handbrakeApplied;
			this.handbrakeApplied = false;
			if (this.localPlayerIsDriver || this.overrideControls)
			{
				if (this.brakesApplied)
				{
					this.brakesApplied = false;
				}
				if (this.isReversing)
				{
					this.isReversing = false;
				}
				foreach (Wheel wheel in this.wheels)
				{
					wheel.wheelCollider.motorTorque = 0.0001f;
					wheel.wheelCollider.brakeTorque = 0f;
				}
				if (this.localPlayerIsDriver)
				{
					this.handbrakeApplied = GameInput.GetButton(GameInput.ButtonCode.Handbrake);
				}
				if (this.handbrakeApplied && Mathf.Abs(this.speed_Kmh) > 4f)
				{
					this.brakesApplied = true;
					if (!handbrakeApplied && this.onHandbrakeApplied != null)
					{
						this.onHandbrakeApplied.Invoke();
					}
				}
				if (this.currentThrottle != 0f && (Mathf.Abs(this.speed_Kmh) < 4f || Mathf.Sign(this.speed_Kmh) == Mathf.Sign(this.currentThrottle)))
				{
					if (this.speed_Kmh < -0.1f && this.currentThrottle < 0f && !this.isReversing)
					{
						this.isReversing = true;
					}
					float num = this.motorTorque.Evaluate(Mathf.Abs(this.speed_Kmh));
					if (this.isReversing)
					{
						num = this.motorTorque.Evaluate(Mathf.Abs(this.speed_Kmh) / this.reverseMultiplier);
					}
					WheelCollider[] array = this.driveWheels;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].motorTorque = this.currentThrottle * num * this.diffGearing / 2f;
					}
					goto IL_2B7;
				}
				if (this.currentThrottle == 0f)
				{
					goto IL_2B7;
				}
				if (Mathf.Abs(this.currentThrottle) > 0.05f && !this.brakesApplied)
				{
					this.brakesApplied = true;
				}
				using (List<Wheel>.Enumerator enumerator = this.wheels.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Wheel wheel2 = enumerator.Current;
						wheel2.wheelCollider.brakeTorque = Mathf.Abs(this.currentThrottle) * this.brakeForce.Evaluate(Mathf.Abs(this.speed_Kmh));
					}
					goto IL_2B7;
				}
			}
			foreach (Wheel wheel3 in this.wheels)
			{
				wheel3.wheelCollider.motorTorque = 0f;
			}
			if (!this.isOccupied)
			{
				if (!this.handbrakeApplied)
				{
					this.handbrakeApplied = true;
				}
				if (this.isReversing)
				{
					this.isReversing = false;
				}
				if (this.brakesApplied)
				{
					this.brakesApplied = false;
				}
			}
			IL_2B7:
			if (this.handbrakeApplied)
			{
				foreach (WheelCollider wheelCollider in this.handbrakeWheels)
				{
					wheelCollider.motorTorque = 0f;
					wheelCollider.brakeTorque = this.handBrakeForce;
				}
			}
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x000E33A0 File Offset: 0x000E15A0
		public void ApplyHandbrake()
		{
			this.handbrakeApplied = true;
			foreach (WheelCollider wheelCollider in this.handbrakeWheels)
			{
				wheelCollider.motorTorque = 0f;
				wheelCollider.brakeTorque = this.handBrakeForce;
			}
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x000E33E2 File Offset: 0x000E15E2
		[ServerRpc(RequireOwnership = false)]
		private void SetSteeringAngle(float sa)
		{
			this.RpcWriter___Server_SetSteeringAngle_431000436(sa);
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x000E33F0 File Offset: 0x000E15F0
		protected virtual void UpdateSteerAngle()
		{
			if (this.localPlayerIsDriver)
			{
				this.sync___set_value_currentSteerAngle(this.lastFrameSteerAngle, true);
				if (this.DriverPlayer.IsTased || Player.Local.Seizure)
				{
					this.sync___set_value_currentSteerAngle(Mathf.MoveTowards(this.SyncAccessor_currentSteerAngle, Random.Range(-this.ActualMaxSteeringAngle, this.ActualMaxSteeringAngle), this.steerRate * Time.deltaTime), true);
				}
				else
				{
					float num = 1f;
					if (Player.Local.Disoriented)
					{
						num = -1f;
					}
					if (GameInput.GetButton(GameInput.ButtonCode.Left))
					{
						this.sync___set_value_currentSteerAngle(Mathf.Clamp(this.SyncAccessor_currentSteerAngle - this.steerRate * Time.deltaTime * num, -this.ActualMaxSteeringAngle, this.ActualMaxSteeringAngle), true);
					}
					if (GameInput.GetButton(GameInput.ButtonCode.Right))
					{
						this.sync___set_value_currentSteerAngle(Mathf.Clamp(this.SyncAccessor_currentSteerAngle + this.steerRate * Time.deltaTime * num, -this.ActualMaxSteeringAngle, this.ActualMaxSteeringAngle), true);
					}
					if (!GameInput.GetButton(GameInput.ButtonCode.Left) && !GameInput.GetButton(GameInput.ButtonCode.Right))
					{
						this.sync___set_value_currentSteerAngle(Mathf.MoveTowards(this.SyncAccessor_currentSteerAngle, 0f, this.steerRate * Time.deltaTime), true);
					}
				}
				if (Mathf.Abs(this.lastReplicatedSteerAngle - this.SyncAccessor_currentSteerAngle) > 3f)
				{
					this.lastReplicatedSteerAngle = this.SyncAccessor_currentSteerAngle;
					this.SetSteeringAngle(this.SyncAccessor_currentSteerAngle);
				}
				this.lastFrameSteerAngle = this.SyncAccessor_currentSteerAngle;
			}
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x000E3558 File Offset: 0x000E1758
		protected virtual void ApplySteerAngle()
		{
			float num = this.SyncAccessor_currentSteerAngle;
			if (this.flipSteer)
			{
				num *= -1f;
			}
			WheelCollider[] array = this.steerWheels;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].steerAngle = num;
			}
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x000E359C File Offset: 0x000E179C
		private void DelaySetStatic(bool stat)
		{
			LandVehicle.<>c__DisplayClass224_0 CS$<>8__locals1 = new LandVehicle.<>c__DisplayClass224_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.stat = stat;
			base.StartCoroutine(CS$<>8__locals1.<DelaySetStatic>g__Wait|0());
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x000E35CC File Offset: 0x000E17CC
		public virtual void SetIsStatic(bool stat)
		{
			this.isStatic = stat;
			if (this.isStatic)
			{
				this.rb.isKinematic = true;
			}
			else
			{
				this.rb.isKinematic = false;
			}
			foreach (Wheel wheel in this.wheels)
			{
				wheel.SetIsStatic(this.isStatic);
			}
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x000E364C File Offset: 0x000E184C
		public void AlignTo(Transform target, EParkingAlignment type, bool network = false)
		{
			Tuple<Vector3, Quaternion> alignmentTransform = this.GetAlignmentTransform(target, type);
			base.transform.rotation = alignmentTransform.Item2;
			base.transform.position = alignmentTransform.Item1;
			this.rb.position = alignmentTransform.Item1;
			this.rb.rotation = alignmentTransform.Item2;
			if (network)
			{
				this.SetTransform_Server(alignmentTransform.Item1, alignmentTransform.Item2);
			}
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x000E36BC File Offset: 0x000E18BC
		public Tuple<Vector3, Quaternion> GetAlignmentTransform(Transform target, EParkingAlignment type)
		{
			Quaternion quaternion = target.rotation;
			if (type == EParkingAlignment.FrontToKerb)
			{
				quaternion *= Quaternion.Euler(0f, 180f, 0f);
			}
			Vector3 vector = target.position + target.up * (this.boundingBoxDimensions.y / 2f - this.boundingBox.transform.localPosition.y);
			if (type == EParkingAlignment.FrontToKerb)
			{
				vector += target.forward * (this.boundingBoxDimensions.z / 2f - this.boundingBox.transform.localPosition.y);
			}
			else
			{
				vector += target.forward * (this.boundingBoxDimensions.z / 2f - this.boundingBox.transform.localPosition.y);
			}
			return new Tuple<Vector3, Quaternion>(vector, quaternion);
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x000E37AA File Offset: 0x000E19AA
		public float GetVehicleValue()
		{
			return this.VehiclePrice;
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x000E37B2 File Offset: 0x000E19B2
		public void OverrideMaxSteerAngle(float maxAngle)
		{
			this.OverriddenMaxSteerAngle = maxAngle;
			this.MaxSteerAngleOverridden = true;
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x000E37C2 File Offset: 0x000E19C2
		public void ResetMaxSteerAngle()
		{
			this.MaxSteerAngleOverridden = false;
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x000E37CB File Offset: 0x000E19CB
		public void SetObstaclesActive(bool active)
		{
			this.NavmeshCut.enabled = active;
			this.NavMeshObstacle.carving = active;
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x000E37E8 File Offset: 0x000E19E8
		public VehicleSeat GetFirstFreeSeat()
		{
			for (int i = 0; i < this.Seats.Length; i++)
			{
				if (!this.Seats[i].isOccupied)
				{
					return this.Seats[i];
				}
			}
			return null;
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x000E3824 File Offset: 0x000E1A24
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSeatOccupant(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetSeatOccupant_3428404692(conn, seatIndex, occupant);
				this.RpcLogic___SetSeatOccupant_3428404692(conn, seatIndex, occupant);
			}
			else
			{
				this.RpcWriter___Target_SetSeatOccupant_3428404692(conn, seatIndex, occupant);
			}
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x000E3871 File Offset: 0x000E1A71
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SetSeatOccupant_Server(int seatIndex, NetworkConnection conn)
		{
			this.RpcWriter___Server_SetSeatOccupant_Server_3266232555(seatIndex, conn);
			this.RpcLogic___SetSeatOccupant_Server_3266232555(seatIndex, conn);
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x000E3890 File Offset: 0x000E1A90
		private void Hovered()
		{
			if (!this.IsPlayerOwned)
			{
				this.intObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			if (this.CurrentPlayerOccupancy < this.Capacity)
			{
				this.intObj.SetMessage("Enter vehicle");
				this.intObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.intObj.SetMessage("Vehicle full");
			this.intObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x000E38F9 File Offset: 0x000E1AF9
		private void Interacted()
		{
			if (this.justExitedVehicle)
			{
				return;
			}
			if (!this.IsPlayerOwned)
			{
				return;
			}
			if (this.CurrentPlayerOccupancy < this.Capacity)
			{
				this.EnterVehicle();
			}
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x000E3924 File Offset: 0x000E1B24
		private void EnterVehicle()
		{
			if (this.justExitedVehicle)
			{
				return;
			}
			this.localPlayerIsInVehicle = true;
			this.localPlayerSeat = this.GetFirstFreeSeat();
			this.localPlayerIsDriver = this.localPlayerSeat.isDriverSeat;
			this.SetSeatOccupant_Server(Array.IndexOf<VehicleSeat>(this.Seats, this.localPlayerSeat), Player.Local.Connection);
			this.closestExitPoint = this.GetClosestExitPoint(this.localPlayerSeat.transform.position);
			Player.Local.EnterVehicle(this);
			PlayerSingleton<PlayerCamera>.Instance.SetCameraMode(PlayerCamera.ECameraMode.Vehicle);
			if (PlayerSingleton<PlayerInventory>.InstanceExists)
			{
				PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			}
			if (this.localPlayerIsDriver)
			{
				base.NetworkObject.SetLocalOwnership(Player.Local.Connection);
				this.SetOwner(Player.Local.Connection);
			}
			this.SetObstaclesActive(!this.isOccupied);
			Singleton<HUD>.Instance.SetCrosshairVisible(false);
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x000E3A0C File Offset: 0x000E1C0C
		public void ExitVehicle()
		{
			if (this.localPlayerIsDriver)
			{
				this.SetOwner(null);
			}
			this.localPlayerIsInVehicle = false;
			this.localPlayerIsDriver = false;
			if (this.localPlayerSeat != null)
			{
				this.SetSeatOccupant_Server(Array.IndexOf<VehicleSeat>(this.Seats, this.localPlayerSeat), null);
				this.localPlayerSeat = null;
			}
			List<Transform> list = new List<Transform>();
			list.Add(this.closestExitPoint);
			list.AddRange(this.exitPoints);
			Transform validExitPoint = this.GetValidExitPoint(list);
			Player.Local.ExitVehicle(validExitPoint);
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.ResetRotation();
			PlayerSingleton<PlayerCamera>.Instance.SetCameraMode(PlayerCamera.ECameraMode.Default);
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			Singleton<HUD>.Instance.SetCrosshairVisible(true);
			this.SetObstaclesActive(!this.isOccupied);
			this.justExitedVehicle = true;
			base.Invoke("EndJustExited", 0.05f);
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x000E3AF6 File Offset: 0x000E1CF6
		private void EndJustExited()
		{
			this.justExitedVehicle = false;
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x000E3AFF File Offset: 0x000E1CFF
		public Transform GetExitPoint(int seatIndex = 0)
		{
			return this.exitPoints[seatIndex];
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x000E3B10 File Offset: 0x000E1D10
		private Transform GetClosestExitPoint(Vector3 pos)
		{
			Transform transform = null;
			for (int i = 0; i < this.exitPoints.Count; i++)
			{
				if (transform == null || Vector3.Distance(this.exitPoints[i].position, pos) < Vector3.Distance(transform.transform.position, pos))
				{
					transform = this.exitPoints[i];
				}
			}
			return transform;
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x000E3B78 File Offset: 0x000E1D78
		private Transform GetValidExitPoint(List<Transform> possibleExitPoints)
		{
			LayerMask mask = default(LayerMask) | 1 << LayerMask.NameToLayer("Default");
			mask |= 1 << LayerMask.NameToLayer("Vehicle");
			mask |= 1 << LayerMask.NameToLayer("Terrain");
			for (int i = 0; i < possibleExitPoints.Count; i++)
			{
				if (Physics.OverlapSphere(possibleExitPoints[i].position, 0.35f, mask).Length == 0)
				{
					return possibleExitPoints[i];
				}
			}
			Console.LogWarning("Unable to find clear exit point for vehicle. Using first exit point.", null);
			return possibleExitPoints[0];
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x000E3C2C File Offset: 0x000E1E2C
		public void AddNPCOccupant(NPC npc)
		{
			int num = (from x in this.OccupantNPCs
			where x != null
			select x).Count<NPC>();
			if (!this.OccupantNPCs.Contains(npc))
			{
				for (int i = 0; i < this.OccupantNPCs.Length; i++)
				{
					if (this.OccupantNPCs[i] == null)
					{
						this.OccupantNPCs[i] = npc;
						break;
					}
				}
			}
			this.isOccupied = true;
			this.SetObstaclesActive(!this.isOccupied);
			if (num == 0 && this.onVehicleStart != null)
			{
				this.onVehicleStart.Invoke();
			}
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x000E3CD4 File Offset: 0x000E1ED4
		public void RemoveNPCOccupant(NPC npc)
		{
			for (int i = 0; i < this.OccupantNPCs.Length; i++)
			{
				if (this.OccupantNPCs[i] == npc)
				{
					this.OccupantNPCs[i] = null;
				}
			}
			if ((from x in this.OccupantNPCs
			where x != null
			select x).Count<NPC>() == 0)
			{
				this.isOccupied = false;
				if (this.onVehicleStop != null)
				{
					this.onVehicleStop.Invoke();
				}
			}
			this.SetObstaclesActive(!this.isOccupied);
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x000E3D67 File Offset: 0x000E1F67
		public virtual bool CanBeRecovered()
		{
			return this.IsPlayerOwned && !this.isOccupied && !this.isStatic;
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x000E3D84 File Offset: 0x000E1F84
		public virtual void RecoverVehicle()
		{
			VehicleRecoveryPoint closestRecoveryPoint = VehicleRecoveryPoint.GetClosestRecoveryPoint(base.transform.position);
			base.transform.position = closestRecoveryPoint.transform.position + Vector3.up * 2f;
			base.transform.up = Vector3.up;
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x000E3DDC File Offset: 0x000E1FDC
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendOwnedColor(EVehicleColor col)
		{
			this.RpcWriter___Server_SendOwnedColor_911055161(col);
			this.RpcLogic___SendOwnedColor_911055161(col);
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x000E3DF2 File Offset: 0x000E1FF2
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		protected virtual void SetOwnedColor(NetworkConnection conn, EVehicleColor col)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetOwnedColor_1679996372(conn, col);
				this.RpcLogic___SetOwnedColor_1679996372(conn, col);
			}
			else
			{
				this.RpcWriter___Target_SetOwnedColor_1679996372(conn, col);
			}
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x000E3E28 File Offset: 0x000E2028
		public virtual void ApplyColor(EVehicleColor col)
		{
			if (col == EVehicleColor.Custom)
			{
				this.DisplayedColor = col;
				return;
			}
			this.DisplayedColor = col;
			Material material = Singleton<VehicleColors>.Instance.colorLibrary.Find((VehicleColors.VehicleColorData x) => x.color == this.DisplayedColor).material;
			for (int i = 0; i < this.BodyMeshes.Length; i++)
			{
				this.BodyMeshes[i].Renderer.materials[this.BodyMeshes[i].MaterialIndex].color = material.color;
			}
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x000E3EA8 File Offset: 0x000E20A8
		public void ApplyOwnedColor()
		{
			this.ApplyColor(this.OwnedColor);
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x000E3EB8 File Offset: 0x000E20B8
		public void ShowOutline(BuildableItem.EOutlineColor color)
		{
			if (this.outlineEffect == null)
			{
				this.outlineEffect = base.gameObject.AddComponent<Outlinable>();
				this.outlineEffect.OutlineParameters.BlurShift = 0f;
				this.outlineEffect.OutlineParameters.DilateShift = 0.5f;
				this.outlineEffect.OutlineParameters.FillPass.Shader = Resources.Load<Shader>("Easy performant outline/Shaders/Fills/ColorFill");
				foreach (GameObject gameObject in this.outlineRenderers)
				{
					MeshRenderer[] componentsInChildren = gameObject.GetComponentsInChildren<MeshRenderer>();
					for (int i = 0; i < componentsInChildren.Length; i++)
					{
						OutlineTarget outlineTarget = new OutlineTarget(componentsInChildren[i], 0);
						this.outlineEffect.TryAddTarget(outlineTarget);
					}
				}
			}
			this.outlineEffect.OutlineParameters.Color = BuildableItem.GetColorFromOutlineColorEnum(color);
			Color32 colorFromOutlineColorEnum = BuildableItem.GetColorFromOutlineColorEnum(color);
			colorFromOutlineColorEnum.a = 9;
			this.outlineEffect.OutlineParameters.FillPass.SetColor("_PublicColor", colorFromOutlineColorEnum);
			this.outlineEffect.enabled = true;
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x000E3FF4 File Offset: 0x000E21F4
		public void HideOutline()
		{
			if (this.outlineEffect != null)
			{
				this.outlineEffect.enabled = false;
			}
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x000E4010 File Offset: 0x000E2210
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void Park_Networked(NetworkConnection conn, ParkData parkData)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_Park_Networked_2633993806(conn, parkData);
				this.RpcLogic___Park_Networked_2633993806(conn, parkData);
			}
			else
			{
				this.RpcWriter___Target_Park_Networked_2633993806(conn, parkData);
			}
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x000E4048 File Offset: 0x000E2248
		public void Park(NetworkConnection conn, ParkData parkData, bool network)
		{
			if (this.isParked)
			{
				this.ExitPark(true);
			}
			if (network)
			{
				this.Park_Networked(conn, parkData);
				return;
			}
			this.CurrentParkingLot = GUIDManager.GetObject<ParkingLot>(parkData.lotGUID);
			if (this.CurrentParkingLot == null)
			{
				Console.LogWarning("LandVehicle.Park: parking lot not found with the given GUID.", null);
				return;
			}
			this.CurrentParkData = parkData;
			if (parkData.spotIndex < 0 || parkData.spotIndex >= this.CurrentParkingLot.ParkingSpots.Count)
			{
				this.SetVisible(false);
			}
			else
			{
				this.CurrentParkingSpot = this.CurrentParkingLot.ParkingSpots[parkData.spotIndex];
				this.CurrentParkingSpot.SetOccupant(this);
				this.AlignTo(this.CurrentParkingSpot.AlignmentPoint, parkData.alignment, false);
			}
			this.SetIsStatic(true);
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x000E4113 File Offset: 0x000E2313
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void ExitPark_Networked(NetworkConnection conn, bool moveToExitPoint = true)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_ExitPark_Networked_214505783(conn, moveToExitPoint);
				this.RpcLogic___ExitPark_Networked_214505783(conn, moveToExitPoint);
			}
			else
			{
				this.RpcWriter___Target_ExitPark_Networked_214505783(conn, moveToExitPoint);
			}
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x000E414C File Offset: 0x000E234C
		public void ExitPark(bool moveToExitPoint = true)
		{
			if (this.CurrentParkingLot == null)
			{
				return;
			}
			if (this.CurrentParkingLot.ExitPoint != null && moveToExitPoint)
			{
				this.AlignTo(this.CurrentParkingLot.ExitPoint, this.CurrentParkingLot.ExitAlignment, false);
			}
			this.CurrentParkData = null;
			this.CurrentParkingLot = null;
			if (this.CurrentParkingSpot != null)
			{
				this.CurrentParkingSpot.SetOccupant(null);
				this.CurrentParkingSpot = null;
			}
			this.SetIsStatic(false);
			this.SetVisible(true);
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x000E41E3 File Offset: 0x000E23E3
		public void SetVisible(bool vis)
		{
			this.IsVisible = vis;
			this.vehicleModel.gameObject.SetActive(vis);
			this.HumanoidColliderContainer.gameObject.SetActive(vis);
			this.boundingBox.gameObject.SetActive(vis);
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x000E4220 File Offset: 0x000E2420
		public List<ItemInstance> GetContents()
		{
			List<ItemInstance> list = new List<ItemInstance>();
			if (this.Storage != null)
			{
				list.AddRange(this.Storage.GetAllItems());
			}
			return list;
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x000E4253 File Offset: 0x000E2453
		public virtual string GetSaveString()
		{
			return new VehicleData(this.GUID, this.vehicleCode, base.transform.position, base.transform.rotation, this.OwnedColor).GetJson(true);
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x000E4288 File Offset: 0x000E2488
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			if (this.Storage != null && this.Storage.ItemCount > 0)
			{
				string json = new ItemSet(this.Storage.ItemSlots).GetJSON();
				list.Add("Contents.json");
				((ISaveable)this).WriteSubfile(parentFolderPath, "Contents", json);
			}
			return list;
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x000E42E8 File Offset: 0x000E24E8
		public virtual void Load(VehicleData data, string containerPath)
		{
			this.SetGUID(new Guid(data.GUID));
			this.SetTransform(data.Position, data.Rotation);
			this.SetOwnedColor(null, Enum.Parse<EVehicleColor>(data.Color));
			string json;
			if (this.Storage != null && File.Exists(Path.Combine(containerPath, "Contents.json")) && this.Loader.TryLoadFile(containerPath, "Contents", out json))
			{
				ItemInstance[] array = ItemSet.Deserialize(json);
				for (int i = 0; i < array.Length; i++)
				{
					this.Storage.ItemSlots[i].SetStoredItem(array[i], false);
				}
			}
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x000E4564 File Offset: 0x000E2764
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<isReversing>k__BackingField = new SyncVar<bool>(this, 2U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, 0.1f, Channel.Unreliable, this.<isReversing>k__BackingField);
			this.syncVar___<brakesApplied>k__BackingField = new SyncVar<bool>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, 0.1f, Channel.Unreliable, this.<brakesApplied>k__BackingField);
			this.syncVar___currentSteerAngle = new SyncVar<float>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, 0.05f, Channel.Unreliable, this.currentSteerAngle);
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_SetIsPlayerOwned_214505783));
			base.RegisterTargetRpc(1U, new ClientRpcDelegate(this.RpcReader___Target_SetIsPlayerOwned_214505783));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_SetOwner_328543758));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_OnOwnerChanged_2166136261));
			base.RegisterServerRpc(4U, new ServerRpcDelegate(this.RpcReader___Server_SetTransform_Server_3848837105));
			base.RegisterObserversRpc(5U, new ClientRpcDelegate(this.RpcReader___Observers_SetTransform_3848837105));
			base.RegisterServerRpc(6U, new ServerRpcDelegate(this.RpcReader___Server_SetSteeringAngle_431000436));
			base.RegisterObserversRpc(7U, new ClientRpcDelegate(this.RpcReader___Observers_SetSeatOccupant_3428404692));
			base.RegisterTargetRpc(8U, new ClientRpcDelegate(this.RpcReader___Target_SetSeatOccupant_3428404692));
			base.RegisterServerRpc(9U, new ServerRpcDelegate(this.RpcReader___Server_SetSeatOccupant_Server_3266232555));
			base.RegisterServerRpc(10U, new ServerRpcDelegate(this.RpcReader___Server_SendOwnedColor_911055161));
			base.RegisterTargetRpc(11U, new ClientRpcDelegate(this.RpcReader___Target_SetOwnedColor_1679996372));
			base.RegisterObserversRpc(12U, new ClientRpcDelegate(this.RpcReader___Observers_SetOwnedColor_1679996372));
			base.RegisterObserversRpc(13U, new ClientRpcDelegate(this.RpcReader___Observers_Park_Networked_2633993806));
			base.RegisterTargetRpc(14U, new ClientRpcDelegate(this.RpcReader___Target_Park_Networked_2633993806));
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_ExitPark_Networked_214505783));
			base.RegisterTargetRpc(16U, new ClientRpcDelegate(this.RpcReader___Target_ExitPark_Networked_214505783));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Vehicles.LandVehicle));
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x000E479C File Offset: 0x000E299C
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<isReversing>k__BackingField.SetRegistered();
			this.syncVar___<brakesApplied>k__BackingField.SetRegistered();
			this.syncVar___currentSteerAngle.SetRegistered();
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x000E47D0 File Offset: 0x000E29D0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x000E47E0 File Offset: 0x000E29E0
		private void RpcWriter___Observers_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteBoolean(playerOwned);
			base.SendObserversRpc(0U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x000E4896 File Offset: 0x000E2A96
		public void RpcLogic___SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			this.IsPlayerOwned = playerOwned;
			if (base.GetComponent<StorageEntity>() != null)
			{
				base.GetComponent<StorageEntity>().AccessSettings = (playerOwned ? StorageEntity.EAccessSettings.Full : StorageEntity.EAccessSettings.Closed);
			}
			this.RefreshPoI();
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x000E48C8 File Offset: 0x000E2AC8
		private void RpcReader___Observers_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
			bool playerOwned = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetIsPlayerOwned_214505783(null, playerOwned);
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x000E4904 File Offset: 0x000E2B04
		private void RpcWriter___Target_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteBoolean(playerOwned);
			base.SendTargetRpc(1U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x000E49BC File Offset: 0x000E2BBC
		private void RpcReader___Target_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
			bool playerOwned = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetIsPlayerOwned_214505783(base.LocalConnection, playerOwned);
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x000E49F4 File Offset: 0x000E2BF4
		private void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteNetworkConnection(conn);
			base.SendServerRpc(2U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x000E4A9B File Offset: 0x000E2C9B
		protected virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn)
		{
			base.NetworkObject.GiveOwnership(conn);
			this.OnOwnerChanged();
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x000E4AB0 File Offset: 0x000E2CB0
		private void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkConnection conn2 = PooledReader0.ReadNetworkConnection();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SetOwner_328543758(conn2);
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x000E4AE4 File Offset: 0x000E2CE4
		private void RpcWriter___Observers_OnOwnerChanged_2166136261()
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x000E4B90 File Offset: 0x000E2D90
		protected virtual void RpcLogic___OnOwnerChanged_2166136261()
		{
			if (base.NetworkObject.Owner == base.LocalConnection || (base.NetworkObject.OwnerId == -1 && InstanceFinder.IsHost))
			{
				Console.Log("Local client owns vehicle", null);
				this.rb.isKinematic = false;
				this.rb.interpolation = 1;
				base.GetComponent<NetworkTransform>().ClearReplicateCache();
				base.GetComponent<NetworkTransform>().ForceSend();
				return;
			}
			Console.Log("Local client no longer owns vehicle", null);
			if (!InstanceFinder.IsHost || (InstanceFinder.IsHost && !this.localPlayerIsDriver && this.CurrentPlayerOccupancy > 0))
			{
				this.rb.interpolation = 0;
				Debug.Log("No interpolation");
				this.rb.isKinematic = false;
				this.rb.isKinematic = true;
			}
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x000E4C5C File Offset: 0x000E2E5C
		private void RpcReader___Observers_OnOwnerChanged_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___OnOwnerChanged_2166136261();
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x000E4C7C File Offset: 0x000E2E7C
		private void RpcWriter___Server_SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteVector3(pos);
			writer.WriteQuaternion(rot, AutoPackType.Packed);
			base.SendServerRpc(4U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x000E4D35 File Offset: 0x000E2F35
		public void RpcLogic___SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
			this.SetTransform(pos, rot);
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x000E4D40 File Offset: 0x000E2F40
		private void RpcReader___Server_SetTransform_Server_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			Vector3 pos = PooledReader0.ReadVector3();
			Quaternion rot = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetTransform_Server_3848837105(pos, rot);
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x000E4D94 File Offset: 0x000E2F94
		private void RpcWriter___Observers_SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteVector3(pos);
			writer.WriteQuaternion(rot, AutoPackType.Packed);
			base.SendObserversRpc(5U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x000E4E5C File Offset: 0x000E305C
		public void RpcLogic___SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
			base.transform.position = pos;
			base.transform.rotation = rot;
			this.rb.position = pos;
			this.rb.rotation = rot;
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x000E4E90 File Offset: 0x000E3090
		private void RpcReader___Observers_SetTransform_3848837105(PooledReader PooledReader0, Channel channel)
		{
			Vector3 pos = PooledReader0.ReadVector3();
			Quaternion rot = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetTransform_3848837105(pos, rot);
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x000E4EE4 File Offset: 0x000E30E4
		private void RpcWriter___Server_SetSteeringAngle_431000436(float sa)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteSingle(sa, AutoPackType.Unpacked);
			base.SendServerRpc(6U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x000E4F90 File Offset: 0x000E3190
		private void RpcLogic___SetSteeringAngle_431000436(float sa)
		{
			this.sync___set_value_currentSteerAngle(sa, true);
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x000E4F9C File Offset: 0x000E319C
		private void RpcReader___Server_SetSteeringAngle_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			float sa = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SetSteeringAngle_431000436(sa);
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x000E4FD4 File Offset: 0x000E31D4
		private void RpcWriter___Observers_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(seatIndex, AutoPackType.Packed);
			writer.WriteNetworkConnection(occupant);
			base.SendObserversRpc(7U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x000E509C File Offset: 0x000E329C
		private void RpcLogic___SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			Player occupant2 = this.Seats[seatIndex].Occupant;
			this.Seats[seatIndex].Occupant = Player.GetPlayer(occupant);
			occupant != null;
			if (seatIndex == 0)
			{
				if (occupant != null)
				{
					if (this.onVehicleStart != null)
					{
						this.onVehicleStart.Invoke();
					}
				}
				else if (this.onVehicleStop != null)
				{
					this.onVehicleStop.Invoke();
				}
			}
			if (occupant != null)
			{
				if (this.onPlayerEnterVehicle != null)
				{
					this.onPlayerEnterVehicle(this.Seats[seatIndex].Occupant);
				}
			}
			else if (this.onPlayerExitVehicle != null)
			{
				this.onPlayerExitVehicle(occupant2);
			}
			this.isOccupied = (this.Seats.Count((VehicleSeat s) => s.isOccupied) > 0);
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x000E5178 File Offset: 0x000E3378
		private void RpcReader___Observers_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
			int seatIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			NetworkConnection occupant = PooledReader0.ReadNetworkConnection();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetSeatOccupant_3428404692(null, seatIndex, occupant);
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x000E51CC File Offset: 0x000E33CC
		private void RpcWriter___Target_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(seatIndex, AutoPackType.Packed);
			writer.WriteNetworkConnection(occupant);
			base.SendTargetRpc(8U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600366D RID: 13933 RVA: 0x000E5294 File Offset: 0x000E3494
		private void RpcReader___Target_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
			int seatIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			NetworkConnection occupant = PooledReader0.ReadNetworkConnection();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetSeatOccupant_3428404692(base.LocalConnection, seatIndex, occupant);
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x000E52E4 File Offset: 0x000E34E4
		private void RpcWriter___Server_SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(seatIndex, AutoPackType.Packed);
			writer.WriteNetworkConnection(conn);
			base.SendServerRpc(9U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x000E539D File Offset: 0x000E359D
		private void RpcLogic___SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
			this.SetSeatOccupant(null, seatIndex, conn);
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x000E53A8 File Offset: 0x000E35A8
		private void RpcReader___Server_SetSeatOccupant_Server_3266232555(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int seatIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			NetworkConnection conn2 = PooledReader0.ReadNetworkConnection();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetSeatOccupant_Server_3266232555(seatIndex, conn2);
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x000E53FC File Offset: 0x000E35FC
		private void RpcWriter___Server_SendOwnedColor_911055161(EVehicleColor col)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.Write___ScheduleOne.Vehicles.Modification.EVehicleColorFishNet.Serializing.Generated(col);
			base.SendServerRpc(10U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x000E54A3 File Offset: 0x000E36A3
		public void RpcLogic___SendOwnedColor_911055161(EVehicleColor col)
		{
			this.SetOwnedColor(null, col);
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x000E54B0 File Offset: 0x000E36B0
		private void RpcReader___Server_SendOwnedColor_911055161(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			EVehicleColor col = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Vehicles.Modification.EVehicleColorFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendOwnedColor_911055161(col);
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x000E54F0 File Offset: 0x000E36F0
		private void RpcWriter___Target_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.Write___ScheduleOne.Vehicles.Modification.EVehicleColorFishNet.Serializing.Generated(col);
			base.SendTargetRpc(11U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x000E55A5 File Offset: 0x000E37A5
		protected virtual void RpcLogic___SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			this.OwnedColor = col;
			this.ApplyOwnedColor();
			this.RefreshPoI();
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x000E55BC File Offset: 0x000E37BC
		private void RpcReader___Target_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
			EVehicleColor col = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Vehicles.Modification.EVehicleColorFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetOwnedColor_1679996372(base.LocalConnection, col);
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x000E55F4 File Offset: 0x000E37F4
		private void RpcWriter___Observers_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.Write___ScheduleOne.Vehicles.Modification.EVehicleColorFishNet.Serializing.Generated(col);
			base.SendObserversRpc(12U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x000E56AC File Offset: 0x000E38AC
		private void RpcReader___Observers_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
			EVehicleColor col = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Vehicles.Modification.EVehicleColorFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetOwnedColor_1679996372(null, col);
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x000E56E8 File Offset: 0x000E38E8
		private void RpcWriter___Observers_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.Write___ScheduleOne.Vehicles.ParkDataFishNet.Serializing.Generated(parkData);
			base.SendObserversRpc(13U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x000E579E File Offset: 0x000E399E
		private void RpcLogic___Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			this.Park(conn, parkData, false);
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x000E57AC File Offset: 0x000E39AC
		private void RpcReader___Observers_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
			ParkData parkData = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Vehicles.ParkDataFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Park_Networked_2633993806(null, parkData);
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x000E57E8 File Offset: 0x000E39E8
		private void RpcWriter___Target_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.Write___ScheduleOne.Vehicles.ParkDataFishNet.Serializing.Generated(parkData);
			base.SendTargetRpc(14U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x000E58A0 File Offset: 0x000E3AA0
		private void RpcReader___Target_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
			ParkData parkData = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Vehicles.ParkDataFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Park_Networked_2633993806(base.LocalConnection, parkData);
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x000E58D8 File Offset: 0x000E3AD8
		private void RpcWriter___Observers_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteBoolean(moveToExitPoint);
			base.SendObserversRpc(15U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x000E598E File Offset: 0x000E3B8E
		public void RpcLogic___ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			this.ExitPark(moveToExitPoint);
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x000E5998 File Offset: 0x000E3B98
		private void RpcReader___Observers_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
			bool moveToExitPoint = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ExitPark_Networked_214505783(null, moveToExitPoint);
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x000E59D4 File Offset: 0x000E3BD4
		private void RpcWriter___Target_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteBoolean(moveToExitPoint);
			base.SendTargetRpc(16U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x000E5A8C File Offset: 0x000E3C8C
		private void RpcReader___Target_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
			bool moveToExitPoint = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ExitPark_Networked_214505783(base.LocalConnection, moveToExitPoint);
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06003683 RID: 13955 RVA: 0x000E5AC3 File Offset: 0x000E3CC3
		// (set) Token: 0x06003684 RID: 13956 RVA: 0x000E5ACB File Offset: 0x000E3CCB
		public float SyncAccessor_currentSteerAngle
		{
			get
			{
				return this.currentSteerAngle;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.currentSteerAngle = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___currentSteerAngle.SetValue(value, value);
				}
			}
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x000E5B08 File Offset: 0x000E3D08
		public virtual bool LandVehicle(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 2U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<isReversing>k__BackingField(this.syncVar___<isReversing>k__BackingField.GetValue(true), true);
					return true;
				}
				bool value = PooledReader0.ReadBoolean();
				this.sync___set_value_<isReversing>k__BackingField(value, Boolean2);
				return true;
			}
			else if (UInt321 == 1U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<brakesApplied>k__BackingField(this.syncVar___<brakesApplied>k__BackingField.GetValue(true), true);
					return true;
				}
				bool value2 = PooledReader0.ReadBoolean();
				this.sync___set_value_<brakesApplied>k__BackingField(value2, Boolean2);
				return true;
			}
			else
			{
				if (UInt321 != 0U)
				{
					return false;
				}
				if (PooledReader0 == null)
				{
					this.sync___set_value_currentSteerAngle(this.syncVar___currentSteerAngle.GetValue(true), true);
					return true;
				}
				float value3 = PooledReader0.ReadSingle(AutoPackType.Unpacked);
				this.sync___set_value_currentSteerAngle(value3, Boolean2);
				return true;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06003686 RID: 13958 RVA: 0x000E5BE7 File Offset: 0x000E3DE7
		// (set) Token: 0x06003687 RID: 13959 RVA: 0x000E5BEF File Offset: 0x000E3DEF
		public bool SyncAccessor_<brakesApplied>k__BackingField
		{
			get
			{
				return this.<brakesApplied>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<brakesApplied>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<brakesApplied>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06003688 RID: 13960 RVA: 0x000E5C2B File Offset: 0x000E3E2B
		// (set) Token: 0x06003689 RID: 13961 RVA: 0x000E5C33 File Offset: 0x000E3E33
		public bool SyncAccessor_<isReversing>k__BackingField
		{
			get
			{
				return this.<isReversing>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<isReversing>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<isReversing>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x000E5C70 File Offset: 0x000E3E70
		protected virtual void dll()
		{
			this.OccupantNPCs = new NPC[this.Seats.Length];
			this.boundingBox.gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");
			for (int i = 0; i < this.driveWheels.Length; i++)
			{
				this.wheels.Add(this.driveWheels[i].GetComponent<Wheel>());
			}
			for (int j = 0; j < this.steerWheels.Length; j++)
			{
				if (!this.wheels.Contains(this.steerWheels[j].GetComponent<Wheel>()))
				{
					this.wheels.Add(this.steerWheels[j].GetComponent<Wheel>());
				}
			}
			this.OwnedColor = this.DefaultColor;
			this.InitializeSaveable();
			if (base.GetComponent<StorageEntity>() != null)
			{
				base.GetComponent<StorageEntity>().AccessSettings = StorageEntity.EAccessSettings.Closed;
			}
			this.SetObstaclesActive(true);
			this.RefreshPoI();
		}

		// Token: 0x040026B2 RID: 9906
		public const float KINEMATIC_THRESHOLD_DISTANCE = 30f;

		// Token: 0x040026B3 RID: 9907
		public const float MAX_TURNOVER_SPEED = 5f;

		// Token: 0x040026B4 RID: 9908
		public const float TURNOVER_FORCE = 8f;

		// Token: 0x040026B5 RID: 9909
		public const bool USE_WHEEL = false;

		// Token: 0x040026B6 RID: 9910
		public const float SPEED_DISPLAY_MULTIPLIER = 1.4f;

		// Token: 0x040026B7 RID: 9911
		public bool DEBUG;

		// Token: 0x040026B8 RID: 9912
		[Header("Settings")]
		[SerializeField]
		protected string vehicleName = "Vehicle";

		// Token: 0x040026B9 RID: 9913
		[SerializeField]
		protected string vehicleCode = "vehicle_code";

		// Token: 0x040026BA RID: 9914
		[SerializeField]
		protected float vehiclePrice = 1000f;

		// Token: 0x040026BD RID: 9917
		public bool UseHumanoidCollider = true;

		// Token: 0x040026BF RID: 9919
		public bool SpawnAsPlayerOwned;

		// Token: 0x040026C1 RID: 9921
		[Header("References")]
		[SerializeField]
		protected GameObject vehicleModel;

		// Token: 0x040026C2 RID: 9922
		[SerializeField]
		protected WheelCollider[] driveWheels;

		// Token: 0x040026C3 RID: 9923
		[SerializeField]
		protected WheelCollider[] steerWheels;

		// Token: 0x040026C4 RID: 9924
		[SerializeField]
		protected WheelCollider[] handbrakeWheels;

		// Token: 0x040026C5 RID: 9925
		[HideInInspector]
		public List<Wheel> wheels = new List<Wheel>();

		// Token: 0x040026C6 RID: 9926
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x040026C7 RID: 9927
		[SerializeField]
		protected List<Transform> exitPoints = new List<Transform>();

		// Token: 0x040026C8 RID: 9928
		[SerializeField]
		protected Rigidbody rb;

		// Token: 0x040026C9 RID: 9929
		public VehicleSeat[] Seats;

		// Token: 0x040026CA RID: 9930
		public BoxCollider boundingBox;

		// Token: 0x040026CB RID: 9931
		public VehicleAgent Agent;

		// Token: 0x040026CC RID: 9932
		public SmoothedVelocityCalculator VelocityCalculator;

		// Token: 0x040026CD RID: 9933
		public StorageDoorAnimation Trunk;

		// Token: 0x040026CE RID: 9934
		public NavMeshObstacle NavMeshObstacle;

		// Token: 0x040026CF RID: 9935
		public NavmeshCut NavmeshCut;

		// Token: 0x040026D0 RID: 9936
		public VehicleHumanoidCollider HumanoidColliderContainer;

		// Token: 0x040026D1 RID: 9937
		public POI POI;

		// Token: 0x040026D2 RID: 9938
		[SerializeField]
		protected Transform centerOfMass;

		// Token: 0x040026D3 RID: 9939
		[SerializeField]
		protected Transform cameraOrigin;

		// Token: 0x040026D4 RID: 9940
		[SerializeField]
		protected VehicleLights lights;

		// Token: 0x040026D5 RID: 9941
		[Header("Steer settings")]
		[SerializeField]
		protected float maxSteeringAngle = 25f;

		// Token: 0x040026D6 RID: 9942
		[SerializeField]
		protected float steerRate = 50f;

		// Token: 0x040026D7 RID: 9943
		[SerializeField]
		protected bool flipSteer;

		// Token: 0x040026DA RID: 9946
		[Header("Drive settings")]
		[SerializeField]
		protected AnimationCurve motorTorque = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 200f),
			new Keyframe(50f, 300f),
			new Keyframe(200f, 0f)
		});

		// Token: 0x040026DB RID: 9947
		public float TopSpeed = 60f;

		// Token: 0x040026DC RID: 9948
		[Range(2f, 16f)]
		[SerializeField]
		protected float diffGearing = 4f;

		// Token: 0x040026DD RID: 9949
		[SerializeField]
		protected float handBrakeForce = 300f;

		// Token: 0x040026DE RID: 9950
		[SerializeField]
		protected AnimationCurve brakeForce = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 200f),
			new Keyframe(50f, 300f),
			new Keyframe(200f, 0f)
		});

		// Token: 0x040026DF RID: 9951
		[Range(0.5f, 10f)]
		[SerializeField]
		protected float downforce = 1f;

		// Token: 0x040026E0 RID: 9952
		[Range(0f, 1f)]
		[SerializeField]
		protected float reverseMultiplier = 0.35f;

		// Token: 0x040026E1 RID: 9953
		[Header("Color Settings")]
		[SerializeField]
		protected LandVehicle.BodyMesh[] BodyMeshes;

		// Token: 0x040026E2 RID: 9954
		public EVehicleColor DefaultColor = EVehicleColor.White;

		// Token: 0x040026E4 RID: 9956
		private EVehicleColor DisplayedColor = EVehicleColor.White;

		// Token: 0x040026E5 RID: 9957
		[Header("Outline settings")]
		[SerializeField]
		protected List<GameObject> outlineRenderers = new List<GameObject>();

		// Token: 0x040026E6 RID: 9958
		protected Outlinable outlineEffect;

		// Token: 0x040026E7 RID: 9959
		[Header("Control overrides")]
		public bool overrideControls;

		// Token: 0x040026E8 RID: 9960
		public float throttleOverride;

		// Token: 0x040026E9 RID: 9961
		public float steerOverride;

		// Token: 0x040026EA RID: 9962
		[Header("Storage settings")]
		public StorageEntity Storage;

		// Token: 0x040026EB RID: 9963
		private VehicleSeat localPlayerSeat;

		// Token: 0x040026F1 RID: 9969
		private List<float> previousSpeeds = new List<float>();

		// Token: 0x040026F2 RID: 9970
		private int previousSpeedsSampleSize = 20;

		// Token: 0x040026F4 RID: 9972
		[SyncVar(Channel = Channel.Unreliable, SendRate = 0.05f, WritePermissions = WritePermission.ClientUnsynchronized)]
		public float currentSteerAngle;

		// Token: 0x040026F5 RID: 9973
		private float lastFrameSteerAngle;

		// Token: 0x040026F6 RID: 9974
		private float lastReplicatedSteerAngle;

		// Token: 0x040026F7 RID: 9975
		private bool justExitedVehicle;

		// Token: 0x040026FC RID: 9980
		private Vector3 lastFramePosition = Vector3.zero;

		// Token: 0x040026FD RID: 9981
		private Transform closestExitPoint;

		// Token: 0x040026FE RID: 9982
		[HideInInspector]
		public ParkData CurrentParkData;

		// Token: 0x04002701 RID: 9985
		private VehicleLoader loader = new VehicleLoader();

		// Token: 0x04002705 RID: 9989
		public LandVehicle.VehiclePlayerEvent onPlayerEnterVehicle;

		// Token: 0x04002706 RID: 9990
		public LandVehicle.VehiclePlayerEvent onPlayerExitVehicle;

		// Token: 0x04002707 RID: 9991
		public UnityEvent onVehicleStart;

		// Token: 0x04002708 RID: 9992
		public UnityEvent onVehicleStop;

		// Token: 0x04002709 RID: 9993
		public UnityEvent onHandbrakeApplied;

		// Token: 0x0400270A RID: 9994
		public UnityEvent<Collision> onCollision = new UnityEvent<Collision>();

		// Token: 0x0400270B RID: 9995
		public SyncVar<float> syncVar___currentSteerAngle;

		// Token: 0x0400270C RID: 9996
		public SyncVar<bool> syncVar___<brakesApplied>k__BackingField;

		// Token: 0x0400270D RID: 9997
		public SyncVar<bool> syncVar___<isReversing>k__BackingField;

		// Token: 0x0400270E RID: 9998
		private bool dll_Excuted;

		// Token: 0x0400270F RID: 9999
		private bool dll_Excuted;

		// Token: 0x020007C5 RID: 1989
		[Serializable]
		public class BodyMesh
		{
			// Token: 0x04002710 RID: 10000
			public MeshRenderer Renderer;

			// Token: 0x04002711 RID: 10001
			public int MaterialIndex;
		}

		// Token: 0x020007C6 RID: 1990
		// (Invoke) Token: 0x0600368D RID: 13965
		public delegate void VehiclePlayerEvent(Player player);
	}
}
