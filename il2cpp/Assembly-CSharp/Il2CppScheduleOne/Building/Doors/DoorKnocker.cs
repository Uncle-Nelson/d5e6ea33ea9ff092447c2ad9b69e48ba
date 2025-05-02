using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building.Doors
{
	// Token: 0x020004C5 RID: 1221
	public class DoorKnocker : MonoBehaviour
	{
		// Token: 0x06006AE8 RID: 27368 RVA: 0x001DD17C File Offset: 0x001DB37C
		// Note: this type is marked as 'beforefieldinit'.
		static DoorKnocker()
		{
			Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building.Doors", "DoorKnocker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr);
			DoorKnocker.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, "Anim");
			DoorKnocker.NativeFieldInfoPtr_KnockingSoundClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, "KnockingSoundClipName");
			DoorKnocker.NativeFieldInfoPtr_KnockingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, "KnockingSound");
			DoorKnocker.NativeMethodInfoPtr_Knock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, 100676848);
			DoorKnocker.NativeMethodInfoPtr_PlayKnockingSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, 100676849);
			DoorKnocker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, 100676850);
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x001DD224 File Offset: 0x001DB424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215583, XrefRangeEnd = 215587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Knock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorKnocker.NativeMethodInfoPtr_Knock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x001DD258 File Offset: 0x001DB458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215587, XrefRangeEnd = 215589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayKnockingSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorKnocker.NativeMethodInfoPtr_PlayKnockingSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AEB RID: 27371 RVA: 0x001DD28C File Offset: 0x001DB48C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorKnocker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorKnocker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AEC RID: 27372 RVA: 0x000328C9 File Offset: 0x00030AC9
		public DoorKnocker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x06006AED RID: 27373 RVA: 0x001DD2C8 File Offset: 0x001DB4C8
		// (set) Token: 0x06006AEE RID: 27374 RVA: 0x000328D2 File Offset: 0x00030AD2
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x06006AEF RID: 27375 RVA: 0x001DD2F8 File Offset: 0x001DB4F8
		// (set) Token: 0x06006AF0 RID: 27376 RVA: 0x000328F1 File Offset: 0x00030AF1
		public unsafe string KnockingSoundClipName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSoundClipName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSoundClipName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x06006AF1 RID: 27377 RVA: 0x001DD320 File Offset: 0x001DB520
		// (set) Token: 0x06006AF2 RID: 27378 RVA: 0x00032910 File Offset: 0x00030B10
		public unsafe AudioSource KnockingSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400492A RID: 18730
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x0400492B RID: 18731
		private static readonly IntPtr NativeFieldInfoPtr_KnockingSoundClipName;

		// Token: 0x0400492C RID: 18732
		private static readonly IntPtr NativeFieldInfoPtr_KnockingSound;

		// Token: 0x0400492D RID: 18733
		private static readonly IntPtr NativeMethodInfoPtr_Knock_Public_Void_0;

		// Token: 0x0400492E RID: 18734
		private static readonly IntPtr NativeMethodInfoPtr_PlayKnockingSound_Public_Void_0;

		// Token: 0x0400492F RID: 18735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
