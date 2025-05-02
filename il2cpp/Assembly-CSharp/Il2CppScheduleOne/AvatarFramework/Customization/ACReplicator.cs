using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200061F RID: 1567
	public class ACReplicator : MonoBehaviour
	{
		// Token: 0x06008A58 RID: 35416 RVA: 0x00244644 File Offset: 0x00242844
		// Note: this type is marked as 'beforefieldinit'.
		static ACReplicator()
		{
			Il2CppClassPointerStore<ACReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr);
			ACReplicator.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, "propertyName");
			ACReplicator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, 100680496);
			ACReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_New_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, 100680497);
			ACReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, 100680498);
		}

		// Token: 0x06008A59 RID: 35417 RVA: 0x002446C4 File Offset: 0x002428C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254442, XrefRangeEnd = 254468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACReplicator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A5A RID: 35418 RVA: 0x002446F8 File Offset: 0x002428F8
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_New_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A5B RID: 35419 RVA: 0x00244748 File Offset: 0x00242948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254438, RefRangeEnd = 254439, XrefRangeStart = 254438, XrefRangeEnd = 254439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A5C RID: 35420 RVA: 0x000422A5 File Offset: 0x000404A5
		public ACReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A27 RID: 10791
		// (get) Token: 0x06008A5D RID: 35421 RVA: 0x00244784 File Offset: 0x00242984
		// (set) Token: 0x06008A5E RID: 35422 RVA: 0x000422AE File Offset: 0x000404AE
		public unsafe string propertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACReplicator.NativeFieldInfoPtr_propertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACReplicator.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04005DE1 RID: 24033
		private static readonly IntPtr NativeFieldInfoPtr_propertyName;

		// Token: 0x04005DE2 RID: 24034
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005DE3 RID: 24035
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_New_Void_AvatarSettings_0;

		// Token: 0x04005DE4 RID: 24036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
