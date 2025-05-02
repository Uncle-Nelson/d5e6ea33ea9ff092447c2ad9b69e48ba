using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000549 RID: 1353
	public class RandomIntervalEvent : MonoBehaviour
	{
		// Token: 0x060077A5 RID: 30629 RVA: 0x00206DA4 File Offset: 0x00204FA4
		// Note: this type is marked as 'beforefieldinit'.
		static RandomIntervalEvent()
		{
			Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RandomIntervalEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr);
			RandomIntervalEvent.NativeFieldInfoPtr_MinInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "MinInterval");
			RandomIntervalEvent.NativeFieldInfoPtr_MaxInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "MaxInterval");
			RandomIntervalEvent.NativeFieldInfoPtr_ExecuteOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "ExecuteOnEnable");
			RandomIntervalEvent.NativeFieldInfoPtr_OnInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "OnInterval");
			RandomIntervalEvent.NativeFieldInfoPtr_nextInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "nextInterval");
			RandomIntervalEvent.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678361);
			RandomIntervalEvent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678362);
			RandomIntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678363);
			RandomIntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678364);
		}

		// Token: 0x060077A6 RID: 30630 RVA: 0x00206E88 File Offset: 0x00205088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232134, XrefRangeEnd = 232139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077A7 RID: 30631 RVA: 0x00206EBC File Offset: 0x002050BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232139, XrefRangeEnd = 232143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077A8 RID: 30632 RVA: 0x00206EF0 File Offset: 0x002050F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232143, XrefRangeEnd = 232146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x00206F24 File Offset: 0x00205124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232146, XrefRangeEnd = 232147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomIntervalEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077AA RID: 30634 RVA: 0x00038A95 File Offset: 0x00036C95
		public RandomIntervalEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x060077AB RID: 30635 RVA: 0x00206F60 File Offset: 0x00205160
		// (set) Token: 0x060077AC RID: 30636 RVA: 0x00038A9E File Offset: 0x00036C9E
		public unsafe float MinInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MinInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MinInterval)) = value;
			}
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x060077AD RID: 30637 RVA: 0x00206F88 File Offset: 0x00205188
		// (set) Token: 0x060077AE RID: 30638 RVA: 0x00038AB9 File Offset: 0x00036CB9
		public unsafe float MaxInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MaxInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MaxInterval)) = value;
			}
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x060077AF RID: 30639 RVA: 0x00206FB0 File Offset: 0x002051B0
		// (set) Token: 0x060077B0 RID: 30640 RVA: 0x00038AD4 File Offset: 0x00036CD4
		public unsafe bool ExecuteOnEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_ExecuteOnEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_ExecuteOnEnable)) = value;
			}
		}

		// Token: 0x1700242C RID: 9260
		// (get) Token: 0x060077B1 RID: 30641 RVA: 0x00206FD8 File Offset: 0x002051D8
		// (set) Token: 0x060077B2 RID: 30642 RVA: 0x00038AEF File Offset: 0x00036CEF
		public unsafe UnityEvent OnInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_OnInterval);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_OnInterval), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x060077B3 RID: 30643 RVA: 0x00207008 File Offset: 0x00205208
		// (set) Token: 0x060077B4 RID: 30644 RVA: 0x00038B0E File Offset: 0x00036D0E
		public unsafe float nextInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_nextInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_nextInterval)) = value;
			}
		}

		// Token: 0x040051A4 RID: 20900
		private static readonly IntPtr NativeFieldInfoPtr_MinInterval;

		// Token: 0x040051A5 RID: 20901
		private static readonly IntPtr NativeFieldInfoPtr_MaxInterval;

		// Token: 0x040051A6 RID: 20902
		private static readonly IntPtr NativeFieldInfoPtr_ExecuteOnEnable;

		// Token: 0x040051A7 RID: 20903
		private static readonly IntPtr NativeFieldInfoPtr_OnInterval;

		// Token: 0x040051A8 RID: 20904
		private static readonly IntPtr NativeFieldInfoPtr_nextInterval;

		// Token: 0x040051A9 RID: 20905
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040051AA RID: 20906
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040051AB RID: 20907
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_0;

		// Token: 0x040051AC RID: 20908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
