using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000068 RID: 104
	[Serializable]
	public class GrainModel : PostProcessingModel
	{
		// Token: 0x06000788 RID: 1928 RVA: 0x00087684 File Offset: 0x00085884
		// Note: this type is marked as 'beforefieldinit'.
		static GrainModel()
		{
			Il2CppClassPointerStore<GrainModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "GrainModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrainModel>.NativeClassPtr);
			GrainModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainModel>.NativeClassPtr, "m_Settings");
			GrainModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainModel>.NativeClassPtr, 100664108);
			GrainModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainModel>.NativeClassPtr, 100664109);
			GrainModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainModel>.NativeClassPtr, 100664110);
			GrainModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainModel>.NativeClassPtr, 100664111);
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00087718 File Offset: 0x00085918
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x00087754 File Offset: 0x00085954
		public unsafe GrainModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00087794 File Offset: 0x00085994
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrainModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x000877D0 File Offset: 0x000859D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77888, XrefRangeEnd = 77889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrainModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrainModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00006193 File Offset: 0x00004393
		public GrainModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x0008780C File Offset: 0x00085A0C
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x0000619C File Offset: 0x0000439C
		public unsafe GrainModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrainModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrainModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007FC RID: 2044
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BCDB RID: 48347 RVA: 0x002E8B58 File Offset: 0x002E6D58
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrainModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr);
				GrainModel.Settings.NativeFieldInfoPtr_colored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr, "colored");
				GrainModel.Settings.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr, "intensity");
				GrainModel.Settings.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr, "size");
				GrainModel.Settings.NativeFieldInfoPtr_luminanceContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr, "luminanceContribution");
				GrainModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr, 100664112);
			}

			// Token: 0x17003A8C RID: 14988
			// (get) Token: 0x0600BCDC RID: 48348 RVA: 0x002E8BE8 File Offset: 0x002E6DE8
			public unsafe static GrainModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCDD RID: 48349 RVA: 0x0005C697 File Offset: 0x0005A897
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FD1 RID: 32721
			private static readonly IntPtr NativeFieldInfoPtr_colored;

			// Token: 0x04007FD2 RID: 32722
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04007FD3 RID: 32723
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x04007FD4 RID: 32724
			private static readonly IntPtr NativeFieldInfoPtr_luminanceContribution;

			// Token: 0x04007FD5 RID: 32725
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007FD6 RID: 32726
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool colored;

			// Token: 0x04007FD7 RID: 32727
			[FieldOffset(4)]
			public float intensity;

			// Token: 0x04007FD8 RID: 32728
			[FieldOffset(8)]
			public float size;

			// Token: 0x04007FD9 RID: 32729
			[FieldOffset(12)]
			public float luminanceContribution;
		}
	}
}
