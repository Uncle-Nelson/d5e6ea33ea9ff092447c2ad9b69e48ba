using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000692 RID: 1682
	public class SensitivitySlider : SettingsSlider
	{
		// Token: 0x0600960C RID: 38412 RVA: 0x002673F4 File Offset: 0x002655F4
		// Note: this type is marked as 'beforefieldinit'.
		static SensitivitySlider()
		{
			Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SensitivitySlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr);
			SensitivitySlider.NativeFieldInfoPtr_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, "MULTIPLIER");
			SensitivitySlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, 100681850);
			SensitivitySlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, 100681851);
			SensitivitySlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, 100681852);
		}

		// Token: 0x0600960D RID: 38413 RVA: 0x00267474 File Offset: 0x00265674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269528, XrefRangeEnd = 269533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SensitivitySlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600960E RID: 38414 RVA: 0x002674B0 File Offset: 0x002656B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269533, XrefRangeEnd = 269550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SensitivitySlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600960F RID: 38415 RVA: 0x002674FC File Offset: 0x002656FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SensitivitySlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensitivitySlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009610 RID: 38416 RVA: 0x00048DC6 File Offset: 0x00046FC6
		public SensitivitySlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x06009611 RID: 38417 RVA: 0x00267538 File Offset: 0x00265738
		// (set) Token: 0x06009612 RID: 38418 RVA: 0x00048DCF File Offset: 0x00046FCF
		public unsafe static float MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SensitivitySlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SensitivitySlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x0400652B RID: 25899
		private static readonly IntPtr NativeFieldInfoPtr_MULTIPLIER;

		// Token: 0x0400652C RID: 25900
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400652D RID: 25901
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x0400652E RID: 25902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
