using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C6 RID: 1478
	public class Equippable_StorableItem : Equippable
	{
		// Token: 0x060081FD RID: 33277 RVA: 0x00229EDC File Offset: 0x002280DC
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_StorableItem()
		{
			Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_StorableItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr);
			Equippable_StorableItem.NativeFieldInfoPtr_isBuildingStoredItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, "isBuildingStoredItem");
			Equippable_StorableItem.NativeFieldInfoPtr_lookingAtStorageObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, "lookingAtStorageObject");
			Equippable_StorableItem.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, "rotation");
			Equippable_StorableItem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679563);
			Equippable_StorableItem.NativeMethodInfoPtr_CheckLookingAtStorageObject_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679564);
			Equippable_StorableItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679565);
			Equippable_StorableItem.NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679566);
			Equippable_StorableItem.NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679567);
			Equippable_StorableItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679568);
		}

		// Token: 0x060081FE RID: 33278 RVA: 0x00229FC0 File Offset: 0x002281C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 245959, RefRangeEnd = 245964, XrefRangeStart = 245959, XrefRangeEnd = 245959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_StorableItem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081FF RID: 33279 RVA: 0x00229FFC File Offset: 0x002281FC
		[CallerCount(0)]
		public unsafe void CheckLookingAtStorageObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_StorableItem.NativeMethodInfoPtr_CheckLookingAtStorageObject_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008200 RID: 33280 RVA: 0x0022A030 File Offset: 0x00228230
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 245980, RefRangeEnd = 245986, XrefRangeStart = 245964, XrefRangeEnd = 245980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_StorableItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008201 RID: 33281 RVA: 0x0022A06C File Offset: 0x0022826C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245986, XrefRangeEnd = 245997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartBuildingStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_StorableItem.NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008202 RID: 33282 RVA: 0x0022A0A8 File Offset: 0x002282A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245997, XrefRangeEnd = 246009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopBuildingStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_StorableItem.NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008203 RID: 33283 RVA: 0x0022A0E4 File Offset: 0x002282E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_StorableItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_StorableItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008204 RID: 33284 RVA: 0x0003DD0A File Offset: 0x0003BF0A
		public Equippable_StorableItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x06008205 RID: 33285 RVA: 0x0022A120 File Offset: 0x00228320
		// (set) Token: 0x06008206 RID: 33286 RVA: 0x0003DD13 File Offset: 0x0003BF13
		public unsafe bool isBuildingStoredItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_isBuildingStoredItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_isBuildingStoredItem)) = value;
			}
		}

		// Token: 0x1700275B RID: 10075
		// (get) Token: 0x06008207 RID: 33287 RVA: 0x0022A148 File Offset: 0x00228348
		// (set) Token: 0x06008208 RID: 33288 RVA: 0x0003DD2E File Offset: 0x0003BF2E
		public unsafe bool lookingAtStorageObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_lookingAtStorageObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_lookingAtStorageObject)) = value;
			}
		}

		// Token: 0x1700275C RID: 10076
		// (get) Token: 0x06008209 RID: 33289 RVA: 0x0022A170 File Offset: 0x00228370
		// (set) Token: 0x0600820A RID: 33290 RVA: 0x0003DD49 File Offset: 0x0003BF49
		public unsafe float rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x04005871 RID: 22641
		private static readonly IntPtr NativeFieldInfoPtr_isBuildingStoredItem;

		// Token: 0x04005872 RID: 22642
		private static readonly IntPtr NativeFieldInfoPtr_lookingAtStorageObject;

		// Token: 0x04005873 RID: 22643
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04005874 RID: 22644
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04005875 RID: 22645
		private static readonly IntPtr NativeMethodInfoPtr_CheckLookingAtStorageObject_Protected_Void_0;

		// Token: 0x04005876 RID: 22646
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005877 RID: 22647
		private static readonly IntPtr NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_New_Void_0;

		// Token: 0x04005878 RID: 22648
		private static readonly IntPtr NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_New_Void_0;

		// Token: 0x04005879 RID: 22649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
