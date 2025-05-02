using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Audio;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D5 RID: 1237
	public class MusicPlayer : PersistentSingleton<MusicPlayer>
	{
		// Token: 0x06006C37 RID: 27703 RVA: 0x001E0CD0 File Offset: 0x001DEED0
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayer()
		{
			Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "MusicPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr);
			MusicPlayer.NativeFieldInfoPtr_TimeSinceLastAmbientTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "TimeSinceLastAmbientTrack");
			MusicPlayer.NativeFieldInfoPtr_Tracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "Tracks");
			MusicPlayer.NativeFieldInfoPtr_MusicMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "MusicMixer");
			MusicPlayer.NativeFieldInfoPtr_DefaultSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "DefaultSnapshot");
			MusicPlayer.NativeFieldInfoPtr_DistortedSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "DistortedSnapshot");
			MusicPlayer.NativeFieldInfoPtr__currentTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "_currentTrack");
			MusicPlayer.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676972);
			MusicPlayer.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676973);
			MusicPlayer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676974);
			MusicPlayer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676975);
			MusicPlayer.NativeMethodInfoPtr_SetMusicDistorted_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676976);
			MusicPlayer.NativeMethodInfoPtr_SetTrackEnabled_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676977);
			MusicPlayer.NativeMethodInfoPtr_StopTrack_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676978);
			MusicPlayer.NativeMethodInfoPtr_StopAndDisableTracks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676979);
			MusicPlayer.NativeMethodInfoPtr_UpdateTracks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676980);
			MusicPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676981);
			MusicPlayer.NativeMethodInfoPtr__Start_b__9_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676983);
		}

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x06006C38 RID: 27704 RVA: 0x001E0E54 File Offset: 0x001DF054
		public unsafe bool IsPlaying
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 216890, RefRangeEnd = 216892, XrefRangeStart = 216886, XrefRangeEnd = 216890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006C39 RID: 27705 RVA: 0x001E0E90 File Offset: 0x001DF090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216892, XrefRangeEnd = 216913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C3A RID: 27706 RVA: 0x001E0EC4 File Offset: 0x001DF0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216913, XrefRangeEnd = 216944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicPlayer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C3B RID: 27707 RVA: 0x001E0F00 File Offset: 0x001DF100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216944, XrefRangeEnd = 216950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C3C RID: 27708 RVA: 0x001E0F34 File Offset: 0x001DF134
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 216953, RefRangeEnd = 216961, XrefRangeStart = 216950, XrefRangeEnd = 216953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMusicDistorted(bool distorted, float transition = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref distorted;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_SetMusicDistorted_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C3D RID: 27709 RVA: 0x001E0F80 File Offset: 0x001DF180
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 216981, RefRangeEnd = 216987, XrefRangeStart = 216961, XrefRangeEnd = 216981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrackEnabled(string trackName, bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_SetTrackEnabled_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C3E RID: 27710 RVA: 0x001E0FD0 File Offset: 0x001DF1D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217013, RefRangeEnd = 217014, XrefRangeStart = 216987, XrefRangeEnd = 217013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTrack(string trackName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_StopTrack_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C3F RID: 27711 RVA: 0x001E1014 File Offset: 0x001DF214
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217028, RefRangeEnd = 217030, XrefRangeStart = 217014, XrefRangeEnd = 217028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAndDisableTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_StopAndDisableTracks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C40 RID: 27712 RVA: 0x001E1048 File Offset: 0x001DF248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217030, XrefRangeEnd = 217066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_UpdateTracks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C41 RID: 27713 RVA: 0x001E107C File Offset: 0x001DF27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217066, XrefRangeEnd = 217076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicPlayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C42 RID: 27714 RVA: 0x001E10B8 File Offset: 0x001DF2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217076, XrefRangeEnd = 217078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__9_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr__Start_b__9_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C43 RID: 27715 RVA: 0x000333C7 File Offset: 0x000315C7
		public MusicPlayer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x06006C44 RID: 27716 RVA: 0x001E10EC File Offset: 0x001DF2EC
		// (set) Token: 0x06006C45 RID: 27717 RVA: 0x000333D0 File Offset: 0x000315D0
		public unsafe static float TimeSinceLastAmbientTrack
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayer.NativeFieldInfoPtr_TimeSinceLastAmbientTrack, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayer.NativeFieldInfoPtr_TimeSinceLastAmbientTrack, (void*)(&value));
			}
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x06006C46 RID: 27718 RVA: 0x001E1108 File Offset: 0x001DF308
		// (set) Token: 0x06006C47 RID: 27719 RVA: 0x000333DE File Offset: 0x000315DE
		public unsafe List<MusicTrack> Tracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_Tracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MusicTrack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_Tracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x06006C48 RID: 27720 RVA: 0x001E1138 File Offset: 0x001DF338
		// (set) Token: 0x06006C49 RID: 27721 RVA: 0x000333FD File Offset: 0x000315FD
		public unsafe AudioMixerGroup MusicMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_MusicMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_MusicMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x06006C4A RID: 27722 RVA: 0x001E1168 File Offset: 0x001DF368
		// (set) Token: 0x06006C4B RID: 27723 RVA: 0x0003341C File Offset: 0x0003161C
		public unsafe AudioMixerSnapshot DefaultSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_DefaultSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_DefaultSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x06006C4C RID: 27724 RVA: 0x001E1198 File Offset: 0x001DF398
		// (set) Token: 0x06006C4D RID: 27725 RVA: 0x0003343B File Offset: 0x0003163B
		public unsafe AudioMixerSnapshot DistortedSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_DistortedSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_DistortedSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x06006C4E RID: 27726 RVA: 0x001E11C8 File Offset: 0x001DF3C8
		// (set) Token: 0x06006C4F RID: 27727 RVA: 0x0003345A File Offset: 0x0003165A
		public unsafe MusicTrack _currentTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr__currentTrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicTrack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr__currentTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049FE RID: 18942
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceLastAmbientTrack;

		// Token: 0x040049FF RID: 18943
		private static readonly IntPtr NativeFieldInfoPtr_Tracks;

		// Token: 0x04004A00 RID: 18944
		private static readonly IntPtr NativeFieldInfoPtr_MusicMixer;

		// Token: 0x04004A01 RID: 18945
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSnapshot;

		// Token: 0x04004A02 RID: 18946
		private static readonly IntPtr NativeFieldInfoPtr_DistortedSnapshot;

		// Token: 0x04004A03 RID: 18947
		private static readonly IntPtr NativeFieldInfoPtr__currentTrack;

		// Token: 0x04004A04 RID: 18948
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04004A05 RID: 18949
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x04004A06 RID: 18950
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004A07 RID: 18951
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004A08 RID: 18952
		private static readonly IntPtr NativeMethodInfoPtr_SetMusicDistorted_Public_Void_Boolean_Single_0;

		// Token: 0x04004A09 RID: 18953
		private static readonly IntPtr NativeMethodInfoPtr_SetTrackEnabled_Public_Void_String_Boolean_0;

		// Token: 0x04004A0A RID: 18954
		private static readonly IntPtr NativeMethodInfoPtr_StopTrack_Public_Void_String_0;

		// Token: 0x04004A0B RID: 18955
		private static readonly IntPtr NativeMethodInfoPtr_StopAndDisableTracks_Public_Void_0;

		// Token: 0x04004A0C RID: 18956
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTracks_Private_Void_0;

		// Token: 0x04004A0D RID: 18957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004A0E RID: 18958
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__9_0_Private_Void_0;

		// Token: 0x02000A60 RID: 2656
		[ObfuscatedName("ScheduleOne.Audio.MusicPlayer+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600D0BE RID: 53438 RVA: 0x00320B60 File Offset: 0x0031ED60
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr);
				MusicPlayer.__c__DisplayClass12_0.NativeFieldInfoPtr_trackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr, "trackName");
				MusicPlayer.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr, 100676984);
				MusicPlayer.__c__DisplayClass12_0.NativeMethodInfoPtr__SetTrackEnabled_b__0_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr, 100676985);
			}

			// Token: 0x0600D0BF RID: 53439 RVA: 0x00320BC8 File Offset: 0x0031EDC8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0C0 RID: 53440 RVA: 0x00320C04 File Offset: 0x0031EE04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetTrackEnabled_b__0(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.__c__DisplayClass12_0.NativeMethodInfoPtr__SetTrackEnabled_b__0_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0C1 RID: 53441 RVA: 0x00065A2B File Offset: 0x00063C2B
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D6 RID: 16598
			// (get) Token: 0x0600D0C2 RID: 53442 RVA: 0x00320C54 File Offset: 0x0031EE54
			// (set) Token: 0x0600D0C3 RID: 53443 RVA: 0x00065A34 File Offset: 0x00063C34
			public unsafe string trackName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.__c__DisplayClass12_0.NativeFieldInfoPtr_trackName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.__c__DisplayClass12_0.NativeFieldInfoPtr_trackName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008CE6 RID: 36070
			private static readonly IntPtr NativeFieldInfoPtr_trackName;

			// Token: 0x04008CE7 RID: 36071
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CE8 RID: 36072
			private static readonly IntPtr NativeMethodInfoPtr__SetTrackEnabled_b__0_Internal_Boolean_MusicTrack_0;
		}

		// Token: 0x02000A61 RID: 2657
		[ObfuscatedName("ScheduleOne.Audio.MusicPlayer+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600D0C4 RID: 53444 RVA: 0x00320C7C File Offset: 0x0031EE7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr);
				MusicPlayer.__c__DisplayClass13_0.NativeFieldInfoPtr_trackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr, "trackName");
				MusicPlayer.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr, 100676986);
				MusicPlayer.__c__DisplayClass13_0.NativeMethodInfoPtr__StopTrack_b__0_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr, 100676987);
			}

			// Token: 0x0600D0C5 RID: 53445 RVA: 0x00320CE4 File Offset: 0x0031EEE4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0C6 RID: 53446 RVA: 0x00320D20 File Offset: 0x0031EF20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StopTrack_b__0(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.__c__DisplayClass13_0.NativeMethodInfoPtr__StopTrack_b__0_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0C7 RID: 53447 RVA: 0x00065A53 File Offset: 0x00063C53
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D7 RID: 16599
			// (get) Token: 0x0600D0C8 RID: 53448 RVA: 0x00320D70 File Offset: 0x0031EF70
			// (set) Token: 0x0600D0C9 RID: 53449 RVA: 0x00065A5C File Offset: 0x00063C5C
			public unsafe string trackName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.__c__DisplayClass13_0.NativeFieldInfoPtr_trackName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.__c__DisplayClass13_0.NativeFieldInfoPtr_trackName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008CE9 RID: 36073
			private static readonly IntPtr NativeFieldInfoPtr_trackName;

			// Token: 0x04008CEA RID: 36074
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CEB RID: 36075
			private static readonly IntPtr NativeMethodInfoPtr__StopTrack_b__0_Internal_Boolean_MusicTrack_0;
		}
	}
}
