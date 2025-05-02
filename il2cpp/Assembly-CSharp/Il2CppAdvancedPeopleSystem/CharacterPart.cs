using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000142 RID: 322
	[Serializable]
	public class CharacterPart : Il2CppSystem.Object
	{
		// Token: 0x06001B03 RID: 6915 RVA: 0x000C53E4 File Offset: 0x000C35E4
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterPart()
		{
			Il2CppClassPointerStore<CharacterPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterPart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterPart>.NativeClassPtr);
			CharacterPart.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPart>.NativeClassPtr, "name");
			CharacterPart.NativeFieldInfoPtr_skinnedMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPart>.NativeClassPtr, "skinnedMesh");
			CharacterPart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPart>.NativeClassPtr, 100666193);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x000C5450 File Offset: 0x000C3650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99592, RefRangeEnd = 99593, XrefRangeStart = 99584, XrefRangeEnd = 99592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterPart() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterPart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterPart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0000F3F7 File Offset: 0x0000D5F7
		public CharacterPart(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x000C548C File Offset: 0x000C368C
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x0000F400 File Offset: 0x0000D600
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPart.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPart.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x000C54B4 File Offset: 0x000C36B4
		// (set) Token: 0x06001B09 RID: 6921 RVA: 0x0000F41F File Offset: 0x0000D61F
		public unsafe List<SkinnedMeshRenderer> skinnedMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPart.NativeFieldInfoPtr_skinnedMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPart.NativeFieldInfoPtr_skinnedMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeFieldInfoPtr_skinnedMesh;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
