using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005B8 RID: 1464
	public class LiquidMeth_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06008096 RID: 32918 RVA: 0x00225D90 File Offset: 0x00223F90
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMeth_Equippable()
		{
			Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "LiquidMeth_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr);
			LiquidMeth_Equippable.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr, "Visuals");
			LiquidMeth_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr, 100679433);
			LiquidMeth_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr, 100679434);
		}

		// Token: 0x06008097 RID: 32919 RVA: 0x00225DFC File Offset: 0x00223FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244690, XrefRangeEnd = 244701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidMeth_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x00225E4C File Offset: 0x0022404C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 244704, RefRangeEnd = 244712, XrefRangeStart = 244701, XrefRangeEnd = 244704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMeth_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMeth_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008099 RID: 32921 RVA: 0x0003D033 File Offset: 0x0003B233
		public LiquidMeth_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026D9 RID: 9945
		// (get) Token: 0x0600809A RID: 32922 RVA: 0x00225E88 File Offset: 0x00224088
		// (set) Token: 0x0600809B RID: 32923 RVA: 0x0003D03C File Offset: 0x0003B23C
		public unsafe LiquidMethVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_Equippable.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidMethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_Equippable.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005796 RID: 22422
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04005797 RID: 22423
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005798 RID: 22424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
