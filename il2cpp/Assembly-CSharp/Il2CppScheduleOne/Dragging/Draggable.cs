using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dragging
{
	// Token: 0x0200041E RID: 1054
	public class Draggable : MonoBehaviour
	{
		// Token: 0x06005C85 RID: 23685 RVA: 0x001AC190 File Offset: 0x001AA390
		// Note: this type is marked as 'beforefieldinit'.
		static Draggable()
		{
			Il2CppClassPointerStore<Draggable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dragging", "Draggable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Draggable>.NativeClassPtr);
			Draggable.NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "INITIAL_REPLICATION_DISTANCE");
			Draggable.NativeFieldInfoPtr_MAX_DRAG_START_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "MAX_DRAG_START_RANGE");
			Draggable.NativeFieldInfoPtr_MAX_TARGET_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "MAX_TARGET_OFFSET");
			Draggable.NativeFieldInfoPtr__CurrentDragger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<CurrentDragger>k__BackingField");
			Draggable.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<GUID>k__BackingField");
			Draggable.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "BakedGUID");
			Draggable.NativeFieldInfoPtr_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "Rigidbody");
			Draggable.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "IntObj");
			Draggable.NativeFieldInfoPtr_DragOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DragOrigin");
			Draggable.NativeFieldInfoPtr_CreateCoM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "CreateCoM");
			Draggable.NativeFieldInfoPtr_HoldDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "HoldDistanceMultiplier");
			Draggable.NativeFieldInfoPtr_DragForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DragForceMultiplier");
			Draggable.NativeFieldInfoPtr_InitialReplicationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "InitialReplicationMode");
			Draggable.NativeFieldInfoPtr_timeSinceLastDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "timeSinceLastDrag");
			Draggable.NativeFieldInfoPtr_onDragStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onDragStart");
			Draggable.NativeFieldInfoPtr_onDragEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onDragEnd");
			Draggable.NativeFieldInfoPtr_onHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onHovered");
			Draggable.NativeFieldInfoPtr_onInteracted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onInteracted");
			Draggable.NativeFieldInfoPtr__initialPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<initialPosition>k__BackingField");
			Draggable.NativeMethodInfoPtr_get_IsBeingDragged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675095);
			Draggable.NativeMethodInfoPtr_get_CurrentDragger_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675096);
			Draggable.NativeMethodInfoPtr_set_CurrentDragger_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675097);
			Draggable.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675098);
			Draggable.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675099);
			Draggable.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675100);
			Draggable.NativeMethodInfoPtr_get_initialPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675101);
			Draggable.NativeMethodInfoPtr_set_initialPosition_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675102);
			Draggable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675103);
			Draggable.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675104);
			Draggable.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675105);
			Draggable.NativeMethodInfoPtr_OnValidate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675106);
			Draggable.NativeMethodInfoPtr_OnDestroy_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675107);
			Draggable.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675108);
			Draggable.NativeMethodInfoPtr_ApplyDragForces_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675109);
			Draggable.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675110);
			Draggable.NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675111);
			Draggable.NativeMethodInfoPtr_CanInteract_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675112);
			Draggable.NativeMethodInfoPtr_StartDragging_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675113);
			Draggable.NativeMethodInfoPtr_StopDragging_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675114);
			Draggable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675115);
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06005C86 RID: 23686 RVA: 0x001AC4E0 File Offset: 0x001AA6E0
		public unsafe bool IsBeingDragged
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 195063, RefRangeEnd = 195068, XrefRangeStart = 195059, XrefRangeEnd = 195063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_IsBeingDragged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06005C87 RID: 23687 RVA: 0x001AC51C File Offset: 0x001AA71C
		// (set) Token: 0x06005C88 RID: 23688 RVA: 0x001AC55C File Offset: 0x001AA75C
		public unsafe Player CurrentDragger
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_CurrentDragger_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_set_CurrentDragger_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x06005C89 RID: 23689 RVA: 0x001AC5A0 File Offset: 0x001AA7A0
		// (set) Token: 0x06005C8A RID: 23690 RVA: 0x001AC5DC File Offset: 0x001AA7DC
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 54194, RefRangeEnd = 54198, XrefRangeStart = 54194, XrefRangeEnd = 54198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005C8B RID: 23691 RVA: 0x001AC61C File Offset: 0x001AA81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195068, XrefRangeEnd = 195071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x06005C8C RID: 23692 RVA: 0x001AC650 File Offset: 0x001AA850
		// (set) Token: 0x06005C8D RID: 23693 RVA: 0x001AC68C File Offset: 0x001AA88C
		public unsafe Vector3 initialPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_initialPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_set_initialPosition_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005C8E RID: 23694 RVA: 0x001AC6CC File Offset: 0x001AA8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195071, XrefRangeEnd = 195104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C8F RID: 23695 RVA: 0x001AC708 File Offset: 0x001AA908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195104, XrefRangeEnd = 195110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x001AC744 File Offset: 0x001AA944
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195114, RefRangeEnd = 195116, XrefRangeStart = 195110, XrefRangeEnd = 195114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x001AC784 File Offset: 0x001AA984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195116, XrefRangeEnd = 195131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_OnValidate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x001AC7B8 File Offset: 0x001AA9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195131, XrefRangeEnd = 195154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_OnDestroy_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C93 RID: 23699 RVA: 0x001AC7EC File Offset: 0x001AA9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195154, XrefRangeEnd = 195175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x001AC820 File Offset: 0x001AAA20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195216, RefRangeEnd = 195218, XrefRangeStart = 195175, XrefRangeEnd = 195216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDragForces(Vector3 targetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_ApplyDragForces_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C95 RID: 23701 RVA: 0x001AC860 File Offset: 0x001AAA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195218, XrefRangeEnd = 195225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C96 RID: 23702 RVA: 0x001AC89C File Offset: 0x001AAA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195225, XrefRangeEnd = 195232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C97 RID: 23703 RVA: 0x001AC8D8 File Offset: 0x001AAAD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195243, RefRangeEnd = 195245, XrefRangeStart = 195232, XrefRangeEnd = 195243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_CanInteract_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005C98 RID: 23704 RVA: 0x001AC914 File Offset: 0x001AAB14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195252, RefRangeEnd = 195253, XrefRangeStart = 195245, XrefRangeEnd = 195252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDragging(Player dragger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_StartDragging_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x001AC958 File Offset: 0x001AAB58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 195260, RefRangeEnd = 195263, XrefRangeStart = 195253, XrefRangeEnd = 195260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopDragging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_StopDragging_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x001AC98C File Offset: 0x001AAB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195263, XrefRangeEnd = 195267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Draggable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Draggable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x0002B9F1 File Offset: 0x00029BF1
		public Draggable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x06005C9C RID: 23708 RVA: 0x001AC9C8 File Offset: 0x001AABC8
		// (set) Token: 0x06005C9D RID: 23709 RVA: 0x0002B9FA File Offset: 0x00029BFA
		public unsafe static float INITIAL_REPLICATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Draggable.NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Draggable.NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x06005C9E RID: 23710 RVA: 0x001AC9E4 File Offset: 0x001AABE4
		// (set) Token: 0x06005C9F RID: 23711 RVA: 0x0002BA08 File Offset: 0x00029C08
		public unsafe static float MAX_DRAG_START_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Draggable.NativeFieldInfoPtr_MAX_DRAG_START_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Draggable.NativeFieldInfoPtr_MAX_DRAG_START_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x06005CA0 RID: 23712 RVA: 0x001ACA00 File Offset: 0x001AAC00
		// (set) Token: 0x06005CA1 RID: 23713 RVA: 0x0002BA16 File Offset: 0x00029C16
		public unsafe static float MAX_TARGET_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Draggable.NativeFieldInfoPtr_MAX_TARGET_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Draggable.NativeFieldInfoPtr_MAX_TARGET_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x06005CA2 RID: 23714 RVA: 0x001ACA1C File Offset: 0x001AAC1C
		// (set) Token: 0x06005CA3 RID: 23715 RVA: 0x0002BA24 File Offset: 0x00029C24
		public unsafe Player _CurrentDragger_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__CurrentDragger_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__CurrentDragger_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x06005CA4 RID: 23716 RVA: 0x001ACA4C File Offset: 0x001AAC4C
		// (set) Token: 0x06005CA5 RID: 23717 RVA: 0x0002BA43 File Offset: 0x00029C43
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x06005CA6 RID: 23718 RVA: 0x001ACA74 File Offset: 0x001AAC74
		// (set) Token: 0x06005CA7 RID: 23719 RVA: 0x0002BA5E File Offset: 0x00029C5E
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x06005CA8 RID: 23720 RVA: 0x001ACA9C File Offset: 0x001AAC9C
		// (set) Token: 0x06005CA9 RID: 23721 RVA: 0x0002BA7D File Offset: 0x00029C7D
		public unsafe Rigidbody Rigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_Rigidbody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_Rigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x06005CAA RID: 23722 RVA: 0x001ACACC File Offset: 0x001AACCC
		// (set) Token: 0x06005CAB RID: 23723 RVA: 0x0002BA9C File Offset: 0x00029C9C
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x06005CAC RID: 23724 RVA: 0x001ACAFC File Offset: 0x001AACFC
		// (set) Token: 0x06005CAD RID: 23725 RVA: 0x0002BABB File Offset: 0x00029CBB
		public unsafe Transform DragOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x06005CAE RID: 23726 RVA: 0x001ACB2C File Offset: 0x001AAD2C
		// (set) Token: 0x06005CAF RID: 23727 RVA: 0x0002BADA File Offset: 0x00029CDA
		public unsafe bool CreateCoM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_CreateCoM);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_CreateCoM)) = value;
			}
		}

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x06005CB0 RID: 23728 RVA: 0x001ACB54 File Offset: 0x001AAD54
		// (set) Token: 0x06005CB1 RID: 23729 RVA: 0x0002BAF5 File Offset: 0x00029CF5
		public unsafe float HoldDistanceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_HoldDistanceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_HoldDistanceMultiplier)) = value;
			}
		}

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x06005CB2 RID: 23730 RVA: 0x001ACB7C File Offset: 0x001AAD7C
		// (set) Token: 0x06005CB3 RID: 23731 RVA: 0x0002BB10 File Offset: 0x00029D10
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

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06005CB4 RID: 23732 RVA: 0x001ACBA4 File Offset: 0x001AADA4
		// (set) Token: 0x06005CB5 RID: 23733 RVA: 0x0002BB2B File Offset: 0x00029D2B
		public unsafe Draggable.EInitialReplicationMode InitialReplicationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_InitialReplicationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_InitialReplicationMode)) = value;
			}
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x06005CB6 RID: 23734 RVA: 0x001ACBCC File Offset: 0x001AADCC
		// (set) Token: 0x06005CB7 RID: 23735 RVA: 0x0002BB46 File Offset: 0x00029D46
		public unsafe float timeSinceLastDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_timeSinceLastDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_timeSinceLastDrag)) = value;
			}
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x06005CB8 RID: 23736 RVA: 0x001ACBF4 File Offset: 0x001AADF4
		// (set) Token: 0x06005CB9 RID: 23737 RVA: 0x0002BB61 File Offset: 0x00029D61
		public unsafe UnityEvent onDragStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x06005CBA RID: 23738 RVA: 0x001ACC24 File Offset: 0x001AAE24
		// (set) Token: 0x06005CBB RID: 23739 RVA: 0x0002BB80 File Offset: 0x00029D80
		public unsafe UnityEvent onDragEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06005CBC RID: 23740 RVA: 0x001ACC54 File Offset: 0x001AAE54
		// (set) Token: 0x06005CBD RID: 23741 RVA: 0x0002BB9F File Offset: 0x00029D9F
		public unsafe UnityEvent onHovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onHovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onHovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06005CBE RID: 23742 RVA: 0x001ACC84 File Offset: 0x001AAE84
		// (set) Token: 0x06005CBF RID: 23743 RVA: 0x0002BBBE File Offset: 0x00029DBE
		public unsafe UnityEvent onInteracted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onInteracted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onInteracted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06005CC0 RID: 23744 RVA: 0x001ACCB4 File Offset: 0x001AAEB4
		// (set) Token: 0x06005CC1 RID: 23745 RVA: 0x0002BBDD File Offset: 0x00029DDD
		public unsafe Vector3 _initialPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__initialPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__initialPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x04003F49 RID: 16201
		private static readonly IntPtr NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE;

		// Token: 0x04003F4A RID: 16202
		private static readonly IntPtr NativeFieldInfoPtr_MAX_DRAG_START_RANGE;

		// Token: 0x04003F4B RID: 16203
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TARGET_OFFSET;

		// Token: 0x04003F4C RID: 16204
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDragger_k__BackingField;

		// Token: 0x04003F4D RID: 16205
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003F4E RID: 16206
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04003F4F RID: 16207
		private static readonly IntPtr NativeFieldInfoPtr_Rigidbody;

		// Token: 0x04003F50 RID: 16208
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04003F51 RID: 16209
		private static readonly IntPtr NativeFieldInfoPtr_DragOrigin;

		// Token: 0x04003F52 RID: 16210
		private static readonly IntPtr NativeFieldInfoPtr_CreateCoM;

		// Token: 0x04003F53 RID: 16211
		private static readonly IntPtr NativeFieldInfoPtr_HoldDistanceMultiplier;

		// Token: 0x04003F54 RID: 16212
		private static readonly IntPtr NativeFieldInfoPtr_DragForceMultiplier;

		// Token: 0x04003F55 RID: 16213
		private static readonly IntPtr NativeFieldInfoPtr_InitialReplicationMode;

		// Token: 0x04003F56 RID: 16214
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastDrag;

		// Token: 0x04003F57 RID: 16215
		private static readonly IntPtr NativeFieldInfoPtr_onDragStart;

		// Token: 0x04003F58 RID: 16216
		private static readonly IntPtr NativeFieldInfoPtr_onDragEnd;

		// Token: 0x04003F59 RID: 16217
		private static readonly IntPtr NativeFieldInfoPtr_onHovered;

		// Token: 0x04003F5A RID: 16218
		private static readonly IntPtr NativeFieldInfoPtr_onInteracted;

		// Token: 0x04003F5B RID: 16219
		private static readonly IntPtr NativeFieldInfoPtr__initialPosition_k__BackingField;

		// Token: 0x04003F5C RID: 16220
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBeingDragged_Public_get_Boolean_0;

		// Token: 0x04003F5D RID: 16221
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDragger_Public_get_Player_0;

		// Token: 0x04003F5E RID: 16222
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDragger_Protected_set_Void_Player_0;

		// Token: 0x04003F5F RID: 16223
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04003F60 RID: 16224
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04003F61 RID: 16225
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04003F62 RID: 16226
		private static readonly IntPtr NativeMethodInfoPtr_get_initialPosition_Public_get_Vector3_0;

		// Token: 0x04003F63 RID: 16227
		private static readonly IntPtr NativeMethodInfoPtr_set_initialPosition_Private_set_Void_Vector3_0;

		// Token: 0x04003F64 RID: 16228
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003F65 RID: 16229
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04003F66 RID: 16230
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04003F67 RID: 16231
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Void_0;

		// Token: 0x04003F68 RID: 16232
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Void_0;

		// Token: 0x04003F69 RID: 16233
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04003F6A RID: 16234
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDragForces_Public_Void_Vector3_0;

		// Token: 0x04003F6B RID: 16235
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0;

		// Token: 0x04003F6C RID: 16236
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0;

		// Token: 0x04003F6D RID: 16237
		private static readonly IntPtr NativeMethodInfoPtr_CanInteract_Private_Boolean_0;

		// Token: 0x04003F6E RID: 16238
		private static readonly IntPtr NativeMethodInfoPtr_StartDragging_Public_Void_Player_0;

		// Token: 0x04003F6F RID: 16239
		private static readonly IntPtr NativeMethodInfoPtr_StopDragging_Public_Void_0;

		// Token: 0x04003F70 RID: 16240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009F0 RID: 2544
		[OriginalName("Assembly-CSharp.dll", "", "EInitialReplicationMode")]
		public enum EInitialReplicationMode
		{
			// Token: 0x04008AFB RID: 35579
			Off,
			// Token: 0x04008AFC RID: 35580
			OnlyIfMoved,
			// Token: 0x04008AFD RID: 35581
			Full
		}
	}
}
