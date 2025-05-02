using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000062 RID: 98
	[Serializable]
	public class ChromaticAberrationModel : PostProcessingModel
	{
		// Token: 0x0600074F RID: 1871 RVA: 0x00086A2C File Offset: 0x00084C2C
		// Note: this type is marked as 'beforefieldinit'.
		static ChromaticAberrationModel()
		{
			Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "ChromaticAberrationModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr);
			ChromaticAberrationModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr, "m_Settings");
			ChromaticAberrationModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr, 100664066);
			ChromaticAberrationModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr, 100664067);
			ChromaticAberrationModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr, 100664068);
			ChromaticAberrationModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr, 100664069);
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00086AC0 File Offset: 0x00084CC0
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00086AF8 File Offset: 0x00084CF8
		public unsafe ChromaticAberrationModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ChromaticAberrationModel.Settings(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77774, XrefRangeEnd = 77775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00086B40 File Offset: 0x00084D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77775, XrefRangeEnd = 77777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChromaticAberrationModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00086B7C File Offset: 0x00084D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77777, XrefRangeEnd = 77780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChromaticAberrationModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0000605B File Offset: 0x0000425B
		public ChromaticAberrationModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00086BB8 File Offset: 0x00084DB8
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00006064 File Offset: 0x00004264
		public ChromaticAberrationModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationModel.NativeFieldInfoPtr_m_Settings);
				return new ChromaticAberrationModel.Settings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationModel.NativeFieldInfoPtr_m_Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007EB RID: 2027
		[Serializable]
		public sealed class Settings : ValueType
		{
			// Token: 0x0600BC89 RID: 48265 RVA: 0x002E7D98 File Offset: 0x002E5F98
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr);
				ChromaticAberrationModel.Settings.NativeFieldInfoPtr_spectralTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr, "spectralTexture");
				ChromaticAberrationModel.Settings.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr, "intensity");
				ChromaticAberrationModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr, 100664070);
			}

			// Token: 0x17003A6D RID: 14957
			// (get) Token: 0x0600BC8A RID: 48266 RVA: 0x002E7E00 File Offset: 0x002E6000
			public unsafe static ChromaticAberrationModel.Settings defaultSettings
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77773, XrefRangeEnd = 77774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new ChromaticAberrationModel.Settings(pointer);
				}
			}

			// Token: 0x0600BC8B RID: 48267 RVA: 0x0005C30B File Offset: 0x0005A50B
			public Settings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BC8C RID: 48268 RVA: 0x0005C314 File Offset: 0x0005A514
			public Settings() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr))
			{
			}

			// Token: 0x17003A6B RID: 14955
			// (get) Token: 0x0600BC8D RID: 48269 RVA: 0x002E7E2C File Offset: 0x002E602C
			// (set) Token: 0x0600BC8E RID: 48270 RVA: 0x0005C326 File Offset: 0x0005A526
			public unsafe Texture2D spectralTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationModel.Settings.NativeFieldInfoPtr_spectralTexture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationModel.Settings.NativeFieldInfoPtr_spectralTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A6C RID: 14956
			// (get) Token: 0x0600BC8F RID: 48271 RVA: 0x002E7E5C File Offset: 0x002E605C
			// (set) Token: 0x0600BC90 RID: 48272 RVA: 0x0005C345 File Offset: 0x0005A545
			public unsafe float intensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationModel.Settings.NativeFieldInfoPtr_intensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationModel.Settings.NativeFieldInfoPtr_intensity)) = value;
				}
			}

			// Token: 0x04007F4B RID: 32587
			private static readonly IntPtr NativeFieldInfoPtr_spectralTexture;

			// Token: 0x04007F4C RID: 32588
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04007F4D RID: 32589
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;
		}
	}
}
