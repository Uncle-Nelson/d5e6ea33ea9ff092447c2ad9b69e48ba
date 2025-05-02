using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppScheduleOne.Property;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C4 RID: 452
	public class Quest_UnfavourableAgreements : Quest
	{
		// Token: 0x060026B9 RID: 9913 RVA: 0x000EA128 File Offset: 0x000E8328
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_UnfavourableAgreements()
		{
			Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_UnfavourableAgreements");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr);
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_WEEKLY_DELIVERY_HOURS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "WEEKLY_DELIVERY_HOURS");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_REMINDER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "REMINDER_THRESHOLD");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_Thomas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "Thomas");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_Gate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "Gate");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_Switch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "Switch");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_RV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "RV");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_QuestEntryTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "QuestEntryTitle");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_handoverSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "handoverSetup");
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667629);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667630);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667631);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_SetupHandover_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667632);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_CheckHandoverExpiry_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667633);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_UpdateName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667634);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_HandoverCompleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667635);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_ResetTimer_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667636);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667637);
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x000EA2AC File Offset: 0x000E84AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117425, XrefRangeEnd = 117462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_UnfavourableAgreements.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x000EA2E8 File Offset: 0x000E84E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117462, XrefRangeEnd = 117464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_UnfavourableAgreements.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x000EA334 File Offset: 0x000E8534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117464, XrefRangeEnd = 117506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x000EA368 File Offset: 0x000E8568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117506, XrefRangeEnd = 117516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupHandover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_SetupHandover_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000EA39C File Offset: 0x000E859C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117516, XrefRangeEnd = 117539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckHandoverExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_CheckHandoverExpiry_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x000EA3D0 File Offset: 0x000E85D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117575, RefRangeEnd = 117578, XrefRangeStart = 117539, XrefRangeEnd = 117575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_UpdateName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x000EA404 File Offset: 0x000E8604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117578, XrefRangeEnd = 117579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandoverCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_HandoverCompleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x000EA438 File Offset: 0x000E8638
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117608, RefRangeEnd = 117611, XrefRangeStart = 117579, XrefRangeEnd = 117608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTimer(bool allowBuildup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref allowBuildup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_ResetTimer_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x000EA478 File Offset: 0x000E8678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117611, XrefRangeEnd = 117615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_UnfavourableAgreements() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x00015746 File Offset: 0x00013946
		public Quest_UnfavourableAgreements(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x000EA4B4 File Offset: 0x000E86B4
		// (set) Token: 0x060026C5 RID: 9925 RVA: 0x0001574F File Offset: 0x0001394F
		public unsafe static float WEEKLY_DELIVERY_HOURS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_UnfavourableAgreements.NativeFieldInfoPtr_WEEKLY_DELIVERY_HOURS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_UnfavourableAgreements.NativeFieldInfoPtr_WEEKLY_DELIVERY_HOURS, (void*)(&value));
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x000EA4D0 File Offset: 0x000E86D0
		// (set) Token: 0x060026C7 RID: 9927 RVA: 0x0001575D File Offset: 0x0001395D
		public unsafe static float REMINDER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_UnfavourableAgreements.NativeFieldInfoPtr_REMINDER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_UnfavourableAgreements.NativeFieldInfoPtr_REMINDER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x060026C8 RID: 9928 RVA: 0x000EA4EC File Offset: 0x000E86EC
		// (set) Token: 0x060026C9 RID: 9929 RVA: 0x0001576B File Offset: 0x0001396B
		public unsafe Thomas Thomas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Thomas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thomas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Thomas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x000EA51C File Offset: 0x000E871C
		// (set) Token: 0x060026CB RID: 9931 RVA: 0x0001578A File Offset: 0x0001398A
		public unsafe ManorGate Gate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Gate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManorGate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Gate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x000EA54C File Offset: 0x000E874C
		// (set) Token: 0x060026CD RID: 9933 RVA: 0x000157A9 File Offset: 0x000139A9
		public unsafe ModularSwitch Switch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Switch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModularSwitch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Switch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x060026CE RID: 9934 RVA: 0x000EA57C File Offset: 0x000E877C
		// (set) Token: 0x060026CF RID: 9935 RVA: 0x000157C8 File Offset: 0x000139C8
		public unsafe RV RV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_RV);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RV>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_RV), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x000EA5AC File Offset: 0x000E87AC
		// (set) Token: 0x060026D1 RID: 9937 RVA: 0x000157E7 File Offset: 0x000139E7
		public unsafe string QuestEntryTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_QuestEntryTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_QuestEntryTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060026D2 RID: 9938 RVA: 0x000EA5D4 File Offset: 0x000E87D4
		// (set) Token: 0x060026D3 RID: 9939 RVA: 0x00015806 File Offset: 0x00013A06
		public unsafe bool handoverSetup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_handoverSetup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_handoverSetup)) = value;
			}
		}

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeFieldInfoPtr_WEEKLY_DELIVERY_HOURS;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeFieldInfoPtr_REMINDER_THRESHOLD;

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeFieldInfoPtr_Thomas;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeFieldInfoPtr_Gate;

		// Token: 0x040019C7 RID: 6599
		private static readonly IntPtr NativeFieldInfoPtr_Switch;

		// Token: 0x040019C8 RID: 6600
		private static readonly IntPtr NativeFieldInfoPtr_RV;

		// Token: 0x040019C9 RID: 6601
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryTitle;

		// Token: 0x040019CA RID: 6602
		private static readonly IntPtr NativeFieldInfoPtr_handoverSetup;

		// Token: 0x040019CB RID: 6603
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040019CC RID: 6604
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0;

		// Token: 0x040019CD RID: 6605
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x040019CE RID: 6606
		private static readonly IntPtr NativeMethodInfoPtr_SetupHandover_Private_Void_0;

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeMethodInfoPtr_CheckHandoverExpiry_Private_Void_0;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeMethodInfoPtr_UpdateName_Private_Void_0;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeMethodInfoPtr_HandoverCompleted_Private_Void_0;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeMethodInfoPtr_ResetTimer_Public_Void_Boolean_0;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
