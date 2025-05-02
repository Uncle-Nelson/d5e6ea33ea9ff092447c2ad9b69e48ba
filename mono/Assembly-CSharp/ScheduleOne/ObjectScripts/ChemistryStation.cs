using System;
using System.Collections.Generic;
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
using ScheduleOne.Misc;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.Tools;
using ScheduleOne.Trash;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Management;
using ScheduleOne.UI.Stations;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BC8 RID: 3016
	public class ChemistryStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06005218 RID: 21016 RVA: 0x00159DF8 File Offset: 0x00157FF8
		public bool isOpen
		{
			get
			{
				return this.PlayerUserObject == Player.Local.NetworkObject;
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06005219 RID: 21017 RVA: 0x00159E0F File Offset: 0x0015800F
		// (set) Token: 0x0600521A RID: 21018 RVA: 0x00159E17 File Offset: 0x00158017
		public List<ItemSlot> ItemSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x0600521B RID: 21019 RVA: 0x00159E20 File Offset: 0x00158020
		// (set) Token: 0x0600521C RID: 21020 RVA: 0x00159E28 File Offset: 0x00158028
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

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x0600521D RID: 21021 RVA: 0x00159E32 File Offset: 0x00158032
		// (set) Token: 0x0600521E RID: 21022 RVA: 0x00159E3A File Offset: 0x0015803A
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

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x0600521F RID: 21023 RVA: 0x00159E44 File Offset: 0x00158044
		// (set) Token: 0x06005220 RID: 21024 RVA: 0x00159E4C File Offset: 0x0015804C
		public ChemistryCookOperation CurrentCookOperation { get; set; }

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06005221 RID: 21025 RVA: 0x00150487 File Offset: 0x0014E687
		public string Name
		{
			get
			{
				return base.ItemInstance.Name;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06005222 RID: 21026 RVA: 0x00159E55 File Offset: 0x00158055
		// (set) Token: 0x06005223 RID: 21027 RVA: 0x00159E5D File Offset: 0x0015805D
		public List<ItemSlot> InputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06005224 RID: 21028 RVA: 0x00159E66 File Offset: 0x00158066
		// (set) Token: 0x06005225 RID: 21029 RVA: 0x00159E6E File Offset: 0x0015806E
		public List<ItemSlot> OutputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06005226 RID: 21030 RVA: 0x00159E77 File Offset: 0x00158077
		public Transform LinkOrigin
		{
			get
			{
				return this.UIPoint;
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06005227 RID: 21031 RVA: 0x00159E7F File Offset: 0x0015807F
		public Transform[] AccessPoints
		{
			get
			{
				return this.accessPoints;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06005228 RID: 21032 RVA: 0x00159E87 File Offset: 0x00158087
		public bool Selectable { get; } = 1;

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06005229 RID: 21033 RVA: 0x00159E8F File Offset: 0x0015808F
		// (set) Token: 0x0600522A RID: 21034 RVA: 0x00159E97 File Offset: 0x00158097
		public bool IsAcceptingItems { get; set; } = true;

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x0600522B RID: 21035 RVA: 0x00159EA0 File Offset: 0x001580A0
		public EntityConfiguration Configuration
		{
			get
			{
				return this.stationConfiguration;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x0600522C RID: 21036 RVA: 0x00159EA8 File Offset: 0x001580A8
		// (set) Token: 0x0600522D RID: 21037 RVA: 0x00159EB0 File Offset: 0x001580B0
		protected ChemistryStationConfiguration stationConfiguration { get; set; }

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600522E RID: 21038 RVA: 0x00159EB9 File Offset: 0x001580B9
		public ConfigurationReplicator ConfigReplicator
		{
			get
			{
				return this.configReplicator;
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600522F RID: 21039 RVA: 0x000105B0 File Offset: 0x0000E7B0
		public EConfigurableType ConfigurableType
		{
			get
			{
				return EConfigurableType.ChemistryStation;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06005230 RID: 21040 RVA: 0x00159EC1 File Offset: 0x001580C1
		// (set) Token: 0x06005231 RID: 21041 RVA: 0x00159EC9 File Offset: 0x001580C9
		public WorldspaceUIElement WorldspaceUI { get; set; }

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06005232 RID: 21042 RVA: 0x00159ED2 File Offset: 0x001580D2
		// (set) Token: 0x06005233 RID: 21043 RVA: 0x00159EDA File Offset: 0x001580DA
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

		// Token: 0x06005234 RID: 21044 RVA: 0x00159EE4 File Offset: 0x001580E4
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
			this.RpcWriter___Server_SetConfigurer_3323014238(player);
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06005235 RID: 21045 RVA: 0x00159EFA File Offset: 0x001580FA
		public Sprite TypeIcon
		{
			get
			{
				return this.typeIcon;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06005236 RID: 21046 RVA: 0x000AEDCB File Offset: 0x000ACFCB
		public Transform Transform
		{
			get
			{
				return base.transform;
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06005237 RID: 21047 RVA: 0x00159F02 File Offset: 0x00158102
		public Transform UIPoint
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06005238 RID: 21048 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CanBeSelected
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x00159F0C File Offset: 0x0015810C
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ObjectScripts.ChemistryStation_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x00159F2C File Offset: 0x0015812C
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
				GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 4);
				TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance2.onMinutePass = (Action)Delegate.Combine(instance2.onMinutePass, new Action(this.MinPass));
				TimeManager instance3 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance3.onTimeSkip = (Action<int>)Delegate.Combine(instance3.onTimeSkip, new Action<int>(this.TimeSkipped));
				base.ParentProperty.AddConfigurable(this);
				this.stationConfiguration = new ChemistryStationConfiguration(this.configReplicator, this, this);
				this.CreateWorldspaceUI();
			}
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x00159FDF File Offset: 0x001581DF
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			((IItemSlotOwner)this).SendItemsToClient(connection);
			if (this.CurrentCookOperation != null)
			{
				this.SetCookOperation(connection, this.CurrentCookOperation);
			}
			this.SendConfigurationToClient(connection);
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x0015A00C File Offset: 0x0015820C
		public void SendConfigurationToClient(NetworkConnection conn)
		{
			ChemistryStation.<>c__DisplayClass101_0 CS$<>8__locals1 = new ChemistryStation.<>c__DisplayClass101_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.conn = conn;
			if (CS$<>8__locals1.conn.IsHost)
			{
				return;
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SendConfigurationToClient>g__WaitForConfig|0());
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x0015A04C File Offset: 0x0015824C
		public override bool CanBeDestroyed(out string reason)
		{
			if (((IItemSlotOwner)this).GetTotalItemCount() > 0)
			{
				reason = "Contains items";
				return false;
			}
			if (((IUsable)this).IsInUse)
			{
				reason = "Currently in use";
				return false;
			}
			if (this.CurrentCookOperation != null)
			{
				reason = "Currently cooking";
				return false;
			}
			return base.CanBeDestroyed(out reason);
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x0015A08C File Offset: 0x0015828C
		public override void DestroyItem(bool callOnServer = true)
		{
			GameInput.DeregisterExitListener(new GameInput.ExitDelegate(this.Exit));
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance2.onTimeSkip = (Action<int>)Delegate.Remove(instance2.onTimeSkip, new Action<int>(this.TimeSkipped));
			if (this.Configuration != null)
			{
				this.Configuration.Destroy();
				this.DestroyWorldspaceUI();
				base.ParentProperty.RemoveConfigurable(this);
			}
			base.DestroyItem(callOnServer);
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x0015A124 File Offset: 0x00158324
		protected virtual void MinPass()
		{
			this.Alarm.FlashScreen = false;
			if (this.CurrentCookOperation != null)
			{
				this.CurrentCookOperation.Progress(1);
				base.HasChanged = true;
				float t = Mathf.Clamp01((float)this.CurrentCookOperation.CurrentTime / (float)this.CurrentCookOperation.Recipe.CookTime_Mins);
				this.BoilingFlask.LiquidContainer.SetLiquidColor(Color.Lerp(this.CurrentCookOperation.StartLiquidColor, this.CurrentCookOperation.Recipe.FinalLiquidColor, t), true, true);
				if (InstanceFinder.IsServer && this.CurrentCookOperation.CurrentTime >= this.CurrentCookOperation.Recipe.CookTime_Mins)
				{
					this.FinalizeOperation();
				}
			}
			this.UpdateClock();
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x0015A1E4 File Offset: 0x001583E4
		private void TimeSkipped(int minsSkippped)
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			for (int i = 0; i < minsSkippped; i++)
			{
				this.MinPass();
			}
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x0015A20C File Offset: 0x0015840C
		private void UpdateClock()
		{
			if (this.CurrentCookOperation == null)
			{
				this.Alarm.SetScreenLit(false);
				this.Alarm.DisplayText(string.Empty);
				return;
			}
			int num = this.CurrentCookOperation.Recipe.CookTime_Mins - this.CurrentCookOperation.CurrentTime;
			num = Mathf.Max(0, num);
			this.Alarm.DisplayMinutes(num);
			if (this.CurrentCookOperation.CurrentTime >= this.CurrentCookOperation.Recipe.CookTime_Mins)
			{
				this.Alarm.FlashScreen = true;
				this.Burner.SetDialPosition(0f);
				return;
			}
			this.Alarm.SetScreenLit(true);
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x0015A2B5 File Offset: 0x001584B5
		protected virtual void Update()
		{
			this.StaticFunnel.gameObject.SetActive(!this.LabStand.Funnel.gameObject.activeSelf);
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x0015A2E0 File Offset: 0x001584E0
		public Beaker CreateBeaker()
		{
			Beaker component = Object.Instantiate<GameObject>(this.BeakerPrefab, this.BeakerAlignmentTransform.position, this.BeakerAlignmentTransform.rotation).GetComponent<Beaker>();
			component.Anchor = this.AnchorRb;
			component.transform.SetParent(this.ItemContainer);
			component.Constraint.Container = this.ItemContainer;
			return component;
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x0015A341 File Offset: 0x00158541
		public StirringRod CreateStirringRod()
		{
			StirringRod component = Object.Instantiate<GameObject>(this.StirringRodPrefab.gameObject, this.BeakerAlignmentTransform).GetComponent<StirringRod>();
			component.transform.localPosition = Vector3.zero;
			component.transform.localRotation = Quaternion.identity;
			return component;
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x0015A37E File Offset: 0x0015857E
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCookOperation(ChemistryCookOperation op)
		{
			this.RpcWriter___Server_SendCookOperation_3552222198(op);
			this.RpcLogic___SendCookOperation_3552222198(op);
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x0015A394 File Offset: 0x00158594
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetCookOperation(NetworkConnection conn, ChemistryCookOperation operation)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetCookOperation_1024887225(conn, operation);
				this.RpcLogic___SetCookOperation_1024887225(conn, operation);
			}
			else
			{
				this.RpcWriter___Target_SetCookOperation_1024887225(conn, operation);
			}
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x0015A3D8 File Offset: 0x001585D8
		[ObserversRpc]
		public void FinalizeOperation()
		{
			this.RpcWriter___Observers_FinalizeOperation_2166136261();
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x0015A3EC File Offset: 0x001585EC
		public void ResetStation()
		{
			this.BoilingFlask.SetRecipe(null);
			this.BoilingFlask.ResetContents();
			this.BoilingFlask.SetTemperature(0f);
			this.BoilingFlask.LockTemperature = false;
			this.Burner.SetDialPosition(0f);
			this.Burner.LockDial = false;
			this.LabStand.SetPosition(1f);
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x0015A458 File Offset: 0x00158658
		public bool DoesOutputHaveSpace(StationRecipe recipe)
		{
			StorableItemInstance productInstance = recipe.GetProductInstance(this.GetIngredients());
			return this.OutputSlot.GetCapacityForItem(productInstance) >= recipe.Product.Quantity;
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x0015A490 File Offset: 0x00158690
		public List<ItemInstance> GetIngredients()
		{
			List<ItemInstance> list = new List<ItemInstance>();
			foreach (ItemSlot itemSlot in this.IngredientSlots)
			{
				if (itemSlot.ItemInstance != null)
				{
					list.Add(itemSlot.ItemInstance);
				}
			}
			return list;
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x0015A4D4 File Offset: 0x001586D4
		public bool HasIngredientsForRecipe(StationRecipe recipe)
		{
			List<ItemInstance> ingredients = this.GetIngredients();
			return recipe.DoIngredientsSuffice(ingredients);
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x0015A4F0 File Offset: 0x001586F0
		public void CreateTrash(List<StationItem> mixerItems)
		{
			for (int i = 0; i < mixerItems.Count; i++)
			{
				if (!(mixerItems[i].TrashPrefab == null))
				{
					Vector3 posiiton = this.TrashSpawnVolume.transform.TransformPoint(new Vector3(Random.Range(-this.TrashSpawnVolume.size.x / 2f, this.TrashSpawnVolume.size.x / 2f), 0f, Random.Range(-this.TrashSpawnVolume.size.z / 2f, this.TrashSpawnVolume.size.z / 2f)));
					Vector3 vector = this.TrashSpawnVolume.transform.forward;
					vector = Quaternion.Euler(0f, Random.Range(-45f, 45f), 0f) * vector;
					float d = Random.Range(0.25f, 0.4f);
					NetworkSingleton<TrashManager>.Instance.CreateTrashItem(mixerItems[i].TrashPrefab.ID, posiiton, Random.rotation, vector * d, "", false);
				}
			}
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x0015A620 File Offset: 0x00158820
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

		// Token: 0x0600524E RID: 21070 RVA: 0x0015A67A File Offset: 0x0015887A
		public void Interacted()
		{
			if (((IUsable)this).IsInUse || Singleton<ManagementClipboard>.Instance.IsEquipped)
			{
				return;
			}
			this.Open();
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x0015A697 File Offset: 0x00158897
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.isOpen)
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

		// Token: 0x06005250 RID: 21072 RVA: 0x0015A6C4 File Offset: 0x001588C4
		public void Open()
		{
			this.SetPlayerUser(Player.Local.NetworkObject);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.CameraPosition_Default.position, this.CameraPosition_Default.rotation, 0.2f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(65f, 0.2f);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			Singleton<ChemistryStationCanvas>.Instance.Open(this);
			Singleton<CompassManager>.Instance.SetVisible(false);
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x0015A764 File Offset: 0x00158964
		public void Close()
		{
			Singleton<ChemistryStationCanvas>.Instance.Close(true);
			this.LabStand.SetPosition(1f);
			this.SetPlayerUser(null);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.2f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.2f);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			Singleton<CompassManager>.Instance.SetVisible(true);
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x0015A7EE File Offset: 0x001589EE
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
			this.RpcWriter___Server_SetPlayerUser_3323014238(playerObject);
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x0015A804 File Offset: 0x00158A04
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
			this.RpcWriter___Server_SetNPCUser_3323014238(npcObject);
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x0015A81A File Offset: 0x00158A1A
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			this.RpcWriter___Server_SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
			this.RpcLogic___SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x0015A840 File Offset: 0x00158A40
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

		// Token: 0x06005256 RID: 21078 RVA: 0x0015A89F File Offset: 0x00158A9F
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Server_SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x0015A8BD File Offset: 0x00158ABD
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x0015A8DB File Offset: 0x00158ADB
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			this.RpcWriter___Server_SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			this.RpcLogic___SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x0015A914 File Offset: 0x00158B14
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

		// Token: 0x0600525A RID: 21082 RVA: 0x0015A994 File Offset: 0x00158B94
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				Console.LogWarning(base.gameObject.name + " already has a worldspace UI element!", null);
			}
			if (base.ParentProperty == null)
			{
				Console.LogError(base.gameObject.name + " is not a child of a property!", null);
				return null;
			}
			ChemistryStationUIElement component = Object.Instantiate<ChemistryStationUIElement>(this.WorldspaceUIPrefab, base.ParentProperty.WorldspaceUIContainer).GetComponent<ChemistryStationUIElement>();
			component.Initialize(this);
			this.WorldspaceUI = component;
			return component;
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x0015AA20 File Offset: 0x00158C20
		public void DestroyWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				this.WorldspaceUI.Destroy();
			}
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x0015AA3C File Offset: 0x00158C3C
		public override string GetSaveString()
		{
			string currentRecipeID = string.Empty;
			EQuality productQuality = EQuality.Standard;
			Color startLiquidColor = Color.clear;
			float liquidLevel = 0f;
			int currentTime = 0;
			if (this.CurrentCookOperation != null)
			{
				currentRecipeID = this.CurrentCookOperation.RecipeID;
				productQuality = this.CurrentCookOperation.ProductQuality;
				startLiquidColor = this.CurrentCookOperation.StartLiquidColor;
				liquidLevel = this.CurrentCookOperation.LiquidLevel;
				currentTime = this.CurrentCookOperation.CurrentTime;
			}
			return new ChemistryStationData(base.GUID, base.ItemInstance, 0, base.OwnerGrid, this.OriginCoordinate, this.Rotation, new ItemSet(this.IngredientSlots), new ItemSet(new List<ItemSlot>
			{
				this.OutputSlot
			}), currentRecipeID, productQuality, startLiquidColor, liquidLevel, currentTime).GetJson(true);
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x0015AAF8 File Offset: 0x00158CF8
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

		// Token: 0x06005261 RID: 21089 RVA: 0x0015AB8C File Offset: 0x00158D8C
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.ChemistryStationAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.ChemistryStationAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField = new SyncVar<NetworkObject>(this, 2U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<CurrentPlayerConfigurer>k__BackingField);
			this.syncVar___<PlayerUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<PlayerUserObject>k__BackingField);
			this.syncVar___<NPCUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<NPCUserObject>k__BackingField);
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SetConfigurer_3323014238));
			base.RegisterServerRpc(9U, new ServerRpcDelegate(this.RpcReader___Server_SendCookOperation_3552222198));
			base.RegisterObserversRpc(10U, new ClientRpcDelegate(this.RpcReader___Observers_SetCookOperation_1024887225));
			base.RegisterTargetRpc(11U, new ClientRpcDelegate(this.RpcReader___Target_SetCookOperation_1024887225));
			base.RegisterObserversRpc(12U, new ClientRpcDelegate(this.RpcReader___Observers_FinalizeOperation_2166136261));
			base.RegisterServerRpc(13U, new ServerRpcDelegate(this.RpcReader___Server_SetPlayerUser_3323014238));
			base.RegisterServerRpc(14U, new ServerRpcDelegate(this.RpcReader___Server_SetNPCUser_3323014238));
			base.RegisterServerRpc(15U, new ServerRpcDelegate(this.RpcReader___Server_SetStoredInstance_2652194801));
			base.RegisterObserversRpc(16U, new ClientRpcDelegate(this.RpcReader___Observers_SetStoredInstance_Internal_2652194801));
			base.RegisterTargetRpc(17U, new ClientRpcDelegate(this.RpcReader___Target_SetStoredInstance_Internal_2652194801));
			base.RegisterServerRpc(18U, new ServerRpcDelegate(this.RpcReader___Server_SetItemSlotQuantity_1692629761));
			base.RegisterObserversRpc(19U, new ClientRpcDelegate(this.RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761));
			base.RegisterServerRpc(20U, new ServerRpcDelegate(this.RpcReader___Server_SetSlotLocked_3170825843));
			base.RegisterTargetRpc(21U, new ClientRpcDelegate(this.RpcReader___Target_SetSlotLocked_Internal_3170825843));
			base.RegisterObserversRpc(22U, new ClientRpcDelegate(this.RpcReader___Observers_SetSlotLocked_Internal_3170825843));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.ObjectScripts.ChemistryStation));
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x0015AD9C File Offset: 0x00158F9C
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.ChemistryStationAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.ChemistryStationAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetRegistered();
			this.syncVar___<PlayerUserObject>k__BackingField.SetRegistered();
			this.syncVar___<NPCUserObject>k__BackingField.SetRegistered();
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x0015ADD6 File Offset: 0x00158FD6
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x0015ADE4 File Offset: 0x00158FE4
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

		// Token: 0x06005265 RID: 21093 RVA: 0x0015AE8B File Offset: 0x0015908B
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			this.CurrentPlayerConfigurer = player;
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x0015AE94 File Offset: 0x00159094
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

		// Token: 0x06005267 RID: 21095 RVA: 0x0015AED4 File Offset: 0x001590D4
		private void RpcWriter___Server_SendCookOperation_3552222198(ChemistryCookOperation op)
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
			writer.Write___ScheduleOne.ObjectScripts.ChemistryCookOperationFishNet.Serializing.Generated(op);
			base.SendServerRpc(9U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x0015AF7B File Offset: 0x0015917B
		public void RpcLogic___SendCookOperation_3552222198(ChemistryCookOperation op)
		{
			this.SetCookOperation(null, op);
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x0015AF88 File Offset: 0x00159188
		private void RpcReader___Server_SendCookOperation_3552222198(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			ChemistryCookOperation op = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.ChemistryCookOperationFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendCookOperation_3552222198(op);
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x0015AFC8 File Offset: 0x001591C8
		private void RpcWriter___Observers_SetCookOperation_1024887225(NetworkConnection conn, ChemistryCookOperation operation)
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
			writer.Write___ScheduleOne.ObjectScripts.ChemistryCookOperationFishNet.Serializing.Generated(operation);
			base.SendObserversRpc(10U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x0015B080 File Offset: 0x00159280
		public void RpcLogic___SetCookOperation_1024887225(NetworkConnection conn, ChemistryCookOperation operation)
		{
			this.CurrentCookOperation = operation;
			this.BoilingFlask.LiquidContainer.SetLiquidLevel(operation.LiquidLevel, false);
			this.BoilingFlask.LiquidContainer.LiquidVolume.liquidColor1 = operation.StartLiquidColor;
			this.BoilingFlask.LiquidContainer.LiquidVolume.liquidColor2 = operation.StartLiquidColor;
			this.BoilingFlask.SetTemperature(operation.Recipe.CookTemperature);
			this.BoilingFlask.LockTemperature = true;
			this.Burner.SetDialPosition(this.CurrentCookOperation.Recipe.CookTemperature / 500f);
			this.Burner.LockDial = true;
			base.HasChanged = true;
			this.UpdateClock();
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x0015B140 File Offset: 0x00159340
		private void RpcReader___Observers_SetCookOperation_1024887225(PooledReader PooledReader0, Channel channel)
		{
			ChemistryCookOperation operation = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.ChemistryCookOperationFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetCookOperation_1024887225(null, operation);
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x0015B17C File Offset: 0x0015937C
		private void RpcWriter___Target_SetCookOperation_1024887225(NetworkConnection conn, ChemistryCookOperation operation)
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
			writer.Write___ScheduleOne.ObjectScripts.ChemistryCookOperationFishNet.Serializing.Generated(operation);
			base.SendTargetRpc(11U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x0015B234 File Offset: 0x00159434
		private void RpcReader___Target_SetCookOperation_1024887225(PooledReader PooledReader0, Channel channel)
		{
			ChemistryCookOperation operation = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.ChemistryCookOperationFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetCookOperation_1024887225(base.LocalConnection, operation);
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x0015B26C File Offset: 0x0015946C
		private void RpcWriter___Observers_FinalizeOperation_2166136261()
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
			base.SendObserversRpc(12U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x0015B318 File Offset: 0x00159518
		public void RpcLogic___FinalizeOperation_2166136261()
		{
			if (this.CurrentCookOperation == null)
			{
				Console.LogWarning("No cook operation to finalize", null);
				return;
			}
			if (InstanceFinder.IsServer)
			{
				StorableItemInstance productInstance = this.CurrentCookOperation.Recipe.GetProductInstance(this.CurrentCookOperation.ProductQuality);
				this.OutputSlot.AddItem(productInstance, false);
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Chemical_Operations_Completed", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Chemical_Operations_Completed") + 1f).ToString(), true);
			}
			this.CurrentCookOperation = null;
			this.ResetStation();
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x0015B3A4 File Offset: 0x001595A4
		private void RpcReader___Observers_FinalizeOperation_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___FinalizeOperation_2166136261();
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x0015B3C4 File Offset: 0x001595C4
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
			base.SendServerRpc(13U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x0015B46B File Offset: 0x0015966B
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			this.PlayerUserObject = playerObject;
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x0015B474 File Offset: 0x00159674
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

		// Token: 0x06005275 RID: 21109 RVA: 0x0015B4B4 File Offset: 0x001596B4
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
			base.SendServerRpc(14U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x0015B55B File Offset: 0x0015975B
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			this.NPCUserObject = npcObject;
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x0015B564 File Offset: 0x00159764
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

		// Token: 0x06005278 RID: 21112 RVA: 0x0015B5A4 File Offset: 0x001597A4
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
			base.SendServerRpc(15U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x0015B66A File Offset: 0x0015986A
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetStoredInstance_Internal(null, itemSlotIndex, instance);
				return;
			}
			this.SetStoredInstance_Internal(conn, itemSlotIndex, instance);
		}

		// Token: 0x0600527A RID: 21114 RVA: 0x0015B694 File Offset: 0x00159894
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

		// Token: 0x0600527B RID: 21115 RVA: 0x0015B6FC File Offset: 0x001598FC
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
			base.SendObserversRpc(16U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x0015B7C4 File Offset: 0x001599C4
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (instance != null)
			{
				this.ItemSlots[itemSlotIndex].SetStoredItem(instance, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].ClearStoredInstance(true);
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x0015B7F0 File Offset: 0x001599F0
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

		// Token: 0x0600527E RID: 21118 RVA: 0x0015B844 File Offset: 0x00159A44
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
			base.SendTargetRpc(17U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600527F RID: 21119 RVA: 0x0015B90C File Offset: 0x00159B0C
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

		// Token: 0x06005280 RID: 21120 RVA: 0x0015B964 File Offset: 0x00159B64
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
			base.SendServerRpc(18U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x0015BA22 File Offset: 0x00159C22
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			this.SetItemSlotQuantity_Internal(itemSlotIndex, quantity);
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x0015BA2C File Offset: 0x00159C2C
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

		// Token: 0x06005283 RID: 21123 RVA: 0x0015BA88 File Offset: 0x00159C88
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
			base.SendObserversRpc(19U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x0015BB55 File Offset: 0x00159D55
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			this.ItemSlots[itemSlotIndex].SetQuantity(quantity, true);
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x0015BB6C File Offset: 0x00159D6C
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

		// Token: 0x06005286 RID: 21126 RVA: 0x0015BBC4 File Offset: 0x00159DC4
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
			base.SendServerRpc(20U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005287 RID: 21127 RVA: 0x0015BCA4 File Offset: 0x00159EA4
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetSlotLocked_Internal(null, itemSlotIndex, locked, lockOwner, lockReason);
				return;
			}
			this.SetSlotLocked_Internal(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x0015BCD4 File Offset: 0x00159ED4
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

		// Token: 0x06005289 RID: 21129 RVA: 0x0015BD5C File Offset: 0x00159F5C
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
			base.SendTargetRpc(21U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x0015BE3D File Offset: 0x0015A03D
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (locked)
			{
				this.ItemSlots[itemSlotIndex].ApplyLock(lockOwner, lockReason, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].RemoveLock(true);
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x0015BE6C File Offset: 0x0015A06C
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

		// Token: 0x0600528C RID: 21132 RVA: 0x0015BEE8 File Offset: 0x0015A0E8
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
			base.SendObserversRpc(22U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x0015BFCC File Offset: 0x0015A1CC
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

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x0600528E RID: 21134 RVA: 0x0015C040 File Offset: 0x0015A240
		// (set) Token: 0x0600528F RID: 21135 RVA: 0x0015C048 File Offset: 0x0015A248
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

		// Token: 0x06005290 RID: 21136 RVA: 0x0015C084 File Offset: 0x0015A284
		public virtual bool ChemistryStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
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

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06005291 RID: 21137 RVA: 0x0015C15E File Offset: 0x0015A35E
		// (set) Token: 0x06005292 RID: 21138 RVA: 0x0015C166 File Offset: 0x0015A366
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

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06005293 RID: 21139 RVA: 0x0015C1A2 File Offset: 0x0015A3A2
		// (set) Token: 0x06005294 RID: 21140 RVA: 0x0015C1AA File Offset: 0x0015A3AA
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

		// Token: 0x06005295 RID: 21141 RVA: 0x0015C1E8 File Offset: 0x0015A3E8
		protected virtual void dll()
		{
			base.Awake();
			if (!this.isGhost)
			{
				this.IngredientSlots = new ItemSlot[3];
				for (int i = 0; i < 3; i++)
				{
					this.IngredientSlots[i] = new ItemSlot();
					this.IngredientSlots[i].SetSlotOwner(this);
					this.InputVisuals.AddSlot(this.IngredientSlots[i], false);
					ItemSlot itemSlot = this.IngredientSlots[i];
					itemSlot.onItemDataChanged = (Action)Delegate.Combine(itemSlot.onItemDataChanged, new Action(delegate()
					{
						base.HasChanged = true;
					}));
				}
				this.OutputSlot.SetIsAddLocked(true);
				this.OutputSlot.SetSlotOwner(this);
				this.OutputVisuals.AddSlot(this.OutputSlot, false);
				ItemSlot outputSlot = this.OutputSlot;
				outputSlot.onItemDataChanged = (Action)Delegate.Combine(outputSlot.onItemDataChanged, new Action(delegate()
				{
					base.HasChanged = true;
				}));
				this.InputSlots.AddRange(this.IngredientSlots);
				this.OutputSlots.Add(this.OutputSlot);
			}
		}

		// Token: 0x04003D8D RID: 15757
		public const float FOV_OVERRIDE = 65f;

		// Token: 0x04003D8E RID: 15758
		public const int INPUT_SLOT_COUNT = 3;

		// Token: 0x04003D93 RID: 15763
		public ItemSlot[] IngredientSlots;

		// Token: 0x04003D94 RID: 15764
		public ItemSlot OutputSlot;

		// Token: 0x04003D95 RID: 15765
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04003D96 RID: 15766
		public Transform CameraPosition_Default;

		// Token: 0x04003D97 RID: 15767
		public Transform CameraPosition_Stirring;

		// Token: 0x04003D98 RID: 15768
		public Transform StaticBeaker;

		// Token: 0x04003D99 RID: 15769
		public Transform StaticFunnel;

		// Token: 0x04003D9A RID: 15770
		public Transform StaticStirringRod;

		// Token: 0x04003D9B RID: 15771
		public Transform ItemContainer;

		// Token: 0x04003D9C RID: 15772
		public LabStand LabStand;

		// Token: 0x04003D9D RID: 15773
		public StorageVisualizer InputVisuals;

		// Token: 0x04003D9E RID: 15774
		public StorageVisualizer OutputVisuals;

		// Token: 0x04003D9F RID: 15775
		public Rigidbody AnchorRb;

		// Token: 0x04003DA0 RID: 15776
		public BunsenBurner Burner;

		// Token: 0x04003DA1 RID: 15777
		public BoilingFlask BoilingFlask;

		// Token: 0x04003DA2 RID: 15778
		public DigitalAlarm Alarm;

		// Token: 0x04003DA3 RID: 15779
		public Transform uiPoint;

		// Token: 0x04003DA4 RID: 15780
		public Transform[] accessPoints;

		// Token: 0x04003DA5 RID: 15781
		public ConfigurationReplicator configReplicator;

		// Token: 0x04003DA6 RID: 15782
		public BoxCollider TrashSpawnVolume;

		// Token: 0x04003DA7 RID: 15783
		public Transform ExplosionPoint;

		// Token: 0x04003DA8 RID: 15784
		[Header("Slot Display Points")]
		public Transform InputSlotsPosition;

		// Token: 0x04003DA9 RID: 15785
		public Transform OutputSlotPosition;

		// Token: 0x04003DAA RID: 15786
		[Header("Transforms")]
		public Transform[] IngredientTransforms;

		// Token: 0x04003DAB RID: 15787
		public Transform BeakerAlignmentTransform;

		// Token: 0x04003DAC RID: 15788
		[Header("Prefabs")]
		public GameObject BeakerPrefab;

		// Token: 0x04003DAD RID: 15789
		public StirringRod StirringRodPrefab;

		// Token: 0x04003DAE RID: 15790
		[Header("UI")]
		public ChemistryStationUIElement WorldspaceUIPrefab;

		// Token: 0x04003DAF RID: 15791
		public Sprite typeIcon;

		// Token: 0x04003DB7 RID: 15799
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003DB8 RID: 15800
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003DB9 RID: 15801
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04003DBA RID: 15802
		private bool dll_Excuted;

		// Token: 0x04003DBB RID: 15803
		private bool dll_Excuted;

		// Token: 0x02000BC9 RID: 3017
		public enum EStep
		{
			// Token: 0x04003DBD RID: 15805
			CombineIngredients,
			// Token: 0x04003DBE RID: 15806
			Stir,
			// Token: 0x04003DBF RID: 15807
			LowerBoilingFlask,
			// Token: 0x04003DC0 RID: 15808
			PourIntoBoilingFlask,
			// Token: 0x04003DC1 RID: 15809
			RaiseBoilingFlask,
			// Token: 0x04003DC2 RID: 15810
			StartHeat,
			// Token: 0x04003DC3 RID: 15811
			Cook,
			// Token: 0x04003DC4 RID: 15812
			LowerBoilingFlaskAgain,
			// Token: 0x04003DC5 RID: 15813
			PourThroughFilter
		}
	}
}
