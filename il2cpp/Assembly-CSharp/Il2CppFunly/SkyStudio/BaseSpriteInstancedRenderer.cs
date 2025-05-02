using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000124 RID: 292
	public class BaseSpriteInstancedRenderer : MonoBehaviour
	{
		// Token: 0x060018D2 RID: 6354 RVA: 0x000BDF84 File Offset: 0x000BC184
		// Note: this type is marked as 'beforefieldinit'.
		static BaseSpriteInstancedRenderer()
		{
			Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BaseSpriteInstancedRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr);
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr_kArrayMaxSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "kArrayMaxSprites");
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr__maxSprites_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "<maxSprites>k__BackingField");
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr_modelMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "modelMesh");
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr_renderMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "renderMaterial");
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_Available = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "m_Available");
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "m_Active");
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_PropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "m_PropertyBlock");
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_ModelMatrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "m_ModelMatrices");
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_StartTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "m_StartTimes");
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_EndTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "m_EndTimes");
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_SpriteSheetLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "m_SpriteSheetLayout");
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_SpriteTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "m_SpriteTexture");
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_TintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "m_TintColor");
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr__m_ViewerCamera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "<m_ViewerCamera>k__BackingField");
			BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_DefaltModelMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, "m_DefaltModelMesh");
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_get_maxSprites_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665937);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_set_maxSprites_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665938);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_get_m_ViewerCamera_Protected_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665939);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_set_m_ViewerCamera_Protected_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665940);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665941);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_CalculateMeshBounds_Protected_Abstract_Virtual_New_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665942);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_CreateSpriteItemData_Protected_Abstract_Virtual_New_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665943);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_IsRenderingEnabled_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665944);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_GetNextSpawnCount_Protected_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665945);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Abstract_Virtual_New_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665946);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Abstract_Virtual_New_Void_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665947);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Abstract_Virtual_New_Void_Int32_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665948);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Abstract_Virtual_New_Void_byref_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665949);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_DequeueNextSpriteItemData_Private_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665950);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_ReturnSpriteItemData_Private_Void_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665951);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665952);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_GenerateNewSprites_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665953);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_AdvanceAllSprites_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665954);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_RenderAllSprites_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665955);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_GetMesh_Protected_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665956);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr_GenerateMesh_Protected_Virtual_New_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665957);
			BaseSpriteInstancedRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr, 100665958);
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060018D3 RID: 6355 RVA: 0x000BE298 File Offset: 0x000BC498
		// (set) Token: 0x060018D4 RID: 6356 RVA: 0x000BE2D4 File Offset: 0x000BC4D4
		public unsafe int maxSprites
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20564, RefRangeEnd = 20565, XrefRangeStart = 20564, XrefRangeEnd = 20565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteInstancedRenderer.NativeMethodInfoPtr_get_maxSprites_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29976, RefRangeEnd = 29977, XrefRangeStart = 29976, XrefRangeEnd = 29977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteInstancedRenderer.NativeMethodInfoPtr_set_maxSprites_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x000BE314 File Offset: 0x000BC514
		// (set) Token: 0x060018D6 RID: 6358 RVA: 0x000BE354 File Offset: 0x000BC554
		public unsafe Camera m_ViewerCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteInstancedRenderer.NativeMethodInfoPtr_get_m_ViewerCamera_Protected_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 95750, RefRangeEnd = 95751, XrefRangeStart = 95749, XrefRangeEnd = 95750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteInstancedRenderer.NativeMethodInfoPtr_set_m_ViewerCamera_Protected_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x000BE398 File Offset: 0x000BC598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95751, XrefRangeEnd = 95761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteInstancedRenderer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x000BE3CC File Offset: 0x000BC5CC
		[CallerCount(0)]
		public unsafe virtual Bounds CalculateMeshBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSpriteInstancedRenderer.NativeMethodInfoPtr_CalculateMeshBounds_Protected_Abstract_Virtual_New_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x000BE414 File Offset: 0x000BC614
		[CallerCount(0)]
		public unsafe virtual BaseSpriteItemData CreateSpriteItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSpriteInstancedRenderer.NativeMethodInfoPtr_CreateSpriteItemData_Protected_Abstract_Virtual_New_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseSpriteItemData>(intPtr3) : null;
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x000BE460 File Offset: 0x000BC660
		[CallerCount(0)]
		public unsafe virtual bool IsRenderingEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSpriteInstancedRenderer.NativeMethodInfoPtr_IsRenderingEnabled_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x000BE4A8 File Offset: 0x000BC6A8
		[CallerCount(0)]
		public unsafe virtual int GetNextSpawnCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSpriteInstancedRenderer.NativeMethodInfoPtr_GetNextSpawnCount_Protected_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x000BE4F0 File Offset: 0x000BC6F0
		[CallerCount(0)]
		public unsafe virtual void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spritePosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteRotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSpriteInstancedRenderer.NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Abstract_Virtual_New_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x000BE568 File Offset: 0x000BC768
		[CallerCount(0)]
		public unsafe virtual void ConfigureSpriteItemData(BaseSpriteItemData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSpriteInstancedRenderer.NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Abstract_Virtual_New_Void_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x000BE5B8 File Offset: 0x000BC7B8
		[CallerCount(0)]
		public unsafe virtual void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref instanceId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSpriteInstancedRenderer.NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Abstract_Virtual_New_Void_Int32_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x000BE614 File Offset: 0x000BC814
		[CallerCount(0)]
		public unsafe virtual void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(propertyBlock);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSpriteInstancedRenderer.NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Abstract_Virtual_New_Void_byref_MaterialPropertyBlock_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			propertyBlock = ((intPtr4 == 0) ? null : new MaterialPropertyBlock(intPtr4));
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x000BE678 File Offset: 0x000BC878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95761, XrefRangeEnd = 95769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseSpriteItemData DequeueNextSpriteItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteInstancedRenderer.NativeMethodInfoPtr_DequeueNextSpriteItemData_Private_BaseSpriteItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseSpriteItemData>(intPtr3) : null;
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x000BE6B8 File Offset: 0x000BC8B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95776, RefRangeEnd = 95777, XrefRangeStart = 95769, XrefRangeEnd = 95776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnSpriteItemData(BaseSpriteItemData splash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(splash);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteInstancedRenderer.NativeMethodInfoPtr_ReturnSpriteItemData_Private_Void_BaseSpriteItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x000BE6FC File Offset: 0x000BC8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95777, XrefRangeEnd = 95782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSpriteInstancedRenderer.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x000BE738 File Offset: 0x000BC938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95793, RefRangeEnd = 95794, XrefRangeStart = 95782, XrefRangeEnd = 95793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateNewSprites()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteInstancedRenderer.NativeMethodInfoPtr_GenerateNewSprites_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x000BE76C File Offset: 0x000BC96C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95816, RefRangeEnd = 95817, XrefRangeStart = 95794, XrefRangeEnd = 95816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdvanceAllSprites()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteInstancedRenderer.NativeMethodInfoPtr_AdvanceAllSprites_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x000BE7A0 File Offset: 0x000BC9A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95892, RefRangeEnd = 95893, XrefRangeStart = 95817, XrefRangeEnd = 95892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderAllSprites()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteInstancedRenderer.NativeMethodInfoPtr_RenderAllSprites_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x000BE7D4 File Offset: 0x000BC9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95893, XrefRangeEnd = 95901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mesh GetMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteInstancedRenderer.NativeMethodInfoPtr_GetMesh_Protected_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x000BE814 File Offset: 0x000BCA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95901, XrefRangeEnd = 95920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Mesh GenerateMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSpriteInstancedRenderer.NativeMethodInfoPtr_GenerateMesh_Protected_Virtual_New_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x000BE860 File Offset: 0x000BCA60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95951, RefRangeEnd = 95953, XrefRangeStart = 95920, XrefRangeEnd = 95951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseSpriteInstancedRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseSpriteInstancedRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteInstancedRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0000E362 File Offset: 0x0000C562
		public BaseSpriteInstancedRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x000BE89C File Offset: 0x000BCA9C
		// (set) Token: 0x060018EB RID: 6379 RVA: 0x0000E36B File Offset: 0x0000C56B
		public unsafe static int kArrayMaxSprites
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_kArrayMaxSprites, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_kArrayMaxSprites, (void*)(&value));
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x000BE8B8 File Offset: 0x000BCAB8
		// (set) Token: 0x060018ED RID: 6381 RVA: 0x0000E379 File Offset: 0x0000C579
		public unsafe int _maxSprites_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr__maxSprites_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr__maxSprites_k__BackingField)) = value;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x000BE8E0 File Offset: 0x000BCAE0
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x0000E394 File Offset: 0x0000C594
		public unsafe Mesh modelMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_modelMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_modelMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x000BE910 File Offset: 0x000BCB10
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x0000E3B3 File Offset: 0x0000C5B3
		public unsafe Material renderMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_renderMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_renderMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x000BE940 File Offset: 0x000BCB40
		// (set) Token: 0x060018F3 RID: 6387 RVA: 0x0000E3D2 File Offset: 0x0000C5D2
		public unsafe Queue<BaseSpriteItemData> m_Available
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_Available);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<BaseSpriteItemData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_Available), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x000BE970 File Offset: 0x000BCB70
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x0000E3F1 File Offset: 0x0000C5F1
		public unsafe HashSet<BaseSpriteItemData> m_Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_Active);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<BaseSpriteItemData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_Active), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x000BE9A0 File Offset: 0x000BCBA0
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x0000E410 File Offset: 0x0000C610
		public unsafe MaterialPropertyBlock m_PropertyBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_PropertyBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_PropertyBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x000BE9D0 File Offset: 0x000BCBD0
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x0000E42F File Offset: 0x0000C62F
		public unsafe Il2CppStructArray<Matrix4x4> m_ModelMatrices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_ModelMatrices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_ModelMatrices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x000BEA00 File Offset: 0x000BCC00
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x0000E44E File Offset: 0x0000C64E
		public unsafe Il2CppStructArray<float> m_StartTimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_StartTimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_StartTimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x000BEA30 File Offset: 0x000BCC30
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x0000E46D File Offset: 0x0000C66D
		public unsafe Il2CppStructArray<float> m_EndTimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_EndTimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_EndTimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x000BEA60 File Offset: 0x000BCC60
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x0000E48C File Offset: 0x0000C68C
		public unsafe SpriteSheetData m_SpriteSheetLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_SpriteSheetLayout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteSheetData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_SpriteSheetLayout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x000BEA90 File Offset: 0x000BCC90
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x0000E4AB File Offset: 0x0000C6AB
		public unsafe Texture m_SpriteTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_SpriteTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_SpriteTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x000BEAC0 File Offset: 0x000BCCC0
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x0000E4CA File Offset: 0x0000C6CA
		public unsafe Color m_TintColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_TintColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_TintColor)) = value;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x000BEAE8 File Offset: 0x000BCCE8
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x0000E4E5 File Offset: 0x0000C6E5
		public unsafe Camera _m_ViewerCamera_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr__m_ViewerCamera_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr__m_ViewerCamera_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x000BEB18 File Offset: 0x000BCD18
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x0000E504 File Offset: 0x0000C704
		public unsafe Mesh m_DefaltModelMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_DefaltModelMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteInstancedRenderer.NativeFieldInfoPtr_m_DefaltModelMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeFieldInfoPtr_kArrayMaxSprites;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeFieldInfoPtr__maxSprites_k__BackingField;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeFieldInfoPtr_modelMesh;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeFieldInfoPtr_renderMaterial;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeFieldInfoPtr_m_Available;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeFieldInfoPtr_m_Active;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyBlock;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeFieldInfoPtr_m_ModelMatrices;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeFieldInfoPtr_m_StartTimes;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeFieldInfoPtr_m_EndTimes;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteSheetLayout;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteTexture;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeFieldInfoPtr_m_TintColor;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeFieldInfoPtr__m_ViewerCamera_k__BackingField;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaltModelMesh;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeMethodInfoPtr_get_maxSprites_Public_get_Int32_0;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeMethodInfoPtr_set_maxSprites_Protected_set_Void_Int32_0;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeMethodInfoPtr_get_m_ViewerCamera_Protected_get_Camera_0;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr_set_m_ViewerCamera_Protected_set_Void_Camera_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_CalculateMeshBounds_Protected_Abstract_Virtual_New_Bounds_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpriteItemData_Protected_Abstract_Virtual_New_BaseSpriteItemData_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderingEnabled_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSpawnCount_Protected_Abstract_Virtual_New_Int32_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Abstract_Virtual_New_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Abstract_Virtual_New_Void_BaseSpriteItemData_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Abstract_Virtual_New_Void_Int32_BaseSpriteItemData_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Abstract_Virtual_New_Void_byref_MaterialPropertyBlock_0;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr_DequeueNextSpriteItemData_Private_BaseSpriteItemData_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_ReturnSpriteItemData_Private_Void_BaseSpriteItemData_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNewSprites_Private_Void_0;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_AdvanceAllSprites_Private_Void_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_RenderAllSprites_Private_Void_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_GetMesh_Protected_Mesh_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMesh_Protected_Virtual_New_Mesh_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
