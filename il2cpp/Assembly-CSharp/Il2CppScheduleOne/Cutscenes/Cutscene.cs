using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Cutscenes
{
	// Token: 0x0200047E RID: 1150
	public class Cutscene : MonoBehaviour
	{
		// Token: 0x060063B3 RID: 25523 RVA: 0x001C407C File Offset: 0x001C227C
		// Note: this type is marked as 'beforefieldinit'.
		static Cutscene()
		{
			Il2CppClassPointerStore<Cutscene>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cutscenes", "Cutscene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cutscene>.NativeClassPtr);
			Cutscene.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "<IsPlaying>k__BackingField");
			Cutscene.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "Name");
			Cutscene.NativeFieldInfoPtr_DisablePlayerControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "DisablePlayerControl");
			Cutscene.NativeFieldInfoPtr_OverrideFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "OverrideFOV");
			Cutscene.NativeFieldInfoPtr_CameraFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "CameraFOV");
			Cutscene.NativeFieldInfoPtr_CameraControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "CameraControl");
			Cutscene.NativeFieldInfoPtr_onPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "onPlay");
			Cutscene.NativeFieldInfoPtr_onEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "onEnd");
			Cutscene.NativeFieldInfoPtr_animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "animation");
			Cutscene.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675939);
			Cutscene.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675940);
			Cutscene.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675941);
			Cutscene.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675942);
			Cutscene.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675943);
			Cutscene.NativeMethodInfoPtr_InvokeEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675944);
			Cutscene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675945);
		}

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x060063B4 RID: 25524 RVA: 0x001C41EC File Offset: 0x001C23EC
		// (set) Token: 0x060063B5 RID: 25525 RVA: 0x001C4228 File Offset: 0x001C2428
		public unsafe bool IsPlaying
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x001C4268 File Offset: 0x001C2468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203801, XrefRangeEnd = 203805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cutscene.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x001C42A4 File Offset: 0x001C24A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203805, XrefRangeEnd = 203818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x001C42D8 File Offset: 0x001C24D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203861, RefRangeEnd = 203862, XrefRangeStart = 203818, XrefRangeEnd = 203861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cutscene.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x001C4314 File Offset: 0x001C2514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203862, XrefRangeEnd = 203908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_InvokeEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x001C4348 File Offset: 0x001C2548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203908, XrefRangeEnd = 203913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cutscene() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cutscene>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063BB RID: 25531 RVA: 0x0002F214 File Offset: 0x0002D414
		public Cutscene(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x060063BC RID: 25532 RVA: 0x001C4384 File Offset: 0x001C2584
		// (set) Token: 0x060063BD RID: 25533 RVA: 0x0002F21D File Offset: 0x0002D41D
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x060063BE RID: 25534 RVA: 0x001C43AC File Offset: 0x001C25AC
		// (set) Token: 0x060063BF RID: 25535 RVA: 0x0002F238 File Offset: 0x0002D438
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x060063C0 RID: 25536 RVA: 0x001C43D4 File Offset: 0x001C25D4
		// (set) Token: 0x060063C1 RID: 25537 RVA: 0x0002F257 File Offset: 0x0002D457
		public unsafe bool DisablePlayerControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_DisablePlayerControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_DisablePlayerControl)) = value;
			}
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x060063C2 RID: 25538 RVA: 0x001C43FC File Offset: 0x001C25FC
		// (set) Token: 0x060063C3 RID: 25539 RVA: 0x0002F272 File Offset: 0x0002D472
		public unsafe bool OverrideFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_OverrideFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_OverrideFOV)) = value;
			}
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x060063C4 RID: 25540 RVA: 0x001C4424 File Offset: 0x001C2624
		// (set) Token: 0x060063C5 RID: 25541 RVA: 0x0002F28D File Offset: 0x0002D48D
		public unsafe float CameraFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraFOV)) = value;
			}
		}

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x060063C6 RID: 25542 RVA: 0x001C444C File Offset: 0x001C264C
		// (set) Token: 0x060063C7 RID: 25543 RVA: 0x0002F2A8 File Offset: 0x0002D4A8
		public unsafe Transform CameraControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x060063C8 RID: 25544 RVA: 0x001C447C File Offset: 0x001C267C
		// (set) Token: 0x060063C9 RID: 25545 RVA: 0x0002F2C7 File Offset: 0x0002D4C7
		public unsafe UnityEvent onPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onPlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onPlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x060063CA RID: 25546 RVA: 0x001C44AC File Offset: 0x001C26AC
		// (set) Token: 0x060063CB RID: 25547 RVA: 0x0002F2E6 File Offset: 0x0002D4E6
		public unsafe UnityEvent onEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x060063CC RID: 25548 RVA: 0x001C44DC File Offset: 0x001C26DC
		// (set) Token: 0x060063CD RID: 25549 RVA: 0x0002F305 File Offset: 0x0002D505
		public unsafe Animation animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400440D RID: 17421
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x0400440E RID: 17422
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400440F RID: 17423
		private static readonly IntPtr NativeFieldInfoPtr_DisablePlayerControl;

		// Token: 0x04004410 RID: 17424
		private static readonly IntPtr NativeFieldInfoPtr_OverrideFOV;

		// Token: 0x04004411 RID: 17425
		private static readonly IntPtr NativeFieldInfoPtr_CameraFOV;

		// Token: 0x04004412 RID: 17426
		private static readonly IntPtr NativeFieldInfoPtr_CameraControl;

		// Token: 0x04004413 RID: 17427
		private static readonly IntPtr NativeFieldInfoPtr_onPlay;

		// Token: 0x04004414 RID: 17428
		private static readonly IntPtr NativeFieldInfoPtr_onEnd;

		// Token: 0x04004415 RID: 17429
		private static readonly IntPtr NativeFieldInfoPtr_animation;

		// Token: 0x04004416 RID: 17430
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04004417 RID: 17431
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0;

		// Token: 0x04004418 RID: 17432
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004419 RID: 17433
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400441A RID: 17434
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0;

		// Token: 0x0400441B RID: 17435
		private static readonly IntPtr NativeMethodInfoPtr_InvokeEnd_Public_Void_0;

		// Token: 0x0400441C RID: 17436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
