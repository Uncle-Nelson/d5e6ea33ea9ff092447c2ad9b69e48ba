using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x020006F2 RID: 1778
	public class PromptImageWithText : PromptImage
	{
		// Token: 0x06009F08 RID: 40712 RVA: 0x00282498 File Offset: 0x00280698
		// Note: this type is marked as 'beforefieldinit'.
		static PromptImageWithText()
		{
			Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "PromptImageWithText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr);
			PromptImageWithText.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr, "Label");
			PromptImageWithText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr, 100682795);
		}

		// Token: 0x06009F09 RID: 40713 RVA: 0x002824F0 File Offset: 0x002806F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptImageWithText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptImageWithText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F0A RID: 40714 RVA: 0x0004E06D File Offset: 0x0004C26D
		public PromptImageWithText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x06009F0B RID: 40715 RVA: 0x0028252C File Offset: 0x0028072C
		// (set) Token: 0x06009F0C RID: 40716 RVA: 0x0004E076 File Offset: 0x0004C276
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImageWithText.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImageWithText.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006AB4 RID: 27316
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006AB5 RID: 27317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
