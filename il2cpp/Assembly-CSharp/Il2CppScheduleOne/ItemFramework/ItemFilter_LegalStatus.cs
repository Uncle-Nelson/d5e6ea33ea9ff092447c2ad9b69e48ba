using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005DB RID: 1499
	public class ItemFilter_LegalStatus : ItemFilter
	{
		// Token: 0x06008369 RID: 33641 RVA: 0x0022EE10 File Offset: 0x0022D010
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_LegalStatus()
		{
			Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_LegalStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr);
			ItemFilter_LegalStatus.NativeFieldInfoPtr_RequiredLegalStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr, "RequiredLegalStatus");
			ItemFilter_LegalStatus.NativeMethodInfoPtr__ctor_Public_Void_ELegalStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr, 100679731);
			ItemFilter_LegalStatus.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr, 100679732);
		}

		// Token: 0x0600836A RID: 33642 RVA: 0x0022EE7C File Offset: 0x0022D07C
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_LegalStatus(ELegalStatus requiredLegalStatus) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requiredLegalStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_LegalStatus.NativeMethodInfoPtr__ctor_Public_Void_ELegalStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600836B RID: 33643 RVA: 0x0022EEC4 File Offset: 0x0022D0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247467, XrefRangeEnd = 247468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_LegalStatus.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600836C RID: 33644 RVA: 0x0003E6EC File Offset: 0x0003C8EC
		public ItemFilter_LegalStatus(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027C1 RID: 10177
		// (get) Token: 0x0600836D RID: 33645 RVA: 0x0022EF1C File Offset: 0x0022D11C
		// (set) Token: 0x0600836E RID: 33646 RVA: 0x0003E6F5 File Offset: 0x0003C8F5
		public unsafe ELegalStatus RequiredLegalStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_LegalStatus.NativeFieldInfoPtr_RequiredLegalStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_LegalStatus.NativeFieldInfoPtr_RequiredLegalStatus)) = value;
			}
		}

		// Token: 0x04005971 RID: 22897
		private static readonly IntPtr NativeFieldInfoPtr_RequiredLegalStatus;

		// Token: 0x04005972 RID: 22898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ELegalStatus_0;

		// Token: 0x04005973 RID: 22899
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
