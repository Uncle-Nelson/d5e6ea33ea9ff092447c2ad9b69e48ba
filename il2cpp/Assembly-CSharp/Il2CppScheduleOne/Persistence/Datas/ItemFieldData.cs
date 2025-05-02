using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000279 RID: 633
	[Serializable]
	public class ItemFieldData : Object
	{
		// Token: 0x06002FA7 RID: 12199 RVA: 0x00108448 File Offset: 0x00106648
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFieldData()
		{
			Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ItemFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr);
			ItemFieldData.NativeFieldInfoPtr_ItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr, "ItemID");
			ItemFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr, 100668784);
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x001084A0 File Offset: 0x001066A0
		[CallerCount(177)]
		[CachedScanResults(RefRangeStart = 17913, RefRangeEnd = 18090, XrefRangeStart = 17913, XrefRangeEnd = 18090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFieldData(string itemID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x000193F4 File Offset: 0x000175F4
		public ItemFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06002FAA RID: 12202 RVA: 0x001084EC File Offset: 0x001066EC
		// (set) Token: 0x06002FAB RID: 12203 RVA: 0x000193FD File Offset: 0x000175FD
		public unsafe string ItemID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldData.NativeFieldInfoPtr_ItemID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldData.NativeFieldInfoPtr_ItemID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeFieldInfoPtr_ItemID;

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
