using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Water
{
	// Token: 0x02000517 RID: 1303
	public class WaterManager : Singleton<WaterManager>
	{
		// Token: 0x06007405 RID: 29701 RVA: 0x001FA394 File Offset: 0x001F8594
		// Note: this type is marked as 'beforefieldinit'.
		static WaterManager()
		{
			Il2CppClassPointerStore<WaterManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Water", "WaterManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterManager>.NativeClassPtr);
			WaterManager.NativeFieldInfoPtr_waterPipePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, "waterPipePrefab");
			WaterManager.NativeFieldInfoPtr_pricePerL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, "pricePerL");
			WaterManager.NativeFieldInfoPtr_usageAtTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, "usageAtTime");
			WaterManager.NativeFieldInfoPtr_usageThisMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, "usageThisMinute");
			WaterManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100677888);
			WaterManager.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100677889);
			WaterManager.NativeMethodInfoPtr_DayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100677890);
			WaterManager.NativeMethodInfoPtr_GetTotalUsage_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100677891);
			WaterManager.NativeMethodInfoPtr_ConsumeWater_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100677892);
			WaterManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100677893);
		}

		// Token: 0x06007406 RID: 29702 RVA: 0x001FA48C File Offset: 0x001F868C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226956, XrefRangeEnd = 226994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007407 RID: 29703 RVA: 0x001FA4C8 File Offset: 0x001F86C8
		[CallerCount(0)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007408 RID: 29704 RVA: 0x001FA4FC File Offset: 0x001F86FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226994, XrefRangeEnd = 226998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr_DayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007409 RID: 29705 RVA: 0x001FA530 File Offset: 0x001F8730
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227018, RefRangeEnd = 227020, XrefRangeStart = 226998, XrefRangeEnd = 227018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalUsage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr_GetTotalUsage_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600740A RID: 29706 RVA: 0x001FA56C File Offset: 0x001F876C
		[CallerCount(0)]
		public unsafe void ConsumeWater(float litres)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref litres;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr_ConsumeWater_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600740B RID: 29707 RVA: 0x001FA5AC File Offset: 0x001F87AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227020, XrefRangeEnd = 227030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600740C RID: 29708 RVA: 0x000371F1 File Offset: 0x000353F1
		public WaterManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x0600740D RID: 29709 RVA: 0x001FA5E8 File Offset: 0x001F87E8
		// (set) Token: 0x0600740E RID: 29710 RVA: 0x000371FA File Offset: 0x000353FA
		public unsafe GameObject waterPipePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_waterPipePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_waterPipePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x0600740F RID: 29711 RVA: 0x001FA618 File Offset: 0x001F8818
		// (set) Token: 0x06007410 RID: 29712 RVA: 0x00037219 File Offset: 0x00035419
		public unsafe static float pricePerL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WaterManager.NativeFieldInfoPtr_pricePerL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaterManager.NativeFieldInfoPtr_pricePerL, (void*)(&value));
			}
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x06007411 RID: 29713 RVA: 0x001FA634 File Offset: 0x001F8834
		// (set) Token: 0x06007412 RID: 29714 RVA: 0x00037227 File Offset: 0x00035427
		public unsafe Dictionary<int, float> usageAtTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_usageAtTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_usageAtTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x06007413 RID: 29715 RVA: 0x001FA664 File Offset: 0x001F8864
		// (set) Token: 0x06007414 RID: 29716 RVA: 0x00037246 File Offset: 0x00035446
		public unsafe float usageThisMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_usageThisMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_usageThisMinute)) = value;
			}
		}

		// Token: 0x04004F3B RID: 20283
		private static readonly IntPtr NativeFieldInfoPtr_waterPipePrefab;

		// Token: 0x04004F3C RID: 20284
		private static readonly IntPtr NativeFieldInfoPtr_pricePerL;

		// Token: 0x04004F3D RID: 20285
		private static readonly IntPtr NativeFieldInfoPtr_usageAtTime;

		// Token: 0x04004F3E RID: 20286
		private static readonly IntPtr NativeFieldInfoPtr_usageThisMinute;

		// Token: 0x04004F3F RID: 20287
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004F40 RID: 20288
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04004F41 RID: 20289
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Private_Void_0;

		// Token: 0x04004F42 RID: 20290
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalUsage_Public_Single_0;

		// Token: 0x04004F43 RID: 20291
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeWater_Public_Void_Single_0;

		// Token: 0x04004F44 RID: 20292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
