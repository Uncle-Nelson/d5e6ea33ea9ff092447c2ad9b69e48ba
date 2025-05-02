using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054C RID: 1356
	public class RoadCracksRandomizer : MonoBehaviour
	{
		// Token: 0x060077BF RID: 30655 RVA: 0x00207214 File Offset: 0x00205414
		// Note: this type is marked as 'beforefieldinit'.
		static RoadCracksRandomizer()
		{
			Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RoadCracksRandomizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr);
			RoadCracksRandomizer.NativeFieldInfoPtr_Cracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, "Cracks");
			RoadCracksRandomizer.NativeFieldInfoPtr_MinCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, "MinCount");
			RoadCracksRandomizer.NativeFieldInfoPtr_MaxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, "MaxCount");
			RoadCracksRandomizer.NativeMethodInfoPtr_Randomize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, 100678369);
			RoadCracksRandomizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, 100678370);
		}

		// Token: 0x060077C0 RID: 30656 RVA: 0x002072A8 File Offset: 0x002054A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232158, XrefRangeEnd = 232183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Randomize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCracksRandomizer.NativeMethodInfoPtr_Randomize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077C1 RID: 30657 RVA: 0x002072DC File Offset: 0x002054DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232183, XrefRangeEnd = 232184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoadCracksRandomizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCracksRandomizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x00038B5A File Offset: 0x00036D5A
		public RoadCracksRandomizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700242F RID: 9263
		// (get) Token: 0x060077C3 RID: 30659 RVA: 0x00207318 File Offset: 0x00205518
		// (set) Token: 0x060077C4 RID: 30660 RVA: 0x00038B63 File Offset: 0x00036D63
		public unsafe Il2CppReferenceArray<Transform> Cracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_Cracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_Cracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x060077C5 RID: 30661 RVA: 0x00207348 File Offset: 0x00205548
		// (set) Token: 0x060077C6 RID: 30662 RVA: 0x00038B82 File Offset: 0x00036D82
		public unsafe int MinCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MinCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MinCount)) = value;
			}
		}

		// Token: 0x17002431 RID: 9265
		// (get) Token: 0x060077C7 RID: 30663 RVA: 0x00207370 File Offset: 0x00205570
		// (set) Token: 0x060077C8 RID: 30664 RVA: 0x00038B9D File Offset: 0x00036D9D
		public unsafe int MaxCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MaxCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MaxCount)) = value;
			}
		}

		// Token: 0x040051B2 RID: 20914
		private static readonly IntPtr NativeFieldInfoPtr_Cracks;

		// Token: 0x040051B3 RID: 20915
		private static readonly IntPtr NativeFieldInfoPtr_MinCount;

		// Token: 0x040051B4 RID: 20916
		private static readonly IntPtr NativeFieldInfoPtr_MaxCount;

		// Token: 0x040051B5 RID: 20917
		private static readonly IntPtr NativeMethodInfoPtr_Randomize_Private_Void_0;

		// Token: 0x040051B6 RID: 20918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
