using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x0200039A RID: 922
	public class StationRecipeField : ConfigField
	{
		// Token: 0x06004853 RID: 18515 RVA: 0x00161B24 File Offset: 0x0015FD24
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeField()
		{
			Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "StationRecipeField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr);
			StationRecipeField.NativeFieldInfoPtr__SelectedRecipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "<SelectedRecipe>k__BackingField");
			StationRecipeField.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "Options");
			StationRecipeField.NativeFieldInfoPtr_onRecipeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "onRecipeChanged");
			StationRecipeField.NativeMethodInfoPtr_get_SelectedRecipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672233);
			StationRecipeField.NativeMethodInfoPtr_set_SelectedRecipe_Protected_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672234);
			StationRecipeField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672235);
			StationRecipeField.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672236);
			StationRecipeField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672237);
			StationRecipeField.NativeMethodInfoPtr_GetData_Public_StationRecipeFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672238);
			StationRecipeField.NativeMethodInfoPtr_Load_Public_Void_StationRecipeFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100672239);
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06004854 RID: 18516 RVA: 0x00161C1C File Offset: 0x0015FE1C
		// (set) Token: 0x06004855 RID: 18517 RVA: 0x00161C5C File Offset: 0x0015FE5C
		public unsafe StationRecipe SelectedRecipe
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_get_SelectedRecipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_set_SelectedRecipe_Protected_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004856 RID: 18518 RVA: 0x00161CA0 File Offset: 0x0015FEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162172, XrefRangeEnd = 162187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004857 RID: 18519 RVA: 0x00161CEC File Offset: 0x0015FEEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162192, RefRangeEnd = 162194, XrefRangeStart = 162187, XrefRangeEnd = 162192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRecipe(StationRecipe recipe, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x00161D3C File Offset: 0x0015FF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162194, XrefRangeEnd = 162198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationRecipeField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004859 RID: 18521 RVA: 0x00161D84 File Offset: 0x0015FF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162198, XrefRangeEnd = 162210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_GetData_Public_StationRecipeFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldData>(intPtr3) : null;
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x00161DC4 File Offset: 0x0015FFC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162226, RefRangeEnd = 162227, XrefRangeStart = 162210, XrefRangeEnd = 162226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(StationRecipeFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_Load_Public_Void_StationRecipeFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600485B RID: 18523 RVA: 0x00022F9A File Offset: 0x0002119A
		public StationRecipeField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x0600485C RID: 18524 RVA: 0x00161E08 File Offset: 0x00160008
		// (set) Token: 0x0600485D RID: 18525 RVA: 0x00022FA3 File Offset: 0x000211A3
		public unsafe StationRecipe _SelectedRecipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr__SelectedRecipe_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr__SelectedRecipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x00161E38 File Offset: 0x00160038
		// (set) Token: 0x0600485F RID: 18527 RVA: 0x00022FC2 File Offset: 0x000211C2
		public unsafe List<StationRecipe> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x00161E68 File Offset: 0x00160068
		// (set) Token: 0x06004861 RID: 18529 RVA: 0x00022FE1 File Offset: 0x000211E1
		public unsafe UnityEvent<StationRecipe> onRecipeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_onRecipeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_onRecipeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030BD RID: 12477
		private static readonly IntPtr NativeFieldInfoPtr__SelectedRecipe_k__BackingField;

		// Token: 0x040030BE RID: 12478
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x040030BF RID: 12479
		private static readonly IntPtr NativeFieldInfoPtr_onRecipeChanged;

		// Token: 0x040030C0 RID: 12480
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedRecipe_Public_get_StationRecipe_0;

		// Token: 0x040030C1 RID: 12481
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedRecipe_Protected_set_Void_StationRecipe_0;

		// Token: 0x040030C2 RID: 12482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040030C3 RID: 12483
		private static readonly IntPtr NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_Boolean_0;

		// Token: 0x040030C4 RID: 12484
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040030C5 RID: 12485
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_StationRecipeFieldData_0;

		// Token: 0x040030C6 RID: 12486
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_StationRecipeFieldData_0;

		// Token: 0x02000977 RID: 2423
		[ObfuscatedName("ScheduleOne.Management.StationRecipeField+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600C9CD RID: 51661 RVA: 0x0030D6D4 File Offset: 0x0030B8D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr);
				StationRecipeField.__c__DisplayClass10_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr, "data");
				StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr, 100672240);
				StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr, 100672241);
			}

			// Token: 0x0600C9CE RID: 51662 RVA: 0x0030D73C File Offset: 0x0030B93C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9CF RID: 51663 RVA: 0x0030D778 File Offset: 0x0030B978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162169, XrefRangeEnd = 162172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(StationRecipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C9D0 RID: 51664 RVA: 0x00062219 File Offset: 0x00060419
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EEA RID: 16106
			// (get) Token: 0x0600C9D1 RID: 51665 RVA: 0x0030D7C8 File Offset: 0x0030B9C8
			// (set) Token: 0x0600C9D2 RID: 51666 RVA: 0x00062222 File Offset: 0x00060422
			public unsafe StationRecipeFieldData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.__c__DisplayClass10_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.__c__DisplayClass10_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400888D RID: 34957
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x0400888E RID: 34958
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400888F RID: 34959
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_StationRecipe_0;
		}
	}
}
