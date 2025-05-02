using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200040F RID: 1039
	[Serializable]
	public class CustomerAffinityData : Object
	{
		// Token: 0x06005A27 RID: 23079 RVA: 0x001A38FC File Offset: 0x001A1AFC
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerAffinityData()
		{
			Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "CustomerAffinityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr);
			CustomerAffinityData.NativeFieldInfoPtr_ProductAffinities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, "ProductAffinities");
			CustomerAffinityData.NativeMethodInfoPtr_CopyTo_Public_Void_CustomerAffinityData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, 100674780);
			CustomerAffinityData.NativeMethodInfoPtr_GetAffinity_Public_Single_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, 100674781);
			CustomerAffinityData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, 100674782);
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x001A397C File Offset: 0x001A1B7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190578, RefRangeEnd = 190579, XrefRangeStart = 190534, XrefRangeEnd = 190578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(CustomerAffinityData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.NativeMethodInfoPtr_CopyTo_Public_Void_CustomerAffinityData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x001A39C0 File Offset: 0x001A1BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190595, RefRangeEnd = 190596, XrefRangeStart = 190579, XrefRangeEnd = 190595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAffinity(EDrugType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.NativeMethodInfoPtr_GetAffinity_Public_Single_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x001A3A0C File Offset: 0x001A1C0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190604, RefRangeEnd = 190605, XrefRangeStart = 190596, XrefRangeEnd = 190604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerAffinityData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A2B RID: 23083 RVA: 0x0002A93F File Offset: 0x00028B3F
		public CustomerAffinityData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x06005A2C RID: 23084 RVA: 0x001A3A48 File Offset: 0x001A1C48
		// (set) Token: 0x06005A2D RID: 23085 RVA: 0x0002A948 File Offset: 0x00028B48
		public unsafe List<ProductTypeAffinity> ProductAffinities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.NativeFieldInfoPtr_ProductAffinities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductTypeAffinity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.NativeFieldInfoPtr_ProductAffinities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D90 RID: 15760
		private static readonly IntPtr NativeFieldInfoPtr_ProductAffinities;

		// Token: 0x04003D91 RID: 15761
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_CustomerAffinityData_0;

		// Token: 0x04003D92 RID: 15762
		private static readonly IntPtr NativeMethodInfoPtr_GetAffinity_Public_Single_EDrugType_0;

		// Token: 0x04003D93 RID: 15763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009E2 RID: 2530
		[ObfuscatedName("ScheduleOne.Economy.CustomerAffinityData+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600CD51 RID: 52561 RVA: 0x00317654 File Offset: 0x00315854
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr);
				CustomerAffinityData.__c__DisplayClass1_0.NativeFieldInfoPtr_affinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, "affinity");
				CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, 100674783);
				CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, 100674784);
				CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__1_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, 100674785);
			}

			// Token: 0x0600CD52 RID: 52562 RVA: 0x003176D0 File Offset: 0x003158D0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD53 RID: 52563 RVA: 0x0031770C File Offset: 0x0031590C
			[CallerCount(0)]
			public unsafe bool _CopyTo_b__0(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD54 RID: 52564 RVA: 0x0031775C File Offset: 0x0031595C
			[CallerCount(0)]
			public unsafe bool _CopyTo_b__1(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__1_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD55 RID: 52565 RVA: 0x00063DF6 File Offset: 0x00061FF6
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FED RID: 16365
			// (get) Token: 0x0600CD56 RID: 52566 RVA: 0x003177AC File Offset: 0x003159AC
			// (set) Token: 0x0600CD57 RID: 52567 RVA: 0x00063DFF File Offset: 0x00061FFF
			public unsafe ProductTypeAffinity affinity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass1_0.NativeFieldInfoPtr_affinity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductTypeAffinity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass1_0.NativeFieldInfoPtr_affinity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ABB RID: 35515
			private static readonly IntPtr NativeFieldInfoPtr_affinity;

			// Token: 0x04008ABC RID: 35516
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ABD RID: 35517
			private static readonly IntPtr NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_ProductTypeAffinity_0;

			// Token: 0x04008ABE RID: 35518
			private static readonly IntPtr NativeMethodInfoPtr__CopyTo_b__1_Internal_Boolean_ProductTypeAffinity_0;
		}

		// Token: 0x020009E3 RID: 2531
		[ObfuscatedName("ScheduleOne.Economy.CustomerAffinityData+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600CD58 RID: 52568 RVA: 0x003177DC File Offset: 0x003159DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr);
				CustomerAffinityData.__c__DisplayClass2_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr, "type");
				CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr, 100674786);
				CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr, 100674787);
			}

			// Token: 0x0600CD59 RID: 52569 RVA: 0x00317844 File Offset: 0x00315A44
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD5A RID: 52570 RVA: 0x00317880 File Offset: 0x00315A80
			[CallerCount(0)]
			public unsafe bool _GetAffinity_b__0(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD5B RID: 52571 RVA: 0x00063E1E File Offset: 0x0006201E
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FEE RID: 16366
			// (get) Token: 0x0600CD5C RID: 52572 RVA: 0x003178D0 File Offset: 0x00315AD0
			// (set) Token: 0x0600CD5D RID: 52573 RVA: 0x00063E27 File Offset: 0x00062027
			public unsafe EDrugType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass2_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass2_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x04008ABF RID: 35519
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04008AC0 RID: 35520
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AC1 RID: 35521
			private static readonly IntPtr NativeMethodInfoPtr__GetAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0;
		}
	}
}
