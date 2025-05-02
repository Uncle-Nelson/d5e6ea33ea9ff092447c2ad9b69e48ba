using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004CF RID: 1231
	public class AudioZoneModifierVolume : MonoBehaviour
	{
		// Token: 0x06006BE4 RID: 27620 RVA: 0x001DFE98 File Offset: 0x001DE098
		// Note: this type is marked as 'beforefieldinit'.
		static AudioZoneModifierVolume()
		{
			Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioZoneModifierVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr);
			AudioZoneModifierVolume.NativeFieldInfoPtr_Zones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, "Zones");
			AudioZoneModifierVolume.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, "VolumeMultiplier");
			AudioZoneModifierVolume.NativeFieldInfoPtr_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, "colliders");
			AudioZoneModifierVolume.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, 100676934);
			AudioZoneModifierVolume.NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, 100676935);
			AudioZoneModifierVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, 100676936);
		}

		// Token: 0x06006BE5 RID: 27621 RVA: 0x001DFF40 File Offset: 0x001DE140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216474, XrefRangeEnd = 216486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BE6 RID: 27622 RVA: 0x001DFF74 File Offset: 0x001DE174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216486, XrefRangeEnd = 216530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BE7 RID: 27623 RVA: 0x001DFFA8 File Offset: 0x001DE1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216530, XrefRangeEnd = 216538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioZoneModifierVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BE8 RID: 27624 RVA: 0x000330F8 File Offset: 0x000312F8
		public AudioZoneModifierVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x06006BE9 RID: 27625 RVA: 0x001DFFE4 File Offset: 0x001DE1E4
		// (set) Token: 0x06006BEA RID: 27626 RVA: 0x00033101 File Offset: 0x00031301
		public unsafe List<AudioZone> Zones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_Zones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioZone>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_Zones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x06006BEB RID: 27627 RVA: 0x001E0014 File Offset: 0x001DE214
		// (set) Token: 0x06006BEC RID: 27628 RVA: 0x00033120 File Offset: 0x00031320
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x06006BED RID: 27629 RVA: 0x001E003C File Offset: 0x001DE23C
		// (set) Token: 0x06006BEE RID: 27630 RVA: 0x0003313B File Offset: 0x0003133B
		public unsafe Il2CppReferenceArray<BoxCollider> colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoxCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049CF RID: 18895
		private static readonly IntPtr NativeFieldInfoPtr_Zones;

		// Token: 0x040049D0 RID: 18896
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x040049D1 RID: 18897
		private static readonly IntPtr NativeFieldInfoPtr_colliders;

		// Token: 0x040049D2 RID: 18898
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040049D3 RID: 18899
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;

		// Token: 0x040049D4 RID: 18900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
