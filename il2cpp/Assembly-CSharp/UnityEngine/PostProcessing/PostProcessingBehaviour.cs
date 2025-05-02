using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200006D RID: 109
	public class PostProcessingBehaviour : MonoBehaviour
	{
		// Token: 0x060007B0 RID: 1968 RVA: 0x00087F0C File Offset: 0x0008610C
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingBehaviour()
		{
			Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "PostProcessingBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr);
			PostProcessingBehaviour.NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "profile");
			PostProcessingBehaviour.NativeFieldInfoPtr_jitteredMatrixFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "jitteredMatrixFunc");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_CommandBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_CommandBuffers");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_Components = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_Components");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_ComponentStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_ComponentStates");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_MaterialFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_MaterialFactory");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_RenderTextureFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_RenderTextureFactory");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_Context");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_Camera");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_PreviousProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_PreviousProfile");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_RenderingInSceneView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_RenderingInSceneView");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_DebugViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_DebugViews");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_AmbientOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_AmbientOcclusion");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_ScreenSpaceReflection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_ScreenSpaceReflection");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_FogComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_FogComponent");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_MotionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_MotionBlur");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_Taa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_Taa");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_EyeAdaptation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_EyeAdaptation");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_DepthOfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_DepthOfField");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_Bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_Bloom");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_ChromaticAberration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_ChromaticAberration");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_ColorGrading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_ColorGrading");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_UserLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_UserLut");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_Grain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_Grain");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_Vignette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_Vignette");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_Dithering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_Dithering");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_Fxaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_Fxaa");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_ComponentsToEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_ComponentsToEnable");
			PostProcessingBehaviour.NativeFieldInfoPtr_m_ComponentsToDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, "m_ComponentsToDisable");
			PostProcessingBehaviour.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664133);
			PostProcessingBehaviour.NativeMethodInfoPtr_OnPreCull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664134);
			PostProcessingBehaviour.NativeMethodInfoPtr_OnPreRender_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664135);
			PostProcessingBehaviour.NativeMethodInfoPtr_OnPostRender_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664136);
			PostProcessingBehaviour.NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664137);
			PostProcessingBehaviour.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664138);
			PostProcessingBehaviour.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664139);
			PostProcessingBehaviour.NativeMethodInfoPtr_ResetTemporalEffects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664140);
			PostProcessingBehaviour.NativeMethodInfoPtr_CheckObservers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664141);
			PostProcessingBehaviour.NativeMethodInfoPtr_DisableComponents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664142);
			PostProcessingBehaviour.NativeMethodInfoPtr_AddCommandBuffer_Private_CommandBuffer_CameraEvent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664143);
			PostProcessingBehaviour.NativeMethodInfoPtr_RemoveCommandBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664144);
			PostProcessingBehaviour.NativeMethodInfoPtr_GetCommandBuffer_Private_CommandBuffer_CameraEvent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664145);
			PostProcessingBehaviour.NativeMethodInfoPtr_TryExecuteCommandBuffer_Private_Void_PostProcessingComponentCommandBuffer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664146);
			PostProcessingBehaviour.NativeMethodInfoPtr_TryPrepareUberImageEffect_Private_Boolean_PostProcessingComponentRenderTexture_1_T_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664147);
			PostProcessingBehaviour.NativeMethodInfoPtr_AddComponent_Private_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664148);
			PostProcessingBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr, 100664149);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x000882D4 File Offset: 0x000864D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77922, XrefRangeEnd = 78142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00088308 File Offset: 0x00086508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78142, XrefRangeEnd = 78184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreCull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.NativeMethodInfoPtr_OnPreCull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0008833C File Offset: 0x0008653C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78184, XrefRangeEnd = 78203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreRender()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.NativeMethodInfoPtr_OnPreRender_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00088370 File Offset: 0x00086570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78203, XrefRangeEnd = 78211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPostRender()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.NativeMethodInfoPtr_OnPostRender_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000883A4 File Offset: 0x000865A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78211, XrefRangeEnd = 78299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000883F8 File Offset: 0x000865F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78299, XrefRangeEnd = 78309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0008842C File Offset: 0x0008662C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78309, XrefRangeEnd = 78364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00088460 File Offset: 0x00086660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78364, XrefRangeEnd = 78368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTemporalEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.NativeMethodInfoPtr_ResetTemporalEffects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00088494 File Offset: 0x00086694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78406, RefRangeEnd = 78407, XrefRangeStart = 78368, XrefRangeEnd = 78406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckObservers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.NativeMethodInfoPtr_CheckObservers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000884C8 File Offset: 0x000866C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78421, RefRangeEnd = 78423, XrefRangeStart = 78407, XrefRangeEnd = 78421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableComponents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.NativeMethodInfoPtr_DisableComponents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000884FC File Offset: 0x000866FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78423, XrefRangeEnd = 78441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandBuffer AddCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evt;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.MethodInfoStoreGeneric_AddCommandBuffer_Private_CommandBuffer_CameraEvent_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr3) : null;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0008855C File Offset: 0x0008675C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78441, XrefRangeEnd = 78456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCommandBuffer<T>() where T : PostProcessingModel
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.MethodInfoStoreGeneric_RemoveCommandBuffer_Private_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00088590 File Offset: 0x00086790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78456, XrefRangeEnd = 78466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandBuffer GetCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evt;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.MethodInfoStoreGeneric_GetCommandBuffer_Private_CommandBuffer_CameraEvent_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr3) : null;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x000885F0 File Offset: 0x000867F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 78468, RefRangeEnd = 78473, XrefRangeStart = 78466, XrefRangeEnd = 78468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryExecuteCommandBuffer<T>(PostProcessingComponentCommandBuffer<T> component) where T : PostProcessingModel
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.MethodInfoStoreGeneric_TryExecuteCommandBuffer_Private_Void_PostProcessingComponentCommandBuffer_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00088634 File Offset: 0x00086834
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 78473, RefRangeEnd = 78481, XrefRangeStart = 78473, XrefRangeEnd = 78473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryPrepareUberImageEffect<T>(PostProcessingComponentRenderTexture<T> component, Material material) where T : PostProcessingModel
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.MethodInfoStoreGeneric_TryPrepareUberImageEffect_Private_Boolean_PostProcessingComponentRenderTexture_1_T_Material_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00088694 File Offset: 0x00086894
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 78484, RefRangeEnd = 78500, XrefRangeStart = 78481, XrefRangeEnd = 78484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T AddComponent<T>(T component) where T : PostProcessingComponentBase
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = component;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref component;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.MethodInfoStoreGeneric_AddComponent_Private_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0008872C File Offset: 0x0008692C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78500, XrefRangeEnd = 78513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0000626D File Offset: 0x0000446D
		public PostProcessingBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00088768 File Offset: 0x00086968
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00006276 File Offset: 0x00004476
		public unsafe PostProcessingProfile profile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_profile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessingProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_profile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00088798 File Offset: 0x00086998
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x00006295 File Offset: 0x00004495
		public unsafe Func<Vector2, Matrix4x4> jitteredMatrixFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_jitteredMatrixFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2, Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_jitteredMatrixFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x000887C8 File Offset: 0x000869C8
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x000062B4 File Offset: 0x000044B4
		public unsafe Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>> m_CommandBuffers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_CommandBuffers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_CommandBuffers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x000887F8 File Offset: 0x000869F8
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x000062D3 File Offset: 0x000044D3
		public unsafe List<PostProcessingComponentBase> m_Components
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Components);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PostProcessingComponentBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Components), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00088828 File Offset: 0x00086A28
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x000062F2 File Offset: 0x000044F2
		public unsafe Dictionary<PostProcessingComponentBase, bool> m_ComponentStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_ComponentStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PostProcessingComponentBase, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_ComponentStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00088858 File Offset: 0x00086A58
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x00006311 File Offset: 0x00004511
		public unsafe MaterialFactory m_MaterialFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_MaterialFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_MaterialFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00088888 File Offset: 0x00086A88
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x00006330 File Offset: 0x00004530
		public unsafe RenderTextureFactory m_RenderTextureFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_RenderTextureFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTextureFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_RenderTextureFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x000888B8 File Offset: 0x00086AB8
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x0000634F File Offset: 0x0000454F
		public unsafe PostProcessingContext m_Context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessingContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x000888E8 File Offset: 0x00086AE8
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x0000636E File Offset: 0x0000456E
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00088918 File Offset: 0x00086B18
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x0000638D File Offset: 0x0000458D
		public unsafe PostProcessingProfile m_PreviousProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_PreviousProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessingProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_PreviousProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00088948 File Offset: 0x00086B48
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x000063AC File Offset: 0x000045AC
		public unsafe bool m_RenderingInSceneView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_RenderingInSceneView);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_RenderingInSceneView)) = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x00088970 File Offset: 0x00086B70
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x000063C7 File Offset: 0x000045C7
		public unsafe BuiltinDebugViewsComponent m_DebugViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_DebugViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuiltinDebugViewsComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_DebugViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x000889A0 File Offset: 0x00086BA0
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x000063E6 File Offset: 0x000045E6
		public unsafe AmbientOcclusionComponent m_AmbientOcclusion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_AmbientOcclusion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmbientOcclusionComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_AmbientOcclusion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x000889D0 File Offset: 0x00086BD0
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x00006405 File Offset: 0x00004605
		public unsafe ScreenSpaceReflectionComponent m_ScreenSpaceReflection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_ScreenSpaceReflection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenSpaceReflectionComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_ScreenSpaceReflection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00088A00 File Offset: 0x00086C00
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x00006424 File Offset: 0x00004624
		public unsafe FogComponent m_FogComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_FogComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FogComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_FogComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00088A30 File Offset: 0x00086C30
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00006443 File Offset: 0x00004643
		public unsafe MotionBlurComponent m_MotionBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_MotionBlur);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotionBlurComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_MotionBlur), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00088A60 File Offset: 0x00086C60
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x00006462 File Offset: 0x00004662
		public unsafe TaaComponent m_Taa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Taa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaaComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Taa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00088A90 File Offset: 0x00086C90
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00006481 File Offset: 0x00004681
		public unsafe EyeAdaptationComponent m_EyeAdaptation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_EyeAdaptation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeAdaptationComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_EyeAdaptation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00088AC0 File Offset: 0x00086CC0
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x000064A0 File Offset: 0x000046A0
		public unsafe DepthOfFieldComponent m_DepthOfField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_DepthOfField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOfFieldComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_DepthOfField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00088AF0 File Offset: 0x00086CF0
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x000064BF File Offset: 0x000046BF
		public unsafe BloomComponent m_Bloom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Bloom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BloomComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Bloom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00088B20 File Offset: 0x00086D20
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x000064DE File Offset: 0x000046DE
		public unsafe ChromaticAberrationComponent m_ChromaticAberration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_ChromaticAberration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChromaticAberrationComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_ChromaticAberration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00088B50 File Offset: 0x00086D50
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x000064FD File Offset: 0x000046FD
		public unsafe ColorGradingComponent m_ColorGrading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_ColorGrading);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_ColorGrading), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00088B80 File Offset: 0x00086D80
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x0000651C File Offset: 0x0000471C
		public unsafe UserLutComponent m_UserLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_UserLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserLutComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_UserLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00088BB0 File Offset: 0x00086DB0
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x0000653B File Offset: 0x0000473B
		public unsafe GrainComponent m_Grain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Grain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrainComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Grain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00088BE0 File Offset: 0x00086DE0
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x0000655A File Offset: 0x0000475A
		public unsafe VignetteComponent m_Vignette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Vignette);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VignetteComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Vignette), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00088C10 File Offset: 0x00086E10
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x00006579 File Offset: 0x00004779
		public unsafe DitheringComponent m_Dithering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Dithering);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DitheringComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Dithering), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00088C40 File Offset: 0x00086E40
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x00006598 File Offset: 0x00004798
		public unsafe FxaaComponent m_Fxaa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Fxaa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FxaaComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_Fxaa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00088C70 File Offset: 0x00086E70
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x000065B7 File Offset: 0x000047B7
		public unsafe List<PostProcessingComponentBase> m_ComponentsToEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_ComponentsToEnable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PostProcessingComponentBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_ComponentsToEnable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x00088CA0 File Offset: 0x00086EA0
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x000065D6 File Offset: 0x000047D6
		public unsafe List<PostProcessingComponentBase> m_ComponentsToDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_ComponentsToDisable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PostProcessingComponentBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingBehaviour.NativeFieldInfoPtr_m_ComponentsToDisable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeFieldInfoPtr_profile;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeFieldInfoPtr_jitteredMatrixFunc;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeFieldInfoPtr_m_CommandBuffers;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeFieldInfoPtr_m_Components;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeFieldInfoPtr_m_ComponentStates;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialFactory;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderTextureFactory;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeFieldInfoPtr_m_Context;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousProfile;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderingInSceneView;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugViews;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeFieldInfoPtr_m_AmbientOcclusion;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenSpaceReflection;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeFieldInfoPtr_m_FogComponent;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeFieldInfoPtr_m_MotionBlur;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeFieldInfoPtr_m_Taa;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeFieldInfoPtr_m_EyeAdaptation;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthOfField;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr_m_Bloom;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeFieldInfoPtr_m_ChromaticAberration;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGrading;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr_m_UserLut;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr_m_Grain;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr_m_Vignette;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr_m_Dithering;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr_m_Fxaa;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_m_ComponentsToEnable;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeFieldInfoPtr_m_ComponentsToDisable;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_OnPreCull_Private_Void_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_OnPreRender_Private_Void_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_OnPostRender_Private_Void_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_ResetTemporalEffects_Public_Void_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_CheckObservers_Private_Void_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_DisableComponents_Private_Void_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_AddCommandBuffer_Private_CommandBuffer_CameraEvent_String_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCommandBuffer_Private_Void_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_GetCommandBuffer_Private_CommandBuffer_CameraEvent_String_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteCommandBuffer_Private_Void_PostProcessingComponentCommandBuffer_1_T_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_TryPrepareUberImageEffect_Private_Boolean_PostProcessingComponentRenderTexture_1_T_Material_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Private_T_T_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000807 RID: 2055
		private sealed class MethodInfoStoreGeneric_AddCommandBuffer_Private_CommandBuffer_CameraEvent_String_0<T>
		{
			// Token: 0x04008018 RID: 32792
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessingBehaviour.NativeMethodInfoPtr_AddCommandBuffer_Private_CommandBuffer_CameraEvent_String_0, Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000808 RID: 2056
		private sealed class MethodInfoStoreGeneric_RemoveCommandBuffer_Private_Void_0<T>
		{
			// Token: 0x04008019 RID: 32793
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessingBehaviour.NativeMethodInfoPtr_RemoveCommandBuffer_Private_Void_0, Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000809 RID: 2057
		private sealed class MethodInfoStoreGeneric_GetCommandBuffer_Private_CommandBuffer_CameraEvent_String_0<T>
		{
			// Token: 0x0400801A RID: 32794
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessingBehaviour.NativeMethodInfoPtr_GetCommandBuffer_Private_CommandBuffer_CameraEvent_String_0, Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200080A RID: 2058
		private sealed class MethodInfoStoreGeneric_TryExecuteCommandBuffer_Private_Void_PostProcessingComponentCommandBuffer_1_T_0<T>
		{
			// Token: 0x0400801B RID: 32795
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessingBehaviour.NativeMethodInfoPtr_TryExecuteCommandBuffer_Private_Void_PostProcessingComponentCommandBuffer_1_T_0, Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200080B RID: 2059
		private sealed class MethodInfoStoreGeneric_TryPrepareUberImageEffect_Private_Boolean_PostProcessingComponentRenderTexture_1_T_Material_0<T>
		{
			// Token: 0x0400801C RID: 32796
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessingBehaviour.NativeMethodInfoPtr_TryPrepareUberImageEffect_Private_Boolean_PostProcessingComponentRenderTexture_1_T_Material_0, Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200080C RID: 2060
		private sealed class MethodInfoStoreGeneric_AddComponent_Private_T_T_0<T>
		{
			// Token: 0x0400801D RID: 32797
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessingBehaviour.NativeMethodInfoPtr_AddComponent_Private_T_T_0, Il2CppClassPointerStore<PostProcessingBehaviour>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
