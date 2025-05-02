using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200025B RID: 603
	[Serializable]
	public class DateTimeData : SaveData
	{
		// Token: 0x06002ED7 RID: 11991 RVA: 0x00106030 File Offset: 0x00104230
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeData()
		{
			Il2CppClassPointerStore<DateTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DateTimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr);
			DateTimeData.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Year");
			DateTimeData.NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Month");
			DateTimeData.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Day");
			DateTimeData.NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Hour");
			DateTimeData.NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Minute");
			DateTimeData.NativeFieldInfoPtr_Second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Second");
			DateTimeData.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, 100668730);
			DateTimeData.NativeMethodInfoPtr_GetDateTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, 100668731);
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00106100 File Offset: 0x00104300
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130530, RefRangeEnd = 130536, XrefRangeStart = 130520, XrefRangeEnd = 130530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeData(DateTime date) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref date;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeData.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x00106148 File Offset: 0x00104348
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130537, RefRangeEnd = 130540, XrefRangeStart = 130536, XrefRangeEnd = 130537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime GetDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeData.NativeMethodInfoPtr_GetDateTime_Public_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x00018BF3 File Offset: 0x00016DF3
		public DateTimeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06002EDB RID: 11995 RVA: 0x00106184 File Offset: 0x00104384
		// (set) Token: 0x06002EDC RID: 11996 RVA: 0x00018BFC File Offset: 0x00016DFC
		public unsafe int Year
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Year);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Year)) = value;
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x001061AC File Offset: 0x001043AC
		// (set) Token: 0x06002EDE RID: 11998 RVA: 0x00018C17 File Offset: 0x00016E17
		public unsafe int Month
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Month);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Month)) = value;
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06002EDF RID: 11999 RVA: 0x001061D4 File Offset: 0x001043D4
		// (set) Token: 0x06002EE0 RID: 12000 RVA: 0x00018C32 File Offset: 0x00016E32
		public unsafe int Day
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Day);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Day)) = value;
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x001061FC File Offset: 0x001043FC
		// (set) Token: 0x06002EE2 RID: 12002 RVA: 0x00018C4D File Offset: 0x00016E4D
		public unsafe int Hour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Hour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Hour)) = value;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x00106224 File Offset: 0x00104424
		// (set) Token: 0x06002EE4 RID: 12004 RVA: 0x00018C68 File Offset: 0x00016E68
		public unsafe int Minute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Minute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Minute)) = value;
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x0010624C File Offset: 0x0010444C
		// (set) Token: 0x06002EE6 RID: 12006 RVA: 0x00018C83 File Offset: 0x00016E83
		public unsafe int Second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Second);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Second)) = value;
			}
		}

		// Token: 0x04001EFD RID: 7933
		private static readonly IntPtr NativeFieldInfoPtr_Year;

		// Token: 0x04001EFE RID: 7934
		private static readonly IntPtr NativeFieldInfoPtr_Month;

		// Token: 0x04001EFF RID: 7935
		private static readonly IntPtr NativeFieldInfoPtr_Day;

		// Token: 0x04001F00 RID: 7936
		private static readonly IntPtr NativeFieldInfoPtr_Hour;

		// Token: 0x04001F01 RID: 7937
		private static readonly IntPtr NativeFieldInfoPtr_Minute;

		// Token: 0x04001F02 RID: 7938
		private static readonly IntPtr NativeFieldInfoPtr_Second;

		// Token: 0x04001F03 RID: 7939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_0;

		// Token: 0x04001F04 RID: 7940
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTime_Public_DateTime_0;
	}
}
