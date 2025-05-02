using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000693 RID: 1683
	public class SettingsDropdown : MonoBehaviour
	{
		// Token: 0x06009613 RID: 38419 RVA: 0x00267554 File Offset: 0x00265754
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsDropdown()
		{
			Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SettingsDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr);
			SettingsDropdown.NativeFieldInfoPtr_DefaultOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, "DefaultOptions");
			SettingsDropdown.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, "dropdown");
			SettingsDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100681853);
			SettingsDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100681854);
			SettingsDropdown.NativeMethodInfoPtr_AddOption_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100681855);
			SettingsDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100681856);
		}

		// Token: 0x06009614 RID: 38420 RVA: 0x002675FC File Offset: 0x002657FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 269563, RefRangeEnd = 269569, XrefRangeStart = 269550, XrefRangeEnd = 269563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009615 RID: 38421 RVA: 0x00267638 File Offset: 0x00265838
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValueChanged(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009616 RID: 38422 RVA: 0x00267684 File Offset: 0x00265884
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 269580, RefRangeEnd = 269587, XrefRangeStart = 269569, XrefRangeEnd = 269580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOption(string option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsDropdown.NativeMethodInfoPtr_AddOption_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009617 RID: 38423 RVA: 0x002676C8 File Offset: 0x002658C8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsDropdown() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009618 RID: 38424 RVA: 0x00048DDD File Offset: 0x00046FDD
		public SettingsDropdown(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x06009619 RID: 38425 RVA: 0x00267704 File Offset: 0x00265904
		// (set) Token: 0x0600961A RID: 38426 RVA: 0x00048DE6 File Offset: 0x00046FE6
		public unsafe Il2CppStringArray DefaultOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr_DefaultOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr_DefaultOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x0600961B RID: 38427 RVA: 0x00267734 File Offset: 0x00265934
		// (set) Token: 0x0600961C RID: 38428 RVA: 0x00048E05 File Offset: 0x00047005
		public unsafe TMP_Dropdown dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr_dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400652F RID: 25903
		private static readonly IntPtr NativeFieldInfoPtr_DefaultOptions;

		// Token: 0x04006530 RID: 25904
		private static readonly IntPtr NativeFieldInfoPtr_dropdown;

		// Token: 0x04006531 RID: 25905
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006532 RID: 25906
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04006533 RID: 25907
		private static readonly IntPtr NativeMethodInfoPtr_AddOption_Protected_Void_String_0;

		// Token: 0x04006534 RID: 25908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
