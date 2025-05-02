using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000672 RID: 1650
	public class VehicleCanvas : Singleton<VehicleCanvas>
	{
		// Token: 0x06009336 RID: 37686 RVA: 0x0025E8F8 File Offset: 0x0025CAF8
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleCanvas()
		{
			Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "VehicleCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr);
			VehicleCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "Canvas");
			VehicleCanvas.NativeFieldInfoPtr_SpeedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "SpeedText");
			VehicleCanvas.NativeFieldInfoPtr_DriverPromptsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "DriverPromptsContainer");
			VehicleCanvas.NativeFieldInfoPtr_currentVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "currentVehicle");
			VehicleCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681544);
			VehicleCanvas.NativeMethodInfoPtr_Subscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681545);
			VehicleCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681546);
			VehicleCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681547);
			VehicleCanvas.NativeMethodInfoPtr_VehicleEntered_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681548);
			VehicleCanvas.NativeMethodInfoPtr_VehicleExited_Private_Void_LandVehicle_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681549);
			VehicleCanvas.NativeMethodInfoPtr_UpdateSpeedText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681550);
			VehicleCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681551);
		}

		// Token: 0x06009337 RID: 37687 RVA: 0x0025EA18 File Offset: 0x0025CC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265331, XrefRangeEnd = 265354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009338 RID: 37688 RVA: 0x0025EA54 File Offset: 0x0025CC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265354, XrefRangeEnd = 265386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_Subscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009339 RID: 37689 RVA: 0x0025EA88 File Offset: 0x0025CC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265386, XrefRangeEnd = 265405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933A RID: 37690 RVA: 0x0025EABC File Offset: 0x0025CCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265405, XrefRangeEnd = 265410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933B RID: 37691 RVA: 0x0025EAF0 File Offset: 0x0025CCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265410, XrefRangeEnd = 265415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VehicleEntered(LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_VehicleEntered_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933C RID: 37692 RVA: 0x0025EB34 File Offset: 0x0025CD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265415, XrefRangeEnd = 265418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VehicleExited(LandVehicle veh, Transform exitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_VehicleExited_Private_Void_LandVehicle_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933D RID: 37693 RVA: 0x0025EB88 File Offset: 0x0025CD88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265434, RefRangeEnd = 265436, XrefRangeStart = 265418, XrefRangeEnd = 265434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_UpdateSpeedText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933E RID: 37694 RVA: 0x0025EBBC File Offset: 0x0025CDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265436, XrefRangeEnd = 265439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600933F RID: 37695 RVA: 0x000474F3 File Offset: 0x000456F3
		public VehicleCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D21 RID: 11553
		// (get) Token: 0x06009340 RID: 37696 RVA: 0x0025EBF8 File Offset: 0x0025CDF8
		// (set) Token: 0x06009341 RID: 37697 RVA: 0x000474FC File Offset: 0x000456FC
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D22 RID: 11554
		// (get) Token: 0x06009342 RID: 37698 RVA: 0x0025EC28 File Offset: 0x0025CE28
		// (set) Token: 0x06009343 RID: 37699 RVA: 0x0004751B File Offset: 0x0004571B
		public unsafe TextMeshProUGUI SpeedText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_SpeedText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_SpeedText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D23 RID: 11555
		// (get) Token: 0x06009344 RID: 37700 RVA: 0x0025EC58 File Offset: 0x0025CE58
		// (set) Token: 0x06009345 RID: 37701 RVA: 0x0004753A File Offset: 0x0004573A
		public unsafe GameObject DriverPromptsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_DriverPromptsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_DriverPromptsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x06009346 RID: 37702 RVA: 0x0025EC88 File Offset: 0x0025CE88
		// (set) Token: 0x06009347 RID: 37703 RVA: 0x00047559 File Offset: 0x00045759
		public unsafe LandVehicle currentVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_currentVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_currentVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006363 RID: 25443
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006364 RID: 25444
		private static readonly IntPtr NativeFieldInfoPtr_SpeedText;

		// Token: 0x04006365 RID: 25445
		private static readonly IntPtr NativeFieldInfoPtr_DriverPromptsContainer;

		// Token: 0x04006366 RID: 25446
		private static readonly IntPtr NativeFieldInfoPtr_currentVehicle;

		// Token: 0x04006367 RID: 25447
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006368 RID: 25448
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Private_Void_0;

		// Token: 0x04006369 RID: 25449
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400636A RID: 25450
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400636B RID: 25451
		private static readonly IntPtr NativeMethodInfoPtr_VehicleEntered_Private_Void_LandVehicle_0;

		// Token: 0x0400636C RID: 25452
		private static readonly IntPtr NativeMethodInfoPtr_VehicleExited_Private_Void_LandVehicle_Transform_0;

		// Token: 0x0400636D RID: 25453
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeedText_Private_Void_0;

		// Token: 0x0400636E RID: 25454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
