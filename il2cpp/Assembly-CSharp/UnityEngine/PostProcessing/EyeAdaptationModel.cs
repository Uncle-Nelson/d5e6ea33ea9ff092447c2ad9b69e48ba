using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000066 RID: 102
	[Serializable]
	public class EyeAdaptationModel : PostProcessingModel
	{
		// Token: 0x06000778 RID: 1912 RVA: 0x00087324 File Offset: 0x00085524
		// Note: this type is marked as 'beforefieldinit'.
		static EyeAdaptationModel()
		{
			Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "EyeAdaptationModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr);
			EyeAdaptationModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr, "m_Settings");
			EyeAdaptationModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr, 100664098);
			EyeAdaptationModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr, 100664099);
			EyeAdaptationModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr, 100664100);
			EyeAdaptationModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr, 100664101);
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x000873B8 File Offset: 0x000855B8
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x000873F4 File Offset: 0x000855F4
		public unsafe EyeAdaptationModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00087434 File Offset: 0x00085634
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EyeAdaptationModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00087470 File Offset: 0x00085670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77886, XrefRangeEnd = 77887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyeAdaptationModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0000614B File Offset: 0x0000434B
		public EyeAdaptationModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x000874AC File Offset: 0x000856AC
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00006154 File Offset: 0x00004354
		public unsafe EyeAdaptationModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007F9 RID: 2041
		[OriginalName("Assembly-CSharp.dll", "", "EyeAdaptationType")]
		public enum EyeAdaptationType
		{
			// Token: 0x04007FB5 RID: 32693
			Progressive,
			// Token: 0x04007FB6 RID: 32694
			Fixed
		}

		// Token: 0x020007FA RID: 2042
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BCD5 RID: 48341 RVA: 0x002E8988 File Offset: 0x002E6B88
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr);
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_lowPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "lowPercent");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_highPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "highPercent");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_minLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "minLuminance");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_maxLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "maxLuminance");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_keyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "keyValue");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_dynamicKeyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "dynamicKeyValue");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_adaptationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "adaptationType");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_speedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "speedUp");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_speedDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "speedDown");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_logMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "logMin");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_logMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "logMax");
				EyeAdaptationModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, 100664102);
			}

			// Token: 0x17003A8A RID: 14986
			// (get) Token: 0x0600BCD6 RID: 48342 RVA: 0x002E8AA4 File Offset: 0x002E6CA4
			public unsafe static EyeAdaptationModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCD7 RID: 48343 RVA: 0x0005C673 File Offset: 0x0005A873
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FB7 RID: 32695
			private static readonly IntPtr NativeFieldInfoPtr_lowPercent;

			// Token: 0x04007FB8 RID: 32696
			private static readonly IntPtr NativeFieldInfoPtr_highPercent;

			// Token: 0x04007FB9 RID: 32697
			private static readonly IntPtr NativeFieldInfoPtr_minLuminance;

			// Token: 0x04007FBA RID: 32698
			private static readonly IntPtr NativeFieldInfoPtr_maxLuminance;

			// Token: 0x04007FBB RID: 32699
			private static readonly IntPtr NativeFieldInfoPtr_keyValue;

			// Token: 0x04007FBC RID: 32700
			private static readonly IntPtr NativeFieldInfoPtr_dynamicKeyValue;

			// Token: 0x04007FBD RID: 32701
			private static readonly IntPtr NativeFieldInfoPtr_adaptationType;

			// Token: 0x04007FBE RID: 32702
			private static readonly IntPtr NativeFieldInfoPtr_speedUp;

			// Token: 0x04007FBF RID: 32703
			private static readonly IntPtr NativeFieldInfoPtr_speedDown;

			// Token: 0x04007FC0 RID: 32704
			private static readonly IntPtr NativeFieldInfoPtr_logMin;

			// Token: 0x04007FC1 RID: 32705
			private static readonly IntPtr NativeFieldInfoPtr_logMax;

			// Token: 0x04007FC2 RID: 32706
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007FC3 RID: 32707
			[FieldOffset(0)]
			public float lowPercent;

			// Token: 0x04007FC4 RID: 32708
			[FieldOffset(4)]
			public float highPercent;

			// Token: 0x04007FC5 RID: 32709
			[FieldOffset(8)]
			public float minLuminance;

			// Token: 0x04007FC6 RID: 32710
			[FieldOffset(12)]
			public float maxLuminance;

			// Token: 0x04007FC7 RID: 32711
			[FieldOffset(16)]
			public float keyValue;

			// Token: 0x04007FC8 RID: 32712
			[FieldOffset(20)]
			[MarshalAs(4)]
			public bool dynamicKeyValue;

			// Token: 0x04007FC9 RID: 32713
			[FieldOffset(24)]
			public EyeAdaptationModel.EyeAdaptationType adaptationType;

			// Token: 0x04007FCA RID: 32714
			[FieldOffset(28)]
			public float speedUp;

			// Token: 0x04007FCB RID: 32715
			[FieldOffset(32)]
			public float speedDown;

			// Token: 0x04007FCC RID: 32716
			[FieldOffset(36)]
			public int logMin;

			// Token: 0x04007FCD RID: 32717
			[FieldOffset(40)]
			public int logMax;
		}
	}
}
