using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine.Audio;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004CB RID: 1227
	public class AudioManager : PersistentSingleton<AudioManager>
	{
		// Token: 0x06006B5C RID: 27484 RVA: 0x001DE46C File Offset: 0x001DC66C
		// Note: this type is marked as 'beforefieldinit'.
		static AudioManager()
		{
			Il2CppClassPointerStore<AudioManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioManager>.NativeClassPtr);
			AudioManager.NativeFieldInfoPtr_masterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "masterVolume");
			AudioManager.NativeFieldInfoPtr_ambientVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "ambientVolume");
			AudioManager.NativeFieldInfoPtr_footstepsVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "footstepsVolume");
			AudioManager.NativeFieldInfoPtr_fxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "fxVolume");
			AudioManager.NativeFieldInfoPtr_uiVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "uiVolume");
			AudioManager.NativeFieldInfoPtr_musicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "musicVolume");
			AudioManager.NativeFieldInfoPtr_voiceVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "voiceVolume");
			AudioManager.NativeFieldInfoPtr_onSettingsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "onSettingsChanged");
			AudioManager.NativeFieldInfoPtr_DoorOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "DoorOpen");
			AudioManager.NativeFieldInfoPtr_DoorClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "DoorClose");
			AudioManager.NativeFieldInfoPtr_MainGameMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MainGameMixer");
			AudioManager.NativeFieldInfoPtr_MenuMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MenuMixer");
			AudioManager.NativeFieldInfoPtr_MusicMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MusicMixer");
			AudioManager.NativeFieldInfoPtr_currentGameVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "currentGameVolume");
			AudioManager.NativeFieldInfoPtr_minGameVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "minGameVolume");
			AudioManager.NativeFieldInfoPtr_maxGameVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "maxGameVolume");
			AudioManager.NativeFieldInfoPtr_gameVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "gameVolumeMultiplier");
			AudioManager.NativeFieldInfoPtr_DefaultSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "DefaultSnapshot");
			AudioManager.NativeFieldInfoPtr_DistortedSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "DistortedSnapshot");
			AudioManager.NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676878);
			AudioManager.NativeMethodInfoPtr_get_AmbientVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676879);
			AudioManager.NativeMethodInfoPtr_get_UnscaledAmbientVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676880);
			AudioManager.NativeMethodInfoPtr_get_FootstepsVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676881);
			AudioManager.NativeMethodInfoPtr_get_UnscaledFootstepsVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676882);
			AudioManager.NativeMethodInfoPtr_get_FXVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676883);
			AudioManager.NativeMethodInfoPtr_get_UnscaledFXVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676884);
			AudioManager.NativeMethodInfoPtr_get_UIVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676885);
			AudioManager.NativeMethodInfoPtr_get_UnscaledUIVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676886);
			AudioManager.NativeMethodInfoPtr_get_MusicVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676887);
			AudioManager.NativeMethodInfoPtr_get_UnscaledMusicVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676888);
			AudioManager.NativeMethodInfoPtr_get_VoiceVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676889);
			AudioManager.NativeMethodInfoPtr_get_UnscaledVoiceVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676890);
			AudioManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676891);
			AudioManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676892);
			AudioManager.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676893);
			AudioManager.NativeMethodInfoPtr_SetGameVolumeMultipler_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676894);
			AudioManager.NativeMethodInfoPtr_SetDistorted_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676895);
			AudioManager.NativeMethodInfoPtr_SetGameVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676896);
			AudioManager.NativeMethodInfoPtr_GetVolume_Public_Single_EAudioType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676897);
			AudioManager.NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676898);
			AudioManager.NativeMethodInfoPtr_SetVolume_Public_Void_EAudioType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676899);
			AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676900);
			AudioManager.NativeMethodInfoPtr__Start_b__46_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676901);
		}

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x06006B5D RID: 27485 RVA: 0x001DE7F8 File Offset: 0x001DC9F8
		public unsafe float MasterVolume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59852, RefRangeEnd = 59853, XrefRangeStart = 59852, XrefRangeEnd = 59853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x06006B5E RID: 27486 RVA: 0x001DE834 File Offset: 0x001DCA34
		public unsafe float AmbientVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_AmbientVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x06006B5F RID: 27487 RVA: 0x001DE870 File Offset: 0x001DCA70
		public unsafe float UnscaledAmbientVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledAmbientVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x06006B60 RID: 27488 RVA: 0x001DE8AC File Offset: 0x001DCAAC
		public unsafe float FootstepsVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_FootstepsVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x06006B61 RID: 27489 RVA: 0x001DE8E8 File Offset: 0x001DCAE8
		public unsafe float UnscaledFootstepsVolume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30021, RefRangeEnd = 30022, XrefRangeStart = 30021, XrefRangeEnd = 30022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledFootstepsVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x06006B62 RID: 27490 RVA: 0x001DE924 File Offset: 0x001DCB24
		public unsafe float FXVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_FXVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x06006B63 RID: 27491 RVA: 0x001DE960 File Offset: 0x001DCB60
		public unsafe float UnscaledFXVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledFXVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x06006B64 RID: 27492 RVA: 0x001DE99C File Offset: 0x001DCB9C
		public unsafe float UIVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UIVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x06006B65 RID: 27493 RVA: 0x001DE9D8 File Offset: 0x001DCBD8
		public unsafe float UnscaledUIVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledUIVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x06006B66 RID: 27494 RVA: 0x001DEA14 File Offset: 0x001DCC14
		public unsafe float MusicVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_MusicVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x06006B67 RID: 27495 RVA: 0x001DEA50 File Offset: 0x001DCC50
		public unsafe float UnscaledMusicVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledMusicVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x06006B68 RID: 27496 RVA: 0x001DEA8C File Offset: 0x001DCC8C
		public unsafe float VoiceVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_VoiceVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x06006B69 RID: 27497 RVA: 0x001DEAC8 File Offset: 0x001DCCC8
		public unsafe float UnscaledVoiceVolume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30024, RefRangeEnd = 30025, XrefRangeStart = 30024, XrefRangeEnd = 30025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledVoiceVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x001DEB04 File Offset: 0x001DCD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215959, XrefRangeEnd = 215977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x001DEB40 File Offset: 0x001DCD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215977, XrefRangeEnd = 216004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B6C RID: 27500 RVA: 0x001DEB7C File Offset: 0x001DCD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216004, XrefRangeEnd = 216020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B6D RID: 27501 RVA: 0x001DEBB0 File Offset: 0x001DCDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216020, XrefRangeEnd = 216021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameVolumeMultipler(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetGameVolumeMultipler_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B6E RID: 27502 RVA: 0x001DEBF0 File Offset: 0x001DCDF0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 216024, RefRangeEnd = 216032, XrefRangeStart = 216021, XrefRangeEnd = 216024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDistorted(bool distorted, float transition = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref distorted;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetDistorted_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B6F RID: 27503 RVA: 0x001DEC3C File Offset: 0x001DCE3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 216038, RefRangeEnd = 216042, XrefRangeStart = 216032, XrefRangeEnd = 216038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameVolume(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetGameVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B70 RID: 27504 RVA: 0x001DEC7C File Offset: 0x001DCE7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216042, RefRangeEnd = 216043, XrefRangeStart = 216042, XrefRangeEnd = 216042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetVolume(EAudioType audioType, bool scaled = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref audioType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_GetVolume_Public_Single_EAudioType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x001DECD4 File Offset: 0x001DCED4
		[CallerCount(0)]
		public unsafe void SetMasterVolume(float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B72 RID: 27506 RVA: 0x001DED14 File Offset: 0x001DCF14
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 216043, RefRangeEnd = 216049, XrefRangeStart = 216043, XrefRangeEnd = 216043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVolume(EAudioType type, float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetVolume_Public_Void_EAudioType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x001DED60 File Offset: 0x001DCF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216049, XrefRangeEnd = 216057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x001DED9C File Offset: 0x001DCF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216057, XrefRangeEnd = 216059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__46_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr__Start_b__46_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x00032CC8 File Offset: 0x00030EC8
		public AudioManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x06006B76 RID: 27510 RVA: 0x001DEDD0 File Offset: 0x001DCFD0
		// (set) Token: 0x06006B77 RID: 27511 RVA: 0x00032CD1 File Offset: 0x00030ED1
		public unsafe float masterVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_masterVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_masterVolume)) = value;
			}
		}

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x06006B78 RID: 27512 RVA: 0x001DEDF8 File Offset: 0x001DCFF8
		// (set) Token: 0x06006B79 RID: 27513 RVA: 0x00032CEC File Offset: 0x00030EEC
		public unsafe float ambientVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_ambientVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_ambientVolume)) = value;
			}
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x06006B7A RID: 27514 RVA: 0x001DEE20 File Offset: 0x001DD020
		// (set) Token: 0x06006B7B RID: 27515 RVA: 0x00032D07 File Offset: 0x00030F07
		public unsafe float footstepsVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_footstepsVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_footstepsVolume)) = value;
			}
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x06006B7C RID: 27516 RVA: 0x001DEE48 File Offset: 0x001DD048
		// (set) Token: 0x06006B7D RID: 27517 RVA: 0x00032D22 File Offset: 0x00030F22
		public unsafe float fxVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_fxVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_fxVolume)) = value;
			}
		}

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x06006B7E RID: 27518 RVA: 0x001DEE70 File Offset: 0x001DD070
		// (set) Token: 0x06006B7F RID: 27519 RVA: 0x00032D3D File Offset: 0x00030F3D
		public unsafe float uiVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_uiVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_uiVolume)) = value;
			}
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x06006B80 RID: 27520 RVA: 0x001DEE98 File Offset: 0x001DD098
		// (set) Token: 0x06006B81 RID: 27521 RVA: 0x00032D58 File Offset: 0x00030F58
		public unsafe float musicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicVolume)) = value;
			}
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x06006B82 RID: 27522 RVA: 0x001DEEC0 File Offset: 0x001DD0C0
		// (set) Token: 0x06006B83 RID: 27523 RVA: 0x00032D73 File Offset: 0x00030F73
		public unsafe float voiceVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_voiceVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_voiceVolume)) = value;
			}
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x06006B84 RID: 27524 RVA: 0x001DEEE8 File Offset: 0x001DD0E8
		// (set) Token: 0x06006B85 RID: 27525 RVA: 0x00032D8E File Offset: 0x00030F8E
		public unsafe UnityEvent onSettingsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_onSettingsChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_onSettingsChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x06006B86 RID: 27526 RVA: 0x001DEF18 File Offset: 0x001DD118
		// (set) Token: 0x06006B87 RID: 27527 RVA: 0x00032DAD File Offset: 0x00030FAD
		public unsafe AudioSourceController DoorOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DoorOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DoorOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x06006B88 RID: 27528 RVA: 0x001DEF48 File Offset: 0x001DD148
		// (set) Token: 0x06006B89 RID: 27529 RVA: 0x00032DCC File Offset: 0x00030FCC
		public unsafe AudioSourceController DoorClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DoorClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DoorClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x06006B8A RID: 27530 RVA: 0x001DEF78 File Offset: 0x001DD178
		// (set) Token: 0x06006B8B RID: 27531 RVA: 0x00032DEB File Offset: 0x00030FEB
		public unsafe AudioMixerGroup MainGameMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MainGameMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MainGameMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x06006B8C RID: 27532 RVA: 0x001DEFA8 File Offset: 0x001DD1A8
		// (set) Token: 0x06006B8D RID: 27533 RVA: 0x00032E0A File Offset: 0x0003100A
		public unsafe AudioMixerGroup MenuMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MenuMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MenuMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x06006B8E RID: 27534 RVA: 0x001DEFD8 File Offset: 0x001DD1D8
		// (set) Token: 0x06006B8F RID: 27535 RVA: 0x00032E29 File Offset: 0x00031029
		public unsafe AudioMixerGroup MusicMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MusicMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MusicMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x06006B90 RID: 27536 RVA: 0x001DF008 File Offset: 0x001DD208
		// (set) Token: 0x06006B91 RID: 27537 RVA: 0x00032E48 File Offset: 0x00031048
		public unsafe float currentGameVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_currentGameVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_currentGameVolume)) = value;
			}
		}

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x06006B92 RID: 27538 RVA: 0x001DF030 File Offset: 0x001DD230
		// (set) Token: 0x06006B93 RID: 27539 RVA: 0x00032E63 File Offset: 0x00031063
		public unsafe static float minGameVolume
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_minGameVolume, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_minGameVolume, (void*)(&value));
			}
		}

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x06006B94 RID: 27540 RVA: 0x001DF04C File Offset: 0x001DD24C
		// (set) Token: 0x06006B95 RID: 27541 RVA: 0x00032E71 File Offset: 0x00031071
		public unsafe static float maxGameVolume
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_maxGameVolume, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_maxGameVolume, (void*)(&value));
			}
		}

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x06006B96 RID: 27542 RVA: 0x001DF068 File Offset: 0x001DD268
		// (set) Token: 0x06006B97 RID: 27543 RVA: 0x00032E7F File Offset: 0x0003107F
		public unsafe float gameVolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_gameVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_gameVolumeMultiplier)) = value;
			}
		}

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x06006B98 RID: 27544 RVA: 0x001DF090 File Offset: 0x001DD290
		// (set) Token: 0x06006B99 RID: 27545 RVA: 0x00032E9A File Offset: 0x0003109A
		public unsafe AudioMixerSnapshot DefaultSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DefaultSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DefaultSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x06006B9A RID: 27546 RVA: 0x001DF0C0 File Offset: 0x001DD2C0
		// (set) Token: 0x06006B9B RID: 27547 RVA: 0x00032EB9 File Offset: 0x000310B9
		public unsafe AudioMixerSnapshot DistortedSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DistortedSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DistortedSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400496D RID: 18797
		private static readonly IntPtr NativeFieldInfoPtr_masterVolume;

		// Token: 0x0400496E RID: 18798
		private static readonly IntPtr NativeFieldInfoPtr_ambientVolume;

		// Token: 0x0400496F RID: 18799
		private static readonly IntPtr NativeFieldInfoPtr_footstepsVolume;

		// Token: 0x04004970 RID: 18800
		private static readonly IntPtr NativeFieldInfoPtr_fxVolume;

		// Token: 0x04004971 RID: 18801
		private static readonly IntPtr NativeFieldInfoPtr_uiVolume;

		// Token: 0x04004972 RID: 18802
		private static readonly IntPtr NativeFieldInfoPtr_musicVolume;

		// Token: 0x04004973 RID: 18803
		private static readonly IntPtr NativeFieldInfoPtr_voiceVolume;

		// Token: 0x04004974 RID: 18804
		private static readonly IntPtr NativeFieldInfoPtr_onSettingsChanged;

		// Token: 0x04004975 RID: 18805
		private static readonly IntPtr NativeFieldInfoPtr_DoorOpen;

		// Token: 0x04004976 RID: 18806
		private static readonly IntPtr NativeFieldInfoPtr_DoorClose;

		// Token: 0x04004977 RID: 18807
		private static readonly IntPtr NativeFieldInfoPtr_MainGameMixer;

		// Token: 0x04004978 RID: 18808
		private static readonly IntPtr NativeFieldInfoPtr_MenuMixer;

		// Token: 0x04004979 RID: 18809
		private static readonly IntPtr NativeFieldInfoPtr_MusicMixer;

		// Token: 0x0400497A RID: 18810
		private static readonly IntPtr NativeFieldInfoPtr_currentGameVolume;

		// Token: 0x0400497B RID: 18811
		private static readonly IntPtr NativeFieldInfoPtr_minGameVolume;

		// Token: 0x0400497C RID: 18812
		private static readonly IntPtr NativeFieldInfoPtr_maxGameVolume;

		// Token: 0x0400497D RID: 18813
		private static readonly IntPtr NativeFieldInfoPtr_gameVolumeMultiplier;

		// Token: 0x0400497E RID: 18814
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSnapshot;

		// Token: 0x0400497F RID: 18815
		private static readonly IntPtr NativeFieldInfoPtr_DistortedSnapshot;

		// Token: 0x04004980 RID: 18816
		private static readonly IntPtr NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0;

		// Token: 0x04004981 RID: 18817
		private static readonly IntPtr NativeMethodInfoPtr_get_AmbientVolume_Public_get_Single_0;

		// Token: 0x04004982 RID: 18818
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledAmbientVolume_Public_get_Single_0;

		// Token: 0x04004983 RID: 18819
		private static readonly IntPtr NativeMethodInfoPtr_get_FootstepsVolume_Public_get_Single_0;

		// Token: 0x04004984 RID: 18820
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledFootstepsVolume_Public_get_Single_0;

		// Token: 0x04004985 RID: 18821
		private static readonly IntPtr NativeMethodInfoPtr_get_FXVolume_Public_get_Single_0;

		// Token: 0x04004986 RID: 18822
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledFXVolume_Public_get_Single_0;

		// Token: 0x04004987 RID: 18823
		private static readonly IntPtr NativeMethodInfoPtr_get_UIVolume_Public_get_Single_0;

		// Token: 0x04004988 RID: 18824
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledUIVolume_Public_get_Single_0;

		// Token: 0x04004989 RID: 18825
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicVolume_Public_get_Single_0;

		// Token: 0x0400498A RID: 18826
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledMusicVolume_Public_get_Single_0;

		// Token: 0x0400498B RID: 18827
		private static readonly IntPtr NativeMethodInfoPtr_get_VoiceVolume_Public_get_Single_0;

		// Token: 0x0400498C RID: 18828
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledVoiceVolume_Public_get_Single_0;

		// Token: 0x0400498D RID: 18829
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400498E RID: 18830
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400498F RID: 18831
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x04004990 RID: 18832
		private static readonly IntPtr NativeMethodInfoPtr_SetGameVolumeMultipler_Public_Void_Single_0;

		// Token: 0x04004991 RID: 18833
		private static readonly IntPtr NativeMethodInfoPtr_SetDistorted_Public_Void_Boolean_Single_0;

		// Token: 0x04004992 RID: 18834
		private static readonly IntPtr NativeMethodInfoPtr_SetGameVolume_Private_Void_Single_0;

		// Token: 0x04004993 RID: 18835
		private static readonly IntPtr NativeMethodInfoPtr_GetVolume_Public_Single_EAudioType_Boolean_0;

		// Token: 0x04004994 RID: 18836
		private static readonly IntPtr NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0;

		// Token: 0x04004995 RID: 18837
		private static readonly IntPtr NativeMethodInfoPtr_SetVolume_Public_Void_EAudioType_Single_0;

		// Token: 0x04004996 RID: 18838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004997 RID: 18839
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__46_0_Private_Void_0;
	}
}
