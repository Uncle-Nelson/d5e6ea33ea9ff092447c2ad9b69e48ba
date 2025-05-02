using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne
{
	// Token: 0x0200016B RID: 363
	public class AchievementManager : PersistentSingleton<AchievementManager>
	{
		// Token: 0x06001D70 RID: 7536 RVA: 0x000CC014 File Offset: 0x000CA214
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementManager()
		{
			Il2CppClassPointerStore<AchievementManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "AchievementManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr);
			AchievementManager.NativeFieldInfoPtr_achievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "achievements");
			AchievementManager.NativeFieldInfoPtr_achievementUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "achievementUnlocked");
			AchievementManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666644);
			AchievementManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666645);
			AchievementManager.NativeMethodInfoPtr_PullAchievements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666646);
			AchievementManager.NativeMethodInfoPtr_UnlockAchievement_Public_Void_EAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666647);
			AchievementManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100666648);
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x000CC0D0 File Offset: 0x000CA2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105986, XrefRangeEnd = 106024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AchievementManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x000CC10C File Offset: 0x000CA30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106024, XrefRangeEnd = 106059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AchievementManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x000CC148 File Offset: 0x000CA348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106059, XrefRangeEnd = 106077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PullAchievements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_PullAchievements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x000CC17C File Offset: 0x000CA37C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 106102, RefRangeEnd = 106111, XrefRangeStart = 106077, XrefRangeEnd = 106102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnlockAchievement(AchievementManager.EAchievement achievement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref achievement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_UnlockAchievement_Public_Void_EAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x000CC1BC File Offset: 0x000CA3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106111, XrefRangeEnd = 106121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AchievementManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00010A5D File Offset: 0x0000EC5D
		public AchievementManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x000CC1F8 File Offset: 0x000CA3F8
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x00010A66 File Offset: 0x0000EC66
		public unsafe Il2CppStructArray<AchievementManager.EAchievement> achievements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_achievements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AchievementManager.EAchievement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_achievements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x000CC228 File Offset: 0x000CA428
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x00010A85 File Offset: 0x0000EC85
		public unsafe Dictionary<AchievementManager.EAchievement, bool> achievementUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_achievementUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AchievementManager.EAchievement, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_achievementUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeFieldInfoPtr_achievements;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeFieldInfoPtr_achievementUnlocked;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_PullAchievements_Private_Void_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Void_EAchievement_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008A7 RID: 2215
		[OriginalName("Assembly-CSharp.dll", "", "EAchievement")]
		public enum EAchievement
		{
			// Token: 0x04008410 RID: 33808
			COMPLETE_PROLOGUE,
			// Token: 0x04008411 RID: 33809
			RV_DESTROYED,
			// Token: 0x04008412 RID: 33810
			DEALER_RECRUITED,
			// Token: 0x04008413 RID: 33811
			MASTER_CHEF,
			// Token: 0x04008414 RID: 33812
			BUSINESSMAN,
			// Token: 0x04008415 RID: 33813
			BIGWIG,
			// Token: 0x04008416 RID: 33814
			MAGNATE,
			// Token: 0x04008417 RID: 33815
			UPSTANDING_CITIZEN,
			// Token: 0x04008418 RID: 33816
			ROLLING_IN_STYLE,
			// Token: 0x04008419 RID: 33817
			LONG_ARM_OF_THE_LAW,
			// Token: 0x0400841A RID: 33818
			INDIAN_DEALER
		}
	}
}
