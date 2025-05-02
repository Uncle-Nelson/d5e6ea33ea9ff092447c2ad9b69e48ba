using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppVLB_Samples
{
	// Token: 0x020000BB RID: 187
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		// Token: 0x06000E03 RID: 3587 RVA: 0x0009DAD4 File Offset: 0x0009BCD4
		// Note: this type is marked as 'beforefieldinit'.
		static FeaturesNotSupportedMessage()
		{
			Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "FeaturesNotSupportedMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr);
			FeaturesNotSupportedMessage.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr, 100665022);
			FeaturesNotSupportedMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr, 100665023);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0009DB2C File Offset: 0x0009BD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85516, XrefRangeEnd = 85522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesNotSupportedMessage.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0009DB60 File Offset: 0x0009BD60
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeaturesNotSupportedMessage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesNotSupportedMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00008C1D File Offset: 0x00006E1D
		public FeaturesNotSupportedMessage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
