using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D0 RID: 1744
	public class ManagementWorldspaceCanvas : Singleton<ManagementWorldspaceCanvas>
	{
		// Token: 0x06009CAB RID: 40107 RVA: 0x0027ADAC File Offset: 0x00278FAC
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementWorldspaceCanvas()
		{
			Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ManagementWorldspaceCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr);
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_VISIBILITY_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "VISIBILITY_RANGE");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "PROPERTY_CANVAS_RANGE");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "<IsOpen>k__BackingField");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "Canvas");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_ScaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "ScaleCurve");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_TransitRouteVisualsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "TransitRouteVisualsPrefab");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_CrosshairPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "CrosshairPrompt");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_ObjectSelectionLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "ObjectSelectionLayerMask");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "HoveredOutlineColor");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "SelectedOutlineColor");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_ShownConfigurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "ShownConfigurables");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredConfigurable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "HoveredConfigurable");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_OutlinedConfigurable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "OutlinedConfigurable");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedConfigurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "SelectedConfigurables");
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682530);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682531);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682532);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682533);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682534);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682535);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateInputPrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682536);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateUIs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682537);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682538);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682539);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_AddToSelection_Private_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682540);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveFromSelection_Private_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682541);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_ClearSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682542);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveNullConfigurables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682543);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetHoveredConfigurable_Private_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682544);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetConfigurablesToShow_Private_List_1_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682545);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_ShowCrosshairPrompt_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682546);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_HideCrosshairPrompt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682547);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682548);
		}

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x06009CAC RID: 40108 RVA: 0x0027B070 File Offset: 0x00279270
		// (set) Token: 0x06009CAD RID: 40109 RVA: 0x0027B0AC File Offset: 0x002792AC
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x06009CAE RID: 40110 RVA: 0x0027B0EC File Offset: 0x002792EC
		public unsafe Property CurrentProperty
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 278195, RefRangeEnd = 278199, XrefRangeStart = 278191, XrefRangeEnd = 278195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
		}

		// Token: 0x06009CAF RID: 40111 RVA: 0x0027B12C File Offset: 0x0027932C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278216, RefRangeEnd = 278218, XrefRangeStart = 278199, XrefRangeEnd = 278216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CB0 RID: 40112 RVA: 0x0027B160 File Offset: 0x00279360
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278232, RefRangeEnd = 278234, XrefRangeStart = 278218, XrefRangeEnd = 278232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool preserveSelection = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref preserveSelection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CB1 RID: 40113 RVA: 0x0027B1A0 File Offset: 0x002793A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278234, XrefRangeEnd = 278272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CB2 RID: 40114 RVA: 0x0027B1D4 File Offset: 0x002793D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278310, RefRangeEnd = 278312, XrefRangeStart = 278272, XrefRangeEnd = 278310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateInputPrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CB3 RID: 40115 RVA: 0x0027B208 File Offset: 0x00279408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278397, RefRangeEnd = 278398, XrefRangeStart = 278312, XrefRangeEnd = 278397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUIs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateUIs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CB4 RID: 40116 RVA: 0x0027B23C File Offset: 0x0027943C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278398, XrefRangeEnd = 278466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CB5 RID: 40117 RVA: 0x0027B270 File Offset: 0x00279470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278543, RefRangeEnd = 278544, XrefRangeStart = 278466, XrefRangeEnd = 278543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CB6 RID: 40118 RVA: 0x0027B2A4 File Offset: 0x002794A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278544, XrefRangeEnd = 278555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToSelection(IConfigurable config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_AddToSelection_Private_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CB7 RID: 40119 RVA: 0x0027B2E8 File Offset: 0x002794E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278570, RefRangeEnd = 278571, XrefRangeStart = 278555, XrefRangeEnd = 278570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromSelection(IConfigurable config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveFromSelection_Private_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CB8 RID: 40120 RVA: 0x0027B32C File Offset: 0x0027952C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 278590, RefRangeEnd = 278593, XrefRangeStart = 278571, XrefRangeEnd = 278590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_ClearSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CB9 RID: 40121 RVA: 0x0027B360 File Offset: 0x00279560
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278605, RefRangeEnd = 278607, XrefRangeStart = 278593, XrefRangeEnd = 278605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNullConfigurables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveNullConfigurables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CBA RID: 40122 RVA: 0x0027B394 File Offset: 0x00279594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278607, XrefRangeEnd = 278616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IConfigurable GetHoveredConfigurable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetHoveredConfigurable_Private_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr3) : null;
		}

		// Token: 0x06009CBB RID: 40123 RVA: 0x0027B3D4 File Offset: 0x002795D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278687, RefRangeEnd = 278688, XrefRangeStart = 278616, XrefRangeEnd = 278687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<IConfigurable> GetConfigurablesToShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetConfigurablesToShow_Private_List_1_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr3) : null;
		}

		// Token: 0x06009CBC RID: 40124 RVA: 0x0027B414 File Offset: 0x00279614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278695, RefRangeEnd = 278696, XrefRangeStart = 278688, XrefRangeEnd = 278695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowCrosshairPrompt(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_ShowCrosshairPrompt_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CBD RID: 40125 RVA: 0x0027B458 File Offset: 0x00279658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278696, XrefRangeEnd = 278699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideCrosshairPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_HideCrosshairPrompt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CBE RID: 40126 RVA: 0x0027B48C File Offset: 0x0027968C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278699, XrefRangeEnd = 278714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementWorldspaceCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CBF RID: 40127 RVA: 0x0004CD16 File Offset: 0x0004AF16
		public ManagementWorldspaceCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x06009CC0 RID: 40128 RVA: 0x0027B4C8 File Offset: 0x002796C8
		// (set) Token: 0x06009CC1 RID: 40129 RVA: 0x0004CD1F File Offset: 0x0004AF1F
		public unsafe static float VISIBILITY_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_VISIBILITY_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_VISIBILITY_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x06009CC2 RID: 40130 RVA: 0x0027B4E4 File Offset: 0x002796E4
		// (set) Token: 0x06009CC3 RID: 40131 RVA: 0x0004CD2D File Offset: 0x0004AF2D
		public unsafe static float PROPERTY_CANVAS_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x06009CC4 RID: 40132 RVA: 0x0027B500 File Offset: 0x00279700
		// (set) Token: 0x06009CC5 RID: 40133 RVA: 0x0004CD3B File Offset: 0x0004AF3B
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x06009CC6 RID: 40134 RVA: 0x0027B528 File Offset: 0x00279728
		// (set) Token: 0x06009CC7 RID: 40135 RVA: 0x0004CD56 File Offset: 0x0004AF56
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x06009CC8 RID: 40136 RVA: 0x0027B558 File Offset: 0x00279758
		// (set) Token: 0x06009CC9 RID: 40137 RVA: 0x0004CD75 File Offset: 0x0004AF75
		public unsafe AnimationCurve ScaleCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ScaleCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ScaleCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x06009CCA RID: 40138 RVA: 0x0027B588 File Offset: 0x00279788
		// (set) Token: 0x06009CCB RID: 40139 RVA: 0x0004CD94 File Offset: 0x0004AF94
		public unsafe TransitLineVisuals TransitRouteVisualsPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_TransitRouteVisualsPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitLineVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_TransitRouteVisualsPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x06009CCC RID: 40140 RVA: 0x0027B5B8 File Offset: 0x002797B8
		// (set) Token: 0x06009CCD RID: 40141 RVA: 0x0004CDB3 File Offset: 0x0004AFB3
		public unsafe InputPrompt CrosshairPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_CrosshairPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_CrosshairPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x06009CCE RID: 40142 RVA: 0x0027B5E8 File Offset: 0x002797E8
		// (set) Token: 0x06009CCF RID: 40143 RVA: 0x0004CDD2 File Offset: 0x0004AFD2
		public unsafe LayerMask ObjectSelectionLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ObjectSelectionLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ObjectSelectionLayerMask)) = value;
			}
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x06009CD0 RID: 40144 RVA: 0x0027B610 File Offset: 0x00279810
		// (set) Token: 0x06009CD1 RID: 40145 RVA: 0x0004CDED File Offset: 0x0004AFED
		public unsafe Color HoveredOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredOutlineColor)) = value;
			}
		}

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x06009CD2 RID: 40146 RVA: 0x0027B638 File Offset: 0x00279838
		// (set) Token: 0x06009CD3 RID: 40147 RVA: 0x0004CE08 File Offset: 0x0004B008
		public unsafe Color SelectedOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedOutlineColor)) = value;
			}
		}

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x06009CD4 RID: 40148 RVA: 0x0027B660 File Offset: 0x00279860
		// (set) Token: 0x06009CD5 RID: 40149 RVA: 0x0004CE23 File Offset: 0x0004B023
		public unsafe List<IConfigurable> ShownConfigurables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ShownConfigurables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ShownConfigurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x06009CD6 RID: 40150 RVA: 0x0027B690 File Offset: 0x00279890
		// (set) Token: 0x06009CD7 RID: 40151 RVA: 0x0004CE42 File Offset: 0x0004B042
		public unsafe IConfigurable HoveredConfigurable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredConfigurable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredConfigurable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x06009CD8 RID: 40152 RVA: 0x0027B6C0 File Offset: 0x002798C0
		// (set) Token: 0x06009CD9 RID: 40153 RVA: 0x0004CE61 File Offset: 0x0004B061
		public unsafe IConfigurable OutlinedConfigurable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_OutlinedConfigurable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_OutlinedConfigurable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x06009CDA RID: 40154 RVA: 0x0027B6F0 File Offset: 0x002798F0
		// (set) Token: 0x06009CDB RID: 40155 RVA: 0x0004CE80 File Offset: 0x0004B080
		public unsafe List<IConfigurable> SelectedConfigurables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedConfigurables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedConfigurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400693B RID: 26939
		private static readonly IntPtr NativeFieldInfoPtr_VISIBILITY_RANGE;

		// Token: 0x0400693C RID: 26940
		private static readonly IntPtr NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE;

		// Token: 0x0400693D RID: 26941
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400693E RID: 26942
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400693F RID: 26943
		private static readonly IntPtr NativeFieldInfoPtr_ScaleCurve;

		// Token: 0x04006940 RID: 26944
		private static readonly IntPtr NativeFieldInfoPtr_TransitRouteVisualsPrefab;

		// Token: 0x04006941 RID: 26945
		private static readonly IntPtr NativeFieldInfoPtr_CrosshairPrompt;

		// Token: 0x04006942 RID: 26946
		private static readonly IntPtr NativeFieldInfoPtr_ObjectSelectionLayerMask;

		// Token: 0x04006943 RID: 26947
		private static readonly IntPtr NativeFieldInfoPtr_HoveredOutlineColor;

		// Token: 0x04006944 RID: 26948
		private static readonly IntPtr NativeFieldInfoPtr_SelectedOutlineColor;

		// Token: 0x04006945 RID: 26949
		private static readonly IntPtr NativeFieldInfoPtr_ShownConfigurables;

		// Token: 0x04006946 RID: 26950
		private static readonly IntPtr NativeFieldInfoPtr_HoveredConfigurable;

		// Token: 0x04006947 RID: 26951
		private static readonly IntPtr NativeFieldInfoPtr_OutlinedConfigurable;

		// Token: 0x04006948 RID: 26952
		private static readonly IntPtr NativeFieldInfoPtr_SelectedConfigurables;

		// Token: 0x04006949 RID: 26953
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400694A RID: 26954
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400694B RID: 26955
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0;

		// Token: 0x0400694C RID: 26956
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400694D RID: 26957
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x0400694E RID: 26958
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400694F RID: 26959
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputPrompt_Private_Void_0;

		// Token: 0x04006950 RID: 26960
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUIs_Private_Void_0;

		// Token: 0x04006951 RID: 26961
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006952 RID: 26962
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelection_Private_Void_0;

		// Token: 0x04006953 RID: 26963
		private static readonly IntPtr NativeMethodInfoPtr_AddToSelection_Private_Void_IConfigurable_0;

		// Token: 0x04006954 RID: 26964
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromSelection_Private_Void_IConfigurable_0;

		// Token: 0x04006955 RID: 26965
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Private_Void_0;

		// Token: 0x04006956 RID: 26966
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNullConfigurables_Private_Void_0;

		// Token: 0x04006957 RID: 26967
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredConfigurable_Private_IConfigurable_0;

		// Token: 0x04006958 RID: 26968
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigurablesToShow_Private_List_1_IConfigurable_0;

		// Token: 0x04006959 RID: 26969
		private static readonly IntPtr NativeMethodInfoPtr_ShowCrosshairPrompt_Public_Void_String_0;

		// Token: 0x0400695A RID: 26970
		private static readonly IntPtr NativeMethodInfoPtr_HideCrosshairPrompt_Public_Void_0;

		// Token: 0x0400695B RID: 26971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B93 RID: 2963
		[ObfuscatedName("ScheduleOne.UI.Management.ManagementWorldspaceCanvas+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DC1F RID: 56351 RVA: 0x003410F0 File Offset: 0x0033F2F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr);
				ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, "<>9");
				ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, "<>9__24_0");
				ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, 100682550);
				ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__LateUpdate_b__24_0_Internal_Int32_IConfigurable_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, 100682551);
			}

			// Token: 0x0600DC20 RID: 56352 RVA: 0x0034116C File Offset: 0x0033F36C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC21 RID: 56353 RVA: 0x003411A8 File Offset: 0x0033F3A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278158, XrefRangeEnd = 278187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _LateUpdate_b__24_0(IConfigurable a, IConfigurable b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__LateUpdate_b__24_0_Internal_Int32_IConfigurable_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DC22 RID: 56354 RVA: 0x0006B3DA File Offset: 0x000695DA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700443D RID: 17469
			// (get) Token: 0x0600DC23 RID: 56355 RVA: 0x00341208 File Offset: 0x0033F408
			// (set) Token: 0x0600DC24 RID: 56356 RVA: 0x0006B3E3 File Offset: 0x000695E3
			public unsafe static ManagementWorldspaceCanvas.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementWorldspaceCanvas.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700443E RID: 17470
			// (get) Token: 0x0600DC25 RID: 56357 RVA: 0x00341230 File Offset: 0x0033F430
			// (set) Token: 0x0600DC26 RID: 56358 RVA: 0x0006B3F5 File Offset: 0x000695F5
			public unsafe static Comparison<IConfigurable> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<IConfigurable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400938E RID: 37774
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400938F RID: 37775
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04009390 RID: 37776
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009391 RID: 37777
			private static readonly IntPtr NativeMethodInfoPtr__LateUpdate_b__24_0_Internal_Int32_IConfigurable_IConfigurable_0;
		}

		// Token: 0x02000B94 RID: 2964
		[ObfuscatedName("ScheduleOne.UI.Management.ManagementWorldspaceCanvas+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC27 RID: 56359 RVA: 0x00341258 File Offset: 0x0033F458
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr);
				ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr, "config");
				ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr, "<>4__this");
				ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr, 100682552);
				ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeMethodInfoPtr__UpdateUIs_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr, 100682553);
			}

			// Token: 0x0600DC28 RID: 56360 RVA: 0x003412D4 File Offset: 0x0033F4D4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC29 RID: 56361 RVA: 0x00341310 File Offset: 0x0033F510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278187, XrefRangeEnd = 278191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateUIs_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeMethodInfoPtr__UpdateUIs_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC2A RID: 56362 RVA: 0x0006B407 File Offset: 0x00069607
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700443F RID: 17471
			// (get) Token: 0x0600DC2B RID: 56363 RVA: 0x00341344 File Offset: 0x0033F544
			// (set) Token: 0x0600DC2C RID: 56364 RVA: 0x0006B410 File Offset: 0x00069610
			public unsafe IConfigurable config
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr_config);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr_config), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004440 RID: 17472
			// (get) Token: 0x0600DC2D RID: 56365 RVA: 0x00341374 File Offset: 0x0033F574
			// (set) Token: 0x0600DC2E RID: 56366 RVA: 0x0006B42F File Offset: 0x0006962F
			public unsafe ManagementWorldspaceCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementWorldspaceCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009392 RID: 37778
			private static readonly IntPtr NativeFieldInfoPtr_config;

			// Token: 0x04009393 RID: 37779
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009394 RID: 37780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009395 RID: 37781
			private static readonly IntPtr NativeMethodInfoPtr__UpdateUIs_b__0_Internal_Void_0;
		}
	}
}
