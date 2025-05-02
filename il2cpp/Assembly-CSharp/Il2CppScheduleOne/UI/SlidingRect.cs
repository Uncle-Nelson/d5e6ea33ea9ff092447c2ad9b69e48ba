using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066D RID: 1645
	public class SlidingRect : MonoBehaviour
	{
		// Token: 0x060092DE RID: 37598 RVA: 0x0025DA48 File Offset: 0x0025BC48
		// Note: this type is marked as 'beforefieldinit'.
		static SlidingRect()
		{
			Il2CppClassPointerStore<SlidingRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "SlidingRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr);
			SlidingRect.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "Rect");
			SlidingRect.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "Start");
			SlidingRect.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "End");
			SlidingRect.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "Duration");
			SlidingRect.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "SpeedMultiplier");
			SlidingRect.NativeFieldInfoPtr__time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "_time");
			SlidingRect.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, 100681518);
			SlidingRect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, 100681519);
		}

		// Token: 0x060092DF RID: 37599 RVA: 0x0025DB18 File Offset: 0x0025BD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265185, XrefRangeEnd = 265189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingRect.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092E0 RID: 37600 RVA: 0x0025DB4C File Offset: 0x0025BD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265189, XrefRangeEnd = 265190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlidingRect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingRect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092E1 RID: 37601 RVA: 0x000471A6 File Offset: 0x000453A6
		public SlidingRect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D03 RID: 11523
		// (get) Token: 0x060092E2 RID: 37602 RVA: 0x0025DB88 File Offset: 0x0025BD88
		// (set) Token: 0x060092E3 RID: 37603 RVA: 0x000471AF File Offset: 0x000453AF
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D04 RID: 11524
		// (get) Token: 0x060092E4 RID: 37604 RVA: 0x0025DBB8 File Offset: 0x0025BDB8
		// (set) Token: 0x060092E5 RID: 37605 RVA: 0x000471CE File Offset: 0x000453CE
		public unsafe Vector2 Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Start)) = value;
			}
		}

		// Token: 0x17002D05 RID: 11525
		// (get) Token: 0x060092E6 RID: 37606 RVA: 0x0025DBE0 File Offset: 0x0025BDE0
		// (set) Token: 0x060092E7 RID: 37607 RVA: 0x000471E9 File Offset: 0x000453E9
		public unsafe Vector2 End
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_End);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_End)) = value;
			}
		}

		// Token: 0x17002D06 RID: 11526
		// (get) Token: 0x060092E8 RID: 37608 RVA: 0x0025DC08 File Offset: 0x0025BE08
		// (set) Token: 0x060092E9 RID: 37609 RVA: 0x00047204 File Offset: 0x00045404
		public unsafe float Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Duration)) = value;
			}
		}

		// Token: 0x17002D07 RID: 11527
		// (get) Token: 0x060092EA RID: 37610 RVA: 0x0025DC30 File Offset: 0x0025BE30
		// (set) Token: 0x060092EB RID: 37611 RVA: 0x0004721F File Offset: 0x0004541F
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002D08 RID: 11528
		// (get) Token: 0x060092EC RID: 37612 RVA: 0x0025DC58 File Offset: 0x0025BE58
		// (set) Token: 0x060092ED RID: 37613 RVA: 0x0004723A File Offset: 0x0004543A
		public unsafe float _time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr__time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr__time)) = value;
			}
		}

		// Token: 0x04006331 RID: 25393
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04006332 RID: 25394
		private static readonly IntPtr NativeFieldInfoPtr_Start;

		// Token: 0x04006333 RID: 25395
		private static readonly IntPtr NativeFieldInfoPtr_End;

		// Token: 0x04006334 RID: 25396
		private static readonly IntPtr NativeFieldInfoPtr_Duration;

		// Token: 0x04006335 RID: 25397
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x04006336 RID: 25398
		private static readonly IntPtr NativeFieldInfoPtr__time;

		// Token: 0x04006337 RID: 25399
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04006338 RID: 25400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
