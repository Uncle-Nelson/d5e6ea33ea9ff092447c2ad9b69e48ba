using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management.Presets;
using UnityEngine;

namespace Il2CppScheduleOne.Management.Objects
{
	// Token: 0x020003B2 RID: 946
	public class ManageableObject : MonoBehaviour
	{
		// Token: 0x060049CD RID: 18893 RVA: 0x001672A0 File Offset: 0x001654A0
		// Note: this type is marked as 'beforefieldinit'.
		static ManageableObject()
		{
			Il2CppClassPointerStore<ManageableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Objects", "ManageableObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr);
			ManageableObject.NativeMethodInfoPtr_GetObjectType_Public_Abstract_Virtual_New_ManageableObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr, 100672451);
			ManageableObject.NativeMethodInfoPtr_GetCurrentPreset_Public_Abstract_Virtual_New_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr, 100672452);
			ManageableObject.NativeMethodInfoPtr_SetPreset_Public_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr, 100672453);
			ManageableObject.NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_New_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr, 100672454);
			ManageableObject.NativeMethodInfoPtr_ExistingPresetDeleted_Public_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr, 100672455);
			ManageableObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr, 100672456);
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x00167348 File Offset: 0x00165548
		[CallerCount(0)]
		public unsafe virtual ManageableObjectType GetObjectType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageableObject.NativeMethodInfoPtr_GetObjectType_Public_Abstract_Virtual_New_ManageableObjectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x00167390 File Offset: 0x00165590
		[CallerCount(0)]
		public unsafe virtual Preset GetCurrentPreset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageableObject.NativeMethodInfoPtr_GetCurrentPreset_Public_Abstract_Virtual_New_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr3) : null;
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x001673DC File Offset: 0x001655DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163694, XrefRangeEnd = 163708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPreset(Preset newPreset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newPreset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManageableObject.NativeMethodInfoPtr_SetPreset_Public_Void_Preset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x00167420 File Offset: 0x00165620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163708, XrefRangeEnd = 163722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPreset_Internal(Preset preset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageableObject.NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_New_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D2 RID: 18898 RVA: 0x00167470 File Offset: 0x00165670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExistingPresetDeleted(Preset replacement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replacement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManageableObject.NativeMethodInfoPtr_ExistingPresetDeleted_Public_Void_Preset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D3 RID: 18899 RVA: 0x001674B4 File Offset: 0x001656B4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManageableObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManageableObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManageableObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D4 RID: 18900 RVA: 0x00023918 File Offset: 0x00021B18
		public ManageableObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040031C3 RID: 12739
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectType_Public_Abstract_Virtual_New_ManageableObjectType_0;

		// Token: 0x040031C4 RID: 12740
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPreset_Public_Abstract_Virtual_New_Preset_0;

		// Token: 0x040031C5 RID: 12741
		private static readonly IntPtr NativeMethodInfoPtr_SetPreset_Public_Void_Preset_0;

		// Token: 0x040031C6 RID: 12742
		private static readonly IntPtr NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_New_Void_Preset_0;

		// Token: 0x040031C7 RID: 12743
		private static readonly IntPtr NativeMethodInfoPtr_ExistingPresetDeleted_Public_Void_Preset_0;

		// Token: 0x040031C8 RID: 12744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
