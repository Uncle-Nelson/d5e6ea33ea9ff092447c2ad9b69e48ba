using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000568 RID: 1384
	public class PackagingTool : MonoBehaviour
	{
		// Token: 0x0600793F RID: 31039 RVA: 0x0020B5B4 File Offset: 0x002097B4
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingTool()
		{
			Il2CppClassPointerStore<PackagingTool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "PackagingTool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr);
			PackagingTool.NativeFieldInfoPtr__ReceiveInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "<ReceiveInput>k__BackingField");
			PackagingTool.NativeFieldInfoPtr_FinalizeRange_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "FinalizeRange_Min");
			PackagingTool.NativeFieldInfoPtr_FinalizeRange_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "FinalizeRange_Max");
			PackagingTool.NativeFieldInfoPtr_ConveyorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConveyorSpeed");
			PackagingTool.NativeFieldInfoPtr_ConveyorAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConveyorAcceleration");
			PackagingTool.NativeFieldInfoPtr_BaggieRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "BaggieRadius");
			PackagingTool.NativeFieldInfoPtr_JarRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "JarRadius");
			PackagingTool.NativeFieldInfoPtr_DeployAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DeployAngle");
			PackagingTool.NativeFieldInfoPtr_ProductInitialForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductInitialForce");
			PackagingTool.NativeFieldInfoPtr_ProductRandomTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductRandomTorque");
			PackagingTool.NativeFieldInfoPtr_KickForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickForce");
			PackagingTool.NativeFieldInfoPtr_DropCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DropCooldown");
			PackagingTool.NativeFieldInfoPtr_Station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "Station");
			PackagingTool.NativeFieldInfoPtr_ConveyorModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConveyorModel");
			PackagingTool.NativeFieldInfoPtr_DoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DoorAnim");
			PackagingTool.NativeFieldInfoPtr_CapAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "CapAnim");
			PackagingTool.NativeFieldInfoPtr_SealAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "SealAnim");
			PackagingTool.NativeFieldInfoPtr_KickAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickAnim");
			PackagingTool.NativeFieldInfoPtr_LeftButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "LeftButton");
			PackagingTool.NativeFieldInfoPtr_RightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "RightButton");
			PackagingTool.NativeFieldInfoPtr_DropButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DropButton");
			PackagingTool.NativeFieldInfoPtr_PackagingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingContainer");
			PackagingTool.NativeFieldInfoPtr_ProductCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductCountText");
			PackagingTool.NativeFieldInfoPtr_HopperDropPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "HopperDropPoint");
			PackagingTool.NativeFieldInfoPtr_BaggieStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "BaggieStartPoint");
			PackagingTool.NativeFieldInfoPtr_JarStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "JarStartPoint");
			PackagingTool.NativeFieldInfoPtr_ProductContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductContainer");
			PackagingTool.NativeFieldInfoPtr_KickOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickOrigin");
			PackagingTool.NativeFieldInfoPtr_HopperInputCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "HopperInputCollider");
			PackagingTool.NativeFieldInfoPtr_KickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickSound");
			PackagingTool.NativeFieldInfoPtr_MotorSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "MotorSound");
			PackagingTool.NativeFieldInfoPtr_DropSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DropSound");
			PackagingTool.NativeFieldInfoPtr_PackagingPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingPrefab");
			PackagingTool.NativeFieldInfoPtr_ConcealedPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConcealedPackaging");
			PackagingTool.NativeFieldInfoPtr_ProductItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductItem");
			PackagingTool.NativeFieldInfoPtr_ProductPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductPrefab");
			PackagingTool.NativeFieldInfoPtr_ProductInHopper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductInHopper");
			PackagingTool.NativeFieldInfoPtr_PackagingInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingInstances");
			PackagingTool.NativeFieldInfoPtr_ProductInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductInstances");
			PackagingTool.NativeFieldInfoPtr_FinalizedPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "FinalizedPackaging");
			PackagingTool.NativeFieldInfoPtr_conveyorVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "conveyorVelocity");
			PackagingTool.NativeFieldInfoPtr_directionInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "directionInput");
			PackagingTool.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "task");
			PackagingTool.NativeFieldInfoPtr_finalizeInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "finalizeInstance");
			PackagingTool.NativeFieldInfoPtr_finalizeCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "finalizeCoroutine");
			PackagingTool.NativeFieldInfoPtr_leftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "leftDown");
			PackagingTool.NativeFieldInfoPtr_rightDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "rightDown");
			PackagingTool.NativeFieldInfoPtr_dropDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "dropDown");
			PackagingTool.NativeFieldInfoPtr_timeSinceLastDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "timeSinceLastDrop");
			PackagingTool.NativeMethodInfoPtr_get_ReceiveInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678495);
			PackagingTool.NativeMethodInfoPtr_set_ReceiveInput_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678496);
			PackagingTool.NativeMethodInfoPtr_Initialize_Public_Void_Task_FunctionalPackaging_Int32_ProductItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678497);
			PackagingTool.NativeMethodInfoPtr_Deinitialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678498);
			PackagingTool.NativeMethodInfoPtr_LoadPackaging_Private_Void_FunctionalPackaging_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678499);
			PackagingTool.NativeMethodInfoPtr_UnloadPackaging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678500);
			PackagingTool.NativeMethodInfoPtr_LoadProduct_Private_Void_ProductItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678501);
			PackagingTool.NativeMethodInfoPtr_UnloadProduct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678502);
			PackagingTool.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678503);
			PackagingTool.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678504);
			PackagingTool.NativeMethodInfoPtr_UpdateScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678505);
			PackagingTool.NativeMethodInfoPtr_UpdateConveyor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678506);
			PackagingTool.NativeMethodInfoPtr_Rotate_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678507);
			PackagingTool.NativeMethodInfoPtr_CheckDeployPackaging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678508);
			PackagingTool.NativeMethodInfoPtr_CheckFinalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678509);
			PackagingTool.NativeMethodInfoPtr_Finalize_Private_Void_PackagingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678510);
			PackagingTool.NativeMethodInfoPtr_DropProduct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678511);
			PackagingTool.NativeMethodInfoPtr_CheckInsertions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678512);
			PackagingTool.NativeMethodInfoPtr_InsertIntoHopper_Private_Void_FunctionalProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678513);
			PackagingTool.NativeMethodInfoPtr_DeployPackaging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678514);
			PackagingTool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678515);
		}

		// Token: 0x170024D7 RID: 9431
		// (get) Token: 0x06007940 RID: 31040 RVA: 0x0020BB5C File Offset: 0x00209D5C
		// (set) Token: 0x06007941 RID: 31041 RVA: 0x0020BB98 File Offset: 0x00209D98
		public unsafe bool ReceiveInput
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_get_ReceiveInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_set_ReceiveInput_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007942 RID: 31042 RVA: 0x0020BBD8 File Offset: 0x00209DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233120, RefRangeEnd = 233121, XrefRangeStart = 233109, XrefRangeEnd = 233120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Task _task, FunctionalPackaging packaging, int packagingQuantity, ProductItemInstance product, int productQuantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_task);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(packaging);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packagingQuantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Initialize_Public_Void_Task_FunctionalPackaging_Int32_ProductItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007943 RID: 31043 RVA: 0x0020BC5C File Offset: 0x00209E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233167, RefRangeEnd = 233168, XrefRangeStart = 233121, XrefRangeEnd = 233167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Deinitialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007944 RID: 31044 RVA: 0x0020BC90 File Offset: 0x00209E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233168, XrefRangeEnd = 233169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadPackaging(FunctionalPackaging prefab, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_LoadPackaging_Private_Void_FunctionalPackaging_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007945 RID: 31045 RVA: 0x0020BCE0 File Offset: 0x00209EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233169, XrefRangeEnd = 233170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UnloadPackaging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007946 RID: 31046 RVA: 0x0020BD14 File Offset: 0x00209F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233170, XrefRangeEnd = 233177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadProduct(ProductItemInstance product, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_LoadProduct_Private_Void_ProductItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007947 RID: 31047 RVA: 0x0020BD64 File Offset: 0x00209F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233177, XrefRangeEnd = 233182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UnloadProduct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007948 RID: 31048 RVA: 0x0020BD98 File Offset: 0x00209F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233182, XrefRangeEnd = 233209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007949 RID: 31049 RVA: 0x0020BDCC File Offset: 0x00209FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233228, RefRangeEnd = 233229, XrefRangeStart = 233209, XrefRangeEnd = 233228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600794A RID: 31050 RVA: 0x0020BE00 File Offset: 0x0020A000
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 233233, RefRangeEnd = 233237, XrefRangeStart = 233229, XrefRangeEnd = 233233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UpdateScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600794B RID: 31051 RVA: 0x0020BE34 File Offset: 0x0020A034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233237, XrefRangeEnd = 233241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateConveyor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UpdateConveyor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x0020BE68 File Offset: 0x0020A068
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233269, RefRangeEnd = 233272, XrefRangeStart = 233241, XrefRangeEnd = 233269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Rotate_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x0020BEA8 File Offset: 0x0020A0A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233279, RefRangeEnd = 233281, XrefRangeStart = 233272, XrefRangeEnd = 233279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDeployPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_CheckDeployPackaging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x0020BEDC File Offset: 0x0020A0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233281, XrefRangeEnd = 233293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckFinalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_CheckFinalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x0020BF10 File Offset: 0x0020A110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233308, RefRangeEnd = 233310, XrefRangeStart = 233293, XrefRangeEnd = 233308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finalize(PackagingTool.PackagingInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Finalize_Private_Void_PackagingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007950 RID: 31056 RVA: 0x0020BF54 File Offset: 0x0020A154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233330, RefRangeEnd = 233331, XrefRangeStart = 233310, XrefRangeEnd = 233330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_DropProduct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007951 RID: 31057 RVA: 0x0020BF88 File Offset: 0x0020A188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233352, RefRangeEnd = 233353, XrefRangeStart = 233331, XrefRangeEnd = 233352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckInsertions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_CheckInsertions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007952 RID: 31058 RVA: 0x0020BFBC File Offset: 0x0020A1BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233364, RefRangeEnd = 233365, XrefRangeStart = 233353, XrefRangeEnd = 233364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertIntoHopper(FunctionalProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_InsertIntoHopper_Private_Void_FunctionalProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007953 RID: 31059 RVA: 0x0020C000 File Offset: 0x0020A200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233441, RefRangeEnd = 233442, XrefRangeStart = 233365, XrefRangeEnd = 233441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeployPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_DeployPackaging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007954 RID: 31060 RVA: 0x0020C034 File Offset: 0x0020A234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233442, XrefRangeEnd = 233464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingTool() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007955 RID: 31061 RVA: 0x0003994F File Offset: 0x00037B4F
		public PackagingTool(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024A6 RID: 9382
		// (get) Token: 0x06007956 RID: 31062 RVA: 0x0020C070 File Offset: 0x0020A270
		// (set) Token: 0x06007957 RID: 31063 RVA: 0x00039958 File Offset: 0x00037B58
		public unsafe bool _ReceiveInput_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr__ReceiveInput_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr__ReceiveInput_k__BackingField)) = value;
			}
		}

		// Token: 0x170024A7 RID: 9383
		// (get) Token: 0x06007958 RID: 31064 RVA: 0x0020C098 File Offset: 0x0020A298
		// (set) Token: 0x06007959 RID: 31065 RVA: 0x00039973 File Offset: 0x00037B73
		public unsafe static float FinalizeRange_Min
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Min, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Min, (void*)(&value));
			}
		}

		// Token: 0x170024A8 RID: 9384
		// (get) Token: 0x0600795A RID: 31066 RVA: 0x0020C0B4 File Offset: 0x0020A2B4
		// (set) Token: 0x0600795B RID: 31067 RVA: 0x00039981 File Offset: 0x00037B81
		public unsafe static float FinalizeRange_Max
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Max, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Max, (void*)(&value));
			}
		}

		// Token: 0x170024A9 RID: 9385
		// (get) Token: 0x0600795C RID: 31068 RVA: 0x0020C0D0 File Offset: 0x0020A2D0
		// (set) Token: 0x0600795D RID: 31069 RVA: 0x0003998F File Offset: 0x00037B8F
		public unsafe float ConveyorSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorSpeed)) = value;
			}
		}

		// Token: 0x170024AA RID: 9386
		// (get) Token: 0x0600795E RID: 31070 RVA: 0x0020C0F8 File Offset: 0x0020A2F8
		// (set) Token: 0x0600795F RID: 31071 RVA: 0x000399AA File Offset: 0x00037BAA
		public unsafe float ConveyorAcceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorAcceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorAcceleration)) = value;
			}
		}

		// Token: 0x170024AB RID: 9387
		// (get) Token: 0x06007960 RID: 31072 RVA: 0x0020C120 File Offset: 0x0020A320
		// (set) Token: 0x06007961 RID: 31073 RVA: 0x000399C5 File Offset: 0x00037BC5
		public unsafe float BaggieRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieRadius)) = value;
			}
		}

		// Token: 0x170024AC RID: 9388
		// (get) Token: 0x06007962 RID: 31074 RVA: 0x0020C148 File Offset: 0x0020A348
		// (set) Token: 0x06007963 RID: 31075 RVA: 0x000399E0 File Offset: 0x00037BE0
		public unsafe float JarRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarRadius)) = value;
			}
		}

		// Token: 0x170024AD RID: 9389
		// (get) Token: 0x06007964 RID: 31076 RVA: 0x0020C170 File Offset: 0x0020A370
		// (set) Token: 0x06007965 RID: 31077 RVA: 0x000399FB File Offset: 0x00037BFB
		public unsafe float DeployAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DeployAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DeployAngle)) = value;
			}
		}

		// Token: 0x170024AE RID: 9390
		// (get) Token: 0x06007966 RID: 31078 RVA: 0x0020C198 File Offset: 0x0020A398
		// (set) Token: 0x06007967 RID: 31079 RVA: 0x00039A16 File Offset: 0x00037C16
		public unsafe float ProductInitialForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInitialForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInitialForce)) = value;
			}
		}

		// Token: 0x170024AF RID: 9391
		// (get) Token: 0x06007968 RID: 31080 RVA: 0x0020C1C0 File Offset: 0x0020A3C0
		// (set) Token: 0x06007969 RID: 31081 RVA: 0x00039A31 File Offset: 0x00037C31
		public unsafe float ProductRandomTorque
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductRandomTorque);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductRandomTorque)) = value;
			}
		}

		// Token: 0x170024B0 RID: 9392
		// (get) Token: 0x0600796A RID: 31082 RVA: 0x0020C1E8 File Offset: 0x0020A3E8
		// (set) Token: 0x0600796B RID: 31083 RVA: 0x00039A4C File Offset: 0x00037C4C
		public unsafe float KickForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickForce)) = value;
			}
		}

		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x0600796C RID: 31084 RVA: 0x0020C210 File Offset: 0x0020A410
		// (set) Token: 0x0600796D RID: 31085 RVA: 0x00039A67 File Offset: 0x00037C67
		public unsafe float DropCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropCooldown)) = value;
			}
		}

		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x0600796E RID: 31086 RVA: 0x0020C238 File Offset: 0x0020A438
		// (set) Token: 0x0600796F RID: 31087 RVA: 0x00039A82 File Offset: 0x00037C82
		public unsafe PackagingStation Station
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_Station);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_Station), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x06007970 RID: 31088 RVA: 0x0020C268 File Offset: 0x0020A468
		// (set) Token: 0x06007971 RID: 31089 RVA: 0x00039AA1 File Offset: 0x00037CA1
		public unsafe Transform ConveyorModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x06007972 RID: 31090 RVA: 0x0020C298 File Offset: 0x0020A498
		// (set) Token: 0x06007973 RID: 31091 RVA: 0x00039AC0 File Offset: 0x00037CC0
		public unsafe Animation DoorAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DoorAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x06007974 RID: 31092 RVA: 0x0020C2C8 File Offset: 0x0020A4C8
		// (set) Token: 0x06007975 RID: 31093 RVA: 0x00039ADF File Offset: 0x00037CDF
		public unsafe Animation CapAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_CapAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_CapAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x06007976 RID: 31094 RVA: 0x0020C2F8 File Offset: 0x0020A4F8
		// (set) Token: 0x06007977 RID: 31095 RVA: 0x00039AFE File Offset: 0x00037CFE
		public unsafe Animation SealAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_SealAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_SealAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x06007978 RID: 31096 RVA: 0x0020C328 File Offset: 0x0020A528
		// (set) Token: 0x06007979 RID: 31097 RVA: 0x00039B1D File Offset: 0x00037D1D
		public unsafe Animation KickAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B8 RID: 9400
		// (get) Token: 0x0600797A RID: 31098 RVA: 0x0020C358 File Offset: 0x0020A558
		// (set) Token: 0x0600797B RID: 31099 RVA: 0x00039B3C File Offset: 0x00037D3C
		public unsafe Clickable LeftButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_LeftButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_LeftButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B9 RID: 9401
		// (get) Token: 0x0600797C RID: 31100 RVA: 0x0020C388 File Offset: 0x0020A588
		// (set) Token: 0x0600797D RID: 31101 RVA: 0x00039B5B File Offset: 0x00037D5B
		public unsafe Clickable RightButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_RightButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_RightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BA RID: 9402
		// (get) Token: 0x0600797E RID: 31102 RVA: 0x0020C3B8 File Offset: 0x0020A5B8
		// (set) Token: 0x0600797F RID: 31103 RVA: 0x00039B7A File Offset: 0x00037D7A
		public unsafe Clickable DropButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BB RID: 9403
		// (get) Token: 0x06007980 RID: 31104 RVA: 0x0020C3E8 File Offset: 0x0020A5E8
		// (set) Token: 0x06007981 RID: 31105 RVA: 0x00039B99 File Offset: 0x00037D99
		public unsafe Transform PackagingContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BC RID: 9404
		// (get) Token: 0x06007982 RID: 31106 RVA: 0x0020C418 File Offset: 0x0020A618
		// (set) Token: 0x06007983 RID: 31107 RVA: 0x00039BB8 File Offset: 0x00037DB8
		public unsafe TextMeshPro ProductCountText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductCountText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x06007984 RID: 31108 RVA: 0x0020C448 File Offset: 0x0020A648
		// (set) Token: 0x06007985 RID: 31109 RVA: 0x00039BD7 File Offset: 0x00037DD7
		public unsafe Transform HopperDropPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperDropPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperDropPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BE RID: 9406
		// (get) Token: 0x06007986 RID: 31110 RVA: 0x0020C478 File Offset: 0x0020A678
		// (set) Token: 0x06007987 RID: 31111 RVA: 0x00039BF6 File Offset: 0x00037DF6
		public unsafe Transform BaggieStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x06007988 RID: 31112 RVA: 0x0020C4A8 File Offset: 0x0020A6A8
		// (set) Token: 0x06007989 RID: 31113 RVA: 0x00039C15 File Offset: 0x00037E15
		public unsafe Transform JarStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x0600798A RID: 31114 RVA: 0x0020C4D8 File Offset: 0x0020A6D8
		// (set) Token: 0x0600798B RID: 31115 RVA: 0x00039C34 File Offset: 0x00037E34
		public unsafe Transform ProductContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x0600798C RID: 31116 RVA: 0x0020C508 File Offset: 0x0020A708
		// (set) Token: 0x0600798D RID: 31117 RVA: 0x00039C53 File Offset: 0x00037E53
		public unsafe Transform KickOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x0600798E RID: 31118 RVA: 0x0020C538 File Offset: 0x0020A738
		// (set) Token: 0x0600798F RID: 31119 RVA: 0x00039C72 File Offset: 0x00037E72
		public unsafe SphereCollider HopperInputCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperInputCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperInputCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x06007990 RID: 31120 RVA: 0x0020C568 File Offset: 0x0020A768
		// (set) Token: 0x06007991 RID: 31121 RVA: 0x00039C91 File Offset: 0x00037E91
		public unsafe AudioSourceController KickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C4 RID: 9412
		// (get) Token: 0x06007992 RID: 31122 RVA: 0x0020C598 File Offset: 0x0020A798
		// (set) Token: 0x06007993 RID: 31123 RVA: 0x00039CB0 File Offset: 0x00037EB0
		public unsafe AudioSourceController MotorSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_MotorSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_MotorSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C5 RID: 9413
		// (get) Token: 0x06007994 RID: 31124 RVA: 0x0020C5C8 File Offset: 0x0020A7C8
		// (set) Token: 0x06007995 RID: 31125 RVA: 0x00039CCF File Offset: 0x00037ECF
		public unsafe AudioSourceController DropSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C6 RID: 9414
		// (get) Token: 0x06007996 RID: 31126 RVA: 0x0020C5F8 File Offset: 0x0020A7F8
		// (set) Token: 0x06007997 RID: 31127 RVA: 0x00039CEE File Offset: 0x00037EEE
		public unsafe FunctionalPackaging PackagingPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C7 RID: 9415
		// (get) Token: 0x06007998 RID: 31128 RVA: 0x0020C628 File Offset: 0x0020A828
		// (set) Token: 0x06007999 RID: 31129 RVA: 0x00039D0D File Offset: 0x00037F0D
		public unsafe int ConcealedPackaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConcealedPackaging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConcealedPackaging)) = value;
			}
		}

		// Token: 0x170024C8 RID: 9416
		// (get) Token: 0x0600799A RID: 31130 RVA: 0x0020C650 File Offset: 0x0020A850
		// (set) Token: 0x0600799B RID: 31131 RVA: 0x00039D28 File Offset: 0x00037F28
		public unsafe ProductItemInstance ProductItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C9 RID: 9417
		// (get) Token: 0x0600799C RID: 31132 RVA: 0x0020C680 File Offset: 0x0020A880
		// (set) Token: 0x0600799D RID: 31133 RVA: 0x00039D47 File Offset: 0x00037F47
		public unsafe FunctionalProduct ProductPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalProduct>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024CA RID: 9418
		// (get) Token: 0x0600799E RID: 31134 RVA: 0x0020C6B0 File Offset: 0x0020A8B0
		// (set) Token: 0x0600799F RID: 31135 RVA: 0x00039D66 File Offset: 0x00037F66
		public unsafe int ProductInHopper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInHopper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInHopper)) = value;
			}
		}

		// Token: 0x170024CB RID: 9419
		// (get) Token: 0x060079A0 RID: 31136 RVA: 0x0020C6D8 File Offset: 0x0020A8D8
		// (set) Token: 0x060079A1 RID: 31137 RVA: 0x00039D81 File Offset: 0x00037F81
		public unsafe List<PackagingTool.PackagingInstance> PackagingInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PackagingTool.PackagingInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024CC RID: 9420
		// (get) Token: 0x060079A2 RID: 31138 RVA: 0x0020C708 File Offset: 0x0020A908
		// (set) Token: 0x060079A3 RID: 31139 RVA: 0x00039DA0 File Offset: 0x00037FA0
		public unsafe List<FunctionalProduct> ProductInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024CD RID: 9421
		// (get) Token: 0x060079A4 RID: 31140 RVA: 0x0020C738 File Offset: 0x0020A938
		// (set) Token: 0x060079A5 RID: 31141 RVA: 0x00039DBF File Offset: 0x00037FBF
		public unsafe List<FunctionalPackaging> FinalizedPackaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_FinalizedPackaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalPackaging>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_FinalizedPackaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024CE RID: 9422
		// (get) Token: 0x060079A6 RID: 31142 RVA: 0x0020C768 File Offset: 0x0020A968
		// (set) Token: 0x060079A7 RID: 31143 RVA: 0x00039DDE File Offset: 0x00037FDE
		public unsafe float conveyorVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_conveyorVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_conveyorVelocity)) = value;
			}
		}

		// Token: 0x170024CF RID: 9423
		// (get) Token: 0x060079A8 RID: 31144 RVA: 0x0020C790 File Offset: 0x0020A990
		// (set) Token: 0x060079A9 RID: 31145 RVA: 0x00039DF9 File Offset: 0x00037FF9
		public unsafe int directionInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_directionInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_directionInput)) = value;
			}
		}

		// Token: 0x170024D0 RID: 9424
		// (get) Token: 0x060079AA RID: 31146 RVA: 0x0020C7B8 File Offset: 0x0020A9B8
		// (set) Token: 0x060079AB RID: 31147 RVA: 0x00039E14 File Offset: 0x00038014
		public unsafe Task task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D1 RID: 9425
		// (get) Token: 0x060079AC RID: 31148 RVA: 0x0020C7E8 File Offset: 0x0020A9E8
		// (set) Token: 0x060079AD RID: 31149 RVA: 0x00039E33 File Offset: 0x00038033
		public unsafe PackagingTool.PackagingInstance finalizeInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_finalizeInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.PackagingInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_finalizeInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D2 RID: 9426
		// (get) Token: 0x060079AE RID: 31150 RVA: 0x0020C818 File Offset: 0x0020AA18
		// (set) Token: 0x060079AF RID: 31151 RVA: 0x00039E52 File Offset: 0x00038052
		public unsafe Coroutine finalizeCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_finalizeCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_finalizeCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D3 RID: 9427
		// (get) Token: 0x060079B0 RID: 31152 RVA: 0x0020C848 File Offset: 0x0020AA48
		// (set) Token: 0x060079B1 RID: 31153 RVA: 0x00039E71 File Offset: 0x00038071
		public unsafe bool leftDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_leftDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_leftDown)) = value;
			}
		}

		// Token: 0x170024D4 RID: 9428
		// (get) Token: 0x060079B2 RID: 31154 RVA: 0x0020C870 File Offset: 0x0020AA70
		// (set) Token: 0x060079B3 RID: 31155 RVA: 0x00039E8C File Offset: 0x0003808C
		public unsafe bool rightDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_rightDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_rightDown)) = value;
			}
		}

		// Token: 0x170024D5 RID: 9429
		// (get) Token: 0x060079B4 RID: 31156 RVA: 0x0020C898 File Offset: 0x0020AA98
		// (set) Token: 0x060079B5 RID: 31157 RVA: 0x00039EA7 File Offset: 0x000380A7
		public unsafe bool dropDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_dropDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_dropDown)) = value;
			}
		}

		// Token: 0x170024D6 RID: 9430
		// (get) Token: 0x060079B6 RID: 31158 RVA: 0x0020C8C0 File Offset: 0x0020AAC0
		// (set) Token: 0x060079B7 RID: 31159 RVA: 0x00039EC2 File Offset: 0x000380C2
		public unsafe float timeSinceLastDrop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_timeSinceLastDrop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_timeSinceLastDrop)) = value;
			}
		}

		// Token: 0x0400528B RID: 21131
		private static readonly IntPtr NativeFieldInfoPtr__ReceiveInput_k__BackingField;

		// Token: 0x0400528C RID: 21132
		private static readonly IntPtr NativeFieldInfoPtr_FinalizeRange_Min;

		// Token: 0x0400528D RID: 21133
		private static readonly IntPtr NativeFieldInfoPtr_FinalizeRange_Max;

		// Token: 0x0400528E RID: 21134
		private static readonly IntPtr NativeFieldInfoPtr_ConveyorSpeed;

		// Token: 0x0400528F RID: 21135
		private static readonly IntPtr NativeFieldInfoPtr_ConveyorAcceleration;

		// Token: 0x04005290 RID: 21136
		private static readonly IntPtr NativeFieldInfoPtr_BaggieRadius;

		// Token: 0x04005291 RID: 21137
		private static readonly IntPtr NativeFieldInfoPtr_JarRadius;

		// Token: 0x04005292 RID: 21138
		private static readonly IntPtr NativeFieldInfoPtr_DeployAngle;

		// Token: 0x04005293 RID: 21139
		private static readonly IntPtr NativeFieldInfoPtr_ProductInitialForce;

		// Token: 0x04005294 RID: 21140
		private static readonly IntPtr NativeFieldInfoPtr_ProductRandomTorque;

		// Token: 0x04005295 RID: 21141
		private static readonly IntPtr NativeFieldInfoPtr_KickForce;

		// Token: 0x04005296 RID: 21142
		private static readonly IntPtr NativeFieldInfoPtr_DropCooldown;

		// Token: 0x04005297 RID: 21143
		private static readonly IntPtr NativeFieldInfoPtr_Station;

		// Token: 0x04005298 RID: 21144
		private static readonly IntPtr NativeFieldInfoPtr_ConveyorModel;

		// Token: 0x04005299 RID: 21145
		private static readonly IntPtr NativeFieldInfoPtr_DoorAnim;

		// Token: 0x0400529A RID: 21146
		private static readonly IntPtr NativeFieldInfoPtr_CapAnim;

		// Token: 0x0400529B RID: 21147
		private static readonly IntPtr NativeFieldInfoPtr_SealAnim;

		// Token: 0x0400529C RID: 21148
		private static readonly IntPtr NativeFieldInfoPtr_KickAnim;

		// Token: 0x0400529D RID: 21149
		private static readonly IntPtr NativeFieldInfoPtr_LeftButton;

		// Token: 0x0400529E RID: 21150
		private static readonly IntPtr NativeFieldInfoPtr_RightButton;

		// Token: 0x0400529F RID: 21151
		private static readonly IntPtr NativeFieldInfoPtr_DropButton;

		// Token: 0x040052A0 RID: 21152
		private static readonly IntPtr NativeFieldInfoPtr_PackagingContainer;

		// Token: 0x040052A1 RID: 21153
		private static readonly IntPtr NativeFieldInfoPtr_ProductCountText;

		// Token: 0x040052A2 RID: 21154
		private static readonly IntPtr NativeFieldInfoPtr_HopperDropPoint;

		// Token: 0x040052A3 RID: 21155
		private static readonly IntPtr NativeFieldInfoPtr_BaggieStartPoint;

		// Token: 0x040052A4 RID: 21156
		private static readonly IntPtr NativeFieldInfoPtr_JarStartPoint;

		// Token: 0x040052A5 RID: 21157
		private static readonly IntPtr NativeFieldInfoPtr_ProductContainer;

		// Token: 0x040052A6 RID: 21158
		private static readonly IntPtr NativeFieldInfoPtr_KickOrigin;

		// Token: 0x040052A7 RID: 21159
		private static readonly IntPtr NativeFieldInfoPtr_HopperInputCollider;

		// Token: 0x040052A8 RID: 21160
		private static readonly IntPtr NativeFieldInfoPtr_KickSound;

		// Token: 0x040052A9 RID: 21161
		private static readonly IntPtr NativeFieldInfoPtr_MotorSound;

		// Token: 0x040052AA RID: 21162
		private static readonly IntPtr NativeFieldInfoPtr_DropSound;

		// Token: 0x040052AB RID: 21163
		private static readonly IntPtr NativeFieldInfoPtr_PackagingPrefab;

		// Token: 0x040052AC RID: 21164
		private static readonly IntPtr NativeFieldInfoPtr_ConcealedPackaging;

		// Token: 0x040052AD RID: 21165
		private static readonly IntPtr NativeFieldInfoPtr_ProductItem;

		// Token: 0x040052AE RID: 21166
		private static readonly IntPtr NativeFieldInfoPtr_ProductPrefab;

		// Token: 0x040052AF RID: 21167
		private static readonly IntPtr NativeFieldInfoPtr_ProductInHopper;

		// Token: 0x040052B0 RID: 21168
		private static readonly IntPtr NativeFieldInfoPtr_PackagingInstances;

		// Token: 0x040052B1 RID: 21169
		private static readonly IntPtr NativeFieldInfoPtr_ProductInstances;

		// Token: 0x040052B2 RID: 21170
		private static readonly IntPtr NativeFieldInfoPtr_FinalizedPackaging;

		// Token: 0x040052B3 RID: 21171
		private static readonly IntPtr NativeFieldInfoPtr_conveyorVelocity;

		// Token: 0x040052B4 RID: 21172
		private static readonly IntPtr NativeFieldInfoPtr_directionInput;

		// Token: 0x040052B5 RID: 21173
		private static readonly IntPtr NativeFieldInfoPtr_task;

		// Token: 0x040052B6 RID: 21174
		private static readonly IntPtr NativeFieldInfoPtr_finalizeInstance;

		// Token: 0x040052B7 RID: 21175
		private static readonly IntPtr NativeFieldInfoPtr_finalizeCoroutine;

		// Token: 0x040052B8 RID: 21176
		private static readonly IntPtr NativeFieldInfoPtr_leftDown;

		// Token: 0x040052B9 RID: 21177
		private static readonly IntPtr NativeFieldInfoPtr_rightDown;

		// Token: 0x040052BA RID: 21178
		private static readonly IntPtr NativeFieldInfoPtr_dropDown;

		// Token: 0x040052BB RID: 21179
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastDrop;

		// Token: 0x040052BC RID: 21180
		private static readonly IntPtr NativeMethodInfoPtr_get_ReceiveInput_Public_get_Boolean_0;

		// Token: 0x040052BD RID: 21181
		private static readonly IntPtr NativeMethodInfoPtr_set_ReceiveInput_Private_set_Void_Boolean_0;

		// Token: 0x040052BE RID: 21182
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Task_FunctionalPackaging_Int32_ProductItemInstance_Int32_0;

		// Token: 0x040052BF RID: 21183
		private static readonly IntPtr NativeMethodInfoPtr_Deinitialize_Public_Void_0;

		// Token: 0x040052C0 RID: 21184
		private static readonly IntPtr NativeMethodInfoPtr_LoadPackaging_Private_Void_FunctionalPackaging_Int32_0;

		// Token: 0x040052C1 RID: 21185
		private static readonly IntPtr NativeMethodInfoPtr_UnloadPackaging_Private_Void_0;

		// Token: 0x040052C2 RID: 21186
		private static readonly IntPtr NativeMethodInfoPtr_LoadProduct_Private_Void_ProductItemInstance_Int32_0;

		// Token: 0x040052C3 RID: 21187
		private static readonly IntPtr NativeMethodInfoPtr_UnloadProduct_Private_Void_0;

		// Token: 0x040052C4 RID: 21188
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040052C5 RID: 21189
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x040052C6 RID: 21190
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScreen_Private_Void_0;

		// Token: 0x040052C7 RID: 21191
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConveyor_Private_Void_0;

		// Token: 0x040052C8 RID: 21192
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Private_Void_Single_0;

		// Token: 0x040052C9 RID: 21193
		private static readonly IntPtr NativeMethodInfoPtr_CheckDeployPackaging_Private_Void_0;

		// Token: 0x040052CA RID: 21194
		private static readonly IntPtr NativeMethodInfoPtr_CheckFinalize_Private_Void_0;

		// Token: 0x040052CB RID: 21195
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Private_Void_PackagingInstance_0;

		// Token: 0x040052CC RID: 21196
		private static readonly IntPtr NativeMethodInfoPtr_DropProduct_Private_Void_0;

		// Token: 0x040052CD RID: 21197
		private static readonly IntPtr NativeMethodInfoPtr_CheckInsertions_Private_Void_0;

		// Token: 0x040052CE RID: 21198
		private static readonly IntPtr NativeMethodInfoPtr_InsertIntoHopper_Private_Void_FunctionalProduct_0;

		// Token: 0x040052CF RID: 21199
		private static readonly IntPtr NativeMethodInfoPtr_DeployPackaging_Private_Void_0;

		// Token: 0x040052D0 RID: 21200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA9 RID: 2729
		public class PackagingInstance : Il2CppSystem.Object
		{
			// Token: 0x0600D365 RID: 54117 RVA: 0x003283B4 File Offset: 0x003265B4
			// Note: this type is marked as 'beforefieldinit'.
			static PackagingInstance()
			{
				Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr);
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "Container");
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_ContainerRb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "ContainerRb");
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_Packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "Packaging");
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_AnglePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "AnglePosition");
				PackagingTool.PackagingInstance.NativeMethodInfoPtr_ChangePosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, 100678516);
				PackagingTool.PackagingInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, 100678517);
			}

			// Token: 0x0600D366 RID: 54118 RVA: 0x00328458 File Offset: 0x00326658
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 233064, RefRangeEnd = 233065, XrefRangeStart = 233058, XrefRangeEnd = 233064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ChangePosition(float angleDelta)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref angleDelta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.PackagingInstance.NativeMethodInfoPtr_ChangePosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D367 RID: 54119 RVA: 0x00328498 File Offset: 0x00326698
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PackagingInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.PackagingInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D368 RID: 54120 RVA: 0x00066E6C File Offset: 0x0006506C
			public PackagingInstance(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004190 RID: 16784
			// (get) Token: 0x0600D369 RID: 54121 RVA: 0x003284D4 File Offset: 0x003266D4
			// (set) Token: 0x0600D36A RID: 54122 RVA: 0x00066E75 File Offset: 0x00065075
			public unsafe Transform Container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004191 RID: 16785
			// (get) Token: 0x0600D36B RID: 54123 RVA: 0x00328504 File Offset: 0x00326704
			// (set) Token: 0x0600D36C RID: 54124 RVA: 0x00066E94 File Offset: 0x00065094
			public unsafe Rigidbody ContainerRb
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_ContainerRb);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_ContainerRb), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004192 RID: 16786
			// (get) Token: 0x0600D36D RID: 54125 RVA: 0x00328534 File Offset: 0x00326734
			// (set) Token: 0x0600D36E RID: 54126 RVA: 0x00066EB3 File Offset: 0x000650B3
			public unsafe FunctionalPackaging Packaging
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Packaging);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004193 RID: 16787
			// (get) Token: 0x0600D36F RID: 54127 RVA: 0x00328564 File Offset: 0x00326764
			// (set) Token: 0x0600D370 RID: 54128 RVA: 0x00066ED2 File Offset: 0x000650D2
			public unsafe float AnglePosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_AnglePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_AnglePosition)) = value;
				}
			}

			// Token: 0x04008E6F RID: 36463
			private static readonly IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x04008E70 RID: 36464
			private static readonly IntPtr NativeFieldInfoPtr_ContainerRb;

			// Token: 0x04008E71 RID: 36465
			private static readonly IntPtr NativeFieldInfoPtr_Packaging;

			// Token: 0x04008E72 RID: 36466
			private static readonly IntPtr NativeFieldInfoPtr_AnglePosition;

			// Token: 0x04008E73 RID: 36467
			private static readonly IntPtr NativeMethodInfoPtr_ChangePosition_Public_Void_Single_0;

			// Token: 0x04008E74 RID: 36468
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AAA RID: 2730
		[ObfuscatedName("ScheduleOne.Packaging.PackagingTool+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D371 RID: 54129 RVA: 0x0032858C File Offset: 0x0032678C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr);
				PackagingTool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, "<>9");
				PackagingTool.__c.NativeFieldInfoPtr___9__63_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, "<>9__63_0");
				PackagingTool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, 100678519);
				PackagingTool.__c.NativeMethodInfoPtr__Rotate_b__63_0_Internal_Int32_PackagingInstance_PackagingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, 100678520);
			}

			// Token: 0x0600D372 RID: 54130 RVA: 0x00328608 File Offset: 0x00326808
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D373 RID: 54131 RVA: 0x00328644 File Offset: 0x00326844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233065, XrefRangeEnd = 233067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Rotate_b__63_0(PackagingTool.PackagingInstance a, PackagingTool.PackagingInstance b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c.NativeMethodInfoPtr__Rotate_b__63_0_Internal_Int32_PackagingInstance_PackagingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D374 RID: 54132 RVA: 0x00066EED File Offset: 0x000650ED
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004194 RID: 16788
			// (get) Token: 0x0600D375 RID: 54133 RVA: 0x003286A4 File Offset: 0x003268A4
			// (set) Token: 0x0600D376 RID: 54134 RVA: 0x00066EF6 File Offset: 0x000650F6
			public unsafe static PackagingTool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PackagingTool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PackagingTool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004195 RID: 16789
			// (get) Token: 0x0600D377 RID: 54135 RVA: 0x003286CC File Offset: 0x003268CC
			// (set) Token: 0x0600D378 RID: 54136 RVA: 0x00066F08 File Offset: 0x00065108
			public unsafe static Comparison<PackagingTool.PackagingInstance> __9__63_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PackagingTool.__c.NativeFieldInfoPtr___9__63_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<PackagingTool.PackagingInstance>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PackagingTool.__c.NativeFieldInfoPtr___9__63_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E75 RID: 36469
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E76 RID: 36470
			private static readonly IntPtr NativeFieldInfoPtr___9__63_0;

			// Token: 0x04008E77 RID: 36471
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E78 RID: 36472
			private static readonly IntPtr NativeMethodInfoPtr__Rotate_b__63_0_Internal_Int32_PackagingInstance_PackagingInstance_0;
		}

		// Token: 0x02000AAB RID: 2731
		[ObfuscatedName("ScheduleOne.Packaging.PackagingTool+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D379 RID: 54137 RVA: 0x003286F4 File Offset: 0x003268F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr);
				PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, "instance");
				PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, "<>4__this");
				PackagingTool.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, 100678521);
				PackagingTool.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, 100678522);
			}

			// Token: 0x0600D37A RID: 54138 RVA: 0x00328770 File Offset: 0x00326970
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D37B RID: 54139 RVA: 0x003287AC File Offset: 0x003269AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233104, XrefRangeEnd = 233109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D37C RID: 54140 RVA: 0x00066F1A File Offset: 0x0006511A
			public __c__DisplayClass66_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004196 RID: 16790
			// (get) Token: 0x0600D37D RID: 54141 RVA: 0x003287EC File Offset: 0x003269EC
			// (set) Token: 0x0600D37E RID: 54142 RVA: 0x00066F23 File Offset: 0x00065123
			public unsafe PackagingTool.PackagingInstance instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.PackagingInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004197 RID: 16791
			// (get) Token: 0x0600D37F RID: 54143 RVA: 0x0032881C File Offset: 0x00326A1C
			// (set) Token: 0x0600D380 RID: 54144 RVA: 0x00066F42 File Offset: 0x00065142
			public unsafe PackagingTool __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E79 RID: 36473
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x04008E7A RID: 36474
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E7B RID: 36475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E7C RID: 36476
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C64 RID: 3172
			[ObfuscatedName("ScheduleOne.Packaging.PackagingTool+<>c__DisplayClass66_0+<<Finalize>g__FinalizeRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E457 RID: 58455 RVA: 0x00358D14 File Offset: 0x00356F14
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, "<<Finalize>g__FinalizeRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678523);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678524);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678525);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678526);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678527);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678528);
				}

				// Token: 0x0600E458 RID: 58456 RVA: 0x00358DF4 File Offset: 0x00356FF4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E459 RID: 58457 RVA: 0x00358E3C File Offset: 0x0035703C
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E45A RID: 58458 RVA: 0x00358E70 File Offset: 0x00357070
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233067, XrefRangeEnd = 233099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046EB RID: 18155
				// (get) Token: 0x0600E45B RID: 58459 RVA: 0x00358EAC File Offset: 0x003570AC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E45C RID: 58460 RVA: 0x00358EEC File Offset: 0x003570EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233099, XrefRangeEnd = 233104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046EC RID: 18156
				// (get) Token: 0x0600E45D RID: 58461 RVA: 0x00358F20 File Offset: 0x00357120
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E45E RID: 58462 RVA: 0x0006F54E File Offset: 0x0006D74E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046E8 RID: 18152
				// (get) Token: 0x0600E45F RID: 58463 RVA: 0x00358F60 File Offset: 0x00357160
				// (set) Token: 0x0600E460 RID: 58464 RVA: 0x0006F557 File Offset: 0x0006D757
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046E9 RID: 18153
				// (get) Token: 0x0600E461 RID: 58465 RVA: 0x00358F88 File Offset: 0x00357188
				// (set) Token: 0x0600E462 RID: 58466 RVA: 0x0006F572 File Offset: 0x0006D772
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046EA RID: 18154
				// (get) Token: 0x0600E463 RID: 58467 RVA: 0x00358FB8 File Offset: 0x003571B8
				// (set) Token: 0x0600E464 RID: 58468 RVA: 0x0006F591 File Offset: 0x0006D791
				public unsafe PackagingTool.__c__DisplayClass66_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.__c__DisplayClass66_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040098BF RID: 39103
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098C0 RID: 39104
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098C1 RID: 39105
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098C2 RID: 39106
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098C3 RID: 39107
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098C4 RID: 39108
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098C5 RID: 39109
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098C6 RID: 39110
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098C7 RID: 39111
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
