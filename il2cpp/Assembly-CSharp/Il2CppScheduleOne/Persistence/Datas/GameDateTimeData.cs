using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.GameTime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200025F RID: 607
	[Serializable]
	public class GameDateTimeData : SaveData
	{
		// Token: 0x06002EFF RID: 12031 RVA: 0x00106664 File Offset: 0x00104864
		// Note: this type is marked as 'beforefieldinit'.
		static GameDateTimeData()
		{
			Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GameDateTimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr);
			GameDateTimeData.NativeFieldInfoPtr_ElapsedDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr, "ElapsedDays");
			GameDateTimeData.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr, "Time");
			GameDateTimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr, 100668736);
			GameDateTimeData.NativeMethodInfoPtr__ctor_Public_Void_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr, 100668737);
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x001066E4 File Offset: 0x001048E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130558, XrefRangeEnd = 130559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTimeData(int _elapsedDays, int _time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _elapsedDays;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x0010673C File Offset: 0x0010493C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130560, RefRangeEnd = 130564, XrefRangeStart = 130559, XrefRangeEnd = 130560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTimeData(GameDateTime gameDateTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gameDateTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTimeData.NativeMethodInfoPtr__ctor_Public_Void_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x00018D86 File Offset: 0x00016F86
		public GameDateTimeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x00106784 File Offset: 0x00104984
		// (set) Token: 0x06002F04 RID: 12036 RVA: 0x00018D8F File Offset: 0x00016F8F
		public unsafe int ElapsedDays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDateTimeData.NativeFieldInfoPtr_ElapsedDays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDateTimeData.NativeFieldInfoPtr_ElapsedDays)) = value;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x001067AC File Offset: 0x001049AC
		// (set) Token: 0x06002F06 RID: 12038 RVA: 0x00018DAA File Offset: 0x00016FAA
		public unsafe int Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDateTimeData.NativeFieldInfoPtr_Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDateTimeData.NativeFieldInfoPtr_Time)) = value;
			}
		}

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeFieldInfoPtr_ElapsedDays;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeFieldInfoPtr_Time;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameDateTime_0;
	}
}
