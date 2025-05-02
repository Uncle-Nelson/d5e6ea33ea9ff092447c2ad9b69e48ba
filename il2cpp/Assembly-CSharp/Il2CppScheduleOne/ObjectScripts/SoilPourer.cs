using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000757 RID: 1879
	public class SoilPourer : GridItem
	{
		// Token: 0x0600B2A7 RID: 45735 RVA: 0x002C8FCC File Offset: 0x002C71CC
		// Note: this type is marked as 'beforefieldinit'.
		static SoilPourer()
		{
			Il2CppClassPointerStore<SoilPourer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "SoilPourer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr);
			SoilPourer.NativeFieldInfoPtr__SoilID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "<SoilID>k__BackingField");
			SoilPourer.NativeFieldInfoPtr_AnimationDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "AnimationDuration");
			SoilPourer.NativeFieldInfoPtr_HandleIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "HandleIntObj");
			SoilPourer.NativeFieldInfoPtr_FillIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "FillIntObj");
			SoilPourer.NativeFieldInfoPtr_DirtPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "DirtPlane");
			SoilPourer.NativeFieldInfoPtr_Dirt_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "Dirt_Min");
			SoilPourer.NativeFieldInfoPtr_Dirt_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "Dirt_Max");
			SoilPourer.NativeFieldInfoPtr_PourParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "PourParticles");
			SoilPourer.NativeFieldInfoPtr_PourAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "PourAnimation");
			SoilPourer.NativeFieldInfoPtr_FillSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "FillSound");
			SoilPourer.NativeFieldInfoPtr_ActivateSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "ActivateSound");
			SoilPourer.NativeFieldInfoPtr_DirtPourSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "DirtPourSound");
			SoilPourer.NativeFieldInfoPtr_isDispensing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "isDispensing");
			SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted");
			SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted");
			SoilPourer.NativeMethodInfoPtr_get_SoilID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685314);
			SoilPourer.NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685315);
			SoilPourer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685316);
			SoilPourer.NativeMethodInfoPtr_HandleHovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685317);
			SoilPourer.NativeMethodInfoPtr_HandleInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685318);
			SoilPourer.NativeMethodInfoPtr_SendPourSoil_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685319);
			SoilPourer.NativeMethodInfoPtr_PourSoil_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685320);
			SoilPourer.NativeMethodInfoPtr_ApplySoil_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685321);
			SoilPourer.NativeMethodInfoPtr_FillHovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685322);
			SoilPourer.NativeMethodInfoPtr_FillInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685323);
			SoilPourer.NativeMethodInfoPtr_SendSoil_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685324);
			SoilPourer.NativeMethodInfoPtr_SetSoil_Protected_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685325);
			SoilPourer.NativeMethodInfoPtr_SetSoilLevel_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685326);
			SoilPourer.NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685327);
			SoilPourer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685328);
			SoilPourer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685329);
			SoilPourer.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685330);
			SoilPourer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685331);
			SoilPourer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685332);
			SoilPourer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685333);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Server_SendPourSoil_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685334);
			SoilPourer.NativeMethodInfoPtr_RpcLogic___SendPourSoil_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685335);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Server_SendPourSoil_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685336);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Observers_PourSoil_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685337);
			SoilPourer.NativeMethodInfoPtr_RpcLogic___PourSoil_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685338);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Observers_PourSoil_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685339);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Server_SendSoil_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685340);
			SoilPourer.NativeMethodInfoPtr_RpcLogic___SendSoil_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685341);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Server_SendSoil_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685342);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Observers_SetSoil_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685343);
			SoilPourer.NativeMethodInfoPtr_RpcLogic___SetSoil_2971853958_Protected_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685344);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Observers_SetSoil_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685345);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Target_SetSoil_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685346);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Target_SetSoil_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685347);
			SoilPourer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685348);
		}

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x0600B2A8 RID: 45736 RVA: 0x002C93E4 File Offset: 0x002C75E4
		// (set) Token: 0x0600B2A9 RID: 45737 RVA: 0x002C941C File Offset: 0x002C761C
		public unsafe string SoilID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_get_SoilID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B2AA RID: 45738 RVA: 0x002C9460 File Offset: 0x002C7660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307822, XrefRangeEnd = 307831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AB RID: 45739 RVA: 0x002C94B0 File Offset: 0x002C76B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307831, XrefRangeEnd = 307835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_HandleHovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AC RID: 45740 RVA: 0x002C94E4 File Offset: 0x002C76E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307835, XrefRangeEnd = 307856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_HandleInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AD RID: 45741 RVA: 0x002C9518 File Offset: 0x002C7718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307856, XrefRangeEnd = 307877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPourSoil()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_SendPourSoil_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AE RID: 45742 RVA: 0x002C954C File Offset: 0x002C774C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307898, RefRangeEnd = 307901, XrefRangeStart = 307877, XrefRangeEnd = 307898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PourSoil()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_PourSoil_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x002C9580 File Offset: 0x002C7780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307901, XrefRangeEnd = 307914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySoil(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_ApplySoil_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2B0 RID: 45744 RVA: 0x002C95C4 File Offset: 0x002C77C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307914, XrefRangeEnd = 307932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_FillHovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2B1 RID: 45745 RVA: 0x002C95F8 File Offset: 0x002C77F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307932, XrefRangeEnd = 307976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_FillInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2B2 RID: 45746 RVA: 0x002C962C File Offset: 0x002C782C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307998, RefRangeEnd = 307999, XrefRangeStart = 307976, XrefRangeEnd = 307998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendSoil(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_SendSoil_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2B3 RID: 45747 RVA: 0x002C9670 File Offset: 0x002C7870
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 308041, RefRangeEnd = 308045, XrefRangeStart = 307999, XrefRangeEnd = 308041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSoil(NetworkConnection conn, string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_SetSoil_Protected_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2B4 RID: 45748 RVA: 0x002C96C4 File Offset: 0x002C78C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308053, RefRangeEnd = 308055, XrefRangeStart = 308045, XrefRangeEnd = 308053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSoilLevel(float level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_SetSoilLevel_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2B5 RID: 45749 RVA: 0x002C9704 File Offset: 0x002C7904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308055, XrefRangeEnd = 308114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<Pot> GetPots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr3) : null;
		}

		// Token: 0x0600B2B6 RID: 45750 RVA: 0x002C9750 File Offset: 0x002C7950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308114, XrefRangeEnd = 308119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B2B7 RID: 45751 RVA: 0x002C9794 File Offset: 0x002C7994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308119, XrefRangeEnd = 308123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilPourer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2B8 RID: 45752 RVA: 0x002C97D0 File Offset: 0x002C79D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308123, XrefRangeEnd = 308128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B2B9 RID: 45753 RVA: 0x002C9810 File Offset: 0x002C7A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308128, XrefRangeEnd = 308161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2BA RID: 45754 RVA: 0x002C984C File Offset: 0x002C7A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308161, XrefRangeEnd = 308162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2BB RID: 45755 RVA: 0x002C9888 File Offset: 0x002C7A88
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x002C98C4 File Offset: 0x002C7AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308162, XrefRangeEnd = 308180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPourSoil_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Server_SendPourSoil_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2BD RID: 45757 RVA: 0x002C98F8 File Offset: 0x002C7AF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307898, RefRangeEnd = 307901, XrefRangeStart = 307898, XrefRangeEnd = 307901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPourSoil_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcLogic___SendPourSoil_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2BE RID: 45758 RVA: 0x002C992C File Offset: 0x002C7B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308180, XrefRangeEnd = 308183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPourSoil_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Server_SendPourSoil_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2BF RID: 45759 RVA: 0x002C9990 File Offset: 0x002C7B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308183, XrefRangeEnd = 308201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PourSoil_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Observers_PourSoil_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C0 RID: 45760 RVA: 0x002C99C4 File Offset: 0x002C7BC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 308207, RefRangeEnd = 308210, XrefRangeStart = 308201, XrefRangeEnd = 308207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PourSoil_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcLogic___PourSoil_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C1 RID: 45761 RVA: 0x002C99F8 File Offset: 0x002C7BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308210, XrefRangeEnd = 308213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PourSoil_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Observers_PourSoil_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C2 RID: 45762 RVA: 0x002C9A48 File Offset: 0x002C7C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308213, XrefRangeEnd = 308232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendSoil_3615296227(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Server_SendSoil_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C3 RID: 45763 RVA: 0x002C9A8C File Offset: 0x002C7C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308232, XrefRangeEnd = 308233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendSoil_3615296227(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcLogic___SendSoil_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C4 RID: 45764 RVA: 0x002C9AD0 File Offset: 0x002C7CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308233, XrefRangeEnd = 308237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendSoil_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Server_SendSoil_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C5 RID: 45765 RVA: 0x002C9B34 File Offset: 0x002C7D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308237, XrefRangeEnd = 308256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSoil_2971853958(NetworkConnection conn, string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Observers_SetSoil_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C6 RID: 45766 RVA: 0x002C9B88 File Offset: 0x002C7D88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 308265, RefRangeEnd = 308268, XrefRangeStart = 308256, XrefRangeEnd = 308265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSoil_2971853958(NetworkConnection conn, string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcLogic___SetSoil_2971853958_Protected_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C7 RID: 45767 RVA: 0x002C9BDC File Offset: 0x002C7DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308268, XrefRangeEnd = 308272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSoil_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Observers_SetSoil_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C8 RID: 45768 RVA: 0x002C9C2C File Offset: 0x002C7E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308272, XrefRangeEnd = 308291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSoil_2971853958(NetworkConnection conn, string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Target_SetSoil_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C9 RID: 45769 RVA: 0x002C9C80 File Offset: 0x002C7E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308291, XrefRangeEnd = 308295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSoil_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Target_SetSoil_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2CA RID: 45770 RVA: 0x002C9CD0 File Offset: 0x002C7ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291098, RefRangeEnd = 291099, XrefRangeStart = 291098, XrefRangeEnd = 291099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2CB RID: 45771 RVA: 0x000579E3 File Offset: 0x00055BE3
		public SoilPourer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x0600B2CC RID: 45772 RVA: 0x002C9D0C File Offset: 0x002C7F0C
		// (set) Token: 0x0600B2CD RID: 45773 RVA: 0x000579EC File Offset: 0x00055BEC
		public unsafe string _SoilID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr__SoilID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr__SoilID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x0600B2CE RID: 45774 RVA: 0x002C9D34 File Offset: 0x002C7F34
		// (set) Token: 0x0600B2CF RID: 45775 RVA: 0x00057A0B File Offset: 0x00055C0B
		public unsafe float AnimationDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_AnimationDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_AnimationDuration)) = value;
			}
		}

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x0600B2D0 RID: 45776 RVA: 0x002C9D5C File Offset: 0x002C7F5C
		// (set) Token: 0x0600B2D1 RID: 45777 RVA: 0x00057A26 File Offset: 0x00055C26
		public unsafe InteractableObject HandleIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_HandleIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_HandleIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003770 RID: 14192
		// (get) Token: 0x0600B2D2 RID: 45778 RVA: 0x002C9D8C File Offset: 0x002C7F8C
		// (set) Token: 0x0600B2D3 RID: 45779 RVA: 0x00057A45 File Offset: 0x00055C45
		public unsafe InteractableObject FillIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_FillIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_FillIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x0600B2D4 RID: 45780 RVA: 0x002C9DBC File Offset: 0x002C7FBC
		// (set) Token: 0x0600B2D5 RID: 45781 RVA: 0x00057A64 File Offset: 0x00055C64
		public unsafe MeshRenderer DirtPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_DirtPlane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_DirtPlane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x0600B2D6 RID: 45782 RVA: 0x002C9DEC File Offset: 0x002C7FEC
		// (set) Token: 0x0600B2D7 RID: 45783 RVA: 0x00057A83 File Offset: 0x00055C83
		public unsafe Transform Dirt_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_Dirt_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_Dirt_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003773 RID: 14195
		// (get) Token: 0x0600B2D8 RID: 45784 RVA: 0x002C9E1C File Offset: 0x002C801C
		// (set) Token: 0x0600B2D9 RID: 45785 RVA: 0x00057AA2 File Offset: 0x00055CA2
		public unsafe Transform Dirt_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_Dirt_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_Dirt_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003774 RID: 14196
		// (get) Token: 0x0600B2DA RID: 45786 RVA: 0x002C9E4C File Offset: 0x002C804C
		// (set) Token: 0x0600B2DB RID: 45787 RVA: 0x00057AC1 File Offset: 0x00055CC1
		public unsafe ParticleSystem PourParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_PourParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_PourParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003775 RID: 14197
		// (get) Token: 0x0600B2DC RID: 45788 RVA: 0x002C9E7C File Offset: 0x002C807C
		// (set) Token: 0x0600B2DD RID: 45789 RVA: 0x00057AE0 File Offset: 0x00055CE0
		public unsafe Animation PourAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_PourAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_PourAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003776 RID: 14198
		// (get) Token: 0x0600B2DE RID: 45790 RVA: 0x002C9EAC File Offset: 0x002C80AC
		// (set) Token: 0x0600B2DF RID: 45791 RVA: 0x00057AFF File Offset: 0x00055CFF
		public unsafe AudioSourceController FillSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_FillSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_FillSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003777 RID: 14199
		// (get) Token: 0x0600B2E0 RID: 45792 RVA: 0x002C9EDC File Offset: 0x002C80DC
		// (set) Token: 0x0600B2E1 RID: 45793 RVA: 0x00057B1E File Offset: 0x00055D1E
		public unsafe AudioSourceController ActivateSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_ActivateSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_ActivateSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003778 RID: 14200
		// (get) Token: 0x0600B2E2 RID: 45794 RVA: 0x002C9F0C File Offset: 0x002C810C
		// (set) Token: 0x0600B2E3 RID: 45795 RVA: 0x00057B3D File Offset: 0x00055D3D
		public unsafe AudioSourceController DirtPourSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_DirtPourSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_DirtPourSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x0600B2E4 RID: 45796 RVA: 0x002C9F3C File Offset: 0x002C813C
		// (set) Token: 0x0600B2E5 RID: 45797 RVA: 0x00057B5C File Offset: 0x00055D5C
		public unsafe bool isDispensing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_isDispensing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_isDispensing)) = value;
			}
		}

		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x0600B2E6 RID: 45798 RVA: 0x002C9F64 File Offset: 0x002C8164
		// (set) Token: 0x0600B2E7 RID: 45799 RVA: 0x00057B77 File Offset: 0x00055D77
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x0600B2E8 RID: 45800 RVA: 0x002C9F8C File Offset: 0x002C818C
		// (set) Token: 0x0600B2E9 RID: 45801 RVA: 0x00057B92 File Offset: 0x00055D92
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400787D RID: 30845
		private static readonly IntPtr NativeFieldInfoPtr__SoilID_k__BackingField;

		// Token: 0x0400787E RID: 30846
		private static readonly IntPtr NativeFieldInfoPtr_AnimationDuration;

		// Token: 0x0400787F RID: 30847
		private static readonly IntPtr NativeFieldInfoPtr_HandleIntObj;

		// Token: 0x04007880 RID: 30848
		private static readonly IntPtr NativeFieldInfoPtr_FillIntObj;

		// Token: 0x04007881 RID: 30849
		private static readonly IntPtr NativeFieldInfoPtr_DirtPlane;

		// Token: 0x04007882 RID: 30850
		private static readonly IntPtr NativeFieldInfoPtr_Dirt_Min;

		// Token: 0x04007883 RID: 30851
		private static readonly IntPtr NativeFieldInfoPtr_Dirt_Max;

		// Token: 0x04007884 RID: 30852
		private static readonly IntPtr NativeFieldInfoPtr_PourParticles;

		// Token: 0x04007885 RID: 30853
		private static readonly IntPtr NativeFieldInfoPtr_PourAnimation;

		// Token: 0x04007886 RID: 30854
		private static readonly IntPtr NativeFieldInfoPtr_FillSound;

		// Token: 0x04007887 RID: 30855
		private static readonly IntPtr NativeFieldInfoPtr_ActivateSound;

		// Token: 0x04007888 RID: 30856
		private static readonly IntPtr NativeFieldInfoPtr_DirtPourSound;

		// Token: 0x04007889 RID: 30857
		private static readonly IntPtr NativeFieldInfoPtr_isDispensing;

		// Token: 0x0400788A RID: 30858
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400788B RID: 30859
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400788C RID: 30860
		private static readonly IntPtr NativeMethodInfoPtr_get_SoilID_Public_get_String_0;

		// Token: 0x0400788D RID: 30861
		private static readonly IntPtr NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0;

		// Token: 0x0400788E RID: 30862
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400788F RID: 30863
		private static readonly IntPtr NativeMethodInfoPtr_HandleHovered_Public_Void_0;

		// Token: 0x04007890 RID: 30864
		private static readonly IntPtr NativeMethodInfoPtr_HandleInteracted_Public_Void_0;

		// Token: 0x04007891 RID: 30865
		private static readonly IntPtr NativeMethodInfoPtr_SendPourSoil_Private_Void_0;

		// Token: 0x04007892 RID: 30866
		private static readonly IntPtr NativeMethodInfoPtr_PourSoil_Private_Void_0;

		// Token: 0x04007893 RID: 30867
		private static readonly IntPtr NativeMethodInfoPtr_ApplySoil_Private_Void_String_0;

		// Token: 0x04007894 RID: 30868
		private static readonly IntPtr NativeMethodInfoPtr_FillHovered_Public_Void_0;

		// Token: 0x04007895 RID: 30869
		private static readonly IntPtr NativeMethodInfoPtr_FillInteracted_Public_Void_0;

		// Token: 0x04007896 RID: 30870
		private static readonly IntPtr NativeMethodInfoPtr_SendSoil_Public_Void_String_0;

		// Token: 0x04007897 RID: 30871
		private static readonly IntPtr NativeMethodInfoPtr_SetSoil_Protected_Void_NetworkConnection_String_0;

		// Token: 0x04007898 RID: 30872
		private static readonly IntPtr NativeMethodInfoPtr_SetSoilLevel_Public_Void_Single_0;

		// Token: 0x04007899 RID: 30873
		private static readonly IntPtr NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0;

		// Token: 0x0400789A RID: 30874
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x0400789B RID: 30875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400789C RID: 30876
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0400789D RID: 30877
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400789E RID: 30878
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400789F RID: 30879
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040078A0 RID: 30880
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPourSoil_2166136261_Private_Void_0;

		// Token: 0x040078A1 RID: 30881
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPourSoil_2166136261_Private_Void_0;

		// Token: 0x040078A2 RID: 30882
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPourSoil_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040078A3 RID: 30883
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PourSoil_2166136261_Private_Void_0;

		// Token: 0x040078A4 RID: 30884
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PourSoil_2166136261_Private_Void_0;

		// Token: 0x040078A5 RID: 30885
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PourSoil_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040078A6 RID: 30886
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendSoil_3615296227_Private_Void_String_0;

		// Token: 0x040078A7 RID: 30887
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendSoil_3615296227_Public_Void_String_0;

		// Token: 0x040078A8 RID: 30888
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendSoil_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040078A9 RID: 30889
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSoil_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x040078AA RID: 30890
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSoil_2971853958_Protected_Void_NetworkConnection_String_0;

		// Token: 0x040078AB RID: 30891
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSoil_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x040078AC RID: 30892
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSoil_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x040078AD RID: 30893
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSoil_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x040078AE RID: 30894
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000BF6 RID: 3062
		[ObfuscatedName("ScheduleOne.ObjectScripts.SoilPourer+<<PourSoil>g__PourRoutine|20_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DF9A RID: 57242 RVA: 0x0034AFF0 File Offset: 0x003491F0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique()
			{
				Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "<<PourSoil>g__PourRoutine|20_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<>1__state");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<>2__current");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<>4__this");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__targetPot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<targetPot>5__2");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<i>5__3");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685349);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685350);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685351);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685352);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685353);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685354);
			}

			// Token: 0x0600DF9B RID: 57243 RVA: 0x0034B0F8 File Offset: 0x003492F8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF9C RID: 57244 RVA: 0x0034B140 File Offset: 0x00349340
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF9D RID: 57245 RVA: 0x0034B174 File Offset: 0x00349374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307808, XrefRangeEnd = 307817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004550 RID: 17744
			// (get) Token: 0x0600DF9E RID: 57246 RVA: 0x0034B1B0 File Offset: 0x003493B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF9F RID: 57247 RVA: 0x0034B1F0 File Offset: 0x003493F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307817, XrefRangeEnd = 307822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004551 RID: 17745
			// (get) Token: 0x0600DFA0 RID: 57248 RVA: 0x0034B224 File Offset: 0x00349424
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFA1 RID: 57249 RVA: 0x0006D07E File Offset: 0x0006B27E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700454B RID: 17739
			// (get) Token: 0x0600DFA2 RID: 57250 RVA: 0x0034B264 File Offset: 0x00349464
			// (set) Token: 0x0600DFA3 RID: 57251 RVA: 0x0006D087 File Offset: 0x0006B287
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700454C RID: 17740
			// (get) Token: 0x0600DFA4 RID: 57252 RVA: 0x0034B28C File Offset: 0x0034948C
			// (set) Token: 0x0600DFA5 RID: 57253 RVA: 0x0006D0A2 File Offset: 0x0006B2A2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700454D RID: 17741
			// (get) Token: 0x0600DFA6 RID: 57254 RVA: 0x0034B2BC File Offset: 0x003494BC
			// (set) Token: 0x0600DFA7 RID: 57255 RVA: 0x0006D0C1 File Offset: 0x0006B2C1
			public unsafe SoilPourer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilPourer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700454E RID: 17742
			// (get) Token: 0x0600DFA8 RID: 57256 RVA: 0x0034B2EC File Offset: 0x003494EC
			// (set) Token: 0x0600DFA9 RID: 57257 RVA: 0x0006D0E0 File Offset: 0x0006B2E0
			public unsafe Pot _targetPot_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__targetPot_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__targetPot_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700454F RID: 17743
			// (get) Token: 0x0600DFAA RID: 57258 RVA: 0x0034B31C File Offset: 0x0034951C
			// (set) Token: 0x0600DFAB RID: 57259 RVA: 0x0006D0FF File Offset: 0x0006B2FF
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040095C9 RID: 38345
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040095CA RID: 38346
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040095CB RID: 38347
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095CC RID: 38348
			private static readonly IntPtr NativeFieldInfoPtr__targetPot_5__2;

			// Token: 0x040095CD RID: 38349
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040095CE RID: 38350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040095CF RID: 38351
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095D0 RID: 38352
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040095D1 RID: 38353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040095D2 RID: 38354
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095D3 RID: 38355
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
