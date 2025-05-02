using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x020004FC RID: 1276
	public class MoveItemBehaviour : Behaviour
	{
		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x00079AF5 File Offset: 0x00077CF5
		// (set) Token: 0x06001D8A RID: 7562 RVA: 0x00079AFD File Offset: 0x00077CFD
		public bool Initialized { get; protected set; }

		// Token: 0x06001D8B RID: 7563 RVA: 0x00079B08 File Offset: 0x00077D08
		public void Initialize(TransitRoute route, ItemInstance _itemToRetrieveTemplate, int _maxMoveAmount = -1, bool _skipPickup = false)
		{
			string str;
			if (!this.IsTransitRouteValid(route, _itemToRetrieveTemplate, out str))
			{
				Console.LogError("Invalid transit route for move item behaviour! Reason: " + str, null);
				return;
			}
			this.assignedRoute = route;
			this.itemToRetrieveTemplate = _itemToRetrieveTemplate;
			this.maxMoveAmount = _maxMoveAmount;
			if (base.Npc.behaviour.DEBUG_MODE)
			{
				Console.Log(string.Concat(new string[]
				{
					"MoveItemBehaviour initialized with route: ",
					route.Source.Name,
					" -> ",
					route.Destination.Name,
					" for item: ",
					_itemToRetrieveTemplate.ID
				}), null);
			}
			this.skipPickup = _skipPickup;
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x00079BB0 File Offset: 0x00077DB0
		public void Resume(TransitRoute route, ItemInstance _itemToRetrieveTemplate, int _maxMoveAmount = -1)
		{
			this.assignedRoute = route;
			this.itemToRetrieveTemplate = _itemToRetrieveTemplate;
			this.maxMoveAmount = _maxMoveAmount;
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x00079BC7 File Offset: 0x00077DC7
		protected override void Begin()
		{
			base.Begin();
			this.StartTransit();
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00079BD5 File Offset: 0x00077DD5
		protected override void Pause()
		{
			base.Pause();
			this.StopCurrentActivity();
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00079BE3 File Offset: 0x00077DE3
		protected override void Resume()
		{
			base.Resume();
			this.StartTransit();
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00079BF1 File Offset: 0x00077DF1
		protected override void End()
		{
			base.End();
			this.skipPickup = false;
			this.EndTransit();
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00077BBF File Offset: 0x00075DBF
		public override void Disable()
		{
			base.Disable();
			if (base.Active)
			{
				this.End();
			}
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x00079C08 File Offset: 0x00077E08
		private void StartTransit()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (base.Npc.Inventory.GetIdenticalItemAmount(this.itemToRetrieveTemplate) == 0)
			{
				string text;
				if (!this.IsTransitRouteValid(this.assignedRoute, this.itemToRetrieveTemplate, out text))
				{
					Console.LogWarning("Invalid transit route for move item behaviour!", null);
					base.Disable_Networked(null);
					return;
				}
			}
			else
			{
				ItemInstance firstIdenticalItem = base.Npc.Inventory.GetFirstIdenticalItem(this.itemToRetrieveTemplate, new NPCInventory.ItemFilter(this.IsNpcInventoryItemValid));
				if (base.Npc.behaviour.DEBUG_MODE)
				{
					string str = "Moving item: ";
					ItemInstance itemInstance = firstIdenticalItem;
					Console.Log(str + ((itemInstance != null) ? itemInstance.ToString() : null), null);
				}
				if (!this.IsDestinationValid(this.assignedRoute, firstIdenticalItem))
				{
					Console.LogWarning("Invalid transit route for move item behaviour!", null);
					base.Disable_Networked(null);
					return;
				}
			}
			this.currentState = MoveItemBehaviour.EState.Idle;
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00079CDC File Offset: 0x00077EDC
		private bool IsNpcInventoryItemValid(ItemInstance item)
		{
			return this.assignedRoute.Destination.GetInputCapacityForItem(item, base.Npc) != 0;
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00079CFC File Offset: 0x00077EFC
		private void EndTransit()
		{
			this.StopCurrentActivity();
			if (this.assignedRoute != null && base.Npc != null && this.assignedRoute.Destination != null)
			{
				this.assignedRoute.Destination.RemoveSlotLocks(base.Npc.NetworkObject);
			}
			this.Initialized = false;
			this.assignedRoute = null;
			this.itemToRetrieveTemplate = null;
			this.grabbedAmount = 0;
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x00079D6C File Offset: 0x00077F6C
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.assignedRoute.AreEntitiesNonNull())
			{
				Console.LogWarning("Transit route entities are null!", null);
				base.Disable_Networked(null);
				return;
			}
			if (base.beh.DEBUG_MODE)
			{
				Console.Log("State: " + this.currentState.ToString(), null);
				Console.Log("Moving: " + base.Npc.Movement.IsMoving.ToString(), null);
			}
			if (this.currentState == MoveItemBehaviour.EState.Idle)
			{
				if (base.Npc.Inventory.GetIdenticalItemAmount(this.itemToRetrieveTemplate) > 0 && this.grabbedAmount > 0)
				{
					if (this.IsAtDestination())
					{
						this.PlaceItem();
						return;
					}
					this.WalkToDestination();
					return;
				}
				else
				{
					if (this.skipPickup)
					{
						this.TakeItem();
						this.skipPickup = false;
						return;
					}
					if (this.IsAtSource())
					{
						this.GrabItem();
						return;
					}
					this.WalkToSource();
				}
			}
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00079E68 File Offset: 0x00078068
		public void WalkToSource()
		{
			if (base.beh.DEBUG_MODE)
			{
				Console.Log("MoveItemBehaviour.WalkToSource", null);
			}
			if (!base.Npc.Movement.CanGetTo(this.GetSourceAccessPoint(this.assignedRoute).position, 1f))
			{
				Console.LogWarning("MoveItemBehaviour.WalkToSource: Can't get to source", null);
				base.Disable_Networked(null);
				return;
			}
			this.currentState = MoveItemBehaviour.EState.WalkingToSource;
			this.walkToSourceRoutine = base.StartCoroutine(this.<WalkToSource>g__Routine|26_0());
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00079EE1 File Offset: 0x000780E1
		public void GrabItem()
		{
			if (base.beh.DEBUG_MODE)
			{
				Console.Log("MoveItemBehaviour.GrabItem", null);
			}
			this.currentState = MoveItemBehaviour.EState.Grabbing;
			this.grabRoutine = base.StartCoroutine(this.<GrabItem>g__Routine|27_0());
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x00079F14 File Offset: 0x00078114
		private void TakeItem()
		{
			if (base.beh.DEBUG_MODE)
			{
				Console.Log("MoveItemBehaviour.TakeItem", null);
			}
			int amountToGrab = this.GetAmountToGrab();
			if (amountToGrab == 0)
			{
				Console.LogWarning("Amount to grab is 0!", null);
				return;
			}
			ItemSlot firstSlotContainingTemplateItem = this.assignedRoute.Source.GetFirstSlotContainingTemplateItem(this.itemToRetrieveTemplate, ITransitEntity.ESlotType.Output);
			ItemInstance copy = ((firstSlotContainingTemplateItem != null) ? firstSlotContainingTemplateItem.ItemInstance : null).GetCopy(amountToGrab);
			this.grabbedAmount = amountToGrab;
			firstSlotContainingTemplateItem.ChangeQuantity(-amountToGrab, false);
			base.Npc.Inventory.InsertItem(copy, true);
			this.assignedRoute.Destination.ReserveInputSlotsForItem(copy, base.Npc.NetworkObject);
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00079FB8 File Offset: 0x000781B8
		public void WalkToDestination()
		{
			if (base.beh.DEBUG_MODE)
			{
				Console.Log("MoveItemBehaviour.WalkToDestination", null);
			}
			if (!base.Npc.Movement.CanGetTo(this.GetDestinationAccessPoint(this.assignedRoute).position, 1f))
			{
				Console.LogWarning("MoveItemBehaviour.WalkToDestination: Can't get to destination", null);
				base.Disable_Networked(null);
				return;
			}
			this.currentState = MoveItemBehaviour.EState.WalkingToDestination;
			this.walkToDestinationRoutine = base.StartCoroutine(this.<WalkToDestination>g__Routine|29_0());
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x0007A031 File Offset: 0x00078231
		public void PlaceItem()
		{
			if (base.beh.DEBUG_MODE)
			{
				Console.Log("MoveItemBehaviour.PlaceItem", null);
			}
			this.currentState = MoveItemBehaviour.EState.Placing;
			this.placingRoutine = base.StartCoroutine(this.<PlaceItem>g__Routine|30_0());
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x0007A064 File Offset: 0x00078264
		private int GetAmountToGrab()
		{
			ItemSlot firstSlotContainingTemplateItem = this.assignedRoute.Source.GetFirstSlotContainingTemplateItem(this.itemToRetrieveTemplate, ITransitEntity.ESlotType.Output);
			ItemInstance itemInstance = (firstSlotContainingTemplateItem != null) ? firstSlotContainingTemplateItem.ItemInstance : null;
			if (itemInstance == null)
			{
				return 0;
			}
			int num = itemInstance.Quantity;
			if (this.maxMoveAmount > 0)
			{
				num = Mathf.Min(this.maxMoveAmount, num);
			}
			int inputCapacityForItem = this.assignedRoute.Destination.GetInputCapacityForItem(itemInstance, base.Npc);
			return Mathf.Min(num, inputCapacityForItem);
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x0007A0D8 File Offset: 0x000782D8
		private void StopCurrentActivity()
		{
			switch (this.currentState)
			{
			case MoveItemBehaviour.EState.WalkingToSource:
				if (this.walkToSourceRoutine != null)
				{
					base.StopCoroutine(this.walkToSourceRoutine);
				}
				break;
			case MoveItemBehaviour.EState.Grabbing:
				if (this.grabRoutine != null)
				{
					base.StopCoroutine(this.grabRoutine);
				}
				break;
			case MoveItemBehaviour.EState.WalkingToDestination:
				if (this.walkToDestinationRoutine != null)
				{
					base.StopCoroutine(this.walkToDestinationRoutine);
				}
				break;
			case MoveItemBehaviour.EState.Placing:
				if (this.placingRoutine != null)
				{
					base.StopCoroutine(this.placingRoutine);
				}
				break;
			}
			this.currentState = MoveItemBehaviour.EState.Idle;
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x0007A168 File Offset: 0x00078368
		public bool IsTransitRouteValid(TransitRoute route, string itemID, out string invalidReason)
		{
			invalidReason = string.Empty;
			if (route == null)
			{
				invalidReason = "Route is null!";
				return false;
			}
			if (!route.AreEntitiesNonNull())
			{
				invalidReason = "Entities are null!";
				return false;
			}
			ItemSlot firstSlotContainingItem = route.Source.GetFirstSlotContainingItem(itemID, ITransitEntity.ESlotType.Output);
			ItemInstance itemInstance = (firstSlotContainingItem != null) ? firstSlotContainingItem.ItemInstance : null;
			if (itemInstance == null || itemInstance.Quantity <= 0)
			{
				invalidReason = "Item is null or quantity is 0!";
				return false;
			}
			if (!this.IsDestinationValid(route, itemInstance))
			{
				invalidReason = "Can't access source, destination or destination is full!";
				return false;
			}
			return true;
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x0007A1DC File Offset: 0x000783DC
		public bool IsTransitRouteValid(TransitRoute route, ItemInstance templateItem, out string invalidReason)
		{
			invalidReason = string.Empty;
			if (route == null)
			{
				invalidReason = "Route is null!";
				return false;
			}
			if (!route.AreEntitiesNonNull())
			{
				invalidReason = "Entities are null!";
				return false;
			}
			ItemSlot firstSlotContainingTemplateItem = route.Source.GetFirstSlotContainingTemplateItem(templateItem, ITransitEntity.ESlotType.Output);
			ItemInstance itemInstance = (firstSlotContainingTemplateItem != null) ? firstSlotContainingTemplateItem.ItemInstance : null;
			if (itemInstance == null || itemInstance.Quantity <= 0)
			{
				invalidReason = "Item is null or quantity is 0!";
				return false;
			}
			if (!this.IsDestinationValid(route, itemInstance))
			{
				invalidReason = "Can't access source, destination or destination is full!";
				return false;
			}
			return true;
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x0007A250 File Offset: 0x00078450
		public bool IsTransitRouteValid(TransitRoute route, string itemID)
		{
			string text;
			return this.IsTransitRouteValid(route, itemID, out text);
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x0007A268 File Offset: 0x00078468
		public bool IsDestinationValid(TransitRoute route, ItemInstance item)
		{
			if (route.Destination.GetInputCapacityForItem(item, base.Npc) == 0)
			{
				Console.LogWarning("Destination has no capacity for item!", null);
				return false;
			}
			if (!this.CanGetToDestination(route))
			{
				Console.LogWarning("Cannot get to destination!", null);
				return false;
			}
			if (!this.CanGetToSource(route))
			{
				Console.LogWarning("Cannot get to source!", null);
				return false;
			}
			return true;
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x0007A2C3 File Offset: 0x000784C3
		public bool CanGetToSource(TransitRoute route)
		{
			return this.GetSourceAccessPoint(route) != null;
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x0007A2D2 File Offset: 0x000784D2
		private Transform GetSourceAccessPoint(TransitRoute route)
		{
			return NavMeshUtility.GetAccessPoint(route.Source, base.Npc);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x0007A2E5 File Offset: 0x000784E5
		private bool IsAtSource()
		{
			return NavMeshUtility.IsAtTransitEntity(this.assignedRoute.Source, base.Npc, 0.4f);
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x0007A302 File Offset: 0x00078502
		public bool CanGetToDestination(TransitRoute route)
		{
			return this.GetDestinationAccessPoint(route) != null;
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x0007A311 File Offset: 0x00078511
		private Transform GetDestinationAccessPoint(TransitRoute route)
		{
			if (route.Destination == null)
			{
				Console.LogWarning("Destination is null!", null);
				return null;
			}
			return NavMeshUtility.GetAccessPoint(route.Destination, base.Npc);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x0007A33C File Offset: 0x0007853C
		private bool IsAtDestination()
		{
			if (base.beh.DEBUG_MODE)
			{
				ITransitEntity destination = this.assignedRoute.Destination;
				Console.Log("Destination: " + destination.Name, null);
				foreach (Transform transform in destination.AccessPoints)
				{
					Debug.DrawLine(base.Npc.transform.position, transform.position, Color.red, 0.1f);
				}
			}
			return NavMeshUtility.IsAtTransitEntity(this.assignedRoute.Destination, base.Npc, 0.4f);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x0007A3D4 File Offset: 0x000785D4
		public MoveItemData GetSaveData()
		{
			if (!base.Active || this.grabbedAmount == 0)
			{
				return null;
			}
			string templateItemJson = string.Empty;
			if (this.itemToRetrieveTemplate != null)
			{
				templateItemJson = this.itemToRetrieveTemplate.GetItemData().GetJson(false);
			}
			return new MoveItemData(templateItemJson, this.grabbedAmount, (this.assignedRoute.Source as IGUIDRegisterable).GUID, (this.assignedRoute.Destination as IGUIDRegisterable).GUID);
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x0007A44C File Offset: 0x0007864C
		public void Load(MoveItemData moveItemData)
		{
			if (moveItemData == null)
			{
				return;
			}
			if (moveItemData.GrabbedItemQuantity == 0 || string.IsNullOrEmpty(moveItemData.TemplateItemJSON))
			{
				return;
			}
			ITransitEntity @object = GUIDManager.GetObject<ITransitEntity>(new Guid(moveItemData.SourceGUID));
			ITransitEntity object2 = GUIDManager.GetObject<ITransitEntity>(new Guid(moveItemData.DestinationGUID));
			if (@object == null)
			{
				Console.LogWarning("Failed to load source transit entity", null);
				return;
			}
			if (object2 == null)
			{
				Console.LogWarning("Failed to load destination transit entity", null);
				return;
			}
			TransitRoute route = new TransitRoute(@object, object2);
			this.grabbedAmount = moveItemData.GrabbedItemQuantity;
			Debug.Log("Resuming move item behaviour");
			ItemInstance itemInstance = ItemDeserializer.LoadItem(moveItemData.TemplateItemJSON);
			if (itemInstance != null)
			{
				this.Resume(route, itemInstance, -1);
				base.Enable_Networked(null);
			}
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x0007A4FF File Offset: 0x000786FF
		[CompilerGenerated]
		private IEnumerator <WalkToSource>g__Routine|26_0()
		{
			base.SetDestination(this.GetSourceAccessPoint(this.assignedRoute).position, true);
			yield return new WaitForSeconds(0.5f);
			yield return new WaitUntil(() => !base.Npc.Movement.IsMoving);
			this.currentState = MoveItemBehaviour.EState.Idle;
			this.walkToSourceRoutine = null;
			yield break;
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x0007A523 File Offset: 0x00078723
		[CompilerGenerated]
		private IEnumerator <GrabItem>g__Routine|27_0()
		{
			Transform sourceAccessPoint = this.GetSourceAccessPoint(this.assignedRoute);
			if (sourceAccessPoint == null)
			{
				Console.LogWarning("Could not find source access point!", null);
				this.grabRoutine = null;
				base.Disable_Networked(null);
				yield break;
			}
			base.Npc.Movement.FaceDirection(sourceAccessPoint.forward, 0.5f);
			base.Npc.SetAnimationTrigger_Networked(null, "GrabItem");
			float seconds = 0.5f;
			yield return new WaitForSeconds(seconds);
			string str;
			if (!this.IsTransitRouteValid(this.assignedRoute, this.itemToRetrieveTemplate, out str))
			{
				Console.LogWarning("Transit route no longer valid! Reason: " + str, null);
				this.grabRoutine = null;
				base.Disable_Networked(null);
				yield break;
			}
			this.TakeItem();
			yield return new WaitForSeconds(0.5f);
			this.grabRoutine = null;
			this.currentState = MoveItemBehaviour.EState.Idle;
			yield break;
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x0007A532 File Offset: 0x00078732
		[CompilerGenerated]
		private IEnumerator <WalkToDestination>g__Routine|29_0()
		{
			base.SetDestination(this.GetDestinationAccessPoint(this.assignedRoute).position, true);
			yield return new WaitForSeconds(0.5f);
			yield return new WaitUntil(() => !base.Npc.Movement.IsMoving);
			this.currentState = MoveItemBehaviour.EState.Idle;
			this.walkToDestinationRoutine = null;
			yield break;
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x0007A541 File Offset: 0x00078741
		[CompilerGenerated]
		private IEnumerator <PlaceItem>g__Routine|30_0()
		{
			if (this.GetDestinationAccessPoint(this.assignedRoute) != null)
			{
				base.Npc.Movement.FaceDirection(this.GetDestinationAccessPoint(this.assignedRoute).forward, 0.5f);
			}
			base.Npc.SetAnimationTrigger_Networked(null, "GrabItem");
			float seconds = 0.5f;
			yield return new WaitForSeconds(seconds);
			this.assignedRoute.Destination.RemoveSlotLocks(base.Npc.NetworkObject);
			ItemInstance firstIdenticalItem = base.Npc.Inventory.GetFirstIdenticalItem(this.itemToRetrieveTemplate, null);
			if (firstIdenticalItem != null && this.grabbedAmount > 0)
			{
				ItemInstance copy = firstIdenticalItem.GetCopy(this.grabbedAmount);
				if (this.assignedRoute.Destination.GetInputCapacityForItem(copy, base.Npc) >= this.grabbedAmount)
				{
					this.assignedRoute.Destination.InsertItemIntoInput(copy, base.Npc);
				}
				else
				{
					Console.LogWarning("Destination does not have enough capacity for item! Attempting to return item to source.", null);
					if (this.assignedRoute.Source.GetOutputCapacityForItem(copy, base.Npc) >= this.grabbedAmount)
					{
						this.assignedRoute.Source.InsertItemIntoOutput(copy, base.Npc);
					}
					else
					{
						Console.LogWarning("Source does not have enough capacity for item! Item will be lost.", null);
					}
				}
				firstIdenticalItem.ChangeQuantity(-this.grabbedAmount);
			}
			else
			{
				Console.LogWarning("Could not find carried item to place!", null);
			}
			yield return new WaitForSeconds(0.5f);
			this.placingRoutine = null;
			this.currentState = MoveItemBehaviour.EState.Idle;
			base.Disable_Networked(null);
			yield break;
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x0007A550 File Offset: 0x00078750
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.MoveItemBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.MoveItemBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x0007A569 File Offset: 0x00078769
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.MoveItemBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.MoveItemBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0007A582 File Offset: 0x00078782
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x0007A590 File Offset: 0x00078790
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040017BB RID: 6075
		private TransitRoute assignedRoute;

		// Token: 0x040017BC RID: 6076
		private ItemInstance itemToRetrieveTemplate;

		// Token: 0x040017BD RID: 6077
		private int grabbedAmount;

		// Token: 0x040017BE RID: 6078
		private int maxMoveAmount = -1;

		// Token: 0x040017BF RID: 6079
		private MoveItemBehaviour.EState currentState;

		// Token: 0x040017C0 RID: 6080
		private Coroutine walkToSourceRoutine;

		// Token: 0x040017C1 RID: 6081
		private Coroutine grabRoutine;

		// Token: 0x040017C2 RID: 6082
		private Coroutine walkToDestinationRoutine;

		// Token: 0x040017C3 RID: 6083
		private Coroutine placingRoutine;

		// Token: 0x040017C4 RID: 6084
		private bool skipPickup;

		// Token: 0x040017C5 RID: 6085
		private bool dll_Excuted;

		// Token: 0x040017C6 RID: 6086
		private bool dll_Excuted;

		// Token: 0x020004FD RID: 1277
		public enum EState
		{
			// Token: 0x040017C8 RID: 6088
			Idle,
			// Token: 0x040017C9 RID: 6089
			WalkingToSource,
			// Token: 0x040017CA RID: 6090
			Grabbing,
			// Token: 0x040017CB RID: 6091
			WalkingToDestination,
			// Token: 0x040017CC RID: 6092
			Placing
		}
	}
}
