using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI.Construction;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Construction
{
	// Token: 0x02000481 RID: 1153
	public class ConstructionManager : Singleton<ConstructionManager>
	{
		// Token: 0x060063EA RID: 25578 RVA: 0x001C4A38 File Offset: 0x001C2C38
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionManager()
		{
			Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction", "ConstructionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr);
			ConstructionManager.NativeFieldInfoPtr_networkObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "networkObject");
			ConstructionManager.NativeFieldInfoPtr__constructionModeEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "<constructionModeEnabled>k__BackingField");
			ConstructionManager.NativeFieldInfoPtr_onConstructionModeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "onConstructionModeEnabled");
			ConstructionManager.NativeFieldInfoPtr_onConstructionModeDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "onConstructionModeDisabled");
			ConstructionManager.NativeFieldInfoPtr__isDeployingConstructable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "<isDeployingConstructable>k__BackingField");
			ConstructionManager.NativeFieldInfoPtr_constructHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "constructHandler");
			ConstructionManager.NativeFieldInfoPtr__isMovingConstructable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "<isMovingConstructable>k__BackingField");
			ConstructionManager.NativeFieldInfoPtr_onNewConstructableBuilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "onNewConstructableBuilt");
			ConstructionManager.NativeFieldInfoPtr_onConstructableMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "onConstructableMoved");
			ConstructionManager.NativeFieldInfoPtr_currentProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "currentProperty");
			ConstructionManager.NativeMethodInfoPtr_get_constructionModeEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675958);
			ConstructionManager.NativeMethodInfoPtr_set_constructionModeEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675959);
			ConstructionManager.NativeMethodInfoPtr_get_isDeployingConstructable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675960);
			ConstructionManager.NativeMethodInfoPtr_set_isDeployingConstructable_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675961);
			ConstructionManager.NativeMethodInfoPtr_get_isMovingConstructable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675962);
			ConstructionManager.NativeMethodInfoPtr_set_isMovingConstructable_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675963);
			ConstructionManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675964);
			ConstructionManager.NativeMethodInfoPtr_EnterConstructionMode_Public_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675965);
			ConstructionManager.NativeMethodInfoPtr_ExitConstructionMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675966);
			ConstructionManager.NativeMethodInfoPtr_DeployConstructable_Public_Void_ConstructionMenuListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675967);
			ConstructionManager.NativeMethodInfoPtr_StopConstructableDeploy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675968);
			ConstructionManager.NativeMethodInfoPtr_MoveConstructable_Public_Void_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675969);
			ConstructionManager.NativeMethodInfoPtr_StopMovingConstructable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675970);
			ConstructionManager.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675971);
			ConstructionManager.NativeMethodInfoPtr_CreateConstructable_GridBased_Public_Constructable_GridBased_String_Grid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675972);
			ConstructionManager.NativeMethodInfoPtr_CreateConstructable_Public_Constructable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675973);
			ConstructionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675974);
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x060063EB RID: 25579 RVA: 0x001C4C84 File Offset: 0x001C2E84
		// (set) Token: 0x060063EC RID: 25580 RVA: 0x001C4CC0 File Offset: 0x001C2EC0
		public unsafe bool constructionModeEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_get_constructionModeEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_set_constructionModeEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x060063ED RID: 25581 RVA: 0x001C4D00 File Offset: 0x001C2F00
		// (set) Token: 0x060063EE RID: 25582 RVA: 0x001C4D3C File Offset: 0x001C2F3C
		public unsafe bool isDeployingConstructable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_get_isDeployingConstructable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 50985, RefRangeEnd = 50988, XrefRangeStart = 50985, XrefRangeEnd = 50988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_set_isDeployingConstructable_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x060063EF RID: 25583 RVA: 0x001C4D7C File Offset: 0x001C2F7C
		// (set) Token: 0x060063F0 RID: 25584 RVA: 0x001C4DB8 File Offset: 0x001C2FB8
		public unsafe bool isMovingConstructable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_get_isMovingConstructable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_set_isMovingConstructable_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x001C4DF8 File Offset: 0x001C2FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204015, XrefRangeEnd = 204028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x001C4E34 File Offset: 0x001C3034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204044, RefRangeEnd = 204045, XrefRangeStart = 204028, XrefRangeEnd = 204044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterConstructionMode(Property prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_EnterConstructionMode_Public_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x001C4E78 File Offset: 0x001C3078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204066, RefRangeEnd = 204067, XrefRangeStart = 204045, XrefRangeEnd = 204066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitConstructionMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_ExitConstructionMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x001C4EAC File Offset: 0x001C30AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204090, RefRangeEnd = 204092, XrefRangeStart = 204067, XrefRangeEnd = 204090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeployConstructable(ConstructionMenu.ConstructionMenuListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_DeployConstructable_Public_Void_ConstructionMenuListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x001C4EF0 File Offset: 0x001C30F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204096, RefRangeEnd = 204097, XrefRangeStart = 204092, XrefRangeEnd = 204096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopConstructableDeploy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_StopConstructableDeploy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F6 RID: 25590 RVA: 0x001C4F24 File Offset: 0x001C3124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204118, RefRangeEnd = 204119, XrefRangeStart = 204097, XrefRangeEnd = 204118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveConstructable(Constructable_GridBased c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_MoveConstructable_Public_Void_Constructable_GridBased_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x001C4F68 File Offset: 0x001C3168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204119, XrefRangeEnd = 204123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopMovingConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_StopMovingConstructable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F8 RID: 25592 RVA: 0x001C4F9C File Offset: 0x001C319C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204123, XrefRangeEnd = 204125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x001C4FE0 File Offset: 0x001C31E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204125, XrefRangeEnd = 204137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable_GridBased CreateConstructable_GridBased(string ID, Grid grid, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_CreateConstructable_GridBased_Public_Constructable_GridBased_String_Grid_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr3) : null;
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x001C5060 File Offset: 0x001C3260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204148, RefRangeEnd = 204149, XrefRangeStart = 204137, XrefRangeEnd = 204148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable CreateConstructable(string prefabID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_CreateConstructable_Public_Constructable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr3) : null;
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x001C50B0 File Offset: 0x001C32B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204149, XrefRangeEnd = 204152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x0002F40F File Offset: 0x0002D60F
		public ConstructionManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x060063FD RID: 25597 RVA: 0x001C50EC File Offset: 0x001C32EC
		// (set) Token: 0x060063FE RID: 25598 RVA: 0x0002F418 File Offset: 0x0002D618
		public unsafe NetworkObject networkObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_networkObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_networkObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x060063FF RID: 25599 RVA: 0x001C511C File Offset: 0x001C331C
		// (set) Token: 0x06006400 RID: 25600 RVA: 0x0002F437 File Offset: 0x0002D637
		public unsafe bool _constructionModeEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__constructionModeEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__constructionModeEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x06006401 RID: 25601 RVA: 0x001C5144 File Offset: 0x001C3344
		// (set) Token: 0x06006402 RID: 25602 RVA: 0x0002F452 File Offset: 0x0002D652
		public unsafe Action onConstructionModeEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructionModeEnabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructionModeEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x06006403 RID: 25603 RVA: 0x001C5174 File Offset: 0x001C3374
		// (set) Token: 0x06006404 RID: 25604 RVA: 0x0002F471 File Offset: 0x0002D671
		public unsafe Action onConstructionModeDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructionModeDisabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructionModeDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x06006405 RID: 25605 RVA: 0x001C51A4 File Offset: 0x001C33A4
		// (set) Token: 0x06006406 RID: 25606 RVA: 0x0002F490 File Offset: 0x0002D690
		public unsafe bool _isDeployingConstructable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__isDeployingConstructable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__isDeployingConstructable_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x06006407 RID: 25607 RVA: 0x001C51CC File Offset: 0x001C33CC
		// (set) Token: 0x06006408 RID: 25608 RVA: 0x0002F4AB File Offset: 0x0002D6AB
		public unsafe GameObject constructHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_constructHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_constructHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x06006409 RID: 25609 RVA: 0x001C51FC File Offset: 0x001C33FC
		// (set) Token: 0x0600640A RID: 25610 RVA: 0x0002F4CA File Offset: 0x0002D6CA
		public unsafe bool _isMovingConstructable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__isMovingConstructable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__isMovingConstructable_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x0600640B RID: 25611 RVA: 0x001C5224 File Offset: 0x001C3424
		// (set) Token: 0x0600640C RID: 25612 RVA: 0x0002F4E5 File Offset: 0x0002D6E5
		public unsafe ConstructionManager.ConstructableNotification onNewConstructableBuilt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onNewConstructableBuilt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionManager.ConstructableNotification>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onNewConstructableBuilt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x0600640D RID: 25613 RVA: 0x001C5254 File Offset: 0x001C3454
		// (set) Token: 0x0600640E RID: 25614 RVA: 0x0002F504 File Offset: 0x0002D704
		public unsafe ConstructionManager.ConstructableNotification onConstructableMoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructableMoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionManager.ConstructableNotification>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructableMoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x0600640F RID: 25615 RVA: 0x001C5284 File Offset: 0x001C3484
		// (set) Token: 0x06006410 RID: 25616 RVA: 0x0002F523 File Offset: 0x0002D723
		public unsafe Property currentProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_currentProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_currentProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400442E RID: 17454
		private static readonly IntPtr NativeFieldInfoPtr_networkObject;

		// Token: 0x0400442F RID: 17455
		private static readonly IntPtr NativeFieldInfoPtr__constructionModeEnabled_k__BackingField;

		// Token: 0x04004430 RID: 17456
		private static readonly IntPtr NativeFieldInfoPtr_onConstructionModeEnabled;

		// Token: 0x04004431 RID: 17457
		private static readonly IntPtr NativeFieldInfoPtr_onConstructionModeDisabled;

		// Token: 0x04004432 RID: 17458
		private static readonly IntPtr NativeFieldInfoPtr__isDeployingConstructable_k__BackingField;

		// Token: 0x04004433 RID: 17459
		private static readonly IntPtr NativeFieldInfoPtr_constructHandler;

		// Token: 0x04004434 RID: 17460
		private static readonly IntPtr NativeFieldInfoPtr__isMovingConstructable_k__BackingField;

		// Token: 0x04004435 RID: 17461
		private static readonly IntPtr NativeFieldInfoPtr_onNewConstructableBuilt;

		// Token: 0x04004436 RID: 17462
		private static readonly IntPtr NativeFieldInfoPtr_onConstructableMoved;

		// Token: 0x04004437 RID: 17463
		private static readonly IntPtr NativeFieldInfoPtr_currentProperty;

		// Token: 0x04004438 RID: 17464
		private static readonly IntPtr NativeMethodInfoPtr_get_constructionModeEnabled_Public_get_Boolean_0;

		// Token: 0x04004439 RID: 17465
		private static readonly IntPtr NativeMethodInfoPtr_set_constructionModeEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x0400443A RID: 17466
		private static readonly IntPtr NativeMethodInfoPtr_get_isDeployingConstructable_Public_get_Boolean_0;

		// Token: 0x0400443B RID: 17467
		private static readonly IntPtr NativeMethodInfoPtr_set_isDeployingConstructable_Protected_set_Void_Boolean_0;

		// Token: 0x0400443C RID: 17468
		private static readonly IntPtr NativeMethodInfoPtr_get_isMovingConstructable_Public_get_Boolean_0;

		// Token: 0x0400443D RID: 17469
		private static readonly IntPtr NativeMethodInfoPtr_set_isMovingConstructable_Protected_set_Void_Boolean_0;

		// Token: 0x0400443E RID: 17470
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400443F RID: 17471
		private static readonly IntPtr NativeMethodInfoPtr_EnterConstructionMode_Public_Void_Property_0;

		// Token: 0x04004440 RID: 17472
		private static readonly IntPtr NativeMethodInfoPtr_ExitConstructionMode_Public_Void_0;

		// Token: 0x04004441 RID: 17473
		private static readonly IntPtr NativeMethodInfoPtr_DeployConstructable_Public_Void_ConstructionMenuListing_0;

		// Token: 0x04004442 RID: 17474
		private static readonly IntPtr NativeMethodInfoPtr_StopConstructableDeploy_Public_Void_0;

		// Token: 0x04004443 RID: 17475
		private static readonly IntPtr NativeMethodInfoPtr_MoveConstructable_Public_Void_Constructable_GridBased_0;

		// Token: 0x04004444 RID: 17476
		private static readonly IntPtr NativeMethodInfoPtr_StopMovingConstructable_Public_Void_0;

		// Token: 0x04004445 RID: 17477
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04004446 RID: 17478
		private static readonly IntPtr NativeMethodInfoPtr_CreateConstructable_GridBased_Public_Constructable_GridBased_String_Grid_Vector2_Single_0;

		// Token: 0x04004447 RID: 17479
		private static readonly IntPtr NativeMethodInfoPtr_CreateConstructable_Public_Constructable_String_0;

		// Token: 0x04004448 RID: 17480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A2B RID: 2603
		public class WorldIntersection : Il2CppSystem.Object
		{
			// Token: 0x0600CF53 RID: 53075 RVA: 0x0031D0A0 File Offset: 0x0031B2A0
			// Note: this type is marked as 'beforefieldinit'.
			static WorldIntersection()
			{
				Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "WorldIntersection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr);
				ConstructionManager.WorldIntersection.NativeFieldInfoPtr_footprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr, "footprint");
				ConstructionManager.WorldIntersection.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr, "tile");
				ConstructionManager.WorldIntersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr, 100675975);
			}

			// Token: 0x0600CF54 RID: 53076 RVA: 0x0031D108 File Offset: 0x0031B308
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WorldIntersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.WorldIntersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF55 RID: 53077 RVA: 0x00064DB5 File Offset: 0x00062FB5
			public WorldIntersection(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004070 RID: 16496
			// (get) Token: 0x0600CF56 RID: 53078 RVA: 0x0031D144 File Offset: 0x0031B344
			// (set) Token: 0x0600CF57 RID: 53079 RVA: 0x00064DBE File Offset: 0x00062FBE
			public unsafe FootprintTile footprint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.WorldIntersection.NativeFieldInfoPtr_footprint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.WorldIntersection.NativeFieldInfoPtr_footprint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004071 RID: 16497
			// (get) Token: 0x0600CF58 RID: 53080 RVA: 0x0031D174 File Offset: 0x0031B374
			// (set) Token: 0x0600CF59 RID: 53081 RVA: 0x00064DDD File Offset: 0x00062FDD
			public unsafe Tile tile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.WorldIntersection.NativeFieldInfoPtr_tile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.WorldIntersection.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BE1 RID: 35809
			private static readonly IntPtr NativeFieldInfoPtr_footprint;

			// Token: 0x04008BE2 RID: 35810
			private static readonly IntPtr NativeFieldInfoPtr_tile;

			// Token: 0x04008BE3 RID: 35811
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A2C RID: 2604
		public sealed class ConstructableNotification : MulticastDelegate
		{
			// Token: 0x0600CF5A RID: 53082 RVA: 0x0031D1A4 File Offset: 0x0031B3A4
			// Note: this type is marked as 'beforefieldinit'.
			static ConstructableNotification()
			{
				Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "ConstructableNotification");
				ConstructionManager.ConstructableNotification.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr, 100675976);
				ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr, 100675977);
				ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Constructable_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr, 100675978);
				ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr, 100675979);
			}

			// Token: 0x0600CF5B RID: 53083 RVA: 0x0031D218 File Offset: 0x0031B418
			[CallerCount(632)]
			[CachedScanResults(RefRangeStart = 81889, RefRangeEnd = 82521, XrefRangeStart = 81889, XrefRangeEnd = 82521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConstructableNotification(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.ConstructableNotification.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF5C RID: 53084 RVA: 0x0031D274 File Offset: 0x0031B474
			[CallerCount(0)]
			public unsafe void Invoke(Constructable c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF5D RID: 53085 RVA: 0x0031D2B8 File Offset: 0x0031B4B8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Constructable c, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Constructable_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600CF5E RID: 53086 RVA: 0x0031D32C File Offset: 0x0031B52C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF5F RID: 53087 RVA: 0x00064DFC File Offset: 0x00062FFC
			public ConstructableNotification(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CF60 RID: 53088 RVA: 0x00064E05 File Offset: 0x00063005
			public static implicit operator ConstructionManager.ConstructableNotification(Action<Constructable> A_0)
			{
				return DelegateSupport.ConvertDelegate<ConstructionManager.ConstructableNotification>(A_0);
			}

			// Token: 0x0600CF61 RID: 53089 RVA: 0x00064E0D File Offset: 0x0006300D
			public static ConstructionManager.ConstructableNotification operator +(ConstructionManager.ConstructableNotification A_0, ConstructionManager.ConstructableNotification A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ConstructionManager.ConstructableNotification>();
			}

			// Token: 0x0600CF62 RID: 53090 RVA: 0x00064E1B File Offset: 0x0006301B
			public static ConstructionManager.ConstructableNotification operator -(ConstructionManager.ConstructableNotification A_0, ConstructionManager.ConstructableNotification A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<ConstructionManager.ConstructableNotification>();
				}
				return result;
			}

			// Token: 0x04008BE4 RID: 35812
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008BE5 RID: 35813
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Constructable_0;

			// Token: 0x04008BE6 RID: 35814
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Constructable_AsyncCallback_Object_0;

			// Token: 0x04008BE7 RID: 35815
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
