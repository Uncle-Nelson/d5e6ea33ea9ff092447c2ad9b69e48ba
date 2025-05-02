using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x02000167 RID: 359
	public class Registry : PersistentSingleton<Registry>
	{
		// Token: 0x06001D03 RID: 7427 RVA: 0x000CA7E4 File Offset: 0x000C89E4
		// Note: this type is marked as 'beforefieldinit'.
		static Registry()
		{
			Il2CppClassPointerStore<Registry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "Registry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry>.NativeClassPtr);
			Registry.NativeFieldInfoPtr_ObjectRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ObjectRegistry");
			Registry.NativeFieldInfoPtr_ItemRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemRegistry");
			Registry.NativeFieldInfoPtr_ItemsAddedAtRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemsAddedAtRuntime");
			Registry.NativeFieldInfoPtr_ItemDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemDictionary");
			Registry.NativeFieldInfoPtr_itemIDAliases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "itemIDAliases");
			Registry.NativeFieldInfoPtr_Seeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "Seeds");
			Registry.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666565);
			Registry.NativeMethodInfoPtr_GetPrefab_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666566);
			Registry.NativeMethodInfoPtr_GetItem_Public_Static_ItemDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666567);
			Registry.NativeMethodInfoPtr_ItemExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666568);
			Registry.NativeMethodInfoPtr_GetItem_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666569);
			Registry.NativeMethodInfoPtr__GetItem_Public_ItemDefinition_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666570);
			Registry.NativeMethodInfoPtr_GetConstructable_Public_Static_Constructable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666571);
			Registry.NativeMethodInfoPtr_GetHash_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666572);
			Registry.NativeMethodInfoPtr_RemoveAssetsAndPrefab_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666573);
			Registry.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666574);
			Registry.NativeMethodInfoPtr_AddToRegistry_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666575);
			Registry.NativeMethodInfoPtr_AddToItemDictionary_Private_Void_ItemRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666576);
			Registry.NativeMethodInfoPtr_RemoveItemFromDictionary_Private_Void_ItemRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666577);
			Registry.NativeMethodInfoPtr_RemoveRuntimeItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666578);
			Registry.NativeMethodInfoPtr_RemoveFromRegistry_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666579);
			Registry.NativeMethodInfoPtr_LogOrderedUnlocks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666580);
			Registry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666581);
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x000CA9E0 File Offset: 0x000C8BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104280, XrefRangeEnd = 104324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Registry.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x000CAA1C File Offset: 0x000C8C1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 104343, RefRangeEnd = 104346, XrefRangeStart = 104324, XrefRangeEnd = 104343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject GetPrefab(string id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetPrefab_Public_Static_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x000CAA60 File Offset: 0x000C8C60
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 104352, RefRangeEnd = 104418, XrefRangeStart = 104346, XrefRangeEnd = 104352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemDefinition GetItem(string ID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetItem_Public_Static_ItemDefinition_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x000CAAA4 File Offset: 0x000C8CA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104428, RefRangeEnd = 104429, XrefRangeStart = 104418, XrefRangeEnd = 104428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ItemExists(string ID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_ItemExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x000CAAE8 File Offset: 0x000C8CE8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 104438, RefRangeEnd = 104452, XrefRangeStart = 104429, XrefRangeEnd = 104438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetItem<T>(string ID) where T : ItemDefinition
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.MethodInfoStoreGeneric_GetItem_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x000CAB28 File Offset: 0x000C8D28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 104496, RefRangeEnd = 104501, XrefRangeStart = 104452, XrefRangeEnd = 104496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinition _GetItem(string ID, bool warnIfNonExistent = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warnIfNonExistent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr__GetItem_Public_ItemDefinition_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x000CAB88 File Offset: 0x000C8D88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 104528, RefRangeEnd = 104534, XrefRangeStart = 104501, XrefRangeEnd = 104528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Constructable GetConstructable(string id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetConstructable_Public_Static_Constructable_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr3) : null;
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x000CABCC File Offset: 0x000C8DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104534, XrefRangeEnd = 104536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHash(string ID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetHash_Private_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x000CAC10 File Offset: 0x000C8E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104536, XrefRangeEnd = 104545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveAssetsAndPrefab(string originalString)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(originalString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveAssetsAndPrefab_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x000CAC4C File Offset: 0x000C8E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104545, XrefRangeEnd = 104560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Registry.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x000CAC88 File Offset: 0x000C8E88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 104613, RefRangeEnd = 104616, XrefRangeStart = 104560, XrefRangeEnd = 104613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToRegistry(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_AddToRegistry_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x000CACCC File Offset: 0x000C8ECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 104634, RefRangeEnd = 104636, XrefRangeStart = 104616, XrefRangeEnd = 104634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToItemDictionary(Registry.ItemRegister reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_AddToItemDictionary_Private_Void_ItemRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x000CAD10 File Offset: 0x000C8F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104636, XrefRangeEnd = 104641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItemFromDictionary(Registry.ItemRegister reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveItemFromDictionary_Private_Void_ItemRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x000CAD54 File Offset: 0x000C8F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104641, XrefRangeEnd = 104693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRuntimeItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveRuntimeItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x000CAD88 File Offset: 0x000C8F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104693, XrefRangeEnd = 104714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromRegistry(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveFromRegistry_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x000CADCC File Offset: 0x000C8FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104714, XrefRangeEnd = 104784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogOrderedUnlocks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_LogOrderedUnlocks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x000CAE00 File Offset: 0x000C9000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104784, XrefRangeEnd = 104835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Registry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00010873 File Offset: 0x0000EA73
		public Registry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x000CAE3C File Offset: 0x000C903C
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x0001087C File Offset: 0x0000EA7C
		public unsafe List<Registry.ObjectRegister> ObjectRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ObjectRegistry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Registry.ObjectRegister>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ObjectRegistry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x000CAE6C File Offset: 0x000C906C
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x0001089B File Offset: 0x0000EA9B
		public unsafe List<Registry.ItemRegister> ItemRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemRegistry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Registry.ItemRegister>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemRegistry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x000CAE9C File Offset: 0x000C909C
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x000108BA File Offset: 0x0000EABA
		public unsafe List<Registry.ItemRegister> ItemsAddedAtRuntime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemsAddedAtRuntime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Registry.ItemRegister>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemsAddedAtRuntime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x000CAECC File Offset: 0x000C90CC
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x000108D9 File Offset: 0x0000EAD9
		public unsafe Dictionary<int, Registry.ItemRegister> ItemDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Registry.ItemRegister>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x000CAEFC File Offset: 0x000C90FC
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x000108F8 File Offset: 0x0000EAF8
		public unsafe Dictionary<string, string> itemIDAliases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_itemIDAliases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_itemIDAliases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x000CAF2C File Offset: 0x000C912C
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x00010917 File Offset: 0x0000EB17
		public unsafe List<SeedDefinition> Seeds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_Seeds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SeedDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_Seeds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeFieldInfoPtr_ObjectRegistry;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeFieldInfoPtr_ItemRegistry;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeFieldInfoPtr_ItemsAddedAtRuntime;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeFieldInfoPtr_ItemDictionary;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeFieldInfoPtr_itemIDAliases;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeFieldInfoPtr_Seeds;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefab_Public_Static_GameObject_String_0;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeMethodInfoPtr_GetItem_Public_Static_ItemDefinition_String_0;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr_ItemExists_Public_Static_Boolean_String_0;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeMethodInfoPtr_GetItem_Public_Static_T_String_0;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr__GetItem_Public_ItemDefinition_String_Boolean_0;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructable_Public_Static_Constructable_String_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr_GetHash_Private_Static_Int32_String_0;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAssetsAndPrefab_Private_Static_String_String_0;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_AddToRegistry_Public_Void_ItemDefinition_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_AddToItemDictionary_Private_Void_ItemRegister_0;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItemFromDictionary_Private_Void_ItemRegister_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRuntimeItems_Public_Void_0;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromRegistry_Public_Void_ItemDefinition_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_LogOrderedUnlocks_Public_Void_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200089D RID: 2205
		[Serializable]
		public class ObjectRegister : Il2CppSystem.Object
		{
			// Token: 0x0600C2A9 RID: 49833 RVA: 0x002F8B00 File Offset: 0x002F6D00
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectRegister()
			{
				Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ObjectRegister");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr);
				Registry.ObjectRegister.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr, "ID");
				Registry.ObjectRegister.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr, "AssetPath");
				Registry.ObjectRegister.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr, "Prefab");
				Registry.ObjectRegister.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr, 100666582);
			}

			// Token: 0x0600C2AA RID: 49834 RVA: 0x002F8B7C File Offset: 0x002F6D7C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectRegister() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.ObjectRegister.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2AB RID: 49835 RVA: 0x0005EB8F File Offset: 0x0005CD8F
			public ObjectRegister(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CCC RID: 15564
			// (get) Token: 0x0600C2AC RID: 49836 RVA: 0x002F8BB8 File Offset: 0x002F6DB8
			// (set) Token: 0x0600C2AD RID: 49837 RVA: 0x0005EB98 File Offset: 0x0005CD98
			public unsafe string ID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_ID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003CCD RID: 15565
			// (get) Token: 0x0600C2AE RID: 49838 RVA: 0x002F8BE0 File Offset: 0x002F6DE0
			// (set) Token: 0x0600C2AF RID: 49839 RVA: 0x0005EBB7 File Offset: 0x0005CDB7
			public unsafe string AssetPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_AssetPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003CCE RID: 15566
			// (get) Token: 0x0600C2B0 RID: 49840 RVA: 0x002F8C08 File Offset: 0x002F6E08
			// (set) Token: 0x0600C2B1 RID: 49841 RVA: 0x0005EBD6 File Offset: 0x0005CDD6
			public unsafe NetworkObject Prefab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_Prefab);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040083D5 RID: 33749
			private static readonly IntPtr NativeFieldInfoPtr_ID;

			// Token: 0x040083D6 RID: 33750
			private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

			// Token: 0x040083D7 RID: 33751
			private static readonly IntPtr NativeFieldInfoPtr_Prefab;

			// Token: 0x040083D8 RID: 33752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200089E RID: 2206
		[Serializable]
		public class ItemRegister : Il2CppSystem.Object
		{
			// Token: 0x0600C2B2 RID: 49842 RVA: 0x002F8C38 File Offset: 0x002F6E38
			// Note: this type is marked as 'beforefieldinit'.
			static ItemRegister()
			{
				Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemRegister");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr);
				Registry.ItemRegister.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, "ID");
				Registry.ItemRegister.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, "AssetPath");
				Registry.ItemRegister.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, "Definition");
				Registry.ItemRegister.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, 100666583);
			}

			// Token: 0x0600C2B3 RID: 49843 RVA: 0x002F8CB4 File Offset: 0x002F6EB4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemRegister() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.ItemRegister.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2B4 RID: 49844 RVA: 0x0005EBF5 File Offset: 0x0005CDF5
			public ItemRegister(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CCF RID: 15567
			// (get) Token: 0x0600C2B5 RID: 49845 RVA: 0x002F8CF0 File Offset: 0x002F6EF0
			// (set) Token: 0x0600C2B6 RID: 49846 RVA: 0x0005EBFE File Offset: 0x0005CDFE
			public unsafe string ID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_ID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003CD0 RID: 15568
			// (get) Token: 0x0600C2B7 RID: 49847 RVA: 0x002F8D18 File Offset: 0x002F6F18
			// (set) Token: 0x0600C2B8 RID: 49848 RVA: 0x0005EC1D File Offset: 0x0005CE1D
			public unsafe string AssetPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_AssetPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003CD1 RID: 15569
			// (get) Token: 0x0600C2B9 RID: 49849 RVA: 0x002F8D40 File Offset: 0x002F6F40
			// (set) Token: 0x0600C2BA RID: 49850 RVA: 0x0005EC3C File Offset: 0x0005CE3C
			public unsafe ItemDefinition Definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_Definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040083D9 RID: 33753
			private static readonly IntPtr NativeFieldInfoPtr_ID;

			// Token: 0x040083DA RID: 33754
			private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

			// Token: 0x040083DB RID: 33755
			private static readonly IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x040083DC RID: 33756
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200089F RID: 2207
		[ObfuscatedName("ScheduleOne.Registry+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C2BB RID: 49851 RVA: 0x002F8D70 File Offset: 0x002F6F70
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Registry.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr);
				Registry.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, "<>9");
				Registry.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, "<>9__23_0");
				Registry.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, 100666585);
				Registry.__c.NativeMethodInfoPtr__LogOrderedUnlocks_b__23_0_Internal_Int32_ItemDefinition_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, 100666586);
			}

			// Token: 0x0600C2BC RID: 49852 RVA: 0x002F8DEC File Offset: 0x002F6FEC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2BD RID: 49853 RVA: 0x002F8E28 File Offset: 0x002F7028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104247, XrefRangeEnd = 104251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _LogOrderedUnlocks_b__23_0(ItemDefinition x, ItemDefinition y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c.NativeMethodInfoPtr__LogOrderedUnlocks_b__23_0_Internal_Int32_ItemDefinition_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C2BE RID: 49854 RVA: 0x0005EC5B File Offset: 0x0005CE5B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CD2 RID: 15570
			// (get) Token: 0x0600C2BF RID: 49855 RVA: 0x002F8E88 File Offset: 0x002F7088
			// (set) Token: 0x0600C2C0 RID: 49856 RVA: 0x0005EC64 File Offset: 0x0005CE64
			public unsafe static Registry.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Registry.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Registry.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Registry.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CD3 RID: 15571
			// (get) Token: 0x0600C2C1 RID: 49857 RVA: 0x002F8EB0 File Offset: 0x002F70B0
			// (set) Token: 0x0600C2C2 RID: 49858 RVA: 0x0005EC76 File Offset: 0x0005CE76
			public unsafe static Comparison<ItemDefinition> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Registry.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ItemDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Registry.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040083DD RID: 33757
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040083DE RID: 33758
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x040083DF RID: 33759
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040083E0 RID: 33760
			private static readonly IntPtr NativeMethodInfoPtr__LogOrderedUnlocks_b__23_0_Internal_Int32_ItemDefinition_ItemDefinition_0;
		}

		// Token: 0x020008A0 RID: 2208
		[ObfuscatedName("ScheduleOne.Registry+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C2C3 RID: 49859 RVA: 0x002F8ED8 File Offset: 0x002F70D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<Registry.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.__c__DisplayClass22_0>.NativeClassPtr);
				Registry.__c__DisplayClass22_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c__DisplayClass22_0>.NativeClassPtr, "item");
				Registry.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c__DisplayClass22_0>.NativeClassPtr, 100666587);
				Registry.__c__DisplayClass22_0.NativeMethodInfoPtr__RemoveFromRegistry_b__0_Internal_Boolean_ItemRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c__DisplayClass22_0>.NativeClassPtr, 100666588);
			}

			// Token: 0x0600C2C4 RID: 49860 RVA: 0x002F8F40 File Offset: 0x002F7140
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2C5 RID: 49861 RVA: 0x002F8F7C File Offset: 0x002F717C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104251, XrefRangeEnd = 104256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveFromRegistry_b__0(Registry.ItemRegister x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c__DisplayClass22_0.NativeMethodInfoPtr__RemoveFromRegistry_b__0_Internal_Boolean_ItemRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C2C6 RID: 49862 RVA: 0x0005EC88 File Offset: 0x0005CE88
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CD4 RID: 15572
			// (get) Token: 0x0600C2C7 RID: 49863 RVA: 0x002F8FCC File Offset: 0x002F71CC
			// (set) Token: 0x0600C2C8 RID: 49864 RVA: 0x0005EC91 File Offset: 0x0005CE91
			public unsafe ItemDefinition item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.__c__DisplayClass22_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.__c__DisplayClass22_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040083E1 RID: 33761
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x040083E2 RID: 33762
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040083E3 RID: 33763
			private static readonly IntPtr NativeMethodInfoPtr__RemoveFromRegistry_b__0_Internal_Boolean_ItemRegister_0;
		}

		// Token: 0x020008A1 RID: 2209
		[ObfuscatedName("ScheduleOne.Registry+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C2C9 RID: 49865 RVA: 0x002F8FFC File Offset: 0x002F71FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<Registry.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.__c__DisplayClass9_0>.NativeClassPtr);
				Registry.__c__DisplayClass9_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c__DisplayClass9_0>.NativeClassPtr, "id");
				Registry.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c__DisplayClass9_0>.NativeClassPtr, 100666589);
				Registry.__c__DisplayClass9_0.NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_ObjectRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c__DisplayClass9_0>.NativeClassPtr, 100666590);
			}

			// Token: 0x0600C2CA RID: 49866 RVA: 0x002F9064 File Offset: 0x002F7264
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2CB RID: 49867 RVA: 0x002F90A0 File Offset: 0x002F72A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104256, XrefRangeEnd = 104280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPrefab_b__0(Registry.ObjectRegister x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c__DisplayClass9_0.NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_ObjectRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C2CC RID: 49868 RVA: 0x0005ECB0 File Offset: 0x0005CEB0
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CD5 RID: 15573
			// (get) Token: 0x0600C2CD RID: 49869 RVA: 0x002F90F0 File Offset: 0x002F72F0
			// (set) Token: 0x0600C2CE RID: 49870 RVA: 0x0005ECB9 File Offset: 0x0005CEB9
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.__c__DisplayClass9_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.__c__DisplayClass9_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040083E4 RID: 33764
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040083E5 RID: 33765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040083E6 RID: 33766
			private static readonly IntPtr NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_ObjectRegister_0;
		}

		// Token: 0x020008A2 RID: 2210
		private sealed class MethodInfoStoreGeneric_GetItem_Public_Static_T_String_0<T>
		{
			// Token: 0x040083E7 RID: 33767
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Registry.NativeMethodInfoPtr_GetItem_Public_Static_T_String_0, Il2CppClassPointerStore<Registry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
