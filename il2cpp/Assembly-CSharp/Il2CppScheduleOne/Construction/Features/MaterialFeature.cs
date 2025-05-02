using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Construction.Features;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x02000486 RID: 1158
	public class MaterialFeature : OptionListFeature
	{
		// Token: 0x06006478 RID: 25720 RVA: 0x001C6834 File Offset: 0x001C4A34
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialFeature()
		{
			Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "MaterialFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr);
			MaterialFeature.NativeFieldInfoPtr_materialTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "materialTargets");
			MaterialFeature.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "materials");
			MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Construction.Features.MaterialFeatureAssembly-CSharp.dll_Excuted");
			MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Construction.Features.MaterialFeatureAssembly-CSharp.dll_Excuted");
			MaterialFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676023);
			MaterialFeature.NativeMethodInfoPtr_ApplyMaterial_Private_Void_NamedMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676024);
			MaterialFeature.NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676025);
			MaterialFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676026);
			MaterialFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676027);
			MaterialFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676028);
			MaterialFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676029);
			MaterialFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676030);
		}

		// Token: 0x06006479 RID: 25721 RVA: 0x001C6954 File Offset: 0x001C4B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204453, XrefRangeEnd = 204462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SelectOption(int optionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref optionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647A RID: 25722 RVA: 0x001C69A0 File Offset: 0x001C4BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204462, XrefRangeEnd = 204468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMaterial(MaterialFeature.NamedMaterial mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFeature.NativeMethodInfoPtr_ApplyMaterial_Private_Void_NamedMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x001C69E4 File Offset: 0x001C4BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204468, XrefRangeEnd = 204492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<FI_OptionList.Option> GetOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FI_OptionList.Option>>(intPtr3) : null;
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x001C6A30 File Offset: 0x001C4C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204492, XrefRangeEnd = 204511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x001C6A6C File Offset: 0x001C4C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204511, XrefRangeEnd = 204512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x001C6AA8 File Offset: 0x001C4CA8
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x001C6AE4 File Offset: 0x001C4CE4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x001C6B20 File Offset: 0x001C4D20
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x0002F87F File Offset: 0x0002DA7F
		public MaterialFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x06006482 RID: 25730 RVA: 0x001C6B5C File Offset: 0x001C4D5C
		// (set) Token: 0x06006483 RID: 25731 RVA: 0x0002F888 File Offset: 0x0002DA88
		public unsafe List<MeshRenderer> materialTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_materialTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_materialTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x06006484 RID: 25732 RVA: 0x001C6B8C File Offset: 0x001C4D8C
		// (set) Token: 0x06006485 RID: 25733 RVA: 0x0002F8A7 File Offset: 0x0002DAA7
		public unsafe List<MaterialFeature.NamedMaterial> materials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_materials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialFeature.NamedMaterial>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x06006486 RID: 25734 RVA: 0x001C6BBC File Offset: 0x001C4DBC
		// (set) Token: 0x06006487 RID: 25735 RVA: 0x0002F8C6 File Offset: 0x0002DAC6
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x06006488 RID: 25736 RVA: 0x001C6BE4 File Offset: 0x001C4DE4
		// (set) Token: 0x06006489 RID: 25737 RVA: 0x0002F8E1 File Offset: 0x0002DAE1
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400448D RID: 17549
		private static readonly IntPtr NativeFieldInfoPtr_materialTargets;

		// Token: 0x0400448E RID: 17550
		private static readonly IntPtr NativeFieldInfoPtr_materials;

		// Token: 0x0400448F RID: 17551
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004490 RID: 17552
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004491 RID: 17553
		private static readonly IntPtr NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0;

		// Token: 0x04004492 RID: 17554
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterial_Private_Void_NamedMaterial_0;

		// Token: 0x04004493 RID: 17555
		private static readonly IntPtr NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0;

		// Token: 0x04004494 RID: 17556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004495 RID: 17557
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004496 RID: 17558
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004497 RID: 17559
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004498 RID: 17560
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A2F RID: 2607
		[Serializable]
		public class NamedMaterial : Il2CppSystem.Object
		{
			// Token: 0x0600CF75 RID: 53109 RVA: 0x0031D5D8 File Offset: 0x0031B7D8
			// Note: this type is marked as 'beforefieldinit'.
			static NamedMaterial()
			{
				Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "NamedMaterial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr);
				MaterialFeature.NamedMaterial.NativeFieldInfoPtr_matName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, "matName");
				MaterialFeature.NamedMaterial.NativeFieldInfoPtr_buttonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, "buttonColor");
				MaterialFeature.NamedMaterial.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, "mat");
				MaterialFeature.NamedMaterial.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, "price");
				MaterialFeature.NamedMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, 100676031);
			}

			// Token: 0x0600CF76 RID: 53110 RVA: 0x0031D668 File Offset: 0x0031B868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204452, XrefRangeEnd = 204453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamedMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFeature.NamedMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF77 RID: 53111 RVA: 0x00064EE8 File Offset: 0x000630E8
			public NamedMaterial(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004078 RID: 16504
			// (get) Token: 0x0600CF78 RID: 53112 RVA: 0x0031D6A4 File Offset: 0x0031B8A4
			// (set) Token: 0x0600CF79 RID: 53113 RVA: 0x00064EF1 File Offset: 0x000630F1
			public unsafe string matName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_matName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_matName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004079 RID: 16505
			// (get) Token: 0x0600CF7A RID: 53114 RVA: 0x0031D6CC File Offset: 0x0031B8CC
			// (set) Token: 0x0600CF7B RID: 53115 RVA: 0x00064F10 File Offset: 0x00063110
			public unsafe Color buttonColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_buttonColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_buttonColor)) = value;
				}
			}

			// Token: 0x1700407A RID: 16506
			// (get) Token: 0x0600CF7C RID: 53116 RVA: 0x0031D6F4 File Offset: 0x0031B8F4
			// (set) Token: 0x0600CF7D RID: 53117 RVA: 0x00064F2B File Offset: 0x0006312B
			public unsafe Material mat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_mat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700407B RID: 16507
			// (get) Token: 0x0600CF7E RID: 53118 RVA: 0x0031D724 File Offset: 0x0031B924
			// (set) Token: 0x0600CF7F RID: 53119 RVA: 0x00064F4A File Offset: 0x0006314A
			public unsafe float price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_price)) = value;
				}
			}

			// Token: 0x04008BF0 RID: 35824
			private static readonly IntPtr NativeFieldInfoPtr_matName;

			// Token: 0x04008BF1 RID: 35825
			private static readonly IntPtr NativeFieldInfoPtr_buttonColor;

			// Token: 0x04008BF2 RID: 35826
			private static readonly IntPtr NativeFieldInfoPtr_mat;

			// Token: 0x04008BF3 RID: 35827
			private static readonly IntPtr NativeFieldInfoPtr_price;

			// Token: 0x04008BF4 RID: 35828
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
