using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200010B RID: 267
	public class ProfileSectionKeys : Object
	{
		// Token: 0x06001556 RID: 5462 RVA: 0x000B28B8 File Offset: 0x000B0AB8
		// Note: this type is marked as 'beforefieldinit'.
		static ProfileSectionKeys()
		{
			Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ProfileSectionKeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr);
			ProfileSectionKeys.NativeFieldInfoPtr_FeaturesSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "FeaturesSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_SkySectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "SkySectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_SunSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "SunSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_MoonSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "MoonSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_CloudSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "CloudSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_FogSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "FogSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_StarsBasicSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "StarsBasicSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_Star1SectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "Star1SectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_Star2SectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "Star2SectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_Star3SectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "Star3SectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_RainSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "RainSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_RainSplashSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "RainSplashSectionKey");
			ProfileSectionKeys.NativeFieldInfoPtr_LightningSectionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, "LightningSectionKey");
			ProfileSectionKeys.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr, 100665555);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x000B2A00 File Offset: 0x000B0C00
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfileSectionKeys() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileSectionKeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileSectionKeys.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x0000C9FC File Offset: 0x0000ABFC
		public ProfileSectionKeys(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x000B2A3C File Offset: 0x000B0C3C
		// (set) Token: 0x0600155A RID: 5466 RVA: 0x0000CA05 File Offset: 0x0000AC05
		public unsafe static string FeaturesSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_FeaturesSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_FeaturesSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600155B RID: 5467 RVA: 0x000B2A5C File Offset: 0x000B0C5C
		// (set) Token: 0x0600155C RID: 5468 RVA: 0x0000CA17 File Offset: 0x0000AC17
		public unsafe static string SkySectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_SkySectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_SkySectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x000B2A7C File Offset: 0x000B0C7C
		// (set) Token: 0x0600155E RID: 5470 RVA: 0x0000CA29 File Offset: 0x0000AC29
		public unsafe static string SunSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_SunSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_SunSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x000B2A9C File Offset: 0x000B0C9C
		// (set) Token: 0x06001560 RID: 5472 RVA: 0x0000CA3B File Offset: 0x0000AC3B
		public unsafe static string MoonSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_MoonSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_MoonSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x000B2ABC File Offset: 0x000B0CBC
		// (set) Token: 0x06001562 RID: 5474 RVA: 0x0000CA4D File Offset: 0x0000AC4D
		public unsafe static string CloudSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_CloudSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_CloudSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x000B2ADC File Offset: 0x000B0CDC
		// (set) Token: 0x06001564 RID: 5476 RVA: 0x0000CA5F File Offset: 0x0000AC5F
		public unsafe static string FogSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_FogSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_FogSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x000B2AFC File Offset: 0x000B0CFC
		// (set) Token: 0x06001566 RID: 5478 RVA: 0x0000CA71 File Offset: 0x0000AC71
		public unsafe static string StarsBasicSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_StarsBasicSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_StarsBasicSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x000B2B1C File Offset: 0x000B0D1C
		// (set) Token: 0x06001568 RID: 5480 RVA: 0x0000CA83 File Offset: 0x0000AC83
		public unsafe static string Star1SectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_Star1SectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_Star1SectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x000B2B3C File Offset: 0x000B0D3C
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x0000CA95 File Offset: 0x0000AC95
		public unsafe static string Star2SectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_Star2SectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_Star2SectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x000B2B5C File Offset: 0x000B0D5C
		// (set) Token: 0x0600156C RID: 5484 RVA: 0x0000CAA7 File Offset: 0x0000ACA7
		public unsafe static string Star3SectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_Star3SectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_Star3SectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x000B2B7C File Offset: 0x000B0D7C
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x0000CAB9 File Offset: 0x0000ACB9
		public unsafe static string RainSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_RainSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_RainSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x000B2B9C File Offset: 0x000B0D9C
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x0000CACB File Offset: 0x0000ACCB
		public unsafe static string RainSplashSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_RainSplashSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_RainSplashSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x000B2BBC File Offset: 0x000B0DBC
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x0000CADD File Offset: 0x0000ACDD
		public unsafe static string LightningSectionKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProfileSectionKeys.NativeFieldInfoPtr_LightningSectionKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfileSectionKeys.NativeFieldInfoPtr_LightningSectionKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeFieldInfoPtr_FeaturesSectionKey;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeFieldInfoPtr_SkySectionKey;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeFieldInfoPtr_SunSectionKey;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeFieldInfoPtr_MoonSectionKey;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeFieldInfoPtr_CloudSectionKey;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeFieldInfoPtr_FogSectionKey;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeFieldInfoPtr_StarsBasicSectionKey;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeFieldInfoPtr_Star1SectionKey;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeFieldInfoPtr_Star2SectionKey;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeFieldInfoPtr_Star3SectionKey;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeFieldInfoPtr_RainSectionKey;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeFieldInfoPtr_RainSplashSectionKey;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeFieldInfoPtr_LightningSectionKey;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
