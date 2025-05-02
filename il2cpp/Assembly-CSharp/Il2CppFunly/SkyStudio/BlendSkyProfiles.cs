using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F0 RID: 240
	public class BlendSkyProfiles : MonoBehaviour
	{
		// Token: 0x06001285 RID: 4741 RVA: 0x000AB2B4 File Offset: 0x000A94B4
		// Note: this type is marked as 'beforefieldinit'.
		static BlendSkyProfiles()
		{
			Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BlendSkyProfiles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr);
			BlendSkyProfiles.NativeFieldInfoPtr__fromProfile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "<fromProfile>k__BackingField");
			BlendSkyProfiles.NativeFieldInfoPtr__toProfile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "<toProfile>k__BackingField");
			BlendSkyProfiles.NativeFieldInfoPtr__blendedProfile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "<blendedProfile>k__BackingField");
			BlendSkyProfiles.NativeFieldInfoPtr_onBlendComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "onBlendComplete");
			BlendSkyProfiles.NativeFieldInfoPtr_m_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "m_StartTime");
			BlendSkyProfiles.NativeFieldInfoPtr_m_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "m_EndTime");
			BlendSkyProfiles.NativeFieldInfoPtr_skyBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "skyBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_sunBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "sunBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_moonBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "moonBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_cloudBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "cloudBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_starLayer1Blender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "starLayer1Blender");
			BlendSkyProfiles.NativeFieldInfoPtr_starLayer2Blender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "starLayer2Blender");
			BlendSkyProfiles.NativeFieldInfoPtr_starLayer3Blender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "starLayer3Blender");
			BlendSkyProfiles.NativeFieldInfoPtr_rainBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "rainBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_rainSplashBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "rainSplashBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_lightningBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "lightningBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_fogBlender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "fogBlender");
			BlendSkyProfiles.NativeFieldInfoPtr_m_IsBlendingFirstHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "m_IsBlendingFirstHalf");
			BlendSkyProfiles.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "m_State");
			BlendSkyProfiles.NativeFieldInfoPtr_m_TimeOfDayController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "m_TimeOfDayController");
			BlendSkyProfiles.NativeFieldInfoPtr_blendingHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, "blendingHelper");
			BlendSkyProfiles.NativeMethodInfoPtr_get_fromProfile_Public_get_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665433);
			BlendSkyProfiles.NativeMethodInfoPtr_set_fromProfile_Private_set_Void_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665434);
			BlendSkyProfiles.NativeMethodInfoPtr_get_toProfile_Public_get_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665435);
			BlendSkyProfiles.NativeMethodInfoPtr_set_toProfile_Private_set_Void_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665436);
			BlendSkyProfiles.NativeMethodInfoPtr_get_blendedProfile_Public_get_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665437);
			BlendSkyProfiles.NativeMethodInfoPtr_set_blendedProfile_Private_set_Void_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665438);
			BlendSkyProfiles.NativeMethodInfoPtr_StartBlending_Public_SkyProfile_TimeOfDayController_SkyProfile_SkyProfile_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665439);
			BlendSkyProfiles.NativeMethodInfoPtr_CancelBlending_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665440);
			BlendSkyProfiles.NativeMethodInfoPtr_TearDownBlending_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665441);
			BlendSkyProfiles.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665442);
			BlendSkyProfiles.NativeMethodInfoPtr_UpdateBlendedProfile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665443);
			BlendSkyProfiles.NativeMethodInfoPtr_PercentForMode_Private_Single_ProfileFeatureBlendingMode_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665444);
			BlendSkyProfiles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr, 100665445);
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x000AB58C File Offset: 0x000A978C
		// (set) Token: 0x06001287 RID: 4743 RVA: 0x000AB5CC File Offset: 0x000A97CC
		public unsafe SkyProfile fromProfile
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_get_fromProfile_Public_get_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_set_fromProfile_Private_set_Void_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x000AB610 File Offset: 0x000A9810
		// (set) Token: 0x06001289 RID: 4745 RVA: 0x000AB650 File Offset: 0x000A9850
		public unsafe SkyProfile toProfile
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_get_toProfile_Public_get_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_set_toProfile_Private_set_Void_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x000AB694 File Offset: 0x000A9894
		// (set) Token: 0x0600128B RID: 4747 RVA: 0x000AB6D4 File Offset: 0x000A98D4
		public unsafe SkyProfile blendedProfile
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_get_blendedProfile_Public_get_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_set_blendedProfile_Private_set_Void_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x000AB718 File Offset: 0x000A9918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89918, RefRangeEnd = 89919, XrefRangeStart = 89852, XrefRangeEnd = 89918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkyProfile StartBlending(TimeOfDayController controller, SkyProfile fromProfile, SkyProfile toProfile, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fromProfile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toProfile);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_StartBlending_Public_SkyProfile_TimeOfDayController_SkyProfile_SkyProfile_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr3) : null;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x000AB79C File Offset: 0x000A999C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89919, XrefRangeEnd = 89920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelBlending()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_CancelBlending_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x000AB7D0 File Offset: 0x000A99D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 89931, RefRangeEnd = 89935, XrefRangeStart = 89920, XrefRangeEnd = 89931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TearDownBlending()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_TearDownBlending_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x000AB804 File Offset: 0x000A9A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89935, XrefRangeEnd = 89940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x000AB838 File Offset: 0x000A9A38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89988, RefRangeEnd = 89990, XrefRangeStart = 89940, XrefRangeEnd = 89988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBlendedProfile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_UpdateBlendedProfile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x000AB86C File Offset: 0x000A9A6C
		[CallerCount(0)]
		public unsafe float PercentForMode(ProfileFeatureBlendingMode mode, float percent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr_PercentForMode_Private_Single_ProfileFeatureBlendingMode_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x000AB8C4 File Offset: 0x000A9AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89990, XrefRangeEnd = 89991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlendSkyProfiles() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlendSkyProfiles>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendSkyProfiles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0000B1F6 File Offset: 0x000093F6
		public BlendSkyProfiles(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x000AB900 File Offset: 0x000A9B00
		// (set) Token: 0x06001295 RID: 4757 RVA: 0x0000B1FF File Offset: 0x000093FF
		public unsafe SkyProfile _fromProfile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr__fromProfile_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr__fromProfile_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x000AB930 File Offset: 0x000A9B30
		// (set) Token: 0x06001297 RID: 4759 RVA: 0x0000B21E File Offset: 0x0000941E
		public unsafe SkyProfile _toProfile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr__toProfile_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr__toProfile_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x000AB960 File Offset: 0x000A9B60
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x0000B23D File Offset: 0x0000943D
		public unsafe SkyProfile _blendedProfile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr__blendedProfile_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr__blendedProfile_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x000AB990 File Offset: 0x000A9B90
		// (set) Token: 0x0600129B RID: 4763 RVA: 0x0000B25C File Offset: 0x0000945C
		public unsafe Action<BlendSkyProfiles> onBlendComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_onBlendComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BlendSkyProfiles>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_onBlendComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x000AB9C0 File Offset: 0x000A9BC0
		// (set) Token: 0x0600129D RID: 4765 RVA: 0x0000B27B File Offset: 0x0000947B
		public unsafe float m_StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_StartTime)) = value;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x000AB9E8 File Offset: 0x000A9BE8
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x0000B296 File Offset: 0x00009496
		public unsafe float m_EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_EndTime)) = value;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x000ABA10 File Offset: 0x000A9C10
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x0000B2B1 File Offset: 0x000094B1
		public unsafe FeatureBlender skyBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_skyBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_skyBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x000ABA40 File Offset: 0x000A9C40
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x0000B2D0 File Offset: 0x000094D0
		public unsafe FeatureBlender sunBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_sunBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_sunBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x000ABA70 File Offset: 0x000A9C70
		// (set) Token: 0x060012A5 RID: 4773 RVA: 0x0000B2EF File Offset: 0x000094EF
		public unsafe FeatureBlender moonBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_moonBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_moonBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x000ABAA0 File Offset: 0x000A9CA0
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x0000B30E File Offset: 0x0000950E
		public unsafe FeatureBlender cloudBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_cloudBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_cloudBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x000ABAD0 File Offset: 0x000A9CD0
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x0000B32D File Offset: 0x0000952D
		public unsafe FeatureBlender starLayer1Blender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_starLayer1Blender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_starLayer1Blender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x000ABB00 File Offset: 0x000A9D00
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x0000B34C File Offset: 0x0000954C
		public unsafe FeatureBlender starLayer2Blender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_starLayer2Blender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_starLayer2Blender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x000ABB30 File Offset: 0x000A9D30
		// (set) Token: 0x060012AD RID: 4781 RVA: 0x0000B36B File Offset: 0x0000956B
		public unsafe FeatureBlender starLayer3Blender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_starLayer3Blender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_starLayer3Blender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x000ABB60 File Offset: 0x000A9D60
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x0000B38A File Offset: 0x0000958A
		public unsafe FeatureBlender rainBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_rainBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_rainBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x000ABB90 File Offset: 0x000A9D90
		// (set) Token: 0x060012B1 RID: 4785 RVA: 0x0000B3A9 File Offset: 0x000095A9
		public unsafe FeatureBlender rainSplashBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_rainSplashBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_rainSplashBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x000ABBC0 File Offset: 0x000A9DC0
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x0000B3C8 File Offset: 0x000095C8
		public unsafe FeatureBlender lightningBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_lightningBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_lightningBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x000ABBF0 File Offset: 0x000A9DF0
		// (set) Token: 0x060012B5 RID: 4789 RVA: 0x0000B3E7 File Offset: 0x000095E7
		public unsafe FeatureBlender fogBlender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_fogBlender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureBlender>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_fogBlender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x000ABC20 File Offset: 0x000A9E20
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x0000B406 File Offset: 0x00009606
		public unsafe bool m_IsBlendingFirstHalf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_IsBlendingFirstHalf);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_IsBlendingFirstHalf)) = value;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x000ABC48 File Offset: 0x000A9E48
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x0000B421 File Offset: 0x00009621
		public ProfileBlendingState m_State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_State);
				return new ProfileBlendingState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_State), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x000ABC78 File Offset: 0x000A9E78
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x0000B44F File Offset: 0x0000964F
		public unsafe TimeOfDayController m_TimeOfDayController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_TimeOfDayController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeOfDayController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_m_TimeOfDayController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x000ABCA8 File Offset: 0x000A9EA8
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x0000B46E File Offset: 0x0000966E
		public unsafe BlendingHelper blendingHelper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_blendingHelper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlendingHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendSkyProfiles.NativeFieldInfoPtr_blendingHelper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeFieldInfoPtr__fromProfile_k__BackingField;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeFieldInfoPtr__toProfile_k__BackingField;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeFieldInfoPtr__blendedProfile_k__BackingField;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeFieldInfoPtr_onBlendComplete;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeFieldInfoPtr_m_StartTime;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeFieldInfoPtr_m_EndTime;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeFieldInfoPtr_skyBlender;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeFieldInfoPtr_sunBlender;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeFieldInfoPtr_moonBlender;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeFieldInfoPtr_cloudBlender;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeFieldInfoPtr_starLayer1Blender;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeFieldInfoPtr_starLayer2Blender;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeFieldInfoPtr_starLayer3Blender;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeFieldInfoPtr_rainBlender;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeFieldInfoPtr_rainSplashBlender;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeFieldInfoPtr_lightningBlender;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeFieldInfoPtr_fogBlender;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeFieldInfoPtr_m_IsBlendingFirstHalf;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeFieldInfoPtr_m_State;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeOfDayController;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeFieldInfoPtr_blendingHelper;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_get_fromProfile_Public_get_SkyProfile_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_set_fromProfile_Private_set_Void_SkyProfile_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_get_toProfile_Public_get_SkyProfile_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_set_toProfile_Private_set_Void_SkyProfile_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_get_blendedProfile_Public_get_SkyProfile_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_set_blendedProfile_Private_set_Void_SkyProfile_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_StartBlending_Public_SkyProfile_TimeOfDayController_SkyProfile_SkyProfile_Single_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_CancelBlending_Public_Void_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_TearDownBlending_Public_Void_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBlendedProfile_Private_Void_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_PercentForMode_Private_Single_ProfileFeatureBlendingMode_Single_0;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
