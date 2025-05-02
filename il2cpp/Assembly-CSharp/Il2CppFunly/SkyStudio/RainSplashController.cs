using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200012A RID: 298
	public class RainSplashController : MonoBehaviour
	{
		// Token: 0x0600197B RID: 6523 RVA: 0x000C0394 File Offset: 0x000BE594
		// Note: this type is marked as 'beforefieldinit'.
		static RainSplashController()
		{
			Il2CppClassPointerStore<RainSplashController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RainSplashController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr);
			RainSplashController.NativeFieldInfoPtr_m_SkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, "m_SkyProfile");
			RainSplashController.NativeFieldInfoPtr_m_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, "m_TimeOfDay");
			RainSplashController.NativeFieldInfoPtr_m_SplashRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, "m_SplashRenderers");
			RainSplashController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, 100666009);
			RainSplashController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, 100666010);
			RainSplashController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, 100666011);
			RainSplashController.NativeMethodInfoPtr_ClearSplashRenderers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, 100666012);
			RainSplashController.NativeMethodInfoPtr_CreateSplashRenderers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, 100666013);
			RainSplashController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr, 100666014);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x000C0478 File Offset: 0x000BE678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96430, XrefRangeEnd = 96439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x000C04AC File Offset: 0x000BE6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skyProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x000C04FC File Offset: 0x000BE6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96439, XrefRangeEnd = 96468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x000C0530 File Offset: 0x000BE730
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96481, RefRangeEnd = 96484, XrefRangeStart = 96468, XrefRangeEnd = 96481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSplashRenderers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashController.NativeMethodInfoPtr_ClearSplashRenderers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x000C0564 File Offset: 0x000BE764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96503, RefRangeEnd = 96504, XrefRangeStart = 96484, XrefRangeEnd = 96503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateSplashRenderers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashController.NativeMethodInfoPtr_CreateSplashRenderers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x000C0598 File Offset: 0x000BE798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96504, XrefRangeEnd = 96512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RainSplashController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RainSplashController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x0000E85A File Offset: 0x0000CA5A
		public RainSplashController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x000C05D4 File Offset: 0x000BE7D4
		// (set) Token: 0x06001984 RID: 6532 RVA: 0x0000E863 File Offset: 0x0000CA63
		public unsafe SkyProfile m_SkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashController.NativeFieldInfoPtr_m_SkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashController.NativeFieldInfoPtr_m_SkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001985 RID: 6533 RVA: 0x000C0604 File Offset: 0x000BE804
		// (set) Token: 0x06001986 RID: 6534 RVA: 0x0000E882 File Offset: 0x0000CA82
		public unsafe float m_TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashController.NativeFieldInfoPtr_m_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashController.NativeFieldInfoPtr_m_TimeOfDay)) = value;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x000C062C File Offset: 0x000BE82C
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x0000E89D File Offset: 0x0000CA9D
		public unsafe List<RainSplashRenderer> m_SplashRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashController.NativeFieldInfoPtr_m_SplashRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RainSplashRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashController.NativeFieldInfoPtr_m_SplashRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyProfile;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeOfDay;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeFieldInfoPtr_m_SplashRenderers;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr_ClearSplashRenderers_Public_Void_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr_CreateSplashRenderers_Public_Void_0;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
