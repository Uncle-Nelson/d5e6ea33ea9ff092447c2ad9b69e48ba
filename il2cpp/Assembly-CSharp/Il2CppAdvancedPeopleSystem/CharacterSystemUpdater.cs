using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000148 RID: 328
	public static class CharacterSystemUpdater : Object
	{
		// Token: 0x06001B57 RID: 6999 RVA: 0x000C60CC File Offset: 0x000C42CC
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterSystemUpdater()
		{
			Il2CppClassPointerStore<CharacterSystemUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterSystemUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSystemUpdater>.NativeClassPtr);
			CharacterSystemUpdater.NativeMethodInfoPtr_updateCharacters_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSystemUpdater>.NativeClassPtr, 100666216);
			CharacterSystemUpdater.NativeMethodInfoPtr_UpdateCharactersOnScene_Public_Static_Void_Boolean_CharacterCustomization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSystemUpdater>.NativeClassPtr, 100666217);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x000C6124 File Offset: 0x000C4324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100296, XrefRangeEnd = 100307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void updateCharacters()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSystemUpdater.NativeMethodInfoPtr_updateCharacters_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x000C614C File Offset: 0x000C434C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateCharactersOnScene(bool revertPrefabs = false, CharacterCustomization reverbObject = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref revertPrefabs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reverbObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSystemUpdater.NativeMethodInfoPtr_UpdateCharactersOnScene_Public_Static_Void_Boolean_CharacterCustomization_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0000F74C File Offset: 0x0000D94C
		public CharacterSystemUpdater(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_updateCharacters_Private_Static_Void_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCharactersOnScene_Public_Static_Void_Boolean_CharacterCustomization_0;
	}
}
