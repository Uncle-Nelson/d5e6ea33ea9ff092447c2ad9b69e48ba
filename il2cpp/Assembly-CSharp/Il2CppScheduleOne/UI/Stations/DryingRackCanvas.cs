using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.UI.Stations.Drying_rack;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200067F RID: 1663
	public class DryingRackCanvas : Singleton<DryingRackCanvas>
	{
		// Token: 0x060094AF RID: 38063 RVA: 0x00262DB8 File Offset: 0x00260FB8
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackCanvas()
		{
			Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "DryingRackCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr);
			DryingRackCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			DryingRackCanvas.NativeFieldInfoPtr__Rack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "<Rack>k__BackingField");
			DryingRackCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "Canvas");
			DryingRackCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "Container");
			DryingRackCanvas.NativeFieldInfoPtr_InputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "InputSlotUI");
			DryingRackCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "OutputSlotUI");
			DryingRackCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "InstructionLabel");
			DryingRackCanvas.NativeFieldInfoPtr_CapacityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "CapacityLabel");
			DryingRackCanvas.NativeFieldInfoPtr_InsertButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "InsertButton");
			DryingRackCanvas.NativeFieldInfoPtr_IndicatorContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "IndicatorContainer");
			DryingRackCanvas.NativeFieldInfoPtr_IndicatorAlignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "IndicatorAlignments");
			DryingRackCanvas.NativeFieldInfoPtr_IndicatorPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "IndicatorPrefab");
			DryingRackCanvas.NativeFieldInfoPtr_operationUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "operationUIs");
			DryingRackCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681703);
			DryingRackCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681704);
			DryingRackCanvas.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681705);
			DryingRackCanvas.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681706);
			DryingRackCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681707);
			DryingRackCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681708);
			DryingRackCanvas.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681709);
			DryingRackCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681710);
			DryingRackCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681711);
			DryingRackCanvas.NativeMethodInfoPtr_UpdateDryingOperations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681712);
			DryingRackCanvas.NativeMethodInfoPtr_UpdateQuantities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681713);
			DryingRackCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_DryingRack_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681714);
			DryingRackCanvas.NativeMethodInfoPtr_CreateOperationUI_Private_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681715);
			DryingRackCanvas.NativeMethodInfoPtr_DestroyOperationUI_Private_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681716);
			DryingRackCanvas.NativeMethodInfoPtr_Insert_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681717);
			DryingRackCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100681718);
		}

		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x060094B0 RID: 38064 RVA: 0x0026302C File Offset: 0x0026122C
		// (set) Token: 0x060094B1 RID: 38065 RVA: 0x00263068 File Offset: 0x00261268
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x060094B2 RID: 38066 RVA: 0x002630A8 File Offset: 0x002612A8
		// (set) Token: 0x060094B3 RID: 38067 RVA: 0x002630E8 File Offset: 0x002612E8
		public unsafe DryingRack Rack
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060094B4 RID: 38068 RVA: 0x0026312C File Offset: 0x0026132C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267494, XrefRangeEnd = 267497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094B5 RID: 38069 RVA: 0x00263168 File Offset: 0x00261368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267497, XrefRangeEnd = 267519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094B6 RID: 38070 RVA: 0x002631A4 File Offset: 0x002613A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267519, XrefRangeEnd = 267520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094B7 RID: 38071 RVA: 0x002631D8 File Offset: 0x002613D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267520, XrefRangeEnd = 267521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094B8 RID: 38072 RVA: 0x00263214 File Offset: 0x00261414
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267531, RefRangeEnd = 267533, XrefRangeStart = 267521, XrefRangeEnd = 267531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094B9 RID: 38073 RVA: 0x00263248 File Offset: 0x00261448
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 267562, RefRangeEnd = 267566, XrefRangeStart = 267533, XrefRangeEnd = 267562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDryingOperations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_UpdateDryingOperations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094BA RID: 38074 RVA: 0x0026327C File Offset: 0x0026147C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267566, XrefRangeEnd = 267584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateQuantities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_UpdateQuantities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094BB RID: 38075 RVA: 0x002632B0 File Offset: 0x002614B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 267767, RefRangeEnd = 267770, XrefRangeStart = 267584, XrefRangeEnd = 267767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(DryingRack rack, bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_DryingRack_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094BC RID: 38076 RVA: 0x00263300 File Offset: 0x00261500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267770, XrefRangeEnd = 267789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOperationUI(DryingOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_CreateOperationUI_Private_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094BD RID: 38077 RVA: 0x00263344 File Offset: 0x00261544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267789, XrefRangeEnd = 267814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyOperationUI(DryingOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_DestroyOperationUI_Private_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094BE RID: 38078 RVA: 0x00263388 File Offset: 0x00261588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267814, XrefRangeEnd = 267816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_Insert_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094BF RID: 38079 RVA: 0x002633BC File Offset: 0x002615BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267816, XrefRangeEnd = 267826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094C0 RID: 38080 RVA: 0x0004833A File Offset: 0x0004653A
		public DryingRackCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x060094C1 RID: 38081 RVA: 0x002633F8 File Offset: 0x002615F8
		// (set) Token: 0x060094C2 RID: 38082 RVA: 0x00048343 File Offset: 0x00046543
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x060094C3 RID: 38083 RVA: 0x00263420 File Offset: 0x00261620
		// (set) Token: 0x060094C4 RID: 38084 RVA: 0x0004835E File Offset: 0x0004655E
		public unsafe DryingRack _Rack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr__Rack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr__Rack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x060094C5 RID: 38085 RVA: 0x00263450 File Offset: 0x00261650
		// (set) Token: 0x060094C6 RID: 38086 RVA: 0x0004837D File Offset: 0x0004657D
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x060094C7 RID: 38087 RVA: 0x00263480 File Offset: 0x00261680
		// (set) Token: 0x060094C8 RID: 38088 RVA: 0x0004839C File Offset: 0x0004659C
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x060094C9 RID: 38089 RVA: 0x002634B0 File Offset: 0x002616B0
		// (set) Token: 0x060094CA RID: 38090 RVA: 0x000483BB File Offset: 0x000465BB
		public unsafe ItemSlotUI InputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DAA RID: 11690
		// (get) Token: 0x060094CB RID: 38091 RVA: 0x002634E0 File Offset: 0x002616E0
		// (set) Token: 0x060094CC RID: 38092 RVA: 0x000483DA File Offset: 0x000465DA
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DAB RID: 11691
		// (get) Token: 0x060094CD RID: 38093 RVA: 0x00263510 File Offset: 0x00261710
		// (set) Token: 0x060094CE RID: 38094 RVA: 0x000483F9 File Offset: 0x000465F9
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x060094CF RID: 38095 RVA: 0x00263540 File Offset: 0x00261740
		// (set) Token: 0x060094D0 RID: 38096 RVA: 0x00048418 File Offset: 0x00046618
		public unsafe TextMeshProUGUI CapacityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_CapacityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_CapacityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DAD RID: 11693
		// (get) Token: 0x060094D1 RID: 38097 RVA: 0x00263570 File Offset: 0x00261770
		// (set) Token: 0x060094D2 RID: 38098 RVA: 0x00048437 File Offset: 0x00046637
		public unsafe Button InsertButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InsertButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InsertButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x060094D3 RID: 38099 RVA: 0x002635A0 File Offset: 0x002617A0
		// (set) Token: 0x060094D4 RID: 38100 RVA: 0x00048456 File Offset: 0x00046656
		public unsafe RectTransform IndicatorContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x060094D5 RID: 38101 RVA: 0x002635D0 File Offset: 0x002617D0
		// (set) Token: 0x060094D6 RID: 38102 RVA: 0x00048475 File Offset: 0x00046675
		public unsafe Il2CppReferenceArray<RectTransform> IndicatorAlignments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorAlignments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorAlignments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x060094D7 RID: 38103 RVA: 0x00263600 File Offset: 0x00261800
		// (set) Token: 0x060094D8 RID: 38104 RVA: 0x00048494 File Offset: 0x00046694
		public unsafe DryingOperationUI IndicatorPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingOperationUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB1 RID: 11697
		// (get) Token: 0x060094D9 RID: 38105 RVA: 0x00263630 File Offset: 0x00261830
		// (set) Token: 0x060094DA RID: 38106 RVA: 0x000484B3 File Offset: 0x000466B3
		public unsafe List<DryingOperationUI> operationUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_operationUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DryingOperationUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_operationUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400644A RID: 25674
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x0400644B RID: 25675
		private static readonly IntPtr NativeFieldInfoPtr__Rack_k__BackingField;

		// Token: 0x0400644C RID: 25676
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400644D RID: 25677
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400644E RID: 25678
		private static readonly IntPtr NativeFieldInfoPtr_InputSlotUI;

		// Token: 0x0400644F RID: 25679
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x04006450 RID: 25680
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x04006451 RID: 25681
		private static readonly IntPtr NativeFieldInfoPtr_CapacityLabel;

		// Token: 0x04006452 RID: 25682
		private static readonly IntPtr NativeFieldInfoPtr_InsertButton;

		// Token: 0x04006453 RID: 25683
		private static readonly IntPtr NativeFieldInfoPtr_IndicatorContainer;

		// Token: 0x04006454 RID: 25684
		private static readonly IntPtr NativeFieldInfoPtr_IndicatorAlignments;

		// Token: 0x04006455 RID: 25685
		private static readonly IntPtr NativeFieldInfoPtr_IndicatorPrefab;

		// Token: 0x04006456 RID: 25686
		private static readonly IntPtr NativeFieldInfoPtr_operationUIs;

		// Token: 0x04006457 RID: 25687
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006458 RID: 25688
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006459 RID: 25689
		private static readonly IntPtr NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0;

		// Token: 0x0400645A RID: 25690
		private static readonly IntPtr NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0;

		// Token: 0x0400645B RID: 25691
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400645C RID: 25692
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400645D RID: 25693
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400645E RID: 25694
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400645F RID: 25695
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04006460 RID: 25696
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDryingOperations_Private_Void_0;

		// Token: 0x04006461 RID: 25697
		private static readonly IntPtr NativeMethodInfoPtr_UpdateQuantities_Private_Void_0;

		// Token: 0x04006462 RID: 25698
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_DryingRack_Boolean_0;

		// Token: 0x04006463 RID: 25699
		private static readonly IntPtr NativeMethodInfoPtr_CreateOperationUI_Private_Void_DryingOperation_0;

		// Token: 0x04006464 RID: 25700
		private static readonly IntPtr NativeMethodInfoPtr_DestroyOperationUI_Private_Void_DryingOperation_0;

		// Token: 0x04006465 RID: 25701
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_0;

		// Token: 0x04006466 RID: 25702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B5E RID: 2910
		[ObfuscatedName("ScheduleOne.UI.Stations.DryingRackCanvas+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA49 RID: 55881 RVA: 0x0033C014 File Offset: 0x0033A214
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr);
				DryingRackCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr, "operation");
				DryingRackCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr, 100681719);
				DryingRackCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr__DestroyOperationUI_b__0_Internal_Boolean_DryingOperationUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr, 100681720);
			}

			// Token: 0x0600DA4A RID: 55882 RVA: 0x0033C07C File Offset: 0x0033A27C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA4B RID: 55883 RVA: 0x0033C0B8 File Offset: 0x0033A2B8
			[CallerCount(0)]
			public unsafe bool _DestroyOperationUI_b__0(DryingOperationUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr__DestroyOperationUI_b__0_Internal_Boolean_DryingOperationUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA4C RID: 55884 RVA: 0x0006A4BF File Offset: 0x000686BF
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B7 RID: 17335
			// (get) Token: 0x0600DA4D RID: 55885 RVA: 0x0033C108 File Offset: 0x0033A308
			// (set) Token: 0x0600DA4E RID: 55886 RVA: 0x0006A4C8 File Offset: 0x000686C8
			public unsafe DryingOperation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400928D RID: 37517
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x0400928E RID: 37518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400928F RID: 37519
			private static readonly IntPtr NativeMethodInfoPtr__DestroyOperationUI_b__0_Internal_Boolean_DryingOperationUI_0;
		}
	}
}
