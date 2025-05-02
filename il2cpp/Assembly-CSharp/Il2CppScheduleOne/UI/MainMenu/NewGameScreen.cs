using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006EB RID: 1771
	public class NewGameScreen : MainMenuScreen
	{
		// Token: 0x06009E90 RID: 40592 RVA: 0x00280DD8 File Offset: 0x0027EFD8
		// Note: this type is marked as 'beforefieldinit'.
		static NewGameScreen()
		{
			Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "NewGameScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr);
			NewGameScreen.NativeFieldInfoPtr_ConfirmOverwriteScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, "ConfirmOverwriteScreen");
			NewGameScreen.NativeFieldInfoPtr_SetupScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, "SetupScreen");
			NewGameScreen.NativeMethodInfoPtr_SlotSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, 100682751);
			NewGameScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, 100682752);
		}

		// Token: 0x06009E91 RID: 40593 RVA: 0x00280E58 File Offset: 0x0027F058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280549, XrefRangeEnd = 280555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotSelected(int slotIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slotIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewGameScreen.NativeMethodInfoPtr_SlotSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E92 RID: 40594 RVA: 0x00280E98 File Offset: 0x0027F098
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewGameScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewGameScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E93 RID: 40595 RVA: 0x0004DC65 File Offset: 0x0004BE65
		public NewGameScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x06009E94 RID: 40596 RVA: 0x00280ED4 File Offset: 0x0027F0D4
		// (set) Token: 0x06009E95 RID: 40597 RVA: 0x0004DC6E File Offset: 0x0004BE6E
		public unsafe ConfirmOverwriteScreen ConfirmOverwriteScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_ConfirmOverwriteScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOverwriteScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_ConfirmOverwriteScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x06009E96 RID: 40598 RVA: 0x00280F04 File Offset: 0x0027F104
		// (set) Token: 0x06009E97 RID: 40599 RVA: 0x0004DC8D File Offset: 0x0004BE8D
		public unsafe SetupScreen SetupScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_SetupScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_SetupScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A6B RID: 27243
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmOverwriteScreen;

		// Token: 0x04006A6C RID: 27244
		private static readonly IntPtr NativeFieldInfoPtr_SetupScreen;

		// Token: 0x04006A6D RID: 27245
		private static readonly IntPtr NativeMethodInfoPtr_SlotSelected_Public_Void_Int32_0;

		// Token: 0x04006A6E RID: 27246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
