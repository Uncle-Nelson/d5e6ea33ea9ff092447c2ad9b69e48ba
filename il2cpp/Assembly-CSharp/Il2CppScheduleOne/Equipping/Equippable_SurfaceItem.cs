using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C7 RID: 1479
	public class Equippable_SurfaceItem : Equippable_StorableItem
	{
		// Token: 0x0600820B RID: 33291 RVA: 0x0022A198 File Offset: 0x00228398
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_SurfaceItem()
		{
			Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_SurfaceItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr);
			Equippable_SurfaceItem.NativeFieldInfoPtr_isBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, "isBuilding");
			Equippable_SurfaceItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, 100679569);
			Equippable_SurfaceItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, 100679570);
			Equippable_SurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, 100679571);
		}

		// Token: 0x0600820C RID: 33292 RVA: 0x0022A218 File Offset: 0x00228418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246009, XrefRangeEnd = 246026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_SurfaceItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600820D RID: 33293 RVA: 0x0022A254 File Offset: 0x00228454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246026, XrefRangeEnd = 246033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_SurfaceItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600820E RID: 33294 RVA: 0x0022A290 File Offset: 0x00228490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_SurfaceItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_SurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600820F RID: 33295 RVA: 0x0003DD64 File Offset: 0x0003BF64
		public Equippable_SurfaceItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700275D RID: 10077
		// (get) Token: 0x06008210 RID: 33296 RVA: 0x0022A2CC File Offset: 0x002284CC
		// (set) Token: 0x06008211 RID: 33297 RVA: 0x0003DD6D File Offset: 0x0003BF6D
		public unsafe bool isBuilding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_SurfaceItem.NativeFieldInfoPtr_isBuilding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_SurfaceItem.NativeFieldInfoPtr_isBuilding)) = value;
			}
		}

		// Token: 0x0400587A RID: 22650
		private static readonly IntPtr NativeFieldInfoPtr_isBuilding;

		// Token: 0x0400587B RID: 22651
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400587C RID: 22652
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x0400587D RID: 22653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
