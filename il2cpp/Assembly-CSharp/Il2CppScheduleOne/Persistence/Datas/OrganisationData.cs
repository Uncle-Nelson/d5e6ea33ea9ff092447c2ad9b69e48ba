using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A6 RID: 678
	[Serializable]
	public class OrganisationData : SaveData
	{
		// Token: 0x0600311F RID: 12575 RVA: 0x0010C904 File Offset: 0x0010AB04
		// Note: this type is marked as 'beforefieldinit'.
		static OrganisationData()
		{
			Il2CppClassPointerStore<OrganisationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "OrganisationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr);
			OrganisationData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr, "Name");
			OrganisationData.NativeFieldInfoPtr_NetWorth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr, "NetWorth");
			OrganisationData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr, 100668830);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x0010C970 File Offset: 0x0010AB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131088, XrefRangeEnd = 131090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrganisationData(string name, float netWorth) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref netWorth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrganisationData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x0001A351 File Offset: 0x00018551
		public OrganisationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x0010C9CC File Offset: 0x0010ABCC
		// (set) Token: 0x06003123 RID: 12579 RVA: 0x0001A35A File Offset: 0x0001855A
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x0010C9F4 File Offset: 0x0010ABF4
		// (set) Token: 0x06003125 RID: 12581 RVA: 0x0001A379 File Offset: 0x00018579
		public unsafe float NetWorth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_NetWorth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_NetWorth)) = value;
			}
		}

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeFieldInfoPtr_NetWorth;

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;
	}
}
