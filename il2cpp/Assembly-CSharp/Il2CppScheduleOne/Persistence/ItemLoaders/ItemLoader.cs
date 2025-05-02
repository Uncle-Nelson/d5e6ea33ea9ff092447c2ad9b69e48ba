using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020002C6 RID: 710
	public class ItemLoader : Object
	{
		// Token: 0x0600323F RID: 12863 RVA: 0x0010FB54 File Offset: 0x0010DD54
		// Note: this type is marked as 'beforefieldinit'.
		static ItemLoader()
		{
			Il2CppClassPointerStore<ItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.ItemLoaders", "ItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr);
			ItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100668878);
			ItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100668879);
			ItemLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_New_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100668880);
			ItemLoader.NativeMethodInfoPtr_LoadData_Protected_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100668881);
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06003240 RID: 12864 RVA: 0x0010FBD4 File Offset: 0x0010DDD4
		public unsafe virtual string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131485, XrefRangeEnd = 131492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x0010FC18 File Offset: 0x0010DE18
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 131503, RefRangeEnd = 131515, XrefRangeStart = 131492, XrefRangeEnd = 131503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x0010FC54 File Offset: 0x0010DE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131515, XrefRangeEnd = 131533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemInstance LoadItem(string itemString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_New_ItemInstance_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x0010FCB0 File Offset: 0x0010DEB0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 131543, RefRangeEnd = 131554, XrefRangeStart = 131533, XrefRangeEnd = 131543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T LoadData<T>(string itemString) where T : ItemData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemLoader.MethodInfoStoreGeneric_LoadData_Protected_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x0001AEBC File Offset: 0x000190BC
		public ItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400208A RID: 8330
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0;

		// Token: 0x0400208B RID: 8331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400208C RID: 8332
		private static readonly IntPtr NativeMethodInfoPtr_LoadItem_Public_Virtual_New_ItemInstance_String_0;

		// Token: 0x0400208D RID: 8333
		private static readonly IntPtr NativeMethodInfoPtr_LoadData_Protected_T_String_0;

		// Token: 0x0200091A RID: 2330
		private sealed class MethodInfoStoreGeneric_LoadData_Protected_T_String_0<T>
		{
			// Token: 0x04008633 RID: 34355
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ItemLoader.NativeMethodInfoPtr_LoadData_Protected_T_String_0, Il2CppClassPointerStore<ItemLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
