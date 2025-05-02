using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppEasyButtons.Example
{
	// Token: 0x02000138 RID: 312
	public class ScriptableObjectExample : ScriptableObject
	{
		// Token: 0x06001A3E RID: 6718 RVA: 0x000C2934 File Offset: 0x000C0B34
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableObjectExample()
		{
			Il2CppClassPointerStore<ScriptableObjectExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "EasyButtons.Example", "ScriptableObjectExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableObjectExample>.NativeClassPtr);
			ScriptableObjectExample.NativeMethodInfoPtr_SayHello_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObjectExample>.NativeClassPtr, 100666080);
			ScriptableObjectExample.NativeMethodInfoPtr_SayHelloEditor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObjectExample>.NativeClassPtr, 100666081);
			ScriptableObjectExample.NativeMethodInfoPtr_SayHelloPlayMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObjectExample>.NativeClassPtr, 100666082);
			ScriptableObjectExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObjectExample>.NativeClassPtr, 100666083);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x000C29B4 File Offset: 0x000C0BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97028, XrefRangeEnd = 97043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayHello()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObjectExample.NativeMethodInfoPtr_SayHello_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x000C29E8 File Offset: 0x000C0BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97043, XrefRangeEnd = 97049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayHelloEditor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObjectExample.NativeMethodInfoPtr_SayHelloEditor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000C2A1C File Offset: 0x000C0C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97049, XrefRangeEnd = 97055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayHelloPlayMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObjectExample.NativeMethodInfoPtr_SayHelloPlayMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x000C2A50 File Offset: 0x000C0C50
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88919, RefRangeEnd = 88931, XrefRangeStart = 88919, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableObjectExample() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableObjectExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObjectExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0000EE7A File Offset: 0x0000D07A
		public ScriptableObjectExample(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeMethodInfoPtr_SayHello_Public_Void_0;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr_SayHelloEditor_Public_Void_0;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr_SayHelloPlayMode_Public_Void_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
