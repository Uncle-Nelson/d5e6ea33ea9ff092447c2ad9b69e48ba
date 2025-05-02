using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003DD RID: 989
	public class SentryLocation : MonoBehaviour
	{
		// Token: 0x06004C8B RID: 19595 RVA: 0x0016FE28 File Offset: 0x0016E028
		// Note: this type is marked as 'beforefieldinit'.
		static SentryLocation()
		{
			Il2CppClassPointerStore<SentryLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "SentryLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr);
			SentryLocation.NativeFieldInfoPtr_StandPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, "StandPoints");
			SentryLocation.NativeFieldInfoPtr_AssignedOfficers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, "AssignedOfficers");
			SentryLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, 100672744);
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x0016FE94 File Offset: 0x0016E094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165822, XrefRangeEnd = 165837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SentryLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x00024D05 File Offset: 0x00022F05
		public SentryLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06004C8E RID: 19598 RVA: 0x0016FED0 File Offset: 0x0016E0D0
		// (set) Token: 0x06004C8F RID: 19599 RVA: 0x00024D0E File Offset: 0x00022F0E
		public unsafe List<Transform> StandPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr_StandPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr_StandPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06004C90 RID: 19600 RVA: 0x0016FF00 File Offset: 0x0016E100
		// (set) Token: 0x06004C91 RID: 19601 RVA: 0x00024D2D File Offset: 0x00022F2D
		public unsafe List<PoliceOfficer> AssignedOfficers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr_AssignedOfficers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr_AssignedOfficers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400338E RID: 13198
		private static readonly IntPtr NativeFieldInfoPtr_StandPoints;

		// Token: 0x0400338F RID: 13199
		private static readonly IntPtr NativeFieldInfoPtr_AssignedOfficers;

		// Token: 0x04003390 RID: 13200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
