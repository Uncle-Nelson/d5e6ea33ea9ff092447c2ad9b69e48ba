using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x020006F1 RID: 1777
	public class PromptImage : MonoBehaviour
	{
		// Token: 0x06009F03 RID: 40707 RVA: 0x002823DC File Offset: 0x002805DC
		// Note: this type is marked as 'beforefieldinit'.
		static PromptImage()
		{
			Il2CppClassPointerStore<PromptImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "PromptImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptImage>.NativeClassPtr);
			PromptImage.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptImage>.NativeClassPtr, "Width");
			PromptImage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptImage>.NativeClassPtr, 100682794);
		}

		// Token: 0x06009F04 RID: 40708 RVA: 0x00282434 File Offset: 0x00280634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281290, XrefRangeEnd = 281291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptImage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptImage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptImage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F05 RID: 40709 RVA: 0x0004E049 File Offset: 0x0004C249
		public PromptImage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x06009F06 RID: 40710 RVA: 0x00282470 File Offset: 0x00280670
		// (set) Token: 0x06009F07 RID: 40711 RVA: 0x0004E052 File Offset: 0x0004C252
		public unsafe float Width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImage.NativeFieldInfoPtr_Width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImage.NativeFieldInfoPtr_Width)) = value;
			}
		}

		// Token: 0x04006AB2 RID: 27314
		private static readonly IntPtr NativeFieldInfoPtr_Width;

		// Token: 0x04006AB3 RID: 27315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
