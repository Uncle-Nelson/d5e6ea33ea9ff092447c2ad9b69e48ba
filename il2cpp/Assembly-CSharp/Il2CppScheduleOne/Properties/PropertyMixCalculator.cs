using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001F0 RID: 496
	public static class PropertyMixCalculator : Object
	{
		// Token: 0x0600286E RID: 10350 RVA: 0x000F0550 File Offset: 0x000EE750
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyMixCalculator()
		{
			Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "PropertyMixCalculator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr);
			PropertyMixCalculator.NativeFieldInfoPtr_MAX_PROPERTIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr, "MAX_PROPERTIES");
			PropertyMixCalculator.NativeFieldInfoPtr_MAX_DELTA_DIFFERENCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr, "MAX_DELTA_DIFFERENCE");
			PropertyMixCalculator.NativeMethodInfoPtr_MixProperties_Public_Static_List_1_Property_List_1_Property_Property_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr, 100667859);
			PropertyMixCalculator.NativeMethodInfoPtr_Shuffle_Public_Static_Void_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr, 100667860);
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x000F05D0 File Offset: 0x000EE7D0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 118590, RefRangeEnd = 118599, XrefRangeStart = 118493, XrefRangeEnd = 118590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Property> MixProperties(List<Property> existingProperties, Property newProperty, EDrugType drugType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(existingProperties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newProperty);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMixCalculator.NativeMethodInfoPtr_MixProperties_Public_Static_List_1_Property_List_1_Property_Property_EDrugType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr3) : null;
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x000F0634 File Offset: 0x000EE834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118599, XrefRangeEnd = 118611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shuffle<T>(List<T> list, int seed)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMixCalculator.MethodInfoStoreGeneric_Shuffle_Public_Static_Void_List_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x00015FF4 File Offset: 0x000141F4
		public PropertyMixCalculator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002872 RID: 10354 RVA: 0x000F0678 File Offset: 0x000EE878
		// (set) Token: 0x06002873 RID: 10355 RVA: 0x00015FFD File Offset: 0x000141FD
		public unsafe static int MAX_PROPERTIES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PropertyMixCalculator.NativeFieldInfoPtr_MAX_PROPERTIES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropertyMixCalculator.NativeFieldInfoPtr_MAX_PROPERTIES, (void*)(&value));
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x000F0694 File Offset: 0x000EE894
		// (set) Token: 0x06002875 RID: 10357 RVA: 0x0001600B File Offset: 0x0001420B
		public unsafe static float MAX_DELTA_DIFFERENCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PropertyMixCalculator.NativeFieldInfoPtr_MAX_DELTA_DIFFERENCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropertyMixCalculator.NativeFieldInfoPtr_MAX_DELTA_DIFFERENCE, (void*)(&value));
			}
		}

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PROPERTIES;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeFieldInfoPtr_MAX_DELTA_DIFFERENCE;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeMethodInfoPtr_MixProperties_Public_Static_List_1_Property_List_1_Property_Property_EDrugType_0;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr_Shuffle_Public_Static_Void_List_1_T_Int32_0;

		// Token: 0x020008D8 RID: 2264
		public class Reaction : Object
		{
			// Token: 0x0600C459 RID: 50265 RVA: 0x002FD634 File Offset: 0x002FB834
			// Note: this type is marked as 'beforefieldinit'.
			static Reaction()
			{
				Il2CppClassPointerStore<PropertyMixCalculator.Reaction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr, "Reaction");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyMixCalculator.Reaction>.NativeClassPtr);
				PropertyMixCalculator.Reaction.NativeFieldInfoPtr_Existing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMixCalculator.Reaction>.NativeClassPtr, "Existing");
				PropertyMixCalculator.Reaction.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMixCalculator.Reaction>.NativeClassPtr, "Output");
				PropertyMixCalculator.Reaction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMixCalculator.Reaction>.NativeClassPtr, 100667861);
			}

			// Token: 0x0600C45A RID: 50266 RVA: 0x002FD69C File Offset: 0x002FB89C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Reaction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyMixCalculator.Reaction>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMixCalculator.Reaction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C45B RID: 50267 RVA: 0x0005F8DC File Offset: 0x0005DADC
			public Reaction(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D47 RID: 15687
			// (get) Token: 0x0600C45C RID: 50268 RVA: 0x002FD6D8 File Offset: 0x002FB8D8
			// (set) Token: 0x0600C45D RID: 50269 RVA: 0x0005F8E5 File Offset: 0x0005DAE5
			public unsafe Property Existing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMixCalculator.Reaction.NativeFieldInfoPtr_Existing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMixCalculator.Reaction.NativeFieldInfoPtr_Existing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D48 RID: 15688
			// (get) Token: 0x0600C45E RID: 50270 RVA: 0x002FD708 File Offset: 0x002FB908
			// (set) Token: 0x0600C45F RID: 50271 RVA: 0x0005F904 File Offset: 0x0005DB04
			public unsafe Property Output
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMixCalculator.Reaction.NativeFieldInfoPtr_Output);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMixCalculator.Reaction.NativeFieldInfoPtr_Output), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400850F RID: 34063
			private static readonly IntPtr NativeFieldInfoPtr_Existing;

			// Token: 0x04008510 RID: 34064
			private static readonly IntPtr NativeFieldInfoPtr_Output;

			// Token: 0x04008511 RID: 34065
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008D9 RID: 2265
		private sealed class MethodInfoStoreGeneric_Shuffle_Public_Static_Void_List_1_T_Int32_0<T>
		{
			// Token: 0x04008512 RID: 34066
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PropertyMixCalculator.NativeMethodInfoPtr_Shuffle_Public_Static_Void_List_1_T_Int32_0, Il2CppClassPointerStore<PropertyMixCalculator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
