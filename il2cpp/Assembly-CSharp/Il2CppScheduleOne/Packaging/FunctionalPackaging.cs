using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x0200056A RID: 1386
	public class FunctionalPackaging : Draggable
	{
		// Token: 0x060079C2 RID: 31170 RVA: 0x0020CA7C File Offset: 0x0020AC7C
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalPackaging()
		{
			Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalPackaging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr);
			FunctionalPackaging.NativeFieldInfoPtr__IsSealed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "<IsSealed>k__BackingField");
			FunctionalPackaging.NativeFieldInfoPtr__IsFull_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "<IsFull>k__BackingField");
			FunctionalPackaging.NativeFieldInfoPtr__ReachedOutput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "<ReachedOutput>k__BackingField");
			FunctionalPackaging.NativeFieldInfoPtr_SealInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "SealInstruction");
			FunctionalPackaging.NativeFieldInfoPtr_AutoEnableSealing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "AutoEnableSealing");
			FunctionalPackaging.NativeFieldInfoPtr_ProductContactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "ProductContactTime");
			FunctionalPackaging.NativeFieldInfoPtr_ProductContactMaxVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "ProductContactMaxVelocity");
			FunctionalPackaging.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "Definition");
			FunctionalPackaging.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "AlignmentPoint");
			FunctionalPackaging.NativeFieldInfoPtr_ProductAlignmentPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "ProductAlignmentPoints");
			FunctionalPackaging.NativeFieldInfoPtr_SealSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "SealSound");
			FunctionalPackaging.NativeFieldInfoPtr_PackedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "PackedProducts");
			FunctionalPackaging.NativeFieldInfoPtr_onFullyPacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "onFullyPacked");
			FunctionalPackaging.NativeFieldInfoPtr_onSealed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "onSealed");
			FunctionalPackaging.NativeFieldInfoPtr_onReachOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "onReachOutput");
			FunctionalPackaging.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "station");
			FunctionalPackaging.NativeFieldInfoPtr_productContactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "productContactTime");
			FunctionalPackaging.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "VelocityCalculator");
			FunctionalPackaging.NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678536);
			FunctionalPackaging.NativeMethodInfoPtr_set_IsSealed_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678537);
			FunctionalPackaging.NativeMethodInfoPtr_get_IsFull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678538);
			FunctionalPackaging.NativeMethodInfoPtr_set_IsFull_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678539);
			FunctionalPackaging.NativeMethodInfoPtr_get_ReachedOutput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678540);
			FunctionalPackaging.NativeMethodInfoPtr_set_ReachedOutput_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678541);
			FunctionalPackaging.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678542);
			FunctionalPackaging.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678543);
			FunctionalPackaging.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678544);
			FunctionalPackaging.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678545);
			FunctionalPackaging.NativeMethodInfoPtr_PackProduct_Protected_Virtual_New_Void_FunctionalProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678546);
			FunctionalPackaging.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678547);
			FunctionalPackaging.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678548);
			FunctionalPackaging.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678549);
			FunctionalPackaging.NativeMethodInfoPtr_Seal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678550);
			FunctionalPackaging.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678551);
		}

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x060079C3 RID: 31171 RVA: 0x0020CD54 File Offset: 0x0020AF54
		// (set) Token: 0x060079C4 RID: 31172 RVA: 0x0020CD90 File Offset: 0x0020AF90
		public unsafe bool IsSealed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_set_IsSealed_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x060079C5 RID: 31173 RVA: 0x0020CDD0 File Offset: 0x0020AFD0
		// (set) Token: 0x060079C6 RID: 31174 RVA: 0x0020CE0C File Offset: 0x0020B00C
		public unsafe bool IsFull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_get_IsFull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_set_IsFull_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x060079C7 RID: 31175 RVA: 0x0020CE4C File Offset: 0x0020B04C
		// (set) Token: 0x060079C8 RID: 31176 RVA: 0x0020CE88 File Offset: 0x0020B088
		public unsafe bool ReachedOutput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_get_ReachedOutput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_set_ReachedOutput_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060079C9 RID: 31177 RVA: 0x0020CEC8 File Offset: 0x0020B0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233483, XrefRangeEnd = 233495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(PackagingStation _station, Transform alignment, bool align = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079CA RID: 31178 RVA: 0x0020CF38 File Offset: 0x0020B138
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233525, RefRangeEnd = 233528, XrefRangeStart = 233495, XrefRangeEnd = 233525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTo(Transform alignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079CB RID: 31179 RVA: 0x0020CF7C File Offset: 0x0020B17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233528, XrefRangeEnd = 233533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079CC RID: 31180 RVA: 0x0020CFB8 File Offset: 0x0020B1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233533, XrefRangeEnd = 233564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079CD RID: 31181 RVA: 0x0020CFF4 File Offset: 0x0020B1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233564, XrefRangeEnd = 233583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PackProduct(FunctionalProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_PackProduct_Protected_Virtual_New_Void_FunctionalProduct_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x0020D044 File Offset: 0x0020B244
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233601, RefRangeEnd = 233603, XrefRangeStart = 233583, XrefRangeEnd = 233601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FullyPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079CF RID: 31183 RVA: 0x0020D080 File Offset: 0x0020B280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233643, RefRangeEnd = 233644, XrefRangeStart = 233603, XrefRangeEnd = 233643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079D0 RID: 31184 RVA: 0x0020D0D0 File Offset: 0x0020B2D0
		[CallerCount(0)]
		public unsafe virtual void EnableSealing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079D1 RID: 31185 RVA: 0x0020D10C File Offset: 0x0020B30C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233667, RefRangeEnd = 233669, XrefRangeStart = 233644, XrefRangeEnd = 233667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Seal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_Seal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079D2 RID: 31186 RVA: 0x0020D148 File Offset: 0x0020B348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233688, RefRangeEnd = 233690, XrefRangeStart = 233669, XrefRangeEnd = 233688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalPackaging() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079D3 RID: 31187 RVA: 0x00039F43 File Offset: 0x00038143
		public FunctionalPackaging(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024DB RID: 9435
		// (get) Token: 0x060079D4 RID: 31188 RVA: 0x0020D184 File Offset: 0x0020B384
		// (set) Token: 0x060079D5 RID: 31189 RVA: 0x00039F4C File Offset: 0x0003814C
		public unsafe bool _IsSealed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsSealed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsSealed_k__BackingField)) = value;
			}
		}

		// Token: 0x170024DC RID: 9436
		// (get) Token: 0x060079D6 RID: 31190 RVA: 0x0020D1AC File Offset: 0x0020B3AC
		// (set) Token: 0x060079D7 RID: 31191 RVA: 0x00039F67 File Offset: 0x00038167
		public unsafe bool _IsFull_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsFull_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsFull_k__BackingField)) = value;
			}
		}

		// Token: 0x170024DD RID: 9437
		// (get) Token: 0x060079D8 RID: 31192 RVA: 0x0020D1D4 File Offset: 0x0020B3D4
		// (set) Token: 0x060079D9 RID: 31193 RVA: 0x00039F82 File Offset: 0x00038182
		public unsafe bool _ReachedOutput_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__ReachedOutput_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__ReachedOutput_k__BackingField)) = value;
			}
		}

		// Token: 0x170024DE RID: 9438
		// (get) Token: 0x060079DA RID: 31194 RVA: 0x0020D1FC File Offset: 0x0020B3FC
		// (set) Token: 0x060079DB RID: 31195 RVA: 0x00039F9D File Offset: 0x0003819D
		public unsafe string SealInstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealInstruction);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealInstruction), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024DF RID: 9439
		// (get) Token: 0x060079DC RID: 31196 RVA: 0x0020D224 File Offset: 0x0020B424
		// (set) Token: 0x060079DD RID: 31197 RVA: 0x00039FBC File Offset: 0x000381BC
		public unsafe bool AutoEnableSealing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AutoEnableSealing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AutoEnableSealing)) = value;
			}
		}

		// Token: 0x170024E0 RID: 9440
		// (get) Token: 0x060079DE RID: 31198 RVA: 0x0020D24C File Offset: 0x0020B44C
		// (set) Token: 0x060079DF RID: 31199 RVA: 0x00039FD7 File Offset: 0x000381D7
		public unsafe float ProductContactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactTime)) = value;
			}
		}

		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x060079E0 RID: 31200 RVA: 0x0020D274 File Offset: 0x0020B474
		// (set) Token: 0x060079E1 RID: 31201 RVA: 0x00039FF2 File Offset: 0x000381F2
		public unsafe float ProductContactMaxVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactMaxVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactMaxVelocity)) = value;
			}
		}

		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x060079E2 RID: 31202 RVA: 0x0020D29C File Offset: 0x0020B49C
		// (set) Token: 0x060079E3 RID: 31203 RVA: 0x0003A00D File Offset: 0x0003820D
		public unsafe PackagingDefinition Definition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_Definition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E3 RID: 9443
		// (get) Token: 0x060079E4 RID: 31204 RVA: 0x0020D2CC File Offset: 0x0020B4CC
		// (set) Token: 0x060079E5 RID: 31205 RVA: 0x0003A02C File Offset: 0x0003822C
		public unsafe Transform AlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E4 RID: 9444
		// (get) Token: 0x060079E6 RID: 31206 RVA: 0x0020D2FC File Offset: 0x0020B4FC
		// (set) Token: 0x060079E7 RID: 31207 RVA: 0x0003A04B File Offset: 0x0003824B
		public unsafe Il2CppReferenceArray<Transform> ProductAlignmentPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductAlignmentPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductAlignmentPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x060079E8 RID: 31208 RVA: 0x0020D32C File Offset: 0x0020B52C
		// (set) Token: 0x060079E9 RID: 31209 RVA: 0x0003A06A File Offset: 0x0003826A
		public unsafe AudioSourceController SealSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x060079EA RID: 31210 RVA: 0x0020D35C File Offset: 0x0020B55C
		// (set) Token: 0x060079EB RID: 31211 RVA: 0x0003A089 File Offset: 0x00038289
		public unsafe List<FunctionalProduct> PackedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_PackedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_PackedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x060079EC RID: 31212 RVA: 0x0020D38C File Offset: 0x0020B58C
		// (set) Token: 0x060079ED RID: 31213 RVA: 0x0003A0A8 File Offset: 0x000382A8
		public unsafe Action onFullyPacked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onFullyPacked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onFullyPacked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x060079EE RID: 31214 RVA: 0x0020D3BC File Offset: 0x0020B5BC
		// (set) Token: 0x060079EF RID: 31215 RVA: 0x0003A0C7 File Offset: 0x000382C7
		public unsafe Action onSealed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onSealed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onSealed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x060079F0 RID: 31216 RVA: 0x0020D3EC File Offset: 0x0020B5EC
		// (set) Token: 0x060079F1 RID: 31217 RVA: 0x0003A0E6 File Offset: 0x000382E6
		public unsafe Action onReachOutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onReachOutput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onReachOutput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x060079F2 RID: 31218 RVA: 0x0020D41C File Offset: 0x0020B61C
		// (set) Token: 0x060079F3 RID: 31219 RVA: 0x0003A105 File Offset: 0x00038305
		public unsafe PackagingStation station
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_station);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x060079F4 RID: 31220 RVA: 0x0020D44C File Offset: 0x0020B64C
		// (set) Token: 0x060079F5 RID: 31221 RVA: 0x0003A124 File Offset: 0x00038324
		public unsafe Dictionary<FunctionalProduct, float> productContactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_productContactTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FunctionalProduct, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_productContactTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x060079F6 RID: 31222 RVA: 0x0020D47C File Offset: 0x0020B67C
		// (set) Token: 0x060079F7 RID: 31223 RVA: 0x0003A143 File Offset: 0x00038343
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052D6 RID: 21206
		private static readonly IntPtr NativeFieldInfoPtr__IsSealed_k__BackingField;

		// Token: 0x040052D7 RID: 21207
		private static readonly IntPtr NativeFieldInfoPtr__IsFull_k__BackingField;

		// Token: 0x040052D8 RID: 21208
		private static readonly IntPtr NativeFieldInfoPtr__ReachedOutput_k__BackingField;

		// Token: 0x040052D9 RID: 21209
		private static readonly IntPtr NativeFieldInfoPtr_SealInstruction;

		// Token: 0x040052DA RID: 21210
		private static readonly IntPtr NativeFieldInfoPtr_AutoEnableSealing;

		// Token: 0x040052DB RID: 21211
		private static readonly IntPtr NativeFieldInfoPtr_ProductContactTime;

		// Token: 0x040052DC RID: 21212
		private static readonly IntPtr NativeFieldInfoPtr_ProductContactMaxVelocity;

		// Token: 0x040052DD RID: 21213
		private static readonly IntPtr NativeFieldInfoPtr_Definition;

		// Token: 0x040052DE RID: 21214
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x040052DF RID: 21215
		private static readonly IntPtr NativeFieldInfoPtr_ProductAlignmentPoints;

		// Token: 0x040052E0 RID: 21216
		private static readonly IntPtr NativeFieldInfoPtr_SealSound;

		// Token: 0x040052E1 RID: 21217
		private static readonly IntPtr NativeFieldInfoPtr_PackedProducts;

		// Token: 0x040052E2 RID: 21218
		private static readonly IntPtr NativeFieldInfoPtr_onFullyPacked;

		// Token: 0x040052E3 RID: 21219
		private static readonly IntPtr NativeFieldInfoPtr_onSealed;

		// Token: 0x040052E4 RID: 21220
		private static readonly IntPtr NativeFieldInfoPtr_onReachOutput;

		// Token: 0x040052E5 RID: 21221
		private static readonly IntPtr NativeFieldInfoPtr_station;

		// Token: 0x040052E6 RID: 21222
		private static readonly IntPtr NativeFieldInfoPtr_productContactTime;

		// Token: 0x040052E7 RID: 21223
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x040052E8 RID: 21224
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0;

		// Token: 0x040052E9 RID: 21225
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSealed_Protected_set_Void_Boolean_0;

		// Token: 0x040052EA RID: 21226
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFull_Public_get_Boolean_0;

		// Token: 0x040052EB RID: 21227
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFull_Protected_set_Void_Boolean_0;

		// Token: 0x040052EC RID: 21228
		private static readonly IntPtr NativeMethodInfoPtr_get_ReachedOutput_Public_get_Boolean_0;

		// Token: 0x040052ED RID: 21229
		private static readonly IntPtr NativeMethodInfoPtr_set_ReachedOutput_Protected_set_Void_Boolean_0;

		// Token: 0x040052EE RID: 21230
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_Transform_Boolean_0;

		// Token: 0x040052EF RID: 21231
		private static readonly IntPtr NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0;

		// Token: 0x040052F0 RID: 21232
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x040052F1 RID: 21233
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0;

		// Token: 0x040052F2 RID: 21234
		private static readonly IntPtr NativeMethodInfoPtr_PackProduct_Protected_Virtual_New_Void_FunctionalProduct_0;

		// Token: 0x040052F3 RID: 21235
		private static readonly IntPtr NativeMethodInfoPtr_FullyPacked_Protected_Virtual_New_Void_0;

		// Token: 0x040052F4 RID: 21236
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0;

		// Token: 0x040052F5 RID: 21237
		private static readonly IntPtr NativeMethodInfoPtr_EnableSealing_Protected_Virtual_New_Void_0;

		// Token: 0x040052F6 RID: 21238
		private static readonly IntPtr NativeMethodInfoPtr_Seal_Public_Virtual_New_Void_0;

		// Token: 0x040052F7 RID: 21239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
