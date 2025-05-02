using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000413 RID: 1043
	[Serializable]
	public class DealGenerationEvent : Object
	{
		// Token: 0x06005B5F RID: 23391 RVA: 0x001A863C File Offset: 0x001A683C
		// Note: this type is marked as 'beforefieldinit'.
		static DealGenerationEvent()
		{
			Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DealGenerationEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr);
			DealGenerationEvent.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "Enabled");
			DealGenerationEvent.NativeFieldInfoPtr_CanBeAccepted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "CanBeAccepted");
			DealGenerationEvent.NativeFieldInfoPtr_CanBeRejected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "CanBeRejected");
			DealGenerationEvent.NativeFieldInfoPtr_ApplicableDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ApplicableDays");
			DealGenerationEvent.NativeFieldInfoPtr_GenerationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "GenerationTime");
			DealGenerationEvent.NativeFieldInfoPtr_GenerationWindowDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "GenerationWindowDuration");
			DealGenerationEvent.NativeFieldInfoPtr_ProductList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ProductList");
			DealGenerationEvent.NativeFieldInfoPtr_Payment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "Payment");
			DealGenerationEvent.NativeFieldInfoPtr_RelationshipRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "RelationshipRequirement");
			DealGenerationEvent.NativeFieldInfoPtr_RequestMessageChains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "RequestMessageChains");
			DealGenerationEvent.NativeFieldInfoPtr_ContractAcceptedResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ContractAcceptedResponses");
			DealGenerationEvent.NativeFieldInfoPtr_ContractRejectedResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ContractRejectedResponses");
			DealGenerationEvent.NativeFieldInfoPtr_DeliveryLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "DeliveryLocation");
			DealGenerationEvent.NativeFieldInfoPtr_PickupScheduleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "PickupScheduleGroup");
			DealGenerationEvent.NativeFieldInfoPtr_DeliveryWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "DeliveryWindow");
			DealGenerationEvent.NativeFieldInfoPtr_Expires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "Expires");
			DealGenerationEvent.NativeFieldInfoPtr_ExpiresAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ExpiresAfter");
			DealGenerationEvent.NativeMethodInfoPtr_GenerateContractInfo_Public_ContractInfo_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674963);
			DealGenerationEvent.NativeMethodInfoPtr_ShouldGenerate_Public_Boolean_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674964);
			DealGenerationEvent.NativeMethodInfoPtr_GetRandomRequestMessage_Public_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674965);
			DealGenerationEvent.NativeMethodInfoPtr_ProcessMessage_Public_MessageChain_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674966);
			DealGenerationEvent.NativeMethodInfoPtr_GetRejectionMessage_Public_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674967);
			DealGenerationEvent.NativeMethodInfoPtr_GetAcceptanceMessage_Public_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674968);
			DealGenerationEvent.NativeMethodInfoPtr_GetProductStringList_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674969);
			DealGenerationEvent.NativeMethodInfoPtr_GetQualityString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674970);
			DealGenerationEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674971);
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x001A8874 File Offset: 0x001A6A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193434, XrefRangeEnd = 193439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractInfo GenerateContractInfo(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GenerateContractInfo_Public_ContractInfo_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr3) : null;
		}

		// Token: 0x06005B61 RID: 23393 RVA: 0x001A88C4 File Offset: 0x001A6AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193439, XrefRangeEnd = 193462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldGenerate(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_ShouldGenerate_Public_Boolean_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B62 RID: 23394 RVA: 0x001A8914 File Offset: 0x001A6B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193462, XrefRangeEnd = 193466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain GetRandomRequestMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetRandomRequestMessage_Public_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x001A8954 File Offset: 0x001A6B54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193517, RefRangeEnd = 193520, XrefRangeStart = 193466, XrefRangeEnd = 193517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain ProcessMessage(MessageChain messageChain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_ProcessMessage_Public_MessageChain_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x001A89A4 File Offset: 0x001A6BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193520, XrefRangeEnd = 193524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain GetRejectionMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetRejectionMessage_Public_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x06005B65 RID: 23397 RVA: 0x001A89E4 File Offset: 0x001A6BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193524, XrefRangeEnd = 193528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain GetAcceptanceMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetAcceptanceMessage_Public_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x06005B66 RID: 23398 RVA: 0x001A8A24 File Offset: 0x001A6C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193528, XrefRangeEnd = 193530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetProductStringList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetProductStringList_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005B67 RID: 23399 RVA: 0x001A8A5C File Offset: 0x001A6C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193530, XrefRangeEnd = 193532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetQualityString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetQualityString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x001A8A94 File Offset: 0x001A6C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193532, XrefRangeEnd = 193540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealGenerationEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x0002B108 File Offset: 0x00029308
		public DealGenerationEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x06005B6A RID: 23402 RVA: 0x001A8AD0 File Offset: 0x001A6CD0
		// (set) Token: 0x06005B6B RID: 23403 RVA: 0x0002B111 File Offset: 0x00029311
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x06005B6C RID: 23404 RVA: 0x001A8AF8 File Offset: 0x001A6CF8
		// (set) Token: 0x06005B6D RID: 23405 RVA: 0x0002B12C File Offset: 0x0002932C
		public unsafe bool CanBeAccepted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_CanBeAccepted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_CanBeAccepted)) = value;
			}
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x06005B6E RID: 23406 RVA: 0x001A8B20 File Offset: 0x001A6D20
		// (set) Token: 0x06005B6F RID: 23407 RVA: 0x0002B147 File Offset: 0x00029347
		public unsafe bool CanBeRejected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_CanBeRejected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_CanBeRejected)) = value;
			}
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x06005B70 RID: 23408 RVA: 0x001A8B48 File Offset: 0x001A6D48
		// (set) Token: 0x06005B71 RID: 23409 RVA: 0x0002B162 File Offset: 0x00029362
		public unsafe List<DealGenerationEvent.DayContainer> ApplicableDays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ApplicableDays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DealGenerationEvent.DayContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ApplicableDays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x06005B72 RID: 23410 RVA: 0x001A8B78 File Offset: 0x001A6D78
		// (set) Token: 0x06005B73 RID: 23411 RVA: 0x0002B181 File Offset: 0x00029381
		public unsafe int GenerationTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_GenerationTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_GenerationTime)) = value;
			}
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x06005B74 RID: 23412 RVA: 0x001A8BA0 File Offset: 0x001A6DA0
		// (set) Token: 0x06005B75 RID: 23413 RVA: 0x0002B19C File Offset: 0x0002939C
		public unsafe int GenerationWindowDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_GenerationWindowDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_GenerationWindowDuration)) = value;
			}
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x06005B76 RID: 23414 RVA: 0x001A8BC8 File Offset: 0x001A6DC8
		// (set) Token: 0x06005B77 RID: 23415 RVA: 0x0002B1B7 File Offset: 0x000293B7
		public unsafe ProductList ProductList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ProductList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ProductList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x06005B78 RID: 23416 RVA: 0x001A8BF8 File Offset: 0x001A6DF8
		// (set) Token: 0x06005B79 RID: 23417 RVA: 0x0002B1D6 File Offset: 0x000293D6
		public unsafe float Payment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Payment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Payment)) = value;
			}
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x06005B7A RID: 23418 RVA: 0x001A8C20 File Offset: 0x001A6E20
		// (set) Token: 0x06005B7B RID: 23419 RVA: 0x0002B1F1 File Offset: 0x000293F1
		public unsafe float RelationshipRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_RelationshipRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_RelationshipRequirement)) = value;
			}
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06005B7C RID: 23420 RVA: 0x001A8C48 File Offset: 0x001A6E48
		// (set) Token: 0x06005B7D RID: 23421 RVA: 0x0002B20C File Offset: 0x0002940C
		public unsafe Il2CppReferenceArray<MessageChain> RequestMessageChains
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_RequestMessageChains);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MessageChain>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_RequestMessageChains), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06005B7E RID: 23422 RVA: 0x001A8C78 File Offset: 0x001A6E78
		// (set) Token: 0x06005B7F RID: 23423 RVA: 0x0002B22B File Offset: 0x0002942B
		public unsafe Il2CppReferenceArray<MessageChain> ContractAcceptedResponses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ContractAcceptedResponses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MessageChain>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ContractAcceptedResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06005B80 RID: 23424 RVA: 0x001A8CA8 File Offset: 0x001A6EA8
		// (set) Token: 0x06005B81 RID: 23425 RVA: 0x0002B24A File Offset: 0x0002944A
		public unsafe Il2CppReferenceArray<MessageChain> ContractRejectedResponses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ContractRejectedResponses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MessageChain>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ContractRejectedResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x06005B82 RID: 23426 RVA: 0x001A8CD8 File Offset: 0x001A6ED8
		// (set) Token: 0x06005B83 RID: 23427 RVA: 0x0002B269 File Offset: 0x00029469
		public unsafe DeliveryLocation DeliveryLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_DeliveryLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_DeliveryLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x06005B84 RID: 23428 RVA: 0x001A8D08 File Offset: 0x001A6F08
		// (set) Token: 0x06005B85 RID: 23429 RVA: 0x0002B288 File Offset: 0x00029488
		public unsafe int PickupScheduleGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_PickupScheduleGroup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_PickupScheduleGroup)) = value;
			}
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06005B86 RID: 23430 RVA: 0x001A8D30 File Offset: 0x001A6F30
		// (set) Token: 0x06005B87 RID: 23431 RVA: 0x0002B2A3 File Offset: 0x000294A3
		public unsafe QuestWindowConfig DeliveryWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_DeliveryWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_DeliveryWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x06005B88 RID: 23432 RVA: 0x001A8D60 File Offset: 0x001A6F60
		// (set) Token: 0x06005B89 RID: 23433 RVA: 0x0002B2C2 File Offset: 0x000294C2
		public unsafe bool Expires
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Expires);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Expires)) = value;
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06005B8A RID: 23434 RVA: 0x001A8D88 File Offset: 0x001A6F88
		// (set) Token: 0x06005B8B RID: 23435 RVA: 0x0002B2DD File Offset: 0x000294DD
		public unsafe int ExpiresAfter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ExpiresAfter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ExpiresAfter)) = value;
			}
		}

		// Token: 0x04003E78 RID: 15992
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04003E79 RID: 15993
		private static readonly IntPtr NativeFieldInfoPtr_CanBeAccepted;

		// Token: 0x04003E7A RID: 15994
		private static readonly IntPtr NativeFieldInfoPtr_CanBeRejected;

		// Token: 0x04003E7B RID: 15995
		private static readonly IntPtr NativeFieldInfoPtr_ApplicableDays;

		// Token: 0x04003E7C RID: 15996
		private static readonly IntPtr NativeFieldInfoPtr_GenerationTime;

		// Token: 0x04003E7D RID: 15997
		private static readonly IntPtr NativeFieldInfoPtr_GenerationWindowDuration;

		// Token: 0x04003E7E RID: 15998
		private static readonly IntPtr NativeFieldInfoPtr_ProductList;

		// Token: 0x04003E7F RID: 15999
		private static readonly IntPtr NativeFieldInfoPtr_Payment;

		// Token: 0x04003E80 RID: 16000
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipRequirement;

		// Token: 0x04003E81 RID: 16001
		private static readonly IntPtr NativeFieldInfoPtr_RequestMessageChains;

		// Token: 0x04003E82 RID: 16002
		private static readonly IntPtr NativeFieldInfoPtr_ContractAcceptedResponses;

		// Token: 0x04003E83 RID: 16003
		private static readonly IntPtr NativeFieldInfoPtr_ContractRejectedResponses;

		// Token: 0x04003E84 RID: 16004
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryLocation;

		// Token: 0x04003E85 RID: 16005
		private static readonly IntPtr NativeFieldInfoPtr_PickupScheduleGroup;

		// Token: 0x04003E86 RID: 16006
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryWindow;

		// Token: 0x04003E87 RID: 16007
		private static readonly IntPtr NativeFieldInfoPtr_Expires;

		// Token: 0x04003E88 RID: 16008
		private static readonly IntPtr NativeFieldInfoPtr_ExpiresAfter;

		// Token: 0x04003E89 RID: 16009
		private static readonly IntPtr NativeMethodInfoPtr_GenerateContractInfo_Public_ContractInfo_Customer_0;

		// Token: 0x04003E8A RID: 16010
		private static readonly IntPtr NativeMethodInfoPtr_ShouldGenerate_Public_Boolean_Customer_0;

		// Token: 0x04003E8B RID: 16011
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomRequestMessage_Public_MessageChain_0;

		// Token: 0x04003E8C RID: 16012
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessage_Public_MessageChain_MessageChain_0;

		// Token: 0x04003E8D RID: 16013
		private static readonly IntPtr NativeMethodInfoPtr_GetRejectionMessage_Public_MessageChain_0;

		// Token: 0x04003E8E RID: 16014
		private static readonly IntPtr NativeMethodInfoPtr_GetAcceptanceMessage_Public_MessageChain_0;

		// Token: 0x04003E8F RID: 16015
		private static readonly IntPtr NativeMethodInfoPtr_GetProductStringList_Public_String_0;

		// Token: 0x04003E90 RID: 16016
		private static readonly IntPtr NativeMethodInfoPtr_GetQualityString_Public_String_0;

		// Token: 0x04003E91 RID: 16017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009EA RID: 2538
		[Serializable]
		public class DayContainer : Object
		{
			// Token: 0x0600CD90 RID: 52624 RVA: 0x00318200 File Offset: 0x00316400
			// Note: this type is marked as 'beforefieldinit'.
			static DayContainer()
			{
				Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "DayContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr);
				DealGenerationEvent.DayContainer.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr, "Day");
				DealGenerationEvent.DayContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr, 100674972);
			}

			// Token: 0x0600CD91 RID: 52625 RVA: 0x00318254 File Offset: 0x00316454
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DayContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.DayContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD92 RID: 52626 RVA: 0x00063F96 File Offset: 0x00062196
			public DayContainer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FFB RID: 16379
			// (get) Token: 0x0600CD93 RID: 52627 RVA: 0x00318290 File Offset: 0x00316490
			// (set) Token: 0x0600CD94 RID: 52628 RVA: 0x00063F9F File Offset: 0x0006219F
			public unsafe EDay Day
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.DayContainer.NativeFieldInfoPtr_Day);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.DayContainer.NativeFieldInfoPtr_Day)) = value;
				}
			}

			// Token: 0x04008ADC RID: 35548
			private static readonly IntPtr NativeFieldInfoPtr_Day;

			// Token: 0x04008ADD RID: 35549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009EB RID: 2539
		[ObfuscatedName("ScheduleOne.Economy.DealGenerationEvent+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600CD95 RID: 52629 RVA: 0x003182B8 File Offset: 0x003164B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr);
				DealGenerationEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr, "<>9");
				DealGenerationEvent.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr, "<>9__19_0");
				DealGenerationEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr, 100674974);
				DealGenerationEvent.__c.NativeMethodInfoPtr__ShouldGenerate_b__19_0_Internal_Boolean_DayContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr, 100674975);
			}

			// Token: 0x0600CD96 RID: 52630 RVA: 0x00318334 File Offset: 0x00316534
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD97 RID: 52631 RVA: 0x00318370 File Offset: 0x00316570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193429, XrefRangeEnd = 193434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShouldGenerate_b__19_0(DealGenerationEvent.DayContainer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.__c.NativeMethodInfoPtr__ShouldGenerate_b__19_0_Internal_Boolean_DayContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD98 RID: 52632 RVA: 0x00063FBA File Offset: 0x000621BA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FFC RID: 16380
			// (get) Token: 0x0600CD99 RID: 52633 RVA: 0x003183C0 File Offset: 0x003165C0
			// (set) Token: 0x0600CD9A RID: 52634 RVA: 0x00063FC3 File Offset: 0x000621C3
			public unsafe static DealGenerationEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealGenerationEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealGenerationEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealGenerationEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FFD RID: 16381
			// (get) Token: 0x0600CD9B RID: 52635 RVA: 0x003183E8 File Offset: 0x003165E8
			// (set) Token: 0x0600CD9C RID: 52636 RVA: 0x00063FD5 File Offset: 0x000621D5
			public unsafe static Predicate<DealGenerationEvent.DayContainer> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealGenerationEvent.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<DealGenerationEvent.DayContainer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealGenerationEvent.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ADE RID: 35550
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008ADF RID: 35551
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04008AE0 RID: 35552
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AE1 RID: 35553
			private static readonly IntPtr NativeMethodInfoPtr__ShouldGenerate_b__19_0_Internal_Boolean_DayContainer_0;
		}
	}
}
