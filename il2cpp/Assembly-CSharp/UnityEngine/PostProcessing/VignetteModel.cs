using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200006C RID: 108
	[Serializable]
	public class VignetteModel : PostProcessingModel
	{
		// Token: 0x060007A8 RID: 1960 RVA: 0x00087D50 File Offset: 0x00085F50
		// Note: this type is marked as 'beforefieldinit'.
		static VignetteModel()
		{
			Il2CppClassPointerStore<VignetteModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "VignetteModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr);
			VignetteModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr, "m_Settings");
			VignetteModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr, 100664128);
			VignetteModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr, 100664129);
			VignetteModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr, 100664130);
			VignetteModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr, 100664131);
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00087DE4 File Offset: 0x00085FE4
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x00087E1C File Offset: 0x0008601C
		public unsafe VignetteModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(VignetteModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new VignetteModel.Settings(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77898, XrefRangeEnd = 77917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VignetteModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00087E64 File Offset: 0x00086064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77917, XrefRangeEnd = 77919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VignetteModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00087EA0 File Offset: 0x000860A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77919, XrefRangeEnd = 77922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VignetteModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VignetteModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00006236 File Offset: 0x00004436
		public VignetteModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x00087EDC File Offset: 0x000860DC
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x0000623F File Offset: 0x0000443F
		public VignetteModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.NativeFieldInfoPtr_m_Settings);
				return new VignetteModel.Settings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.NativeFieldInfoPtr_m_Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000805 RID: 2053
		[OriginalName("Assembly-CSharp.dll", "", "Mode")]
		public enum Mode
		{
			// Token: 0x0400800C RID: 32780
			Classic,
			// Token: 0x0400800D RID: 32781
			Masked
		}

		// Token: 0x02000806 RID: 2054
		[Serializable]
		public sealed class Settings : ValueType
		{
			// Token: 0x0600BCF2 RID: 48370 RVA: 0x002E8FA4 File Offset: 0x002E71A4
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr);
				VignetteModel.Settings.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "mode");
				VignetteModel.Settings.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "color");
				VignetteModel.Settings.NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "center");
				VignetteModel.Settings.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "intensity");
				VignetteModel.Settings.NativeFieldInfoPtr_smoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "smoothness");
				VignetteModel.Settings.NativeFieldInfoPtr_roundness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "roundness");
				VignetteModel.Settings.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "mask");
				VignetteModel.Settings.NativeFieldInfoPtr_opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "opacity");
				VignetteModel.Settings.NativeFieldInfoPtr_rounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "rounded");
				VignetteModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, 100664132);
			}

			// Token: 0x17003A9B RID: 15003
			// (get) Token: 0x0600BCF3 RID: 48371 RVA: 0x002E9098 File Offset: 0x002E7298
			public unsafe static VignetteModel.Settings defaultSettings
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77897, XrefRangeEnd = 77898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(VignetteModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new VignetteModel.Settings(pointer);
				}
			}

			// Token: 0x0600BCF4 RID: 48372 RVA: 0x0005C78C File Offset: 0x0005A98C
			public Settings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BCF5 RID: 48373 RVA: 0x0005C795 File Offset: 0x0005A995
			public Settings() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr))
			{
			}

			// Token: 0x17003A92 RID: 14994
			// (get) Token: 0x0600BCF6 RID: 48374 RVA: 0x002E90C4 File Offset: 0x002E72C4
			// (set) Token: 0x0600BCF7 RID: 48375 RVA: 0x0005C7A7 File Offset: 0x0005A9A7
			public unsafe VignetteModel.Mode mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_mode)) = value;
				}
			}

			// Token: 0x17003A93 RID: 14995
			// (get) Token: 0x0600BCF8 RID: 48376 RVA: 0x002E90EC File Offset: 0x002E72EC
			// (set) Token: 0x0600BCF9 RID: 48377 RVA: 0x0005C7C2 File Offset: 0x0005A9C2
			public unsafe Color color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x17003A94 RID: 14996
			// (get) Token: 0x0600BCFA RID: 48378 RVA: 0x002E9114 File Offset: 0x002E7314
			// (set) Token: 0x0600BCFB RID: 48379 RVA: 0x0005C7DD File Offset: 0x0005A9DD
			public unsafe Vector2 center
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_center);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_center)) = value;
				}
			}

			// Token: 0x17003A95 RID: 14997
			// (get) Token: 0x0600BCFC RID: 48380 RVA: 0x002E913C File Offset: 0x002E733C
			// (set) Token: 0x0600BCFD RID: 48381 RVA: 0x0005C7F8 File Offset: 0x0005A9F8
			public unsafe float intensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_intensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_intensity)) = value;
				}
			}

			// Token: 0x17003A96 RID: 14998
			// (get) Token: 0x0600BCFE RID: 48382 RVA: 0x002E9164 File Offset: 0x002E7364
			// (set) Token: 0x0600BCFF RID: 48383 RVA: 0x0005C813 File Offset: 0x0005AA13
			public unsafe float smoothness
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_smoothness);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_smoothness)) = value;
				}
			}

			// Token: 0x17003A97 RID: 14999
			// (get) Token: 0x0600BD00 RID: 48384 RVA: 0x002E918C File Offset: 0x002E738C
			// (set) Token: 0x0600BD01 RID: 48385 RVA: 0x0005C82E File Offset: 0x0005AA2E
			public unsafe float roundness
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_roundness);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_roundness)) = value;
				}
			}

			// Token: 0x17003A98 RID: 15000
			// (get) Token: 0x0600BD02 RID: 48386 RVA: 0x002E91B4 File Offset: 0x002E73B4
			// (set) Token: 0x0600BD03 RID: 48387 RVA: 0x0005C849 File Offset: 0x0005AA49
			public unsafe Texture mask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_mask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_mask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A99 RID: 15001
			// (get) Token: 0x0600BD04 RID: 48388 RVA: 0x002E91E4 File Offset: 0x002E73E4
			// (set) Token: 0x0600BD05 RID: 48389 RVA: 0x0005C868 File Offset: 0x0005AA68
			public unsafe float opacity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_opacity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_opacity)) = value;
				}
			}

			// Token: 0x17003A9A RID: 15002
			// (get) Token: 0x0600BD06 RID: 48390 RVA: 0x002E920C File Offset: 0x002E740C
			// (set) Token: 0x0600BD07 RID: 48391 RVA: 0x0005C883 File Offset: 0x0005AA83
			public unsafe bool rounded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_rounded);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_rounded)) = value;
				}
			}

			// Token: 0x0400800E RID: 32782
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x0400800F RID: 32783
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008010 RID: 32784
			private static readonly IntPtr NativeFieldInfoPtr_center;

			// Token: 0x04008011 RID: 32785
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04008012 RID: 32786
			private static readonly IntPtr NativeFieldInfoPtr_smoothness;

			// Token: 0x04008013 RID: 32787
			private static readonly IntPtr NativeFieldInfoPtr_roundness;

			// Token: 0x04008014 RID: 32788
			private static readonly IntPtr NativeFieldInfoPtr_mask;

			// Token: 0x04008015 RID: 32789
			private static readonly IntPtr NativeFieldInfoPtr_opacity;

			// Token: 0x04008016 RID: 32790
			private static readonly IntPtr NativeFieldInfoPtr_rounded;

			// Token: 0x04008017 RID: 32791
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;
		}
	}
}
