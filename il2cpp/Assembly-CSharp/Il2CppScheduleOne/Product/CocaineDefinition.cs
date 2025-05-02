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
	// Token: 0x02000598 RID: 1432
	[Serializable]
	public class CocaineDefinition : ProductDefinition
	{
		// Token: 0x06007DDD RID: 32221 RVA: 0x0021B0DC File Offset: 0x002192DC
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineDefinition()
		{
			Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "CocaineDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr);
			CocaineDefinition.NativeFieldInfoPtr_RockMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, "RockMaterial");
			CocaineDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, "<AppearanceSettings>k__BackingField");
			CocaineDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679028);
			CocaineDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679029);
			CocaineDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679030);
			CocaineDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679031);
			CocaineDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679032);
			CocaineDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_CocaineAppearanceSettings_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679033);
			CocaineDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679034);
		}

		// Token: 0x1700261E RID: 9758
		// (get) Token: 0x06007DDE RID: 32222 RVA: 0x0021B1C0 File Offset: 0x002193C0
		// (set) Token: 0x06007DDF RID: 32223 RVA: 0x0021B200 File Offset: 0x00219400
		public unsafe CocaineAppearanceSettings AppearanceSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238404, XrefRangeEnd = 238405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007DE0 RID: 32224 RVA: 0x0021B244 File Offset: 0x00219444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238405, XrefRangeEnd = 238449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007DE1 RID: 32225 RVA: 0x0021B29C File Offset: 0x0021949C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238468, RefRangeEnd = 238470, XrefRangeStart = 238449, XrefRangeEnd = 238468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Property> properties, List<EDrugType> drugTypes, CocaineAppearanceSettings _appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_appearance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DE2 RID: 32226 RVA: 0x0021B304 File Offset: 0x00219504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238470, XrefRangeEnd = 238486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ProductData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductData>(intPtr3) : null;
		}

		// Token: 0x06007DE3 RID: 32227 RVA: 0x0021B350 File Offset: 0x00219550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238562, RefRangeEnd = 238564, XrefRangeStart = 238486, XrefRangeEnd = 238562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CocaineAppearanceSettings GetAppearanceSettings(List<Property> properties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_CocaineAppearanceSettings_List_1_Property_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x06007DE4 RID: 32228 RVA: 0x0021B394 File Offset: 0x00219594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238564, XrefRangeEnd = 238565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DE5 RID: 32229 RVA: 0x0003BDA6 File Offset: 0x00039FA6
		public CocaineDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x06007DE6 RID: 32230 RVA: 0x0021B3D0 File Offset: 0x002195D0
		// (set) Token: 0x06007DE7 RID: 32231 RVA: 0x0003BDAF File Offset: 0x00039FAF
		public unsafe Material RockMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr_RockMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr_RockMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x06007DE8 RID: 32232 RVA: 0x0021B400 File Offset: 0x00219600
		// (set) Token: 0x06007DE9 RID: 32233 RVA: 0x0003BDCE File Offset: 0x00039FCE
		public unsafe CocaineAppearanceSettings _AppearanceSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005595 RID: 21909
		private static readonly IntPtr NativeFieldInfoPtr_RockMaterial;

		// Token: 0x04005596 RID: 21910
		private static readonly IntPtr NativeFieldInfoPtr__AppearanceSettings_k__BackingField;

		// Token: 0x04005597 RID: 21911
		private static readonly IntPtr NativeMethodInfoPtr_get_AppearanceSettings_Public_get_CocaineAppearanceSettings_0;

		// Token: 0x04005598 RID: 21912
		private static readonly IntPtr NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_CocaineAppearanceSettings_0;

		// Token: 0x04005599 RID: 21913
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x0400559A RID: 21914
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_CocaineAppearanceSettings_0;

		// Token: 0x0400559B RID: 21915
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0;

		// Token: 0x0400559C RID: 21916
		private static readonly IntPtr NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_CocaineAppearanceSettings_List_1_Property_0;

		// Token: 0x0400559D RID: 21917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AC5 RID: 2757
		[ObfuscatedName("ScheduleOne.Product.CocaineDefinition+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D41F RID: 54303 RVA: 0x0032A440 File Offset: 0x00328640
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr);
				CocaineDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, "<>9");
				CocaineDefinition.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, "<>9__8_0");
				CocaineDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, 100679036);
				CocaineDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, 100679037);
			}

			// Token: 0x0600D420 RID: 54304 RVA: 0x0032A4BC File Offset: 0x003286BC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D421 RID: 54305 RVA: 0x0032A4F8 File Offset: 0x003286F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238402, XrefRangeEnd = 238404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAppearanceSettings_b__8_0(Property x, Property y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D422 RID: 54306 RVA: 0x00067404 File Offset: 0x00065604
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041C3 RID: 16835
			// (get) Token: 0x0600D423 RID: 54307 RVA: 0x0032A558 File Offset: 0x00328758
			// (set) Token: 0x0600D424 RID: 54308 RVA: 0x0006740D File Offset: 0x0006560D
			public unsafe static CocaineDefinition.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CocaineDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CocaineDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C4 RID: 16836
			// (get) Token: 0x0600D425 RID: 54309 RVA: 0x0032A580 File Offset: 0x00328780
			// (set) Token: 0x0600D426 RID: 54310 RVA: 0x0006741F File Offset: 0x0006561F
			public unsafe static Comparison<Property> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CocaineDefinition.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Property>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CocaineDefinition.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ED8 RID: 36568
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008ED9 RID: 36569
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04008EDA RID: 36570
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EDB RID: 36571
			private static readonly IntPtr NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0;
		}
	}
}
