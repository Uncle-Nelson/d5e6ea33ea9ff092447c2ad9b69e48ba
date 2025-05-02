using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000306 RID: 774
	public class Fixer : NPC
	{
		// Token: 0x06003A14 RID: 14868 RVA: 0x0012D664 File Offset: 0x0012B864
		// Note: this type is marked as 'beforefieldinit'.
		static Fixer()
		{
			Il2CppClassPointerStore<Fixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Fixer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fixer>.NativeClassPtr);
			Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "ADDITIONAL_SIGNING_FEE_1");
			Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "ADDITIONAL_SIGNING_FEE_2");
			Fixer.NativeFieldInfoPtr_MAX_SIGNING_FEE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "MAX_SIGNING_FEE");
			Fixer.NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "ADDITIONAL_FEE_THRESHOLD");
			Fixer.NativeFieldInfoPtr_GreetingDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "GreetingDialogue");
			Fixer.NativeFieldInfoPtr_GreetedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "GreetedVariable");
			Fixer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted");
			Fixer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted");
			Fixer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670060);
			Fixer.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670061);
			Fixer.NativeMethodInfoPtr_EnableGreeting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670062);
			Fixer.NativeMethodInfoPtr_SetGreeted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670063);
			Fixer.NativeMethodInfoPtr_GetAdditionalSigningFee_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670064);
			Fixer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670065);
			Fixer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670066);
			Fixer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670067);
			Fixer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670068);
			Fixer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670069);
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x0012D7FC File Offset: 0x0012B9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142209, XrefRangeEnd = 142222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x0012D838 File Offset: 0x0012BA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142222, XrefRangeEnd = 142251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x0012D86C File Offset: 0x0012BA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142251, XrefRangeEnd = 142263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableGreeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_EnableGreeting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x0012D8A0 File Offset: 0x0012BAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142263, XrefRangeEnd = 142283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGreeted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_SetGreeted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x0012D8D4 File Offset: 0x0012BAD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142311, RefRangeEnd = 142314, XrefRangeStart = 142283, XrefRangeEnd = 142311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAdditionalSigningFee()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_GetAdditionalSigningFee_Public_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x0012D904 File Offset: 0x0012BB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142314, XrefRangeEnd = 142319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Fixer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fixer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A1B RID: 14875 RVA: 0x0012D940 File Offset: 0x0012BB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x0012D97C File Offset: 0x0012BB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x0012D9B8 File Offset: 0x0012BBB8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x0012D9F4 File Offset: 0x0012BBF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142072, RefRangeEnd = 142075, XrefRangeStart = 142072, XrefRangeEnd = 142075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x0001DBF2 File Offset: 0x0001BDF2
		public Fixer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x06003A20 RID: 14880 RVA: 0x0012DA30 File Offset: 0x0012BC30
		// (set) Token: 0x06003A21 RID: 14881 RVA: 0x0001DBFB File Offset: 0x0001BDFB
		public unsafe static int ADDITIONAL_SIGNING_FEE_1
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1, (void*)(&value));
			}
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x06003A22 RID: 14882 RVA: 0x0012DA4C File Offset: 0x0012BC4C
		// (set) Token: 0x06003A23 RID: 14883 RVA: 0x0001DC09 File Offset: 0x0001BE09
		public unsafe static int ADDITIONAL_SIGNING_FEE_2
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2, (void*)(&value));
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06003A24 RID: 14884 RVA: 0x0012DA68 File Offset: 0x0012BC68
		// (set) Token: 0x06003A25 RID: 14885 RVA: 0x0001DC17 File Offset: 0x0001BE17
		public unsafe static int MAX_SIGNING_FEE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_MAX_SIGNING_FEE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_MAX_SIGNING_FEE, (void*)(&value));
			}
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06003A26 RID: 14886 RVA: 0x0012DA84 File Offset: 0x0012BC84
		// (set) Token: 0x06003A27 RID: 14887 RVA: 0x0001DC25 File Offset: 0x0001BE25
		public unsafe static int ADDITIONAL_FEE_THRESHOLD
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06003A28 RID: 14888 RVA: 0x0012DAA0 File Offset: 0x0012BCA0
		// (set) Token: 0x06003A29 RID: 14889 RVA: 0x0001DC33 File Offset: 0x0001BE33
		public unsafe DialogueContainer GreetingDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetingDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetingDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06003A2A RID: 14890 RVA: 0x0012DAD0 File Offset: 0x0012BCD0
		// (set) Token: 0x06003A2B RID: 14891 RVA: 0x0001DC52 File Offset: 0x0001BE52
		public unsafe string GreetedVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06003A2C RID: 14892 RVA: 0x0012DAF8 File Offset: 0x0012BCF8
		// (set) Token: 0x06003A2D RID: 14893 RVA: 0x0001DC71 File Offset: 0x0001BE71
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06003A2E RID: 14894 RVA: 0x0012DB20 File Offset: 0x0012BD20
		// (set) Token: 0x06003A2F RID: 14895 RVA: 0x0001DC8C File Offset: 0x0001BE8C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002654 RID: 9812
		private static readonly IntPtr NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1;

		// Token: 0x04002655 RID: 9813
		private static readonly IntPtr NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2;

		// Token: 0x04002656 RID: 9814
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SIGNING_FEE;

		// Token: 0x04002657 RID: 9815
		private static readonly IntPtr NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD;

		// Token: 0x04002658 RID: 9816
		private static readonly IntPtr NativeFieldInfoPtr_GreetingDialogue;

		// Token: 0x04002659 RID: 9817
		private static readonly IntPtr NativeFieldInfoPtr_GreetedVariable;

		// Token: 0x0400265A RID: 9818
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400265B RID: 9819
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400265C RID: 9820
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400265D RID: 9821
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x0400265E RID: 9822
		private static readonly IntPtr NativeMethodInfoPtr_EnableGreeting_Private_Void_0;

		// Token: 0x0400265F RID: 9823
		private static readonly IntPtr NativeMethodInfoPtr_SetGreeted_Private_Void_0;

		// Token: 0x04002660 RID: 9824
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionalSigningFee_Public_Static_Single_0;

		// Token: 0x04002661 RID: 9825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002662 RID: 9826
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002663 RID: 9827
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002664 RID: 9828
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002665 RID: 9829
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
