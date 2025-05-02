using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005FA RID: 1530
	public class Hair : Accessory
	{
		// Token: 0x060086EC RID: 34540 RVA: 0x0023A778 File Offset: 0x00238978
		// Note: this type is marked as 'beforefieldinit'.
		static Hair()
		{
			Il2CppClassPointerStore<Hair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Hair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hair>.NativeClassPtr);
			Hair.NativeFieldInfoPtr__BlockedByHat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hair>.NativeClassPtr, "<BlockedByHat>k__BackingField");
			Hair.NativeFieldInfoPtr_hairToHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hair>.NativeClassPtr, "hairToHide");
			Hair.NativeMethodInfoPtr_get_BlockedByHat_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680139);
			Hair.NativeMethodInfoPtr_set_BlockedByHat_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680140);
			Hair.NativeMethodInfoPtr_SetBlockedByHat_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680141);
			Hair.NativeMethodInfoPtr_BlockHair_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680142);
			Hair.NativeMethodInfoPtr_UnBlockHair_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680143);
			Hair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680144);
		}

		// Token: 0x17002903 RID: 10499
		// (get) Token: 0x060086ED RID: 34541 RVA: 0x0023A848 File Offset: 0x00238A48
		// (set) Token: 0x060086EE RID: 34542 RVA: 0x0023A884 File Offset: 0x00238A84
		public unsafe bool BlockedByHat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr_get_BlockedByHat_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr_set_BlockedByHat_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060086EF RID: 34543 RVA: 0x0023A8C4 File Offset: 0x00238AC4
		[CallerCount(0)]
		public unsafe void SetBlockedByHat(bool blocked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blocked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr_SetBlockedByHat_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086F0 RID: 34544 RVA: 0x0023A904 File Offset: 0x00238B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251390, XrefRangeEnd = 251392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BlockHair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hair.NativeMethodInfoPtr_BlockHair_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086F1 RID: 34545 RVA: 0x0023A940 File Offset: 0x00238B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251392, XrefRangeEnd = 251394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnBlockHair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hair.NativeMethodInfoPtr_UnBlockHair_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086F2 RID: 34546 RVA: 0x0023A97C File Offset: 0x00238B7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249312, RefRangeEnd = 249313, XrefRangeStart = 249312, XrefRangeEnd = 249313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086F3 RID: 34547 RVA: 0x000402EF File Offset: 0x0003E4EF
		public Hair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002901 RID: 10497
		// (get) Token: 0x060086F4 RID: 34548 RVA: 0x0023A9B8 File Offset: 0x00238BB8
		// (set) Token: 0x060086F5 RID: 34549 RVA: 0x000402F8 File Offset: 0x0003E4F8
		public unsafe bool _BlockedByHat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr__BlockedByHat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr__BlockedByHat_k__BackingField)) = value;
			}
		}

		// Token: 0x17002902 RID: 10498
		// (get) Token: 0x060086F6 RID: 34550 RVA: 0x0023A9E0 File Offset: 0x00238BE0
		// (set) Token: 0x060086F7 RID: 34551 RVA: 0x00040313 File Offset: 0x0003E513
		public unsafe Il2CppReferenceArray<GameObject> hairToHide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr_hairToHide);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr_hairToHide), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BD1 RID: 23505
		private static readonly IntPtr NativeFieldInfoPtr__BlockedByHat_k__BackingField;

		// Token: 0x04005BD2 RID: 23506
		private static readonly IntPtr NativeFieldInfoPtr_hairToHide;

		// Token: 0x04005BD3 RID: 23507
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockedByHat_Public_get_Boolean_0;

		// Token: 0x04005BD4 RID: 23508
		private static readonly IntPtr NativeMethodInfoPtr_set_BlockedByHat_Protected_set_Void_Boolean_0;

		// Token: 0x04005BD5 RID: 23509
		private static readonly IntPtr NativeMethodInfoPtr_SetBlockedByHat_Public_Void_Boolean_0;

		// Token: 0x04005BD6 RID: 23510
		private static readonly IntPtr NativeMethodInfoPtr_BlockHair_Protected_Virtual_New_Void_0;

		// Token: 0x04005BD7 RID: 23511
		private static readonly IntPtr NativeMethodInfoPtr_UnBlockHair_Protected_Virtual_New_Void_0;

		// Token: 0x04005BD8 RID: 23512
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
