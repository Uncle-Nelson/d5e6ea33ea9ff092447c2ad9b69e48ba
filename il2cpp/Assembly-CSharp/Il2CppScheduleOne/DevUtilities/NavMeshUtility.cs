using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200045D RID: 1117
	public static class NavMeshUtility : Il2CppSystem.Object
	{
		// Token: 0x060060F4 RID: 24820 RVA: 0x001BAD64 File Offset: 0x001B8F64
		// Note: this type is marked as 'beforefieldinit'.
		static NavMeshUtility()
		{
			Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "NavMeshUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr);
			NavMeshUtility.NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "SAMPLE_MAX_DISTANCE");
			NavMeshUtility.NativeFieldInfoPtr_SampleCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "SampleCache");
			NavMeshUtility.NativeFieldInfoPtr_sampleCacheKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "sampleCacheKeys");
			NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "SAMPLE_CACHE_MAX_SQR_DIST");
			NavMeshUtility.NativeFieldInfoPtr_MAX_CACHE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "MAX_CACHE_SIZE");
			NavMeshUtility.NativeMethodInfoPtr_GetPathLength_Public_Static_Single_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675627);
			NavMeshUtility.NativeMethodInfoPtr_GetAccessPoint_Public_Static_Transform_ITransitEntity_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675628);
			NavMeshUtility.NativeMethodInfoPtr_IsAtTransitEntity_Public_Static_Boolean_ITransitEntity_NPC_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675629);
			NavMeshUtility.NativeMethodInfoPtr_GetNavMeshAgentID_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675630);
			NavMeshUtility.NativeMethodInfoPtr_SamplePosition_Public_Static_Boolean_Vector3_byref_NavMeshHit_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675631);
			NavMeshUtility.NativeMethodInfoPtr_Quantize_Private_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675632);
			NavMeshUtility.NativeMethodInfoPtr_ClearCache_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675633);
		}

		// Token: 0x060060F5 RID: 24821 RVA: 0x001BAE84 File Offset: 0x001B9084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199739, XrefRangeEnd = 199748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPathLength(NavMeshPath path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_GetPathLength_Public_Static_Single_NavMeshPath_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060F6 RID: 24822 RVA: 0x001BAEC8 File Offset: 0x001B90C8
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 199786, RefRangeEnd = 199811, XrefRangeStart = 199748, XrefRangeEnd = 199786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform GetAccessPoint(ITransitEntity entity, NPC npc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_GetAccessPoint_Public_Static_Transform_ITransitEntity_NPC_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060060F7 RID: 24823 RVA: 0x001BAF20 File Offset: 0x001B9120
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 199832, RefRangeEnd = 199837, XrefRangeStart = 199811, XrefRangeEnd = 199832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAtTransitEntity(ITransitEntity entity, NPC npc, float distanceThreshold = 0.4f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_IsAtTransitEntity_Public_Static_Boolean_ITransitEntity_NPC_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x001BAF84 File Offset: 0x001B9184
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199843, RefRangeEnd = 199846, XrefRangeStart = 199837, XrefRangeEnd = 199843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNavMeshAgentID(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_GetNavMeshAgentID_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060F9 RID: 24825 RVA: 0x001BAFC8 File Offset: 0x001B91C8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 199870, RefRangeEnd = 199878, XrefRangeStart = 199846, XrefRangeEnd = 199870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask, bool useCache = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sourcePosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref areaMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCache;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_SamplePosition_Public_Static_Boolean_Vector3_byref_NavMeshHit_Single_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060FA RID: 24826 RVA: 0x001BB040 File Offset: 0x001B9240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199878, XrefRangeEnd = 199881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Quantize(Vector3 position, float precision = 0.1f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_Quantize_Private_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x001BB08C File Offset: 0x001B928C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199890, RefRangeEnd = 199891, XrefRangeStart = 199881, XrefRangeEnd = 199890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCache()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_ClearCache_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060FC RID: 24828 RVA: 0x0002DD6C File Offset: 0x0002BF6C
		public NavMeshUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x060060FD RID: 24829 RVA: 0x001BB0B4 File Offset: 0x001B92B4
		// (set) Token: 0x060060FE RID: 24830 RVA: 0x0002DD75 File Offset: 0x0002BF75
		public unsafe static float SAMPLE_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x060060FF RID: 24831 RVA: 0x001BB0D0 File Offset: 0x001B92D0
		// (set) Token: 0x06006100 RID: 24832 RVA: 0x0002DD83 File Offset: 0x0002BF83
		public unsafe static Dictionary<Vector3, Vector3> SampleCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_SampleCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector3, Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_SampleCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x06006101 RID: 24833 RVA: 0x001BB0F8 File Offset: 0x001B92F8
		// (set) Token: 0x06006102 RID: 24834 RVA: 0x0002DD95 File Offset: 0x0002BF95
		public unsafe static List<Vector3> sampleCacheKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_sampleCacheKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_sampleCacheKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x06006103 RID: 24835 RVA: 0x001BB120 File Offset: 0x001B9320
		// (set) Token: 0x06006104 RID: 24836 RVA: 0x0002DDA7 File Offset: 0x0002BFA7
		public unsafe static float SAMPLE_CACHE_MAX_SQR_DIST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST, (void*)(&value));
			}
		}

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x06006105 RID: 24837 RVA: 0x001BB13C File Offset: 0x001B933C
		// (set) Token: 0x06006106 RID: 24838 RVA: 0x0002DDB5 File Offset: 0x0002BFB5
		public unsafe static float MAX_CACHE_SIZE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_MAX_CACHE_SIZE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_MAX_CACHE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x0400422B RID: 16939
		private static readonly IntPtr NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE;

		// Token: 0x0400422C RID: 16940
		private static readonly IntPtr NativeFieldInfoPtr_SampleCache;

		// Token: 0x0400422D RID: 16941
		private static readonly IntPtr NativeFieldInfoPtr_sampleCacheKeys;

		// Token: 0x0400422E RID: 16942
		private static readonly IntPtr NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST;

		// Token: 0x0400422F RID: 16943
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CACHE_SIZE;

		// Token: 0x04004230 RID: 16944
		private static readonly IntPtr NativeMethodInfoPtr_GetPathLength_Public_Static_Single_NavMeshPath_0;

		// Token: 0x04004231 RID: 16945
		private static readonly IntPtr NativeMethodInfoPtr_GetAccessPoint_Public_Static_Transform_ITransitEntity_NPC_0;

		// Token: 0x04004232 RID: 16946
		private static readonly IntPtr NativeMethodInfoPtr_IsAtTransitEntity_Public_Static_Boolean_ITransitEntity_NPC_Single_0;

		// Token: 0x04004233 RID: 16947
		private static readonly IntPtr NativeMethodInfoPtr_GetNavMeshAgentID_Public_Static_Int32_String_0;

		// Token: 0x04004234 RID: 16948
		private static readonly IntPtr NativeMethodInfoPtr_SamplePosition_Public_Static_Boolean_Vector3_byref_NavMeshHit_Single_Int32_Boolean_0;

		// Token: 0x04004235 RID: 16949
		private static readonly IntPtr NativeMethodInfoPtr_Quantize_Private_Static_Vector3_Vector3_Single_0;

		// Token: 0x04004236 RID: 16950
		private static readonly IntPtr NativeMethodInfoPtr_ClearCache_Public_Static_Void_0;
	}
}
