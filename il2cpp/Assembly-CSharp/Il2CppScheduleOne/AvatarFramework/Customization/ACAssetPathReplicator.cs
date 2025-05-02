using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200061B RID: 1563
	public class ACAssetPathReplicator<T> : ACReplicator where T : UnityEngine.Object
	{
		// Token: 0x06008A45 RID: 35397 RVA: 0x002442F0 File Offset: 0x002424F0
		// Note: this type is marked as 'beforefieldinit'.
		static ACAssetPathReplicator()
		{
			Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAssetPathReplicator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr);
			ACAssetPathReplicator<T>.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, "selection");
			ACAssetPathReplicator<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, 100680489);
			ACAssetPathReplicator<T>.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, 100680490);
			ACAssetPathReplicator<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, 100680491);
		}

		// Token: 0x06008A46 RID: 35398 RVA: 0x002443AC File Offset: 0x002425AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254414, XrefRangeEnd = 254417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAssetPathReplicator<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A47 RID: 35399 RVA: 0x002443E8 File Offset: 0x002425E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254417, XrefRangeEnd = 254422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAssetPathReplicator<T>.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A48 RID: 35400 RVA: 0x00244438 File Offset: 0x00242638
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254423, RefRangeEnd = 254426, XrefRangeStart = 254422, XrefRangeEnd = 254423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAssetPathReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAssetPathReplicator<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A49 RID: 35401 RVA: 0x000421D1 File Offset: 0x000403D1
		public ACAssetPathReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x06008A4A RID: 35402 RVA: 0x00244474 File Offset: 0x00242674
		// (set) Token: 0x06008A4B RID: 35403 RVA: 0x000421DA File Offset: 0x000403DA
		public unsafe ACSelection<T> selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACAssetPathReplicator<T>.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ACSelection<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACAssetPathReplicator<T>.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005DD8 RID: 24024
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x04005DD9 RID: 24025
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005DDA RID: 24026
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0;

		// Token: 0x04005DDB RID: 24027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
