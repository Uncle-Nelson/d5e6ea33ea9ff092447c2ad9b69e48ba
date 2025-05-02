using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000134 RID: 308
	public class SkyStudioSetupURPPipeline : MonoBehaviour
	{
		// Token: 0x06001A1C RID: 6684 RVA: 0x000C2214 File Offset: 0x000C0414
		// Note: this type is marked as 'beforefieldinit'.
		static SkyStudioSetupURPPipeline()
		{
			Il2CppClassPointerStore<SkyStudioSetupURPPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SkyStudioSetupURPPipeline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyStudioSetupURPPipeline>.NativeClassPtr);
			SkyStudioSetupURPPipeline.NativeFieldInfoPtr_pipelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyStudioSetupURPPipeline>.NativeClassPtr, "pipelineAsset");
			SkyStudioSetupURPPipeline.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyStudioSetupURPPipeline>.NativeClassPtr, 100666062);
			SkyStudioSetupURPPipeline.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyStudioSetupURPPipeline>.NativeClassPtr, 100666063);
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x000C2280 File Offset: 0x000C0480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96929, XrefRangeEnd = 96936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyStudioSetupURPPipeline.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000C22B4 File Offset: 0x000C04B4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkyStudioSetupURPPipeline() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyStudioSetupURPPipeline>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyStudioSetupURPPipeline.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0000EDDA File Offset: 0x0000CFDA
		public SkyStudioSetupURPPipeline(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x000C22F0 File Offset: 0x000C04F0
		// (set) Token: 0x06001A21 RID: 6689 RVA: 0x0000EDE3 File Offset: 0x0000CFE3
		public unsafe RenderPipelineAsset pipelineAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyStudioSetupURPPipeline.NativeFieldInfoPtr_pipelineAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyStudioSetupURPPipeline.NativeFieldInfoPtr_pipelineAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeFieldInfoPtr_pipelineAsset;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
