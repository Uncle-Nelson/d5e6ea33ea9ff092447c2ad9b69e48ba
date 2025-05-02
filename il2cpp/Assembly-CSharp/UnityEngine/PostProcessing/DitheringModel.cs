using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000065 RID: 101
	[Serializable]
	public class DitheringModel : PostProcessingModel
	{
		// Token: 0x06000770 RID: 1904 RVA: 0x00087174 File Offset: 0x00085374
		// Note: this type is marked as 'beforefieldinit'.
		static DitheringModel()
		{
			Il2CppClassPointerStore<DitheringModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "DitheringModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr);
			DitheringModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr, "m_Settings");
			DitheringModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr, 100664093);
			DitheringModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr, 100664094);
			DitheringModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr, 100664095);
			DitheringModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr, 100664096);
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00087208 File Offset: 0x00085408
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x00087244 File Offset: 0x00085444
		public unsafe DitheringModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00087284 File Offset: 0x00085484
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42641, RefRangeEnd = 42643, XrefRangeStart = 42641, XrefRangeEnd = 42643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DitheringModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000872C0 File Offset: 0x000854C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77885, XrefRangeEnd = 77886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DitheringModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00006127 File Offset: 0x00004327
		public DitheringModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x000872FC File Offset: 0x000854FC
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00006130 File Offset: 0x00004330
		public unsafe DitheringModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DitheringModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DitheringModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007F8 RID: 2040
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BCD2 RID: 48338 RVA: 0x0005C62D File Offset: 0x0005A82D
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<DitheringModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DitheringModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DitheringModel.Settings>.NativeClassPtr);
				DitheringModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringModel.Settings>.NativeClassPtr, 100664097);
			}

			// Token: 0x17003A89 RID: 14985
			// (get) Token: 0x0600BCD3 RID: 48339 RVA: 0x002E8958 File Offset: 0x002E6B58
			public unsafe static DitheringModel.Settings defaultSettings
			{
				[CallerCount(183)]
				[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCD4 RID: 48340 RVA: 0x0005C661 File Offset: 0x0005A861
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DitheringModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FB3 RID: 32691
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;
		}
	}
}
