using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000127 RID: 295
	public class LightningRenderer : BaseSpriteInstancedRenderer
	{
		// Token: 0x06001937 RID: 6455 RVA: 0x000BF57C File Offset: 0x000BD77C
		// Note: this type is marked as 'beforefieldinit'.
		static LightningRenderer()
		{
			Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "LightningRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr);
			LightningRenderer.NativeFieldInfoPtr_m_SpawnAreas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_SpawnAreas");
			LightningRenderer.NativeFieldInfoPtr_m_LightningProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_LightningProbability");
			LightningRenderer.NativeFieldInfoPtr_m_NextSpawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_NextSpawnTime");
			LightningRenderer.NativeFieldInfoPtr_m_SkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_SkyProfile");
			LightningRenderer.NativeFieldInfoPtr_m_Style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_Style");
			LightningRenderer.NativeFieldInfoPtr_m_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_TimeOfDay");
			LightningRenderer.NativeFieldInfoPtr_m_AudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_AudioSource");
			LightningRenderer.NativeFieldInfoPtr_m_LightningIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_LightningIntensity");
			LightningRenderer.NativeFieldInfoPtr_m_ThunderSoundDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_ThunderSoundDelay");
			LightningRenderer.NativeFieldInfoPtr_m_SpawnCoolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "m_SpawnCoolDown");
			LightningRenderer.NativeFieldInfoPtr_k_ProbabiltyCheckInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, "k_ProbabiltyCheckInterval");
			LightningRenderer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665982);
			LightningRenderer.NativeMethodInfoPtr_CalculateMeshBounds_Protected_Virtual_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665983);
			LightningRenderer.NativeMethodInfoPtr_CreateSpriteItemData_Protected_Virtual_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665984);
			LightningRenderer.NativeMethodInfoPtr_IsRenderingEnabled_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665985);
			LightningRenderer.NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Virtual_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665986);
			LightningRenderer.NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Virtual_Void_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665987);
			LightningRenderer.NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Virtual_Void_Int32_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665988);
			LightningRenderer.NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Virtual_Void_byref_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665989);
			LightningRenderer.NativeMethodInfoPtr_GetNextSpawnCount_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665990);
			LightningRenderer.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_LightningArtItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665991);
			LightningRenderer.NativeMethodInfoPtr_SyncDataFromSkyProfile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665992);
			LightningRenderer.NativeMethodInfoPtr_GetRandomLightningSpawnArea_Private_LightningSpawnArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665993);
			LightningRenderer.NativeMethodInfoPtr_PlayThunderBoltSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665994);
			LightningRenderer.NativeMethodInfoPtr_AddSpawnArea_Public_Static_Void_LightningSpawnArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665995);
			LightningRenderer.NativeMethodInfoPtr_RemoveSpawnArea_Public_Static_Void_LightningSpawnArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665996);
			LightningRenderer.NativeMethodInfoPtr_GetRandomWorldPositionInsideSpawnArea_Private_Vector3_LightningSpawnArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665997);
			LightningRenderer.NativeMethodInfoPtr_CalculateLightningBoltScaleForArea_Private_Single_LightningSpawnArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665998);
			LightningRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr, 100665999);
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x000BF7F0 File Offset: 0x000BD9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96056, XrefRangeEnd = 96068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x000BF824 File Offset: 0x000BDA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96068, XrefRangeEnd = 96070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Bounds CalculateMeshBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_CalculateMeshBounds_Protected_Virtual_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x000BF86C File Offset: 0x000BDA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96070, XrefRangeEnd = 96074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BaseSpriteItemData CreateSpriteItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_CreateSpriteItemData_Protected_Virtual_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseSpriteItemData>(intPtr3) : null;
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x000BF8B8 File Offset: 0x000BDAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96074, XrefRangeEnd = 96086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsRenderingEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_IsRenderingEnabled_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x000BF900 File Offset: 0x000BDB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96086, XrefRangeEnd = 96105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spritePosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteRotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Virtual_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x000BF978 File Offset: 0x000BDB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96105, XrefRangeEnd = 96111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConfigureSpriteItemData(BaseSpriteItemData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Virtual_Void_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x000BF9C8 File Offset: 0x000BDBC8
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref instanceId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Virtual_Void_Int32_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x000BFA24 File Offset: 0x000BDC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96111, XrefRangeEnd = 96115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(propertyBlock);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Virtual_Void_byref_MaterialPropertyBlock_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			propertyBlock = ((intPtr4 == 0) ? null : new MaterialPropertyBlock(intPtr4));
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x000BFA88 File Offset: 0x000BDC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96115, XrefRangeEnd = 96118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetNextSpawnCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningRenderer.NativeMethodInfoPtr_GetNextSpawnCount_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x000BFAD0 File Offset: 0x000BDCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96118, XrefRangeEnd = 96140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, LightningArtItem artItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skyProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(artItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_LightningArtItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x000BFB34 File Offset: 0x000BDD34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96158, RefRangeEnd = 96160, XrefRangeStart = 96140, XrefRangeEnd = 96158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncDataFromSkyProfile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_SyncDataFromSkyProfile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x000BFB68 File Offset: 0x000BDD68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96182, RefRangeEnd = 96183, XrefRangeStart = 96160, XrefRangeEnd = 96182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightningSpawnArea GetRandomLightningSpawnArea()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_GetRandomLightningSpawnArea_Private_LightningSpawnArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LightningSpawnArea>(intPtr3) : null;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x000BFBA8 File Offset: 0x000BDDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96183, XrefRangeEnd = 96192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayThunderBoltSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_PlayThunderBoltSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x000BFBDC File Offset: 0x000BDDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96192, XrefRangeEnd = 96205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddSpawnArea(LightningSpawnArea area)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(area);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_AddSpawnArea_Public_Static_Void_LightningSpawnArea_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x000BFC14 File Offset: 0x000BDE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96205, XrefRangeEnd = 96218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveSpawnArea(LightningSpawnArea area)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(area);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_RemoveSpawnArea_Public_Static_Void_LightningSpawnArea_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x000BFC4C File Offset: 0x000BDE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96218, XrefRangeEnd = 96222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRandomWorldPositionInsideSpawnArea(LightningSpawnArea area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(area);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_GetRandomWorldPositionInsideSpawnArea_Private_Vector3_LightningSpawnArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x000BFC9C File Offset: 0x000BDE9C
		[CallerCount(0)]
		public unsafe float CalculateLightningBoltScaleForArea(LightningSpawnArea area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(area);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr_CalculateLightningBoltScaleForArea_Private_Single_LightningSpawnArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x000BFCEC File Offset: 0x000BDEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96222, XrefRangeEnd = 96223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightningRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0000E64F File Offset: 0x0000C84F
		public LightningRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x0600194B RID: 6475 RVA: 0x000BFD28 File Offset: 0x000BDF28
		// (set) Token: 0x0600194C RID: 6476 RVA: 0x0000E658 File Offset: 0x0000C858
		public unsafe static List<LightningSpawnArea> m_SpawnAreas
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LightningRenderer.NativeFieldInfoPtr_m_SpawnAreas, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LightningSpawnArea>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightningRenderer.NativeFieldInfoPtr_m_SpawnAreas, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x000BFD50 File Offset: 0x000BDF50
		// (set) Token: 0x0600194E RID: 6478 RVA: 0x0000E66A File Offset: 0x0000C86A
		public unsafe float m_LightningProbability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_LightningProbability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_LightningProbability)) = value;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x000BFD78 File Offset: 0x000BDF78
		// (set) Token: 0x06001950 RID: 6480 RVA: 0x0000E685 File Offset: 0x0000C885
		public unsafe float m_NextSpawnTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_NextSpawnTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_NextSpawnTime)) = value;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x000BFDA0 File Offset: 0x000BDFA0
		// (set) Token: 0x06001952 RID: 6482 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		public unsafe SkyProfile m_SkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_SkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_SkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x000BFDD0 File Offset: 0x000BDFD0
		// (set) Token: 0x06001954 RID: 6484 RVA: 0x0000E6BF File Offset: 0x0000C8BF
		public unsafe LightningArtItem m_Style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_Style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightningArtItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_Style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x000BFE00 File Offset: 0x000BE000
		// (set) Token: 0x06001956 RID: 6486 RVA: 0x0000E6DE File Offset: 0x0000C8DE
		public unsafe float m_TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_TimeOfDay)) = value;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x000BFE28 File Offset: 0x000BE028
		// (set) Token: 0x06001958 RID: 6488 RVA: 0x0000E6F9 File Offset: 0x0000C8F9
		public unsafe AudioSource m_AudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_AudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_AudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x000BFE58 File Offset: 0x000BE058
		// (set) Token: 0x0600195A RID: 6490 RVA: 0x0000E718 File Offset: 0x0000C918
		public unsafe float m_LightningIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_LightningIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_LightningIntensity)) = value;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x000BFE80 File Offset: 0x000BE080
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x0000E733 File Offset: 0x0000C933
		public unsafe float m_ThunderSoundDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_ThunderSoundDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_ThunderSoundDelay)) = value;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x000BFEA8 File Offset: 0x000BE0A8
		// (set) Token: 0x0600195E RID: 6494 RVA: 0x0000E74E File Offset: 0x0000C94E
		public unsafe float m_SpawnCoolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_SpawnCoolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningRenderer.NativeFieldInfoPtr_m_SpawnCoolDown)) = value;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x000BFED0 File Offset: 0x000BE0D0
		// (set) Token: 0x06001960 RID: 6496 RVA: 0x0000E769 File Offset: 0x0000C969
		public unsafe static float k_ProbabiltyCheckInterval
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LightningRenderer.NativeFieldInfoPtr_k_ProbabiltyCheckInterval, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightningRenderer.NativeFieldInfoPtr_k_ProbabiltyCheckInterval, (void*)(&value));
			}
		}

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeFieldInfoPtr_m_SpawnAreas;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeFieldInfoPtr_m_LightningProbability;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeFieldInfoPtr_m_NextSpawnTime;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyProfile;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeFieldInfoPtr_m_Style;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeOfDay;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeFieldInfoPtr_m_AudioSource;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeFieldInfoPtr_m_LightningIntensity;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeFieldInfoPtr_m_ThunderSoundDelay;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeFieldInfoPtr_m_SpawnCoolDown;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeFieldInfoPtr_k_ProbabiltyCheckInterval;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_CalculateMeshBounds_Protected_Virtual_Bounds_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpriteItemData_Protected_Virtual_BaseSpriteItemData_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderingEnabled_Protected_Virtual_Boolean_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Virtual_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Virtual_Void_BaseSpriteItemData_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Virtual_Void_Int32_BaseSpriteItemData_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Virtual_Void_byref_MaterialPropertyBlock_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSpawnCount_Protected_Virtual_Int32_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_LightningArtItem_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_SyncDataFromSkyProfile_Private_Void_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomLightningSpawnArea_Private_LightningSpawnArea_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_PlayThunderBoltSound_Private_Void_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_AddSpawnArea_Public_Static_Void_LightningSpawnArea_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSpawnArea_Public_Static_Void_LightningSpawnArea_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomWorldPositionInsideSpawnArea_Private_Vector3_LightningSpawnArea_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLightningBoltScaleForArea_Private_Single_LightningSpawnArea_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
