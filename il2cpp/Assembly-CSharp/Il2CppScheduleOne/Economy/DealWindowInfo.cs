using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000415 RID: 1045
	[StructLayout(2)]
	public struct DealWindowInfo
	{
		// Token: 0x06005B8C RID: 23436 RVA: 0x001A8DB0 File Offset: 0x001A6FB0
		// Note: this type is marked as 'beforefieldinit'.
		static DealWindowInfo()
		{
			Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DealWindowInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr);
			DealWindowInfo.NativeFieldInfoPtr_WINDOW_DURATION_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "WINDOW_DURATION_MINS");
			DealWindowInfo.NativeFieldInfoPtr_WINDOW_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "WINDOW_COUNT");
			DealWindowInfo.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "StartTime");
			DealWindowInfo.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "EndTime");
			DealWindowInfo.NativeFieldInfoPtr_Morning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "Morning");
			DealWindowInfo.NativeFieldInfoPtr_Afternoon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "Afternoon");
			DealWindowInfo.NativeFieldInfoPtr_Night = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "Night");
			DealWindowInfo.NativeFieldInfoPtr_LateNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "LateNight");
			DealWindowInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, 100674976);
			DealWindowInfo.NativeMethodInfoPtr_GetWindowInfo_Public_Static_DealWindowInfo_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, 100674977);
			DealWindowInfo.NativeMethodInfoPtr_GetWindow_Public_Static_EDealWindow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, 100674978);
		}

		// Token: 0x06005B8D RID: 23437 RVA: 0x001A8EBC File Offset: 0x001A70BC
		[CallerCount(94)]
		[CachedScanResults(RefRangeStart = 34315, RefRangeEnd = 34409, XrefRangeStart = 34315, XrefRangeEnd = 34409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealWindowInfo(int startTime, int endTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x001A8EFC File Offset: 0x001A70FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193544, RefRangeEnd = 193547, XrefRangeStart = 193540, XrefRangeEnd = 193544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DealWindowInfo GetWindowInfo(EDealWindow window)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowInfo.NativeMethodInfoPtr_GetWindowInfo_Public_Static_DealWindowInfo_EDealWindow_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x001A8F3C File Offset: 0x001A713C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193553, RefRangeEnd = 193555, XrefRangeStart = 193547, XrefRangeEnd = 193553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EDealWindow GetWindow(int time)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowInfo.NativeMethodInfoPtr_GetWindow_Public_Static_EDealWindow_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x0002B2F8 File Offset: 0x000294F8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06005B91 RID: 23441 RVA: 0x001A8F7C File Offset: 0x001A717C
		// (set) Token: 0x06005B92 RID: 23442 RVA: 0x0002B30A File Offset: 0x0002950A
		public unsafe static int WINDOW_DURATION_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_DURATION_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_DURATION_MINS, (void*)(&value));
			}
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x06005B93 RID: 23443 RVA: 0x001A8F98 File Offset: 0x001A7198
		// (set) Token: 0x06005B94 RID: 23444 RVA: 0x0002B318 File Offset: 0x00029518
		public unsafe static int WINDOW_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06005B95 RID: 23445 RVA: 0x001A8FB4 File Offset: 0x001A71B4
		// (set) Token: 0x06005B96 RID: 23446 RVA: 0x0002B326 File Offset: 0x00029526
		public unsafe static DealWindowInfo Morning
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_Morning, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_Morning, (void*)(&value));
			}
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x06005B97 RID: 23447 RVA: 0x001A8FD0 File Offset: 0x001A71D0
		// (set) Token: 0x06005B98 RID: 23448 RVA: 0x0002B334 File Offset: 0x00029534
		public unsafe static DealWindowInfo Afternoon
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_Afternoon, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_Afternoon, (void*)(&value));
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x06005B99 RID: 23449 RVA: 0x001A8FEC File Offset: 0x001A71EC
		// (set) Token: 0x06005B9A RID: 23450 RVA: 0x0002B342 File Offset: 0x00029542
		public unsafe static DealWindowInfo Night
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_Night, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_Night, (void*)(&value));
			}
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x06005B9B RID: 23451 RVA: 0x001A9008 File Offset: 0x001A7208
		// (set) Token: 0x06005B9C RID: 23452 RVA: 0x0002B350 File Offset: 0x00029550
		public unsafe static DealWindowInfo LateNight
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_LateNight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_LateNight, (void*)(&value));
			}
		}

		// Token: 0x04003E97 RID: 16023
		private static readonly IntPtr NativeFieldInfoPtr_WINDOW_DURATION_MINS;

		// Token: 0x04003E98 RID: 16024
		private static readonly IntPtr NativeFieldInfoPtr_WINDOW_COUNT;

		// Token: 0x04003E99 RID: 16025
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04003E9A RID: 16026
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04003E9B RID: 16027
		private static readonly IntPtr NativeFieldInfoPtr_Morning;

		// Token: 0x04003E9C RID: 16028
		private static readonly IntPtr NativeFieldInfoPtr_Afternoon;

		// Token: 0x04003E9D RID: 16029
		private static readonly IntPtr NativeFieldInfoPtr_Night;

		// Token: 0x04003E9E RID: 16030
		private static readonly IntPtr NativeFieldInfoPtr_LateNight;

		// Token: 0x04003E9F RID: 16031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04003EA0 RID: 16032
		private static readonly IntPtr NativeMethodInfoPtr_GetWindowInfo_Public_Static_DealWindowInfo_EDealWindow_0;

		// Token: 0x04003EA1 RID: 16033
		private static readonly IntPtr NativeMethodInfoPtr_GetWindow_Public_Static_EDealWindow_Int32_0;

		// Token: 0x04003EA2 RID: 16034
		[FieldOffset(0)]
		public int StartTime;

		// Token: 0x04003EA3 RID: 16035
		[FieldOffset(4)]
		public int EndTime;
	}
}
