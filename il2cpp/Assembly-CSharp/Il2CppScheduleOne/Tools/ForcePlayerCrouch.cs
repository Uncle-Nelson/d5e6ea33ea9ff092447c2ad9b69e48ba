using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200053B RID: 1339
	public class ForcePlayerCrouch : MonoBehaviour
	{
		// Token: 0x060076FA RID: 30458 RVA: 0x00204D48 File Offset: 0x00202F48
		// Note: this type is marked as 'beforefieldinit'.
		static ForcePlayerCrouch()
		{
			Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ForcePlayerCrouch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr);
			ForcePlayerCrouch.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr, 100678287);
			ForcePlayerCrouch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr, 100678288);
		}

		// Token: 0x060076FB RID: 30459 RVA: 0x00204DA0 File Offset: 0x00202FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231512, XrefRangeEnd = 231532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForcePlayerCrouch.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076FC RID: 30460 RVA: 0x00204DE4 File Offset: 0x00202FE4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForcePlayerCrouch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForcePlayerCrouch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076FD RID: 30461 RVA: 0x000385CD File Offset: 0x000367CD
		public ForcePlayerCrouch(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400513C RID: 20796
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x0400513D RID: 20797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
