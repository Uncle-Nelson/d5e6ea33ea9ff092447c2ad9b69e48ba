using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000433 RID: 1075
	public class DialogueController_Police : DialogueController
	{
		// Token: 0x06005E82 RID: 24194 RVA: 0x001B314C File Offset: 0x001B134C
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Police()
		{
			Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Police");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr);
			DialogueController_Police.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, "officer");
			DialogueController_Police.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, 100675336);
			DialogueController_Police.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, 100675337);
			DialogueController_Police.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, 100675338);
		}

		// Token: 0x06005E83 RID: 24195 RVA: 0x001B31CC File Offset: 0x001B13CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197333, XrefRangeEnd = 197341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Police.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E84 RID: 24196 RVA: 0x001B3208 File Offset: 0x001B1408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197341, XrefRangeEnd = 197342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanStartDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Police.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x001B3250 File Offset: 0x001B1450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197342, XrefRangeEnd = 197346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Police() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Police.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x0002C93E File Offset: 0x0002AB3E
		public DialogueController_Police(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x06005E87 RID: 24199 RVA: 0x001B328C File Offset: 0x001B148C
		// (set) Token: 0x06005E88 RID: 24200 RVA: 0x0002C947 File Offset: 0x0002AB47
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Police.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Police.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040A3 RID: 16547
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x040040A4 RID: 16548
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040040A5 RID: 16549
		private static readonly IntPtr NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_Boolean_0;

		// Token: 0x040040A6 RID: 16550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
