using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x0200069E RID: 1694
	public class CounterOfferProductSelector : MonoBehaviour
	{
		// Token: 0x060096FB RID: 38651 RVA: 0x0026A158 File Offset: 0x00268358
		// Note: this type is marked as 'beforefieldinit'.
		static CounterOfferProductSelector()
		{
			Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CounterOfferProductSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr);
			CounterOfferProductSelector.NativeFieldInfoPtr_ENTRIES_PER_PAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "ENTRIES_PER_PAGE");
			CounterOfferProductSelector.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "Container");
			CounterOfferProductSelector.NativeFieldInfoPtr_SearchBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "SearchBar");
			CounterOfferProductSelector.NativeFieldInfoPtr_ProductContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "ProductContainer");
			CounterOfferProductSelector.NativeFieldInfoPtr_PageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "PageLabel");
			CounterOfferProductSelector.NativeFieldInfoPtr_ProductEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "ProductEntryPrefab");
			CounterOfferProductSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			CounterOfferProductSelector.NativeFieldInfoPtr_onProductPreviewed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "onProductPreviewed");
			CounterOfferProductSelector.NativeFieldInfoPtr_onProductSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "onProductSelected");
			CounterOfferProductSelector.NativeFieldInfoPtr_productEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "productEntries");
			CounterOfferProductSelector.NativeFieldInfoPtr_productEntriesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "productEntriesDict");
			CounterOfferProductSelector.NativeFieldInfoPtr_searchTerm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "searchTerm");
			CounterOfferProductSelector.NativeFieldInfoPtr_pageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "pageIndex");
			CounterOfferProductSelector.NativeFieldInfoPtr_pageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "pageCount");
			CounterOfferProductSelector.NativeFieldInfoPtr_results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "results");
			CounterOfferProductSelector.NativeFieldInfoPtr_lastPreviewedResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "lastPreviewedResult");
			CounterOfferProductSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681936);
			CounterOfferProductSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681937);
			CounterOfferProductSelector.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681938);
			CounterOfferProductSelector.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681939);
			CounterOfferProductSelector.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681940);
			CounterOfferProductSelector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681941);
			CounterOfferProductSelector.NativeMethodInfoPtr_SetSearchTerm_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681942);
			CounterOfferProductSelector.NativeMethodInfoPtr_RebuildResultsList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681943);
			CounterOfferProductSelector.NativeMethodInfoPtr_GetMatchingProducts_Private_List_1_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681944);
			CounterOfferProductSelector.NativeMethodInfoPtr_EnsureAllEntriesExist_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681945);
			CounterOfferProductSelector.NativeMethodInfoPtr_CreateProductEntry_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681946);
			CounterOfferProductSelector.NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681947);
			CounterOfferProductSelector.NativeMethodInfoPtr_SetPage_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681948);
			CounterOfferProductSelector.NativeMethodInfoPtr_ProductHovered_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681949);
			CounterOfferProductSelector.NativeMethodInfoPtr_ProductSelected_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681950);
			CounterOfferProductSelector.NativeMethodInfoPtr_IsMouseOverSelector_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681951);
			CounterOfferProductSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681952);
		}

		// Token: 0x17002E59 RID: 11865
		// (get) Token: 0x060096FC RID: 38652 RVA: 0x0026A41C File Offset: 0x0026861C
		// (set) Token: 0x060096FD RID: 38653 RVA: 0x0026A458 File Offset: 0x00268658
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 50985, RefRangeEnd = 50988, XrefRangeStart = 50985, XrefRangeEnd = 50988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060096FE RID: 38654 RVA: 0x0026A498 File Offset: 0x00268698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270466, XrefRangeEnd = 270476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096FF RID: 38655 RVA: 0x0026A4CC File Offset: 0x002686CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270476, XrefRangeEnd = 270495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009700 RID: 38656 RVA: 0x0026A500 File Offset: 0x00268700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270495, XrefRangeEnd = 270498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009701 RID: 38657 RVA: 0x0026A534 File Offset: 0x00268734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270498, XrefRangeEnd = 270507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009702 RID: 38658 RVA: 0x0026A568 File Offset: 0x00268768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270507, XrefRangeEnd = 270519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSearchTerm(string search)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(search);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_SetSearchTerm_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009703 RID: 38659 RVA: 0x0026A5AC File Offset: 0x002687AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 270555, RefRangeEnd = 270558, XrefRangeStart = 270519, XrefRangeEnd = 270555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildResultsList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_RebuildResultsList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009704 RID: 38660 RVA: 0x0026A5E0 File Offset: 0x002687E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270653, RefRangeEnd = 270654, XrefRangeStart = 270558, XrefRangeEnd = 270653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ProductDefinition> GetMatchingProducts(string searchTerm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(searchTerm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_GetMatchingProducts_Private_List_1_ProductDefinition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr3) : null;
		}

		// Token: 0x06009705 RID: 38661 RVA: 0x0026A630 File Offset: 0x00268830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270676, RefRangeEnd = 270678, XrefRangeStart = 270654, XrefRangeEnd = 270676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureAllEntriesExist()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_EnsureAllEntriesExist_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009706 RID: 38662 RVA: 0x0026A664 File Offset: 0x00268864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270740, RefRangeEnd = 270741, XrefRangeStart = 270678, XrefRangeEnd = 270740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateProductEntry(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_CreateProductEntry_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009707 RID: 38663 RVA: 0x0026A6A8 File Offset: 0x002688A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270741, XrefRangeEnd = 270742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangePage(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009708 RID: 38664 RVA: 0x0026A6E8 File Offset: 0x002688E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270810, RefRangeEnd = 270812, XrefRangeStart = 270742, XrefRangeEnd = 270810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPage(int page)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref page;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_SetPage_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009709 RID: 38665 RVA: 0x0026A728 File Offset: 0x00268928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270812, XrefRangeEnd = 270813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductHovered(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_ProductHovered_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600970A RID: 38666 RVA: 0x0026A76C File Offset: 0x0026896C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270816, RefRangeEnd = 270817, XrefRangeStart = 270813, XrefRangeEnd = 270816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductSelected(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_ProductSelected_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600970B RID: 38667 RVA: 0x0026A7B0 File Offset: 0x002689B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270817, XrefRangeEnd = 270839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOverSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_IsMouseOverSelector_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600970C RID: 38668 RVA: 0x0026A7EC File Offset: 0x002689EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270839, XrefRangeEnd = 270864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CounterOfferProductSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600970D RID: 38669 RVA: 0x00049562 File Offset: 0x00047762
		public CounterOfferProductSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x0600970E RID: 38670 RVA: 0x0026A828 File Offset: 0x00268A28
		// (set) Token: 0x0600970F RID: 38671 RVA: 0x0004956B File Offset: 0x0004776B
		public unsafe static int ENTRIES_PER_PAGE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CounterOfferProductSelector.NativeFieldInfoPtr_ENTRIES_PER_PAGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterOfferProductSelector.NativeFieldInfoPtr_ENTRIES_PER_PAGE, (void*)(&value));
			}
		}

		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x06009710 RID: 38672 RVA: 0x0026A844 File Offset: 0x00268A44
		// (set) Token: 0x06009711 RID: 38673 RVA: 0x00049579 File Offset: 0x00047779
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x06009712 RID: 38674 RVA: 0x0026A874 File Offset: 0x00268A74
		// (set) Token: 0x06009713 RID: 38675 RVA: 0x00049598 File Offset: 0x00047798
		public unsafe InputField SearchBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_SearchBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_SearchBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4C RID: 11852
		// (get) Token: 0x06009714 RID: 38676 RVA: 0x0026A8A4 File Offset: 0x00268AA4
		// (set) Token: 0x06009715 RID: 38677 RVA: 0x000495B7 File Offset: 0x000477B7
		public unsafe RectTransform ProductContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x06009716 RID: 38678 RVA: 0x0026A8D4 File Offset: 0x00268AD4
		// (set) Token: 0x06009717 RID: 38679 RVA: 0x000495D6 File Offset: 0x000477D6
		public unsafe Text PageLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_PageLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_PageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x06009718 RID: 38680 RVA: 0x0026A904 File Offset: 0x00268B04
		// (set) Token: 0x06009719 RID: 38681 RVA: 0x000495F5 File Offset: 0x000477F5
		public unsafe GameObject ProductEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x0600971A RID: 38682 RVA: 0x0026A934 File Offset: 0x00268B34
		// (set) Token: 0x0600971B RID: 38683 RVA: 0x00049614 File Offset: 0x00047814
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x0600971C RID: 38684 RVA: 0x0026A95C File Offset: 0x00268B5C
		// (set) Token: 0x0600971D RID: 38685 RVA: 0x0004962F File Offset: 0x0004782F
		public unsafe Action<ProductDefinition> onProductPreviewed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductPreviewed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductPreviewed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x0600971E RID: 38686 RVA: 0x0026A98C File Offset: 0x00268B8C
		// (set) Token: 0x0600971F RID: 38687 RVA: 0x0004964E File Offset: 0x0004784E
		public unsafe Action<ProductDefinition> onProductSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x06009720 RID: 38688 RVA: 0x0026A9BC File Offset: 0x00268BBC
		// (set) Token: 0x06009721 RID: 38689 RVA: 0x0004966D File Offset: 0x0004786D
		public unsafe List<RectTransform> productEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x06009722 RID: 38690 RVA: 0x0026A9EC File Offset: 0x00268BEC
		// (set) Token: 0x06009723 RID: 38691 RVA: 0x0004968C File Offset: 0x0004788C
		public unsafe Dictionary<ProductDefinition, RectTransform> productEntriesDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntriesDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductDefinition, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntriesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x06009724 RID: 38692 RVA: 0x0026AA1C File Offset: 0x00268C1C
		// (set) Token: 0x06009725 RID: 38693 RVA: 0x000496AB File Offset: 0x000478AB
		public unsafe string searchTerm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_searchTerm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_searchTerm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x06009726 RID: 38694 RVA: 0x0026AA44 File Offset: 0x00268C44
		// (set) Token: 0x06009727 RID: 38695 RVA: 0x000496CA File Offset: 0x000478CA
		public unsafe int pageIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageIndex)) = value;
			}
		}

		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x06009728 RID: 38696 RVA: 0x0026AA6C File Offset: 0x00268C6C
		// (set) Token: 0x06009729 RID: 38697 RVA: 0x000496E5 File Offset: 0x000478E5
		public unsafe int pageCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageCount)) = value;
			}
		}

		// Token: 0x17002E57 RID: 11863
		// (get) Token: 0x0600972A RID: 38698 RVA: 0x0026AA94 File Offset: 0x00268C94
		// (set) Token: 0x0600972B RID: 38699 RVA: 0x00049700 File Offset: 0x00047900
		public unsafe List<ProductDefinition> results
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_results);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_results), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E58 RID: 11864
		// (get) Token: 0x0600972C RID: 38700 RVA: 0x0026AAC4 File Offset: 0x00268CC4
		// (set) Token: 0x0600972D RID: 38701 RVA: 0x0004971F File Offset: 0x0004791F
		public unsafe ProductDefinition lastPreviewedResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_lastPreviewedResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_lastPreviewedResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040065C0 RID: 26048
		private static readonly IntPtr NativeFieldInfoPtr_ENTRIES_PER_PAGE;

		// Token: 0x040065C1 RID: 26049
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040065C2 RID: 26050
		private static readonly IntPtr NativeFieldInfoPtr_SearchBar;

		// Token: 0x040065C3 RID: 26051
		private static readonly IntPtr NativeFieldInfoPtr_ProductContainer;

		// Token: 0x040065C4 RID: 26052
		private static readonly IntPtr NativeFieldInfoPtr_PageLabel;

		// Token: 0x040065C5 RID: 26053
		private static readonly IntPtr NativeFieldInfoPtr_ProductEntryPrefab;

		// Token: 0x040065C6 RID: 26054
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040065C7 RID: 26055
		private static readonly IntPtr NativeFieldInfoPtr_onProductPreviewed;

		// Token: 0x040065C8 RID: 26056
		private static readonly IntPtr NativeFieldInfoPtr_onProductSelected;

		// Token: 0x040065C9 RID: 26057
		private static readonly IntPtr NativeFieldInfoPtr_productEntries;

		// Token: 0x040065CA RID: 26058
		private static readonly IntPtr NativeFieldInfoPtr_productEntriesDict;

		// Token: 0x040065CB RID: 26059
		private static readonly IntPtr NativeFieldInfoPtr_searchTerm;

		// Token: 0x040065CC RID: 26060
		private static readonly IntPtr NativeFieldInfoPtr_pageIndex;

		// Token: 0x040065CD RID: 26061
		private static readonly IntPtr NativeFieldInfoPtr_pageCount;

		// Token: 0x040065CE RID: 26062
		private static readonly IntPtr NativeFieldInfoPtr_results;

		// Token: 0x040065CF RID: 26063
		private static readonly IntPtr NativeFieldInfoPtr_lastPreviewedResult;

		// Token: 0x040065D0 RID: 26064
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040065D1 RID: 26065
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040065D2 RID: 26066
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040065D3 RID: 26067
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040065D4 RID: 26068
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040065D5 RID: 26069
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040065D6 RID: 26070
		private static readonly IntPtr NativeMethodInfoPtr_SetSearchTerm_Public_Void_String_0;

		// Token: 0x040065D7 RID: 26071
		private static readonly IntPtr NativeMethodInfoPtr_RebuildResultsList_Private_Void_0;

		// Token: 0x040065D8 RID: 26072
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchingProducts_Private_List_1_ProductDefinition_String_0;

		// Token: 0x040065D9 RID: 26073
		private static readonly IntPtr NativeMethodInfoPtr_EnsureAllEntriesExist_Private_Void_0;

		// Token: 0x040065DA RID: 26074
		private static readonly IntPtr NativeMethodInfoPtr_CreateProductEntry_Private_Void_ProductDefinition_0;

		// Token: 0x040065DB RID: 26075
		private static readonly IntPtr NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0;

		// Token: 0x040065DC RID: 26076
		private static readonly IntPtr NativeMethodInfoPtr_SetPage_Private_Void_Int32_0;

		// Token: 0x040065DD RID: 26077
		private static readonly IntPtr NativeMethodInfoPtr_ProductHovered_Private_Void_ProductDefinition_0;

		// Token: 0x040065DE RID: 26078
		private static readonly IntPtr NativeMethodInfoPtr_ProductSelected_Private_Void_ProductDefinition_0;

		// Token: 0x040065DF RID: 26079
		private static readonly IntPtr NativeMethodInfoPtr_IsMouseOverSelector_Public_Boolean_0;

		// Token: 0x040065E0 RID: 26080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B61 RID: 2913
		[ObfuscatedName("ScheduleOne.UI.Phone.CounterOfferProductSelector+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA63 RID: 55907 RVA: 0x0033C514 File Offset: 0x0033A714
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr);
				CounterOfferProductSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, "<>9");
				CounterOfferProductSelector.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, "<>9__24_0");
				CounterOfferProductSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, 100681954);
				CounterOfferProductSelector.__c.NativeMethodInfoPtr__RebuildResultsList_b__24_0_Internal_Int32_ProductDefinition_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, 100681955);
			}

			// Token: 0x0600DA64 RID: 55908 RVA: 0x0033C590 File Offset: 0x0033A790
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA65 RID: 55909 RVA: 0x0033C5CC File Offset: 0x0033A7CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270453, XrefRangeEnd = 270461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RebuildResultsList_b__24_0(ProductDefinition a, ProductDefinition b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c.NativeMethodInfoPtr__RebuildResultsList_b__24_0_Internal_Int32_ProductDefinition_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA66 RID: 55910 RVA: 0x0006A571 File Offset: 0x00068771
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043BE RID: 17342
			// (get) Token: 0x0600DA67 RID: 55911 RVA: 0x0033C62C File Offset: 0x0033A82C
			// (set) Token: 0x0600DA68 RID: 55912 RVA: 0x0006A57A File Offset: 0x0006877A
			public unsafe static CounterOfferProductSelector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterOfferProductSelector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043BF RID: 17343
			// (get) Token: 0x0600DA69 RID: 55913 RVA: 0x0033C654 File Offset: 0x0033A854
			// (set) Token: 0x0600DA6A RID: 55914 RVA: 0x0006A58C File Offset: 0x0006878C
			public unsafe static Comparison<ProductDefinition> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ProductDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400929C RID: 37532
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400929D RID: 37533
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x0400929E RID: 37534
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400929F RID: 37535
			private static readonly IntPtr NativeMethodInfoPtr__RebuildResultsList_b__24_0_Internal_Int32_ProductDefinition_ProductDefinition_0;
		}

		// Token: 0x02000B62 RID: 2914
		[ObfuscatedName("ScheduleOne.UI.Phone.CounterOfferProductSelector+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA6B RID: 55915 RVA: 0x0033C67C File Offset: 0x0033A87C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr);
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, "product");
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, 100681956);
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__CreateProductEntry_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, 100681957);
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__CreateProductEntry_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, 100681958);
			}

			// Token: 0x0600DA6C RID: 55916 RVA: 0x0033C70C File Offset: 0x0033A90C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA6D RID: 55917 RVA: 0x0033C748 File Offset: 0x0033A948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270461, XrefRangeEnd = 270464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateProductEntry_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__CreateProductEntry_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA6E RID: 55918 RVA: 0x0033C77C File Offset: 0x0033A97C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270464, XrefRangeEnd = 270466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateProductEntry_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__CreateProductEntry_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA6F RID: 55919 RVA: 0x0006A59E File Offset: 0x0006879E
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C0 RID: 17344
			// (get) Token: 0x0600DA70 RID: 55920 RVA: 0x0033C7C0 File Offset: 0x0033A9C0
			// (set) Token: 0x0600DA71 RID: 55921 RVA: 0x0006A5A7 File Offset: 0x000687A7
			public unsafe CounterOfferProductSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterOfferProductSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C1 RID: 17345
			// (get) Token: 0x0600DA72 RID: 55922 RVA: 0x0033C7F0 File Offset: 0x0033A9F0
			// (set) Token: 0x0600DA73 RID: 55923 RVA: 0x0006A5C6 File Offset: 0x000687C6
			public unsafe ProductDefinition product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092A0 RID: 37536
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092A1 RID: 37537
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x040092A2 RID: 37538
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092A3 RID: 37539
			private static readonly IntPtr NativeMethodInfoPtr__CreateProductEntry_b__0_Internal_Void_0;

			// Token: 0x040092A4 RID: 37540
			private static readonly IntPtr NativeMethodInfoPtr__CreateProductEntry_b__1_Internal_Void_BaseEventData_0;
		}
	}
}
