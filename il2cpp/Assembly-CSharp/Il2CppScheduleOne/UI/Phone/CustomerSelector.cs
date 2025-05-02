using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x0200069B RID: 1691
	public class CustomerSelector : MonoBehaviour
	{
		// Token: 0x06009682 RID: 38530 RVA: 0x00268B7C File Offset: 0x00266D7C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerSelector()
		{
			Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CustomerSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr);
			CustomerSelector.NativeFieldInfoPtr_ButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "ButtonPrefab");
			CustomerSelector.NativeFieldInfoPtr_EntriesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "EntriesContainer");
			CustomerSelector.NativeFieldInfoPtr_onCustomerSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "onCustomerSelected");
			CustomerSelector.NativeFieldInfoPtr_customerEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "customerEntries");
			CustomerSelector.NativeFieldInfoPtr_entryToCustomer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "entryToCustomer");
			CustomerSelector.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681899);
			CustomerSelector.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681900);
			CustomerSelector.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681901);
			CustomerSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681902);
			CustomerSelector.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681903);
			CustomerSelector.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681904);
			CustomerSelector.NativeMethodInfoPtr_CreateEntry_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681905);
			CustomerSelector.NativeMethodInfoPtr_CustomerSelected_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681906);
			CustomerSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681907);
		}

		// Token: 0x06009683 RID: 38531 RVA: 0x00268CC4 File Offset: 0x00266EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269994, XrefRangeEnd = 270029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009684 RID: 38532 RVA: 0x00268CF8 File Offset: 0x00266EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270029, XrefRangeEnd = 270039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009685 RID: 38533 RVA: 0x00268D2C File Offset: 0x00266F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270039, XrefRangeEnd = 270061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009686 RID: 38534 RVA: 0x00268D60 File Offset: 0x00266F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270061, XrefRangeEnd = 270074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009687 RID: 38535 RVA: 0x00268DA4 File Offset: 0x00266FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270097, RefRangeEnd = 270098, XrefRangeStart = 270074, XrefRangeEnd = 270097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009688 RID: 38536 RVA: 0x00268DD8 File Offset: 0x00266FD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194914, RefRangeEnd = 194915, XrefRangeStart = 194914, XrefRangeEnd = 194915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009689 RID: 38537 RVA: 0x00268E0C File Offset: 0x0026700C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270147, RefRangeEnd = 270148, XrefRangeStart = 270098, XrefRangeEnd = 270147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEntry(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_CreateEntry_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600968A RID: 38538 RVA: 0x00268E50 File Offset: 0x00267050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270148, XrefRangeEnd = 270158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerSelected(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_CustomerSelected_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600968B RID: 38539 RVA: 0x00268E94 File Offset: 0x00267094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270158, XrefRangeEnd = 270173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600968C RID: 38540 RVA: 0x000490CB File Offset: 0x000472CB
		public CustomerSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E20 RID: 11808
		// (get) Token: 0x0600968D RID: 38541 RVA: 0x00268ED0 File Offset: 0x002670D0
		// (set) Token: 0x0600968E RID: 38542 RVA: 0x000490D4 File Offset: 0x000472D4
		public unsafe GameObject ButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_ButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_ButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E21 RID: 11809
		// (get) Token: 0x0600968F RID: 38543 RVA: 0x00268F00 File Offset: 0x00267100
		// (set) Token: 0x06009690 RID: 38544 RVA: 0x000490F3 File Offset: 0x000472F3
		public unsafe RectTransform EntriesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_EntriesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_EntriesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E22 RID: 11810
		// (get) Token: 0x06009691 RID: 38545 RVA: 0x00268F30 File Offset: 0x00267130
		// (set) Token: 0x06009692 RID: 38546 RVA: 0x00049112 File Offset: 0x00047312
		public unsafe UnityEvent<Customer> onCustomerSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_onCustomerSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Customer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_onCustomerSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E23 RID: 11811
		// (get) Token: 0x06009693 RID: 38547 RVA: 0x00268F60 File Offset: 0x00267160
		// (set) Token: 0x06009694 RID: 38548 RVA: 0x00049131 File Offset: 0x00047331
		public unsafe List<RectTransform> customerEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_customerEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_customerEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x06009695 RID: 38549 RVA: 0x00268F90 File Offset: 0x00267190
		// (set) Token: 0x06009696 RID: 38550 RVA: 0x00049150 File Offset: 0x00047350
		public unsafe Dictionary<RectTransform, Customer> entryToCustomer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_entryToCustomer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RectTransform, Customer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_entryToCustomer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006575 RID: 25973
		private static readonly IntPtr NativeFieldInfoPtr_ButtonPrefab;

		// Token: 0x04006576 RID: 25974
		private static readonly IntPtr NativeFieldInfoPtr_EntriesContainer;

		// Token: 0x04006577 RID: 25975
		private static readonly IntPtr NativeFieldInfoPtr_onCustomerSelected;

		// Token: 0x04006578 RID: 25976
		private static readonly IntPtr NativeFieldInfoPtr_customerEntries;

		// Token: 0x04006579 RID: 25977
		private static readonly IntPtr NativeFieldInfoPtr_entryToCustomer;

		// Token: 0x0400657A RID: 25978
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x0400657B RID: 25979
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400657C RID: 25980
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400657D RID: 25981
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400657E RID: 25982
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400657F RID: 25983
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006580 RID: 25984
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntry_Private_Void_Customer_0;

		// Token: 0x04006581 RID: 25985
		private static readonly IntPtr NativeMethodInfoPtr_CustomerSelected_Private_Void_Customer_0;

		// Token: 0x04006582 RID: 25986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B60 RID: 2912
		[ObfuscatedName("ScheduleOne.UI.Phone.CustomerSelector+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA5B RID: 55899 RVA: 0x0033C3C8 File Offset: 0x0033A5C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr);
				CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr_customer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr, "customer");
				CustomerSelector.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr, 100681908);
				CustomerSelector.__c__DisplayClass11_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr, 100681909);
			}

			// Token: 0x0600DA5C RID: 55900 RVA: 0x0033C444 File Offset: 0x0033A644
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA5D RID: 55901 RVA: 0x0033C480 File Offset: 0x0033A680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269984, XrefRangeEnd = 269994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateEntry_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.__c__DisplayClass11_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA5E RID: 55902 RVA: 0x0006A52A File Offset: 0x0006872A
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043BC RID: 17340
			// (get) Token: 0x0600DA5F RID: 55903 RVA: 0x0033C4B4 File Offset: 0x0033A6B4
			// (set) Token: 0x0600DA60 RID: 55904 RVA: 0x0006A533 File Offset: 0x00068733
			public unsafe CustomerSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043BD RID: 17341
			// (get) Token: 0x0600DA61 RID: 55905 RVA: 0x0033C4E4 File Offset: 0x0033A6E4
			// (set) Token: 0x0600DA62 RID: 55906 RVA: 0x0006A552 File Offset: 0x00068752
			public unsafe Customer customer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr_customer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr_customer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009298 RID: 37528
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009299 RID: 37529
			private static readonly IntPtr NativeFieldInfoPtr_customer;

			// Token: 0x0400929A RID: 37530
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400929B RID: 37531
			private static readonly IntPtr NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0;
		}
	}
}
