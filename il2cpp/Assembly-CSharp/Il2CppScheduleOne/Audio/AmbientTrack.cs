using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004CA RID: 1226
	public class AmbientTrack : MonoBehaviour
	{
		// Token: 0x06006B41 RID: 27457 RVA: 0x001DE084 File Offset: 0x001DC284
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientTrack()
		{
			Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AmbientTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr);
			AmbientTrack.NativeFieldInfoPtr_MIN_TIME_BETWEEN_AMBIENT_TRACKS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "MIN_TIME_BETWEEN_AMBIENT_TRACKS");
			AmbientTrack.NativeFieldInfoPtr_LastPlayedTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "LastPlayedTrack");
			AmbientTrack.NativeFieldInfoPtr_TrackQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "TrackQueued");
			AmbientTrack.NativeFieldInfoPtr_Tracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "Tracks");
			AmbientTrack.NativeFieldInfoPtr_MinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "MinTime");
			AmbientTrack.NativeFieldInfoPtr_MaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "MaxTime");
			AmbientTrack.NativeFieldInfoPtr_Chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "Chance");
			AmbientTrack.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "startTime");
			AmbientTrack.NativeFieldInfoPtr_playTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "playTrack");
			AmbientTrack.NativeFieldInfoPtr_trackRandomized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "trackRandomized");
			AmbientTrack.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100676873);
			AmbientTrack.NativeMethodInfoPtr_ForcePlay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100676874);
			AmbientTrack.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100676875);
			AmbientTrack.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100676876);
			AmbientTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100676877);
		}

		// Token: 0x06006B42 RID: 27458 RVA: 0x001DE1E0 File Offset: 0x001DC3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215824, XrefRangeEnd = 215837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x001DE214 File Offset: 0x001DC414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215861, RefRangeEnd = 215862, XrefRangeStart = 215837, XrefRangeEnd = 215861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForcePlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr_ForcePlay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B44 RID: 27460 RVA: 0x001DE248 File Offset: 0x001DC448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215862, XrefRangeEnd = 215868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B45 RID: 27461 RVA: 0x001DE27C File Offset: 0x001DC47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215868, XrefRangeEnd = 215951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B46 RID: 27462 RVA: 0x001DE2B0 File Offset: 0x001DC4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215951, XrefRangeEnd = 215959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientTrack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B47 RID: 27463 RVA: 0x00032BD0 File Offset: 0x00030DD0
		public AmbientTrack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x06006B48 RID: 27464 RVA: 0x001DE2EC File Offset: 0x001DC4EC
		// (set) Token: 0x06006B49 RID: 27465 RVA: 0x00032BD9 File Offset: 0x00030DD9
		public unsafe static float MIN_TIME_BETWEEN_AMBIENT_TRACKS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AmbientTrack.NativeFieldInfoPtr_MIN_TIME_BETWEEN_AMBIENT_TRACKS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientTrack.NativeFieldInfoPtr_MIN_TIME_BETWEEN_AMBIENT_TRACKS, (void*)(&value));
			}
		}

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x06006B4A RID: 27466 RVA: 0x001DE308 File Offset: 0x001DC508
		// (set) Token: 0x06006B4B RID: 27467 RVA: 0x00032BE7 File Offset: 0x00030DE7
		public unsafe static AmbientTrack LastPlayedTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AmbientTrack.NativeFieldInfoPtr_LastPlayedTrack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmbientTrack>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientTrack.NativeFieldInfoPtr_LastPlayedTrack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x06006B4C RID: 27468 RVA: 0x001DE330 File Offset: 0x001DC530
		// (set) Token: 0x06006B4D RID: 27469 RVA: 0x00032BF9 File Offset: 0x00030DF9
		public unsafe static bool TrackQueued
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(AmbientTrack.NativeFieldInfoPtr_TrackQueued, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientTrack.NativeFieldInfoPtr_TrackQueued, (void*)(&value));
			}
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x06006B4E RID: 27470 RVA: 0x001DE34C File Offset: 0x001DC54C
		// (set) Token: 0x06006B4F RID: 27471 RVA: 0x00032C07 File Offset: 0x00030E07
		public unsafe List<MusicTrack> Tracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_Tracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MusicTrack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_Tracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x06006B50 RID: 27472 RVA: 0x001DE37C File Offset: 0x001DC57C
		// (set) Token: 0x06006B51 RID: 27473 RVA: 0x00032C26 File Offset: 0x00030E26
		public unsafe int MinTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_MinTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_MinTime)) = value;
			}
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x06006B52 RID: 27474 RVA: 0x001DE3A4 File Offset: 0x001DC5A4
		// (set) Token: 0x06006B53 RID: 27475 RVA: 0x00032C41 File Offset: 0x00030E41
		public unsafe int MaxTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_MaxTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_MaxTime)) = value;
			}
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x06006B54 RID: 27476 RVA: 0x001DE3CC File Offset: 0x001DC5CC
		// (set) Token: 0x06006B55 RID: 27477 RVA: 0x00032C5C File Offset: 0x00030E5C
		public unsafe float Chance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_Chance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_Chance)) = value;
			}
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x06006B56 RID: 27478 RVA: 0x001DE3F4 File Offset: 0x001DC5F4
		// (set) Token: 0x06006B57 RID: 27479 RVA: 0x00032C77 File Offset: 0x00030E77
		public unsafe int startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x06006B58 RID: 27480 RVA: 0x001DE41C File Offset: 0x001DC61C
		// (set) Token: 0x06006B59 RID: 27481 RVA: 0x00032C92 File Offset: 0x00030E92
		public unsafe bool playTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_playTrack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_playTrack)) = value;
			}
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x06006B5A RID: 27482 RVA: 0x001DE444 File Offset: 0x001DC644
		// (set) Token: 0x06006B5B RID: 27483 RVA: 0x00032CAD File Offset: 0x00030EAD
		public unsafe bool trackRandomized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_trackRandomized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_trackRandomized)) = value;
			}
		}

		// Token: 0x0400495E RID: 18782
		private static readonly IntPtr NativeFieldInfoPtr_MIN_TIME_BETWEEN_AMBIENT_TRACKS;

		// Token: 0x0400495F RID: 18783
		private static readonly IntPtr NativeFieldInfoPtr_LastPlayedTrack;

		// Token: 0x04004960 RID: 18784
		private static readonly IntPtr NativeFieldInfoPtr_TrackQueued;

		// Token: 0x04004961 RID: 18785
		private static readonly IntPtr NativeFieldInfoPtr_Tracks;

		// Token: 0x04004962 RID: 18786
		private static readonly IntPtr NativeFieldInfoPtr_MinTime;

		// Token: 0x04004963 RID: 18787
		private static readonly IntPtr NativeFieldInfoPtr_MaxTime;

		// Token: 0x04004964 RID: 18788
		private static readonly IntPtr NativeFieldInfoPtr_Chance;

		// Token: 0x04004965 RID: 18789
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x04004966 RID: 18790
		private static readonly IntPtr NativeFieldInfoPtr_playTrack;

		// Token: 0x04004967 RID: 18791
		private static readonly IntPtr NativeFieldInfoPtr_trackRandomized;

		// Token: 0x04004968 RID: 18792
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004969 RID: 18793
		private static readonly IntPtr NativeMethodInfoPtr_ForcePlay_Public_Void_0;

		// Token: 0x0400496A RID: 18794
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x0400496B RID: 18795
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400496C RID: 18796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
