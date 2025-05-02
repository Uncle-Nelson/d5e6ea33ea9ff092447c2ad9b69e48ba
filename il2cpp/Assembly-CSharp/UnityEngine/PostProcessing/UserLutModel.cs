using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200006B RID: 107
	[Serializable]
	public class UserLutModel : PostProcessingModel
	{
		// Token: 0x060007A0 RID: 1952 RVA: 0x00087B94 File Offset: 0x00085D94
		// Note: this type is marked as 'beforefieldinit'.
		static UserLutModel()
		{
			Il2CppClassPointerStore<UserLutModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "UserLutModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr);
			UserLutModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr, "m_Settings");
			UserLutModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr, 100664123);
			UserLutModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr, 100664124);
			UserLutModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr, 100664125);
			UserLutModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr, 100664126);
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00087C28 File Offset: 0x00085E28
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00087C60 File Offset: 0x00085E60
		public unsafe UserLutModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UserLutModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UserLutModel.Settings(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserLutModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00087CA8 File Offset: 0x00085EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77892, XrefRangeEnd = 77894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserLutModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00087CE4 File Offset: 0x00085EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77894, XrefRangeEnd = 77897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserLutModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserLutModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000061FF File Offset: 0x000043FF
		public UserLutModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00087D20 File Offset: 0x00085F20
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00006208 File Offset: 0x00004408
		public UserLutModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserLutModel.NativeFieldInfoPtr_m_Settings);
				return new UserLutModel.Settings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserLutModel.NativeFieldInfoPtr_m_Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000804 RID: 2052
		[Serializable]
		public sealed class Settings : ValueType
		{
			// Token: 0x0600BCEA RID: 48362 RVA: 0x002E8EB8 File Offset: 0x002E70B8
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserLutModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr);
				UserLutModel.Settings.NativeFieldInfoPtr_lut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr, "lut");
				UserLutModel.Settings.NativeFieldInfoPtr_contribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr, "contribution");
				UserLutModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr, 100664127);
			}

			// Token: 0x17003A91 RID: 14993
			// (get) Token: 0x0600BCEB RID: 48363 RVA: 0x002E8F20 File Offset: 0x002E7120
			public unsafe static UserLutModel.Settings defaultSettings
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77891, XrefRangeEnd = 77892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UserLutModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new UserLutModel.Settings(pointer);
				}
			}

			// Token: 0x0600BCEC RID: 48364 RVA: 0x0005C737 File Offset: 0x0005A937
			public Settings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BCED RID: 48365 RVA: 0x0005C740 File Offset: 0x0005A940
			public Settings() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserLutModel.Settings>.NativeClassPtr))
			{
			}

			// Token: 0x17003A8F RID: 14991
			// (get) Token: 0x0600BCEE RID: 48366 RVA: 0x002E8F4C File Offset: 0x002E714C
			// (set) Token: 0x0600BCEF RID: 48367 RVA: 0x0005C752 File Offset: 0x0005A952
			public unsafe Texture2D lut
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserLutModel.Settings.NativeFieldInfoPtr_lut);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserLutModel.Settings.NativeFieldInfoPtr_lut), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A90 RID: 14992
			// (get) Token: 0x0600BCF0 RID: 48368 RVA: 0x002E8F7C File Offset: 0x002E717C
			// (set) Token: 0x0600BCF1 RID: 48369 RVA: 0x0005C771 File Offset: 0x0005A971
			public unsafe float contribution
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserLutModel.Settings.NativeFieldInfoPtr_contribution);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserLutModel.Settings.NativeFieldInfoPtr_contribution)) = value;
				}
			}

			// Token: 0x04008008 RID: 32776
			private static readonly IntPtr NativeFieldInfoPtr_lut;

			// Token: 0x04008009 RID: 32777
			private static readonly IntPtr NativeFieldInfoPtr_contribution;

			// Token: 0x0400800A RID: 32778
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;
		}
	}
}
