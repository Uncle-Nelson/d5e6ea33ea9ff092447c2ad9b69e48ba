using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003DB RID: 987
	public static class PenaltyHandler : Object
	{
		// Token: 0x06004C57 RID: 19543 RVA: 0x0016F7AC File Offset: 0x0016D9AC
		// Note: this type is marked as 'beforefieldinit'.
		static PenaltyHandler()
		{
			Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PenaltyHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr);
			PenaltyHandler.NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "CONTROLLED_SUBSTANCE_FINE");
			PenaltyHandler.NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "LOW_SEVERITY_DRUG_FINE");
			PenaltyHandler.NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "MED_SEVERITY_DRUG_FINE");
			PenaltyHandler.NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "HIGH_SEVERITY_DRUG_FINE");
			PenaltyHandler.NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "FAILURE_TO_COMPLY_FINE");
			PenaltyHandler.NativeFieldInfoPtr_EVADING_ARREST_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "EVADING_ARREST_FINE");
			PenaltyHandler.NativeFieldInfoPtr_VIOLATING_CURFEW_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "VIOLATING_CURFEW_TIME");
			PenaltyHandler.NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "ATTEMPT_TO_SELL_FINE");
			PenaltyHandler.NativeFieldInfoPtr_ASSAULT_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "ASSAULT_FINE");
			PenaltyHandler.NativeFieldInfoPtr_DEADLY_ASSAULT_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "DEADLY_ASSAULT_FINE");
			PenaltyHandler.NativeFieldInfoPtr_VANDALISM_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "VANDALISM_FINE");
			PenaltyHandler.NativeFieldInfoPtr_THEFT_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "THEFT_FINE");
			PenaltyHandler.NativeFieldInfoPtr_BRANDISHING_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "BRANDISHING_FINE");
			PenaltyHandler.NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "DISCHARGE_FIREARM_FINE");
			PenaltyHandler.NativeMethodInfoPtr_ProcessCrimeList_Public_Static_List_1_String_Dictionary_2_Crime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, 100672738);
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x0016F908 File Offset: 0x0016DB08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165732, RefRangeEnd = 165733, XrefRangeStart = 165621, XrefRangeEnd = 165732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> ProcessCrimeList(Dictionary<Crime, int> crimes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(crimes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PenaltyHandler.NativeMethodInfoPtr_ProcessCrimeList_Public_Static_List_1_String_Dictionary_2_Crime_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x00024B6A File Offset: 0x00022D6A
		public PenaltyHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06004C5A RID: 19546 RVA: 0x0016F94C File Offset: 0x0016DB4C
		// (set) Token: 0x06004C5B RID: 19547 RVA: 0x00024B73 File Offset: 0x00022D73
		public unsafe static float CONTROLLED_SUBSTANCE_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06004C5C RID: 19548 RVA: 0x0016F968 File Offset: 0x0016DB68
		// (set) Token: 0x06004C5D RID: 19549 RVA: 0x00024B81 File Offset: 0x00022D81
		public unsafe static float LOW_SEVERITY_DRUG_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x06004C5E RID: 19550 RVA: 0x0016F984 File Offset: 0x0016DB84
		// (set) Token: 0x06004C5F RID: 19551 RVA: 0x00024B8F File Offset: 0x00022D8F
		public unsafe static float MED_SEVERITY_DRUG_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x06004C60 RID: 19552 RVA: 0x0016F9A0 File Offset: 0x0016DBA0
		// (set) Token: 0x06004C61 RID: 19553 RVA: 0x00024B9D File Offset: 0x00022D9D
		public unsafe static float HIGH_SEVERITY_DRUG_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x06004C62 RID: 19554 RVA: 0x0016F9BC File Offset: 0x0016DBBC
		// (set) Token: 0x06004C63 RID: 19555 RVA: 0x00024BAB File Offset: 0x00022DAB
		public unsafe static float FAILURE_TO_COMPLY_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x06004C64 RID: 19556 RVA: 0x0016F9D8 File Offset: 0x0016DBD8
		// (set) Token: 0x06004C65 RID: 19557 RVA: 0x00024BB9 File Offset: 0x00022DB9
		public unsafe static float EVADING_ARREST_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_EVADING_ARREST_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_EVADING_ARREST_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06004C66 RID: 19558 RVA: 0x0016F9F4 File Offset: 0x0016DBF4
		// (set) Token: 0x06004C67 RID: 19559 RVA: 0x00024BC7 File Offset: 0x00022DC7
		public unsafe static float VIOLATING_CURFEW_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_VIOLATING_CURFEW_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_VIOLATING_CURFEW_TIME, (void*)(&value));
			}
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06004C68 RID: 19560 RVA: 0x0016FA10 File Offset: 0x0016DC10
		// (set) Token: 0x06004C69 RID: 19561 RVA: 0x00024BD5 File Offset: 0x00022DD5
		public unsafe static float ATTEMPT_TO_SELL_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06004C6A RID: 19562 RVA: 0x0016FA2C File Offset: 0x0016DC2C
		// (set) Token: 0x06004C6B RID: 19563 RVA: 0x00024BE3 File Offset: 0x00022DE3
		public unsafe static float ASSAULT_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_ASSAULT_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_ASSAULT_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06004C6C RID: 19564 RVA: 0x0016FA48 File Offset: 0x0016DC48
		// (set) Token: 0x06004C6D RID: 19565 RVA: 0x00024BF1 File Offset: 0x00022DF1
		public unsafe static float DEADLY_ASSAULT_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_DEADLY_ASSAULT_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_DEADLY_ASSAULT_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06004C6E RID: 19566 RVA: 0x0016FA64 File Offset: 0x0016DC64
		// (set) Token: 0x06004C6F RID: 19567 RVA: 0x00024BFF File Offset: 0x00022DFF
		public unsafe static float VANDALISM_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_VANDALISM_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_VANDALISM_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06004C70 RID: 19568 RVA: 0x0016FA80 File Offset: 0x0016DC80
		// (set) Token: 0x06004C71 RID: 19569 RVA: 0x00024C0D File Offset: 0x00022E0D
		public unsafe static float THEFT_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_THEFT_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_THEFT_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06004C72 RID: 19570 RVA: 0x0016FA9C File Offset: 0x0016DC9C
		// (set) Token: 0x06004C73 RID: 19571 RVA: 0x00024C1B File Offset: 0x00022E1B
		public unsafe static float BRANDISHING_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_BRANDISHING_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_BRANDISHING_FINE, (void*)(&value));
			}
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06004C74 RID: 19572 RVA: 0x0016FAB8 File Offset: 0x0016DCB8
		// (set) Token: 0x06004C75 RID: 19573 RVA: 0x00024C29 File Offset: 0x00022E29
		public unsafe static float DISCHARGE_FIREARM_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE, (void*)(&value));
			}
		}

		// Token: 0x04003373 RID: 13171
		private static readonly IntPtr NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE;

		// Token: 0x04003374 RID: 13172
		private static readonly IntPtr NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE;

		// Token: 0x04003375 RID: 13173
		private static readonly IntPtr NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE;

		// Token: 0x04003376 RID: 13174
		private static readonly IntPtr NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE;

		// Token: 0x04003377 RID: 13175
		private static readonly IntPtr NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE;

		// Token: 0x04003378 RID: 13176
		private static readonly IntPtr NativeFieldInfoPtr_EVADING_ARREST_FINE;

		// Token: 0x04003379 RID: 13177
		private static readonly IntPtr NativeFieldInfoPtr_VIOLATING_CURFEW_TIME;

		// Token: 0x0400337A RID: 13178
		private static readonly IntPtr NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE;

		// Token: 0x0400337B RID: 13179
		private static readonly IntPtr NativeFieldInfoPtr_ASSAULT_FINE;

		// Token: 0x0400337C RID: 13180
		private static readonly IntPtr NativeFieldInfoPtr_DEADLY_ASSAULT_FINE;

		// Token: 0x0400337D RID: 13181
		private static readonly IntPtr NativeFieldInfoPtr_VANDALISM_FINE;

		// Token: 0x0400337E RID: 13182
		private static readonly IntPtr NativeFieldInfoPtr_THEFT_FINE;

		// Token: 0x0400337F RID: 13183
		private static readonly IntPtr NativeFieldInfoPtr_BRANDISHING_FINE;

		// Token: 0x04003380 RID: 13184
		private static readonly IntPtr NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE;

		// Token: 0x04003381 RID: 13185
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCrimeList_Public_Static_List_1_String_Dictionary_2_Crime_Int32_0;
	}
}
