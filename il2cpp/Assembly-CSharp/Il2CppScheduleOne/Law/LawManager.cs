using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D9 RID: 985
	public class LawManager : Singleton<LawManager>
	{
		// Token: 0x06004C35 RID: 19509 RVA: 0x0016F13C File Offset: 0x0016D33C
		// Note: this type is marked as 'beforefieldinit'.
		static LawManager()
		{
			Il2CppClassPointerStore<LawManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "LawManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawManager>.NativeClassPtr);
			LawManager.NativeFieldInfoPtr_DISPATCH_OFFICER_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager>.NativeClassPtr, "DISPATCH_OFFICER_COUNT");
			LawManager.NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager>.NativeClassPtr, "DISPATCH_VEHICLE_USE_THRESHOLD");
			LawManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672722);
			LawManager.NativeMethodInfoPtr_PoliceCalled_Public_Void_Player_Crime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672723);
			LawManager.NativeMethodInfoPtr_StartFootpatrol_Public_PatrolGroup_FootPatrolRoute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672724);
			LawManager.NativeMethodInfoPtr_StartVehiclePatrol_Public_PoliceOfficer_VehiclePatrolRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672725);
			LawManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672726);
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x0016F1F8 File Offset: 0x0016D3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165446, XrefRangeEnd = 165472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x0016F234 File Offset: 0x0016D434
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 165492, RefRangeEnd = 165495, XrefRangeStart = 165472, XrefRangeEnd = 165492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PoliceCalled(Player target, Crime crime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(crime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr_PoliceCalled_Public_Void_Player_Crime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x0016F288 File Offset: 0x0016D488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165523, RefRangeEnd = 165524, XrefRangeStart = 165495, XrefRangeEnd = 165523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PatrolGroup StartFootpatrol(FootPatrolRoute route, int requestedMembers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedMembers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr_StartFootpatrol_Public_PatrolGroup_FootPatrolRoute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr3) : null;
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x0016F2E8 File Offset: 0x0016D4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165524, XrefRangeEnd = 165536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceOfficer StartVehiclePatrol(VehiclePatrolRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr_StartVehiclePatrol_Public_PoliceOfficer_VehiclePatrolRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr3) : null;
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x0016F338 File Offset: 0x0016D538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165536, XrefRangeEnd = 165539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x00024A77 File Offset: 0x00022C77
		public LawManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x06004C3C RID: 19516 RVA: 0x0016F374 File Offset: 0x0016D574
		// (set) Token: 0x06004C3D RID: 19517 RVA: 0x00024A80 File Offset: 0x00022C80
		public unsafe static int DISPATCH_OFFICER_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LawManager.NativeFieldInfoPtr_DISPATCH_OFFICER_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LawManager.NativeFieldInfoPtr_DISPATCH_OFFICER_COUNT, (void*)(&value));
			}
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x06004C3E RID: 19518 RVA: 0x0016F390 File Offset: 0x0016D590
		// (set) Token: 0x06004C3F RID: 19519 RVA: 0x00024A8E File Offset: 0x00022C8E
		public unsafe static float DISPATCH_VEHICLE_USE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LawManager.NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LawManager.NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x0400335E RID: 13150
		private static readonly IntPtr NativeFieldInfoPtr_DISPATCH_OFFICER_COUNT;

		// Token: 0x0400335F RID: 13151
		private static readonly IntPtr NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD;

		// Token: 0x04003360 RID: 13152
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003361 RID: 13153
		private static readonly IntPtr NativeMethodInfoPtr_PoliceCalled_Public_Void_Player_Crime_0;

		// Token: 0x04003362 RID: 13154
		private static readonly IntPtr NativeMethodInfoPtr_StartFootpatrol_Public_PatrolGroup_FootPatrolRoute_Int32_0;

		// Token: 0x04003363 RID: 13155
		private static readonly IntPtr NativeMethodInfoPtr_StartVehiclePatrol_Public_PoliceOfficer_VehiclePatrolRoute_0;

		// Token: 0x04003364 RID: 13156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200098A RID: 2442
		[ObfuscatedName("ScheduleOne.Law.LawManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600CA60 RID: 51808 RVA: 0x0030F1B4 File Offset: 0x0030D3B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LawManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr);
				LawManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, "<>9");
				LawManager.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, "<>9__2_0");
				LawManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, 100672729);
				LawManager.__c.NativeMethodInfoPtr__Start_b__2_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, 100672730);
			}

			// Token: 0x0600CA61 RID: 51809 RVA: 0x0030F230 File Offset: 0x0030D430
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA62 RID: 51810 RVA: 0x0030F26C File Offset: 0x0030D46C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165440, XrefRangeEnd = 165446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__2_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.__c.NativeMethodInfoPtr__Start_b__2_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA63 RID: 51811 RVA: 0x00062657 File Offset: 0x00060857
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F10 RID: 16144
			// (get) Token: 0x0600CA64 RID: 51812 RVA: 0x0030F2A0 File Offset: 0x0030D4A0
			// (set) Token: 0x0600CA65 RID: 51813 RVA: 0x00062660 File Offset: 0x00060860
			public unsafe static LawManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LawManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LawManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F11 RID: 16145
			// (get) Token: 0x0600CA66 RID: 51814 RVA: 0x0030F2C8 File Offset: 0x0030D4C8
			// (set) Token: 0x0600CA67 RID: 51815 RVA: 0x00062672 File Offset: 0x00060872
			public unsafe static UnityAction __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LawManager.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LawManager.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088E8 RID: 35048
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040088E9 RID: 35049
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040088EA RID: 35050
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088EB RID: 35051
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__2_0_Internal_Void_0;
		}
	}
}
