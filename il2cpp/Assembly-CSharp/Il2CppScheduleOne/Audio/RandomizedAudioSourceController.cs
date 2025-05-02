using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D8 RID: 1240
	public class RandomizedAudioSourceController : AudioSourceController
	{
		// Token: 0x06006C75 RID: 27765 RVA: 0x001E18B4 File Offset: 0x001DFAB4
		// Note: this type is marked as 'beforefieldinit'.
		static RandomizedAudioSourceController()
		{
			Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "RandomizedAudioSourceController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr);
			RandomizedAudioSourceController.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, "Clips");
			RandomizedAudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, 100677001);
			RandomizedAudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, 100677002);
			RandomizedAudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, 100677003);
		}

		// Token: 0x06006C76 RID: 27766 RVA: 0x001E1934 File Offset: 0x001DFB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217135, XrefRangeEnd = 217148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RandomizedAudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C77 RID: 27767 RVA: 0x001E1970 File Offset: 0x001DFB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217148, XrefRangeEnd = 217159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayOneShot(bool duplicateAudioSource = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duplicateAudioSource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RandomizedAudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C78 RID: 27768 RVA: 0x001E19BC File Offset: 0x001DFBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomizedAudioSourceController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomizedAudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C79 RID: 27769 RVA: 0x000335A1 File Offset: 0x000317A1
		public RandomizedAudioSourceController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x06006C7A RID: 27770 RVA: 0x001E19F8 File Offset: 0x001DFBF8
		// (set) Token: 0x06006C7B RID: 27771 RVA: 0x000335AA File Offset: 0x000317AA
		public unsafe Il2CppReferenceArray<AudioClip> Clips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomizedAudioSourceController.NativeFieldInfoPtr_Clips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomizedAudioSourceController.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A26 RID: 18982
		private static readonly IntPtr NativeFieldInfoPtr_Clips;

		// Token: 0x04004A27 RID: 18983
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_0;

		// Token: 0x04004A28 RID: 18984
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Virtual_Void_Boolean_0;

		// Token: 0x04004A29 RID: 18985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
