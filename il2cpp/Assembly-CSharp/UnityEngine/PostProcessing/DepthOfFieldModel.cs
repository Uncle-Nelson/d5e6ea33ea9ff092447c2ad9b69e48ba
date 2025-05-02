using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000064 RID: 100
	[Serializable]
	public class DepthOfFieldModel : PostProcessingModel
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x00086FC4 File Offset: 0x000851C4
		// Note: this type is marked as 'beforefieldinit'.
		static DepthOfFieldModel()
		{
			Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "DepthOfFieldModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr);
			DepthOfFieldModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr, "m_Settings");
			DepthOfFieldModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr, 100664088);
			DepthOfFieldModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr, 100664089);
			DepthOfFieldModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr, 100664090);
			DepthOfFieldModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr, 100664091);
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00087058 File Offset: 0x00085258
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00087094 File Offset: 0x00085294
		public unsafe DepthOfFieldModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x000870D4 File Offset: 0x000852D4
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DepthOfFieldModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00087110 File Offset: 0x00085310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77884, XrefRangeEnd = 77885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DepthOfFieldModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00006103 File Offset: 0x00004303
		public DepthOfFieldModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x0008714C File Offset: 0x0008534C
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x0000610C File Offset: 0x0000430C
		public unsafe DepthOfFieldModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfFieldModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfFieldModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007F6 RID: 2038
		[OriginalName("Assembly-CSharp.dll", "", "KernelSize")]
		public enum KernelSize
		{
			// Token: 0x04007FA4 RID: 32676
			Small,
			// Token: 0x04007FA5 RID: 32677
			Medium,
			// Token: 0x04007FA6 RID: 32678
			Large,
			// Token: 0x04007FA7 RID: 32679
			VeryLarge
		}

		// Token: 0x020007F7 RID: 2039
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BCCF RID: 48335 RVA: 0x002E8884 File Offset: 0x002E6A84
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DepthOfFieldModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr);
				DepthOfFieldModel.Settings.NativeFieldInfoPtr_focusDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr, "focusDistance");
				DepthOfFieldModel.Settings.NativeFieldInfoPtr_aperture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr, "aperture");
				DepthOfFieldModel.Settings.NativeFieldInfoPtr_focalLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr, "focalLength");
				DepthOfFieldModel.Settings.NativeFieldInfoPtr_useCameraFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr, "useCameraFov");
				DepthOfFieldModel.Settings.NativeFieldInfoPtr_kernelSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr, "kernelSize");
				DepthOfFieldModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr, 100664092);
			}

			// Token: 0x17003A88 RID: 14984
			// (get) Token: 0x0600BCD0 RID: 48336 RVA: 0x002E8928 File Offset: 0x002E6B28
			public unsafe static DepthOfFieldModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCD1 RID: 48337 RVA: 0x0005C61B File Offset: 0x0005A81B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DepthOfFieldModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FA8 RID: 32680
			private static readonly IntPtr NativeFieldInfoPtr_focusDistance;

			// Token: 0x04007FA9 RID: 32681
			private static readonly IntPtr NativeFieldInfoPtr_aperture;

			// Token: 0x04007FAA RID: 32682
			private static readonly IntPtr NativeFieldInfoPtr_focalLength;

			// Token: 0x04007FAB RID: 32683
			private static readonly IntPtr NativeFieldInfoPtr_useCameraFov;

			// Token: 0x04007FAC RID: 32684
			private static readonly IntPtr NativeFieldInfoPtr_kernelSize;

			// Token: 0x04007FAD RID: 32685
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007FAE RID: 32686
			[FieldOffset(0)]
			public float focusDistance;

			// Token: 0x04007FAF RID: 32687
			[FieldOffset(4)]
			public float aperture;

			// Token: 0x04007FB0 RID: 32688
			[FieldOffset(8)]
			public float focalLength;

			// Token: 0x04007FB1 RID: 32689
			[FieldOffset(12)]
			[MarshalAs(4)]
			public bool useCameraFov;

			// Token: 0x04007FB2 RID: 32690
			[FieldOffset(16)]
			public DepthOfFieldModel.KernelSize kernelSize;
		}
	}
}
