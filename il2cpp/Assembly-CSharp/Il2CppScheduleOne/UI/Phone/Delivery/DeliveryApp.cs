using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020006AA RID: 1706
	public class DeliveryApp : App<DeliveryApp>
	{
		// Token: 0x060098D1 RID: 39121 RVA: 0x0026F968 File Offset: 0x0026DB68
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryApp()
		{
			Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "DeliveryApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr);
			DeliveryApp.NativeFieldInfoPtr_deliveryShops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "deliveryShops");
			DeliveryApp.NativeFieldInfoPtr_StatusDisplayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "StatusDisplayPrefab");
			DeliveryApp.NativeFieldInfoPtr_OrderSubmittedAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "OrderSubmittedAnim");
			DeliveryApp.NativeFieldInfoPtr_OrderSubmittedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "OrderSubmittedSound");
			DeliveryApp.NativeFieldInfoPtr_StatusDisplayContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "StatusDisplayContainer");
			DeliveryApp.NativeFieldInfoPtr_NoDeliveriesIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "NoDeliveriesIndicator");
			DeliveryApp.NativeFieldInfoPtr_MainScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "MainScrollRect");
			DeliveryApp.NativeFieldInfoPtr_MainLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "MainLayoutGroup");
			DeliveryApp.NativeFieldInfoPtr_statusDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "statusDisplays");
			DeliveryApp.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "started");
			DeliveryApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682153);
			DeliveryApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682154);
			DeliveryApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682155);
			DeliveryApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682156);
			DeliveryApp.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682157);
			DeliveryApp.NativeMethodInfoPtr_RefreshContent_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682158);
			DeliveryApp.NativeMethodInfoPtr_PlayOrderSubmittedAnim_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682159);
			DeliveryApp.NativeMethodInfoPtr_CreateDeliveryStatusDisplay_Private_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682160);
			DeliveryApp.NativeMethodInfoPtr_DeliveryCompleted_Private_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682161);
			DeliveryApp.NativeMethodInfoPtr_SortStatusDisplays_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682162);
			DeliveryApp.NativeMethodInfoPtr_RefreshNoDeliveriesIndicator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682163);
			DeliveryApp.NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682164);
			DeliveryApp.NativeMethodInfoPtr_GetShop_Public_DeliveryShop_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682165);
			DeliveryApp.NativeMethodInfoPtr_GetShop_Public_DeliveryShop_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682166);
			DeliveryApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682167);
		}

		// Token: 0x060098D2 RID: 39122 RVA: 0x0026FB8C File Offset: 0x0026DD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272993, XrefRangeEnd = 273003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098D3 RID: 39123 RVA: 0x0026FBC8 File Offset: 0x0026DDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273003, XrefRangeEnd = 273072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098D4 RID: 39124 RVA: 0x0026FC04 File Offset: 0x0026DE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273072, XrefRangeEnd = 273075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098D5 RID: 39125 RVA: 0x0026FC40 File Offset: 0x0026DE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273075, XrefRangeEnd = 273119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098D6 RID: 39126 RVA: 0x0026FC8C File Offset: 0x0026DE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273119, XrefRangeEnd = 273135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098D7 RID: 39127 RVA: 0x0026FCC0 File Offset: 0x0026DEC0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 273148, RefRangeEnd = 273153, XrefRangeStart = 273135, XrefRangeEnd = 273148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshContent(bool keepScrollPosition = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref keepScrollPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_RefreshContent_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098D8 RID: 39128 RVA: 0x0026FD00 File Offset: 0x0026DF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273153, XrefRangeEnd = 273155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOrderSubmittedAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_PlayOrderSubmittedAnim_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098D9 RID: 39129 RVA: 0x0026FD34 File Offset: 0x0026DF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273155, XrefRangeEnd = 273174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateDeliveryStatusDisplay(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_CreateDeliveryStatusDisplay_Private_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098DA RID: 39130 RVA: 0x0026FD78 File Offset: 0x0026DF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273174, XrefRangeEnd = 273203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeliveryCompleted(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_DeliveryCompleted_Private_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098DB RID: 39131 RVA: 0x0026FDBC File Offset: 0x0026DFBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273232, RefRangeEnd = 273234, XrefRangeStart = 273203, XrefRangeEnd = 273232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortStatusDisplays()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_SortStatusDisplays_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098DC RID: 39132 RVA: 0x0026FDF0 File Offset: 0x0026DFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273234, XrefRangeEnd = 273238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNoDeliveriesIndicator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_RefreshNoDeliveriesIndicator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098DD RID: 39133 RVA: 0x0026FE24 File Offset: 0x0026E024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273238, XrefRangeEnd = 273259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefreshLayoutGroupsImmediateAndRecursive(GameObject root)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098DE RID: 39134 RVA: 0x0026FE5C File Offset: 0x0026E05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273259, XrefRangeEnd = 273274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryShop GetShop(ShopInterface matchingShop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchingShop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_GetShop_Public_DeliveryShop_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryShop>(intPtr3) : null;
		}

		// Token: 0x060098DF RID: 39135 RVA: 0x0026FEAC File Offset: 0x0026E0AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273289, RefRangeEnd = 273290, XrefRangeStart = 273274, XrefRangeEnd = 273289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryShop GetShop(string shopName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shopName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_GetShop_Public_DeliveryShop_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryShop>(intPtr3) : null;
		}

		// Token: 0x060098E0 RID: 39136 RVA: 0x0026FEFC File Offset: 0x0026E0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273290, XrefRangeEnd = 273310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098E1 RID: 39137 RVA: 0x0004A775 File Offset: 0x00048975
		public DeliveryApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EEF RID: 12015
		// (get) Token: 0x060098E2 RID: 39138 RVA: 0x0026FF38 File Offset: 0x0026E138
		// (set) Token: 0x060098E3 RID: 39139 RVA: 0x0004A77E File Offset: 0x0004897E
		public unsafe List<DeliveryShop> deliveryShops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_deliveryShops);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeliveryShop>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_deliveryShops), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF0 RID: 12016
		// (get) Token: 0x060098E4 RID: 39140 RVA: 0x0026FF68 File Offset: 0x0026E168
		// (set) Token: 0x060098E5 RID: 39141 RVA: 0x0004A79D File Offset: 0x0004899D
		public unsafe DeliveryStatusDisplay StatusDisplayPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_StatusDisplayPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryStatusDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_StatusDisplayPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF1 RID: 12017
		// (get) Token: 0x060098E6 RID: 39142 RVA: 0x0026FF98 File Offset: 0x0026E198
		// (set) Token: 0x060098E7 RID: 39143 RVA: 0x0004A7BC File Offset: 0x000489BC
		public unsafe Animation OrderSubmittedAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF2 RID: 12018
		// (get) Token: 0x060098E8 RID: 39144 RVA: 0x0026FFC8 File Offset: 0x0026E1C8
		// (set) Token: 0x060098E9 RID: 39145 RVA: 0x0004A7DB File Offset: 0x000489DB
		public unsafe AudioSourceController OrderSubmittedSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF3 RID: 12019
		// (get) Token: 0x060098EA RID: 39146 RVA: 0x0026FFF8 File Offset: 0x0026E1F8
		// (set) Token: 0x060098EB RID: 39147 RVA: 0x0004A7FA File Offset: 0x000489FA
		public unsafe RectTransform StatusDisplayContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_StatusDisplayContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_StatusDisplayContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF4 RID: 12020
		// (get) Token: 0x060098EC RID: 39148 RVA: 0x00270028 File Offset: 0x0026E228
		// (set) Token: 0x060098ED RID: 39149 RVA: 0x0004A819 File Offset: 0x00048A19
		public unsafe RectTransform NoDeliveriesIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_NoDeliveriesIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_NoDeliveriesIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF5 RID: 12021
		// (get) Token: 0x060098EE RID: 39150 RVA: 0x00270058 File Offset: 0x0026E258
		// (set) Token: 0x060098EF RID: 39151 RVA: 0x0004A838 File Offset: 0x00048A38
		public unsafe ScrollRect MainScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_MainScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_MainScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF6 RID: 12022
		// (get) Token: 0x060098F0 RID: 39152 RVA: 0x00270088 File Offset: 0x0026E288
		// (set) Token: 0x060098F1 RID: 39153 RVA: 0x0004A857 File Offset: 0x00048A57
		public unsafe LayoutGroup MainLayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_MainLayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_MainLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF7 RID: 12023
		// (get) Token: 0x060098F2 RID: 39154 RVA: 0x002700B8 File Offset: 0x0026E2B8
		// (set) Token: 0x060098F3 RID: 39155 RVA: 0x0004A876 File Offset: 0x00048A76
		public unsafe List<DeliveryStatusDisplay> statusDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_statusDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeliveryStatusDisplay>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_statusDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF8 RID: 12024
		// (get) Token: 0x060098F4 RID: 39156 RVA: 0x002700E8 File Offset: 0x0026E2E8
		// (set) Token: 0x060098F5 RID: 39157 RVA: 0x0004A895 File Offset: 0x00048A95
		public unsafe bool started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x040066E6 RID: 26342
		private static readonly IntPtr NativeFieldInfoPtr_deliveryShops;

		// Token: 0x040066E7 RID: 26343
		private static readonly IntPtr NativeFieldInfoPtr_StatusDisplayPrefab;

		// Token: 0x040066E8 RID: 26344
		private static readonly IntPtr NativeFieldInfoPtr_OrderSubmittedAnim;

		// Token: 0x040066E9 RID: 26345
		private static readonly IntPtr NativeFieldInfoPtr_OrderSubmittedSound;

		// Token: 0x040066EA RID: 26346
		private static readonly IntPtr NativeFieldInfoPtr_StatusDisplayContainer;

		// Token: 0x040066EB RID: 26347
		private static readonly IntPtr NativeFieldInfoPtr_NoDeliveriesIndicator;

		// Token: 0x040066EC RID: 26348
		private static readonly IntPtr NativeFieldInfoPtr_MainScrollRect;

		// Token: 0x040066ED RID: 26349
		private static readonly IntPtr NativeFieldInfoPtr_MainLayoutGroup;

		// Token: 0x040066EE RID: 26350
		private static readonly IntPtr NativeFieldInfoPtr_statusDisplays;

		// Token: 0x040066EF RID: 26351
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x040066F0 RID: 26352
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040066F1 RID: 26353
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040066F2 RID: 26354
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040066F3 RID: 26355
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x040066F4 RID: 26356
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x040066F5 RID: 26357
		private static readonly IntPtr NativeMethodInfoPtr_RefreshContent_Public_Void_Boolean_0;

		// Token: 0x040066F6 RID: 26358
		private static readonly IntPtr NativeMethodInfoPtr_PlayOrderSubmittedAnim_Public_Void_0;

		// Token: 0x040066F7 RID: 26359
		private static readonly IntPtr NativeMethodInfoPtr_CreateDeliveryStatusDisplay_Private_Void_DeliveryInstance_0;

		// Token: 0x040066F8 RID: 26360
		private static readonly IntPtr NativeMethodInfoPtr_DeliveryCompleted_Private_Void_DeliveryInstance_0;

		// Token: 0x040066F9 RID: 26361
		private static readonly IntPtr NativeMethodInfoPtr_SortStatusDisplays_Private_Void_0;

		// Token: 0x040066FA RID: 26362
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNoDeliveriesIndicator_Private_Void_0;

		// Token: 0x040066FB RID: 26363
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_GameObject_0;

		// Token: 0x040066FC RID: 26364
		private static readonly IntPtr NativeMethodInfoPtr_GetShop_Public_DeliveryShop_ShopInterface_0;

		// Token: 0x040066FD RID: 26365
		private static readonly IntPtr NativeMethodInfoPtr_GetShop_Public_DeliveryShop_String_0;

		// Token: 0x040066FE RID: 26366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B74 RID: 2932
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DB2C RID: 56108 RVA: 0x0033E83C File Offset: 0x0033CA3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr);
				DeliveryApp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, "<>9");
				DeliveryApp.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, "<>9__19_0");
				DeliveryApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, 100682169);
				DeliveryApp.__c.NativeMethodInfoPtr__SortStatusDisplays_b__19_0_Internal_Int32_DeliveryStatusDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, 100682170);
			}

			// Token: 0x0600DB2D RID: 56109 RVA: 0x0033E8B8 File Offset: 0x0033CAB8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB2E RID: 56110 RVA: 0x0033E8F4 File Offset: 0x0033CAF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272971, XrefRangeEnd = 272973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortStatusDisplays_b__19_0(DeliveryStatusDisplay d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c.NativeMethodInfoPtr__SortStatusDisplays_b__19_0_Internal_Int32_DeliveryStatusDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB2F RID: 56111 RVA: 0x0006AC1F File Offset: 0x00068E1F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043FE RID: 17406
			// (get) Token: 0x0600DB30 RID: 56112 RVA: 0x0033E944 File Offset: 0x0033CB44
			// (set) Token: 0x0600DB31 RID: 56113 RVA: 0x0006AC28 File Offset: 0x00068E28
			public unsafe static DeliveryApp.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeliveryApp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeliveryApp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043FF RID: 17407
			// (get) Token: 0x0600DB32 RID: 56114 RVA: 0x0033E96C File Offset: 0x0033CB6C
			// (set) Token: 0x0600DB33 RID: 56115 RVA: 0x0006AC3A File Offset: 0x00068E3A
			public unsafe static Func<DeliveryStatusDisplay, int> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeliveryApp.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeliveryStatusDisplay, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeliveryApp.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400930B RID: 37643
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400930C RID: 37644
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x0400930D RID: 37645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400930E RID: 37646
			private static readonly IntPtr NativeMethodInfoPtr__SortStatusDisplays_b__19_0_Internal_Int32_DeliveryStatusDisplay_0;
		}

		// Token: 0x02000B75 RID: 2933
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB34 RID: 56116 RVA: 0x0033E994 File Offset: 0x0033CB94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_keepScrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, "keepScrollPosition");
				DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_scrollPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, "scrollPos");
				DeliveryApp.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, 100682171);
				DeliveryApp.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, 100682172);
			}

			// Token: 0x0600DB35 RID: 56117 RVA: 0x0033EA24 File Offset: 0x0033CC24
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB36 RID: 56118 RVA: 0x0033EA60 File Offset: 0x0033CC60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272979, XrefRangeEnd = 272984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DB37 RID: 56119 RVA: 0x0006AC4C File Offset: 0x00068E4C
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004400 RID: 17408
			// (get) Token: 0x0600DB38 RID: 56120 RVA: 0x0033EAA0 File Offset: 0x0033CCA0
			// (set) Token: 0x0600DB39 RID: 56121 RVA: 0x0006AC55 File Offset: 0x00068E55
			public unsafe DeliveryApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004401 RID: 17409
			// (get) Token: 0x0600DB3A RID: 56122 RVA: 0x0033EAD0 File Offset: 0x0033CCD0
			// (set) Token: 0x0600DB3B RID: 56123 RVA: 0x0006AC74 File Offset: 0x00068E74
			public unsafe bool keepScrollPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_keepScrollPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_keepScrollPosition)) = value;
				}
			}

			// Token: 0x17004402 RID: 17410
			// (get) Token: 0x0600DB3C RID: 56124 RVA: 0x0033EAF8 File Offset: 0x0033CCF8
			// (set) Token: 0x0600DB3D RID: 56125 RVA: 0x0006AC8F File Offset: 0x00068E8F
			public unsafe float scrollPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_scrollPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_scrollPos)) = value;
				}
			}

			// Token: 0x0400930F RID: 37647
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009310 RID: 37648
			private static readonly IntPtr NativeFieldInfoPtr_keepScrollPosition;

			// Token: 0x04009311 RID: 37649
			private static readonly IntPtr NativeFieldInfoPtr_scrollPos;

			// Token: 0x04009312 RID: 37650
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009313 RID: 37651
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C7D RID: 3197
			[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass15_0+<<RefreshContent>g__Delay|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E630 RID: 58928 RVA: 0x0035E27C File Offset: 0x0035C47C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, "<<RefreshContent>g__Delay|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682173);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682174);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682175);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682176);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682177);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682178);
				}

				// Token: 0x0600E631 RID: 58929 RVA: 0x0035E35C File Offset: 0x0035C55C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E632 RID: 58930 RVA: 0x0035E3A4 File Offset: 0x0035C5A4
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E633 RID: 58931 RVA: 0x0035E3D8 File Offset: 0x0035C5D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272973, XrefRangeEnd = 272974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047A5 RID: 18341
				// (get) Token: 0x0600E634 RID: 58932 RVA: 0x0035E414 File Offset: 0x0035C614
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E635 RID: 58933 RVA: 0x0035E454 File Offset: 0x0035C654
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272974, XrefRangeEnd = 272979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047A6 RID: 18342
				// (get) Token: 0x0600E636 RID: 58934 RVA: 0x0035E488 File Offset: 0x0035C688
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E637 RID: 58935 RVA: 0x00070572 File Offset: 0x0006E772
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047A2 RID: 18338
				// (get) Token: 0x0600E638 RID: 58936 RVA: 0x0035E4C8 File Offset: 0x0035C6C8
				// (set) Token: 0x0600E639 RID: 58937 RVA: 0x0007057B File Offset: 0x0006E77B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047A3 RID: 18339
				// (get) Token: 0x0600E63A RID: 58938 RVA: 0x0035E4F0 File Offset: 0x0035C6F0
				// (set) Token: 0x0600E63B RID: 58939 RVA: 0x00070596 File Offset: 0x0006E796
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047A4 RID: 18340
				// (get) Token: 0x0600E63C RID: 58940 RVA: 0x0035E520 File Offset: 0x0035C720
				// (set) Token: 0x0600E63D RID: 58941 RVA: 0x000705B5 File Offset: 0x0006E7B5
				public unsafe DeliveryApp.__c__DisplayClass15_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp.__c__DisplayClass15_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040099DE RID: 39390
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040099DF RID: 39391
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040099E0 RID: 39392
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040099E1 RID: 39393
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040099E2 RID: 39394
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099E3 RID: 39395
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040099E4 RID: 39396
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040099E5 RID: 39397
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099E6 RID: 39398
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B76 RID: 2934
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB3E RID: 56126 RVA: 0x0033EB20 File Offset: 0x0033CD20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass18_0.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr, "instance");
				DeliveryApp.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr, 100682179);
				DeliveryApp.__c__DisplayClass18_0.NativeMethodInfoPtr__DeliveryCompleted_b__0_Internal_Boolean_DeliveryStatusDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr, 100682180);
			}

			// Token: 0x0600DB3F RID: 56127 RVA: 0x0033EB88 File Offset: 0x0033CD88
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB40 RID: 56128 RVA: 0x0033EBC4 File Offset: 0x0033CDC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272984, XrefRangeEnd = 272986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeliveryCompleted_b__0(DeliveryStatusDisplay d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass18_0.NativeMethodInfoPtr__DeliveryCompleted_b__0_Internal_Boolean_DeliveryStatusDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB41 RID: 56129 RVA: 0x0006ACAA File Offset: 0x00068EAA
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004403 RID: 17411
			// (get) Token: 0x0600DB42 RID: 56130 RVA: 0x0033EC14 File Offset: 0x0033CE14
			// (set) Token: 0x0600DB43 RID: 56131 RVA: 0x0006ACB3 File Offset: 0x00068EB3
			public unsafe DeliveryInstance instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass18_0.NativeFieldInfoPtr_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass18_0.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009314 RID: 37652
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x04009315 RID: 37653
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009316 RID: 37654
			private static readonly IntPtr NativeMethodInfoPtr__DeliveryCompleted_b__0_Internal_Boolean_DeliveryStatusDisplay_0;
		}

		// Token: 0x02000B77 RID: 2935
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB44 RID: 56132 RVA: 0x0033EC44 File Offset: 0x0033CE44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass22_0.NativeFieldInfoPtr_matchingShop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr, "matchingShop");
				DeliveryApp.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr, 100682181);
				DeliveryApp.__c__DisplayClass22_0.NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr, 100682182);
			}

			// Token: 0x0600DB45 RID: 56133 RVA: 0x0033ECAC File Offset: 0x0033CEAC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB46 RID: 56134 RVA: 0x0033ECE8 File Offset: 0x0033CEE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272986, XrefRangeEnd = 272991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetShop_b__0(DeliveryShop x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass22_0.NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB47 RID: 56135 RVA: 0x0006ACD2 File Offset: 0x00068ED2
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004404 RID: 17412
			// (get) Token: 0x0600DB48 RID: 56136 RVA: 0x0033ED38 File Offset: 0x0033CF38
			// (set) Token: 0x0600DB49 RID: 56137 RVA: 0x0006ACDB File Offset: 0x00068EDB
			public unsafe ShopInterface matchingShop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass22_0.NativeFieldInfoPtr_matchingShop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass22_0.NativeFieldInfoPtr_matchingShop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009317 RID: 37655
			private static readonly IntPtr NativeFieldInfoPtr_matchingShop;

			// Token: 0x04009318 RID: 37656
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009319 RID: 37657
			private static readonly IntPtr NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0;
		}

		// Token: 0x02000B78 RID: 2936
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB4A RID: 56138 RVA: 0x0033ED68 File Offset: 0x0033CF68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass23_0.NativeFieldInfoPtr_shopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr, "shopName");
				DeliveryApp.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr, 100682183);
				DeliveryApp.__c__DisplayClass23_0.NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr, 100682184);
			}

			// Token: 0x0600DB4B RID: 56139 RVA: 0x0033EDD0 File Offset: 0x0033CFD0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB4C RID: 56140 RVA: 0x0033EE0C File Offset: 0x0033D00C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272991, XrefRangeEnd = 272993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetShop_b__0(DeliveryShop x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass23_0.NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB4D RID: 56141 RVA: 0x0006ACFA File Offset: 0x00068EFA
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004405 RID: 17413
			// (get) Token: 0x0600DB4E RID: 56142 RVA: 0x0033EE5C File Offset: 0x0033D05C
			// (set) Token: 0x0600DB4F RID: 56143 RVA: 0x0006AD03 File Offset: 0x00068F03
			public unsafe string shopName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass23_0.NativeFieldInfoPtr_shopName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass23_0.NativeFieldInfoPtr_shopName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400931A RID: 37658
			private static readonly IntPtr NativeFieldInfoPtr_shopName;

			// Token: 0x0400931B RID: 37659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400931C RID: 37660
			private static readonly IntPtr NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0;
		}
	}
}
