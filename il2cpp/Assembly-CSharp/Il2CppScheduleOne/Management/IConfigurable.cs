using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Management;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x0200039B RID: 923
	public class IConfigurable : Il2CppObjectBase
	{
		// Token: 0x06004862 RID: 18530 RVA: 0x00161E98 File Offset: 0x00160098
		// Note: this type is marked as 'beforefieldinit'.
		static IConfigurable()
		{
			Il2CppClassPointerStore<IConfigurable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "IConfigurable");
			IConfigurable.NativeMethodInfoPtr_get_Configuration_Public_Abstract_Virtual_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672242);
			IConfigurable.NativeMethodInfoPtr_get_ConfigReplicator_Public_Abstract_Virtual_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672243);
			IConfigurable.NativeMethodInfoPtr_get_ConfigurableType_Public_Abstract_Virtual_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672244);
			IConfigurable.NativeMethodInfoPtr_get_WorldspaceUI_Public_Abstract_Virtual_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672245);
			IConfigurable.NativeMethodInfoPtr_set_WorldspaceUI_Public_Abstract_Virtual_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672246);
			IConfigurable.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Abstract_Virtual_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672247);
			IConfigurable.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Abstract_Virtual_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672248);
			IConfigurable.NativeMethodInfoPtr_get_IsBeingConfiguredByOtherPlayer_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672249);
			IConfigurable.NativeMethodInfoPtr_get_TypeIcon_Public_Abstract_Virtual_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672250);
			IConfigurable.NativeMethodInfoPtr_get_Transform_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672251);
			IConfigurable.NativeMethodInfoPtr_get_UIPoint_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672252);
			IConfigurable.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672253);
			IConfigurable.NativeMethodInfoPtr_get_CanBeSelected_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672254);
			IConfigurable.NativeMethodInfoPtr_get_ParentProperty_Public_Abstract_Virtual_New_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672255);
			IConfigurable.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Abstract_Virtual_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672256);
			IConfigurable.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672257);
			IConfigurable.NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672258);
			IConfigurable.NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672259);
			IConfigurable.NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672260);
			IConfigurable.NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672261);
			IConfigurable.NativeMethodInfoPtr_SetConfigurer_Public_Abstract_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672262);
			IConfigurable.NativeMethodInfoPtr_SendConfigurationToClient_Public_Abstract_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672263);
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06004863 RID: 18531 RVA: 0x00162078 File Offset: 0x00160278
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_Configuration_Public_Abstract_Virtual_New_get_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06004864 RID: 18532 RVA: 0x001620C4 File Offset: 0x001602C4
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_ConfigReplicator_Public_Abstract_Virtual_New_get_ConfigurationReplicator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06004865 RID: 18533 RVA: 0x00162110 File Offset: 0x00160310
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_ConfigurableType_Public_Abstract_Virtual_New_get_EConfigurableType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06004866 RID: 18534 RVA: 0x00162158 File Offset: 0x00160358
		// (set) Token: 0x06004867 RID: 18535 RVA: 0x001621A4 File Offset: 0x001603A4
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_WorldspaceUI_Public_Abstract_Virtual_New_get_WorldspaceUIElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_set_WorldspaceUI_Public_Abstract_Virtual_New_set_Void_WorldspaceUIElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06004868 RID: 18536 RVA: 0x001621F4 File Offset: 0x001603F4
		// (set) Token: 0x06004869 RID: 18537 RVA: 0x00162240 File Offset: 0x00160440
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Abstract_Virtual_New_get_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Abstract_Virtual_New_set_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x0600486A RID: 18538 RVA: 0x00162290 File Offset: 0x00160490
		public unsafe virtual bool IsBeingConfiguredByOtherPlayer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162227, XrefRangeEnd = 162234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_IsBeingConfiguredByOtherPlayer_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x0600486B RID: 18539 RVA: 0x001622D8 File Offset: 0x001604D8
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_TypeIcon_Public_Abstract_Virtual_New_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x0600486C RID: 18540 RVA: 0x00162324 File Offset: 0x00160524
		public unsafe virtual Transform Transform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_Transform_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x0600486D RID: 18541 RVA: 0x00162370 File Offset: 0x00160570
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_UIPoint_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x0600486E RID: 18542 RVA: 0x001623BC File Offset: 0x001605BC
		public unsafe virtual bool IsDestroyed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162234, XrefRangeEnd = 162236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x0600486F RID: 18543 RVA: 0x00162404 File Offset: 0x00160604
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_CanBeSelected_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x0016244C File Offset: 0x0016064C
		public unsafe virtual Property ParentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_ParentProperty_Public_Abstract_Virtual_New_get_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x00162498 File Offset: 0x00160698
		[CallerCount(0)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Abstract_Virtual_New_WorldspaceUIElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x001624E4 File Offset: 0x001606E4
		[CallerCount(0)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x00162520 File Offset: 0x00160720
		[CallerCount(0)]
		public unsafe virtual void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x0016256C File Offset: 0x0016076C
		[CallerCount(0)]
		public unsafe virtual void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x001625A8 File Offset: 0x001607A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162236, XrefRangeEnd = 162240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x001625E4 File Offset: 0x001607E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162240, XrefRangeEnd = 162244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x00162620 File Offset: 0x00160820
		[CallerCount(0)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_SetConfigurer_Public_Abstract_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x00162670 File Offset: 0x00160870
		[CallerCount(0)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_SendConfigurationToClient_Public_Abstract_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x00023000 File Offset: 0x00021200
		public IConfigurable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040030C7 RID: 12487
		private static readonly IntPtr NativeMethodInfoPtr_get_Configuration_Public_Abstract_Virtual_New_get_EntityConfiguration_0;

		// Token: 0x040030C8 RID: 12488
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Abstract_Virtual_New_get_ConfigurationReplicator_0;

		// Token: 0x040030C9 RID: 12489
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Abstract_Virtual_New_get_EConfigurableType_0;

		// Token: 0x040030CA RID: 12490
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Abstract_Virtual_New_get_WorldspaceUIElement_0;

		// Token: 0x040030CB RID: 12491
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Abstract_Virtual_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x040030CC RID: 12492
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Abstract_Virtual_New_get_NetworkObject_0;

		// Token: 0x040030CD RID: 12493
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Abstract_Virtual_New_set_Void_NetworkObject_0;

		// Token: 0x040030CE RID: 12494
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBeingConfiguredByOtherPlayer_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040030CF RID: 12495
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Abstract_Virtual_New_get_Sprite_0;

		// Token: 0x040030D0 RID: 12496
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x040030D1 RID: 12497
		private static readonly IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x040030D2 RID: 12498
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040030D3 RID: 12499
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040030D4 RID: 12500
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_Abstract_Virtual_New_get_Property_0;

		// Token: 0x040030D5 RID: 12501
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Abstract_Virtual_New_WorldspaceUIElement_0;

		// Token: 0x040030D6 RID: 12502
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040030D7 RID: 12503
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0;

		// Token: 0x040030D8 RID: 12504
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040030D9 RID: 12505
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0;

		// Token: 0x040030DA RID: 12506
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0;

		// Token: 0x040030DB RID: 12507
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Abstract_Virtual_New_Void_NetworkObject_0;

		// Token: 0x040030DC RID: 12508
		private static readonly IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Abstract_Virtual_New_Void_NetworkConnection_0;
	}
}
