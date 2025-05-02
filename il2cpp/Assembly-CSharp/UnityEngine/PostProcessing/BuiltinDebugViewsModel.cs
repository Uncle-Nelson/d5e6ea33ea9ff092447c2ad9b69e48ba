using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000061 RID: 97
	[Serializable]
	public class BuiltinDebugViewsModel : PostProcessingModel
	{
		// Token: 0x06000745 RID: 1861 RVA: 0x000867CC File Offset: 0x000849CC
		// Note: this type is marked as 'beforefieldinit'.
		static BuiltinDebugViewsModel()
		{
			Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "BuiltinDebugViewsModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr);
			BuiltinDebugViewsModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, "m_Settings");
			BuiltinDebugViewsModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, 100664057);
			BuiltinDebugViewsModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, 100664058);
			BuiltinDebugViewsModel.NativeMethodInfoPtr_get_willInterrupt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, 100664059);
			BuiltinDebugViewsModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, 100664060);
			BuiltinDebugViewsModel.NativeMethodInfoPtr_IsModeActive_Public_Boolean_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, 100664061);
			BuiltinDebugViewsModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, 100664062);
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00086888 File Offset: 0x00084A88
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x000868C4 File Offset: 0x00084AC4
		public unsafe BuiltinDebugViewsModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00086904 File Offset: 0x00084B04
		public unsafe bool willInterrupt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.NativeMethodInfoPtr_get_willInterrupt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00086940 File Offset: 0x00084B40
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuiltinDebugViewsModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0008697C File Offset: 0x00084B7C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 77764, RefRangeEnd = 77772, XrefRangeStart = 77764, XrefRangeEnd = 77764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsModeActive(BuiltinDebugViewsModel.Mode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.NativeMethodInfoPtr_IsModeActive_Public_Boolean_Mode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000869C8 File Offset: 0x00084BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77772, XrefRangeEnd = 77773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuiltinDebugViewsModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00006037 File Offset: 0x00004237
		public BuiltinDebugViewsModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00086A04 File Offset: 0x00084C04
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00006040 File Offset: 0x00004240
		public unsafe BuiltinDebugViewsModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_get_willInterrupt_Public_get_Boolean_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_IsModeActive_Public_Boolean_Mode_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007E7 RID: 2023
		[Serializable]
		[StructLayout(2)]
		public struct DepthSettings
		{
			// Token: 0x0600BC80 RID: 48256 RVA: 0x002E7B80 File Offset: 0x002E5D80
			// Note: this type is marked as 'beforefieldinit'.
			static DepthSettings()
			{
				Il2CppClassPointerStore<BuiltinDebugViewsModel.DepthSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, "DepthSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinDebugViewsModel.DepthSettings>.NativeClassPtr);
				BuiltinDebugViewsModel.DepthSettings.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.DepthSettings>.NativeClassPtr, "scale");
				BuiltinDebugViewsModel.DepthSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_DepthSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel.DepthSettings>.NativeClassPtr, 100664063);
			}

			// Token: 0x17003A68 RID: 14952
			// (get) Token: 0x0600BC81 RID: 48257 RVA: 0x002E7BD4 File Offset: 0x002E5DD4
			public unsafe static BuiltinDebugViewsModel.DepthSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.DepthSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_DepthSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC82 RID: 48258 RVA: 0x0005C2D5 File Offset: 0x0005A4D5
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuiltinDebugViewsModel.DepthSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F29 RID: 32553
			private static readonly IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x04007F2A RID: 32554
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_DepthSettings_0;

			// Token: 0x04007F2B RID: 32555
			[FieldOffset(0)]
			public float scale;
		}

		// Token: 0x020007E8 RID: 2024
		[Serializable]
		[StructLayout(2)]
		public struct MotionVectorsSettings
		{
			// Token: 0x0600BC83 RID: 48259 RVA: 0x002E7C04 File Offset: 0x002E5E04
			// Note: this type is marked as 'beforefieldinit'.
			static MotionVectorsSettings()
			{
				Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, "MotionVectorsSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr);
				BuiltinDebugViewsModel.MotionVectorsSettings.NativeFieldInfoPtr_sourceOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, "sourceOpacity");
				BuiltinDebugViewsModel.MotionVectorsSettings.NativeFieldInfoPtr_motionImageOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, "motionImageOpacity");
				BuiltinDebugViewsModel.MotionVectorsSettings.NativeFieldInfoPtr_motionImageAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, "motionImageAmplitude");
				BuiltinDebugViewsModel.MotionVectorsSettings.NativeFieldInfoPtr_motionVectorsOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, "motionVectorsOpacity");
				BuiltinDebugViewsModel.MotionVectorsSettings.NativeFieldInfoPtr_motionVectorsResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, "motionVectorsResolution");
				BuiltinDebugViewsModel.MotionVectorsSettings.NativeFieldInfoPtr_motionVectorsAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, "motionVectorsAmplitude");
				BuiltinDebugViewsModel.MotionVectorsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_MotionVectorsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, 100664064);
			}

			// Token: 0x17003A69 RID: 14953
			// (get) Token: 0x0600BC84 RID: 48260 RVA: 0x002E7CBC File Offset: 0x002E5EBC
			public unsafe static BuiltinDebugViewsModel.MotionVectorsSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.MotionVectorsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_MotionVectorsSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC85 RID: 48261 RVA: 0x0005C2E7 File Offset: 0x0005A4E7
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuiltinDebugViewsModel.MotionVectorsSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F2C RID: 32556
			private static readonly IntPtr NativeFieldInfoPtr_sourceOpacity;

			// Token: 0x04007F2D RID: 32557
			private static readonly IntPtr NativeFieldInfoPtr_motionImageOpacity;

			// Token: 0x04007F2E RID: 32558
			private static readonly IntPtr NativeFieldInfoPtr_motionImageAmplitude;

			// Token: 0x04007F2F RID: 32559
			private static readonly IntPtr NativeFieldInfoPtr_motionVectorsOpacity;

			// Token: 0x04007F30 RID: 32560
			private static readonly IntPtr NativeFieldInfoPtr_motionVectorsResolution;

			// Token: 0x04007F31 RID: 32561
			private static readonly IntPtr NativeFieldInfoPtr_motionVectorsAmplitude;

			// Token: 0x04007F32 RID: 32562
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_MotionVectorsSettings_0;

			// Token: 0x04007F33 RID: 32563
			[FieldOffset(0)]
			public float sourceOpacity;

			// Token: 0x04007F34 RID: 32564
			[FieldOffset(4)]
			public float motionImageOpacity;

			// Token: 0x04007F35 RID: 32565
			[FieldOffset(8)]
			public float motionImageAmplitude;

			// Token: 0x04007F36 RID: 32566
			[FieldOffset(12)]
			public float motionVectorsOpacity;

			// Token: 0x04007F37 RID: 32567
			[FieldOffset(16)]
			public int motionVectorsResolution;

			// Token: 0x04007F38 RID: 32568
			[FieldOffset(20)]
			public float motionVectorsAmplitude;
		}

		// Token: 0x020007E9 RID: 2025
		[OriginalName("Assembly-CSharp.dll", "", "Mode")]
		public enum Mode
		{
			// Token: 0x04007F3A RID: 32570
			None,
			// Token: 0x04007F3B RID: 32571
			Depth,
			// Token: 0x04007F3C RID: 32572
			Normals,
			// Token: 0x04007F3D RID: 32573
			MotionVectors,
			// Token: 0x04007F3E RID: 32574
			AmbientOcclusion,
			// Token: 0x04007F3F RID: 32575
			EyeAdaptation,
			// Token: 0x04007F40 RID: 32576
			FocusPlane,
			// Token: 0x04007F41 RID: 32577
			PreGradingLog,
			// Token: 0x04007F42 RID: 32578
			LogLut,
			// Token: 0x04007F43 RID: 32579
			UserLut
		}

		// Token: 0x020007EA RID: 2026
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BC86 RID: 48262 RVA: 0x002E7CEC File Offset: 0x002E5EEC
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<BuiltinDebugViewsModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuiltinDebugViewsModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinDebugViewsModel.Settings>.NativeClassPtr);
				BuiltinDebugViewsModel.Settings.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.Settings>.NativeClassPtr, "mode");
				BuiltinDebugViewsModel.Settings.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.Settings>.NativeClassPtr, "depth");
				BuiltinDebugViewsModel.Settings.NativeFieldInfoPtr_motionVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsModel.Settings>.NativeClassPtr, "motionVectors");
				BuiltinDebugViewsModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsModel.Settings>.NativeClassPtr, 100664065);
			}

			// Token: 0x17003A6A RID: 14954
			// (get) Token: 0x0600BC87 RID: 48263 RVA: 0x002E7D68 File Offset: 0x002E5F68
			public unsafe static BuiltinDebugViewsModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC88 RID: 48264 RVA: 0x0005C2F9 File Offset: 0x0005A4F9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuiltinDebugViewsModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F44 RID: 32580
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x04007F45 RID: 32581
			private static readonly IntPtr NativeFieldInfoPtr_depth;

			// Token: 0x04007F46 RID: 32582
			private static readonly IntPtr NativeFieldInfoPtr_motionVectors;

			// Token: 0x04007F47 RID: 32583
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007F48 RID: 32584
			[FieldOffset(0)]
			public BuiltinDebugViewsModel.Mode mode;

			// Token: 0x04007F49 RID: 32585
			[FieldOffset(4)]
			public BuiltinDebugViewsModel.DepthSettings depth;

			// Token: 0x04007F4A RID: 32586
			[FieldOffset(8)]
			public BuiltinDebugViewsModel.MotionVectorsSettings motionVectors;
		}
	}
}
