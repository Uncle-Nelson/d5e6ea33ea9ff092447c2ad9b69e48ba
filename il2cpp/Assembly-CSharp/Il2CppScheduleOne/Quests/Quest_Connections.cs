using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001B7 RID: 439
	public class Quest_Connections : Quest
	{
		// Token: 0x06002628 RID: 9768 RVA: 0x000E85E4 File Offset: 0x000E67E4
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Connections()
		{
			Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Connections");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr);
			Quest_Connections.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr, 100667566);
			Quest_Connections.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr, 100667567);
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x000E863C File Offset: 0x000E683C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116765, XrefRangeEnd = 116784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Connections.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x000E8688 File Offset: 0x000E6888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116784, XrefRangeEnd = 116788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Connections() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Connections.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x00015302 File Offset: 0x00013502
		public Quest_Connections(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
