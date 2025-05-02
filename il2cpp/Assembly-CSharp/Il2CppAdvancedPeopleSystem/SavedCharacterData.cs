using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200015E RID: 350
	public class SavedCharacterData : Object
	{
		// Token: 0x06001C3F RID: 7231 RVA: 0x000C830C File Offset: 0x000C650C
		// Note: this type is marked as 'beforefieldinit'.
		static SavedCharacterData()
		{
			Il2CppClassPointerStore<SavedCharacterData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "SavedCharacterData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SavedCharacterData>.NativeClassPtr);
			SavedCharacterData.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedCharacterData>.NativeClassPtr, "name");
			SavedCharacterData.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedCharacterData>.NativeClassPtr, "path");
			SavedCharacterData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedCharacterData>.NativeClassPtr, 100666244);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x000C8378 File Offset: 0x000C6578
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SavedCharacterData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SavedCharacterData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedCharacterData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x000101AA File Offset: 0x0000E3AA
		public SavedCharacterData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x000C83B4 File Offset: 0x000C65B4
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x000101B3 File Offset: 0x0000E3B3
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedCharacterData.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedCharacterData.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x000C83DC File Offset: 0x000C65DC
		// (set) Token: 0x06001C45 RID: 7237 RVA: 0x000101D2 File Offset: 0x0000E3D2
		public unsafe string path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedCharacterData.NativeFieldInfoPtr_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedCharacterData.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
