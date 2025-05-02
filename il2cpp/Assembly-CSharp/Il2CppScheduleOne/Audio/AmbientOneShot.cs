using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004C9 RID: 1225
	public class AmbientOneShot : MonoBehaviour
	{
		// Token: 0x06006B2A RID: 27434 RVA: 0x001DDCFC File Offset: 0x001DBEFC
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientOneShot()
		{
			Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AmbientOneShot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr);
			AmbientOneShot.NativeFieldInfoPtr_Audio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "Audio");
			AmbientOneShot.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "Volume");
			AmbientOneShot.NativeFieldInfoPtr_ChancePerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "ChancePerHour");
			AmbientOneShot.NativeFieldInfoPtr_CooldownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "CooldownTime");
			AmbientOneShot.NativeFieldInfoPtr_PlayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "PlayTime");
			AmbientOneShot.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "MinDistance");
			AmbientOneShot.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "MaxDistance");
			AmbientOneShot.NativeFieldInfoPtr_timeSinceLastPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "timeSinceLastPlay");
			AmbientOneShot.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676868);
			AmbientOneShot.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676869);
			AmbientOneShot.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676870);
			AmbientOneShot.NativeMethodInfoPtr_Play_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676871);
			AmbientOneShot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676872);
		}

		// Token: 0x06006B2B RID: 27435 RVA: 0x001DDE30 File Offset: 0x001DC030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215771, XrefRangeEnd = 215789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B2C RID: 27436 RVA: 0x001DDE64 File Offset: 0x001DC064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215789, XrefRangeEnd = 215797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B2D RID: 27437 RVA: 0x001DDE98 File Offset: 0x001DC098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215797, XrefRangeEnd = 215821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B2E RID: 27438 RVA: 0x001DDECC File Offset: 0x001DC0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215821, XrefRangeEnd = 215823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_Play_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B2F RID: 27439 RVA: 0x001DDF00 File Offset: 0x001DC100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215823, XrefRangeEnd = 215824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientOneShot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B30 RID: 27440 RVA: 0x00032AEB File Offset: 0x00030CEB
		public AmbientOneShot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x06006B31 RID: 27441 RVA: 0x001DDF3C File Offset: 0x001DC13C
		// (set) Token: 0x06006B32 RID: 27442 RVA: 0x00032AF4 File Offset: 0x00030CF4
		public unsafe AudioSourceController Audio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_Audio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_Audio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x06006B33 RID: 27443 RVA: 0x001DDF6C File Offset: 0x001DC16C
		// (set) Token: 0x06006B34 RID: 27444 RVA: 0x00032B13 File Offset: 0x00030D13
		public unsafe float Volume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_Volume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_Volume)) = value;
			}
		}

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x06006B35 RID: 27445 RVA: 0x001DDF94 File Offset: 0x001DC194
		// (set) Token: 0x06006B36 RID: 27446 RVA: 0x00032B2E File Offset: 0x00030D2E
		public unsafe float ChancePerHour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_ChancePerHour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_ChancePerHour)) = value;
			}
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x06006B37 RID: 27447 RVA: 0x001DDFBC File Offset: 0x001DC1BC
		// (set) Token: 0x06006B38 RID: 27448 RVA: 0x00032B49 File Offset: 0x00030D49
		public unsafe int CooldownTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_CooldownTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_CooldownTime)) = value;
			}
		}

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x06006B39 RID: 27449 RVA: 0x001DDFE4 File Offset: 0x001DC1E4
		// (set) Token: 0x06006B3A RID: 27450 RVA: 0x00032B64 File Offset: 0x00030D64
		public unsafe AmbientOneShot.EPlayTime PlayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_PlayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_PlayTime)) = value;
			}
		}

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x06006B3B RID: 27451 RVA: 0x001DE00C File Offset: 0x001DC20C
		// (set) Token: 0x06006B3C RID: 27452 RVA: 0x00032B7F File Offset: 0x00030D7F
		public unsafe float MinDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_MinDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_MinDistance)) = value;
			}
		}

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x06006B3D RID: 27453 RVA: 0x001DE034 File Offset: 0x001DC234
		// (set) Token: 0x06006B3E RID: 27454 RVA: 0x00032B9A File Offset: 0x00030D9A
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x06006B3F RID: 27455 RVA: 0x001DE05C File Offset: 0x001DC25C
		// (set) Token: 0x06006B40 RID: 27456 RVA: 0x00032BB5 File Offset: 0x00030DB5
		public unsafe int timeSinceLastPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_timeSinceLastPlay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_timeSinceLastPlay)) = value;
			}
		}

		// Token: 0x04004951 RID: 18769
		private static readonly IntPtr NativeFieldInfoPtr_Audio;

		// Token: 0x04004952 RID: 18770
		private static readonly IntPtr NativeFieldInfoPtr_Volume;

		// Token: 0x04004953 RID: 18771
		private static readonly IntPtr NativeFieldInfoPtr_ChancePerHour;

		// Token: 0x04004954 RID: 18772
		private static readonly IntPtr NativeFieldInfoPtr_CooldownTime;

		// Token: 0x04004955 RID: 18773
		private static readonly IntPtr NativeFieldInfoPtr_PlayTime;

		// Token: 0x04004956 RID: 18774
		private static readonly IntPtr NativeFieldInfoPtr_MinDistance;

		// Token: 0x04004957 RID: 18775
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x04004958 RID: 18776
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastPlay;

		// Token: 0x04004959 RID: 18777
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400495A RID: 18778
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x0400495B RID: 18779
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400495C RID: 18780
		private static readonly IntPtr NativeMethodInfoPtr_Play_Private_Void_0;

		// Token: 0x0400495D RID: 18781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A59 RID: 2649
		[OriginalName("Assembly-CSharp.dll", "", "EPlayTime")]
		public enum EPlayTime
		{
			// Token: 0x04008CB5 RID: 36021
			All,
			// Token: 0x04008CB6 RID: 36022
			Day,
			// Token: 0x04008CB7 RID: 36023
			Night
		}
	}
}
