using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D6 RID: 1238
	public class MusicPlayerUtility : MonoBehaviour
	{
		// Token: 0x06006C50 RID: 27728 RVA: 0x001E11F8 File Offset: 0x001DF3F8
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerUtility()
		{
			Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "MusicPlayerUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr);
			MusicPlayerUtility.NativeMethodInfoPtr_PlayTrack_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr, 100676988);
			MusicPlayerUtility.NativeMethodInfoPtr_StopTracks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr, 100676989);
			MusicPlayerUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr, 100676990);
		}

		// Token: 0x06006C51 RID: 27729 RVA: 0x001E1264 File Offset: 0x001DF464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217078, XrefRangeEnd = 217102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayTrack(string trackName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerUtility.NativeMethodInfoPtr_PlayTrack_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C52 RID: 27730 RVA: 0x001E12A8 File Offset: 0x001DF4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217102, XrefRangeEnd = 217108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerUtility.NativeMethodInfoPtr_StopTracks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x001E12DC File Offset: 0x001DF4DC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicPlayerUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x00033479 File Offset: 0x00031679
		public MusicPlayerUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004A0F RID: 18959
		private static readonly IntPtr NativeMethodInfoPtr_PlayTrack_Public_Void_String_0;

		// Token: 0x04004A10 RID: 18960
		private static readonly IntPtr NativeMethodInfoPtr_StopTracks_Public_Void_0;

		// Token: 0x04004A11 RID: 18961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
