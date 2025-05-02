using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000294 RID: 660
	[Serializable]
	public class BuildableItemData : SaveData
	{
		// Token: 0x06003081 RID: 12417 RVA: 0x0010AA20 File Offset: 0x00108C20
		// Note: this type is marked as 'beforefieldinit'.
		static BuildableItemData()
		{
			Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BuildableItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr);
			BuildableItemData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, "GUID");
			BuildableItemData.NativeFieldInfoPtr_ItemString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, "ItemString");
			BuildableItemData.NativeFieldInfoPtr_LoadOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, "LoadOrder");
			BuildableItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, 100668812);
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x0010AAA0 File Offset: 0x00108CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130981, RefRangeEnd = 130982, XrefRangeStart = 130977, XrefRangeEnd = 130981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemData(Guid guid, ItemInstance item, int loadOrder) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x00019CB7 File Offset: 0x00017EB7
		public BuildableItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06003084 RID: 12420 RVA: 0x0010AB08 File Offset: 0x00108D08
		// (set) Token: 0x06003085 RID: 12421 RVA: 0x00019CC0 File Offset: 0x00017EC0
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06003086 RID: 12422 RVA: 0x0010AB30 File Offset: 0x00108D30
		// (set) Token: 0x06003087 RID: 12423 RVA: 0x00019CDF File Offset: 0x00017EDF
		public unsafe string ItemString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_ItemString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_ItemString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x0010AB58 File Offset: 0x00108D58
		// (set) Token: 0x06003089 RID: 12425 RVA: 0x00019CFE File Offset: 0x00017EFE
		public unsafe int LoadOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_LoadOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_LoadOrder)) = value;
			}
		}

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeFieldInfoPtr_ItemString;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeFieldInfoPtr_LoadOrder;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_0;
	}
}
