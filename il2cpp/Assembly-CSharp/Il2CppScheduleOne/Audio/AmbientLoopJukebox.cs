using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004C8 RID: 1224
	public class AmbientLoopJukebox : MonoBehaviour
	{
		// Token: 0x06006B1A RID: 27418 RVA: 0x001DDA60 File Offset: 0x001DBC60
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientLoopJukebox()
		{
			Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AmbientLoopJukebox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr);
			AmbientLoopJukebox.NativeFieldInfoPtr_VolumeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "VolumeCurve");
			AmbientLoopJukebox.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "Clips");
			AmbientLoopJukebox.NativeFieldInfoPtr_audioSourceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "audioSourceController");
			AmbientLoopJukebox.NativeFieldInfoPtr_currentClipIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "currentClipIndex");
			AmbientLoopJukebox.NativeFieldInfoPtr_musicScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "musicScale");
			AmbientLoopJukebox.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, 100676864);
			AmbientLoopJukebox.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, 100676865);
			AmbientLoopJukebox.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, 100676866);
			AmbientLoopJukebox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, 100676867);
		}

		// Token: 0x06006B1B RID: 27419 RVA: 0x001DDB44 File Offset: 0x001DBD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215717, XrefRangeEnd = 215745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoopJukebox.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B1C RID: 27420 RVA: 0x001DDB78 File Offset: 0x001DBD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215745, XrefRangeEnd = 215752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoopJukebox.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B1D RID: 27421 RVA: 0x001DDBAC File Offset: 0x001DBDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215752, XrefRangeEnd = 215763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoopJukebox.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B1E RID: 27422 RVA: 0x001DDBE0 File Offset: 0x001DBDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215763, XrefRangeEnd = 215771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientLoopJukebox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoopJukebox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B1F RID: 27423 RVA: 0x00032A4F File Offset: 0x00030C4F
		public AmbientLoopJukebox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x06006B20 RID: 27424 RVA: 0x001DDC1C File Offset: 0x001DBE1C
		// (set) Token: 0x06006B21 RID: 27425 RVA: 0x00032A58 File Offset: 0x00030C58
		public unsafe AnimationCurve VolumeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_VolumeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_VolumeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x06006B22 RID: 27426 RVA: 0x001DDC4C File Offset: 0x001DBE4C
		// (set) Token: 0x06006B23 RID: 27427 RVA: 0x00032A77 File Offset: 0x00030C77
		public unsafe List<AudioClip> Clips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_Clips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x06006B24 RID: 27428 RVA: 0x001DDC7C File Offset: 0x001DBE7C
		// (set) Token: 0x06006B25 RID: 27429 RVA: 0x00032A96 File Offset: 0x00030C96
		public unsafe AudioSourceController audioSourceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_audioSourceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_audioSourceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x06006B26 RID: 27430 RVA: 0x001DDCAC File Offset: 0x001DBEAC
		// (set) Token: 0x06006B27 RID: 27431 RVA: 0x00032AB5 File Offset: 0x00030CB5
		public unsafe int currentClipIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_currentClipIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_currentClipIndex)) = value;
			}
		}

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x06006B28 RID: 27432 RVA: 0x001DDCD4 File Offset: 0x001DBED4
		// (set) Token: 0x06006B29 RID: 27433 RVA: 0x00032AD0 File Offset: 0x00030CD0
		public unsafe float musicScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_musicScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_musicScale)) = value;
			}
		}

		// Token: 0x04004948 RID: 18760
		private static readonly IntPtr NativeFieldInfoPtr_VolumeCurve;

		// Token: 0x04004949 RID: 18761
		private static readonly IntPtr NativeFieldInfoPtr_Clips;

		// Token: 0x0400494A RID: 18762
		private static readonly IntPtr NativeFieldInfoPtr_audioSourceController;

		// Token: 0x0400494B RID: 18763
		private static readonly IntPtr NativeFieldInfoPtr_currentClipIndex;

		// Token: 0x0400494C RID: 18764
		private static readonly IntPtr NativeFieldInfoPtr_musicScale;

		// Token: 0x0400494D RID: 18765
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400494E RID: 18766
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400494F RID: 18767
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04004950 RID: 18768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
