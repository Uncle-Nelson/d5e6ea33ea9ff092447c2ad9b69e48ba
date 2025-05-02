using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D5 RID: 1493
	public class IDs : ItemFilter
	{
		// Token: 0x06008344 RID: 33604 RVA: 0x0022E61C File Offset: 0x0022C81C
		// Note: this type is marked as 'beforefieldinit'.
		static IDs()
		{
			Il2CppClassPointerStore<IDs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IDs>.NativeClassPtr);
			IDs.NativeFieldInfoPtr_AcceptedIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IDs>.NativeClassPtr, "AcceptedIDs");
			IDs.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDs>.NativeClassPtr, 100679716);
			IDs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDs>.NativeClassPtr, 100679717);
		}

		// Token: 0x06008345 RID: 33605 RVA: 0x0022E688 File Offset: 0x0022C888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247390, XrefRangeEnd = 247393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDs.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008346 RID: 33606 RVA: 0x0022E6E0 File Offset: 0x0022C8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247393, XrefRangeEnd = 247401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDs() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IDs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IDs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008347 RID: 33607 RVA: 0x0003E623 File Offset: 0x0003C823
		public IDs(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027BB RID: 10171
		// (get) Token: 0x06008348 RID: 33608 RVA: 0x0022E71C File Offset: 0x0022C91C
		// (set) Token: 0x06008349 RID: 33609 RVA: 0x0003E62C File Offset: 0x0003C82C
		public unsafe List<string> AcceptedIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IDs.NativeFieldInfoPtr_AcceptedIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IDs.NativeFieldInfoPtr_AcceptedIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400595D RID: 22877
		private static readonly IntPtr NativeFieldInfoPtr_AcceptedIDs;

		// Token: 0x0400595E RID: 22878
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;

		// Token: 0x0400595F RID: 22879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
