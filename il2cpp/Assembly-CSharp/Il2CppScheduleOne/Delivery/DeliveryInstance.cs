using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x0200047A RID: 1146
	[Serializable]
	public class DeliveryInstance : Object
	{
		// Token: 0x06006304 RID: 25348 RVA: 0x001C1754 File Offset: 0x001BF954
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryInstance()
		{
			Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "DeliveryInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr);
			DeliveryInstance.NativeFieldInfoPtr_DeliveryID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "DeliveryID");
			DeliveryInstance.NativeFieldInfoPtr_StoreName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "StoreName");
			DeliveryInstance.NativeFieldInfoPtr_DestinationCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "DestinationCode");
			DeliveryInstance.NativeFieldInfoPtr_LoadingDockIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "LoadingDockIndex");
			DeliveryInstance.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "Items");
			DeliveryInstance.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "Status");
			DeliveryInstance.NativeFieldInfoPtr_TimeUntilArrival = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "TimeUntilArrival");
			DeliveryInstance.NativeFieldInfoPtr__ActiveVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "<ActiveVehicle>k__BackingField");
			DeliveryInstance.NativeFieldInfoPtr_onDeliveryCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "onDeliveryCompleted");
			DeliveryInstance.NativeMethodInfoPtr_get_ActiveVehicle_Public_get_DeliveryVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675842);
			DeliveryInstance.NativeMethodInfoPtr_set_ActiveVehicle_Private_set_Void_DeliveryVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675843);
			DeliveryInstance.NativeMethodInfoPtr_get_Destination_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675844);
			DeliveryInstance.NativeMethodInfoPtr_get_LoadingDock_Public_get_LoadingDock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675845);
			DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_EDeliveryStatus_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675846);
			DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675847);
			DeliveryInstance.NativeMethodInfoPtr_GetTimeStatus_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675848);
			DeliveryInstance.NativeMethodInfoPtr_SetStatus_Public_Void_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675849);
			DeliveryInstance.NativeMethodInfoPtr_AddItemsToDeliveryVehicle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675850);
			DeliveryInstance.NativeMethodInfoPtr_OnMinPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675851);
		}

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x06006305 RID: 25349 RVA: 0x001C1900 File Offset: 0x001BFB00
		// (set) Token: 0x06006306 RID: 25350 RVA: 0x001C1940 File Offset: 0x001BFB40
		public unsafe DeliveryVehicle ActiveVehicle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35358, RefRangeEnd = 35359, XrefRangeStart = 35358, XrefRangeEnd = 35359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_get_ActiveVehicle_Public_get_DeliveryVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_set_ActiveVehicle_Private_set_Void_DeliveryVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x06006307 RID: 25351 RVA: 0x001C1984 File Offset: 0x001BFB84
		public unsafe Property Destination
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 202995, RefRangeEnd = 203002, XrefRangeStart = 202989, XrefRangeEnd = 202995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_get_Destination_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x06006308 RID: 25352 RVA: 0x001C19C4 File Offset: 0x001BFBC4
		public unsafe LoadingDock LoadingDock
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203002, XrefRangeEnd = 203003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_get_LoadingDock_Public_get_LoadingDock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadingDock>(intPtr3) : null;
			}
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x001C1A04 File Offset: 0x001BFC04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203008, RefRangeEnd = 203009, XrefRangeStart = 203003, XrefRangeEnd = 203008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance(string deliveryID, string storeName, string destinationCode, int loadingDockIndex, Il2CppReferenceArray<StringIntPair> items, EDeliveryStatus status, int timeUntilArrival) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationCode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadingDockIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeUntilArrival;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_EDeliveryStatus_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600630A RID: 25354 RVA: 0x001C1AB0 File Offset: 0x001BFCB0
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600630B RID: 25355 RVA: 0x001C1AEC File Offset: 0x001BFCEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203009, RefRangeEnd = 203010, XrefRangeStart = 203009, XrefRangeEnd = 203009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTimeStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_GetTimeStatus_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600630C RID: 25356 RVA: 0x001C1B28 File Offset: 0x001BFD28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 203052, RefRangeEnd = 203055, XrefRangeStart = 203010, XrefRangeEnd = 203052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStatus(EDeliveryStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_SetStatus_Public_Void_EDeliveryStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x001C1B68 File Offset: 0x001BFD68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203064, RefRangeEnd = 203065, XrefRangeStart = 203055, XrefRangeEnd = 203064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItemsToDeliveryVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_AddItemsToDeliveryVehicle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600630E RID: 25358 RVA: 0x001C1B9C File Offset: 0x001BFD9C
		[CallerCount(0)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_OnMinPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600630F RID: 25359 RVA: 0x0002ED5F File Offset: 0x0002CF5F
		public DeliveryInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x06006310 RID: 25360 RVA: 0x001C1BD0 File Offset: 0x001BFDD0
		// (set) Token: 0x06006311 RID: 25361 RVA: 0x0002ED68 File Offset: 0x0002CF68
		public unsafe string DeliveryID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DeliveryID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DeliveryID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x06006312 RID: 25362 RVA: 0x001C1BF8 File Offset: 0x001BFDF8
		// (set) Token: 0x06006313 RID: 25363 RVA: 0x0002ED87 File Offset: 0x0002CF87
		public unsafe string StoreName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_StoreName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_StoreName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x06006314 RID: 25364 RVA: 0x001C1C20 File Offset: 0x001BFE20
		// (set) Token: 0x06006315 RID: 25365 RVA: 0x0002EDA6 File Offset: 0x0002CFA6
		public unsafe string DestinationCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DestinationCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DestinationCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x06006316 RID: 25366 RVA: 0x001C1C48 File Offset: 0x001BFE48
		// (set) Token: 0x06006317 RID: 25367 RVA: 0x0002EDC5 File Offset: 0x0002CFC5
		public unsafe int LoadingDockIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_LoadingDockIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_LoadingDockIndex)) = value;
			}
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x06006318 RID: 25368 RVA: 0x001C1C70 File Offset: 0x001BFE70
		// (set) Token: 0x06006319 RID: 25369 RVA: 0x0002EDE0 File Offset: 0x0002CFE0
		public unsafe Il2CppReferenceArray<StringIntPair> Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x0600631A RID: 25370 RVA: 0x001C1CA0 File Offset: 0x001BFEA0
		// (set) Token: 0x0600631B RID: 25371 RVA: 0x0002EDFF File Offset: 0x0002CFFF
		public unsafe EDeliveryStatus Status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Status)) = value;
			}
		}

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x0600631C RID: 25372 RVA: 0x001C1CC8 File Offset: 0x001BFEC8
		// (set) Token: 0x0600631D RID: 25373 RVA: 0x0002EE1A File Offset: 0x0002D01A
		public unsafe int TimeUntilArrival
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_TimeUntilArrival);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_TimeUntilArrival)) = value;
			}
		}

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x0600631E RID: 25374 RVA: 0x001C1CF0 File Offset: 0x001BFEF0
		// (set) Token: 0x0600631F RID: 25375 RVA: 0x0002EE35 File Offset: 0x0002D035
		public unsafe DeliveryVehicle _ActiveVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr__ActiveVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr__ActiveVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x06006320 RID: 25376 RVA: 0x001C1D20 File Offset: 0x001BFF20
		// (set) Token: 0x06006321 RID: 25377 RVA: 0x0002EE54 File Offset: 0x0002D054
		public unsafe UnityEvent onDeliveryCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_onDeliveryCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_onDeliveryCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400438D RID: 17293
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryID;

		// Token: 0x0400438E RID: 17294
		private static readonly IntPtr NativeFieldInfoPtr_StoreName;

		// Token: 0x0400438F RID: 17295
		private static readonly IntPtr NativeFieldInfoPtr_DestinationCode;

		// Token: 0x04004390 RID: 17296
		private static readonly IntPtr NativeFieldInfoPtr_LoadingDockIndex;

		// Token: 0x04004391 RID: 17297
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04004392 RID: 17298
		private static readonly IntPtr NativeFieldInfoPtr_Status;

		// Token: 0x04004393 RID: 17299
		private static readonly IntPtr NativeFieldInfoPtr_TimeUntilArrival;

		// Token: 0x04004394 RID: 17300
		private static readonly IntPtr NativeFieldInfoPtr__ActiveVehicle_k__BackingField;

		// Token: 0x04004395 RID: 17301
		private static readonly IntPtr NativeFieldInfoPtr_onDeliveryCompleted;

		// Token: 0x04004396 RID: 17302
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveVehicle_Public_get_DeliveryVehicle_0;

		// Token: 0x04004397 RID: 17303
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveVehicle_Private_set_Void_DeliveryVehicle_0;

		// Token: 0x04004398 RID: 17304
		private static readonly IntPtr NativeMethodInfoPtr_get_Destination_Public_get_Property_0;

		// Token: 0x04004399 RID: 17305
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadingDock_Public_get_LoadingDock_0;

		// Token: 0x0400439A RID: 17306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_EDeliveryStatus_Int32_0;

		// Token: 0x0400439B RID: 17307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400439C RID: 17308
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeStatus_Public_Int32_0;

		// Token: 0x0400439D RID: 17309
		private static readonly IntPtr NativeMethodInfoPtr_SetStatus_Public_Void_EDeliveryStatus_0;

		// Token: 0x0400439E RID: 17310
		private static readonly IntPtr NativeMethodInfoPtr_AddItemsToDeliveryVehicle_Public_Void_0;

		// Token: 0x0400439F RID: 17311
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Public_Void_0;
	}
}
