using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x020003C0 RID: 960
	public class RankData : SaveData
	{
		// Token: 0x06004ADB RID: 19163 RVA: 0x0016AB64 File Offset: 0x00168D64
		// Note: this type is marked as 'beforefieldinit'.
		static RankData()
		{
			Il2CppClassPointerStore<RankData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "RankData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankData>.NativeClassPtr);
			RankData.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "Rank");
			RankData.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "Tier");
			RankData.NativeFieldInfoPtr_XP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "XP");
			RankData.NativeFieldInfoPtr_TotalXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "TotalXP");
			RankData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankData>.NativeClassPtr, 100672584);
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x0016ABF8 File Offset: 0x00168DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164622, XrefRangeEnd = 164623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankData(int rank, int tier, int xp, int totalXP) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXP;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x000240CB File Offset: 0x000222CB
		public RankData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x06004ADE RID: 19166 RVA: 0x0016AC6C File Offset: 0x00168E6C
		// (set) Token: 0x06004ADF RID: 19167 RVA: 0x000240D4 File Offset: 0x000222D4
		public unsafe int Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x06004AE0 RID: 19168 RVA: 0x0016AC94 File Offset: 0x00168E94
		// (set) Token: 0x06004AE1 RID: 19169 RVA: 0x000240EF File Offset: 0x000222EF
		public unsafe int Tier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Tier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Tier)) = value;
			}
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x06004AE2 RID: 19170 RVA: 0x0016ACBC File Offset: 0x00168EBC
		// (set) Token: 0x06004AE3 RID: 19171 RVA: 0x0002410A File Offset: 0x0002230A
		public unsafe int XP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_XP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_XP)) = value;
			}
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x06004AE4 RID: 19172 RVA: 0x0016ACE4 File Offset: 0x00168EE4
		// (set) Token: 0x06004AE5 RID: 19173 RVA: 0x00024125 File Offset: 0x00022325
		public unsafe int TotalXP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_TotalXP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_TotalXP)) = value;
			}
		}

		// Token: 0x04003285 RID: 12933
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x04003286 RID: 12934
		private static readonly IntPtr NativeFieldInfoPtr_Tier;

		// Token: 0x04003287 RID: 12935
		private static readonly IntPtr NativeFieldInfoPtr_XP;

		// Token: 0x04003288 RID: 12936
		private static readonly IntPtr NativeFieldInfoPtr_TotalXP;

		// Token: 0x04003289 RID: 12937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;
	}
}
