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
using ScheduleOne.Property;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.Tools;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Management;
using ScheduleOne.UI.Stations;
using TMPro;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BD4 RID: 3028
	public class LabOven : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06005354 RID: 21332 RVA: 0x0015F3BE File Offset: 0x0015D5BE
		public bool isOpen
		{
			get
			{
				return Singleton<LabOvenCanvas>.Instance.isOpen && Singleton<LabOvenCanvas>.Instance.Oven == this;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06005355 RID: 21333 RVA: 0x0015F3DE File Offset: 0x0015D5DE
		// (set) Token: 0x06005356 RID: 21334 RVA: 0x0015F3E6 File Offset: 0x0015D5E6
		public OvenCookOperation CurrentOperation { get; private set; }

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06005357 RID: 21335 RVA: 0x0015F3EF File Offset: 0x0015D5EF
		// (set) Token: 0x06005358 RID: 21336 RVA: 0x0015F3F7 File Offset: 0x0015D5F7
		public List<ItemSlot> ItemSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06005359 RID: 21337 RVA: 0x0015F400 File Offset: 0x0015D600
		// (set) Token: 0x0600535A RID: 21338 RVA: 0x0015F408 File Offset: 0x0015D608
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

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x0600535B RID: 21339 RVA: 0x0015F412 File Offset: 0x0015D612
		// (set) Token: 0x0600535C RID: 21340 RVA: 0x0015F41A File Offset: 0x0015D61A
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

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x0600535D RID: 21341 RVA: 0x00150487 File Offset: 0x0014E687
		public string Name
		{
			get
			{
				return base.ItemInstance.Name;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x0600535E RID: 21342 RVA: 0x0015F424 File Offset: 0x0015D624
		// (set) Token: 0x0600535F RID: 21343 RVA: 0x0015F42C File Offset: 0x0015D62C
		public List<ItemSlot> InputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06005360 RID: 21344 RVA: 0x0015F435 File Offset: 0x0015D635
		// (set) Token: 0x06005361 RID: 21345 RVA: 0x0015F43D File Offset: 0x0015D63D
		public List<ItemSlot> OutputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06005362 RID: 21346 RVA: 0x0015F446 File Offset: 0x0015D646
		public Transform LinkOrigin
		{
			get
			{
				return this.UIPoint;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06005363 RID: 21347 RVA: 0x0015F44E File Offset: 0x0015D64E
		public Transform[] AccessPoints
		{
			get
			{
				return this.accessPoints;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06005364 RID: 21348 RVA: 0x0015F456 File Offset: 0x0015D656
		public bool Selectable { get; } = 1;

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06005365 RID: 21349 RVA: 0x0015F45E File Offset: 0x0015D65E
		// (set) Token: 0x06005366 RID: 21350 RVA: 0x0015F466 File Offset: 0x0015D666
		public bool IsAcceptingItems { get; set; } = true;

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06005367 RID: 21351 RVA: 0x0015F46F File Offset: 0x0015D66F
		public EntityConfiguration Configuration
		{
			get
			{
				return this.ovenConfiguration;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06005368 RID: 21352 RVA: 0x0015F477 File Offset: 0x0015D677
		// (set) Token: 0x06005369 RID: 21353 RVA: 0x0015F47F File Offset: 0x0015D67F
		protected LabOvenConfiguration ovenConfiguration { get; set; }

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x0600536A RID: 21354 RVA: 0x0015F488 File Offset: 0x0015D688
		public ConfigurationReplicator ConfigReplicator
		{
			get
			{
				return this.configReplicator;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x0600536B RID: 21355 RVA: 0x0001AA34 File Offset: 0x00018C34
		public EConfigurableType ConfigurableType
		{
			get
			{
				return EConfigurableType.LabOven;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x0600536C RID: 21356 RVA: 0x0015F490 File Offset: 0x0015D690
		// (set) Token: 0x0600536D RID: 21357 RVA: 0x0015F498 File Offset: 0x0015D698
		public WorldspaceUIElement WorldspaceUI { get; set; }

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x0600536E RID: 21358 RVA: 0x0015F4A1 File Offset: 0x0015D6A1
		// (set) Token: 0x0600536F RID: 21359 RVA: 0x0015F4A9 File Offset: 0x0015D6A9
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

		// Token: 0x06005370 RID: 21360 RVA: 0x0015F4B3 File Offset: 0x0015D6B3
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
			this.RpcWriter___Server_SetConfigurer_3323014238(player);
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06005371 RID: 21361 RVA: 0x0015F4C9 File Offset: 0x0015D6C9
		public Sprite TypeIcon
		{
			get
			{
				return this.typeIcon;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06005372 RID: 21362 RVA: 0x000AEDCB File Offset: 0x000ACFCB
		public Transform Transform
		{
			get
			{
				return base.transform;
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06005373 RID: 21363 RVA: 0x0015F4D1 File Offset: 0x0015D6D1
		public Transform UIPoint
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06005374 RID: 21364 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CanBeSelected
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x0015F4DC File Offset: 0x0015D6DC
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ObjectScripts.LabOven_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x0015F4FC File Offset: 0x0015D6FC
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
				this.ovenConfiguration = new LabOvenConfiguration(this.configReplicator, this, this);
				this.CreateWorldspaceUI();
				GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 4);
				TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance2.onMinutePass = (Action)Delegate.Combine(instance2.onMinutePass, new Action(this.MinPass));
				TimeManager instance3 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance3.onTimeSkip = (Action<int>)Delegate.Combine(instance3.onTimeSkip, new Action<int>(this.TimeSkipped));
			}
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x0015F5AE File Offset: 0x0015D7AE
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			((IItemSlotOwner)this).SendItemsToClient(connection);
			if (this.CurrentOperation != null)
			{
				this.SetCookOperation(connection, this.CurrentOperation, false);
			}
			this.SendConfigurationToClient(connection);
		}

		// Token: 0x06005378 RID: 21368 RVA: 0x0015F5DC File Offset: 0x0015D7DC
		public void SendConfigurationToClient(NetworkConnection conn)
		{
			LabOven.<>c__DisplayClass125_0 CS$<>8__locals1 = new LabOven.<>c__DisplayClass125_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.conn = conn;
			if (CS$<>8__locals1.conn.IsHost)
			{
				return;
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SendConfigurationToClient>g__WaitForConfig|0());
		}

		// Token: 0x06005379 RID: 21369 RVA: 0x0015F61C File Offset: 0x0015D81C
		private void Update()
		{
			switch (this.LightMode)
			{
			case LabOven.ELightMode.Off:
				this.Light.isOn = false;
				break;
			case LabOven.ELightMode.On:
				this.Light.isOn = true;
				break;
			case LabOven.ELightMode.Flash:
				this.Light.isOn = (Mathf.Sin(Time.timeSinceLevelLoad * 4f) > 0f);
				break;
			}
			if (this.CurrentOperation != null)
			{
				this.RunLoopSound.VolumeMultiplier = Mathf.MoveTowards(this.RunLoopSound.VolumeMultiplier, 1f, Time.deltaTime);
				if (!this.RunLoopSound.isPlaying)
				{
					this.RunLoopSound.Play();
					return;
				}
			}
			else
			{
				this.RunLoopSound.VolumeMultiplier = Mathf.MoveTowards(this.RunLoopSound.VolumeMultiplier, 0f, Time.deltaTime);
				if (this.RunLoopSound.VolumeMultiplier <= 0f)
				{
					this.RunLoopSound.Stop();
				}
			}
		}

		// Token: 0x0600537A RID: 21370 RVA: 0x0015F70C File Offset: 0x0015D90C
		private void MinPass()
		{
			if (this.CurrentOperation != null)
			{
				bool flag = this.CurrentOperation.CookProgress >= this.CurrentOperation.GetCookDuration();
				this.CurrentOperation.UpdateCookProgress(1);
				if (!flag && this.CurrentOperation.CookProgress >= this.CurrentOperation.GetCookDuration())
				{
					this.DingSound.Play();
				}
			}
			this.UpdateOvenAppearance();
			this.UpdateLiquid();
		}

		// Token: 0x0600537B RID: 21371 RVA: 0x0015F77C File Offset: 0x0015D97C
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

		// Token: 0x0600537C RID: 21372 RVA: 0x0015F7A4 File Offset: 0x0015D9A4
		private void UpdateOvenAppearance()
		{
			if (this.CurrentOperation != null)
			{
				this.Button.SetPressed(true);
				this.TimerLabel.enabled = true;
				if (this.CurrentOperation.CookProgress >= this.CurrentOperation.GetCookDuration())
				{
					this.SetOvenLit(false);
					this.LightMode = LabOven.ELightMode.Flash;
				}
				else
				{
					this.SetOvenLit(true);
					this.LightMode = LabOven.ELightMode.On;
				}
				int num = this.CurrentOperation.GetCookDuration() - this.CurrentOperation.CookProgress;
				num = Mathf.Max(0, num);
				int num2 = num / 60;
				num %= 60;
				this.TimerLabel.text = string.Format("{0:D2}:{1:D2}", num2, num);
				return;
			}
			this.TimerLabel.enabled = false;
			this.Button.SetPressed(false);
			this.SetOvenLit(false);
			this.LightMode = LabOven.ELightMode.Off;
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x0015F87C File Offset: 0x0015DA7C
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

		// Token: 0x0600537E RID: 21374 RVA: 0x0015F8A7 File Offset: 0x0015DAA7
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
			if (this.CurrentOperation != null)
			{
				reason = "Currently cooking";
				return false;
			}
			return base.CanBeDestroyed(out reason);
		}

		// Token: 0x0600537F RID: 21375 RVA: 0x0015F8E4 File Offset: 0x0015DAE4
		public override void DestroyItem(bool callOnServer = true)
		{
			base.DestroyItem(callOnServer);
			if (!this.isGhost)
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
			}
		}

		// Token: 0x06005380 RID: 21376 RVA: 0x0015F985 File Offset: 0x0015DB85
		public void SetOvenLit(bool lit)
		{
			this.OvenLight.isOn = lit;
			this.Button.SetPressed(lit);
		}

		// Token: 0x06005381 RID: 21377 RVA: 0x0015F99F File Offset: 0x0015DB9F
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
			this.RpcWriter___Server_SetPlayerUser_3323014238(playerObject);
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x0015F9B5 File Offset: 0x0015DBB5
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
			this.RpcWriter___Server_SetNPCUser_3323014238(npcObject);
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x0015F9CC File Offset: 0x0015DBCC
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

		// Token: 0x06005384 RID: 21380 RVA: 0x0015FA26 File Offset: 0x0015DC26
		public void Interacted()
		{
			if (((IUsable)this).IsInUse || Singleton<ManagementClipboard>.Instance.IsEquipped)
			{
				return;
			}
			this.Open();
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x0015FA44 File Offset: 0x0015DC44
		public void Open()
		{
			this.SetPlayerUser(Player.Local.NetworkObject);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.CameraPosition_Default.position, this.CameraPosition_Default.rotation, 0.2f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(70f, 0.2f);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			Singleton<CompassManager>.Instance.SetVisible(false);
			Singleton<LabOvenCanvas>.Instance.SetIsOpen(this, true, true);
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x0015FAE4 File Offset: 0x0015DCE4
		public void Close()
		{
			Singleton<LabOvenCanvas>.Instance.SetIsOpen(null, false, true);
			this.SetPlayerUser(null);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.2f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.2f);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			Singleton<CompassManager>.Instance.SetVisible(true);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x0015FB60 File Offset: 0x0015DD60
		public bool IsIngredientCookable()
		{
			if (this.IngredientSlot.ItemInstance == null)
			{
				return false;
			}
			StorableItemDefinition storableItemDefinition = this.IngredientSlot.ItemInstance.Definition as StorableItemDefinition;
			return !(storableItemDefinition.StationItem == null) && storableItemDefinition.StationItem.HasModule<CookableModule>();
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x0015FBAD File Offset: 0x0015DDAD
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCookOperation(OvenCookOperation operation)
		{
			this.RpcWriter___Server_SendCookOperation_3708012700(operation);
			this.RpcLogic___SendCookOperation_3708012700(operation);
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x0015FBC4 File Offset: 0x0015DDC4
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetCookOperation(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetCookOperation_2611294368(conn, operation, playButtonPress);
				this.RpcLogic___SetCookOperation_2611294368(conn, operation, playButtonPress);
			}
			else
			{
				this.RpcWriter___Target_SetCookOperation_2611294368(conn, operation, playButtonPress);
			}
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x0015FC11 File Offset: 0x0015DE11
		public bool IsReadyToStart()
		{
			return this.IngredientSlot.Quantity > 0 && this.IsIngredientCookable() && this.CurrentOperation == null;
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x0015FC34 File Offset: 0x0015DE34
		public bool IsReadyForHarvest()
		{
			return this.CurrentOperation != null && this.CurrentOperation.CookProgress >= this.CurrentOperation.GetCookDuration();
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x0015FC5B File Offset: 0x0015DE5B
		public bool CanOutputSpaceFitCurrentOperation()
		{
			return this.CurrentOperation != null && this.OutputSlot.GetCapacityForItem(this.CurrentOperation.GetProductItem(1)) >= this.CurrentOperation.Cookable.ProductQuantity;
		}

		// Token: 0x0600538D RID: 21389 RVA: 0x0015FC93 File Offset: 0x0015DE93
		public void SetLiquidColor(Color col)
		{
			this.LiquidMesh.material.color = col;
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x0015FCA8 File Offset: 0x0015DEA8
		private void UpdateLiquid()
		{
			if (this.CurrentOperation == null)
			{
				return;
			}
			if (this.CurrentOperation.CookProgress >= this.CurrentOperation.GetCookDuration())
			{
				this.LiquidMesh.gameObject.SetActive(false);
				this.CookedLiquidMesh.gameObject.SetActive(true);
				return;
			}
			this.LiquidMesh.gameObject.SetActive(true);
			this.CookedLiquidMesh.gameObject.SetActive(false);
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x0015FD1C File Offset: 0x0015DF1C
		public StationItem[] CreateStationItems(int quantity = 1)
		{
			if (this.IngredientSlot.ItemInstance == null)
			{
				return null;
			}
			StorableItemDefinition storableItemDefinition = this.IngredientSlot.ItemInstance.Definition as StorableItemDefinition;
			if (storableItemDefinition.StationItem == null)
			{
				return null;
			}
			StationItem[] array;
			if (storableItemDefinition.StationItem.GetModule<CookableModule>().CookType == CookableModule.ECookableType.Liquid)
			{
				StationItem stationItem = Object.Instantiate<StationItem>(storableItemDefinition.StationItem, this.PourableContainer);
				stationItem.Initialize(storableItemDefinition);
				array = new StationItem[]
				{
					stationItem
				};
			}
			else
			{
				array = new StationItem[quantity];
				for (int i = 0; i < quantity; i++)
				{
					StationItem stationItem2 = Object.Instantiate<StationItem>(storableItemDefinition.StationItem, this.ItemContainer);
					stationItem2.Initialize(storableItemDefinition);
					stationItem2.transform.position = this.SolidIngredientSpawnPoints[i].position;
					stationItem2.transform.rotation = this.SolidIngredientSpawnPoints[i].rotation;
					stationItem2.transform.Rotate(Vector3.up, Random.Range(0f, 360f));
					array[i] = stationItem2;
				}
			}
			return array;
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x0015FE21 File Offset: 0x0015E021
		public void ResetPourableContainer()
		{
			this.PourableContainer.localPosition = this.pourableContainerDefaultPos;
			this.PourableContainer.localRotation = this.pourableContainerDefaultRot;
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x0015FE45 File Offset: 0x0015E045
		public void ResetSquareTray()
		{
			this.SquareTray.SetParent(this.WireTray.transform);
			this.SquareTray.localPosition = this.squareTrayDefaultPos;
			this.SquareTray.localRotation = this.squareTrayDefaultRot;
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x0015FE80 File Offset: 0x0015E080
		public LabOvenHammer CreateHammer()
		{
			LabOvenHammer component = Object.Instantiate<GameObject>(this.HammerPrefab.gameObject, this.HammerSpawnPoint.position, this.HammerSpawnPoint.rotation).GetComponent<LabOvenHammer>();
			component.Rotator.CuntAssFuckingBitch = this.OafBastard;
			component.Constraint.Container = this.HammerContainer;
			component.transform.SetParent(this.HammerContainer);
			return component;
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x0015FEEC File Offset: 0x0015E0EC
		public void CreateImpactEffects(Vector3 point, bool playSound = true)
		{
			Vector3 vector = this.DecalContainer.InverseTransformPoint(point);
			vector.y = 0f;
			vector.x = Mathf.Clamp(vector.x, this.DecalMinBounds.localPosition.x, this.DecalMaxBounds.localPosition.x);
			vector.z = Mathf.Clamp(vector.z, this.DecalMinBounds.localPosition.z, this.DecalMaxBounds.localPosition.z);
			GameObject gameObject = Object.Instantiate<GameObject>(this.SmashDecalPrefab, this.DecalContainer);
			gameObject.transform.localPosition = vector;
			this.decals.Add(gameObject);
			if (playSound)
			{
				this.ImpactSound.transform.position = point;
				this.ImpactSound.Play();
			}
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x0015FFC0 File Offset: 0x0015E1C0
		public void Shatter(int shardQuantity, GameObject shardPrefab)
		{
			this.CookedLiquidMesh.gameObject.SetActive(false);
			this.ShatterParticles.Play();
			this.ShatterSound.Play();
			this.ClearDecals();
			for (int i = 0; i < shardQuantity; i++)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(shardPrefab.gameObject, NetworkSingleton<GameManager>.Instance.Temp);
				gameObject.transform.position = this.ShardSpawnPoints[i].position;
				gameObject.transform.rotation = this.ShardSpawnPoints[i].rotation;
				gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 2f, 2);
				gameObject.GetComponent<Rigidbody>().AddTorque(Random.insideUnitSphere * 2f, 2);
				this.shards.Add(gameObject);
			}
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x00160094 File Offset: 0x0015E294
		public void ClearShards()
		{
			for (int i = 0; i < this.shards.Count; i++)
			{
				Object.Destroy(this.shards[i].gameObject);
			}
			this.shards.Clear();
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x001600D8 File Offset: 0x0015E2D8
		public void ClearDecals()
		{
			for (int i = 0; i < this.decals.Count; i++)
			{
				Object.Destroy(this.decals[i]);
			}
			this.decals.Clear();
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x00160117 File Offset: 0x0015E317
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			this.RpcWriter___Server_SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
			this.RpcLogic___SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x00160140 File Offset: 0x0015E340
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

		// Token: 0x06005399 RID: 21401 RVA: 0x0016019F File Offset: 0x0015E39F
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Server_SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x001601BD File Offset: 0x0015E3BD
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x001601DB File Offset: 0x0015E3DB
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			this.RpcWriter___Server_SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			this.RpcLogic___SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x00160214 File Offset: 0x0015E414
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

		// Token: 0x0600539D RID: 21405 RVA: 0x00160294 File Offset: 0x0015E494
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
			LabOvenUIElement component = Object.Instantiate<LabOvenUIElement>(this.WorldspaceUIPrefab, base.ParentProperty.WorldspaceUIContainer).GetComponent<LabOvenUIElement>();
			component.Initialize(this);
			this.WorldspaceUI = component;
			return component;
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x00160327 File Offset: 0x0015E527
		public void DestroyWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				this.WorldspaceUI.Destroy();
			}
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x00160344 File Offset: 0x0015E544
		public override string GetSaveString()
		{
			string ingredientID = string.Empty;
			int currentIngredientQuantity = 0;
			EQuality ingredientQuality = EQuality.Standard;
			string productID = string.Empty;
			int currentCookProgress = 0;
			if (this.CurrentOperation != null)
			{
				ingredientID = this.CurrentOperation.IngredientID;
				currentIngredientQuantity = this.CurrentOperation.IngredientQuantity;
				ingredientQuality = this.CurrentOperation.IngredientQuality;
				productID = this.CurrentOperation.ProductID;
				currentCookProgress = this.CurrentOperation.CookProgress;
			}
			return new LabOvenData(base.GUID, base.ItemInstance, 0, base.OwnerGrid, this.OriginCoordinate, this.Rotation, new ItemSet(new List<ItemSlot>
			{
				this.IngredientSlot
			}), new ItemSet(new List<ItemSlot>
			{
				this.OutputSlot
			}), ingredientID, currentIngredientQuantity, ingredientQuality, productID, currentCookProgress).GetJson(true);
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x00160408 File Offset: 0x0015E608
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

		// Token: 0x060053A2 RID: 21410 RVA: 0x001604B4 File Offset: 0x0015E6B4
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.LabOvenAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.LabOvenAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField = new SyncVar<NetworkObject>(this, 2U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<CurrentPlayerConfigurer>k__BackingField);
			this.syncVar___<PlayerUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<PlayerUserObject>k__BackingField);
			this.syncVar___<NPCUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<NPCUserObject>k__BackingField);
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SetConfigurer_3323014238));
			base.RegisterServerRpc(9U, new ServerRpcDelegate(this.RpcReader___Server_SetPlayerUser_3323014238));
			base.RegisterServerRpc(10U, new ServerRpcDelegate(this.RpcReader___Server_SetNPCUser_3323014238));
			base.RegisterServerRpc(11U, new ServerRpcDelegate(this.RpcReader___Server_SendCookOperation_3708012700));
			base.RegisterObserversRpc(12U, new ClientRpcDelegate(this.RpcReader___Observers_SetCookOperation_2611294368));
			base.RegisterTargetRpc(13U, new ClientRpcDelegate(this.RpcReader___Target_SetCookOperation_2611294368));
			base.RegisterServerRpc(14U, new ServerRpcDelegate(this.RpcReader___Server_SetStoredInstance_2652194801));
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_SetStoredInstance_Internal_2652194801));
			base.RegisterTargetRpc(16U, new ClientRpcDelegate(this.RpcReader___Target_SetStoredInstance_Internal_2652194801));
			base.RegisterServerRpc(17U, new ServerRpcDelegate(this.RpcReader___Server_SetItemSlotQuantity_1692629761));
			base.RegisterObserversRpc(18U, new ClientRpcDelegate(this.RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761));
			base.RegisterServerRpc(19U, new ServerRpcDelegate(this.RpcReader___Server_SetSlotLocked_3170825843));
			base.RegisterTargetRpc(20U, new ClientRpcDelegate(this.RpcReader___Target_SetSlotLocked_Internal_3170825843));
			base.RegisterObserversRpc(21U, new ClientRpcDelegate(this.RpcReader___Observers_SetSlotLocked_Internal_3170825843));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.ObjectScripts.LabOven));
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x001606AD File Offset: 0x0015E8AD
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.LabOvenAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.LabOvenAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetRegistered();
			this.syncVar___<PlayerUserObject>k__BackingField.SetRegistered();
			this.syncVar___<NPCUserObject>k__BackingField.SetRegistered();
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x001606E7 File Offset: 0x0015E8E7
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x001606F8 File Offset: 0x0015E8F8
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

		// Token: 0x060053A6 RID: 21414 RVA: 0x0016079F File Offset: 0x0015E99F
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			this.CurrentPlayerConfigurer = player;
		}

		// Token: 0x060053A7 RID: 21415 RVA: 0x001607A8 File Offset: 0x0015E9A8
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

		// Token: 0x060053A8 RID: 21416 RVA: 0x001607E8 File Offset: 0x0015E9E8
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
			base.SendServerRpc(9U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060053A9 RID: 21417 RVA: 0x0016088F File Offset: 0x0015EA8F
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			this.PlayerUserObject = playerObject;
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x00160898 File Offset: 0x0015EA98
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

		// Token: 0x060053AB RID: 21419 RVA: 0x001608D8 File Offset: 0x0015EAD8
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
			base.SendServerRpc(10U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060053AC RID: 21420 RVA: 0x0016097F File Offset: 0x0015EB7F
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			this.NPCUserObject = npcObject;
		}

		// Token: 0x060053AD RID: 21421 RVA: 0x00160988 File Offset: 0x0015EB88
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

		// Token: 0x060053AE RID: 21422 RVA: 0x001609C8 File Offset: 0x0015EBC8
		private void RpcWriter___Server_SendCookOperation_3708012700(OvenCookOperation operation)
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
			writer.Write___ScheduleOne.ObjectScripts.OvenCookOperationFishNet.Serializing.Generated(operation);
			base.SendServerRpc(11U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060053AF RID: 21423 RVA: 0x00160A6F File Offset: 0x0015EC6F
		public void RpcLogic___SendCookOperation_3708012700(OvenCookOperation operation)
		{
			this.SetCookOperation(null, operation, true);
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x00160A7C File Offset: 0x0015EC7C
		private void RpcReader___Server_SendCookOperation_3708012700(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			OvenCookOperation operation = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.OvenCookOperationFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendCookOperation_3708012700(operation);
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x00160ABC File Offset: 0x0015ECBC
		private void RpcWriter___Observers_SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
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
			writer.Write___ScheduleOne.ObjectScripts.OvenCookOperationFishNet.Serializing.Generated(operation);
			writer.WriteBoolean(playButtonPress);
			base.SendObserversRpc(12U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x00160B80 File Offset: 0x0015ED80
		public void RpcLogic___SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
		{
			this.CurrentOperation = operation;
			if (this.CurrentOperation == null)
			{
				this.LiquidMesh.gameObject.SetActive(false);
				this.CookedLiquidMesh.gameObject.SetActive(false);
				return;
			}
			CookableModule module = operation.Ingredient.StationItem.GetModule<CookableModule>();
			if (module == null)
			{
				return;
			}
			this.SetLiquidColor(module.LiquidColor);
			this.CookedLiquidMesh.material.color = module.SolidColor;
			this.UpdateLiquid();
			if (playButtonPress)
			{
				this.ButtonSound.Play();
			}
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x00160C10 File Offset: 0x0015EE10
		private void RpcReader___Observers_SetCookOperation_2611294368(PooledReader PooledReader0, Channel channel)
		{
			OvenCookOperation operation = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.OvenCookOperationFishNet.Serializing.Generateds(PooledReader0);
			bool playButtonPress = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetCookOperation_2611294368(null, operation, playButtonPress);
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x00160C60 File Offset: 0x0015EE60
		private void RpcWriter___Target_SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
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
			writer.Write___ScheduleOne.ObjectScripts.OvenCookOperationFishNet.Serializing.Generated(operation);
			writer.WriteBoolean(playButtonPress);
			base.SendTargetRpc(13U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x00160D24 File Offset: 0x0015EF24
		private void RpcReader___Target_SetCookOperation_2611294368(PooledReader PooledReader0, Channel channel)
		{
			OvenCookOperation operation = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.OvenCookOperationFishNet.Serializing.Generateds(PooledReader0);
			bool playButtonPress = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetCookOperation_2611294368(base.LocalConnection, operation, playButtonPress);
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x00160D6C File Offset: 0x0015EF6C
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

		// Token: 0x060053B7 RID: 21431 RVA: 0x00160E32 File Offset: 0x0015F032
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetStoredInstance_Internal(null, itemSlotIndex, instance);
				return;
			}
			this.SetStoredInstance_Internal(conn, itemSlotIndex, instance);
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x00160E5C File Offset: 0x0015F05C
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

		// Token: 0x060053B9 RID: 21433 RVA: 0x00160EC4 File Offset: 0x0015F0C4
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

		// Token: 0x060053BA RID: 21434 RVA: 0x00160F8C File Offset: 0x0015F18C
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (instance != null)
			{
				this.ItemSlots[itemSlotIndex].SetStoredItem(instance, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].ClearStoredInstance(true);
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x00160FB8 File Offset: 0x0015F1B8
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

		// Token: 0x060053BC RID: 21436 RVA: 0x0016100C File Offset: 0x0015F20C
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

		// Token: 0x060053BD RID: 21437 RVA: 0x001610D4 File Offset: 0x0015F2D4
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

		// Token: 0x060053BE RID: 21438 RVA: 0x0016112C File Offset: 0x0015F32C
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

		// Token: 0x060053BF RID: 21439 RVA: 0x001611EA File Offset: 0x0015F3EA
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			this.SetItemSlotQuantity_Internal(itemSlotIndex, quantity);
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x001611F4 File Offset: 0x0015F3F4
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

		// Token: 0x060053C1 RID: 21441 RVA: 0x00161250 File Offset: 0x0015F450
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

		// Token: 0x060053C2 RID: 21442 RVA: 0x0016131D File Offset: 0x0015F51D
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			this.ItemSlots[itemSlotIndex].SetQuantity(quantity, true);
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x00161334 File Offset: 0x0015F534
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

		// Token: 0x060053C4 RID: 21444 RVA: 0x0016138C File Offset: 0x0015F58C
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

		// Token: 0x060053C5 RID: 21445 RVA: 0x0016146C File Offset: 0x0015F66C
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetSlotLocked_Internal(null, itemSlotIndex, locked, lockOwner, lockReason);
				return;
			}
			this.SetSlotLocked_Internal(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x0016149C File Offset: 0x0015F69C
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

		// Token: 0x060053C7 RID: 21447 RVA: 0x00161524 File Offset: 0x0015F724
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

		// Token: 0x060053C8 RID: 21448 RVA: 0x00161605 File Offset: 0x0015F805
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (locked)
			{
				this.ItemSlots[itemSlotIndex].ApplyLock(lockOwner, lockReason, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].RemoveLock(true);
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x00161634 File Offset: 0x0015F834
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

		// Token: 0x060053CA RID: 21450 RVA: 0x001616B0 File Offset: 0x0015F8B0
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

		// Token: 0x060053CB RID: 21451 RVA: 0x00161794 File Offset: 0x0015F994
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

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060053CC RID: 21452 RVA: 0x00161808 File Offset: 0x0015FA08
		// (set) Token: 0x060053CD RID: 21453 RVA: 0x00161810 File Offset: 0x0015FA10
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

		// Token: 0x060053CE RID: 21454 RVA: 0x0016184C File Offset: 0x0015FA4C
		public virtual bool LabOven(PooledReader PooledReader0, uint UInt321, bool Boolean2)
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

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060053CF RID: 21455 RVA: 0x00161926 File Offset: 0x0015FB26
		// (set) Token: 0x060053D0 RID: 21456 RVA: 0x0016192E File Offset: 0x0015FB2E
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

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x060053D1 RID: 21457 RVA: 0x0016196A File Offset: 0x0015FB6A
		// (set) Token: 0x060053D2 RID: 21458 RVA: 0x00161972 File Offset: 0x0015FB72
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

		// Token: 0x060053D3 RID: 21459 RVA: 0x001619B0 File Offset: 0x0015FBB0
		protected virtual void dll()
		{
			base.Awake();
			this.pourableContainerDefaultPos = this.PourableContainer.localPosition;
			this.pourableContainerDefaultRot = this.PourableContainer.localRotation;
			this.squareTrayDefaultPos = this.SquareTray.localPosition;
			this.squareTrayDefaultRot = this.SquareTray.localRotation;
			this.TimerLabel.enabled = false;
			if (!this.isGhost)
			{
				this.IngredientSlot.SetSlotOwner(this);
				this.OutputSlot.SetSlotOwner(this);
				this.OutputSlot.SetIsAddLocked(true);
				this.InputVisuals.AddSlot(this.IngredientSlot, false);
				this.OutputVisuals.AddSlot(this.OutputSlot, false);
				this.InputSlots.Add(this.IngredientSlot);
				this.OutputSlots.Add(this.OutputSlot);
			}
		}

		// Token: 0x04003E1C RID: 15900
		public const int SOLID_INGREDIENT_COOK_LIMIT = 10;

		// Token: 0x04003E1D RID: 15901
		public const float FOV_OVERRIDE = 70f;

		// Token: 0x04003E20 RID: 15904
		public LabOven.ELightMode LightMode;

		// Token: 0x04003E21 RID: 15905
		[Header("References")]
		public Transform CameraPosition_Default;

		// Token: 0x04003E22 RID: 15906
		public Transform CameraPosition_Pour;

		// Token: 0x04003E23 RID: 15907
		public Transform CameraPosition_PlaceItems;

		// Token: 0x04003E24 RID: 15908
		public Transform CameraPosition_Breaking;

		// Token: 0x04003E25 RID: 15909
		public InteractableObject IntObj;

		// Token: 0x04003E26 RID: 15910
		public LabOvenDoor Door;

		// Token: 0x04003E27 RID: 15911
		public LabOvenWireTray WireTray;

		// Token: 0x04003E28 RID: 15912
		public ToggleableLight OvenLight;

		// Token: 0x04003E29 RID: 15913
		public LabOvenButton Button;

		// Token: 0x04003E2A RID: 15914
		public TextMeshPro TimerLabel;

		// Token: 0x04003E2B RID: 15915
		public ToggleableLight Light;

		// Token: 0x04003E2C RID: 15916
		public Transform PourableContainer;

		// Token: 0x04003E2D RID: 15917
		public Transform ItemContainer;

		// Token: 0x04003E2E RID: 15918
		public Animation PourAnimation;

		// Token: 0x04003E2F RID: 15919
		public SkinnedMeshRenderer LiquidMesh;

		// Token: 0x04003E30 RID: 15920
		public StorageVisualizer InputVisuals;

		// Token: 0x04003E31 RID: 15921
		public StorageVisualizer OutputVisuals;

		// Token: 0x04003E32 RID: 15922
		public MeshRenderer CookedLiquidMesh;

		// Token: 0x04003E33 RID: 15923
		public Animation RemoveTrayAnimation;

		// Token: 0x04003E34 RID: 15924
		public Transform SquareTray;

		// Token: 0x04003E35 RID: 15925
		public Transform HammerSpawnPoint;

		// Token: 0x04003E36 RID: 15926
		public Transform HammerContainer;

		// Token: 0x04003E37 RID: 15927
		public Transform OafBastard;

		// Token: 0x04003E38 RID: 15928
		public Transform DecalContainer;

		// Token: 0x04003E39 RID: 15929
		public Transform DecalMaxBounds;

		// Token: 0x04003E3A RID: 15930
		public Transform DecalMinBounds;

		// Token: 0x04003E3B RID: 15931
		public BoxCollider CookedLiquidCollider;

		// Token: 0x04003E3C RID: 15932
		public Transform[] ShardSpawnPoints;

		// Token: 0x04003E3D RID: 15933
		public ParticleSystem ShatterParticles;

		// Token: 0x04003E3E RID: 15934
		public Transform uiPoint;

		// Token: 0x04003E3F RID: 15935
		public Transform[] accessPoints;

		// Token: 0x04003E40 RID: 15936
		public ConfigurationReplicator configReplicator;

		// Token: 0x04003E41 RID: 15937
		public Transform[] SolidIngredientSpawnPoints;

		// Token: 0x04003E42 RID: 15938
		public BoxCollider TrayDetectionArea;

		// Token: 0x04003E43 RID: 15939
		[Header("Sounds")]
		public AudioSourceController ButtonSound;

		// Token: 0x04003E44 RID: 15940
		public AudioSourceController DingSound;

		// Token: 0x04003E45 RID: 15941
		public AudioSourceController RunLoopSound;

		// Token: 0x04003E46 RID: 15942
		public AudioSourceController ImpactSound;

		// Token: 0x04003E47 RID: 15943
		public AudioSourceController ShatterSound;

		// Token: 0x04003E48 RID: 15944
		[Header("UI")]
		public LabOvenUIElement WorldspaceUIPrefab;

		// Token: 0x04003E49 RID: 15945
		public Sprite typeIcon;

		// Token: 0x04003E4A RID: 15946
		[Header("Prefabs")]
		public LabOvenHammer HammerPrefab;

		// Token: 0x04003E4B RID: 15947
		public GameObject SmashDecalPrefab;

		// Token: 0x04003E4E RID: 15950
		public ItemSlot IngredientSlot;

		// Token: 0x04003E4F RID: 15951
		public ItemSlot OutputSlot;

		// Token: 0x04003E57 RID: 15959
		private Vector3 pourableContainerDefaultPos;

		// Token: 0x04003E58 RID: 15960
		private Quaternion pourableContainerDefaultRot;

		// Token: 0x04003E59 RID: 15961
		private Vector3 squareTrayDefaultPos;

		// Token: 0x04003E5A RID: 15962
		private Quaternion squareTrayDefaultRot;

		// Token: 0x04003E5B RID: 15963
		private List<GameObject> decals = new List<GameObject>();

		// Token: 0x04003E5C RID: 15964
		private List<GameObject> shards = new List<GameObject>();

		// Token: 0x04003E5D RID: 15965
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003E5E RID: 15966
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003E5F RID: 15967
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04003E60 RID: 15968
		private bool dll_Excuted;

		// Token: 0x04003E61 RID: 15969
		private bool dll_Excuted;

		// Token: 0x02000BD5 RID: 3029
		public enum ELightMode
		{
			// Token: 0x04003E63 RID: 15971
			Off,
			// Token: 0x04003E64 RID: 15972
			On,
			// Token: 0x04003E65 RID: 15973
			Flash
		}

		// Token: 0x02000BD6 RID: 3030
		public enum EState
		{
			// Token: 0x04003E67 RID: 15975
			CanBegin,
			// Token: 0x04003E68 RID: 15976
			MissingItems,
			// Token: 0x04003E69 RID: 15977
			InsufficentProduct,
			// Token: 0x04003E6A RID: 15978
			OutputSlotFull,
			// Token: 0x04003E6B RID: 15979
			Mismatch
		}
	}
}
