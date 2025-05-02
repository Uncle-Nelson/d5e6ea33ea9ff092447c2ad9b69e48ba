using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000533 RID: 1331
	public class CountdownText : MonoBehaviour
	{
		// Token: 0x0600769F RID: 30367 RVA: 0x00203C2C File Offset: 0x00201E2C
		// Note: this type is marked as 'beforefieldinit'.
		static CountdownText()
		{
			Il2CppClassPointerStore<CountdownText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CountdownText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountdownText>.NativeClassPtr);
			CountdownText.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "TimeLabel");
			CountdownText.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Year");
			CountdownText.NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Month");
			CountdownText.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Day");
			CountdownText.NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Hour");
			CountdownText.NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Minute");
			CountdownText.NativeFieldInfoPtr_Second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Second");
			CountdownText.NativeFieldInfoPtr_targetPDTDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "targetPDTDate");
			CountdownText.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678237);
			CountdownText.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678238);
			CountdownText.NativeMethodInfoPtr_UpdateCountdown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678239);
			CountdownText.NativeMethodInfoPtr_FormatTime_Private_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678240);
			CountdownText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678241);
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x00203D60 File Offset: 0x00201F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231165, XrefRangeEnd = 231176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x00203D94 File Offset: 0x00201F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231176, XrefRangeEnd = 231187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x00203DC8 File Offset: 0x00201FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCountdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_UpdateCountdown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x00203DFC File Offset: 0x00201FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231187, XrefRangeEnd = 231212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatTime(TimeSpan timeSpan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref timeSpan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_FormatTime_Private_String_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x00203E40 File Offset: 0x00202040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231212, XrefRangeEnd = 231213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CountdownText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountdownText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076A5 RID: 30373 RVA: 0x0003834D File Offset: 0x0003654D
		public CountdownText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x060076A6 RID: 30374 RVA: 0x00203E7C File Offset: 0x0020207C
		// (set) Token: 0x060076A7 RID: 30375 RVA: 0x00038356 File Offset: 0x00036556
		public unsafe TextMeshProUGUI TimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_TimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x060076A8 RID: 30376 RVA: 0x00203EAC File Offset: 0x002020AC
		// (set) Token: 0x060076A9 RID: 30377 RVA: 0x00038375 File Offset: 0x00036575
		public unsafe int Year
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Year);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Year)) = value;
			}
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x060076AA RID: 30378 RVA: 0x00203ED4 File Offset: 0x002020D4
		// (set) Token: 0x060076AB RID: 30379 RVA: 0x00038390 File Offset: 0x00036590
		public unsafe int Month
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Month);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Month)) = value;
			}
		}

		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x060076AC RID: 30380 RVA: 0x00203EFC File Offset: 0x002020FC
		// (set) Token: 0x060076AD RID: 30381 RVA: 0x000383AB File Offset: 0x000365AB
		public unsafe int Day
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Day);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Day)) = value;
			}
		}

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x060076AE RID: 30382 RVA: 0x00203F24 File Offset: 0x00202124
		// (set) Token: 0x060076AF RID: 30383 RVA: 0x000383C6 File Offset: 0x000365C6
		public unsafe int Hour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Hour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Hour)) = value;
			}
		}

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x060076B0 RID: 30384 RVA: 0x00203F4C File Offset: 0x0020214C
		// (set) Token: 0x060076B1 RID: 30385 RVA: 0x000383E1 File Offset: 0x000365E1
		public unsafe int Minute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Minute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Minute)) = value;
			}
		}

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x060076B2 RID: 30386 RVA: 0x00203F74 File Offset: 0x00202174
		// (set) Token: 0x060076B3 RID: 30387 RVA: 0x000383FC File Offset: 0x000365FC
		public unsafe int Second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Second);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Second)) = value;
			}
		}

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x060076B4 RID: 30388 RVA: 0x00203F9C File Offset: 0x0020219C
		// (set) Token: 0x060076B5 RID: 30389 RVA: 0x00038417 File Offset: 0x00036617
		public unsafe DateTime targetPDTDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_targetPDTDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_targetPDTDate)) = value;
			}
		}

		// Token: 0x04005105 RID: 20741
		private static readonly IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x04005106 RID: 20742
		private static readonly IntPtr NativeFieldInfoPtr_Year;

		// Token: 0x04005107 RID: 20743
		private static readonly IntPtr NativeFieldInfoPtr_Month;

		// Token: 0x04005108 RID: 20744
		private static readonly IntPtr NativeFieldInfoPtr_Day;

		// Token: 0x04005109 RID: 20745
		private static readonly IntPtr NativeFieldInfoPtr_Hour;

		// Token: 0x0400510A RID: 20746
		private static readonly IntPtr NativeFieldInfoPtr_Minute;

		// Token: 0x0400510B RID: 20747
		private static readonly IntPtr NativeFieldInfoPtr_Second;

		// Token: 0x0400510C RID: 20748
		private static readonly IntPtr NativeFieldInfoPtr_targetPDTDate;

		// Token: 0x0400510D RID: 20749
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400510E RID: 20750
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400510F RID: 20751
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCountdown_Private_Void_0;

		// Token: 0x04005110 RID: 20752
		private static readonly IntPtr NativeMethodInfoPtr_FormatTime_Private_String_TimeSpan_0;

		// Token: 0x04005111 RID: 20753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
