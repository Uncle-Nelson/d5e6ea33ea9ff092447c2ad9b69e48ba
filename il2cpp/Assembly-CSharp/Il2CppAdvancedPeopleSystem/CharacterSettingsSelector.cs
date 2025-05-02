using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000156 RID: 342
	[Serializable]
	public class CharacterSettingsSelector : Object
	{
		// Token: 0x06001BF8 RID: 7160 RVA: 0x000C78A4 File Offset: 0x000C5AA4
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterSettingsSelector()
		{
			Il2CppClassPointerStore<CharacterSettingsSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterSettingsSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSettingsSelector>.NativeClassPtr);
			CharacterSettingsSelector.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettingsSelector>.NativeClassPtr, "name");
			CharacterSettingsSelector.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettingsSelector>.NativeClassPtr, "settings");
			CharacterSettingsSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSettingsSelector>.NativeClassPtr, 100666235);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x000C7910 File Offset: 0x000C5B10
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterSettingsSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSettingsSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSettingsSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0000FE97 File Offset: 0x0000E097
		public CharacterSettingsSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001BFB RID: 7163 RVA: 0x000C794C File Offset: 0x000C5B4C
		// (set) Token: 0x06001BFC RID: 7164 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettingsSelector.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettingsSelector.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x000C7974 File Offset: 0x000C5B74
		// (set) Token: 0x06001BFE RID: 7166 RVA: 0x0000FEBF File Offset: 0x0000E0BF
		public unsafe CharacterSettings settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettingsSelector.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettingsSelector.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
