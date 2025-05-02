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
	// Token: 0x020005A1 RID: 1441
	[Serializable]
	public class MethDefinition : ProductDefinition
	{
		// Token: 0x06007E11 RID: 32273 RVA: 0x0021BD18 File Offset: 0x00219F18
		// Note: this type is marked as 'beforefieldinit'.
		static MethDefinition()
		{
			Il2CppClassPointerStore<MethDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MethDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr);
			MethDefinition.NativeFieldInfoPtr_CrystalMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "CrystalMaterial");
			MethDefinition.NativeFieldInfoPtr_TintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "TintColor");
			MethDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "<AppearanceSettings>k__BackingField");
			MethDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679057);
			MethDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679058);
			MethDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679059);
			MethDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679060);
			MethDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679061);
			MethDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_MethAppearanceSettings_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679062);
			MethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679063);
		}

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x06007E12 RID: 32274 RVA: 0x0021BE10 File Offset: 0x0021A010
		// (set) Token: 0x06007E13 RID: 32275 RVA: 0x0021BE50 File Offset: 0x0021A050
		public unsafe MethAppearanceSettings AppearanceSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_MethAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_MethAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007E14 RID: 32276 RVA: 0x0021BE94 File Offset: 0x0021A094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238693, XrefRangeEnd = 238737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007E15 RID: 32277 RVA: 0x0021BEEC File Offset: 0x0021A0EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238756, RefRangeEnd = 238758, XrefRangeStart = 238737, XrefRangeEnd = 238756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Property> properties, List<EDrugType> drugTypes, MethAppearanceSettings _appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_appearance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_MethAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E16 RID: 32278 RVA: 0x0021BF54 File Offset: 0x0021A154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238758, XrefRangeEnd = 238774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ProductData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductData>(intPtr3) : null;
		}

		// Token: 0x06007E17 RID: 32279 RVA: 0x0021BFA0 File Offset: 0x0021A1A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238850, RefRangeEnd = 238852, XrefRangeStart = 238774, XrefRangeEnd = 238850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethAppearanceSettings GetAppearanceSettings(List<Property> properties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_MethAppearanceSettings_List_1_Property_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x06007E18 RID: 32280 RVA: 0x0021BFE4 File Offset: 0x0021A1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238852, XrefRangeEnd = 238853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E19 RID: 32281 RVA: 0x0003BE8F File Offset: 0x0003A08F
		public MethDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x06007E1A RID: 32282 RVA: 0x0021C020 File Offset: 0x0021A220
		// (set) Token: 0x06007E1B RID: 32283 RVA: 0x0003BE98 File Offset: 0x0003A098
		public unsafe Material CrystalMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_CrystalMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_CrystalMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x06007E1C RID: 32284 RVA: 0x0021C050 File Offset: 0x0021A250
		// (set) Token: 0x06007E1D RID: 32285 RVA: 0x0003BEB7 File Offset: 0x0003A0B7
		public unsafe Color TintColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_TintColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_TintColor)) = value;
			}
		}

		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x06007E1E RID: 32286 RVA: 0x0021C078 File Offset: 0x0021A278
		// (set) Token: 0x06007E1F RID: 32287 RVA: 0x0003BED2 File Offset: 0x0003A0D2
		public unsafe MethAppearanceSettings _AppearanceSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040055CE RID: 21966
		private static readonly IntPtr NativeFieldInfoPtr_CrystalMaterial;

		// Token: 0x040055CF RID: 21967
		private static readonly IntPtr NativeFieldInfoPtr_TintColor;

		// Token: 0x040055D0 RID: 21968
		private static readonly IntPtr NativeFieldInfoPtr__AppearanceSettings_k__BackingField;

		// Token: 0x040055D1 RID: 21969
		private static readonly IntPtr NativeMethodInfoPtr_get_AppearanceSettings_Public_get_MethAppearanceSettings_0;

		// Token: 0x040055D2 RID: 21970
		private static readonly IntPtr NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_MethAppearanceSettings_0;

		// Token: 0x040055D3 RID: 21971
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040055D4 RID: 21972
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_MethAppearanceSettings_0;

		// Token: 0x040055D5 RID: 21973
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0;

		// Token: 0x040055D6 RID: 21974
		private static readonly IntPtr NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_MethAppearanceSettings_List_1_Property_0;

		// Token: 0x040055D7 RID: 21975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AC6 RID: 2758
		[ObfuscatedName("ScheduleOne.Product.MethDefinition+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D427 RID: 54311 RVA: 0x0032A5A8 File Offset: 0x003287A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr);
				MethDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, "<>9");
				MethDefinition.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, "<>9__9_0");
				MethDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, 100679065);
				MethDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__9_0_Internal_Int32_Property_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, 100679066);
			}

			// Token: 0x0600D428 RID: 54312 RVA: 0x0032A624 File Offset: 0x00328824
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D429 RID: 54313 RVA: 0x0032A660 File Offset: 0x00328860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAppearanceSettings_b__9_0(Property x, Property y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__9_0_Internal_Int32_Property_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D42A RID: 54314 RVA: 0x00067431 File Offset: 0x00065631
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041C5 RID: 16837
			// (get) Token: 0x0600D42B RID: 54315 RVA: 0x0032A6C0 File Offset: 0x003288C0
			// (set) Token: 0x0600D42C RID: 54316 RVA: 0x0006743A File Offset: 0x0006563A
			public unsafe static MethDefinition.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MethDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MethDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C6 RID: 16838
			// (get) Token: 0x0600D42D RID: 54317 RVA: 0x0032A6E8 File Offset: 0x003288E8
			// (set) Token: 0x0600D42E RID: 54318 RVA: 0x0006744C File Offset: 0x0006564C
			public unsafe static Comparison<Property> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MethDefinition.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Property>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MethDefinition.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EDC RID: 36572
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008EDD RID: 36573
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04008EDE RID: 36574
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EDF RID: 36575
			private static readonly IntPtr NativeMethodInfoPtr__GetAppearanceSettings_b__9_0_Internal_Int32_Property_Property_0;
		}
	}
}
