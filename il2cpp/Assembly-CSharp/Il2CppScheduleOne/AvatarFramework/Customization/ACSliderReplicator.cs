using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000620 RID: 1568
	public class ACSliderReplicator : ACReplicator
	{
		// Token: 0x06008A5F RID: 35423 RVA: 0x002447AC File Offset: 0x002429AC
		// Note: this type is marked as 'beforefieldinit'.
		static ACSliderReplicator()
		{
			Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACSliderReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr);
			ACSliderReplicator.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr, "slider");
			ACSliderReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr, 100680499);
			ACSliderReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr, 100680500);
		}

		// Token: 0x06008A60 RID: 35424 RVA: 0x00244818 File Offset: 0x00242A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254468, XrefRangeEnd = 254474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSliderReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A61 RID: 35425 RVA: 0x00244868 File Offset: 0x00242A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254438, RefRangeEnd = 254439, XrefRangeStart = 254438, XrefRangeEnd = 254439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACSliderReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSliderReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A62 RID: 35426 RVA: 0x000422CD File Offset: 0x000404CD
		public ACSliderReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A28 RID: 10792
		// (get) Token: 0x06008A63 RID: 35427 RVA: 0x002448A4 File Offset: 0x00242AA4
		// (set) Token: 0x06008A64 RID: 35428 RVA: 0x000422D6 File Offset: 0x000404D6
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSliderReplicator.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSliderReplicator.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005DE5 RID: 24037
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04005DE6 RID: 24038
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0;

		// Token: 0x04005DE7 RID: 24039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
