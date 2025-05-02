using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000047 RID: 71
	public class RenderPipelineLighting : MonoBehaviour
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x00082394 File Offset: 0x00080594
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPipelineLighting()
		{
			Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RenderPipelineLighting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr);
			RenderPipelineLighting.NativeFieldInfoPtr__standardLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr, "_standardLighting");
			RenderPipelineLighting.NativeFieldInfoPtr__standardSky = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr, "_standardSky");
			RenderPipelineLighting.NativeFieldInfoPtr__standardTerrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr, "_standardTerrain");
			RenderPipelineLighting.NativeFieldInfoPtr__universalLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr, "_universalLighting");
			RenderPipelineLighting.NativeFieldInfoPtr__universalSky = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr, "_universalSky");
			RenderPipelineLighting.NativeFieldInfoPtr__universalTerrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr, "_universalTerrain");
			RenderPipelineLighting.NativeFieldInfoPtr__highDefinitionLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr, "_highDefinitionLighting");
			RenderPipelineLighting.NativeFieldInfoPtr__highDefinitionSky = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr, "_highDefinitionSky");
			RenderPipelineLighting.NativeFieldInfoPtr__highDefinitionTerrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr, "_highDefinitionTerrain");
			RenderPipelineLighting.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr, 100663860);
			RenderPipelineLighting.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr, 100663861);
			RenderPipelineLighting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr, 100663862);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x000824B4 File Offset: 0x000806B4
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineLighting.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x000824E8 File Offset: 0x000806E8
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineLighting.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0008251C File Offset: 0x0008071C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderPipelineLighting() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipelineLighting>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineLighting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00005850 File Offset: 0x00003A50
		public RenderPipelineLighting(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00082558 File Offset: 0x00080758
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x00005859 File Offset: 0x00003A59
		public unsafe GameObject _standardLighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__standardLighting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__standardLighting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00082588 File Offset: 0x00080788
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x00005878 File Offset: 0x00003A78
		public unsafe Material _standardSky
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__standardSky);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__standardSky), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x000825B8 File Offset: 0x000807B8
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x00005897 File Offset: 0x00003A97
		public unsafe Material _standardTerrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__standardTerrain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__standardTerrain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x000825E8 File Offset: 0x000807E8
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x000058B6 File Offset: 0x00003AB6
		public unsafe GameObject _universalLighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__universalLighting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__universalLighting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00082618 File Offset: 0x00080818
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x000058D5 File Offset: 0x00003AD5
		public unsafe Material _universalSky
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__universalSky);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__universalSky), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00082648 File Offset: 0x00080848
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x000058F4 File Offset: 0x00003AF4
		public unsafe Material _universalTerrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__universalTerrain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__universalTerrain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x00082678 File Offset: 0x00080878
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00005913 File Offset: 0x00003B13
		public unsafe GameObject _highDefinitionLighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__highDefinitionLighting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__highDefinitionLighting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x000826A8 File Offset: 0x000808A8
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x00005932 File Offset: 0x00003B32
		public unsafe Material _highDefinitionSky
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__highDefinitionSky);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__highDefinitionSky), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x000826D8 File Offset: 0x000808D8
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x00005951 File Offset: 0x00003B51
		public unsafe Material _highDefinitionTerrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__highDefinitionTerrain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipelineLighting.NativeFieldInfoPtr__highDefinitionTerrain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeFieldInfoPtr__standardLighting;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeFieldInfoPtr__standardSky;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeFieldInfoPtr__standardTerrain;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeFieldInfoPtr__universalLighting;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeFieldInfoPtr__universalSky;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeFieldInfoPtr__universalTerrain;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeFieldInfoPtr__highDefinitionLighting;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeFieldInfoPtr__highDefinitionSky;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeFieldInfoPtr__highDefinitionTerrain;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
