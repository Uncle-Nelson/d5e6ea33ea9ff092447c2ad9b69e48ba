using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Map;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000316 RID: 790
	public class Jeremy : NPC
	{
		// Token: 0x06003ADB RID: 15067 RVA: 0x0012FDB0 File Offset: 0x0012DFB0
		// Note: this type is marked as 'beforefieldinit'.
		static Jeremy()
		{
			Il2CppClassPointerStore<Jeremy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Jeremy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jeremy>.NativeClassPtr);
			Jeremy.NativeFieldInfoPtr_Dealership = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "Dealership");
			Jeremy.NativeFieldInfoPtr_Listings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "Listings");
			Jeremy.NativeFieldInfoPtr_GreetingDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "GreetingDialogue");
			Jeremy.NativeFieldInfoPtr_GreetedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "GreetedVariable");
			Jeremy.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JeremyAssembly-CSharp.dll_Excuted");
			Jeremy.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JeremyAssembly-CSharp.dll_Excuted");
			Jeremy.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670147);
			Jeremy.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670148);
			Jeremy.NativeMethodInfoPtr_EnableGreeting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670149);
			Jeremy.NativeMethodInfoPtr_SetGreeted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670150);
			Jeremy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670151);
			Jeremy.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670152);
			Jeremy.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670153);
			Jeremy.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670154);
			Jeremy.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670155);
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x0012FF0C File Offset: 0x0012E10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142362, XrefRangeEnd = 142375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x0012FF48 File Offset: 0x0012E148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142375, XrefRangeEnd = 142404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x0012FF7C File Offset: 0x0012E17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142404, XrefRangeEnd = 142416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableGreeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr_EnableGreeting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x0012FFB0 File Offset: 0x0012E1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142416, XrefRangeEnd = 142436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGreeted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr_SetGreeted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x0012FFE4 File Offset: 0x0012E1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142436, XrefRangeEnd = 142448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Jeremy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jeremy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AE1 RID: 15073 RVA: 0x00130020 File Offset: 0x0012E220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142448, XrefRangeEnd = 142449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AE2 RID: 15074 RVA: 0x0013005C File Offset: 0x0012E25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142449, XrefRangeEnd = 142450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x00130098 File Offset: 0x0012E298
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AE4 RID: 15076 RVA: 0x001300D4 File Offset: 0x0012E2D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142072, RefRangeEnd = 142075, XrefRangeStart = 142072, XrefRangeEnd = 142075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x0001E096 File Offset: 0x0001C296
		public Jeremy(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06003AE6 RID: 15078 RVA: 0x00130110 File Offset: 0x0012E310
		// (set) Token: 0x06003AE7 RID: 15079 RVA: 0x0001E09F File Offset: 0x0001C29F
		public unsafe Dealership Dealership
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Dealership);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealership>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Dealership), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06003AE8 RID: 15080 RVA: 0x00130140 File Offset: 0x0012E340
		// (set) Token: 0x06003AE9 RID: 15081 RVA: 0x0001E0BE File Offset: 0x0001C2BE
		public unsafe List<Jeremy.DealershipListing> Listings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Listings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Jeremy.DealershipListing>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Listings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06003AEA RID: 15082 RVA: 0x00130170 File Offset: 0x0012E370
		// (set) Token: 0x06003AEB RID: 15083 RVA: 0x0001E0DD File Offset: 0x0001C2DD
		public unsafe DialogueContainer GreetingDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetingDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetingDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06003AEC RID: 15084 RVA: 0x001301A0 File Offset: 0x0012E3A0
		// (set) Token: 0x06003AED RID: 15085 RVA: 0x0001E0FC File Offset: 0x0001C2FC
		public unsafe string GreetedVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06003AEE RID: 15086 RVA: 0x001301C8 File Offset: 0x0012E3C8
		// (set) Token: 0x06003AEF RID: 15087 RVA: 0x0001E11B File Offset: 0x0001C31B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x001301F0 File Offset: 0x0012E3F0
		// (set) Token: 0x06003AF1 RID: 15089 RVA: 0x0001E136 File Offset: 0x0001C336
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040026D3 RID: 9939
		private static readonly IntPtr NativeFieldInfoPtr_Dealership;

		// Token: 0x040026D4 RID: 9940
		private static readonly IntPtr NativeFieldInfoPtr_Listings;

		// Token: 0x040026D5 RID: 9941
		private static readonly IntPtr NativeFieldInfoPtr_GreetingDialogue;

		// Token: 0x040026D6 RID: 9942
		private static readonly IntPtr NativeFieldInfoPtr_GreetedVariable;

		// Token: 0x040026D7 RID: 9943
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040026D8 RID: 9944
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040026D9 RID: 9945
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040026DA RID: 9946
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x040026DB RID: 9947
		private static readonly IntPtr NativeMethodInfoPtr_EnableGreeting_Private_Void_0;

		// Token: 0x040026DC RID: 9948
		private static readonly IntPtr NativeMethodInfoPtr_SetGreeted_Private_Void_0;

		// Token: 0x040026DD RID: 9949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040026DE RID: 9950
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040026DF RID: 9951
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040026E0 RID: 9952
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040026E1 RID: 9953
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0200093C RID: 2364
		[Serializable]
		public class DealershipListing : Object
		{
			// Token: 0x0600C754 RID: 51028 RVA: 0x00305D38 File Offset: 0x00303F38
			// Note: this type is marked as 'beforefieldinit'.
			static DealershipListing()
			{
				Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "DealershipListing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr);
				Jeremy.DealershipListing.NativeFieldInfoPtr_vehicleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, "vehicleCode");
				Jeremy.DealershipListing.NativeMethodInfoPtr_get_vehicleName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, 100670156);
				Jeremy.DealershipListing.NativeMethodInfoPtr_get_price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, 100670157);
				Jeremy.DealershipListing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, 100670158);
			}

			// Token: 0x17003E1C RID: 15900
			// (get) Token: 0x0600C755 RID: 51029 RVA: 0x00305DB4 File Offset: 0x00303FB4
			public unsafe string vehicleName
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 142349, RefRangeEnd = 142350, XrefRangeStart = 142344, XrefRangeEnd = 142349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.DealershipListing.NativeMethodInfoPtr_get_vehicleName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003E1D RID: 15901
			// (get) Token: 0x0600C756 RID: 51030 RVA: 0x00305DEC File Offset: 0x00303FEC
			public unsafe float price
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 142355, RefRangeEnd = 142358, XrefRangeStart = 142350, XrefRangeEnd = 142355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.DealershipListing.NativeMethodInfoPtr_get_price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600C757 RID: 51031 RVA: 0x00305E28 File Offset: 0x00304028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142358, XrefRangeEnd = 142362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DealershipListing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.DealershipListing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C758 RID: 51032 RVA: 0x0006101F File Offset: 0x0005F21F
			public DealershipListing(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E1B RID: 15899
			// (get) Token: 0x0600C759 RID: 51033 RVA: 0x00305E64 File Offset: 0x00304064
			// (set) Token: 0x0600C75A RID: 51034 RVA: 0x00061028 File Offset: 0x0005F228
			public unsafe string vehicleCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.DealershipListing.NativeFieldInfoPtr_vehicleCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.DealershipListing.NativeFieldInfoPtr_vehicleCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040086EC RID: 34540
			private static readonly IntPtr NativeFieldInfoPtr_vehicleCode;

			// Token: 0x040086ED RID: 34541
			private static readonly IntPtr NativeMethodInfoPtr_get_vehicleName_Public_get_String_0;

			// Token: 0x040086EE RID: 34542
			private static readonly IntPtr NativeMethodInfoPtr_get_price_Public_get_Single_0;

			// Token: 0x040086EF RID: 34543
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
