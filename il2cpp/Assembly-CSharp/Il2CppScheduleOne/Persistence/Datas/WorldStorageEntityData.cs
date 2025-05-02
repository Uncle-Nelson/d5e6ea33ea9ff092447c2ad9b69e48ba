using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002C0 RID: 704
	[Serializable]
	public class WorldStorageEntityData : SaveData
	{
		// Token: 0x0600321D RID: 12829 RVA: 0x0010F3F0 File Offset: 0x0010D5F0
		// Note: this type is marked as 'beforefieldinit'.
		static WorldStorageEntityData()
		{
			Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WorldStorageEntityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr);
			WorldStorageEntityData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr, "GUID");
			WorldStorageEntityData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr, "Contents");
			WorldStorageEntityData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr, 100668864);
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x0010F45C File Offset: 0x0010D65C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131344, RefRangeEnd = 131345, XrefRangeStart = 131340, XrefRangeEnd = 131344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldStorageEntityData(Guid guid, ItemSet contents) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntityData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x0001AE12 File Offset: 0x00019012
		public WorldStorageEntityData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06003220 RID: 12832 RVA: 0x0010F4B8 File Offset: 0x0010D6B8
		// (set) Token: 0x06003221 RID: 12833 RVA: 0x0001AE1B File Offset: 0x0001901B
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06003222 RID: 12834 RVA: 0x0010F4E0 File Offset: 0x0010D6E0
		// (set) Token: 0x06003223 RID: 12835 RVA: 0x0001AE3A File Offset: 0x0001903A
		public unsafe ItemSet Contents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_Contents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_Contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002078 RID: 8312
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002079 RID: 8313
		private static readonly IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x0400207A RID: 8314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemSet_0;
	}
}
