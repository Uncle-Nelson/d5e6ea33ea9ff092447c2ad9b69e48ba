using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200007B RID: 123
	public class BeamGeometryAbstractBase : MonoBehaviour
	{
		// Token: 0x060008A8 RID: 2216 RVA: 0x0008B2D4 File Offset: 0x000894D4
		// Note: this type is marked as 'beforefieldinit'.
		static BeamGeometryAbstractBase()
		{
			Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "BeamGeometryAbstractBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr);
			BeamGeometryAbstractBase.NativeFieldInfoPtr__meshRenderer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "<meshRenderer>k__BackingField");
			BeamGeometryAbstractBase.NativeFieldInfoPtr__meshFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "<meshFilter>k__BackingField");
			BeamGeometryAbstractBase.NativeFieldInfoPtr__coneMesh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "<coneMesh>k__BackingField");
			BeamGeometryAbstractBase.NativeFieldInfoPtr_m_ColorGradientMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "m_ColorGradientMatrix");
			BeamGeometryAbstractBase.NativeFieldInfoPtr_m_CustomMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "m_CustomMaterial");
			BeamGeometryAbstractBase.NativeMethodInfoPtr_get_meshRenderer_Public_get_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664222);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_set_meshRenderer_Protected_set_Void_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664223);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664224);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_set_meshFilter_Protected_set_Void_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664225);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_get_coneMesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664226);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_set_coneMesh_Protected_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664227);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_GetMaster_Protected_Abstract_Virtual_New_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664228);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664229);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664230);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_DestroyInvalidOwner_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664231);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_DestroyBeamGeometryGameObject_Public_Static_Void_BeamGeometryAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664232);
			BeamGeometryAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100664233);
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0008B458 File Offset: 0x00089658
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x0008B498 File Offset: 0x00089698
		public unsafe MeshRenderer meshRenderer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_get_meshRenderer_Public_get_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_set_meshRenderer_Protected_set_Void_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x0008B4DC File Offset: 0x000896DC
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x0008B51C File Offset: 0x0008971C
		public unsafe MeshFilter meshFilter
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_set_meshFilter_Protected_set_Void_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x0008B560 File Offset: 0x00089760
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x0008B5A0 File Offset: 0x000897A0
		public unsafe Mesh coneMesh
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_get_coneMesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_set_coneMesh_Protected_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0008B5E4 File Offset: 0x000897E4
		[CallerCount(0)]
		public unsafe virtual VolumetricLightBeamAbstractBase GetMaster()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BeamGeometryAbstractBase.NativeMethodInfoPtr_GetMaster_Protected_Abstract_Virtual_New_VolumetricLightBeamAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr3) : null;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0008B630 File Offset: 0x00089830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79564, XrefRangeEnd = 79576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0008B664 File Offset: 0x00089864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79576, XrefRangeEnd = 79584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0008B698 File Offset: 0x00089898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyInvalidOwner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_DestroyInvalidOwner_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0008B6CC File Offset: 0x000898CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79592, RefRangeEnd = 79594, XrefRangeStart = 79584, XrefRangeEnd = 79592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyBeamGeometryGameObject(BeamGeometryAbstractBase beamGeom)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beamGeom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_DestroyBeamGeometryGameObject_Public_Static_Void_BeamGeometryAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0008B704 File Offset: 0x00089904
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeamGeometryAbstractBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00006AC6 File Offset: 0x00004CC6
		public BeamGeometryAbstractBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x0008B740 File Offset: 0x00089940
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00006ACF File Offset: 0x00004CCF
		public unsafe MeshRenderer _meshRenderer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__meshRenderer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__meshRenderer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0008B770 File Offset: 0x00089970
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00006AEE File Offset: 0x00004CEE
		public unsafe MeshFilter _meshFilter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__meshFilter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__meshFilter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0008B7A0 File Offset: 0x000899A0
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x00006B0D File Offset: 0x00004D0D
		public unsafe Mesh _coneMesh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__coneMesh_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__coneMesh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0008B7D0 File Offset: 0x000899D0
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00006B2C File Offset: 0x00004D2C
		public unsafe Matrix4x4 m_ColorGradientMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr_m_ColorGradientMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr_m_ColorGradientMatrix)) = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0008B7F8 File Offset: 0x000899F8
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x00006B47 File Offset: 0x00004D47
		public unsafe Material m_CustomMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr_m_CustomMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr_m_CustomMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeFieldInfoPtr__meshRenderer_k__BackingField;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeFieldInfoPtr__meshFilter_k__BackingField;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr__coneMesh_k__BackingField;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGradientMatrix;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomMaterial;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_get_meshRenderer_Public_get_MeshRenderer_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_set_meshRenderer_Protected_set_Void_MeshRenderer_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_set_meshFilter_Protected_set_Void_MeshFilter_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_get_coneMesh_Public_get_Mesh_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_set_coneMesh_Protected_set_Void_Mesh_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_GetMaster_Protected_Abstract_Virtual_New_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_DestroyInvalidOwner_Private_Void_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBeamGeometryGameObject_Public_Static_Void_BeamGeometryAbstractBase_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
