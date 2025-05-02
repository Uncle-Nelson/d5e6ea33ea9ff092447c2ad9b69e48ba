using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000063 RID: 99
	[Serializable]
	public class ColorGradingModel : PostProcessingModel
	{
		// Token: 0x06000757 RID: 1879 RVA: 0x00086BE8 File Offset: 0x00084DE8
		// Note: this type is marked as 'beforefieldinit'.
		static ColorGradingModel()
		{
			Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "ColorGradingModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr);
			ColorGradingModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "m_Settings");
			ColorGradingModel.NativeFieldInfoPtr__isDirty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "<isDirty>k__BackingField");
			ColorGradingModel.NativeFieldInfoPtr__bakedLut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "<bakedLut>k__BackingField");
			ColorGradingModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664071);
			ColorGradingModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664072);
			ColorGradingModel.NativeMethodInfoPtr_get_isDirty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664073);
			ColorGradingModel.NativeMethodInfoPtr_set_isDirty_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664074);
			ColorGradingModel.NativeMethodInfoPtr_get_bakedLut_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664075);
			ColorGradingModel.NativeMethodInfoPtr_set_bakedLut_Internal_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664076);
			ColorGradingModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664077);
			ColorGradingModel.NativeMethodInfoPtr_OnValidate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664078);
			ColorGradingModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664079);
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00086D08 File Offset: 0x00084F08
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00086D40 File Offset: 0x00084F40
		public unsafe ColorGradingModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ColorGradingModel.Settings(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77877, XrefRangeEnd = 77878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00086D88 File Offset: 0x00084F88
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x00086DC4 File Offset: 0x00084FC4
		public unsafe bool isDirty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.NativeMethodInfoPtr_get_isDirty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.NativeMethodInfoPtr_set_isDirty_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00086E04 File Offset: 0x00085004
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x00086E44 File Offset: 0x00085044
		public unsafe RenderTexture bakedLut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.NativeMethodInfoPtr_get_bakedLut_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77878, XrefRangeEnd = 77879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.NativeMethodInfoPtr_set_bakedLut_Internal_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00086E88 File Offset: 0x00085088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77879, XrefRangeEnd = 77881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorGradingModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00086EC4 File Offset: 0x000850C4
		[CallerCount(0)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorGradingModel.NativeMethodInfoPtr_OnValidate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00086F00 File Offset: 0x00085100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77881, XrefRangeEnd = 77884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorGradingModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00006092 File Offset: 0x00004292
		public ColorGradingModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00086F3C File Offset: 0x0008513C
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x0000609B File Offset: 0x0000429B
		public ColorGradingModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.NativeFieldInfoPtr_m_Settings);
				return new ColorGradingModel.Settings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.NativeFieldInfoPtr_m_Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00086F6C File Offset: 0x0008516C
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x000060C9 File Offset: 0x000042C9
		public unsafe bool _isDirty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.NativeFieldInfoPtr__isDirty_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.NativeFieldInfoPtr__isDirty_k__BackingField)) = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00086F94 File Offset: 0x00085194
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x000060E4 File Offset: 0x000042E4
		public unsafe RenderTexture _bakedLut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.NativeFieldInfoPtr__bakedLut_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.NativeFieldInfoPtr__bakedLut_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeFieldInfoPtr__isDirty_k__BackingField;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeFieldInfoPtr__bakedLut_k__BackingField;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_get_isDirty_Public_get_Boolean_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_set_isDirty_Internal_set_Void_Boolean_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_get_bakedLut_Public_get_RenderTexture_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_set_bakedLut_Internal_set_Void_RenderTexture_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Virtual_Void_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007EC RID: 2028
		[OriginalName("Assembly-CSharp.dll", "", "Tonemapper")]
		public enum Tonemapper
		{
			// Token: 0x04007F4F RID: 32591
			None,
			// Token: 0x04007F50 RID: 32592
			ACES,
			// Token: 0x04007F51 RID: 32593
			Neutral
		}

		// Token: 0x020007ED RID: 2029
		[Serializable]
		[StructLayout(2)]
		public struct TonemappingSettings
		{
			// Token: 0x0600BC91 RID: 48273 RVA: 0x002E7E84 File Offset: 0x002E6084
			// Note: this type is marked as 'beforefieldinit'.
			static TonemappingSettings()
			{
				Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "TonemappingSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr);
				ColorGradingModel.TonemappingSettings.NativeFieldInfoPtr_tonemapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, "tonemapper");
				ColorGradingModel.TonemappingSettings.NativeFieldInfoPtr_neutralBlackIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, "neutralBlackIn");
				ColorGradingModel.TonemappingSettings.NativeFieldInfoPtr_neutralWhiteIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, "neutralWhiteIn");
				ColorGradingModel.TonemappingSettings.NativeFieldInfoPtr_neutralBlackOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, "neutralBlackOut");
				ColorGradingModel.TonemappingSettings.NativeFieldInfoPtr_neutralWhiteOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, "neutralWhiteOut");
				ColorGradingModel.TonemappingSettings.NativeFieldInfoPtr_neutralWhiteLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, "neutralWhiteLevel");
				ColorGradingModel.TonemappingSettings.NativeFieldInfoPtr_neutralWhiteClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, "neutralWhiteClip");
				ColorGradingModel.TonemappingSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_TonemappingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, 100664080);
			}

			// Token: 0x17003A6E RID: 14958
			// (get) Token: 0x0600BC92 RID: 48274 RVA: 0x002E7F50 File Offset: 0x002E6150
			public unsafe static ColorGradingModel.TonemappingSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.TonemappingSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_TonemappingSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC93 RID: 48275 RVA: 0x0005C360 File Offset: 0x0005A560
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F52 RID: 32594
			private static readonly IntPtr NativeFieldInfoPtr_tonemapper;

			// Token: 0x04007F53 RID: 32595
			private static readonly IntPtr NativeFieldInfoPtr_neutralBlackIn;

			// Token: 0x04007F54 RID: 32596
			private static readonly IntPtr NativeFieldInfoPtr_neutralWhiteIn;

			// Token: 0x04007F55 RID: 32597
			private static readonly IntPtr NativeFieldInfoPtr_neutralBlackOut;

			// Token: 0x04007F56 RID: 32598
			private static readonly IntPtr NativeFieldInfoPtr_neutralWhiteOut;

			// Token: 0x04007F57 RID: 32599
			private static readonly IntPtr NativeFieldInfoPtr_neutralWhiteLevel;

			// Token: 0x04007F58 RID: 32600
			private static readonly IntPtr NativeFieldInfoPtr_neutralWhiteClip;

			// Token: 0x04007F59 RID: 32601
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_TonemappingSettings_0;

			// Token: 0x04007F5A RID: 32602
			[FieldOffset(0)]
			public ColorGradingModel.Tonemapper tonemapper;

			// Token: 0x04007F5B RID: 32603
			[FieldOffset(4)]
			public float neutralBlackIn;

			// Token: 0x04007F5C RID: 32604
			[FieldOffset(8)]
			public float neutralWhiteIn;

			// Token: 0x04007F5D RID: 32605
			[FieldOffset(12)]
			public float neutralBlackOut;

			// Token: 0x04007F5E RID: 32606
			[FieldOffset(16)]
			public float neutralWhiteOut;

			// Token: 0x04007F5F RID: 32607
			[FieldOffset(20)]
			public float neutralWhiteLevel;

			// Token: 0x04007F60 RID: 32608
			[FieldOffset(24)]
			public float neutralWhiteClip;
		}

		// Token: 0x020007EE RID: 2030
		[Serializable]
		[StructLayout(2)]
		public struct BasicSettings
		{
			// Token: 0x0600BC94 RID: 48276 RVA: 0x002E7F80 File Offset: 0x002E6180
			// Note: this type is marked as 'beforefieldinit'.
			static BasicSettings()
			{
				Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "BasicSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr);
				ColorGradingModel.BasicSettings.NativeFieldInfoPtr_postExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, "postExposure");
				ColorGradingModel.BasicSettings.NativeFieldInfoPtr_temperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, "temperature");
				ColorGradingModel.BasicSettings.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, "tint");
				ColorGradingModel.BasicSettings.NativeFieldInfoPtr_hueShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, "hueShift");
				ColorGradingModel.BasicSettings.NativeFieldInfoPtr_saturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, "saturation");
				ColorGradingModel.BasicSettings.NativeFieldInfoPtr_contrast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, "contrast");
				ColorGradingModel.BasicSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_BasicSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, 100664081);
			}

			// Token: 0x17003A6F RID: 14959
			// (get) Token: 0x0600BC95 RID: 48277 RVA: 0x002E8038 File Offset: 0x002E6238
			public unsafe static ColorGradingModel.BasicSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.BasicSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_BasicSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC96 RID: 48278 RVA: 0x0005C372 File Offset: 0x0005A572
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F61 RID: 32609
			private static readonly IntPtr NativeFieldInfoPtr_postExposure;

			// Token: 0x04007F62 RID: 32610
			private static readonly IntPtr NativeFieldInfoPtr_temperature;

			// Token: 0x04007F63 RID: 32611
			private static readonly IntPtr NativeFieldInfoPtr_tint;

			// Token: 0x04007F64 RID: 32612
			private static readonly IntPtr NativeFieldInfoPtr_hueShift;

			// Token: 0x04007F65 RID: 32613
			private static readonly IntPtr NativeFieldInfoPtr_saturation;

			// Token: 0x04007F66 RID: 32614
			private static readonly IntPtr NativeFieldInfoPtr_contrast;

			// Token: 0x04007F67 RID: 32615
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_BasicSettings_0;

			// Token: 0x04007F68 RID: 32616
			[FieldOffset(0)]
			public float postExposure;

			// Token: 0x04007F69 RID: 32617
			[FieldOffset(4)]
			public float temperature;

			// Token: 0x04007F6A RID: 32618
			[FieldOffset(8)]
			public float tint;

			// Token: 0x04007F6B RID: 32619
			[FieldOffset(12)]
			public float hueShift;

			// Token: 0x04007F6C RID: 32620
			[FieldOffset(16)]
			public float saturation;

			// Token: 0x04007F6D RID: 32621
			[FieldOffset(20)]
			public float contrast;
		}

		// Token: 0x020007EF RID: 2031
		[Serializable]
		[StructLayout(2)]
		public struct ChannelMixerSettings
		{
			// Token: 0x0600BC97 RID: 48279 RVA: 0x002E8068 File Offset: 0x002E6268
			// Note: this type is marked as 'beforefieldinit'.
			static ChannelMixerSettings()
			{
				Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "ChannelMixerSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr);
				ColorGradingModel.ChannelMixerSettings.NativeFieldInfoPtr_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr, "red");
				ColorGradingModel.ChannelMixerSettings.NativeFieldInfoPtr_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr, "green");
				ColorGradingModel.ChannelMixerSettings.NativeFieldInfoPtr_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr, "blue");
				ColorGradingModel.ChannelMixerSettings.NativeFieldInfoPtr_currentEditingChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr, "currentEditingChannel");
				ColorGradingModel.ChannelMixerSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ChannelMixerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr, 100664082);
			}

			// Token: 0x17003A70 RID: 14960
			// (get) Token: 0x0600BC98 RID: 48280 RVA: 0x002E80F8 File Offset: 0x002E62F8
			public unsafe static ColorGradingModel.ChannelMixerSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.ChannelMixerSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ChannelMixerSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC99 RID: 48281 RVA: 0x0005C384 File Offset: 0x0005A584
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F6E RID: 32622
			private static readonly IntPtr NativeFieldInfoPtr_red;

			// Token: 0x04007F6F RID: 32623
			private static readonly IntPtr NativeFieldInfoPtr_green;

			// Token: 0x04007F70 RID: 32624
			private static readonly IntPtr NativeFieldInfoPtr_blue;

			// Token: 0x04007F71 RID: 32625
			private static readonly IntPtr NativeFieldInfoPtr_currentEditingChannel;

			// Token: 0x04007F72 RID: 32626
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ChannelMixerSettings_0;

			// Token: 0x04007F73 RID: 32627
			[FieldOffset(0)]
			public Vector3 red;

			// Token: 0x04007F74 RID: 32628
			[FieldOffset(12)]
			public Vector3 green;

			// Token: 0x04007F75 RID: 32629
			[FieldOffset(24)]
			public Vector3 blue;

			// Token: 0x04007F76 RID: 32630
			[FieldOffset(36)]
			public int currentEditingChannel;
		}

		// Token: 0x020007F0 RID: 2032
		[Serializable]
		[StructLayout(2)]
		public struct LogWheelsSettings
		{
			// Token: 0x0600BC9A RID: 48282 RVA: 0x002E8128 File Offset: 0x002E6328
			// Note: this type is marked as 'beforefieldinit'.
			static LogWheelsSettings()
			{
				Il2CppClassPointerStore<ColorGradingModel.LogWheelsSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "LogWheelsSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.LogWheelsSettings>.NativeClassPtr);
				ColorGradingModel.LogWheelsSettings.NativeFieldInfoPtr_slope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.LogWheelsSettings>.NativeClassPtr, "slope");
				ColorGradingModel.LogWheelsSettings.NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.LogWheelsSettings>.NativeClassPtr, "power");
				ColorGradingModel.LogWheelsSettings.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.LogWheelsSettings>.NativeClassPtr, "offset");
				ColorGradingModel.LogWheelsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LogWheelsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.LogWheelsSettings>.NativeClassPtr, 100664083);
			}

			// Token: 0x17003A71 RID: 14961
			// (get) Token: 0x0600BC9B RID: 48283 RVA: 0x002E81A4 File Offset: 0x002E63A4
			public unsafe static ColorGradingModel.LogWheelsSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.LogWheelsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LogWheelsSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC9C RID: 48284 RVA: 0x0005C396 File Offset: 0x0005A596
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.LogWheelsSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F77 RID: 32631
			private static readonly IntPtr NativeFieldInfoPtr_slope;

			// Token: 0x04007F78 RID: 32632
			private static readonly IntPtr NativeFieldInfoPtr_power;

			// Token: 0x04007F79 RID: 32633
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04007F7A RID: 32634
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LogWheelsSettings_0;

			// Token: 0x04007F7B RID: 32635
			[FieldOffset(0)]
			public Color slope;

			// Token: 0x04007F7C RID: 32636
			[FieldOffset(16)]
			public Color power;

			// Token: 0x04007F7D RID: 32637
			[FieldOffset(32)]
			public Color offset;
		}

		// Token: 0x020007F1 RID: 2033
		[Serializable]
		[StructLayout(2)]
		public struct LinearWheelsSettings
		{
			// Token: 0x0600BC9D RID: 48285 RVA: 0x002E81D4 File Offset: 0x002E63D4
			// Note: this type is marked as 'beforefieldinit'.
			static LinearWheelsSettings()
			{
				Il2CppClassPointerStore<ColorGradingModel.LinearWheelsSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "LinearWheelsSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.LinearWheelsSettings>.NativeClassPtr);
				ColorGradingModel.LinearWheelsSettings.NativeFieldInfoPtr_lift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.LinearWheelsSettings>.NativeClassPtr, "lift");
				ColorGradingModel.LinearWheelsSettings.NativeFieldInfoPtr_gamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.LinearWheelsSettings>.NativeClassPtr, "gamma");
				ColorGradingModel.LinearWheelsSettings.NativeFieldInfoPtr_gain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.LinearWheelsSettings>.NativeClassPtr, "gain");
				ColorGradingModel.LinearWheelsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LinearWheelsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.LinearWheelsSettings>.NativeClassPtr, 100664084);
			}

			// Token: 0x17003A72 RID: 14962
			// (get) Token: 0x0600BC9E RID: 48286 RVA: 0x002E8250 File Offset: 0x002E6450
			public unsafe static ColorGradingModel.LinearWheelsSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.LinearWheelsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LinearWheelsSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC9F RID: 48287 RVA: 0x0005C3A8 File Offset: 0x0005A5A8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.LinearWheelsSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F7E RID: 32638
			private static readonly IntPtr NativeFieldInfoPtr_lift;

			// Token: 0x04007F7F RID: 32639
			private static readonly IntPtr NativeFieldInfoPtr_gamma;

			// Token: 0x04007F80 RID: 32640
			private static readonly IntPtr NativeFieldInfoPtr_gain;

			// Token: 0x04007F81 RID: 32641
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LinearWheelsSettings_0;

			// Token: 0x04007F82 RID: 32642
			[FieldOffset(0)]
			public Color lift;

			// Token: 0x04007F83 RID: 32643
			[FieldOffset(16)]
			public Color gamma;

			// Token: 0x04007F84 RID: 32644
			[FieldOffset(32)]
			public Color gain;
		}

		// Token: 0x020007F2 RID: 2034
		[OriginalName("Assembly-CSharp.dll", "", "ColorWheelMode")]
		public enum ColorWheelMode
		{
			// Token: 0x04007F86 RID: 32646
			Linear,
			// Token: 0x04007F87 RID: 32647
			Log
		}

		// Token: 0x020007F3 RID: 2035
		[Serializable]
		[StructLayout(2)]
		public struct ColorWheelsSettings
		{
			// Token: 0x0600BCA0 RID: 48288 RVA: 0x002E8280 File Offset: 0x002E6480
			// Note: this type is marked as 'beforefieldinit'.
			static ColorWheelsSettings()
			{
				Il2CppClassPointerStore<ColorGradingModel.ColorWheelsSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "ColorWheelsSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.ColorWheelsSettings>.NativeClassPtr);
				ColorGradingModel.ColorWheelsSettings.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.ColorWheelsSettings>.NativeClassPtr, "mode");
				ColorGradingModel.ColorWheelsSettings.NativeFieldInfoPtr_log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.ColorWheelsSettings>.NativeClassPtr, "log");
				ColorGradingModel.ColorWheelsSettings.NativeFieldInfoPtr_linear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.ColorWheelsSettings>.NativeClassPtr, "linear");
				ColorGradingModel.ColorWheelsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ColorWheelsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.ColorWheelsSettings>.NativeClassPtr, 100664085);
			}

			// Token: 0x17003A73 RID: 14963
			// (get) Token: 0x0600BCA1 RID: 48289 RVA: 0x002E82FC File Offset: 0x002E64FC
			public unsafe static ColorGradingModel.ColorWheelsSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.ColorWheelsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ColorWheelsSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCA2 RID: 48290 RVA: 0x0005C3BA File Offset: 0x0005A5BA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.ColorWheelsSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F88 RID: 32648
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x04007F89 RID: 32649
			private static readonly IntPtr NativeFieldInfoPtr_log;

			// Token: 0x04007F8A RID: 32650
			private static readonly IntPtr NativeFieldInfoPtr_linear;

			// Token: 0x04007F8B RID: 32651
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ColorWheelsSettings_0;

			// Token: 0x04007F8C RID: 32652
			[FieldOffset(0)]
			public ColorGradingModel.ColorWheelMode mode;

			// Token: 0x04007F8D RID: 32653
			[FieldOffset(4)]
			public ColorGradingModel.LogWheelsSettings log;

			// Token: 0x04007F8E RID: 32654
			[FieldOffset(52)]
			public ColorGradingModel.LinearWheelsSettings linear;
		}

		// Token: 0x020007F4 RID: 2036
		[Serializable]
		public sealed class CurvesSettings : ValueType
		{
			// Token: 0x0600BCA3 RID: 48291 RVA: 0x002E832C File Offset: 0x002E652C
			// Note: this type is marked as 'beforefieldinit'.
			static CurvesSettings()
			{
				Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "CurvesSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr);
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "master");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "red");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "green");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "blue");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_hueVShue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "hueVShue");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_hueVSsat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "hueVSsat");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_satVSsat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "satVSsat");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_lumVSsat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "lumVSsat");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurrentEditingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "e_CurrentEditingCurve");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "e_CurveY");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "e_CurveR");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "e_CurveG");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "e_CurveB");
				ColorGradingModel.CurvesSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_CurvesSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, 100664086);
			}

			// Token: 0x17003A81 RID: 14977
			// (get) Token: 0x0600BCA4 RID: 48292 RVA: 0x002E8470 File Offset: 0x002E6670
			public unsafe static ColorGradingModel.CurvesSettings defaultSettings
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 77871, RefRangeEnd = 77872, XrefRangeStart = 77780, XrefRangeEnd = 77871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.CurvesSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_CurvesSettings_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new ColorGradingModel.CurvesSettings(pointer);
				}
			}

			// Token: 0x0600BCA5 RID: 48293 RVA: 0x0005C3CC File Offset: 0x0005A5CC
			public CurvesSettings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BCA6 RID: 48294 RVA: 0x0005C3D5 File Offset: 0x0005A5D5
			public CurvesSettings() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr))
			{
			}

			// Token: 0x17003A74 RID: 14964
			// (get) Token: 0x0600BCA7 RID: 48295 RVA: 0x002E849C File Offset: 0x002E669C
			// (set) Token: 0x0600BCA8 RID: 48296 RVA: 0x0005C3E7 File Offset: 0x0005A5E7
			public unsafe ColorGradingCurve master
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_master);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_master), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A75 RID: 14965
			// (get) Token: 0x0600BCA9 RID: 48297 RVA: 0x002E84CC File Offset: 0x002E66CC
			// (set) Token: 0x0600BCAA RID: 48298 RVA: 0x0005C406 File Offset: 0x0005A606
			public unsafe ColorGradingCurve red
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_red);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_red), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A76 RID: 14966
			// (get) Token: 0x0600BCAB RID: 48299 RVA: 0x002E84FC File Offset: 0x002E66FC
			// (set) Token: 0x0600BCAC RID: 48300 RVA: 0x0005C425 File Offset: 0x0005A625
			public unsafe ColorGradingCurve green
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_green);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_green), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A77 RID: 14967
			// (get) Token: 0x0600BCAD RID: 48301 RVA: 0x002E852C File Offset: 0x002E672C
			// (set) Token: 0x0600BCAE RID: 48302 RVA: 0x0005C444 File Offset: 0x0005A644
			public unsafe ColorGradingCurve blue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_blue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_blue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A78 RID: 14968
			// (get) Token: 0x0600BCAF RID: 48303 RVA: 0x002E855C File Offset: 0x002E675C
			// (set) Token: 0x0600BCB0 RID: 48304 RVA: 0x0005C463 File Offset: 0x0005A663
			public unsafe ColorGradingCurve hueVShue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_hueVShue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_hueVShue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A79 RID: 14969
			// (get) Token: 0x0600BCB1 RID: 48305 RVA: 0x002E858C File Offset: 0x002E678C
			// (set) Token: 0x0600BCB2 RID: 48306 RVA: 0x0005C482 File Offset: 0x0005A682
			public unsafe ColorGradingCurve hueVSsat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_hueVSsat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_hueVSsat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A7A RID: 14970
			// (get) Token: 0x0600BCB3 RID: 48307 RVA: 0x002E85BC File Offset: 0x002E67BC
			// (set) Token: 0x0600BCB4 RID: 48308 RVA: 0x0005C4A1 File Offset: 0x0005A6A1
			public unsafe ColorGradingCurve satVSsat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_satVSsat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_satVSsat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A7B RID: 14971
			// (get) Token: 0x0600BCB5 RID: 48309 RVA: 0x002E85EC File Offset: 0x002E67EC
			// (set) Token: 0x0600BCB6 RID: 48310 RVA: 0x0005C4C0 File Offset: 0x0005A6C0
			public unsafe ColorGradingCurve lumVSsat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_lumVSsat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_lumVSsat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A7C RID: 14972
			// (get) Token: 0x0600BCB7 RID: 48311 RVA: 0x002E861C File Offset: 0x002E681C
			// (set) Token: 0x0600BCB8 RID: 48312 RVA: 0x0005C4DF File Offset: 0x0005A6DF
			public unsafe int e_CurrentEditingCurve
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurrentEditingCurve);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurrentEditingCurve)) = value;
				}
			}

			// Token: 0x17003A7D RID: 14973
			// (get) Token: 0x0600BCB9 RID: 48313 RVA: 0x002E8644 File Offset: 0x002E6844
			// (set) Token: 0x0600BCBA RID: 48314 RVA: 0x0005C4FA File Offset: 0x0005A6FA
			public unsafe bool e_CurveY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveY)) = value;
				}
			}

			// Token: 0x17003A7E RID: 14974
			// (get) Token: 0x0600BCBB RID: 48315 RVA: 0x002E866C File Offset: 0x002E686C
			// (set) Token: 0x0600BCBC RID: 48316 RVA: 0x0005C515 File Offset: 0x0005A715
			public unsafe bool e_CurveR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveR);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveR)) = value;
				}
			}

			// Token: 0x17003A7F RID: 14975
			// (get) Token: 0x0600BCBD RID: 48317 RVA: 0x002E8694 File Offset: 0x002E6894
			// (set) Token: 0x0600BCBE RID: 48318 RVA: 0x0005C530 File Offset: 0x0005A730
			public unsafe bool e_CurveG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveG);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveG)) = value;
				}
			}

			// Token: 0x17003A80 RID: 14976
			// (get) Token: 0x0600BCBF RID: 48319 RVA: 0x002E86BC File Offset: 0x002E68BC
			// (set) Token: 0x0600BCC0 RID: 48320 RVA: 0x0005C54B File Offset: 0x0005A74B
			public unsafe bool e_CurveB
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveB);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveB)) = value;
				}
			}

			// Token: 0x04007F8F RID: 32655
			private static readonly IntPtr NativeFieldInfoPtr_master;

			// Token: 0x04007F90 RID: 32656
			private static readonly IntPtr NativeFieldInfoPtr_red;

			// Token: 0x04007F91 RID: 32657
			private static readonly IntPtr NativeFieldInfoPtr_green;

			// Token: 0x04007F92 RID: 32658
			private static readonly IntPtr NativeFieldInfoPtr_blue;

			// Token: 0x04007F93 RID: 32659
			private static readonly IntPtr NativeFieldInfoPtr_hueVShue;

			// Token: 0x04007F94 RID: 32660
			private static readonly IntPtr NativeFieldInfoPtr_hueVSsat;

			// Token: 0x04007F95 RID: 32661
			private static readonly IntPtr NativeFieldInfoPtr_satVSsat;

			// Token: 0x04007F96 RID: 32662
			private static readonly IntPtr NativeFieldInfoPtr_lumVSsat;

			// Token: 0x04007F97 RID: 32663
			private static readonly IntPtr NativeFieldInfoPtr_e_CurrentEditingCurve;

			// Token: 0x04007F98 RID: 32664
			private static readonly IntPtr NativeFieldInfoPtr_e_CurveY;

			// Token: 0x04007F99 RID: 32665
			private static readonly IntPtr NativeFieldInfoPtr_e_CurveR;

			// Token: 0x04007F9A RID: 32666
			private static readonly IntPtr NativeFieldInfoPtr_e_CurveG;

			// Token: 0x04007F9B RID: 32667
			private static readonly IntPtr NativeFieldInfoPtr_e_CurveB;

			// Token: 0x04007F9C RID: 32668
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_CurvesSettings_0;
		}

		// Token: 0x020007F5 RID: 2037
		[Serializable]
		public sealed class Settings : ValueType
		{
			// Token: 0x0600BCC1 RID: 48321 RVA: 0x002E86E4 File Offset: 0x002E68E4
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr);
				ColorGradingModel.Settings.NativeFieldInfoPtr_tonemapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, "tonemapping");
				ColorGradingModel.Settings.NativeFieldInfoPtr_basic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, "basic");
				ColorGradingModel.Settings.NativeFieldInfoPtr_channelMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, "channelMixer");
				ColorGradingModel.Settings.NativeFieldInfoPtr_colorWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, "colorWheels");
				ColorGradingModel.Settings.NativeFieldInfoPtr_curves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, "curves");
				ColorGradingModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, 100664087);
			}

			// Token: 0x17003A87 RID: 14983
			// (get) Token: 0x0600BCC2 RID: 48322 RVA: 0x002E8788 File Offset: 0x002E6988
			public unsafe static ColorGradingModel.Settings defaultSettings
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 77874, RefRangeEnd = 77877, XrefRangeStart = 77872, XrefRangeEnd = 77874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new ColorGradingModel.Settings(pointer);
				}
			}

			// Token: 0x0600BCC3 RID: 48323 RVA: 0x0005C566 File Offset: 0x0005A766
			public Settings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BCC4 RID: 48324 RVA: 0x0005C56F File Offset: 0x0005A76F
			public Settings() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr))
			{
			}

			// Token: 0x17003A82 RID: 14978
			// (get) Token: 0x0600BCC5 RID: 48325 RVA: 0x002E87B4 File Offset: 0x002E69B4
			// (set) Token: 0x0600BCC6 RID: 48326 RVA: 0x0005C581 File Offset: 0x0005A781
			public unsafe ColorGradingModel.TonemappingSettings tonemapping
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_tonemapping);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_tonemapping)) = value;
				}
			}

			// Token: 0x17003A83 RID: 14979
			// (get) Token: 0x0600BCC7 RID: 48327 RVA: 0x002E87DC File Offset: 0x002E69DC
			// (set) Token: 0x0600BCC8 RID: 48328 RVA: 0x0005C59C File Offset: 0x0005A79C
			public unsafe ColorGradingModel.BasicSettings basic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_basic);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_basic)) = value;
				}
			}

			// Token: 0x17003A84 RID: 14980
			// (get) Token: 0x0600BCC9 RID: 48329 RVA: 0x002E8804 File Offset: 0x002E6A04
			// (set) Token: 0x0600BCCA RID: 48330 RVA: 0x0005C5B7 File Offset: 0x0005A7B7
			public unsafe ColorGradingModel.ChannelMixerSettings channelMixer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_channelMixer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_channelMixer)) = value;
				}
			}

			// Token: 0x17003A85 RID: 14981
			// (get) Token: 0x0600BCCB RID: 48331 RVA: 0x002E882C File Offset: 0x002E6A2C
			// (set) Token: 0x0600BCCC RID: 48332 RVA: 0x0005C5D2 File Offset: 0x0005A7D2
			public unsafe ColorGradingModel.ColorWheelsSettings colorWheels
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_colorWheels);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_colorWheels)) = value;
				}
			}

			// Token: 0x17003A86 RID: 14982
			// (get) Token: 0x0600BCCD RID: 48333 RVA: 0x002E8854 File Offset: 0x002E6A54
			// (set) Token: 0x0600BCCE RID: 48334 RVA: 0x0005C5ED File Offset: 0x0005A7ED
			public ColorGradingModel.CurvesSettings curves
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_curves);
					return new ColorGradingModel.CurvesSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_curves), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04007F9D RID: 32669
			private static readonly IntPtr NativeFieldInfoPtr_tonemapping;

			// Token: 0x04007F9E RID: 32670
			private static readonly IntPtr NativeFieldInfoPtr_basic;

			// Token: 0x04007F9F RID: 32671
			private static readonly IntPtr NativeFieldInfoPtr_channelMixer;

			// Token: 0x04007FA0 RID: 32672
			private static readonly IntPtr NativeFieldInfoPtr_colorWheels;

			// Token: 0x04007FA1 RID: 32673
			private static readonly IntPtr NativeFieldInfoPtr_curves;

			// Token: 0x04007FA2 RID: 32674
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;
		}
	}
}
