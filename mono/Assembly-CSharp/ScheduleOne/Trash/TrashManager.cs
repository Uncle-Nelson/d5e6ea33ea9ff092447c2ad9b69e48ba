using System;
using System.Collections.Generic;
using System.Linq;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x02000836 RID: 2102
	public class TrashManager : NetworkSingleton<TrashManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060039B9 RID: 14777 RVA: 0x000F3C44 File Offset: 0x000F1E44
		public string SaveFolderName
		{
			get
			{
				return "Trash";
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060039BA RID: 14778 RVA: 0x000F3C44 File Offset: 0x000F1E44
		public string SaveFileName
		{
			get
			{
				return "Trash";
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060039BB RID: 14779 RVA: 0x000F3C4B File Offset: 0x000F1E4B
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060039BC RID: 14780 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060039BD RID: 14781 RVA: 0x000F3C53 File Offset: 0x000F1E53
		// (set) Token: 0x060039BE RID: 14782 RVA: 0x000F3C5B File Offset: 0x000F1E5B
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060039BF RID: 14783 RVA: 0x000F3C64 File Offset: 0x000F1E64
		// (set) Token: 0x060039C0 RID: 14784 RVA: 0x000F3C6C File Offset: 0x000F1E6C
		public List<string> LocalExtraFolders { get; set; } = new List<string>
		{
			"Generators"
		};

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060039C1 RID: 14785 RVA: 0x000F3C75 File Offset: 0x000F1E75
		// (set) Token: 0x060039C2 RID: 14786 RVA: 0x000F3C7D File Offset: 0x000F1E7D
		public bool HasChanged { get; set; }

		// Token: 0x060039C3 RID: 14787 RVA: 0x000F3C86 File Offset: 0x000F1E86
		protected override void Start()
		{
			base.Start();
			this.InitializeSaveable();
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x000F3C94 File Offset: 0x000F1E94
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			Console.Log("Sending " + this.trashItems.Count.ToString() + " trash items to new player", null);
			foreach (TrashItem trashItem in this.trashItems)
			{
				this.CreateTrashItem(connection, trashItem.ID, trashItem.transform.position, trashItem.transform.rotation, Vector3.zero, null, trashItem.GUID.ToString(), false);
			}
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x000F3D50 File Offset: 0x000F1F50
		public void ReplicateTransformData(TrashItem trash)
		{
			this.SendTransformData(trash.GUID.ToString(), trash.transform.position, trash.transform.rotation, trash.Rigidbody.velocity, Player.Local.LocalConnection);
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x000F3DA2 File Offset: 0x000F1FA2
		[ServerRpc(RequireOwnership = false)]
		private void SendTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			this.RpcWriter___Server_SendTransformData_2990100769(guid, position, rotation, velocity, sender);
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x000F3DC0 File Offset: 0x000F1FC0
		[ObserversRpc]
		private void ReceiveTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			this.RpcWriter___Observers_ReceiveTransformData_2990100769(guid, position, rotation, velocity, sender);
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x000F3DE8 File Offset: 0x000F1FE8
		public TrashItem CreateTrashItem(string id, Vector3 posiiton, Quaternion rotation, Vector3 initialVelocity = default(Vector3), string guid = "", bool startKinematic = false)
		{
			if (guid == "")
			{
				guid = Guid.NewGuid().ToString();
			}
			this.SendTrashItem(id, posiiton, rotation, initialVelocity, Player.Local.LocalConnection, guid, false);
			return this.CreateAndReturnTrashItem(id, posiiton, rotation, initialVelocity, guid, startKinematic);
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x000F3E40 File Offset: 0x000F2040
		[ServerRpc(RequireOwnership = false)]
		private void SendTrashItem(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			this.RpcWriter___Server_SendTrashItem_478112418(id, position, rotation, initialVelocity, sender, guid, startKinematic);
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x000F3E70 File Offset: 0x000F2070
		[ObserversRpc]
		[TargetRpc]
		private void CreateTrashItem(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_CreateTrashItem_2385526393(conn, id, position, rotation, initialVelocity, sender, guid, startKinematic);
			}
			else
			{
				this.RpcWriter___Target_CreateTrashItem_2385526393(conn, id, position, rotation, initialVelocity, sender, guid, startKinematic);
			}
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x000F3ED4 File Offset: 0x000F20D4
		private TrashItem CreateAndReturnTrashItem(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, string guid, bool startKinematic)
		{
			TrashItem trashPrefab = this.GetTrashPrefab(id);
			if (trashPrefab == null)
			{
				Debug.LogError("Trash item with ID " + id + " not found.");
				return null;
			}
			if (GUIDManager.IsGUIDAlreadyRegistered(new Guid(guid)))
			{
				return null;
			}
			trashPrefab.Draggable.CreateCoM = false;
			trashPrefab.GetComponent<PhysicsDamageable>().ForceMultiplier = this.TrashForceMultiplier;
			TrashItem trashItem = Object.Instantiate<TrashItem>(trashPrefab, position, rotation, NetworkSingleton<GameManager>.Instance.Temp);
			trashItem.SetGUID(new Guid(guid));
			if (!startKinematic)
			{
				trashItem.SetContinuousCollisionDetection();
			}
			if (initialVelocity != default(Vector3))
			{
				trashItem.SetVelocity(initialVelocity);
			}
			this.trashItems.Add(trashItem);
			this.HasChanged = true;
			return trashItem;
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x000F3F90 File Offset: 0x000F2190
		public TrashItem CreateTrashBag(string id, Vector3 posiiton, Quaternion rotation, TrashContentData content, Vector3 initialVelocity = default(Vector3), string guid = "", bool startKinematic = false)
		{
			if (guid == "")
			{
				guid = Guid.NewGuid().ToString();
			}
			this.SendTrashBag(id, posiiton, rotation, content, initialVelocity, Player.Local.LocalConnection, guid, false);
			return this.CreateAndReturnTrashBag(id, posiiton, rotation, content, initialVelocity, guid, startKinematic);
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x000F3FEC File Offset: 0x000F21EC
		[ServerRpc(RequireOwnership = false)]
		private void SendTrashBag(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			this.RpcWriter___Server_SendTrashBag_3965031115(id, position, rotation, content, initialVelocity, sender, guid, startKinematic);
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x000F4020 File Offset: 0x000F2220
		[ObserversRpc]
		[TargetRpc]
		private void CreateTrashBag(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_CreateTrashBag_680856992(conn, id, position, rotation, content, initialVelocity, sender, guid, startKinematic);
			}
			else
			{
				this.RpcWriter___Target_CreateTrashBag_680856992(conn, id, position, rotation, content, initialVelocity, sender, guid, startKinematic);
			}
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x000F408C File Offset: 0x000F228C
		private TrashItem CreateAndReturnTrashBag(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, string guid, bool startKinematic)
		{
			TrashBag trashBag = this.GetTrashPrefab(id) as TrashBag;
			if (trashBag == null)
			{
				Debug.LogError("Trash item with ID " + id + " not found.");
				return null;
			}
			TrashBag trashBag2 = Object.Instantiate<TrashBag>(trashBag, position, rotation, NetworkSingleton<GameManager>.Instance.Temp);
			trashBag2.SetGUID(new Guid(guid));
			trashBag2.LoadContent(content);
			if (!startKinematic)
			{
				trashBag2.SetContinuousCollisionDetection();
			}
			if (initialVelocity != default(Vector3))
			{
				trashBag2.SetVelocity(initialVelocity);
			}
			this.trashItems.Add(trashBag2);
			this.HasChanged = true;
			return trashBag2;
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x000F4128 File Offset: 0x000F2328
		public void DestroyAllTrash()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			List<TrashItem> list = new List<TrashItem>();
			list.AddRange(this.trashItems);
			for (int i = 0; i < list.Count; i++)
			{
				list[i].DestroyTrash();
			}
		}

		// Token: 0x060039D2 RID: 14802 RVA: 0x000F416C File Offset: 0x000F236C
		public void DestroyTrash(TrashItem trash)
		{
			this.SendDestroyTrash(trash.GUID.ToString());
		}

		// Token: 0x060039D3 RID: 14803 RVA: 0x000F4193 File Offset: 0x000F2393
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendDestroyTrash(string guid)
		{
			this.RpcWriter___Server_SendDestroyTrash_3615296227(guid);
			this.RpcLogic___SendDestroyTrash_3615296227(guid);
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x000F41AC File Offset: 0x000F23AC
		[ObserversRpc(RunLocally = true)]
		private void DestroyTrash(string guid)
		{
			this.RpcWriter___Observers_DestroyTrash_3615296227(guid);
			this.RpcLogic___DestroyTrash_3615296227(guid);
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x000F41D0 File Offset: 0x000F23D0
		public TrashItem GetTrashPrefab(string id)
		{
			return this.TrashPrefabs.FirstOrDefault((TrashItem t) => t.ID == id);
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x000F4204 File Offset: 0x000F2404
		public TrashItem GetRandomGeneratableTrashPrefab()
		{
			float maxInclusive = this.GenerateableTrashItems.Sum((TrashManager.TrashItemData t) => t.GenerationChance);
			float num = Random.Range(0f, maxInclusive);
			foreach (TrashManager.TrashItemData trashItemData in this.GenerateableTrashItems)
			{
				if (num < trashItemData.GenerationChance)
				{
					return trashItemData.Item;
				}
				num -= trashItemData.GenerationChance;
			}
			return this.GenerateableTrashItems[this.GenerateableTrashItems.Length - 1].Item;
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x000F4294 File Offset: 0x000F2494
		public virtual string GetSaveString()
		{
			List<ScheduleOne.Persistence.Datas.TrashItemData> list = new List<ScheduleOne.Persistence.Datas.TrashItemData>();
			int num = 0;
			while (num < this.trashItems.Count && num < 2000)
			{
				list.Add(this.trashItems[num].GetData());
				num++;
			}
			return new TrashData(list.ToArray()).GetJson(true);
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x000F42F0 File Offset: 0x000F24F0
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> result = new List<string>();
			string parentFolderPath2 = ((ISaveable)this).WriteFolder(parentFolderPath, "Generators");
			foreach (TrashGenerator trashGenerator in TrashGenerator.AllGenerators)
			{
				if (trashGenerator.ShouldSave() && trashGenerator.HasChanged)
				{
					new SaveRequest(trashGenerator, parentFolderPath2);
				}
			}
			return result;
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x000F43C8 File Offset: 0x000F25C8
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Trash.TrashManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Trash.TrashManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendTransformData_2990100769));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveTransformData_2990100769));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_SendTrashItem_478112418));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_CreateTrashItem_2385526393));
			base.RegisterTargetRpc(4U, new ClientRpcDelegate(this.RpcReader___Target_CreateTrashItem_2385526393));
			base.RegisterServerRpc(5U, new ServerRpcDelegate(this.RpcReader___Server_SendTrashBag_3965031115));
			base.RegisterObserversRpc(6U, new ClientRpcDelegate(this.RpcReader___Observers_CreateTrashBag_680856992));
			base.RegisterTargetRpc(7U, new ClientRpcDelegate(this.RpcReader___Target_CreateTrashBag_680856992));
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SendDestroyTrash_3615296227));
			base.RegisterObserversRpc(9U, new ClientRpcDelegate(this.RpcReader___Observers_DestroyTrash_3615296227));
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x000F44D2 File Offset: 0x000F26D2
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Trash.TrashManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Trash.TrashManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x000F44EB File Offset: 0x000F26EB
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x000F44FC File Offset: 0x000F26FC
		private void RpcWriter___Server_SendTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
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
			writer.WriteString(guid);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.WriteVector3(velocity);
			writer.WriteNetworkConnection(sender);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x000F45DC File Offset: 0x000F27DC
		private void RpcLogic___SendTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			this.ReceiveTransformData(guid, position, rotation, velocity, sender);
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x000F45EC File Offset: 0x000F27EC
		private void RpcReader___Server_SendTransformData_2990100769(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string guid = PooledReader0.ReadString();
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			Vector3 velocity = PooledReader0.ReadVector3();
			NetworkConnection sender = PooledReader0.ReadNetworkConnection();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendTransformData_2990100769(guid, position, rotation, velocity, sender);
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x000F4668 File Offset: 0x000F2868
		private void RpcWriter___Observers_ReceiveTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
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
			writer.WriteString(guid);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.WriteVector3(velocity);
			writer.WriteNetworkConnection(sender);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x000F4758 File Offset: 0x000F2958
		private void RpcLogic___ReceiveTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			if (sender.IsLocalClient)
			{
				return;
			}
			TrashItem @object = GUIDManager.GetObject<TrashItem>(new Guid(guid));
			if (@object == null)
			{
				return;
			}
			@object.transform.position = position;
			@object.transform.rotation = rotation;
			@object.Rigidbody.velocity = velocity;
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x000F47AC File Offset: 0x000F29AC
		private void RpcReader___Observers_ReceiveTransformData_2990100769(PooledReader PooledReader0, Channel channel)
		{
			string guid = PooledReader0.ReadString();
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			Vector3 velocity = PooledReader0.ReadVector3();
			NetworkConnection sender = PooledReader0.ReadNetworkConnection();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveTransformData_2990100769(guid, position, rotation, velocity, sender);
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x000F4828 File Offset: 0x000F2A28
		private void RpcWriter___Server_SendTrashItem_478112418(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
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
			writer.WriteString(id);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.WriteVector3(initialVelocity);
			writer.WriteNetworkConnection(sender);
			writer.WriteString(guid);
			writer.WriteBoolean(startKinematic);
			base.SendServerRpc(2U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x000F4924 File Offset: 0x000F2B24
		private void RpcLogic___SendTrashItem_478112418(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			if (this.trashItems.Count >= 2000)
			{
				this.trashItems[Random.Range(0, this.trashItems.Count)].DestroyTrash();
			}
			this.CreateTrashItem(null, id, position, rotation, initialVelocity, sender, guid, startKinematic);
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x000F4978 File Offset: 0x000F2B78
		private void RpcReader___Server_SendTrashItem_478112418(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string id = PooledReader0.ReadString();
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			Vector3 initialVelocity = PooledReader0.ReadVector3();
			NetworkConnection sender = PooledReader0.ReadNetworkConnection();
			string guid = PooledReader0.ReadString();
			bool startKinematic = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendTrashItem_478112418(id, position, rotation, initialVelocity, sender, guid, startKinematic);
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x000F4A14 File Offset: 0x000F2C14
		private void RpcWriter___Observers_CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
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
			writer.WriteString(id);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.WriteVector3(initialVelocity);
			writer.WriteNetworkConnection(sender);
			writer.WriteString(guid);
			writer.WriteBoolean(startKinematic);
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x000F4B1D File Offset: 0x000F2D1D
		private void RpcLogic___CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			if (sender.IsLocalClient)
			{
				return;
			}
			this.CreateAndReturnTrashItem(id, position, rotation, initialVelocity, guid, startKinematic);
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x000F4B3C File Offset: 0x000F2D3C
		private void RpcReader___Observers_CreateTrashItem_2385526393(PooledReader PooledReader0, Channel channel)
		{
			string id = PooledReader0.ReadString();
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			Vector3 initialVelocity = PooledReader0.ReadVector3();
			NetworkConnection sender = PooledReader0.ReadNetworkConnection();
			string guid = PooledReader0.ReadString();
			bool startKinematic = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___CreateTrashItem_2385526393(null, id, position, rotation, initialVelocity, sender, guid, startKinematic);
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x000F4BDC File Offset: 0x000F2DDC
		private void RpcWriter___Target_CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
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
			writer.WriteString(id);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.WriteVector3(initialVelocity);
			writer.WriteNetworkConnection(sender);
			writer.WriteString(guid);
			writer.WriteBoolean(startKinematic);
			base.SendTargetRpc(4U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x000F4CE4 File Offset: 0x000F2EE4
		private void RpcReader___Target_CreateTrashItem_2385526393(PooledReader PooledReader0, Channel channel)
		{
			string id = PooledReader0.ReadString();
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			Vector3 initialVelocity = PooledReader0.ReadVector3();
			NetworkConnection sender = PooledReader0.ReadNetworkConnection();
			string guid = PooledReader0.ReadString();
			bool startKinematic = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___CreateTrashItem_2385526393(base.LocalConnection, id, position, rotation, initialVelocity, sender, guid, startKinematic);
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x000F4D88 File Offset: 0x000F2F88
		private void RpcWriter___Server_SendTrashBag_3965031115(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
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
			writer.WriteString(id);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.Write___ScheduleOne.Persistence.TrashContentDataFishNet.Serializing.Generated(content);
			writer.WriteVector3(initialVelocity);
			writer.WriteNetworkConnection(sender);
			writer.WriteString(guid);
			writer.WriteBoolean(startKinematic);
			base.SendServerRpc(5U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x000F4E90 File Offset: 0x000F3090
		private void RpcLogic___SendTrashBag_3965031115(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			if (this.trashItems.Count >= 2000)
			{
				this.trashItems[Random.Range(0, this.trashItems.Count)].DestroyTrash();
			}
			this.CreateTrashBag(null, id, position, rotation, content, initialVelocity, sender, guid, startKinematic);
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x000F4EE4 File Offset: 0x000F30E4
		private void RpcReader___Server_SendTrashBag_3965031115(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string id = PooledReader0.ReadString();
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			TrashContentData content = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Persistence.TrashContentDataFishNet.Serializing.Generateds(PooledReader0);
			Vector3 initialVelocity = PooledReader0.ReadVector3();
			NetworkConnection sender = PooledReader0.ReadNetworkConnection();
			string guid = PooledReader0.ReadString();
			bool startKinematic = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendTrashBag_3965031115(id, position, rotation, content, initialVelocity, sender, guid, startKinematic);
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x000F4F94 File Offset: 0x000F3194
		private void RpcWriter___Observers_CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
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
			writer.WriteString(id);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.Write___ScheduleOne.Persistence.TrashContentDataFishNet.Serializing.Generated(content);
			writer.WriteVector3(initialVelocity);
			writer.WriteNetworkConnection(sender);
			writer.WriteString(guid);
			writer.WriteBoolean(startKinematic);
			base.SendObserversRpc(6U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x000F50AA File Offset: 0x000F32AA
		private void RpcLogic___CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			if (sender.IsLocalClient)
			{
				return;
			}
			this.CreateAndReturnTrashBag(id, position, rotation, content, initialVelocity, guid, startKinematic);
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x000F50CC File Offset: 0x000F32CC
		private void RpcReader___Observers_CreateTrashBag_680856992(PooledReader PooledReader0, Channel channel)
		{
			string id = PooledReader0.ReadString();
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			TrashContentData content = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Persistence.TrashContentDataFishNet.Serializing.Generateds(PooledReader0);
			Vector3 initialVelocity = PooledReader0.ReadVector3();
			NetworkConnection sender = PooledReader0.ReadNetworkConnection();
			string guid = PooledReader0.ReadString();
			bool startKinematic = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___CreateTrashBag_680856992(null, id, position, rotation, content, initialVelocity, sender, guid, startKinematic);
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x000F517C File Offset: 0x000F337C
		private void RpcWriter___Target_CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
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
			writer.WriteString(id);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.Write___ScheduleOne.Persistence.TrashContentDataFishNet.Serializing.Generated(content);
			writer.WriteVector3(initialVelocity);
			writer.WriteNetworkConnection(sender);
			writer.WriteString(guid);
			writer.WriteBoolean(startKinematic);
			base.SendTargetRpc(7U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x000F5294 File Offset: 0x000F3494
		private void RpcReader___Target_CreateTrashBag_680856992(PooledReader PooledReader0, Channel channel)
		{
			string id = PooledReader0.ReadString();
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			TrashContentData content = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Persistence.TrashContentDataFishNet.Serializing.Generateds(PooledReader0);
			Vector3 initialVelocity = PooledReader0.ReadVector3();
			NetworkConnection sender = PooledReader0.ReadNetworkConnection();
			string guid = PooledReader0.ReadString();
			bool startKinematic = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___CreateTrashBag_680856992(base.LocalConnection, id, position, rotation, content, initialVelocity, sender, guid, startKinematic);
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x000F5348 File Offset: 0x000F3548
		private void RpcWriter___Server_SendDestroyTrash_3615296227(string guid)
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
			writer.WriteString(guid);
			base.SendServerRpc(8U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x000F53EF File Offset: 0x000F35EF
		private void RpcLogic___SendDestroyTrash_3615296227(string guid)
		{
			this.DestroyTrash(guid);
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x000F53F8 File Offset: 0x000F35F8
		private void RpcReader___Server_SendDestroyTrash_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string guid = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendDestroyTrash_3615296227(guid);
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x000F5438 File Offset: 0x000F3638
		private void RpcWriter___Observers_DestroyTrash_3615296227(string guid)
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
			writer.WriteString(guid);
			base.SendObserversRpc(9U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x000F54F0 File Offset: 0x000F36F0
		private void RpcLogic___DestroyTrash_3615296227(string guid)
		{
			TrashItem @object = GUIDManager.GetObject<TrashItem>(new Guid(guid));
			if (@object == null)
			{
				return;
			}
			this.trashItems.Remove(@object);
			GUIDManager.DeregisterObject(@object);
			if (@object.onDestroyed != null)
			{
				@object.onDestroyed(@object);
			}
			@object.Deinitialize();
			Object.Destroy(@object.gameObject);
			this.HasChanged = true;
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x000F5554 File Offset: 0x000F3754
		private void RpcReader___Observers_DestroyTrash_3615296227(PooledReader PooledReader0, Channel channel)
		{
			string guid = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___DestroyTrash_3615296227(guid);
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x000F558F File Offset: 0x000F378F
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040029A6 RID: 10662
		public const int TRASH_ITEM_LIMIT = 2000;

		// Token: 0x040029A7 RID: 10663
		public TrashItem[] TrashPrefabs;

		// Token: 0x040029A8 RID: 10664
		public TrashItem TrashBagPrefab;

		// Token: 0x040029A9 RID: 10665
		public TrashManager.TrashItemData[] GenerateableTrashItems;

		// Token: 0x040029AA RID: 10666
		private List<TrashItem> trashItems = new List<TrashItem>();

		// Token: 0x040029AB RID: 10667
		public float TrashForceMultiplier = 0.3f;

		// Token: 0x040029AC RID: 10668
		private TrashLoader loader = new TrashLoader();

		// Token: 0x040029B0 RID: 10672
		private List<string> writtenItemFiles = new List<string>();

		// Token: 0x040029B1 RID: 10673
		private bool dll_Excuted;

		// Token: 0x040029B2 RID: 10674
		private bool dll_Excuted;

		// Token: 0x02000837 RID: 2103
		[Serializable]
		public class TrashItemData
		{
			// Token: 0x040029B3 RID: 10675
			public TrashItem Item;

			// Token: 0x040029B4 RID: 10676
			[Range(0f, 1f)]
			public float GenerationChance = 0.5f;
		}
	}
}
