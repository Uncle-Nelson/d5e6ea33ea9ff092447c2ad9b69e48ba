using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200005F RID: 95
	[Serializable]
	public class AntialiasingModel : PostProcessingModel
	{
		// Token: 0x06000735 RID: 1845 RVA: 0x00086460 File Offset: 0x00084660
		// Note: this type is marked as 'beforefieldinit'.
		static AntialiasingModel()
		{
			Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "AntialiasingModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr);
			AntialiasingModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, "m_Settings");
			AntialiasingModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, 100664039);
			AntialiasingModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, 100664040);
			AntialiasingModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, 100664041);
			AntialiasingModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, 100664042);
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x000864F4 File Offset: 0x000846F4
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x00086530 File Offset: 0x00084730
		public unsafe AntialiasingModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AntialiasingModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AntialiasingModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00086570 File Offset: 0x00084770
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AntialiasingModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000865AC File Offset: 0x000847AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77749, XrefRangeEnd = 77750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AntialiasingModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AntialiasingModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00005FDC File Offset: 0x000041DC
		public AntialiasingModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x000865E8 File Offset: 0x000847E8
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00005FE5 File Offset: 0x000041E5
		public unsafe AntialiasingModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AntialiasingModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AntialiasingModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007DD RID: 2013
		[OriginalName("Assembly-CSharp.dll", "", "Method")]
		public enum Method
		{
			// Token: 0x04007EEB RID: 32491
			Fxaa,
			// Token: 0x04007EEC RID: 32492
			Taa
		}

		// Token: 0x020007DE RID: 2014
		[OriginalName("Assembly-CSharp.dll", "", "FxaaPreset")]
		public enum FxaaPreset
		{
			// Token: 0x04007EEE RID: 32494
			ExtremePerformance,
			// Token: 0x04007EEF RID: 32495
			Performance,
			// Token: 0x04007EF0 RID: 32496
			Default,
			// Token: 0x04007EF1 RID: 32497
			Quality,
			// Token: 0x04007EF2 RID: 32498
			ExtremeQuality
		}

		// Token: 0x020007DF RID: 2015
		[Serializable]
		[StructLayout(2)]
		public struct FxaaQualitySettings
		{
			// Token: 0x0600BC5A RID: 48218 RVA: 0x002E74FC File Offset: 0x002E56FC
			// Note: this type is marked as 'beforefieldinit'.
			static FxaaQualitySettings()
			{
				Il2CppClassPointerStore<AntialiasingModel.FxaaQualitySettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, "FxaaQualitySettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntialiasingModel.FxaaQualitySettings>.NativeClassPtr);
				AntialiasingModel.FxaaQualitySettings.NativeFieldInfoPtr_subpixelAliasingRemovalAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaQualitySettings>.NativeClassPtr, "subpixelAliasingRemovalAmount");
				AntialiasingModel.FxaaQualitySettings.NativeFieldInfoPtr_edgeDetectionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaQualitySettings>.NativeClassPtr, "edgeDetectionThreshold");
				AntialiasingModel.FxaaQualitySettings.NativeFieldInfoPtr_minimumRequiredLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaQualitySettings>.NativeClassPtr, "minimumRequiredLuminance");
				AntialiasingModel.FxaaQualitySettings.NativeFieldInfoPtr_presets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaQualitySettings>.NativeClassPtr, "presets");
			}

			// Token: 0x0600BC5B RID: 48219 RVA: 0x0005C18C File Offset: 0x0005A38C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AntialiasingModel.FxaaQualitySettings>.NativeClassPtr, ref this));
			}

			// Token: 0x17003A5B RID: 14939
			// (get) Token: 0x0600BC5C RID: 48220 RVA: 0x002E7578 File Offset: 0x002E5778
			// (set) Token: 0x0600BC5D RID: 48221 RVA: 0x0005C19E File Offset: 0x0005A39E
			public unsafe static Il2CppStructArray<AntialiasingModel.FxaaQualitySettings> presets
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AntialiasingModel.FxaaQualitySettings.NativeFieldInfoPtr_presets, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AntialiasingModel.FxaaQualitySettings>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AntialiasingModel.FxaaQualitySettings.NativeFieldInfoPtr_presets, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007EF3 RID: 32499
			private static readonly IntPtr NativeFieldInfoPtr_subpixelAliasingRemovalAmount;

			// Token: 0x04007EF4 RID: 32500
			private static readonly IntPtr NativeFieldInfoPtr_edgeDetectionThreshold;

			// Token: 0x04007EF5 RID: 32501
			private static readonly IntPtr NativeFieldInfoPtr_minimumRequiredLuminance;

			// Token: 0x04007EF6 RID: 32502
			private static readonly IntPtr NativeFieldInfoPtr_presets;

			// Token: 0x04007EF7 RID: 32503
			[FieldOffset(0)]
			public float subpixelAliasingRemovalAmount;

			// Token: 0x04007EF8 RID: 32504
			[FieldOffset(4)]
			public float edgeDetectionThreshold;

			// Token: 0x04007EF9 RID: 32505
			[FieldOffset(8)]
			public float minimumRequiredLuminance;
		}

		// Token: 0x020007E0 RID: 2016
		[Serializable]
		[StructLayout(2)]
		public struct FxaaConsoleSettings
		{
			// Token: 0x0600BC5E RID: 48222 RVA: 0x002E75A0 File Offset: 0x002E57A0
			// Note: this type is marked as 'beforefieldinit'.
			static FxaaConsoleSettings()
			{
				Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, "FxaaConsoleSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr);
				AntialiasingModel.FxaaConsoleSettings.NativeFieldInfoPtr_subpixelSpreadAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr, "subpixelSpreadAmount");
				AntialiasingModel.FxaaConsoleSettings.NativeFieldInfoPtr_edgeSharpnessAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr, "edgeSharpnessAmount");
				AntialiasingModel.FxaaConsoleSettings.NativeFieldInfoPtr_edgeDetectionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr, "edgeDetectionThreshold");
				AntialiasingModel.FxaaConsoleSettings.NativeFieldInfoPtr_minimumRequiredLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr, "minimumRequiredLuminance");
				AntialiasingModel.FxaaConsoleSettings.NativeFieldInfoPtr_presets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr, "presets");
			}

			// Token: 0x0600BC5F RID: 48223 RVA: 0x0005C1B0 File Offset: 0x0005A3B0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x17003A5C RID: 14940
			// (get) Token: 0x0600BC60 RID: 48224 RVA: 0x002E7630 File Offset: 0x002E5830
			// (set) Token: 0x0600BC61 RID: 48225 RVA: 0x0005C1C2 File Offset: 0x0005A3C2
			public unsafe static Il2CppStructArray<AntialiasingModel.FxaaConsoleSettings> presets
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AntialiasingModel.FxaaConsoleSettings.NativeFieldInfoPtr_presets, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AntialiasingModel.FxaaConsoleSettings>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AntialiasingModel.FxaaConsoleSettings.NativeFieldInfoPtr_presets, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007EFA RID: 32506
			private static readonly IntPtr NativeFieldInfoPtr_subpixelSpreadAmount;

			// Token: 0x04007EFB RID: 32507
			private static readonly IntPtr NativeFieldInfoPtr_edgeSharpnessAmount;

			// Token: 0x04007EFC RID: 32508
			private static readonly IntPtr NativeFieldInfoPtr_edgeDetectionThreshold;

			// Token: 0x04007EFD RID: 32509
			private static readonly IntPtr NativeFieldInfoPtr_minimumRequiredLuminance;

			// Token: 0x04007EFE RID: 32510
			private static readonly IntPtr NativeFieldInfoPtr_presets;

			// Token: 0x04007EFF RID: 32511
			[FieldOffset(0)]
			public float subpixelSpreadAmount;

			// Token: 0x04007F00 RID: 32512
			[FieldOffset(4)]
			public float edgeSharpnessAmount;

			// Token: 0x04007F01 RID: 32513
			[FieldOffset(8)]
			public float edgeDetectionThreshold;

			// Token: 0x04007F02 RID: 32514
			[FieldOffset(12)]
			public float minimumRequiredLuminance;
		}

		// Token: 0x020007E1 RID: 2017
		[Serializable]
		[StructLayout(2)]
		public struct FxaaSettings
		{
			// Token: 0x0600BC62 RID: 48226 RVA: 0x002E7658 File Offset: 0x002E5858
			// Note: this type is marked as 'beforefieldinit'.
			static FxaaSettings()
			{
				Il2CppClassPointerStore<AntialiasingModel.FxaaSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, "FxaaSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntialiasingModel.FxaaSettings>.NativeClassPtr);
				AntialiasingModel.FxaaSettings.NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaSettings>.NativeClassPtr, "preset");
				AntialiasingModel.FxaaSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_FxaaSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntialiasingModel.FxaaSettings>.NativeClassPtr, 100664045);
			}

			// Token: 0x17003A5D RID: 14941
			// (get) Token: 0x0600BC63 RID: 48227 RVA: 0x002E76AC File Offset: 0x002E58AC
			public unsafe static AntialiasingModel.FxaaSettings defaultSettings
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 77742, RefRangeEnd = 77749, XrefRangeStart = 77742, XrefRangeEnd = 77742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AntialiasingModel.FxaaSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_FxaaSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC64 RID: 48228 RVA: 0x0005C1D4 File Offset: 0x0005A3D4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AntialiasingModel.FxaaSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F03 RID: 32515
			private static readonly IntPtr NativeFieldInfoPtr_preset;

			// Token: 0x04007F04 RID: 32516
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_FxaaSettings_0;

			// Token: 0x04007F05 RID: 32517
			[FieldOffset(0)]
			public AntialiasingModel.FxaaPreset preset;
		}

		// Token: 0x020007E2 RID: 2018
		[Serializable]
		[StructLayout(2)]
		public struct TaaSettings
		{
			// Token: 0x0600BC65 RID: 48229 RVA: 0x002E76DC File Offset: 0x002E58DC
			// Note: this type is marked as 'beforefieldinit'.
			static TaaSettings()
			{
				Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, "TaaSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr);
				AntialiasingModel.TaaSettings.NativeFieldInfoPtr_jitterSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr, "jitterSpread");
				AntialiasingModel.TaaSettings.NativeFieldInfoPtr_sharpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr, "sharpen");
				AntialiasingModel.TaaSettings.NativeFieldInfoPtr_stationaryBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr, "stationaryBlending");
				AntialiasingModel.TaaSettings.NativeFieldInfoPtr_motionBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr, "motionBlending");
				AntialiasingModel.TaaSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_TaaSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr, 100664046);
			}

			// Token: 0x17003A5E RID: 14942
			// (get) Token: 0x0600BC66 RID: 48230 RVA: 0x002E776C File Offset: 0x002E596C
			public unsafe static AntialiasingModel.TaaSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AntialiasingModel.TaaSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_TaaSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC67 RID: 48231 RVA: 0x0005C1E6 File Offset: 0x0005A3E6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F06 RID: 32518
			private static readonly IntPtr NativeFieldInfoPtr_jitterSpread;

			// Token: 0x04007F07 RID: 32519
			private static readonly IntPtr NativeFieldInfoPtr_sharpen;

			// Token: 0x04007F08 RID: 32520
			private static readonly IntPtr NativeFieldInfoPtr_stationaryBlending;

			// Token: 0x04007F09 RID: 32521
			private static readonly IntPtr NativeFieldInfoPtr_motionBlending;

			// Token: 0x04007F0A RID: 32522
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_TaaSettings_0;

			// Token: 0x04007F0B RID: 32523
			[FieldOffset(0)]
			public float jitterSpread;

			// Token: 0x04007F0C RID: 32524
			[FieldOffset(4)]
			public float sharpen;

			// Token: 0x04007F0D RID: 32525
			[FieldOffset(8)]
			public float stationaryBlending;

			// Token: 0x04007F0E RID: 32526
			[FieldOffset(12)]
			public float motionBlending;
		}

		// Token: 0x020007E3 RID: 2019
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BC68 RID: 48232 RVA: 0x002E779C File Offset: 0x002E599C
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<AntialiasingModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntialiasingModel.Settings>.NativeClassPtr);
				AntialiasingModel.Settings.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.Settings>.NativeClassPtr, "method");
				AntialiasingModel.Settings.NativeFieldInfoPtr_fxaaSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.Settings>.NativeClassPtr, "fxaaSettings");
				AntialiasingModel.Settings.NativeFieldInfoPtr_taaSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.Settings>.NativeClassPtr, "taaSettings");
				AntialiasingModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntialiasingModel.Settings>.NativeClassPtr, 100664047);
			}

			// Token: 0x17003A5F RID: 14943
			// (get) Token: 0x0600BC69 RID: 48233 RVA: 0x002E7818 File Offset: 0x002E5A18
			public unsafe static AntialiasingModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AntialiasingModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC6A RID: 48234 RVA: 0x0005C1F8 File Offset: 0x0005A3F8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AntialiasingModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F0F RID: 32527
			private static readonly IntPtr NativeFieldInfoPtr_method;

			// Token: 0x04007F10 RID: 32528
			private static readonly IntPtr NativeFieldInfoPtr_fxaaSettings;

			// Token: 0x04007F11 RID: 32529
			private static readonly IntPtr NativeFieldInfoPtr_taaSettings;

			// Token: 0x04007F12 RID: 32530
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007F13 RID: 32531
			[FieldOffset(0)]
			public AntialiasingModel.Method method;

			// Token: 0x04007F14 RID: 32532
			[FieldOffset(4)]
			public AntialiasingModel.FxaaSettings fxaaSettings;

			// Token: 0x04007F15 RID: 32533
			[FieldOffset(8)]
			public AntialiasingModel.TaaSettings taaSettings;
		}
	}
}
