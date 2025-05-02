using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200011D RID: 285
	public class LoadOverheadDepthTexture : MonoBehaviour
	{
		// Token: 0x06001864 RID: 6244 RVA: 0x000BC7E8 File Offset: 0x000BA9E8
		// Note: this type is marked as 'beforefieldinit'.
		static LoadOverheadDepthTexture()
		{
			Il2CppClassPointerStore<LoadOverheadDepthTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "LoadOverheadDepthTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadOverheadDepthTexture>.NativeClassPtr);
			LoadOverheadDepthTexture.NativeFieldInfoPtr_m_RainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadOverheadDepthTexture>.NativeClassPtr, "m_RainCamera");
			LoadOverheadDepthTexture.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadOverheadDepthTexture>.NativeClassPtr, 100665893);
			LoadOverheadDepthTexture.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadOverheadDepthTexture>.NativeClassPtr, 100665894);
			LoadOverheadDepthTexture.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadOverheadDepthTexture>.NativeClassPtr, 100665895);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x000BC868 File Offset: 0x000BAA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95292, XrefRangeEnd = 95299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadOverheadDepthTexture.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x000BC89C File Offset: 0x000BAA9C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadOverheadDepthTexture.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x000BC8D0 File Offset: 0x000BAAD0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadOverheadDepthTexture() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadOverheadDepthTexture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadOverheadDepthTexture.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0000E083 File Offset: 0x0000C283
		public LoadOverheadDepthTexture(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x000BC90C File Offset: 0x000BAB0C
		// (set) Token: 0x0600186A RID: 6250 RVA: 0x0000E08C File Offset: 0x0000C28C
		public unsafe WeatherDepthCamera m_RainCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadOverheadDepthTexture.NativeFieldInfoPtr_m_RainCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherDepthCamera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadOverheadDepthTexture.NativeFieldInfoPtr_m_RainCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeFieldInfoPtr_m_RainCamera;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
