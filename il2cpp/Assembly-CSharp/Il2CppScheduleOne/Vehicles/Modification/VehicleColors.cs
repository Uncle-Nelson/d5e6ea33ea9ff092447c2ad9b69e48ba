using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Modification
{
	// Token: 0x020004FA RID: 1274
	public class VehicleColors : Singleton<VehicleColors>
	{
		// Token: 0x060070A0 RID: 28832 RVA: 0x001EF14C File Offset: 0x001ED34C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleColors()
		{
			Il2CppClassPointerStore<VehicleColors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Modification", "VehicleColors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr);
			VehicleColors.NativeFieldInfoPtr_colorLibrary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "colorLibrary");
			VehicleColors.NativeMethodInfoPtr_GetColorName_Public_String_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, 100677445);
			VehicleColors.NativeMethodInfoPtr_GetColorUIColor_Public_Color32_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, 100677446);
			VehicleColors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, 100677447);
		}

		// Token: 0x060070A1 RID: 28833 RVA: 0x001EF1CC File Offset: 0x001ED3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221856, XrefRangeEnd = 221869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetColorName(EVehicleColor c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.NativeMethodInfoPtr_GetColorName_Public_String_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060070A2 RID: 28834 RVA: 0x001EF210 File Offset: 0x001ED410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221869, XrefRangeEnd = 221882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 GetColorUIColor(EVehicleColor c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.NativeMethodInfoPtr_GetColorUIColor_Public_Color32_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070A3 RID: 28835 RVA: 0x001EF25C File Offset: 0x001ED45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221882, XrefRangeEnd = 221892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleColors() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070A4 RID: 28836 RVA: 0x0003579B File Offset: 0x0003399B
		public VehicleColors(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x060070A5 RID: 28837 RVA: 0x001EF298 File Offset: 0x001ED498
		// (set) Token: 0x060070A6 RID: 28838 RVA: 0x000357A4 File Offset: 0x000339A4
		public unsafe List<VehicleColors.VehicleColorData> colorLibrary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.NativeFieldInfoPtr_colorLibrary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleColors.VehicleColorData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.NativeFieldInfoPtr_colorLibrary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004CF9 RID: 19705
		private static readonly IntPtr NativeFieldInfoPtr_colorLibrary;

		// Token: 0x04004CFA RID: 19706
		private static readonly IntPtr NativeMethodInfoPtr_GetColorName_Public_String_EVehicleColor_0;

		// Token: 0x04004CFB RID: 19707
		private static readonly IntPtr NativeMethodInfoPtr_GetColorUIColor_Public_Color32_EVehicleColor_0;

		// Token: 0x04004CFC RID: 19708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A6E RID: 2670
		[Serializable]
		public class VehicleColorData : Il2CppSystem.Object
		{
			// Token: 0x0600D141 RID: 53569 RVA: 0x00322230 File Offset: 0x00320430
			// Note: this type is marked as 'beforefieldinit'.
			static VehicleColorData()
			{
				Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "VehicleColorData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr);
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "color");
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_colorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "colorName");
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "material");
				VehicleColors.VehicleColorData.NativeFieldInfoPtr_UIColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, "UIColor");
				VehicleColors.VehicleColorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr, 100677448);
			}

			// Token: 0x0600D142 RID: 53570 RVA: 0x003222C0 File Offset: 0x003204C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221854, XrefRangeEnd = 221856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehicleColorData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors.VehicleColorData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.VehicleColorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D143 RID: 53571 RVA: 0x00065DF6 File Offset: 0x00063FF6
			public VehicleColorData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040F9 RID: 16633
			// (get) Token: 0x0600D144 RID: 53572 RVA: 0x003222FC File Offset: 0x003204FC
			// (set) Token: 0x0600D145 RID: 53573 RVA: 0x00065DFF File Offset: 0x00063FFF
			public unsafe EVehicleColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x170040FA RID: 16634
			// (get) Token: 0x0600D146 RID: 53574 RVA: 0x00322324 File Offset: 0x00320524
			// (set) Token: 0x0600D147 RID: 53575 RVA: 0x00065E1A File Offset: 0x0006401A
			public unsafe string colorName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_colorName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_colorName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170040FB RID: 16635
			// (get) Token: 0x0600D148 RID: 53576 RVA: 0x0032234C File Offset: 0x0032054C
			// (set) Token: 0x0600D149 RID: 53577 RVA: 0x00065E39 File Offset: 0x00064039
			public unsafe Material material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040FC RID: 16636
			// (get) Token: 0x0600D14A RID: 53578 RVA: 0x0032237C File Offset: 0x0032057C
			// (set) Token: 0x0600D14B RID: 53579 RVA: 0x00065E58 File Offset: 0x00064058
			public unsafe Color32 UIColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_UIColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.VehicleColorData.NativeFieldInfoPtr_UIColor)) = value;
				}
			}

			// Token: 0x04008D2E RID: 36142
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008D2F RID: 36143
			private static readonly IntPtr NativeFieldInfoPtr_colorName;

			// Token: 0x04008D30 RID: 36144
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x04008D31 RID: 36145
			private static readonly IntPtr NativeFieldInfoPtr_UIColor;

			// Token: 0x04008D32 RID: 36146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A6F RID: 2671
		[ObfuscatedName("ScheduleOne.Vehicles.Modification.VehicleColors+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D14C RID: 53580 RVA: 0x003223A4 File Offset: 0x003205A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr);
				VehicleColors.__c__DisplayClass2_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr, "c");
				VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr, 100677449);
				VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__GetColorName_b__0_Internal_Boolean_VehicleColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr, 100677450);
			}

			// Token: 0x0600D14D RID: 53581 RVA: 0x0032240C File Offset: 0x0032060C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D14E RID: 53582 RVA: 0x00322448 File Offset: 0x00320648
			[CallerCount(0)]
			public unsafe bool _GetColorName_b__0(VehicleColors.VehicleColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass2_0.NativeMethodInfoPtr__GetColorName_b__0_Internal_Boolean_VehicleColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D14F RID: 53583 RVA: 0x00065E73 File Offset: 0x00064073
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040FD RID: 16637
			// (get) Token: 0x0600D150 RID: 53584 RVA: 0x00322498 File Offset: 0x00320698
			// (set) Token: 0x0600D151 RID: 53585 RVA: 0x00065E7C File Offset: 0x0006407C
			public unsafe EVehicleColor c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass2_0.NativeFieldInfoPtr_c);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass2_0.NativeFieldInfoPtr_c)) = value;
				}
			}

			// Token: 0x04008D33 RID: 36147
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x04008D34 RID: 36148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D35 RID: 36149
			private static readonly IntPtr NativeMethodInfoPtr__GetColorName_b__0_Internal_Boolean_VehicleColorData_0;
		}

		// Token: 0x02000A70 RID: 2672
		[ObfuscatedName("ScheduleOne.Vehicles.Modification.VehicleColors+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D152 RID: 53586 RVA: 0x003224C0 File Offset: 0x003206C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleColors>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr);
				VehicleColors.__c__DisplayClass3_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr, "c");
				VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr, 100677451);
				VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__GetColorUIColor_b__0_Internal_Boolean_VehicleColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr, 100677452);
			}

			// Token: 0x0600D153 RID: 53587 RVA: 0x00322528 File Offset: 0x00320728
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColors.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D154 RID: 53588 RVA: 0x00322564 File Offset: 0x00320764
			[CallerCount(0)]
			public unsafe bool _GetColorUIColor_b__0(VehicleColors.VehicleColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColors.__c__DisplayClass3_0.NativeMethodInfoPtr__GetColorUIColor_b__0_Internal_Boolean_VehicleColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D155 RID: 53589 RVA: 0x00065E97 File Offset: 0x00064097
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040FE RID: 16638
			// (get) Token: 0x0600D156 RID: 53590 RVA: 0x003225B4 File Offset: 0x003207B4
			// (set) Token: 0x0600D157 RID: 53591 RVA: 0x00065EA0 File Offset: 0x000640A0
			public unsafe EVehicleColor c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass3_0.NativeFieldInfoPtr_c);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColors.__c__DisplayClass3_0.NativeFieldInfoPtr_c)) = value;
				}
			}

			// Token: 0x04008D36 RID: 36150
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x04008D37 RID: 36151
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D38 RID: 36152
			private static readonly IntPtr NativeMethodInfoPtr__GetColorUIColor_b__0_Internal_Boolean_VehicleColorData_0;
		}
	}
}
