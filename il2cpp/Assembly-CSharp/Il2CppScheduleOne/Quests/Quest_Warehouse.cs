using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C5 RID: 453
	public class Quest_Warehouse : Quest
	{
		// Token: 0x060026D4 RID: 9940 RVA: 0x000EA5FC File Offset: 0x000E87FC
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Warehouse()
		{
			Il2CppClassPointerStore<Quest_Warehouse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Warehouse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Warehouse>.NativeClassPtr);
			Quest_Warehouse.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Warehouse>.NativeClassPtr, 100667638);
			Quest_Warehouse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Warehouse>.NativeClassPtr, 100667639);
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x000EA654 File Offset: 0x000E8854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Warehouse.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x000EA690 File Offset: 0x000E8890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117615, XrefRangeEnd = 117619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Warehouse() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Warehouse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Warehouse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x00015821 File Offset: 0x00013A21
		public Quest_Warehouse(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
