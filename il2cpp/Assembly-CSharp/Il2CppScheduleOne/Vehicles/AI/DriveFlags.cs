using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020004FC RID: 1276
	[Serializable]
	public class DriveFlags : Object
	{
		// Token: 0x060070B6 RID: 28854 RVA: 0x001EF600 File Offset: 0x001ED800
		// Note: this type is marked as 'beforefieldinit'.
		static DriveFlags()
		{
			Il2CppClassPointerStore<DriveFlags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "DriveFlags");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr);
			DriveFlags.NativeFieldInfoPtr_OverrideSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "OverrideSpeed");
			DriveFlags.NativeFieldInfoPtr_OverriddenSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "OverriddenSpeed");
			DriveFlags.NativeFieldInfoPtr_OverriddenReverseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "OverriddenReverseSpeed");
			DriveFlags.NativeFieldInfoPtr_SpeedLimitMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "SpeedLimitMultiplier");
			DriveFlags.NativeFieldInfoPtr_IgnoreTrafficLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "IgnoreTrafficLights");
			DriveFlags.NativeFieldInfoPtr_UseRoads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "UseRoads");
			DriveFlags.NativeFieldInfoPtr_StuckDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "StuckDetection");
			DriveFlags.NativeFieldInfoPtr_ObstacleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "ObstacleMode");
			DriveFlags.NativeFieldInfoPtr_AutoBrakeAtDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "AutoBrakeAtDestination");
			DriveFlags.NativeFieldInfoPtr_TurnBasedSpeedReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "TurnBasedSpeedReduction");
			DriveFlags.NativeMethodInfoPtr_ResetFlags_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, 100677460);
			DriveFlags.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, 100677461);
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x001EF720 File Offset: 0x001ED920
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 221987, RefRangeEnd = 221990, XrefRangeStart = 221987, XrefRangeEnd = 221987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DriveFlags.NativeMethodInfoPtr_ResetFlags_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x001EF754 File Offset: 0x001ED954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221990, XrefRangeEnd = 221991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DriveFlags() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DriveFlags.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070B9 RID: 28857 RVA: 0x00035829 File Offset: 0x00033A29
		public DriveFlags(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x060070BA RID: 28858 RVA: 0x001EF790 File Offset: 0x001ED990
		// (set) Token: 0x060070BB RID: 28859 RVA: 0x00035832 File Offset: 0x00033A32
		public unsafe bool OverrideSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverrideSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverrideSpeed)) = value;
			}
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x060070BC RID: 28860 RVA: 0x001EF7B8 File Offset: 0x001ED9B8
		// (set) Token: 0x060070BD RID: 28861 RVA: 0x0003584D File Offset: 0x00033A4D
		public unsafe float OverriddenSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenSpeed)) = value;
			}
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x060070BE RID: 28862 RVA: 0x001EF7E0 File Offset: 0x001ED9E0
		// (set) Token: 0x060070BF RID: 28863 RVA: 0x00035868 File Offset: 0x00033A68
		public unsafe float OverriddenReverseSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenReverseSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenReverseSpeed)) = value;
			}
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x060070C0 RID: 28864 RVA: 0x001EF808 File Offset: 0x001EDA08
		// (set) Token: 0x060070C1 RID: 28865 RVA: 0x00035883 File Offset: 0x00033A83
		public unsafe float SpeedLimitMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_SpeedLimitMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_SpeedLimitMultiplier)) = value;
			}
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x060070C2 RID: 28866 RVA: 0x001EF830 File Offset: 0x001EDA30
		// (set) Token: 0x060070C3 RID: 28867 RVA: 0x0003589E File Offset: 0x00033A9E
		public unsafe bool IgnoreTrafficLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_IgnoreTrafficLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_IgnoreTrafficLights)) = value;
			}
		}

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x060070C4 RID: 28868 RVA: 0x001EF858 File Offset: 0x001EDA58
		// (set) Token: 0x060070C5 RID: 28869 RVA: 0x000358B9 File Offset: 0x00033AB9
		public unsafe bool UseRoads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_UseRoads);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_UseRoads)) = value;
			}
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x060070C6 RID: 28870 RVA: 0x001EF880 File Offset: 0x001EDA80
		// (set) Token: 0x060070C7 RID: 28871 RVA: 0x000358D4 File Offset: 0x00033AD4
		public unsafe bool StuckDetection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_StuckDetection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_StuckDetection)) = value;
			}
		}

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x060070C8 RID: 28872 RVA: 0x001EF8A8 File Offset: 0x001EDAA8
		// (set) Token: 0x060070C9 RID: 28873 RVA: 0x000358EF File Offset: 0x00033AEF
		public unsafe DriveFlags.EObstacleMode ObstacleMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_ObstacleMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_ObstacleMode)) = value;
			}
		}

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x060070CA RID: 28874 RVA: 0x001EF8D0 File Offset: 0x001EDAD0
		// (set) Token: 0x060070CB RID: 28875 RVA: 0x0003590A File Offset: 0x00033B0A
		public unsafe bool AutoBrakeAtDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_AutoBrakeAtDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_AutoBrakeAtDestination)) = value;
			}
		}

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x060070CC RID: 28876 RVA: 0x001EF8F8 File Offset: 0x001EDAF8
		// (set) Token: 0x060070CD RID: 28877 RVA: 0x00035925 File Offset: 0x00033B25
		public unsafe bool TurnBasedSpeedReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_TurnBasedSpeedReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_TurnBasedSpeedReduction)) = value;
			}
		}

		// Token: 0x04004D07 RID: 19719
		private static readonly IntPtr NativeFieldInfoPtr_OverrideSpeed;

		// Token: 0x04004D08 RID: 19720
		private static readonly IntPtr NativeFieldInfoPtr_OverriddenSpeed;

		// Token: 0x04004D09 RID: 19721
		private static readonly IntPtr NativeFieldInfoPtr_OverriddenReverseSpeed;

		// Token: 0x04004D0A RID: 19722
		private static readonly IntPtr NativeFieldInfoPtr_SpeedLimitMultiplier;

		// Token: 0x04004D0B RID: 19723
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreTrafficLights;

		// Token: 0x04004D0C RID: 19724
		private static readonly IntPtr NativeFieldInfoPtr_UseRoads;

		// Token: 0x04004D0D RID: 19725
		private static readonly IntPtr NativeFieldInfoPtr_StuckDetection;

		// Token: 0x04004D0E RID: 19726
		private static readonly IntPtr NativeFieldInfoPtr_ObstacleMode;

		// Token: 0x04004D0F RID: 19727
		private static readonly IntPtr NativeFieldInfoPtr_AutoBrakeAtDestination;

		// Token: 0x04004D10 RID: 19728
		private static readonly IntPtr NativeFieldInfoPtr_TurnBasedSpeedReduction;

		// Token: 0x04004D11 RID: 19729
		private static readonly IntPtr NativeMethodInfoPtr_ResetFlags_Public_Void_0;

		// Token: 0x04004D12 RID: 19730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A71 RID: 2673
		[OriginalName("Assembly-CSharp.dll", "", "EObstacleMode")]
		public enum EObstacleMode
		{
			// Token: 0x04008D3A RID: 36154
			Default,
			// Token: 0x04008D3B RID: 36155
			IgnoreAll,
			// Token: 0x04008D3C RID: 36156
			IgnoreOnlySquishy
		}
	}
}
