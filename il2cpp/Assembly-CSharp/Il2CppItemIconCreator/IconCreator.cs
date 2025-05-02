using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppItemIconCreator
{
	// Token: 0x0200015F RID: 351
	public class IconCreator : MonoBehaviour
	{
		// Token: 0x06001C46 RID: 7238 RVA: 0x000C8404 File Offset: 0x000C6604
		// Note: this type is marked as 'beforefieldinit'.
		static IconCreator()
		{
			Il2CppClassPointerStore<IconCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ItemIconCreator", "IconCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconCreator>.NativeClassPtr);
			IconCreator.NativeFieldInfoPtr_isCreatingIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "isCreatingIcons");
			IconCreator.NativeFieldInfoPtr_useDafaultName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "useDafaultName");
			IconCreator.NativeFieldInfoPtr_includeResolutionInFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "includeResolutionInFileName");
			IconCreator.NativeFieldInfoPtr_iconFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "iconFileName");
			IconCreator.NativeFieldInfoPtr_pathLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "pathLocation");
			IconCreator.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "mode");
			IconCreator.NativeFieldInfoPtr_folderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "folderName");
			IconCreator.NativeFieldInfoPtr_useTransparency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "useTransparency");
			IconCreator.NativeFieldInfoPtr_lookAtObjectCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "lookAtObjectCenter");
			IconCreator.NativeFieldInfoPtr_dynamicFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "dynamicFov");
			IconCreator.NativeFieldInfoPtr_fovOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "fovOffset");
			IconCreator.NativeFieldInfoPtr_finalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "finalPath");
			IconCreator.NativeFieldInfoPtr_mousePostion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "mousePostion");
			IconCreator.NativeFieldInfoPtr_nextIconKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "nextIconKey");
			IconCreator.NativeFieldInfoPtr_CanMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "CanMove");
			IconCreator.NativeFieldInfoPtr_preview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "preview");
			IconCreator.NativeFieldInfoPtr_whiteCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "whiteCam");
			IconCreator.NativeFieldInfoPtr_blackCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "blackCam");
			IconCreator.NativeFieldInfoPtr_mainCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "mainCam");
			IconCreator.NativeFieldInfoPtr_texBlack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "texBlack");
			IconCreator.NativeFieldInfoPtr_texWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "texWhite");
			IconCreator.NativeFieldInfoPtr_finalTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "finalTexture");
			IconCreator.NativeFieldInfoPtr_originalClearFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "originalClearFlags");
			IconCreator.NativeFieldInfoPtr_currentObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "currentObject");
			IconCreator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666245);
			IconCreator.NativeMethodInfoPtr_Initialize_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666246);
			IconCreator.NativeMethodInfoPtr_DeleteCameras_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666247);
			IconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666248);
			IconCreator.NativeMethodInfoPtr_CaptureFrame_Protected_IEnumerator_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666249);
			IconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666250);
			IconCreator.NativeMethodInfoPtr_RenderCamToTexture_Private_Void_Camera_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666251);
			IconCreator.NativeMethodInfoPtr_CreateBlackAndWhiteCameras_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666252);
			IconCreator.NativeMethodInfoPtr_CreateNewFolderForIcons_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666253);
			IconCreator.NativeMethodInfoPtr_GetFinalFolder_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666254);
			IconCreator.NativeMethodInfoPtr_WriteScreenImageToTexture_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666255);
			IconCreator.NativeMethodInfoPtr_CalculateOutputTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666256);
			IconCreator.NativeMethodInfoPtr_SavePng_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666257);
			IconCreator.NativeMethodInfoPtr_GetFileName_Public_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666258);
			IconCreator.NativeMethodInfoPtr_CacheAndInitialiseFields_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666259);
			IconCreator.NativeMethodInfoPtr_UpdateFOV_Protected_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666260);
			IconCreator.NativeMethodInfoPtr_UpdateFOV_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666261);
			IconCreator.NativeMethodInfoPtr_LookAtTargetCenter_Protected_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666262);
			IconCreator.NativeMethodInfoPtr_GetTargetFov_Private_Single_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666263);
			IconCreator.NativeMethodInfoPtr_GetRenderers_Private_List_1_Renderer_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666264);
			IconCreator.NativeMethodInfoPtr_GetMeshCenter_Private_Vector3_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666265);
			IconCreator.NativeMethodInfoPtr_RevealInFinder_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666266);
			IconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666267);
			IconCreator.NativeMethodInfoPtr_GetBaseLocation_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666268);
			IconCreator.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666269);
			IconCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666270);
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x000C881C File Offset: 0x000C6A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100652, XrefRangeEnd = 100676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x000C8850 File Offset: 0x000C6A50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100711, RefRangeEnd = 100712, XrefRangeStart = 100676, XrefRangeEnd = 100711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_Initialize_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x000C8884 File Offset: 0x000C6A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100727, RefRangeEnd = 100728, XrefRangeStart = 100712, XrefRangeEnd = 100727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteCameras()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_DeleteCameras_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x000C88B8 File Offset: 0x000C6AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100728, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BuildIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x000C88F4 File Offset: 0x000C6AF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100740, RefRangeEnd = 100742, XrefRangeStart = 100734, XrefRangeEnd = 100740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CaptureFrame(string objectName, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CaptureFrame_Protected_IEnumerator_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x000C8954 File Offset: 0x000C6B54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100761, RefRangeEnd = 100763, XrefRangeStart = 100742, XrefRangeEnd = 100761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x000C8990 File Offset: 0x000C6B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100763, XrefRangeEnd = 100771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderCamToTexture(Camera cam, Texture2D tex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_RenderCamToTexture_Private_Void_Camera_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x000C89E4 File Offset: 0x000C6BE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100805, RefRangeEnd = 100806, XrefRangeStart = 100771, XrefRangeEnd = 100805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateBlackAndWhiteCameras()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CreateBlackAndWhiteCameras_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x000C8A18 File Offset: 0x000C6C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100806, XrefRangeEnd = 100830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateNewFolderForIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CreateNewFolderForIcons_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x000C8A4C File Offset: 0x000C6C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100830, XrefRangeEnd = 100833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFinalFolder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetFinalFolder_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x000C8A84 File Offset: 0x000C6C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100833, XrefRangeEnd = 100838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteScreenImageToTexture(Texture2D tex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_WriteScreenImageToTexture_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x000C8AC8 File Offset: 0x000C6CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100838, XrefRangeEnd = 100845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateOutputTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CalculateOutputTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x000C8AFC File Offset: 0x000C6CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100845, XrefRangeEnd = 100871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SavePng(string name, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_SavePng_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x000C8B4C File Offset: 0x000C6D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100871, XrefRangeEnd = 100884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFileName(string name, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetFileName_Public_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x000C8BA4 File Offset: 0x000C6DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100884, XrefRangeEnd = 100904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheAndInitialiseFields()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CacheAndInitialiseFields_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x000C8BD8 File Offset: 0x000C6DD8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 100909, RefRangeEnd = 100913, XrefRangeStart = 100904, XrefRangeEnd = 100909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFOV(GameObject targetItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_UpdateFOV_Protected_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x000C8C1C File Offset: 0x000C6E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100913, XrefRangeEnd = 100920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFOV(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_UpdateFOV_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x000C8C5C File Offset: 0x000C6E5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 100934, RefRangeEnd = 100938, XrefRangeStart = 100920, XrefRangeEnd = 100934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAtTargetCenter(GameObject targetItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_LookAtTargetCenter_Protected_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x000C8CA0 File Offset: 0x000C6EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100993, RefRangeEnd = 100994, XrefRangeStart = 100938, XrefRangeEnd = 100993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTargetFov(GameObject a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetTargetFov_Private_Single_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x000C8CF0 File Offset: 0x000C6EF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 101015, RefRangeEnd = 101017, XrefRangeStart = 100994, XrefRangeEnd = 101015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Renderer> GetRenderers(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetRenderers_Private_List_1_Renderer_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Renderer>>(intPtr3) : null;
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x000C8D40 File Offset: 0x000C6F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101028, RefRangeEnd = 101029, XrefRangeStart = 101017, XrefRangeEnd = 101028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetMeshCenter(GameObject a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetMeshCenter_Private_Vector3_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x000C8D90 File Offset: 0x000C6F90
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RevealInFinder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_RevealInFinder_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x000C8DC4 File Offset: 0x000C6FC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 101040, RefRangeEnd = 101042, XrefRangeStart = 101029, XrefRangeEnd = 101040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckConditions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x000C8E0C File Offset: 0x000C700C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 101046, RefRangeEnd = 101049, XrefRangeStart = 101042, XrefRangeEnd = 101046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetBaseLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetBaseLocation_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x000C8E44 File Offset: 0x000C7044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101049, XrefRangeEnd = 101057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x000C8E78 File Offset: 0x000C7078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101057, XrefRangeEnd = 101062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IconCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x000101F1 File Offset: 0x0000E3F1
		public IconCreator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x000C8EB4 File Offset: 0x000C70B4
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x000101FA File Offset: 0x0000E3FA
		public unsafe bool isCreatingIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_isCreatingIcons);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_isCreatingIcons)) = value;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x000C8EDC File Offset: 0x000C70DC
		// (set) Token: 0x06001C65 RID: 7269 RVA: 0x00010215 File Offset: 0x0000E415
		public unsafe bool useDafaultName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_useDafaultName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_useDafaultName)) = value;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x000C8F04 File Offset: 0x000C7104
		// (set) Token: 0x06001C67 RID: 7271 RVA: 0x00010230 File Offset: 0x0000E430
		public unsafe bool includeResolutionInFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_includeResolutionInFileName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_includeResolutionInFileName)) = value;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x000C8F2C File Offset: 0x000C712C
		// (set) Token: 0x06001C69 RID: 7273 RVA: 0x0001024B File Offset: 0x0000E44B
		public unsafe string iconFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_iconFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_iconFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x000C8F54 File Offset: 0x000C7154
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x0001026A File Offset: 0x0000E46A
		public unsafe IconCreator.SaveLocation pathLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_pathLocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_pathLocation)) = value;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x000C8F7C File Offset: 0x000C717C
		// (set) Token: 0x06001C6D RID: 7277 RVA: 0x00010285 File Offset: 0x0000E485
		public unsafe IconCreator.Mode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001C6E RID: 7278 RVA: 0x000C8FA4 File Offset: 0x000C71A4
		// (set) Token: 0x06001C6F RID: 7279 RVA: 0x000102A0 File Offset: 0x0000E4A0
		public unsafe string folderName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_folderName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_folderName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x000C8FCC File Offset: 0x000C71CC
		// (set) Token: 0x06001C71 RID: 7281 RVA: 0x000102BF File Offset: 0x0000E4BF
		public unsafe bool useTransparency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_useTransparency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_useTransparency)) = value;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x000C8FF4 File Offset: 0x000C71F4
		// (set) Token: 0x06001C73 RID: 7283 RVA: 0x000102DA File Offset: 0x0000E4DA
		public unsafe bool lookAtObjectCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_lookAtObjectCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_lookAtObjectCenter)) = value;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x000C901C File Offset: 0x000C721C
		// (set) Token: 0x06001C75 RID: 7285 RVA: 0x000102F5 File Offset: 0x0000E4F5
		public unsafe bool dynamicFov
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_dynamicFov);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_dynamicFov)) = value;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x000C9044 File Offset: 0x000C7244
		// (set) Token: 0x06001C77 RID: 7287 RVA: 0x00010310 File Offset: 0x0000E510
		public unsafe float fovOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_fovOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_fovOffset)) = value;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x000C906C File Offset: 0x000C726C
		// (set) Token: 0x06001C79 RID: 7289 RVA: 0x0001032B File Offset: 0x0000E52B
		public unsafe string finalPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_finalPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_finalPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x000C9094 File Offset: 0x000C7294
		// (set) Token: 0x06001C7B RID: 7291 RVA: 0x0001034A File Offset: 0x0000E54A
		public unsafe Vector3 mousePostion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mousePostion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mousePostion)) = value;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001C7C RID: 7292 RVA: 0x000C90BC File Offset: 0x000C72BC
		// (set) Token: 0x06001C7D RID: 7293 RVA: 0x00010365 File Offset: 0x0000E565
		public unsafe KeyCode nextIconKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_nextIconKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_nextIconKey)) = value;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x000C90E4 File Offset: 0x000C72E4
		// (set) Token: 0x06001C7F RID: 7295 RVA: 0x00010380 File Offset: 0x0000E580
		public unsafe bool CanMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_CanMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_CanMove)) = value;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x000C910C File Offset: 0x000C730C
		// (set) Token: 0x06001C81 RID: 7297 RVA: 0x0001039B File Offset: 0x0000E59B
		public unsafe bool preview
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_preview);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_preview)) = value;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x000C9134 File Offset: 0x000C7334
		// (set) Token: 0x06001C83 RID: 7299 RVA: 0x000103B6 File Offset: 0x0000E5B6
		public unsafe Camera whiteCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_whiteCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_whiteCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x000C9164 File Offset: 0x000C7364
		// (set) Token: 0x06001C85 RID: 7301 RVA: 0x000103D5 File Offset: 0x0000E5D5
		public unsafe Camera blackCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_blackCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_blackCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x000C9194 File Offset: 0x000C7394
		// (set) Token: 0x06001C87 RID: 7303 RVA: 0x000103F4 File Offset: 0x0000E5F4
		public unsafe Camera mainCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mainCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mainCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x000C91C4 File Offset: 0x000C73C4
		// (set) Token: 0x06001C89 RID: 7305 RVA: 0x00010413 File Offset: 0x0000E613
		public unsafe Texture2D texBlack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_texBlack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_texBlack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x000C91F4 File Offset: 0x000C73F4
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x00010432 File Offset: 0x0000E632
		public unsafe Texture2D texWhite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_texWhite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_texWhite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x000C9224 File Offset: 0x000C7424
		// (set) Token: 0x06001C8D RID: 7309 RVA: 0x00010451 File Offset: 0x0000E651
		public unsafe Texture2D finalTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_finalTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_finalTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x000C9254 File Offset: 0x000C7454
		// (set) Token: 0x06001C8F RID: 7311 RVA: 0x00010470 File Offset: 0x0000E670
		public unsafe CameraClearFlags originalClearFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_originalClearFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_originalClearFlags)) = value;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x000C927C File Offset: 0x000C747C
		// (set) Token: 0x06001C91 RID: 7313 RVA: 0x0001048B File Offset: 0x0000E68B
		public unsafe Transform currentObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_currentObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_currentObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeFieldInfoPtr_isCreatingIcons;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeFieldInfoPtr_useDafaultName;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeFieldInfoPtr_includeResolutionInFileName;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeFieldInfoPtr_iconFileName;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeFieldInfoPtr_pathLocation;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeFieldInfoPtr_folderName;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeFieldInfoPtr_useTransparency;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeFieldInfoPtr_lookAtObjectCenter;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeFieldInfoPtr_dynamicFov;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeFieldInfoPtr_fovOffset;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeFieldInfoPtr_finalPath;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeFieldInfoPtr_mousePostion;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeFieldInfoPtr_nextIconKey;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeFieldInfoPtr_CanMove;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeFieldInfoPtr_preview;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeFieldInfoPtr_whiteCam;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeFieldInfoPtr_blackCam;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeFieldInfoPtr_mainCam;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeFieldInfoPtr_texBlack;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeFieldInfoPtr_texWhite;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeFieldInfoPtr_finalTexture;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeFieldInfoPtr_originalClearFlags;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeFieldInfoPtr_currentObject;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Void_0;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeMethodInfoPtr_DeleteCameras_Protected_Void_0;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeMethodInfoPtr_BuildIcons_Public_Virtual_New_Void_0;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeMethodInfoPtr_CaptureFrame_Protected_IEnumerator_String_Int32_0;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeMethodInfoPtr_RenderCamToTexture_Private_Void_Camera_Texture2D_0;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlackAndWhiteCameras_Private_Void_0;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewFolderForIcons_Protected_Void_0;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalFolder_Public_String_0;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr_WriteScreenImageToTexture_Private_Void_Texture2D_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr_CalculateOutputTexture_Private_Void_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr_SavePng_Private_Void_String_Int32_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Public_String_String_Int32_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_CacheAndInitialiseFields_Private_Void_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFOV_Protected_Void_GameObject_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFOV_Protected_Void_Single_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_LookAtTargetCenter_Protected_Void_GameObject_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetFov_Private_Single_GameObject_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderers_Private_List_1_Renderer_GameObject_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshCenter_Private_Vector3_GameObject_0;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeMethodInfoPtr_RevealInFinder_Protected_Void_0;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeMethodInfoPtr_CheckConditions_Public_Virtual_New_Boolean_0;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseLocation_Private_String_0;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000864 RID: 2148
		[OriginalName("Assembly-CSharp.dll", "", "SaveLocation")]
		public enum SaveLocation
		{
			// Token: 0x040082B4 RID: 33460
			persistentDataPath,
			// Token: 0x040082B5 RID: 33461
			dataPath,
			// Token: 0x040082B6 RID: 33462
			projectFolder,
			// Token: 0x040082B7 RID: 33463
			custom
		}

		// Token: 0x02000865 RID: 2149
		[OriginalName("Assembly-CSharp.dll", "", "Mode")]
		public enum Mode
		{
			// Token: 0x040082B9 RID: 33465
			Automatic,
			// Token: 0x040082BA RID: 33466
			Manual
		}

		// Token: 0x02000866 RID: 2150
		[ObfuscatedName("ItemIconCreator.IconCreator+<CaptureFrame>d__30")]
		public sealed class _CaptureFrame_d__30 : Il2CppSystem.Object
		{
			// Token: 0x0600C0FE RID: 49406 RVA: 0x002F2434 File Offset: 0x002F0634
			// Note: this type is marked as 'beforefieldinit'.
			static _CaptureFrame_d__30()
			{
				Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "<CaptureFrame>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr);
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "<>1__state");
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "<>2__current");
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "<>4__this");
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_objectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "objectName");
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "i");
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100666271);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100666272);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100666273);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100666274);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100666275);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100666276);
			}

			// Token: 0x0600C0FF RID: 49407 RVA: 0x002F253C File Offset: 0x002F073C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CaptureFrame_d__30(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C100 RID: 49408 RVA: 0x002F2584 File Offset: 0x002F0784
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C101 RID: 49409 RVA: 0x002F25B8 File Offset: 0x002F07B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100633, XrefRangeEnd = 100647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003C24 RID: 15396
			// (get) Token: 0x0600C102 RID: 49410 RVA: 0x002F25F4 File Offset: 0x002F07F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C103 RID: 49411 RVA: 0x002F2634 File Offset: 0x002F0834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100647, XrefRangeEnd = 100652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003C25 RID: 15397
			// (get) Token: 0x0600C104 RID: 49412 RVA: 0x002F2668 File Offset: 0x002F0868
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C105 RID: 49413 RVA: 0x0005E5A3 File Offset: 0x0005C7A3
			public _CaptureFrame_d__30(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C1F RID: 15391
			// (get) Token: 0x0600C106 RID: 49414 RVA: 0x002F26A8 File Offset: 0x002F08A8
			// (set) Token: 0x0600C107 RID: 49415 RVA: 0x0005E5AC File Offset: 0x0005C7AC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C20 RID: 15392
			// (get) Token: 0x0600C108 RID: 49416 RVA: 0x002F26D0 File Offset: 0x002F08D0
			// (set) Token: 0x0600C109 RID: 49417 RVA: 0x0005E5C7 File Offset: 0x0005C7C7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C21 RID: 15393
			// (get) Token: 0x0600C10A RID: 49418 RVA: 0x002F2700 File Offset: 0x002F0900
			// (set) Token: 0x0600C10B RID: 49419 RVA: 0x0005E5E6 File Offset: 0x0005C7E6
			public unsafe IconCreator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IconCreator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C22 RID: 15394
			// (get) Token: 0x0600C10C RID: 49420 RVA: 0x002F2730 File Offset: 0x002F0930
			// (set) Token: 0x0600C10D RID: 49421 RVA: 0x0005E605 File Offset: 0x0005C805
			public unsafe string objectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_objectName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_objectName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C23 RID: 15395
			// (get) Token: 0x0600C10E RID: 49422 RVA: 0x002F2758 File Offset: 0x002F0958
			// (set) Token: 0x0600C10F RID: 49423 RVA: 0x0005E624 File Offset: 0x0005C824
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x040082BB RID: 33467
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040082BC RID: 33468
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040082BD RID: 33469
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040082BE RID: 33470
			private static readonly IntPtr NativeFieldInfoPtr_objectName;

			// Token: 0x040082BF RID: 33471
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x040082C0 RID: 33472
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040082C1 RID: 33473
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040082C2 RID: 33474
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040082C3 RID: 33475
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040082C4 RID: 33476
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040082C5 RID: 33477
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
