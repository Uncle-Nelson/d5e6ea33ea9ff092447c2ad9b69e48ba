using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200074A RID: 1866
	public class LabOvenWireTray : MonoBehaviour
	{
		// Token: 0x0600AF04 RID: 44804 RVA: 0x002BA914 File Offset: 0x002B8B14
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenWireTray()
		{
			Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenWireTray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr);
			LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "HIT_OFFSET_MAX");
			LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "HIT_OFFSET_MIN");
			LabOvenWireTray.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "<Interactable>k__BackingField");
			LabOvenWireTray.NativeFieldInfoPtr__TargetPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "<TargetPosition>k__BackingField");
			LabOvenWireTray.NativeFieldInfoPtr__ActualPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "<ActualPosition>k__BackingField");
			LabOvenWireTray.NativeFieldInfoPtr_Tray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "Tray");
			LabOvenWireTray.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "PlaneNormal");
			LabOvenWireTray.NativeFieldInfoPtr_ClosedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "ClosedPosition");
			LabOvenWireTray.NativeFieldInfoPtr_OpenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "OpenPosition");
			LabOvenWireTray.NativeFieldInfoPtr_OvenDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "OvenDoor");
			LabOvenWireTray.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "MoveSpeed");
			LabOvenWireTray.NativeFieldInfoPtr_DoorClampCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "DoorClampCurve");
			LabOvenWireTray.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "clickOffset");
			LabOvenWireTray.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, "isMoving");
			LabOvenWireTray.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684808);
			LabOvenWireTray.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684809);
			LabOvenWireTray.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684810);
			LabOvenWireTray.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684811);
			LabOvenWireTray.NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684812);
			LabOvenWireTray.NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684813);
			LabOvenWireTray.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684814);
			LabOvenWireTray.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684815);
			LabOvenWireTray.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684816);
			LabOvenWireTray.NativeMethodInfoPtr_ClampAngle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684817);
			LabOvenWireTray.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684818);
			LabOvenWireTray.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684819);
			LabOvenWireTray.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684820);
			LabOvenWireTray.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684821);
			LabOvenWireTray.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684822);
			LabOvenWireTray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr, 100684823);
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x0600AF05 RID: 44805 RVA: 0x002BAB9C File Offset: 0x002B8D9C
		// (set) Token: 0x0600AF06 RID: 44806 RVA: 0x002BABD8 File Offset: 0x002B8DD8
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x0600AF07 RID: 44807 RVA: 0x002BAC18 File Offset: 0x002B8E18
		// (set) Token: 0x0600AF08 RID: 44808 RVA: 0x002BAC54 File Offset: 0x002B8E54
		public unsafe float TargetPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x0600AF09 RID: 44809 RVA: 0x002BAC94 File Offset: 0x002B8E94
		// (set) Token: 0x0600AF0A RID: 44810 RVA: 0x002BACD0 File Offset: 0x002B8ED0
		public unsafe float ActualPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59852, RefRangeEnd = 59853, XrefRangeStart = 59852, XrefRangeEnd = 59853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AF0B RID: 44811 RVA: 0x002BAD10 File Offset: 0x002B8F10
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF0C RID: 44812 RVA: 0x002BAD44 File Offset: 0x002B8F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302656, XrefRangeEnd = 302675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF0D RID: 44813 RVA: 0x002BAD78 File Offset: 0x002B8F78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302684, RefRangeEnd = 302685, XrefRangeStart = 302675, XrefRangeEnd = 302684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF0E RID: 44814 RVA: 0x002BADAC File Offset: 0x002B8FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302685, XrefRangeEnd = 302691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_ClampAngle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF0F RID: 44815 RVA: 0x002BADE0 File Offset: 0x002B8FE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF10 RID: 44816 RVA: 0x002BAE20 File Offset: 0x002B9020
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 29977, RefRangeEnd = 29988, XrefRangeStart = 29977, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF11 RID: 44817 RVA: 0x002BAE60 File Offset: 0x002B9060
		[CallerCount(0)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF12 RID: 44818 RVA: 0x002BAEA0 File Offset: 0x002B90A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302704, RefRangeEnd = 302705, XrefRangeStart = 302691, XrefRangeEnd = 302704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AF13 RID: 44819 RVA: 0x002BAEDC File Offset: 0x002B90DC
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF14 RID: 44820 RVA: 0x002BAF10 File Offset: 0x002B9110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302705, XrefRangeEnd = 302708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenWireTray() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenWireTray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenWireTray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF15 RID: 44821 RVA: 0x00056069 File Offset: 0x00054269
		public LabOvenWireTray(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003643 RID: 13891
		// (get) Token: 0x0600AF16 RID: 44822 RVA: 0x002BAF4C File Offset: 0x002B914C
		// (set) Token: 0x0600AF17 RID: 44823 RVA: 0x00056072 File Offset: 0x00054272
		public unsafe static float HIT_OFFSET_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MAX, (void*)(&value));
			}
		}

		// Token: 0x17003644 RID: 13892
		// (get) Token: 0x0600AF18 RID: 44824 RVA: 0x002BAF68 File Offset: 0x002B9168
		// (set) Token: 0x0600AF19 RID: 44825 RVA: 0x00056080 File Offset: 0x00054280
		public unsafe static float HIT_OFFSET_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenWireTray.NativeFieldInfoPtr_HIT_OFFSET_MIN, (void*)(&value));
			}
		}

		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x0600AF1A RID: 44826 RVA: 0x002BAF84 File Offset: 0x002B9184
		// (set) Token: 0x0600AF1B RID: 44827 RVA: 0x0005608E File Offset: 0x0005428E
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x0600AF1C RID: 44828 RVA: 0x002BAFAC File Offset: 0x002B91AC
		// (set) Token: 0x0600AF1D RID: 44829 RVA: 0x000560A9 File Offset: 0x000542A9
		public unsafe float _TargetPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__TargetPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__TargetPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x0600AF1E RID: 44830 RVA: 0x002BAFD4 File Offset: 0x002B91D4
		// (set) Token: 0x0600AF1F RID: 44831 RVA: 0x000560C4 File Offset: 0x000542C4
		public unsafe float _ActualPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__ActualPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr__ActualPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x0600AF20 RID: 44832 RVA: 0x002BAFFC File Offset: 0x002B91FC
		// (set) Token: 0x0600AF21 RID: 44833 RVA: 0x000560DF File Offset: 0x000542DF
		public unsafe Transform Tray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_Tray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_Tray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x0600AF22 RID: 44834 RVA: 0x002BB02C File Offset: 0x002B922C
		// (set) Token: 0x0600AF23 RID: 44835 RVA: 0x000560FE File Offset: 0x000542FE
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x0600AF24 RID: 44836 RVA: 0x002BB05C File Offset: 0x002B925C
		// (set) Token: 0x0600AF25 RID: 44837 RVA: 0x0005611D File Offset: 0x0005431D
		public unsafe Transform ClosedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_ClosedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_ClosedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x0600AF26 RID: 44838 RVA: 0x002BB08C File Offset: 0x002B928C
		// (set) Token: 0x0600AF27 RID: 44839 RVA: 0x0005613C File Offset: 0x0005433C
		public unsafe Transform OpenPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_OpenPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_OpenPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x0600AF28 RID: 44840 RVA: 0x002BB0BC File Offset: 0x002B92BC
		// (set) Token: 0x0600AF29 RID: 44841 RVA: 0x0005615B File Offset: 0x0005435B
		public unsafe LabOvenDoor OvenDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_OvenDoor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenDoor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_OvenDoor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x0600AF2A RID: 44842 RVA: 0x002BB0EC File Offset: 0x002B92EC
		// (set) Token: 0x0600AF2B RID: 44843 RVA: 0x0005617A File Offset: 0x0005437A
		public unsafe float MoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_MoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_MoveSpeed)) = value;
			}
		}

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x0600AF2C RID: 44844 RVA: 0x002BB114 File Offset: 0x002B9314
		// (set) Token: 0x0600AF2D RID: 44845 RVA: 0x00056195 File Offset: 0x00054395
		public unsafe AnimationCurve DoorClampCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_DoorClampCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_DoorClampCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x0600AF2E RID: 44846 RVA: 0x002BB144 File Offset: 0x002B9344
		// (set) Token: 0x0600AF2F RID: 44847 RVA: 0x000561B4 File Offset: 0x000543B4
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x0600AF30 RID: 44848 RVA: 0x002BB16C File Offset: 0x002B936C
		// (set) Token: 0x0600AF31 RID: 44849 RVA: 0x000561CF File Offset: 0x000543CF
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenWireTray.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x040075CC RID: 30156
		private static readonly IntPtr NativeFieldInfoPtr_HIT_OFFSET_MAX;

		// Token: 0x040075CD RID: 30157
		private static readonly IntPtr NativeFieldInfoPtr_HIT_OFFSET_MIN;

		// Token: 0x040075CE RID: 30158
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x040075CF RID: 30159
		private static readonly IntPtr NativeFieldInfoPtr__TargetPosition_k__BackingField;

		// Token: 0x040075D0 RID: 30160
		private static readonly IntPtr NativeFieldInfoPtr__ActualPosition_k__BackingField;

		// Token: 0x040075D1 RID: 30161
		private static readonly IntPtr NativeFieldInfoPtr_Tray;

		// Token: 0x040075D2 RID: 30162
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x040075D3 RID: 30163
		private static readonly IntPtr NativeFieldInfoPtr_ClosedPosition;

		// Token: 0x040075D4 RID: 30164
		private static readonly IntPtr NativeFieldInfoPtr_OpenPosition;

		// Token: 0x040075D5 RID: 30165
		private static readonly IntPtr NativeFieldInfoPtr_OvenDoor;

		// Token: 0x040075D6 RID: 30166
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeed;

		// Token: 0x040075D7 RID: 30167
		private static readonly IntPtr NativeFieldInfoPtr_DoorClampCurve;

		// Token: 0x040075D8 RID: 30168
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x040075D9 RID: 30169
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x040075DA RID: 30170
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x040075DB RID: 30171
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x040075DC RID: 30172
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0;

		// Token: 0x040075DD RID: 30173
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0;

		// Token: 0x040075DE RID: 30174
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0;

		// Token: 0x040075DF RID: 30175
		private static readonly IntPtr NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0;

		// Token: 0x040075E0 RID: 30176
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040075E1 RID: 30177
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040075E2 RID: 30178
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x040075E3 RID: 30179
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Void_0;

		// Token: 0x040075E4 RID: 30180
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x040075E5 RID: 30181
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x040075E6 RID: 30182
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x040075E7 RID: 30183
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x040075E8 RID: 30184
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x040075E9 RID: 30185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
