using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000718 RID: 1816
	public class ItemInfoPanel : MonoBehaviour
	{
		// Token: 0x0600A341 RID: 41793 RVA: 0x0028FA6C File Offset: 0x0028DC6C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInfoPanel()
		{
			Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemInfoPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr);
			ItemInfoPanel.NativeFieldInfoPtr_VERTICAL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "VERTICAL_THRESHOLD");
			ItemInfoPanel.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "<IsOpen>k__BackingField");
			ItemInfoPanel.NativeFieldInfoPtr__CurrentItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "<CurrentItem>k__BackingField");
			ItemInfoPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "Container");
			ItemInfoPanel.NativeFieldInfoPtr_ContentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "ContentContainer");
			ItemInfoPanel.NativeFieldInfoPtr_TopArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "TopArrow");
			ItemInfoPanel.NativeFieldInfoPtr_BottomArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "BottomArrow");
			ItemInfoPanel.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "Canvas");
			ItemInfoPanel.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "Offset");
			ItemInfoPanel.NativeFieldInfoPtr_DefaultContentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "DefaultContentPrefab");
			ItemInfoPanel.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "content");
			ItemInfoPanel.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683271);
			ItemInfoPanel.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683272);
			ItemInfoPanel.NativeMethodInfoPtr_get_CurrentItem_Public_get_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683273);
			ItemInfoPanel.NativeMethodInfoPtr_set_CurrentItem_Protected_set_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683274);
			ItemInfoPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683275);
			ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemInstance_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683276);
			ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683277);
			ItemInfoPanel.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683278);
			ItemInfoPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100683279);
		}

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0600A342 RID: 41794 RVA: 0x0028FC2C File Offset: 0x0028DE2C
		// (set) Token: 0x0600A343 RID: 41795 RVA: 0x0028FC68 File Offset: 0x0028DE68
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x0600A344 RID: 41796 RVA: 0x0028FCA8 File Offset: 0x0028DEA8
		// (set) Token: 0x0600A345 RID: 41797 RVA: 0x0028FCE8 File Offset: 0x0028DEE8
		public unsafe ItemInstance CurrentItem
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_get_CurrentItem_Public_get_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_set_CurrentItem_Protected_set_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A346 RID: 41798 RVA: 0x0028FD2C File Offset: 0x0028DF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285998, XrefRangeEnd = 285999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A347 RID: 41799 RVA: 0x0028FD60 File Offset: 0x0028DF60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286037, RefRangeEnd = 286038, XrefRangeStart = 285999, XrefRangeEnd = 286037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemInstance item, RectTransform rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemInstance_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A348 RID: 41800 RVA: 0x0028FDB4 File Offset: 0x0028DFB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286071, RefRangeEnd = 286072, XrefRangeStart = 286038, XrefRangeEnd = 286071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemDefinition def, RectTransform rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A349 RID: 41801 RVA: 0x0028FE08 File Offset: 0x0028E008
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 286084, RefRangeEnd = 286089, XrefRangeStart = 286072, XrefRangeEnd = 286084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A34A RID: 41802 RVA: 0x0028FE3C File Offset: 0x0028E03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286089, XrefRangeEnd = 286090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInfoPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A34B RID: 41803 RVA: 0x000505C8 File Offset: 0x0004E7C8
		public ItemInfoPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x0600A34C RID: 41804 RVA: 0x0028FE78 File Offset: 0x0028E078
		// (set) Token: 0x0600A34D RID: 41805 RVA: 0x000505D1 File Offset: 0x0004E7D1
		public unsafe static float VERTICAL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemInfoPanel.NativeFieldInfoPtr_VERTICAL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemInfoPanel.NativeFieldInfoPtr_VERTICAL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x0600A34E RID: 41806 RVA: 0x0028FE94 File Offset: 0x0028E094
		// (set) Token: 0x0600A34F RID: 41807 RVA: 0x000505DF File Offset: 0x0004E7DF
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x0600A350 RID: 41808 RVA: 0x0028FEBC File Offset: 0x0028E0BC
		// (set) Token: 0x0600A351 RID: 41809 RVA: 0x000505FA File Offset: 0x0004E7FA
		public unsafe ItemInstance _CurrentItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__CurrentItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__CurrentItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x0600A352 RID: 41810 RVA: 0x0028FEEC File Offset: 0x0028E0EC
		// (set) Token: 0x0600A353 RID: 41811 RVA: 0x00050619 File Offset: 0x0004E819
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x0600A354 RID: 41812 RVA: 0x0028FF1C File Offset: 0x0028E11C
		// (set) Token: 0x0600A355 RID: 41813 RVA: 0x00050638 File Offset: 0x0004E838
		public unsafe RectTransform ContentContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_ContentContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_ContentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x0600A356 RID: 41814 RVA: 0x0028FF4C File Offset: 0x0028E14C
		// (set) Token: 0x0600A357 RID: 41815 RVA: 0x00050657 File Offset: 0x0004E857
		public unsafe GameObject TopArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_TopArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_TopArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x0600A358 RID: 41816 RVA: 0x0028FF7C File Offset: 0x0028E17C
		// (set) Token: 0x0600A359 RID: 41817 RVA: 0x00050676 File Offset: 0x0004E876
		public unsafe GameObject BottomArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_BottomArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_BottomArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x0600A35A RID: 41818 RVA: 0x0028FFAC File Offset: 0x0028E1AC
		// (set) Token: 0x0600A35B RID: 41819 RVA: 0x00050695 File Offset: 0x0004E895
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700325E RID: 12894
		// (get) Token: 0x0600A35C RID: 41820 RVA: 0x0028FFDC File Offset: 0x0028E1DC
		// (set) Token: 0x0600A35D RID: 41821 RVA: 0x000506B4 File Offset: 0x0004E8B4
		public unsafe Vector2 Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x0600A35E RID: 41822 RVA: 0x00290004 File Offset: 0x0028E204
		// (set) Token: 0x0600A35F RID: 41823 RVA: 0x000506CF File Offset: 0x0004E8CF
		public unsafe ItemInfoContent DefaultContentPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_DefaultContentPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_DefaultContentPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x0600A360 RID: 41824 RVA: 0x00290034 File Offset: 0x0028E234
		// (set) Token: 0x0600A361 RID: 41825 RVA: 0x000506EE File Offset: 0x0004E8EE
		public unsafe ItemInfoContent content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D7E RID: 28030
		private static readonly IntPtr NativeFieldInfoPtr_VERTICAL_THRESHOLD;

		// Token: 0x04006D7F RID: 28031
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006D80 RID: 28032
		private static readonly IntPtr NativeFieldInfoPtr__CurrentItem_k__BackingField;

		// Token: 0x04006D81 RID: 28033
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006D82 RID: 28034
		private static readonly IntPtr NativeFieldInfoPtr_ContentContainer;

		// Token: 0x04006D83 RID: 28035
		private static readonly IntPtr NativeFieldInfoPtr_TopArrow;

		// Token: 0x04006D84 RID: 28036
		private static readonly IntPtr NativeFieldInfoPtr_BottomArrow;

		// Token: 0x04006D85 RID: 28037
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006D86 RID: 28038
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x04006D87 RID: 28039
		private static readonly IntPtr NativeFieldInfoPtr_DefaultContentPrefab;

		// Token: 0x04006D88 RID: 28040
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04006D89 RID: 28041
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006D8A RID: 28042
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006D8B RID: 28043
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentItem_Public_get_ItemInstance_0;

		// Token: 0x04006D8C RID: 28044
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentItem_Protected_set_Void_ItemInstance_0;

		// Token: 0x04006D8D RID: 28045
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006D8E RID: 28046
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemInstance_RectTransform_0;

		// Token: 0x04006D8F RID: 28047
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_RectTransform_0;

		// Token: 0x04006D90 RID: 28048
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006D91 RID: 28049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
