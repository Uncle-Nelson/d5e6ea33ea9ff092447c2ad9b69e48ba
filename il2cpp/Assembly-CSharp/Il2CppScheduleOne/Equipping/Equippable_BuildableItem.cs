using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C1 RID: 1473
	public class Equippable_BuildableItem : Equippable_StorableItem
	{
		// Token: 0x0600811B RID: 33051 RVA: 0x00227720 File Offset: 0x00225920
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_BuildableItem()
		{
			Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_BuildableItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr);
			Equippable_BuildableItem.NativeFieldInfoPtr_isBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, "isBuilding");
			Equippable_BuildableItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, 100679478);
			Equippable_BuildableItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, 100679479);
			Equippable_BuildableItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, 100679480);
		}

		// Token: 0x0600811C RID: 33052 RVA: 0x002277A0 File Offset: 0x002259A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245132, XrefRangeEnd = 245149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_BuildableItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600811D RID: 33053 RVA: 0x002277DC File Offset: 0x002259DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245149, XrefRangeEnd = 245156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_BuildableItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600811E RID: 33054 RVA: 0x00227818 File Offset: 0x00225A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_BuildableItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_BuildableItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600811F RID: 33055 RVA: 0x0003D46F File Offset: 0x0003B66F
		public Equippable_BuildableItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x06008120 RID: 33056 RVA: 0x00227854 File Offset: 0x00225A54
		// (set) Token: 0x06008121 RID: 33057 RVA: 0x0003D478 File Offset: 0x0003B678
		public unsafe bool isBuilding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_BuildableItem.NativeFieldInfoPtr_isBuilding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_BuildableItem.NativeFieldInfoPtr_isBuilding)) = value;
			}
		}

		// Token: 0x040057E6 RID: 22502
		private static readonly IntPtr NativeFieldInfoPtr_isBuilding;

		// Token: 0x040057E7 RID: 22503
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040057E8 RID: 22504
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040057E9 RID: 22505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
