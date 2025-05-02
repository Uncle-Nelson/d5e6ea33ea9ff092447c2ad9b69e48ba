using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000742 RID: 1858
	public class LabStand : MonoBehaviour
	{
		// Token: 0x0600AC54 RID: 44116 RVA: 0x002B0618 File Offset: 0x002AE818
		// Note: this type is marked as 'beforefieldinit'.
		static LabStand()
		{
			Il2CppClassPointerStore<LabStand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabStand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabStand>.NativeClassPtr);
			LabStand.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "<Interactable>k__BackingField");
			LabStand.NativeFieldInfoPtr__CurrentPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "<CurrentPosition>k__BackingField");
			LabStand.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "MoveSpeed");
			LabStand.NativeFieldInfoPtr_FunnelEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "FunnelEnabled");
			LabStand.NativeFieldInfoPtr_FunnelThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "FunnelThreshold");
			LabStand.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "Anim");
			LabStand.NativeFieldInfoPtr_GripTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "GripTransform");
			LabStand.NativeFieldInfoPtr_SpinnyThingy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "SpinnyThingy");
			LabStand.NativeFieldInfoPtr_RaisedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "RaisedTransform");
			LabStand.NativeFieldInfoPtr_LoweredTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "LoweredTransform");
			LabStand.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "PlaneNormal");
			LabStand.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "HandleClickable");
			LabStand.NativeFieldInfoPtr_Funnel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "Funnel");
			LabStand.NativeFieldInfoPtr_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "Highlight");
			LabStand.NativeFieldInfoPtr_LowerSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "LowerSound");
			LabStand.NativeFieldInfoPtr_RaiseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "RaiseSound");
			LabStand.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "clickOffset");
			LabStand.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "isMoving");
			LabStand.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684457);
			LabStand.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684458);
			LabStand.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684459);
			LabStand.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684460);
			LabStand.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684461);
			LabStand.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684462);
			LabStand.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684463);
			LabStand.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684464);
			LabStand.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684465);
			LabStand.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684466);
			LabStand.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684467);
			LabStand.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684468);
			LabStand.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684469);
			LabStand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684470);
		}

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x0600AC55 RID: 44117 RVA: 0x002B08C8 File Offset: 0x002AEAC8
		// (set) Token: 0x0600AC56 RID: 44118 RVA: 0x002B0904 File Offset: 0x002AEB04
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x0600AC57 RID: 44119 RVA: 0x002B0944 File Offset: 0x002AEB44
		// (set) Token: 0x0600AC58 RID: 44120 RVA: 0x002B0980 File Offset: 0x002AEB80
		public unsafe float CurrentPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AC59 RID: 44121 RVA: 0x002B09C0 File Offset: 0x002AEBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299013, XrefRangeEnd = 299033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC5A RID: 44122 RVA: 0x002B09F4 File Offset: 0x002AEBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299033, XrefRangeEnd = 299047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC5B RID: 44123 RVA: 0x002B0A28 File Offset: 0x002AEC28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299070, RefRangeEnd = 299071, XrefRangeStart = 299047, XrefRangeEnd = 299070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC5C RID: 44124 RVA: 0x002B0A5C File Offset: 0x002AEC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299071, XrefRangeEnd = 299075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSound(float difference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref difference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC5D RID: 44125 RVA: 0x002B0A9C File Offset: 0x002AEC9C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 29977, RefRangeEnd = 29988, XrefRangeStart = 29977, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC5E RID: 44126 RVA: 0x002B0ADC File Offset: 0x002AECDC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 299078, RefRangeEnd = 299084, XrefRangeStart = 299075, XrefRangeEnd = 299078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC5F RID: 44127 RVA: 0x002B0B1C File Offset: 0x002AED1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299084, XrefRangeEnd = 299087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC60 RID: 44128 RVA: 0x002B0B5C File Offset: 0x002AED5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299100, RefRangeEnd = 299102, XrefRangeStart = 299087, XrefRangeEnd = 299100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AC61 RID: 44129 RVA: 0x002B0B98 File Offset: 0x002AED98
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC62 RID: 44130 RVA: 0x002B0BCC File Offset: 0x002AEDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299102, XrefRangeEnd = 299105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabStand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabStand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC63 RID: 44131 RVA: 0x00054C0E File Offset: 0x00052E0E
		public LabStand(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x0600AC64 RID: 44132 RVA: 0x002B0C08 File Offset: 0x002AEE08
		// (set) Token: 0x0600AC65 RID: 44133 RVA: 0x00054C17 File Offset: 0x00052E17
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x17003558 RID: 13656
		// (get) Token: 0x0600AC66 RID: 44134 RVA: 0x002B0C30 File Offset: 0x002AEE30
		// (set) Token: 0x0600AC67 RID: 44135 RVA: 0x00054C32 File Offset: 0x00052E32
		public unsafe float _CurrentPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__CurrentPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__CurrentPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x0600AC68 RID: 44136 RVA: 0x002B0C58 File Offset: 0x002AEE58
		// (set) Token: 0x0600AC69 RID: 44137 RVA: 0x00054C4D File Offset: 0x00052E4D
		public unsafe float MoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_MoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_MoveSpeed)) = value;
			}
		}

		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0600AC6A RID: 44138 RVA: 0x002B0C80 File Offset: 0x002AEE80
		// (set) Token: 0x0600AC6B RID: 44139 RVA: 0x00054C68 File Offset: 0x00052E68
		public unsafe bool FunnelEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelEnabled)) = value;
			}
		}

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x0600AC6C RID: 44140 RVA: 0x002B0CA8 File Offset: 0x002AEEA8
		// (set) Token: 0x0600AC6D RID: 44141 RVA: 0x00054C83 File Offset: 0x00052E83
		public unsafe float FunnelThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelThreshold)) = value;
			}
		}

		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x0600AC6E RID: 44142 RVA: 0x002B0CD0 File Offset: 0x002AEED0
		// (set) Token: 0x0600AC6F RID: 44143 RVA: 0x00054C9E File Offset: 0x00052E9E
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x0600AC70 RID: 44144 RVA: 0x002B0D00 File Offset: 0x002AEF00
		// (set) Token: 0x0600AC71 RID: 44145 RVA: 0x00054CBD File Offset: 0x00052EBD
		public unsafe Transform GripTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_GripTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_GripTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x0600AC72 RID: 44146 RVA: 0x002B0D30 File Offset: 0x002AEF30
		// (set) Token: 0x0600AC73 RID: 44147 RVA: 0x00054CDC File Offset: 0x00052EDC
		public unsafe Transform SpinnyThingy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_SpinnyThingy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_SpinnyThingy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x0600AC74 RID: 44148 RVA: 0x002B0D60 File Offset: 0x002AEF60
		// (set) Token: 0x0600AC75 RID: 44149 RVA: 0x00054CFB File Offset: 0x00052EFB
		public unsafe Transform RaisedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaisedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaisedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x0600AC76 RID: 44150 RVA: 0x002B0D90 File Offset: 0x002AEF90
		// (set) Token: 0x0600AC77 RID: 44151 RVA: 0x00054D1A File Offset: 0x00052F1A
		public unsafe Transform LoweredTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LoweredTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LoweredTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x0600AC78 RID: 44152 RVA: 0x002B0DC0 File Offset: 0x002AEFC0
		// (set) Token: 0x0600AC79 RID: 44153 RVA: 0x00054D39 File Offset: 0x00052F39
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x0600AC7A RID: 44154 RVA: 0x002B0DF0 File Offset: 0x002AEFF0
		// (set) Token: 0x0600AC7B RID: 44155 RVA: 0x00054D58 File Offset: 0x00052F58
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x0600AC7C RID: 44156 RVA: 0x002B0E20 File Offset: 0x002AF020
		// (set) Token: 0x0600AC7D RID: 44157 RVA: 0x00054D77 File Offset: 0x00052F77
		public unsafe Transform Funnel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Funnel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Funnel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x0600AC7E RID: 44158 RVA: 0x002B0E50 File Offset: 0x002AF050
		// (set) Token: 0x0600AC7F RID: 44159 RVA: 0x00054D96 File Offset: 0x00052F96
		public unsafe GameObject Highlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Highlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x0600AC80 RID: 44160 RVA: 0x002B0E80 File Offset: 0x002AF080
		// (set) Token: 0x0600AC81 RID: 44161 RVA: 0x00054DB5 File Offset: 0x00052FB5
		public unsafe AudioSourceController LowerSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LowerSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LowerSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x0600AC82 RID: 44162 RVA: 0x002B0EB0 File Offset: 0x002AF0B0
		// (set) Token: 0x0600AC83 RID: 44163 RVA: 0x00054DD4 File Offset: 0x00052FD4
		public unsafe AudioSourceController RaiseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaiseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaiseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x0600AC84 RID: 44164 RVA: 0x002B0EE0 File Offset: 0x002AF0E0
		// (set) Token: 0x0600AC85 RID: 44165 RVA: 0x00054DF3 File Offset: 0x00052FF3
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x0600AC86 RID: 44166 RVA: 0x002B0F08 File Offset: 0x002AF108
		// (set) Token: 0x0600AC87 RID: 44167 RVA: 0x00054E0E File Offset: 0x0005300E
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x040073DC RID: 29660
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x040073DD RID: 29661
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPosition_k__BackingField;

		// Token: 0x040073DE RID: 29662
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeed;

		// Token: 0x040073DF RID: 29663
		private static readonly IntPtr NativeFieldInfoPtr_FunnelEnabled;

		// Token: 0x040073E0 RID: 29664
		private static readonly IntPtr NativeFieldInfoPtr_FunnelThreshold;

		// Token: 0x040073E1 RID: 29665
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x040073E2 RID: 29666
		private static readonly IntPtr NativeFieldInfoPtr_GripTransform;

		// Token: 0x040073E3 RID: 29667
		private static readonly IntPtr NativeFieldInfoPtr_SpinnyThingy;

		// Token: 0x040073E4 RID: 29668
		private static readonly IntPtr NativeFieldInfoPtr_RaisedTransform;

		// Token: 0x040073E5 RID: 29669
		private static readonly IntPtr NativeFieldInfoPtr_LoweredTransform;

		// Token: 0x040073E6 RID: 29670
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x040073E7 RID: 29671
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x040073E8 RID: 29672
		private static readonly IntPtr NativeFieldInfoPtr_Funnel;

		// Token: 0x040073E9 RID: 29673
		private static readonly IntPtr NativeFieldInfoPtr_Highlight;

		// Token: 0x040073EA RID: 29674
		private static readonly IntPtr NativeFieldInfoPtr_LowerSound;

		// Token: 0x040073EB RID: 29675
		private static readonly IntPtr NativeFieldInfoPtr_RaiseSound;

		// Token: 0x040073EC RID: 29676
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x040073ED RID: 29677
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x040073EE RID: 29678
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x040073EF RID: 29679
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x040073F0 RID: 29680
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0;

		// Token: 0x040073F1 RID: 29681
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0;

		// Token: 0x040073F2 RID: 29682
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040073F3 RID: 29683
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040073F4 RID: 29684
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x040073F5 RID: 29685
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0;

		// Token: 0x040073F6 RID: 29686
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x040073F7 RID: 29687
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x040073F8 RID: 29688
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x040073F9 RID: 29689
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x040073FA RID: 29690
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x040073FB RID: 29691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
