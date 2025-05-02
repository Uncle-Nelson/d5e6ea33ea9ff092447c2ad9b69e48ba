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
using ScheduleOne.Misc;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Property;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.Tools;
using ScheduleOne.Trash;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Management;
using ScheduleOne.UI.Stations;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BBD RID: 3005
	public class Cauldron : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06005174 RID: 20852 RVA: 0x001570D4 File Offset: 0x001552D4
		public bool isOpen
		{
			get
			{
				return Singleton<CauldronCanvas>.Instance.isOpen && Singleton<CauldronCanvas>.Instance.Cauldron == this;
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06005175 RID: 20853 RVA: 0x001570F4 File Offset: 0x001552F4
		// (set) Token: 0x06005176 RID: 20854 RVA: 0x001570FC File Offset: 0x001552FC
		public List<ItemSlot> ItemSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06005177 RID: 20855 RVA: 0x00157105 File Offset: 0x00155305
		// (set) Token: 0x06005178 RID: 20856 RVA: 0x0015710D File Offset: 0x0015530D
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

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06005179 RID: 20857 RVA: 0x00157117 File Offset: 0x00155317
		// (set) Token: 0x0600517A RID: 20858 RVA: 0x0015711F File Offset: 0x0015531F
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

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x0600517B RID: 20859 RVA: 0x00150487 File Offset: 0x0014E687
		public string Name
		{
			get
			{
				return base.ItemInstance.Name;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x0600517C RID: 20860 RVA: 0x00157129 File Offset: 0x00155329
		// (set) Token: 0x0600517D RID: 20861 RVA: 0x00157131 File Offset: 0x00155331
		public List<ItemSlot> InputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x0600517E RID: 20862 RVA: 0x0015713A File Offset: 0x0015533A
		// (set) Token: 0x0600517F RID: 20863 RVA: 0x00157142 File Offset: 0x00155342
		public List<ItemSlot> OutputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06005180 RID: 20864 RVA: 0x0015714B File Offset: 0x0015534B
		public Transform LinkOrigin
		{
			get
			{
				return this.UIPoint;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06005181 RID: 20865 RVA: 0x00157153 File Offset: 0x00155353
		public Transform[] AccessPoints
		{
			get
			{
				return this.accessPoints;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06005182 RID: 20866 RVA: 0x0015715B File Offset: 0x0015535B
		public bool Selectable { get; } = 1;

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06005183 RID: 20867 RVA: 0x00157163 File Offset: 0x00155363
		// (set) Token: 0x06005184 RID: 20868 RVA: 0x0015716B File Offset: 0x0015536B
		public bool IsAcceptingItems { get; set; } = true;

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06005185 RID: 20869 RVA: 0x00157174 File Offset: 0x00155374
		public EntityConfiguration Configuration
		{
			get
			{
				return this.cauldronConfiguration;
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06005186 RID: 20870 RVA: 0x0015717C File Offset: 0x0015537C
		// (set) Token: 0x06005187 RID: 20871 RVA: 0x00157184 File Offset: 0x00155384
		protected CauldronConfiguration cauldronConfiguration { get; set; }

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06005188 RID: 20872 RVA: 0x0015718D File Offset: 0x0015538D
		public ConfigurationReplicator ConfigReplicator
		{
			get
			{
				return this.configReplicator;
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06005189 RID: 20873 RVA: 0x00157195 File Offset: 0x00155395
		public EConfigurableType ConfigurableType
		{
			get
			{
				return EConfigurableType.Cauldron;
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x0600518A RID: 20874 RVA: 0x00157198 File Offset: 0x00155398
		// (set) Token: 0x0600518B RID: 20875 RVA: 0x001571A0 File Offset: 0x001553A0
		public WorldspaceUIElement WorldspaceUI { get; set; }

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x0600518C RID: 20876 RVA: 0x001571A9 File Offset: 0x001553A9
		// (set) Token: 0x0600518D RID: 20877 RVA: 0x001571B1 File Offset: 0x001553B1
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

		// Token: 0x0600518E RID: 20878 RVA: 0x001571BB File Offset: 0x001553BB
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
			this.RpcWriter___Server_SetConfigurer_3323014238(player);
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x0600518F RID: 20879 RVA: 0x001571D1 File Offset: 0x001553D1
		public Sprite TypeIcon
		{
			get
			{
				return this.typeIcon;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06005190 RID: 20880 RVA: 0x000AEDCB File Offset: 0x000ACFCB
		public Transform Transform
		{
			get
			{
				return base.transform;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06005191 RID: 20881 RVA: 0x001571D9 File Offset: 0x001553D9
		public Transform UIPoint
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06005192 RID: 20882 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CanBeSelected
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06005193 RID: 20883 RVA: 0x001571E1 File Offset: 0x001553E1
		private bool isCooking
		{
			get
			{
				return this.RemainingCookTime > 0;
			}
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x001571EC File Offset: 0x001553EC
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ObjectScripts.Cauldron_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x0015720C File Offset: 0x0015540C
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
				this.cauldronConfiguration = new CauldronConfiguration(this.configReplicator, this, this);
				this.CreateWorldspaceUI();
				GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 4);
			}
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x00157270 File Offset: 0x00155470
		protected override void Start()
		{
			base.Start();
			if (!this.isGhost)
			{
				TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
				TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance2.onTimeSkip = (Action<int>)Delegate.Combine(instance2.onTimeSkip, new Action<int>(this.TimeSkipped));
				this.StartButtonClickable.onClickStart.AddListener(new UnityAction<RaycastHit>(this.ButtonClicked));
			}
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x001572F3 File Offset: 0x001554F3
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.RemainingCookTime > 0)
			{
				this.StartCookOperation(connection, this.RemainingCookTime, this.InputQuality);
			}
			this.SendConfigurationToClient(connection);
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x00157320 File Offset: 0x00155520
		public void SendConfigurationToClient(NetworkConnection conn)
		{
			Cauldron.<>c__DisplayClass108_0 CS$<>8__locals1 = new Cauldron.<>c__DisplayClass108_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.conn = conn;
			if (CS$<>8__locals1.conn.IsHost)
			{
				return;
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SendConfigurationToClient>g__WaitForConfig|0());
		}

		// Token: 0x06005199 RID: 20889 RVA: 0x00157360 File Offset: 0x00155560
		public override void DestroyItem(bool callOnServer = true)
		{
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance2.onTimeSkip = (Action<int>)Delegate.Remove(instance2.onTimeSkip, new Action<int>(this.TimeSkipped));
			GameInput.DeregisterExitListener(new GameInput.ExitDelegate(this.Exit));
			if (this.Configuration != null)
			{
				this.Configuration.Destroy();
				this.DestroyWorldspaceUI();
				base.ParentProperty.RemoveConfigurable(this);
			}
			base.DestroyItem(callOnServer);
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x001573F8 File Offset: 0x001555F8
		private void MinPass()
		{
			if (this.RemainingCookTime > 0)
			{
				this.Alarm.SetScreenLit(true);
				this.Alarm.DisplayMinutes(this.RemainingCookTime);
				this.Light.isOn = true;
				this.RemainingCookTime--;
				if (this.RemainingCookTime <= 0 && InstanceFinder.IsServer)
				{
					this.FinishCookOperation();
					return;
				}
			}
			else
			{
				this.Alarm.SetScreenLit(false);
				this.Alarm.DisplayMinutes(0);
				if (this.OutputSlot.Quantity > 0)
				{
					this.Light.isOn = (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.DailyMinTotal % 2 == 0);
					return;
				}
				this.Light.isOn = false;
			}
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x001574AC File Offset: 0x001556AC
		private void TimeSkipped(int minsPassed)
		{
			for (int i = 0; i < minsPassed; i++)
			{
				this.MinPass();
			}
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x001574CB File Offset: 0x001556CB
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

		// Token: 0x0600519D RID: 20893 RVA: 0x001574F8 File Offset: 0x001556F8
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

		// Token: 0x0600519E RID: 20894 RVA: 0x00157552 File Offset: 0x00155752
		public void Interacted()
		{
			if (((IUsable)this).IsInUse || Singleton<ManagementClipboard>.Instance.IsEquipped)
			{
				return;
			}
			this.Open();
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x00157570 File Offset: 0x00155770
		public void Open()
		{
			this.SetPlayerUser(Player.Local.NetworkObject);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.CameraPosition.position, this.CameraPosition.rotation, 0.2f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(65f, 0.2f);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			Singleton<CompassManager>.Instance.SetVisible(false);
			Singleton<CauldronCanvas>.Instance.SetIsOpen(this, true, true);
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x00157610 File Offset: 0x00155810
		public void Close()
		{
			Singleton<CauldronCanvas>.Instance.SetIsOpen(null, false, true);
			this.SetPlayerUser(null);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.2f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.2f);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			Singleton<CompassManager>.Instance.SetVisible(true);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x0015768C File Offset: 0x0015588C
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
			if (this.isCooking)
			{
				reason = "Currently cooking";
				return false;
			}
			return base.CanBeDestroyed(out reason);
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x001576CC File Offset: 0x001558CC
		private void UpdateIngredientVisuals()
		{
			ItemInstance itemInstance;
			int num;
			ItemInstance itemInstance2;
			int num2;
			this.GetMainInputs(out itemInstance, out num, out itemInstance2, out num2);
			if (itemInstance != null)
			{
				this.PrimaryTub.Configure(CauldronDisplayTub.EContents.CocaLeaf, (float)num / 20f);
			}
			else
			{
				this.PrimaryTub.Configure(CauldronDisplayTub.EContents.None, 0f);
			}
			if (itemInstance2 != null)
			{
				this.SecondaryTub.Configure(CauldronDisplayTub.EContents.CocaLeaf, (float)num2 / 20f);
				return;
			}
			this.SecondaryTub.Configure(CauldronDisplayTub.EContents.None, 0f);
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x0015773C File Offset: 0x0015593C
		public void GetMainInputs(out ItemInstance primaryItem, out int primaryItemQuantity, out ItemInstance secondaryItem, out int secondaryItemQuantity)
		{
			Cauldron.<>c__DisplayClass119_0 CS$<>8__locals1 = new Cauldron.<>c__DisplayClass119_0();
			CS$<>8__locals1.<>4__this = this;
			List<ItemInstance> list = new List<ItemInstance>();
			CS$<>8__locals1.itemQuantities = new Dictionary<ItemInstance, int>();
			int i;
			int k;
			for (i = 0; i < this.IngredientSlots.Length; i = k + 1)
			{
				if (this.IngredientSlots[i].ItemInstance != null)
				{
					ItemInstance itemInstance = list.Find((ItemInstance x) => x.ID == CS$<>8__locals1.<>4__this.IngredientSlots[i].ItemInstance.ID);
					if (itemInstance == null || !itemInstance.CanStackWith(this.IngredientSlots[i].ItemInstance, false))
					{
						itemInstance = this.IngredientSlots[i].ItemInstance;
						list.Add(itemInstance);
						if (!CS$<>8__locals1.itemQuantities.ContainsKey(this.IngredientSlots[i].ItemInstance))
						{
							CS$<>8__locals1.itemQuantities.Add(this.IngredientSlots[i].ItemInstance, 0);
						}
					}
					Dictionary<ItemInstance, int> itemQuantities = CS$<>8__locals1.itemQuantities;
					ItemInstance key = itemInstance;
					itemQuantities[key] += this.IngredientSlots[i].Quantity;
				}
				k = i;
			}
			for (int j = 0; j < list.Count; j++)
			{
				if (CS$<>8__locals1.itemQuantities[list[j]] > 20)
				{
					int num = CS$<>8__locals1.itemQuantities[list[j]] - 20;
					CS$<>8__locals1.itemQuantities[list[j]] = 20;
					ItemInstance copy = list[j].GetCopy(num);
					list.Add(copy);
					CS$<>8__locals1.itemQuantities.Add(copy, num);
				}
			}
			list = (from x in list
			orderby CS$<>8__locals1.itemQuantities[x] descending
			select x).ToList<ItemInstance>();
			if (list.Count > 0)
			{
				primaryItem = list[0];
				primaryItemQuantity = CS$<>8__locals1.itemQuantities[list[0]];
			}
			else
			{
				primaryItem = null;
				primaryItemQuantity = 0;
			}
			if (list.Count > 1)
			{
				secondaryItem = list[1];
				secondaryItemQuantity = CS$<>8__locals1.itemQuantities[list[1]];
				return;
			}
			secondaryItem = null;
			secondaryItemQuantity = 0;
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x00157979 File Offset: 0x00155B79
		public Cauldron.EState GetState()
		{
			if (this.isCooking)
			{
				return Cauldron.EState.Cooking;
			}
			if (!this.HasIngredients())
			{
				return Cauldron.EState.MissingIngredients;
			}
			if (!this.HasOutputSpace())
			{
				return Cauldron.EState.OutputFull;
			}
			return Cauldron.EState.Ready;
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x0015799C File Offset: 0x00155B9C
		public bool HasOutputSpace()
		{
			ItemInstance defaultInstance = this.CocaineBaseDefinition.GetDefaultInstance(1);
			return this.OutputSlot.GetCapacityForItem(defaultInstance) >= 10;
		}

		// Token: 0x060051A6 RID: 20902 RVA: 0x001579CC File Offset: 0x00155BCC
		public EQuality RemoveIngredients()
		{
			this.LiquidSlot.ChangeQuantity(-1, false);
			EQuality equality = EQuality.Heavenly;
			int num = 20;
			int num2 = this.IngredientSlots.Length - 1;
			while (num2 >= 0 && num > 0)
			{
				if (this.IngredientSlots[num2].Quantity > 0)
				{
					EQuality quality = (this.IngredientSlots[num2].ItemInstance as QualityItemInstance).Quality;
					if (quality < equality)
					{
						equality = quality;
					}
					int num3 = Mathf.Min(num, this.IngredientSlots[num2].Quantity);
					this.IngredientSlots[num2].ChangeQuantity(-num3, false);
					num -= num3;
				}
				num2--;
			}
			return equality;
		}

		// Token: 0x060051A7 RID: 20903 RVA: 0x00157A60 File Offset: 0x00155C60
		public bool HasIngredients()
		{
			int num = 0;
			int quantity = this.LiquidSlot.Quantity;
			for (int i = 0; i < this.IngredientSlots.Length; i++)
			{
				if (this.IngredientSlots[i].ItemInstance != null)
				{
					num += this.IngredientSlots[i].Quantity;
				}
			}
			return num >= 20 && quantity > 0;
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x00157AB8 File Offset: 0x00155CB8
		[ServerRpc(RequireOwnership = false)]
		public void SendCookOperation(int remainingCookTime, EQuality quality)
		{
			this.RpcWriter___Server_SendCookOperation_3536682170(remainingCookTime, quality);
		}

		// Token: 0x060051A9 RID: 20905 RVA: 0x00157AC8 File Offset: 0x00155CC8
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void StartCookOperation(NetworkConnection conn, int remainingCookTime, EQuality quality)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_StartCookOperation_4210838825(conn, remainingCookTime, quality);
				this.RpcLogic___StartCookOperation_4210838825(conn, remainingCookTime, quality);
			}
			else
			{
				this.RpcWriter___Target_StartCookOperation_4210838825(conn, remainingCookTime, quality);
			}
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x00157B18 File Offset: 0x00155D18
		[ObserversRpc]
		public void FinishCookOperation()
		{
			this.RpcWriter___Observers_FinishCookOperation_2166136261();
		}

		// Token: 0x060051AB RID: 20907 RVA: 0x00157B2B File Offset: 0x00155D2B
		private void ButtonClicked(RaycastHit hit)
		{
			if (this.onStartButtonClicked != null)
			{
				this.onStartButtonClicked.Invoke();
			}
		}

		// Token: 0x060051AC RID: 20908 RVA: 0x00157B40 File Offset: 0x00155D40
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

		// Token: 0x060051AD RID: 20909 RVA: 0x00157C6F File Offset: 0x00155E6F
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
			this.RpcWriter___Server_SetPlayerUser_3323014238(playerObject);
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x00157C85 File Offset: 0x00155E85
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
			this.RpcWriter___Server_SetNPCUser_3323014238(npcObject);
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x060051AF RID: 20911 RVA: 0x00157C9B File Offset: 0x00155E9B
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			this.RpcWriter___Server_SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
			this.RpcLogic___SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
		}

		// Token: 0x060051B0 RID: 20912 RVA: 0x00157CC4 File Offset: 0x00155EC4
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

		// Token: 0x060051B1 RID: 20913 RVA: 0x00157D23 File Offset: 0x00155F23
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Server_SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x060051B2 RID: 20914 RVA: 0x00157D41 File Offset: 0x00155F41
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x060051B3 RID: 20915 RVA: 0x00157D5F File Offset: 0x00155F5F
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			this.RpcWriter___Server_SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			this.RpcLogic___SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x060051B4 RID: 20916 RVA: 0x00157D98 File Offset: 0x00155F98
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

		// Token: 0x060051B5 RID: 20917 RVA: 0x00157E18 File Offset: 0x00156018
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
			CauldronUIElement component = Object.Instantiate<CauldronUIElement>(this.WorldspaceUIPrefab, base.ParentProperty.WorldspaceUIContainer).GetComponent<CauldronUIElement>();
			component.Initialize(this);
			this.WorldspaceUI = component;
			return component;
		}

		// Token: 0x060051B6 RID: 20918 RVA: 0x00157EAB File Offset: 0x001560AB
		public void DestroyWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				this.WorldspaceUI.Destroy();
			}
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x00157EC8 File Offset: 0x001560C8
		public override string GetSaveString()
		{
			return new CauldronData(base.GUID, base.ItemInstance, 0, base.OwnerGrid, this.OriginCoordinate, this.Rotation, new ItemSet(new List<ItemSlot>(this.IngredientSlots)), new ItemSet(new List<ItemSlot>
			{
				this.LiquidSlot
			}), new ItemSet(new List<ItemSlot>
			{
				this.OutputSlot
			}), this.RemainingCookTime, this.InputQuality).GetJson(true);
		}

		// Token: 0x060051B8 RID: 20920 RVA: 0x00157F48 File Offset: 0x00156148
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

		// Token: 0x060051BA RID: 20922 RVA: 0x00157FF0 File Offset: 0x001561F0
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.CauldronAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.CauldronAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField = new SyncVar<NetworkObject>(this, 2U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<CurrentPlayerConfigurer>k__BackingField);
			this.syncVar___<PlayerUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<PlayerUserObject>k__BackingField);
			this.syncVar___<NPCUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<NPCUserObject>k__BackingField);
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SetConfigurer_3323014238));
			base.RegisterServerRpc(9U, new ServerRpcDelegate(this.RpcReader___Server_SendCookOperation_3536682170));
			base.RegisterObserversRpc(10U, new ClientRpcDelegate(this.RpcReader___Observers_StartCookOperation_4210838825));
			base.RegisterTargetRpc(11U, new ClientRpcDelegate(this.RpcReader___Target_StartCookOperation_4210838825));
			base.RegisterObserversRpc(12U, new ClientRpcDelegate(this.RpcReader___Observers_FinishCookOperation_2166136261));
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
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.ObjectScripts.Cauldron));
		}

		// Token: 0x060051BB RID: 20923 RVA: 0x00158200 File Offset: 0x00156400
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.CauldronAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.CauldronAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetRegistered();
			this.syncVar___<PlayerUserObject>k__BackingField.SetRegistered();
			this.syncVar___<NPCUserObject>k__BackingField.SetRegistered();
		}

		// Token: 0x060051BC RID: 20924 RVA: 0x0015823A File Offset: 0x0015643A
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060051BD RID: 20925 RVA: 0x00158248 File Offset: 0x00156448
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

		// Token: 0x060051BE RID: 20926 RVA: 0x001582EF File Offset: 0x001564EF
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			this.CurrentPlayerConfigurer = player;
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x001582F8 File Offset: 0x001564F8
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

		// Token: 0x060051C0 RID: 20928 RVA: 0x00158338 File Offset: 0x00156538
		private void RpcWriter___Server_SendCookOperation_3536682170(int remainingCookTime, EQuality quality)
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
			writer.WriteInt32(remainingCookTime, AutoPackType.Packed);
			writer.Write___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generated(quality);
			base.SendServerRpc(9U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060051C1 RID: 20929 RVA: 0x001583F1 File Offset: 0x001565F1
		public void RpcLogic___SendCookOperation_3536682170(int remainingCookTime, EQuality quality)
		{
			this.StartCookOperation(null, remainingCookTime, quality);
		}

		// Token: 0x060051C2 RID: 20930 RVA: 0x001583FC File Offset: 0x001565FC
		private void RpcReader___Server_SendCookOperation_3536682170(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int remainingCookTime = PooledReader0.ReadInt32(AutoPackType.Packed);
			EQuality quality = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendCookOperation_3536682170(remainingCookTime, quality);
		}

		// Token: 0x060051C3 RID: 20931 RVA: 0x00158444 File Offset: 0x00156644
		private void RpcWriter___Observers_StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality)
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
			writer.WriteInt32(remainingCookTime, AutoPackType.Packed);
			writer.Write___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generated(quality);
			base.SendObserversRpc(10U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x0015850C File Offset: 0x0015670C
		public void RpcLogic___StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality)
		{
			this.RemainingCookTime = remainingCookTime;
			this.InputQuality = quality;
			this.CauldronFillable.AddLiquid("gasoline", 1f, Color.white);
			if (this.onCookStart != null)
			{
				this.onCookStart.Invoke();
			}
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x0015854C File Offset: 0x0015674C
		private void RpcReader___Observers_StartCookOperation_4210838825(PooledReader PooledReader0, Channel channel)
		{
			int remainingCookTime = PooledReader0.ReadInt32(AutoPackType.Packed);
			EQuality quality = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___StartCookOperation_4210838825(null, remainingCookTime, quality);
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x001585A0 File Offset: 0x001567A0
		private void RpcWriter___Target_StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality)
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
			writer.WriteInt32(remainingCookTime, AutoPackType.Packed);
			writer.Write___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generated(quality);
			base.SendTargetRpc(11U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x00158668 File Offset: 0x00156868
		private void RpcReader___Target_StartCookOperation_4210838825(PooledReader PooledReader0, Channel channel)
		{
			int remainingCookTime = PooledReader0.ReadInt32(AutoPackType.Packed);
			EQuality quality = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___StartCookOperation_4210838825(base.LocalConnection, remainingCookTime, quality);
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x001586B8 File Offset: 0x001568B8
		private void RpcWriter___Observers_FinishCookOperation_2166136261()
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

		// Token: 0x060051C9 RID: 20937 RVA: 0x00158764 File Offset: 0x00156964
		public void RpcLogic___FinishCookOperation_2166136261()
		{
			if (InstanceFinder.IsServer)
			{
				QualityItemInstance qualityItemInstance = this.CocaineBaseDefinition.GetDefaultInstance(10) as QualityItemInstance;
				qualityItemInstance.SetQuality(this.InputQuality);
				this.OutputSlot.InsertItem(qualityItemInstance);
			}
			this.CauldronFillable.ResetContents();
			if (this.onCookEnd != null)
			{
				this.onCookEnd.Invoke();
			}
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x001587C4 File Offset: 0x001569C4
		private void RpcReader___Observers_FinishCookOperation_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___FinishCookOperation_2166136261();
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x001587E4 File Offset: 0x001569E4
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

		// Token: 0x060051CC RID: 20940 RVA: 0x0015888B File Offset: 0x00156A8B
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			this.PlayerUserObject = playerObject;
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x00158894 File Offset: 0x00156A94
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

		// Token: 0x060051CE RID: 20942 RVA: 0x001588D4 File Offset: 0x00156AD4
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

		// Token: 0x060051CF RID: 20943 RVA: 0x0015897B File Offset: 0x00156B7B
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			this.NPCUserObject = npcObject;
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x00158984 File Offset: 0x00156B84
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

		// Token: 0x060051D1 RID: 20945 RVA: 0x001589C4 File Offset: 0x00156BC4
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

		// Token: 0x060051D2 RID: 20946 RVA: 0x00158A8A File Offset: 0x00156C8A
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetStoredInstance_Internal(null, itemSlotIndex, instance);
				return;
			}
			this.SetStoredInstance_Internal(conn, itemSlotIndex, instance);
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x00158AB4 File Offset: 0x00156CB4
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

		// Token: 0x060051D4 RID: 20948 RVA: 0x00158B1C File Offset: 0x00156D1C
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

		// Token: 0x060051D5 RID: 20949 RVA: 0x00158BE4 File Offset: 0x00156DE4
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (instance != null)
			{
				this.ItemSlots[itemSlotIndex].SetStoredItem(instance, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].ClearStoredInstance(true);
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x00158C10 File Offset: 0x00156E10
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

		// Token: 0x060051D7 RID: 20951 RVA: 0x00158C64 File Offset: 0x00156E64
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

		// Token: 0x060051D8 RID: 20952 RVA: 0x00158D2C File Offset: 0x00156F2C
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

		// Token: 0x060051D9 RID: 20953 RVA: 0x00158D84 File Offset: 0x00156F84
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

		// Token: 0x060051DA RID: 20954 RVA: 0x00158E42 File Offset: 0x00157042
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			this.SetItemSlotQuantity_Internal(itemSlotIndex, quantity);
		}

		// Token: 0x060051DB RID: 20955 RVA: 0x00158E4C File Offset: 0x0015704C
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

		// Token: 0x060051DC RID: 20956 RVA: 0x00158EA8 File Offset: 0x001570A8
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

		// Token: 0x060051DD RID: 20957 RVA: 0x00158F75 File Offset: 0x00157175
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			this.ItemSlots[itemSlotIndex].SetQuantity(quantity, true);
		}

		// Token: 0x060051DE RID: 20958 RVA: 0x00158F8C File Offset: 0x0015718C
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

		// Token: 0x060051DF RID: 20959 RVA: 0x00158FE4 File Offset: 0x001571E4
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

		// Token: 0x060051E0 RID: 20960 RVA: 0x001590C4 File Offset: 0x001572C4
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetSlotLocked_Internal(null, itemSlotIndex, locked, lockOwner, lockReason);
				return;
			}
			this.SetSlotLocked_Internal(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x001590F4 File Offset: 0x001572F4
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

		// Token: 0x060051E2 RID: 20962 RVA: 0x0015917C File Offset: 0x0015737C
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

		// Token: 0x060051E3 RID: 20963 RVA: 0x0015925D File Offset: 0x0015745D
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (locked)
			{
				this.ItemSlots[itemSlotIndex].ApplyLock(lockOwner, lockReason, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].RemoveLock(true);
		}

		// Token: 0x060051E4 RID: 20964 RVA: 0x0015928C File Offset: 0x0015748C
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

		// Token: 0x060051E5 RID: 20965 RVA: 0x00159308 File Offset: 0x00157508
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

		// Token: 0x060051E6 RID: 20966 RVA: 0x001593EC File Offset: 0x001575EC
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

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060051E7 RID: 20967 RVA: 0x00159460 File Offset: 0x00157660
		// (set) Token: 0x060051E8 RID: 20968 RVA: 0x00159468 File Offset: 0x00157668
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

		// Token: 0x060051E9 RID: 20969 RVA: 0x001594A4 File Offset: 0x001576A4
		public virtual bool Cauldron(PooledReader PooledReader0, uint UInt321, bool Boolean2)
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

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060051EA RID: 20970 RVA: 0x0015957E File Offset: 0x0015777E
		// (set) Token: 0x060051EB RID: 20971 RVA: 0x00159586 File Offset: 0x00157786
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

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060051EC RID: 20972 RVA: 0x001595C2 File Offset: 0x001577C2
		// (set) Token: 0x060051ED RID: 20973 RVA: 0x001595CA File Offset: 0x001577CA
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

		// Token: 0x060051EE RID: 20974 RVA: 0x00159608 File Offset: 0x00157808
		protected virtual void dll()
		{
			base.Awake();
			if (!this.isGhost)
			{
				this.IngredientSlots = new ItemSlot[4];
				for (int i = 0; i < 4; i++)
				{
					this.IngredientSlots[i] = new ItemSlot();
					this.IngredientSlots[i].SetSlotOwner(this);
					this.IngredientSlots[i].AddFilter(new ItemFilter_ID(new List<string>
					{
						"cocaleaf"
					}));
					ItemSlot itemSlot = this.IngredientSlots[i];
					itemSlot.onItemDataChanged = (Action)Delegate.Combine(itemSlot.onItemDataChanged, new Action(this.UpdateIngredientVisuals));
				}
				this.LiquidSlot = new ItemSlot();
				this.LiquidSlot.SetSlotOwner(this);
				this.LiquidSlot.AddFilter(new ItemFilter_ID(new List<string>
				{
					"gasoline"
				}));
				this.LiquidVisuals.AddSlot(this.LiquidSlot, false);
				this.OutputSlot = new ItemSlot();
				this.OutputSlot.SetSlotOwner(this);
				this.OutputSlot.SetIsAddLocked(true);
				this.OutputVisuals.AddSlot(this.OutputSlot, false);
				this.InputSlots.AddRange(this.IngredientSlots);
				this.InputSlots.Add(this.LiquidSlot);
				this.OutputSlots.Add(this.OutputSlot);
				this.PrimaryTub.gameObject.SetActive(true);
				this.SecondaryTub.gameObject.SetActive(true);
			}
		}

		// Token: 0x04003D1C RID: 15644
		public const int INGREDIENT_SLOT_COUNT = 4;

		// Token: 0x04003D1D RID: 15645
		public const int COCA_LEAF_REQUIRED = 20;

		// Token: 0x04003D1E RID: 15646
		public ItemSlot[] IngredientSlots;

		// Token: 0x04003D1F RID: 15647
		public ItemSlot LiquidSlot;

		// Token: 0x04003D20 RID: 15648
		public ItemSlot OutputSlot;

		// Token: 0x04003D22 RID: 15650
		public int CookTime = 360;

		// Token: 0x04003D23 RID: 15651
		[Header("References")]
		public Transform CameraPosition;

		// Token: 0x04003D24 RID: 15652
		public Transform CameraPosition_CombineIngredients;

		// Token: 0x04003D25 RID: 15653
		public Transform CameraPosition_StartMachine;

		// Token: 0x04003D26 RID: 15654
		public InteractableObject IntObj;

		// Token: 0x04003D27 RID: 15655
		public Transform[] accessPoints;

		// Token: 0x04003D28 RID: 15656
		public Transform StandPoint;

		// Token: 0x04003D29 RID: 15657
		public Transform uiPoint;

		// Token: 0x04003D2A RID: 15658
		public StorageVisualizer LiquidVisuals;

		// Token: 0x04003D2B RID: 15659
		public StorageVisualizer OutputVisuals;

		// Token: 0x04003D2C RID: 15660
		public CauldronDisplayTub PrimaryTub;

		// Token: 0x04003D2D RID: 15661
		public CauldronDisplayTub SecondaryTub;

		// Token: 0x04003D2E RID: 15662
		public Transform ItemContainer;

		// Token: 0x04003D2F RID: 15663
		public Transform GasolineSpawnPoint;

		// Token: 0x04003D30 RID: 15664
		public Transform TubSpawnPoint;

		// Token: 0x04003D31 RID: 15665
		public Transform[] LeafSpawns;

		// Token: 0x04003D32 RID: 15666
		public Light OverheadLight;

		// Token: 0x04003D33 RID: 15667
		public Fillable CauldronFillable;

		// Token: 0x04003D34 RID: 15668
		public Clickable StartButtonClickable;

		// Token: 0x04003D35 RID: 15669
		public DigitalAlarm Alarm;

		// Token: 0x04003D36 RID: 15670
		public ToggleableLight Light;

		// Token: 0x04003D37 RID: 15671
		public ConfigurationReplicator configReplicator;

		// Token: 0x04003D38 RID: 15672
		public BoxCollider TrashSpawnVolume;

		// Token: 0x04003D39 RID: 15673
		[Header("Prefabs")]
		public StationItem CocaLeafPrefab;

		// Token: 0x04003D3A RID: 15674
		public StationItem GasolinePrefab;

		// Token: 0x04003D3B RID: 15675
		public Draggable TubPrefab;

		// Token: 0x04003D3C RID: 15676
		public QualityItemDefinition CocaineBaseDefinition;

		// Token: 0x04003D3D RID: 15677
		[Header("UI")]
		public CauldronUIElement WorldspaceUIPrefab;

		// Token: 0x04003D3E RID: 15678
		public Sprite typeIcon;

		// Token: 0x04003D3F RID: 15679
		public UnityEvent onStartButtonClicked;

		// Token: 0x04003D40 RID: 15680
		public UnityEvent onCookStart;

		// Token: 0x04003D41 RID: 15681
		public UnityEvent onCookEnd;

		// Token: 0x04003D42 RID: 15682
		public int RemainingCookTime;

		// Token: 0x04003D43 RID: 15683
		public EQuality InputQuality = EQuality.Standard;

		// Token: 0x04003D4D RID: 15693
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003D4E RID: 15694
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003D4F RID: 15695
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04003D50 RID: 15696
		private bool dll_Excuted;

		// Token: 0x04003D51 RID: 15697
		private bool dll_Excuted;

		// Token: 0x02000BBE RID: 3006
		public enum EState
		{
			// Token: 0x04003D53 RID: 15699
			MissingIngredients,
			// Token: 0x04003D54 RID: 15700
			Ready,
			// Token: 0x04003D55 RID: 15701
			Cooking,
			// Token: 0x04003D56 RID: 15702
			OutputFull
		}
	}
}
