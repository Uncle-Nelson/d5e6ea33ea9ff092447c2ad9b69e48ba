using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000113 RID: 275
	[Serializable]
	public class BaseShaderDefinition : Object
	{
		// Token: 0x060015CC RID: 5580 RVA: 0x000B34AC File Offset: 0x000B16AC
		// Note: this type is marked as 'beforefieldinit'.
		static BaseShaderDefinition()
		{
			Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BaseShaderDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr);
			BaseShaderDefinition.NativeFieldInfoPtr__shaderName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr, "<shaderName>k__BackingField");
			BaseShaderDefinition.NativeFieldInfoPtr_m_ProfileDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr, "m_ProfileDefinitions");
			BaseShaderDefinition.NativeFieldInfoPtr_m_ProfileFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr, "m_ProfileFeatures");
			BaseShaderDefinition.NativeFieldInfoPtr_m_KeyToFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr, "m_KeyToFeature");
			BaseShaderDefinition.NativeMethodInfoPtr_get_shaderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr, 100665563);
			BaseShaderDefinition.NativeMethodInfoPtr_set_shaderName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr, 100665564);
			BaseShaderDefinition.NativeMethodInfoPtr_get_groups_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_ProfileGroupSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr, 100665565);
			BaseShaderDefinition.NativeMethodInfoPtr_get_features_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_ProfileFeatureSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr, 100665566);
			BaseShaderDefinition.NativeMethodInfoPtr_GetFeatureDefinition_Public_Virtual_Final_New_ProfileFeatureDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr, 100665567);
			BaseShaderDefinition.NativeMethodInfoPtr_ProfileFeatureSection_Protected_Abstract_Virtual_New_Il2CppReferenceArray_1_ProfileFeatureSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr, 100665568);
			BaseShaderDefinition.NativeMethodInfoPtr_ProfileDefinitionTable_Protected_Abstract_Virtual_New_Il2CppReferenceArray_1_ProfileGroupSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr, 100665569);
			BaseShaderDefinition.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr, 100665570);
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x000B35CC File Offset: 0x000B17CC
		// (set) Token: 0x060015CE RID: 5582 RVA: 0x000B3604 File Offset: 0x000B1804
		public unsafe virtual string shaderName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseShaderDefinition.NativeMethodInfoPtr_get_shaderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseShaderDefinition.NativeMethodInfoPtr_set_shaderName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x000B3648 File Offset: 0x000B1848
		public unsafe virtual Il2CppReferenceArray<ProfileGroupSection> groups
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90678, XrefRangeEnd = 90679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseShaderDefinition.NativeMethodInfoPtr_get_groups_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_ProfileGroupSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileGroupSection>>(intPtr3) : null;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x000B3688 File Offset: 0x000B1888
		public unsafe virtual Il2CppReferenceArray<ProfileFeatureSection> features
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90679, XrefRangeEnd = 90680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseShaderDefinition.NativeMethodInfoPtr_get_features_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_ProfileFeatureSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileFeatureSection>>(intPtr3) : null;
			}
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x000B36C8 File Offset: 0x000B18C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90680, XrefRangeEnd = 90704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ProfileFeatureDefinition GetFeatureDefinition(string featureKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(featureKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseShaderDefinition.NativeMethodInfoPtr_GetFeatureDefinition_Public_Virtual_Final_New_ProfileFeatureDefinition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileFeatureDefinition>(intPtr3) : null;
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x000B3718 File Offset: 0x000B1918
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<ProfileFeatureSection> ProfileFeatureSection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseShaderDefinition.NativeMethodInfoPtr_ProfileFeatureSection_Protected_Abstract_Virtual_New_Il2CppReferenceArray_1_ProfileFeatureSection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileFeatureSection>>(intPtr3) : null;
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x000B3764 File Offset: 0x000B1964
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<ProfileGroupSection> ProfileDefinitionTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseShaderDefinition.NativeMethodInfoPtr_ProfileDefinitionTable_Protected_Abstract_Virtual_New_Il2CppReferenceArray_1_ProfileGroupSection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileGroupSection>>(intPtr3) : null;
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x000B37B0 File Offset: 0x000B19B0
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseShaderDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseShaderDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseShaderDefinition.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		public BaseShaderDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x000B37EC File Offset: 0x000B19EC
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x0000CEF1 File Offset: 0x0000B0F1
		public unsafe string _shaderName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseShaderDefinition.NativeFieldInfoPtr__shaderName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseShaderDefinition.NativeFieldInfoPtr__shaderName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x000B3814 File Offset: 0x000B1A14
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x0000CF10 File Offset: 0x0000B110
		public unsafe Il2CppReferenceArray<ProfileGroupSection> m_ProfileDefinitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseShaderDefinition.NativeFieldInfoPtr_m_ProfileDefinitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileGroupSection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseShaderDefinition.NativeFieldInfoPtr_m_ProfileDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x000B3844 File Offset: 0x000B1A44
		// (set) Token: 0x060015DB RID: 5595 RVA: 0x0000CF2F File Offset: 0x0000B12F
		public unsafe Il2CppReferenceArray<ProfileFeatureSection> m_ProfileFeatures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseShaderDefinition.NativeFieldInfoPtr_m_ProfileFeatures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileFeatureSection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseShaderDefinition.NativeFieldInfoPtr_m_ProfileFeatures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x000B3874 File Offset: 0x000B1A74
		// (set) Token: 0x060015DD RID: 5597 RVA: 0x0000CF4E File Offset: 0x0000B14E
		public unsafe Dictionary<string, ProfileFeatureDefinition> m_KeyToFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseShaderDefinition.NativeFieldInfoPtr_m_KeyToFeature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ProfileFeatureDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseShaderDefinition.NativeFieldInfoPtr_m_KeyToFeature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeFieldInfoPtr__shaderName_k__BackingField;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfileDefinitions;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfileFeatures;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyToFeature;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_get_shaderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr_set_shaderName_Protected_set_Void_String_0;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr_get_groups_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_ProfileGroupSection_0;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr_get_features_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_ProfileFeatureSection_0;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeMethodInfoPtr_GetFeatureDefinition_Public_Virtual_Final_New_ProfileFeatureDefinition_String_0;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeMethodInfoPtr_ProfileFeatureSection_Protected_Abstract_Virtual_New_Il2CppReferenceArray_1_ProfileFeatureSection_0;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeMethodInfoPtr_ProfileDefinitionTable_Protected_Abstract_Virtual_New_Il2CppReferenceArray_1_ProfileGroupSection_0;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
