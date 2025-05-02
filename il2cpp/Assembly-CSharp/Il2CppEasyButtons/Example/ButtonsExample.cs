using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppEasyButtons.Example
{
	// Token: 0x02000136 RID: 310
	public class ButtonsExample : MonoBehaviour
	{
		// Token: 0x06001A2D RID: 6701 RVA: 0x000C24FC File Offset: 0x000C06FC
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonsExample()
		{
			Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "EasyButtons.Example", "ButtonsExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr);
			ButtonsExample.NativeMethodInfoPtr_SayMyName_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666067);
			ButtonsExample.NativeMethodInfoPtr_SayHelloEditor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666068);
			ButtonsExample.NativeMethodInfoPtr_SayHelloInRuntime_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666069);
			ButtonsExample.NativeMethodInfoPtr_TestButtonName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666070);
			ButtonsExample.NativeMethodInfoPtr_TestButtonNameEditorOnly_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666071);
			ButtonsExample.NativeMethodInfoPtr_TestStaticMethod_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666072);
			ButtonsExample.NativeMethodInfoPtr_TestButtonSpaceBoth_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666073);
			ButtonsExample.NativeMethodInfoPtr_TestButtonWithParams_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666074);
			ButtonsExample.NativeMethodInfoPtr_TestExpandedButton_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666075);
			ButtonsExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666076);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x000C25F4 File Offset: 0x000C07F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96961, XrefRangeEnd = 96966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayMyName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_SayMyName_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x000C2628 File Offset: 0x000C0828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96966, XrefRangeEnd = 96972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayHelloEditor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_SayHelloEditor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x000C265C File Offset: 0x000C085C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96972, XrefRangeEnd = 96978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayHelloInRuntime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_SayHelloInRuntime_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x000C2690 File Offset: 0x000C0890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96978, XrefRangeEnd = 96984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestButtonName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_TestButtonName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x000C26C4 File Offset: 0x000C08C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96984, XrefRangeEnd = 96990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestButtonNameEditorOnly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_TestButtonNameEditorOnly_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x000C26F8 File Offset: 0x000C08F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96990, XrefRangeEnd = 96996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestStaticMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_TestStaticMethod_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x000C2720 File Offset: 0x000C0920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96996, XrefRangeEnd = 97002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestButtonSpaceBoth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_TestButtonSpaceBoth_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x000C2754 File Offset: 0x000C0954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97002, XrefRangeEnd = 97012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestButtonWithParams(string message, int number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_TestButtonWithParams_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x000C27A4 File Offset: 0x000C09A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97012, XrefRangeEnd = 97016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestExpandedButton(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_TestExpandedButton_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x000C27E8 File Offset: 0x000C09E8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonsExample() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0000EE68 File Offset: 0x0000D068
		public ButtonsExample(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeMethodInfoPtr_SayMyName_Public_Void_0;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeMethodInfoPtr_SayHelloEditor_Protected_Void_0;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeMethodInfoPtr_SayHelloInRuntime_Private_Void_0;

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeMethodInfoPtr_TestButtonName_Private_Void_0;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeMethodInfoPtr_TestButtonNameEditorOnly_Private_Void_0;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeMethodInfoPtr_TestStaticMethod_Private_Static_Void_0;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeMethodInfoPtr_TestButtonSpaceBoth_Private_Void_0;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeMethodInfoPtr_TestButtonWithParams_Private_Void_String_Int32_0;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeMethodInfoPtr_TestExpandedButton_Private_Void_String_0;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
