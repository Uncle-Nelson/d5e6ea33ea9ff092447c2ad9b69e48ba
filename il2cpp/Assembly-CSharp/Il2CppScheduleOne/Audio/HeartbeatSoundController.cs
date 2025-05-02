using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D3 RID: 1235
	public class HeartbeatSoundController : MonoBehaviour
	{
		// Token: 0x06006C1C RID: 27676 RVA: 0x001E0860 File Offset: 0x001DEA60
		// Note: this type is marked as 'beforefieldinit'.
		static HeartbeatSoundController()
		{
			Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "HeartbeatSoundController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr);
			HeartbeatSoundController.NativeFieldInfoPtr_sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, "sound");
			HeartbeatSoundController.NativeFieldInfoPtr_VolumeController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, "VolumeController");
			HeartbeatSoundController.NativeFieldInfoPtr_PitchController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, "PitchController");
			HeartbeatSoundController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, 100676965);
			HeartbeatSoundController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, 100676966);
			HeartbeatSoundController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, 100676967);
		}

		// Token: 0x06006C1D RID: 27677 RVA: 0x001E0908 File Offset: 0x001DEB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216811, XrefRangeEnd = 216816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeartbeatSoundController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C1E RID: 27678 RVA: 0x001E093C File Offset: 0x001DEB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216816, XrefRangeEnd = 216819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeartbeatSoundController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C1F RID: 27679 RVA: 0x001E0970 File Offset: 0x001DEB70
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeartbeatSoundController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeartbeatSoundController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C20 RID: 27680 RVA: 0x000332E7 File Offset: 0x000314E7
		public HeartbeatSoundController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x06006C21 RID: 27681 RVA: 0x001E09AC File Offset: 0x001DEBAC
		// (set) Token: 0x06006C22 RID: 27682 RVA: 0x000332F0 File Offset: 0x000314F0
		public unsafe AudioSourceController sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x06006C23 RID: 27683 RVA: 0x001E09DC File Offset: 0x001DEBDC
		// (set) Token: 0x06006C24 RID: 27684 RVA: 0x0003330F File Offset: 0x0003150F
		public unsafe FloatSmoother VolumeController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_VolumeController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_VolumeController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x06006C25 RID: 27685 RVA: 0x001E0A0C File Offset: 0x001DEC0C
		// (set) Token: 0x06006C26 RID: 27686 RVA: 0x0003332E File Offset: 0x0003152E
		public unsafe FloatSmoother PitchController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_PitchController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_PitchController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049EF RID: 18927
		private static readonly IntPtr NativeFieldInfoPtr_sound;

		// Token: 0x040049F0 RID: 18928
		private static readonly IntPtr NativeFieldInfoPtr_VolumeController;

		// Token: 0x040049F1 RID: 18929
		private static readonly IntPtr NativeFieldInfoPtr_PitchController;

		// Token: 0x040049F2 RID: 18930
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040049F3 RID: 18931
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040049F4 RID: 18932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
