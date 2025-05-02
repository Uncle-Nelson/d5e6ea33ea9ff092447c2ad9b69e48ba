using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x02000759 RID: 1881
	[Serializable]
	public class TrashGrabberDefinition : StorableItemDefinition
	{
		// Token: 0x0600B32F RID: 45871 RVA: 0x002CB2A4 File Offset: 0x002C94A4
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGrabberDefinition()
		{
			Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "TrashGrabberDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr);
			TrashGrabberDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr, 100685396);
			TrashGrabberDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr, 100685397);
		}

		// Token: 0x0600B330 RID: 45872 RVA: 0x002CB2FC File Offset: 0x002C94FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308719, XrefRangeEnd = 308723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600B331 RID: 45873 RVA: 0x002CB354 File Offset: 0x002C9554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B332 RID: 45874 RVA: 0x00057D39 File Offset: 0x00055F39
		public TrashGrabberDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040078E5 RID: 30949
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040078E6 RID: 30950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
