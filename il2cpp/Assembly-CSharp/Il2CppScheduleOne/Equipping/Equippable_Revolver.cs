using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C5 RID: 1477
	public class Equippable_Revolver : Equippable_RangedWeapon
	{
		// Token: 0x060081F3 RID: 33267 RVA: 0x00229C70 File Offset: 0x00227E70
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Revolver()
		{
			Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Revolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr);
			Equippable_Revolver.NativeFieldInfoPtr_Bullets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, "Bullets");
			Equippable_Revolver.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679557);
			Equippable_Revolver.NativeMethodInfoPtr_Fire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679558);
			Equippable_Revolver.NativeMethodInfoPtr_Reload_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679559);
			Equippable_Revolver.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679560);
			Equippable_Revolver.NativeMethodInfoPtr_SetDisplayedBullets_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679561);
			Equippable_Revolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679562);
		}

		// Token: 0x060081F4 RID: 33268 RVA: 0x00229D2C File Offset: 0x00227F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245929, XrefRangeEnd = 245932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081F5 RID: 33269 RVA: 0x00229D7C File Offset: 0x00227F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245932, XrefRangeEnd = 245935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_Fire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081F6 RID: 33270 RVA: 0x00229DB8 File Offset: 0x00227FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245935, XrefRangeEnd = 245950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_Reload_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081F7 RID: 33271 RVA: 0x00229DF4 File Offset: 0x00227FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245950, XrefRangeEnd = 245952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NotifyIncrementalReload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081F8 RID: 33272 RVA: 0x00229E30 File Offset: 0x00228030
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 245955, RefRangeEnd = 245959, XrefRangeStart = 245952, XrefRangeEnd = 245955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedBullets(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Revolver.NativeMethodInfoPtr_SetDisplayedBullets_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081F9 RID: 33273 RVA: 0x00229E70 File Offset: 0x00228070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Revolver() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Revolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081FA RID: 33274 RVA: 0x0003DCE2 File Offset: 0x0003BEE2
		public Equippable_Revolver(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002759 RID: 10073
		// (get) Token: 0x060081FB RID: 33275 RVA: 0x00229EAC File Offset: 0x002280AC
		// (set) Token: 0x060081FC RID: 33276 RVA: 0x0003DCEB File Offset: 0x0003BEEB
		public unsafe Il2CppReferenceArray<Transform> Bullets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Revolver.NativeFieldInfoPtr_Bullets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Revolver.NativeFieldInfoPtr_Bullets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400586A RID: 22634
		private static readonly IntPtr NativeFieldInfoPtr_Bullets;

		// Token: 0x0400586B RID: 22635
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x0400586C RID: 22636
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Public_Virtual_Void_0;

		// Token: 0x0400586D RID: 22637
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Public_Virtual_Void_0;

		// Token: 0x0400586E RID: 22638
		private static readonly IntPtr NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_Void_0;

		// Token: 0x0400586F RID: 22639
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedBullets_Private_Void_Int32_0;

		// Token: 0x04005870 RID: 22640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
