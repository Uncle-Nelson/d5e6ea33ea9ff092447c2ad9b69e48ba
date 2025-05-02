using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C3 RID: 1475
	public class Equippable_Pourable : Equippable_Viewmodel
	{
		// Token: 0x06008162 RID: 33122 RVA: 0x002282C4 File Offset: 0x002264C4
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Pourable()
		{
			Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Pourable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr);
			Equippable_Pourable.NativeFieldInfoPtr__InteractionLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, "<InteractionLabel>k__BackingField");
			Equippable_Pourable.NativeFieldInfoPtr_InteractionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, "InteractionRange");
			Equippable_Pourable.NativeFieldInfoPtr_PourablePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, "PourablePrefab");
			Equippable_Pourable.NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679503);
			Equippable_Pourable.NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679504);
			Equippable_Pourable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679505);
			Equippable_Pourable.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_New_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679506);
			Equippable_Pourable.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_Pot_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679507);
			Equippable_Pourable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679508);
		}

		// Token: 0x17002720 RID: 10016
		// (get) Token: 0x06008163 RID: 33123 RVA: 0x002283A8 File Offset: 0x002265A8
		// (set) Token: 0x06008164 RID: 33124 RVA: 0x002283EC File Offset: 0x002265EC
		public unsafe virtual string InteractionLabel
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 22951, RefRangeEnd = 22968, XrefRangeStart = 22951, XrefRangeEnd = 22968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008165 RID: 33125 RVA: 0x0022843C File Offset: 0x0022663C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245370, XrefRangeEnd = 245420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008166 RID: 33126 RVA: 0x00228478 File Offset: 0x00226678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245420, XrefRangeEnd = 245424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartPourTask(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_New_Void_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008167 RID: 33127 RVA: 0x002284C8 File Offset: 0x002266C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245424, XrefRangeEnd = 245427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPour(Pot pot, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_Pot_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008168 RID: 33128 RVA: 0x0022853C File Offset: 0x0022673C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 245434, RefRangeEnd = 245437, XrefRangeStart = 245427, XrefRangeEnd = 245434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Pourable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Pourable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008169 RID: 33129 RVA: 0x0003D734 File Offset: 0x0003B934
		public Equippable_Pourable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700271D RID: 10013
		// (get) Token: 0x0600816A RID: 33130 RVA: 0x00228578 File Offset: 0x00226778
		// (set) Token: 0x0600816B RID: 33131 RVA: 0x0003D73D File Offset: 0x0003B93D
		public unsafe string _InteractionLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr__InteractionLabel_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr__InteractionLabel_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700271E RID: 10014
		// (get) Token: 0x0600816C RID: 33132 RVA: 0x002285A0 File Offset: 0x002267A0
		// (set) Token: 0x0600816D RID: 33133 RVA: 0x0003D75C File Offset: 0x0003B95C
		public unsafe float InteractionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr_InteractionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr_InteractionRange)) = value;
			}
		}

		// Token: 0x1700271F RID: 10015
		// (get) Token: 0x0600816E RID: 33134 RVA: 0x002285C8 File Offset: 0x002267C8
		// (set) Token: 0x0600816F RID: 33135 RVA: 0x0003D777 File Offset: 0x0003B977
		public unsafe Pourable PourablePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr_PourablePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pourable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr_PourablePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005810 RID: 22544
		private static readonly IntPtr NativeFieldInfoPtr__InteractionLabel_k__BackingField;

		// Token: 0x04005811 RID: 22545
		private static readonly IntPtr NativeFieldInfoPtr_InteractionRange;

		// Token: 0x04005812 RID: 22546
		private static readonly IntPtr NativeFieldInfoPtr_PourablePrefab;

		// Token: 0x04005813 RID: 22547
		private static readonly IntPtr NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_New_get_String_0;

		// Token: 0x04005814 RID: 22548
		private static readonly IntPtr NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04005815 RID: 22549
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005816 RID: 22550
		private static readonly IntPtr NativeMethodInfoPtr_StartPourTask_Protected_Virtual_New_Void_Pot_0;

		// Token: 0x04005817 RID: 22551
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_Pot_byref_String_0;

		// Token: 0x04005818 RID: 22552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
