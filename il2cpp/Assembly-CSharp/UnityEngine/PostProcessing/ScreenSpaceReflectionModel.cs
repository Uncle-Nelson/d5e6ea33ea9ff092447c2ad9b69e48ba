using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200006A RID: 106
	[Serializable]
	public class ScreenSpaceReflectionModel : PostProcessingModel
	{
		// Token: 0x06000798 RID: 1944 RVA: 0x000879E4 File Offset: 0x00085BE4
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenSpaceReflectionModel()
		{
			Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "ScreenSpaceReflectionModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr);
			ScreenSpaceReflectionModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, "m_Settings");
			ScreenSpaceReflectionModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, 100664118);
			ScreenSpaceReflectionModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, 100664119);
			ScreenSpaceReflectionModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, 100664120);
			ScreenSpaceReflectionModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, 100664121);
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00087A78 File Offset: 0x00085C78
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x00087AB4 File Offset: 0x00085CB4
		public unsafe ScreenSpaceReflectionModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00087AF4 File Offset: 0x00085CF4
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceReflectionModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00087B30 File Offset: 0x00085D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77890, XrefRangeEnd = 77891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenSpaceReflectionModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000061DB File Offset: 0x000043DB
		public ScreenSpaceReflectionModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00087B6C File Offset: 0x00085D6C
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x000061E4 File Offset: 0x000043E4
		public unsafe ScreenSpaceReflectionModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007FE RID: 2046
		[OriginalName("Assembly-CSharp.dll", "", "SSRResolution")]
		public enum SSRResolution
		{
			// Token: 0x04007FE2 RID: 32738
			High,
			// Token: 0x04007FE3 RID: 32739
			Low = 2
		}

		// Token: 0x020007FF RID: 2047
		[OriginalName("Assembly-CSharp.dll", "", "SSRReflectionBlendType")]
		public enum SSRReflectionBlendType
		{
			// Token: 0x04007FE5 RID: 32741
			PhysicallyBased,
			// Token: 0x04007FE6 RID: 32742
			Additive
		}

		// Token: 0x02000800 RID: 2048
		[Serializable]
		[StructLayout(2)]
		public struct IntensitySettings
		{
			// Token: 0x0600BCE1 RID: 48353 RVA: 0x002E8CC4 File Offset: 0x002E6EC4
			// Note: this type is marked as 'beforefieldinit'.
			static IntensitySettings()
			{
				Il2CppClassPointerStore<ScreenSpaceReflectionModel.IntensitySettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, "IntensitySettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionModel.IntensitySettings>.NativeClassPtr);
				ScreenSpaceReflectionModel.IntensitySettings.NativeFieldInfoPtr_reflectionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.IntensitySettings>.NativeClassPtr, "reflectionMultiplier");
				ScreenSpaceReflectionModel.IntensitySettings.NativeFieldInfoPtr_fadeDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.IntensitySettings>.NativeClassPtr, "fadeDistance");
				ScreenSpaceReflectionModel.IntensitySettings.NativeFieldInfoPtr_fresnelFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.IntensitySettings>.NativeClassPtr, "fresnelFade");
				ScreenSpaceReflectionModel.IntensitySettings.NativeFieldInfoPtr_fresnelFadePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.IntensitySettings>.NativeClassPtr, "fresnelFadePower");
			}

			// Token: 0x0600BCE2 RID: 48354 RVA: 0x0005C6BB File Offset: 0x0005A8BB
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenSpaceReflectionModel.IntensitySettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FE7 RID: 32743
			private static readonly IntPtr NativeFieldInfoPtr_reflectionMultiplier;

			// Token: 0x04007FE8 RID: 32744
			private static readonly IntPtr NativeFieldInfoPtr_fadeDistance;

			// Token: 0x04007FE9 RID: 32745
			private static readonly IntPtr NativeFieldInfoPtr_fresnelFade;

			// Token: 0x04007FEA RID: 32746
			private static readonly IntPtr NativeFieldInfoPtr_fresnelFadePower;

			// Token: 0x04007FEB RID: 32747
			[FieldOffset(0)]
			public float reflectionMultiplier;

			// Token: 0x04007FEC RID: 32748
			[FieldOffset(4)]
			public float fadeDistance;

			// Token: 0x04007FED RID: 32749
			[FieldOffset(8)]
			public float fresnelFade;

			// Token: 0x04007FEE RID: 32750
			[FieldOffset(12)]
			public float fresnelFadePower;
		}

		// Token: 0x02000801 RID: 2049
		[Serializable]
		[StructLayout(2)]
		public struct ReflectionSettings
		{
			// Token: 0x0600BCE3 RID: 48355 RVA: 0x002E8D40 File Offset: 0x002E6F40
			// Note: this type is marked as 'beforefieldinit'.
			static ReflectionSettings()
			{
				Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, "ReflectionSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr);
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_blendType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "blendType");
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_reflectionQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "reflectionQuality");
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "maxDistance");
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_iterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "iterationCount");
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_stepSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "stepSize");
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_widthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "widthModifier");
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_reflectionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "reflectionBlur");
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_reflectBackfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "reflectBackfaces");
			}

			// Token: 0x0600BCE4 RID: 48356 RVA: 0x0005C6CD File Offset: 0x0005A8CD
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FEF RID: 32751
			private static readonly IntPtr NativeFieldInfoPtr_blendType;

			// Token: 0x04007FF0 RID: 32752
			private static readonly IntPtr NativeFieldInfoPtr_reflectionQuality;

			// Token: 0x04007FF1 RID: 32753
			private static readonly IntPtr NativeFieldInfoPtr_maxDistance;

			// Token: 0x04007FF2 RID: 32754
			private static readonly IntPtr NativeFieldInfoPtr_iterationCount;

			// Token: 0x04007FF3 RID: 32755
			private static readonly IntPtr NativeFieldInfoPtr_stepSize;

			// Token: 0x04007FF4 RID: 32756
			private static readonly IntPtr NativeFieldInfoPtr_widthModifier;

			// Token: 0x04007FF5 RID: 32757
			private static readonly IntPtr NativeFieldInfoPtr_reflectionBlur;

			// Token: 0x04007FF6 RID: 32758
			private static readonly IntPtr NativeFieldInfoPtr_reflectBackfaces;

			// Token: 0x04007FF7 RID: 32759
			[FieldOffset(0)]
			public ScreenSpaceReflectionModel.SSRReflectionBlendType blendType;

			// Token: 0x04007FF8 RID: 32760
			[FieldOffset(4)]
			public ScreenSpaceReflectionModel.SSRResolution reflectionQuality;

			// Token: 0x04007FF9 RID: 32761
			[FieldOffset(8)]
			public float maxDistance;

			// Token: 0x04007FFA RID: 32762
			[FieldOffset(12)]
			public int iterationCount;

			// Token: 0x04007FFB RID: 32763
			[FieldOffset(16)]
			public int stepSize;

			// Token: 0x04007FFC RID: 32764
			[FieldOffset(20)]
			public float widthModifier;

			// Token: 0x04007FFD RID: 32765
			[FieldOffset(24)]
			public float reflectionBlur;

			// Token: 0x04007FFE RID: 32766
			[FieldOffset(28)]
			[MarshalAs(4)]
			public bool reflectBackfaces;
		}

		// Token: 0x02000802 RID: 2050
		[Serializable]
		[StructLayout(2)]
		public struct ScreenEdgeMask
		{
			// Token: 0x0600BCE5 RID: 48357 RVA: 0x0005C6DF File Offset: 0x0005A8DF
			// Note: this type is marked as 'beforefieldinit'.
			static ScreenEdgeMask()
			{
				Il2CppClassPointerStore<ScreenSpaceReflectionModel.ScreenEdgeMask>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, "ScreenEdgeMask");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ScreenEdgeMask>.NativeClassPtr);
				ScreenSpaceReflectionModel.ScreenEdgeMask.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ScreenEdgeMask>.NativeClassPtr, "intensity");
			}

			// Token: 0x0600BCE6 RID: 48358 RVA: 0x0005C713 File Offset: 0x0005A913
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ScreenEdgeMask>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FFF RID: 32767
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04008000 RID: 32768
			[FieldOffset(0)]
			public float intensity;
		}

		// Token: 0x02000803 RID: 2051
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BCE7 RID: 48359 RVA: 0x002E8E0C File Offset: 0x002E700C
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<ScreenSpaceReflectionModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionModel.Settings>.NativeClassPtr);
				ScreenSpaceReflectionModel.Settings.NativeFieldInfoPtr_reflection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.Settings>.NativeClassPtr, "reflection");
				ScreenSpaceReflectionModel.Settings.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.Settings>.NativeClassPtr, "intensity");
				ScreenSpaceReflectionModel.Settings.NativeFieldInfoPtr_screenEdgeMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.Settings>.NativeClassPtr, "screenEdgeMask");
				ScreenSpaceReflectionModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionModel.Settings>.NativeClassPtr, 100664122);
			}

			// Token: 0x17003A8E RID: 14990
			// (get) Token: 0x0600BCE8 RID: 48360 RVA: 0x002E8E88 File Offset: 0x002E7088
			public unsafe static ScreenSpaceReflectionModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCE9 RID: 48361 RVA: 0x0005C725 File Offset: 0x0005A925
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenSpaceReflectionModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04008001 RID: 32769
			private static readonly IntPtr NativeFieldInfoPtr_reflection;

			// Token: 0x04008002 RID: 32770
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04008003 RID: 32771
			private static readonly IntPtr NativeFieldInfoPtr_screenEdgeMask;

			// Token: 0x04008004 RID: 32772
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04008005 RID: 32773
			[FieldOffset(0)]
			public ScreenSpaceReflectionModel.ReflectionSettings reflection;

			// Token: 0x04008006 RID: 32774
			[FieldOffset(32)]
			public ScreenSpaceReflectionModel.IntensitySettings intensity;

			// Token: 0x04008007 RID: 32775
			[FieldOffset(48)]
			public ScreenSpaceReflectionModel.ScreenEdgeMask screenEdgeMask;
		}
	}
}
