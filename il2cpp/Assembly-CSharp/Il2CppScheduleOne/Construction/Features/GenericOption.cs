using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x02000484 RID: 1156
	public class GenericOption : MonoBehaviour
	{
		// Token: 0x0600644E RID: 25678 RVA: 0x001C603C File Offset: 0x001C423C
		// Note: this type is marked as 'beforefieldinit'.
		static GenericOption()
		{
			Il2CppClassPointerStore<GenericOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "GenericOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericOption>.NativeClassPtr);
			GenericOption.NativeFieldInfoPtr_optionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "optionName");
			GenericOption.NativeFieldInfoPtr_optionButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "optionButtonColor");
			GenericOption.NativeFieldInfoPtr_optionPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "optionPrice");
			GenericOption.NativeFieldInfoPtr_onInstalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "onInstalled");
			GenericOption.NativeFieldInfoPtr_onUninstalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "onUninstalled");
			GenericOption.NativeFieldInfoPtr_onSetVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "onSetVisible");
			GenericOption.NativeFieldInfoPtr_onSetInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "onSetInvisible");
			GenericOption.NativeMethodInfoPtr_Install_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676009);
			GenericOption.NativeMethodInfoPtr_Uninstall_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676010);
			GenericOption.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676011);
			GenericOption.NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676012);
			GenericOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676013);
		}

		// Token: 0x0600644F RID: 25679 RVA: 0x001C615C File Offset: 0x001C435C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204372, XrefRangeEnd = 204373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Install()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOption.NativeMethodInfoPtr_Install_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006450 RID: 25680 RVA: 0x001C6198 File Offset: 0x001C4398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204373, XrefRangeEnd = 204374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Uninstall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOption.NativeMethodInfoPtr_Uninstall_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006451 RID: 25681 RVA: 0x001C61D4 File Offset: 0x001C43D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204374, XrefRangeEnd = 204375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOption.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006452 RID: 25682 RVA: 0x001C6210 File Offset: 0x001C4410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204375, XrefRangeEnd = 204376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOption.NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006453 RID: 25683 RVA: 0x001C624C File Offset: 0x001C444C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericOption() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericOption>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006454 RID: 25684 RVA: 0x0002F709 File Offset: 0x0002D909
		public GenericOption(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x06006455 RID: 25685 RVA: 0x001C6288 File Offset: 0x001C4488
		// (set) Token: 0x06006456 RID: 25686 RVA: 0x0002F712 File Offset: 0x0002D912
		public unsafe string optionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x06006457 RID: 25687 RVA: 0x001C62B0 File Offset: 0x001C44B0
		// (set) Token: 0x06006458 RID: 25688 RVA: 0x0002F731 File Offset: 0x0002D931
		public unsafe Color optionButtonColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionButtonColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionButtonColor)) = value;
			}
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x06006459 RID: 25689 RVA: 0x001C62D8 File Offset: 0x001C44D8
		// (set) Token: 0x0600645A RID: 25690 RVA: 0x0002F74C File Offset: 0x0002D94C
		public unsafe float optionPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionPrice)) = value;
			}
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x0600645B RID: 25691 RVA: 0x001C6300 File Offset: 0x001C4500
		// (set) Token: 0x0600645C RID: 25692 RVA: 0x0002F767 File Offset: 0x0002D967
		public unsafe UnityEvent onInstalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onInstalled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onInstalled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x0600645D RID: 25693 RVA: 0x001C6330 File Offset: 0x001C4530
		// (set) Token: 0x0600645E RID: 25694 RVA: 0x0002F786 File Offset: 0x0002D986
		public unsafe UnityEvent onUninstalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onUninstalled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onUninstalled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x0600645F RID: 25695 RVA: 0x001C6360 File Offset: 0x001C4560
		// (set) Token: 0x06006460 RID: 25696 RVA: 0x0002F7A5 File Offset: 0x0002D9A5
		public unsafe UnityEvent onSetVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onSetVisible);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onSetVisible), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x06006461 RID: 25697 RVA: 0x001C6390 File Offset: 0x001C4590
		// (set) Token: 0x06006462 RID: 25698 RVA: 0x0002F7C4 File Offset: 0x0002D9C4
		public unsafe UnityEvent onSetInvisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onSetInvisible);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onSetInvisible), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004473 RID: 17523
		private static readonly IntPtr NativeFieldInfoPtr_optionName;

		// Token: 0x04004474 RID: 17524
		private static readonly IntPtr NativeFieldInfoPtr_optionButtonColor;

		// Token: 0x04004475 RID: 17525
		private static readonly IntPtr NativeFieldInfoPtr_optionPrice;

		// Token: 0x04004476 RID: 17526
		private static readonly IntPtr NativeFieldInfoPtr_onInstalled;

		// Token: 0x04004477 RID: 17527
		private static readonly IntPtr NativeFieldInfoPtr_onUninstalled;

		// Token: 0x04004478 RID: 17528
		private static readonly IntPtr NativeFieldInfoPtr_onSetVisible;

		// Token: 0x04004479 RID: 17529
		private static readonly IntPtr NativeFieldInfoPtr_onSetInvisible;

		// Token: 0x0400447A RID: 17530
		private static readonly IntPtr NativeMethodInfoPtr_Install_Public_Virtual_New_Void_0;

		// Token: 0x0400447B RID: 17531
		private static readonly IntPtr NativeMethodInfoPtr_Uninstall_Public_Virtual_New_Void_0;

		// Token: 0x0400447C RID: 17532
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_0;

		// Token: 0x0400447D RID: 17533
		private static readonly IntPtr NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0;

		// Token: 0x0400447E RID: 17534
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
