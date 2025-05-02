using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000126 RID: 294
	public class LightningController : MonoBehaviour
	{
		// Token: 0x06001929 RID: 6441 RVA: 0x000BF2B4 File Offset: 0x000BD4B4
		// Note: this type is marked as 'beforefieldinit'.
		static LightningController()
		{
			Il2CppClassPointerStore<LightningController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "LightningController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningController>.NativeClassPtr);
			LightningController.NativeFieldInfoPtr_m_SkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningController>.NativeClassPtr, "m_SkyProfile");
			LightningController.NativeFieldInfoPtr_m_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningController>.NativeClassPtr, "m_TimeOfDay");
			LightningController.NativeFieldInfoPtr_m_LightningRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningController>.NativeClassPtr, "m_LightningRenderers");
			LightningController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningController>.NativeClassPtr, 100665976);
			LightningController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningController>.NativeClassPtr, 100665977);
			LightningController.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningController>.NativeClassPtr, 100665978);
			LightningController.NativeMethodInfoPtr_ClearLightningRenderers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningController>.NativeClassPtr, 100665979);
			LightningController.NativeMethodInfoPtr_CreateLightningRenderers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningController>.NativeClassPtr, 100665980);
			LightningController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningController>.NativeClassPtr, 100665981);
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x000BF398 File Offset: 0x000BD598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95958, XrefRangeEnd = 95967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x000BF3CC File Offset: 0x000BD5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95967, XrefRangeEnd = 95968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skyProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x000BF41C File Offset: 0x000BD61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95968, XrefRangeEnd = 96012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningController.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x000BF450 File Offset: 0x000BD650
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96025, RefRangeEnd = 96028, XrefRangeStart = 96012, XrefRangeEnd = 96025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLightningRenderers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningController.NativeMethodInfoPtr_ClearLightningRenderers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x000BF484 File Offset: 0x000BD684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96047, RefRangeEnd = 96048, XrefRangeStart = 96028, XrefRangeEnd = 96047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateLightningRenderers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningController.NativeMethodInfoPtr_CreateLightningRenderers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x000BF4B8 File Offset: 0x000BD6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96048, XrefRangeEnd = 96056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightningController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x0000E5ED File Offset: 0x0000C7ED
		public LightningController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x000BF4F4 File Offset: 0x000BD6F4
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x0000E5F6 File Offset: 0x0000C7F6
		public unsafe SkyProfile m_SkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningController.NativeFieldInfoPtr_m_SkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningController.NativeFieldInfoPtr_m_SkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x000BF524 File Offset: 0x000BD724
		// (set) Token: 0x06001934 RID: 6452 RVA: 0x0000E615 File Offset: 0x0000C815
		public unsafe float m_TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningController.NativeFieldInfoPtr_m_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningController.NativeFieldInfoPtr_m_TimeOfDay)) = value;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x000BF54C File Offset: 0x000BD74C
		// (set) Token: 0x06001936 RID: 6454 RVA: 0x0000E630 File Offset: 0x0000C830
		public unsafe List<LightningRenderer> m_LightningRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningController.NativeFieldInfoPtr_m_LightningRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LightningRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningController.NativeFieldInfoPtr_m_LightningRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyProfile;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeOfDay;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeFieldInfoPtr_m_LightningRenderers;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr_ClearLightningRenderers_Public_Void_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_CreateLightningRenderers_Public_Void_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
