using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.UI.Tooltips;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations.Drying_rack
{
	// Token: 0x02000683 RID: 1667
	public class DryingOperationUI : MonoBehaviour
	{
		// Token: 0x0600957D RID: 38269 RVA: 0x0026555C File Offset: 0x0026375C
		// Note: this type is marked as 'beforefieldinit'.
		static DryingOperationUI()
		{
			Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations.Drying_rack", "DryingOperationUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr);
			DryingOperationUI.NativeFieldInfoPtr__AssignedOperation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "<AssignedOperation>k__BackingField");
			DryingOperationUI.NativeFieldInfoPtr__Alignment_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "<Alignment>k__BackingField");
			DryingOperationUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Rect");
			DryingOperationUI.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Icon");
			DryingOperationUI.NativeFieldInfoPtr_QuantityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "QuantityLabel");
			DryingOperationUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Button");
			DryingOperationUI.NativeFieldInfoPtr_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Tooltip");
			DryingOperationUI.NativeMethodInfoPtr_get_AssignedOperation_Public_get_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681773);
			DryingOperationUI.NativeMethodInfoPtr_set_AssignedOperation_Protected_set_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681774);
			DryingOperationUI.NativeMethodInfoPtr_get_Alignment_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681775);
			DryingOperationUI.NativeMethodInfoPtr_set_Alignment_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681776);
			DryingOperationUI.NativeMethodInfoPtr_SetOperation_Public_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681777);
			DryingOperationUI.NativeMethodInfoPtr_SetAlignment_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681778);
			DryingOperationUI.NativeMethodInfoPtr_RefreshQuantity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681779);
			DryingOperationUI.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681780);
			DryingOperationUI.NativeMethodInfoPtr_UpdatePosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681781);
			DryingOperationUI.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681782);
			DryingOperationUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681783);
			DryingOperationUI.NativeMethodInfoPtr__Start_b__16_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100681784);
		}

		// Token: 0x17002DF5 RID: 11765
		// (get) Token: 0x0600957E RID: 38270 RVA: 0x00265708 File Offset: 0x00263908
		// (set) Token: 0x0600957F RID: 38271 RVA: 0x00265748 File Offset: 0x00263948
		public unsafe DryingOperation AssignedOperation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_get_AssignedOperation_Public_get_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingOperation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_set_AssignedOperation_Protected_set_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DF6 RID: 11766
		// (get) Token: 0x06009580 RID: 38272 RVA: 0x0026578C File Offset: 0x0026398C
		// (set) Token: 0x06009581 RID: 38273 RVA: 0x002657CC File Offset: 0x002639CC
		public unsafe RectTransform Alignment
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_get_Alignment_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_set_Alignment_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009582 RID: 38274 RVA: 0x00265810 File Offset: 0x00263A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268886, XrefRangeEnd = 268892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOperation(DryingOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_SetOperation_Public_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009583 RID: 38275 RVA: 0x00265854 File Offset: 0x00263A54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268897, RefRangeEnd = 268898, XrefRangeStart = 268892, XrefRangeEnd = 268897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlignment(RectTransform alignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_SetAlignment_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009584 RID: 38276 RVA: 0x00265898 File Offset: 0x00263A98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 268903, RefRangeEnd = 268906, XrefRangeStart = 268898, XrefRangeEnd = 268903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshQuantity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_RefreshQuantity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009585 RID: 38277 RVA: 0x002658CC File Offset: 0x00263ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268906, XrefRangeEnd = 268914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x00265900 File Offset: 0x00263B00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 268926, RefRangeEnd = 268930, XrefRangeStart = 268914, XrefRangeEnd = 268926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_UpdatePosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009587 RID: 38279 RVA: 0x00265934 File Offset: 0x00263B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268930, XrefRangeEnd = 268943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009588 RID: 38280 RVA: 0x00265968 File Offset: 0x00263B68
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingOperationUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009589 RID: 38281 RVA: 0x002659A4 File Offset: 0x00263BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__16_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr__Start_b__16_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600958A RID: 38282 RVA: 0x00048B1D File Offset: 0x00046D1D
		public DryingOperationUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x0600958B RID: 38283 RVA: 0x002659D8 File Offset: 0x00263BD8
		// (set) Token: 0x0600958C RID: 38284 RVA: 0x00048B26 File Offset: 0x00046D26
		public unsafe DryingOperation _AssignedOperation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__AssignedOperation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__AssignedOperation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x0600958D RID: 38285 RVA: 0x00265A08 File Offset: 0x00263C08
		// (set) Token: 0x0600958E RID: 38286 RVA: 0x00048B45 File Offset: 0x00046D45
		public unsafe RectTransform _Alignment_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__Alignment_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__Alignment_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x0600958F RID: 38287 RVA: 0x00265A38 File Offset: 0x00263C38
		// (set) Token: 0x06009590 RID: 38288 RVA: 0x00048B64 File Offset: 0x00046D64
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x06009591 RID: 38289 RVA: 0x00265A68 File Offset: 0x00263C68
		// (set) Token: 0x06009592 RID: 38290 RVA: 0x00048B83 File Offset: 0x00046D83
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x06009593 RID: 38291 RVA: 0x00265A98 File Offset: 0x00263C98
		// (set) Token: 0x06009594 RID: 38292 RVA: 0x00048BA2 File Offset: 0x00046DA2
		public unsafe TextMeshProUGUI QuantityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_QuantityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_QuantityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DF3 RID: 11763
		// (get) Token: 0x06009595 RID: 38293 RVA: 0x00265AC8 File Offset: 0x00263CC8
		// (set) Token: 0x06009596 RID: 38294 RVA: 0x00048BC1 File Offset: 0x00046DC1
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DF4 RID: 11764
		// (get) Token: 0x06009597 RID: 38295 RVA: 0x00265AF8 File Offset: 0x00263CF8
		// (set) Token: 0x06009598 RID: 38296 RVA: 0x00048BE0 File Offset: 0x00046DE0
		public unsafe Tooltip Tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Tooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Tooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040064CF RID: 25807
		private static readonly IntPtr NativeFieldInfoPtr__AssignedOperation_k__BackingField;

		// Token: 0x040064D0 RID: 25808
		private static readonly IntPtr NativeFieldInfoPtr__Alignment_k__BackingField;

		// Token: 0x040064D1 RID: 25809
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040064D2 RID: 25810
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x040064D3 RID: 25811
		private static readonly IntPtr NativeFieldInfoPtr_QuantityLabel;

		// Token: 0x040064D4 RID: 25812
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040064D5 RID: 25813
		private static readonly IntPtr NativeFieldInfoPtr_Tooltip;

		// Token: 0x040064D6 RID: 25814
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedOperation_Public_get_DryingOperation_0;

		// Token: 0x040064D7 RID: 25815
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedOperation_Protected_set_Void_DryingOperation_0;

		// Token: 0x040064D8 RID: 25816
		private static readonly IntPtr NativeMethodInfoPtr_get_Alignment_Public_get_RectTransform_0;

		// Token: 0x040064D9 RID: 25817
		private static readonly IntPtr NativeMethodInfoPtr_set_Alignment_Private_set_Void_RectTransform_0;

		// Token: 0x040064DA RID: 25818
		private static readonly IntPtr NativeMethodInfoPtr_SetOperation_Public_Void_DryingOperation_0;

		// Token: 0x040064DB RID: 25819
		private static readonly IntPtr NativeMethodInfoPtr_SetAlignment_Public_Void_RectTransform_0;

		// Token: 0x040064DC RID: 25820
		private static readonly IntPtr NativeMethodInfoPtr_RefreshQuantity_Public_Void_0;

		// Token: 0x040064DD RID: 25821
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040064DE RID: 25822
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Void_0;

		// Token: 0x040064DF RID: 25823
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x040064E0 RID: 25824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040064E1 RID: 25825
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__16_0_Private_Void_0;
	}
}
