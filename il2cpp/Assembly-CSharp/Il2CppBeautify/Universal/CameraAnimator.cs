using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppBeautify.Universal
{
	// Token: 0x0200013B RID: 315
	public class CameraAnimator : MonoBehaviour
	{
		// Token: 0x06001A50 RID: 6736 RVA: 0x000C2CF0 File Offset: 0x000C0EF0
		// Note: this type is marked as 'beforefieldinit'.
		static CameraAnimator()
		{
			Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Beautify.Universal", "CameraAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr);
			CameraAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, 100666090);
			CameraAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, 100666091);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x000C2D48 File Offset: 0x000C0F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97146, XrefRangeEnd = 97149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x000C2D7C File Offset: 0x000C0F7C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
		public CameraAnimator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
