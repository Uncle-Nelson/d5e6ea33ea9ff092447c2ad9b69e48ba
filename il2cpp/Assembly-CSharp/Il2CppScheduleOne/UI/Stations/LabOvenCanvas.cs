using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x02000680 RID: 1664
	public class LabOvenCanvas : Singleton<LabOvenCanvas>
	{
		// Token: 0x060094DB RID: 38107 RVA: 0x00263660 File Offset: 0x00261860
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenCanvas()
		{
			Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "LabOvenCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr);
			LabOvenCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			LabOvenCanvas.NativeFieldInfoPtr__Oven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "<Oven>k__BackingField");
			LabOvenCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "Canvas");
			LabOvenCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "Container");
			LabOvenCanvas.NativeFieldInfoPtr_IngredientSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "IngredientSlotUI");
			LabOvenCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "OutputSlotUI");
			LabOvenCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "InstructionLabel");
			LabOvenCanvas.NativeFieldInfoPtr_ErrorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ErrorLabel");
			LabOvenCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "BeginButton");
			LabOvenCanvas.NativeFieldInfoPtr_BeginButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "BeginButtonLabel");
			LabOvenCanvas.NativeFieldInfoPtr_ProgressContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ProgressContainer");
			LabOvenCanvas.NativeFieldInfoPtr_IngredientIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "IngredientIcon");
			LabOvenCanvas.NativeFieldInfoPtr_ProgressImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ProgressImg");
			LabOvenCanvas.NativeFieldInfoPtr_ProductIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ProductIcon");
			LabOvenCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681721);
			LabOvenCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681722);
			LabOvenCanvas.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681723);
			LabOvenCanvas.NativeMethodInfoPtr_set_Oven_Protected_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681724);
			LabOvenCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681725);
			LabOvenCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681726);
			LabOvenCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681727);
			LabOvenCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_LabOven_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681728);
			LabOvenCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681729);
			LabOvenCanvas.NativeMethodInfoPtr_CanBegin_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681730);
			LabOvenCanvas.NativeMethodInfoPtr_DoesOvenOutputHaveSpace_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681731);
			LabOvenCanvas.NativeMethodInfoPtr_RefreshActiveOperation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681732);
			LabOvenCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100681733);
		}

		// Token: 0x17002DC2 RID: 11714
		// (get) Token: 0x060094DC RID: 38108 RVA: 0x002638AC File Offset: 0x00261AAC
		// (set) Token: 0x060094DD RID: 38109 RVA: 0x002638E8 File Offset: 0x00261AE8
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x060094DE RID: 38110 RVA: 0x00263928 File Offset: 0x00261B28
		// (set) Token: 0x060094DF RID: 38111 RVA: 0x00263968 File Offset: 0x00261B68
		public unsafe LabOven Oven
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_set_Oven_Protected_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060094E0 RID: 38112 RVA: 0x002639AC File Offset: 0x00261BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267826, XrefRangeEnd = 267837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094E1 RID: 38113 RVA: 0x002639E8 File Offset: 0x00261BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267837, XrefRangeEnd = 267841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094E2 RID: 38114 RVA: 0x00263A24 File Offset: 0x00261C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267841, XrefRangeEnd = 267864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094E3 RID: 38115 RVA: 0x00263A60 File Offset: 0x00261C60
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 267939, RefRangeEnd = 267946, XrefRangeStart = 267864, XrefRangeEnd = 267939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(LabOven oven, bool open, bool removeUI = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeUI;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_LabOven_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094E4 RID: 38116 RVA: 0x00263AC0 File Offset: 0x00261CC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267972, RefRangeEnd = 267973, XrefRangeStart = 267946, XrefRangeEnd = 267972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094E5 RID: 38117 RVA: 0x00263AF4 File Offset: 0x00261CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267973, XrefRangeEnd = 267980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_CanBegin_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060094E6 RID: 38118 RVA: 0x00263B30 File Offset: 0x00261D30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267982, RefRangeEnd = 267984, XrefRangeStart = 267980, XrefRangeEnd = 267982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesOvenOutputHaveSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_DoesOvenOutputHaveSpace_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060094E7 RID: 38119 RVA: 0x00263B6C File Offset: 0x00261D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267984, XrefRangeEnd = 267988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshActiveOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_RefreshActiveOperation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094E8 RID: 38120 RVA: 0x00263BA0 File Offset: 0x00261DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267988, XrefRangeEnd = 267991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094E9 RID: 38121 RVA: 0x000484D2 File Offset: 0x000466D2
		public LabOvenCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x060094EA RID: 38122 RVA: 0x00263BDC File Offset: 0x00261DDC
		// (set) Token: 0x060094EB RID: 38123 RVA: 0x000484DB File Offset: 0x000466DB
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x060094EC RID: 38124 RVA: 0x00263C04 File Offset: 0x00261E04
		// (set) Token: 0x060094ED RID: 38125 RVA: 0x000484F6 File Offset: 0x000466F6
		public unsafe LabOven _Oven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr__Oven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr__Oven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x060094EE RID: 38126 RVA: 0x00263C34 File Offset: 0x00261E34
		// (set) Token: 0x060094EF RID: 38127 RVA: 0x00048515 File Offset: 0x00046715
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x060094F0 RID: 38128 RVA: 0x00263C64 File Offset: 0x00261E64
		// (set) Token: 0x060094F1 RID: 38129 RVA: 0x00048534 File Offset: 0x00046734
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB8 RID: 11704
		// (get) Token: 0x060094F2 RID: 38130 RVA: 0x00263C94 File Offset: 0x00261E94
		// (set) Token: 0x060094F3 RID: 38131 RVA: 0x00048553 File Offset: 0x00046753
		public unsafe ItemSlotUI IngredientSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB9 RID: 11705
		// (get) Token: 0x060094F4 RID: 38132 RVA: 0x00263CC4 File Offset: 0x00261EC4
		// (set) Token: 0x060094F5 RID: 38133 RVA: 0x00048572 File Offset: 0x00046772
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DBA RID: 11706
		// (get) Token: 0x060094F6 RID: 38134 RVA: 0x00263CF4 File Offset: 0x00261EF4
		// (set) Token: 0x060094F7 RID: 38135 RVA: 0x00048591 File Offset: 0x00046791
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x060094F8 RID: 38136 RVA: 0x00263D24 File Offset: 0x00261F24
		// (set) Token: 0x060094F9 RID: 38137 RVA: 0x000485B0 File Offset: 0x000467B0
		public unsafe TextMeshProUGUI ErrorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ErrorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ErrorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x060094FA RID: 38138 RVA: 0x00263D54 File Offset: 0x00261F54
		// (set) Token: 0x060094FB RID: 38139 RVA: 0x000485CF File Offset: 0x000467CF
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x060094FC RID: 38140 RVA: 0x00263D84 File Offset: 0x00261F84
		// (set) Token: 0x060094FD RID: 38141 RVA: 0x000485EE File Offset: 0x000467EE
		public unsafe TextMeshProUGUI BeginButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x060094FE RID: 38142 RVA: 0x00263DB4 File Offset: 0x00261FB4
		// (set) Token: 0x060094FF RID: 38143 RVA: 0x0004860D File Offset: 0x0004680D
		public unsafe RectTransform ProgressContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DBF RID: 11711
		// (get) Token: 0x06009500 RID: 38144 RVA: 0x00263DE4 File Offset: 0x00261FE4
		// (set) Token: 0x06009501 RID: 38145 RVA: 0x0004862C File Offset: 0x0004682C
		public unsafe Image IngredientIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC0 RID: 11712
		// (get) Token: 0x06009502 RID: 38146 RVA: 0x00263E14 File Offset: 0x00262014
		// (set) Token: 0x06009503 RID: 38147 RVA: 0x0004864B File Offset: 0x0004684B
		public unsafe Image ProgressImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC1 RID: 11713
		// (get) Token: 0x06009504 RID: 38148 RVA: 0x00263E44 File Offset: 0x00262044
		// (set) Token: 0x06009505 RID: 38149 RVA: 0x0004866A File Offset: 0x0004686A
		public unsafe Image ProductIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProductIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProductIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006467 RID: 25703
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006468 RID: 25704
		private static readonly IntPtr NativeFieldInfoPtr__Oven_k__BackingField;

		// Token: 0x04006469 RID: 25705
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400646A RID: 25706
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400646B RID: 25707
		private static readonly IntPtr NativeFieldInfoPtr_IngredientSlotUI;

		// Token: 0x0400646C RID: 25708
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x0400646D RID: 25709
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x0400646E RID: 25710
		private static readonly IntPtr NativeFieldInfoPtr_ErrorLabel;

		// Token: 0x0400646F RID: 25711
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x04006470 RID: 25712
		private static readonly IntPtr NativeFieldInfoPtr_BeginButtonLabel;

		// Token: 0x04006471 RID: 25713
		private static readonly IntPtr NativeFieldInfoPtr_ProgressContainer;

		// Token: 0x04006472 RID: 25714
		private static readonly IntPtr NativeFieldInfoPtr_IngredientIcon;

		// Token: 0x04006473 RID: 25715
		private static readonly IntPtr NativeFieldInfoPtr_ProgressImg;

		// Token: 0x04006474 RID: 25716
		private static readonly IntPtr NativeFieldInfoPtr_ProductIcon;

		// Token: 0x04006475 RID: 25717
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006476 RID: 25718
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006477 RID: 25719
		private static readonly IntPtr NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0;

		// Token: 0x04006478 RID: 25720
		private static readonly IntPtr NativeMethodInfoPtr_set_Oven_Protected_set_Void_LabOven_0;

		// Token: 0x04006479 RID: 25721
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400647A RID: 25722
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400647B RID: 25723
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400647C RID: 25724
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_LabOven_Boolean_Boolean_0;

		// Token: 0x0400647D RID: 25725
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x0400647E RID: 25726
		private static readonly IntPtr NativeMethodInfoPtr_CanBegin_Public_Boolean_0;

		// Token: 0x0400647F RID: 25727
		private static readonly IntPtr NativeMethodInfoPtr_DoesOvenOutputHaveSpace_Private_Boolean_0;

		// Token: 0x04006480 RID: 25728
		private static readonly IntPtr NativeMethodInfoPtr_RefreshActiveOperation_Private_Void_0;

		// Token: 0x04006481 RID: 25729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
