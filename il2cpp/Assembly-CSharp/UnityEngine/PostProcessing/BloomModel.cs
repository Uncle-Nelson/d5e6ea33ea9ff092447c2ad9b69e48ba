using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000060 RID: 96
	[Serializable]
	public class BloomModel : PostProcessingModel
	{
		// Token: 0x0600073D RID: 1853 RVA: 0x00086610 File Offset: 0x00084810
		// Note: this type is marked as 'beforefieldinit'.
		static BloomModel()
		{
			Il2CppClassPointerStore<BloomModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "BloomModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomModel>.NativeClassPtr);
			BloomModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, "m_Settings");
			BloomModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, 100664048);
			BloomModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, 100664049);
			BloomModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, 100664050);
			BloomModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, 100664051);
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x000866A4 File Offset: 0x000848A4
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x000866DC File Offset: 0x000848DC
		public unsafe BloomModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BloomModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new BloomModel.Settings(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77756, XrefRangeEnd = 77757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00086724 File Offset: 0x00084924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77757, XrefRangeEnd = 77760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BloomModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00086760 File Offset: 0x00084960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77760, XrefRangeEnd = 77764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BloomModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloomModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00006000 File Offset: 0x00004200
		public BloomModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x0008679C File Offset: 0x0008499C
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00006009 File Offset: 0x00004209
		public BloomModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.NativeFieldInfoPtr_m_Settings);
				return new BloomModel.Settings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.NativeFieldInfoPtr_m_Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007E4 RID: 2020
		[Serializable]
		[StructLayout(2)]
		public struct BloomSettings
		{
			// Token: 0x0600BC6B RID: 48235 RVA: 0x002E7848 File Offset: 0x002E5A48
			// Note: this type is marked as 'beforefieldinit'.
			static BloomSettings()
			{
				Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, "BloomSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr);
				BloomModel.BloomSettings.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, "intensity");
				BloomModel.BloomSettings.NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, "threshold");
				BloomModel.BloomSettings.NativeFieldInfoPtr_softKnee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, "softKnee");
				BloomModel.BloomSettings.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, "radius");
				BloomModel.BloomSettings.NativeFieldInfoPtr_antiFlicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, "antiFlicker");
				BloomModel.BloomSettings.NativeMethodInfoPtr_set_thresholdLinear_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, 100664052);
				BloomModel.BloomSettings.NativeMethodInfoPtr_get_thresholdLinear_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, 100664053);
				BloomModel.BloomSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_BloomSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, 100664054);
			}

			// Token: 0x17003A60 RID: 14944
			// (get) Token: 0x0600BC6D RID: 48237 RVA: 0x002E7948 File Offset: 0x002E5B48
			// (set) Token: 0x0600BC6C RID: 48236 RVA: 0x002E7914 File Offset: 0x002E5B14
			public unsafe float thresholdLinear
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 77752, RefRangeEnd = 77753, XrefRangeStart = 77751, XrefRangeEnd = 77752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomModel.BloomSettings.NativeMethodInfoPtr_get_thresholdLinear_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77750, XrefRangeEnd = 77751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomModel.BloomSettings.NativeMethodInfoPtr_set_thresholdLinear_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17003A61 RID: 14945
			// (get) Token: 0x0600BC6E RID: 48238 RVA: 0x002E7978 File Offset: 0x002E5B78
			public unsafe static BloomModel.BloomSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomModel.BloomSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_BloomSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC6F RID: 48239 RVA: 0x0005C20A File Offset: 0x0005A40A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloomModel.BloomSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F16 RID: 32534
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04007F17 RID: 32535
			private static readonly IntPtr NativeFieldInfoPtr_threshold;

			// Token: 0x04007F18 RID: 32536
			private static readonly IntPtr NativeFieldInfoPtr_softKnee;

			// Token: 0x04007F19 RID: 32537
			private static readonly IntPtr NativeFieldInfoPtr_radius;

			// Token: 0x04007F1A RID: 32538
			private static readonly IntPtr NativeFieldInfoPtr_antiFlicker;

			// Token: 0x04007F1B RID: 32539
			private static readonly IntPtr NativeMethodInfoPtr_set_thresholdLinear_Public_set_Void_Single_0;

			// Token: 0x04007F1C RID: 32540
			private static readonly IntPtr NativeMethodInfoPtr_get_thresholdLinear_Public_get_Single_0;

			// Token: 0x04007F1D RID: 32541
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_BloomSettings_0;

			// Token: 0x04007F1E RID: 32542
			[FieldOffset(0)]
			public float intensity;

			// Token: 0x04007F1F RID: 32543
			[FieldOffset(4)]
			public float threshold;

			// Token: 0x04007F20 RID: 32544
			[FieldOffset(8)]
			public float softKnee;

			// Token: 0x04007F21 RID: 32545
			[FieldOffset(12)]
			public float radius;

			// Token: 0x04007F22 RID: 32546
			[FieldOffset(16)]
			[MarshalAs(4)]
			public bool antiFlicker;
		}

		// Token: 0x020007E5 RID: 2021
		[Serializable]
		public sealed class LensDirtSettings : ValueType
		{
			// Token: 0x0600BC70 RID: 48240 RVA: 0x002E79A8 File Offset: 0x002E5BA8
			// Note: this type is marked as 'beforefieldinit'.
			static LensDirtSettings()
			{
				Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, "LensDirtSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr);
				BloomModel.LensDirtSettings.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr, "texture");
				BloomModel.LensDirtSettings.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr, "intensity");
				BloomModel.LensDirtSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LensDirtSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr, 100664055);
			}

			// Token: 0x17003A64 RID: 14948
			// (get) Token: 0x0600BC71 RID: 48241 RVA: 0x002E7A10 File Offset: 0x002E5C10
			public unsafe static BloomModel.LensDirtSettings defaultSettings
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77753, XrefRangeEnd = 77754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BloomModel.LensDirtSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LensDirtSettings_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new BloomModel.LensDirtSettings(pointer);
				}
			}

			// Token: 0x0600BC72 RID: 48242 RVA: 0x0005C21C File Offset: 0x0005A41C
			public LensDirtSettings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BC73 RID: 48243 RVA: 0x0005C225 File Offset: 0x0005A425
			public LensDirtSettings() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr))
			{
			}

			// Token: 0x17003A62 RID: 14946
			// (get) Token: 0x0600BC74 RID: 48244 RVA: 0x002E7A3C File Offset: 0x002E5C3C
			// (set) Token: 0x0600BC75 RID: 48245 RVA: 0x0005C237 File Offset: 0x0005A437
			public unsafe Texture texture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.LensDirtSettings.NativeFieldInfoPtr_texture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.LensDirtSettings.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A63 RID: 14947
			// (get) Token: 0x0600BC76 RID: 48246 RVA: 0x002E7A6C File Offset: 0x002E5C6C
			// (set) Token: 0x0600BC77 RID: 48247 RVA: 0x0005C256 File Offset: 0x0005A456
			public unsafe float intensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.LensDirtSettings.NativeFieldInfoPtr_intensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.LensDirtSettings.NativeFieldInfoPtr_intensity)) = value;
				}
			}

			// Token: 0x04007F23 RID: 32547
			private static readonly IntPtr NativeFieldInfoPtr_texture;

			// Token: 0x04007F24 RID: 32548
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04007F25 RID: 32549
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LensDirtSettings_0;
		}

		// Token: 0x020007E6 RID: 2022
		[Serializable]
		public sealed class Settings : ValueType
		{
			// Token: 0x0600BC78 RID: 48248 RVA: 0x002E7A94 File Offset: 0x002E5C94
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloomModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr);
				BloomModel.Settings.NativeFieldInfoPtr_bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr, "bloom");
				BloomModel.Settings.NativeFieldInfoPtr_lensDirt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr, "lensDirt");
				BloomModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr, 100664056);
			}

			// Token: 0x17003A67 RID: 14951
			// (get) Token: 0x0600BC79 RID: 48249 RVA: 0x002E7AFC File Offset: 0x002E5CFC
			public unsafe static BloomModel.Settings defaultSettings
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77754, XrefRangeEnd = 77756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BloomModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new BloomModel.Settings(pointer);
				}
			}

			// Token: 0x0600BC7A RID: 48250 RVA: 0x0005C271 File Offset: 0x0005A471
			public Settings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BC7B RID: 48251 RVA: 0x0005C27A File Offset: 0x0005A47A
			public Settings() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloomModel.Settings>.NativeClassPtr))
			{
			}

			// Token: 0x17003A65 RID: 14949
			// (get) Token: 0x0600BC7C RID: 48252 RVA: 0x002E7B28 File Offset: 0x002E5D28
			// (set) Token: 0x0600BC7D RID: 48253 RVA: 0x0005C28C File Offset: 0x0005A48C
			public unsafe BloomModel.BloomSettings bloom
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.Settings.NativeFieldInfoPtr_bloom);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.Settings.NativeFieldInfoPtr_bloom)) = value;
				}
			}

			// Token: 0x17003A66 RID: 14950
			// (get) Token: 0x0600BC7E RID: 48254 RVA: 0x002E7B50 File Offset: 0x002E5D50
			// (set) Token: 0x0600BC7F RID: 48255 RVA: 0x0005C2A7 File Offset: 0x0005A4A7
			public BloomModel.LensDirtSettings lensDirt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.Settings.NativeFieldInfoPtr_lensDirt);
					return new BloomModel.LensDirtSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomModel.Settings.NativeFieldInfoPtr_lensDirt), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BloomModel.LensDirtSettings>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04007F26 RID: 32550
			private static readonly IntPtr NativeFieldInfoPtr_bloom;

			// Token: 0x04007F27 RID: 32551
			private static readonly IntPtr NativeFieldInfoPtr_lensDirt;

			// Token: 0x04007F28 RID: 32552
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;
		}
	}
}
