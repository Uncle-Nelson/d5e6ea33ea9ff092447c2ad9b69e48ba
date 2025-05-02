using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Delivery;
using ScheduleOne.DevUtilities;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.Management;
using ScheduleOne.Map;
using ScheduleOne.Misc;
using ScheduleOne.Money;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Management;
using ScheduleOne.Variables;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Property
{
	// Token: 0x02000814 RID: 2068
	public class Property : NetworkBehaviour, ISaveable
	{
		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06003826 RID: 14374 RVA: 0x000EDF5B File Offset: 0x000EC15B
		// (set) Token: 0x06003827 RID: 14375 RVA: 0x000EDF63 File Offset: 0x000EC163
		public bool IsOwned { get; protected set; }

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06003828 RID: 14376 RVA: 0x000EDF6C File Offset: 0x000EC16C
		// (set) Token: 0x06003829 RID: 14377 RVA: 0x000EDF74 File Offset: 0x000EC174
		public List<Employee> Employees { get; protected set; } = new List<Employee>();

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x0600382A RID: 14378 RVA: 0x000EDF7D File Offset: 0x000EC17D
		// (set) Token: 0x0600382B RID: 14379 RVA: 0x000EDF85 File Offset: 0x000EC185
		public RectTransform WorldspaceUIContainer { get; protected set; }

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x0600382C RID: 14380 RVA: 0x000EDF8E File Offset: 0x000EC18E
		// (set) Token: 0x0600382D RID: 14381 RVA: 0x000EDF96 File Offset: 0x000EC196
		public bool IsContentCulled { get; set; }

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x0600382E RID: 14382 RVA: 0x000EDF9F File Offset: 0x000EC19F
		public string PropertyName
		{
			get
			{
				return this.propertyName;
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600382F RID: 14383 RVA: 0x000EDFA7 File Offset: 0x000EC1A7
		public string PropertyCode
		{
			get
			{
				return this.propertyCode;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06003830 RID: 14384 RVA: 0x000EDFAF File Offset: 0x000EC1AF
		public int LoadingDockCount
		{
			get
			{
				return this.LoadingDocks.Length;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06003831 RID: 14385 RVA: 0x000EDF9F File Offset: 0x000EC19F
		public string SaveFolderName
		{
			get
			{
				return this.propertyName;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06003832 RID: 14386 RVA: 0x000EDFB9 File Offset: 0x000EC1B9
		public string SaveFileName
		{
			get
			{
				return "Property";
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06003833 RID: 14387 RVA: 0x000EDFC0 File Offset: 0x000EC1C0
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06003834 RID: 14388 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06003835 RID: 14389 RVA: 0x000EDFC8 File Offset: 0x000EC1C8
		// (set) Token: 0x06003836 RID: 14390 RVA: 0x000EDFD0 File Offset: 0x000EC1D0
		public List<string> LocalExtraFiles { get; set; } = new List<string>
		{
			"Safe"
		};

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06003837 RID: 14391 RVA: 0x000EDFD9 File Offset: 0x000EC1D9
		// (set) Token: 0x06003838 RID: 14392 RVA: 0x000EDFE1 File Offset: 0x000EC1E1
		public List<string> LocalExtraFolders { get; set; } = new List<string>
		{
			"Objects",
			"Employees"
		};

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06003839 RID: 14393 RVA: 0x000EDFEA File Offset: 0x000EC1EA
		// (set) Token: 0x0600383A RID: 14394 RVA: 0x000EDFF2 File Offset: 0x000EC1F2
		public bool HasChanged { get; set; }

		// Token: 0x0600383B RID: 14395 RVA: 0x000EDFFC File Offset: 0x000EC1FC
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Property.Property_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x000EE01B File Offset: 0x000EC21B
		protected virtual void Start()
		{
			MoneyManager instance = NetworkSingleton<MoneyManager>.Instance;
			instance.onNetworthCalculation = (Action<MoneyManager.FloatContainer>)Delegate.Combine(instance.onNetworthCalculation, new Action<MoneyManager.FloatContainer>(this.GetNetworth));
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x000EE044 File Offset: 0x000EC244
		protected virtual void FixedUpdate()
		{
			this.UpdateCulling();
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x000EE04C File Offset: 0x000EC24C
		public void AddConfigurable(IConfigurable configurable)
		{
			if (this.Configurables.Contains(configurable))
			{
				return;
			}
			this.Configurables.Add(configurable);
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x000EE069 File Offset: 0x000EC269
		public void RemoveConfigurable(IConfigurable configurable)
		{
			if (!this.Configurables.Contains(configurable))
			{
				return;
			}
			this.Configurables.Remove(configurable);
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x000EE088 File Offset: 0x000EC288
		private void UpdateCulling()
		{
			if (!Singleton<LoadManager>.InstanceExists || Singleton<LoadManager>.Instance.IsLoading)
			{
				return;
			}
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			if (!this.ContentCullingEnabled)
			{
				this.SetContentCulled(false);
			}
			float num = Vector3.Distance(PlayerSingleton<PlayerCamera>.Instance.transform.position, base.transform.position);
			if (num < this.MinimumCullingDistance)
			{
				this.SetContentCulled(false);
				return;
			}
			if (num > this.MinimumCullingDistance + 5f)
			{
				this.SetContentCulled(true);
			}
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x000EE108 File Offset: 0x000EC308
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			for (int i = 0; i < this.Toggleables.Count; i++)
			{
				if (this.Toggleables[i].IsActivated)
				{
					this.SetToggleableState(connection, i, this.Toggleables[i].IsActivated);
				}
			}
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x000EE160 File Offset: 0x000EC360
		protected virtual void OnDestroy()
		{
			if (NetworkSingleton<MoneyManager>.InstanceExists)
			{
				MoneyManager instance = NetworkSingleton<MoneyManager>.Instance;
				instance.onNetworthCalculation = (Action<MoneyManager.FloatContainer>)Delegate.Remove(instance.onNetworthCalculation, new Action<MoneyManager.FloatContainer>(this.GetNetworth));
			}
			Property.Properties.Remove(this);
			Property.UnownedProperties.Remove(this);
			Property.OwnedProperties.Remove(this);
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x000EE1BF File Offset: 0x000EC3BF
		protected virtual void GetNetworth(MoneyManager.FloatContainer container)
		{
			if (this.IsOwned)
			{
				container.ChangeValue(this.Price);
			}
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x000EE1D8 File Offset: 0x000EC3D8
		public override void OnStartServer()
		{
			base.OnStartServer();
			if ((Application.isEditor || Debug.isDebugBuild) && this.DEBUG_SET_OWNED)
			{
				this.SetOwned_Server();
			}
			else if (this.OwnedByDefault)
			{
				this.SetOwned_Server();
			}
			if (base.NetworkObject.GetInitializeOrder() == 0)
			{
				Console.LogError("Property " + this.PropertyName + " has an initialize order of 0. This will cause issues.", null);
			}
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x000EE23F File Offset: 0x000EC43F
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected void SetOwned_Server()
		{
			this.RpcWriter___Server_SetOwned_Server_2166136261();
			this.RpcLogic___SetOwned_Server_2166136261();
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x000EE24D File Offset: 0x000EC44D
		[ObserversRpc(RunLocally = true, BufferLast = true)]
		private void ReceiveOwned_Networked()
		{
			this.RpcWriter___Observers_ReceiveOwned_Networked_2166136261();
			this.RpcLogic___ReceiveOwned_Networked_2166136261();
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x000EE25C File Offset: 0x000EC45C
		protected virtual void RecieveOwned()
		{
			if (this.IsOwned)
			{
				return;
			}
			this.IsOwned = true;
			this.HasChanged = true;
			if (this.IsOwnedVariable != string.Empty && NetworkSingleton<VariableDatabase>.InstanceExists && InstanceFinder.IsServer)
			{
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue(this.IsOwnedVariable, "true", true);
			}
			if (Property.UnownedProperties.Contains(this))
			{
				Property.UnownedProperties.Remove(this);
				Property.OwnedProperties.Add(this);
			}
			if (Property.onPropertyAcquired != null)
			{
				Property.onPropertyAcquired(this);
			}
			if (this.onThisPropertyAcquired != null)
			{
				this.onThisPropertyAcquired.Invoke();
			}
			this.ForSaleSign.gameObject.SetActive(false);
			if (this.ListingPoster != null)
			{
				this.ListingPoster.gameObject.SetActive(false);
			}
			this.PoI.gameObject.SetActive(true);
			this.PoI.SetMainText(this.propertyName + " (Owned)");
			base.StartCoroutine(this.<RecieveOwned>g__Wait|93_0());
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x000EE368 File Offset: 0x000EC568
		public virtual bool ShouldSave()
		{
			return this.IsOwned || this.Container.transform.childCount > 0;
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x000EE387 File Offset: 0x000EC587
		public void SetOwned()
		{
			this.SetOwned_Server();
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x000045B1 File Offset: 0x000027B1
		public void SetBoundsVisible(bool vis)
		{
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x000EE390 File Offset: 0x000EC590
		public virtual void SetContentCulled(bool culled)
		{
			if (this.IsContentCulled == culled)
			{
				return;
			}
			this.IsContentCulled = culled;
			foreach (BuildableItem buildableItem in this.BuildableItems)
			{
				if (!(buildableItem == null))
				{
					buildableItem.SetCulled(culled);
				}
			}
			foreach (GameObject gameObject in this.ObjectsToCull)
			{
				if (!(gameObject == null))
				{
					gameObject.SetActive(!culled);
				}
			}
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x000EE42C File Offset: 0x000EC62C
		public int RegisterEmployee(Employee emp)
		{
			this.Employees.Add(emp);
			return this.Employees.IndexOf(emp);
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x000EE446 File Offset: 0x000EC646
		public void DeregisterEmployee(Employee emp)
		{
			this.Employees.Remove(emp);
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x000EE455 File Offset: 0x000EC655
		private void ToggleableActioned(InteractableToggleable toggleable)
		{
			this.HasChanged = true;
			this.SendToggleableState(this.Toggleables.IndexOf(toggleable), toggleable.IsActivated);
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x000EE476 File Offset: 0x000EC676
		[ServerRpc(RequireOwnership = false)]
		public void SendToggleableState(int index, bool state)
		{
			this.RpcWriter___Server_SendToggleableState_3658436649(index, state);
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x000EE486 File Offset: 0x000EC686
		[ObserversRpc]
		[TargetRpc]
		public void SetToggleableState(NetworkConnection conn, int index, bool state)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetToggleableState_338960014(conn, index, state);
			}
			else
			{
				this.RpcWriter___Target_SetToggleableState_338960014(conn, index, state);
			}
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x000EE4B8 File Offset: 0x000EC6B8
		public virtual string GetSaveString()
		{
			bool[] array = new bool[this.Switches.Count];
			for (int i = 0; i < this.Switches.Count; i++)
			{
				if (!(this.Switches[i] == null))
				{
					array[i] = this.Switches[i].isOn;
				}
			}
			bool[] array2 = new bool[this.Toggleables.Count];
			for (int j = 0; j < this.Toggleables.Count; j++)
			{
				if (!(this.Toggleables[j] == null))
				{
					array2[j] = this.Toggleables[j].IsActivated;
				}
			}
			return new PropertyData(this.propertyCode, this.IsOwned, array, array2).GetJson(true);
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x000EE57C File Offset: 0x000EC77C
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> result = new List<string>();
			this.savedObjectPaths.Clear();
			this.savedEmployeePaths.Clear();
			string parentFolderPath2 = ((ISaveable)this).WriteFolder(parentFolderPath, "Objects");
			foreach (BuildableItem buildableItem in this.BuildableItems)
			{
				try
				{
					new SaveRequest(buildableItem, parentFolderPath2);
					this.savedObjectPaths.Add(buildableItem.SaveFolderName);
				}
				catch (Exception ex)
				{
					Console.LogError("Error saving object: " + ex.Message, null);
					SaveManager.ReportSaveError();
				}
			}
			string parentFolderPath3 = ((ISaveable)this).WriteFolder(parentFolderPath, "Employees");
			foreach (Employee employee in this.Employees)
			{
				try
				{
					new SaveRequest(employee, parentFolderPath3);
					this.savedEmployeePaths.Add(employee.SaveFolderName);
				}
				catch (Exception ex2)
				{
					Console.LogError("Error saving employees: " + ex2.Message, null);
					SaveManager.ReportSaveError();
				}
			}
			return result;
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x000EE6D0 File Offset: 0x000EC8D0
		public virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
			string path = ((ISaveable)this).WriteFolder(parentFolderPath, "Objects");
			string path2 = ((ISaveable)this).WriteFolder(parentFolderPath, "Employees");
			string[] directories = Directory.GetDirectories(path);
			for (int i = 0; i < directories.Length; i++)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(directories[i]);
				if (!this.savedObjectPaths.Contains(directoryInfo.Name))
				{
					Directory.Delete(directories[i], true);
				}
			}
			directories = Directory.GetDirectories(path2);
			for (int j = 0; j < directories.Length; j++)
			{
				DirectoryInfo directoryInfo2 = new DirectoryInfo(directories[j]);
				if (!this.savedEmployeePaths.Contains(directoryInfo2.Name))
				{
					Directory.Delete(directories[j], true);
				}
			}
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x000EE774 File Offset: 0x000EC974
		public virtual void Load(PropertyData propertyData, string containerPath)
		{
			if (propertyData.IsOwned)
			{
				this.SetOwned();
			}
			int num = 0;
			while (num < propertyData.SwitchStates.Length && num < this.Switches.Count)
			{
				if (propertyData.SwitchStates[num] && this.Switches.Count > num)
				{
					this.Switches[num].SwitchOn();
				}
				num++;
			}
			if (propertyData.ToggleableStates != null)
			{
				int num2 = 0;
				while (num2 < propertyData.ToggleableStates.Length && num2 < this.Toggleables.Count)
				{
					if (propertyData.ToggleableStates[num2] && this.Toggleables.Count > num2)
					{
						this.Toggleables[num2].Toggle();
					}
					num2++;
				}
			}
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x000EE82C File Offset: 0x000ECA2C
		public bool DoBoundsContainPoint(Vector3 point)
		{
			foreach (BoxCollider boxCollider in this.propertyBoundsColliders)
			{
				if (!(boxCollider == null) && this.IsPointInsideBox(point, boxCollider))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x000EE868 File Offset: 0x000ECA68
		private bool IsPointInsideBox(Vector3 worldPoint, BoxCollider box)
		{
			if (box == null)
			{
				Console.LogWarning("BoxCollider is null.", null);
				return false;
			}
			Vector3 vector = box.transform.InverseTransformPoint(worldPoint);
			vector -= box.center;
			Vector3 vector2 = box.size * 0.5f;
			return Mathf.Abs(vector.x) <= vector2.x && Mathf.Abs(vector.y) <= vector2.y && Mathf.Abs(vector.z) <= vector2.z;
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x000EE8F4 File Offset: 0x000ECAF4
		public List<Bed> GetUnassignedBeds()
		{
			return (from x in this.Container.GetComponentsInChildren<Bed>()
			where x.AssignedEmployee == null
			select x).ToList<Bed>();
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x000EEA2E File Offset: 0x000ECC2E
		[CompilerGenerated]
		private IEnumerator <RecieveOwned>g__Wait|93_0()
		{
			yield return new WaitUntil(() => this.PoI.UISetup);
			this.PoI.IconContainer.Find("Unowned").gameObject.SetActive(false);
			this.PoI.IconContainer.Find("Owned").gameObject.SetActive(true);
			yield break;
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x000EEA4C File Offset: 0x000ECC4C
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SetOwned_Server_2166136261));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveOwned_Networked_2166136261));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_SendToggleableState_3658436649));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_SetToggleableState_338960014));
			base.RegisterTargetRpc(4U, new ClientRpcDelegate(this.RpcReader___Target_SetToggleableState_338960014));
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x000EEADD File Offset: 0x000ECCDD
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x000EEAF0 File Offset: 0x000ECCF0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x000EEB00 File Offset: 0x000ECD00
		private void RpcWriter___Server_SetOwned_Server_2166136261()
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
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x000EEB9A File Offset: 0x000ECD9A
		protected void RpcLogic___SetOwned_Server_2166136261()
		{
			this.ReceiveOwned_Networked();
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x000EEBA4 File Offset: 0x000ECDA4
		private void RpcReader___Server_SetOwned_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetOwned_Server_2166136261();
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x000EEBD4 File Offset: 0x000ECDD4
		private void RpcWriter___Observers_ReceiveOwned_Networked_2166136261()
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
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, true, false, false);
			writer.Store();
		}

		// Token: 0x06003865 RID: 14437 RVA: 0x000EEC7D File Offset: 0x000ECE7D
		private void RpcLogic___ReceiveOwned_Networked_2166136261()
		{
			this.RecieveOwned();
		}

		// Token: 0x06003866 RID: 14438 RVA: 0x000EEC88 File Offset: 0x000ECE88
		private void RpcReader___Observers_ReceiveOwned_Networked_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ReceiveOwned_Networked_2166136261();
		}

		// Token: 0x06003867 RID: 14439 RVA: 0x000EECB4 File Offset: 0x000ECEB4
		private void RpcWriter___Server_SendToggleableState_3658436649(int index, bool state)
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
			writer.WriteInt32(index, AutoPackType.Packed);
			writer.WriteBoolean(state);
			base.SendServerRpc(2U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003868 RID: 14440 RVA: 0x000EED6D File Offset: 0x000ECF6D
		public void RpcLogic___SendToggleableState_3658436649(int index, bool state)
		{
			this.SetToggleableState(null, index, state);
		}

		// Token: 0x06003869 RID: 14441 RVA: 0x000EED78 File Offset: 0x000ECF78
		private void RpcReader___Server_SendToggleableState_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int index = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool state = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendToggleableState_3658436649(index, state);
		}

		// Token: 0x0600386A RID: 14442 RVA: 0x000EEDC0 File Offset: 0x000ECFC0
		private void RpcWriter___Observers_SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
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
			writer.WriteInt32(index, AutoPackType.Packed);
			writer.WriteBoolean(state);
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600386B RID: 14443 RVA: 0x000EEE88 File Offset: 0x000ED088
		public void RpcLogic___SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
			this.Toggleables[index].SetState(state);
		}

		// Token: 0x0600386C RID: 14444 RVA: 0x000EEE9C File Offset: 0x000ED09C
		private void RpcReader___Observers_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel)
		{
			int index = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool state = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetToggleableState_338960014(null, index, state);
		}

		// Token: 0x0600386D RID: 14445 RVA: 0x000EEEE4 File Offset: 0x000ED0E4
		private void RpcWriter___Target_SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
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
			writer.WriteInt32(index, AutoPackType.Packed);
			writer.WriteBoolean(state);
			base.SendTargetRpc(4U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x000EEFAC File Offset: 0x000ED1AC
		private void RpcReader___Target_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel)
		{
			int index = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool state = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetToggleableState_338960014(base.LocalConnection, index, state);
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x000EEFFC File Offset: 0x000ED1FC
		protected virtual void dll()
		{
			this.propertyBoundsColliders = this.BoundingBox.GetComponentsInChildren<BoxCollider>();
			foreach (BoxCollider boxCollider in this.propertyBoundsColliders)
			{
				boxCollider.isTrigger = true;
				boxCollider.gameObject.layer = LayerMask.NameToLayer("Invisible");
			}
			if (!(this is Business))
			{
				Property.Properties.Add(this);
				Property.UnownedProperties.Remove(this);
				Property.UnownedProperties.Add(this);
			}
			this.Container.Property = this;
			this.PoI.SetMainText(this.propertyName + " (Unowned)");
			this.SetBoundsVisible(false);
			this.ForSaleSign.transform.Find("Name").GetComponent<TextMeshPro>().text = this.propertyName;
			this.ForSaleSign.transform.Find("Price").GetComponent<TextMeshPro>().text = MoneyManager.FormatAmount(this.Price, false, false);
			if (this.DisposalArea == null)
			{
				Console.LogWarning("Property " + this.PropertyName + " has no disposal area.", null);
			}
			if (this.EmployeeIdlePoints.Length < this.EmployeeCapacity)
			{
				Debug.LogWarning("Property " + this.PropertyName + " has less idle points than employee capacity.");
			}
			if (!GameManager.IS_TUTORIAL)
			{
				this.WorldspaceUIContainer = new GameObject(this.propertyName + " Worldspace UI Container").AddComponent<RectTransform>();
				this.WorldspaceUIContainer.SetParent(Singleton<ManagementWorldspaceCanvas>.Instance.Canvas.transform);
				this.WorldspaceUIContainer.gameObject.SetActive(false);
			}
			if (this.ListingPoster != null)
			{
				this.ListingPoster.Find("Title").GetComponent<TextMeshPro>().text = this.propertyName;
				this.ListingPoster.Find("Price").GetComponent<TextMeshPro>().text = MoneyManager.FormatAmount(this.Price, false, false);
				this.ListingPoster.Find("Parking/Text").GetComponent<TextMeshPro>().text = this.LoadingDockCount.ToString();
				this.ListingPoster.Find("Employee/Text").GetComponent<TextMeshPro>().text = this.EmployeeCapacity.ToString();
			}
			this.PoI.gameObject.SetActive(false);
			foreach (ModularSwitch modularSwitch in this.Switches)
			{
				if (!(modularSwitch == null))
				{
					ModularSwitch modularSwitch2 = modularSwitch;
					modularSwitch2.onToggled = (ModularSwitch.ButtonChange)Delegate.Combine(modularSwitch2.onToggled, new ModularSwitch.ButtonChange(delegate(bool <p0>)
					{
						this.HasChanged = true;
					}));
				}
			}
			foreach (InteractableToggleable interactableToggleable in this.Toggleables)
			{
				if (!(interactableToggleable == null))
				{
					InteractableToggleable toggleable1 = interactableToggleable;
					interactableToggleable.onToggle.AddListener(new UnityAction(delegate()
					{
						this.ToggleableActioned(toggleable1);
					}));
				}
			}
			this.InitializeSaveable();
		}

		// Token: 0x040028DE RID: 10462
		public static List<Property> Properties = new List<Property>();

		// Token: 0x040028DF RID: 10463
		public static List<Property> UnownedProperties = new List<Property>();

		// Token: 0x040028E0 RID: 10464
		public static List<Property> OwnedProperties = new List<Property>();

		// Token: 0x040028E1 RID: 10465
		public static Property.PropertyChange onPropertyAcquired;

		// Token: 0x040028E2 RID: 10466
		public UnityEvent onThisPropertyAcquired;

		// Token: 0x040028E7 RID: 10471
		[Header("Settings")]
		[SerializeField]
		protected string propertyName = "Property Name";

		// Token: 0x040028E8 RID: 10472
		public bool AvailableInDemo = true;

		// Token: 0x040028E9 RID: 10473
		[SerializeField]
		protected string propertyCode = "propertycode";

		// Token: 0x040028EA RID: 10474
		public float Price = 1f;

		// Token: 0x040028EB RID: 10475
		public float DefaultRotation;

		// Token: 0x040028EC RID: 10476
		public int EmployeeCapacity = 10;

		// Token: 0x040028ED RID: 10477
		public bool OwnedByDefault;

		// Token: 0x040028EE RID: 10478
		public bool DEBUG_SET_OWNED;

		// Token: 0x040028EF RID: 10479
		public string IsOwnedVariable = string.Empty;

		// Token: 0x040028F0 RID: 10480
		[Header("Culling Settings")]
		public bool ContentCullingEnabled = true;

		// Token: 0x040028F1 RID: 10481
		public float MinimumCullingDistance = 50f;

		// Token: 0x040028F2 RID: 10482
		public GameObject[] ObjectsToCull;

		// Token: 0x040028F3 RID: 10483
		[Header("References")]
		public PropertyContentsContainer Container;

		// Token: 0x040028F4 RID: 10484
		public Transform EmployeeContainer;

		// Token: 0x040028F5 RID: 10485
		public Transform SpawnPoint;

		// Token: 0x040028F6 RID: 10486
		public Transform InteriorSpawnPoint;

		// Token: 0x040028F7 RID: 10487
		public GameObject ForSaleSign;

		// Token: 0x040028F8 RID: 10488
		public GameObject BoundingBox;

		// Token: 0x040028F9 RID: 10489
		public POI PoI;

		// Token: 0x040028FA RID: 10490
		public Transform ListingPoster;

		// Token: 0x040028FB RID: 10491
		public Transform NPCSpawnPoint;

		// Token: 0x040028FC RID: 10492
		public Transform[] EmployeeIdlePoints;

		// Token: 0x040028FD RID: 10493
		public List<ModularSwitch> Switches;

		// Token: 0x040028FE RID: 10494
		public List<InteractableToggleable> Toggleables;

		// Token: 0x040028FF RID: 10495
		public PropertyDisposalArea DisposalArea;

		// Token: 0x04002900 RID: 10496
		public LoadingDock[] LoadingDocks;

		// Token: 0x04002901 RID: 10497
		[HideInInspector]
		public List<BuildableItem> BuildableItems = new List<BuildableItem>();

		// Token: 0x04002902 RID: 10498
		public List<IConfigurable> Configurables = new List<IConfigurable>();

		// Token: 0x04002903 RID: 10499
		private BoxCollider[] propertyBoundsColliders;

		// Token: 0x04002904 RID: 10500
		private PropertyLoader loader = new PropertyLoader();

		// Token: 0x04002908 RID: 10504
		private List<string> savedObjectPaths = new List<string>();

		// Token: 0x04002909 RID: 10505
		private List<string> savedEmployeePaths = new List<string>();

		// Token: 0x0400290A RID: 10506
		private bool dll_Excuted;

		// Token: 0x0400290B RID: 10507
		private bool dll_Excuted;

		// Token: 0x02000815 RID: 2069
		// (Invoke) Token: 0x06003871 RID: 14449
		public delegate void PropertyChange(Property property);
	}
}
