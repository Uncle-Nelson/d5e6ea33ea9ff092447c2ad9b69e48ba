using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004CC RID: 1228
	public class AudioSourceController : MonoBehaviour
	{
		// Token: 0x06006B9C RID: 27548 RVA: 0x001DF0F0 File Offset: 0x001DD2F0
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSourceController()
		{
			Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioSourceController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr);
			AudioSourceController.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "DEBUG");
			AudioSourceController.NativeFieldInfoPtr__Volume_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "<Volume>k__BackingField");
			AudioSourceController.NativeFieldInfoPtr_AudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "AudioSource");
			AudioSourceController.NativeFieldInfoPtr_AudioType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "AudioType");
			AudioSourceController.NativeFieldInfoPtr_DefaultVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "DefaultVolume");
			AudioSourceController.NativeFieldInfoPtr_RandomizePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "RandomizePitch");
			AudioSourceController.NativeFieldInfoPtr_MinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "MinPitch");
			AudioSourceController.NativeFieldInfoPtr_MaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "MaxPitch");
			AudioSourceController.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "VolumeMultiplier");
			AudioSourceController.NativeFieldInfoPtr_PitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "PitchMultiplier");
			AudioSourceController.NativeFieldInfoPtr_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "paused");
			AudioSourceController.NativeFieldInfoPtr_isPlayingCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "isPlayingCached");
			AudioSourceController.NativeFieldInfoPtr_basePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "basePitch");
			AudioSourceController.NativeMethodInfoPtr_get_Volume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676902);
			AudioSourceController.NativeMethodInfoPtr_set_Volume_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676903);
			AudioSourceController.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676904);
			AudioSourceController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676905);
			AudioSourceController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676906);
			AudioSourceController.NativeMethodInfoPtr_DoPauseStuff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676907);
			AudioSourceController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676908);
			AudioSourceController.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676909);
			AudioSourceController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676910);
			AudioSourceController.NativeMethodInfoPtr_Pause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676911);
			AudioSourceController.NativeMethodInfoPtr_Unpause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676912);
			AudioSourceController.NativeMethodInfoPtr_SetVolume_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676913);
			AudioSourceController.NativeMethodInfoPtr_ApplyVolume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676914);
			AudioSourceController.NativeMethodInfoPtr_ApplyPitch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676915);
			AudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676916);
			AudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676917);
			AudioSourceController.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676918);
			AudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676919);
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x06006B9D RID: 27549 RVA: 0x001DF38C File Offset: 0x001DD58C
		// (set) Token: 0x06006B9E RID: 27550 RVA: 0x001DF3C8 File Offset: 0x001DD5C8
		public unsafe float Volume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_get_Volume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29977, RefRangeEnd = 29988, XrefRangeStart = 29977, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_set_Volume_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x06006B9F RID: 27551 RVA: 0x001DF408 File Offset: 0x001DD608
		public unsafe bool isPlaying
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 216061, RefRangeEnd = 216088, XrefRangeStart = 216059, XrefRangeEnd = 216061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006BA0 RID: 27552 RVA: 0x001DF444 File Offset: 0x001DD644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216088, XrefRangeEnd = 216092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BA1 RID: 27553 RVA: 0x001DF478 File Offset: 0x001DD678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216092, XrefRangeEnd = 216110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x001DF4AC File Offset: 0x001DD6AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216149, RefRangeEnd = 216150, XrefRangeStart = 216110, XrefRangeEnd = 216149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoPauseStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_DoPauseStuff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BA3 RID: 27555 RVA: 0x001DF4E0 File Offset: 0x001DD6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216150, XrefRangeEnd = 216168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BA4 RID: 27556 RVA: 0x001DF514 File Offset: 0x001DD714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216168, XrefRangeEnd = 216176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BA5 RID: 27557 RVA: 0x001DF548 File Offset: 0x001DD748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216176, XrefRangeEnd = 216178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x001DF57C File Offset: 0x001DD77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216178, XrefRangeEnd = 216180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Pause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x001DF5B0 File Offset: 0x001DD7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216180, XrefRangeEnd = 216182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unpause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Unpause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x001DF5E4 File Offset: 0x001DD7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216182, XrefRangeEnd = 216183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVolume(float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_SetVolume_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BA9 RID: 27561 RVA: 0x001DF624 File Offset: 0x001DD824
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 216226, RefRangeEnd = 216238, XrefRangeStart = 216183, XrefRangeEnd = 216226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_ApplyVolume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BAA RID: 27562 RVA: 0x001DF658 File Offset: 0x001DD858
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 216242, RefRangeEnd = 216247, XrefRangeStart = 216238, XrefRangeEnd = 216242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPitch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_ApplyPitch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BAB RID: 27563 RVA: 0x001DF68C File Offset: 0x001DD88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216247, XrefRangeEnd = 216251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BAC RID: 27564 RVA: 0x001DF6C8 File Offset: 0x001DD8C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216285, RefRangeEnd = 216286, XrefRangeStart = 216251, XrefRangeEnd = 216285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayOneShot(bool duplicateAudioSource = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duplicateAudioSource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BAD RID: 27565 RVA: 0x001DF714 File Offset: 0x001DD914
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 216288, RefRangeEnd = 216321, XrefRangeStart = 216286, XrefRangeEnd = 216288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BAE RID: 27566 RVA: 0x001DF748 File Offset: 0x001DD948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216321, XrefRangeEnd = 216322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSourceController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BAF RID: 27567 RVA: 0x00032ED8 File Offset: 0x000310D8
		public AudioSourceController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x06006BB0 RID: 27568 RVA: 0x001DF784 File Offset: 0x001DD984
		// (set) Token: 0x06006BB1 RID: 27569 RVA: 0x00032EE1 File Offset: 0x000310E1
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x06006BB2 RID: 27570 RVA: 0x001DF7AC File Offset: 0x001DD9AC
		// (set) Token: 0x06006BB3 RID: 27571 RVA: 0x00032EFC File Offset: 0x000310FC
		public unsafe float _Volume_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__Volume_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__Volume_k__BackingField)) = value;
			}
		}

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x06006BB4 RID: 27572 RVA: 0x001DF7D4 File Offset: 0x001DD9D4
		// (set) Token: 0x06006BB5 RID: 27573 RVA: 0x00032F17 File Offset: 0x00031117
		public unsafe AudioSource AudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_AudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_AudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x06006BB6 RID: 27574 RVA: 0x001DF804 File Offset: 0x001DDA04
		// (set) Token: 0x06006BB7 RID: 27575 RVA: 0x00032F36 File Offset: 0x00031136
		public unsafe EAudioType AudioType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_AudioType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_AudioType)) = value;
			}
		}

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x06006BB8 RID: 27576 RVA: 0x001DF82C File Offset: 0x001DDA2C
		// (set) Token: 0x06006BB9 RID: 27577 RVA: 0x00032F51 File Offset: 0x00031151
		public unsafe float DefaultVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_DefaultVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_DefaultVolume)) = value;
			}
		}

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x06006BBA RID: 27578 RVA: 0x001DF854 File Offset: 0x001DDA54
		// (set) Token: 0x06006BBB RID: 27579 RVA: 0x00032F6C File Offset: 0x0003116C
		public unsafe bool RandomizePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_RandomizePitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_RandomizePitch)) = value;
			}
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x06006BBC RID: 27580 RVA: 0x001DF87C File Offset: 0x001DDA7C
		// (set) Token: 0x06006BBD RID: 27581 RVA: 0x00032F87 File Offset: 0x00031187
		public unsafe float MinPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_MinPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_MinPitch)) = value;
			}
		}

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x06006BBE RID: 27582 RVA: 0x001DF8A4 File Offset: 0x001DDAA4
		// (set) Token: 0x06006BBF RID: 27583 RVA: 0x00032FA2 File Offset: 0x000311A2
		public unsafe float MaxPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_MaxPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_MaxPitch)) = value;
			}
		}

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x06006BC0 RID: 27584 RVA: 0x001DF8CC File Offset: 0x001DDACC
		// (set) Token: 0x06006BC1 RID: 27585 RVA: 0x00032FBD File Offset: 0x000311BD
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x06006BC2 RID: 27586 RVA: 0x001DF8F4 File Offset: 0x001DDAF4
		// (set) Token: 0x06006BC3 RID: 27587 RVA: 0x00032FD8 File Offset: 0x000311D8
		public unsafe float PitchMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_PitchMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_PitchMultiplier)) = value;
			}
		}

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x06006BC4 RID: 27588 RVA: 0x001DF91C File Offset: 0x001DDB1C
		// (set) Token: 0x06006BC5 RID: 27589 RVA: 0x00032FF3 File Offset: 0x000311F3
		public unsafe bool paused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_paused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_paused)) = value;
			}
		}

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x06006BC6 RID: 27590 RVA: 0x001DF944 File Offset: 0x001DDB44
		// (set) Token: 0x06006BC7 RID: 27591 RVA: 0x0003300E File Offset: 0x0003120E
		public unsafe bool isPlayingCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_isPlayingCached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_isPlayingCached)) = value;
			}
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x06006BC8 RID: 27592 RVA: 0x001DF96C File Offset: 0x001DDB6C
		// (set) Token: 0x06006BC9 RID: 27593 RVA: 0x00033029 File Offset: 0x00031229
		public unsafe float basePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_basePitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_basePitch)) = value;
			}
		}

		// Token: 0x04004998 RID: 18840
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04004999 RID: 18841
		private static readonly IntPtr NativeFieldInfoPtr__Volume_k__BackingField;

		// Token: 0x0400499A RID: 18842
		private static readonly IntPtr NativeFieldInfoPtr_AudioSource;

		// Token: 0x0400499B RID: 18843
		private static readonly IntPtr NativeFieldInfoPtr_AudioType;

		// Token: 0x0400499C RID: 18844
		private static readonly IntPtr NativeFieldInfoPtr_DefaultVolume;

		// Token: 0x0400499D RID: 18845
		private static readonly IntPtr NativeFieldInfoPtr_RandomizePitch;

		// Token: 0x0400499E RID: 18846
		private static readonly IntPtr NativeFieldInfoPtr_MinPitch;

		// Token: 0x0400499F RID: 18847
		private static readonly IntPtr NativeFieldInfoPtr_MaxPitch;

		// Token: 0x040049A0 RID: 18848
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x040049A1 RID: 18849
		private static readonly IntPtr NativeFieldInfoPtr_PitchMultiplier;

		// Token: 0x040049A2 RID: 18850
		private static readonly IntPtr NativeFieldInfoPtr_paused;

		// Token: 0x040049A3 RID: 18851
		private static readonly IntPtr NativeFieldInfoPtr_isPlayingCached;

		// Token: 0x040049A4 RID: 18852
		private static readonly IntPtr NativeFieldInfoPtr_basePitch;

		// Token: 0x040049A5 RID: 18853
		private static readonly IntPtr NativeMethodInfoPtr_get_Volume_Public_get_Single_0;

		// Token: 0x040049A6 RID: 18854
		private static readonly IntPtr NativeMethodInfoPtr_set_Volume_Protected_set_Void_Single_0;

		// Token: 0x040049A7 RID: 18855
		private static readonly IntPtr NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0;

		// Token: 0x040049A8 RID: 18856
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040049A9 RID: 18857
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040049AA RID: 18858
		private static readonly IntPtr NativeMethodInfoPtr_DoPauseStuff_Private_Void_0;

		// Token: 0x040049AB RID: 18859
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040049AC RID: 18860
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040049AD RID: 18861
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040049AE RID: 18862
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Private_Void_0;

		// Token: 0x040049AF RID: 18863
		private static readonly IntPtr NativeMethodInfoPtr_Unpause_Private_Void_0;

		// Token: 0x040049B0 RID: 18864
		private static readonly IntPtr NativeMethodInfoPtr_SetVolume_Public_Void_Single_0;

		// Token: 0x040049B1 RID: 18865
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVolume_Public_Void_0;

		// Token: 0x040049B2 RID: 18866
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPitch_Public_Void_0;

		// Token: 0x040049B3 RID: 18867
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0;

		// Token: 0x040049B4 RID: 18868
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040049B5 RID: 18869
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x040049B6 RID: 18870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
