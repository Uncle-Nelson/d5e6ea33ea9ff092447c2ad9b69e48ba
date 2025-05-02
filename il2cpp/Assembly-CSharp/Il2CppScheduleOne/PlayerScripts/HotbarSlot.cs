using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003DF RID: 991
	public class HotbarSlot : ItemSlot
	{
		// Token: 0x06004CA7 RID: 19623 RVA: 0x00170290 File Offset: 0x0016E490
		// Note: this type is marked as 'beforefieldinit'.
		static HotbarSlot()
		{
			Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "HotbarSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr);
			HotbarSlot.NativeFieldInfoPtr__IsEquipped_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "<IsEquipped>k__BackingField");
			HotbarSlot.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "Equippable");
			HotbarSlot.NativeFieldInfoPtr_onEquipChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "onEquipChanged");
			HotbarSlot.NativeMethodInfoPtr_get_IsEquipped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672750);
			HotbarSlot.NativeMethodInfoPtr_set_IsEquipped_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672751);
			HotbarSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_Void_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672752);
			HotbarSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672753);
			HotbarSlot.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672754);
			HotbarSlot.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672755);
			HotbarSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672756);
			HotbarSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672757);
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06004CA8 RID: 19624 RVA: 0x0017039C File Offset: 0x0016E59C
		// (set) Token: 0x06004CA9 RID: 19625 RVA: 0x001703D8 File Offset: 0x0016E5D8
		public unsafe bool IsEquipped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.NativeMethodInfoPtr_get_IsEquipped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.NativeMethodInfoPtr_set_IsEquipped_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x00170418 File Offset: 0x0016E618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165952, XrefRangeEnd = 165979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_Void_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x00170474 File Offset: 0x0016E674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165979, XrefRangeEnd = 165986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x001704C0 File Offset: 0x0016E6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165986, XrefRangeEnd = 166008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Equip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x001704FC File Offset: 0x0016E6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166008, XrefRangeEnd = 166013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x00170538 File Offset: 0x0016E738
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanSlotAcceptCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x00170580 File Offset: 0x0016E780
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 166014, RefRangeEnd = 166017, XrefRangeStart = 166013, XrefRangeEnd = 166014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HotbarSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CB0 RID: 19632 RVA: 0x00024E1A File Offset: 0x0002301A
		public HotbarSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06004CB1 RID: 19633 RVA: 0x001705BC File Offset: 0x0016E7BC
		// (set) Token: 0x06004CB2 RID: 19634 RVA: 0x00024E23 File Offset: 0x00023023
		public unsafe bool _IsEquipped_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr__IsEquipped_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr__IsEquipped_k__BackingField)) = value;
			}
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06004CB3 RID: 19635 RVA: 0x001705E4 File Offset: 0x0016E7E4
		// (set) Token: 0x06004CB4 RID: 19636 RVA: 0x00024E3E File Offset: 0x0002303E
		public unsafe Equippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06004CB5 RID: 19637 RVA: 0x00170614 File Offset: 0x0016E814
		// (set) Token: 0x06004CB6 RID: 19638 RVA: 0x00024E5D File Offset: 0x0002305D
		public unsafe HotbarSlot.EquipEvent onEquipChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr_onEquipChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotbarSlot.EquipEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr_onEquipChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400339D RID: 13213
		private static readonly IntPtr NativeFieldInfoPtr__IsEquipped_k__BackingField;

		// Token: 0x0400339E RID: 13214
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x0400339F RID: 13215
		private static readonly IntPtr NativeFieldInfoPtr_onEquipChanged;

		// Token: 0x040033A0 RID: 13216
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEquipped_Public_get_Boolean_0;

		// Token: 0x040033A1 RID: 13217
		private static readonly IntPtr NativeMethodInfoPtr_set_IsEquipped_Protected_set_Void_Boolean_0;

		// Token: 0x040033A2 RID: 13218
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredItem_Public_Virtual_Void_ItemInstance_Boolean_0;

		// Token: 0x040033A3 RID: 13219
		private static readonly IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0;

		// Token: 0x040033A4 RID: 13220
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_0;

		// Token: 0x040033A5 RID: 13221
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0;

		// Token: 0x040033A6 RID: 13222
		private static readonly IntPtr NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0;

		// Token: 0x040033A7 RID: 13223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200098B RID: 2443
		public sealed class EquipEvent : MulticastDelegate
		{
			// Token: 0x0600CA68 RID: 51816 RVA: 0x0030F2F0 File Offset: 0x0030D4F0
			// Note: this type is marked as 'beforefieldinit'.
			static EquipEvent()
			{
				Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "EquipEvent");
				HotbarSlot.EquipEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100672758);
				HotbarSlot.EquipEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100672759);
				HotbarSlot.EquipEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100672760);
				HotbarSlot.EquipEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100672761);
			}

			// Token: 0x0600CA69 RID: 51817 RVA: 0x0030F364 File Offset: 0x0030D564
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 165905, RefRangeEnd = 165948, XrefRangeStart = 165902, XrefRangeEnd = 165905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EquipEvent(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA6A RID: 51818 RVA: 0x0030F3C0 File Offset: 0x0030D5C0
			[CallerCount(0)]
			public unsafe void Invoke(bool equipped)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref equipped;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA6B RID: 51819 RVA: 0x0030F400 File Offset: 0x0030D600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165948, XrefRangeEnd = 165952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(bool equipped, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref equipped;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600CA6C RID: 51820 RVA: 0x0030F470 File Offset: 0x0030D670
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA6D RID: 51821 RVA: 0x00062684 File Offset: 0x00060884
			public EquipEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CA6E RID: 51822 RVA: 0x0006268D File Offset: 0x0006088D
			public static implicit operator HotbarSlot.EquipEvent(Action<bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<HotbarSlot.EquipEvent>(A_0);
			}

			// Token: 0x0600CA6F RID: 51823 RVA: 0x00062695 File Offset: 0x00060895
			public static HotbarSlot.EquipEvent operator +(HotbarSlot.EquipEvent A_0, HotbarSlot.EquipEvent A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<HotbarSlot.EquipEvent>();
			}

			// Token: 0x0600CA70 RID: 51824 RVA: 0x000626A3 File Offset: 0x000608A3
			public static HotbarSlot.EquipEvent operator -(HotbarSlot.EquipEvent A_0, HotbarSlot.EquipEvent A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<HotbarSlot.EquipEvent>();
				}
				return result;
			}

			// Token: 0x040088EC RID: 35052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040088ED RID: 35053
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;

			// Token: 0x040088EE RID: 35054
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

			// Token: 0x040088EF RID: 35055
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
