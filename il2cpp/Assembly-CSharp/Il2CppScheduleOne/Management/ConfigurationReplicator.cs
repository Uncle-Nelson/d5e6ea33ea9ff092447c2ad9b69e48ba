using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000382 RID: 898
	public class ConfigurationReplicator : NetworkBehaviour
	{
		// Token: 0x06004618 RID: 17944 RVA: 0x001587E4 File Offset: 0x001569E4
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationReplicator()
		{
			Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ConfigurationReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr);
			ConfigurationReplicator.NativeFieldInfoPtr_Configuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "Configuration");
			ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted");
			ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted");
			ConfigurationReplicator.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671908);
			ConfigurationReplicator.NativeMethodInfoPtr_SendItemField_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671909);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveItemField_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671910);
			ConfigurationReplicator.NativeMethodInfoPtr_SendNPCField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671911);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNPCField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671912);
			ConfigurationReplicator.NativeMethodInfoPtr_SendObjectField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671913);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671914);
			ConfigurationReplicator.NativeMethodInfoPtr_SendObjectListField_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671915);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectListField_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671916);
			ConfigurationReplicator.NativeMethodInfoPtr_SendRecipeField_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671917);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRecipeField_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671918);
			ConfigurationReplicator.NativeMethodInfoPtr_SendNumberField_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671919);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNumberField_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671920);
			ConfigurationReplicator.NativeMethodInfoPtr_SendRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671921);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671922);
			ConfigurationReplicator.NativeMethodInfoPtr_SendQualityField_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671923);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveQualityField_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671924);
			ConfigurationReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671925);
			ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671926);
			ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671927);
			ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671928);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671929);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671930);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendItemField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671931);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671932);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671933);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveItemField_2801973956_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671934);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671935);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671936);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNPCField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671937);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671938);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671939);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNPCField_1687693739_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671940);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671941);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671942);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671943);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671944);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671945);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectField_1687693739_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671946);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671947);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671948);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectListField_690244341_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671949);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671950);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671951);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectListField_690244341_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671952);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671953);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671954);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRecipeField_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671955);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671956);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671957);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRecipeField_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671958);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671959);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671960);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNumberField_1293284375_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671961);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671962);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671963);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNumberField_1293284375_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671964);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671965);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671966);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRouteListField_3226448297_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671967);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671968);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671969);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRouteListField_3226448297_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671970);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671971);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671972);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendQualityField_3536682170_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671973);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671974);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671975);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQualityField_3536682170_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671976);
			ConfigurationReplicator.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671977);
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x00158DC8 File Offset: 0x00156FC8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 158291, RefRangeEnd = 158303, XrefRangeStart = 158073, XrefRangeEnd = 158291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateField(ConfigField field, NetworkConnection conn = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x00158E1C File Offset: 0x0015701C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158303, XrefRangeEnd = 158324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendItemField(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendItemField_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x00158E6C File Offset: 0x0015706C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158324, XrefRangeEnd = 158345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveItemField(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveItemField_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x00158EBC File Offset: 0x001570BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158345, XrefRangeEnd = 158366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNPCField(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendNPCField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x00158F0C File Offset: 0x0015710C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158366, XrefRangeEnd = 158387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveNPCField(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNPCField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x00158F5C File Offset: 0x0015715C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158387, XrefRangeEnd = 158408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendObjectField(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendObjectField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x00158FAC File Offset: 0x001571AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158408, XrefRangeEnd = 158429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveObjectField(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x00158FFC File Offset: 0x001571FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158429, XrefRangeEnd = 158450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendObjectListField_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x0015904C File Offset: 0x0015724C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158450, XrefRangeEnd = 158471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectListField_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x0015909C File Offset: 0x0015729C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158471, XrefRangeEnd = 158493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRecipeField(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendRecipeField_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x001590E8 File Offset: 0x001572E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158493, XrefRangeEnd = 158515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveRecipeField(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRecipeField_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x00159134 File Offset: 0x00157334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158515, XrefRangeEnd = 158536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNumberField(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendNumberField_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x00159180 File Offset: 0x00157380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158536, XrefRangeEnd = 158557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveNumberField(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNumberField_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x001591CC File Offset: 0x001573CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158557, XrefRangeEnd = 158578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRouteListField(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x0015921C File Offset: 0x0015741C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158578, XrefRangeEnd = 158599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveRouteListField(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x0015926C File Offset: 0x0015746C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158599, XrefRangeEnd = 158620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendQualityField(int fieldIndex, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendQualityField_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x001592B8 File Offset: 0x001574B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158620, XrefRangeEnd = 158641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveQualityField(int fieldIndex, EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveQualityField_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x00159304 File Offset: 0x00157504
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 134906, RefRangeEnd = 134928, XrefRangeStart = 134906, XrefRangeEnd = 134928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurationReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x00159340 File Offset: 0x00157540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158641, XrefRangeEnd = 158739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x0015937C File Offset: 0x0015757C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462D RID: 17965 RVA: 0x001593B8 File Offset: 0x001575B8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x001593F4 File Offset: 0x001575F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x00159444 File Offset: 0x00157644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x00159494 File Offset: 0x00157694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158739, XrefRangeEnd = 158755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendItemField_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendItemField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x001594F8 File Offset: 0x001576F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x00159548 File Offset: 0x00157748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158755, XrefRangeEnd = 158773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x00159598 File Offset: 0x00157798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158773, XrefRangeEnd = 158795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveItemField_2801973956(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveItemField_2801973956_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x001595E8 File Offset: 0x001577E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x00159638 File Offset: 0x00157838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x00159688 File Offset: 0x00157888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158795, XrefRangeEnd = 158811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendNPCField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNPCField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x001596EC File Offset: 0x001578EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x0015973C File Offset: 0x0015793C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158836, RefRangeEnd = 158837, XrefRangeStart = 158811, XrefRangeEnd = 158836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x0015978C File Offset: 0x0015798C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158837, XrefRangeEnd = 158842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveNPCField_1687693739(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNPCField_1687693739_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x001597DC File Offset: 0x001579DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x0015982C File Offset: 0x00157A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x0015987C File Offset: 0x00157A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158842, XrefRangeEnd = 158858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendObjectField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x001598E0 File Offset: 0x00157AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x00159930 File Offset: 0x00157B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158858, XrefRangeEnd = 158877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x00159980 File Offset: 0x00157B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158877, XrefRangeEnd = 158899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveObjectField_1687693739(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectField_1687693739_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x001599D0 File Offset: 0x00157BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x00159A20 File Offset: 0x00157C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x00159A70 File Offset: 0x00157C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158899, XrefRangeEnd = 158915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendObjectListField_690244341(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectListField_690244341_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x00159AD4 File Offset: 0x00157CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x00159B24 File Offset: 0x00157D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158944, RefRangeEnd = 158945, XrefRangeStart = 158915, XrefRangeEnd = 158944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x00159B74 File Offset: 0x00157D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158945, XrefRangeEnd = 158950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveObjectListField_690244341(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectListField_690244341_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x00159BC4 File Offset: 0x00157DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x00159C10 File Offset: 0x00157E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x00159C5C File Offset: 0x00157E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158950, XrefRangeEnd = 158968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRecipeField_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRecipeField_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x00159CC0 File Offset: 0x00157EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x00159D0C File Offset: 0x00157F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158968, XrefRangeEnd = 158983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x00159D58 File Offset: 0x00157F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158983, XrefRangeEnd = 159003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveRecipeField_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRecipeField_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x00159DA8 File Offset: 0x00157FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x00159DF4 File Offset: 0x00157FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x00159E40 File Offset: 0x00158040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159003, XrefRangeEnd = 159019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendNumberField_1293284375(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNumberField_1293284375_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x00159EA4 File Offset: 0x001580A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x00159EF0 File Offset: 0x001580F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159019, XrefRangeEnd = 159027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x00159F3C File Offset: 0x0015813C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159027, XrefRangeEnd = 159039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveNumberField_1293284375(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNumberField_1293284375_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x00159F8C File Offset: 0x0015818C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x00159FDC File Offset: 0x001581DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x0015A02C File Offset: 0x0015822C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159039, XrefRangeEnd = 159055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRouteListField_3226448297(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRouteListField_3226448297_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x0015A090 File Offset: 0x00158290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x0015A0E0 File Offset: 0x001582E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159088, RefRangeEnd = 159089, XrefRangeStart = 159055, XrefRangeEnd = 159088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x0015A130 File Offset: 0x00158330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159089, XrefRangeEnd = 159094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveRouteListField_3226448297(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRouteListField_3226448297_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x0015A180 File Offset: 0x00158380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x0015A1CC File Offset: 0x001583CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x0015A218 File Offset: 0x00158418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159094, XrefRangeEnd = 159110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendQualityField_3536682170(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendQualityField_3536682170_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x0015A27C File Offset: 0x0015847C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x0015A2C8 File Offset: 0x001584C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159110, XrefRangeEnd = 159118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x0015A314 File Offset: 0x00158514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159118, XrefRangeEnd = 159130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveQualityField_3536682170(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQualityField_3536682170_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x0015A364 File Offset: 0x00158564
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x00022268 File Offset: 0x00020468
		public ConfigurationReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06004660 RID: 18016 RVA: 0x0015A3A0 File Offset: 0x001585A0
		// (set) Token: 0x06004661 RID: 18017 RVA: 0x00022271 File Offset: 0x00020471
		public unsafe EntityConfiguration Configuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_Configuration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_Configuration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06004662 RID: 18018 RVA: 0x0015A3D0 File Offset: 0x001585D0
		// (set) Token: 0x06004663 RID: 18019 RVA: 0x00022290 File Offset: 0x00020490
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06004664 RID: 18020 RVA: 0x0015A3F8 File Offset: 0x001585F8
		// (set) Token: 0x06004665 RID: 18021 RVA: 0x000222AB File Offset: 0x000204AB
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002F09 RID: 12041
		private static readonly IntPtr NativeFieldInfoPtr_Configuration;

		// Token: 0x04002F0A RID: 12042
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002F0B RID: 12043
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002F0C RID: 12044
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0;

		// Token: 0x04002F0D RID: 12045
		private static readonly IntPtr NativeMethodInfoPtr_SendItemField_Private_Void_Int32_String_0;

		// Token: 0x04002F0E RID: 12046
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveItemField_Private_Void_Int32_String_0;

		// Token: 0x04002F0F RID: 12047
		private static readonly IntPtr NativeMethodInfoPtr_SendNPCField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F10 RID: 12048
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveNPCField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F11 RID: 12049
		private static readonly IntPtr NativeMethodInfoPtr_SendObjectField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F12 RID: 12050
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveObjectField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F13 RID: 12051
		private static readonly IntPtr NativeMethodInfoPtr_SendObjectListField_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002F14 RID: 12052
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveObjectListField_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002F15 RID: 12053
		private static readonly IntPtr NativeMethodInfoPtr_SendRecipeField_Private_Void_Int32_Int32_0;

		// Token: 0x04002F16 RID: 12054
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveRecipeField_Private_Void_Int32_Int32_0;

		// Token: 0x04002F17 RID: 12055
		private static readonly IntPtr NativeMethodInfoPtr_SendNumberField_Private_Void_Int32_Single_0;

		// Token: 0x04002F18 RID: 12056
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveNumberField_Private_Void_Int32_Single_0;

		// Token: 0x04002F19 RID: 12057
		private static readonly IntPtr NativeMethodInfoPtr_SendRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04002F1A RID: 12058
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04002F1B RID: 12059
		private static readonly IntPtr NativeMethodInfoPtr_SendQualityField_Private_Void_Int32_EQuality_0;

		// Token: 0x04002F1C RID: 12060
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveQualityField_Private_Void_Int32_EQuality_0;

		// Token: 0x04002F1D RID: 12061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002F1E RID: 12062
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002F1F RID: 12063
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002F20 RID: 12064
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002F21 RID: 12065
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002F22 RID: 12066
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002F23 RID: 12067
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendItemField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F24 RID: 12068
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002F25 RID: 12069
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002F26 RID: 12070
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveItemField_2801973956_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F27 RID: 12071
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F28 RID: 12072
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F29 RID: 12073
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendNPCField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F2A RID: 12074
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F2B RID: 12075
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F2C RID: 12076
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveNPCField_1687693739_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F2D RID: 12077
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F2E RID: 12078
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F2F RID: 12079
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendObjectField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F30 RID: 12080
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F31 RID: 12081
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F32 RID: 12082
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectField_1687693739_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F33 RID: 12083
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002F34 RID: 12084
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002F35 RID: 12085
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendObjectListField_690244341_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F36 RID: 12086
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002F37 RID: 12087
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002F38 RID: 12088
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectListField_690244341_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F39 RID: 12089
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04002F3A RID: 12090
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04002F3B RID: 12091
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRecipeField_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F3C RID: 12092
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04002F3D RID: 12093
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04002F3E RID: 12094
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveRecipeField_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F3F RID: 12095
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04002F40 RID: 12096
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04002F41 RID: 12097
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendNumberField_1293284375_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F42 RID: 12098
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04002F43 RID: 12099
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04002F44 RID: 12100
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveNumberField_1293284375_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F45 RID: 12101
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04002F46 RID: 12102
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04002F47 RID: 12103
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRouteListField_3226448297_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F48 RID: 12104
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04002F49 RID: 12105
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04002F4A RID: 12106
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveRouteListField_3226448297_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F4B RID: 12107
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x04002F4C RID: 12108
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x04002F4D RID: 12109
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendQualityField_3536682170_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F4E RID: 12110
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x04002F4F RID: 12111
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x04002F50 RID: 12112
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveQualityField_3536682170_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F51 RID: 12113
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000976 RID: 2422
		[ObfuscatedName("ScheduleOne.Management.ConfigurationReplicator+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600C9C2 RID: 51650 RVA: 0x0030D4DC File Offset: 0x0030B6DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr);
				ConfigurationReplicator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, "<>9");
				ConfigurationReplicator.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, "<>9__1_0");
				ConfigurationReplicator.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, "<>9__15_0");
				ConfigurationReplicator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, 100671979);
				ConfigurationReplicator.__c.NativeMethodInfoPtr__ReplicateField_b__1_0_Internal_AdvancedTransitRouteData_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, 100671980);
				ConfigurationReplicator.__c.NativeMethodInfoPtr__ReceiveRouteListField_b__15_0_Internal_AdvancedTransitRoute_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, 100671981);
			}

			// Token: 0x0600C9C3 RID: 51651 RVA: 0x0030D580 File Offset: 0x0030B780
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9C4 RID: 51652 RVA: 0x0030D5BC File Offset: 0x0030B7BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158067, XrefRangeEnd = 158069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdvancedTransitRouteData _ReplicateField_b__1_0(AdvancedTransitRoute x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c.NativeMethodInfoPtr__ReplicateField_b__1_0_Internal_AdvancedTransitRouteData_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRouteData>(intPtr3) : null;
			}

			// Token: 0x0600C9C5 RID: 51653 RVA: 0x0030D60C File Offset: 0x0030B80C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158069, XrefRangeEnd = 158073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdvancedTransitRoute _ReceiveRouteListField_b__15_0(AdvancedTransitRouteData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c.NativeMethodInfoPtr__ReceiveRouteListField_b__15_0_Internal_AdvancedTransitRoute_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRoute>(intPtr3) : null;
			}

			// Token: 0x0600C9C6 RID: 51654 RVA: 0x000621DA File Offset: 0x000603DA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EE7 RID: 16103
			// (get) Token: 0x0600C9C7 RID: 51655 RVA: 0x0030D65C File Offset: 0x0030B85C
			// (set) Token: 0x0600C9C8 RID: 51656 RVA: 0x000621E3 File Offset: 0x000603E3
			public unsafe static ConfigurationReplicator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EE8 RID: 16104
			// (get) Token: 0x0600C9C9 RID: 51657 RVA: 0x0030D684 File Offset: 0x0030B884
			// (set) Token: 0x0600C9CA RID: 51658 RVA: 0x000621F5 File Offset: 0x000603F5
			public unsafe static Func<AdvancedTransitRoute, AdvancedTransitRouteData> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AdvancedTransitRoute, AdvancedTransitRouteData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EE9 RID: 16105
			// (get) Token: 0x0600C9CB RID: 51659 RVA: 0x0030D6AC File Offset: 0x0030B8AC
			// (set) Token: 0x0600C9CC RID: 51660 RVA: 0x00062207 File Offset: 0x00060407
			public unsafe static Func<AdvancedTransitRouteData, AdvancedTransitRoute> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AdvancedTransitRouteData, AdvancedTransitRoute>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008887 RID: 34951
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008888 RID: 34952
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04008889 RID: 34953
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x0400888A RID: 34954
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400888B RID: 34955
			private static readonly IntPtr NativeMethodInfoPtr__ReplicateField_b__1_0_Internal_AdvancedTransitRouteData_AdvancedTransitRoute_0;

			// Token: 0x0400888C RID: 34956
			private static readonly IntPtr NativeMethodInfoPtr__ReceiveRouteListField_b__15_0_Internal_AdvancedTransitRoute_AdvancedTransitRouteData_0;
		}
	}
}
