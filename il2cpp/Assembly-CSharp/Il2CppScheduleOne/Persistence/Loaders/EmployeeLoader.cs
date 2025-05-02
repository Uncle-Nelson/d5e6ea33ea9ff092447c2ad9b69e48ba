using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000241 RID: 577
	public class EmployeeLoader : NPCLoader
	{
		// Token: 0x06002E31 RID: 11825 RVA: 0x0010396C File Offset: 0x00101B6C
		// Note: this type is marked as 'beforefieldinit'.
		static EmployeeLoader()
		{
			Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "EmployeeLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr);
			EmployeeLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr, 100668625);
			EmployeeLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr, 100668626);
			EmployeeLoader.NativeMethodInfoPtr_LoadAndCreateEmployee_Public_Employee_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr, 100668627);
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06002E32 RID: 11826 RVA: 0x001039D8 File Offset: 0x00101BD8
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128747, XrefRangeEnd = 128754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x00103A1C File Offset: 0x00101C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x00103A58 File Offset: 0x00101C58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 128822, RefRangeEnd = 128826, XrefRangeStart = 128754, XrefRangeEnd = 128822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee LoadAndCreateEmployee(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeLoader.NativeMethodInfoPtr_LoadAndCreateEmployee_Public_Employee_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x00018941 File Offset: 0x00016B41
		public EmployeeLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndCreateEmployee_Public_Employee_String_0;
	}
}
