using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppVLB
{
	// Token: 0x020000B1 RID: 177
	public static class SRPHelper : Il2CppSystem.Object
	{
		// Token: 0x06000D2A RID: 3370 RVA: 0x0009A9AC File Offset: 0x00098BAC
		// Note: this type is marked as 'beforefieldinit'.
		static SRPHelper()
		{
			Il2CppClassPointerStore<SRPHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "SRPHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr);
			SRPHelper.NativeFieldInfoPtr_m_IsRenderPipelineCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, "m_IsRenderPipelineCached");
			SRPHelper.NativeFieldInfoPtr_m_RenderPipelineCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, "m_RenderPipelineCached");
			SRPHelper.NativeMethodInfoPtr_get_renderPipelineScriptingDefineSymbolAsString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, 100664905);
			SRPHelper.NativeMethodInfoPtr_get_projectRenderPipeline_Public_Static_get_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, 100664906);
			SRPHelper.NativeMethodInfoPtr_ComputeRenderPipeline_Private_Static_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, 100664907);
			SRPHelper.NativeMethodInfoPtr_IsUsingCustomRenderPipeline_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, 100664908);
			SRPHelper.NativeMethodInfoPtr_RegisterOnBeginCameraRendering_Public_Static_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, 100664909);
			SRPHelper.NativeMethodInfoPtr_UnregisterOnBeginCameraRendering_Public_Static_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, 100664910);
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x0009AA7C File Offset: 0x00098C7C
		public unsafe static string renderPipelineScriptingDefineSymbolAsString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84401, XrefRangeEnd = 84403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPHelper.NativeMethodInfoPtr_get_renderPipelineScriptingDefineSymbolAsString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x0009AAA8 File Offset: 0x00098CA8
		public unsafe static RenderPipeline projectRenderPipeline
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 84425, RefRangeEnd = 84437, XrefRangeStart = 84403, XrefRangeEnd = 84425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPHelper.NativeMethodInfoPtr_get_projectRenderPipeline_Public_Static_get_RenderPipeline_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0009AAD8 File Offset: 0x00098CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84437, XrefRangeEnd = 84452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderPipeline ComputeRenderPipeline()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPHelper.NativeMethodInfoPtr_ComputeRenderPipeline_Private_Static_RenderPipeline_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0009AB08 File Offset: 0x00098D08
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 84460, RefRangeEnd = 84470, XrefRangeStart = 84452, XrefRangeEnd = 84460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUsingCustomRenderPipeline()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPHelper.NativeMethodInfoPtr_IsUsingCustomRenderPipeline_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0009AB38 File Offset: 0x00098D38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84476, RefRangeEnd = 84477, XrefRangeStart = 84470, XrefRangeEnd = 84476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPHelper.NativeMethodInfoPtr_RegisterOnBeginCameraRendering_Public_Static_Void_Action_2_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0009AB70 File Offset: 0x00098D70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84482, RefRangeEnd = 84483, XrefRangeStart = 84477, XrefRangeEnd = 84482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPHelper.NativeMethodInfoPtr_UnregisterOnBeginCameraRendering_Public_Static_Void_Action_2_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0000877C File Offset: 0x0000697C
		public SRPHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x0009ABA8 File Offset: 0x00098DA8
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x00008785 File Offset: 0x00006985
		public unsafe static bool m_IsRenderPipelineCached
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(SRPHelper.NativeFieldInfoPtr_m_IsRenderPipelineCached, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SRPHelper.NativeFieldInfoPtr_m_IsRenderPipelineCached, (void*)(&value));
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x0009ABC4 File Offset: 0x00098DC4
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x00008793 File Offset: 0x00006993
		public unsafe static RenderPipeline m_RenderPipelineCached
		{
			get
			{
				RenderPipeline result;
				IL2CPP.il2cpp_field_static_get_value(SRPHelper.NativeFieldInfoPtr_m_RenderPipelineCached, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SRPHelper.NativeFieldInfoPtr_m_RenderPipelineCached, (void*)(&value));
			}
		}

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeFieldInfoPtr_m_IsRenderPipelineCached;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderPipelineCached;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_get_renderPipelineScriptingDefineSymbolAsString_Public_Static_get_String_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_get_projectRenderPipeline_Public_Static_get_RenderPipeline_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_ComputeRenderPipeline_Private_Static_RenderPipeline_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_IsUsingCustomRenderPipeline_Public_Static_Boolean_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnBeginCameraRendering_Public_Static_Void_Action_2_ScriptableRenderContext_Camera_0;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterOnBeginCameraRendering_Public_Static_Void_Action_2_ScriptableRenderContext_Camera_0;
	}
}
