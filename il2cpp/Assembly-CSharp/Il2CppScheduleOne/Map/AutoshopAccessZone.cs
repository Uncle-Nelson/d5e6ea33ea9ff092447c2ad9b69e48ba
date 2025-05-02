using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000772 RID: 1906
	public class AutoshopAccessZone : NPCPresenceAccessZone
	{
		// Token: 0x0600B4D7 RID: 46295 RVA: 0x002D0064 File Offset: 0x002CE264
		// Note: this type is marked as 'beforefieldinit'.
		static AutoshopAccessZone()
		{
			Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "AutoshopAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr);
			AutoshopAccessZone.NativeFieldInfoPtr_RollerDoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, "RollerDoorAnim");
			AutoshopAccessZone.NativeFieldInfoPtr_VehicleDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, "VehicleDetection");
			AutoshopAccessZone.NativeFieldInfoPtr_rollerDoorOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, "rollerDoorOpen");
			AutoshopAccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, 100685538);
			AutoshopAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, 100685539);
			AutoshopAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, 100685540);
		}

		// Token: 0x0600B4D8 RID: 46296 RVA: 0x002D010C File Offset: 0x002CE30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309861, XrefRangeEnd = 309867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoshopAccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4D9 RID: 46297 RVA: 0x002D0158 File Offset: 0x002CE358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309867, XrefRangeEnd = 309878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoshopAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4DA RID: 46298 RVA: 0x002D0194 File Offset: 0x002CE394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309878, XrefRangeEnd = 309879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoshopAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoshopAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4DB RID: 46299 RVA: 0x00058BB9 File Offset: 0x00056DB9
		public AutoshopAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003811 RID: 14353
		// (get) Token: 0x0600B4DC RID: 46300 RVA: 0x002D01D0 File Offset: 0x002CE3D0
		// (set) Token: 0x0600B4DD RID: 46301 RVA: 0x00058BC2 File Offset: 0x00056DC2
		public unsafe Animation RollerDoorAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_RollerDoorAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_RollerDoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x0600B4DE RID: 46302 RVA: 0x002D0200 File Offset: 0x002CE400
		// (set) Token: 0x0600B4DF RID: 46303 RVA: 0x00058BE1 File Offset: 0x00056DE1
		public unsafe VehicleDetector VehicleDetection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_VehicleDetection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_VehicleDetection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x0600B4E0 RID: 46304 RVA: 0x002D0230 File Offset: 0x002CE430
		// (set) Token: 0x0600B4E1 RID: 46305 RVA: 0x00058C00 File Offset: 0x00056E00
		public unsafe bool rollerDoorOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_rollerDoorOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_rollerDoorOpen)) = value;
			}
		}

		// Token: 0x040079E0 RID: 31200
		private static readonly IntPtr NativeFieldInfoPtr_RollerDoorAnim;

		// Token: 0x040079E1 RID: 31201
		private static readonly IntPtr NativeFieldInfoPtr_VehicleDetection;

		// Token: 0x040079E2 RID: 31202
		private static readonly IntPtr NativeFieldInfoPtr_rollerDoorOpen;

		// Token: 0x040079E3 RID: 31203
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x040079E4 RID: 31204
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040079E5 RID: 31205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
