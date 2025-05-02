using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.Storage;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200062E RID: 1582
	public class CreateMixInterface : Singleton<CreateMixInterface>
	{
		// Token: 0x06008B74 RID: 35700 RVA: 0x002479A4 File Offset: 0x00245BA4
		// Note: this type is marked as 'beforefieldinit'.
		static CreateMixInterface()
		{
			Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CreateMixInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr);
			CreateMixInterface.NativeFieldInfoPtr_BEAN_REQUIREMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "BEAN_REQUIREMENT");
			CreateMixInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CreateMixInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "Canvas");
			CreateMixInterface.NativeFieldInfoPtr_BeansSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "BeansSlot");
			CreateMixInterface.NativeFieldInfoPtr_ProductSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "ProductSlot");
			CreateMixInterface.NativeFieldInfoPtr_MixerSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "MixerSlot");
			CreateMixInterface.NativeFieldInfoPtr_OutputSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "OutputSlot");
			CreateMixInterface.NativeFieldInfoPtr_OutputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "OutputIcon");
			CreateMixInterface.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "BeginButton");
			CreateMixInterface.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "Storage");
			CreateMixInterface.NativeFieldInfoPtr_ProductPropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "ProductPropertiesLabel");
			CreateMixInterface.NativeFieldInfoPtr_OutputPropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "OutputPropertiesLabel");
			CreateMixInterface.NativeFieldInfoPtr_BeanProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "BeanProblemLabel");
			CreateMixInterface.NativeFieldInfoPtr_ProductProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "ProductProblemLabel");
			CreateMixInterface.NativeFieldInfoPtr_MixerProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "MixerProblemLabel");
			CreateMixInterface.NativeFieldInfoPtr_OutputProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "OutputProblemLabel");
			CreateMixInterface.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "CameraPosition");
			CreateMixInterface.NativeFieldInfoPtr_UnknownOutputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "UnknownOutputIcon");
			CreateMixInterface.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "onOpen");
			CreateMixInterface.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "onClose");
			CreateMixInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680622);
			CreateMixInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680623);
			CreateMixInterface.NativeMethodInfoPtr_get_beanSlot_Private_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680624);
			CreateMixInterface.NativeMethodInfoPtr_get_mixerSlot_Private_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680625);
			CreateMixInterface.NativeMethodInfoPtr_get_outputSlot_Private_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680626);
			CreateMixInterface.NativeMethodInfoPtr_get_productSlot_Private_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680627);
			CreateMixInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680628);
			CreateMixInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680629);
			CreateMixInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680630);
			CreateMixInterface.NativeMethodInfoPtr_ContentsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680631);
			CreateMixInterface.NativeMethodInfoPtr_UpdateCanBegin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680632);
			CreateMixInterface.NativeMethodInfoPtr_UpdateOutput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680633);
			CreateMixInterface.NativeMethodInfoPtr_BeginPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680634);
			CreateMixInterface.NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680635);
			CreateMixInterface.NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680636);
			CreateMixInterface.NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680637);
			CreateMixInterface.NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680638);
			CreateMixInterface.NativeMethodInfoPtr_CanBegin_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680639);
			CreateMixInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680640);
			CreateMixInterface.NativeMethodInfoPtr_HasProduct_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680641);
			CreateMixInterface.NativeMethodInfoPtr_HasBeans_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680642);
			CreateMixInterface.NativeMethodInfoPtr_HasMixer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680643);
			CreateMixInterface.NativeMethodInfoPtr_GetProduct_Private_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680644);
			CreateMixInterface.NativeMethodInfoPtr_GetMixer_Private_PropertyItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680645);
			CreateMixInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680646);
		}

		// Token: 0x17002A97 RID: 10903
		// (get) Token: 0x06008B75 RID: 35701 RVA: 0x00247D58 File Offset: 0x00245F58
		// (set) Token: 0x06008B76 RID: 35702 RVA: 0x00247D94 File Offset: 0x00245F94
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x06008B77 RID: 35703 RVA: 0x00247DD4 File Offset: 0x00245FD4
		public unsafe ItemSlot beanSlot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255473, XrefRangeEnd = 255477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_beanSlot_Private_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
		}

		// Token: 0x17002A99 RID: 10905
		// (get) Token: 0x06008B78 RID: 35704 RVA: 0x00247E14 File Offset: 0x00246014
		public unsafe ItemSlot mixerSlot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255477, XrefRangeEnd = 255481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_mixerSlot_Private_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
		}

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x06008B79 RID: 35705 RVA: 0x00247E54 File Offset: 0x00246054
		public unsafe ItemSlot outputSlot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255481, XrefRangeEnd = 255485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_outputSlot_Private_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
		}

		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x06008B7A RID: 35706 RVA: 0x00247E94 File Offset: 0x00246094
		public unsafe ItemSlot productSlot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255485, XrefRangeEnd = 255489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_productSlot_Private_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
		}

		// Token: 0x06008B7B RID: 35707 RVA: 0x00247ED4 File Offset: 0x002460D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255489, XrefRangeEnd = 255573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateMixInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B7C RID: 35708 RVA: 0x00247F10 File Offset: 0x00246110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255573, XrefRangeEnd = 255575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B7D RID: 35709 RVA: 0x00247F54 File Offset: 0x00246154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255673, RefRangeEnd = 255674, XrefRangeStart = 255575, XrefRangeEnd = 255673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B7E RID: 35710 RVA: 0x00247F88 File Offset: 0x00246188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255674, XrefRangeEnd = 255676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContentsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_ContentsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B7F RID: 35711 RVA: 0x00247FBC File Offset: 0x002461BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255721, RefRangeEnd = 255723, XrefRangeStart = 255676, XrefRangeEnd = 255721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCanBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_UpdateCanBegin_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B80 RID: 35712 RVA: 0x00247FF0 File Offset: 0x002461F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255813, RefRangeEnd = 255815, XrefRangeStart = 255723, XrefRangeEnd = 255813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOutput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_UpdateOutput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B81 RID: 35713 RVA: 0x00248024 File Offset: 0x00246224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255815, XrefRangeEnd = 255840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_BeginPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B82 RID: 35714 RVA: 0x00248058 File Offset: 0x00246258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255840, XrefRangeEnd = 255846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr3) : null;
		}

		// Token: 0x06008B83 RID: 35715 RVA: 0x002480BC File Offset: 0x002462BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255873, RefRangeEnd = 255874, XrefRangeStart = 255846, XrefRangeEnd = 255873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			knownProduct = ((intPtr4 == 0) ? null : new ProductDefinition(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008B84 RID: 35716 RVA: 0x0024811C File Offset: 0x0024631C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255887, RefRangeEnd = 255889, XrefRangeStart = 255874, XrefRangeEnd = 255887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyListString(List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008B85 RID: 35717 RVA: 0x00248164 File Offset: 0x00246364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255907, RefRangeEnd = 255909, XrefRangeStart = 255889, XrefRangeEnd = 255907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyString(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008B86 RID: 35718 RVA: 0x002481AC File Offset: 0x002463AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255924, RefRangeEnd = 255926, XrefRangeStart = 255909, XrefRangeEnd = 255924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_CanBegin_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008B87 RID: 35719 RVA: 0x002481E8 File Offset: 0x002463E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256022, RefRangeEnd = 256024, XrefRangeStart = 255926, XrefRangeEnd = 256022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B88 RID: 35720 RVA: 0x0024821C File Offset: 0x0024641C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256024, XrefRangeEnd = 256029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_HasProduct_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008B89 RID: 35721 RVA: 0x00248258 File Offset: 0x00246458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256029, XrefRangeEnd = 256033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasBeans()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_HasBeans_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008B8A RID: 35722 RVA: 0x00248294 File Offset: 0x00246494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256033, XrefRangeEnd = 256038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasMixer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_HasMixer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008B8B RID: 35723 RVA: 0x002482D0 File Offset: 0x002464D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 256042, RefRangeEnd = 256049, XrefRangeStart = 256038, XrefRangeEnd = 256042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDefinition GetProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetProduct_Private_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr3) : null;
		}

		// Token: 0x06008B8C RID: 35724 RVA: 0x00248310 File Offset: 0x00246510
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 256070, RefRangeEnd = 256076, XrefRangeStart = 256049, XrefRangeEnd = 256070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyItemDefinition GetMixer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetMixer_Private_PropertyItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyItemDefinition>(intPtr3) : null;
		}

		// Token: 0x06008B8D RID: 35725 RVA: 0x00248350 File Offset: 0x00246550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256076, XrefRangeEnd = 256079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateMixInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B8E RID: 35726 RVA: 0x00042C44 File Offset: 0x00040E44
		public CreateMixInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x06008B8F RID: 35727 RVA: 0x0024838C File Offset: 0x0024658C
		// (set) Token: 0x06008B90 RID: 35728 RVA: 0x00042C4D File Offset: 0x00040E4D
		public unsafe static int BEAN_REQUIREMENT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CreateMixInterface.NativeFieldInfoPtr_BEAN_REQUIREMENT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreateMixInterface.NativeFieldInfoPtr_BEAN_REQUIREMENT, (void*)(&value));
			}
		}

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x06008B91 RID: 35729 RVA: 0x002483A8 File Offset: 0x002465A8
		// (set) Token: 0x06008B92 RID: 35730 RVA: 0x00042C5B File Offset: 0x00040E5B
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x06008B93 RID: 35731 RVA: 0x002483D0 File Offset: 0x002465D0
		// (set) Token: 0x06008B94 RID: 35732 RVA: 0x00042C76 File Offset: 0x00040E76
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x06008B95 RID: 35733 RVA: 0x00248400 File Offset: 0x00246600
		// (set) Token: 0x06008B96 RID: 35734 RVA: 0x00042C95 File Offset: 0x00040E95
		public unsafe ItemSlotUI BeansSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeansSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeansSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x06008B97 RID: 35735 RVA: 0x00248430 File Offset: 0x00246630
		// (set) Token: 0x06008B98 RID: 35736 RVA: 0x00042CB4 File Offset: 0x00040EB4
		public unsafe ItemSlotUI ProductSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x06008B99 RID: 35737 RVA: 0x00248460 File Offset: 0x00246660
		// (set) Token: 0x06008B9A RID: 35738 RVA: 0x00042CD3 File Offset: 0x00040ED3
		public unsafe ItemSlotUI MixerSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_MixerSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_MixerSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x06008B9B RID: 35739 RVA: 0x00248490 File Offset: 0x00246690
		// (set) Token: 0x06008B9C RID: 35740 RVA: 0x00042CF2 File Offset: 0x00040EF2
		public unsafe ItemSlotUI OutputSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8A RID: 10890
		// (get) Token: 0x06008B9D RID: 35741 RVA: 0x002484C0 File Offset: 0x002466C0
		// (set) Token: 0x06008B9E RID: 35742 RVA: 0x00042D11 File Offset: 0x00040F11
		public unsafe Image OutputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8B RID: 10891
		// (get) Token: 0x06008B9F RID: 35743 RVA: 0x002484F0 File Offset: 0x002466F0
		// (set) Token: 0x06008BA0 RID: 35744 RVA: 0x00042D30 File Offset: 0x00040F30
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8C RID: 10892
		// (get) Token: 0x06008BA1 RID: 35745 RVA: 0x00248520 File Offset: 0x00246720
		// (set) Token: 0x06008BA2 RID: 35746 RVA: 0x00042D4F File Offset: 0x00040F4F
		public unsafe WorldStorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldStorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8D RID: 10893
		// (get) Token: 0x06008BA3 RID: 35747 RVA: 0x00248550 File Offset: 0x00246750
		// (set) Token: 0x06008BA4 RID: 35748 RVA: 0x00042D6E File Offset: 0x00040F6E
		public unsafe TextMeshProUGUI ProductPropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductPropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductPropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8E RID: 10894
		// (get) Token: 0x06008BA5 RID: 35749 RVA: 0x00248580 File Offset: 0x00246780
		// (set) Token: 0x06008BA6 RID: 35750 RVA: 0x00042D8D File Offset: 0x00040F8D
		public unsafe TextMeshProUGUI OutputPropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputPropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputPropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8F RID: 10895
		// (get) Token: 0x06008BA7 RID: 35751 RVA: 0x002485B0 File Offset: 0x002467B0
		// (set) Token: 0x06008BA8 RID: 35752 RVA: 0x00042DAC File Offset: 0x00040FAC
		public unsafe TextMeshProUGUI BeanProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeanProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeanProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A90 RID: 10896
		// (get) Token: 0x06008BA9 RID: 35753 RVA: 0x002485E0 File Offset: 0x002467E0
		// (set) Token: 0x06008BAA RID: 35754 RVA: 0x00042DCB File Offset: 0x00040FCB
		public unsafe TextMeshProUGUI ProductProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A91 RID: 10897
		// (get) Token: 0x06008BAB RID: 35755 RVA: 0x00248610 File Offset: 0x00246810
		// (set) Token: 0x06008BAC RID: 35756 RVA: 0x00042DEA File Offset: 0x00040FEA
		public unsafe TextMeshProUGUI MixerProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_MixerProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_MixerProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A92 RID: 10898
		// (get) Token: 0x06008BAD RID: 35757 RVA: 0x00248640 File Offset: 0x00246840
		// (set) Token: 0x06008BAE RID: 35758 RVA: 0x00042E09 File Offset: 0x00041009
		public unsafe TextMeshProUGUI OutputProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A93 RID: 10899
		// (get) Token: 0x06008BAF RID: 35759 RVA: 0x00248670 File Offset: 0x00246870
		// (set) Token: 0x06008BB0 RID: 35760 RVA: 0x00042E28 File Offset: 0x00041028
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A94 RID: 10900
		// (get) Token: 0x06008BB1 RID: 35761 RVA: 0x002486A0 File Offset: 0x002468A0
		// (set) Token: 0x06008BB2 RID: 35762 RVA: 0x00042E47 File Offset: 0x00041047
		public unsafe RectTransform UnknownOutputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_UnknownOutputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_UnknownOutputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A95 RID: 10901
		// (get) Token: 0x06008BB3 RID: 35763 RVA: 0x002486D0 File Offset: 0x002468D0
		// (set) Token: 0x06008BB4 RID: 35764 RVA: 0x00042E66 File Offset: 0x00041066
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A96 RID: 10902
		// (get) Token: 0x06008BB5 RID: 35765 RVA: 0x00248700 File Offset: 0x00246900
		// (set) Token: 0x06008BB6 RID: 35766 RVA: 0x00042E85 File Offset: 0x00041085
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005E8D RID: 24205
		private static readonly IntPtr NativeFieldInfoPtr_BEAN_REQUIREMENT;

		// Token: 0x04005E8E RID: 24206
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005E8F RID: 24207
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04005E90 RID: 24208
		private static readonly IntPtr NativeFieldInfoPtr_BeansSlot;

		// Token: 0x04005E91 RID: 24209
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlot;

		// Token: 0x04005E92 RID: 24210
		private static readonly IntPtr NativeFieldInfoPtr_MixerSlot;

		// Token: 0x04005E93 RID: 24211
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlot;

		// Token: 0x04005E94 RID: 24212
		private static readonly IntPtr NativeFieldInfoPtr_OutputIcon;

		// Token: 0x04005E95 RID: 24213
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x04005E96 RID: 24214
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04005E97 RID: 24215
		private static readonly IntPtr NativeFieldInfoPtr_ProductPropertiesLabel;

		// Token: 0x04005E98 RID: 24216
		private static readonly IntPtr NativeFieldInfoPtr_OutputPropertiesLabel;

		// Token: 0x04005E99 RID: 24217
		private static readonly IntPtr NativeFieldInfoPtr_BeanProblemLabel;

		// Token: 0x04005E9A RID: 24218
		private static readonly IntPtr NativeFieldInfoPtr_ProductProblemLabel;

		// Token: 0x04005E9B RID: 24219
		private static readonly IntPtr NativeFieldInfoPtr_MixerProblemLabel;

		// Token: 0x04005E9C RID: 24220
		private static readonly IntPtr NativeFieldInfoPtr_OutputProblemLabel;

		// Token: 0x04005E9D RID: 24221
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04005E9E RID: 24222
		private static readonly IntPtr NativeFieldInfoPtr_UnknownOutputIcon;

		// Token: 0x04005E9F RID: 24223
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x04005EA0 RID: 24224
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04005EA1 RID: 24225
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005EA2 RID: 24226
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005EA3 RID: 24227
		private static readonly IntPtr NativeMethodInfoPtr_get_beanSlot_Private_get_ItemSlot_0;

		// Token: 0x04005EA4 RID: 24228
		private static readonly IntPtr NativeMethodInfoPtr_get_mixerSlot_Private_get_ItemSlot_0;

		// Token: 0x04005EA5 RID: 24229
		private static readonly IntPtr NativeMethodInfoPtr_get_outputSlot_Private_get_ItemSlot_0;

		// Token: 0x04005EA6 RID: 24230
		private static readonly IntPtr NativeMethodInfoPtr_get_productSlot_Private_get_ItemSlot_0;

		// Token: 0x04005EA7 RID: 24231
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005EA8 RID: 24232
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04005EA9 RID: 24233
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04005EAA RID: 24234
		private static readonly IntPtr NativeMethodInfoPtr_ContentsChanged_Private_Void_0;

		// Token: 0x04005EAB RID: 24235
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanBegin_Private_Void_0;

		// Token: 0x04005EAC RID: 24236
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOutput_Private_Void_0;

		// Token: 0x04005EAD RID: 24237
		private static readonly IntPtr NativeMethodInfoPtr_BeginPressed_Private_Void_0;

		// Token: 0x04005EAE RID: 24238
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0;

		// Token: 0x04005EAF RID: 24239
		private static readonly IntPtr NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0;

		// Token: 0x04005EB0 RID: 24240
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0;

		// Token: 0x04005EB1 RID: 24241
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0;

		// Token: 0x04005EB2 RID: 24242
		private static readonly IntPtr NativeMethodInfoPtr_CanBegin_Private_Boolean_0;

		// Token: 0x04005EB3 RID: 24243
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005EB4 RID: 24244
		private static readonly IntPtr NativeMethodInfoPtr_HasProduct_Private_Boolean_0;

		// Token: 0x04005EB5 RID: 24245
		private static readonly IntPtr NativeMethodInfoPtr_HasBeans_Private_Boolean_0;

		// Token: 0x04005EB6 RID: 24246
		private static readonly IntPtr NativeMethodInfoPtr_HasMixer_Private_Boolean_0;

		// Token: 0x04005EB7 RID: 24247
		private static readonly IntPtr NativeMethodInfoPtr_GetProduct_Private_ProductDefinition_0;

		// Token: 0x04005EB8 RID: 24248
		private static readonly IntPtr NativeMethodInfoPtr_GetMixer_Private_PropertyItemDefinition_0;

		// Token: 0x04005EB9 RID: 24249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
