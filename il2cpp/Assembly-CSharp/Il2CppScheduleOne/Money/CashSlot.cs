using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Money
{
	// Token: 0x02000726 RID: 1830
	public class CashSlot : HotbarSlot
	{
		// Token: 0x0600A516 RID: 42262 RVA: 0x002955CC File Offset: 0x002937CC
		// Note: this type is marked as 'beforefieldinit'.
		static CashSlot()
		{
			Il2CppClassPointerStore<CashSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Money", "CashSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashSlot>.NativeClassPtr);
			CashSlot.NativeFieldInfoPtr_MAX_CASH_PER_SLOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, "MAX_CASH_PER_SLOT");
			CashSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, 100683468);
			CashSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, 100683469);
			CashSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, 100683470);
		}

		// Token: 0x0600A517 RID: 42263 RVA: 0x0029564C File Offset: 0x0029384C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288667, XrefRangeEnd = 288671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A518 RID: 42264 RVA: 0x00295698 File Offset: 0x00293898
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanSlotAcceptCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A519 RID: 42265 RVA: 0x002956E0 File Offset: 0x002938E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247388, RefRangeEnd = 247390, XrefRangeStart = 247388, XrefRangeEnd = 247390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A51A RID: 42266 RVA: 0x000515EA File Offset: 0x0004F7EA
		public CashSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0600A51B RID: 42267 RVA: 0x0029571C File Offset: 0x0029391C
		// (set) Token: 0x0600A51C RID: 42268 RVA: 0x000515F3 File Offset: 0x0004F7F3
		public unsafe static float MAX_CASH_PER_SLOT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashSlot.NativeFieldInfoPtr_MAX_CASH_PER_SLOT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashSlot.NativeFieldInfoPtr_MAX_CASH_PER_SLOT, (void*)(&value));
			}
		}

		// Token: 0x04006EAD RID: 28333
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CASH_PER_SLOT;

		// Token: 0x04006EAE RID: 28334
		private static readonly IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006EAF RID: 28335
		private static readonly IntPtr NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0;

		// Token: 0x04006EB0 RID: 28336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
