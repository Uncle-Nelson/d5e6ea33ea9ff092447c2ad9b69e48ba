using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000420 RID: 1056
	public class DarkMarketRollerDoors : SensorRollerDoors
	{
		// Token: 0x06005D03 RID: 23811 RVA: 0x001ADEA8 File Offset: 0x001AC0A8
		// Note: this type is marked as 'beforefieldinit'.
		static DarkMarketRollerDoors()
		{
			Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DarkMarketRollerDoors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr);
			DarkMarketRollerDoors.NativeMethodInfoPtr_CanOpen_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr, 100675151);
			DarkMarketRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr, 100675152);
		}

		// Token: 0x06005D04 RID: 23812 RVA: 0x001ADF00 File Offset: 0x001AC100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195802, XrefRangeEnd = 195806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarketRollerDoors.NativeMethodInfoPtr_CanOpen_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005D05 RID: 23813 RVA: 0x001ADF48 File Offset: 0x001AC148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195806, XrefRangeEnd = 195809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DarkMarketRollerDoors() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D06 RID: 23814 RVA: 0x0002BD82 File Offset: 0x00029F82
		public DarkMarketRollerDoors(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003FA2 RID: 16290
		private static readonly IntPtr NativeMethodInfoPtr_CanOpen_Protected_Virtual_Boolean_0;

		// Token: 0x04003FA3 RID: 16291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
