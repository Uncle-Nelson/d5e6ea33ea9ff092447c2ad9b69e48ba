using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000271 RID: 625
	[Serializable]
	public class AdvancedTransitRouteData : Object
	{
		// Token: 0x06002F6C RID: 12140 RVA: 0x00107A64 File Offset: 0x00105C64
		// Note: this type is marked as 'beforefieldinit'.
		static AdvancedTransitRouteData()
		{
			Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "AdvancedTransitRouteData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr);
			AdvancedTransitRouteData.NativeFieldInfoPtr_SourceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "SourceGUID");
			AdvancedTransitRouteData.NativeFieldInfoPtr_DestinationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "DestinationGUID");
			AdvancedTransitRouteData.NativeFieldInfoPtr_FilterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "FilterMode");
			AdvancedTransitRouteData.NativeFieldInfoPtr_FilterItemIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "FilterItemIDs");
			AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EMode_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, 100668775);
			AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, 100668776);
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x00107B0C File Offset: 0x00105D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130729, RefRangeEnd = 130730, XrefRangeStart = 130725, XrefRangeEnd = 130729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRouteData(string sourceGUID, string destinationGUID, ManagementItemFilter.EMode filtermode, List<string> filterGUIDs) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filtermode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterGUIDs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EMode_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00107B8C File Offset: 0x00105D8C
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRouteData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x000191A1 File Offset: 0x000173A1
		public AdvancedTransitRouteData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06002F70 RID: 12144 RVA: 0x00107BC8 File Offset: 0x00105DC8
		// (set) Token: 0x06002F71 RID: 12145 RVA: 0x000191AA File Offset: 0x000173AA
		public unsafe string SourceGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_SourceGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_SourceGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06002F72 RID: 12146 RVA: 0x00107BF0 File Offset: 0x00105DF0
		// (set) Token: 0x06002F73 RID: 12147 RVA: 0x000191C9 File Offset: 0x000173C9
		public unsafe string DestinationGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_DestinationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_DestinationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x00107C18 File Offset: 0x00105E18
		// (set) Token: 0x06002F75 RID: 12149 RVA: 0x000191E8 File Offset: 0x000173E8
		public unsafe ManagementItemFilter.EMode FilterMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterMode)) = value;
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06002F76 RID: 12150 RVA: 0x00107C40 File Offset: 0x00105E40
		// (set) Token: 0x06002F77 RID: 12151 RVA: 0x00019203 File Offset: 0x00017403
		public unsafe List<string> FilterItemIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterItemIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterItemIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F42 RID: 8002
		private static readonly IntPtr NativeFieldInfoPtr_SourceGUID;

		// Token: 0x04001F43 RID: 8003
		private static readonly IntPtr NativeFieldInfoPtr_DestinationGUID;

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeFieldInfoPtr_FilterMode;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeFieldInfoPtr_FilterItemIDs;

		// Token: 0x04001F46 RID: 8006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EMode_List_1_String_0;

		// Token: 0x04001F47 RID: 8007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
