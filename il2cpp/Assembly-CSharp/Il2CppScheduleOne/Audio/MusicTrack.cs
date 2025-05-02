using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D7 RID: 1239
	public class MusicTrack : MonoBehaviour
	{
		// Token: 0x06006C55 RID: 27733 RVA: 0x001E1318 File Offset: 0x001DF518
		// Note: this type is marked as 'beforefieldinit'.
		static MusicTrack()
		{
			Il2CppClassPointerStore<MusicTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "MusicTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr);
			MusicTrack.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "<IsPlaying>k__BackingField");
			MusicTrack.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "Enabled");
			MusicTrack.NativeFieldInfoPtr_TrackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "TrackName");
			MusicTrack.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "Priority");
			MusicTrack.NativeFieldInfoPtr_FadeInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "FadeInTime");
			MusicTrack.NativeFieldInfoPtr_FadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "FadeOutTime");
			MusicTrack.NativeFieldInfoPtr_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "Controller");
			MusicTrack.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "VolumeMultiplier");
			MusicTrack.NativeFieldInfoPtr_AutoFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "AutoFadeOut");
			MusicTrack.NativeFieldInfoPtr_volumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "volumeMultiplier");
			MusicTrack.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676991);
			MusicTrack.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676992);
			MusicTrack.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676993);
			MusicTrack.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676994);
			MusicTrack.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676995);
			MusicTrack.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676996);
			MusicTrack.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676997);
			MusicTrack.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676998);
			MusicTrack.NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676999);
			MusicTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100677000);
		}

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x06006C56 RID: 27734 RVA: 0x001E14D8 File Offset: 0x001DF6D8
		// (set) Token: 0x06006C57 RID: 27735 RVA: 0x001E1514 File Offset: 0x001DF714
		public unsafe bool IsPlaying
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x001E1554 File Offset: 0x001DF754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217108, XrefRangeEnd = 217117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x001E1588 File Offset: 0x001DF788
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 217117, RefRangeEnd = 217121, XrefRangeStart = 217117, XrefRangeEnd = 217117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x001E15BC File Offset: 0x001DF7BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217121, RefRangeEnd = 217123, XrefRangeStart = 217121, XrefRangeEnd = 217121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C5B RID: 27739 RVA: 0x001E15F0 File Offset: 0x001DF7F0
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x001E162C File Offset: 0x001DF82C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217128, RefRangeEnd = 217129, XrefRangeStart = 217123, XrefRangeEnd = 217128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x001E1668 File Offset: 0x001DF868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217129, XrefRangeEnd = 217130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C5E RID: 27742 RVA: 0x001E16A4 File Offset: 0x001DF8A4
		[CallerCount(0)]
		public unsafe virtual void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x001E16E0 File Offset: 0x001DF8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217130, XrefRangeEnd = 217135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicTrack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C60 RID: 27744 RVA: 0x00033482 File Offset: 0x00031682
		public MusicTrack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x06006C61 RID: 27745 RVA: 0x001E171C File Offset: 0x001DF91C
		// (set) Token: 0x06006C62 RID: 27746 RVA: 0x0003348B File Offset: 0x0003168B
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x06006C63 RID: 27747 RVA: 0x001E1744 File Offset: 0x001DF944
		// (set) Token: 0x06006C64 RID: 27748 RVA: 0x000334A6 File Offset: 0x000316A6
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x06006C65 RID: 27749 RVA: 0x001E176C File Offset: 0x001DF96C
		// (set) Token: 0x06006C66 RID: 27750 RVA: 0x000334C1 File Offset: 0x000316C1
		public unsafe string TrackName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_TrackName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_TrackName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x06006C67 RID: 27751 RVA: 0x001E1794 File Offset: 0x001DF994
		// (set) Token: 0x06006C68 RID: 27752 RVA: 0x000334E0 File Offset: 0x000316E0
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x06006C69 RID: 27753 RVA: 0x001E17BC File Offset: 0x001DF9BC
		// (set) Token: 0x06006C6A RID: 27754 RVA: 0x000334FB File Offset: 0x000316FB
		public unsafe float FadeInTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_FadeInTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_FadeInTime)) = value;
			}
		}

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x06006C6B RID: 27755 RVA: 0x001E17E4 File Offset: 0x001DF9E4
		// (set) Token: 0x06006C6C RID: 27756 RVA: 0x00033516 File Offset: 0x00031716
		public unsafe float FadeOutTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_FadeOutTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_FadeOutTime)) = value;
			}
		}

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x06006C6D RID: 27757 RVA: 0x001E180C File Offset: 0x001DFA0C
		// (set) Token: 0x06006C6E RID: 27758 RVA: 0x00033531 File Offset: 0x00031731
		public unsafe AudioSourceController Controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x06006C6F RID: 27759 RVA: 0x001E183C File Offset: 0x001DFA3C
		// (set) Token: 0x06006C70 RID: 27760 RVA: 0x00033550 File Offset: 0x00031750
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x06006C71 RID: 27761 RVA: 0x001E1864 File Offset: 0x001DFA64
		// (set) Token: 0x06006C72 RID: 27762 RVA: 0x0003356B File Offset: 0x0003176B
		public unsafe bool AutoFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_AutoFadeOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_AutoFadeOut)) = value;
			}
		}

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x06006C73 RID: 27763 RVA: 0x001E188C File Offset: 0x001DFA8C
		// (set) Token: 0x06006C74 RID: 27764 RVA: 0x00033586 File Offset: 0x00031786
		public unsafe float volumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_volumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_volumeMultiplier)) = value;
			}
		}

		// Token: 0x04004A12 RID: 18962
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x04004A13 RID: 18963
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04004A14 RID: 18964
		private static readonly IntPtr NativeFieldInfoPtr_TrackName;

		// Token: 0x04004A15 RID: 18965
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04004A16 RID: 18966
		private static readonly IntPtr NativeFieldInfoPtr_FadeInTime;

		// Token: 0x04004A17 RID: 18967
		private static readonly IntPtr NativeFieldInfoPtr_FadeOutTime;

		// Token: 0x04004A18 RID: 18968
		private static readonly IntPtr NativeFieldInfoPtr_Controller;

		// Token: 0x04004A19 RID: 18969
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x04004A1A RID: 18970
		private static readonly IntPtr NativeFieldInfoPtr_AutoFadeOut;

		// Token: 0x04004A1B RID: 18971
		private static readonly IntPtr NativeFieldInfoPtr_volumeMultiplier;

		// Token: 0x04004A1C RID: 18972
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04004A1D RID: 18973
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0;

		// Token: 0x04004A1E RID: 18974
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04004A1F RID: 18975
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

		// Token: 0x04004A20 RID: 18976
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x04004A21 RID: 18977
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004A22 RID: 18978
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x04004A23 RID: 18979
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0;

		// Token: 0x04004A24 RID: 18980
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0;

		// Token: 0x04004A25 RID: 18981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
