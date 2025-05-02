using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001CC RID: 460
	public class SystemTriggerObject : MonoBehaviour
	{
		// Token: 0x06002730 RID: 10032 RVA: 0x000EB48C File Offset: 0x000E968C
		// Note: this type is marked as 'beforefieldinit'.
		static SystemTriggerObject()
		{
			Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "SystemTriggerObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr);
			SystemTriggerObject.NativeFieldInfoPtr_SystemTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr, "SystemTrigger");
			SystemTriggerObject.NativeMethodInfoPtr_Trigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr, 100667664);
			SystemTriggerObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr, 100667665);
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x000EB4F8 File Offset: 0x000E96F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117756, XrefRangeEnd = 117758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTriggerObject.NativeMethodInfoPtr_Trigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x000EB52C File Offset: 0x000E972C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemTriggerObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTriggerObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x00015B95 File Offset: 0x00013D95
		public SystemTriggerObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x000EB568 File Offset: 0x000E9768
		// (set) Token: 0x06002735 RID: 10037 RVA: 0x00015B9E File Offset: 0x00013D9E
		public unsafe SystemTrigger SystemTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTriggerObject.NativeFieldInfoPtr_SystemTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SystemTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTriggerObject.NativeFieldInfoPtr_SystemTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeFieldInfoPtr_SystemTrigger;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Public_Void_0;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
