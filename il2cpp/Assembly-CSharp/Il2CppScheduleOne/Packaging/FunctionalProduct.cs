using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x0200056B RID: 1387
	public class FunctionalProduct : Draggable
	{
		// Token: 0x060079F8 RID: 31224 RVA: 0x0020D4AC File Offset: 0x0020B6AC
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalProduct()
		{
			Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalProduct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr);
			FunctionalProduct.NativeFieldInfoPtr_ClampZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "ClampZ");
			FunctionalProduct.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "AlignmentPoint");
			FunctionalProduct.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "Visuals");
			FunctionalProduct.NativeFieldInfoPtr_startLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "startLocalPos");
			FunctionalProduct.NativeFieldInfoPtr_lowestMaxZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "lowestMaxZ");
			FunctionalProduct.NativeFieldInfoPtr__VelocityCalculator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "<VelocityCalculator>k__BackingField");
			FunctionalProduct.NativeMethodInfoPtr_get_VelocityCalculator_Public_get_SmoothedVelocityCalculator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678552);
			FunctionalProduct.NativeMethodInfoPtr_set_VelocityCalculator_Private_set_Void_SmoothedVelocityCalculator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678553);
			FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_ItemInstance_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678554);
			FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678555);
			FunctionalProduct.NativeMethodInfoPtr_InitializeVisuals_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678556);
			FunctionalProduct.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678557);
			FunctionalProduct.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678558);
			FunctionalProduct.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678559);
			FunctionalProduct.NativeMethodInfoPtr_Clamp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678560);
			FunctionalProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678561);
		}

		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x060079F9 RID: 31225 RVA: 0x0020D61C File Offset: 0x0020B81C
		// (set) Token: 0x060079FA RID: 31226 RVA: 0x0020D65C File Offset: 0x0020B85C
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_get_VelocityCalculator_Public_get_SmoothedVelocityCalculator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_set_VelocityCalculator_Private_set_Void_SmoothedVelocityCalculator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x0020D6A0 File Offset: 0x0020B8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233690, XrefRangeEnd = 233708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(PackagingStation station, ItemInstance item, Transform alignment, bool align = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_ItemInstance_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079FC RID: 31228 RVA: 0x0020D720 File Offset: 0x0020B920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233708, XrefRangeEnd = 233725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079FD RID: 31229 RVA: 0x0020D770 File Offset: 0x0020B970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233725, XrefRangeEnd = 233733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeVisuals(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_InitializeVisuals_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079FE RID: 31230 RVA: 0x0020D7C0 File Offset: 0x0020B9C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233746, RefRangeEnd = 233748, XrefRangeStart = 233733, XrefRangeEnd = 233746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTo(Transform alignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079FF RID: 31231 RVA: 0x0020D804 File Offset: 0x0020BA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233748, XrefRangeEnd = 233749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A00 RID: 31232 RVA: 0x0020D840 File Offset: 0x0020BA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233749, XrefRangeEnd = 233761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A01 RID: 31233 RVA: 0x0020D87C File Offset: 0x0020BA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233761, XrefRangeEnd = 233772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_Clamp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A02 RID: 31234 RVA: 0x0020D8B0 File Offset: 0x0020BAB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233773, RefRangeEnd = 233775, XrefRangeStart = 233772, XrefRangeEnd = 233773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A03 RID: 31235 RVA: 0x0003A162 File Offset: 0x00038362
		public FunctionalProduct(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x06007A04 RID: 31236 RVA: 0x0020D8EC File Offset: 0x0020BAEC
		// (set) Token: 0x06007A05 RID: 31237 RVA: 0x0003A16B File Offset: 0x0003836B
		public unsafe bool ClampZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_ClampZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_ClampZ)) = value;
			}
		}

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x06007A06 RID: 31238 RVA: 0x0020D914 File Offset: 0x0020BB14
		// (set) Token: 0x06007A07 RID: 31239 RVA: 0x0003A186 File Offset: 0x00038386
		public unsafe Transform AlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_AlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x06007A08 RID: 31240 RVA: 0x0020D944 File Offset: 0x0020BB44
		// (set) Token: 0x06007A09 RID: 31241 RVA: 0x0003A1A5 File Offset: 0x000383A5
		public unsafe FilledPackagingVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x06007A0A RID: 31242 RVA: 0x0020D974 File Offset: 0x0020BB74
		// (set) Token: 0x06007A0B RID: 31243 RVA: 0x0003A1C4 File Offset: 0x000383C4
		public unsafe Vector3 startLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_startLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_startLocalPos)) = value;
			}
		}

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x06007A0C RID: 31244 RVA: 0x0020D99C File Offset: 0x0020BB9C
		// (set) Token: 0x06007A0D RID: 31245 RVA: 0x0003A1DF File Offset: 0x000383DF
		public unsafe float lowestMaxZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_lowestMaxZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_lowestMaxZ)) = value;
			}
		}

		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x06007A0E RID: 31246 RVA: 0x0020D9C4 File Offset: 0x0020BBC4
		// (set) Token: 0x06007A0F RID: 31247 RVA: 0x0003A1FA File Offset: 0x000383FA
		public unsafe SmoothedVelocityCalculator _VelocityCalculator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr__VelocityCalculator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr__VelocityCalculator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052F8 RID: 21240
		private static readonly IntPtr NativeFieldInfoPtr_ClampZ;

		// Token: 0x040052F9 RID: 21241
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x040052FA RID: 21242
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040052FB RID: 21243
		private static readonly IntPtr NativeFieldInfoPtr_startLocalPos;

		// Token: 0x040052FC RID: 21244
		private static readonly IntPtr NativeFieldInfoPtr_lowestMaxZ;

		// Token: 0x040052FD RID: 21245
		private static readonly IntPtr NativeFieldInfoPtr__VelocityCalculator_k__BackingField;

		// Token: 0x040052FE RID: 21246
		private static readonly IntPtr NativeMethodInfoPtr_get_VelocityCalculator_Public_get_SmoothedVelocityCalculator_0;

		// Token: 0x040052FF RID: 21247
		private static readonly IntPtr NativeMethodInfoPtr_set_VelocityCalculator_Private_set_Void_SmoothedVelocityCalculator_0;

		// Token: 0x04005300 RID: 21248
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_ItemInstance_Transform_Boolean_0;

		// Token: 0x04005301 RID: 21249
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04005302 RID: 21250
		private static readonly IntPtr NativeMethodInfoPtr_InitializeVisuals_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04005303 RID: 21251
		private static readonly IntPtr NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0;

		// Token: 0x04005304 RID: 21252
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0;

		// Token: 0x04005305 RID: 21253
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x04005306 RID: 21254
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Private_Void_0;

		// Token: 0x04005307 RID: 21255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
