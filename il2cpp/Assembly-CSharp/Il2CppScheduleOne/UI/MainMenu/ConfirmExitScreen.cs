using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006E3 RID: 1763
	public class ConfirmExitScreen : MainMenuScreen
	{
		// Token: 0x06009E33 RID: 40499 RVA: 0x0027FCD0 File Offset: 0x0027DED0
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmExitScreen()
		{
			Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "ConfirmExitScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr);
			ConfirmExitScreen.NativeFieldInfoPtr_TimeSinceSaveLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, "TimeSinceSaveLabel");
			ConfirmExitScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, 100682705);
			ConfirmExitScreen.NativeMethodInfoPtr_ConfirmExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, 100682706);
			ConfirmExitScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, 100682707);
		}

		// Token: 0x06009E34 RID: 40500 RVA: 0x0027FD50 File Offset: 0x0027DF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280257, XrefRangeEnd = 280270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmExitScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E35 RID: 40501 RVA: 0x0027FD84 File Offset: 0x0027DF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280270, XrefRangeEnd = 280276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmExitScreen.NativeMethodInfoPtr_ConfirmExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E36 RID: 40502 RVA: 0x0027FDB8 File Offset: 0x0027DFB8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmExitScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmExitScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E37 RID: 40503 RVA: 0x0004D99B File Offset: 0x0004BB9B
		public ConfirmExitScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x06009E38 RID: 40504 RVA: 0x0027FDF4 File Offset: 0x0027DFF4
		// (set) Token: 0x06009E39 RID: 40505 RVA: 0x0004D9A4 File Offset: 0x0004BBA4
		public unsafe TextMeshProUGUI TimeSinceSaveLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmExitScreen.NativeFieldInfoPtr_TimeSinceSaveLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmExitScreen.NativeFieldInfoPtr_TimeSinceSaveLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A35 RID: 27189
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceSaveLabel;

		// Token: 0x04006A36 RID: 27190
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006A37 RID: 27191
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmExit_Public_Void_0;

		// Token: 0x04006A38 RID: 27192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
