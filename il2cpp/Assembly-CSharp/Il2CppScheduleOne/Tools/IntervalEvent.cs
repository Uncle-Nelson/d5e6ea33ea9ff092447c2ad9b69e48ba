using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200053F RID: 1343
	public class IntervalEvent : MonoBehaviour
	{
		// Token: 0x06007726 RID: 30502 RVA: 0x00205610 File Offset: 0x00203810
		// Note: this type is marked as 'beforefieldinit'.
		static IntervalEvent()
		{
			Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "IntervalEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr);
			IntervalEvent.NativeFieldInfoPtr_Interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, "Interval");
			IntervalEvent.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, "Event");
			IntervalEvent.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, 100678314);
			IntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, 100678315);
			IntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, 100678316);
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x002056A4 File Offset: 0x002038A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231690, XrefRangeEnd = 231693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalEvent.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x002056D8 File Offset: 0x002038D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141891, RefRangeEnd = 141895, XrefRangeStart = 141891, XrefRangeEnd = 141895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x0020570C File Offset: 0x0020390C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74374, RefRangeEnd = 74378, XrefRangeStart = 74374, XrefRangeEnd = 74378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntervalEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x000386F4 File Offset: 0x000368F4
		public IntervalEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700240A RID: 9226
		// (get) Token: 0x0600772B RID: 30507 RVA: 0x00205748 File Offset: 0x00203948
		// (set) Token: 0x0600772C RID: 30508 RVA: 0x000386FD File Offset: 0x000368FD
		public unsafe float Interval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Interval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Interval)) = value;
			}
		}

		// Token: 0x1700240B RID: 9227
		// (get) Token: 0x0600772D RID: 30509 RVA: 0x00205770 File Offset: 0x00203970
		// (set) Token: 0x0600772E RID: 30510 RVA: 0x00038718 File Offset: 0x00036918
		public unsafe UnityEvent Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005157 RID: 20823
		private static readonly IntPtr NativeFieldInfoPtr_Interval;

		// Token: 0x04005158 RID: 20824
		private static readonly IntPtr NativeFieldInfoPtr_Event;

		// Token: 0x04005159 RID: 20825
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400515A RID: 20826
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_0;

		// Token: 0x0400515B RID: 20827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
