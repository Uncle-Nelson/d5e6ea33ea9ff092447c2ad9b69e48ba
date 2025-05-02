using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000280 RID: 640
	[Serializable]
	public class PackagerConfigurationData : SaveData
	{
		// Token: 0x06002FCC RID: 12236 RVA: 0x00108A48 File Offset: 0x00106C48
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerConfigurationData()
		{
			Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PackagerConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr);
			PackagerConfigurationData.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr, "Bed");
			PackagerConfigurationData.NativeFieldInfoPtr_Stations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr, "Stations");
			PackagerConfigurationData.NativeFieldInfoPtr_Routes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr, "Routes");
			PackagerConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_RouteListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr, 100668791);
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x00108AC8 File Offset: 0x00106CC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130734, RefRangeEnd = 130736, XrefRangeStart = 130734, XrefRangeEnd = 130736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerConfigurationData(ObjectFieldData bed, ObjectListFieldData stations, RouteListData routes) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stations);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(routes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_RouteListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x00019527 File Offset: 0x00017727
		public PackagerConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06002FCF RID: 12239 RVA: 0x00108B38 File Offset: 0x00106D38
		// (set) Token: 0x06002FD0 RID: 12240 RVA: 0x00019530 File Offset: 0x00017730
		public unsafe ObjectFieldData Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06002FD1 RID: 12241 RVA: 0x00108B68 File Offset: 0x00106D68
		// (set) Token: 0x06002FD2 RID: 12242 RVA: 0x0001954F File Offset: 0x0001774F
		public unsafe ObjectListFieldData Stations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Stations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Stations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06002FD3 RID: 12243 RVA: 0x00108B98 File Offset: 0x00106D98
		// (set) Token: 0x06002FD4 RID: 12244 RVA: 0x0001956E File Offset: 0x0001776E
		public unsafe RouteListData Routes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Routes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteListData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Routes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeFieldInfoPtr_Stations;

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeFieldInfoPtr_Routes;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_RouteListData_0;
	}
}
