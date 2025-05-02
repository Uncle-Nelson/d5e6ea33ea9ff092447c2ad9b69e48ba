using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppBeautify.Demos
{
	// Token: 0x0200013A RID: 314
	public class ToggleDoF : MonoBehaviour
	{
		// Token: 0x06001A4C RID: 6732 RVA: 0x000C2C28 File Offset: 0x000C0E28
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleDoF()
		{
			Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Beautify.Demos", "ToggleDoF");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr);
			ToggleDoF.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr, 100666088);
			ToggleDoF.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr, 100666089);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x000C2C80 File Offset: 0x000C0E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97140, XrefRangeEnd = 97146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleDoF.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x000C2CB4 File Offset: 0x000C0EB4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleDoF() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleDoF>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleDoF.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0000EEAB File Offset: 0x0000D0AB
		public ToggleDoF(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
