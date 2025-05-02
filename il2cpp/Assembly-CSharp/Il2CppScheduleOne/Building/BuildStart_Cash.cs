using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004B5 RID: 1205
	public class BuildStart_Cash : BuildStart_StoredItem
	{
		// Token: 0x060069FF RID: 27135 RVA: 0x001DA34C File Offset: 0x001D854C
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStart_Cash()
		{
			Il2CppClassPointerStore<BuildStart_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStart_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStart_Cash>.NativeClassPtr);
			BuildStart_Cash.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Cash>.NativeClassPtr, 100676757);
			BuildStart_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Cash>.NativeClassPtr, 100676758);
		}

		// Token: 0x06006A00 RID: 27136 RVA: 0x001DA3A4 File Offset: 0x001D85A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213567, XrefRangeEnd = 213601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartBuilding(ItemInstance itemInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_Cash.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x001DA3F4 File Offset: 0x001D85F4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStart_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStart_Cash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x000321A8 File Offset: 0x000303A8
		public BuildStart_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004899 RID: 18585
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x0400489A RID: 18586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
