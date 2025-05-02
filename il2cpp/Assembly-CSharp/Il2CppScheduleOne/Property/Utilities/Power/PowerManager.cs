using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Power
{
	// Token: 0x02000519 RID: 1305
	public class PowerManager : Singleton<PowerManager>
	{
		// Token: 0x06007441 RID: 29761 RVA: 0x001FAFD8 File Offset: 0x001F91D8
		// Note: this type is marked as 'beforefieldinit'.
		static PowerManager()
		{
			Il2CppClassPointerStore<PowerManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Power", "PowerManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerManager>.NativeClassPtr);
			PowerManager.NativeFieldInfoPtr_powerLineSegmentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, "powerLineSegmentPrefab");
			PowerManager.NativeFieldInfoPtr_pricePerkWh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, "pricePerkWh");
			PowerManager.NativeFieldInfoPtr_usageAtTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, "usageAtTime");
			PowerManager.NativeFieldInfoPtr_usageThisMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, "usageThisMinute");
			PowerManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100677914);
			PowerManager.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100677915);
			PowerManager.NativeMethodInfoPtr_DayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100677916);
			PowerManager.NativeMethodInfoPtr_GetTotalUsage_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100677917);
			PowerManager.NativeMethodInfoPtr_ConsumePower_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100677918);
			PowerManager.NativeMethodInfoPtr_CreatePowerLine_Public_PowerLine_PowerNode_PowerNode_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100677919);
			PowerManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100677920);
		}

		// Token: 0x06007442 RID: 29762 RVA: 0x001FB0E4 File Offset: 0x001F92E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227430, XrefRangeEnd = 227468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007443 RID: 29763 RVA: 0x001FB120 File Offset: 0x001F9320
		[CallerCount(0)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007444 RID: 29764 RVA: 0x001FB154 File Offset: 0x001F9354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227468, XrefRangeEnd = 227472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_DayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007445 RID: 29765 RVA: 0x001FB188 File Offset: 0x001F9388
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227492, RefRangeEnd = 227494, XrefRangeStart = 227472, XrefRangeEnd = 227492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalUsage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_GetTotalUsage_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007446 RID: 29766 RVA: 0x001FB1C4 File Offset: 0x001F93C4
		[CallerCount(0)]
		public unsafe void ConsumePower(float kwh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref kwh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_ConsumePower_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x001FB204 File Offset: 0x001F9404
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227514, RefRangeEnd = 227517, XrefRangeStart = 227494, XrefRangeEnd = 227514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerLine CreatePowerLine(PowerNode nodeA, PowerNode nodeB, Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodeA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodeB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_CreatePowerLine_Public_PowerLine_PowerNode_PowerNode_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PowerLine>(intPtr3) : null;
		}

		// Token: 0x06007448 RID: 29768 RVA: 0x001FB278 File Offset: 0x001F9478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227517, XrefRangeEnd = 227527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x00037386 File Offset: 0x00035586
		public PowerManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x0600744A RID: 29770 RVA: 0x001FB2B4 File Offset: 0x001F94B4
		// (set) Token: 0x0600744B RID: 29771 RVA: 0x0003738F File Offset: 0x0003558F
		public unsafe GameObject powerLineSegmentPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_powerLineSegmentPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_powerLineSegmentPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x0600744C RID: 29772 RVA: 0x001FB2E4 File Offset: 0x001F94E4
		// (set) Token: 0x0600744D RID: 29773 RVA: 0x000373AE File Offset: 0x000355AE
		public unsafe static float pricePerkWh
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PowerManager.NativeFieldInfoPtr_pricePerkWh, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerManager.NativeFieldInfoPtr_pricePerkWh, (void*)(&value));
			}
		}

		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x0600744E RID: 29774 RVA: 0x001FB300 File Offset: 0x001F9500
		// (set) Token: 0x0600744F RID: 29775 RVA: 0x000373BC File Offset: 0x000355BC
		public unsafe Dictionary<int, float> usageAtTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_usageAtTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_usageAtTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x06007450 RID: 29776 RVA: 0x001FB330 File Offset: 0x001F9530
		// (set) Token: 0x06007451 RID: 29777 RVA: 0x000373DB File Offset: 0x000355DB
		public unsafe float usageThisMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_usageThisMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_usageThisMinute)) = value;
			}
		}

		// Token: 0x04004F63 RID: 20323
		private static readonly IntPtr NativeFieldInfoPtr_powerLineSegmentPrefab;

		// Token: 0x04004F64 RID: 20324
		private static readonly IntPtr NativeFieldInfoPtr_pricePerkWh;

		// Token: 0x04004F65 RID: 20325
		private static readonly IntPtr NativeFieldInfoPtr_usageAtTime;

		// Token: 0x04004F66 RID: 20326
		private static readonly IntPtr NativeFieldInfoPtr_usageThisMinute;

		// Token: 0x04004F67 RID: 20327
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004F68 RID: 20328
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04004F69 RID: 20329
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Private_Void_0;

		// Token: 0x04004F6A RID: 20330
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalUsage_Public_Single_0;

		// Token: 0x04004F6B RID: 20331
		private static readonly IntPtr NativeMethodInfoPtr_ConsumePower_Public_Void_Single_0;

		// Token: 0x04004F6C RID: 20332
		private static readonly IntPtr NativeMethodInfoPtr_CreatePowerLine_Public_PowerLine_PowerNode_PowerNode_Property_0;

		// Token: 0x04004F6D RID: 20333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
