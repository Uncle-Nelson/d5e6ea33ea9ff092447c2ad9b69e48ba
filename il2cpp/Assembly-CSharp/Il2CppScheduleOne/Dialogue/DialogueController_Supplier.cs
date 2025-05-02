using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000435 RID: 1077
	public class DialogueController_Supplier : DialogueController
	{
		// Token: 0x06005E98 RID: 24216 RVA: 0x001B36A4 File Offset: 0x001B18A4
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Supplier()
		{
			Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Supplier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr);
			DialogueController_Supplier.NativeFieldInfoPtr__Supplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, "<Supplier>k__BackingField");
			DialogueController_Supplier.NativeMethodInfoPtr_get_Supplier_Public_get_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, 100675351);
			DialogueController_Supplier.NativeMethodInfoPtr_set_Supplier_Private_set_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, 100675352);
			DialogueController_Supplier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, 100675353);
			DialogueController_Supplier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, 100675354);
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x06005E99 RID: 24217 RVA: 0x001B3738 File Offset: 0x001B1938
		// (set) Token: 0x06005E9A RID: 24218 RVA: 0x001B3778 File Offset: 0x001B1978
		public unsafe Supplier Supplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Supplier.NativeMethodInfoPtr_get_Supplier_Public_get_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Supplier.NativeMethodInfoPtr_set_Supplier_Private_set_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005E9B RID: 24219 RVA: 0x001B37BC File Offset: 0x001B19BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197498, XrefRangeEnd = 197504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Supplier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x001B37F8 File Offset: 0x001B19F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197504, XrefRangeEnd = 197508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Supplier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Supplier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E9D RID: 24221 RVA: 0x0002C9CC File Offset: 0x0002ABCC
		public DialogueController_Supplier(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x06005E9E RID: 24222 RVA: 0x001B3834 File Offset: 0x001B1A34
		// (set) Token: 0x06005E9F RID: 24223 RVA: 0x0002C9D5 File Offset: 0x0002ABD5
		public unsafe Supplier _Supplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Supplier.NativeFieldInfoPtr__Supplier_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Supplier.NativeFieldInfoPtr__Supplier_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040B1 RID: 16561
		private static readonly IntPtr NativeFieldInfoPtr__Supplier_k__BackingField;

		// Token: 0x040040B2 RID: 16562
		private static readonly IntPtr NativeMethodInfoPtr_get_Supplier_Public_get_Supplier_0;

		// Token: 0x040040B3 RID: 16563
		private static readonly IntPtr NativeMethodInfoPtr_set_Supplier_Private_set_Void_Supplier_0;

		// Token: 0x040040B4 RID: 16564
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040040B5 RID: 16565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
