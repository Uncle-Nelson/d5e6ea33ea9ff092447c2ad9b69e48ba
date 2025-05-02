using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000564 RID: 1380
	public class FunctionalJar : FunctionalPackaging
	{
		// Token: 0x0600790F RID: 30991 RVA: 0x0020ACAC File Offset: 0x00208EAC
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalJar()
		{
			Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalJar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr);
			FunctionalJar.NativeFieldInfoPtr__HoveredCursor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "<HoveredCursor>k__BackingField");
			FunctionalJar.NativeFieldInfoPtr_Lid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "Lid");
			FunctionalJar.NativeFieldInfoPtr_LidStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidStartPoint");
			FunctionalJar.NativeFieldInfoPtr_LidSensor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidSensor");
			FunctionalJar.NativeFieldInfoPtr_LidCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidCollider");
			FunctionalJar.NativeFieldInfoPtr_FullyPackedBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "FullyPackedBlocker");
			FunctionalJar.NativeFieldInfoPtr_LidObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidObject");
			FunctionalJar.NativeFieldInfoPtr_lidPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "lidPosition");
			FunctionalJar.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678477);
			FunctionalJar.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678478);
			FunctionalJar.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_PackagingStation_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678479);
			FunctionalJar.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678480);
			FunctionalJar.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678481);
			FunctionalJar.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678482);
			FunctionalJar.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678483);
			FunctionalJar.NativeMethodInfoPtr_Seal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678484);
			FunctionalJar.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678485);
			FunctionalJar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678486);
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x06007910 RID: 30992 RVA: 0x0020AE44 File Offset: 0x00209044
		// (set) Token: 0x06007911 RID: 30993 RVA: 0x0020AE8C File Offset: 0x0020908C
		public unsafe override CursorManager.ECursorType HoveredCursor
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 60914, RefRangeEnd = 60954, XrefRangeStart = 60914, XrefRangeEnd = 60954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007912 RID: 30994 RVA: 0x0020AED8 File Offset: 0x002090D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232950, XrefRangeEnd = 232978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(PackagingStation _station, Transform alignment, bool align = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_PackagingStation_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007913 RID: 30995 RVA: 0x0020AF48 File Offset: 0x00209148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232978, XrefRangeEnd = 232987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007914 RID: 30996 RVA: 0x0020AF84 File Offset: 0x00209184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232987, XrefRangeEnd = 232991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EnableSealing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007915 RID: 30997 RVA: 0x0020AFC0 File Offset: 0x002091C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232991, XrefRangeEnd = 232992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x0020AFFC File Offset: 0x002091FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232992, XrefRangeEnd = 233003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007917 RID: 30999 RVA: 0x0020B04C File Offset: 0x0020924C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233003, XrefRangeEnd = 233020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Seal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_Seal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007918 RID: 31000 RVA: 0x0020B088 File Offset: 0x00209288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233020, XrefRangeEnd = 233023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FullyPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007919 RID: 31001 RVA: 0x0020B0C4 File Offset: 0x002092C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233023, XrefRangeEnd = 233026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalJar() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalJar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600791A RID: 31002 RVA: 0x00039774 File Offset: 0x00037974
		public FunctionalJar(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700249A RID: 9370
		// (get) Token: 0x0600791B RID: 31003 RVA: 0x0020B100 File Offset: 0x00209300
		// (set) Token: 0x0600791C RID: 31004 RVA: 0x0003977D File Offset: 0x0003797D
		public new unsafe CursorManager.ECursorType _HoveredCursor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr__HoveredCursor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr__HoveredCursor_k__BackingField)) = value;
			}
		}

		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x0600791D RID: 31005 RVA: 0x0020B128 File Offset: 0x00209328
		// (set) Token: 0x0600791E RID: 31006 RVA: 0x00039798 File Offset: 0x00037998
		public unsafe Draggable Lid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_Lid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_Lid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249C RID: 9372
		// (get) Token: 0x0600791F RID: 31007 RVA: 0x0020B158 File Offset: 0x00209358
		// (set) Token: 0x06007920 RID: 31008 RVA: 0x000397B7 File Offset: 0x000379B7
		public unsafe Transform LidStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249D RID: 9373
		// (get) Token: 0x06007921 RID: 31009 RVA: 0x0020B188 File Offset: 0x00209388
		// (set) Token: 0x06007922 RID: 31010 RVA: 0x000397D6 File Offset: 0x000379D6
		public unsafe Collider LidSensor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidSensor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidSensor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249E RID: 9374
		// (get) Token: 0x06007923 RID: 31011 RVA: 0x0020B1B8 File Offset: 0x002093B8
		// (set) Token: 0x06007924 RID: 31012 RVA: 0x000397F5 File Offset: 0x000379F5
		public unsafe Collider LidCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x06007925 RID: 31013 RVA: 0x0020B1E8 File Offset: 0x002093E8
		// (set) Token: 0x06007926 RID: 31014 RVA: 0x00039814 File Offset: 0x00037A14
		public unsafe GameObject FullyPackedBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_FullyPackedBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_FullyPackedBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x06007927 RID: 31015 RVA: 0x0020B218 File Offset: 0x00209418
		// (set) Token: 0x06007928 RID: 31016 RVA: 0x00039833 File Offset: 0x00037A33
		public unsafe GameObject LidObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x06007929 RID: 31017 RVA: 0x0020B248 File Offset: 0x00209448
		// (set) Token: 0x0600792A RID: 31018 RVA: 0x00039852 File Offset: 0x00037A52
		public unsafe Vector3 lidPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_lidPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_lidPosition)) = value;
			}
		}

		// Token: 0x0400526E RID: 21102
		private static readonly IntPtr NativeFieldInfoPtr__HoveredCursor_k__BackingField;

		// Token: 0x0400526F RID: 21103
		private static readonly IntPtr NativeFieldInfoPtr_Lid;

		// Token: 0x04005270 RID: 21104
		private static readonly IntPtr NativeFieldInfoPtr_LidStartPoint;

		// Token: 0x04005271 RID: 21105
		private static readonly IntPtr NativeFieldInfoPtr_LidSensor;

		// Token: 0x04005272 RID: 21106
		private static readonly IntPtr NativeFieldInfoPtr_LidCollider;

		// Token: 0x04005273 RID: 21107
		private static readonly IntPtr NativeFieldInfoPtr_FullyPackedBlocker;

		// Token: 0x04005274 RID: 21108
		private static readonly IntPtr NativeFieldInfoPtr_LidObject;

		// Token: 0x04005275 RID: 21109
		private static readonly IntPtr NativeFieldInfoPtr_lidPosition;

		// Token: 0x04005276 RID: 21110
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0;

		// Token: 0x04005277 RID: 21111
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0;

		// Token: 0x04005278 RID: 21112
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_PackagingStation_Transform_Boolean_0;

		// Token: 0x04005279 RID: 21113
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x0400527A RID: 21114
		private static readonly IntPtr NativeMethodInfoPtr_EnableSealing_Protected_Virtual_Void_0;

		// Token: 0x0400527B RID: 21115
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400527C RID: 21116
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_Void_Collider_0;

		// Token: 0x0400527D RID: 21117
		private static readonly IntPtr NativeMethodInfoPtr_Seal_Public_Virtual_Void_0;

		// Token: 0x0400527E RID: 21118
		private static readonly IntPtr NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0;

		// Token: 0x0400527F RID: 21119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
