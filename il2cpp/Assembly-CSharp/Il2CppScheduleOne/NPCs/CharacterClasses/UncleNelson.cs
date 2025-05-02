using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000339 RID: 825
	public class UncleNelson : NPC
	{
		// Token: 0x06003CD5 RID: 15573 RVA: 0x001364D4 File Offset: 0x001346D4
		// Note: this type is marked as 'beforefieldinit'.
		static UncleNelson()
		{
			Il2CppClassPointerStore<UncleNelson>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "UncleNelson");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr);
			UncleNelson.NativeFieldInfoPtr_InitialMessage_Demo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, "InitialMessage_Demo");
			UncleNelson.NativeFieldInfoPtr_InitialMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, "InitialMessage");
			UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.UncleNelsonAssembly-CSharp.dll_Excuted");
			UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.UncleNelsonAssembly-CSharp.dll_Excuted");
			UncleNelson.NativeMethodInfoPtr_SendInitialMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670387);
			UncleNelson.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670388);
			UncleNelson.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670389);
			UncleNelson.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670390);
			UncleNelson.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670391);
			UncleNelson.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670392);
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x001365CC File Offset: 0x001347CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143171, XrefRangeEnd = 143192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendInitialMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UncleNelson.NativeMethodInfoPtr_SendInitialMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x00136600 File Offset: 0x00134800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143192, XrefRangeEnd = 143201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UncleNelson() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UncleNelson.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x0013663C File Offset: 0x0013483C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UncleNelson.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x00136678 File Offset: 0x00134878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UncleNelson.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x001366B4 File Offset: 0x001348B4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UncleNelson.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x001366F0 File Offset: 0x001348F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142072, RefRangeEnd = 142075, XrefRangeStart = 142072, XrefRangeEnd = 142075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UncleNelson.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x0001ED1B File Offset: 0x0001CF1B
		public UncleNelson(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06003CDD RID: 15581 RVA: 0x0013672C File Offset: 0x0013492C
		// (set) Token: 0x06003CDE RID: 15582 RVA: 0x0001ED24 File Offset: 0x0001CF24
		public unsafe string InitialMessage_Demo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_InitialMessage_Demo);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_InitialMessage_Demo), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06003CDF RID: 15583 RVA: 0x00136754 File Offset: 0x00134954
		// (set) Token: 0x06003CE0 RID: 15584 RVA: 0x0001ED43 File Offset: 0x0001CF43
		public unsafe string InitialMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_InitialMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_InitialMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06003CE1 RID: 15585 RVA: 0x0013677C File Offset: 0x0013497C
		// (set) Token: 0x06003CE2 RID: 15586 RVA: 0x0001ED62 File Offset: 0x0001CF62
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06003CE3 RID: 15587 RVA: 0x001367A4 File Offset: 0x001349A4
		// (set) Token: 0x06003CE4 RID: 15588 RVA: 0x0001ED7D File Offset: 0x0001CF7D
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400281F RID: 10271
		private static readonly IntPtr NativeFieldInfoPtr_InitialMessage_Demo;

		// Token: 0x04002820 RID: 10272
		private static readonly IntPtr NativeFieldInfoPtr_InitialMessage;

		// Token: 0x04002821 RID: 10273
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002822 RID: 10274
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002823 RID: 10275
		private static readonly IntPtr NativeMethodInfoPtr_SendInitialMessage_Public_Void_0;

		// Token: 0x04002824 RID: 10276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002825 RID: 10277
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002826 RID: 10278
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002827 RID: 10279
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002828 RID: 10280
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
