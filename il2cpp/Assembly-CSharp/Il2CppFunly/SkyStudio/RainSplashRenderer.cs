using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200012C RID: 300
	public class RainSplashRenderer : BaseSpriteInstancedRenderer
	{
		// Token: 0x0600198E RID: 6542 RVA: 0x000C0718 File Offset: 0x000BE918
		// Note: this type is marked as 'beforefieldinit'.
		static RainSplashRenderer()
		{
			Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RainSplashRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr);
			RainSplashRenderer.NativeFieldInfoPtr_m_DepthCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_DepthCamera");
			RainSplashRenderer.NativeFieldInfoPtr_m_StartSplashYPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_StartSplashYPositions");
			RainSplashRenderer.NativeFieldInfoPtr_m_DepthUs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_DepthUs");
			RainSplashRenderer.NativeFieldInfoPtr_m_DepthVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_DepthVs");
			RainSplashRenderer.NativeFieldInfoPtr_m_SplashAreaStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_SplashAreaStart");
			RainSplashRenderer.NativeFieldInfoPtr_m_SplashAreaLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_SplashAreaLength");
			RainSplashRenderer.NativeFieldInfoPtr_m_SplashScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_SplashScale");
			RainSplashRenderer.NativeFieldInfoPtr_m_SplashScaleVarience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_SplashScaleVarience");
			RainSplashRenderer.NativeFieldInfoPtr_m_SplashItensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_SplashItensity");
			RainSplashRenderer.NativeFieldInfoPtr_m_SplashSurfaceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_SplashSurfaceOffset");
			RainSplashRenderer.NativeFieldInfoPtr_m_SkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_SkyProfile");
			RainSplashRenderer.NativeFieldInfoPtr_m_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_TimeOfDay");
			RainSplashRenderer.NativeFieldInfoPtr_m_Style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_Style");
			RainSplashRenderer.NativeFieldInfoPtr_m_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_Bounds");
			RainSplashRenderer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666016);
			RainSplashRenderer.NativeMethodInfoPtr_CalculateMeshBounds_Protected_Virtual_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666017);
			RainSplashRenderer.NativeMethodInfoPtr_CreateSpriteItemData_Protected_Virtual_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666018);
			RainSplashRenderer.NativeMethodInfoPtr_IsRenderingEnabled_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666019);
			RainSplashRenderer.NativeMethodInfoPtr_GetNextSpawnCount_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666020);
			RainSplashRenderer.NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Virtual_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666021);
			RainSplashRenderer.NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Virtual_Void_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666022);
			RainSplashRenderer.NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Virtual_Void_Int32_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666023);
			RainSplashRenderer.NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Virtual_Void_byref_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666024);
			RainSplashRenderer.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_RainSplashArtItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666025);
			RainSplashRenderer.NativeMethodInfoPtr_SyncDataFromSkyProfile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666026);
			RainSplashRenderer.NativeMethodInfoPtr_CreateWorldSplashPoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666027);
			RainSplashRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666028);
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x000C0964 File Offset: 0x000BEB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96512, XrefRangeEnd = 96538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashRenderer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x000C0998 File Offset: 0x000BEB98
		[CallerCount(0)]
		public unsafe override Bounds CalculateMeshBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_CalculateMeshBounds_Protected_Virtual_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x000C09E0 File Offset: 0x000BEBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96538, XrefRangeEnd = 96542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BaseSpriteItemData CreateSpriteItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_CreateSpriteItemData_Protected_Virtual_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseSpriteItemData>(intPtr3) : null;
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x000C0A2C File Offset: 0x000BEC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96542, XrefRangeEnd = 96554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsRenderingEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_IsRenderingEnabled_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x000C0A74 File Offset: 0x000BEC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96554, XrefRangeEnd = 96555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetNextSpawnCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_GetNextSpawnCount_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x000C0ABC File Offset: 0x000BECBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96555, XrefRangeEnd = 96558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spritePosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteRotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Virtual_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x000C0B34 File Offset: 0x000BED34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96558, XrefRangeEnd = 96568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConfigureSpriteItemData(BaseSpriteItemData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Virtual_Void_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x000C0B84 File Offset: 0x000BED84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96568, XrefRangeEnd = 96574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref instanceId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Virtual_Void_Int32_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x000C0BE0 File Offset: 0x000BEDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96574, XrefRangeEnd = 96590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(propertyBlock);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Virtual_Void_byref_MaterialPropertyBlock_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			propertyBlock = ((intPtr4 == 0) ? null : new MaterialPropertyBlock(intPtr4));
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x000C0C44 File Offset: 0x000BEE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96590, XrefRangeEnd = 96597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, RainSplashArtItem style)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skyProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashRenderer.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_RainSplashArtItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x000C0CA8 File Offset: 0x000BEEA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96624, RefRangeEnd = 96626, XrefRangeStart = 96597, XrefRangeEnd = 96624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncDataFromSkyProfile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashRenderer.NativeMethodInfoPtr_SyncDataFromSkyProfile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x000C0CDC File Offset: 0x000BEEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96626, XrefRangeEnd = 96635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 CreateWorldSplashPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashRenderer.NativeMethodInfoPtr_CreateWorldSplashPoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x000C0D18 File Offset: 0x000BEF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96635, XrefRangeEnd = 96648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RainSplashRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		public RainSplashRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x000C0D54 File Offset: 0x000BEF54
		// (set) Token: 0x0600199E RID: 6558 RVA: 0x0000E8E9 File Offset: 0x0000CAE9
		public unsafe Camera m_DepthCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_DepthCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_DepthCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x000C0D84 File Offset: 0x000BEF84
		// (set) Token: 0x060019A0 RID: 6560 RVA: 0x0000E908 File Offset: 0x0000CB08
		public unsafe Il2CppStructArray<float> m_StartSplashYPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_StartSplashYPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_StartSplashYPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x000C0DB4 File Offset: 0x000BEFB4
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x0000E927 File Offset: 0x0000CB27
		public unsafe Il2CppStructArray<float> m_DepthUs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_DepthUs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_DepthUs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x000C0DE4 File Offset: 0x000BEFE4
		// (set) Token: 0x060019A4 RID: 6564 RVA: 0x0000E946 File Offset: 0x0000CB46
		public unsafe Il2CppStructArray<float> m_DepthVs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_DepthVs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_DepthVs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x000C0E14 File Offset: 0x000BF014
		// (set) Token: 0x060019A6 RID: 6566 RVA: 0x0000E965 File Offset: 0x0000CB65
		public unsafe float m_SplashAreaStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashAreaStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashAreaStart)) = value;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x000C0E3C File Offset: 0x000BF03C
		// (set) Token: 0x060019A8 RID: 6568 RVA: 0x0000E980 File Offset: 0x0000CB80
		public unsafe float m_SplashAreaLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashAreaLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashAreaLength)) = value;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x000C0E64 File Offset: 0x000BF064
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x0000E99B File Offset: 0x0000CB9B
		public unsafe float m_SplashScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashScale)) = value;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x000C0E8C File Offset: 0x000BF08C
		// (set) Token: 0x060019AC RID: 6572 RVA: 0x0000E9B6 File Offset: 0x0000CBB6
		public unsafe float m_SplashScaleVarience
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashScaleVarience);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashScaleVarience)) = value;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x000C0EB4 File Offset: 0x000BF0B4
		// (set) Token: 0x060019AE RID: 6574 RVA: 0x0000E9D1 File Offset: 0x0000CBD1
		public unsafe float m_SplashItensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashItensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashItensity)) = value;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x060019AF RID: 6575 RVA: 0x000C0EDC File Offset: 0x000BF0DC
		// (set) Token: 0x060019B0 RID: 6576 RVA: 0x0000E9EC File Offset: 0x0000CBEC
		public unsafe float m_SplashSurfaceOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashSurfaceOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashSurfaceOffset)) = value;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x000C0F04 File Offset: 0x000BF104
		// (set) Token: 0x060019B2 RID: 6578 RVA: 0x0000EA07 File Offset: 0x0000CC07
		public unsafe SkyProfile m_SkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x000C0F34 File Offset: 0x000BF134
		// (set) Token: 0x060019B4 RID: 6580 RVA: 0x0000EA26 File Offset: 0x0000CC26
		public unsafe float m_TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_TimeOfDay)) = value;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x000C0F5C File Offset: 0x000BF15C
		// (set) Token: 0x060019B6 RID: 6582 RVA: 0x0000EA41 File Offset: 0x0000CC41
		public unsafe RainSplashArtItem m_Style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_Style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RainSplashArtItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_Style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x000C0F8C File Offset: 0x000BF18C
		// (set) Token: 0x060019B8 RID: 6584 RVA: 0x0000EA60 File Offset: 0x0000CC60
		public unsafe Bounds m_Bounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_Bounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_Bounds)) = value;
			}
		}

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthCamera;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeFieldInfoPtr_m_StartSplashYPositions;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthUs;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthVs;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeFieldInfoPtr_m_SplashAreaStart;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeFieldInfoPtr_m_SplashAreaLength;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeFieldInfoPtr_m_SplashScale;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeFieldInfoPtr_m_SplashScaleVarience;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeFieldInfoPtr_m_SplashItensity;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeFieldInfoPtr_m_SplashSurfaceOffset;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyProfile;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeOfDay;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeFieldInfoPtr_m_Style;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeFieldInfoPtr_m_Bounds;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_CalculateMeshBounds_Protected_Virtual_Bounds_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpriteItemData_Protected_Virtual_BaseSpriteItemData_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderingEnabled_Protected_Virtual_Boolean_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSpawnCount_Protected_Virtual_Int32_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Virtual_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Virtual_Void_BaseSpriteItemData_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Virtual_Void_Int32_BaseSpriteItemData_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Virtual_Void_byref_MaterialPropertyBlock_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_RainSplashArtItem_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_SyncDataFromSkyProfile_Private_Void_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldSplashPoint_Private_Vector3_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
