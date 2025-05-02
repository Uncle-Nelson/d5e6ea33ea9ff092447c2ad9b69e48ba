using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200077E RID: 1918
	public class MedicalCentre : NPCEnterableBuilding
	{
		// Token: 0x0600B5B3 RID: 46515 RVA: 0x002D29E8 File Offset: 0x002D0BE8
		// Note: this type is marked as 'beforefieldinit'.
		static MedicalCentre()
		{
			Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "MedicalCentre");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr);
			MedicalCentre.NativeFieldInfoPtr_RespawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr, "RespawnPoint");
			MedicalCentre.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr, 100685627);
		}

		// Token: 0x0600B5B4 RID: 46516 RVA: 0x002D2A40 File Offset: 0x002D0C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310621, XrefRangeEnd = 310622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MedicalCentre() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MedicalCentre.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5B5 RID: 46517 RVA: 0x00059305 File Offset: 0x00057505
		public MedicalCentre(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x0600B5B6 RID: 46518 RVA: 0x002D2A7C File Offset: 0x002D0C7C
		// (set) Token: 0x0600B5B7 RID: 46519 RVA: 0x0005930E File Offset: 0x0005750E
		public unsafe Transform RespawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MedicalCentre.NativeFieldInfoPtr_RespawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MedicalCentre.NativeFieldInfoPtr_RespawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A70 RID: 31344
		private static readonly IntPtr NativeFieldInfoPtr_RespawnPoint;

		// Token: 0x04007A71 RID: 31345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
