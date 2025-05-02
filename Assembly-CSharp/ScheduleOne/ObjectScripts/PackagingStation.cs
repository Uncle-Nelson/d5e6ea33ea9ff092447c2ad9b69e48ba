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
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.Decoration;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Packaging;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Property;
using ScheduleOne.Tiles;
using ScheduleOne.Tools;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Management;
using ScheduleOne.UI.Stations;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BE6 RID: 3046
	public class PackagingStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06005517 RID: 21783 RVA: 0x001667D2 File Offset: 0x001649D2
		// (set) Token: 0x06005518 RID: 21784 RVA: 0x001667DA File Offset: 0x001649DA
		public List<ItemSlot> ItemSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06005519 RID: 21785 RVA: 0x001667E3 File Offset: 0x001649E3
		// (set) Token: 0x0600551A RID: 21786 RVA: 0x001667EB File Offset: 0x001649EB
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

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600551B RID: 21787 RVA: 0x001667F5 File Offset: 0x001649F5
		// (set) Token: 0x0600551C RID: 21788 RVA: 0x001667FD File Offset: 0x001649FD
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

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x0600551D RID: 21789 RVA: 0x00150487 File Offset: 0x0014E687
		public string Name
		{
			get
			{
				return base.ItemInstance.Name;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x0600551E RID: 21790 RVA: 0x00166807 File Offset: 0x00164A07
		// (set) Token: 0x0600551F RID: 21791 RVA: 0x0016680F File Offset: 0x00164A0F
		public List<ItemSlot> InputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06005520 RID: 21792 RVA: 0x00166818 File Offset: 0x00164A18
		// (set) Token: 0x06005521 RID: 21793 RVA: 0x00166820 File Offset: 0x00164A20
		public List<ItemSlot> OutputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06005522 RID: 21794 RVA: 0x00166829 File Offset: 0x00164A29
		public Transform LinkOrigin
		{
			get
			{
				return this.UIPoint;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06005523 RID: 21795 RVA: 0x00166831 File Offset: 0x00164A31
		public Transform[] AccessPoints
		{
			get
			{
				return this.accessPoints;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06005524 RID: 21796 RVA: 0x00166839 File Offset: 0x00164A39
		public bool Selectable { get; } = 1;

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06005525 RID: 21797 RVA: 0x00166841 File Offset: 0x00164A41
		// (set) Token: 0x06005526 RID: 21798 RVA: 0x00166849 File Offset: 0x00164A49
		public bool IsAcceptingItems { get; set; } = true;

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06005527 RID: 21799 RVA: 0x00166852 File Offset: 0x00164A52
		public EntityConfiguration Configuration
		{
			get
			{
				return this.stationConfiguration;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06005528 RID: 21800 RVA: 0x0016685A File Offset: 0x00164A5A
		// (set) Token: 0x06005529 RID: 21801 RVA: 0x00166862 File Offset: 0x00164A62
		protected PackagingStationConfiguration stationConfiguration { get; set; }

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x0600552A RID: 21802 RVA: 0x0016686B File Offset: 0x00164A6B
		public ConfigurationReplicator ConfigReplicator
		{
			get
			{
				return this.configReplicator;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x0600552B RID: 21803 RVA: 0x000022C9 File Offset: 0x000004C9
		public EConfigurableType ConfigurableType
		{
			get
			{
				return EConfigurableType.PackagingStation;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x0600552C RID: 21804 RVA: 0x00166873 File Offset: 0x00164A73
		// (set) Token: 0x0600552D RID: 21805 RVA: 0x0016687B File Offset: 0x00164A7B
		public WorldspaceUIElement WorldspaceUI { get; set; }

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x0600552E RID: 21806 RVA: 0x00166884 File Offset: 0x00164A84
		// (set) Token: 0x0600552F RID: 21807 RVA: 0x0016688C File Offset: 0x00164A8C
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

		// Token: 0x06005530 RID: 21808 RVA: 0x00166896 File Offset: 0x00164A96
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
			this.RpcWriter___Server_SetConfigurer_3323014238(player);
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06005531 RID: 21809 RVA: 0x001668AC File Offset: 0x00164AAC
		public Sprite TypeIcon
		{
			get
			{
				return this.typeIcon;
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06005532 RID: 21810 RVA: 0x000AEDCB File Offset: 0x000ACFCB
		public Transform Transform
		{
			get
			{
				return base.transform;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06005533 RID: 21811 RVA: 0x001668B4 File Offset: 0x00164AB4
		public Transform UIPoint
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06005534 RID: 21812 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CanBeSelected
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x001668BC File Offset: 0x00164ABC
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ObjectScripts.PackagingStation_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x001668DC File Offset: 0x00164ADC
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
				this.stationConfiguration = new PackagingStationConfiguration(this.configReplicator, this, this);
				this.CreateWorldspaceUI();
				GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 4);
			}
		}

		// Token: 0x06005537 RID: 21815 RVA: 0x0016693F File Offset: 0x00164B3F
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			((IItemSlotOwner)this).SendItemsToClient(connection);
			this.SendConfigurationToClient(connection);
		}

		// Token: 0x06005538 RID: 21816 RVA: 0x00166958 File Offset: 0x00164B58
		public void SendConfigurationToClient(NetworkConnection conn)
		{
			PackagingStation.<>c__DisplayClass103_0 CS$<>8__locals1 = new PackagingStation.<>c__DisplayClass103_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.conn = conn;
			if (CS$<>8__locals1.conn.IsHost)
			{
				return;
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SendConfigurationToClient>g__WaitForConfig|0());
		}

		// Token: 0x06005539 RID: 21817 RVA: 0x00166998 File Offset: 0x00164B98
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!Singleton<PackagingStationCanvas>.Instance.isOpen)
			{
				return;
			}
			if (Singleton<PackagingStationCanvas>.Instance.PackagingStation != this)
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

		// Token: 0x0600553A RID: 21818 RVA: 0x001669E5 File Offset: 0x00164BE5
		public override bool CanBeDestroyed(out string reason)
		{
			if (((IUsable)this).IsInUse)
			{
				reason = "Currently in use";
				return false;
			}
			if (((IItemSlotOwner)this).GetTotalItemCount() > 0)
			{
				reason = "Contains items";
				return false;
			}
			return base.CanBeDestroyed(out reason);
		}

		// Token: 0x0600553B RID: 21819 RVA: 0x00166A11 File Offset: 0x00164C11
		public override void DestroyItem(bool callOnServer = true)
		{
			GameInput.DeregisterExitListener(new GameInput.ExitDelegate(this.Exit));
			if (this.Configuration != null)
			{
				this.Configuration.Destroy();
				this.DestroyWorldspaceUI();
				base.ParentProperty.RemoveConfigurable(this);
			}
			base.DestroyItem(callOnServer);
		}

		// Token: 0x0600553C RID: 21820 RVA: 0x00166A50 File Offset: 0x00164C50
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
			this.RpcWriter___Server_SetPlayerUser_3323014238(playerObject);
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x0600553D RID: 21821 RVA: 0x00166A71 File Offset: 0x00164C71
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
			this.RpcWriter___Server_SetNPCUser_3323014238(npcObject);
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x00166A88 File Offset: 0x00164C88
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

		// Token: 0x0600553F RID: 21823 RVA: 0x00166AE2 File Offset: 0x00164CE2
		public void Interacted()
		{
			if (((IUsable)this).IsInUse || Singleton<ManagementClipboard>.Instance.IsEquipped)
			{
				return;
			}
			this.Open();
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x00166B00 File Offset: 0x00164D00
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
			Singleton<PackagingStationCanvas>.Instance.SetIsOpen(this, true, true);
		}

		// Token: 0x06005541 RID: 21825 RVA: 0x00166BA0 File Offset: 0x00164DA0
		public void Close()
		{
			if (Singleton<PackagingStationCanvas>.InstanceExists)
			{
				Singleton<PackagingStationCanvas>.Instance.SetIsOpen(null, false, true);
			}
			this.SetPlayerUser(null);
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
				PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.2f, true, true);
				PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.2f);
				PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			}
			if (Singleton<CompassManager>.InstanceExists)
			{
				Singleton<CompassManager>.Instance.SetVisible(true);
			}
			if (PlayerSingleton<PlayerInventory>.InstanceExists)
			{
				PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
			}
			if (PlayerSingleton<PlayerMovement>.InstanceExists)
			{
				PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			}
		}

		// Token: 0x06005542 RID: 21826 RVA: 0x00166C40 File Offset: 0x00164E40
		public PackagingStation.EState GetState(PackagingStation.EMode mode)
		{
			if (mode == PackagingStation.EMode.Package)
			{
				if (this.PackagingSlot.Quantity == 0)
				{
					return PackagingStation.EState.MissingItems;
				}
				if (this.ProductSlot.Quantity == 0)
				{
					return PackagingStation.EState.MissingItems;
				}
				if (this.OutputSlot.IsAtCapacity)
				{
					return PackagingStation.EState.OutputSlotFull;
				}
				if (this.OutputSlot.Quantity > 0 && this.OutputSlot.ItemInstance.ID != this.ProductSlot.ItemInstance.ID)
				{
					return PackagingStation.EState.Mismatch;
				}
				if (this.OutputSlot.Quantity > 0 && (this.OutputSlot.ItemInstance as ProductItemInstance).AppliedPackaging.ID != this.PackagingSlot.ItemInstance.Definition.ID)
				{
					return PackagingStation.EState.Mismatch;
				}
				if (this.OutputSlot.Quantity > 0 && (this.OutputSlot.ItemInstance as ProductItemInstance).Quality != (this.ProductSlot.ItemInstance as ProductItemInstance).Quality)
				{
					return PackagingStation.EState.Mismatch;
				}
				int quantity = (this.PackagingSlot.ItemInstance.Definition as PackagingDefinition).Quantity;
				if (this.ProductSlot.Quantity < quantity)
				{
					return PackagingStation.EState.InsufficentProduct;
				}
			}
			else if (mode == PackagingStation.EMode.Unpackage)
			{
				if (this.OutputSlot.Quantity == 0)
				{
					return PackagingStation.EState.MissingItems;
				}
				ProductItemInstance productItemInstance = this.OutputSlot.ItemInstance.GetCopy(1) as ProductItemInstance;
				if (productItemInstance == null)
				{
					return PackagingStation.EState.MissingItems;
				}
				PackagingDefinition appliedPackaging = productItemInstance.AppliedPackaging;
				int quantity2 = appliedPackaging.Quantity;
				if (this.PackagingSlot.GetCapacityForItem(appliedPackaging.GetDefaultInstance(1)) < 1)
				{
					return PackagingStation.EState.PackageSlotFull;
				}
				productItemInstance.SetPackaging(null);
				if (this.ProductSlot.GetCapacityForItem(productItemInstance) < quantity2)
				{
					return PackagingStation.EState.ProductSlotFull;
				}
			}
			return PackagingStation.EState.CanBegin;
		}

		// Token: 0x06005543 RID: 21827 RVA: 0x00166DD4 File Offset: 0x00164FD4
		public void Unpack()
		{
			PackagingDefinition appliedPackaging = (this.OutputSlot.ItemInstance as ProductItemInstance).AppliedPackaging;
			int quantity = appliedPackaging.Quantity;
			ProductItemInstance productItemInstance = this.OutputSlot.ItemInstance.GetCopy(quantity) as ProductItemInstance;
			productItemInstance.SetPackaging(null);
			if (appliedPackaging.ID != "brick")
			{
				this.PackagingSlot.AddItem(appliedPackaging.GetDefaultInstance(1), false);
			}
			this.ProductSlot.AddItem(productItemInstance, false);
			this.OutputSlot.ChangeQuantity(-1, false);
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x00166E5C File Offset: 0x0016505C
		public void PackSingleInstance()
		{
			int quantity = (this.PackagingSlot.ItemInstance.Definition as PackagingDefinition).Quantity;
			float value = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("PackagedProductCount");
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("PackagedProductCount", (value + 1f).ToString(), true);
			if (this.OutputSlot.ItemInstance == null)
			{
				ItemInstance copy = this.ProductSlot.ItemInstance.GetCopy(1);
				(copy as ProductItemInstance).SetPackaging(this.PackagingSlot.ItemInstance.Definition as PackagingDefinition);
				this.OutputSlot.SetStoredItem(copy, false);
			}
			else
			{
				this.OutputSlot.ChangeQuantity(1, false);
			}
			this.PackagingSlot.ChangeQuantity(-1, false);
			this.ProductSlot.ChangeQuantity(-quantity, false);
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x00166F2C File Offset: 0x0016512C
		public void SetHatchOpen(bool open)
		{
			PackagingStation.<>c__DisplayClass116_0 CS$<>8__locals1 = new PackagingStation.<>c__DisplayClass116_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.open = open;
			if (CS$<>8__locals1.open == this.hatchOpen)
			{
				return;
			}
			this.hatchOpen = CS$<>8__locals1.open;
			if (this.hatchOpen)
			{
				this.HatchOpenSound.Play();
			}
			else
			{
				this.HatchCloseSound.Play();
			}
			if (this.hatchRoutine != null)
			{
				base.StopCoroutine(this.hatchRoutine);
			}
			base.StartCoroutine(CS$<>8__locals1.<SetHatchOpen>g__Routine|0());
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x00166FA9 File Offset: 0x001651A9
		public void UpdatePackagingVisuals()
		{
			this.UpdatePackagingVisuals(this.PackagingSlot.Quantity);
		}

		// Token: 0x06005547 RID: 21831 RVA: 0x00166FBC File Offset: 0x001651BC
		public void SetVisualsLocked(bool locked)
		{
			this.visualsLocked = locked;
		}

		// Token: 0x06005548 RID: 21832 RVA: 0x00166FC8 File Offset: 0x001651C8
		public void UpdatePackagingVisuals(int quantity)
		{
			if (this.PackagingSlot == null)
			{
				return;
			}
			if (this.visualsLocked)
			{
				return;
			}
			string text = string.Empty;
			FunctionalPackaging functionalPackaging = null;
			if (quantity > 0 && this.PackagingSlot.ItemInstance != null)
			{
				text = this.PackagingSlot.ItemInstance.ID;
				if (this.PackagingSlot.ItemInstance.Definition as PackagingDefinition == null)
				{
					string str = "Failed to get packaging definition for item instance: ";
					ItemInstance itemInstance = this.PackagingSlot.ItemInstance;
					Console.LogError(str + ((itemInstance != null) ? itemInstance.ToString() : null), null);
					return;
				}
				functionalPackaging = (this.PackagingSlot.ItemInstance.Definition as PackagingDefinition).FunctionalPackaging;
			}
			for (int i = 0; i < this.PackagingAlignments.Length; i++)
			{
				if ((quantity <= i || this.PackagingSlotModelID[i] != text) && this.PackagingSlotModelID[i] != string.Empty)
				{
					if (this.PackagingAlignments[i].childCount > 0)
					{
						Object.Destroy(this.PackagingAlignments[i].GetChild(0).gameObject);
					}
					this.PackagingSlotModelID[i] = string.Empty;
				}
				if (!(functionalPackaging == null) && quantity > i && this.PackagingSlotModelID[i] != text)
				{
					GameObject gameObject = Object.Instantiate<GameObject>(functionalPackaging.gameObject, this.PackagingAlignments[i]).gameObject;
					gameObject.GetComponent<FunctionalPackaging>().AlignTo(this.PackagingAlignments[i]);
					this.PackagingSlotModelID[i] = text;
					Object.Destroy(gameObject.GetComponent<FunctionalPackaging>());
				}
			}
		}

		// Token: 0x06005549 RID: 21833 RVA: 0x00167156 File Offset: 0x00165356
		public void UpdateProductVisuals()
		{
			this.UpdateProductVisuals(this.ProductSlot.Quantity);
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x0016716C File Offset: 0x0016536C
		public void UpdateProductVisuals(int quantity)
		{
			if (this.ProductSlot == null)
			{
				return;
			}
			if (this.visualsLocked)
			{
				return;
			}
			string text = string.Empty;
			FunctionalProduct functionalProduct = null;
			if (quantity > 0)
			{
				text = this.ProductSlot.ItemInstance.ID;
				ProductDefinition productDefinition = this.ProductSlot.ItemInstance.Definition as ProductDefinition;
				if (productDefinition == null)
				{
					string str = "Failed to get product definition for item instance: ";
					ItemInstance itemInstance = this.PackagingSlot.ItemInstance;
					Console.LogError(str + ((itemInstance != null) ? itemInstance.ToString() : null), null);
					return;
				}
				functionalProduct = productDefinition.FunctionalProduct;
			}
			for (int i = 0; i < this.ProductAlignments.Length; i++)
			{
				if ((quantity <= i || this.ProductSlotModelID[i] != text) && this.ProductSlotModelID[i] != string.Empty)
				{
					Object.Destroy(this.ProductAlignments[i].GetChild(0).gameObject);
					this.ProductSlotModelID[i] = string.Empty;
				}
				if (!(functionalProduct == null) && quantity > i && this.ProductSlotModelID[i] != text)
				{
					FunctionalProduct component = Object.Instantiate<GameObject>(functionalProduct.gameObject, this.ProductAlignments[i]).GetComponent<FunctionalProduct>();
					component.InitializeVisuals(this.ProductSlot.ItemInstance);
					component.AlignTo(this.ProductAlignments[i]);
					if (component.Rb != null)
					{
						component.Rb.isKinematic = true;
					}
					this.ProductSlotModelID[i] = text;
					Object.Destroy(component);
				}
			}
		}

		// Token: 0x0600554B RID: 21835 RVA: 0x001672F7 File Offset: 0x001654F7
		public virtual void StartTask()
		{
			new PackageProductTask(this);
		}

		// Token: 0x0600554C RID: 21836 RVA: 0x00167300 File Offset: 0x00165500
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			this.RpcWriter___Server_SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
			this.RpcLogic___SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
		}

		// Token: 0x0600554D RID: 21837 RVA: 0x00167328 File Offset: 0x00165528
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

		// Token: 0x0600554E RID: 21838 RVA: 0x00167387 File Offset: 0x00165587
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Server_SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x001673A5 File Offset: 0x001655A5
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x001673C3 File Offset: 0x001655C3
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			this.RpcWriter___Server_SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			this.RpcLogic___SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06005551 RID: 21841 RVA: 0x001673FC File Offset: 0x001655FC
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

		// Token: 0x06005552 RID: 21842 RVA: 0x0016747C File Offset: 0x0016567C
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
			PackagingStationUIElement component = Object.Instantiate<PackagingStationUIElement>(this.WorldspaceUIPrefab, base.ParentProperty.WorldspaceUIContainer).GetComponent<PackagingStationUIElement>();
			component.Initialize(this);
			this.WorldspaceUI = component;
			return component;
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x0016750F File Offset: 0x0016570F
		public void DestroyWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				this.WorldspaceUI.Destroy();
			}
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x0016752A File Offset: 0x0016572A
		public override string GetSaveString()
		{
			return new PackagingStationData(base.GUID, base.ItemInstance, 0, base.OwnerGrid, this.OriginCoordinate, this.Rotation, new ItemSet(this.ItemSlots)).GetJson(true);
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x00167564 File Offset: 0x00165764
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

		// Token: 0x06005557 RID: 21847 RVA: 0x00167628 File Offset: 0x00165828
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.PackagingStationAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.PackagingStationAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField = new SyncVar<NetworkObject>(this, 2U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<CurrentPlayerConfigurer>k__BackingField);
			this.syncVar___<PlayerUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<PlayerUserObject>k__BackingField);
			this.syncVar___<NPCUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<NPCUserObject>k__BackingField);
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SetConfigurer_3323014238));
			base.RegisterServerRpc(9U, new ServerRpcDelegate(this.RpcReader___Server_SetPlayerUser_3323014238));
			base.RegisterServerRpc(10U, new ServerRpcDelegate(this.RpcReader___Server_SetNPCUser_3323014238));
			base.RegisterServerRpc(11U, new ServerRpcDelegate(this.RpcReader___Server_SetStoredInstance_2652194801));
			base.RegisterObserversRpc(12U, new ClientRpcDelegate(this.RpcReader___Observers_SetStoredInstance_Internal_2652194801));
			base.RegisterTargetRpc(13U, new ClientRpcDelegate(this.RpcReader___Target_SetStoredInstance_Internal_2652194801));
			base.RegisterServerRpc(14U, new ServerRpcDelegate(this.RpcReader___Server_SetItemSlotQuantity_1692629761));
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761));
			base.RegisterServerRpc(16U, new ServerRpcDelegate(this.RpcReader___Server_SetSlotLocked_3170825843));
			base.RegisterTargetRpc(17U, new ClientRpcDelegate(this.RpcReader___Target_SetSlotLocked_Internal_3170825843));
			base.RegisterObserversRpc(18U, new ClientRpcDelegate(this.RpcReader___Observers_SetSlotLocked_Internal_3170825843));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.ObjectScripts.PackagingStation));
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x001677DC File Offset: 0x001659DC
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.PackagingStationAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.PackagingStationAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetRegistered();
			this.syncVar___<PlayerUserObject>k__BackingField.SetRegistered();
			this.syncVar___<NPCUserObject>k__BackingField.SetRegistered();
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x00167816 File Offset: 0x00165A16
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x00167824 File Offset: 0x00165A24
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

		// Token: 0x0600555B RID: 21851 RVA: 0x001678CB File Offset: 0x00165ACB
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			this.CurrentPlayerConfigurer = player;
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x001678D4 File Offset: 0x00165AD4
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

		// Token: 0x0600555D RID: 21853 RVA: 0x00167914 File Offset: 0x00165B14
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

		// Token: 0x0600555E RID: 21854 RVA: 0x001679BC File Offset: 0x00165BBC
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			if (this.PlayerUserObject != null && this.PlayerUserObject.Owner.IsLocalClient && playerObject != null && !playerObject.Owner.IsLocalClient)
			{
				Singleton<GameInput>.Instance.ExitAll();
			}
			this.PlayerUserObject = playerObject;
			if (this.OverheadLight != null)
			{
				this.OverheadLight.gameObject.SetActive(this.PlayerUserObject != null);
			}
			if (this.OverheadLightMeshRend != null)
			{
				this.OverheadLightMeshRend.material = ((this.PlayerUserObject != null) ? this.LightMeshOnMat : this.LightMeshOffMat);
			}
			if (this.Switch != null)
			{
				this.Switch.SetIsOn(this.PlayerUserObject != null);
			}
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x00167A94 File Offset: 0x00165C94
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

		// Token: 0x06005560 RID: 21856 RVA: 0x00167AD4 File Offset: 0x00165CD4
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

		// Token: 0x06005561 RID: 21857 RVA: 0x00167B7B File Offset: 0x00165D7B
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			this.NPCUserObject = npcObject;
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x00167B84 File Offset: 0x00165D84
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

		// Token: 0x06005563 RID: 21859 RVA: 0x00167BC4 File Offset: 0x00165DC4
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
			base.SendServerRpc(11U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005564 RID: 21860 RVA: 0x00167C8A File Offset: 0x00165E8A
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetStoredInstance_Internal(null, itemSlotIndex, instance);
				return;
			}
			this.SetStoredInstance_Internal(conn, itemSlotIndex, instance);
		}

		// Token: 0x06005565 RID: 21861 RVA: 0x00167CB4 File Offset: 0x00165EB4
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

		// Token: 0x06005566 RID: 21862 RVA: 0x00167D1C File Offset: 0x00165F1C
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
			base.SendObserversRpc(12U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06005567 RID: 21863 RVA: 0x00167DE4 File Offset: 0x00165FE4
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (instance != null)
			{
				this.ItemSlots[itemSlotIndex].SetStoredItem(instance, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].ClearStoredInstance(true);
		}

		// Token: 0x06005568 RID: 21864 RVA: 0x00167E10 File Offset: 0x00166010
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

		// Token: 0x06005569 RID: 21865 RVA: 0x00167E64 File Offset: 0x00166064
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
			base.SendTargetRpc(13U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x00167F2C File Offset: 0x0016612C
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

		// Token: 0x0600556B RID: 21867 RVA: 0x00167F84 File Offset: 0x00166184
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
			base.SendServerRpc(14U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x00168042 File Offset: 0x00166242
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			this.SetItemSlotQuantity_Internal(itemSlotIndex, quantity);
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x0016804C File Offset: 0x0016624C
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

		// Token: 0x0600556E RID: 21870 RVA: 0x001680A8 File Offset: 0x001662A8
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
			base.SendObserversRpc(15U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x00168175 File Offset: 0x00166375
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			this.ItemSlots[itemSlotIndex].SetQuantity(quantity, true);
		}

		// Token: 0x06005570 RID: 21872 RVA: 0x0016818C File Offset: 0x0016638C
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

		// Token: 0x06005571 RID: 21873 RVA: 0x001681E4 File Offset: 0x001663E4
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
			base.SendServerRpc(16U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x001682C4 File Offset: 0x001664C4
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetSlotLocked_Internal(null, itemSlotIndex, locked, lockOwner, lockReason);
				return;
			}
			this.SetSlotLocked_Internal(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06005573 RID: 21875 RVA: 0x001682F4 File Offset: 0x001664F4
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

		// Token: 0x06005574 RID: 21876 RVA: 0x0016837C File Offset: 0x0016657C
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
			base.SendTargetRpc(17U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06005575 RID: 21877 RVA: 0x0016845D File Offset: 0x0016665D
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (locked)
			{
				this.ItemSlots[itemSlotIndex].ApplyLock(lockOwner, lockReason, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].RemoveLock(true);
		}

		// Token: 0x06005576 RID: 21878 RVA: 0x0016848C File Offset: 0x0016668C
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

		// Token: 0x06005577 RID: 21879 RVA: 0x00168508 File Offset: 0x00166708
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
			base.SendObserversRpc(18U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x001685EC File Offset: 0x001667EC
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

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06005579 RID: 21881 RVA: 0x00168660 File Offset: 0x00166860
		// (set) Token: 0x0600557A RID: 21882 RVA: 0x00168668 File Offset: 0x00166868
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

		// Token: 0x0600557B RID: 21883 RVA: 0x001686A4 File Offset: 0x001668A4
		public virtual bool PackagingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
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

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x0600557C RID: 21884 RVA: 0x0016877E File Offset: 0x0016697E
		// (set) Token: 0x0600557D RID: 21885 RVA: 0x00168786 File Offset: 0x00166986
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

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x0600557E RID: 21886 RVA: 0x001687C2 File Offset: 0x001669C2
		// (set) Token: 0x0600557F RID: 21887 RVA: 0x001687CA File Offset: 0x001669CA
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

		// Token: 0x06005580 RID: 21888 RVA: 0x00168808 File Offset: 0x00166A08
		protected virtual void dll()
		{
			base.Awake();
			this.OverheadLight.gameObject.SetActive(false);
			this.Switch.SetIsOn(false);
			if (!this.isGhost)
			{
				for (int i = 0; i < this.PackagingAlignments.Length; i++)
				{
					this.PackagingSlotModelID.Add(string.Empty);
				}
				for (int j = 0; j < this.ProductAlignments.Length; j++)
				{
					this.ProductSlotModelID.Add(string.Empty);
				}
				this.PackagingSlot.SetSlotOwner(this);
				this.ProductSlot.SetSlotOwner(this);
				this.OutputSlot.SetSlotOwner(this);
				ItemSlot packagingSlot = this.PackagingSlot;
				packagingSlot.onItemDataChanged = (Action)Delegate.Combine(packagingSlot.onItemDataChanged, new Action(this.UpdatePackagingVisuals));
				ItemSlot productSlot = this.ProductSlot;
				productSlot.onItemDataChanged = (Action)Delegate.Combine(productSlot.onItemDataChanged, new Action(this.UpdateProductVisuals));
				this.PackagingSlot.AddFilter(new ItemFilter_Category(new List<EItemCategory>
				{
					EItemCategory.Packaging
				}));
				this.ProductSlot.AddFilter(new ItemFilter_UnpackagedProduct());
				this.OutputSlot.AddFilter(new ItemFilter_PackagedProduct());
				this.InputSlots.Add(this.PackagingSlot);
				this.InputSlots.Add(this.ProductSlot);
				this.OutputSlots.Add(this.OutputSlot);
			}
		}

		// Token: 0x04003F1A RID: 16154
		[Header("References")]
		public Light OverheadLight;

		// Token: 0x04003F1B RID: 16155
		public MeshRenderer OverheadLightMeshRend;

		// Token: 0x04003F1C RID: 16156
		public RockerSwitch Switch;

		// Token: 0x04003F1D RID: 16157
		public Transform CameraPosition;

		// Token: 0x04003F1E RID: 16158
		public Transform CameraPosition_Task;

		// Token: 0x04003F1F RID: 16159
		public InteractableObject IntObj;

		// Token: 0x04003F20 RID: 16160
		public Transform ActivePackagingAlignent;

		// Token: 0x04003F21 RID: 16161
		public Transform[] ActiveProductAlignments;

		// Token: 0x04003F22 RID: 16162
		public Transform Container;

		// Token: 0x04003F23 RID: 16163
		public Collider OutputCollider;

		// Token: 0x04003F24 RID: 16164
		public Transform Hatch;

		// Token: 0x04003F25 RID: 16165
		public Transform[] PackagingAlignments;

		// Token: 0x04003F26 RID: 16166
		public Transform[] ProductAlignments;

		// Token: 0x04003F27 RID: 16167
		public Transform uiPoint;

		// Token: 0x04003F28 RID: 16168
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04003F29 RID: 16169
		public Transform StandPoint;

		// Token: 0x04003F2A RID: 16170
		public Transform[] accessPoints;

		// Token: 0x04003F2B RID: 16171
		public AudioSourceController HatchOpenSound;

		// Token: 0x04003F2C RID: 16172
		public AudioSourceController HatchCloseSound;

		// Token: 0x04003F2D RID: 16173
		[Header("UI")]
		public PackagingStationUIElement WorldspaceUIPrefab;

		// Token: 0x04003F2E RID: 16174
		public Sprite typeIcon;

		// Token: 0x04003F2F RID: 16175
		[Header("Slot Display Points")]
		public Transform PackagingSlotPosition;

		// Token: 0x04003F30 RID: 16176
		public Transform ProductSlotPosition;

		// Token: 0x04003F31 RID: 16177
		public Transform OutputSlotPosition;

		// Token: 0x04003F32 RID: 16178
		[Header("Materials")]
		public Material LightMeshOnMat;

		// Token: 0x04003F33 RID: 16179
		public Material LightMeshOffMat;

		// Token: 0x04003F34 RID: 16180
		[Header("Settings")]
		public float PackagerEmployeeSpeedMultiplier = 1f;

		// Token: 0x04003F35 RID: 16181
		public Vector3 HatchClosedRotation;

		// Token: 0x04003F36 RID: 16182
		public Vector3 HatchOpenRotation;

		// Token: 0x04003F37 RID: 16183
		public float HatchLerpTime = 0.5f;

		// Token: 0x04003F3A RID: 16186
		public ItemSlot PackagingSlot;

		// Token: 0x04003F3B RID: 16187
		public ItemSlot ProductSlot;

		// Token: 0x04003F3C RID: 16188
		public ItemSlot OutputSlot;

		// Token: 0x04003F3D RID: 16189
		private bool hatchOpen;

		// Token: 0x04003F3E RID: 16190
		private Coroutine hatchRoutine;

		// Token: 0x04003F3F RID: 16191
		private List<string> PackagingSlotModelID = new List<string>();

		// Token: 0x04003F40 RID: 16192
		private List<string> ProductSlotModelID = new List<string>();

		// Token: 0x04003F48 RID: 16200
		private bool visualsLocked;

		// Token: 0x04003F49 RID: 16201
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003F4A RID: 16202
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003F4B RID: 16203
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04003F4C RID: 16204
		private bool dll_Excuted;

		// Token: 0x04003F4D RID: 16205
		private bool dll_Excuted;

		// Token: 0x02000BE7 RID: 3047
		public enum EMode
		{
			// Token: 0x04003F4F RID: 16207
			Package,
			// Token: 0x04003F50 RID: 16208
			Unpackage
		}

		// Token: 0x02000BE8 RID: 3048
		public enum EState
		{
			// Token: 0x04003F52 RID: 16210
			CanBegin,
			// Token: 0x04003F53 RID: 16211
			MissingItems,
			// Token: 0x04003F54 RID: 16212
			InsufficentProduct,
			// Token: 0x04003F55 RID: 16213
			OutputSlotFull,
			// Token: 0x04003F56 RID: 16214
			Mismatch,
			// Token: 0x04003F57 RID: 16215
			PackageSlotFull,
			// Token: 0x04003F58 RID: 16216
			ProductSlotFull
		}
	}
}
