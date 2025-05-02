using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005B1 RID: 1457
	[Serializable]
	public class WeedDefinition : ProductDefinition
	{
		// Token: 0x06008010 RID: 32784 RVA: 0x00224418 File Offset: 0x00222618
		// Note: this type is marked as 'beforefieldinit'.
		static WeedDefinition()
		{
			Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "WeedDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr);
			WeedDefinition.NativeFieldInfoPtr_MainMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "MainMat");
			WeedDefinition.NativeFieldInfoPtr_SecondaryMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "SecondaryMat");
			WeedDefinition.NativeFieldInfoPtr_LeafMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "LeafMat");
			WeedDefinition.NativeFieldInfoPtr_StemMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "StemMat");
			WeedDefinition.NativeFieldInfoPtr_appearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "appearance");
			WeedDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679382);
			WeedDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_WeedAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679383);
			WeedDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679384);
			WeedDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_WeedAppearanceSettings_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679385);
			WeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679386);
		}

		// Token: 0x06008011 RID: 32785 RVA: 0x00224510 File Offset: 0x00222710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243914, XrefRangeEnd = 243918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008012 RID: 32786 RVA: 0x00224568 File Offset: 0x00222768
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243952, RefRangeEnd = 243954, XrefRangeStart = 243918, XrefRangeEnd = 243952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Property> properties, List<EDrugType> drugTypes, WeedAppearanceSettings _appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_appearance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_WeedAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008013 RID: 32787 RVA: 0x002245D0 File Offset: 0x002227D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243954, XrefRangeEnd = 243970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ProductData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductData>(intPtr3) : null;
		}

		// Token: 0x06008014 RID: 32788 RVA: 0x0022461C File Offset: 0x0022281C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244049, RefRangeEnd = 244051, XrefRangeStart = 243970, XrefRangeEnd = 244049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WeedAppearanceSettings GetAppearanceSettings(List<Property> properties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_WeedAppearanceSettings_List_1_Property_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeedAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x06008015 RID: 32789 RVA: 0x00224660 File Offset: 0x00222860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008016 RID: 32790 RVA: 0x0003CB61 File Offset: 0x0003AD61
		public WeedDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026AF RID: 9903
		// (get) Token: 0x06008017 RID: 32791 RVA: 0x0022469C File Offset: 0x0022289C
		// (set) Token: 0x06008018 RID: 32792 RVA: 0x0003CB6A File Offset: 0x0003AD6A
		public unsafe Material MainMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_MainMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_MainMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B0 RID: 9904
		// (get) Token: 0x06008019 RID: 32793 RVA: 0x002246CC File Offset: 0x002228CC
		// (set) Token: 0x0600801A RID: 32794 RVA: 0x0003CB89 File Offset: 0x0003AD89
		public unsafe Material SecondaryMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_SecondaryMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_SecondaryMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B1 RID: 9905
		// (get) Token: 0x0600801B RID: 32795 RVA: 0x002246FC File Offset: 0x002228FC
		// (set) Token: 0x0600801C RID: 32796 RVA: 0x0003CBA8 File Offset: 0x0003ADA8
		public unsafe Material LeafMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_LeafMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_LeafMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B2 RID: 9906
		// (get) Token: 0x0600801D RID: 32797 RVA: 0x0022472C File Offset: 0x0022292C
		// (set) Token: 0x0600801E RID: 32798 RVA: 0x0003CBC7 File Offset: 0x0003ADC7
		public unsafe Material StemMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_StemMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_StemMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B3 RID: 9907
		// (get) Token: 0x0600801F RID: 32799 RVA: 0x0022475C File Offset: 0x0022295C
		// (set) Token: 0x06008020 RID: 32800 RVA: 0x0003CBE6 File Offset: 0x0003ADE6
		public unsafe WeedAppearanceSettings appearance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_appearance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeedAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_appearance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005740 RID: 22336
		private static readonly IntPtr NativeFieldInfoPtr_MainMat;

		// Token: 0x04005741 RID: 22337
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryMat;

		// Token: 0x04005742 RID: 22338
		private static readonly IntPtr NativeFieldInfoPtr_LeafMat;

		// Token: 0x04005743 RID: 22339
		private static readonly IntPtr NativeFieldInfoPtr_StemMat;

		// Token: 0x04005744 RID: 22340
		private static readonly IntPtr NativeFieldInfoPtr_appearance;

		// Token: 0x04005745 RID: 22341
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005746 RID: 22342
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_WeedAppearanceSettings_0;

		// Token: 0x04005747 RID: 22343
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0;

		// Token: 0x04005748 RID: 22344
		private static readonly IntPtr NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_WeedAppearanceSettings_List_1_Property_0;

		// Token: 0x04005749 RID: 22345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ADE RID: 2782
		[ObfuscatedName("ScheduleOne.Product.WeedDefinition+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D4FE RID: 54526 RVA: 0x0032CAF8 File Offset: 0x0032ACF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr);
				WeedDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, "<>9");
				WeedDefinition.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, "<>9__8_0");
				WeedDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, 100679388);
				WeedDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, 100679389);
			}

			// Token: 0x0600D4FF RID: 54527 RVA: 0x0032CB74 File Offset: 0x0032AD74
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D500 RID: 54528 RVA: 0x0032CBB0 File Offset: 0x0032ADB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAppearanceSettings_b__8_0(Property x, Property y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D501 RID: 54529 RVA: 0x00067A64 File Offset: 0x00065C64
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041FE RID: 16894
			// (get) Token: 0x0600D502 RID: 54530 RVA: 0x0032CC10 File Offset: 0x0032AE10
			// (set) Token: 0x0600D503 RID: 54531 RVA: 0x00067A6D File Offset: 0x00065C6D
			public unsafe static WeedDefinition.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeedDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeedDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeedDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041FF RID: 16895
			// (get) Token: 0x0600D504 RID: 54532 RVA: 0x0032CC38 File Offset: 0x0032AE38
			// (set) Token: 0x0600D505 RID: 54533 RVA: 0x00067A7F File Offset: 0x00065C7F
			public unsafe static Comparison<Property> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeedDefinition.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Property>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeedDefinition.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F4C RID: 36684
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F4D RID: 36685
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04008F4E RID: 36686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F4F RID: 36687
			private static readonly IntPtr NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0;
		}
	}
}
