using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x0200040A RID: 1034
	public class EmployeeManager : NetworkSingleton<EmployeeManager>
	{
		// Token: 0x06005830 RID: 22576 RVA: 0x0019B404 File Offset: 0x00199604
		// Note: this type is marked as 'beforefieldinit'.
		static EmployeeManager()
		{
			Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "EmployeeManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr);
			EmployeeManager.NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MALE_EMPLOYEE_CHANCE");
			EmployeeManager.NativeFieldInfoPtr_AllEmployees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "AllEmployees");
			EmployeeManager.NativeFieldInfoPtr_EmployeeQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "EmployeeQuests");
			EmployeeManager.NativeFieldInfoPtr_BotanistPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "BotanistPrefab");
			EmployeeManager.NativeFieldInfoPtr_PackagerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "PackagerPrefab");
			EmployeeManager.NativeFieldInfoPtr_ChemistPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "ChemistPrefab");
			EmployeeManager.NativeFieldInfoPtr_CleanerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "CleanerPrefab");
			EmployeeManager.NativeFieldInfoPtr_MaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_FemaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "FemaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_MaleVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MaleVoices");
			EmployeeManager.NativeFieldInfoPtr_FemaleVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "FemaleVoices");
			EmployeeManager.NativeFieldInfoPtr_MaleFirstNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MaleFirstNames");
			EmployeeManager.NativeFieldInfoPtr_FemaleFirstNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "FemaleFirstNames");
			EmployeeManager.NativeFieldInfoPtr_LastNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "LastNames");
			EmployeeManager.NativeFieldInfoPtr_takenNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "takenNames");
			EmployeeManager.NativeFieldInfoPtr_takenMaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "takenMaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_takenFemaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "takenFemaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted");
			EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted");
			EmployeeManager.NativeMethodInfoPtr_CreateNewEmployee_Public_Void_Property_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674422);
			EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674423);
			EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Server_Public_Employee_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674424);
			EmployeeManager.NativeMethodInfoPtr_IsPositionValid_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674425);
			EmployeeManager.NativeMethodInfoPtr_IsRotationValid_Private_Boolean_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674426);
			EmployeeManager.NativeMethodInfoPtr_IsFloatValid_Private_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674427);
			EmployeeManager.NativeMethodInfoPtr_RegisterName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674428);
			EmployeeManager.NativeMethodInfoPtr_RegisterAppearance_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674429);
			EmployeeManager.NativeMethodInfoPtr_GenerateRandomName_Public_Void_Boolean_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674430);
			EmployeeManager.NativeMethodInfoPtr_GetAppearance_Public_EmployeeAppearance_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674431);
			EmployeeManager.NativeMethodInfoPtr_GetVoice_Public_VODatabase_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674432);
			EmployeeManager.NativeMethodInfoPtr_GetRandomAppearance_Public_Void_Boolean_byref_Int32_byref_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674433);
			EmployeeManager.NativeMethodInfoPtr_GetEmployeePrefab_Public_Employee_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674434);
			EmployeeManager.NativeMethodInfoPtr_GetEmployeesByType_Public_List_1_Employee_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674435);
			EmployeeManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674436);
			EmployeeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674437);
			EmployeeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674438);
			EmployeeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674439);
			EmployeeManager.NativeMethodInfoPtr_RpcWriter___Server_CreateEmployee_311954683_Private_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674440);
			EmployeeManager.NativeMethodInfoPtr_RpcLogic___CreateEmployee_311954683_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674441);
			EmployeeManager.NativeMethodInfoPtr_RpcReader___Server_CreateEmployee_311954683_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674442);
			EmployeeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674443);
		}

		// Token: 0x06005831 RID: 22577 RVA: 0x0019B768 File Offset: 0x00199968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185946, RefRangeEnd = 185947, XrefRangeStart = 185901, XrefRangeEnd = 185946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateNewEmployee(Property property, EEmployeeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_CreateNewEmployee_Public_Void_Property_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005832 RID: 22578 RVA: 0x0019B7B8 File Offset: 0x001999B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185947, XrefRangeEnd = 185948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEmployee(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x0019B890 File Offset: 0x00199A90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186007, RefRangeEnd = 186010, XrefRangeStart = 185948, XrefRangeEnd = 186007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee CreateEmployee_Server(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Server_Public_Employee_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x0019B974 File Offset: 0x00199B74
		[CallerCount(0)]
		public unsafe bool IsPositionValid(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_IsPositionValid_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x0019B9C0 File Offset: 0x00199BC0
		[CallerCount(0)]
		public unsafe bool IsRotationValid(Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_IsRotationValid_Private_Boolean_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x0019BA0C File Offset: 0x00199C0C
		[CallerCount(0)]
		public unsafe bool IsFloatValid(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_IsFloatValid_Private_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x0019BA58 File Offset: 0x00199C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186010, XrefRangeEnd = 186016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RegisterName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x0019BA9C File Offset: 0x00199C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186016, XrefRangeEnd = 186019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterAppearance(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RegisterAppearance_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x0019BAE8 File Offset: 0x00199CE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186030, RefRangeEnd = 186031, XrefRangeStart = 186019, XrefRangeEnd = 186030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateRandomName(bool male, out string firstName, out string lastName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GenerateRandomName_Public_Void_Boolean_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			firstName = IL2CPP.Il2CppStringToManaged(intPtr);
			lastName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x0019BB5C File Offset: 0x00199D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186031, XrefRangeEnd = 186036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeManager.EmployeeAppearance GetAppearance(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetAppearance_Public_EmployeeAppearance_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EmployeeManager.EmployeeAppearance>(intPtr3) : null;
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x0019BBB8 File Offset: 0x00199DB8
		[CallerCount(0)]
		public unsafe VODatabase GetVoice(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetVoice_Public_VODatabase_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VODatabase>(intPtr3) : null;
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x0019BC14 File Offset: 0x00199E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186036, XrefRangeEnd = 186050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRandomAppearance(bool male, out int index, out AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetRandomAppearance_Public_Void_Boolean_byref_Int32_byref_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			settings = ((intPtr4 == 0) ? null : new AvatarSettings(intPtr4));
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x0019BC84 File Offset: 0x00199E84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186060, RefRangeEnd = 186063, XrefRangeStart = 186050, XrefRangeEnd = 186060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee GetEmployeePrefab(EEmployeeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetEmployeePrefab_Public_Employee_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x0019BCD0 File Offset: 0x00199ED0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 186086, RefRangeEnd = 186090, XrefRangeStart = 186063, XrefRangeEnd = 186086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Employee> GetEmployeesByType(EEmployeeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetEmployeesByType_Public_List_1_Employee_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr3) : null;
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x0019BD1C File Offset: 0x00199F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186090, XrefRangeEnd = 186119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005840 RID: 22592 RVA: 0x0019BD58 File Offset: 0x00199F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186119, XrefRangeEnd = 186129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x0019BD94 File Offset: 0x00199F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186129, XrefRangeEnd = 186132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005842 RID: 22594 RVA: 0x0019BDD0 File Offset: 0x00199FD0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x0019BE0C File Offset: 0x0019A00C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 186165, RefRangeEnd = 186167, XrefRangeStart = 186132, XrefRangeEnd = 186165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RpcWriter___Server_CreateEmployee_311954683_Private_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x0019BEE4 File Offset: 0x0019A0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186167, XrefRangeEnd = 186168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RpcLogic___CreateEmployee_311954683_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x0019BFBC File Offset: 0x0019A1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186168, XrefRangeEnd = 186183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateEmployee_311954683(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RpcReader___Server_CreateEmployee_311954683_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x0019C020 File Offset: 0x0019A220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186183, XrefRangeEnd = 186186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x00029F0D File Offset: 0x0002810D
		public EmployeeManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x06005848 RID: 22600 RVA: 0x0019C05C File Offset: 0x0019A25C
		// (set) Token: 0x06005849 RID: 22601 RVA: 0x00029F16 File Offset: 0x00028116
		public unsafe static float MALE_EMPLOYEE_CHANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EmployeeManager.NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmployeeManager.NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE, (void*)(&value));
			}
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x0600584A RID: 22602 RVA: 0x0019C078 File Offset: 0x0019A278
		// (set) Token: 0x0600584B RID: 22603 RVA: 0x00029F24 File Offset: 0x00028124
		public unsafe List<Employee> AllEmployees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_AllEmployees);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_AllEmployees), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x0600584C RID: 22604 RVA: 0x0019C0A8 File Offset: 0x0019A2A8
		// (set) Token: 0x0600584D RID: 22605 RVA: 0x00029F43 File Offset: 0x00028143
		public unsafe Il2CppReferenceArray<Quest_Employees> EmployeeQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_EmployeeQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Quest_Employees>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_EmployeeQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x0600584E RID: 22606 RVA: 0x0019C0D8 File Offset: 0x0019A2D8
		// (set) Token: 0x0600584F RID: 22607 RVA: 0x00029F62 File Offset: 0x00028162
		public unsafe Botanist BotanistPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_BotanistPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_BotanistPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x06005850 RID: 22608 RVA: 0x0019C108 File Offset: 0x0019A308
		// (set) Token: 0x06005851 RID: 22609 RVA: 0x00029F81 File Offset: 0x00028181
		public unsafe Packager PackagerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_PackagerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_PackagerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x06005852 RID: 22610 RVA: 0x0019C138 File Offset: 0x0019A338
		// (set) Token: 0x06005853 RID: 22611 RVA: 0x00029FA0 File Offset: 0x000281A0
		public unsafe Chemist ChemistPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_ChemistPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_ChemistPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x06005854 RID: 22612 RVA: 0x0019C168 File Offset: 0x0019A368
		// (set) Token: 0x06005855 RID: 22613 RVA: 0x00029FBF File Offset: 0x000281BF
		public unsafe Cleaner CleanerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_CleanerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_CleanerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x06005856 RID: 22614 RVA: 0x0019C198 File Offset: 0x0019A398
		// (set) Token: 0x06005857 RID: 22615 RVA: 0x00029FDE File Offset: 0x000281DE
		public unsafe List<EmployeeManager.EmployeeAppearance> MaleAppearances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleAppearances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EmployeeManager.EmployeeAppearance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x06005858 RID: 22616 RVA: 0x0019C1C8 File Offset: 0x0019A3C8
		// (set) Token: 0x06005859 RID: 22617 RVA: 0x00029FFD File Offset: 0x000281FD
		public unsafe List<EmployeeManager.EmployeeAppearance> FemaleAppearances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleAppearances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EmployeeManager.EmployeeAppearance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x0600585A RID: 22618 RVA: 0x0019C1F8 File Offset: 0x0019A3F8
		// (set) Token: 0x0600585B RID: 22619 RVA: 0x0002A01C File Offset: 0x0002821C
		public unsafe Il2CppReferenceArray<VODatabase> MaleVoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleVoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VODatabase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleVoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x0600585C RID: 22620 RVA: 0x0019C228 File Offset: 0x0019A428
		// (set) Token: 0x0600585D RID: 22621 RVA: 0x0002A03B File Offset: 0x0002823B
		public unsafe Il2CppReferenceArray<VODatabase> FemaleVoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleVoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VODatabase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleVoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x0600585E RID: 22622 RVA: 0x0019C258 File Offset: 0x0019A458
		// (set) Token: 0x0600585F RID: 22623 RVA: 0x0002A05A File Offset: 0x0002825A
		public unsafe Il2CppStringArray MaleFirstNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleFirstNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleFirstNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x06005860 RID: 22624 RVA: 0x0019C288 File Offset: 0x0019A488
		// (set) Token: 0x06005861 RID: 22625 RVA: 0x0002A079 File Offset: 0x00028279
		public unsafe Il2CppStringArray FemaleFirstNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleFirstNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleFirstNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x06005862 RID: 22626 RVA: 0x0019C2B8 File Offset: 0x0019A4B8
		// (set) Token: 0x06005863 RID: 22627 RVA: 0x0002A098 File Offset: 0x00028298
		public unsafe Il2CppStringArray LastNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_LastNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_LastNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x06005864 RID: 22628 RVA: 0x0019C2E8 File Offset: 0x0019A4E8
		// (set) Token: 0x06005865 RID: 22629 RVA: 0x0002A0B7 File Offset: 0x000282B7
		public unsafe List<string> takenNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x06005866 RID: 22630 RVA: 0x0019C318 File Offset: 0x0019A518
		// (set) Token: 0x06005867 RID: 22631 RVA: 0x0002A0D6 File Offset: 0x000282D6
		public unsafe List<int> takenMaleAppearances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenMaleAppearances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenMaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x06005868 RID: 22632 RVA: 0x0019C348 File Offset: 0x0019A548
		// (set) Token: 0x06005869 RID: 22633 RVA: 0x0002A0F5 File Offset: 0x000282F5
		public unsafe List<int> takenFemaleAppearances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenFemaleAppearances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenFemaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x0600586A RID: 22634 RVA: 0x0019C378 File Offset: 0x0019A578
		// (set) Token: 0x0600586B RID: 22635 RVA: 0x0002A114 File Offset: 0x00028314
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x0600586C RID: 22636 RVA: 0x0019C3A0 File Offset: 0x0019A5A0
		// (set) Token: 0x0600586D RID: 22637 RVA: 0x0002A12F File Offset: 0x0002832F
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003C06 RID: 15366
		private static readonly IntPtr NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE;

		// Token: 0x04003C07 RID: 15367
		private static readonly IntPtr NativeFieldInfoPtr_AllEmployees;

		// Token: 0x04003C08 RID: 15368
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeQuests;

		// Token: 0x04003C09 RID: 15369
		private static readonly IntPtr NativeFieldInfoPtr_BotanistPrefab;

		// Token: 0x04003C0A RID: 15370
		private static readonly IntPtr NativeFieldInfoPtr_PackagerPrefab;

		// Token: 0x04003C0B RID: 15371
		private static readonly IntPtr NativeFieldInfoPtr_ChemistPrefab;

		// Token: 0x04003C0C RID: 15372
		private static readonly IntPtr NativeFieldInfoPtr_CleanerPrefab;

		// Token: 0x04003C0D RID: 15373
		private static readonly IntPtr NativeFieldInfoPtr_MaleAppearances;

		// Token: 0x04003C0E RID: 15374
		private static readonly IntPtr NativeFieldInfoPtr_FemaleAppearances;

		// Token: 0x04003C0F RID: 15375
		private static readonly IntPtr NativeFieldInfoPtr_MaleVoices;

		// Token: 0x04003C10 RID: 15376
		private static readonly IntPtr NativeFieldInfoPtr_FemaleVoices;

		// Token: 0x04003C11 RID: 15377
		private static readonly IntPtr NativeFieldInfoPtr_MaleFirstNames;

		// Token: 0x04003C12 RID: 15378
		private static readonly IntPtr NativeFieldInfoPtr_FemaleFirstNames;

		// Token: 0x04003C13 RID: 15379
		private static readonly IntPtr NativeFieldInfoPtr_LastNames;

		// Token: 0x04003C14 RID: 15380
		private static readonly IntPtr NativeFieldInfoPtr_takenNames;

		// Token: 0x04003C15 RID: 15381
		private static readonly IntPtr NativeFieldInfoPtr_takenMaleAppearances;

		// Token: 0x04003C16 RID: 15382
		private static readonly IntPtr NativeFieldInfoPtr_takenFemaleAppearances;

		// Token: 0x04003C17 RID: 15383
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003C18 RID: 15384
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003C19 RID: 15385
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewEmployee_Public_Void_Property_EEmployeeType_0;

		// Token: 0x04003C1A RID: 15386
		private static readonly IntPtr NativeMethodInfoPtr_CreateEmployee_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003C1B RID: 15387
		private static readonly IntPtr NativeMethodInfoPtr_CreateEmployee_Server_Public_Employee_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003C1C RID: 15388
		private static readonly IntPtr NativeMethodInfoPtr_IsPositionValid_Private_Boolean_Vector3_0;

		// Token: 0x04003C1D RID: 15389
		private static readonly IntPtr NativeMethodInfoPtr_IsRotationValid_Private_Boolean_Quaternion_0;

		// Token: 0x04003C1E RID: 15390
		private static readonly IntPtr NativeMethodInfoPtr_IsFloatValid_Private_Boolean_Single_0;

		// Token: 0x04003C1F RID: 15391
		private static readonly IntPtr NativeMethodInfoPtr_RegisterName_Public_Void_String_0;

		// Token: 0x04003C20 RID: 15392
		private static readonly IntPtr NativeMethodInfoPtr_RegisterAppearance_Public_Void_Boolean_Int32_0;

		// Token: 0x04003C21 RID: 15393
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandomName_Public_Void_Boolean_byref_String_byref_String_0;

		// Token: 0x04003C22 RID: 15394
		private static readonly IntPtr NativeMethodInfoPtr_GetAppearance_Public_EmployeeAppearance_Boolean_Int32_0;

		// Token: 0x04003C23 RID: 15395
		private static readonly IntPtr NativeMethodInfoPtr_GetVoice_Public_VODatabase_Boolean_Int32_0;

		// Token: 0x04003C24 RID: 15396
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomAppearance_Public_Void_Boolean_byref_Int32_byref_AvatarSettings_0;

		// Token: 0x04003C25 RID: 15397
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployeePrefab_Public_Employee_EEmployeeType_0;

		// Token: 0x04003C26 RID: 15398
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployeesByType_Public_List_1_Employee_EEmployeeType_0;

		// Token: 0x04003C27 RID: 15399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003C28 RID: 15400
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003C29 RID: 15401
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003C2A RID: 15402
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003C2B RID: 15403
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateEmployee_311954683_Private_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003C2C RID: 15404
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateEmployee_311954683_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003C2D RID: 15405
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateEmployee_311954683_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003C2E RID: 15406
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020009D1 RID: 2513
		[Serializable]
		public class EmployeeAppearance : Il2CppSystem.Object
		{
			// Token: 0x0600CCD0 RID: 52432 RVA: 0x003160C4 File Offset: 0x003142C4
			// Note: this type is marked as 'beforefieldinit'.
			static EmployeeAppearance()
			{
				Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "EmployeeAppearance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr);
				EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr, "Settings");
				EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Mugshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr, "Mugshot");
				EmployeeManager.EmployeeAppearance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr, 100674444);
			}

			// Token: 0x0600CCD1 RID: 52433 RVA: 0x0031612C File Offset: 0x0031432C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EmployeeAppearance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.EmployeeAppearance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCD2 RID: 52434 RVA: 0x000639AE File Offset: 0x00061BAE
			public EmployeeAppearance(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FCC RID: 16332
			// (get) Token: 0x0600CCD3 RID: 52435 RVA: 0x00316168 File Offset: 0x00314368
			// (set) Token: 0x0600CCD4 RID: 52436 RVA: 0x000639B7 File Offset: 0x00061BB7
			public unsafe AvatarSettings Settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FCD RID: 16333
			// (get) Token: 0x0600CCD5 RID: 52437 RVA: 0x00316198 File Offset: 0x00314398
			// (set) Token: 0x0600CCD6 RID: 52438 RVA: 0x000639D6 File Offset: 0x00061BD6
			public unsafe Sprite Mugshot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Mugshot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Mugshot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A77 RID: 35447
			private static readonly IntPtr NativeFieldInfoPtr_Settings;

			// Token: 0x04008A78 RID: 35448
			private static readonly IntPtr NativeFieldInfoPtr_Mugshot;

			// Token: 0x04008A79 RID: 35449
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009D2 RID: 2514
		[ObfuscatedName("ScheduleOne.Employees.EmployeeManager+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CCD7 RID: 52439 RVA: 0x003161C8 File Offset: 0x003143C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr);
				EmployeeManager.__c__DisplayClass20_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr, "type");
				EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr, 100674445);
				EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__CreateEmployee_Server_b__0_Internal_Boolean_Quest_Employees_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr, 100674446);
			}

			// Token: 0x0600CCD8 RID: 52440 RVA: 0x00316230 File Offset: 0x00314430
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCD9 RID: 52441 RVA: 0x0031626C File Offset: 0x0031446C
			[CallerCount(0)]
			public unsafe bool _CreateEmployee_Server_b__0(Quest_Employees x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__CreateEmployee_Server_b__0_Internal_Boolean_Quest_Employees_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CCDA RID: 52442 RVA: 0x000639F5 File Offset: 0x00061BF5
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FCE RID: 16334
			// (get) Token: 0x0600CCDB RID: 52443 RVA: 0x003162BC File Offset: 0x003144BC
			// (set) Token: 0x0600CCDC RID: 52444 RVA: 0x000639FE File Offset: 0x00061BFE
			public unsafe EEmployeeType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.__c__DisplayClass20_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.__c__DisplayClass20_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x04008A7A RID: 35450
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04008A7B RID: 35451
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A7C RID: 35452
			private static readonly IntPtr NativeMethodInfoPtr__CreateEmployee_Server_b__0_Internal_Boolean_Quest_Employees_0;
		}
	}
}
