using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000686 RID: 1670
	public class CameraBobSlider : SettingsSlider
	{
		// Token: 0x060095AA RID: 38314 RVA: 0x00265E80 File Offset: 0x00264080
		// Note: this type is marked as 'beforefieldinit'.
		static CameraBobSlider()
		{
			Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "CameraBobSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr);
			CameraBobSlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr, 100681792);
			CameraBobSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr, 100681793);
			CameraBobSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr, 100681794);
		}

		// Token: 0x060095AB RID: 38315 RVA: 0x00265EEC File Offset: 0x002640EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269045, XrefRangeEnd = 269050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CameraBobSlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095AC RID: 38316 RVA: 0x00265F28 File Offset: 0x00264128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269050, XrefRangeEnd = 269060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CameraBobSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095AD RID: 38317 RVA: 0x00265F74 File Offset: 0x00264174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269060, XrefRangeEnd = 269061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraBobSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraBobSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraBobSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095AE RID: 38318 RVA: 0x00048C55 File Offset: 0x00046E55
		public CameraBobSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040064EC RID: 25836
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040064ED RID: 25837
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x040064EE RID: 25838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
