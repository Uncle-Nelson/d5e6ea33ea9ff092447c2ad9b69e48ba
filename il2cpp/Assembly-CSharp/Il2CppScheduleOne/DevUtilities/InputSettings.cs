using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000474 RID: 1140
	[Serializable]
	public class InputSettings : Object
	{
		// Token: 0x06006277 RID: 25207 RVA: 0x001BFA6C File Offset: 0x001BDC6C
		// Note: this type is marked as 'beforefieldinit'.
		static InputSettings()
		{
			Il2CppClassPointerStore<InputSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "InputSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputSettings>.NativeClassPtr);
			InputSettings.NativeFieldInfoPtr_MouseSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "MouseSensitivity");
			InputSettings.NativeFieldInfoPtr_InvertMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "InvertMouse");
			InputSettings.NativeFieldInfoPtr_SprintMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "SprintMode");
			InputSettings.NativeFieldInfoPtr_BindingOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "BindingOverrides");
			InputSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, 100675777);
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x001BFB00 File Offset: 0x001BDD00
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x0002E8F7 File Offset: 0x0002CAF7
		public InputSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x0600627A RID: 25210 RVA: 0x001BFB3C File Offset: 0x001BDD3C
		// (set) Token: 0x0600627B RID: 25211 RVA: 0x0002E900 File Offset: 0x0002CB00
		public unsafe float MouseSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_MouseSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_MouseSensitivity)) = value;
			}
		}

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x0600627C RID: 25212 RVA: 0x001BFB64 File Offset: 0x001BDD64
		// (set) Token: 0x0600627D RID: 25213 RVA: 0x0002E91B File Offset: 0x0002CB1B
		public unsafe bool InvertMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_InvertMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_InvertMouse)) = value;
			}
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x0600627E RID: 25214 RVA: 0x001BFB8C File Offset: 0x001BDD8C
		// (set) Token: 0x0600627F RID: 25215 RVA: 0x0002E936 File Offset: 0x0002CB36
		public unsafe InputSettings.EActionMode SprintMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_SprintMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_SprintMode)) = value;
			}
		}

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x06006280 RID: 25216 RVA: 0x001BFBB4 File Offset: 0x001BDDB4
		// (set) Token: 0x06006281 RID: 25217 RVA: 0x0002E951 File Offset: 0x0002CB51
		public unsafe string BindingOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_BindingOverrides);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_BindingOverrides), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004326 RID: 17190
		private static readonly IntPtr NativeFieldInfoPtr_MouseSensitivity;

		// Token: 0x04004327 RID: 17191
		private static readonly IntPtr NativeFieldInfoPtr_InvertMouse;

		// Token: 0x04004328 RID: 17192
		private static readonly IntPtr NativeFieldInfoPtr_SprintMode;

		// Token: 0x04004329 RID: 17193
		private static readonly IntPtr NativeFieldInfoPtr_BindingOverrides;

		// Token: 0x0400432A RID: 17194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A20 RID: 2592
		[OriginalName("Assembly-CSharp.dll", "", "EActionMode")]
		public enum EActionMode
		{
			// Token: 0x04008BC0 RID: 35776
			Press,
			// Token: 0x04008BC1 RID: 35777
			Hold
		}
	}
}
