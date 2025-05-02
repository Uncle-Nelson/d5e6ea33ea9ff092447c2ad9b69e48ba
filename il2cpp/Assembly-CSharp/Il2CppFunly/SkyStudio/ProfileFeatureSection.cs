using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000109 RID: 265
	[Serializable]
	public class ProfileFeatureSection : Object
	{
		// Token: 0x0600141F RID: 5151 RVA: 0x000B0834 File Offset: 0x000AEA34
		// Note: this type is marked as 'beforefieldinit'.
		static ProfileFeatureSection()
		{
			Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ProfileFeatureSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr);
			ProfileFeatureSection.NativeFieldInfoPtr_sectionTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr, "sectionTitle");
			ProfileFeatureSection.NativeFieldInfoPtr_sectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr, "sectionKey");
			ProfileFeatureSection.NativeFieldInfoPtr_sectionIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr, "sectionIcon");
			ProfileFeatureSection.NativeFieldInfoPtr_featureDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr, "featureDefinitions");
			ProfileFeatureSection.NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppReferenceArray_1_ProfileFeatureDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr, 100665552);
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x000B08C8 File Offset: 0x000AEAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90630, XrefRangeEnd = 90634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfileFeatureSection(string sectionTitle, string sectionKey, Il2CppReferenceArray<ProfileFeatureDefinition> featureDefinitions) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileFeatureSection>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sectionKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(featureDefinitions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileFeatureSection.NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppReferenceArray_1_ProfileFeatureDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0000BF06 File Offset: 0x0000A106
		public ProfileFeatureSection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x000B0938 File Offset: 0x000AEB38
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x0000BF0F File Offset: 0x0000A10F
		public unsafe string sectionTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_sectionTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_sectionTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x000B0960 File Offset: 0x000AEB60
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x0000BF2E File Offset: 0x0000A12E
		public unsafe string sectionKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_sectionKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_sectionKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x000B0988 File Offset: 0x000AEB88
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x0000BF4D File Offset: 0x0000A14D
		public unsafe string sectionIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_sectionIcon);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_sectionIcon), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x000B09B0 File Offset: 0x000AEBB0
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x0000BF6C File Offset: 0x0000A16C
		public unsafe Il2CppReferenceArray<ProfileFeatureDefinition> featureDefinitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_featureDefinitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileFeatureDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileFeatureSection.NativeFieldInfoPtr_featureDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeFieldInfoPtr_sectionTitle;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeFieldInfoPtr_sectionKey;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeFieldInfoPtr_sectionIcon;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeFieldInfoPtr_featureDefinitions;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppReferenceArray_1_ProfileFeatureDefinition_0;
	}
}
