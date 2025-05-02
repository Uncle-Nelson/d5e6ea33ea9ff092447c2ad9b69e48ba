using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Construction.Features;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x02000487 RID: 1159
	public class OptionListFeature : Feature
	{
		// Token: 0x0600648A RID: 25738 RVA: 0x001C6C0C File Offset: 0x001C4E0C
		// Note: this type is marked as 'beforefieldinit'.
		static OptionListFeature()
		{
			Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "OptionListFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr);
			OptionListFeature.NativeFieldInfoPtr_defaultOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "defaultOptionIndex");
			OptionListFeature.NativeFieldInfoPtr_ownedOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "ownedOptionIndex");
			OptionListFeature.NativeFieldInfoPtr_syncVar___ownedOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "syncVar___ownedOptionIndex");
			OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Construction.Features.OptionListFeatureAssembly-CSharp.dll_Excuted");
			OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Construction.Features.OptionListFeatureAssembly-CSharp.dll_Excuted");
			OptionListFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676032);
			OptionListFeature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676033);
			OptionListFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676034);
			OptionListFeature.NativeMethodInfoPtr_GetOptions_Protected_Abstract_Virtual_New_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676035);
			OptionListFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676036);
			OptionListFeature.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676037);
			OptionListFeature.NativeMethodInfoPtr_ReceiveData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676038);
			OptionListFeature.NativeMethodInfoPtr_PurchaseOption_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676039);
			OptionListFeature.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676040);
			OptionListFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676041);
			OptionListFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676042);
			OptionListFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676043);
			OptionListFeature.NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676044);
			OptionListFeature.NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676045);
			OptionListFeature.NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676046);
			OptionListFeature.NativeMethodInfoPtr_sync___get_value_ownedOptionIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676047);
			OptionListFeature.NativeMethodInfoPtr_sync___set_value_ownedOptionIndex_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676048);
			OptionListFeature.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_OptionListFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676049);
			OptionListFeature.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676050);
		}

		// Token: 0x0600648B RID: 25739 RVA: 0x001C6E1C File Offset: 0x001C501C
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600648C RID: 25740 RVA: 0x001C6E58 File Offset: 0x001C5058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204512, XrefRangeEnd = 204533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override FI_Base CreateInterface(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FI_Base>(intPtr3) : null;
		}

		// Token: 0x0600648D RID: 25741 RVA: 0x001C6EB4 File Offset: 0x001C50B4
		[CallerCount(0)]
		public unsafe override void Default()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600648E RID: 25742 RVA: 0x001C6EF0 File Offset: 0x001C50F0
		[CallerCount(0)]
		public unsafe virtual List<FI_OptionList.Option> GetOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_GetOptions_Protected_Abstract_Virtual_New_List_1_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FI_OptionList.Option>>(intPtr3) : null;
		}

		// Token: 0x0600648F RID: 25743 RVA: 0x001C6F3C File Offset: 0x001C513C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SelectOption(int optionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref optionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006490 RID: 25744 RVA: 0x001C6F88 File Offset: 0x001C5188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204533, XrefRangeEnd = 204556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetData(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006491 RID: 25745 RVA: 0x001C6FD4 File Offset: 0x001C51D4
		[CallerCount(0)]
		public unsafe void ReceiveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_ReceiveData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006492 RID: 25746 RVA: 0x001C7008 File Offset: 0x001C5208
		[CallerCount(0)]
		public unsafe virtual void PurchaseOption(int optionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref optionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_PurchaseOption_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006493 RID: 25747 RVA: 0x001C7054 File Offset: 0x001C5254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionListFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006494 RID: 25748 RVA: 0x001C7090 File Offset: 0x001C5290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204579, RefRangeEnd = 204581, XrefRangeStart = 204556, XrefRangeEnd = 204579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006495 RID: 25749 RVA: 0x001C70CC File Offset: 0x001C52CC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006496 RID: 25750 RVA: 0x001C7108 File Offset: 0x001C5308
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006497 RID: 25751 RVA: 0x001C7144 File Offset: 0x001C5344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204581, XrefRangeEnd = 204601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetData_3316948804(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006498 RID: 25752 RVA: 0x001C7184 File Offset: 0x001C5384
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204609, RefRangeEnd = 204611, XrefRangeStart = 204601, XrefRangeEnd = 204609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetData_3316948804(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x001C71D0 File Offset: 0x001C53D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204611, XrefRangeEnd = 204616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetData_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x0600649A RID: 25754 RVA: 0x001C7234 File Offset: 0x001C5434
		// (set) Token: 0x0600649B RID: 25755 RVA: 0x001C7270 File Offset: 0x001C5470
		public unsafe int SyncAccessor_ownedOptionIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_sync___get_value_ownedOptionIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 204624, RefRangeEnd = 204625, XrefRangeStart = 204616, XrefRangeEnd = 204624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_sync___set_value_ownedOptionIndex_Public_set_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600649C RID: 25756 RVA: 0x001C72BC File Offset: 0x001C54BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204625, XrefRangeEnd = 204630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Construction_Features_OptionListFeature(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_OptionListFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600649D RID: 25757 RVA: 0x001C7330 File Offset: 0x001C5530
		[CallerCount(0)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600649E RID: 25758 RVA: 0x0002F8FC File Offset: 0x0002DAFC
		public OptionListFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x0600649F RID: 25759 RVA: 0x001C736C File Offset: 0x001C556C
		// (set) Token: 0x060064A0 RID: 25760 RVA: 0x0002F905 File Offset: 0x0002DB05
		public unsafe int defaultOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_defaultOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_defaultOptionIndex)) = value;
			}
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x060064A1 RID: 25761 RVA: 0x001C7394 File Offset: 0x001C5594
		// (set) Token: 0x060064A2 RID: 25762 RVA: 0x0002F920 File Offset: 0x0002DB20
		public unsafe int ownedOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_ownedOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_ownedOptionIndex)) = value;
			}
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x060064A3 RID: 25763 RVA: 0x001C73BC File Offset: 0x001C55BC
		// (set) Token: 0x060064A4 RID: 25764 RVA: 0x0002F93B File Offset: 0x0002DB3B
		public unsafe SyncVar<int> syncVar___ownedOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_syncVar___ownedOptionIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_syncVar___ownedOptionIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x060064A5 RID: 25765 RVA: 0x001C73EC File Offset: 0x001C55EC
		// (set) Token: 0x060064A6 RID: 25766 RVA: 0x0002F95A File Offset: 0x0002DB5A
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x060064A7 RID: 25767 RVA: 0x001C7414 File Offset: 0x001C5614
		// (set) Token: 0x060064A8 RID: 25768 RVA: 0x0002F975 File Offset: 0x0002DB75
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004499 RID: 17561
		private static readonly IntPtr NativeFieldInfoPtr_defaultOptionIndex;

		// Token: 0x0400449A RID: 17562
		private static readonly IntPtr NativeFieldInfoPtr_ownedOptionIndex;

		// Token: 0x0400449B RID: 17563
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___ownedOptionIndex;

		// Token: 0x0400449C RID: 17564
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400449D RID: 17565
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400449E RID: 17566
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400449F RID: 17567
		private static readonly IntPtr NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0;

		// Token: 0x040044A0 RID: 17568
		private static readonly IntPtr NativeMethodInfoPtr_Default_Public_Virtual_Void_0;

		// Token: 0x040044A1 RID: 17569
		private static readonly IntPtr NativeMethodInfoPtr_GetOptions_Protected_Abstract_Virtual_New_List_1_Option_0;

		// Token: 0x040044A2 RID: 17570
		private static readonly IntPtr NativeMethodInfoPtr_SelectOption_Public_Virtual_New_Void_Int32_0;

		// Token: 0x040044A3 RID: 17571
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x040044A4 RID: 17572
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveData_Private_Void_0;

		// Token: 0x040044A5 RID: 17573
		private static readonly IntPtr NativeMethodInfoPtr_PurchaseOption_Public_Virtual_New_Void_Int32_0;

		// Token: 0x040044A6 RID: 17574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040044A7 RID: 17575
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040044A8 RID: 17576
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040044A9 RID: 17577
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040044AA RID: 17578
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0;

		// Token: 0x040044AB RID: 17579
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x040044AC RID: 17580
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040044AD RID: 17581
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_ownedOptionIndex_Public_get_Int32_0;

		// Token: 0x040044AE RID: 17582
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_ownedOptionIndex_Public_set_Void_Int32_Boolean_0;

		// Token: 0x040044AF RID: 17583
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_OptionListFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040044B0 RID: 17584
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
