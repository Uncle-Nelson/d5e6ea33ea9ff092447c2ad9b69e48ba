using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000259 RID: 601
	[Serializable]
	public class BusinessData : PropertyData
	{
		// Token: 0x06002EB4 RID: 11956 RVA: 0x00105A58 File Offset: 0x00103C58
		// Note: this type is marked as 'beforefieldinit'.
		static BusinessData()
		{
			Il2CppClassPointerStore<BusinessData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BusinessData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BusinessData>.NativeClassPtr);
			BusinessData.NativeFieldInfoPtr_LaunderingOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BusinessData>.NativeClassPtr, "LaunderingOperations");
			BusinessData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_LaunderOperationData_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessData>.NativeClassPtr, 100668727);
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x00105AB0 File Offset: 0x00103CB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130512, RefRangeEnd = 130513, XrefRangeStart = 130507, XrefRangeEnd = 130512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BusinessData(string propertyCode, bool isOwned, Il2CppStructArray<bool> switchStates, Il2CppReferenceArray<LaunderOperationData> launderingOperations, Il2CppStructArray<bool> toggleableStates) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BusinessData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOwned;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(switchStates);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(launderingOperations);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toggleableStates);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_LaunderOperationData_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x00018A57 File Offset: 0x00016C57
		public BusinessData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x00105B44 File Offset: 0x00103D44
		// (set) Token: 0x06002EB8 RID: 11960 RVA: 0x00018A60 File Offset: 0x00016C60
		public unsafe Il2CppReferenceArray<LaunderOperationData> LaunderingOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessData.NativeFieldInfoPtr_LaunderingOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LaunderOperationData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessData.NativeFieldInfoPtr_LaunderingOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeFieldInfoPtr_LaunderingOperations;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_LaunderOperationData_Il2CppStructArray_1_Boolean_0;
	}
}
