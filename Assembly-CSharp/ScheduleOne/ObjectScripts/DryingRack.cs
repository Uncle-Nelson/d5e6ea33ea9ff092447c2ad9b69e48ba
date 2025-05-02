using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.GameTime;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.Tools;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Management;
using ScheduleOne.UI.Stations;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BCF RID: 3023
	public class DryingRack : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060052BF RID: 21183 RVA: 0x0015CAD4 File Offset: 0x0015ACD4
		// (set) Token: 0x060052C0 RID: 21184 RVA: 0x0015CADC File Offset: 0x0015ACDC
		public NetworkObject NPCUserObject
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<NPCUserObject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.sync___set_value_<NPCUserObject>k__BackingField(value, true);
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060052C1 RID: 21185 RVA: 0x0015CAE6 File Offset: 0x0015ACE6
		// (set) Token: 0x060052C2 RID: 21186 RVA: 0x0015CAEE File Offset: 0x0015ACEE
		public NetworkObject PlayerUserObject
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<PlayerUserObject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.sync___set_value_<PlayerUserObject>k__BackingField(value, true);
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060052C3 RID: 21187 RVA: 0x0015CAF8 File Offset: 0x0015ACF8
		// (set) Token: 0x060052C4 RID: 21188 RVA: 0x0015CB00 File Offset: 0x0015AD00
		public List<ItemSlot> ItemSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060052C5 RID: 21189 RVA: 0x00150487 File Offset: 0x0014E687
		public string Name
		{
			get
			{
				return base.ItemInstance.Name;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060052C6 RID: 21190 RVA: 0x0015CB09 File Offset: 0x0015AD09
		// (set) Token: 0x060052C7 RID: 21191 RVA: 0x0015CB11 File Offset: 0x0015AD11
		public List<ItemSlot> InputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060052C8 RID: 21192 RVA: 0x0015CB1A File Offset: 0x0015AD1A
		// (set) Token: 0x060052C9 RID: 21193 RVA: 0x0015CB22 File Offset: 0x0015AD22
		public List<ItemSlot> OutputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060052CA RID: 21194 RVA: 0x0015CB2B File Offset: 0x0015AD2B
		public Transform LinkOrigin
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060052CB RID: 21195 RVA: 0x0015CB33 File Offset: 0x0015AD33
		public Transform[] AccessPoints
		{
			get
			{
				return this.accessPoints;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060052CC RID: 21196 RVA: 0x0015CB3B File Offset: 0x0015AD3B
		public bool Selectable { get; } = 1;

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060052CD RID: 21197 RVA: 0x0015CB43 File Offset: 0x0015AD43
		// (set) Token: 0x060052CE RID: 21198 RVA: 0x0015CB4B File Offset: 0x0015AD4B
		public bool IsAcceptingItems { get; set; } = true;

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060052CF RID: 21199 RVA: 0x0015CB54 File Offset: 0x0015AD54
		public EntityConfiguration Configuration
		{
			get
			{
				return this.stationConfiguration;
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060052D0 RID: 21200 RVA: 0x0015CB5C File Offset: 0x0015AD5C
		// (set) Token: 0x060052D1 RID: 21201 RVA: 0x0015CB64 File Offset: 0x0015AD64
		protected DryingRackConfiguration stationConfiguration { get; set; }

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060052D2 RID: 21202 RVA: 0x0015CB6D File Offset: 0x0015AD6D
		public ConfigurationReplicator ConfigReplicator
		{
			get
			{
				return this.configReplicator;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060052D3 RID: 21203 RVA: 0x0015CB75 File Offset: 0x0015AD75
		public EConfigurableType ConfigurableType
		{
			get
			{
				return EConfigurableType.DryingRack;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060052D4 RID: 21204 RVA: 0x0015CB79 File Offset: 0x0015AD79
		// (set) Token: 0x060052D5 RID: 21205 RVA: 0x0015CB81 File Offset: 0x0015AD81
		public WorldspaceUIElement WorldspaceUI { get; set; }

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060052D6 RID: 21206 RVA: 0x0015CB8A File Offset: 0x0015AD8A
		// (set) Token: 0x060052D7 RID: 21207 RVA: 0x0015CB92 File Offset: 0x0015AD92
		public NetworkObject CurrentPlayerConfigurer
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<CurrentPlayerConfigurer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.sync___set_value_<CurrentPlayerConfigurer>k__BackingField(value, true);
			}
		}

		// Token: 0x060052D8 RID: 21208 RVA: 0x0015CB9C File Offset: 0x0015AD9C
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
			this.RpcWriter___Server_SetConfigurer_3323014238(player);
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060052D9 RID: 21209 RVA: 0x0015CBB2 File Offset: 0x0015ADB2
		public Sprite TypeIcon
		{
			get
			{
				return this.typeIcon;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060052DA RID: 21210 RVA: 0x000AEDCB File Offset: 0x000ACFCB
		public Transform Transform
		{
			get
			{
				return base.transform;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060052DB RID: 21211 RVA: 0x0015CB2B File Offset: 0x0015AD2B
		public Transform UIPoint
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060052DC RID: 21212 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CanBeSelected
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060052DD RID: 21213 RVA: 0x0015CBBA File Offset: 0x0015ADBA
		// (set) Token: 0x060052DE RID: 21214 RVA: 0x0015CBC2 File Offset: 0x0015ADC2
		public ItemSlot InputSlot { get; private set; }

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x060052DF RID: 21215 RVA: 0x0015CBCB File Offset: 0x0015ADCB
		// (set) Token: 0x060052E0 RID: 21216 RVA: 0x0015CBD3 File Offset: 0x0015ADD3
		public ItemSlot OutputSlot { get; private set; }

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x060052E1 RID: 21217 RVA: 0x0015CBDC File Offset: 0x0015ADDC
		// (set) Token: 0x060052E2 RID: 21218 RVA: 0x0015CBE4 File Offset: 0x0015ADE4
		public bool IsOpen { get; private set; }

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x060052E3 RID: 21219 RVA: 0x0015CBED File Offset: 0x0015ADED
		// (set) Token: 0x060052E4 RID: 21220 RVA: 0x0015CBF5 File Offset: 0x0015ADF5
		public List<DryingOperation> DryingOperations { get; set; } = new List<DryingOperation>();

		// Token: 0x060052E5 RID: 21221 RVA: 0x0015CC00 File Offset: 0x0015AE00
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ObjectScripts.DryingRack_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x0015CC20 File Offset: 0x0015AE20
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			bool initialized = base.Initialized;
			base.InitializeGridItem(instance, grid, originCoordinate, rotation, GUID);
			if (initialized)
			{
				return;
			}
			if (!this.isGhost)
			{
				base.ParentProperty.AddConfigurable(this);
				this.stationConfiguration = new DryingRackConfiguration(this.configReplicator, this, this);
				this.CreateWorldspaceUI();
				GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 4);
				TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance2.onMinutePass = (Action)Delegate.Combine(instance2.onMinutePass, new Action(this.MinPass));
			}
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x0015CCAC File Offset: 0x0015AEAC
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			((IItemSlotOwner)this).SendItemsToClient(connection);
			foreach (DryingOperation op in this.DryingOperations)
			{
				this.PleaseReceiveOp(connection, op);
			}
			this.SendConfigurationToClient(connection);
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x0015CD18 File Offset: 0x0015AF18
		public void SendConfigurationToClient(NetworkConnection conn)
		{
			DryingRack.<>c__DisplayClass97_0 CS$<>8__locals1 = new DryingRack.<>c__DisplayClass97_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.conn = conn;
			if (CS$<>8__locals1.conn.IsHost)
			{
				return;
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SendConfigurationToClient>g__WaitForConfig|0());
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x0015CD58 File Offset: 0x0015AF58
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			if (action.exitType != ExitType.Escape)
			{
				return;
			}
			action.used = true;
			this.Close();
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x0015CD83 File Offset: 0x0015AF83
		public override bool CanBeDestroyed(out string reason)
		{
			if (((IUsable)this).IsInUse)
			{
				reason = "In use";
				return false;
			}
			if (((IItemSlotOwner)this).GetTotalItemCount() > 0 || this.DryingOperations.Count > 0)
			{
				reason = "Contains items";
				return false;
			}
			return base.CanBeDestroyed(out reason);
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x0015CDC0 File Offset: 0x0015AFC0
		public override void DestroyItem(bool callOnServer = true)
		{
			GameInput.DeregisterExitListener(new GameInput.ExitDelegate(this.Exit));
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			if (this.Configuration != null)
			{
				this.Configuration.Destroy();
				this.DestroyWorldspaceUI();
				base.ParentProperty.RemoveConfigurable(this);
			}
			base.DestroyItem(callOnServer);
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x0015CE30 File Offset: 0x0015B030
		private void MinPass()
		{
			foreach (DryingOperation dryingOperation in this.DryingOperations.ToArray())
			{
				dryingOperation.Time++;
				if (dryingOperation.Time >= 720)
				{
					if (dryingOperation.StartQuality >= EQuality.Premium)
					{
						if (InstanceFinder.IsServer && this.GetOutputCapacityForOperation(dryingOperation, EQuality.Heavenly) >= dryingOperation.Quantity)
						{
							this.TryEndOperation(this.DryingOperations.IndexOf(dryingOperation), false, EQuality.Heavenly, Random.Range(int.MinValue, int.MaxValue));
						}
					}
					else
					{
						dryingOperation.IncreaseQuality();
					}
				}
			}
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x0015CEC1 File Offset: 0x0015B0C1
		public bool CanStartOperation()
		{
			return this.GetTotalDryingItems() < this.ItemCapacity && this.InputSlot.Quantity != 0 && !this.InputSlot.IsLocked && !this.InputSlot.IsRemovalLocked;
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x0015CF00 File Offset: 0x0015B100
		public void StartOperation()
		{
			int num = Mathf.Min(this.InputSlot.Quantity, this.ItemCapacity - this.GetTotalDryingItems());
			EQuality quality = (this.InputSlot.ItemInstance as QualityItemInstance).Quality;
			DryingOperation op = new DryingOperation(this.InputSlot.ItemInstance.ID, num, quality, 0);
			this.SendOperation(op);
			this.InputSlot.ChangeQuantity(-num, false);
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x0015CF70 File Offset: 0x0015B170
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void TryEndOperation(int operationIndex, bool allowSplitting, EQuality quality, int requestID)
		{
			this.RpcWriter___Server_TryEndOperation_4146970406(operationIndex, allowSplitting, quality, requestID);
			this.RpcLogic___TryEndOperation_4146970406(operationIndex, allowSplitting, quality, requestID);
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x0015CFAC File Offset: 0x0015B1AC
		public List<DryingOperation> GetOperationsAtTargetQuality()
		{
			EQuality targetQuality = (this.Configuration as DryingRackConfiguration).TargetQuality.Value;
			return (from x in this.DryingOperations
			where x.StartQuality >= targetQuality
			select x).ToList<DryingOperation>();
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x0015CFF8 File Offset: 0x0015B1F8
		public int GetOutputCapacityForOperation(DryingOperation operation, EQuality quality)
		{
			QualityItemInstance qualityItemInstance = Registry.GetItem(operation.ItemID).GetDefaultInstance(1) as QualityItemInstance;
			qualityItemInstance.SetQuality(quality);
			return this.OutputSlot.GetCapacityForItem(qualityItemInstance);
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x0015D02F File Offset: 0x0015B22F
		[ServerRpc(RequireOwnership = false)]
		private void SendOperation(DryingOperation op)
		{
			this.RpcWriter___Server_SendOperation_1307702229(op);
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x0015D03C File Offset: 0x0015B23C
		[TargetRpc]
		[ObserversRpc]
		private void PleaseReceiveOp(NetworkConnection conn, DryingOperation op)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_PleaseReceiveOp_1575047616(conn, op);
			}
			else
			{
				this.RpcWriter___Target_PleaseReceiveOp_1575047616(conn, op);
			}
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x0015D070 File Offset: 0x0015B270
		[ObserversRpc(RunLocally = true, ExcludeServer = true)]
		private void RemoveOperation(int opIndex)
		{
			this.RpcWriter___Observers_RemoveOperation_3316948804(opIndex);
			this.RpcLogic___RemoveOperation_3316948804(opIndex);
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x0015D094 File Offset: 0x0015B294
		[ObserversRpc]
		private void SetOperationQuantity(int opIndex, int quantity)
		{
			this.RpcWriter___Observers_SetOperationQuantity_1692629761(opIndex, quantity);
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x0015D0AF File Offset: 0x0015B2AF
		public int GetTotalDryingItems()
		{
			return this.DryingOperations.Sum((DryingOperation x) => x.Quantity);
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x0015D0DC File Offset: 0x0015B2DC
		public void RefreshHangingVisuals()
		{
			for (int i = 0; i < this.hangSlots.Length; i++)
			{
				if (this.DryingOperations.Count > i)
				{
					QualityItemInstance qualityItemInstance = this.DryingOperations[i].GetQualityItemInstance();
					this.hangSlots[i].SetStoredItem(qualityItemInstance, false);
				}
				else
				{
					this.hangSlots[i].ClearStoredInstance(false);
				}
			}
			this.HangingVisuals.RefreshVisuals();
			StoredItem[] array = (from x in this.HangingVisuals.ItemContainer.GetComponentsInChildren<StoredItem>()
			where !x.Destroyed
			select x).ToArray<StoredItem>();
			int num = 0;
			while (num < array.Length && num < this.HangAlignments.Length)
			{
				Transform transform = array[num].GetComponentsInChildren<Transform>().FirstOrDefault((Transform x) => x.name == "HangingAlignment");
				if (transform == null)
				{
					Console.LogError("Missing alignment transform on stored item: " + array[num].name, null);
				}
				else
				{
					Transform transform2 = this.HangAlignments[num];
					Quaternion lhs = transform2.rotation * Quaternion.Inverse(transform.rotation);
					array[num].transform.rotation = lhs * array[num].transform.rotation;
					Vector3 b = transform2.position - transform.position;
					array[num].transform.position += b;
				}
				num++;
			}
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x0015D264 File Offset: 0x0015B464
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				Console.LogWarning(base.gameObject.name + " already has a worldspace UI element!", null);
			}
			if (base.ParentProperty == null)
			{
				Property parentProperty = base.ParentProperty;
				Console.LogError(((parentProperty != null) ? parentProperty.ToString() : null) + " is not a child of a property!", null);
				return null;
			}
			DryingRackUIElement component = Object.Instantiate<DryingRackUIElement>(this.WorldspaceUIPrefab, base.ParentProperty.WorldspaceUIContainer).GetComponent<DryingRackUIElement>();
			component.Initialize(this);
			this.WorldspaceUI = component;
			return component;
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x0015D2F7 File Offset: 0x0015B4F7
		public void DestroyWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				this.WorldspaceUI.Destroy();
			}
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x0015D312 File Offset: 0x0015B512
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
			this.RpcWriter___Server_SetPlayerUser_3323014238(playerObject);
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x0015D328 File Offset: 0x0015B528
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
			this.RpcWriter___Server_SetNPCUser_3323014238(npcObject);
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x0015D340 File Offset: 0x0015B540
		public void Hovered()
		{
			if (((IUsable)this).IsInUse || Singleton<ManagementClipboard>.Instance.IsEquipped)
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			this.IntObj.SetMessage("Use " + base.ItemInstance.Name);
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x0015D39A File Offset: 0x0015B59A
		public void Interacted()
		{
			if (((IUsable)this).IsInUse || Singleton<ManagementClipboard>.Instance.IsEquipped)
			{
				return;
			}
			this.Open();
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x0015D3B8 File Offset: 0x0015B5B8
		public void Open()
		{
			this.IsOpen = true;
			this.SetPlayerUser(Player.Local.NetworkObject);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			Transform transform = this.CameraPositions[0];
			if (Vector3.Distance(PlayerSingleton<PlayerCamera>.Instance.transform.position, this.CameraPositions[1].position) < Vector3.Distance(PlayerSingleton<PlayerCamera>.Instance.transform.position, this.CameraPositions[0].position))
			{
				transform = this.CameraPositions[1];
			}
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(transform.position, transform.rotation, 0.2f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(70f, 0.2f);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			Singleton<CompassManager>.Instance.SetVisible(false);
			Singleton<DryingRackCanvas>.Instance.SetIsOpen(this, true);
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x0015D4AC File Offset: 0x0015B6AC
		public void Close()
		{
			this.IsOpen = false;
			Singleton<DryingRackCanvas>.Instance.SetIsOpen(null, false);
			this.SetPlayerUser(null);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.2f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.2f);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			Singleton<CompassManager>.Instance.SetVisible(true);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x0015D52E File Offset: 0x0015B72E
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			this.RpcWriter___Server_SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
			this.RpcLogic___SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x0015D554 File Offset: 0x0015B754
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetStoredInstance_Internal_2652194801(conn, itemSlotIndex, instance);
				this.RpcLogic___SetStoredInstance_Internal_2652194801(conn, itemSlotIndex, instance);
			}
			else
			{
				this.RpcWriter___Target_SetStoredInstance_Internal_2652194801(conn, itemSlotIndex, instance);
				this.RpcLogic___SetStoredInstance_Internal_2652194801(conn, itemSlotIndex, instance);
			}
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x0015D5B3 File Offset: 0x0015B7B3
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Server_SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x0015D5D1 File Offset: 0x0015B7D1
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x0015D5EF File Offset: 0x0015B7EF
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			this.RpcWriter___Server_SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			this.RpcLogic___SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x0015D628 File Offset: 0x0015B828
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetSlotLocked_Internal_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
				this.RpcLogic___SetSlotLocked_Internal_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			}
			else
			{
				this.RpcWriter___Target_SetSlotLocked_Internal_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
				this.RpcLogic___SetSlotLocked_Internal_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			}
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x0015D6A8 File Offset: 0x0015B8A8
		public override string GetSaveString()
		{
			return new DryingRackData(base.GUID, base.ItemInstance, 0, base.OwnerGrid, this.OriginCoordinate, this.Rotation, new ItemSet(new List<ItemSlot>
			{
				this.InputSlot
			}), new ItemSet(new List<ItemSlot>
			{
				this.OutputSlot
			}), this.DryingOperations.ToArray()).GetJson(true);
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x0015D718 File Offset: 0x0015B918
		public override List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			if (this.Configuration.ShouldSave())
			{
				list.Add("Configuration.json");
				((ISaveable)this).WriteSubfile(parentFolderPath, "Configuration", this.Configuration.GetSaveString());
			}
			list.AddRange(base.WriteData(parentFolderPath));
			return list;
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x0015D7CC File Offset: 0x0015B9CC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.DryingRackAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.DryingRackAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField = new SyncVar<NetworkObject>(this, 2U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<CurrentPlayerConfigurer>k__BackingField);
			this.syncVar___<PlayerUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<PlayerUserObject>k__BackingField);
			this.syncVar___<NPCUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<NPCUserObject>k__BackingField);
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SetConfigurer_3323014238));
			base.RegisterServerRpc(9U, new ServerRpcDelegate(this.RpcReader___Server_TryEndOperation_4146970406));
			base.RegisterServerRpc(10U, new ServerRpcDelegate(this.RpcReader___Server_SendOperation_1307702229));
			base.RegisterTargetRpc(11U, new ClientRpcDelegate(this.RpcReader___Target_PleaseReceiveOp_1575047616));
			base.RegisterObserversRpc(12U, new ClientRpcDelegate(this.RpcReader___Observers_PleaseReceiveOp_1575047616));
			base.RegisterObserversRpc(13U, new ClientRpcDelegate(this.RpcReader___Observers_RemoveOperation_3316948804));
			base.RegisterObserversRpc(14U, new ClientRpcDelegate(this.RpcReader___Observers_SetOperationQuantity_1692629761));
			base.RegisterServerRpc(15U, new ServerRpcDelegate(this.RpcReader___Server_SetPlayerUser_3323014238));
			base.RegisterServerRpc(16U, new ServerRpcDelegate(this.RpcReader___Server_SetNPCUser_3323014238));
			base.RegisterServerRpc(17U, new ServerRpcDelegate(this.RpcReader___Server_SetStoredInstance_2652194801));
			base.RegisterObserversRpc(18U, new ClientRpcDelegate(this.RpcReader___Observers_SetStoredInstance_Internal_2652194801));
			base.RegisterTargetRpc(19U, new ClientRpcDelegate(this.RpcReader___Target_SetStoredInstance_Internal_2652194801));
			base.RegisterServerRpc(20U, new ServerRpcDelegate(this.RpcReader___Server_SetItemSlotQuantity_1692629761));
			base.RegisterObserversRpc(21U, new ClientRpcDelegate(this.RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761));
			base.RegisterServerRpc(22U, new ServerRpcDelegate(this.RpcReader___Server_SetSlotLocked_3170825843));
			base.RegisterTargetRpc(23U, new ClientRpcDelegate(this.RpcReader___Target_SetSlotLocked_Internal_3170825843));
			base.RegisterObserversRpc(24U, new ClientRpcDelegate(this.RpcReader___Observers_SetSlotLocked_Internal_3170825843));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.ObjectScripts.DryingRack));
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x0015DA0A File Offset: 0x0015BC0A
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.DryingRackAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.DryingRackAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetRegistered();
			this.syncVar___<PlayerUserObject>k__BackingField.SetRegistered();
			this.syncVar___<NPCUserObject>k__BackingField.SetRegistered();
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x0015DA44 File Offset: 0x0015BC44
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x0015DA54 File Offset: 0x0015BC54
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
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
			writer.WriteNetworkObject(player);
			base.SendServerRpc(8U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x0015DAFB File Offset: 0x0015BCFB
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			this.CurrentPlayerConfigurer = player;
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x0015DB04 File Offset: 0x0015BD04
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject player = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x0015DB44 File Offset: 0x0015BD44
		private void RpcWriter___Server_TryEndOperation_4146970406(int operationIndex, bool allowSplitting, EQuality quality, int requestID)
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
			writer.WriteInt32(operationIndex, AutoPackType.Packed);
			writer.WriteBoolean(allowSplitting);
			writer.Write___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generated(quality);
			writer.WriteInt32(requestID, AutoPackType.Packed);
			base.SendServerRpc(9U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x0015DC1C File Offset: 0x0015BE1C
		public void RpcLogic___TryEndOperation_4146970406(int operationIndex, bool allowSplitting, EQuality quality, int requestID)
		{
			if (this.requestIDs.Contains(requestID))
			{
				return;
			}
			this.requestIDs.Add(requestID);
			if (operationIndex >= this.DryingOperations.Count)
			{
				Console.LogError("Invalid operation index: " + operationIndex.ToString(), null);
				return;
			}
			DryingOperation dryingOperation = this.DryingOperations[operationIndex];
			int outputCapacityForOperation = this.GetOutputCapacityForOperation(dryingOperation, quality);
			int num = Mathf.Min(dryingOperation.Quantity, outputCapacityForOperation);
			if (num == 0)
			{
				Console.LogWarning("No space in output slot for operation: " + operationIndex.ToString(), null);
				return;
			}
			if (!allowSplitting && num < dryingOperation.Quantity)
			{
				Console.LogWarning("Operation would be split, but splitting is not allowed", null);
				return;
			}
			QualityItemInstance qualityItemInstance = Registry.GetItem(dryingOperation.ItemID).GetDefaultInstance(num) as QualityItemInstance;
			qualityItemInstance.SetQuality(quality);
			this.OutputSlot.InsertItem(qualityItemInstance);
			if (num == dryingOperation.Quantity)
			{
				this.RemoveOperation(this.DryingOperations.IndexOf(dryingOperation));
				return;
			}
			this.SetOperationQuantity(this.DryingOperations.IndexOf(dryingOperation), dryingOperation.Quantity - num);
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x0015DD24 File Offset: 0x0015BF24
		private void RpcReader___Server_TryEndOperation_4146970406(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int operationIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool allowSplitting = PooledReader0.ReadBoolean();
			EQuality quality = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generateds(PooledReader0);
			int requestID = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___TryEndOperation_4146970406(operationIndex, allowSplitting, quality, requestID);
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x0015DDA0 File Offset: 0x0015BFA0
		private void RpcWriter___Server_SendOperation_1307702229(DryingOperation op)
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
			writer.Write___ScheduleOne.ObjectScripts.DryingOperationFishNet.Serializing.Generated(op);
			base.SendServerRpc(10U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005313 RID: 21267 RVA: 0x0015DE47 File Offset: 0x0015C047
		private void RpcLogic___SendOperation_1307702229(DryingOperation op)
		{
			this.PleaseReceiveOp(null, op);
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x0015DE54 File Offset: 0x0015C054
		private void RpcReader___Server_SendOperation_1307702229(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			DryingOperation op = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.DryingOperationFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendOperation_1307702229(op);
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x0015DE88 File Offset: 0x0015C088
		private void RpcWriter___Target_PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op)
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
			writer.Write___ScheduleOne.ObjectScripts.DryingOperationFishNet.Serializing.Generated(op);
			base.SendTargetRpc(11U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06005316 RID: 21270 RVA: 0x0015DF40 File Offset: 0x0015C140
		private void RpcLogic___PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op)
		{
			if (op.Quantity == 0)
			{
				Console.LogWarning("Operation quantity is 0. Ignoring", null);
				return;
			}
			this.DryingOperations.Add(op);
			if (this.onOperationStart != null)
			{
				this.onOperationStart(op);
			}
			if (this.onOperationsChanged != null)
			{
				this.onOperationsChanged();
			}
			this.RefreshHangingVisuals();
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x0015DF9C File Offset: 0x0015C19C
		private void RpcReader___Target_PleaseReceiveOp_1575047616(PooledReader PooledReader0, Channel channel)
		{
			DryingOperation op = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.DryingOperationFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___PleaseReceiveOp_1575047616(base.LocalConnection, op);
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x0015DFD4 File Offset: 0x0015C1D4
		private void RpcWriter___Observers_PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op)
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
			writer.Write___ScheduleOne.ObjectScripts.DryingOperationFishNet.Serializing.Generated(op);
			base.SendObserversRpc(12U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06005319 RID: 21273 RVA: 0x0015E08C File Offset: 0x0015C28C
		private void RpcReader___Observers_PleaseReceiveOp_1575047616(PooledReader PooledReader0, Channel channel)
		{
			DryingOperation op = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.DryingOperationFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___PleaseReceiveOp_1575047616(null, op);
		}

		// Token: 0x0600531A RID: 21274 RVA: 0x0015E0C0 File Offset: 0x0015C2C0
		private void RpcWriter___Observers_RemoveOperation_3316948804(int opIndex)
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
			writer.WriteInt32(opIndex, AutoPackType.Packed);
			base.SendObserversRpc(13U, writer, channel, DataOrderType.Default, false, true, false);
			writer.Store();
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x0015E17C File Offset: 0x0015C37C
		private void RpcLogic___RemoveOperation_3316948804(int opIndex)
		{
			if (opIndex < this.DryingOperations.Count)
			{
				DryingOperation dryingOperation = this.DryingOperations[opIndex];
				this.DryingOperations.Remove(dryingOperation);
				if (this.onOperationComplete != null)
				{
					this.onOperationComplete(dryingOperation);
				}
				if (this.onOperationsChanged != null)
				{
					this.onOperationsChanged();
				}
				this.RefreshHangingVisuals();
				return;
			}
			Console.LogError("Invalid operation index: " + opIndex.ToString(), null);
		}

		// Token: 0x0600531C RID: 21276 RVA: 0x0015E1F8 File Offset: 0x0015C3F8
		private void RpcReader___Observers_RemoveOperation_3316948804(PooledReader PooledReader0, Channel channel)
		{
			int opIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___RemoveOperation_3316948804(opIndex);
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x0015E238 File Offset: 0x0015C438
		private void RpcWriter___Observers_SetOperationQuantity_1692629761(int opIndex, int quantity)
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
			writer.WriteInt32(opIndex, AutoPackType.Packed);
			writer.WriteInt32(quantity, AutoPackType.Packed);
			base.SendObserversRpc(14U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600531E RID: 21278 RVA: 0x0015E308 File Offset: 0x0015C508
		private void RpcLogic___SetOperationQuantity_1692629761(int opIndex, int quantity)
		{
			if (opIndex < this.DryingOperations.Count)
			{
				this.DryingOperations[opIndex].Quantity = quantity;
				if (this.onOperationsChanged != null)
				{
					this.onOperationsChanged();
				}
				this.RefreshHangingVisuals();
				return;
			}
			Console.LogError("Invalid operation index: " + opIndex.ToString(), null);
		}

		// Token: 0x0600531F RID: 21279 RVA: 0x0015E368 File Offset: 0x0015C568
		private void RpcReader___Observers_SetOperationQuantity_1692629761(PooledReader PooledReader0, Channel channel)
		{
			int opIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			int quantity = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetOperationQuantity_1692629761(opIndex, quantity);
		}

		// Token: 0x06005320 RID: 21280 RVA: 0x0015E3B4 File Offset: 0x0015C5B4
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
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
			writer.WriteNetworkObject(playerObject);
			base.SendServerRpc(15U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x0015E45B File Offset: 0x0015C65B
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			this.PlayerUserObject = playerObject;
		}

		// Token: 0x06005322 RID: 21282 RVA: 0x0015E464 File Offset: 0x0015C664
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x0015E4A4 File Offset: 0x0015C6A4
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
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
			writer.WriteNetworkObject(npcObject);
			base.SendServerRpc(16U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x0015E54B File Offset: 0x0015C74B
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			this.NPCUserObject = npcObject;
		}

		// Token: 0x06005325 RID: 21285 RVA: 0x0015E554 File Offset: 0x0015C754
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject npcObject = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x06005326 RID: 21286 RVA: 0x0015E594 File Offset: 0x0015C794
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
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
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteItemInstance(instance);
			base.SendServerRpc(17U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x0015E65A File Offset: 0x0015C85A
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetStoredInstance_Internal(null, itemSlotIndex, instance);
				return;
			}
			this.SetStoredInstance_Internal(conn, itemSlotIndex, instance);
		}

		// Token: 0x06005328 RID: 21288 RVA: 0x0015E684 File Offset: 0x0015C884
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkConnection conn2 = PooledReader0.ReadNetworkConnection();
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			ItemInstance instance = PooledReader0.ReadItemInstance();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetStoredInstance_2652194801(conn2, itemSlotIndex, instance);
		}

		// Token: 0x06005329 RID: 21289 RVA: 0x0015E6EC File Offset: 0x0015C8EC
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
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
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteItemInstance(instance);
			base.SendObserversRpc(18U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600532A RID: 21290 RVA: 0x0015E7B4 File Offset: 0x0015C9B4
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (instance != null)
			{
				this.ItemSlots[itemSlotIndex].SetStoredItem(instance, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].ClearStoredInstance(true);
		}

		// Token: 0x0600532B RID: 21291 RVA: 0x0015E7E0 File Offset: 0x0015C9E0
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			ItemInstance instance = PooledReader0.ReadItemInstance();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetStoredInstance_Internal_2652194801(null, itemSlotIndex, instance);
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x0015E834 File Offset: 0x0015CA34
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
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
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteItemInstance(instance);
			base.SendTargetRpc(19U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x0015E8FC File Offset: 0x0015CAFC
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			ItemInstance instance = PooledReader0.ReadItemInstance();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetStoredInstance_Internal_2652194801(base.LocalConnection, itemSlotIndex, instance);
		}

		// Token: 0x0600532E RID: 21294 RVA: 0x0015E954 File Offset: 0x0015CB54
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
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
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteInt32(quantity, AutoPackType.Packed);
			base.SendServerRpc(20U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600532F RID: 21295 RVA: 0x0015EA12 File Offset: 0x0015CC12
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			this.SetItemSlotQuantity_Internal(itemSlotIndex, quantity);
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x0015EA1C File Offset: 0x0015CC1C
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			int quantity = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06005331 RID: 21297 RVA: 0x0015EA78 File Offset: 0x0015CC78
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
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
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteInt32(quantity, AutoPackType.Packed);
			base.SendObserversRpc(21U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06005332 RID: 21298 RVA: 0x0015EB45 File Offset: 0x0015CD45
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			this.ItemSlots[itemSlotIndex].SetQuantity(quantity, true);
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x0015EB5C File Offset: 0x0015CD5C
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			int quantity = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x0015EBB4 File Offset: 0x0015CDB4
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
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
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteBoolean(locked);
			writer.WriteNetworkObject(lockOwner);
			writer.WriteString(lockReason);
			base.SendServerRpc(22U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x0015EC94 File Offset: 0x0015CE94
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetSlotLocked_Internal(null, itemSlotIndex, locked, lockOwner, lockReason);
				return;
			}
			this.SetSlotLocked_Internal(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x0015ECC4 File Offset: 0x0015CEC4
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkConnection conn2 = PooledReader0.ReadNetworkConnection();
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool locked = PooledReader0.ReadBoolean();
			NetworkObject lockOwner = PooledReader0.ReadNetworkObject();
			string lockReason = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetSlotLocked_3170825843(conn2, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06005337 RID: 21303 RVA: 0x0015ED4C File Offset: 0x0015CF4C
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
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
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteBoolean(locked);
			writer.WriteNetworkObject(lockOwner);
			writer.WriteString(lockReason);
			base.SendTargetRpc(23U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06005338 RID: 21304 RVA: 0x0015EE2D File Offset: 0x0015D02D
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (locked)
			{
				this.ItemSlots[itemSlotIndex].ApplyLock(lockOwner, lockReason, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].RemoveLock(true);
		}

		// Token: 0x06005339 RID: 21305 RVA: 0x0015EE5C File Offset: 0x0015D05C
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool locked = PooledReader0.ReadBoolean();
			NetworkObject lockOwner = PooledReader0.ReadNetworkObject();
			string lockReason = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetSlotLocked_Internal_3170825843(base.LocalConnection, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x0015EED8 File Offset: 0x0015D0D8
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
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
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteBoolean(locked);
			writer.WriteNetworkObject(lockOwner);
			writer.WriteString(lockReason);
			base.SendObserversRpc(24U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600533B RID: 21307 RVA: 0x0015EFBC File Offset: 0x0015D1BC
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool locked = PooledReader0.ReadBoolean();
			NetworkObject lockOwner = PooledReader0.ReadNetworkObject();
			string lockReason = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetSlotLocked_Internal_3170825843(null, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x0600533C RID: 21308 RVA: 0x0015F030 File Offset: 0x0015D230
		// (set) Token: 0x0600533D RID: 21309 RVA: 0x0015F038 File Offset: 0x0015D238
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			get
			{
				return this.<NPCUserObject>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<NPCUserObject>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<NPCUserObject>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x0015F074 File Offset: 0x0015D274
		public virtual bool DryingRack(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 2U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<CurrentPlayerConfigurer>k__BackingField(this.syncVar___<CurrentPlayerConfigurer>k__BackingField.GetValue(true), true);
					return true;
				}
				NetworkObject value = PooledReader0.ReadNetworkObject();
				this.sync___set_value_<CurrentPlayerConfigurer>k__BackingField(value, Boolean2);
				return true;
			}
			else if (UInt321 == 1U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<PlayerUserObject>k__BackingField(this.syncVar___<PlayerUserObject>k__BackingField.GetValue(true), true);
					return true;
				}
				NetworkObject value2 = PooledReader0.ReadNetworkObject();
				this.sync___set_value_<PlayerUserObject>k__BackingField(value2, Boolean2);
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
					this.sync___set_value_<NPCUserObject>k__BackingField(this.syncVar___<NPCUserObject>k__BackingField.GetValue(true), true);
					return true;
				}
				NetworkObject value3 = PooledReader0.ReadNetworkObject();
				this.sync___set_value_<NPCUserObject>k__BackingField(value3, Boolean2);
				return true;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x0600533F RID: 21311 RVA: 0x0015F14E File Offset: 0x0015D34E
		// (set) Token: 0x06005340 RID: 21312 RVA: 0x0015F156 File Offset: 0x0015D356
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			get
			{
				return this.<PlayerUserObject>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<PlayerUserObject>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<PlayerUserObject>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06005341 RID: 21313 RVA: 0x0015F192 File Offset: 0x0015D392
		// (set) Token: 0x06005342 RID: 21314 RVA: 0x0015F19A File Offset: 0x0015D39A
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			get
			{
				return this.<CurrentPlayerConfigurer>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<CurrentPlayerConfigurer>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x06005343 RID: 21315 RVA: 0x0015F1D8 File Offset: 0x0015D3D8
		protected virtual void dll()
		{
			base.Awake();
			if (!this.isGhost)
			{
				this.InputSlot = new ItemSlot();
				this.InputSlot.SetSlotOwner(this);
				this.InputSlot.AddFilter(new ItemFilter_Dryable());
				this.InputVisuals.AddSlot(this.InputSlot, false);
				this.OutputSlot = new ItemSlot();
				this.OutputSlot.SetSlotOwner(this);
				this.OutputSlot.SetIsAddLocked(true);
				this.OutputVisuals.AddSlot(this.OutputSlot, false);
				this.InputSlots.Add(this.InputSlot);
				this.OutputSlots.Add(this.OutputSlot);
				this.HangingVisuals.BlockRefreshes = true;
				this.hangSlots = new ItemSlot[this.HangAlignments.Length];
				for (int i = 0; i < this.HangAlignments.Length; i++)
				{
					this.hangSlots[i] = new ItemSlot();
					this.HangingVisuals.AddSlot(this.hangSlots[i], false);
				}
			}
		}

		// Token: 0x04003DED RID: 15853
		public const int DRY_MINS_PER_TIER = 720;

		// Token: 0x04003DEE RID: 15854
		[Header("Settings")]
		public int ItemCapacity = 20;

		// Token: 0x04003DEF RID: 15855
		[Header("References")]
		public Transform[] CameraPositions;

		// Token: 0x04003DF0 RID: 15856
		public InteractableObject IntObj;

		// Token: 0x04003DF1 RID: 15857
		public Transform uiPoint;

		// Token: 0x04003DF2 RID: 15858
		public Transform[] accessPoints;

		// Token: 0x04003DF3 RID: 15859
		public StorageVisualizer InputVisuals;

		// Token: 0x04003DF4 RID: 15860
		public StorageVisualizer OutputVisuals;

		// Token: 0x04003DF5 RID: 15861
		public StorageVisualizer HangingVisuals;

		// Token: 0x04003DF6 RID: 15862
		public Transform[] HangAlignments;

		// Token: 0x04003DF7 RID: 15863
		public ConfigurationReplicator configReplicator;

		// Token: 0x04003DF8 RID: 15864
		[Header("UI")]
		public DryingRackUIElement WorldspaceUIPrefab;

		// Token: 0x04003DF9 RID: 15865
		public Sprite typeIcon;

		// Token: 0x04003E08 RID: 15880
		public Action<DryingOperation> onOperationStart;

		// Token: 0x04003E09 RID: 15881
		public Action<DryingOperation> onOperationComplete;

		// Token: 0x04003E0A RID: 15882
		public Action onOperationsChanged;

		// Token: 0x04003E0B RID: 15883
		private ItemSlot[] hangSlots;

		// Token: 0x04003E0C RID: 15884
		private List<int> requestIDs = new List<int>();

		// Token: 0x04003E0D RID: 15885
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003E0E RID: 15886
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003E0F RID: 15887
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04003E10 RID: 15888
		private bool dll_Excuted;

		// Token: 0x04003E11 RID: 15889
		private bool dll_Excuted;
	}
}
