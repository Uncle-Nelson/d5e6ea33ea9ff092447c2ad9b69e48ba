using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000037 RID: 55
	public class FlockChildSound : MonoBehaviour
	{
		// Token: 0x06000428 RID: 1064 RVA: 0x0007CEC4 File Offset: 0x0007B0C4
		// Note: this type is marked as 'beforefieldinit'.
		static FlockChildSound()
		{
			Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlockChildSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr);
			FlockChildSound.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "controller");
			FlockChildSound.NativeFieldInfoPtr__idleSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_idleSounds");
			FlockChildSound.NativeFieldInfoPtr__idleSoundRandomChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_idleSoundRandomChance");
			FlockChildSound.NativeFieldInfoPtr__flightSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_flightSounds");
			FlockChildSound.NativeFieldInfoPtr__flightSoundRandomChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_flightSoundRandomChance");
			FlockChildSound.NativeFieldInfoPtr__scareSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_scareSounds");
			FlockChildSound.NativeFieldInfoPtr__pitchMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_pitchMin");
			FlockChildSound.NativeFieldInfoPtr__pitchMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_pitchMax");
			FlockChildSound.NativeFieldInfoPtr__volumeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_volumeMin");
			FlockChildSound.NativeFieldInfoPtr__volumeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_volumeMax");
			FlockChildSound.NativeFieldInfoPtr__flockChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_flockChild");
			FlockChildSound.NativeFieldInfoPtr__audio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_audio");
			FlockChildSound.NativeFieldInfoPtr__hasLanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_hasLanded");
			FlockChildSound.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, 100663673);
			FlockChildSound.NativeMethodInfoPtr_PlayRandomSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, 100663674);
			FlockChildSound.NativeMethodInfoPtr_ScareSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, 100663675);
			FlockChildSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, 100663676);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0007D048 File Offset: 0x0007B248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74103, XrefRangeEnd = 74118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChildSound.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0007D07C File Offset: 0x0007B27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74118, XrefRangeEnd = 74128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayRandomSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChildSound.NativeMethodInfoPtr_PlayRandomSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0007D0B0 File Offset: 0x0007B2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74128, XrefRangeEnd = 74137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScareSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChildSound.NativeMethodInfoPtr_ScareSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0007D0E4 File Offset: 0x0007B2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74137, XrefRangeEnd = 74138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlockChildSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChildSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00004656 File Offset: 0x00002856
		public FlockChildSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0007D120 File Offset: 0x0007B320
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0000465F File Offset: 0x0000285F
		public unsafe AudioSourceController controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr_controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0007D150 File Offset: 0x0007B350
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x0000467E File Offset: 0x0000287E
		public unsafe Il2CppReferenceArray<AudioClip> _idleSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__idleSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__idleSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0007D180 File Offset: 0x0007B380
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x0000469D File Offset: 0x0000289D
		public unsafe float _idleSoundRandomChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__idleSoundRandomChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__idleSoundRandomChance)) = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0007D1A8 File Offset: 0x0007B3A8
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x000046B8 File Offset: 0x000028B8
		public unsafe Il2CppReferenceArray<AudioClip> _flightSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flightSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flightSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0007D1D8 File Offset: 0x0007B3D8
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x000046D7 File Offset: 0x000028D7
		public unsafe float _flightSoundRandomChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flightSoundRandomChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flightSoundRandomChance)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0007D200 File Offset: 0x0007B400
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x000046F2 File Offset: 0x000028F2
		public unsafe Il2CppReferenceArray<AudioClip> _scareSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__scareSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__scareSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0007D230 File Offset: 0x0007B430
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00004711 File Offset: 0x00002911
		public unsafe float _pitchMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__pitchMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__pitchMin)) = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0007D258 File Offset: 0x0007B458
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x0000472C File Offset: 0x0000292C
		public unsafe float _pitchMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__pitchMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__pitchMax)) = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0007D280 File Offset: 0x0007B480
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00004747 File Offset: 0x00002947
		public unsafe float _volumeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__volumeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__volumeMin)) = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0007D2A8 File Offset: 0x0007B4A8
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00004762 File Offset: 0x00002962
		public unsafe float _volumeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__volumeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__volumeMax)) = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0007D2D0 File Offset: 0x0007B4D0
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x0000477D File Offset: 0x0000297D
		public unsafe FlockChild _flockChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flockChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockChild>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flockChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0007D300 File Offset: 0x0007B500
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x0000479C File Offset: 0x0000299C
		public unsafe AudioSource _audio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__audio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__audio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0007D330 File Offset: 0x0007B530
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x000047BB File Offset: 0x000029BB
		public unsafe bool _hasLanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__hasLanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__hasLanded)) = value;
			}
		}

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeFieldInfoPtr_controller;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeFieldInfoPtr__idleSounds;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeFieldInfoPtr__idleSoundRandomChance;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr__flightSounds;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr__flightSoundRandomChance;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeFieldInfoPtr__scareSounds;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr__pitchMin;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr__pitchMax;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr__volumeMin;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr__volumeMax;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr__flockChild;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr__audio;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr__hasLanded;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_PlayRandomSound_Public_Void_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_ScareSound_Public_Void_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
