using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200041C RID: 1052
	public class SupplierLocationConfiguration : MonoBehaviour
	{
		// Token: 0x06005C63 RID: 23651 RVA: 0x001ABAE0 File Offset: 0x001A9CE0
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierLocationConfiguration()
		{
			Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "SupplierLocationConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr);
			SupplierLocationConfiguration.NativeFieldInfoPtr_SupplierID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, "SupplierID");
			SupplierLocationConfiguration.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, 100675081);
			SupplierLocationConfiguration.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, 100675082);
			SupplierLocationConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, 100675083);
		}

		// Token: 0x06005C64 RID: 23652 RVA: 0x001ABB60 File Offset: 0x001A9D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194908, XrefRangeEnd = 194911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocationConfiguration.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C65 RID: 23653 RVA: 0x001ABB94 File Offset: 0x001A9D94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194914, RefRangeEnd = 194915, XrefRangeStart = 194911, XrefRangeEnd = 194914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocationConfiguration.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C66 RID: 23654 RVA: 0x001ABBC8 File Offset: 0x001A9DC8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierLocationConfiguration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocationConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x0002B8EB File Offset: 0x00029AEB
		public SupplierLocationConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x06005C68 RID: 23656 RVA: 0x001ABC04 File Offset: 0x001A9E04
		// (set) Token: 0x06005C69 RID: 23657 RVA: 0x0002B8F4 File Offset: 0x00029AF4
		public unsafe string SupplierID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocationConfiguration.NativeFieldInfoPtr_SupplierID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocationConfiguration.NativeFieldInfoPtr_SupplierID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003F33 RID: 16179
		private static readonly IntPtr NativeFieldInfoPtr_SupplierID;

		// Token: 0x04003F34 RID: 16180
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

		// Token: 0x04003F35 RID: 16181
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x04003F36 RID: 16182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
