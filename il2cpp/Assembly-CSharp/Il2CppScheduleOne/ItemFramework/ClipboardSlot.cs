using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D3 RID: 1491
	public class ClipboardSlot : HotbarSlot
	{
		// Token: 0x06008340 RID: 33600 RVA: 0x0022E53C File Offset: 0x0022C73C
		// Note: this type is marked as 'beforefieldinit'.
		static ClipboardSlot()
		{
			Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ClipboardSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr);
			ClipboardSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr, 100679714);
			ClipboardSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr, 100679715);
		}

		// Token: 0x06008341 RID: 33601 RVA: 0x0022E594 File Offset: 0x0022C794
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClipboardSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008342 RID: 33602 RVA: 0x0022E5E0 File Offset: 0x0022C7E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247388, RefRangeEnd = 247390, XrefRangeStart = 247387, XrefRangeEnd = 247388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClipboardSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008343 RID: 33603 RVA: 0x0003E61A File Offset: 0x0003C81A
		public ClipboardSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400594E RID: 22862
		private static readonly IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400594F RID: 22863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
