using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006E4 RID: 1764
	public class ConfirmOverwriteScreen : MainMenuScreen
	{
		// Token: 0x06009E3A RID: 40506 RVA: 0x0027FE24 File Offset: 0x0027E024
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmOverwriteScreen()
		{
			Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "ConfirmOverwriteScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr);
			ConfirmOverwriteScreen.NativeFieldInfoPtr_SetupScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, "SetupScreen");
			ConfirmOverwriteScreen.NativeFieldInfoPtr_slotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, "slotIndex");
			ConfirmOverwriteScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, 100682708);
			ConfirmOverwriteScreen.NativeMethodInfoPtr_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, 100682709);
			ConfirmOverwriteScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, 100682710);
		}

		// Token: 0x06009E3B RID: 40507 RVA: 0x0027FEB8 File Offset: 0x0027E0B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 48697, RefRangeEnd = 48700, XrefRangeStart = 48697, XrefRangeEnd = 48700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOverwriteScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E3C RID: 40508 RVA: 0x0027FEF8 File Offset: 0x0027E0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280276, XrefRangeEnd = 280277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOverwriteScreen.NativeMethodInfoPtr_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E3D RID: 40509 RVA: 0x0027FF2C File Offset: 0x0027E12C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmOverwriteScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOverwriteScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E3E RID: 40510 RVA: 0x0004D9C3 File Offset: 0x0004BBC3
		public ConfirmOverwriteScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x06009E3F RID: 40511 RVA: 0x0027FF68 File Offset: 0x0027E168
		// (set) Token: 0x06009E40 RID: 40512 RVA: 0x0004D9CC File Offset: 0x0004BBCC
		public unsafe SetupScreen SetupScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_SetupScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_SetupScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x06009E41 RID: 40513 RVA: 0x0027FF98 File Offset: 0x0027E198
		// (set) Token: 0x06009E42 RID: 40514 RVA: 0x0004D9EB File Offset: 0x0004BBEB
		public unsafe int slotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_slotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_slotIndex)) = value;
			}
		}

		// Token: 0x04006A39 RID: 27193
		private static readonly IntPtr NativeFieldInfoPtr_SetupScreen;

		// Token: 0x04006A3A RID: 27194
		private static readonly IntPtr NativeFieldInfoPtr_slotIndex;

		// Token: 0x04006A3B RID: 27195
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_0;

		// Token: 0x04006A3C RID: 27196
		private static readonly IntPtr NativeMethodInfoPtr_Confirm_Public_Void_0;

		// Token: 0x04006A3D RID: 27197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
