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
using ScheduleOne.Audio;
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
using ScheduleOne.Product;
using ScheduleOne.Property;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.Tools;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Management;
using ScheduleOne.UI.Stations;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BE0 RID: 3040
	public class MixingStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06005420 RID: 21536 RVA: 0x0016252A File Offset: 0x0016072A
		// (set) Token: 0x06005421 RID: 21537 RVA: 0x00162532 File Offset: 0x00160732
		public bool IsOpen { get; private set; }

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06005422 RID: 21538 RVA: 0x0016253B File Offset: 0x0016073B
		// (set) Token: 0x06005423 RID: 21539 RVA: 0x00162543 File Offset: 0x00160743
		public MixOperation CurrentMixOperation { get; set; }

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06005424 RID: 21540 RVA: 0x0016254C File Offset: 0x0016074C
		public bool IsMixingDone
		{
			get
			{
				return this.CurrentMixOperation != null && this.CurrentMixTime >= this.GetMixTimeForCurrentOperation();
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06005425 RID: 21541 RVA: 0x00162569 File Offset: 0x00160769
		// (set) Token: 0x06005426 RID: 21542 RVA: 0x00162571 File Offset: 0x00160771
		public int CurrentMixTime { get; protected set; }

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06005427 RID: 21543 RVA: 0x0016257A File Offset: 0x0016077A
		// (set) Token: 0x06005428 RID: 21544 RVA: 0x00162582 File Offset: 0x00160782
		public List<ItemSlot> ItemSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06005429 RID: 21545 RVA: 0x0016258B File Offset: 0x0016078B
		// (set) Token: 0x0600542A RID: 21546 RVA: 0x00162593 File Offset: 0x00160793
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

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x0600542B RID: 21547 RVA: 0x0016259D File Offset: 0x0016079D
		// (set) Token: 0x0600542C RID: 21548 RVA: 0x001625A5 File Offset: 0x001607A5
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

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x0600542D RID: 21549 RVA: 0x00150487 File Offset: 0x0014E687
		public string Name
		{
			get
			{
				return base.ItemInstance.Name;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x0600542E RID: 21550 RVA: 0x001625AF File Offset: 0x001607AF
		// (set) Token: 0x0600542F RID: 21551 RVA: 0x001625B7 File Offset: 0x001607B7
		public List<ItemSlot> InputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06005430 RID: 21552 RVA: 0x001625C0 File Offset: 0x001607C0
		// (set) Token: 0x06005431 RID: 21553 RVA: 0x001625C8 File Offset: 0x001607C8
		public List<ItemSlot> OutputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06005432 RID: 21554 RVA: 0x001625D1 File Offset: 0x001607D1
		public Transform LinkOrigin
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06005433 RID: 21555 RVA: 0x001625D9 File Offset: 0x001607D9
		public Transform[] AccessPoints
		{
			get
			{
				return this.accessPoints;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06005434 RID: 21556 RVA: 0x001625E1 File Offset: 0x001607E1
		public bool Selectable { get; } = 1;

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06005435 RID: 21557 RVA: 0x001625E9 File Offset: 0x001607E9
		// (set) Token: 0x06005436 RID: 21558 RVA: 0x001625F1 File Offset: 0x001607F1
		public bool IsAcceptingItems { get; set; } = true;

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06005437 RID: 21559 RVA: 0x001625FA File Offset: 0x001607FA
		public EntityConfiguration Configuration
		{
			get
			{
				return this.stationConfiguration;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06005438 RID: 21560 RVA: 0x00162602 File Offset: 0x00160802
		// (set) Token: 0x06005439 RID: 21561 RVA: 0x0016260A File Offset: 0x0016080A
		protected MixingStationConfiguration stationConfiguration { get; set; }

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x0600543A RID: 21562 RVA: 0x00162613 File Offset: 0x00160813
		public ConfigurationReplicator ConfigReplicator
		{
			get
			{
				return this.configReplicator;
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x0600543B RID: 21563 RVA: 0x0016261B File Offset: 0x0016081B
		public EConfigurableType ConfigurableType
		{
			get
			{
				return EConfigurableType.MixingStation;
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x0600543C RID: 21564 RVA: 0x0016261F File Offset: 0x0016081F
		// (set) Token: 0x0600543D RID: 21565 RVA: 0x00162627 File Offset: 0x00160827
		public WorldspaceUIElement WorldspaceUI { get; set; }

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x0600543E RID: 21566 RVA: 0x00162630 File Offset: 0x00160830
		// (set) Token: 0x0600543F RID: 21567 RVA: 0x00162638 File Offset: 0x00160838
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

		// Token: 0x06005440 RID: 21568 RVA: 0x00162642 File Offset: 0x00160842
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
			this.RpcWriter___Server_SetConfigurer_3323014238(player);
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06005441 RID: 21569 RVA: 0x00162658 File Offset: 0x00160858
		public Sprite TypeIcon
		{
			get
			{
				return this.typeIcon;
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06005442 RID: 21570 RVA: 0x000AEDCB File Offset: 0x000ACFCB
		public Transform Transform
		{
			get
			{
				return base.transform;
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06005443 RID: 21571 RVA: 0x001625D1 File Offset: 0x001607D1
		public Transform UIPoint
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06005444 RID: 21572 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CanBeSelected
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06005445 RID: 21573 RVA: 0x00162660 File Offset: 0x00160860
		// (set) Token: 0x06005446 RID: 21574 RVA: 0x00162668 File Offset: 0x00160868
		public Vector3 DiscoveryBoxOffset { get; private set; }

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06005447 RID: 21575 RVA: 0x00162671 File Offset: 0x00160871
		// (set) Token: 0x06005448 RID: 21576 RVA: 0x00162679 File Offset: 0x00160879
		public Quaternion DiscoveryBoxRotation { get; private set; }

		// Token: 0x06005449 RID: 21577 RVA: 0x00162684 File Offset: 0x00160884
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ObjectScripts.MixingStation_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x001626A4 File Offset: 0x001608A4
		protected override void Start()
		{
			base.Start();
			if (!this.isGhost)
			{
				TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
				TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance2.onTimeSkip = (Action<int>)Delegate.Combine(instance2.onTimeSkip, new Action<int>(this.TimeSkipped));
				if (this.StartButton != null)
				{
					this.StartButton.onClickStart.AddListener(new UnityAction<RaycastHit>(this.StartButtonClicked));
				}
			}
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x00162738 File Offset: 0x00160938
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
				this.stationConfiguration = new MixingStationConfiguration(this.configReplicator, this, this);
				this.CreateWorldspaceUI();
			}
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x00162789 File Offset: 0x00160989
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			((IItemSlotOwner)this).SendItemsToClient(connection);
			if (this.CurrentMixOperation != null)
			{
				this.SetMixOperation(connection, this.CurrentMixOperation, this.CurrentMixTime);
			}
			this.SendConfigurationToClient(connection);
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x001627BC File Offset: 0x001609BC
		public void SendConfigurationToClient(NetworkConnection conn)
		{
			MixingStation.<>c__DisplayClass121_0 CS$<>8__locals1 = new MixingStation.<>c__DisplayClass121_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.conn = conn;
			if (CS$<>8__locals1.conn.IsHost)
			{
				return;
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SendConfigurationToClient>g__WaitForConfig|0());
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x001627FC File Offset: 0x001609FC
		public override bool CanBeDestroyed(out string reason)
		{
			if (((IItemSlotOwner)this).GetTotalItemCount() > 0)
			{
				reason = "Contains items";
				return false;
			}
			if (this.CurrentMixOperation != null && this.IsMixingDone)
			{
				reason = "Contains items";
				return false;
			}
			if (this.CurrentMixOperation != null)
			{
				reason = "Mixing in progress";
				return false;
			}
			if (((IUsable)this).IsInUse)
			{
				reason = "Currently in use";
				return false;
			}
			return base.CanBeDestroyed(out reason);
		}

		// Token: 0x0600544F RID: 21583 RVA: 0x00162860 File Offset: 0x00160A60
		public override void DestroyItem(bool callOnServer = true)
		{
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

		// Token: 0x06005450 RID: 21584 RVA: 0x001628E8 File Offset: 0x00160AE8
		private void TimeSkipped(int minsPassed)
		{
			for (int i = 0; i < minsPassed; i++)
			{
				this.MinPass();
			}
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x00162908 File Offset: 0x00160B08
		protected virtual void MinPass()
		{
			if (this.CurrentMixOperation != null || this.OutputSlot.Quantity > 0)
			{
				int num = 0;
				if (this.CurrentMixOperation != null)
				{
					int currentMixTime = this.CurrentMixTime;
					int currentMixTime2 = this.CurrentMixTime;
					this.CurrentMixTime = currentMixTime2 + 1;
					num = this.GetMixTimeForCurrentOperation();
					if (this.CurrentMixTime >= num && currentMixTime < num && InstanceFinder.IsServer)
					{
						NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Mixing_Operations_Completed", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Mixing_Operations_Completed") + 1f).ToString(), true);
						this.MixingDone_Networked();
					}
				}
				if (this.Clock != null)
				{
					this.Clock.SetScreenLit(true);
					this.Clock.DisplayMinutes(Mathf.Max(num - this.CurrentMixTime, 0));
				}
				if (this.Light != null)
				{
					if (this.IsMixingDone)
					{
						this.Light.isOn = (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.DailyMinTotal % 2 == 0);
						return;
					}
					this.Light.isOn = true;
					return;
				}
			}
			else
			{
				if (this.Clock != null)
				{
					this.Clock.SetScreenLit(false);
					this.Clock.DisplayText(string.Empty);
				}
				if (this.Light != null && this.IsMixingDone)
				{
					this.Light.isOn = false;
				}
			}
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x00162A5A File Offset: 0x00160C5A
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixingOperation(MixOperation operation, int mixTime)
		{
			this.RpcWriter___Server_SendMixingOperation_2669582547(operation, mixTime);
			this.RpcLogic___SendMixingOperation_2669582547(operation, mixTime);
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x00162A78 File Offset: 0x00160C78
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public virtual void SetMixOperation(NetworkConnection conn, MixOperation operation, int mixTIme)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetMixOperation_1073078804(conn, operation, mixTIme);
				this.RpcLogic___SetMixOperation_1073078804(conn, operation, mixTIme);
			}
			else
			{
				this.RpcWriter___Target_SetMixOperation_1073078804(conn, operation, mixTIme);
			}
		}

		// Token: 0x06005454 RID: 21588 RVA: 0x00162AC5 File Offset: 0x00160CC5
		public virtual void MixingStart()
		{
			this.StartSound.Play();
			this.MachineSound.StartAudio();
			if (this.onMixStart != null)
			{
				this.onMixStart.Invoke();
			}
		}

		// Token: 0x06005455 RID: 21589 RVA: 0x00162AF0 File Offset: 0x00160CF0
		[ObserversRpc]
		public void MixingDone_Networked()
		{
			this.RpcWriter___Observers_MixingDone_Networked_2166136261();
		}

		// Token: 0x06005456 RID: 21590 RVA: 0x00162AF8 File Offset: 0x00160CF8
		public virtual void MixingDone()
		{
			this.MachineSound.StopAudio();
			this.StopSound.Play();
			this.TryCreateOutputItems();
			if (this.onMixDone != null)
			{
				this.onMixDone.Invoke();
			}
		}

		// Token: 0x06005457 RID: 21591 RVA: 0x00162B2C File Offset: 0x00160D2C
		public bool DoesOutputHaveSpace(StationRecipe recipe)
		{
			StorableItemInstance productInstance = recipe.GetProductInstance(this.GetIngredients());
			return this.OutputSlot.GetCapacityForItem(productInstance) >= 1;
		}

		// Token: 0x06005458 RID: 21592 RVA: 0x00162B58 File Offset: 0x00160D58
		public List<ItemInstance> GetIngredients()
		{
			List<ItemInstance> list = new List<ItemInstance>();
			if (this.ProductSlot.ItemInstance != null)
			{
				list.Add(this.ProductSlot.ItemInstance);
			}
			if (this.MixerSlot.ItemInstance != null)
			{
				list.Add(this.MixerSlot.ItemInstance);
			}
			return list;
		}

		// Token: 0x06005459 RID: 21593 RVA: 0x00162BA8 File Offset: 0x00160DA8
		public int GetMixQuantity()
		{
			if (this.GetProduct() == null || this.GetMixer() == null)
			{
				return 0;
			}
			return Mathf.Min(Mathf.Min(this.ProductSlot.Quantity, this.MixerSlot.Quantity), this.MaxMixQuantity);
		}

		// Token: 0x0600545A RID: 21594 RVA: 0x00162BF9 File Offset: 0x00160DF9
		public bool CanStartMix()
		{
			return this.GetMixQuantity() > 0 && this.OutputSlot.Quantity == 0;
		}

		// Token: 0x0600545B RID: 21595 RVA: 0x00162C14 File Offset: 0x00160E14
		public ProductDefinition GetProduct()
		{
			if (this.ProductSlot.ItemInstance != null)
			{
				return this.ProductSlot.ItemInstance.Definition as ProductDefinition;
			}
			return null;
		}

		// Token: 0x0600545C RID: 21596 RVA: 0x00162C3C File Offset: 0x00160E3C
		public PropertyItemDefinition GetMixer()
		{
			if (this.MixerSlot.ItemInstance != null)
			{
				PropertyItemDefinition propertyItemDefinition = this.MixerSlot.ItemInstance.Definition as PropertyItemDefinition;
				if (propertyItemDefinition != null && NetworkSingleton<ProductManager>.Instance.ValidMixIngredients.Contains(propertyItemDefinition))
				{
					return propertyItemDefinition;
				}
			}
			return null;
		}

		// Token: 0x0600545D RID: 21597 RVA: 0x00162C8A File Offset: 0x00160E8A
		public int GetMixTimeForCurrentOperation()
		{
			if (this.CurrentMixOperation == null)
			{
				return 0;
			}
			return this.MixTimePerItem * this.CurrentMixOperation.Quantity;
		}

		// Token: 0x0600545E RID: 21598 RVA: 0x00162CA8 File Offset: 0x00160EA8
		[ServerRpc(RequireOwnership = false)]
		public void TryCreateOutputItems()
		{
			this.RpcWriter___Server_TryCreateOutputItems_2166136261();
		}

		// Token: 0x0600545F RID: 21599 RVA: 0x00162CBB File Offset: 0x00160EBB
		public void SetStartButtonClickable(bool clickable)
		{
			this.StartButton.ClickableEnabled = clickable;
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x00162CCC File Offset: 0x00160ECC
		private void OutputChanged()
		{
			if (this.OutputSlot.Quantity == 0)
			{
				if (this.onOutputCollected != null)
				{
					this.onOutputCollected.Invoke();
				}
				if (InstanceFinder.IsServer)
				{
					NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Mixing_Operations_Collected", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Mixing_Operations_Collected") + 1f).ToString(), true);
				}
			}
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x00162D2D File Offset: 0x00160F2D
		private void StartButtonClicked(RaycastHit hit)
		{
			this.SetStartButtonClickable(false);
			if (this.onStartButtonClicked != null)
			{
				this.onStartButtonClicked.Invoke();
			}
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x00162D4C File Offset: 0x00160F4C
		public void Open()
		{
			this.IsOpen = true;
			if (this.CurrentMixOperation != null && this.IsMixingDone)
			{
				this.TryCreateOutputItems();
			}
			this.SetPlayerUser(Player.Local.NetworkObject);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.CameraPosition.position, this.CameraPosition.rotation, 0.2f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(60f, 0.2f);
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			Singleton<MixingStationCanvas>.Instance.Open(this);
			Singleton<CompassManager>.Instance.SetVisible(false);
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x00162E14 File Offset: 0x00161014
		public void Close()
		{
			this.IsOpen = false;
			this.SetPlayerUser(null);
			if (this.DiscoveryBox != null)
			{
				this.DiscoveryBox.transform.SetParent(this.CameraPosition.transform);
				this.DiscoveryBox.gameObject.SetActive(false);
			}
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
				PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.2f, true, true);
				PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.2f);
				PlayerSingleton<PlayerCamera>.Instance.LockMouse();
				PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
				PlayerSingleton<PlayerMovement>.Instance.canMove = true;
				Singleton<CompassManager>.Instance.SetVisible(true);
			}
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x00162ECC File Offset: 0x001610CC
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

		// Token: 0x06005465 RID: 21605 RVA: 0x00162F26 File Offset: 0x00161126
		public void Interacted()
		{
			if (((IUsable)this).IsInUse || Singleton<ManagementClipboard>.Instance.IsEquipped)
			{
				return;
			}
			this.Open();
		}

		// Token: 0x06005466 RID: 21606 RVA: 0x00162F44 File Offset: 0x00161144
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
			MixingStationUIElement component = Object.Instantiate<MixingStationUIElement>(this.WorldspaceUIPrefab, base.ParentProperty.WorldspaceUIContainer).GetComponent<MixingStationUIElement>();
			component.Initialize(this);
			this.WorldspaceUI = component;
			return component;
		}

		// Token: 0x06005467 RID: 21607 RVA: 0x00162FD7 File Offset: 0x001611D7
		public void DestroyWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				this.WorldspaceUI.Destroy();
			}
		}

		// Token: 0x06005468 RID: 21608 RVA: 0x00162FF2 File Offset: 0x001611F2
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			this.RpcWriter___Server_SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
			this.RpcLogic___SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
		}

		// Token: 0x06005469 RID: 21609 RVA: 0x00163018 File Offset: 0x00161218
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

		// Token: 0x0600546A RID: 21610 RVA: 0x00163077 File Offset: 0x00161277
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Server_SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x0600546B RID: 21611 RVA: 0x00163095 File Offset: 0x00161295
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x001630B3 File Offset: 0x001612B3
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			this.RpcWriter___Server_SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			this.RpcLogic___SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x001630EC File Offset: 0x001612EC
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

		// Token: 0x0600546E RID: 21614 RVA: 0x0016316C File Offset: 0x0016136C
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
			this.RpcWriter___Server_SetPlayerUser_3323014238(playerObject);
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x0016318D File Offset: 0x0016138D
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
			this.RpcWriter___Server_SetNPCUser_3323014238(npcObject);
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x001631A4 File Offset: 0x001613A4
		public override string GetSaveString()
		{
			return new MixingStationData(base.GUID, base.ItemInstance, 0, base.OwnerGrid, this.OriginCoordinate, this.Rotation, new ItemSet(new List<ItemSlot>
			{
				this.ProductSlot
			}), new ItemSet(new List<ItemSlot>
			{
				this.MixerSlot
			}), new ItemSet(new List<ItemSlot>
			{
				this.OutputSlot
			}), this.CurrentMixOperation, this.CurrentMixTime).GetJson(true);
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x0016322C File Offset: 0x0016142C
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

		// Token: 0x06005476 RID: 21622 RVA: 0x001632DC File Offset: 0x001614DC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.MixingStationAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.MixingStationAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField = new SyncVar<NetworkObject>(this, 2U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<CurrentPlayerConfigurer>k__BackingField);
			this.syncVar___<PlayerUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<PlayerUserObject>k__BackingField);
			this.syncVar___<NPCUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<NPCUserObject>k__BackingField);
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SetConfigurer_3323014238));
			base.RegisterServerRpc(9U, new ServerRpcDelegate(this.RpcReader___Server_SendMixingOperation_2669582547));
			base.RegisterObserversRpc(10U, new ClientRpcDelegate(this.RpcReader___Observers_SetMixOperation_1073078804));
			base.RegisterTargetRpc(11U, new ClientRpcDelegate(this.RpcReader___Target_SetMixOperation_1073078804));
			base.RegisterObserversRpc(12U, new ClientRpcDelegate(this.RpcReader___Observers_MixingDone_Networked_2166136261));
			base.RegisterServerRpc(13U, new ServerRpcDelegate(this.RpcReader___Server_TryCreateOutputItems_2166136261));
			base.RegisterServerRpc(14U, new ServerRpcDelegate(this.RpcReader___Server_SetStoredInstance_2652194801));
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_SetStoredInstance_Internal_2652194801));
			base.RegisterTargetRpc(16U, new ClientRpcDelegate(this.RpcReader___Target_SetStoredInstance_Internal_2652194801));
			base.RegisterServerRpc(17U, new ServerRpcDelegate(this.RpcReader___Server_SetItemSlotQuantity_1692629761));
			base.RegisterObserversRpc(18U, new ClientRpcDelegate(this.RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761));
			base.RegisterServerRpc(19U, new ServerRpcDelegate(this.RpcReader___Server_SetSlotLocked_3170825843));
			base.RegisterTargetRpc(20U, new ClientRpcDelegate(this.RpcReader___Target_SetSlotLocked_Internal_3170825843));
			base.RegisterObserversRpc(21U, new ClientRpcDelegate(this.RpcReader___Observers_SetSlotLocked_Internal_3170825843));
			base.RegisterServerRpc(22U, new ServerRpcDelegate(this.RpcReader___Server_SetPlayerUser_3323014238));
			base.RegisterServerRpc(23U, new ServerRpcDelegate(this.RpcReader___Server_SetNPCUser_3323014238));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.ObjectScripts.MixingStation));
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x00163503 File Offset: 0x00161703
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.MixingStationAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.MixingStationAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetRegistered();
			this.syncVar___<PlayerUserObject>k__BackingField.SetRegistered();
			this.syncVar___<NPCUserObject>k__BackingField.SetRegistered();
		}

		// Token: 0x06005478 RID: 21624 RVA: 0x0016353D File Offset: 0x0016173D
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x0016354C File Offset: 0x0016174C
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

		// Token: 0x0600547A RID: 21626 RVA: 0x001635F3 File Offset: 0x001617F3
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			this.CurrentPlayerConfigurer = player;
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x001635FC File Offset: 0x001617FC
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

		// Token: 0x0600547C RID: 21628 RVA: 0x0016363C File Offset: 0x0016183C
		private void RpcWriter___Server_SendMixingOperation_2669582547(MixOperation operation, int mixTime)
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
			writer.Write___ScheduleOne.ObjectScripts.MixOperationFishNet.Serializing.Generated(operation);
			writer.WriteInt32(mixTime, AutoPackType.Packed);
			base.SendServerRpc(9U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x001636F5 File Offset: 0x001618F5
		public void RpcLogic___SendMixingOperation_2669582547(MixOperation operation, int mixTime)
		{
			this.SetMixOperation(null, operation, mixTime);
		}

		// Token: 0x0600547E RID: 21630 RVA: 0x00163700 File Offset: 0x00161900
		private void RpcReader___Server_SendMixingOperation_2669582547(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			MixOperation operation = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.MixOperationFishNet.Serializing.Generateds(PooledReader0);
			int mixTime = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendMixingOperation_2669582547(operation, mixTime);
		}

		// Token: 0x0600547F RID: 21631 RVA: 0x00163754 File Offset: 0x00161954
		private void RpcWriter___Observers_SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTIme)
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
			writer.Write___ScheduleOne.ObjectScripts.MixOperationFishNet.Serializing.Generated(operation);
			writer.WriteInt32(mixTIme, AutoPackType.Packed);
			base.SendObserversRpc(10U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x0016381C File Offset: 0x00161A1C
		public virtual void RpcLogic___SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTIme)
		{
			if (operation != null && string.IsNullOrEmpty(operation.ProductID))
			{
				operation = null;
			}
			MixOperation currentMixOperation = this.CurrentMixOperation;
			this.CurrentMixOperation = operation;
			this.CurrentMixTime = mixTIme;
			if (operation != null)
			{
				if (currentMixOperation == null)
				{
					this.MixingStart();
					return;
				}
			}
			else if (currentMixOperation != null && this.onMixDone != null)
			{
				this.onMixDone.Invoke();
			}
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x00163874 File Offset: 0x00161A74
		private void RpcReader___Observers_SetMixOperation_1073078804(PooledReader PooledReader0, Channel channel)
		{
			MixOperation operation = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.MixOperationFishNet.Serializing.Generateds(PooledReader0);
			int mixTIme = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetMixOperation_1073078804(null, operation, mixTIme);
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x001638C8 File Offset: 0x00161AC8
		private void RpcWriter___Target_SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTIme)
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
			writer.Write___ScheduleOne.ObjectScripts.MixOperationFishNet.Serializing.Generated(operation);
			writer.WriteInt32(mixTIme, AutoPackType.Packed);
			base.SendTargetRpc(11U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x00163990 File Offset: 0x00161B90
		private void RpcReader___Target_SetMixOperation_1073078804(PooledReader PooledReader0, Channel channel)
		{
			MixOperation operation = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.MixOperationFishNet.Serializing.Generateds(PooledReader0);
			int mixTIme = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetMixOperation_1073078804(base.LocalConnection, operation, mixTIme);
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x001639E0 File Offset: 0x00161BE0
		private void RpcWriter___Observers_MixingDone_Networked_2166136261()
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

		// Token: 0x06005485 RID: 21637 RVA: 0x00163A89 File Offset: 0x00161C89
		public void RpcLogic___MixingDone_Networked_2166136261()
		{
			this.MixingDone();
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x00163A94 File Offset: 0x00161C94
		private void RpcReader___Observers_MixingDone_Networked_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___MixingDone_Networked_2166136261();
		}

		// Token: 0x06005487 RID: 21639 RVA: 0x00163AB4 File Offset: 0x00161CB4
		private void RpcWriter___Server_TryCreateOutputItems_2166136261()
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
			base.SendServerRpc(13U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x00163B50 File Offset: 0x00161D50
		public void RpcLogic___TryCreateOutputItems_2166136261()
		{
			if (this.CurrentMixOperation == null)
			{
				return;
			}
			ProductDefinition productDefinition;
			if (this.CurrentMixOperation.IsOutputKnown(out productDefinition))
			{
				QualityItemInstance qualityItemInstance = productDefinition.GetDefaultInstance(this.CurrentMixOperation.Quantity) as QualityItemInstance;
				qualityItemInstance.SetQuality(this.CurrentMixOperation.ProductQuality);
				this.OutputSlot.AddItem(qualityItemInstance, false);
				if (NetworkSingleton<ProductManager>.Instance.GetRecipe(this.CurrentMixOperation.ProductID, this.CurrentMixOperation.IngredientID) == null)
				{
					NetworkSingleton<ProductManager>.Instance.SendMixRecipe(this.CurrentMixOperation.ProductID, this.CurrentMixOperation.IngredientID, qualityItemInstance.ID);
				}
				this.SetMixOperation(null, null, 0);
			}
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x00163C04 File Offset: 0x00161E04
		private void RpcReader___Server_TryCreateOutputItems_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___TryCreateOutputItems_2166136261();
		}

		// Token: 0x0600548A RID: 21642 RVA: 0x00163C24 File Offset: 0x00161E24
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
			base.SendServerRpc(14U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600548B RID: 21643 RVA: 0x00163CEA File Offset: 0x00161EEA
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetStoredInstance_Internal(null, itemSlotIndex, instance);
				return;
			}
			this.SetStoredInstance_Internal(conn, itemSlotIndex, instance);
		}

		// Token: 0x0600548C RID: 21644 RVA: 0x00163D14 File Offset: 0x00161F14
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

		// Token: 0x0600548D RID: 21645 RVA: 0x00163D7C File Offset: 0x00161F7C
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
			base.SendObserversRpc(15U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x00163E44 File Offset: 0x00162044
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (instance != null)
			{
				this.ItemSlots[itemSlotIndex].SetStoredItem(instance, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].ClearStoredInstance(true);
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x00163E70 File Offset: 0x00162070
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

		// Token: 0x06005490 RID: 21648 RVA: 0x00163EC4 File Offset: 0x001620C4
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
			base.SendTargetRpc(16U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06005491 RID: 21649 RVA: 0x00163F8C File Offset: 0x0016218C
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

		// Token: 0x06005492 RID: 21650 RVA: 0x00163FE4 File Offset: 0x001621E4
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
			base.SendServerRpc(17U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x001640A2 File Offset: 0x001622A2
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			this.SetItemSlotQuantity_Internal(itemSlotIndex, quantity);
		}

		// Token: 0x06005494 RID: 21652 RVA: 0x001640AC File Offset: 0x001622AC
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

		// Token: 0x06005495 RID: 21653 RVA: 0x00164108 File Offset: 0x00162308
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
			base.SendObserversRpc(18U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x001641D5 File Offset: 0x001623D5
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			this.ItemSlots[itemSlotIndex].SetQuantity(quantity, true);
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x001641EC File Offset: 0x001623EC
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

		// Token: 0x06005498 RID: 21656 RVA: 0x00164244 File Offset: 0x00162444
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
			base.SendServerRpc(19U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x00164324 File Offset: 0x00162524
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetSlotLocked_Internal(null, itemSlotIndex, locked, lockOwner, lockReason);
				return;
			}
			this.SetSlotLocked_Internal(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x00164354 File Offset: 0x00162554
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

		// Token: 0x0600549B RID: 21659 RVA: 0x001643DC File Offset: 0x001625DC
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
			base.SendTargetRpc(20U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x001644BD File Offset: 0x001626BD
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (locked)
			{
				this.ItemSlots[itemSlotIndex].ApplyLock(lockOwner, lockReason, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].RemoveLock(true);
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x001644EC File Offset: 0x001626EC
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

		// Token: 0x0600549E RID: 21662 RVA: 0x00164568 File Offset: 0x00162768
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
			base.SendObserversRpc(21U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x0016464C File Offset: 0x0016284C
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

		// Token: 0x060054A0 RID: 21664 RVA: 0x001646C0 File Offset: 0x001628C0
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
			base.SendServerRpc(22U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060054A1 RID: 21665 RVA: 0x00164768 File Offset: 0x00162968
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			if (this.PlayerUserObject != null && this.PlayerUserObject.Owner.IsLocalClient && playerObject != null && !playerObject.Owner.IsLocalClient)
			{
				Singleton<GameInput>.Instance.ExitAll();
			}
			this.PlayerUserObject = playerObject;
		}

		// Token: 0x060054A2 RID: 21666 RVA: 0x001647BC File Offset: 0x001629BC
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

		// Token: 0x060054A3 RID: 21667 RVA: 0x001647FC File Offset: 0x001629FC
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
			base.SendServerRpc(23U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060054A4 RID: 21668 RVA: 0x001648A3 File Offset: 0x00162AA3
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			this.NPCUserObject = npcObject;
		}

		// Token: 0x060054A5 RID: 21669 RVA: 0x001648AC File Offset: 0x00162AAC
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

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x001648EA File Offset: 0x00162AEA
		// (set) Token: 0x060054A7 RID: 21671 RVA: 0x001648F2 File Offset: 0x00162AF2
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

		// Token: 0x060054A8 RID: 21672 RVA: 0x00164930 File Offset: 0x00162B30
		public virtual bool MixingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
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

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060054A9 RID: 21673 RVA: 0x00164A0A File Offset: 0x00162C0A
		// (set) Token: 0x060054AA RID: 21674 RVA: 0x00164A12 File Offset: 0x00162C12
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

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060054AB RID: 21675 RVA: 0x00164A4E File Offset: 0x00162C4E
		// (set) Token: 0x060054AC RID: 21676 RVA: 0x00164A56 File Offset: 0x00162C56
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

		// Token: 0x060054AD RID: 21677 RVA: 0x00164A94 File Offset: 0x00162C94
		protected virtual void dll()
		{
			base.Awake();
			if (!this.isGhost)
			{
				this.ProductSlot.AddFilter(new ItemFilter_UnpackagedProduct());
				this.ProductSlot.SetSlotOwner(this);
				this.InputVisuals.AddSlot(this.ProductSlot, false);
				ItemSlot productSlot = this.ProductSlot;
				productSlot.onItemDataChanged = (Action)Delegate.Combine(productSlot.onItemDataChanged, new Action(delegate()
				{
					base.HasChanged = true;
				}));
				this.MixerSlot.AddFilter(new ItemFilter_MixingIngredient());
				this.MixerSlot.SetSlotOwner(this);
				this.InputVisuals.AddSlot(this.MixerSlot, false);
				ItemSlot mixerSlot = this.MixerSlot;
				mixerSlot.onItemDataChanged = (Action)Delegate.Combine(mixerSlot.onItemDataChanged, new Action(delegate()
				{
					base.HasChanged = true;
				}));
				this.OutputSlot.SetIsAddLocked(true);
				this.OutputSlot.SetSlotOwner(this);
				this.OutputVisuals.AddSlot(this.OutputSlot, false);
				ItemSlot outputSlot = this.OutputSlot;
				outputSlot.onItemDataChanged = (Action)Delegate.Combine(outputSlot.onItemDataChanged, new Action(delegate()
				{
					base.HasChanged = true;
				}));
				ItemSlot outputSlot2 = this.OutputSlot;
				outputSlot2.onItemDataChanged = (Action)Delegate.Combine(outputSlot2.onItemDataChanged, new Action(this.OutputChanged));
				this.DiscoveryBoxOffset = this.DiscoveryBox.transform.localPosition;
				this.DiscoveryBoxRotation = this.DiscoveryBox.transform.localRotation;
				this.InputSlots.AddRange(new List<ItemSlot>
				{
					this.ProductSlot,
					this.MixerSlot
				});
				this.OutputSlots.Add(this.OutputSlot);
			}
		}

		// Token: 0x04003EBA RID: 16058
		public ItemSlot ProductSlot;

		// Token: 0x04003EBB RID: 16059
		public ItemSlot MixerSlot;

		// Token: 0x04003EBC RID: 16060
		public ItemSlot OutputSlot;

		// Token: 0x04003EC0 RID: 16064
		public bool RequiresIngredientInsertion = true;

		// Token: 0x04003EC8 RID: 16072
		[Header("Settings")]
		public int MixTimePerItem = 15;

		// Token: 0x04003EC9 RID: 16073
		public int MaxMixQuantity = 10;

		// Token: 0x04003ECA RID: 16074
		[Header("Prefabs")]
		public GameObject JugPrefab;

		// Token: 0x04003ECB RID: 16075
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04003ECC RID: 16076
		public Transform CameraPosition;

		// Token: 0x04003ECD RID: 16077
		public Transform CameraPosition_CombineIngredients;

		// Token: 0x04003ECE RID: 16078
		public Transform CameraPosition_StartMachine;

		// Token: 0x04003ECF RID: 16079
		public StorageVisualizer InputVisuals;

		// Token: 0x04003ED0 RID: 16080
		public StorageVisualizer OutputVisuals;

		// Token: 0x04003ED1 RID: 16081
		public DigitalAlarm Clock;

		// Token: 0x04003ED2 RID: 16082
		public ToggleableLight Light;

		// Token: 0x04003ED3 RID: 16083
		public NewMixDiscoveryBox DiscoveryBox;

		// Token: 0x04003ED4 RID: 16084
		public Transform ItemContainer;

		// Token: 0x04003ED5 RID: 16085
		public Transform[] IngredientTransforms;

		// Token: 0x04003ED6 RID: 16086
		public Fillable BowlFillable;

		// Token: 0x04003ED7 RID: 16087
		public Clickable StartButton;

		// Token: 0x04003ED8 RID: 16088
		public Transform JugAlignment;

		// Token: 0x04003ED9 RID: 16089
		public Rigidbody Anchor;

		// Token: 0x04003EDA RID: 16090
		public BoxCollider TrashSpawnVolume;

		// Token: 0x04003EDB RID: 16091
		public Transform uiPoint;

		// Token: 0x04003EDC RID: 16092
		public Transform[] accessPoints;

		// Token: 0x04003EDD RID: 16093
		public ConfigurationReplicator configReplicator;

		// Token: 0x04003EDE RID: 16094
		[Header("Sounds")]
		public StartLoopStopAudio MachineSound;

		// Token: 0x04003EDF RID: 16095
		public AudioSourceController StartSound;

		// Token: 0x04003EE0 RID: 16096
		public AudioSourceController StopSound;

		// Token: 0x04003EE1 RID: 16097
		[Header("Mix Timing")]
		[Header("UI")]
		public MixingStationUIElement WorldspaceUIPrefab;

		// Token: 0x04003EE2 RID: 16098
		public Sprite typeIcon;

		// Token: 0x04003EE3 RID: 16099
		public UnityEvent onMixStart;

		// Token: 0x04003EE4 RID: 16100
		public UnityEvent onMixDone;

		// Token: 0x04003EE5 RID: 16101
		public UnityEvent onOutputCollected;

		// Token: 0x04003EE6 RID: 16102
		public UnityEvent onStartButtonClicked;

		// Token: 0x04003EE9 RID: 16105
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003EEA RID: 16106
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003EEB RID: 16107
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04003EEC RID: 16108
		private bool dll_Excuted;

		// Token: 0x04003EED RID: 16109
		private bool dll_Excuted;
	}
}
