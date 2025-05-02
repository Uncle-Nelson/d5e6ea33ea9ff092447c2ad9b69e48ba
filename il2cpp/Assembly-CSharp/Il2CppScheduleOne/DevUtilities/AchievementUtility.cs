using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200044B RID: 1099
	public class AchievementUtility : MonoBehaviour
	{
		// Token: 0x06005FB3 RID: 24499 RVA: 0x001B71FC File Offset: 0x001B53FC
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementUtility()
		{
			Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AchievementUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr);
			AchievementUtility.NativeFieldInfoPtr_Achievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr, "Achievement");
			AchievementUtility.NativeMethodInfoPtr_UnlockAchievement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr, 100675505);
			AchievementUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr, 100675506);
		}

		// Token: 0x06005FB4 RID: 24500 RVA: 0x001B7268 File Offset: 0x001B5468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198769, XrefRangeEnd = 198775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnlockAchievement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementUtility.NativeMethodInfoPtr_UnlockAchievement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x001B729C File Offset: 0x001B549C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AchievementUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FB6 RID: 24502 RVA: 0x0002D284 File Offset: 0x0002B484
		public AchievementUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x06005FB7 RID: 24503 RVA: 0x001B72D8 File Offset: 0x001B54D8
		// (set) Token: 0x06005FB8 RID: 24504 RVA: 0x0002D28D File Offset: 0x0002B48D
		public unsafe AchievementManager.EAchievement Achievement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementUtility.NativeFieldInfoPtr_Achievement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementUtility.NativeFieldInfoPtr_Achievement)) = value;
			}
		}

		// Token: 0x04004166 RID: 16742
		private static readonly IntPtr NativeFieldInfoPtr_Achievement;

		// Token: 0x04004167 RID: 16743
		private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Void_0;

		// Token: 0x04004168 RID: 16744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
