using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054D RID: 1357
	public class SafeBalanceActivationZone : MonoBehaviour
	{
		// Token: 0x060077C9 RID: 30665 RVA: 0x00207398 File Offset: 0x00205598
		// Note: this type is marked as 'beforefieldinit'.
		static SafeBalanceActivationZone()
		{
			Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SafeBalanceActivationZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr);
			SafeBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "ActivationDistance");
			SafeBalanceActivationZone.NativeFieldInfoPtr_Safe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "Safe");
			SafeBalanceActivationZone.NativeFieldInfoPtr_exclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "exclude");
			SafeBalanceActivationZone.NativeFieldInfoPtr_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "colliders");
			SafeBalanceActivationZone.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "active");
			SafeBalanceActivationZone.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678371);
			SafeBalanceActivationZone.NativeMethodInfoPtr_UpdateCollider_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678372);
			SafeBalanceActivationZone.NativeMethodInfoPtr_Activate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678373);
			SafeBalanceActivationZone.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678374);
			SafeBalanceActivationZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678375);
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x00207490 File Offset: 0x00205690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232184, XrefRangeEnd = 232194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077CB RID: 30667 RVA: 0x002074C4 File Offset: 0x002056C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232194, XrefRangeEnd = 232202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCollider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr_UpdateCollider_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077CC RID: 30668 RVA: 0x002074F8 File Offset: 0x002056F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232202, RefRangeEnd = 232203, XrefRangeStart = 232202, XrefRangeEnd = 232202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr_Activate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077CD RID: 30669 RVA: 0x0020752C File Offset: 0x0020572C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232203, XrefRangeEnd = 232223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x00207570 File Offset: 0x00205770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232223, XrefRangeEnd = 232231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeBalanceActivationZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x00038BB8 File Offset: 0x00036DB8
		public SafeBalanceActivationZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002432 RID: 9266
		// (get) Token: 0x060077D0 RID: 30672 RVA: 0x002075AC File Offset: 0x002057AC
		// (set) Token: 0x060077D1 RID: 30673 RVA: 0x00038BC1 File Offset: 0x00036DC1
		public unsafe static float ActivationDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SafeBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance, (void*)(&value));
			}
		}

		// Token: 0x17002433 RID: 9267
		// (get) Token: 0x060077D2 RID: 30674 RVA: 0x002075C8 File Offset: 0x002057C8
		// (set) Token: 0x060077D3 RID: 30675 RVA: 0x00038BCF File Offset: 0x00036DCF
		public unsafe Safe Safe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_Safe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Safe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_Safe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x060077D4 RID: 30676 RVA: 0x002075F8 File Offset: 0x002057F8
		// (set) Token: 0x060077D5 RID: 30677 RVA: 0x00038BEE File Offset: 0x00036DEE
		public unsafe List<Collider> exclude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_exclude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_exclude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x060077D6 RID: 30678 RVA: 0x00207628 File Offset: 0x00205828
		// (set) Token: 0x060077D7 RID: 30679 RVA: 0x00038C0D File Offset: 0x00036E0D
		public unsafe Il2CppReferenceArray<Collider> colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002436 RID: 9270
		// (get) Token: 0x060077D8 RID: 30680 RVA: 0x00207658 File Offset: 0x00205858
		// (set) Token: 0x060077D9 RID: 30681 RVA: 0x00038C2C File Offset: 0x00036E2C
		public unsafe bool active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x040051B7 RID: 20919
		private static readonly IntPtr NativeFieldInfoPtr_ActivationDistance;

		// Token: 0x040051B8 RID: 20920
		private static readonly IntPtr NativeFieldInfoPtr_Safe;

		// Token: 0x040051B9 RID: 20921
		private static readonly IntPtr NativeFieldInfoPtr_exclude;

		// Token: 0x040051BA RID: 20922
		private static readonly IntPtr NativeFieldInfoPtr_colliders;

		// Token: 0x040051BB RID: 20923
		private static readonly IntPtr NativeFieldInfoPtr_active;

		// Token: 0x040051BC RID: 20924
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040051BD RID: 20925
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCollider_Private_Void_0;

		// Token: 0x040051BE RID: 20926
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Private_Void_0;

		// Token: 0x040051BF RID: 20927
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x040051C0 RID: 20928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
