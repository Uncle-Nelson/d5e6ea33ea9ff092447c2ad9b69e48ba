using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000135 RID: 309
	public class URPWeatherDepth : MonoBehaviour
	{
		// Token: 0x06001A22 RID: 6690 RVA: 0x000C2320 File Offset: 0x000C0520
		// Note: this type is marked as 'beforefieldinit'.
		static URPWeatherDepth()
		{
			Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "URPWeatherDepth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr);
			URPWeatherDepth.NativeFieldInfoPtr_renderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr, "renderTexture");
			URPWeatherDepth.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr, "m_Camera");
			URPWeatherDepth.NativeFieldInfoPtr_m_CameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr, "m_CameraData");
			URPWeatherDepth.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr, 100666064);
			URPWeatherDepth.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr, 100666065);
			URPWeatherDepth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr, 100666066);
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000C23C8 File Offset: 0x000C05C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96936, XrefRangeEnd = 96944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(URPWeatherDepth.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x000C23FC File Offset: 0x000C05FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96944, XrefRangeEnd = 96961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(URPWeatherDepth.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x000C2430 File Offset: 0x000C0630
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe URPWeatherDepth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(URPWeatherDepth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x0000EE02 File Offset: 0x0000D002
		public URPWeatherDepth(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x000C246C File Offset: 0x000C066C
		// (set) Token: 0x06001A28 RID: 6696 RVA: 0x0000EE0B File Offset: 0x0000D00B
		public unsafe RenderTexture renderTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(URPWeatherDepth.NativeFieldInfoPtr_renderTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(URPWeatherDepth.NativeFieldInfoPtr_renderTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x000C249C File Offset: 0x000C069C
		// (set) Token: 0x06001A2A RID: 6698 RVA: 0x0000EE2A File Offset: 0x0000D02A
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(URPWeatherDepth.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(URPWeatherDepth.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001A2B RID: 6699 RVA: 0x000C24CC File Offset: 0x000C06CC
		// (set) Token: 0x06001A2C RID: 6700 RVA: 0x0000EE49 File Offset: 0x0000D049
		public unsafe UniversalAdditionalCameraData m_CameraData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(URPWeatherDepth.NativeFieldInfoPtr_m_CameraData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalAdditionalCameraData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(URPWeatherDepth.NativeFieldInfoPtr_m_CameraData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeFieldInfoPtr_renderTexture;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraData;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
