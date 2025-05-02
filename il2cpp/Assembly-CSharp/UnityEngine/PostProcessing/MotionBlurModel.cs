using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000069 RID: 105
	[Serializable]
	public class MotionBlurModel : PostProcessingModel
	{
		// Token: 0x06000790 RID: 1936 RVA: 0x00087834 File Offset: 0x00085A34
		// Note: this type is marked as 'beforefieldinit'.
		static MotionBlurModel()
		{
			Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "MotionBlurModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr);
			MotionBlurModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr, "m_Settings");
			MotionBlurModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr, 100664113);
			MotionBlurModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr, 100664114);
			MotionBlurModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr, 100664115);
			MotionBlurModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr, 100664116);
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x000878C8 File Offset: 0x00085AC8
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x00087904 File Offset: 0x00085B04
		public unsafe MotionBlurModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00087944 File Offset: 0x00085B44
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MotionBlurModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00087980 File Offset: 0x00085B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77889, XrefRangeEnd = 77890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionBlurModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000061B7 File Offset: 0x000043B7
		public MotionBlurModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x000879BC File Offset: 0x00085BBC
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x000061C0 File Offset: 0x000043C0
		public unsafe MotionBlurModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007FD RID: 2045
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BCDE RID: 48350 RVA: 0x002E8C18 File Offset: 0x002E6E18
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<MotionBlurModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurModel.Settings>.NativeClassPtr);
				MotionBlurModel.Settings.NativeFieldInfoPtr_shutterAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurModel.Settings>.NativeClassPtr, "shutterAngle");
				MotionBlurModel.Settings.NativeFieldInfoPtr_sampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurModel.Settings>.NativeClassPtr, "sampleCount");
				MotionBlurModel.Settings.NativeFieldInfoPtr_frameBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurModel.Settings>.NativeClassPtr, "frameBlending");
				MotionBlurModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurModel.Settings>.NativeClassPtr, 100664117);
			}

			// Token: 0x17003A8D RID: 14989
			// (get) Token: 0x0600BCDF RID: 48351 RVA: 0x002E8C94 File Offset: 0x002E6E94
			public unsafe static MotionBlurModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCE0 RID: 48352 RVA: 0x0005C6A9 File Offset: 0x0005A8A9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MotionBlurModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FDA RID: 32730
			private static readonly IntPtr NativeFieldInfoPtr_shutterAngle;

			// Token: 0x04007FDB RID: 32731
			private static readonly IntPtr NativeFieldInfoPtr_sampleCount;

			// Token: 0x04007FDC RID: 32732
			private static readonly IntPtr NativeFieldInfoPtr_frameBlending;

			// Token: 0x04007FDD RID: 32733
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007FDE RID: 32734
			[FieldOffset(0)]
			public float shutterAngle;

			// Token: 0x04007FDF RID: 32735
			[FieldOffset(4)]
			public int sampleCount;

			// Token: 0x04007FE0 RID: 32736
			[FieldOffset(8)]
			public float frameBlending;
		}
	}
}
