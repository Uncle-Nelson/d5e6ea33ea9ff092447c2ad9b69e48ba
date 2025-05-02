using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000114 RID: 276
	public class IProfileDefinition : Il2CppObjectBase
	{
		// Token: 0x060015DE RID: 5598 RVA: 0x000B38A4 File Offset: 0x000B1AA4
		// Note: this type is marked as 'beforefieldinit'.
		static IProfileDefinition()
		{
			Il2CppClassPointerStore<IProfileDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "IProfileDefinition");
			IProfileDefinition.NativeMethodInfoPtr_get_shaderName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProfileDefinition>.NativeClassPtr, 100665571);
			IProfileDefinition.NativeMethodInfoPtr_get_features_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_ProfileFeatureSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProfileDefinition>.NativeClassPtr, 100665572);
			IProfileDefinition.NativeMethodInfoPtr_get_groups_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_ProfileGroupSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProfileDefinition>.NativeClassPtr, 100665573);
			IProfileDefinition.NativeMethodInfoPtr_GetFeatureDefinition_Public_Abstract_Virtual_New_ProfileFeatureDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProfileDefinition>.NativeClassPtr, 100665574);
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x000B391C File Offset: 0x000B1B1C
		public unsafe virtual string shaderName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProfileDefinition.NativeMethodInfoPtr_get_shaderName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x000B3960 File Offset: 0x000B1B60
		public unsafe virtual Il2CppReferenceArray<ProfileFeatureSection> features
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProfileDefinition.NativeMethodInfoPtr_get_features_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_ProfileFeatureSection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileFeatureSection>>(intPtr3) : null;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x000B39AC File Offset: 0x000B1BAC
		public unsafe virtual Il2CppReferenceArray<ProfileGroupSection> groups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProfileDefinition.NativeMethodInfoPtr_get_groups_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_ProfileGroupSection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileGroupSection>>(intPtr3) : null;
			}
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x000B39F8 File Offset: 0x000B1BF8
		[CallerCount(0)]
		public unsafe virtual ProfileFeatureDefinition GetFeatureDefinition(string featureKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(featureKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProfileDefinition.NativeMethodInfoPtr_GetFeatureDefinition_Public_Abstract_Virtual_New_ProfileFeatureDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfileFeatureDefinition>(intPtr3) : null;
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x0000CF6D File Offset: 0x0000B16D
		public IProfileDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeMethodInfoPtr_get_shaderName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr_get_features_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_ProfileFeatureSection_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_get_groups_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_ProfileGroupSection_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_GetFeatureDefinition_Public_Abstract_Virtual_New_ProfileFeatureDefinition_String_0;
	}
}
