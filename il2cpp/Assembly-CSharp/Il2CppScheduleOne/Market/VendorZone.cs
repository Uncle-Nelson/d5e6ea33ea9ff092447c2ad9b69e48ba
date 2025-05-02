using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x02000380 RID: 896
	public class VendorZone : MonoBehaviour
	{
		// Token: 0x060045FE RID: 17918 RVA: 0x0015823C File Offset: 0x0015643C
		// Note: this type is marked as 'beforefieldinit'.
		static VendorZone()
		{
			Il2CppClassPointerStore<VendorZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "VendorZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendorZone>.NativeClassPtr);
			VendorZone.NativeFieldInfoPtr_zoneCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, "zoneCollider");
			VendorZone.NativeFieldInfoPtr_doors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, "doors");
			VendorZone.NativeFieldInfoPtr_openTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, "openTime");
			VendorZone.NativeFieldInfoPtr_closeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, "closeTime");
			VendorZone.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100671896);
			VendorZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100671897);
			VendorZone.NativeMethodInfoPtr_MinPassed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100671898);
			VendorZone.NativeMethodInfoPtr_IsPlayerWithinVendorZone_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100671899);
			VendorZone.NativeMethodInfoPtr_SetDoorsActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100671900);
			VendorZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100671901);
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x060045FF RID: 17919 RVA: 0x00158334 File Offset: 0x00156534
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157898, XrefRangeEnd = 157904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x00158370 File Offset: 0x00156570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157904, XrefRangeEnd = 157922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendorZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x001583AC File Offset: 0x001565AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157922, XrefRangeEnd = 157936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr_MinPassed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x001583E0 File Offset: 0x001565E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157936, XrefRangeEnd = 157944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerWithinVendorZone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr_IsPlayerWithinVendorZone_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x0015841C File Offset: 0x0015661C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157950, RefRangeEnd = 157951, XrefRangeStart = 157944, XrefRangeEnd = 157950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDoorsActive(bool a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr_SetDoorsActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x0015845C File Offset: 0x0015665C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157951, XrefRangeEnd = 157959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VendorZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendorZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x000221C3 File Offset: 0x000203C3
		public VendorZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x06004606 RID: 17926 RVA: 0x00158498 File Offset: 0x00156698
		// (set) Token: 0x06004607 RID: 17927 RVA: 0x000221CC File Offset: 0x000203CC
		public unsafe BoxCollider zoneCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_zoneCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_zoneCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x06004608 RID: 17928 RVA: 0x001584C8 File Offset: 0x001566C8
		// (set) Token: 0x06004609 RID: 17929 RVA: 0x000221EB File Offset: 0x000203EB
		public unsafe List<GameObject> doors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_doors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_doors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x0600460A RID: 17930 RVA: 0x001584F8 File Offset: 0x001566F8
		// (set) Token: 0x0600460B RID: 17931 RVA: 0x0002220A File Offset: 0x0002040A
		public unsafe int openTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_openTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_openTime)) = value;
			}
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x0600460C RID: 17932 RVA: 0x00158520 File Offset: 0x00156720
		// (set) Token: 0x0600460D RID: 17933 RVA: 0x00022225 File Offset: 0x00020425
		public unsafe int closeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_closeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_closeTime)) = value;
			}
		}

		// Token: 0x04002EF8 RID: 12024
		private static readonly IntPtr NativeFieldInfoPtr_zoneCollider;

		// Token: 0x04002EF9 RID: 12025
		private static readonly IntPtr NativeFieldInfoPtr_doors;

		// Token: 0x04002EFA RID: 12026
		private static readonly IntPtr NativeFieldInfoPtr_openTime;

		// Token: 0x04002EFB RID: 12027
		private static readonly IntPtr NativeFieldInfoPtr_closeTime;

		// Token: 0x04002EFC RID: 12028
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04002EFD RID: 12029
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04002EFE RID: 12030
		private static readonly IntPtr NativeMethodInfoPtr_MinPassed_Private_Void_0;

		// Token: 0x04002EFF RID: 12031
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerWithinVendorZone_Private_Boolean_0;

		// Token: 0x04002F00 RID: 12032
		private static readonly IntPtr NativeMethodInfoPtr_SetDoorsActive_Private_Void_Boolean_0;

		// Token: 0x04002F01 RID: 12033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
