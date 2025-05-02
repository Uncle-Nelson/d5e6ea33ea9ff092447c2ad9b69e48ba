using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020004FD RID: 1277
	public class FunnelZone : MonoBehaviour
	{
		// Token: 0x060070CE RID: 28878 RVA: 0x001EF920 File Offset: 0x001EDB20
		// Note: this type is marked as 'beforefieldinit'.
		static FunnelZone()
		{
			Il2CppClassPointerStore<FunnelZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "FunnelZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr);
			FunnelZone.NativeFieldInfoPtr_funnelZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, "funnelZones");
			FunnelZone.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, "col");
			FunnelZone.NativeFieldInfoPtr_entryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, "entryPoint");
			FunnelZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100677462);
			FunnelZone.NativeMethodInfoPtr_GetFunnelZone_Public_Static_FunnelZone_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100677463);
			FunnelZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100677464);
			FunnelZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100677465);
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x001EF9DC File Offset: 0x001EDBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221991, XrefRangeEnd = 222001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunnelZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x001EFA18 File Offset: 0x001EDC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222001, XrefRangeEnd = 222019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FunnelZone GetFunnelZone(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunnelZone.NativeMethodInfoPtr_GetFunnelZone_Public_Static_FunnelZone_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FunnelZone>(intPtr3) : null;
		}

		// Token: 0x060070D1 RID: 28881 RVA: 0x001EFA58 File Offset: 0x001EDC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222019, XrefRangeEnd = 222031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunnelZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070D2 RID: 28882 RVA: 0x001EFA8C File Offset: 0x001EDC8C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunnelZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunnelZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070D3 RID: 28883 RVA: 0x00035940 File Offset: 0x00033B40
		public FunnelZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x060070D4 RID: 28884 RVA: 0x001EFAC8 File Offset: 0x001EDCC8
		// (set) Token: 0x060070D5 RID: 28885 RVA: 0x00035949 File Offset: 0x00033B49
		public unsafe static List<FunnelZone> funnelZones
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FunnelZone.NativeFieldInfoPtr_funnelZones, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunnelZone>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FunnelZone.NativeFieldInfoPtr_funnelZones, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x060070D6 RID: 28886 RVA: 0x001EFAF0 File Offset: 0x001EDCF0
		// (set) Token: 0x060070D7 RID: 28887 RVA: 0x0003595B File Offset: 0x00033B5B
		public unsafe BoxCollider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x060070D8 RID: 28888 RVA: 0x001EFB20 File Offset: 0x001EDD20
		// (set) Token: 0x060070D9 RID: 28889 RVA: 0x0003597A File Offset: 0x00033B7A
		public unsafe Transform entryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_entryPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_entryPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D13 RID: 19731
		private static readonly IntPtr NativeFieldInfoPtr_funnelZones;

		// Token: 0x04004D14 RID: 19732
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04004D15 RID: 19733
		private static readonly IntPtr NativeFieldInfoPtr_entryPoint;

		// Token: 0x04004D16 RID: 19734
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004D17 RID: 19735
		private static readonly IntPtr NativeMethodInfoPtr_GetFunnelZone_Public_Static_FunnelZone_Vector3_0;

		// Token: 0x04004D18 RID: 19736
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004D19 RID: 19737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
