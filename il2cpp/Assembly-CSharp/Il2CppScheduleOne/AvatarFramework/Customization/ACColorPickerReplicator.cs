using System;
using Il2CppHSVPicker;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200061D RID: 1565
	public class ACColorPickerReplicator : ACReplicator
	{
		// Token: 0x06008A4F RID: 35407 RVA: 0x002444E0 File Offset: 0x002426E0
		// Note: this type is marked as 'beforefieldinit'.
		static ACColorPickerReplicator()
		{
			Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACColorPickerReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr);
			ACColorPickerReplicator.NativeFieldInfoPtr_picker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr, "picker");
			ACColorPickerReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr, 100680493);
			ACColorPickerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr, 100680494);
		}

		// Token: 0x06008A50 RID: 35408 RVA: 0x0024454C File Offset: 0x0024274C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254429, XrefRangeEnd = 254434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACColorPickerReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A51 RID: 35409 RVA: 0x0024459C File Offset: 0x0024279C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254438, RefRangeEnd = 254439, XrefRangeStart = 254434, XrefRangeEnd = 254438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACColorPickerReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACColorPickerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A52 RID: 35410 RVA: 0x0004223B File Offset: 0x0004043B
		public ACColorPickerReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A26 RID: 10790
		// (get) Token: 0x06008A53 RID: 35411 RVA: 0x002445D8 File Offset: 0x002427D8
		// (set) Token: 0x06008A54 RID: 35412 RVA: 0x00042244 File Offset: 0x00040444
		public unsafe ColorPicker picker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACColorPickerReplicator.NativeFieldInfoPtr_picker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorPicker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACColorPickerReplicator.NativeFieldInfoPtr_picker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005DDD RID: 24029
		private static readonly IntPtr NativeFieldInfoPtr_picker;

		// Token: 0x04005DDE RID: 24030
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0;

		// Token: 0x04005DDF RID: 24031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
