using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppVLB
{
	// Token: 0x02000098 RID: 152
	[Serializable]
	public class RaymarchingQuality : Object
	{
		// Token: 0x060009C0 RID: 2496 RVA: 0x0008E9B4 File Offset: 0x0008CBB4
		// Note: this type is marked as 'beforefieldinit'.
		static RaymarchingQuality()
		{
			Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "RaymarchingQuality");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr);
			RaymarchingQuality.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "name");
			RaymarchingQuality.NativeFieldInfoPtr_stepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "stepCount");
			RaymarchingQuality.NativeFieldInfoPtr__UniqueID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "_UniqueID");
			RaymarchingQuality.NativeFieldInfoPtr_ms_DefaultInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "ms_DefaultInstance");
			RaymarchingQuality.NativeFieldInfoPtr_kRandomUniqueIdMinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "kRandomUniqueIdMinRange");
			RaymarchingQuality.NativeMethodInfoPtr_get_uniqueID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100664365);
			RaymarchingQuality.NativeMethodInfoPtr_get_hasValidUniqueID_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100664366);
			RaymarchingQuality.NativeMethodInfoPtr_get_defaultInstance_Public_Static_get_RaymarchingQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100664367);
			RaymarchingQuality.NativeMethodInfoPtr__ctor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100664368);
			RaymarchingQuality.NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100664369);
			RaymarchingQuality.NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100664370);
			RaymarchingQuality.NativeMethodInfoPtr_HasRaymarchingQualityWithSameUniqueID_Private_Static_Boolean_Il2CppReferenceArray_1_RaymarchingQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100664371);
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0008EAD4 File Offset: 0x0008CCD4
		public unsafe int uniqueID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_get_uniqueID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0008EB10 File Offset: 0x0008CD10
		public unsafe bool hasValidUniqueID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_get_hasValidUniqueID_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0008EB4C File Offset: 0x0008CD4C
		public unsafe static RaymarchingQuality defaultInstance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80821, XrefRangeEnd = 80825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_get_defaultInstance_Public_Static_get_RaymarchingQuality_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr3) : null;
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0008EB80 File Offset: 0x0008CD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80825, XrefRangeEnd = 80830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaymarchingQuality(int uniqueID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref uniqueID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr__ctor_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0008EBC8 File Offset: 0x0008CDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80830, XrefRangeEnd = 80839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaymarchingQuality New()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr3) : null;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0008EBFC File Offset: 0x0008CDFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80848, RefRangeEnd = 80851, XrefRangeStart = 80839, XrefRangeEnd = 80848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaymarchingQuality New(string name, int forcedUniqueID, int stepCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forcedUniqueID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stepCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr3) : null;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0008EC5C File Offset: 0x0008CE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80851, XrefRangeEnd = 80852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasRaymarchingQualityWithSameUniqueID(Il2CppReferenceArray<RaymarchingQuality> values, int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_HasRaymarchingQualityWithSameUniqueID_Private_Static_Boolean_Il2CppReferenceArray_1_RaymarchingQuality_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0000738C File Offset: 0x0000558C
		public RaymarchingQuality(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x0008ECAC File Offset: 0x0008CEAC
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x00007395 File Offset: 0x00005595
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x0008ECD4 File Offset: 0x0008CED4
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x000073B4 File Offset: 0x000055B4
		public unsafe int stepCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr_stepCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr_stepCount)) = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x0008ECFC File Offset: 0x0008CEFC
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x000073CF File Offset: 0x000055CF
		public unsafe int _UniqueID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr__UniqueID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr__UniqueID)) = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0008ED24 File Offset: 0x0008CF24
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x000073EA File Offset: 0x000055EA
		public unsafe static RaymarchingQuality ms_DefaultInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RaymarchingQuality.NativeFieldInfoPtr_ms_DefaultInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RaymarchingQuality.NativeFieldInfoPtr_ms_DefaultInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0008ED4C File Offset: 0x0008CF4C
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x000073FC File Offset: 0x000055FC
		public unsafe static int kRandomUniqueIdMinRange
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RaymarchingQuality.NativeFieldInfoPtr_kRandomUniqueIdMinRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RaymarchingQuality.NativeFieldInfoPtr_kRandomUniqueIdMinRange, (void*)(&value));
			}
		}

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeFieldInfoPtr_stepCount;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeFieldInfoPtr__UniqueID;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeFieldInfoPtr_ms_DefaultInstance;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeFieldInfoPtr_kRandomUniqueIdMinRange;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_get_uniqueID_Public_get_Int32_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_get_hasValidUniqueID_Public_get_Boolean_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultInstance_Public_Static_get_RaymarchingQuality_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_String_Int32_Int32_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_HasRaymarchingQualityWithSameUniqueID_Private_Static_Boolean_Il2CppReferenceArray_1_RaymarchingQuality_Int32_0;
	}
}
