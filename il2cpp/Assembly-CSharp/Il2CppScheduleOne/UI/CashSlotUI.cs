using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000643 RID: 1603
	public class CashSlotUI : ItemSlotUI
	{
		// Token: 0x06008E09 RID: 36361 RVA: 0x0024F664 File Offset: 0x0024D864
		// Note: this type is marked as 'beforefieldinit'.
		static CashSlotUI()
		{
			Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CashSlotUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr);
			CashSlotUI.NativeFieldInfoPtr_cashInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr, "cashInstance");
			CashSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr, 100680935);
		}

		// Token: 0x06008E0A RID: 36362 RVA: 0x0024F6BC File Offset: 0x0024D8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258722, XrefRangeEnd = 258723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashSlotUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E0B RID: 36363 RVA: 0x0004446C File Offset: 0x0004266C
		public CashSlotUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x06008E0C RID: 36364 RVA: 0x0024F6F8 File Offset: 0x0024D8F8
		// (set) Token: 0x06008E0D RID: 36365 RVA: 0x00044475 File Offset: 0x00042675
		public unsafe CashInstance cashInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashSlotUI.NativeFieldInfoPtr_cashInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashSlotUI.NativeFieldInfoPtr_cashInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400602E RID: 24622
		private static readonly IntPtr NativeFieldInfoPtr_cashInstance;

		// Token: 0x0400602F RID: 24623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
