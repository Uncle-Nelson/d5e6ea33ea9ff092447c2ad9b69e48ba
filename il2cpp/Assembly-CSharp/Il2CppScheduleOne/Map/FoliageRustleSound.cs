using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000779 RID: 1913
	public class FoliageRustleSound : MonoBehaviour
	{
		// Token: 0x0600B546 RID: 46406 RVA: 0x002D16E0 File Offset: 0x002CF8E0
		// Note: this type is marked as 'beforefieldinit'.
		static FoliageRustleSound()
		{
			Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "FoliageRustleSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr);
			FoliageRustleSound.NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "ACTIVATION_RANGE_SQUARED");
			FoliageRustleSound.NativeFieldInfoPtr_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "COOLDOWN");
			FoliageRustleSound.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "Sound");
			FoliageRustleSound.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "Container");
			FoliageRustleSound.NativeFieldInfoPtr_timeOnLastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, "timeOnLastHit");
			FoliageRustleSound.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100685592);
			FoliageRustleSound.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100685593);
			FoliageRustleSound.NativeMethodInfoPtr_UpdateActive_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100685594);
			FoliageRustleSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr, 100685595);
		}

		// Token: 0x0600B547 RID: 46407 RVA: 0x002D17C4 File Offset: 0x002CF9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310346, XrefRangeEnd = 310352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B548 RID: 46408 RVA: 0x002D17F8 File Offset: 0x002CF9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310352, XrefRangeEnd = 310377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B549 RID: 46409 RVA: 0x002D183C File Offset: 0x002CFA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310377, XrefRangeEnd = 310392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr_UpdateActive_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B54A RID: 46410 RVA: 0x002D1870 File Offset: 0x002CFA70
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FoliageRustleSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FoliageRustleSound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoliageRustleSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B54B RID: 46411 RVA: 0x00058F10 File Offset: 0x00057110
		public FoliageRustleSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003830 RID: 14384
		// (get) Token: 0x0600B54C RID: 46412 RVA: 0x002D18AC File Offset: 0x002CFAAC
		// (set) Token: 0x0600B54D RID: 46413 RVA: 0x00058F19 File Offset: 0x00057119
		public unsafe static float ACTIVATION_RANGE_SQUARED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FoliageRustleSound.NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FoliageRustleSound.NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED, (void*)(&value));
			}
		}

		// Token: 0x17003831 RID: 14385
		// (get) Token: 0x0600B54E RID: 46414 RVA: 0x002D18C8 File Offset: 0x002CFAC8
		// (set) Token: 0x0600B54F RID: 46415 RVA: 0x00058F27 File Offset: 0x00057127
		public unsafe static float COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FoliageRustleSound.NativeFieldInfoPtr_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FoliageRustleSound.NativeFieldInfoPtr_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x0600B550 RID: 46416 RVA: 0x002D18E4 File Offset: 0x002CFAE4
		// (set) Token: 0x0600B551 RID: 46417 RVA: 0x00058F35 File Offset: 0x00057135
		public unsafe AudioSourceController Sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x0600B552 RID: 46418 RVA: 0x002D1914 File Offset: 0x002CFB14
		// (set) Token: 0x0600B553 RID: 46419 RVA: 0x00058F54 File Offset: 0x00057154
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x0600B554 RID: 46420 RVA: 0x002D1944 File Offset: 0x002CFB44
		// (set) Token: 0x0600B555 RID: 46421 RVA: 0x00058F73 File Offset: 0x00057173
		public unsafe float timeOnLastHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_timeOnLastHit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoliageRustleSound.NativeFieldInfoPtr_timeOnLastHit)) = value;
			}
		}

		// Token: 0x04007A2F RID: 31279
		private static readonly IntPtr NativeFieldInfoPtr_ACTIVATION_RANGE_SQUARED;

		// Token: 0x04007A30 RID: 31280
		private static readonly IntPtr NativeFieldInfoPtr_COOLDOWN;

		// Token: 0x04007A31 RID: 31281
		private static readonly IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x04007A32 RID: 31282
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007A33 RID: 31283
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastHit;

		// Token: 0x04007A34 RID: 31284
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007A35 RID: 31285
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x04007A36 RID: 31286
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActive_Private_Void_0;

		// Token: 0x04007A37 RID: 31287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
