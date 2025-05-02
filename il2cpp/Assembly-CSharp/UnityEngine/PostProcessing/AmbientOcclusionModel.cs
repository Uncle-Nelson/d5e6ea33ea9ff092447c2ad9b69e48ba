using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200005E RID: 94
	[Serializable]
	public class AmbientOcclusionModel : PostProcessingModel
	{
		// Token: 0x0600072D RID: 1837 RVA: 0x000862B0 File Offset: 0x000844B0
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientOcclusionModel()
		{
			Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "AmbientOcclusionModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr);
			AmbientOcclusionModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr, "m_Settings");
			AmbientOcclusionModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr, 100664034);
			AmbientOcclusionModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr, 100664035);
			AmbientOcclusionModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr, 100664036);
			AmbientOcclusionModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr, 100664037);
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00086344 File Offset: 0x00084544
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00086380 File Offset: 0x00084580
		public unsafe AmbientOcclusionModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000863C0 File Offset: 0x000845C0
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AmbientOcclusionModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000863FC File Offset: 0x000845FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77741, XrefRangeEnd = 77742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientOcclusionModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00005FB8 File Offset: 0x000041B8
		public AmbientOcclusionModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00086438 File Offset: 0x00084638
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00005FC1 File Offset: 0x000041C1
		public unsafe AmbientOcclusionModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusionModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusionModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007DB RID: 2011
		[OriginalName("Assembly-CSharp.dll", "", "SampleCount")]
		public enum SampleCount
		{
			// Token: 0x04007ED7 RID: 32471
			Lowest = 3,
			// Token: 0x04007ED8 RID: 32472
			Low = 6,
			// Token: 0x04007ED9 RID: 32473
			Medium = 10,
			// Token: 0x04007EDA RID: 32474
			High = 16
		}

		// Token: 0x020007DC RID: 2012
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BC57 RID: 48215 RVA: 0x002E7400 File Offset: 0x002E5600
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr);
				AmbientOcclusionModel.Settings.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, "intensity");
				AmbientOcclusionModel.Settings.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, "radius");
				AmbientOcclusionModel.Settings.NativeFieldInfoPtr_sampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, "sampleCount");
				AmbientOcclusionModel.Settings.NativeFieldInfoPtr_downsampling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, "downsampling");
				AmbientOcclusionModel.Settings.NativeFieldInfoPtr_forceForwardCompatibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, "forceForwardCompatibility");
				AmbientOcclusionModel.Settings.NativeFieldInfoPtr_ambientOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, "ambientOnly");
				AmbientOcclusionModel.Settings.NativeFieldInfoPtr_highPrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, "highPrecision");
				AmbientOcclusionModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, 100664038);
			}

			// Token: 0x17003A5A RID: 14938
			// (get) Token: 0x0600BC58 RID: 48216 RVA: 0x002E74CC File Offset: 0x002E56CC
			public unsafe static AmbientOcclusionModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC59 RID: 48217 RVA: 0x0005C17A File Offset: 0x0005A37A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007EDB RID: 32475
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04007EDC RID: 32476
			private static readonly IntPtr NativeFieldInfoPtr_radius;

			// Token: 0x04007EDD RID: 32477
			private static readonly IntPtr NativeFieldInfoPtr_sampleCount;

			// Token: 0x04007EDE RID: 32478
			private static readonly IntPtr NativeFieldInfoPtr_downsampling;

			// Token: 0x04007EDF RID: 32479
			private static readonly IntPtr NativeFieldInfoPtr_forceForwardCompatibility;

			// Token: 0x04007EE0 RID: 32480
			private static readonly IntPtr NativeFieldInfoPtr_ambientOnly;

			// Token: 0x04007EE1 RID: 32481
			private static readonly IntPtr NativeFieldInfoPtr_highPrecision;

			// Token: 0x04007EE2 RID: 32482
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007EE3 RID: 32483
			[FieldOffset(0)]
			public float intensity;

			// Token: 0x04007EE4 RID: 32484
			[FieldOffset(4)]
			public float radius;

			// Token: 0x04007EE5 RID: 32485
			[FieldOffset(8)]
			public AmbientOcclusionModel.SampleCount sampleCount;

			// Token: 0x04007EE6 RID: 32486
			[FieldOffset(12)]
			[MarshalAs(4)]
			public bool downsampling;

			// Token: 0x04007EE7 RID: 32487
			[FieldOffset(13)]
			[MarshalAs(4)]
			public bool forceForwardCompatibility;

			// Token: 0x04007EE8 RID: 32488
			[FieldOffset(14)]
			[MarshalAs(4)]
			public bool ambientOnly;

			// Token: 0x04007EE9 RID: 32489
			[FieldOffset(15)]
			[MarshalAs(4)]
			public bool highPrecision;
		}
	}
}
