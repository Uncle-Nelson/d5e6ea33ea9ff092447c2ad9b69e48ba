using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B8 RID: 696
	[Serializable]
	public class TimeData : SaveData
	{
		// Token: 0x060031DE RID: 12766 RVA: 0x0010E9E8 File Offset: 0x0010CBE8
		// Note: this type is marked as 'beforefieldinit'.
		static TimeData()
		{
			Il2CppClassPointerStore<TimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeData>.NativeClassPtr);
			TimeData.NativeFieldInfoPtr_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeData>.NativeClassPtr, "TimeOfDay");
			TimeData.NativeFieldInfoPtr_ElapsedDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeData>.NativeClassPtr, "ElapsedDays");
			TimeData.NativeFieldInfoPtr_Playtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeData>.NativeClassPtr, "Playtime");
			TimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeData>.NativeClassPtr, 100668855);
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x0010EA68 File Offset: 0x0010CC68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131312, RefRangeEnd = 131313, XrefRangeStart = 131311, XrefRangeEnd = 131312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeData(int timeOfDay, int elapsedDays, int playtime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref timeOfDay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playtime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x0001AB60 File Offset: 0x00018D60
		public TimeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x060031E1 RID: 12769 RVA: 0x0010EACC File Offset: 0x0010CCCC
		// (set) Token: 0x060031E2 RID: 12770 RVA: 0x0001AB69 File Offset: 0x00018D69
		public unsafe int TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_TimeOfDay)) = value;
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x060031E3 RID: 12771 RVA: 0x0010EAF4 File Offset: 0x0010CCF4
		// (set) Token: 0x060031E4 RID: 12772 RVA: 0x0001AB84 File Offset: 0x00018D84
		public unsafe int ElapsedDays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_ElapsedDays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_ElapsedDays)) = value;
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x060031E5 RID: 12773 RVA: 0x0010EB1C File Offset: 0x0010CD1C
		// (set) Token: 0x060031E6 RID: 12774 RVA: 0x0001AB9F File Offset: 0x00018D9F
		public unsafe int Playtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_Playtime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_Playtime)) = value;
			}
		}

		// Token: 0x0400205C RID: 8284
		private static readonly IntPtr NativeFieldInfoPtr_TimeOfDay;

		// Token: 0x0400205D RID: 8285
		private static readonly IntPtr NativeFieldInfoPtr_ElapsedDays;

		// Token: 0x0400205E RID: 8286
		private static readonly IntPtr NativeFieldInfoPtr_Playtime;

		// Token: 0x0400205F RID: 8287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;
	}
}
