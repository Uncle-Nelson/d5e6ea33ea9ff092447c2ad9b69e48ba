using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x02000608 RID: 1544
	[Serializable]
	public class AvatarEmotionPreset : Il2CppSystem.Object
	{
		// Token: 0x06008828 RID: 34856 RVA: 0x0023DF48 File Offset: 0x0023C148
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEmotionPreset()
		{
			Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Emotions", "AvatarEmotionPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr);
			AvatarEmotionPreset.NativeFieldInfoPtr_PresetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "PresetName");
			AvatarEmotionPreset.NativeFieldInfoPtr_FaceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "FaceTexture");
			AvatarEmotionPreset.NativeFieldInfoPtr_LeftEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "LeftEyeRestingState");
			AvatarEmotionPreset.NativeFieldInfoPtr_RightEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "RightEyeRestingState");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowAngleChange_L");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_R = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowAngleChange_R");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowHeightChange_L");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_R = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowHeightChange_R");
			AvatarEmotionPreset.NativeMethodInfoPtr_Lerp_Public_Static_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, 100680286);
			AvatarEmotionPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, 100680287);
		}

		// Token: 0x06008829 RID: 34857 RVA: 0x0023E040 File Offset: 0x0023C240
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252483, RefRangeEnd = 252485, XrefRangeStart = 252459, XrefRangeEnd = 252483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AvatarEmotionPreset Lerp(AvatarEmotionPreset start, AvatarEmotionPreset end, AvatarEmotionPreset neutralPreset, float lerp)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(neutralPreset);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionPreset.NativeMethodInfoPtr_Lerp_Public_Static_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr3) : null;
		}

		// Token: 0x0600882A RID: 34858 RVA: 0x0023E0B8 File Offset: 0x0023C2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252485, XrefRangeEnd = 252490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEmotionPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600882B RID: 34859 RVA: 0x00040E5E File Offset: 0x0003F05E
		public AvatarEmotionPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700296F RID: 10607
		// (get) Token: 0x0600882C RID: 34860 RVA: 0x0023E0F4 File Offset: 0x0023C2F4
		// (set) Token: 0x0600882D RID: 34861 RVA: 0x00040E67 File Offset: 0x0003F067
		public unsafe string PresetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_PresetName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_PresetName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002970 RID: 10608
		// (get) Token: 0x0600882E RID: 34862 RVA: 0x0023E11C File Offset: 0x0023C31C
		// (set) Token: 0x0600882F RID: 34863 RVA: 0x00040E86 File Offset: 0x0003F086
		public unsafe Texture2D FaceTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_FaceTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_FaceTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002971 RID: 10609
		// (get) Token: 0x06008830 RID: 34864 RVA: 0x0023E14C File Offset: 0x0023C34C
		// (set) Token: 0x06008831 RID: 34865 RVA: 0x00040EA5 File Offset: 0x0003F0A5
		public unsafe Eye.EyeLidConfiguration LeftEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_LeftEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_LeftEyeRestingState)) = value;
			}
		}

		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x06008832 RID: 34866 RVA: 0x0023E174 File Offset: 0x0023C374
		// (set) Token: 0x06008833 RID: 34867 RVA: 0x00040EC0 File Offset: 0x0003F0C0
		public unsafe Eye.EyeLidConfiguration RightEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_RightEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_RightEyeRestingState)) = value;
			}
		}

		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x06008834 RID: 34868 RVA: 0x0023E19C File Offset: 0x0023C39C
		// (set) Token: 0x06008835 RID: 34869 RVA: 0x00040EDB File Offset: 0x0003F0DB
		public unsafe float BrowAngleChange_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_L)) = value;
			}
		}

		// Token: 0x17002974 RID: 10612
		// (get) Token: 0x06008836 RID: 34870 RVA: 0x0023E1C4 File Offset: 0x0023C3C4
		// (set) Token: 0x06008837 RID: 34871 RVA: 0x00040EF6 File Offset: 0x0003F0F6
		public unsafe float BrowAngleChange_R
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_R);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_R)) = value;
			}
		}

		// Token: 0x17002975 RID: 10613
		// (get) Token: 0x06008838 RID: 34872 RVA: 0x0023E1EC File Offset: 0x0023C3EC
		// (set) Token: 0x06008839 RID: 34873 RVA: 0x00040F11 File Offset: 0x0003F111
		public unsafe float BrowHeightChange_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_L)) = value;
			}
		}

		// Token: 0x17002976 RID: 10614
		// (get) Token: 0x0600883A RID: 34874 RVA: 0x0023E214 File Offset: 0x0023C414
		// (set) Token: 0x0600883B RID: 34875 RVA: 0x00040F2C File Offset: 0x0003F12C
		public unsafe float BrowHeightChange_R
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_R);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_R)) = value;
			}
		}

		// Token: 0x04005C8B RID: 23691
		private static readonly IntPtr NativeFieldInfoPtr_PresetName;

		// Token: 0x04005C8C RID: 23692
		private static readonly IntPtr NativeFieldInfoPtr_FaceTexture;

		// Token: 0x04005C8D RID: 23693
		private static readonly IntPtr NativeFieldInfoPtr_LeftEyeRestingState;

		// Token: 0x04005C8E RID: 23694
		private static readonly IntPtr NativeFieldInfoPtr_RightEyeRestingState;

		// Token: 0x04005C8F RID: 23695
		private static readonly IntPtr NativeFieldInfoPtr_BrowAngleChange_L;

		// Token: 0x04005C90 RID: 23696
		private static readonly IntPtr NativeFieldInfoPtr_BrowAngleChange_R;

		// Token: 0x04005C91 RID: 23697
		private static readonly IntPtr NativeFieldInfoPtr_BrowHeightChange_L;

		// Token: 0x04005C92 RID: 23698
		private static readonly IntPtr NativeFieldInfoPtr_BrowHeightChange_R;

		// Token: 0x04005C93 RID: 23699
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_Single_0;

		// Token: 0x04005C94 RID: 23700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
