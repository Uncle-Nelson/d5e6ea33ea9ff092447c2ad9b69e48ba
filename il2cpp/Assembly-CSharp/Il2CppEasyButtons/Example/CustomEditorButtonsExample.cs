using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppEasyButtons.Example
{
	// Token: 0x02000137 RID: 311
	public class CustomEditorButtonsExample : MonoBehaviour
	{
		// Token: 0x06001A39 RID: 6713 RVA: 0x000C2824 File Offset: 0x000C0A24
		// Note: this type is marked as 'beforefieldinit'.
		static CustomEditorButtonsExample()
		{
			Il2CppClassPointerStore<CustomEditorButtonsExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "EasyButtons.Example", "CustomEditorButtonsExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomEditorButtonsExample>.NativeClassPtr);
			CustomEditorButtonsExample.NativeMethodInfoPtr_SayHello_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEditorButtonsExample>.NativeClassPtr, 100666077);
			CustomEditorButtonsExample.NativeMethodInfoPtr_SecondButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEditorButtonsExample>.NativeClassPtr, 100666078);
			CustomEditorButtonsExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEditorButtonsExample>.NativeClassPtr, 100666079);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x000C2890 File Offset: 0x000C0A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97016, XrefRangeEnd = 97022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayHello()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEditorButtonsExample.NativeMethodInfoPtr_SayHello_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x000C28C4 File Offset: 0x000C0AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97022, XrefRangeEnd = 97028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SecondButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEditorButtonsExample.NativeMethodInfoPtr_SecondButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x000C28F8 File Offset: 0x000C0AF8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomEditorButtonsExample() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomEditorButtonsExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEditorButtonsExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0000EE71 File Offset: 0x0000D071
		public CustomEditorButtonsExample(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeMethodInfoPtr_SayHello_Private_Void_0;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeMethodInfoPtr_SecondButton_Private_Void_0;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
