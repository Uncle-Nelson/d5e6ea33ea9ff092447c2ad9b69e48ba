using System;
using System.Collections;
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
using FishNet.Transporting;
using ScheduleOne.Audio;
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
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.Tools;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Management;
using ScheduleOne.UI.Stations;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BB5 RID: 2997
	public class BrickPress : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060050E0 RID: 20704 RVA: 0x00154C50 File Offset: 0x00152E50
		public bool isOpen
		{
			get
			{
				return this.PlayerUserObject == Player.Local.NetworkObject;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060050E1 RID: 20705 RVA: 0x00154C67 File Offset: 0x00152E67
		// (set) Token: 0x060050E2 RID: 20706 RVA: 0x00154C6F File Offset: 0x00152E6F
		public List<ItemSlot> ItemSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x060050E3 RID: 20707 RVA: 0x00154C78 File Offset: 0x00152E78
		// (set) Token: 0x060050E4 RID: 20708 RVA: 0x00154C80 File Offset: 0x00152E80
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

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x060050E5 RID: 20709 RVA: 0x00154C8A File Offset: 0x00152E8A
		// (set) Token: 0x060050E6 RID: 20710 RVA: 0x00154C92 File Offset: 0x00152E92
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

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x060050E7 RID: 20711 RVA: 0x00154C9C File Offset: 0x00152E9C
		// (set) Token: 0x060050E8 RID: 20712 RVA: 0x00154CA4 File Offset: 0x00152EA4
		public ItemSlot[] ProductSlots { get; private set; }

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x060050E9 RID: 20713 RVA: 0x00154CAD File Offset: 0x00152EAD
		// (set) Token: 0x060050EA RID: 20714 RVA: 0x00154CB5 File Offset: 0x00152EB5
		public ItemSlot OutputSlot { get; private set; }

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x060050EB RID: 20715 RVA: 0x00150487 File Offset: 0x0014E687
		public string Name
		{
			get
			{
				return base.ItemInstance.Name;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x060050EC RID: 20716 RVA: 0x00154CBE File Offset: 0x00152EBE
		// (set) Token: 0x060050ED RID: 20717 RVA: 0x00154CC6 File Offset: 0x00152EC6
		public List<ItemSlot> InputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x060050EE RID: 20718 RVA: 0x00154CCF File Offset: 0x00152ECF
		// (set) Token: 0x060050EF RID: 20719 RVA: 0x00154CD7 File Offset: 0x00152ED7
		public List<ItemSlot> OutputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x060050F0 RID: 20720 RVA: 0x00154CE0 File Offset: 0x00152EE0
		public Transform LinkOrigin
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x060050F1 RID: 20721 RVA: 0x00154CE8 File Offset: 0x00152EE8
		public Transform[] AccessPoints
		{
			get
			{
				return this.accessPoints;
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x060050F2 RID: 20722 RVA: 0x00154CF0 File Offset: 0x00152EF0
		public bool Selectable { get; } = 1;

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x060050F3 RID: 20723 RVA: 0x00154CF8 File Offset: 0x00152EF8
		// (set) Token: 0x060050F4 RID: 20724 RVA: 0x00154D00 File Offset: 0x00152F00
		public bool IsAcceptingItems { get; set; } = true;

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060050F5 RID: 20725 RVA: 0x00154D09 File Offset: 0x00152F09
		public EntityConfiguration Configuration
		{
			get
			{
				return this.stationConfiguration;
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060050F6 RID: 20726 RVA: 0x00154D11 File Offset: 0x00152F11
		// (set) Token: 0x060050F7 RID: 20727 RVA: 0x00154D19 File Offset: 0x00152F19
		protected BrickPressConfiguration stationConfiguration { get; set; }

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x060050F8 RID: 20728 RVA: 0x00154D22 File Offset: 0x00152F22
		public ConfigurationReplicator ConfigReplicator
		{
			get
			{
				return this.configReplicator;
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x060050F9 RID: 20729 RVA: 0x000111A2 File Offset: 0x0000F3A2
		public EConfigurableType ConfigurableType
		{
			get
			{
				return EConfigurableType.BrickPress;
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x060050FA RID: 20730 RVA: 0x00154D2A File Offset: 0x00152F2A
		// (set) Token: 0x060050FB RID: 20731 RVA: 0x00154D32 File Offset: 0x00152F32
		public WorldspaceUIElement WorldspaceUI { get; set; }

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060050FC RID: 20732 RVA: 0x00154D3B File Offset: 0x00152F3B
		// (set) Token: 0x060050FD RID: 20733 RVA: 0x00154D43 File Offset: 0x00152F43
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

		// Token: 0x060050FE RID: 20734 RVA: 0x00154D4D File Offset: 0x00152F4D
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
			this.RpcWriter___Server_SetConfigurer_3323014238(player);
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060050FF RID: 20735 RVA: 0x00154D63 File Offset: 0x00152F63
		public Sprite TypeIcon
		{
			get
			{
				return this.typeIcon;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06005100 RID: 20736 RVA: 0x000AEDCB File Offset: 0x000ACFCB
		public Transform Transform
		{
			get
			{
				return base.transform;
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06005101 RID: 20737 RVA: 0x00154CE0 File Offset: 0x00152EE0
		public Transform UIPoint
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06005102 RID: 20738 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CanBeSelected
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06005103 RID: 20739 RVA: 0x00154D6C File Offset: 0x00152F6C
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ObjectScripts.BrickPress_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x00154D8C File Offset: 0x00152F8C
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
				this.stationConfiguration = new BrickPressConfiguration(this.configReplicator, this, this);
				this.CreateWorldspaceUI();
				GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 4);
			}
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x00154DEF File Offset: 0x00152FEF
		protected virtual void LateUpdate()
		{
			this.PressTransform.localPosition = Vector3.Lerp(this.PressTransform_Raised.localPosition, this.PressTransform_Lowered.localPosition, this.Handle.CurrentPosition);
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x00154E22 File Offset: 0x00153022
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			((IItemSlotOwner)this).SendItemsToClient(connection);
			this.SendConfigurationToClient(connection);
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x00154E3C File Offset: 0x0015303C
		public void SendConfigurationToClient(NetworkConnection conn)
		{
			BrickPress.<>c__DisplayClass98_0 CS$<>8__locals1 = new BrickPress.<>c__DisplayClass98_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.conn = conn;
			if (CS$<>8__locals1.conn.IsHost)
			{
				return;
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SendConfigurationToClient>g__WaitForConfig|0());
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x00154E7C File Offset: 0x0015307C
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

		// Token: 0x06005109 RID: 20745 RVA: 0x00154EA7 File Offset: 0x001530A7
		public override bool CanBeDestroyed(out string reason)
		{
			if (((IUsable)this).IsInUse)
			{
				reason = "In use";
				return false;
			}
			if (((IItemSlotOwner)this).GetTotalItemCount() > 0)
			{
				reason = "Contains items";
				return false;
			}
			return base.CanBeDestroyed(out reason);
		}

		// Token: 0x0600510A RID: 20746 RVA: 0x00154ED3 File Offset: 0x001530D3
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

		// Token: 0x0600510B RID: 20747 RVA: 0x00154F12 File Offset: 0x00153112
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
			this.RpcWriter___Server_SetPlayerUser_3323014238(playerObject);
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x00154F28 File Offset: 0x00153128
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
			this.RpcWriter___Server_SetNPCUser_3323014238(npcObject);
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x00154F40 File Offset: 0x00153140
		public PackagingStation.EState GetState()
		{
			ProductItemInstance productItemInstance;
			if (!this.HasSufficientProduct(out productItemInstance))
			{
				return PackagingStation.EState.InsufficentProduct;
			}
			if (this.OutputSlot.ItemInstance != null)
			{
				if ((this.OutputSlot.ItemInstance as QualityItemInstance).Quality != productItemInstance.Quality)
				{
					return PackagingStation.EState.Mismatch;
				}
				if (this.OutputSlot.ItemInstance.ID != productItemInstance.ID)
				{
					return PackagingStation.EState.Mismatch;
				}
				if (this.OutputSlot.ItemInstance.ID != productItemInstance.ID)
				{
					return PackagingStation.EState.Mismatch;
				}
				if (this.OutputSlot.ItemInstance.Quantity >= this.OutputSlot.ItemInstance.StackLimit)
				{
					return PackagingStation.EState.OutputSlotFull;
				}
			}
			return PackagingStation.EState.CanBegin;
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x00154FEC File Offset: 0x001531EC
		private void UpdateInputVisuals()
		{
			ItemInstance itemInstance;
			int num;
			ItemInstance itemInstance2;
			int num2;
			this.GetMainInputs(out itemInstance, out num, out itemInstance2, out num2);
			if (itemInstance != null)
			{
				this.Container1.SetContents(itemInstance as ProductItemInstance, (float)num / 20f);
			}
			else
			{
				this.Container1.SetContents(null, 0f);
			}
			if (itemInstance2 != null)
			{
				this.Container2.SetContents(itemInstance2 as ProductItemInstance, (float)num2 / 20f);
				return;
			}
			this.Container2.SetContents(null, 0f);
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x00155064 File Offset: 0x00153264
		public bool HasSufficientProduct(out ProductItemInstance product)
		{
			ItemInstance itemInstance;
			int num;
			ItemInstance itemInstance2;
			int num2;
			this.GetMainInputs(out itemInstance, out num, out itemInstance2, out num2);
			if (itemInstance == null)
			{
				product = null;
				return false;
			}
			product = (itemInstance as ProductItemInstance);
			return num >= 20;
		}

		// Token: 0x06005110 RID: 20752 RVA: 0x00155098 File Offset: 0x00153298
		public void GetMainInputs(out ItemInstance primaryItem, out int primaryItemQuantity, out ItemInstance secondaryItem, out int secondaryItemQuantity)
		{
			BrickPress.<>c__DisplayClass107_0 CS$<>8__locals1 = new BrickPress.<>c__DisplayClass107_0();
			CS$<>8__locals1.<>4__this = this;
			List<ItemInstance> list = new List<ItemInstance>();
			CS$<>8__locals1.itemQuantities = new Dictionary<ItemInstance, int>();
			int i;
			int k;
			for (i = 0; i < this.InputSlots.Count; i = k + 1)
			{
				if (this.InputSlots[i].ItemInstance != null)
				{
					ItemInstance itemInstance = list.Find((ItemInstance x) => x.ID == CS$<>8__locals1.<>4__this.InputSlots[i].ItemInstance.ID);
					if (itemInstance == null || !itemInstance.CanStackWith(this.InputSlots[i].ItemInstance, false))
					{
						itemInstance = this.InputSlots[i].ItemInstance;
						list.Add(itemInstance);
						if (!CS$<>8__locals1.itemQuantities.ContainsKey(this.InputSlots[i].ItemInstance))
						{
							CS$<>8__locals1.itemQuantities.Add(this.InputSlots[i].ItemInstance, 0);
						}
					}
					Dictionary<ItemInstance, int> itemQuantities = CS$<>8__locals1.itemQuantities;
					ItemInstance key = itemInstance;
					itemQuantities[key] += this.InputSlots[i].Quantity;
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

		// Token: 0x06005111 RID: 20753 RVA: 0x001552F0 File Offset: 0x001534F0
		public Draggable CreateFunctionalContainer(ProductItemInstance instance, float productScale, out List<FunctionalProduct> products)
		{
			Draggable draggable = Object.Instantiate<Draggable>(this.FunctionalContainerPrefab, NetworkSingleton<GameManager>.Instance.Temp);
			draggable.transform.position = this.ContainerSpawnPoint.position;
			draggable.transform.rotation = this.ContainerSpawnPoint.rotation;
			draggable.GetComponent<DraggableConstraint>().SetContainer(base.transform);
			Transform transform = draggable.transform.Find("ProductSpawnPoints");
			ProductDefinition productDefinition = instance.Definition as ProductDefinition;
			products = new List<FunctionalProduct>();
			for (int i = 0; i < 20; i++)
			{
				Transform child = transform.GetChild(i);
				FunctionalProduct functionalProduct = Object.Instantiate<FunctionalProduct>(productDefinition.FunctionalProduct, NetworkSingleton<GameManager>.Instance.Temp);
				functionalProduct.transform.position = child.position;
				functionalProduct.transform.rotation = child.rotation;
				functionalProduct.transform.localScale = Vector3.one * productScale;
				functionalProduct.Initialize(instance);
				products.Add(functionalProduct);
			}
			return draggable;
		}

		// Token: 0x06005112 RID: 20754 RVA: 0x001553F0 File Offset: 0x001535F0
		public void PlayPressAnim()
		{
			base.StartCoroutine(this.<PlayPressAnim>g__Routine|109_0());
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x00155400 File Offset: 0x00153600
		public void CompletePress(ProductItemInstance product)
		{
			ProductItemInstance productItemInstance = product.GetCopy(1) as ProductItemInstance;
			productItemInstance.SetPackaging(this.BrickPackaging);
			this.OutputSlot.AddItem(productItemInstance, false);
			int num = 20;
			int num2 = 0;
			while (num2 < this.InputSlots.Count && num > 0)
			{
				if (this.InputSlots[num2].ItemInstance != null && this.InputSlots[num2].ItemInstance.CanStackWith(product, false))
				{
					int num3 = Mathf.Min(num, this.InputSlots[num2].Quantity);
					this.InputSlots[num2].ChangeQuantity(-num3, false);
					num -= num3;
				}
				num2++;
			}
		}

		// Token: 0x06005114 RID: 20756 RVA: 0x001554B0 File Offset: 0x001536B0
		public List<FunctionalProduct> GetProductInMould()
		{
			Collider[] array = Physics.OverlapBox(this.MouldDetection.bounds.center, this.MouldDetection.bounds.extents, this.MouldDetection.transform.rotation, LayerMask.GetMask(new string[]
			{
				"Task"
			}));
			List<FunctionalProduct> list = new List<FunctionalProduct>();
			for (int i = 0; i < array.Length; i++)
			{
				FunctionalProduct componentInParent = array[i].GetComponentInParent<FunctionalProduct>();
				if (componentInParent != null && !list.Contains(componentInParent))
				{
					list.Add(componentInParent);
				}
			}
			return list;
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x00155548 File Offset: 0x00153748
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
			BrickPressUIElement component = Object.Instantiate<BrickPressUIElement>(this.WorldspaceUIPrefab, base.ParentProperty.WorldspaceUIContainer).GetComponent<BrickPressUIElement>();
			component.Initialize(this);
			this.WorldspaceUI = component;
			return component;
		}

		// Token: 0x06005116 RID: 20758 RVA: 0x001555DB File Offset: 0x001537DB
		public void DestroyWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				this.WorldspaceUI.Destroy();
			}
		}

		// Token: 0x06005117 RID: 20759 RVA: 0x001555F8 File Offset: 0x001537F8
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

		// Token: 0x06005118 RID: 20760 RVA: 0x00155652 File Offset: 0x00153852
		public void Interacted()
		{
			if (((IUsable)this).IsInUse || Singleton<ManagementClipboard>.Instance.IsEquipped)
			{
				return;
			}
			this.Open();
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x00155670 File Offset: 0x00153870
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
			Singleton<BrickPressCanvas>.Instance.SetIsOpen(this, true, true);
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x00155710 File Offset: 0x00153910
		public void Close()
		{
			Singleton<BrickPressCanvas>.Instance.SetIsOpen(null, false, true);
			this.SetPlayerUser(null);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.2f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.2f);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			Singleton<CompassManager>.Instance.SetVisible(true);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x0015578C File Offset: 0x0015398C
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			this.RpcWriter___Server_SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
			this.RpcLogic___SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x001557B4 File Offset: 0x001539B4
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

		// Token: 0x0600511D RID: 20765 RVA: 0x00155813 File Offset: 0x00153A13
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Server_SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x00155831 File Offset: 0x00153A31
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x0600511F RID: 20767 RVA: 0x0015584F File Offset: 0x00153A4F
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			this.RpcWriter___Server_SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			this.RpcLogic___SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06005120 RID: 20768 RVA: 0x00155888 File Offset: 0x00153A88
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

		// Token: 0x06005121 RID: 20769 RVA: 0x00155907 File Offset: 0x00153B07
		public override string GetSaveString()
		{
			return new BrickPressData(base.GUID, base.ItemInstance, 0, base.OwnerGrid, this.OriginCoordinate, this.Rotation, new ItemSet(this.ItemSlots)).GetJson(true);
		}

		// Token: 0x06005122 RID: 20770 RVA: 0x00155940 File Offset: 0x00153B40
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

		// Token: 0x06005124 RID: 20772 RVA: 0x001559C8 File Offset: 0x00153BC8
		[CompilerGenerated]
		private IEnumerator <PlayPressAnim>g__Routine|109_0()
		{
			this.Handle.Locked = true;
			this.Handle.SetPosition(1f);
			yield return new WaitForSeconds(0.5f);
			this.SlamSound.Play();
			yield return new WaitForSeconds(0.5f);
			this.Handle.Locked = false;
			yield break;
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x001559D8 File Offset: 0x00153BD8
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.BrickPressAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.BrickPressAssembly-CSharp.dll_Excuted = true;
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
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.ObjectScripts.BrickPress));
		}

		// Token: 0x06005126 RID: 20774 RVA: 0x00155B8C File Offset: 0x00153D8C
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.BrickPressAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.BrickPressAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetRegistered();
			this.syncVar___<PlayerUserObject>k__BackingField.SetRegistered();
			this.syncVar___<NPCUserObject>k__BackingField.SetRegistered();
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x00155BC6 File Offset: 0x00153DC6
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x00155BD4 File Offset: 0x00153DD4
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

		// Token: 0x06005129 RID: 20777 RVA: 0x00155C7B File Offset: 0x00153E7B
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			this.CurrentPlayerConfigurer = player;
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x00155C84 File Offset: 0x00153E84
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

		// Token: 0x0600512B RID: 20779 RVA: 0x00155CC4 File Offset: 0x00153EC4
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

		// Token: 0x0600512C RID: 20780 RVA: 0x00155D6B File Offset: 0x00153F6B
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			this.PlayerUserObject = playerObject;
		}

		// Token: 0x0600512D RID: 20781 RVA: 0x00155D74 File Offset: 0x00153F74
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

		// Token: 0x0600512E RID: 20782 RVA: 0x00155DB4 File Offset: 0x00153FB4
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

		// Token: 0x0600512F RID: 20783 RVA: 0x00155E5B File Offset: 0x0015405B
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			this.NPCUserObject = npcObject;
		}

		// Token: 0x06005130 RID: 20784 RVA: 0x00155E64 File Offset: 0x00154064
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

		// Token: 0x06005131 RID: 20785 RVA: 0x00155EA4 File Offset: 0x001540A4
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

		// Token: 0x06005132 RID: 20786 RVA: 0x00155F6A File Offset: 0x0015416A
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetStoredInstance_Internal(null, itemSlotIndex, instance);
				return;
			}
			this.SetStoredInstance_Internal(conn, itemSlotIndex, instance);
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x00155F94 File Offset: 0x00154194
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

		// Token: 0x06005134 RID: 20788 RVA: 0x00155FFC File Offset: 0x001541FC
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

		// Token: 0x06005135 RID: 20789 RVA: 0x001560C4 File Offset: 0x001542C4
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (instance != null)
			{
				this.ItemSlots[itemSlotIndex].SetStoredItem(instance, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].ClearStoredInstance(true);
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x001560F0 File Offset: 0x001542F0
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

		// Token: 0x06005137 RID: 20791 RVA: 0x00156144 File Offset: 0x00154344
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

		// Token: 0x06005138 RID: 20792 RVA: 0x0015620C File Offset: 0x0015440C
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

		// Token: 0x06005139 RID: 20793 RVA: 0x00156264 File Offset: 0x00154464
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

		// Token: 0x0600513A RID: 20794 RVA: 0x00156322 File Offset: 0x00154522
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			this.SetItemSlotQuantity_Internal(itemSlotIndex, quantity);
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x0015632C File Offset: 0x0015452C
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

		// Token: 0x0600513C RID: 20796 RVA: 0x00156388 File Offset: 0x00154588
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

		// Token: 0x0600513D RID: 20797 RVA: 0x00156455 File Offset: 0x00154655
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			this.ItemSlots[itemSlotIndex].SetQuantity(quantity, true);
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x0015646C File Offset: 0x0015466C
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

		// Token: 0x0600513F RID: 20799 RVA: 0x001564C4 File Offset: 0x001546C4
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

		// Token: 0x06005140 RID: 20800 RVA: 0x001565A4 File Offset: 0x001547A4
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetSlotLocked_Internal(null, itemSlotIndex, locked, lockOwner, lockReason);
				return;
			}
			this.SetSlotLocked_Internal(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x001565D4 File Offset: 0x001547D4
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

		// Token: 0x06005142 RID: 20802 RVA: 0x0015665C File Offset: 0x0015485C
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

		// Token: 0x06005143 RID: 20803 RVA: 0x0015673D File Offset: 0x0015493D
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (locked)
			{
				this.ItemSlots[itemSlotIndex].ApplyLock(lockOwner, lockReason, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].RemoveLock(true);
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x0015676C File Offset: 0x0015496C
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

		// Token: 0x06005145 RID: 20805 RVA: 0x001567E8 File Offset: 0x001549E8
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

		// Token: 0x06005146 RID: 20806 RVA: 0x001568CC File Offset: 0x00154ACC
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

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06005147 RID: 20807 RVA: 0x00156940 File Offset: 0x00154B40
		// (set) Token: 0x06005148 RID: 20808 RVA: 0x00156948 File Offset: 0x00154B48
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

		// Token: 0x06005149 RID: 20809 RVA: 0x00156984 File Offset: 0x00154B84
		public virtual bool BrickPress(PooledReader PooledReader0, uint UInt321, bool Boolean2)
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

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x0600514A RID: 20810 RVA: 0x00156A5E File Offset: 0x00154C5E
		// (set) Token: 0x0600514B RID: 20811 RVA: 0x00156A66 File Offset: 0x00154C66
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

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x0600514C RID: 20812 RVA: 0x00156AA2 File Offset: 0x00154CA2
		// (set) Token: 0x0600514D RID: 20813 RVA: 0x00156AAA File Offset: 0x00154CAA
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

		// Token: 0x0600514E RID: 20814 RVA: 0x00156AE8 File Offset: 0x00154CE8
		protected virtual void dll()
		{
			base.Awake();
			if (!this.isGhost)
			{
				this.ProductSlots = new ItemSlot[2];
				for (int i = 0; i < 2; i++)
				{
					this.ProductSlots[i] = new ItemSlot();
					this.ProductSlots[i].SetSlotOwner(this);
					this.ProductSlots[i].AddFilter(new ItemFilter_UnpackagedProduct());
					ItemSlot itemSlot = this.ProductSlots[i];
					itemSlot.onItemDataChanged = (Action)Delegate.Combine(itemSlot.onItemDataChanged, new Action(this.UpdateInputVisuals));
				}
				this.OutputSlot = new ItemSlot();
				this.OutputSlot.SetSlotOwner(this);
				this.OutputSlot.SetIsAddLocked(true);
				this.OutputVisuals.AddSlot(this.OutputSlot, false);
				this.InputSlots.AddRange(this.ProductSlots);
				this.OutputSlots.Add(this.OutputSlot);
			}
		}

		// Token: 0x04003CD6 RID: 15574
		public const int INPUT_SLOT_COUNT = 2;

		// Token: 0x04003CDA RID: 15578
		[Header("References")]
		public Transform CameraPosition;

		// Token: 0x04003CDB RID: 15579
		public Transform CameraPosition_Pouring;

		// Token: 0x04003CDC RID: 15580
		public Transform CameraPosition_Raising;

		// Token: 0x04003CDD RID: 15581
		public InteractableObject IntObj;

		// Token: 0x04003CDE RID: 15582
		public Transform uiPoint;

		// Token: 0x04003CDF RID: 15583
		public Transform StandPoint;

		// Token: 0x04003CE0 RID: 15584
		public Transform[] accessPoints;

		// Token: 0x04003CE1 RID: 15585
		public StorageVisualizer OutputVisuals;

		// Token: 0x04003CE2 RID: 15586
		public BrickPressContainer Container1;

		// Token: 0x04003CE3 RID: 15587
		public BrickPressContainer Container2;

		// Token: 0x04003CE4 RID: 15588
		public Transform ContainerSpawnPoint;

		// Token: 0x04003CE5 RID: 15589
		public PackagingDefinition BrickPackaging;

		// Token: 0x04003CE6 RID: 15590
		public BoxCollider MouldDetection;

		// Token: 0x04003CE7 RID: 15591
		public BrickPressHandle Handle;

		// Token: 0x04003CE8 RID: 15592
		public Transform PressTransform;

		// Token: 0x04003CE9 RID: 15593
		public Transform PressTransform_Raised;

		// Token: 0x04003CEA RID: 15594
		public Transform PressTransform_Lowered;

		// Token: 0x04003CEB RID: 15595
		public Transform PressTransform_Compressed;

		// Token: 0x04003CEC RID: 15596
		public AudioSourceController SlamSound;

		// Token: 0x04003CED RID: 15597
		public ConfigurationReplicator configReplicator;

		// Token: 0x04003CEE RID: 15598
		[Header("Prefabs")]
		public Draggable FunctionalContainerPrefab;

		// Token: 0x04003CEF RID: 15599
		[Header("UI")]
		public BrickPressUIElement WorldspaceUIPrefab;

		// Token: 0x04003CF0 RID: 15600
		public Sprite typeIcon;

		// Token: 0x04003CFA RID: 15610
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003CFB RID: 15611
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003CFC RID: 15612
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04003CFD RID: 15613
		private bool dll_Excuted;

		// Token: 0x04003CFE RID: 15614
		private bool dll_Excuted;
	}
}
