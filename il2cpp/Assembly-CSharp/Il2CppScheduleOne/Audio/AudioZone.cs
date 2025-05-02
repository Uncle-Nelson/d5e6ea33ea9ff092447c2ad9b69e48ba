using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004CE RID: 1230
	public class AudioZone : Zone
	{
		// Token: 0x06006BCA RID: 27594 RVA: 0x001DF994 File Offset: 0x001DDB94
		// Note: this type is marked as 'beforefieldinit'.
		static AudioZone()
		{
			Il2CppClassPointerStore<AudioZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioZone>.NativeClassPtr);
			AudioZone.NativeFieldInfoPtr_VOLUME_CHANGE_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "VOLUME_CHANGE_RATE");
			AudioZone.NativeFieldInfoPtr_ROLLOFF_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "ROLLOFF_SCALE");
			AudioZone.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "MaxDistance");
			AudioZone.NativeFieldInfoPtr_Tracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "Tracks");
			AudioZone.NativeFieldInfoPtr_Modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "Modifiers");
			AudioZone.NativeFieldInfoPtr__VolumeModifier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "<VolumeModifier>k__BackingField");
			AudioZone.NativeFieldInfoPtr_CurrentVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "CurrentVolumeMultiplier");
			AudioZone.NativeMethodInfoPtr_get_VolumeModifier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676920);
			AudioZone.NativeMethodInfoPtr_set_VolumeModifier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676921);
			AudioZone.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676922);
			AudioZone.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676923);
			AudioZone.NativeMethodInfoPtr_GetTotalVolumeMultiplier_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676924);
			AudioZone.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676925);
			AudioZone.NativeMethodInfoPtr_AddModifier_Public_Void_AudioZoneModifierVolume_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676926);
			AudioZone.NativeMethodInfoPtr_RemoveModifier_Public_Void_AudioZoneModifierVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676927);
			AudioZone.NativeMethodInfoPtr_GetFalloffFactor_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676928);
			AudioZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676929);
		}

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x06006BCB RID: 27595 RVA: 0x001DFB18 File Offset: 0x001DDD18
		// (set) Token: 0x06006BCC RID: 27596 RVA: 0x001DFB54 File Offset: 0x001DDD54
		public unsafe float VolumeModifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_get_VolumeModifier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_set_VolumeModifier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006BCD RID: 27597 RVA: 0x001DFB94 File Offset: 0x001DDD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216339, XrefRangeEnd = 216376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BCE RID: 27598 RVA: 0x001DFBC8 File Offset: 0x001DDDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216376, XrefRangeEnd = 216401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BCF RID: 27599 RVA: 0x001DFBFC File Offset: 0x001DDDFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216416, RefRangeEnd = 216417, XrefRangeStart = 216401, XrefRangeEnd = 216416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalVolumeMultiplier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_GetTotalVolumeMultiplier_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006BD0 RID: 27600 RVA: 0x001DFC38 File Offset: 0x001DDE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216417, XrefRangeEnd = 216442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BD1 RID: 27601 RVA: 0x001DFC6C File Offset: 0x001DDE6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216452, RefRangeEnd = 216453, XrefRangeStart = 216442, XrefRangeEnd = 216452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddModifier(AudioZoneModifierVolume modifier, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(modifier);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_AddModifier_Public_Void_AudioZoneModifierVolume_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BD2 RID: 27602 RVA: 0x001DFCBC File Offset: 0x001DDEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216453, XrefRangeEnd = 216459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveModifier(AudioZoneModifierVolume modifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(modifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_RemoveModifier_Public_Void_AudioZoneModifierVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BD3 RID: 27603 RVA: 0x001DFD00 File Offset: 0x001DDF00
		[CallerCount(0)]
		public unsafe float GetFalloffFactor(float distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_GetFalloffFactor_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006BD4 RID: 27604 RVA: 0x001DFD4C File Offset: 0x001DDF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216459, XrefRangeEnd = 216474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BD5 RID: 27605 RVA: 0x00033044 File Offset: 0x00031244
		public AudioZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x06006BD6 RID: 27606 RVA: 0x001DFD88 File Offset: 0x001DDF88
		// (set) Token: 0x06006BD7 RID: 27607 RVA: 0x0003304D File Offset: 0x0003124D
		public unsafe static float VOLUME_CHANGE_RATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioZone.NativeFieldInfoPtr_VOLUME_CHANGE_RATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioZone.NativeFieldInfoPtr_VOLUME_CHANGE_RATE, (void*)(&value));
			}
		}

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x06006BD8 RID: 27608 RVA: 0x001DFDA4 File Offset: 0x001DDFA4
		// (set) Token: 0x06006BD9 RID: 27609 RVA: 0x0003305B File Offset: 0x0003125B
		public unsafe static float ROLLOFF_SCALE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioZone.NativeFieldInfoPtr_ROLLOFF_SCALE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioZone.NativeFieldInfoPtr_ROLLOFF_SCALE, (void*)(&value));
			}
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x06006BDA RID: 27610 RVA: 0x001DFDC0 File Offset: 0x001DDFC0
		// (set) Token: 0x06006BDB RID: 27611 RVA: 0x00033069 File Offset: 0x00031269
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x06006BDC RID: 27612 RVA: 0x001DFDE8 File Offset: 0x001DDFE8
		// (set) Token: 0x06006BDD RID: 27613 RVA: 0x00033084 File Offset: 0x00031284
		public unsafe List<AudioZone.Track> Tracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_Tracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioZone.Track>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_Tracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x06006BDE RID: 27614 RVA: 0x001DFE18 File Offset: 0x001DE018
		// (set) Token: 0x06006BDF RID: 27615 RVA: 0x000330A3 File Offset: 0x000312A3
		public unsafe Dictionary<AudioZoneModifierVolume, float> Modifiers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_Modifiers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AudioZoneModifierVolume, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_Modifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x06006BE0 RID: 27616 RVA: 0x001DFE48 File Offset: 0x001DE048
		// (set) Token: 0x06006BE1 RID: 27617 RVA: 0x000330C2 File Offset: 0x000312C2
		public unsafe float _VolumeModifier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__VolumeModifier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__VolumeModifier_k__BackingField)) = value;
			}
		}

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x06006BE2 RID: 27618 RVA: 0x001DFE70 File Offset: 0x001DE070
		// (set) Token: 0x06006BE3 RID: 27619 RVA: 0x000330DD File Offset: 0x000312DD
		public unsafe float CurrentVolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_CurrentVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_CurrentVolumeMultiplier)) = value;
			}
		}

		// Token: 0x040049BE RID: 18878
		private static readonly IntPtr NativeFieldInfoPtr_VOLUME_CHANGE_RATE;

		// Token: 0x040049BF RID: 18879
		private static readonly IntPtr NativeFieldInfoPtr_ROLLOFF_SCALE;

		// Token: 0x040049C0 RID: 18880
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x040049C1 RID: 18881
		private static readonly IntPtr NativeFieldInfoPtr_Tracks;

		// Token: 0x040049C2 RID: 18882
		private static readonly IntPtr NativeFieldInfoPtr_Modifiers;

		// Token: 0x040049C3 RID: 18883
		private static readonly IntPtr NativeFieldInfoPtr__VolumeModifier_k__BackingField;

		// Token: 0x040049C4 RID: 18884
		private static readonly IntPtr NativeFieldInfoPtr_CurrentVolumeMultiplier;

		// Token: 0x040049C5 RID: 18885
		private static readonly IntPtr NativeMethodInfoPtr_get_VolumeModifier_Public_get_Single_0;

		// Token: 0x040049C6 RID: 18886
		private static readonly IntPtr NativeMethodInfoPtr_set_VolumeModifier_Public_set_Void_Single_0;

		// Token: 0x040049C7 RID: 18887
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040049C8 RID: 18888
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040049C9 RID: 18889
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalVolumeMultiplier_Private_Single_0;

		// Token: 0x040049CA RID: 18890
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040049CB RID: 18891
		private static readonly IntPtr NativeMethodInfoPtr_AddModifier_Public_Void_AudioZoneModifierVolume_Single_0;

		// Token: 0x040049CC RID: 18892
		private static readonly IntPtr NativeMethodInfoPtr_RemoveModifier_Public_Void_AudioZoneModifierVolume_0;

		// Token: 0x040049CD RID: 18893
		private static readonly IntPtr NativeMethodInfoPtr_GetFalloffFactor_Private_Single_Single_0;

		// Token: 0x040049CE RID: 18894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A5A RID: 2650
		[Serializable]
		public class Track : Object
		{
			// Token: 0x0600D079 RID: 53369 RVA: 0x0032012C File Offset: 0x0031E32C
			// Note: this type is marked as 'beforefieldinit'.
			static Track()
			{
				Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "Track");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr);
				AudioZone.Track.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "Source");
				AudioZone.Track.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "Volume");
				AudioZone.Track.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "StartTime");
				AudioZone.Track.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "EndTime");
				AudioZone.Track.NativeFieldInfoPtr_FadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "FadeTime");
				AudioZone.Track.NativeFieldInfoPtr_timeVolMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "timeVolMultiplier");
				AudioZone.Track.NativeFieldInfoPtr_fadeInStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeInStart");
				AudioZone.Track.NativeFieldInfoPtr_fadeInEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeInEnd");
				AudioZone.Track.NativeFieldInfoPtr_fadeOutStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeOutStart");
				AudioZone.Track.NativeFieldInfoPtr_fadeOutEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeOutEnd");
				AudioZone.Track.NativeFieldInfoPtr_fadeInStartMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeInStartMinSum");
				AudioZone.Track.NativeFieldInfoPtr_fadeInEndMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeInEndMinSum");
				AudioZone.Track.NativeFieldInfoPtr_fadeOutStartMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeOutStartMinSum");
				AudioZone.Track.NativeFieldInfoPtr_fadeOutEndMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeOutEndMinSum");
				AudioZone.Track.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, 100676930);
				AudioZone.Track.NativeMethodInfoPtr_Update_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, 100676931);
				AudioZone.Track.NativeMethodInfoPtr_UpdateTimeMultiplier_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, 100676932);
				AudioZone.Track.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, 100676933);
			}

			// Token: 0x0600D07A RID: 53370 RVA: 0x003202C0 File Offset: 0x0031E4C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216322, XrefRangeEnd = 216330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.Track.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D07B RID: 53371 RVA: 0x003202F4 File Offset: 0x0031E4F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216330, XrefRangeEnd = 216333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Update(float multiplier)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref multiplier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.Track.NativeMethodInfoPtr_Update_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D07C RID: 53372 RVA: 0x00320334 File Offset: 0x0031E534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216333, XrefRangeEnd = 216338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateTimeMultiplier(int time)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.Track.NativeMethodInfoPtr_UpdateTimeMultiplier_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D07D RID: 53373 RVA: 0x00320374 File Offset: 0x0031E574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216338, XrefRangeEnd = 216339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Track() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.Track.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D07E RID: 53374 RVA: 0x00065770 File Offset: 0x00063970
			public Track(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040BE RID: 16574
			// (get) Token: 0x0600D07F RID: 53375 RVA: 0x003203B0 File Offset: 0x0031E5B0
			// (set) Token: 0x0600D080 RID: 53376 RVA: 0x00065779 File Offset: 0x00063979
			public unsafe AudioSourceController Source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_Source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040BF RID: 16575
			// (get) Token: 0x0600D081 RID: 53377 RVA: 0x003203E0 File Offset: 0x0031E5E0
			// (set) Token: 0x0600D082 RID: 53378 RVA: 0x00065798 File Offset: 0x00063998
			public unsafe float Volume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_Volume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_Volume)) = value;
				}
			}

			// Token: 0x170040C0 RID: 16576
			// (get) Token: 0x0600D083 RID: 53379 RVA: 0x00320408 File Offset: 0x0031E608
			// (set) Token: 0x0600D084 RID: 53380 RVA: 0x000657B3 File Offset: 0x000639B3
			public unsafe int StartTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_StartTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_StartTime)) = value;
				}
			}

			// Token: 0x170040C1 RID: 16577
			// (get) Token: 0x0600D085 RID: 53381 RVA: 0x00320430 File Offset: 0x0031E630
			// (set) Token: 0x0600D086 RID: 53382 RVA: 0x000657CE File Offset: 0x000639CE
			public unsafe int EndTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_EndTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_EndTime)) = value;
				}
			}

			// Token: 0x170040C2 RID: 16578
			// (get) Token: 0x0600D087 RID: 53383 RVA: 0x00320458 File Offset: 0x0031E658
			// (set) Token: 0x0600D088 RID: 53384 RVA: 0x000657E9 File Offset: 0x000639E9
			public unsafe int FadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_FadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_FadeTime)) = value;
				}
			}

			// Token: 0x170040C3 RID: 16579
			// (get) Token: 0x0600D089 RID: 53385 RVA: 0x00320480 File Offset: 0x0031E680
			// (set) Token: 0x0600D08A RID: 53386 RVA: 0x00065804 File Offset: 0x00063A04
			public unsafe float timeVolMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_timeVolMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_timeVolMultiplier)) = value;
				}
			}

			// Token: 0x170040C4 RID: 16580
			// (get) Token: 0x0600D08B RID: 53387 RVA: 0x003204A8 File Offset: 0x0031E6A8
			// (set) Token: 0x0600D08C RID: 53388 RVA: 0x0006581F File Offset: 0x00063A1F
			public unsafe int fadeInStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInStart)) = value;
				}
			}

			// Token: 0x170040C5 RID: 16581
			// (get) Token: 0x0600D08D RID: 53389 RVA: 0x003204D0 File Offset: 0x0031E6D0
			// (set) Token: 0x0600D08E RID: 53390 RVA: 0x0006583A File Offset: 0x00063A3A
			public unsafe int fadeInEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInEnd)) = value;
				}
			}

			// Token: 0x170040C6 RID: 16582
			// (get) Token: 0x0600D08F RID: 53391 RVA: 0x003204F8 File Offset: 0x0031E6F8
			// (set) Token: 0x0600D090 RID: 53392 RVA: 0x00065855 File Offset: 0x00063A55
			public unsafe int fadeOutStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutStart)) = value;
				}
			}

			// Token: 0x170040C7 RID: 16583
			// (get) Token: 0x0600D091 RID: 53393 RVA: 0x00320520 File Offset: 0x0031E720
			// (set) Token: 0x0600D092 RID: 53394 RVA: 0x00065870 File Offset: 0x00063A70
			public unsafe int fadeOutEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutEnd)) = value;
				}
			}

			// Token: 0x170040C8 RID: 16584
			// (get) Token: 0x0600D093 RID: 53395 RVA: 0x00320548 File Offset: 0x0031E748
			// (set) Token: 0x0600D094 RID: 53396 RVA: 0x0006588B File Offset: 0x00063A8B
			public unsafe int fadeInStartMinSum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInStartMinSum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInStartMinSum)) = value;
				}
			}

			// Token: 0x170040C9 RID: 16585
			// (get) Token: 0x0600D095 RID: 53397 RVA: 0x00320570 File Offset: 0x0031E770
			// (set) Token: 0x0600D096 RID: 53398 RVA: 0x000658A6 File Offset: 0x00063AA6
			public unsafe int fadeInEndMinSum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInEndMinSum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInEndMinSum)) = value;
				}
			}

			// Token: 0x170040CA RID: 16586
			// (get) Token: 0x0600D097 RID: 53399 RVA: 0x00320598 File Offset: 0x0031E798
			// (set) Token: 0x0600D098 RID: 53400 RVA: 0x000658C1 File Offset: 0x00063AC1
			public unsafe int fadeOutStartMinSum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutStartMinSum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutStartMinSum)) = value;
				}
			}

			// Token: 0x170040CB RID: 16587
			// (get) Token: 0x0600D099 RID: 53401 RVA: 0x003205C0 File Offset: 0x0031E7C0
			// (set) Token: 0x0600D09A RID: 53402 RVA: 0x000658DC File Offset: 0x00063ADC
			public unsafe int fadeOutEndMinSum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutEndMinSum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutEndMinSum)) = value;
				}
			}

			// Token: 0x04008CB8 RID: 36024
			private static readonly IntPtr NativeFieldInfoPtr_Source;

			// Token: 0x04008CB9 RID: 36025
			private static readonly IntPtr NativeFieldInfoPtr_Volume;

			// Token: 0x04008CBA RID: 36026
			private static readonly IntPtr NativeFieldInfoPtr_StartTime;

			// Token: 0x04008CBB RID: 36027
			private static readonly IntPtr NativeFieldInfoPtr_EndTime;

			// Token: 0x04008CBC RID: 36028
			private static readonly IntPtr NativeFieldInfoPtr_FadeTime;

			// Token: 0x04008CBD RID: 36029
			private static readonly IntPtr NativeFieldInfoPtr_timeVolMultiplier;

			// Token: 0x04008CBE RID: 36030
			private static readonly IntPtr NativeFieldInfoPtr_fadeInStart;

			// Token: 0x04008CBF RID: 36031
			private static readonly IntPtr NativeFieldInfoPtr_fadeInEnd;

			// Token: 0x04008CC0 RID: 36032
			private static readonly IntPtr NativeFieldInfoPtr_fadeOutStart;

			// Token: 0x04008CC1 RID: 36033
			private static readonly IntPtr NativeFieldInfoPtr_fadeOutEnd;

			// Token: 0x04008CC2 RID: 36034
			private static readonly IntPtr NativeFieldInfoPtr_fadeInStartMinSum;

			// Token: 0x04008CC3 RID: 36035
			private static readonly IntPtr NativeFieldInfoPtr_fadeInEndMinSum;

			// Token: 0x04008CC4 RID: 36036
			private static readonly IntPtr NativeFieldInfoPtr_fadeOutStartMinSum;

			// Token: 0x04008CC5 RID: 36037
			private static readonly IntPtr NativeFieldInfoPtr_fadeOutEndMinSum;

			// Token: 0x04008CC6 RID: 36038
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

			// Token: 0x04008CC7 RID: 36039
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_0;

			// Token: 0x04008CC8 RID: 36040
			private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeMultiplier_Public_Void_Int32_0;

			// Token: 0x04008CC9 RID: 36041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
