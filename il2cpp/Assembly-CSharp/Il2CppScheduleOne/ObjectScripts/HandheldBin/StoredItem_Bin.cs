using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ObjectScripts.HandheldBin
{
	// Token: 0x02000760 RID: 1888
	public class StoredItem_Bin : StoredItem
	{
		// Token: 0x0600B381 RID: 45953 RVA: 0x002CC3C4 File Offset: 0x002CA5C4
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItem_Bin()
		{
			Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.HandheldBin", "StoredItem_Bin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr);
			StoredItem_Bin.NativeFieldInfoPtr_bin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr, "bin");
			StoredItem_Bin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr, 100685428);
		}

		// Token: 0x0600B382 RID: 45954 RVA: 0x002CC41C File Offset: 0x002CA61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem_Bin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem_Bin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B383 RID: 45955 RVA: 0x00057F64 File Offset: 0x00056164
		public StoredItem_Bin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x0600B384 RID: 45956 RVA: 0x002CC458 File Offset: 0x002CA658
		// (set) Token: 0x0600B385 RID: 45957 RVA: 0x00057F6D File Offset: 0x0005616D
		public unsafe HandheldBin_Functional bin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_Bin.NativeFieldInfoPtr_bin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandheldBin_Functional>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_Bin.NativeFieldInfoPtr_bin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007917 RID: 30999
		private static readonly IntPtr NativeFieldInfoPtr_bin;

		// Token: 0x04007918 RID: 31000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
