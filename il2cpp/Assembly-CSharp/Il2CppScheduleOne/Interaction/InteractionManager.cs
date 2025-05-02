using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x020003F3 RID: 1011
	public class InteractionManager : Singleton<InteractionManager>
	{
		// Token: 0x06005393 RID: 21395 RVA: 0x00189898 File Offset: 0x00187A98
		// Note: this type is marked as 'beforefieldinit'.
		static InteractionManager()
		{
			Il2CppClassPointerStore<InteractionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "InteractionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr);
			InteractionManager.NativeFieldInfoPtr_RayRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "RayRadius");
			InteractionManager.NativeFieldInfoPtr_MaxInteractionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "MaxInteractionRange");
			InteractionManager.NativeFieldInfoPtr_interaction_SearchMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interaction_SearchMask");
			InteractionManager.NativeFieldInfoPtr_rightClickRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "rightClickRange");
			InteractionManager.NativeFieldInfoPtr_interactionSearchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionSearchType");
			InteractionManager.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "DEBUG");
			InteractionManager.NativeFieldInfoPtr__CanDestroy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<CanDestroy>k__BackingField");
			InteractionManager.NativeFieldInfoPtr_messageColor_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "messageColor_Default");
			InteractionManager.NativeFieldInfoPtr_iconColor_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "iconColor_Default");
			InteractionManager.NativeFieldInfoPtr_iconColor_Default_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "iconColor_Default_Key");
			InteractionManager.NativeFieldInfoPtr_messageColor_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "messageColor_Invalid");
			InteractionManager.NativeFieldInfoPtr_iconColor_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "iconColor_Invalid");
			InteractionManager.NativeFieldInfoPtr_icon_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "icon_Key");
			InteractionManager.NativeFieldInfoPtr_icon_LeftMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "icon_LeftMouse");
			InteractionManager.NativeFieldInfoPtr_icon_Cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "icon_Cross");
			InteractionManager.NativeFieldInfoPtr_displaySizeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "displaySizeMultiplier");
			InteractionManager.NativeFieldInfoPtr_interaction_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interaction_Canvas");
			InteractionManager.NativeFieldInfoPtr_interactionDisplay_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplay_Container");
			InteractionManager.NativeFieldInfoPtr_interactionDisplay_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplay_Icon");
			InteractionManager.NativeFieldInfoPtr_interactionDisplay_IconText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplay_IconText");
			InteractionManager.NativeFieldInfoPtr_interactionDisplay_MessageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplay_MessageText");
			InteractionManager.NativeFieldInfoPtr_wsLabelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "wsLabelContainer");
			InteractionManager.NativeFieldInfoPtr_InteractInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "InteractInput");
			InteractionManager.NativeFieldInfoPtr_InteractKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "InteractKey");
			InteractionManager.NativeFieldInfoPtr_backgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "backgroundImage");
			InteractionManager.NativeFieldInfoPtr_WSLabelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "WSLabelPrefab");
			InteractionManager.NativeFieldInfoPtr__hoveredInteractableObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<hoveredInteractableObject>k__BackingField");
			InteractionManager.NativeFieldInfoPtr__hoveredValidInteractableObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<hoveredValidInteractableObject>k__BackingField");
			InteractionManager.NativeFieldInfoPtr__interactedObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<interactedObject>k__BackingField");
			InteractionManager.NativeFieldInfoPtr_interactionDisplayEnabledThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplayEnabledThisFrame");
			InteractionManager.NativeFieldInfoPtr_itemBeingDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "itemBeingDestroyed");
			InteractionManager.NativeFieldInfoPtr_palletBeingDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "palletBeingDestroyed");
			InteractionManager.NativeFieldInfoPtr_constructableBeingDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "constructableBeingDestroyed");
			InteractionManager.NativeFieldInfoPtr_destroyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "destroyTime");
			InteractionManager.NativeFieldInfoPtr_tempDisplayScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "tempDisplayScale");
			InteractionManager.NativeFieldInfoPtr_interactCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactCooldown");
			InteractionManager.NativeFieldInfoPtr_timeSinceLastInteractStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "timeSinceLastInteractStart");
			InteractionManager.NativeFieldInfoPtr_activeWSlabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "activeWSlabels");
			InteractionManager.NativeFieldInfoPtr_timeToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "timeToDestroy");
			InteractionManager.NativeFieldInfoPtr_ILerpDisplayScale_Coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "ILerpDisplayScale_Coroutine");
			InteractionManager.NativeMethodInfoPtr_get_Interaction_SearchMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673735);
			InteractionManager.NativeMethodInfoPtr_get_CanDestroy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673736);
			InteractionManager.NativeMethodInfoPtr_set_CanDestroy_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673737);
			InteractionManager.NativeMethodInfoPtr_get_hoveredInteractableObject_Public_get_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673738);
			InteractionManager.NativeMethodInfoPtr_set_hoveredInteractableObject_Protected_set_Void_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673739);
			InteractionManager.NativeMethodInfoPtr_get_hoveredValidInteractableObject_Public_get_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673740);
			InteractionManager.NativeMethodInfoPtr_set_hoveredValidInteractableObject_Protected_set_Void_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673741);
			InteractionManager.NativeMethodInfoPtr_get_interactedObject_Public_get_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673742);
			InteractionManager.NativeMethodInfoPtr_set_interactedObject_Protected_set_Void_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673743);
			InteractionManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673744);
			InteractionManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673745);
			InteractionManager.NativeMethodInfoPtr_LoadInteractKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673746);
			InteractionManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673747);
			InteractionManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673748);
			InteractionManager.NativeMethodInfoPtr_CheckHover_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673749);
			InteractionManager.NativeMethodInfoPtr_CheckInteraction_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673750);
			InteractionManager.NativeMethodInfoPtr_CheckRightClick_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673751);
			InteractionManager.NativeMethodInfoPtr_GetHoveredBuildableItem_Protected_Virtual_New_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673752);
			InteractionManager.NativeMethodInfoPtr_GetHoveredPallet_Protected_Virtual_New_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673753);
			InteractionManager.NativeMethodInfoPtr_GetHoveredConstructable_Protected_Virtual_New_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673754);
			InteractionManager.NativeMethodInfoPtr_SetCanDestroy_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673755);
			InteractionManager.NativeMethodInfoPtr_EnableInteractionDisplay_Public_Void_Vector3_Sprite_String_String_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673756);
			InteractionManager.NativeMethodInfoPtr_LerpDisplayScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673757);
			InteractionManager.NativeMethodInfoPtr_ILerpDisplayScale_Protected_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673758);
			InteractionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100673759);
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06005394 RID: 21396 RVA: 0x00189DDC File Offset: 0x00187FDC
		public unsafe LayerMask Interaction_SearchMask
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29988, RefRangeEnd = 29989, XrefRangeStart = 29988, XrefRangeEnd = 29989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_Interaction_SearchMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x06005395 RID: 21397 RVA: 0x00189E18 File Offset: 0x00188018
		// (set) Token: 0x06005396 RID: 21398 RVA: 0x00189E54 File Offset: 0x00188054
		public unsafe bool CanDestroy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_CanDestroy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_CanDestroy_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x06005397 RID: 21399 RVA: 0x00189E94 File Offset: 0x00188094
		// (set) Token: 0x06005398 RID: 21400 RVA: 0x00189ED4 File Offset: 0x001880D4
		public unsafe InteractableObject hoveredInteractableObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_hoveredInteractableObject_Public_get_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179187, XrefRangeEnd = 179188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_hoveredInteractableObject_Protected_set_Void_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x06005399 RID: 21401 RVA: 0x00189F18 File Offset: 0x00188118
		// (set) Token: 0x0600539A RID: 21402 RVA: 0x00189F58 File Offset: 0x00188158
		public unsafe InteractableObject hoveredValidInteractableObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_hoveredValidInteractableObject_Public_get_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_hoveredValidInteractableObject_Protected_set_Void_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x0600539B RID: 21403 RVA: 0x00189F9C File Offset: 0x0018819C
		// (set) Token: 0x0600539C RID: 21404 RVA: 0x00189FDC File Offset: 0x001881DC
		public unsafe InteractableObject interactedObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_interactedObject_Public_get_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_interactedObject_Protected_set_Void_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x0018A020 File Offset: 0x00188220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179188, XrefRangeEnd = 179232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x0018A05C File Offset: 0x0018825C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179232, XrefRangeEnd = 179256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x0018A098 File Offset: 0x00188298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179256, XrefRangeEnd = 179264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadInteractKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_LoadInteractKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x0018A0CC File Offset: 0x001882CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179264, XrefRangeEnd = 179268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x0018A108 File Offset: 0x00188308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179268, XrefRangeEnd = 179285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x0018A144 File Offset: 0x00188344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179285, XrefRangeEnd = 179497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_CheckHover_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x0018A180 File Offset: 0x00188380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179497, XrefRangeEnd = 179538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckInteraction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_CheckInteraction_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x0018A1BC File Offset: 0x001883BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179538, XrefRangeEnd = 179576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckRightClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_CheckRightClick_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x0018A1F8 File Offset: 0x001883F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179576, XrefRangeEnd = 179586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BuildableItem GetHoveredBuildableItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_GetHoveredBuildableItem_Protected_Virtual_New_BuildableItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr3) : null;
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x0018A244 File Offset: 0x00188444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179586, XrefRangeEnd = 179602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Pallet GetHoveredPallet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_GetHoveredPallet_Protected_Virtual_New_Pallet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr3) : null;
		}

		// Token: 0x060053A7 RID: 21415 RVA: 0x0018A290 File Offset: 0x00188490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179602, XrefRangeEnd = 179612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Constructable GetHoveredConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_GetHoveredConstructable_Protected_Virtual_New_Constructable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr3) : null;
		}

		// Token: 0x060053A8 RID: 21416 RVA: 0x0018A2DC File Offset: 0x001884DC
		[CallerCount(0)]
		public unsafe void SetCanDestroy(bool canDestroy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref canDestroy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_SetCanDestroy_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A9 RID: 21417 RVA: 0x0018A31C File Offset: 0x0018851C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179612, XrefRangeEnd = 179645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableInteractionDisplay(Vector3 pos, Sprite icon, string spriteText, string message, Color messageColor, Color iconColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spriteText);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageColor;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iconColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_EnableInteractionDisplay_Public_Void_Vector3_Sprite_String_String_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x0018A3B0 File Offset: 0x001885B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 179653, RefRangeEnd = 179655, XrefRangeStart = 179645, XrefRangeEnd = 179653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpDisplayScale(float endScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_LerpDisplayScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x0018A3F0 File Offset: 0x001885F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179655, XrefRangeEnd = 179660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ILerpDisplayScale(float startScale, float endScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startScale;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_ILerpDisplayScale_Protected_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060053AC RID: 21420 RVA: 0x0018A44C File Offset: 0x0018864C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179660, XrefRangeEnd = 179673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractionManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053AD RID: 21421 RVA: 0x00027E81 File Offset: 0x00026081
		public InteractionManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x060053AE RID: 21422 RVA: 0x0018A488 File Offset: 0x00188688
		// (set) Token: 0x060053AF RID: 21423 RVA: 0x00027E8A File Offset: 0x0002608A
		public unsafe static float RayRadius
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_RayRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_RayRadius, (void*)(&value));
			}
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x060053B0 RID: 21424 RVA: 0x0018A4A4 File Offset: 0x001886A4
		// (set) Token: 0x060053B1 RID: 21425 RVA: 0x00027E98 File Offset: 0x00026098
		public unsafe static float MaxInteractionRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_MaxInteractionRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_MaxInteractionRange, (void*)(&value));
			}
		}

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x060053B2 RID: 21426 RVA: 0x0018A4C0 File Offset: 0x001886C0
		// (set) Token: 0x060053B3 RID: 21427 RVA: 0x00027EA6 File Offset: 0x000260A6
		public unsafe LayerMask interaction_SearchMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interaction_SearchMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interaction_SearchMask)) = value;
			}
		}

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x060053B4 RID: 21428 RVA: 0x0018A4E8 File Offset: 0x001886E8
		// (set) Token: 0x060053B5 RID: 21429 RVA: 0x00027EC1 File Offset: 0x000260C1
		public unsafe float rightClickRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_rightClickRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_rightClickRange)) = value;
			}
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x060053B6 RID: 21430 RVA: 0x0018A510 File Offset: 0x00188710
		// (set) Token: 0x060053B7 RID: 21431 RVA: 0x00027EDC File Offset: 0x000260DC
		public unsafe EInteractionSearchType interactionSearchType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionSearchType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionSearchType)) = value;
			}
		}

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x060053B8 RID: 21432 RVA: 0x0018A538 File Offset: 0x00188738
		// (set) Token: 0x060053B9 RID: 21433 RVA: 0x00027EF7 File Offset: 0x000260F7
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x060053BA RID: 21434 RVA: 0x0018A560 File Offset: 0x00188760
		// (set) Token: 0x060053BB RID: 21435 RVA: 0x00027F12 File Offset: 0x00026112
		public unsafe bool _CanDestroy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__CanDestroy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__CanDestroy_k__BackingField)) = value;
			}
		}

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x060053BC RID: 21436 RVA: 0x0018A588 File Offset: 0x00188788
		// (set) Token: 0x060053BD RID: 21437 RVA: 0x00027F2D File Offset: 0x0002612D
		public unsafe Color messageColor_Default
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Default);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Default)) = value;
			}
		}

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x060053BE RID: 21438 RVA: 0x0018A5B0 File Offset: 0x001887B0
		// (set) Token: 0x060053BF RID: 21439 RVA: 0x00027F48 File Offset: 0x00026148
		public unsafe Color iconColor_Default
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default)) = value;
			}
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x060053C0 RID: 21440 RVA: 0x0018A5D8 File Offset: 0x001887D8
		// (set) Token: 0x060053C1 RID: 21441 RVA: 0x00027F63 File Offset: 0x00026163
		public unsafe Color iconColor_Default_Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default_Key);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default_Key)) = value;
			}
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x060053C2 RID: 21442 RVA: 0x0018A600 File Offset: 0x00188800
		// (set) Token: 0x060053C3 RID: 21443 RVA: 0x00027F7E File Offset: 0x0002617E
		public unsafe Color messageColor_Invalid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Invalid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Invalid)) = value;
			}
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x060053C4 RID: 21444 RVA: 0x0018A628 File Offset: 0x00188828
		// (set) Token: 0x060053C5 RID: 21445 RVA: 0x00027F99 File Offset: 0x00026199
		public unsafe Color iconColor_Invalid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Invalid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Invalid)) = value;
			}
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x060053C6 RID: 21446 RVA: 0x0018A650 File Offset: 0x00188850
		// (set) Token: 0x060053C7 RID: 21447 RVA: 0x00027FB4 File Offset: 0x000261B4
		public unsafe Sprite icon_Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x060053C8 RID: 21448 RVA: 0x0018A680 File Offset: 0x00188880
		// (set) Token: 0x060053C9 RID: 21449 RVA: 0x00027FD3 File Offset: 0x000261D3
		public unsafe Sprite icon_LeftMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_LeftMouse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_LeftMouse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x060053CA RID: 21450 RVA: 0x0018A6B0 File Offset: 0x001888B0
		// (set) Token: 0x060053CB RID: 21451 RVA: 0x00027FF2 File Offset: 0x000261F2
		public unsafe Sprite icon_Cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x060053CC RID: 21452 RVA: 0x0018A6E0 File Offset: 0x001888E0
		// (set) Token: 0x060053CD RID: 21453 RVA: 0x00028011 File Offset: 0x00026211
		public unsafe float displaySizeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_displaySizeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_displaySizeMultiplier)) = value;
			}
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x060053CE RID: 21454 RVA: 0x0018A708 File Offset: 0x00188908
		// (set) Token: 0x060053CF RID: 21455 RVA: 0x0002802C File Offset: 0x0002622C
		public unsafe Canvas interaction_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interaction_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interaction_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x060053D0 RID: 21456 RVA: 0x0018A738 File Offset: 0x00188938
		// (set) Token: 0x060053D1 RID: 21457 RVA: 0x0002804B File Offset: 0x0002624B
		public unsafe RectTransform interactionDisplay_Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x060053D2 RID: 21458 RVA: 0x0018A768 File Offset: 0x00188968
		// (set) Token: 0x060053D3 RID: 21459 RVA: 0x0002806A File Offset: 0x0002626A
		public unsafe Image interactionDisplay_Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x060053D4 RID: 21460 RVA: 0x0018A798 File Offset: 0x00188998
		// (set) Token: 0x060053D5 RID: 21461 RVA: 0x00028089 File Offset: 0x00026289
		public unsafe Text interactionDisplay_IconText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_IconText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_IconText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x060053D6 RID: 21462 RVA: 0x0018A7C8 File Offset: 0x001889C8
		// (set) Token: 0x060053D7 RID: 21463 RVA: 0x000280A8 File Offset: 0x000262A8
		public unsafe Text interactionDisplay_MessageText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_MessageText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_MessageText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x060053D8 RID: 21464 RVA: 0x0018A7F8 File Offset: 0x001889F8
		// (set) Token: 0x060053D9 RID: 21465 RVA: 0x000280C7 File Offset: 0x000262C7
		public unsafe RectTransform wsLabelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_wsLabelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_wsLabelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x060053DA RID: 21466 RVA: 0x0018A828 File Offset: 0x00188A28
		// (set) Token: 0x060053DB RID: 21467 RVA: 0x000280E6 File Offset: 0x000262E6
		public unsafe InputActionReference InteractInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_InteractInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_InteractInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x060053DC RID: 21468 RVA: 0x0018A858 File Offset: 0x00188A58
		// (set) Token: 0x060053DD RID: 21469 RVA: 0x00028105 File Offset: 0x00026305
		public unsafe string InteractKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_InteractKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_InteractKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x060053DE RID: 21470 RVA: 0x0018A880 File Offset: 0x00188A80
		// (set) Token: 0x060053DF RID: 21471 RVA: 0x00028124 File Offset: 0x00026324
		public unsafe RectTransform backgroundImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_backgroundImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_backgroundImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x060053E0 RID: 21472 RVA: 0x0018A8B0 File Offset: 0x00188AB0
		// (set) Token: 0x060053E1 RID: 21473 RVA: 0x00028143 File Offset: 0x00026343
		public unsafe GameObject WSLabelPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_WSLabelPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_WSLabelPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x060053E2 RID: 21474 RVA: 0x0018A8E0 File Offset: 0x00188AE0
		// (set) Token: 0x060053E3 RID: 21475 RVA: 0x00028162 File Offset: 0x00026362
		public unsafe InteractableObject _hoveredInteractableObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__hoveredInteractableObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__hoveredInteractableObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x060053E4 RID: 21476 RVA: 0x0018A910 File Offset: 0x00188B10
		// (set) Token: 0x060053E5 RID: 21477 RVA: 0x00028181 File Offset: 0x00026381
		public unsafe InteractableObject _hoveredValidInteractableObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__hoveredValidInteractableObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__hoveredValidInteractableObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x060053E6 RID: 21478 RVA: 0x0018A940 File Offset: 0x00188B40
		// (set) Token: 0x060053E7 RID: 21479 RVA: 0x000281A0 File Offset: 0x000263A0
		public unsafe InteractableObject _interactedObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__interactedObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__interactedObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x060053E8 RID: 21480 RVA: 0x0018A970 File Offset: 0x00188B70
		// (set) Token: 0x060053E9 RID: 21481 RVA: 0x000281BF File Offset: 0x000263BF
		public unsafe bool interactionDisplayEnabledThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplayEnabledThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplayEnabledThisFrame)) = value;
			}
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x060053EA RID: 21482 RVA: 0x0018A998 File Offset: 0x00188B98
		// (set) Token: 0x060053EB RID: 21483 RVA: 0x000281DA File Offset: 0x000263DA
		public unsafe BuildableItem itemBeingDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_itemBeingDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_itemBeingDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x060053EC RID: 21484 RVA: 0x0018A9C8 File Offset: 0x00188BC8
		// (set) Token: 0x060053ED RID: 21485 RVA: 0x000281F9 File Offset: 0x000263F9
		public unsafe Pallet palletBeingDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_palletBeingDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_palletBeingDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x060053EE RID: 21486 RVA: 0x0018A9F8 File Offset: 0x00188BF8
		// (set) Token: 0x060053EF RID: 21487 RVA: 0x00028218 File Offset: 0x00026418
		public unsafe Constructable constructableBeingDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_constructableBeingDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_constructableBeingDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x060053F0 RID: 21488 RVA: 0x0018AA28 File Offset: 0x00188C28
		// (set) Token: 0x060053F1 RID: 21489 RVA: 0x00028237 File Offset: 0x00026437
		public unsafe float destroyTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_destroyTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_destroyTime)) = value;
			}
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x060053F2 RID: 21490 RVA: 0x0018AA50 File Offset: 0x00188C50
		// (set) Token: 0x060053F3 RID: 21491 RVA: 0x00028252 File Offset: 0x00026452
		public unsafe float tempDisplayScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_tempDisplayScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_tempDisplayScale)) = value;
			}
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x060053F4 RID: 21492 RVA: 0x0018AA78 File Offset: 0x00188C78
		// (set) Token: 0x060053F5 RID: 21493 RVA: 0x0002826D File Offset: 0x0002646D
		public unsafe static float interactCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_interactCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_interactCooldown, (void*)(&value));
			}
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x060053F6 RID: 21494 RVA: 0x0018AA94 File Offset: 0x00188C94
		// (set) Token: 0x060053F7 RID: 21495 RVA: 0x0002827B File Offset: 0x0002647B
		public unsafe float timeSinceLastInteractStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_timeSinceLastInteractStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_timeSinceLastInteractStart)) = value;
			}
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x060053F8 RID: 21496 RVA: 0x0018AABC File Offset: 0x00188CBC
		// (set) Token: 0x060053F9 RID: 21497 RVA: 0x00028296 File Offset: 0x00026496
		public unsafe List<WorldSpaceLabel> activeWSlabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_activeWSlabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldSpaceLabel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_activeWSlabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x060053FA RID: 21498 RVA: 0x0018AAEC File Offset: 0x00188CEC
		// (set) Token: 0x060053FB RID: 21499 RVA: 0x000282B5 File Offset: 0x000264B5
		public unsafe static float timeToDestroy
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_timeToDestroy, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_timeToDestroy, (void*)(&value));
			}
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x0018AB08 File Offset: 0x00188D08
		// (set) Token: 0x060053FD RID: 21501 RVA: 0x000282C3 File Offset: 0x000264C3
		public unsafe Coroutine ILerpDisplayScale_Coroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_ILerpDisplayScale_Coroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_ILerpDisplayScale_Coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040038A8 RID: 14504
		private static readonly IntPtr NativeFieldInfoPtr_RayRadius;

		// Token: 0x040038A9 RID: 14505
		private static readonly IntPtr NativeFieldInfoPtr_MaxInteractionRange;

		// Token: 0x040038AA RID: 14506
		private static readonly IntPtr NativeFieldInfoPtr_interaction_SearchMask;

		// Token: 0x040038AB RID: 14507
		private static readonly IntPtr NativeFieldInfoPtr_rightClickRange;

		// Token: 0x040038AC RID: 14508
		private static readonly IntPtr NativeFieldInfoPtr_interactionSearchType;

		// Token: 0x040038AD RID: 14509
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x040038AE RID: 14510
		private static readonly IntPtr NativeFieldInfoPtr__CanDestroy_k__BackingField;

		// Token: 0x040038AF RID: 14511
		private static readonly IntPtr NativeFieldInfoPtr_messageColor_Default;

		// Token: 0x040038B0 RID: 14512
		private static readonly IntPtr NativeFieldInfoPtr_iconColor_Default;

		// Token: 0x040038B1 RID: 14513
		private static readonly IntPtr NativeFieldInfoPtr_iconColor_Default_Key;

		// Token: 0x040038B2 RID: 14514
		private static readonly IntPtr NativeFieldInfoPtr_messageColor_Invalid;

		// Token: 0x040038B3 RID: 14515
		private static readonly IntPtr NativeFieldInfoPtr_iconColor_Invalid;

		// Token: 0x040038B4 RID: 14516
		private static readonly IntPtr NativeFieldInfoPtr_icon_Key;

		// Token: 0x040038B5 RID: 14517
		private static readonly IntPtr NativeFieldInfoPtr_icon_LeftMouse;

		// Token: 0x040038B6 RID: 14518
		private static readonly IntPtr NativeFieldInfoPtr_icon_Cross;

		// Token: 0x040038B7 RID: 14519
		private static readonly IntPtr NativeFieldInfoPtr_displaySizeMultiplier;

		// Token: 0x040038B8 RID: 14520
		private static readonly IntPtr NativeFieldInfoPtr_interaction_Canvas;

		// Token: 0x040038B9 RID: 14521
		private static readonly IntPtr NativeFieldInfoPtr_interactionDisplay_Container;

		// Token: 0x040038BA RID: 14522
		private static readonly IntPtr NativeFieldInfoPtr_interactionDisplay_Icon;

		// Token: 0x040038BB RID: 14523
		private static readonly IntPtr NativeFieldInfoPtr_interactionDisplay_IconText;

		// Token: 0x040038BC RID: 14524
		private static readonly IntPtr NativeFieldInfoPtr_interactionDisplay_MessageText;

		// Token: 0x040038BD RID: 14525
		private static readonly IntPtr NativeFieldInfoPtr_wsLabelContainer;

		// Token: 0x040038BE RID: 14526
		private static readonly IntPtr NativeFieldInfoPtr_InteractInput;

		// Token: 0x040038BF RID: 14527
		private static readonly IntPtr NativeFieldInfoPtr_InteractKey;

		// Token: 0x040038C0 RID: 14528
		private static readonly IntPtr NativeFieldInfoPtr_backgroundImage;

		// Token: 0x040038C1 RID: 14529
		private static readonly IntPtr NativeFieldInfoPtr_WSLabelPrefab;

		// Token: 0x040038C2 RID: 14530
		private static readonly IntPtr NativeFieldInfoPtr__hoveredInteractableObject_k__BackingField;

		// Token: 0x040038C3 RID: 14531
		private static readonly IntPtr NativeFieldInfoPtr__hoveredValidInteractableObject_k__BackingField;

		// Token: 0x040038C4 RID: 14532
		private static readonly IntPtr NativeFieldInfoPtr__interactedObject_k__BackingField;

		// Token: 0x040038C5 RID: 14533
		private static readonly IntPtr NativeFieldInfoPtr_interactionDisplayEnabledThisFrame;

		// Token: 0x040038C6 RID: 14534
		private static readonly IntPtr NativeFieldInfoPtr_itemBeingDestroyed;

		// Token: 0x040038C7 RID: 14535
		private static readonly IntPtr NativeFieldInfoPtr_palletBeingDestroyed;

		// Token: 0x040038C8 RID: 14536
		private static readonly IntPtr NativeFieldInfoPtr_constructableBeingDestroyed;

		// Token: 0x040038C9 RID: 14537
		private static readonly IntPtr NativeFieldInfoPtr_destroyTime;

		// Token: 0x040038CA RID: 14538
		private static readonly IntPtr NativeFieldInfoPtr_tempDisplayScale;

		// Token: 0x040038CB RID: 14539
		private static readonly IntPtr NativeFieldInfoPtr_interactCooldown;

		// Token: 0x040038CC RID: 14540
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastInteractStart;

		// Token: 0x040038CD RID: 14541
		private static readonly IntPtr NativeFieldInfoPtr_activeWSlabels;

		// Token: 0x040038CE RID: 14542
		private static readonly IntPtr NativeFieldInfoPtr_timeToDestroy;

		// Token: 0x040038CF RID: 14543
		private static readonly IntPtr NativeFieldInfoPtr_ILerpDisplayScale_Coroutine;

		// Token: 0x040038D0 RID: 14544
		private static readonly IntPtr NativeMethodInfoPtr_get_Interaction_SearchMask_Public_get_LayerMask_0;

		// Token: 0x040038D1 RID: 14545
		private static readonly IntPtr NativeMethodInfoPtr_get_CanDestroy_Public_get_Boolean_0;

		// Token: 0x040038D2 RID: 14546
		private static readonly IntPtr NativeMethodInfoPtr_set_CanDestroy_Public_set_Void_Boolean_0;

		// Token: 0x040038D3 RID: 14547
		private static readonly IntPtr NativeMethodInfoPtr_get_hoveredInteractableObject_Public_get_InteractableObject_0;

		// Token: 0x040038D4 RID: 14548
		private static readonly IntPtr NativeMethodInfoPtr_set_hoveredInteractableObject_Protected_set_Void_InteractableObject_0;

		// Token: 0x040038D5 RID: 14549
		private static readonly IntPtr NativeMethodInfoPtr_get_hoveredValidInteractableObject_Public_get_InteractableObject_0;

		// Token: 0x040038D6 RID: 14550
		private static readonly IntPtr NativeMethodInfoPtr_set_hoveredValidInteractableObject_Protected_set_Void_InteractableObject_0;

		// Token: 0x040038D7 RID: 14551
		private static readonly IntPtr NativeMethodInfoPtr_get_interactedObject_Public_get_InteractableObject_0;

		// Token: 0x040038D8 RID: 14552
		private static readonly IntPtr NativeMethodInfoPtr_set_interactedObject_Protected_set_Void_InteractableObject_0;

		// Token: 0x040038D9 RID: 14553
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040038DA RID: 14554
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040038DB RID: 14555
		private static readonly IntPtr NativeMethodInfoPtr_LoadInteractKey_Private_Void_0;

		// Token: 0x040038DC RID: 14556
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040038DD RID: 14557
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040038DE RID: 14558
		private static readonly IntPtr NativeMethodInfoPtr_CheckHover_Protected_Virtual_New_Void_0;

		// Token: 0x040038DF RID: 14559
		private static readonly IntPtr NativeMethodInfoPtr_CheckInteraction_Protected_Virtual_New_Void_0;

		// Token: 0x040038E0 RID: 14560
		private static readonly IntPtr NativeMethodInfoPtr_CheckRightClick_Protected_Virtual_New_Void_0;

		// Token: 0x040038E1 RID: 14561
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredBuildableItem_Protected_Virtual_New_BuildableItem_0;

		// Token: 0x040038E2 RID: 14562
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredPallet_Protected_Virtual_New_Pallet_0;

		// Token: 0x040038E3 RID: 14563
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredConstructable_Protected_Virtual_New_Constructable_0;

		// Token: 0x040038E4 RID: 14564
		private static readonly IntPtr NativeMethodInfoPtr_SetCanDestroy_Public_Void_Boolean_0;

		// Token: 0x040038E5 RID: 14565
		private static readonly IntPtr NativeMethodInfoPtr_EnableInteractionDisplay_Public_Void_Vector3_Sprite_String_String_Color_Color_0;

		// Token: 0x040038E6 RID: 14566
		private static readonly IntPtr NativeMethodInfoPtr_LerpDisplayScale_Public_Void_Single_0;

		// Token: 0x040038E7 RID: 14567
		private static readonly IntPtr NativeMethodInfoPtr_ILerpDisplayScale_Protected_IEnumerator_Single_Single_0;

		// Token: 0x040038E8 RID: 14568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009B4 RID: 2484
		[ObfuscatedName("ScheduleOne.Interaction.InteractionManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CBDB RID: 52187 RVA: 0x003132F0 File Offset: 0x003114F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr);
				InteractionManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, "<>9");
				InteractionManager.__c.NativeFieldInfoPtr___9__57_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, "<>9__57_0");
				InteractionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, 100673762);
				InteractionManager.__c.NativeMethodInfoPtr__CheckHover_b__57_0_Internal_Int32_RaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, 100673763);
			}

			// Token: 0x0600CBDC RID: 52188 RVA: 0x0031336C File Offset: 0x0031156C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBDD RID: 52189 RVA: 0x003133A8 File Offset: 0x003115A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179162, XrefRangeEnd = 179165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CheckHover_b__57_0(RaycastHit x, RaycastHit y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c.NativeMethodInfoPtr__CheckHover_b__57_0_Internal_Int32_RaycastHit_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBDE RID: 52190 RVA: 0x000632A3 File Offset: 0x000614A3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F81 RID: 16257
			// (get) Token: 0x0600CBDF RID: 52191 RVA: 0x00313400 File Offset: 0x00311600
			// (set) Token: 0x0600CBE0 RID: 52192 RVA: 0x000632AC File Offset: 0x000614AC
			public unsafe static InteractionManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractionManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractionManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractionManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F82 RID: 16258
			// (get) Token: 0x0600CBE1 RID: 52193 RVA: 0x00313428 File Offset: 0x00311628
			// (set) Token: 0x0600CBE2 RID: 52194 RVA: 0x000632BE File Offset: 0x000614BE
			public unsafe static Comparison<RaycastHit> __9__57_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractionManager.__c.NativeFieldInfoPtr___9__57_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<RaycastHit>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractionManager.__c.NativeFieldInfoPtr___9__57_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089D7 RID: 35287
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040089D8 RID: 35288
			private static readonly IntPtr NativeFieldInfoPtr___9__57_0;

			// Token: 0x040089D9 RID: 35289
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089DA RID: 35290
			private static readonly IntPtr NativeMethodInfoPtr__CheckHover_b__57_0_Internal_Int32_RaycastHit_RaycastHit_0;
		}

		// Token: 0x020009B5 RID: 2485
		[ObfuscatedName("ScheduleOne.Interaction.InteractionManager+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBE3 RID: 52195 RVA: 0x00313450 File Offset: 0x00311650
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr);
				InteractionManager.__c__DisplayClass57_0.NativeFieldInfoPtr_objectHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr, "objectHits");
				InteractionManager.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr, 100673764);
				InteractionManager.__c__DisplayClass57_0.NativeMethodInfoPtr__CheckHover_b__1_Internal_Int32_InteractableObject_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr, 100673765);
			}

			// Token: 0x0600CBE4 RID: 52196 RVA: 0x003134B8 File Offset: 0x003116B8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBE5 RID: 52197 RVA: 0x003134F4 File Offset: 0x003116F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179165, XrefRangeEnd = 179174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CheckHover_b__1(InteractableObject x, InteractableObject y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c__DisplayClass57_0.NativeMethodInfoPtr__CheckHover_b__1_Internal_Int32_InteractableObject_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBE6 RID: 52198 RVA: 0x000632D0 File Offset: 0x000614D0
			public __c__DisplayClass57_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F83 RID: 16259
			// (get) Token: 0x0600CBE7 RID: 52199 RVA: 0x00313554 File Offset: 0x00311754
			// (set) Token: 0x0600CBE8 RID: 52200 RVA: 0x000632D9 File Offset: 0x000614D9
			public unsafe Dictionary<InteractableObject, RaycastHit> objectHits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.__c__DisplayClass57_0.NativeFieldInfoPtr_objectHits);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<InteractableObject, RaycastHit>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.__c__DisplayClass57_0.NativeFieldInfoPtr_objectHits), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089DB RID: 35291
			private static readonly IntPtr NativeFieldInfoPtr_objectHits;

			// Token: 0x040089DC RID: 35292
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089DD RID: 35293
			private static readonly IntPtr NativeMethodInfoPtr__CheckHover_b__1_Internal_Int32_InteractableObject_InteractableObject_0;
		}

		// Token: 0x020009B6 RID: 2486
		[ObfuscatedName("ScheduleOne.Interaction.InteractionManager+<ILerpDisplayScale>d__68")]
		public sealed class _ILerpDisplayScale_d__68 : Il2CppSystem.Object
		{
			// Token: 0x0600CBE9 RID: 52201 RVA: 0x00313584 File Offset: 0x00311784
			// Note: this type is marked as 'beforefieldinit'.
			static _ILerpDisplayScale_d__68()
			{
				Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<ILerpDisplayScale>d__68");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr);
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<>1__state");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<>2__current");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "startScale");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_endScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "endScale");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<>4__this");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<lerpTime>5__2");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<i>5__3");
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100673766);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100673767);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100673768);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100673769);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100673770);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100673771);
			}

			// Token: 0x0600CBEA RID: 52202 RVA: 0x003136B4 File Offset: 0x003118B4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ILerpDisplayScale_d__68(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBEB RID: 52203 RVA: 0x003136FC File Offset: 0x003118FC
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBEC RID: 52204 RVA: 0x00313730 File Offset: 0x00311930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179174, XrefRangeEnd = 179182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F8B RID: 16267
			// (get) Token: 0x0600CBED RID: 52205 RVA: 0x0031376C File Offset: 0x0031196C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CBEE RID: 52206 RVA: 0x003137AC File Offset: 0x003119AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179182, XrefRangeEnd = 179187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F8C RID: 16268
			// (get) Token: 0x0600CBEF RID: 52207 RVA: 0x003137E0 File Offset: 0x003119E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CBF0 RID: 52208 RVA: 0x000632F8 File Offset: 0x000614F8
			public _ILerpDisplayScale_d__68(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F84 RID: 16260
			// (get) Token: 0x0600CBF1 RID: 52209 RVA: 0x00313820 File Offset: 0x00311A20
			// (set) Token: 0x0600CBF2 RID: 52210 RVA: 0x00063301 File Offset: 0x00061501
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F85 RID: 16261
			// (get) Token: 0x0600CBF3 RID: 52211 RVA: 0x00313848 File Offset: 0x00311A48
			// (set) Token: 0x0600CBF4 RID: 52212 RVA: 0x0006331C File Offset: 0x0006151C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F86 RID: 16262
			// (get) Token: 0x0600CBF5 RID: 52213 RVA: 0x00313878 File Offset: 0x00311A78
			// (set) Token: 0x0600CBF6 RID: 52214 RVA: 0x0006333B File Offset: 0x0006153B
			public unsafe float startScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_startScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_startScale)) = value;
				}
			}

			// Token: 0x17003F87 RID: 16263
			// (get) Token: 0x0600CBF7 RID: 52215 RVA: 0x003138A0 File Offset: 0x00311AA0
			// (set) Token: 0x0600CBF8 RID: 52216 RVA: 0x00063356 File Offset: 0x00061556
			public unsafe float endScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_endScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_endScale)) = value;
				}
			}

			// Token: 0x17003F88 RID: 16264
			// (get) Token: 0x0600CBF9 RID: 52217 RVA: 0x003138C8 File Offset: 0x00311AC8
			// (set) Token: 0x0600CBFA RID: 52218 RVA: 0x00063371 File Offset: 0x00061571
			public unsafe InteractionManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractionManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F89 RID: 16265
			// (get) Token: 0x0600CBFB RID: 52219 RVA: 0x003138F8 File Offset: 0x00311AF8
			// (set) Token: 0x0600CBFC RID: 52220 RVA: 0x00063390 File Offset: 0x00061590
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x17003F8A RID: 16266
			// (get) Token: 0x0600CBFD RID: 52221 RVA: 0x00313920 File Offset: 0x00311B20
			// (set) Token: 0x0600CBFE RID: 52222 RVA: 0x000633AB File Offset: 0x000615AB
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040089DE RID: 35294
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040089DF RID: 35295
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040089E0 RID: 35296
			private static readonly IntPtr NativeFieldInfoPtr_startScale;

			// Token: 0x040089E1 RID: 35297
			private static readonly IntPtr NativeFieldInfoPtr_endScale;

			// Token: 0x040089E2 RID: 35298
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089E3 RID: 35299
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x040089E4 RID: 35300
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040089E5 RID: 35301
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040089E6 RID: 35302
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089E7 RID: 35303
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040089E8 RID: 35304
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040089E9 RID: 35305
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089EA RID: 35306
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
