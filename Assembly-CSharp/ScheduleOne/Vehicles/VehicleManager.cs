using System;
using System.Collections.Generic;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007D9 RID: 2009
	public class VehicleManager : NetworkSingleton<VehicleManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060036ED RID: 14061 RVA: 0x000E756C File Offset: 0x000E576C
		public string SaveFolderName
		{
			get
			{
				return "OwnedVehicles";
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060036EE RID: 14062 RVA: 0x000E756C File Offset: 0x000E576C
		public string SaveFileName
		{
			get
			{
				return "OwnedVehicles";
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060036EF RID: 14063 RVA: 0x000E7573 File Offset: 0x000E5773
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060036F1 RID: 14065 RVA: 0x000E757B File Offset: 0x000E577B
		// (set) Token: 0x060036F2 RID: 14066 RVA: 0x000E7583 File Offset: 0x000E5783
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060036F3 RID: 14067 RVA: 0x000E758C File Offset: 0x000E578C
		// (set) Token: 0x060036F4 RID: 14068 RVA: 0x000E7594 File Offset: 0x000E5794
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060036F5 RID: 14069 RVA: 0x000E759D File Offset: 0x000E579D
		// (set) Token: 0x060036F6 RID: 14070 RVA: 0x000E75A5 File Offset: 0x000E57A5
		public bool HasChanged { get; set; }

		// Token: 0x060036F7 RID: 14071 RVA: 0x000E75AE File Offset: 0x000E57AE
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Vehicles.VehicleManager_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x000E75C2 File Offset: 0x000E57C2
		[ServerRpc(RequireOwnership = false)]
		public void SpawnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
			this.RpcWriter___Server_SpawnVehicle_3323115898(vehicleCode, position, rotation, playerOwned);
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x000E75DC File Offset: 0x000E57DC
		public LandVehicle SpawnAndReturnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
			LandVehicle vehiclePrefab = this.GetVehiclePrefab(vehicleCode);
			if (vehiclePrefab == null)
			{
				Console.LogError("SpawnVehicle: '" + vehicleCode + "' is not a valid vehicle code!", null);
				return null;
			}
			LandVehicle component = Object.Instantiate<GameObject>(vehiclePrefab.gameObject).GetComponent<LandVehicle>();
			component.transform.position = position;
			component.transform.rotation = rotation;
			base.NetworkObject.Spawn(component.gameObject, null, default(Scene));
			component.SetIsPlayerOwned(null, playerOwned);
			if (playerOwned)
			{
				this.PlayerOwnedVehicles.Add(component);
			}
			return component;
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x000E7670 File Offset: 0x000E5870
		public LandVehicle GetVehiclePrefab(string vehicleCode)
		{
			return this.VehiclePrefabs.Find((LandVehicle x) => x.VehicleCode.ToLower() == vehicleCode.ToLower());
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x000E76A1 File Offset: 0x000E58A1
		public LandVehicle SpawnAndLoadVehicle(VehicleData data, string path, bool playerOwned)
		{
			LandVehicle landVehicle = this.SpawnAndReturnVehicle(data.VehicleCode, data.Position, data.Rotation, playerOwned);
			landVehicle.Load(data, path);
			return landVehicle;
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x000E76C4 File Offset: 0x000E58C4
		public void LoadVehicle(VehicleData data, string path)
		{
			LandVehicle @object = GUIDManager.GetObject<LandVehicle>(new Guid(data.GUID));
			if (@object == null)
			{
				Console.LogError("LoadVehicle: Vehicle not found with GUID " + data.GUID, null);
				return;
			}
			@object.Load(data, path);
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x0003CEED File Offset: 0x0003B0ED
		public virtual string GetSaveString()
		{
			return string.Empty;
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x000E770C File Offset: 0x000E590C
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			string containerFolder = ((ISaveable)this).GetContainerFolder(parentFolderPath);
			for (int i = 0; i < this.PlayerOwnedVehicles.Count; i++)
			{
				new SaveRequest(this.PlayerOwnedVehicles[i], containerFolder);
				list.Add(this.PlayerOwnedVehicles[i].SaveFolderName);
			}
			return list;
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x000E7768 File Offset: 0x000E5968
		public void SpawnLoanSharkVehicle(Vector3 position, Quaternion rot)
		{
			LandVehicle landVehicle = NetworkSingleton<VehicleManager>.Instance.SpawnAndReturnVehicle("shitbox", position, rot, true);
			this.EnableLoanSharkVisuals(landVehicle.NetworkObject);
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x000E7794 File Offset: 0x000E5994
		[ObserversRpc(RunLocally = true)]
		private void EnableLoanSharkVisuals(NetworkObject veh)
		{
			this.RpcWriter___Observers_EnableLoanSharkVisuals_3323014238(veh);
			this.RpcLogic___EnableLoanSharkVisuals_3323014238(veh);
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x000E7804 File Offset: 0x000E5A04
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SpawnVehicle_3323115898));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_EnableLoanSharkVisuals_3323014238));
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x000E7856 File Offset: 0x000E5A56
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Vehicles.VehicleManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Vehicles.VehicleManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x000E786F File Offset: 0x000E5A6F
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x000E7880 File Offset: 0x000E5A80
		private void RpcWriter___Server_SpawnVehicle_3323115898(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
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
			writer.WriteString(vehicleCode);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.WriteBoolean(playerOwned);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x000E7953 File Offset: 0x000E5B53
		public void RpcLogic___SpawnVehicle_3323115898(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
			this.SpawnAndReturnVehicle(vehicleCode, position, rotation, playerOwned);
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x000E7964 File Offset: 0x000E5B64
		private void RpcReader___Server_SpawnVehicle_3323115898(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string vehicleCode = PooledReader0.ReadString();
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			bool playerOwned = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SpawnVehicle_3323115898(vehicleCode, position, rotation, playerOwned);
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x000E79D0 File Offset: 0x000E5BD0
		private void RpcWriter___Observers_EnableLoanSharkVisuals_3323014238(NetworkObject veh)
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
			writer.WriteNetworkObject(veh);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x000E7A86 File Offset: 0x000E5C86
		private void RpcLogic___EnableLoanSharkVisuals_3323014238(NetworkObject veh)
		{
			if (veh == null)
			{
				Console.LogWarning("Vehicle not found", null);
				return;
			}
			veh.GetComponent<LoanSharkCarVisuals>().Configure(true, true);
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x000E7AAC File Offset: 0x000E5CAC
		private void RpcReader___Observers_EnableLoanSharkVisuals_3323014238(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject veh = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___EnableLoanSharkVisuals_3323014238(veh);
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x000E7AE7 File Offset: 0x000E5CE7
		protected virtual void dll()
		{
			base.Awake();
			this.InitializeSaveable();
		}

		// Token: 0x04002779 RID: 10105
		public List<LandVehicle> AllVehicles = new List<LandVehicle>();

		// Token: 0x0400277A RID: 10106
		[Header("Vehicles")]
		public List<LandVehicle> VehiclePrefabs = new List<LandVehicle>();

		// Token: 0x0400277B RID: 10107
		public List<LandVehicle> PlayerOwnedVehicles = new List<LandVehicle>();

		// Token: 0x0400277C RID: 10108
		private VehiclesLoader loader = new VehiclesLoader();

		// Token: 0x04002780 RID: 10112
		private bool dll_Excuted;

		// Token: 0x04002781 RID: 10113
		private bool dll_Excuted;
	}
}
