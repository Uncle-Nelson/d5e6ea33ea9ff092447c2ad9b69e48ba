using System;
using System.Collections.Generic;
using System.IO;
using EasyButtons;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Variables
{
	// Token: 0x02000293 RID: 659
	public class VariableDatabase : NetworkSingleton<VariableDatabase>, IBaseSaveable, ISaveable
	{
		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x0003C9C9 File Offset: 0x0003ABC9
		public string SaveFolderName
		{
			get
			{
				return "Variables";
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x0003C9C9 File Offset: 0x0003ABC9
		public string SaveFileName
		{
			get
			{
				return "Variables";
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0003C9D0 File Offset: 0x0003ABD0
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x0003C9D8 File Offset: 0x0003ABD8
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x0003C9E0 File Offset: 0x0003ABE0
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x0003C9E9 File Offset: 0x0003ABE9
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x0003C9F1 File Offset: 0x0003ABF1
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0003C9FA File Offset: 0x0003ABFA
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x0003CA02 File Offset: 0x0003AC02
		public bool HasChanged { get; set; }

		// Token: 0x06000D9F RID: 3487 RVA: 0x0003CA0C File Offset: 0x0003AC0C
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Variables.VariableDatabase_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0003CA38 File Offset: 0x0003AC38
		private void CreateVariables()
		{
			for (int i = 0; i < this.Creators.Length; i++)
			{
				if (this.Creators[i].Mode == EVariableMode.Player)
				{
					this.playerVariables.Add(this.Creators[i].Name.ToLower());
				}
				else
				{
					this.CreateVariable(this.Creators[i].Name, this.Creators[i].Type, this.Creators[i].InitialValue, this.Creators[i].Persistent, EVariableMode.Global, null, EVariableReplicationMode.Networked);
				}
			}
			this.SetVariableValue("IsDemo", false.ToString(), true);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0003CADC File Offset: 0x0003ACDC
		public void CreatePlayerVariables(Player owner)
		{
			for (int i = 0; i < this.Creators.Length; i++)
			{
				if (this.Creators[i].Mode == EVariableMode.Player)
				{
					this.CreateVariable(this.Creators[i].Name, this.Creators[i].Type, this.Creators[i].InitialValue, this.Creators[i].Persistent, EVariableMode.Player, owner, EVariableReplicationMode.Local);
				}
			}
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0003CB4C File Offset: 0x0003AD4C
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (connection.IsHost)
			{
				return;
			}
			for (int i = 0; i < this.VariableList.Count; i++)
			{
				if (this.VariableList[i].ReplicationMode != EVariableReplicationMode.Local)
				{
					this.VariableList[i].ReplicateValue(connection);
				}
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0003CBA4 File Offset: 0x0003ADA4
		public void CreateVariable(string name, VariableDatabase.EVariableType type, string initialValue, bool persistent, EVariableMode mode, Player owner, EVariableReplicationMode replicationMode = EVariableReplicationMode.Networked)
		{
			if (type == VariableDatabase.EVariableType.Bool)
			{
				new BoolVariable(name, replicationMode, persistent, mode, owner, initialValue == "true");
				return;
			}
			if (type != VariableDatabase.EVariableType.Number)
			{
				return;
			}
			float num;
			float value = float.TryParse(initialValue, out num) ? num : 0f;
			new NumberVariable(name, replicationMode, persistent, mode, owner, value);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0003CC00 File Offset: 0x0003AE00
		public void AddVariable(BaseVariable variable)
		{
			if (this.VariableDict.ContainsKey(variable.Name))
			{
				Console.LogError("Variable with name " + variable.Name + " already exists in the database.", null);
				return;
			}
			this.VariableList.Add(variable);
			this.VariableDict.Add(variable.Name.ToLower(), variable);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0003CC5F File Offset: 0x0003AE5F
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendValue(NetworkConnection conn, string variableName, string value)
		{
			this.RpcWriter___Server_SendValue_3895153758(conn, variableName, value);
			this.RpcLogic___SendValue_3895153758(conn, variableName, value);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0003CC85 File Offset: 0x0003AE85
		[ObserversRpc]
		[TargetRpc]
		public void ReceiveValue(NetworkConnection conn, string variableName, string value)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_ReceiveValue_3895153758(conn, variableName, value);
			}
			else
			{
				this.RpcWriter___Target_ReceiveValue_3895153758(conn, variableName, value);
			}
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0003CCB8 File Offset: 0x0003AEB8
		public void SetVariableValue(string variableName, string value, bool network = true)
		{
			variableName = variableName.ToLower();
			if (this.playerVariables.Contains(variableName))
			{
				Player.Local.SetVariableValue(variableName, value, network);
				return;
			}
			if (this.VariableDict.ContainsKey(variableName))
			{
				this.VariableDict[variableName].SetValue(value, network);
				return;
			}
			Console.LogWarning("Failed to find variable with name: " + variableName, null);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0003CD1C File Offset: 0x0003AF1C
		public BaseVariable GetVariable(string variableName)
		{
			variableName = variableName.ToLower();
			if (this.playerVariables.Contains(variableName))
			{
				return Player.Local.GetVariable(variableName);
			}
			if (this.VariableDict.ContainsKey(variableName))
			{
				return this.VariableDict[variableName];
			}
			Console.LogWarning("Failed to find variable with name: " + variableName, null);
			return null;
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0003CD78 File Offset: 0x0003AF78
		public T GetValue<T>(string variableName)
		{
			variableName = variableName.ToLower();
			if (this.playerVariables.Contains(variableName))
			{
				return Player.Local.GetValue<T>(variableName);
			}
			if (this.VariableDict.ContainsKey(variableName))
			{
				return (T)((object)this.VariableDict[variableName].GetValue());
			}
			Console.LogError("Variable with name " + variableName + " does not exist in the database.", null);
			return default(T);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0003CDEC File Offset: 0x0003AFEC
		[Button]
		public void PrintAllVariables()
		{
			for (int i = 0; i < this.VariableList.Count; i++)
			{
				this.PrintVariableValue(this.VariableList[i].Name);
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0003CE28 File Offset: 0x0003B028
		public void PrintVariableValue(string variableName)
		{
			variableName = variableName.ToLower();
			if (this.VariableDict.ContainsKey(variableName))
			{
				string str = "Value of ";
				string str2 = variableName;
				string str3 = ": ";
				object value = this.VariableDict[variableName].GetValue();
				Console.Log(str + str2 + str3 + ((value != null) ? value.ToString() : null), null);
				return;
			}
			Console.LogError("Variable with name " + variableName + " does not exist in the database.", null);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0003CE98 File Offset: 0x0003B098
		public void NotifyItemAcquired(string id, int quantity)
		{
			if (this.VariableDict.ContainsKey(id + "_acquired"))
			{
				float value = this.GetValue<float>(id + "_acquired");
				this.SetVariableValue(id + "_acquired", (value + (float)quantity).ToString(), true);
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0003CEED File Offset: 0x0003B0ED
		public virtual string GetSaveString()
		{
			return string.Empty;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0003CEF4 File Offset: 0x0003B0F4
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			string containerFolder = ((ISaveable)this).GetContainerFolder(parentFolderPath);
			for (int i = 0; i < this.VariableList.Count; i++)
			{
				if (this.VariableList[i] != null && this.VariableList[i].Persistent && this.VariableList[i].VariableMode != EVariableMode.Player)
				{
					string json = new VariableData(this.VariableList[i].Name, this.VariableList[i].GetValue().ToString()).GetJson(true);
					string text = SaveManager.MakeFileSafe(this.VariableList[i].Name) + ".json";
					list.Add(text);
					string text2 = Path.Combine(containerFolder, text);
					try
					{
						File.WriteAllText(text2, json);
					}
					catch (Exception ex)
					{
						Console.LogWarning("Failed to write variable file: " + text2 + " - " + ex.Message, null);
					}
				}
			}
			return list;
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0003D010 File Offset: 0x0003B210
		public void Load(VariableData data)
		{
			if (this.playerVariables.Contains(data.Name.ToLower()))
			{
				Console.Log("Player variable: " + data.Name + " loaded from database. Redirecting to player.", null);
				Player.Local.SetVariableValue(data.Name, data.Value, false);
				return;
			}
			BaseVariable variable = this.GetVariable(data.Name);
			if (variable == null)
			{
				Console.LogWarning("Failed to find variable with name: " + data.Name, null);
				return;
			}
			variable.SetValue(data.Value, true);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0003D0F4 File Offset: 0x0003B2F4
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Variables.VariableDatabaseAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Variables.VariableDatabaseAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendValue_3895153758));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveValue_3895153758));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_ReceiveValue_3895153758));
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0003D15D File Offset: 0x0003B35D
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Variables.VariableDatabaseAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Variables.VariableDatabaseAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0003D176 File Offset: 0x0003B376
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0003D184 File Offset: 0x0003B384
		private void RpcWriter___Server_SendValue_3895153758(NetworkConnection conn, string variableName, string value)
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
			writer.WriteString(variableName);
			writer.WriteString(value);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0003D245 File Offset: 0x0003B445
		public void RpcLogic___SendValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
			this.ReceiveValue(conn, variableName, value);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0003D250 File Offset: 0x0003B450
		private void RpcReader___Server_SendValue_3895153758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkConnection conn2 = PooledReader0.ReadNetworkConnection();
			string variableName = PooledReader0.ReadString();
			string value = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendValue_3895153758(conn2, variableName, value);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0003D2B0 File Offset: 0x0003B4B0
		private void RpcWriter___Observers_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
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
			writer.WriteString(variableName);
			writer.WriteString(value);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0003D373 File Offset: 0x0003B573
		public void RpcLogic___ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
			variableName = variableName.ToLower();
			if (this.VariableDict.ContainsKey(variableName))
			{
				this.VariableDict[variableName].SetValue(value, false);
			}
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0003D3A0 File Offset: 0x0003B5A0
		private void RpcReader___Observers_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
			string variableName = PooledReader0.ReadString();
			string value = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveValue_3895153758(null, variableName, value);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0003D3E4 File Offset: 0x0003B5E4
		private void RpcWriter___Target_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
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
			writer.WriteString(variableName);
			writer.WriteString(value);
			base.SendTargetRpc(2U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0003D4A8 File Offset: 0x0003B6A8
		private void RpcReader___Target_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
			string variableName = PooledReader0.ReadString();
			string value = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveValue_3895153758(base.LocalConnection, variableName, value);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0003D4F0 File Offset: 0x0003B6F0
		protected virtual void dll()
		{
			base.Awake();
			List<VariableCreator> list = new List<VariableCreator>(this.Creators);
			for (int i = 0; i < this.ItemsToTrackAcquire.Length; i++)
			{
				list.Add(new VariableCreator
				{
					InitialValue = "0",
					Mode = EVariableMode.Global,
					Type = VariableDatabase.EVariableType.Number,
					Persistent = true,
					Name = this.ItemsToTrackAcquire[i].ID + "_acquired"
				});
			}
			this.Creators = list.ToArray();
			this.CreateVariables();
			this.InitializeSaveable();
		}

		// Token: 0x04000E41 RID: 3649
		public List<BaseVariable> VariableList = new List<BaseVariable>();

		// Token: 0x04000E42 RID: 3650
		public Dictionary<string, BaseVariable> VariableDict = new Dictionary<string, BaseVariable>();

		// Token: 0x04000E43 RID: 3651
		private List<string> playerVariables = new List<string>();

		// Token: 0x04000E44 RID: 3652
		public VariableCreator[] Creators;

		// Token: 0x04000E45 RID: 3653
		public StorableItemDefinition[] ItemsToTrackAcquire;

		// Token: 0x04000E46 RID: 3654
		private VariablesLoader loader = new VariablesLoader();

		// Token: 0x04000E4A RID: 3658
		private bool dll_Excuted;

		// Token: 0x04000E4B RID: 3659
		private bool dll_Excuted;

		// Token: 0x02000294 RID: 660
		public enum EVariableType
		{
			// Token: 0x04000E4D RID: 3661
			Bool,
			// Token: 0x04000E4E RID: 3662
			Number
		}
	}
}
