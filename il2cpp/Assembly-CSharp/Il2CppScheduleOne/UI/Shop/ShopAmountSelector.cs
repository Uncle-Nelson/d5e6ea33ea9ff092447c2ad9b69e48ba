using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200070D RID: 1805
	public class ShopAmountSelector : MonoBehaviour
	{
		// Token: 0x0600A225 RID: 41509 RVA: 0x0028C138 File Offset: 0x0028A338
		// Note: this type is marked as 'beforefieldinit'.
		static ShopAmountSelector()
		{
			Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopAmountSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr);
			ShopAmountSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			ShopAmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "<SelectedAmount>k__BackingField");
			ShopAmountSelector.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "Container");
			ShopAmountSelector.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "InputField");
			ShopAmountSelector.NativeFieldInfoPtr_onSubmitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "onSubmitted");
			ShopAmountSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683125);
			ShopAmountSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683126);
			ShopAmountSelector.NativeMethodInfoPtr_get_SelectedAmount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683127);
			ShopAmountSelector.NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683128);
			ShopAmountSelector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683129);
			ShopAmountSelector.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683130);
			ShopAmountSelector.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683131);
			ShopAmountSelector.NativeMethodInfoPtr_OnSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683132);
			ShopAmountSelector.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683133);
			ShopAmountSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683134);
		}

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0600A226 RID: 41510 RVA: 0x0028C294 File Offset: 0x0028A494
		// (set) Token: 0x0600A227 RID: 41511 RVA: 0x0028C2D0 File Offset: 0x0028A4D0
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x0600A228 RID: 41512 RVA: 0x0028C310 File Offset: 0x0028A510
		// (set) Token: 0x0600A229 RID: 41513 RVA: 0x0028C34C File Offset: 0x0028A54C
		public unsafe int SelectedAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_get_SelectedAmount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29963, RefRangeEnd = 29964, XrefRangeStart = 29963, XrefRangeEnd = 29964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A22A RID: 41514 RVA: 0x0028C38C File Offset: 0x0028A58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284625, XrefRangeEnd = 284644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A22B RID: 41515 RVA: 0x0028C3C0 File Offset: 0x0028A5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284644, XrefRangeEnd = 284650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A22C RID: 41516 RVA: 0x0028C3F4 File Offset: 0x0028A5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284650, XrefRangeEnd = 284652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A22D RID: 41517 RVA: 0x0028C428 File Offset: 0x0028A628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284652, XrefRangeEnd = 284664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_OnSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A22E RID: 41518 RVA: 0x0028C46C File Offset: 0x0028A66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284664, XrefRangeEnd = 284668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A22F RID: 41519 RVA: 0x0028C4B0 File Offset: 0x0028A6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284668, XrefRangeEnd = 284669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopAmountSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A230 RID: 41520 RVA: 0x0004FCA3 File Offset: 0x0004DEA3
		public ShopAmountSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x0600A231 RID: 41521 RVA: 0x0028C4EC File Offset: 0x0028A6EC
		// (set) Token: 0x0600A232 RID: 41522 RVA: 0x0004FCAC File Offset: 0x0004DEAC
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x0600A233 RID: 41523 RVA: 0x0028C514 File Offset: 0x0028A714
		// (set) Token: 0x0600A234 RID: 41524 RVA: 0x0004FCC7 File Offset: 0x0004DEC7
		public unsafe int _SelectedAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0600A235 RID: 41525 RVA: 0x0028C53C File Offset: 0x0028A73C
		// (set) Token: 0x0600A236 RID: 41526 RVA: 0x0004FCE2 File Offset: 0x0004DEE2
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0600A237 RID: 41527 RVA: 0x0028C56C File Offset: 0x0028A76C
		// (set) Token: 0x0600A238 RID: 41528 RVA: 0x0004FD01 File Offset: 0x0004DF01
		public unsafe TMP_InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0600A239 RID: 41529 RVA: 0x0028C59C File Offset: 0x0028A79C
		// (set) Token: 0x0600A23A RID: 41530 RVA: 0x0004FD20 File Offset: 0x0004DF20
		public unsafe UnityEvent<int> onSubmitted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_onSubmitted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_onSubmitted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006CC4 RID: 27844
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006CC5 RID: 27845
		private static readonly IntPtr NativeFieldInfoPtr__SelectedAmount_k__BackingField;

		// Token: 0x04006CC6 RID: 27846
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006CC7 RID: 27847
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x04006CC8 RID: 27848
		private static readonly IntPtr NativeFieldInfoPtr_onSubmitted;

		// Token: 0x04006CC9 RID: 27849
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006CCA RID: 27850
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006CCB RID: 27851
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedAmount_Public_get_Int32_0;

		// Token: 0x04006CCC RID: 27852
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Int32_0;

		// Token: 0x04006CCD RID: 27853
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006CCE RID: 27854
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006CCF RID: 27855
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006CD0 RID: 27856
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmitted_Private_Void_String_0;

		// Token: 0x04006CD1 RID: 27857
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0;

		// Token: 0x04006CD2 RID: 27858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
