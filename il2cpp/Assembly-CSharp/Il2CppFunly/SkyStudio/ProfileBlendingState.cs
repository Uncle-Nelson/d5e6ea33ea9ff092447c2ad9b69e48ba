using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F3 RID: 243
	public sealed class ProfileBlendingState : ValueType
	{
		// Token: 0x060012CA RID: 4810 RVA: 0x000AC078 File Offset: 0x000AA278
		// Note: this type is marked as 'beforefieldinit'.
		static ProfileBlendingState()
		{
			Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ProfileBlendingState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr);
			ProfileBlendingState.NativeFieldInfoPtr_blendedProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, "blendedProfile");
			ProfileBlendingState.NativeFieldInfoPtr_fromProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, "fromProfile");
			ProfileBlendingState.NativeFieldInfoPtr_toProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, "toProfile");
			ProfileBlendingState.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, "progress");
			ProfileBlendingState.NativeFieldInfoPtr_outProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, "outProgress");
			ProfileBlendingState.NativeFieldInfoPtr_inProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, "inProgress");
			ProfileBlendingState.NativeFieldInfoPtr_timeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, "timeOfDay");
			ProfileBlendingState.NativeMethodInfoPtr__ctor_Public_Void_SkyProfile_SkyProfile_SkyProfile_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, 100665454);
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x000AC148 File Offset: 0x000AA348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89993, XrefRangeEnd = 89996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfileBlendingState(SkyProfile blendedProfile, SkyProfile fromProfile, SkyProfile toProfile, float progress, float outProgress, float inProgress, float timeOfDay) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(blendedProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fromProfile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toProfile);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outProgress;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inProgress;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfileBlendingState.NativeMethodInfoPtr__ctor_Public_Void_SkyProfile_SkyProfile_SkyProfile_Single_Single_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0000B4CE File Offset: 0x000096CE
		public ProfileBlendingState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0000B4D7 File Offset: 0x000096D7
		public ProfileBlendingState() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr))
		{
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x000AC1F4 File Offset: 0x000AA3F4
		// (set) Token: 0x060012CF RID: 4815 RVA: 0x0000B4E9 File Offset: 0x000096E9
		public unsafe SkyProfile blendedProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_blendedProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_blendedProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x000AC224 File Offset: 0x000AA424
		// (set) Token: 0x060012D1 RID: 4817 RVA: 0x0000B508 File Offset: 0x00009708
		public unsafe SkyProfile fromProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_fromProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_fromProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x000AC254 File Offset: 0x000AA454
		// (set) Token: 0x060012D3 RID: 4819 RVA: 0x0000B527 File Offset: 0x00009727
		public unsafe SkyProfile toProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_toProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_toProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x000AC284 File Offset: 0x000AA484
		// (set) Token: 0x060012D5 RID: 4821 RVA: 0x0000B546 File Offset: 0x00009746
		public unsafe float progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_progress)) = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x000AC2AC File Offset: 0x000AA4AC
		// (set) Token: 0x060012D7 RID: 4823 RVA: 0x0000B561 File Offset: 0x00009761
		public unsafe float outProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_outProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_outProgress)) = value;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x000AC2D4 File Offset: 0x000AA4D4
		// (set) Token: 0x060012D9 RID: 4825 RVA: 0x0000B57C File Offset: 0x0000977C
		public unsafe float inProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_inProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_inProgress)) = value;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x000AC2FC File Offset: 0x000AA4FC
		// (set) Token: 0x060012DB RID: 4827 RVA: 0x0000B597 File Offset: 0x00009797
		public unsafe float timeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_timeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfileBlendingState.NativeFieldInfoPtr_timeOfDay)) = value;
			}
		}

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeFieldInfoPtr_blendedProfile;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeFieldInfoPtr_fromProfile;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeFieldInfoPtr_toProfile;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeFieldInfoPtr_progress;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeFieldInfoPtr_outProgress;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeFieldInfoPtr_inProgress;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeFieldInfoPtr_timeOfDay;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SkyProfile_SkyProfile_SkyProfile_Single_Single_Single_Single_0;
	}
}
