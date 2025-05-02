using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000748 RID: 1864
	public class LabOvenDoor : MonoBehaviour
	{
		// Token: 0x0600AEB5 RID: 44725 RVA: 0x002B9C04 File Offset: 0x002B7E04
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenDoor()
		{
			Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr);
			LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HIT_OFFSET_MAX");
			LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HIT_OFFSET_MIN");
			LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_CLOSED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "DOOR_ANGLE_CLOSED");
			LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_OPEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "DOOR_ANGLE_OPEN");
			LabOvenDoor.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "<Interactable>k__BackingField");
			LabOvenDoor.NativeFieldInfoPtr__TargetPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "<TargetPosition>k__BackingField");
			LabOvenDoor.NativeFieldInfoPtr__ActualPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "<ActualPosition>k__BackingField");
			LabOvenDoor.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HandleClickable");
			LabOvenDoor.NativeFieldInfoPtr_Door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "Door");
			LabOvenDoor.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "PlaneNormal");
			LabOvenDoor.NativeFieldInfoPtr_HitMapCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HitMapCurve");
			LabOvenDoor.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "OpenSound");
			LabOvenDoor.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "CloseSound");
			LabOvenDoor.NativeFieldInfoPtr_ShutSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "ShutSound");
			LabOvenDoor.NativeFieldInfoPtr_DoorMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "DoorMoveSpeed");
			LabOvenDoor.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "clickOffset");
			LabOvenDoor.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "isMoving");
			LabOvenDoor.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684789);
			LabOvenDoor.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684790);
			LabOvenDoor.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684791);
			LabOvenDoor.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684792);
			LabOvenDoor.NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684793);
			LabOvenDoor.NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684794);
			LabOvenDoor.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684795);
			LabOvenDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684796);
			LabOvenDoor.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684797);
			LabOvenDoor.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684798);
			LabOvenDoor.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684799);
			LabOvenDoor.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684800);
			LabOvenDoor.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684801);
			LabOvenDoor.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684802);
			LabOvenDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100684803);
		}

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x0600AEB6 RID: 44726 RVA: 0x002B9EB4 File Offset: 0x002B80B4
		// (set) Token: 0x0600AEB7 RID: 44727 RVA: 0x002B9EF0 File Offset: 0x002B80F0
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x0600AEB8 RID: 44728 RVA: 0x002B9F30 File Offset: 0x002B8130
		// (set) Token: 0x0600AEB9 RID: 44729 RVA: 0x002B9F6C File Offset: 0x002B816C
		public unsafe float TargetPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29977, RefRangeEnd = 29988, XrefRangeStart = 29977, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x0600AEBA RID: 44730 RVA: 0x002B9FAC File Offset: 0x002B81AC
		// (set) Token: 0x0600AEBB RID: 44731 RVA: 0x002B9FE8 File Offset: 0x002B81E8
		public unsafe float ActualPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59852, RefRangeEnd = 59853, XrefRangeStart = 59852, XrefRangeEnd = 59853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AEBC RID: 44732 RVA: 0x002BA028 File Offset: 0x002B8228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302563, XrefRangeEnd = 302581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEBD RID: 44733 RVA: 0x002BA05C File Offset: 0x002B825C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302581, XrefRangeEnd = 302595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEBE RID: 44734 RVA: 0x002BA090 File Offset: 0x002B8290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302595, XrefRangeEnd = 302603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEBF RID: 44735 RVA: 0x002BA0C4 File Offset: 0x002B82C4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 299126, RefRangeEnd = 299141, XrefRangeStart = 299126, XrefRangeEnd = 299141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEC0 RID: 44736 RVA: 0x002BA104 File Offset: 0x002B8304
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 302605, RefRangeEnd = 302623, XrefRangeStart = 302603, XrefRangeEnd = 302605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(float newPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEC1 RID: 44737 RVA: 0x002BA144 File Offset: 0x002B8344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302623, XrefRangeEnd = 302626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEC2 RID: 44738 RVA: 0x002BA184 File Offset: 0x002B8384
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302639, RefRangeEnd = 302641, XrefRangeStart = 302626, XrefRangeEnd = 302639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AEC3 RID: 44739 RVA: 0x002BA1C0 File Offset: 0x002B83C0
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEC4 RID: 44740 RVA: 0x002BA1F4 File Offset: 0x002B83F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302641, XrefRangeEnd = 302644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEC5 RID: 44741 RVA: 0x00055D5F File Offset: 0x00053F5F
		public LabOvenDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x0600AEC6 RID: 44742 RVA: 0x002BA230 File Offset: 0x002B8430
		// (set) Token: 0x0600AEC7 RID: 44743 RVA: 0x00055D68 File Offset: 0x00053F68
		public unsafe static float HIT_OFFSET_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MAX, (void*)(&value));
			}
		}

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x0600AEC8 RID: 44744 RVA: 0x002BA24C File Offset: 0x002B844C
		// (set) Token: 0x0600AEC9 RID: 44745 RVA: 0x00055D76 File Offset: 0x00053F76
		public unsafe static float HIT_OFFSET_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MIN, (void*)(&value));
			}
		}

		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x0600AECA RID: 44746 RVA: 0x002BA268 File Offset: 0x002B8468
		// (set) Token: 0x0600AECB RID: 44747 RVA: 0x00055D84 File Offset: 0x00053F84
		public unsafe static float DOOR_ANGLE_CLOSED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_CLOSED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_CLOSED, (void*)(&value));
			}
		}

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x0600AECC RID: 44748 RVA: 0x002BA284 File Offset: 0x002B8484
		// (set) Token: 0x0600AECD RID: 44749 RVA: 0x00055D92 File Offset: 0x00053F92
		public unsafe static float DOOR_ANGLE_OPEN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_OPEN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_OPEN, (void*)(&value));
			}
		}

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x0600AECE RID: 44750 RVA: 0x002BA2A0 File Offset: 0x002B84A0
		// (set) Token: 0x0600AECF RID: 44751 RVA: 0x00055DA0 File Offset: 0x00053FA0
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x0600AED0 RID: 44752 RVA: 0x002BA2C8 File Offset: 0x002B84C8
		// (set) Token: 0x0600AED1 RID: 44753 RVA: 0x00055DBB File Offset: 0x00053FBB
		public unsafe float _TargetPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__TargetPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__TargetPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x0600AED2 RID: 44754 RVA: 0x002BA2F0 File Offset: 0x002B84F0
		// (set) Token: 0x0600AED3 RID: 44755 RVA: 0x00055DD6 File Offset: 0x00053FD6
		public unsafe float _ActualPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__ActualPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__ActualPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x0600AED4 RID: 44756 RVA: 0x002BA318 File Offset: 0x002B8518
		// (set) Token: 0x0600AED5 RID: 44757 RVA: 0x00055DF1 File Offset: 0x00053FF1
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x0600AED6 RID: 44758 RVA: 0x002BA348 File Offset: 0x002B8548
		// (set) Token: 0x0600AED7 RID: 44759 RVA: 0x00055E10 File Offset: 0x00054010
		public unsafe Transform Door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_Door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_Door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x0600AED8 RID: 44760 RVA: 0x002BA378 File Offset: 0x002B8578
		// (set) Token: 0x0600AED9 RID: 44761 RVA: 0x00055E2F File Offset: 0x0005402F
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x0600AEDA RID: 44762 RVA: 0x002BA3A8 File Offset: 0x002B85A8
		// (set) Token: 0x0600AEDB RID: 44763 RVA: 0x00055E4E File Offset: 0x0005404E
		public unsafe AnimationCurve HitMapCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HitMapCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HitMapCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x0600AEDC RID: 44764 RVA: 0x002BA3D8 File Offset: 0x002B85D8
		// (set) Token: 0x0600AEDD RID: 44765 RVA: 0x00055E6D File Offset: 0x0005406D
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x0600AEDE RID: 44766 RVA: 0x002BA408 File Offset: 0x002B8608
		// (set) Token: 0x0600AEDF RID: 44767 RVA: 0x00055E8C File Offset: 0x0005408C
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x0600AEE0 RID: 44768 RVA: 0x002BA438 File Offset: 0x002B8638
		// (set) Token: 0x0600AEE1 RID: 44769 RVA: 0x00055EAB File Offset: 0x000540AB
		public unsafe AudioSourceController ShutSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_ShutSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_ShutSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x0600AEE2 RID: 44770 RVA: 0x002BA468 File Offset: 0x002B8668
		// (set) Token: 0x0600AEE3 RID: 44771 RVA: 0x00055ECA File Offset: 0x000540CA
		public unsafe float DoorMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_DoorMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_DoorMoveSpeed)) = value;
			}
		}

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x0600AEE4 RID: 44772 RVA: 0x002BA490 File Offset: 0x002B8690
		// (set) Token: 0x0600AEE5 RID: 44773 RVA: 0x00055EE5 File Offset: 0x000540E5
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x0600AEE6 RID: 44774 RVA: 0x002BA4B8 File Offset: 0x002B86B8
		// (set) Token: 0x0600AEE7 RID: 44775 RVA: 0x00055F00 File Offset: 0x00054100
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x0400759D RID: 30109
		private static readonly IntPtr NativeFieldInfoPtr_HIT_OFFSET_MAX;

		// Token: 0x0400759E RID: 30110
		private static readonly IntPtr NativeFieldInfoPtr_HIT_OFFSET_MIN;

		// Token: 0x0400759F RID: 30111
		private static readonly IntPtr NativeFieldInfoPtr_DOOR_ANGLE_CLOSED;

		// Token: 0x040075A0 RID: 30112
		private static readonly IntPtr NativeFieldInfoPtr_DOOR_ANGLE_OPEN;

		// Token: 0x040075A1 RID: 30113
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x040075A2 RID: 30114
		private static readonly IntPtr NativeFieldInfoPtr__TargetPosition_k__BackingField;

		// Token: 0x040075A3 RID: 30115
		private static readonly IntPtr NativeFieldInfoPtr__ActualPosition_k__BackingField;

		// Token: 0x040075A4 RID: 30116
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x040075A5 RID: 30117
		private static readonly IntPtr NativeFieldInfoPtr_Door;

		// Token: 0x040075A6 RID: 30118
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x040075A7 RID: 30119
		private static readonly IntPtr NativeFieldInfoPtr_HitMapCurve;

		// Token: 0x040075A8 RID: 30120
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x040075A9 RID: 30121
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x040075AA RID: 30122
		private static readonly IntPtr NativeFieldInfoPtr_ShutSound;

		// Token: 0x040075AB RID: 30123
		private static readonly IntPtr NativeFieldInfoPtr_DoorMoveSpeed;

		// Token: 0x040075AC RID: 30124
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x040075AD RID: 30125
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x040075AE RID: 30126
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x040075AF RID: 30127
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x040075B0 RID: 30128
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0;

		// Token: 0x040075B1 RID: 30129
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0;

		// Token: 0x040075B2 RID: 30130
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0;

		// Token: 0x040075B3 RID: 30131
		private static readonly IntPtr NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0;

		// Token: 0x040075B4 RID: 30132
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040075B5 RID: 30133
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040075B6 RID: 30134
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x040075B7 RID: 30135
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x040075B8 RID: 30136
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x040075B9 RID: 30137
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x040075BA RID: 30138
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x040075BB RID: 30139
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x040075BC RID: 30140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
