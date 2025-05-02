using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Construction.Features;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x02000482 RID: 1154
	public class ColorFeature : Feature
	{
		// Token: 0x06006411 RID: 25617 RVA: 0x001C52B4 File Offset: 0x001C34B4
		// Note: this type is marked as 'beforefieldinit'.
		static ColorFeature()
		{
			Il2CppClassPointerStore<ColorFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "ColorFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr);
			ColorFeature.NativeFieldInfoPtr_colorTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "colorTargets");
			ColorFeature.NativeFieldInfoPtr_secondaryTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "secondaryTargets");
			ColorFeature.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "colors");
			ColorFeature.NativeFieldInfoPtr_defaultColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "defaultColorIndex");
			ColorFeature.NativeFieldInfoPtr_ownedColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "ownedColorIndex");
			ColorFeature.NativeFieldInfoPtr_syncVar___ownedColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "syncVar___ownedColorIndex");
			ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Construction.Features.ColorFeatureAssembly-CSharp.dll_Excuted");
			ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Construction.Features.ColorFeatureAssembly-CSharp.dll_Excuted");
			ColorFeature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675980);
			ColorFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675981);
			ColorFeature.NativeMethodInfoPtr_ApplyColor_Private_Void_NamedColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675982);
			ColorFeature.NativeMethodInfoPtr_ModifyColor_Public_Static_Color_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675983);
			ColorFeature.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675984);
			ColorFeature.NativeMethodInfoPtr_ReceiveData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675985);
			ColorFeature.NativeMethodInfoPtr_BuyColor_Private_Void_NamedColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675986);
			ColorFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675987);
			ColorFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675988);
			ColorFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675989);
			ColorFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675990);
			ColorFeature.NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675991);
			ColorFeature.NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675992);
			ColorFeature.NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675993);
			ColorFeature.NativeMethodInfoPtr_sync___get_value_ownedColorIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675994);
			ColorFeature.NativeMethodInfoPtr_sync___set_value_ownedColorIndex_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675995);
			ColorFeature.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_ColorFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675996);
			ColorFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675997);
		}

		// Token: 0x06006412 RID: 25618 RVA: 0x001C54EC File Offset: 0x001C36EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204161, XrefRangeEnd = 204188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override FI_Base CreateInterface(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FI_Base>(intPtr3) : null;
		}

		// Token: 0x06006413 RID: 25619 RVA: 0x001C5548 File Offset: 0x001C3748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204188, XrefRangeEnd = 204195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Default()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006414 RID: 25620 RVA: 0x001C5584 File Offset: 0x001C3784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204221, RefRangeEnd = 204222, XrefRangeStart = 204195, XrefRangeEnd = 204221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColor(ColorFeature.NamedColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_ApplyColor_Private_Void_NamedColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006415 RID: 25621 RVA: 0x001C55C8 File Offset: 0x001C37C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204226, RefRangeEnd = 204227, XrefRangeStart = 204222, XrefRangeEnd = 204226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color ModifyColor(Color original, float sChange, float vChange)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref original;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sChange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vChange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_ModifyColor_Public_Static_Color_Color_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006416 RID: 25622 RVA: 0x001C5624 File Offset: 0x001C3824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204227, XrefRangeEnd = 204250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetData(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006417 RID: 25623 RVA: 0x001C5670 File Offset: 0x001C3870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204250, XrefRangeEnd = 204255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_ReceiveData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x001C56A4 File Offset: 0x001C38A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204255, XrefRangeEnd = 204259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuyColor(ColorFeature.NamedColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_BuyColor_Private_Void_NamedColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x001C56E8 File Offset: 0x001C38E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204259, XrefRangeEnd = 204285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x001C5724 File Offset: 0x001C3924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204285, XrefRangeEnd = 204308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600641B RID: 25627 RVA: 0x001C5760 File Offset: 0x001C3960
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x001C579C File Offset: 0x001C399C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600641D RID: 25629 RVA: 0x001C57D8 File Offset: 0x001C39D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204308, XrefRangeEnd = 204328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetData_3316948804(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600641E RID: 25630 RVA: 0x001C5818 File Offset: 0x001C3A18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204337, RefRangeEnd = 204339, XrefRangeStart = 204328, XrefRangeEnd = 204337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetData_3316948804(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x001C5864 File Offset: 0x001C3A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204339, XrefRangeEnd = 204344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetData_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x06006420 RID: 25632 RVA: 0x001C58C8 File Offset: 0x001C3AC8
		// (set) Token: 0x06006421 RID: 25633 RVA: 0x001C5904 File Offset: 0x001C3B04
		public unsafe int SyncAccessor_ownedColorIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_sync___get_value_ownedColorIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 204352, RefRangeEnd = 204353, XrefRangeStart = 204344, XrefRangeEnd = 204352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_sync___set_value_ownedColorIndex_Public_set_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006422 RID: 25634 RVA: 0x001C5950 File Offset: 0x001C3B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204353, XrefRangeEnd = 204358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Construction_Features_ColorFeature(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_ColorFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006423 RID: 25635 RVA: 0x001C59C4 File Offset: 0x001C3BC4
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006424 RID: 25636 RVA: 0x0002F542 File Offset: 0x0002D742
		public ColorFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x06006425 RID: 25637 RVA: 0x001C5A00 File Offset: 0x001C3C00
		// (set) Token: 0x06006426 RID: 25638 RVA: 0x0002F54B File Offset: 0x0002D74B
		public unsafe List<MeshRenderer> colorTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_colorTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_colorTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x06006427 RID: 25639 RVA: 0x001C5A30 File Offset: 0x001C3C30
		// (set) Token: 0x06006428 RID: 25640 RVA: 0x0002F56A File Offset: 0x0002D76A
		public unsafe List<ColorFeature.SecondaryPaintTarget> secondaryTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_secondaryTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ColorFeature.SecondaryPaintTarget>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_secondaryTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x06006429 RID: 25641 RVA: 0x001C5A60 File Offset: 0x001C3C60
		// (set) Token: 0x0600642A RID: 25642 RVA: 0x0002F589 File Offset: 0x0002D789
		public unsafe List<ColorFeature.NamedColor> colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ColorFeature.NamedColor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x0600642B RID: 25643 RVA: 0x001C5A90 File Offset: 0x001C3C90
		// (set) Token: 0x0600642C RID: 25644 RVA: 0x0002F5A8 File Offset: 0x0002D7A8
		public unsafe int defaultColorIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_defaultColorIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_defaultColorIndex)) = value;
			}
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x0600642D RID: 25645 RVA: 0x001C5AB8 File Offset: 0x001C3CB8
		// (set) Token: 0x0600642E RID: 25646 RVA: 0x0002F5C3 File Offset: 0x0002D7C3
		public unsafe int ownedColorIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_ownedColorIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_ownedColorIndex)) = value;
			}
		}

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x0600642F RID: 25647 RVA: 0x001C5AE0 File Offset: 0x001C3CE0
		// (set) Token: 0x06006430 RID: 25648 RVA: 0x0002F5DE File Offset: 0x0002D7DE
		public unsafe SyncVar<int> syncVar___ownedColorIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_syncVar___ownedColorIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_syncVar___ownedColorIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x06006431 RID: 25649 RVA: 0x001C5B10 File Offset: 0x001C3D10
		// (set) Token: 0x06006432 RID: 25650 RVA: 0x0002F5FD File Offset: 0x0002D7FD
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x06006433 RID: 25651 RVA: 0x001C5B38 File Offset: 0x001C3D38
		// (set) Token: 0x06006434 RID: 25652 RVA: 0x0002F618 File Offset: 0x0002D818
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004449 RID: 17481
		private static readonly IntPtr NativeFieldInfoPtr_colorTargets;

		// Token: 0x0400444A RID: 17482
		private static readonly IntPtr NativeFieldInfoPtr_secondaryTargets;

		// Token: 0x0400444B RID: 17483
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x0400444C RID: 17484
		private static readonly IntPtr NativeFieldInfoPtr_defaultColorIndex;

		// Token: 0x0400444D RID: 17485
		private static readonly IntPtr NativeFieldInfoPtr_ownedColorIndex;

		// Token: 0x0400444E RID: 17486
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___ownedColorIndex;

		// Token: 0x0400444F RID: 17487
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004450 RID: 17488
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004451 RID: 17489
		private static readonly IntPtr NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0;

		// Token: 0x04004452 RID: 17490
		private static readonly IntPtr NativeMethodInfoPtr_Default_Public_Virtual_Void_0;

		// Token: 0x04004453 RID: 17491
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColor_Private_Void_NamedColor_0;

		// Token: 0x04004454 RID: 17492
		private static readonly IntPtr NativeMethodInfoPtr_ModifyColor_Public_Static_Color_Color_Single_Single_0;

		// Token: 0x04004455 RID: 17493
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04004456 RID: 17494
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveData_Private_Void_0;

		// Token: 0x04004457 RID: 17495
		private static readonly IntPtr NativeMethodInfoPtr_BuyColor_Private_Void_NamedColor_0;

		// Token: 0x04004458 RID: 17496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004459 RID: 17497
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400445A RID: 17498
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400445B RID: 17499
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400445C RID: 17500
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0;

		// Token: 0x0400445D RID: 17501
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x0400445E RID: 17502
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400445F RID: 17503
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_ownedColorIndex_Public_get_Int32_0;

		// Token: 0x04004460 RID: 17504
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_ownedColorIndex_Public_set_Void_Int32_Boolean_0;

		// Token: 0x04004461 RID: 17505
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_ColorFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004462 RID: 17506
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A2D RID: 2605
		[Serializable]
		public class NamedColor : Il2CppSystem.Object
		{
			// Token: 0x0600CF63 RID: 53091 RVA: 0x0031D370 File Offset: 0x0031B570
			// Note: this type is marked as 'beforefieldinit'.
			static NamedColor()
			{
				Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "NamedColor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr);
				ColorFeature.NamedColor.NativeFieldInfoPtr_colorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr, "colorName");
				ColorFeature.NamedColor.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr, "color");
				ColorFeature.NamedColor.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr, "price");
				ColorFeature.NamedColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr, 100675998);
			}

			// Token: 0x0600CF64 RID: 53092 RVA: 0x0031D3EC File Offset: 0x0031B5EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204152, XrefRangeEnd = 204153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamedColor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NamedColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF65 RID: 53093 RVA: 0x00064E2C File Offset: 0x0006302C
			public NamedColor(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004072 RID: 16498
			// (get) Token: 0x0600CF66 RID: 53094 RVA: 0x0031D428 File Offset: 0x0031B628
			// (set) Token: 0x0600CF67 RID: 53095 RVA: 0x00064E35 File Offset: 0x00063035
			public unsafe string colorName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_colorName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_colorName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004073 RID: 16499
			// (get) Token: 0x0600CF68 RID: 53096 RVA: 0x0031D450 File Offset: 0x0031B650
			// (set) Token: 0x0600CF69 RID: 53097 RVA: 0x00064E54 File Offset: 0x00063054
			public unsafe Color color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x17004074 RID: 16500
			// (get) Token: 0x0600CF6A RID: 53098 RVA: 0x0031D478 File Offset: 0x0031B678
			// (set) Token: 0x0600CF6B RID: 53099 RVA: 0x00064E6F File Offset: 0x0006306F
			public unsafe float price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_price)) = value;
				}
			}

			// Token: 0x04008BE8 RID: 35816
			private static readonly IntPtr NativeFieldInfoPtr_colorName;

			// Token: 0x04008BE9 RID: 35817
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008BEA RID: 35818
			private static readonly IntPtr NativeFieldInfoPtr_price;

			// Token: 0x04008BEB RID: 35819
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A2E RID: 2606
		[Serializable]
		public class SecondaryPaintTarget : Il2CppSystem.Object
		{
			// Token: 0x0600CF6C RID: 53100 RVA: 0x0031D4A0 File Offset: 0x0031B6A0
			// Note: this type is marked as 'beforefieldinit'.
			static SecondaryPaintTarget()
			{
				Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "SecondaryPaintTarget");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr);
				ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_colorTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr, "colorTargets");
				ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_sChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr, "sChange");
				ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_vChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr, "vChange");
				ColorFeature.SecondaryPaintTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr, 100675999);
			}

			// Token: 0x0600CF6D RID: 53101 RVA: 0x0031D51C File Offset: 0x0031B71C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204153, XrefRangeEnd = 204161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SecondaryPaintTarget() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.SecondaryPaintTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF6E RID: 53102 RVA: 0x00064E8A File Offset: 0x0006308A
			public SecondaryPaintTarget(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004075 RID: 16501
			// (get) Token: 0x0600CF6F RID: 53103 RVA: 0x0031D558 File Offset: 0x0031B758
			// (set) Token: 0x0600CF70 RID: 53104 RVA: 0x00064E93 File Offset: 0x00063093
			public unsafe List<MeshRenderer> colorTargets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_colorTargets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_colorTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004076 RID: 16502
			// (get) Token: 0x0600CF71 RID: 53105 RVA: 0x0031D588 File Offset: 0x0031B788
			// (set) Token: 0x0600CF72 RID: 53106 RVA: 0x00064EB2 File Offset: 0x000630B2
			public unsafe float sChange
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_sChange);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_sChange)) = value;
				}
			}

			// Token: 0x17004077 RID: 16503
			// (get) Token: 0x0600CF73 RID: 53107 RVA: 0x0031D5B0 File Offset: 0x0031B7B0
			// (set) Token: 0x0600CF74 RID: 53108 RVA: 0x00064ECD File Offset: 0x000630CD
			public unsafe float vChange
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_vChange);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_vChange)) = value;
				}
			}

			// Token: 0x04008BEC RID: 35820
			private static readonly IntPtr NativeFieldInfoPtr_colorTargets;

			// Token: 0x04008BED RID: 35821
			private static readonly IntPtr NativeFieldInfoPtr_sChange;

			// Token: 0x04008BEE RID: 35822
			private static readonly IntPtr NativeFieldInfoPtr_vChange;

			// Token: 0x04008BEF RID: 35823
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
