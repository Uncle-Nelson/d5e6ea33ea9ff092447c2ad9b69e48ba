using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Construction.Features;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x02000483 RID: 1155
	public class Feature : NetworkBehaviour
	{
		// Token: 0x06006435 RID: 25653 RVA: 0x001C5B60 File Offset: 0x001C3D60
		// Note: this type is marked as 'beforefieldinit'.
		static Feature()
		{
			Il2CppClassPointerStore<Feature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "Feature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Feature>.NativeClassPtr);
			Feature.NativeFieldInfoPtr_featureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "featureName");
			Feature.NativeFieldInfoPtr_featureIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "featureIcon");
			Feature.NativeFieldInfoPtr_featureIconLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "featureIconLocation");
			Feature.NativeFieldInfoPtr_featureInterfacePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "featureInterfacePrefab");
			Feature.NativeFieldInfoPtr_disableRoofDisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "disableRoofDisibility");
			Feature.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Construction.Features.FeatureAssembly-CSharp.dll_Excuted");
			Feature.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Construction.Features.FeatureAssembly-CSharp.dll_Excuted");
			Feature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676000);
			Feature.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676001);
			Feature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_New_FI_Base_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676002);
			Feature.NativeMethodInfoPtr_Default_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676003);
			Feature.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676004);
			Feature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676005);
			Feature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676006);
			Feature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676007);
			Feature.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100676008);
		}

		// Token: 0x06006436 RID: 25654 RVA: 0x001C5CD0 File Offset: 0x001C3ED0
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006437 RID: 25655 RVA: 0x001C5D0C File Offset: 0x001C3F0C
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x001C5D48 File Offset: 0x001C3F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204358, XrefRangeEnd = 204367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual FI_Base CreateInterface(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_New_FI_Base_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FI_Base>(intPtr3) : null;
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x001C5DA4 File Offset: 0x001C3FA4
		[CallerCount(0)]
		public unsafe virtual void Default()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_Default_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x001C5DE0 File Offset: 0x001C3FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204367, XrefRangeEnd = 204372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Feature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Feature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Feature.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600643B RID: 25659 RVA: 0x001C5E1C File Offset: 0x001C401C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600643C RID: 25660 RVA: 0x001C5E58 File Offset: 0x001C4058
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600643D RID: 25661 RVA: 0x001C5E94 File Offset: 0x001C4094
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600643E RID: 25662 RVA: 0x001C5ED0 File Offset: 0x001C40D0
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600643F RID: 25663 RVA: 0x0002F633 File Offset: 0x0002D833
		public Feature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x06006440 RID: 25664 RVA: 0x001C5F0C File Offset: 0x001C410C
		// (set) Token: 0x06006441 RID: 25665 RVA: 0x0002F63C File Offset: 0x0002D83C
		public unsafe string featureName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x06006442 RID: 25666 RVA: 0x001C5F34 File Offset: 0x001C4134
		// (set) Token: 0x06006443 RID: 25667 RVA: 0x0002F65B File Offset: 0x0002D85B
		public unsafe Sprite featureIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x06006444 RID: 25668 RVA: 0x001C5F64 File Offset: 0x001C4164
		// (set) Token: 0x06006445 RID: 25669 RVA: 0x0002F67A File Offset: 0x0002D87A
		public unsafe Transform featureIconLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureIconLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureIconLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x06006446 RID: 25670 RVA: 0x001C5F94 File Offset: 0x001C4194
		// (set) Token: 0x06006447 RID: 25671 RVA: 0x0002F699 File Offset: 0x0002D899
		public unsafe GameObject featureInterfacePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureInterfacePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureInterfacePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x06006448 RID: 25672 RVA: 0x001C5FC4 File Offset: 0x001C41C4
		// (set) Token: 0x06006449 RID: 25673 RVA: 0x0002F6B8 File Offset: 0x0002D8B8
		public unsafe bool disableRoofDisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_disableRoofDisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_disableRoofDisibility)) = value;
			}
		}

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x0600644A RID: 25674 RVA: 0x001C5FEC File Offset: 0x001C41EC
		// (set) Token: 0x0600644B RID: 25675 RVA: 0x0002F6D3 File Offset: 0x0002D8D3
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x0600644C RID: 25676 RVA: 0x001C6014 File Offset: 0x001C4214
		// (set) Token: 0x0600644D RID: 25677 RVA: 0x0002F6EE File Offset: 0x0002D8EE
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004463 RID: 17507
		private static readonly IntPtr NativeFieldInfoPtr_featureName;

		// Token: 0x04004464 RID: 17508
		private static readonly IntPtr NativeFieldInfoPtr_featureIcon;

		// Token: 0x04004465 RID: 17509
		private static readonly IntPtr NativeFieldInfoPtr_featureIconLocation;

		// Token: 0x04004466 RID: 17510
		private static readonly IntPtr NativeFieldInfoPtr_featureInterfacePrefab;

		// Token: 0x04004467 RID: 17511
		private static readonly IntPtr NativeFieldInfoPtr_disableRoofDisibility;

		// Token: 0x04004468 RID: 17512
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004469 RID: 17513
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400446A RID: 17514
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400446B RID: 17515
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x0400446C RID: 17516
		private static readonly IntPtr NativeMethodInfoPtr_CreateInterface_Public_Virtual_New_FI_Base_Transform_0;

		// Token: 0x0400446D RID: 17517
		private static readonly IntPtr NativeMethodInfoPtr_Default_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400446E RID: 17518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400446F RID: 17519
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004470 RID: 17520
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004471 RID: 17521
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004472 RID: 17522
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
