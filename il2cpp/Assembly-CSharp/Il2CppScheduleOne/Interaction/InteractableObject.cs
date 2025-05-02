using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x020003F0 RID: 1008
	public class InteractableObject : MonoBehaviour
	{
		// Token: 0x0600534F RID: 21327 RVA: 0x00188C88 File Offset: 0x00186E88
		// Note: this type is marked as 'beforefieldinit'.
		static InteractableObject()
		{
			Il2CppClassPointerStore<InteractableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "InteractableObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr);
			InteractableObject.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "message");
			InteractableObject.NativeFieldInfoPtr_interactionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "interactionType");
			InteractableObject.NativeFieldInfoPtr_interactionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "interactionState");
			InteractableObject.NativeFieldInfoPtr_MaxInteractionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "MaxInteractionRange");
			InteractableObject.NativeFieldInfoPtr_RequiresUniqueClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "RequiresUniqueClick");
			InteractableObject.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "Priority");
			InteractableObject.NativeFieldInfoPtr_displayLocationCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "displayLocationCollider");
			InteractableObject.NativeFieldInfoPtr_displayLocationPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "displayLocationPoint");
			InteractableObject.NativeFieldInfoPtr_LimitInteractionAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "LimitInteractionAngle");
			InteractableObject.NativeFieldInfoPtr_AngleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "AngleLimit");
			InteractableObject.NativeFieldInfoPtr_onHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "onHovered");
			InteractableObject.NativeFieldInfoPtr_onInteractStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "onInteractStart");
			InteractableObject.NativeFieldInfoPtr_onInteractEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "onInteractEnd");
			InteractableObject.NativeMethodInfoPtr_get__interactionType_Public_get_EInteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673715);
			InteractableObject.NativeMethodInfoPtr_get__interactionState_Public_get_EInteractableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673716);
			InteractableObject.NativeMethodInfoPtr_SetInteractionType_Public_Void_EInteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673717);
			InteractableObject.NativeMethodInfoPtr_SetInteractableState_Public_Void_EInteractableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673718);
			InteractableObject.NativeMethodInfoPtr_SetMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673719);
			InteractableObject.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673720);
			InteractableObject.NativeMethodInfoPtr_StartInteract_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673721);
			InteractableObject.NativeMethodInfoPtr_EndInteract_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673722);
			InteractableObject.NativeMethodInfoPtr_ShowMessage_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673723);
			InteractableObject.NativeMethodInfoPtr_CheckAngleLimit_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673724);
			InteractableObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673725);
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06005350 RID: 21328 RVA: 0x00188E98 File Offset: 0x00187098
		public unsafe InteractableObject.EInteractionType _interactionType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29988, RefRangeEnd = 29989, XrefRangeStart = 29988, XrefRangeEnd = 29989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_get__interactionType_Public_get_EInteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06005351 RID: 21329 RVA: 0x00188ED4 File Offset: 0x001870D4
		public unsafe InteractableObject.EInteractableState _interactionState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_get__interactionState_Public_get_EInteractableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005352 RID: 21330 RVA: 0x00188F10 File Offset: 0x00187110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29989, RefRangeEnd = 29990, XrefRangeStart = 29989, XrefRangeEnd = 29990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractionType(InteractableObject.EInteractionType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_SetInteractionType_Public_Void_EInteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x00188F50 File Offset: 0x00187150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179025, RefRangeEnd = 179026, XrefRangeStart = 179025, XrefRangeEnd = 179026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractableState(InteractableObject.EInteractableState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_SetInteractableState_Public_Void_EInteractableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005354 RID: 21332 RVA: 0x00188F90 File Offset: 0x00187190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMessage(string _message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_SetMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005355 RID: 21333 RVA: 0x00188FD4 File Offset: 0x001871D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179038, RefRangeEnd = 179039, XrefRangeStart = 179037, XrefRangeEnd = 179038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x00189010 File Offset: 0x00187210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179045, RefRangeEnd = 179046, XrefRangeStart = 179039, XrefRangeEnd = 179045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_StartInteract_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x0018904C File Offset: 0x0018724C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179046, XrefRangeEnd = 179053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_EndInteract_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005358 RID: 21336 RVA: 0x00189088 File Offset: 0x00187288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179053, XrefRangeEnd = 179081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_ShowMessage_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x001890C4 File Offset: 0x001872C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179090, RefRangeEnd = 179091, XrefRangeStart = 179081, XrefRangeEnd = 179090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckAngleLimit(Vector3 interactionSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactionSource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_CheckAngleLimit_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600535A RID: 21338 RVA: 0x00189110 File Offset: 0x00187310
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179109, RefRangeEnd = 179110, XrefRangeStart = 179091, XrefRangeEnd = 179109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractableObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x00027BED File Offset: 0x00025DED
		public InteractableObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x0600535C RID: 21340 RVA: 0x0018914C File Offset: 0x0018734C
		// (set) Token: 0x0600535D RID: 21341 RVA: 0x00027BF6 File Offset: 0x00025DF6
		public unsafe string message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x0600535E RID: 21342 RVA: 0x00189174 File Offset: 0x00187374
		// (set) Token: 0x0600535F RID: 21343 RVA: 0x00027C15 File Offset: 0x00025E15
		public unsafe InteractableObject.EInteractionType interactionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionType)) = value;
			}
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x06005360 RID: 21344 RVA: 0x0018919C File Offset: 0x0018739C
		// (set) Token: 0x06005361 RID: 21345 RVA: 0x00027C30 File Offset: 0x00025E30
		public unsafe InteractableObject.EInteractableState interactionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionState)) = value;
			}
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x06005362 RID: 21346 RVA: 0x001891C4 File Offset: 0x001873C4
		// (set) Token: 0x06005363 RID: 21347 RVA: 0x00027C4B File Offset: 0x00025E4B
		public unsafe float MaxInteractionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_MaxInteractionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_MaxInteractionRange)) = value;
			}
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x06005364 RID: 21348 RVA: 0x001891EC File Offset: 0x001873EC
		// (set) Token: 0x06005365 RID: 21349 RVA: 0x00027C66 File Offset: 0x00025E66
		public unsafe bool RequiresUniqueClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_RequiresUniqueClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_RequiresUniqueClick)) = value;
			}
		}

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x06005366 RID: 21350 RVA: 0x00189214 File Offset: 0x00187414
		// (set) Token: 0x06005367 RID: 21351 RVA: 0x00027C81 File Offset: 0x00025E81
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x06005368 RID: 21352 RVA: 0x0018923C File Offset: 0x0018743C
		// (set) Token: 0x06005369 RID: 21353 RVA: 0x00027C9C File Offset: 0x00025E9C
		public unsafe Collider displayLocationCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x0600536A RID: 21354 RVA: 0x0018926C File Offset: 0x0018746C
		// (set) Token: 0x0600536B RID: 21355 RVA: 0x00027CBB File Offset: 0x00025EBB
		public unsafe Transform displayLocationPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x0600536C RID: 21356 RVA: 0x0018929C File Offset: 0x0018749C
		// (set) Token: 0x0600536D RID: 21357 RVA: 0x00027CDA File Offset: 0x00025EDA
		public unsafe bool LimitInteractionAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_LimitInteractionAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_LimitInteractionAngle)) = value;
			}
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x0600536E RID: 21358 RVA: 0x001892C4 File Offset: 0x001874C4
		// (set) Token: 0x0600536F RID: 21359 RVA: 0x00027CF5 File Offset: 0x00025EF5
		public unsafe float AngleLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_AngleLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_AngleLimit)) = value;
			}
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x06005370 RID: 21360 RVA: 0x001892EC File Offset: 0x001874EC
		// (set) Token: 0x06005371 RID: 21361 RVA: 0x00027D10 File Offset: 0x00025F10
		public unsafe UnityEvent onHovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onHovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onHovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x06005372 RID: 21362 RVA: 0x0018931C File Offset: 0x0018751C
		// (set) Token: 0x06005373 RID: 21363 RVA: 0x00027D2F File Offset: 0x00025F2F
		public unsafe UnityEvent onInteractStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x06005374 RID: 21364 RVA: 0x0018934C File Offset: 0x0018754C
		// (set) Token: 0x06005375 RID: 21365 RVA: 0x00027D4E File Offset: 0x00025F4E
		public unsafe UnityEvent onInteractEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400387B RID: 14459
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x0400387C RID: 14460
		private static readonly IntPtr NativeFieldInfoPtr_interactionType;

		// Token: 0x0400387D RID: 14461
		private static readonly IntPtr NativeFieldInfoPtr_interactionState;

		// Token: 0x0400387E RID: 14462
		private static readonly IntPtr NativeFieldInfoPtr_MaxInteractionRange;

		// Token: 0x0400387F RID: 14463
		private static readonly IntPtr NativeFieldInfoPtr_RequiresUniqueClick;

		// Token: 0x04003880 RID: 14464
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04003881 RID: 14465
		private static readonly IntPtr NativeFieldInfoPtr_displayLocationCollider;

		// Token: 0x04003882 RID: 14466
		private static readonly IntPtr NativeFieldInfoPtr_displayLocationPoint;

		// Token: 0x04003883 RID: 14467
		private static readonly IntPtr NativeFieldInfoPtr_LimitInteractionAngle;

		// Token: 0x04003884 RID: 14468
		private static readonly IntPtr NativeFieldInfoPtr_AngleLimit;

		// Token: 0x04003885 RID: 14469
		private static readonly IntPtr NativeFieldInfoPtr_onHovered;

		// Token: 0x04003886 RID: 14470
		private static readonly IntPtr NativeFieldInfoPtr_onInteractStart;

		// Token: 0x04003887 RID: 14471
		private static readonly IntPtr NativeFieldInfoPtr_onInteractEnd;

		// Token: 0x04003888 RID: 14472
		private static readonly IntPtr NativeMethodInfoPtr_get__interactionType_Public_get_EInteractionType_0;

		// Token: 0x04003889 RID: 14473
		private static readonly IntPtr NativeMethodInfoPtr_get__interactionState_Public_get_EInteractableState_0;

		// Token: 0x0400388A RID: 14474
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractionType_Public_Void_EInteractionType_0;

		// Token: 0x0400388B RID: 14475
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractableState_Public_Void_EInteractableState_0;

		// Token: 0x0400388C RID: 14476
		private static readonly IntPtr NativeMethodInfoPtr_SetMessage_Public_Void_String_0;

		// Token: 0x0400388D RID: 14477
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0;

		// Token: 0x0400388E RID: 14478
		private static readonly IntPtr NativeMethodInfoPtr_StartInteract_Public_Virtual_New_Void_0;

		// Token: 0x0400388F RID: 14479
		private static readonly IntPtr NativeMethodInfoPtr_EndInteract_Public_Virtual_New_Void_0;

		// Token: 0x04003890 RID: 14480
		private static readonly IntPtr NativeMethodInfoPtr_ShowMessage_Protected_Virtual_New_Void_0;

		// Token: 0x04003891 RID: 14481
		private static readonly IntPtr NativeMethodInfoPtr_CheckAngleLimit_Public_Boolean_Vector3_0;

		// Token: 0x04003892 RID: 14482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009B2 RID: 2482
		[OriginalName("Assembly-CSharp.dll", "", "EInteractionType")]
		public enum EInteractionType
		{
			// Token: 0x040089D0 RID: 35280
			Key_Press,
			// Token: 0x040089D1 RID: 35281
			LeftMouse_Click
		}

		// Token: 0x020009B3 RID: 2483
		[OriginalName("Assembly-CSharp.dll", "", "EInteractableState")]
		public enum EInteractableState
		{
			// Token: 0x040089D3 RID: 35283
			Default,
			// Token: 0x040089D4 RID: 35284
			Invalid,
			// Token: 0x040089D5 RID: 35285
			Disabled,
			// Token: 0x040089D6 RID: 35286
			Label
		}
	}
}
