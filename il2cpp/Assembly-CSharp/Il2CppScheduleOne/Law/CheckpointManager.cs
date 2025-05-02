using System;
using Il2CppFishNet.Connection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Police;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C2 RID: 962
	public class CheckpointManager : NetworkSingleton<CheckpointManager>
	{
		// Token: 0x06004B02 RID: 19202 RVA: 0x0016B1C8 File Offset: 0x001693C8
		// Note: this type is marked as 'beforefieldinit'.
		static CheckpointManager()
		{
			Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CheckpointManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr);
			CheckpointManager.NativeFieldInfoPtr_WesternCheckpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "WesternCheckpoint");
			CheckpointManager.NativeFieldInfoPtr_DocksCheckpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "DocksCheckpoint");
			CheckpointManager.NativeFieldInfoPtr_NorthResidentialCheckpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "NorthResidentialCheckpoint");
			CheckpointManager.NativeFieldInfoPtr_WestResidentialCheckpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "WestResidentialCheckpoint");
			CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted");
			CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted");
			CheckpointManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672593);
			CheckpointManager.NativeMethodInfoPtr_SetCheckpointEnabled_Public_Void_ECheckpointLocation_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672594);
			CheckpointManager.NativeMethodInfoPtr_GetCheckpoint_Public_RoadCheckpoint_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672595);
			CheckpointManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672596);
			CheckpointManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672597);
			CheckpointManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672598);
			CheckpointManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672599);
			CheckpointManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672600);
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x0016B310 File Offset: 0x00169510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164753, XrefRangeEnd = 164758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x0016B360 File Offset: 0x00169560
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164764, RefRangeEnd = 164765, XrefRangeStart = 164758, XrefRangeEnd = 164764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCheckpointEnabled(CheckpointManager.ECheckpointLocation checkpoint, bool enabled, int requestedOfficers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref checkpoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedOfficers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointManager.NativeMethodInfoPtr_SetCheckpointEnabled_Public_Void_ECheckpointLocation_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x0016B3BC File Offset: 0x001695BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 164765, RefRangeEnd = 164768, XrefRangeStart = 164765, XrefRangeEnd = 164765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoadCheckpoint GetCheckpoint(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointManager.NativeMethodInfoPtr_GetCheckpoint_Public_RoadCheckpoint_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr3) : null;
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x0016B408 File Offset: 0x00169608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164768, XrefRangeEnd = 164771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckpointManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x0016B444 File Offset: 0x00169644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164771, XrefRangeEnd = 164774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x0016B480 File Offset: 0x00169680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164774, XrefRangeEnd = 164777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x0016B4BC File Offset: 0x001696BC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x0016B4F8 File Offset: 0x001696F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164777, XrefRangeEnd = 164780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x00024237 File Offset: 0x00022437
		public CheckpointManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06004B0C RID: 19212 RVA: 0x0016B534 File Offset: 0x00169734
		// (set) Token: 0x06004B0D RID: 19213 RVA: 0x00024240 File Offset: 0x00022440
		public unsafe RoadCheckpoint WesternCheckpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_WesternCheckpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_WesternCheckpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06004B0E RID: 19214 RVA: 0x0016B564 File Offset: 0x00169764
		// (set) Token: 0x06004B0F RID: 19215 RVA: 0x0002425F File Offset: 0x0002245F
		public unsafe RoadCheckpoint DocksCheckpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_DocksCheckpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_DocksCheckpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06004B10 RID: 19216 RVA: 0x0016B594 File Offset: 0x00169794
		// (set) Token: 0x06004B11 RID: 19217 RVA: 0x0002427E File Offset: 0x0002247E
		public unsafe RoadCheckpoint NorthResidentialCheckpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_NorthResidentialCheckpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_NorthResidentialCheckpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06004B12 RID: 19218 RVA: 0x0016B5C4 File Offset: 0x001697C4
		// (set) Token: 0x06004B13 RID: 19219 RVA: 0x0002429D File Offset: 0x0002249D
		public unsafe RoadCheckpoint WestResidentialCheckpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_WestResidentialCheckpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_WestResidentialCheckpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06004B14 RID: 19220 RVA: 0x0016B5F4 File Offset: 0x001697F4
		// (set) Token: 0x06004B15 RID: 19221 RVA: 0x000242BC File Offset: 0x000224BC
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06004B16 RID: 19222 RVA: 0x0016B61C File Offset: 0x0016981C
		// (set) Token: 0x06004B17 RID: 19223 RVA: 0x000242D7 File Offset: 0x000224D7
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400329B RID: 12955
		private static readonly IntPtr NativeFieldInfoPtr_WesternCheckpoint;

		// Token: 0x0400329C RID: 12956
		private static readonly IntPtr NativeFieldInfoPtr_DocksCheckpoint;

		// Token: 0x0400329D RID: 12957
		private static readonly IntPtr NativeFieldInfoPtr_NorthResidentialCheckpoint;

		// Token: 0x0400329E RID: 12958
		private static readonly IntPtr NativeFieldInfoPtr_WestResidentialCheckpoint;

		// Token: 0x0400329F RID: 12959
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040032A0 RID: 12960
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040032A1 RID: 12961
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040032A2 RID: 12962
		private static readonly IntPtr NativeMethodInfoPtr_SetCheckpointEnabled_Public_Void_ECheckpointLocation_Boolean_Int32_0;

		// Token: 0x040032A3 RID: 12963
		private static readonly IntPtr NativeMethodInfoPtr_GetCheckpoint_Public_RoadCheckpoint_ECheckpointLocation_0;

		// Token: 0x040032A4 RID: 12964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040032A5 RID: 12965
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040032A6 RID: 12966
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040032A7 RID: 12967
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040032A8 RID: 12968
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000989 RID: 2441
		[OriginalName("Assembly-CSharp.dll", "", "ECheckpointLocation")]
		public enum ECheckpointLocation
		{
			// Token: 0x040088E4 RID: 35044
			Western,
			// Token: 0x040088E5 RID: 35045
			Docks,
			// Token: 0x040088E6 RID: 35046
			NorthResidential,
			// Token: 0x040088E7 RID: 35047
			WestResidential
		}
	}
}
