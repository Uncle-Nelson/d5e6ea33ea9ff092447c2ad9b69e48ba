using System;
using Il2CppEPOOutline;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using Il2CppScheduleOne.EntityFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ConstructableScripts
{
	// Token: 0x020005CB RID: 1483
	public class Constructable : NetworkBehaviour
	{
		// Token: 0x0600825C RID: 33372 RVA: 0x0022B0F4 File Offset: 0x002292F4
		// Note: this type is marked as 'beforefieldinit'.
		static Constructable()
		{
			Il2CppClassPointerStore<Constructable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ConstructableScripts", "Constructable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Constructable>.NativeClassPtr);
			Constructable.NativeFieldInfoPtr_isStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "isStatic");
			Constructable.NativeFieldInfoPtr_constructableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructableName");
			Constructable.NativeFieldInfoPtr_constructableDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructableDescription");
			Constructable.NativeFieldInfoPtr_constructableAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructableAssetPath");
			Constructable.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "ID");
			Constructable.NativeFieldInfoPtr_constructableIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructableIcon");
			Constructable.NativeFieldInfoPtr_boundingBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "boundingBox");
			Constructable.NativeFieldInfoPtr_constructionHandler_Asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructionHandler_Asset");
			Constructable.NativeFieldInfoPtr_outlineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "outlineRenderers");
			Constructable.NativeFieldInfoPtr_outlineEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "outlineEffect");
			Constructable.NativeFieldInfoPtr_features = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "features");
			Constructable.NativeFieldInfoPtr__isVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "<isVisible>k__BackingField");
			Constructable.NativeFieldInfoPtr_isDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "isDestroyed");
			Constructable.NativeFieldInfoPtr_originalLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "originalLayers");
			Constructable.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ConstructableScripts.ConstructableAssembly-CSharp.dll_Excuted");
			Constructable.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ConstructableScripts.ConstructableAssembly-CSharp.dll_Excuted");
			Constructable.NativeMethodInfoPtr_get_IsStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679596);
			Constructable.NativeMethodInfoPtr_get_ConstructableName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679597);
			Constructable.NativeMethodInfoPtr_get_ConstructableDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679598);
			Constructable.NativeMethodInfoPtr_get_ConstructableAssetPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679599);
			Constructable.NativeMethodInfoPtr_get_PrefabID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679600);
			Constructable.NativeMethodInfoPtr_get_ConstructableIcon_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679601);
			Constructable.NativeMethodInfoPtr_get__constructionHandler_Asset_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679602);
			Constructable.NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679603);
			Constructable.NativeMethodInfoPtr_set_isVisible_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679604);
			Constructable.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679605);
			Constructable.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679606);
			Constructable.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679607);
			Constructable.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679608);
			Constructable.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679609);
			Constructable.NativeMethodInfoPtr_Destroy_Networked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679610);
			Constructable.NativeMethodInfoPtr_DestroyConstructableWrapper_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679611);
			Constructable.NativeMethodInfoPtr_CanBeModified_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679612);
			Constructable.NativeMethodInfoPtr_CanBePickedUpByHand_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679613);
			Constructable.NativeMethodInfoPtr_CanBeSelected_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679614);
			Constructable.NativeMethodInfoPtr_GetBuildableVersionAssetPath_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679615);
			Constructable.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679616);
			Constructable.NativeMethodInfoPtr_HideOutline_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679617);
			Constructable.NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679618);
			Constructable.NativeMethodInfoPtr_GetBoundingBoxLongestSide_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679619);
			Constructable.NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679620);
			Constructable.NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679621);
			Constructable.NativeMethodInfoPtr_SetLayerRecursively_Public_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679622);
			Constructable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679623);
			Constructable.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679624);
			Constructable.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679625);
			Constructable.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679626);
			Constructable.NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679627);
			Constructable.NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679628);
			Constructable.NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679629);
			Constructable.NativeMethodInfoPtr_RpcWriter___Observers_DestroyConstructableWrapper_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679630);
			Constructable.NativeMethodInfoPtr_RpcLogic___DestroyConstructableWrapper_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679631);
			Constructable.NativeMethodInfoPtr_RpcReader___Observers_DestroyConstructableWrapper_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679632);
			Constructable.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679633);
		}

		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x0600825D RID: 33373 RVA: 0x0022B55C File Offset: 0x0022975C
		public unsafe bool IsStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_IsStatic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x0600825E RID: 33374 RVA: 0x0022B598 File Offset: 0x00229798
		public unsafe string ConstructableName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_ConstructableName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x0600825F RID: 33375 RVA: 0x0022B5D0 File Offset: 0x002297D0
		public unsafe string ConstructableDescription
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_ConstructableDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x06008260 RID: 33376 RVA: 0x0022B608 File Offset: 0x00229808
		public unsafe string ConstructableAssetPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_ConstructableAssetPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700278A RID: 10122
		// (get) Token: 0x06008261 RID: 33377 RVA: 0x0022B640 File Offset: 0x00229840
		public unsafe string PrefabID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_PrefabID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x06008262 RID: 33378 RVA: 0x0022B678 File Offset: 0x00229878
		public unsafe Sprite ConstructableIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_ConstructableIcon_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x06008263 RID: 33379 RVA: 0x0022B6B8 File Offset: 0x002298B8
		public unsafe GameObject _constructionHandler_Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get__constructionHandler_Asset_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x06008264 RID: 33380 RVA: 0x0022B6F8 File Offset: 0x002298F8
		// (set) Token: 0x06008265 RID: 33381 RVA: 0x0022B734 File Offset: 0x00229934
		public unsafe bool isVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_set_isVisible_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008266 RID: 33382 RVA: 0x0022B774 File Offset: 0x00229974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246207, RefRangeEnd = 246208, XrefRangeStart = 246206, XrefRangeEnd = 246207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008267 RID: 33383 RVA: 0x0022B7B0 File Offset: 0x002299B0
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008268 RID: 33384 RVA: 0x0022B7EC File Offset: 0x002299EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246208, XrefRangeEnd = 246211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008269 RID: 33385 RVA: 0x0022B850 File Offset: 0x00229A50
		[CallerCount(0)]
		public unsafe virtual bool CanBeDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600826A RID: 33386 RVA: 0x0022B898 File Offset: 0x00229A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246238, RefRangeEnd = 246239, XrefRangeStart = 246211, XrefRangeEnd = 246238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyConstructable(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600826B RID: 33387 RVA: 0x0022B8E4 File Offset: 0x00229AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246239, XrefRangeEnd = 246257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy_Networked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_Destroy_Networked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600826C RID: 33388 RVA: 0x0022B918 File Offset: 0x00229B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246257, XrefRangeEnd = 246275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyConstructableWrapper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_DestroyConstructableWrapper_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600826D RID: 33389 RVA: 0x0022B94C File Offset: 0x00229B4C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeModified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBeModified_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600826E RID: 33390 RVA: 0x0022B994 File Offset: 0x00229B94
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBePickedUpByHand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBePickedUpByHand_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600826F RID: 33391 RVA: 0x0022B9DC File Offset: 0x00229BDC
		[CallerCount(0)]
		public unsafe virtual bool CanBeSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBeSelected_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008270 RID: 33392 RVA: 0x0022BA24 File Offset: 0x00229C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246275, XrefRangeEnd = 246277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetBuildableVersionAssetPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_GetBuildableVersionAssetPath_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008271 RID: 33393 RVA: 0x0022BA68 File Offset: 0x00229C68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 246320, RefRangeEnd = 246323, XrefRangeStart = 246277, XrefRangeEnd = 246320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOutline(BuildableItem.EOutlineColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008272 RID: 33394 RVA: 0x0022BAA8 File Offset: 0x00229CA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246328, RefRangeEnd = 246330, XrefRangeStart = 246323, XrefRangeEnd = 246328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_HideOutline_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008273 RID: 33395 RVA: 0x0022BADC File Offset: 0x00229CDC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 136795, RefRangeEnd = 136807, XrefRangeStart = 136795, XrefRangeEnd = 136807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 GetCosmeticCenter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008274 RID: 33396 RVA: 0x0022BB24 File Offset: 0x00229D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246333, RefRangeEnd = 246334, XrefRangeStart = 246330, XrefRangeEnd = 246333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetBoundingBoxLongestSide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_GetBoundingBoxLongestSide_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008275 RID: 33397 RVA: 0x0022BB60 File Offset: 0x00229D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246334, XrefRangeEnd = 246339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008276 RID: 33398 RVA: 0x0022BB9C File Offset: 0x00229D9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246362, RefRangeEnd = 246363, XrefRangeStart = 246339, XrefRangeEnd = 246362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RestoreVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008277 RID: 33399 RVA: 0x0022BBD8 File Offset: 0x00229DD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246395, RefRangeEnd = 246397, XrefRangeStart = 246363, XrefRangeEnd = 246395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLayerRecursively(GameObject go, int layerNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_SetLayerRecursively_Public_Void_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008278 RID: 33400 RVA: 0x0022BC28 File Offset: 0x00229E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246432, RefRangeEnd = 246433, XrefRangeStart = 246397, XrefRangeEnd = 246432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Constructable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008279 RID: 33401 RVA: 0x0022BC64 File Offset: 0x00229E64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246447, RefRangeEnd = 246448, XrefRangeStart = 246433, XrefRangeEnd = 246447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600827A RID: 33402 RVA: 0x0022BCA0 File Offset: 0x00229EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234459, RefRangeEnd = 234460, XrefRangeStart = 234459, XrefRangeEnd = 234460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600827B RID: 33403 RVA: 0x0022BCDC File Offset: 0x00229EDC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600827C RID: 33404 RVA: 0x0022BD18 File Offset: 0x00229F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Destroy_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600827D RID: 33405 RVA: 0x0022BD4C File Offset: 0x00229F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246448, XrefRangeEnd = 246477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Destroy_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600827E RID: 33406 RVA: 0x0022BD80 File Offset: 0x00229F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246477, XrefRangeEnd = 246507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Destroy_Networked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600827F RID: 33407 RVA: 0x0022BDE4 File Offset: 0x00229FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DestroyConstructableWrapper_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcWriter___Observers_DestroyConstructableWrapper_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008280 RID: 33408 RVA: 0x0022BE18 File Offset: 0x0022A018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246507, XrefRangeEnd = 246513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyConstructableWrapper_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcLogic___DestroyConstructableWrapper_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008281 RID: 33409 RVA: 0x0022BE4C File Offset: 0x0022A04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246513, XrefRangeEnd = 246520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DestroyConstructableWrapper_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcReader___Observers_DestroyConstructableWrapper_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008282 RID: 33410 RVA: 0x0022BE9C File Offset: 0x0022A09C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246539, RefRangeEnd = 246541, XrefRangeStart = 246520, XrefRangeEnd = 246539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008283 RID: 33411 RVA: 0x0003E02D File Offset: 0x0003C22D
		public Constructable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x06008284 RID: 33412 RVA: 0x0022BED8 File Offset: 0x0022A0D8
		// (set) Token: 0x06008285 RID: 33413 RVA: 0x0003E036 File Offset: 0x0003C236
		public unsafe bool isStatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_isStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_isStatic)) = value;
			}
		}

		// Token: 0x17002777 RID: 10103
		// (get) Token: 0x06008286 RID: 33414 RVA: 0x0022BF00 File Offset: 0x0022A100
		// (set) Token: 0x06008287 RID: 33415 RVA: 0x0003E051 File Offset: 0x0003C251
		public unsafe string constructableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002778 RID: 10104
		// (get) Token: 0x06008288 RID: 33416 RVA: 0x0022BF28 File Offset: 0x0022A128
		// (set) Token: 0x06008289 RID: 33417 RVA: 0x0003E070 File Offset: 0x0003C270
		public unsafe string constructableDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002779 RID: 10105
		// (get) Token: 0x0600828A RID: 33418 RVA: 0x0022BF50 File Offset: 0x0022A150
		// (set) Token: 0x0600828B RID: 33419 RVA: 0x0003E08F File Offset: 0x0003C28F
		public unsafe string constructableAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700277A RID: 10106
		// (get) Token: 0x0600828C RID: 33420 RVA: 0x0022BF78 File Offset: 0x0022A178
		// (set) Token: 0x0600828D RID: 33421 RVA: 0x0003E0AE File Offset: 0x0003C2AE
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x0600828E RID: 33422 RVA: 0x0022BFA0 File Offset: 0x0022A1A0
		// (set) Token: 0x0600828F RID: 33423 RVA: 0x0003E0CD File Offset: 0x0003C2CD
		public unsafe Sprite constructableIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x06008290 RID: 33424 RVA: 0x0022BFD0 File Offset: 0x0022A1D0
		// (set) Token: 0x06008291 RID: 33425 RVA: 0x0003E0EC File Offset: 0x0003C2EC
		public unsafe BoxCollider boundingBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_boundingBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_boundingBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277D RID: 10109
		// (get) Token: 0x06008292 RID: 33426 RVA: 0x0022C000 File Offset: 0x0022A200
		// (set) Token: 0x06008293 RID: 33427 RVA: 0x0003E10B File Offset: 0x0003C30B
		public unsafe GameObject constructionHandler_Asset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructionHandler_Asset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructionHandler_Asset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x06008294 RID: 33428 RVA: 0x0022C030 File Offset: 0x0022A230
		// (set) Token: 0x06008295 RID: 33429 RVA: 0x0003E12A File Offset: 0x0003C32A
		public unsafe List<GameObject> outlineRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_outlineRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_outlineRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x06008296 RID: 33430 RVA: 0x0022C060 File Offset: 0x0022A260
		// (set) Token: 0x06008297 RID: 33431 RVA: 0x0003E149 File Offset: 0x0003C349
		public unsafe Outlinable outlineEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_outlineEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outlinable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_outlineEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x06008298 RID: 33432 RVA: 0x0022C090 File Offset: 0x0022A290
		// (set) Token: 0x06008299 RID: 33433 RVA: 0x0003E168 File Offset: 0x0003C368
		public unsafe List<Feature> features
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_features);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Feature>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_features), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x0600829A RID: 33434 RVA: 0x0022C0C0 File Offset: 0x0022A2C0
		// (set) Token: 0x0600829B RID: 33435 RVA: 0x0003E187 File Offset: 0x0003C387
		public unsafe bool _isVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr__isVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr__isVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x0600829C RID: 33436 RVA: 0x0022C0E8 File Offset: 0x0022A2E8
		// (set) Token: 0x0600829D RID: 33437 RVA: 0x0003E1A2 File Offset: 0x0003C3A2
		public unsafe bool isDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_isDestroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_isDestroyed)) = value;
			}
		}

		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x0600829E RID: 33438 RVA: 0x0022C110 File Offset: 0x0022A310
		// (set) Token: 0x0600829F RID: 33439 RVA: 0x0003E1BD File Offset: 0x0003C3BD
		public unsafe Dictionary<Transform, LayerMask> originalLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_originalLayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Transform, LayerMask>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_originalLayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x060082A0 RID: 33440 RVA: 0x0022C140 File Offset: 0x0022A340
		// (set) Token: 0x060082A1 RID: 33441 RVA: 0x0003E1DC File Offset: 0x0003C3DC
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002785 RID: 10117
		// (get) Token: 0x060082A2 RID: 33442 RVA: 0x0022C168 File Offset: 0x0022A368
		// (set) Token: 0x060082A3 RID: 33443 RVA: 0x0003E1F7 File Offset: 0x0003C3F7
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040058AC RID: 22700
		private static readonly IntPtr NativeFieldInfoPtr_isStatic;

		// Token: 0x040058AD RID: 22701
		private static readonly IntPtr NativeFieldInfoPtr_constructableName;

		// Token: 0x040058AE RID: 22702
		private static readonly IntPtr NativeFieldInfoPtr_constructableDescription;

		// Token: 0x040058AF RID: 22703
		private static readonly IntPtr NativeFieldInfoPtr_constructableAssetPath;

		// Token: 0x040058B0 RID: 22704
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x040058B1 RID: 22705
		private static readonly IntPtr NativeFieldInfoPtr_constructableIcon;

		// Token: 0x040058B2 RID: 22706
		private static readonly IntPtr NativeFieldInfoPtr_boundingBox;

		// Token: 0x040058B3 RID: 22707
		private static readonly IntPtr NativeFieldInfoPtr_constructionHandler_Asset;

		// Token: 0x040058B4 RID: 22708
		private static readonly IntPtr NativeFieldInfoPtr_outlineRenderers;

		// Token: 0x040058B5 RID: 22709
		private static readonly IntPtr NativeFieldInfoPtr_outlineEffect;

		// Token: 0x040058B6 RID: 22710
		private static readonly IntPtr NativeFieldInfoPtr_features;

		// Token: 0x040058B7 RID: 22711
		private static readonly IntPtr NativeFieldInfoPtr__isVisible_k__BackingField;

		// Token: 0x040058B8 RID: 22712
		private static readonly IntPtr NativeFieldInfoPtr_isDestroyed;

		// Token: 0x040058B9 RID: 22713
		private static readonly IntPtr NativeFieldInfoPtr_originalLayers;

		// Token: 0x040058BA RID: 22714
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040058BB RID: 22715
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040058BC RID: 22716
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_get_Boolean_0;

		// Token: 0x040058BD RID: 22717
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructableName_Public_get_String_0;

		// Token: 0x040058BE RID: 22718
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructableDescription_Public_get_String_0;

		// Token: 0x040058BF RID: 22719
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructableAssetPath_Public_get_String_0;

		// Token: 0x040058C0 RID: 22720
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabID_Public_get_String_0;

		// Token: 0x040058C1 RID: 22721
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructableIcon_Public_get_Sprite_0;

		// Token: 0x040058C2 RID: 22722
		private static readonly IntPtr NativeMethodInfoPtr_get__constructionHandler_Asset_Public_get_GameObject_0;

		// Token: 0x040058C3 RID: 22723
		private static readonly IntPtr NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0;

		// Token: 0x040058C4 RID: 22724
		private static readonly IntPtr NativeMethodInfoPtr_set_isVisible_Protected_set_Void_Boolean_0;

		// Token: 0x040058C5 RID: 22725
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040058C6 RID: 22726
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040058C7 RID: 22727
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0;

		// Token: 0x040058C8 RID: 22728
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_0;

		// Token: 0x040058C9 RID: 22729
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040058CA RID: 22730
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Networked_Private_Void_0;

		// Token: 0x040058CB RID: 22731
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConstructableWrapper_Private_Void_0;

		// Token: 0x040058CC RID: 22732
		private static readonly IntPtr NativeMethodInfoPtr_CanBeModified_Public_Virtual_New_Boolean_0;

		// Token: 0x040058CD RID: 22733
		private static readonly IntPtr NativeMethodInfoPtr_CanBePickedUpByHand_Public_Virtual_New_Boolean_0;

		// Token: 0x040058CE RID: 22734
		private static readonly IntPtr NativeMethodInfoPtr_CanBeSelected_Public_Virtual_New_Boolean_0;

		// Token: 0x040058CF RID: 22735
		private static readonly IntPtr NativeMethodInfoPtr_GetBuildableVersionAssetPath_Public_Virtual_New_String_0;

		// Token: 0x040058D0 RID: 22736
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0;

		// Token: 0x040058D1 RID: 22737
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Void_0;

		// Token: 0x040058D2 RID: 22738
		private static readonly IntPtr NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_New_Vector3_0;

		// Token: 0x040058D3 RID: 22739
		private static readonly IntPtr NativeMethodInfoPtr_GetBoundingBoxLongestSide_Public_Single_0;

		// Token: 0x040058D4 RID: 22740
		private static readonly IntPtr NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0;

		// Token: 0x040058D5 RID: 22741
		private static readonly IntPtr NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_New_Void_0;

		// Token: 0x040058D6 RID: 22742
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Void_GameObject_Int32_0;

		// Token: 0x040058D7 RID: 22743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040058D8 RID: 22744
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040058D9 RID: 22745
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040058DA RID: 22746
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040058DB RID: 22747
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0;

		// Token: 0x040058DC RID: 22748
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0;

		// Token: 0x040058DD RID: 22749
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040058DE RID: 22750
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DestroyConstructableWrapper_2166136261_Private_Void_0;

		// Token: 0x040058DF RID: 22751
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyConstructableWrapper_2166136261_Private_Void_0;

		// Token: 0x040058E0 RID: 22752
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DestroyConstructableWrapper_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040058E1 RID: 22753
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
