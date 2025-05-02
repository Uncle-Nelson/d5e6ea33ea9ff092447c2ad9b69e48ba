using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x020001FC RID: 508
	public class Draggable : Clickable
	{
		// Token: 0x060029E5 RID: 10725 RVA: 0x000F56EC File Offset: 0x000F38EC
		// Note: this type is marked as 'beforefieldinit'.
		static Draggable()
		{
			Il2CppClassPointerStore<Draggable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Draggable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Draggable>.NativeClassPtr);
			Draggable.NativeFieldInfoPtr_DragForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DragForceMultiplier");
			Draggable.NativeFieldInfoPtr_DragForceOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DragForceOrigin");
			Draggable.NativeFieldInfoPtr_RotationEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "RotationEnabled");
			Draggable.NativeFieldInfoPtr_TorqueMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "TorqueMultiplier");
			Draggable.NativeFieldInfoPtr_DragProjectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DragProjectionMode");
			Draggable.NativeFieldInfoPtr_DisableGravityWhenDragged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DisableGravityWhenDragged");
			Draggable.NativeFieldInfoPtr_NormalRBDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "NormalRBDrag");
			Draggable.NativeFieldInfoPtr_HeldRBDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "HeldRBDrag");
			Draggable.NativeFieldInfoPtr_CanBeMultiDragged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "CanBeMultiDragged");
			Draggable.NativeFieldInfoPtr__Rb_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<Rb>k__BackingField");
			Draggable.NativeFieldInfoPtr__HoveredCursor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<HoveredCursor>k__BackingField");
			Draggable.NativeFieldInfoPtr_idleUpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "idleUpForce");
			Draggable.NativeFieldInfoPtr_LocationRestrictionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "LocationRestrictionEnabled");
			Draggable.NativeFieldInfoPtr_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "Origin");
			Draggable.NativeFieldInfoPtr_MaxDistanceFromOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "MaxDistanceFromOrigin");
			Draggable.NativeFieldInfoPtr_onTriggerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onTriggerExit");
			Draggable.NativeFieldInfoPtr_constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "constraint");
			Draggable.NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668027);
			Draggable.NativeMethodInfoPtr_set_Rb_Protected_set_Void_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668028);
			Draggable.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668029);
			Draggable.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668030);
			Draggable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668031);
			Draggable.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668032);
			Draggable.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668033);
			Draggable.NativeMethodInfoPtr_PostFixedUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668034);
			Draggable.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668035);
			Draggable.NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668036);
			Draggable.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668037);
			Draggable.NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668038);
			Draggable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668039);
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x060029E6 RID: 10726 RVA: 0x000F5974 File Offset: 0x000F3B74
		// (set) Token: 0x060029E7 RID: 10727 RVA: 0x000F59B4 File Offset: 0x000F3BB4
		public unsafe Rigidbody Rb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120265, XrefRangeEnd = 120266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_set_Rb_Protected_set_Void_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x060029E8 RID: 10728 RVA: 0x000F59F8 File Offset: 0x000F3BF8
		// (set) Token: 0x060029E9 RID: 10729 RVA: 0x000F5A40 File Offset: 0x000F3C40
		public unsafe override CursorManager.ECursorType HoveredCursor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x000F5A8C File Offset: 0x000F3C8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120282, RefRangeEnd = 120283, XrefRangeStart = 120266, XrefRangeEnd = 120282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x000F5AC8 File Offset: 0x000F3CC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120313, RefRangeEnd = 120316, XrefRangeStart = 120283, XrefRangeEnd = 120313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x000F5B04 File Offset: 0x000F3D04
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x000F5B40 File Offset: 0x000F3D40
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_PostFixedUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x000F5B7C File Offset: 0x000F3D7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120328, RefRangeEnd = 120330, XrefRangeStart = 120316, XrefRangeEnd = 120328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x000F5BB8 File Offset: 0x000F3DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120330, XrefRangeEnd = 120333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x000F5C08 File Offset: 0x000F3E08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120337, RefRangeEnd = 120338, XrefRangeStart = 120333, XrefRangeEnd = 120337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x000F5C54 File Offset: 0x000F3E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120338, XrefRangeEnd = 120344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x000F5C90 File Offset: 0x000F3E90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120349, RefRangeEnd = 120352, XrefRangeStart = 120344, XrefRangeEnd = 120349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Draggable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Draggable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x00016ABA File Offset: 0x00014CBA
		public Draggable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x060029F4 RID: 10740 RVA: 0x000F5CCC File Offset: 0x000F3ECC
		// (set) Token: 0x060029F5 RID: 10741 RVA: 0x00016AC3 File Offset: 0x00014CC3
		public unsafe float DragForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragForceMultiplier)) = value;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x000F5CF4 File Offset: 0x000F3EF4
		// (set) Token: 0x060029F7 RID: 10743 RVA: 0x00016ADE File Offset: 0x00014CDE
		public unsafe Transform DragForceOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragForceOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragForceOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x060029F8 RID: 10744 RVA: 0x000F5D24 File Offset: 0x000F3F24
		// (set) Token: 0x060029F9 RID: 10745 RVA: 0x00016AFD File Offset: 0x00014CFD
		public unsafe bool RotationEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_RotationEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_RotationEnabled)) = value;
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x060029FA RID: 10746 RVA: 0x000F5D4C File Offset: 0x000F3F4C
		// (set) Token: 0x060029FB RID: 10747 RVA: 0x00016B18 File Offset: 0x00014D18
		public unsafe float TorqueMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_TorqueMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_TorqueMultiplier)) = value;
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x060029FC RID: 10748 RVA: 0x000F5D74 File Offset: 0x000F3F74
		// (set) Token: 0x060029FD RID: 10749 RVA: 0x00016B33 File Offset: 0x00014D33
		public unsafe Draggable.EDragProjectionMode DragProjectionMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragProjectionMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragProjectionMode)) = value;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x000F5D9C File Offset: 0x000F3F9C
		// (set) Token: 0x060029FF RID: 10751 RVA: 0x00016B4E File Offset: 0x00014D4E
		public unsafe bool DisableGravityWhenDragged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DisableGravityWhenDragged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DisableGravityWhenDragged)) = value;
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06002A00 RID: 10752 RVA: 0x000F5DC4 File Offset: 0x000F3FC4
		// (set) Token: 0x06002A01 RID: 10753 RVA: 0x00016B69 File Offset: 0x00014D69
		public unsafe float NormalRBDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_NormalRBDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_NormalRBDrag)) = value;
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06002A02 RID: 10754 RVA: 0x000F5DEC File Offset: 0x000F3FEC
		// (set) Token: 0x06002A03 RID: 10755 RVA: 0x00016B84 File Offset: 0x00014D84
		public unsafe float HeldRBDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_HeldRBDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_HeldRBDrag)) = value;
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x000F5E14 File Offset: 0x000F4014
		// (set) Token: 0x06002A05 RID: 10757 RVA: 0x00016B9F File Offset: 0x00014D9F
		public unsafe bool CanBeMultiDragged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_CanBeMultiDragged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_CanBeMultiDragged)) = value;
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06002A06 RID: 10758 RVA: 0x000F5E3C File Offset: 0x000F403C
		// (set) Token: 0x06002A07 RID: 10759 RVA: 0x00016BBA File Offset: 0x00014DBA
		public unsafe Rigidbody _Rb_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__Rb_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__Rb_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x000F5E6C File Offset: 0x000F406C
		// (set) Token: 0x06002A09 RID: 10761 RVA: 0x00016BD9 File Offset: 0x00014DD9
		public new unsafe CursorManager.ECursorType _HoveredCursor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__HoveredCursor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__HoveredCursor_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x000F5E94 File Offset: 0x000F4094
		// (set) Token: 0x06002A0B RID: 10763 RVA: 0x00016BF4 File Offset: 0x00014DF4
		public unsafe float idleUpForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_idleUpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_idleUpForce)) = value;
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06002A0C RID: 10764 RVA: 0x000F5EBC File Offset: 0x000F40BC
		// (set) Token: 0x06002A0D RID: 10765 RVA: 0x00016C0F File Offset: 0x00014E0F
		public unsafe bool LocationRestrictionEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_LocationRestrictionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_LocationRestrictionEnabled)) = value;
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06002A0E RID: 10766 RVA: 0x000F5EE4 File Offset: 0x000F40E4
		// (set) Token: 0x06002A0F RID: 10767 RVA: 0x00016C2A File Offset: 0x00014E2A
		public unsafe Vector3 Origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_Origin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_Origin)) = value;
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06002A10 RID: 10768 RVA: 0x000F5F0C File Offset: 0x000F410C
		// (set) Token: 0x06002A11 RID: 10769 RVA: 0x00016C45 File Offset: 0x00014E45
		public unsafe float MaxDistanceFromOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_MaxDistanceFromOrigin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_MaxDistanceFromOrigin)) = value;
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06002A12 RID: 10770 RVA: 0x000F5F34 File Offset: 0x000F4134
		// (set) Token: 0x06002A13 RID: 10771 RVA: 0x00016C60 File Offset: 0x00014E60
		public unsafe UnityEvent<Collider> onTriggerExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onTriggerExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onTriggerExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06002A14 RID: 10772 RVA: 0x000F5F64 File Offset: 0x000F4164
		// (set) Token: 0x06002A15 RID: 10773 RVA: 0x00016C7F File Offset: 0x00014E7F
		public unsafe DraggableConstraint constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeFieldInfoPtr_DragForceMultiplier;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeFieldInfoPtr_DragForceOrigin;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeFieldInfoPtr_RotationEnabled;

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeFieldInfoPtr_TorqueMultiplier;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeFieldInfoPtr_DragProjectionMode;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeFieldInfoPtr_DisableGravityWhenDragged;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeFieldInfoPtr_NormalRBDrag;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeFieldInfoPtr_HeldRBDrag;

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeFieldInfoPtr_CanBeMultiDragged;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeFieldInfoPtr__Rb_k__BackingField;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeFieldInfoPtr__HoveredCursor_k__BackingField;

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeFieldInfoPtr_idleUpForce;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeFieldInfoPtr_LocationRestrictionEnabled;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeFieldInfoPtr_Origin;

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistanceFromOrigin;

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeFieldInfoPtr_onTriggerExit;

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeFieldInfoPtr_constraint;

		// Token: 0x04001BE8 RID: 7144
		private static readonly IntPtr NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0;

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeMethodInfoPtr_set_Rb_Protected_set_Void_Rigidbody_0;

		// Token: 0x04001BEA RID: 7146
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0;

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0;

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeMethodInfoPtr_PostFixedUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_New_Void_Collider_0;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008DE RID: 2270
		[OriginalName("Assembly-CSharp.dll", "", "EDragProjectionMode")]
		public enum EDragProjectionMode
		{
			// Token: 0x04008527 RID: 34087
			CameraForward,
			// Token: 0x04008528 RID: 34088
			FlatCameraForward
		}
	}
}
