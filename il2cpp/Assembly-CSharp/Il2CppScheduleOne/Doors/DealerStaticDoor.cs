using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000421 RID: 1057
	public class DealerStaticDoor : StaticDoor
	{
		// Token: 0x06005D07 RID: 23815 RVA: 0x001ADF84 File Offset: 0x001AC184
		// Note: this type is marked as 'beforefieldinit'.
		static DealerStaticDoor()
		{
			Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DealerStaticDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr);
			DealerStaticDoor.NativeFieldInfoPtr_Dealer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr, "Dealer");
			DealerStaticDoor.NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr, 100675153);
			DealerStaticDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr, 100675154);
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x001ADFF0 File Offset: 0x001AC1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195809, XrefRangeEnd = 195823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsKnockValid(out string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerStaticDoor.NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005D09 RID: 23817 RVA: 0x001AE054 File Offset: 0x001AC254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195823, XrefRangeEnd = 195824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerStaticDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerStaticDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D0A RID: 23818 RVA: 0x0002BD8B File Offset: 0x00029F8B
		public DealerStaticDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x06005D0B RID: 23819 RVA: 0x001AE090 File Offset: 0x001AC290
		// (set) Token: 0x06005D0C RID: 23820 RVA: 0x0002BD94 File Offset: 0x00029F94
		public unsafe Dealer Dealer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerStaticDoor.NativeFieldInfoPtr_Dealer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerStaticDoor.NativeFieldInfoPtr_Dealer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003FA4 RID: 16292
		private static readonly IntPtr NativeFieldInfoPtr_Dealer;

		// Token: 0x04003FA5 RID: 16293
		private static readonly IntPtr NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_Boolean_byref_String_0;

		// Token: 0x04003FA6 RID: 16294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
