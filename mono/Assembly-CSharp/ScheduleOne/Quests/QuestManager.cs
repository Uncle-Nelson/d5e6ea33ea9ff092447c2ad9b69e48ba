using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EasyButtons;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.GameTime;
using ScheduleOne.Money;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Product;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x020002DF RID: 735
	public class QuestManager : NetworkSingleton<QuestManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x00048754 File Offset: 0x00046954
		public string SaveFolderName
		{
			get
			{
				return "Quests";
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00048754 File Offset: 0x00046954
		public string SaveFileName
		{
			get
			{
				return "Quests";
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x0004875B File Offset: 0x0004695B
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x00048763 File Offset: 0x00046963
		// (set) Token: 0x06001046 RID: 4166 RVA: 0x0004876B File Offset: 0x0004696B
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x00048774 File Offset: 0x00046974
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x0004877C File Offset: 0x0004697C
		public List<string> LocalExtraFolders { get; set; } = new List<string>
		{
			"Contracts"
		};

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x00048785 File Offset: 0x00046985
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x0004878D File Offset: 0x0004698D
		public bool HasChanged { get; set; }

		// Token: 0x0600104B RID: 4171 RVA: 0x00048798 File Offset: 0x00046998
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Quests.QuestManager_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x000487B7 File Offset: 0x000469B7
		protected override void Start()
		{
			base.Start();
			base.InvokeRepeating("UpdateVariables", 0f, 0.5f);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x000487D4 File Offset: 0x000469D4
		public override void OnSpawnServer(NetworkConnection connection)
		{
			QuestManager.<>c__DisplayClass34_0 CS$<>8__locals1 = new QuestManager.<>c__DisplayClass34_0();
			CS$<>8__locals1.connection = connection;
			CS$<>8__locals1.<>4__this = this;
			base.OnSpawnServer(CS$<>8__locals1.connection);
			if (CS$<>8__locals1.connection.IsLocalClient)
			{
				return;
			}
			base.StartCoroutine(CS$<>8__locals1.<OnSpawnServer>g__SendQuestStuff|0());
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0004881C File Offset: 0x00046A1C
		private void UpdateVariables()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Active_Contract_Count", Contract.Contracts.Count.ToString(), true);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00048854 File Offset: 0x00046A54
		[ServerRpc(RequireOwnership = false)]
		public void SendContractAccepted(NetworkObject customer, ContractInfo contractData, bool track, string guid)
		{
			this.RpcWriter___Server_SendContractAccepted_1030683829(customer, contractData, track, guid);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00048878 File Offset: 0x00046A78
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void CreateContract_Networked(NetworkConnection conn, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_CreateContract_Networked_1113640585(conn, guid, tracked, customer, contractData, expiry, acceptTime, dealerObj);
				this.RpcLogic___CreateContract_Networked_1113640585(conn, guid, tracked, customer, contractData, expiry, acceptTime, dealerObj);
			}
			else
			{
				this.RpcWriter___Target_CreateContract_Networked_1113640585(conn, guid, tracked, customer, contractData, expiry, acceptTime, dealerObj);
			}
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00048904 File Offset: 0x00046B04
		public Contract CreateContract_Local(string title, string description, QuestEntryData[] entries, string guid, bool tracked, NetworkObject customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, bool expires, GameDateTime expiry, int pickupScheduleIndex, GameDateTime acceptTime, Dealer dealer = null)
		{
			Contract component = Object.Instantiate<GameObject>(this.ContractPrefab.gameObject, this.ContractContainer).GetComponent<Contract>();
			component.InitializeContract(title, description, entries, guid, customer, payment, products, deliveryLocationGUID, deliveryWindow, pickupScheduleIndex, acceptTime);
			component.Entries[0].PoILocation = component.DeliveryLocation.CustomerStandPoint;
			component.Entries[0].CreatePoI();
			if (tracked)
			{
				component.SetIsTracked(true);
			}
			if (expires)
			{
				component.ConfigureExpiry(true, expiry);
			}
			if (dealer != null)
			{
				component.SetDealer(dealer);
			}
			component.Begin(false);
			return component;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x000489A5 File Offset: 0x00046BA5
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestAction(string guid, QuestManager.EQuestAction action)
		{
			this.RpcWriter___Server_SendQuestAction_2848227116(guid, action);
			this.RpcLogic___SendQuestAction_2848227116(guid, action);
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x000489C4 File Offset: 0x00046BC4
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceiveQuestAction(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_ReceiveQuestAction_920727549(conn, guid, action);
				this.RpcLogic___ReceiveQuestAction_920727549(conn, guid, action);
			}
			else
			{
				this.RpcWriter___Target_ReceiveQuestAction_920727549(conn, guid, action);
			}
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00048A11 File Offset: 0x00046C11
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestState(string guid, EQuestState state)
		{
			this.RpcWriter___Server_SendQuestState_4117703421(guid, state);
			this.RpcLogic___SendQuestState_4117703421(guid, state);
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00048A30 File Offset: 0x00046C30
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceiveQuestState(NetworkConnection conn, string guid, EQuestState state)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_ReceiveQuestState_3887376304(conn, guid, state);
				this.RpcLogic___ReceiveQuestState_3887376304(conn, guid, state);
			}
			else
			{
				this.RpcWriter___Target_ReceiveQuestState_3887376304(conn, guid, state);
			}
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00048A80 File Offset: 0x00046C80
		[TargetRpc]
		private void SetQuestTracked(NetworkConnection conn, string guid, bool tracked)
		{
			this.RpcWriter___Target_SetQuestTracked_619441887(conn, guid, tracked);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00048A9F File Offset: 0x00046C9F
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestEntryState(string guid, int entryIndex, EQuestState state)
		{
			this.RpcWriter___Server_SendQuestEntryState_375159588(guid, entryIndex, state);
			this.RpcLogic___SendQuestEntryState_375159588(guid, entryIndex, state);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00048AC8 File Offset: 0x00046CC8
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceiveQuestEntryState(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_ReceiveQuestEntryState_311789429(conn, guid, entryIndex, state);
				this.RpcLogic___ReceiveQuestEntryState_311789429(conn, guid, entryIndex, state);
			}
			else
			{
				this.RpcWriter___Target_ReceiveQuestEntryState_311789429(conn, guid, entryIndex, state);
			}
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00048B24 File Offset: 0x00046D24
		[Button]
		public void PrintQuestStates()
		{
			for (int i = 0; i < Quest.Quests.Count; i++)
			{
				Console.Log(Quest.Quests[i].GetQuestTitle() + " state: " + Quest.Quests[i].QuestState.ToString(), null);
			}
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00048B84 File Offset: 0x00046D84
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void CreateDeaddropCollectionQuest(NetworkConnection conn, string dropGUID, string guidString = "")
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758(conn, dropGUID, guidString);
				this.RpcLogic___CreateDeaddropCollectionQuest_3895153758(conn, dropGUID, guidString);
			}
			else
			{
				this.RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758(conn, dropGUID, guidString);
			}
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00048BD4 File Offset: 0x00046DD4
		public DeaddropQuest CreateDeaddropCollectionQuest(string dropGUID, string guidString = "")
		{
			Guid guid = (guidString != "") ? new Guid(guidString) : GUIDManager.GenerateUniqueGUID();
			if (GUIDManager.IsGUIDAlreadyRegistered(guid))
			{
				return null;
			}
			DeadDrop @object = GUIDManager.GetObject<DeadDrop>(new Guid(dropGUID));
			if (@object == null)
			{
				Console.LogWarning("Failed to find dead drop with GUID: " + dropGUID, null);
				return null;
			}
			DeaddropQuest component = Object.Instantiate<GameObject>(this.DeaddropCollectionPrefab.gameObject, this.QuestContainer).GetComponent<DeaddropQuest>();
			component.SetDrop(@object);
			component.Description = "Collect the dead drop " + @object.DeadDropDescription;
			component.SetGUID(guid);
			component.Entries[0].SetEntryTitle(@object.DeadDropName);
			component.Begin(true);
			return component;
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00048C8B File Offset: 0x00046E8B
		public void PlayCompleteQuestSound()
		{
			if (this.QuestEntryCompleteSound.isPlaying)
			{
				this.QuestEntryCompleteSound.Stop();
			}
			this.QuestCompleteSound.Play();
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00048CB0 File Offset: 0x00046EB0
		public void PlayCompleteQuestEntrySound()
		{
			this.QuestEntryCompleteSound.Play();
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0003CEED File Offset: 0x0003B0ED
		public virtual string GetSaveString()
		{
			return string.Empty;
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00048CC0 File Offset: 0x00046EC0
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			this.writtenContractFiles.Clear();
			string containerFolder = ((ISaveable)this).GetContainerFolder(parentFolderPath);
			for (int i = 0; i < Quest.Quests.Count; i++)
			{
				if (!(Quest.Quests[i] is Contract) && Quest.Quests[i].HasChanged)
				{
					list.Add(Quest.Quests[i].SaveFileName);
					new SaveRequest(Quest.Quests[i], containerFolder);
				}
			}
			string parentFolderPath2 = ((ISaveable)this).WriteFolder(parentFolderPath, "Contracts");
			for (int j = 0; j < Contract.Contracts.Count; j++)
			{
				if (Contract.Contracts[j].ShouldSave())
				{
					this.writtenContractFiles.Add(Contract.Contracts[j].SaveFileName + ".json");
					if (Contract.Contracts[j].HasChanged)
					{
						new SaveRequest(Contract.Contracts[j], parentFolderPath2);
					}
				}
			}
			return list;
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00048DD0 File Offset: 0x00046FD0
		public virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
			string[] files = Directory.GetFiles(((ISaveable)this).WriteFolder(parentFolderPath, "Contracts"));
			for (int i = 0; i < files.Length; i++)
			{
				if (!this.writtenContractFiles.Contains(files[i]))
				{
					try
					{
						File.Delete(files[i]);
					}
					catch (Exception ex)
					{
						Console.LogError("Failed to delete unapproved contract file: " + files[i] + " - " + ex.Message, null);
					}
				}
			}
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00048E88 File Offset: 0x00047088
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Quests.QuestManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Quests.QuestManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendContractAccepted_1030683829));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_CreateContract_Networked_1113640585));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_CreateContract_Networked_1113640585));
			base.RegisterServerRpc(3U, new ServerRpcDelegate(this.RpcReader___Server_SendQuestAction_2848227116));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveQuestAction_920727549));
			base.RegisterTargetRpc(5U, new ClientRpcDelegate(this.RpcReader___Target_ReceiveQuestAction_920727549));
			base.RegisterServerRpc(6U, new ServerRpcDelegate(this.RpcReader___Server_SendQuestState_4117703421));
			base.RegisterObserversRpc(7U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveQuestState_3887376304));
			base.RegisterTargetRpc(8U, new ClientRpcDelegate(this.RpcReader___Target_ReceiveQuestState_3887376304));
			base.RegisterTargetRpc(9U, new ClientRpcDelegate(this.RpcReader___Target_SetQuestTracked_619441887));
			base.RegisterServerRpc(10U, new ServerRpcDelegate(this.RpcReader___Server_SendQuestEntryState_375159588));
			base.RegisterObserversRpc(11U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveQuestEntryState_311789429));
			base.RegisterTargetRpc(12U, new ClientRpcDelegate(this.RpcReader___Target_ReceiveQuestEntryState_311789429));
			base.RegisterObserversRpc(13U, new ClientRpcDelegate(this.RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758));
			base.RegisterTargetRpc(14U, new ClientRpcDelegate(this.RpcReader___Target_CreateDeaddropCollectionQuest_3895153758));
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00049005 File Offset: 0x00047205
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Quests.QuestManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Quests.QuestManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0004901E File Offset: 0x0004721E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0004902C File Offset: 0x0004722C
		private void RpcWriter___Server_SendContractAccepted_1030683829(NetworkObject customer, ContractInfo contractData, bool track, string guid)
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
			writer.WriteNetworkObject(customer);
			writer.Write___ScheduleOne.Quests.ContractInfoFishNet.Serializing.Generated(contractData);
			writer.WriteBoolean(track);
			writer.WriteString(guid);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x000490FC File Offset: 0x000472FC
		public void RpcLogic___SendContractAccepted_1030683829(NetworkObject customer, ContractInfo contractData, bool track, string guid)
		{
			GameDateTime expiry = default(GameDateTime);
			expiry.time = contractData.DeliveryWindow.WindowEndTime;
			expiry.elapsedDays = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.ElapsedDays;
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.CurrentTime > contractData.DeliveryWindow.WindowEndTime)
			{
				expiry.elapsedDays++;
			}
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Accepted_Contract_Count", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Accepted_Contract_Count") + 1f).ToString(), true);
			GameDateTime dateTime = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.GetDateTime();
			this.CreateContract_Networked(null, guid, track, customer, contractData, expiry, dateTime, null);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x000491A0 File Offset: 0x000473A0
		private void RpcReader___Server_SendContractAccepted_1030683829(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject customer = PooledReader0.ReadNetworkObject();
			ContractInfo contractData = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Quests.ContractInfoFishNet.Serializing.Generateds(PooledReader0);
			bool track = PooledReader0.ReadBoolean();
			string guid = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendContractAccepted_1030683829(customer, contractData, track, guid);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00049204 File Offset: 0x00047404
		private void RpcWriter___Observers_CreateContract_Networked_1113640585(NetworkConnection conn, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
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
			writer.WriteBoolean(tracked);
			writer.WriteNetworkObject(customer);
			writer.Write___ScheduleOne.Quests.ContractInfoFishNet.Serializing.Generated(contractData);
			writer.Write___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generated(expiry);
			writer.Write___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generated(acceptTime);
			writer.WriteNetworkObject(dealerObj);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00049308 File Offset: 0x00047508
		public void RpcLogic___CreateContract_Networked_1113640585(NetworkConnection conn, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
		{
			if (GUIDManager.IsGUIDAlreadyRegistered(new Guid(guid)))
			{
				return;
			}
			DeliveryLocation @object = GUIDManager.GetObject<DeliveryLocation>(new Guid(contractData.DeliveryLocationGUID));
			QuestEntryData questEntryData = new QuestEntryData(contractData.Products.GetCommaSeperatedString() + ", " + @object.LocationName, EQuestState.Inactive);
			string nameAddress = customer.GetComponent<Customer>().NPC.GetNameAddress();
			string description = string.Concat(new string[]
			{
				nameAddress,
				" has requested a delivery of ",
				contractData.Products.GetCommaSeperatedString(),
				" ",
				@object.GetDescription(),
				" for ",
				MoneyManager.FormatAmount(contractData.Payment, false, false),
				"."
			});
			Dealer dealer = null;
			if (dealerObj != null)
			{
				dealer = dealerObj.GetComponent<Dealer>();
			}
			this.CreateContract_Local("Deal for " + nameAddress, description, new QuestEntryData[]
			{
				questEntryData
			}, guid, tracked, customer, contractData.Payment, contractData.Products, contractData.DeliveryLocationGUID, contractData.DeliveryWindow, contractData.Expires, expiry, contractData.PickupScheduleIndex, acceptTime, dealer);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0004942C File Offset: 0x0004762C
		private void RpcReader___Observers_CreateContract_Networked_1113640585(PooledReader PooledReader0, Channel channel)
		{
			string guid = PooledReader0.ReadString();
			bool tracked = PooledReader0.ReadBoolean();
			NetworkObject customer = PooledReader0.ReadNetworkObject();
			ContractInfo contractData = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Quests.ContractInfoFishNet.Serializing.Generateds(PooledReader0);
			GameDateTime expiry = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generateds(PooledReader0);
			GameDateTime acceptTime = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generateds(PooledReader0);
			NetworkObject dealerObj = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___CreateContract_Networked_1113640585(null, guid, tracked, customer, contractData, expiry, acceptTime, dealerObj);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x000494D0 File Offset: 0x000476D0
		private void RpcWriter___Target_CreateContract_Networked_1113640585(NetworkConnection conn, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
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
			writer.WriteBoolean(tracked);
			writer.WriteNetworkObject(customer);
			writer.Write___ScheduleOne.Quests.ContractInfoFishNet.Serializing.Generated(contractData);
			writer.Write___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generated(expiry);
			writer.Write___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generated(acceptTime);
			writer.WriteNetworkObject(dealerObj);
			base.SendTargetRpc(2U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x000495D4 File Offset: 0x000477D4
		private void RpcReader___Target_CreateContract_Networked_1113640585(PooledReader PooledReader0, Channel channel)
		{
			string guid = PooledReader0.ReadString();
			bool tracked = PooledReader0.ReadBoolean();
			NetworkObject customer = PooledReader0.ReadNetworkObject();
			ContractInfo contractData = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Quests.ContractInfoFishNet.Serializing.Generateds(PooledReader0);
			GameDateTime expiry = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generateds(PooledReader0);
			GameDateTime acceptTime = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generateds(PooledReader0);
			NetworkObject dealerObj = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___CreateContract_Networked_1113640585(base.LocalConnection, guid, tracked, customer, contractData, expiry, acceptTime, dealerObj);
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00049674 File Offset: 0x00047874
		private void RpcWriter___Server_SendQuestAction_2848227116(string guid, QuestManager.EQuestAction action)
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
			writer.Write___ScheduleOne.Quests.QuestManager/EQuestActionFishNet.Serializing.Generated(action);
			base.SendServerRpc(3U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00049728 File Offset: 0x00047928
		public void RpcLogic___SendQuestAction_2848227116(string guid, QuestManager.EQuestAction action)
		{
			this.ReceiveQuestAction(null, guid, action);
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00049734 File Offset: 0x00047934
		private void RpcReader___Server_SendQuestAction_2848227116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string guid = PooledReader0.ReadString();
			QuestManager.EQuestAction action = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Quests.QuestManager/EQuestActionFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendQuestAction_2848227116(guid, action);
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00049784 File Offset: 0x00047984
		private void RpcWriter___Observers_ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
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
			writer.Write___ScheduleOne.Quests.QuestManager/EQuestActionFishNet.Serializing.Generated(action);
			base.SendObserversRpc(4U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00049848 File Offset: 0x00047A48
		private void RpcLogic___ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
			Quest @object = GUIDManager.GetObject<Quest>(new Guid(guid));
			if (@object == null)
			{
				Console.LogWarning("Failed to find quest with GUID: " + guid, null);
				return;
			}
			switch (action)
			{
			case QuestManager.EQuestAction.Begin:
				@object.Begin(false);
				return;
			case QuestManager.EQuestAction.Success:
				@object.Complete(false);
				return;
			case QuestManager.EQuestAction.Fail:
				@object.Fail(false);
				return;
			case QuestManager.EQuestAction.Expire:
				@object.Expire(false);
				return;
			case QuestManager.EQuestAction.Cancel:
				@object.Cancel(false);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x000498C0 File Offset: 0x00047AC0
		private void RpcReader___Observers_ReceiveQuestAction_920727549(PooledReader PooledReader0, Channel channel)
		{
			string guid = PooledReader0.ReadString();
			QuestManager.EQuestAction action = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Quests.QuestManager/EQuestActionFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ReceiveQuestAction_920727549(null, guid, action);
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00049910 File Offset: 0x00047B10
		private void RpcWriter___Target_ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
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
			writer.Write___ScheduleOne.Quests.QuestManager/EQuestActionFishNet.Serializing.Generated(action);
			base.SendTargetRpc(5U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x000499D4 File Offset: 0x00047BD4
		private void RpcReader___Target_ReceiveQuestAction_920727549(PooledReader PooledReader0, Channel channel)
		{
			string guid = PooledReader0.ReadString();
			QuestManager.EQuestAction action = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Quests.QuestManager/EQuestActionFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveQuestAction_920727549(base.LocalConnection, guid, action);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00049A1C File Offset: 0x00047C1C
		private void RpcWriter___Server_SendQuestState_4117703421(string guid, EQuestState state)
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
			writer.Write___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generated(state);
			base.SendServerRpc(6U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00049AD0 File Offset: 0x00047CD0
		public void RpcLogic___SendQuestState_4117703421(string guid, EQuestState state)
		{
			this.ReceiveQuestState(null, guid, state);
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00049ADC File Offset: 0x00047CDC
		private void RpcReader___Server_SendQuestState_4117703421(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string guid = PooledReader0.ReadString();
			EQuestState state = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendQuestState_4117703421(guid, state);
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00049B2C File Offset: 0x00047D2C
		private void RpcWriter___Observers_ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
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
			writer.Write___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generated(state);
			base.SendObserversRpc(7U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00049BF0 File Offset: 0x00047DF0
		private void RpcLogic___ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
			Quest @object = GUIDManager.GetObject<Quest>(new Guid(guid));
			if (@object == null)
			{
				Console.LogWarning("Failed to find quest with GUID: " + guid, null);
				return;
			}
			@object.SetQuestState(state, false);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00049C2C File Offset: 0x00047E2C
		private void RpcReader___Observers_ReceiveQuestState_3887376304(PooledReader PooledReader0, Channel channel)
		{
			string guid = PooledReader0.ReadString();
			EQuestState state = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ReceiveQuestState_3887376304(null, guid, state);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00049C7C File Offset: 0x00047E7C
		private void RpcWriter___Target_ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
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
			writer.Write___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generated(state);
			base.SendTargetRpc(8U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00049D40 File Offset: 0x00047F40
		private void RpcReader___Target_ReceiveQuestState_3887376304(PooledReader PooledReader0, Channel channel)
		{
			string guid = PooledReader0.ReadString();
			EQuestState state = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveQuestState_3887376304(base.LocalConnection, guid, state);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00049D88 File Offset: 0x00047F88
		private void RpcWriter___Target_SetQuestTracked_619441887(NetworkConnection conn, string guid, bool tracked)
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
			writer.WriteBoolean(tracked);
			base.SendTargetRpc(9U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00049E4C File Offset: 0x0004804C
		private void RpcLogic___SetQuestTracked_619441887(NetworkConnection conn, string guid, bool tracked)
		{
			Quest @object = GUIDManager.GetObject<Quest>(new Guid(guid));
			if (@object == null)
			{
				Console.LogWarning("Failed to find quest with GUID: " + guid, null);
				return;
			}
			@object.SetIsTracked(tracked);
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00049E88 File Offset: 0x00048088
		private void RpcReader___Target_SetQuestTracked_619441887(PooledReader PooledReader0, Channel channel)
		{
			string guid = PooledReader0.ReadString();
			bool tracked = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetQuestTracked_619441887(base.LocalConnection, guid, tracked);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00049ED0 File Offset: 0x000480D0
		private void RpcWriter___Server_SendQuestEntryState_375159588(string guid, int entryIndex, EQuestState state)
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
			writer.WriteInt32(entryIndex, AutoPackType.Packed);
			writer.Write___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generated(state);
			base.SendServerRpc(10U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00049F96 File Offset: 0x00048196
		public void RpcLogic___SendQuestEntryState_375159588(string guid, int entryIndex, EQuestState state)
		{
			this.ReceiveQuestEntryState(null, guid, entryIndex, state);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00049FA4 File Offset: 0x000481A4
		private void RpcReader___Server_SendQuestEntryState_375159588(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string guid = PooledReader0.ReadString();
			int entryIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			EQuestState state = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendQuestEntryState_375159588(guid, entryIndex, state);
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0004A00C File Offset: 0x0004820C
		private void RpcWriter___Observers_ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
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
			writer.WriteInt32(entryIndex, AutoPackType.Packed);
			writer.Write___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generated(state);
			base.SendObserversRpc(11U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0004A0E4 File Offset: 0x000482E4
		private void RpcLogic___ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
			Quest @object = GUIDManager.GetObject<Quest>(new Guid(guid));
			if (@object == null)
			{
				Console.LogWarning("Failed to find quest with GUID: " + guid, null);
				return;
			}
			@object.SetQuestEntryState(entryIndex, state, false);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0004A124 File Offset: 0x00048324
		private void RpcReader___Observers_ReceiveQuestEntryState_311789429(PooledReader PooledReader0, Channel channel)
		{
			string guid = PooledReader0.ReadString();
			int entryIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			EQuestState state = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ReceiveQuestEntryState_311789429(null, guid, entryIndex, state);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0004A188 File Offset: 0x00048388
		private void RpcWriter___Target_ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
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
			writer.WriteInt32(entryIndex, AutoPackType.Packed);
			writer.Write___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generated(state);
			base.SendTargetRpc(12U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0004A25C File Offset: 0x0004845C
		private void RpcReader___Target_ReceiveQuestEntryState_311789429(PooledReader PooledReader0, Channel channel)
		{
			string guid = PooledReader0.ReadString();
			int entryIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			EQuestState state = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveQuestEntryState_311789429(base.LocalConnection, guid, entryIndex, state);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0004A2BC File Offset: 0x000484BC
		private void RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
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
			writer.WriteString(dropGUID);
			writer.WriteString(guidString);
			base.SendObserversRpc(13U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0004A37F File Offset: 0x0004857F
		public void RpcLogic___CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
			this.CreateDeaddropCollectionQuest(dropGUID, guidString);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0004A38C File Offset: 0x0004858C
		private void RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758(PooledReader PooledReader0, Channel channel)
		{
			string dropGUID = PooledReader0.ReadString();
			string guidString = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___CreateDeaddropCollectionQuest_3895153758(null, dropGUID, guidString);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0004A3DC File Offset: 0x000485DC
		private void RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
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
			writer.WriteString(dropGUID);
			writer.WriteString(guidString);
			base.SendTargetRpc(14U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0004A4A0 File Offset: 0x000486A0
		private void RpcReader___Target_CreateDeaddropCollectionQuest_3895153758(PooledReader PooledReader0, Channel channel)
		{
			string dropGUID = PooledReader0.ReadString();
			string guidString = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___CreateDeaddropCollectionQuest_3895153758(base.LocalConnection, dropGUID, guidString);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0004A4E8 File Offset: 0x000486E8
		protected virtual void dll()
		{
			base.Awake();
			this.InitializeSaveable();
			foreach (Quest quest in this.QuestContainer.GetComponentsInChildren<Quest>())
			{
				if (!this.DefaultQuests.Contains(quest))
				{
					Console.LogError("Quest " + quest.GetQuestTitle() + " is not in the default quests list!", null);
				}
			}
		}

		// Token: 0x040010C5 RID: 4293
		public const EQuestState DEFAULT_QUEST_STATE = EQuestState.Inactive;

		// Token: 0x040010C6 RID: 4294
		public Quest[] DefaultQuests;

		// Token: 0x040010C7 RID: 4295
		[Header("References")]
		public Transform QuestContainer;

		// Token: 0x040010C8 RID: 4296
		public Transform ContractContainer;

		// Token: 0x040010C9 RID: 4297
		public AudioSourceController QuestCompleteSound;

		// Token: 0x040010CA RID: 4298
		public AudioSourceController QuestEntryCompleteSound;

		// Token: 0x040010CB RID: 4299
		[Header("Prefabs")]
		public Contract ContractPrefab;

		// Token: 0x040010CC RID: 4300
		public DeaddropQuest DeaddropCollectionPrefab;

		// Token: 0x040010CD RID: 4301
		private QuestsLoader loader = new QuestsLoader();

		// Token: 0x040010D1 RID: 4305
		private List<string> writtenContractFiles = new List<string>();

		// Token: 0x040010D2 RID: 4306
		private bool dll_Excuted;

		// Token: 0x040010D3 RID: 4307
		private bool dll_Excuted;

		// Token: 0x020002E0 RID: 736
		public enum EQuestAction
		{
			// Token: 0x040010D5 RID: 4309
			Begin,
			// Token: 0x040010D6 RID: 4310
			Success,
			// Token: 0x040010D7 RID: 4311
			Fail,
			// Token: 0x040010D8 RID: 4312
			Expire,
			// Token: 0x040010D9 RID: 4313
			Cancel
		}
	}
}
