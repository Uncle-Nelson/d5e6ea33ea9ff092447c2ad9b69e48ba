using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x0200069F RID: 1695
	public class PhoneShopInterface : MonoBehaviour
	{
		// Token: 0x0600972E RID: 38702 RVA: 0x0026AAF4 File Offset: 0x00268CF4
		// Note: this type is marked as 'beforefieldinit'.
		static PhoneShopInterface()
		{
			Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "PhoneShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr);
			PhoneShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			PhoneShopInterface.NativeFieldInfoPtr_EntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "EntryPrefab");
			PhoneShopInterface.NativeFieldInfoPtr_ValidAmountColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ValidAmountColor");
			PhoneShopInterface.NativeFieldInfoPtr_InvalidAmountColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "InvalidAmountColor");
			PhoneShopInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "Container");
			PhoneShopInterface.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "TitleLabel");
			PhoneShopInterface.NativeFieldInfoPtr_SubtitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "SubtitleLabel");
			PhoneShopInterface.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "EntryContainer");
			PhoneShopInterface.NativeFieldInfoPtr_OrderTotalLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "OrderTotalLabel");
			PhoneShopInterface.NativeFieldInfoPtr_OrderLimitLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "OrderLimitLabel");
			PhoneShopInterface.NativeFieldInfoPtr_DebtLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "DebtLabel");
			PhoneShopInterface.NativeFieldInfoPtr_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ConfirmButton");
			PhoneShopInterface.NativeFieldInfoPtr_ItemLimitContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ItemLimitContainer");
			PhoneShopInterface.NativeFieldInfoPtr_ItemLimitLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ItemLimitLabel");
			PhoneShopInterface.NativeFieldInfoPtr__entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "_entries");
			PhoneShopInterface.NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "_items");
			PhoneShopInterface.NativeFieldInfoPtr__cart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "_cart");
			PhoneShopInterface.NativeFieldInfoPtr_orderLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "orderLimit");
			PhoneShopInterface.NativeFieldInfoPtr_orderConfirmedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "orderConfirmedCallback");
			PhoneShopInterface.NativeFieldInfoPtr_conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "conversation");
			PhoneShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681959);
			PhoneShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681960);
			PhoneShopInterface.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681961);
			PhoneShopInterface.NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_List_1_Listing_Single_Single_Action_2_List_1_CartEntry_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681962);
			PhoneShopInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681963);
			PhoneShopInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681964);
			PhoneShopInterface.NativeMethodInfoPtr_ChangeListingQuantity_Private_Void_Listing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681965);
			PhoneShopInterface.NativeMethodInfoPtr_CartChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681966);
			PhoneShopInterface.NativeMethodInfoPtr_ConfirmOrderPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681967);
			PhoneShopInterface.NativeMethodInfoPtr_CanConfirmOrder_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681968);
			PhoneShopInterface.NativeMethodInfoPtr_UpdateOrderTotal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681969);
			PhoneShopInterface.NativeMethodInfoPtr_GetOrderTotal_Private_Single_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681970);
			PhoneShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681971);
		}

		// Token: 0x17002E6E RID: 11886
		// (get) Token: 0x0600972F RID: 38703 RVA: 0x0026ADB8 File Offset: 0x00268FB8
		// (set) Token: 0x06009730 RID: 38704 RVA: 0x0026ADF4 File Offset: 0x00268FF4
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009731 RID: 38705 RVA: 0x0026AE34 File Offset: 0x00269034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270870, XrefRangeEnd = 270891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009732 RID: 38706 RVA: 0x0026AE68 File Offset: 0x00269068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271020, RefRangeEnd = 271021, XrefRangeStart = 270891, XrefRangeEnd = 271020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, string subtitle, MSGConversation _conversation, List<PhoneShopInterface.Listing> listings, float _orderLimit, float debt, Action<List<PhoneShopInterface.CartEntry>, float> _orderConfirmedCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_conversation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _orderLimit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debt;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_orderConfirmedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_List_1_Listing_Single_Single_Action_2_List_1_CartEntry_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009733 RID: 38707 RVA: 0x0026AF10 File Offset: 0x00269110
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271059, RefRangeEnd = 271062, XrefRangeStart = 271021, XrefRangeEnd = 271059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009734 RID: 38708 RVA: 0x0026AF44 File Offset: 0x00269144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271062, XrefRangeEnd = 271064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009735 RID: 38709 RVA: 0x0026AF88 File Offset: 0x00269188
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271105, RefRangeEnd = 271107, XrefRangeStart = 271064, XrefRangeEnd = 271105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeListingQuantity(PhoneShopInterface.Listing listing, int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_ChangeListingQuantity_Private_Void_Listing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009736 RID: 38710 RVA: 0x0026AFD8 File Offset: 0x002691D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271121, RefRangeEnd = 271123, XrefRangeStart = 271107, XrefRangeEnd = 271121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CartChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_CartChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009737 RID: 38711 RVA: 0x0026B00C File Offset: 0x0026920C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271123, XrefRangeEnd = 271126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmOrderPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_ConfirmOrderPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009738 RID: 38712 RVA: 0x0026B040 File Offset: 0x00269240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271126, XrefRangeEnd = 271127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanConfirmOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_CanConfirmOrder_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009739 RID: 38713 RVA: 0x0026B07C File Offset: 0x0026927C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271127, XrefRangeEnd = 271136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOrderTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_UpdateOrderTotal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600973A RID: 38714 RVA: 0x0026B0B0 File Offset: 0x002692B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 271150, RefRangeEnd = 271155, XrefRangeStart = 271136, XrefRangeEnd = 271150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetOrderTotal(out int itemCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &itemCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_GetOrderTotal_Private_Single_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600973B RID: 38715 RVA: 0x0026B0FC File Offset: 0x002692FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271155, XrefRangeEnd = 271177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhoneShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600973C RID: 38716 RVA: 0x0004973E File Offset: 0x0004793E
		public PhoneShopInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E5A RID: 11866
		// (get) Token: 0x0600973D RID: 38717 RVA: 0x0026B138 File Offset: 0x00269338
		// (set) Token: 0x0600973E RID: 38718 RVA: 0x00049747 File Offset: 0x00047947
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E5B RID: 11867
		// (get) Token: 0x0600973F RID: 38719 RVA: 0x0026B160 File Offset: 0x00269360
		// (set) Token: 0x06009740 RID: 38720 RVA: 0x00049762 File Offset: 0x00047962
		public unsafe RectTransform EntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E5C RID: 11868
		// (get) Token: 0x06009741 RID: 38721 RVA: 0x0026B190 File Offset: 0x00269390
		// (set) Token: 0x06009742 RID: 38722 RVA: 0x00049781 File Offset: 0x00047981
		public unsafe Color ValidAmountColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ValidAmountColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ValidAmountColor)) = value;
			}
		}

		// Token: 0x17002E5D RID: 11869
		// (get) Token: 0x06009743 RID: 38723 RVA: 0x0026B1B8 File Offset: 0x002693B8
		// (set) Token: 0x06009744 RID: 38724 RVA: 0x0004979C File Offset: 0x0004799C
		public unsafe Color InvalidAmountColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_InvalidAmountColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_InvalidAmountColor)) = value;
			}
		}

		// Token: 0x17002E5E RID: 11870
		// (get) Token: 0x06009745 RID: 38725 RVA: 0x0026B1E0 File Offset: 0x002693E0
		// (set) Token: 0x06009746 RID: 38726 RVA: 0x000497B7 File Offset: 0x000479B7
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E5F RID: 11871
		// (get) Token: 0x06009747 RID: 38727 RVA: 0x0026B210 File Offset: 0x00269410
		// (set) Token: 0x06009748 RID: 38728 RVA: 0x000497D6 File Offset: 0x000479D6
		public unsafe Text TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E60 RID: 11872
		// (get) Token: 0x06009749 RID: 38729 RVA: 0x0026B240 File Offset: 0x00269440
		// (set) Token: 0x0600974A RID: 38730 RVA: 0x000497F5 File Offset: 0x000479F5
		public unsafe Text SubtitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_SubtitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_SubtitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E61 RID: 11873
		// (get) Token: 0x0600974B RID: 38731 RVA: 0x0026B270 File Offset: 0x00269470
		// (set) Token: 0x0600974C RID: 38732 RVA: 0x00049814 File Offset: 0x00047A14
		public unsafe RectTransform EntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E62 RID: 11874
		// (get) Token: 0x0600974D RID: 38733 RVA: 0x0026B2A0 File Offset: 0x002694A0
		// (set) Token: 0x0600974E RID: 38734 RVA: 0x00049833 File Offset: 0x00047A33
		public unsafe Text OrderTotalLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderTotalLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderTotalLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E63 RID: 11875
		// (get) Token: 0x0600974F RID: 38735 RVA: 0x0026B2D0 File Offset: 0x002694D0
		// (set) Token: 0x06009750 RID: 38736 RVA: 0x00049852 File Offset: 0x00047A52
		public unsafe Text OrderLimitLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderLimitLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderLimitLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E64 RID: 11876
		// (get) Token: 0x06009751 RID: 38737 RVA: 0x0026B300 File Offset: 0x00269500
		// (set) Token: 0x06009752 RID: 38738 RVA: 0x00049871 File Offset: 0x00047A71
		public unsafe Text DebtLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_DebtLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_DebtLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E65 RID: 11877
		// (get) Token: 0x06009753 RID: 38739 RVA: 0x0026B330 File Offset: 0x00269530
		// (set) Token: 0x06009754 RID: 38740 RVA: 0x00049890 File Offset: 0x00047A90
		public unsafe Button ConfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ConfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x06009755 RID: 38741 RVA: 0x0026B360 File Offset: 0x00269560
		// (set) Token: 0x06009756 RID: 38742 RVA: 0x000498AF File Offset: 0x00047AAF
		public unsafe GameObject ItemLimitContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x06009757 RID: 38743 RVA: 0x0026B390 File Offset: 0x00269590
		// (set) Token: 0x06009758 RID: 38744 RVA: 0x000498CE File Offset: 0x00047ACE
		public unsafe Text ItemLimitLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x06009759 RID: 38745 RVA: 0x0026B3C0 File Offset: 0x002695C0
		// (set) Token: 0x0600975A RID: 38746 RVA: 0x000498ED File Offset: 0x00047AED
		public unsafe List<RectTransform> _entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x0600975B RID: 38747 RVA: 0x0026B3F0 File Offset: 0x002695F0
		// (set) Token: 0x0600975C RID: 38748 RVA: 0x0004990C File Offset: 0x00047B0C
		public unsafe List<PhoneShopInterface.Listing> _items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PhoneShopInterface.Listing>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x0600975D RID: 38749 RVA: 0x0026B420 File Offset: 0x00269620
		// (set) Token: 0x0600975E RID: 38750 RVA: 0x0004992B File Offset: 0x00047B2B
		public unsafe List<PhoneShopInterface.CartEntry> _cart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__cart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PhoneShopInterface.CartEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__cart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6B RID: 11883
		// (get) Token: 0x0600975F RID: 38751 RVA: 0x0026B450 File Offset: 0x00269650
		// (set) Token: 0x06009760 RID: 38752 RVA: 0x0004994A File Offset: 0x00047B4A
		public unsafe float orderLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderLimit)) = value;
			}
		}

		// Token: 0x17002E6C RID: 11884
		// (get) Token: 0x06009761 RID: 38753 RVA: 0x0026B478 File Offset: 0x00269678
		// (set) Token: 0x06009762 RID: 38754 RVA: 0x00049965 File Offset: 0x00047B65
		public unsafe Action<List<PhoneShopInterface.CartEntry>, float> orderConfirmedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderConfirmedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<PhoneShopInterface.CartEntry>, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderConfirmedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6D RID: 11885
		// (get) Token: 0x06009763 RID: 38755 RVA: 0x0026B4A8 File Offset: 0x002696A8
		// (set) Token: 0x06009764 RID: 38756 RVA: 0x00049984 File Offset: 0x00047B84
		public unsafe MSGConversation conversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_conversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040065E1 RID: 26081
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040065E2 RID: 26082
		private static readonly IntPtr NativeFieldInfoPtr_EntryPrefab;

		// Token: 0x040065E3 RID: 26083
		private static readonly IntPtr NativeFieldInfoPtr_ValidAmountColor;

		// Token: 0x040065E4 RID: 26084
		private static readonly IntPtr NativeFieldInfoPtr_InvalidAmountColor;

		// Token: 0x040065E5 RID: 26085
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040065E6 RID: 26086
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x040065E7 RID: 26087
		private static readonly IntPtr NativeFieldInfoPtr_SubtitleLabel;

		// Token: 0x040065E8 RID: 26088
		private static readonly IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x040065E9 RID: 26089
		private static readonly IntPtr NativeFieldInfoPtr_OrderTotalLabel;

		// Token: 0x040065EA RID: 26090
		private static readonly IntPtr NativeFieldInfoPtr_OrderLimitLabel;

		// Token: 0x040065EB RID: 26091
		private static readonly IntPtr NativeFieldInfoPtr_DebtLabel;

		// Token: 0x040065EC RID: 26092
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmButton;

		// Token: 0x040065ED RID: 26093
		private static readonly IntPtr NativeFieldInfoPtr_ItemLimitContainer;

		// Token: 0x040065EE RID: 26094
		private static readonly IntPtr NativeFieldInfoPtr_ItemLimitLabel;

		// Token: 0x040065EF RID: 26095
		private static readonly IntPtr NativeFieldInfoPtr__entries;

		// Token: 0x040065F0 RID: 26096
		private static readonly IntPtr NativeFieldInfoPtr__items;

		// Token: 0x040065F1 RID: 26097
		private static readonly IntPtr NativeFieldInfoPtr__cart;

		// Token: 0x040065F2 RID: 26098
		private static readonly IntPtr NativeFieldInfoPtr_orderLimit;

		// Token: 0x040065F3 RID: 26099
		private static readonly IntPtr NativeFieldInfoPtr_orderConfirmedCallback;

		// Token: 0x040065F4 RID: 26100
		private static readonly IntPtr NativeFieldInfoPtr_conversation;

		// Token: 0x040065F5 RID: 26101
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040065F6 RID: 26102
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040065F7 RID: 26103
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040065F8 RID: 26104
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_List_1_Listing_Single_Single_Action_2_List_1_CartEntry_Single_0;

		// Token: 0x040065F9 RID: 26105
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040065FA RID: 26106
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x040065FB RID: 26107
		private static readonly IntPtr NativeMethodInfoPtr_ChangeListingQuantity_Private_Void_Listing_Int32_0;

		// Token: 0x040065FC RID: 26108
		private static readonly IntPtr NativeMethodInfoPtr_CartChanged_Private_Void_0;

		// Token: 0x040065FD RID: 26109
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmOrderPressed_Private_Void_0;

		// Token: 0x040065FE RID: 26110
		private static readonly IntPtr NativeMethodInfoPtr_CanConfirmOrder_Private_Boolean_0;

		// Token: 0x040065FF RID: 26111
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOrderTotal_Private_Void_0;

		// Token: 0x04006600 RID: 26112
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderTotal_Private_Single_byref_Int32_0;

		// Token: 0x04006601 RID: 26113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B63 RID: 2915
		[Serializable]
		public class Listing : Il2CppSystem.Object
		{
			// Token: 0x0600DA74 RID: 55924 RVA: 0x0033C820 File Offset: 0x0033AA20
			// Note: this type is marked as 'beforefieldinit'.
			static Listing()
			{
				Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "Listing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr);
				PhoneShopInterface.Listing.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr, "Item");
				PhoneShopInterface.Listing.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr, "Price");
				PhoneShopInterface.Listing.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr, 100681972);
			}

			// Token: 0x0600DA75 RID: 55925 RVA: 0x0033C888 File Offset: 0x0033AA88
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70203, RefRangeEnd = 70204, XrefRangeStart = 70203, XrefRangeEnd = 70204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Listing(ItemDefinition item, float price) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.Listing.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA76 RID: 55926 RVA: 0x0006A5E5 File Offset: 0x000687E5
			public Listing(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C2 RID: 17346
			// (get) Token: 0x0600DA77 RID: 55927 RVA: 0x0033C8E4 File Offset: 0x0033AAE4
			// (set) Token: 0x0600DA78 RID: 55928 RVA: 0x0006A5EE File Offset: 0x000687EE
			public unsafe ItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.Listing.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.Listing.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C3 RID: 17347
			// (get) Token: 0x0600DA79 RID: 55929 RVA: 0x0033C914 File Offset: 0x0033AB14
			// (set) Token: 0x0600DA7A RID: 55930 RVA: 0x0006A60D File Offset: 0x0006880D
			public unsafe float Price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.Listing.NativeFieldInfoPtr_Price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.Listing.NativeFieldInfoPtr_Price)) = value;
				}
			}

			// Token: 0x040092A5 RID: 37541
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x040092A6 RID: 37542
			private static readonly IntPtr NativeFieldInfoPtr_Price;

			// Token: 0x040092A7 RID: 37543
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Single_0;
		}

		// Token: 0x02000B64 RID: 2916
		[Serializable]
		public class CartEntry : Il2CppSystem.Object
		{
			// Token: 0x0600DA7B RID: 55931 RVA: 0x0033C93C File Offset: 0x0033AB3C
			// Note: this type is marked as 'beforefieldinit'.
			static CartEntry()
			{
				Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "CartEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr);
				PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr, "Listing");
				PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr, "Quantity");
				PhoneShopInterface.CartEntry.NativeMethodInfoPtr__ctor_Public_Void_Listing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr, 100681973);
			}

			// Token: 0x0600DA7C RID: 55932 RVA: 0x0033C9A4 File Offset: 0x0033ABA4
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 107300, RefRangeEnd = 107309, XrefRangeStart = 107300, XrefRangeEnd = 107309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CartEntry(PhoneShopInterface.Listing listing, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.CartEntry.NativeMethodInfoPtr__ctor_Public_Void_Listing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA7D RID: 55933 RVA: 0x0006A628 File Offset: 0x00068828
			public CartEntry(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C4 RID: 17348
			// (get) Token: 0x0600DA7E RID: 55934 RVA: 0x0033CA00 File Offset: 0x0033AC00
			// (set) Token: 0x0600DA7F RID: 55935 RVA: 0x0006A631 File Offset: 0x00068831
			public unsafe PhoneShopInterface.Listing Listing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Listing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface.Listing>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C5 RID: 17349
			// (get) Token: 0x0600DA80 RID: 55936 RVA: 0x0033CA30 File Offset: 0x0033AC30
			// (set) Token: 0x0600DA81 RID: 55937 RVA: 0x0006A650 File Offset: 0x00068850
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x040092A8 RID: 37544
			private static readonly IntPtr NativeFieldInfoPtr_Listing;

			// Token: 0x040092A9 RID: 37545
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x040092AA RID: 37546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Listing_Int32_0;
		}

		// Token: 0x02000B65 RID: 2917
		[ObfuscatedName("ScheduleOne.UI.Phone.PhoneShopInterface+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA82 RID: 55938 RVA: 0x0033CA58 File Offset: 0x0033AC58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr);
				PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, "entry");
				PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, 100681974);
				PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, 100681975);
				PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__Open_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, 100681976);
			}

			// Token: 0x0600DA83 RID: 55939 RVA: 0x0033CAE8 File Offset: 0x0033ACE8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA84 RID: 55940 RVA: 0x0033CB24 File Offset: 0x0033AD24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270864, XrefRangeEnd = 270866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Open_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA85 RID: 55941 RVA: 0x0033CB58 File Offset: 0x0033AD58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270866, XrefRangeEnd = 270868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Open_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__Open_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA86 RID: 55942 RVA: 0x0006A66B File Offset: 0x0006886B
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C6 RID: 17350
			// (get) Token: 0x0600DA87 RID: 55943 RVA: 0x0033CB8C File Offset: 0x0033AD8C
			// (set) Token: 0x0600DA88 RID: 55944 RVA: 0x0006A674 File Offset: 0x00068874
			public unsafe PhoneShopInterface.Listing entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface.Listing>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C7 RID: 17351
			// (get) Token: 0x0600DA89 RID: 55945 RVA: 0x0033CBBC File Offset: 0x0033ADBC
			// (set) Token: 0x0600DA8A RID: 55946 RVA: 0x0006A693 File Offset: 0x00068893
			public unsafe PhoneShopInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092AB RID: 37547
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x040092AC RID: 37548
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092AD RID: 37549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092AE RID: 37550
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__0_Internal_Void_0;

			// Token: 0x040092AF RID: 37551
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__1_Internal_Void_0;
		}

		// Token: 0x02000B66 RID: 2918
		[ObfuscatedName("ScheduleOne.UI.Phone.PhoneShopInterface+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA8B RID: 55947 RVA: 0x0033CBEC File Offset: 0x0033ADEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr);
				PhoneShopInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr, "listing");
				PhoneShopInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr, 100681977);
				PhoneShopInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ChangeListingQuantity_b__0_Internal_Boolean_CartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr, 100681978);
			}

			// Token: 0x0600DA8C RID: 55948 RVA: 0x0033CC54 File Offset: 0x0033AE54
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA8D RID: 55949 RVA: 0x0033CC90 File Offset: 0x0033AE90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270868, XrefRangeEnd = 270870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChangeListingQuantity_b__0(PhoneShopInterface.CartEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ChangeListingQuantity_b__0_Internal_Boolean_CartEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA8E RID: 55950 RVA: 0x0006A6B2 File Offset: 0x000688B2
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C8 RID: 17352
			// (get) Token: 0x0600DA8F RID: 55951 RVA: 0x0033CCE0 File Offset: 0x0033AEE0
			// (set) Token: 0x0600DA90 RID: 55952 RVA: 0x0006A6BB File Offset: 0x000688BB
			public unsafe PhoneShopInterface.Listing listing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_listing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface.Listing>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092B0 RID: 37552
			private static readonly IntPtr NativeFieldInfoPtr_listing;

			// Token: 0x040092B1 RID: 37553
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092B2 RID: 37554
			private static readonly IntPtr NativeMethodInfoPtr__ChangeListingQuantity_b__0_Internal_Boolean_CartEntry_0;
		}
	}
}
