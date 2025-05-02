using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000417 RID: 1047
	public class CustomerSatisfaction : Object
	{
		// Token: 0x06005BB6 RID: 23478 RVA: 0x001A9484 File Offset: 0x001A7684
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerSatisfaction()
		{
			Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "CustomerSatisfaction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr);
			CustomerSatisfaction.NativeMethodInfoPtr_GetRelationshipChange_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr, 100674987);
			CustomerSatisfaction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr, 100674988);
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x001A94DC File Offset: 0x001A76DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193595, RefRangeEnd = 193596, XrefRangeStart = 193595, XrefRangeEnd = 193595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetRelationshipChange(float satisfaction)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref satisfaction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSatisfaction.NativeMethodInfoPtr_GetRelationshipChange_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005BB8 RID: 23480 RVA: 0x001A951C File Offset: 0x001A771C
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerSatisfaction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSatisfaction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BB9 RID: 23481 RVA: 0x0002B45B File Offset: 0x0002965B
		public CustomerSatisfaction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003EB3 RID: 16051
		private static readonly IntPtr NativeMethodInfoPtr_GetRelationshipChange_Public_Static_Single_Single_0;

		// Token: 0x04003EB4 RID: 16052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
