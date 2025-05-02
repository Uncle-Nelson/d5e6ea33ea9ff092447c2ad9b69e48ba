using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000B3 RID: 179
	public class TriggerZone : MonoBehaviour
	{
		// Token: 0x06000D39 RID: 3385 RVA: 0x0009AC24 File Offset: 0x00098E24
		// Note: this type is marked as 'beforefieldinit'.
		static TriggerZone()
		{
			Il2CppClassPointerStore<TriggerZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "TriggerZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr);
			TriggerZone.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "ClassName");
			TriggerZone.NativeFieldInfoPtr_setIsTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "setIsTrigger");
			TriggerZone.NativeFieldInfoPtr_rangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "rangeMultiplier");
			TriggerZone.NativeFieldInfoPtr_kMeshColliderNumSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "kMeshColliderNumSides");
			TriggerZone.NativeFieldInfoPtr_m_Beam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "m_Beam");
			TriggerZone.NativeFieldInfoPtr_m_DynamicOcclusionRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "m_DynamicOcclusionRaycasting");
			TriggerZone.NativeFieldInfoPtr_m_PolygonCollider2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "m_PolygonCollider2D");
			TriggerZone.NativeMethodInfoPtr_get_updateRate_Private_get_TriggerZoneUpdateRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664913);
			TriggerZone.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664914);
			TriggerZone.NativeMethodInfoPtr_OnOcclusionProcessed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664915);
			TriggerZone.NativeMethodInfoPtr_ComputeZone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664916);
			TriggerZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664917);
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x0009AD44 File Offset: 0x00098F44
		public unsafe TriggerZone.TriggerZoneUpdateRate updateRate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84491, XrefRangeEnd = 84496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr_get_updateRate_Private_get_TriggerZoneUpdateRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0009AD80 File Offset: 0x00098F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84496, XrefRangeEnd = 84523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x0009ADB4 File Offset: 0x00098FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84523, XrefRangeEnd = 84524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOcclusionProcessed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr_OnOcclusionProcessed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x0009ADE8 File Offset: 0x00098FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84562, RefRangeEnd = 84563, XrefRangeStart = 84524, XrefRangeEnd = 84562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeZone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr_ComputeZone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x0009AE1C File Offset: 0x0009901C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84563, XrefRangeEnd = 84564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TriggerZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x000087E3 File Offset: 0x000069E3
		public TriggerZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0009AE58 File Offset: 0x00099058
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x000087EC File Offset: 0x000069EC
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TriggerZone.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TriggerZone.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x0009AE78 File Offset: 0x00099078
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x000087FE File Offset: 0x000069FE
		public unsafe bool setIsTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_setIsTrigger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_setIsTrigger)) = value;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0009AEA0 File Offset: 0x000990A0
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x00008819 File Offset: 0x00006A19
		public unsafe float rangeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_rangeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_rangeMultiplier)) = value;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x0009AEC8 File Offset: 0x000990C8
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x00008834 File Offset: 0x00006A34
		public unsafe static int kMeshColliderNumSides
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TriggerZone.NativeFieldInfoPtr_kMeshColliderNumSides, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TriggerZone.NativeFieldInfoPtr_kMeshColliderNumSides, (void*)(&value));
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x0009AEE4 File Offset: 0x000990E4
		// (set) Token: 0x06000D49 RID: 3401 RVA: 0x00008842 File Offset: 0x00006A42
		public unsafe VolumetricLightBeamAbstractBase m_Beam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_Beam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_Beam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x0009AF14 File Offset: 0x00099114
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x00008861 File Offset: 0x00006A61
		public unsafe DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_DynamicOcclusionRaycasting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicOcclusionRaycasting>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_DynamicOcclusionRaycasting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x0009AF44 File Offset: 0x00099144
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x00008880 File Offset: 0x00006A80
		public unsafe PolygonCollider2D m_PolygonCollider2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_PolygonCollider2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_PolygonCollider2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeFieldInfoPtr_setIsTrigger;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeFieldInfoPtr_rangeMultiplier;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_kMeshColliderNumSides;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_m_Beam;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_m_DynamicOcclusionRaycasting;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_m_PolygonCollider2D;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeMethodInfoPtr_get_updateRate_Private_get_TriggerZoneUpdateRate_0;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeMethodInfoPtr_OnOcclusionProcessed_Private_Void_0;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeMethodInfoPtr_ComputeZone_Private_Void_0;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200083D RID: 2109
		[OriginalName("Assembly-CSharp.dll", "", "TriggerZoneUpdateRate")]
		public enum TriggerZoneUpdateRate
		{
			// Token: 0x040081C9 RID: 33225
			OnEnable,
			// Token: 0x040081CA RID: 33226
			OnOcclusionChange
		}
	}
}
