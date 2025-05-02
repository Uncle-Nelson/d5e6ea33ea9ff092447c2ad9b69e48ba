using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000287 RID: 647
	[Serializable]
	public class MoneyData : SaveData
	{
		// Token: 0x06003003 RID: 12291 RVA: 0x00109344 File Offset: 0x00107544
		// Note: this type is marked as 'beforefieldinit'.
		static MoneyData()
		{
			Il2CppClassPointerStore<MoneyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MoneyData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyData>.NativeClassPtr);
			MoneyData.NativeFieldInfoPtr_OnlineBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "OnlineBalance");
			MoneyData.NativeFieldInfoPtr_Networth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "Networth");
			MoneyData.NativeFieldInfoPtr_LifetimeEarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "LifetimeEarnings");
			MoneyData.NativeFieldInfoPtr_WeeklyDepositSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "WeeklyDepositSum");
			MoneyData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, 100668798);
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x001093D8 File Offset: 0x001075D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130909, RefRangeEnd = 130910, XrefRangeStart = 130908, XrefRangeEnd = 130909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoneyData(float onlineBalance, float netWorth, float lifetimeEarnings, float weeklyDepositSum) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onlineBalance;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref netWorth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetimeEarnings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weeklyDepositSum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x0001976D File Offset: 0x0001796D
		public MoneyData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06003006 RID: 12294 RVA: 0x0010944C File Offset: 0x0010764C
		// (set) Token: 0x06003007 RID: 12295 RVA: 0x00019776 File Offset: 0x00017976
		public unsafe float OnlineBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_OnlineBalance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_OnlineBalance)) = value;
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06003008 RID: 12296 RVA: 0x00109474 File Offset: 0x00107674
		// (set) Token: 0x06003009 RID: 12297 RVA: 0x00019791 File Offset: 0x00017991
		public unsafe float Networth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_Networth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_Networth)) = value;
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x0010949C File Offset: 0x0010769C
		// (set) Token: 0x0600300B RID: 12299 RVA: 0x000197AC File Offset: 0x000179AC
		public unsafe float LifetimeEarnings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_LifetimeEarnings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_LifetimeEarnings)) = value;
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x0600300C RID: 12300 RVA: 0x001094C4 File Offset: 0x001076C4
		// (set) Token: 0x0600300D RID: 12301 RVA: 0x000197C7 File Offset: 0x000179C7
		public unsafe float WeeklyDepositSum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_WeeklyDepositSum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_WeeklyDepositSum)) = value;
			}
		}

		// Token: 0x04001F83 RID: 8067
		private static readonly IntPtr NativeFieldInfoPtr_OnlineBalance;

		// Token: 0x04001F84 RID: 8068
		private static readonly IntPtr NativeFieldInfoPtr_Networth;

		// Token: 0x04001F85 RID: 8069
		private static readonly IntPtr NativeFieldInfoPtr_LifetimeEarnings;

		// Token: 0x04001F86 RID: 8070
		private static readonly IntPtr NativeFieldInfoPtr_WeeklyDepositSum;

		// Token: 0x04001F87 RID: 8071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;
	}
}
