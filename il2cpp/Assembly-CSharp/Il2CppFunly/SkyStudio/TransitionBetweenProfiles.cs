using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000131 RID: 305
	public class TransitionBetweenProfiles : MonoBehaviour
	{
		// Token: 0x06001A06 RID: 6662 RVA: 0x000C1EA0 File Offset: 0x000C00A0
		// Note: this type is marked as 'beforefieldinit'.
		static TransitionBetweenProfiles()
		{
			Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "TransitionBetweenProfiles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr);
			TransitionBetweenProfiles.NativeFieldInfoPtr_daySkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, "daySkyProfile");
			TransitionBetweenProfiles.NativeFieldInfoPtr_nightSkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, "nightSkyProfile");
			TransitionBetweenProfiles.NativeFieldInfoPtr_transitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, "transitionDuration");
			TransitionBetweenProfiles.NativeFieldInfoPtr_timeOfDayController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, "timeOfDayController");
			TransitionBetweenProfiles.NativeFieldInfoPtr_m_CurrentSkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, "m_CurrentSkyProfile");
			TransitionBetweenProfiles.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, 100666058);
			TransitionBetweenProfiles.NativeMethodInfoPtr_ToggleSkyProfiles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, 100666059);
			TransitionBetweenProfiles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr, 100666060);
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x000C1F70 File Offset: 0x000C0170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96908, XrefRangeEnd = 96918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionBetweenProfiles.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x000C1FA4 File Offset: 0x000C01A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96918, XrefRangeEnd = 96926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleSkyProfiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionBetweenProfiles.NativeMethodInfoPtr_ToggleSkyProfiles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x000C1FD8 File Offset: 0x000C01D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96926, XrefRangeEnd = 96927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitionBetweenProfiles() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionBetweenProfiles>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionBetweenProfiles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0000ECF7 File Offset: 0x0000CEF7
		public TransitionBetweenProfiles(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x000C2014 File Offset: 0x000C0214
		// (set) Token: 0x06001A0C RID: 6668 RVA: 0x0000ED00 File Offset: 0x0000CF00
		public unsafe SkyProfile daySkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_daySkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_daySkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x000C2044 File Offset: 0x000C0244
		// (set) Token: 0x06001A0E RID: 6670 RVA: 0x0000ED1F File Offset: 0x0000CF1F
		public unsafe SkyProfile nightSkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_nightSkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_nightSkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x000C2074 File Offset: 0x000C0274
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x0000ED3E File Offset: 0x0000CF3E
		public unsafe float transitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_transitionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_transitionDuration)) = value;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x000C209C File Offset: 0x000C029C
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x0000ED59 File Offset: 0x0000CF59
		public unsafe TimeOfDayController timeOfDayController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_timeOfDayController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeOfDayController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_timeOfDayController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x000C20CC File Offset: 0x000C02CC
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x0000ED78 File Offset: 0x0000CF78
		public unsafe SkyProfile m_CurrentSkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_m_CurrentSkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionBetweenProfiles.NativeFieldInfoPtr_m_CurrentSkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeFieldInfoPtr_daySkyProfile;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeFieldInfoPtr_nightSkyProfile;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeFieldInfoPtr_transitionDuration;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeFieldInfoPtr_timeOfDayController;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSkyProfile;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_ToggleSkyProfiles_Public_Void_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
