using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000281 RID: 641
	[Serializable]
	public class PackagingStationConfigurationData : SaveData
	{
		// Token: 0x06002FD5 RID: 12245 RVA: 0x00108BC8 File Offset: 0x00106DC8
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationConfigurationData()
		{
			Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PackagingStationConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr);
			PackagingStationConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr, "Destination");
			PackagingStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr, 100668792);
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x00108C20 File Offset: 0x00106E20
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 130499, RefRangeEnd = 130507, XrefRangeStart = 130499, XrefRangeEnd = 130507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationConfigurationData(ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x0001958D File Offset: 0x0001778D
		public PackagingStationConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06002FD8 RID: 12248 RVA: 0x00108C6C File Offset: 0x00106E6C
		// (set) Token: 0x06002FD9 RID: 12249 RVA: 0x00019596 File Offset: 0x00017796
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F6F RID: 8047
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F70 RID: 8048
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0;
	}
}
