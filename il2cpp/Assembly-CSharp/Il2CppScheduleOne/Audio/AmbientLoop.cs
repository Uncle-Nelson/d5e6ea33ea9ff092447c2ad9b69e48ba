using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004C7 RID: 1223
	public class AmbientLoop : MonoBehaviour
	{
		// Token: 0x06006B09 RID: 27401 RVA: 0x001DD7F0 File Offset: 0x001DB9F0
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientLoop()
		{
			Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AmbientLoop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr);
			AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "MUSIC_FADE_MULTIPLIER");
			AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "MUSIC_FADE_TIME");
			AmbientLoop.NativeFieldInfoPtr_VolumeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "VolumeCurve");
			AmbientLoop.NativeFieldInfoPtr_FadeDuringMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "FadeDuringMusic");
			AmbientLoop.NativeFieldInfoPtr_audioSourceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "audioSourceController");
			AmbientLoop.NativeFieldInfoPtr_musicScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "musicScale");
			AmbientLoop.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, 100676861);
			AmbientLoop.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, 100676862);
			AmbientLoop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, 100676863);
		}

		// Token: 0x06006B0A RID: 27402 RVA: 0x001DD8D4 File Offset: 0x001DBAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215695, XrefRangeEnd = 215700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoop.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x001DD908 File Offset: 0x001DBB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215700, XrefRangeEnd = 215716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoop.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B0C RID: 27404 RVA: 0x001DD93C File Offset: 0x001DBB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215716, XrefRangeEnd = 215717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientLoop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B0D RID: 27405 RVA: 0x000329B6 File Offset: 0x00030BB6
		public AmbientLoop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x06006B0E RID: 27406 RVA: 0x001DD978 File Offset: 0x001DBB78
		// (set) Token: 0x06006B0F RID: 27407 RVA: 0x000329BF File Offset: 0x00030BBF
		public unsafe static float MUSIC_FADE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x06006B10 RID: 27408 RVA: 0x001DD994 File Offset: 0x001DBB94
		// (set) Token: 0x06006B11 RID: 27409 RVA: 0x000329CD File Offset: 0x00030BCD
		public unsafe static float MUSIC_FADE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x06006B12 RID: 27410 RVA: 0x001DD9B0 File Offset: 0x001DBBB0
		// (set) Token: 0x06006B13 RID: 27411 RVA: 0x000329DB File Offset: 0x00030BDB
		public unsafe AnimationCurve VolumeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_VolumeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_VolumeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x06006B14 RID: 27412 RVA: 0x001DD9E0 File Offset: 0x001DBBE0
		// (set) Token: 0x06006B15 RID: 27413 RVA: 0x000329FA File Offset: 0x00030BFA
		public unsafe bool FadeDuringMusic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_FadeDuringMusic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_FadeDuringMusic)) = value;
			}
		}

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x06006B16 RID: 27414 RVA: 0x001DDA08 File Offset: 0x001DBC08
		// (set) Token: 0x06006B17 RID: 27415 RVA: 0x00032A15 File Offset: 0x00030C15
		public unsafe AudioSourceController audioSourceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_audioSourceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_audioSourceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x06006B18 RID: 27416 RVA: 0x001DDA38 File Offset: 0x001DBC38
		// (set) Token: 0x06006B19 RID: 27417 RVA: 0x00032A34 File Offset: 0x00030C34
		public unsafe float musicScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_musicScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_musicScale)) = value;
			}
		}

		// Token: 0x0400493F RID: 18751
		private static readonly IntPtr NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER;

		// Token: 0x04004940 RID: 18752
		private static readonly IntPtr NativeFieldInfoPtr_MUSIC_FADE_TIME;

		// Token: 0x04004941 RID: 18753
		private static readonly IntPtr NativeFieldInfoPtr_VolumeCurve;

		// Token: 0x04004942 RID: 18754
		private static readonly IntPtr NativeFieldInfoPtr_FadeDuringMusic;

		// Token: 0x04004943 RID: 18755
		private static readonly IntPtr NativeFieldInfoPtr_audioSourceController;

		// Token: 0x04004944 RID: 18756
		private static readonly IntPtr NativeFieldInfoPtr_musicScale;

		// Token: 0x04004945 RID: 18757
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004946 RID: 18758
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004947 RID: 18759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
