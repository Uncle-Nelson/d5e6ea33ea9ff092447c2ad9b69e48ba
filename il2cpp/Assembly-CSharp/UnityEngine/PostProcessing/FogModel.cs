using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000067 RID: 103
	[Serializable]
	public class FogModel : PostProcessingModel
	{
		// Token: 0x06000780 RID: 1920 RVA: 0x000874D4 File Offset: 0x000856D4
		// Note: this type is marked as 'beforefieldinit'.
		static FogModel()
		{
			Il2CppClassPointerStore<FogModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "FogModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogModel>.NativeClassPtr);
			FogModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogModel>.NativeClassPtr, "m_Settings");
			FogModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogModel>.NativeClassPtr, 100664103);
			FogModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogModel>.NativeClassPtr, 100664104);
			FogModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogModel>.NativeClassPtr, 100664105);
			FogModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogModel>.NativeClassPtr, 100664106);
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00087568 File Offset: 0x00085768
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x000875A4 File Offset: 0x000857A4
		public unsafe FogModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x000875E4 File Offset: 0x000857E4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 42611, RefRangeEnd = 42622, XrefRangeStart = 42611, XrefRangeEnd = 42622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FogModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00087620 File Offset: 0x00085820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77887, XrefRangeEnd = 77888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FogModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FogModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0000616F File Offset: 0x0000436F
		public FogModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x0008765C File Offset: 0x0008585C
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00006178 File Offset: 0x00004378
		public unsafe FogModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FogModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FogModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007FB RID: 2043
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BCD8 RID: 48344 RVA: 0x002E8AD4 File Offset: 0x002E6CD4
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<FogModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FogModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogModel.Settings>.NativeClassPtr);
				FogModel.Settings.NativeFieldInfoPtr_excludeSkybox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogModel.Settings>.NativeClassPtr, "excludeSkybox");
				FogModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogModel.Settings>.NativeClassPtr, 100664107);
			}

			// Token: 0x17003A8B RID: 14987
			// (get) Token: 0x0600BCD9 RID: 48345 RVA: 0x002E8B28 File Offset: 0x002E6D28
			public unsafe static FogModel.Settings defaultSettings
			{
				[CallerCount(20)]
				[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCDA RID: 48346 RVA: 0x0005C685 File Offset: 0x0005A885
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FogModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FCE RID: 32718
			private static readonly IntPtr NativeFieldInfoPtr_excludeSkybox;

			// Token: 0x04007FCF RID: 32719
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007FD0 RID: 32720
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool excludeSkybox;
		}
	}
}
