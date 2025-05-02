using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Levelling;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x020006F9 RID: 1785
	public class CharacterCustomizationOption : MonoBehaviour
	{
		// Token: 0x0600A008 RID: 40968 RVA: 0x0028533C File Offset: 0x0028353C
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomizationOption()
		{
			Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "CharacterCustomizationOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr);
			CharacterCustomizationOption.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "Name");
			CharacterCustomizationOption.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "Label");
			CharacterCustomizationOption.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "Price");
			CharacterCustomizationOption.NativeFieldInfoPtr_RequireLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "RequireLevel");
			CharacterCustomizationOption.NativeFieldInfoPtr_RequiredLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "RequiredLevel");
			CharacterCustomizationOption.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "NameLabel");
			CharacterCustomizationOption.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "PriceLabel");
			CharacterCustomizationOption.NativeFieldInfoPtr_LevelLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "LevelLabel");
			CharacterCustomizationOption.NativeFieldInfoPtr_LockDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "LockDisplay");
			CharacterCustomizationOption.NativeFieldInfoPtr_MainButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "MainButton");
			CharacterCustomizationOption.NativeFieldInfoPtr_BuyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "BuyButton");
			CharacterCustomizationOption.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "SelectionIndicator");
			CharacterCustomizationOption.NativeFieldInfoPtr_onSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "onSelect");
			CharacterCustomizationOption.NativeFieldInfoPtr_onDeselect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "onDeselect");
			CharacterCustomizationOption.NativeFieldInfoPtr_onPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "onPurchase");
			CharacterCustomizationOption.NativeFieldInfoPtr__purchased_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "<purchased>k__BackingField");
			CharacterCustomizationOption.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "selected");
			CharacterCustomizationOption.NativeMethodInfoPtr_get_purchased_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682877);
			CharacterCustomizationOption.NativeMethodInfoPtr_set_purchased_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682878);
			CharacterCustomizationOption.NativeMethodInfoPtr_get_purchaseable_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682879);
			CharacterCustomizationOption.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682880);
			CharacterCustomizationOption.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682881);
			CharacterCustomizationOption.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682882);
			CharacterCustomizationOption.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682883);
			CharacterCustomizationOption.NativeMethodInfoPtr_Selected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682884);
			CharacterCustomizationOption.NativeMethodInfoPtr_Purchased_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682885);
			CharacterCustomizationOption.NativeMethodInfoPtr_UpdatePriceColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682886);
			CharacterCustomizationOption.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682887);
			CharacterCustomizationOption.NativeMethodInfoPtr_SetPurchased_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682888);
			CharacterCustomizationOption.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682889);
			CharacterCustomizationOption.NativeMethodInfoPtr_ParentCategoryClosed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682890);
			CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionSelected_Public_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682891);
			CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionPurchased_Public_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682892);
			CharacterCustomizationOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682893);
		}

		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x0600A009 RID: 40969 RVA: 0x00285614 File Offset: 0x00283814
		// (set) Token: 0x0600A00A RID: 40970 RVA: 0x00285650 File Offset: 0x00283850
		public unsafe bool purchased
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_get_purchased_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_set_purchased_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003160 RID: 12640
		// (get) Token: 0x0600A00B RID: 40971 RVA: 0x00285690 File Offset: 0x00283890
		public unsafe bool purchaseable
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 282276, RefRangeEnd = 282280, XrefRangeStart = 282275, XrefRangeEnd = 282276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_get_purchaseable_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A00C RID: 40972 RVA: 0x002856CC File Offset: 0x002838CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282280, XrefRangeEnd = 282300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A00D RID: 40973 RVA: 0x00285700 File Offset: 0x00283900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A00E RID: 40974 RVA: 0x00285734 File Offset: 0x00283934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282300, XrefRangeEnd = 282306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A00F RID: 40975 RVA: 0x00285768 File Offset: 0x00283968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282306, XrefRangeEnd = 282307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A010 RID: 40976 RVA: 0x0028579C File Offset: 0x0028399C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282307, XrefRangeEnd = 282308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Selected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A011 RID: 40977 RVA: 0x002857D0 File Offset: 0x002839D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282308, XrefRangeEnd = 282324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Purchased()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Purchased_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A012 RID: 40978 RVA: 0x00285804 File Offset: 0x00283A04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282337, RefRangeEnd = 282339, XrefRangeStart = 282324, XrefRangeEnd = 282337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePriceColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_UpdatePriceColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A013 RID: 40979 RVA: 0x00285838 File Offset: 0x00283A38
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 282348, RefRangeEnd = 282359, XrefRangeStart = 282339, XrefRangeEnd = 282348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelected(bool _selected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _selected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A014 RID: 40980 RVA: 0x00285878 File Offset: 0x00283A78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282366, RefRangeEnd = 282368, XrefRangeStart = 282359, XrefRangeEnd = 282366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPurchased(bool _purchased)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _purchased;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SetPurchased_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A015 RID: 40981 RVA: 0x002858B8 File Offset: 0x00283AB8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 282380, RefRangeEnd = 282388, XrefRangeStart = 282368, XrefRangeEnd = 282380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A016 RID: 40982 RVA: 0x002858EC File Offset: 0x00283AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282388, XrefRangeEnd = 282390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParentCategoryClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_ParentCategoryClosed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A017 RID: 40983 RVA: 0x00285920 File Offset: 0x00283B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282390, XrefRangeEnd = 282395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SiblingOptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionSelected_Public_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A018 RID: 40984 RVA: 0x00285964 File Offset: 0x00283B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282395, XrefRangeEnd = 282404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SiblingOptionPurchased(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionPurchased_Public_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A019 RID: 40985 RVA: 0x002859A8 File Offset: 0x00283BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282404, XrefRangeEnd = 282414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationOption() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A01A RID: 40986 RVA: 0x0004EA8D File Offset: 0x0004CC8D
		public CharacterCustomizationOption(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x0600A01B RID: 40987 RVA: 0x002859E4 File Offset: 0x00283BE4
		// (set) Token: 0x0600A01C RID: 40988 RVA: 0x0004EA96 File Offset: 0x0004CC96
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x0600A01D RID: 40989 RVA: 0x00285A0C File Offset: 0x00283C0C
		// (set) Token: 0x0600A01E RID: 40990 RVA: 0x0004EAB5 File Offset: 0x0004CCB5
		public unsafe string Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x0600A01F RID: 40991 RVA: 0x00285A34 File Offset: 0x00283C34
		// (set) Token: 0x0600A020 RID: 40992 RVA: 0x0004EAD4 File Offset: 0x0004CCD4
		public unsafe float Price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Price)) = value;
			}
		}

		// Token: 0x17003151 RID: 12625
		// (get) Token: 0x0600A021 RID: 40993 RVA: 0x00285A5C File Offset: 0x00283C5C
		// (set) Token: 0x0600A022 RID: 40994 RVA: 0x0004EAEF File Offset: 0x0004CCEF
		public unsafe bool RequireLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequireLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequireLevel)) = value;
			}
		}

		// Token: 0x17003152 RID: 12626
		// (get) Token: 0x0600A023 RID: 40995 RVA: 0x00285A84 File Offset: 0x00283C84
		// (set) Token: 0x0600A024 RID: 40996 RVA: 0x0004EB0A File Offset: 0x0004CD0A
		public unsafe FullRank RequiredLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequiredLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequiredLevel)) = value;
			}
		}

		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x0600A025 RID: 40997 RVA: 0x00285AAC File Offset: 0x00283CAC
		// (set) Token: 0x0600A026 RID: 40998 RVA: 0x0004EB25 File Offset: 0x0004CD25
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x0600A027 RID: 40999 RVA: 0x00285ADC File Offset: 0x00283CDC
		// (set) Token: 0x0600A028 RID: 41000 RVA: 0x0004EB44 File Offset: 0x0004CD44
		public unsafe TextMeshProUGUI PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x0600A029 RID: 41001 RVA: 0x00285B0C File Offset: 0x00283D0C
		// (set) Token: 0x0600A02A RID: 41002 RVA: 0x0004EB63 File Offset: 0x0004CD63
		public unsafe TextMeshProUGUI LevelLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LevelLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LevelLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x0600A02B RID: 41003 RVA: 0x00285B3C File Offset: 0x00283D3C
		// (set) Token: 0x0600A02C RID: 41004 RVA: 0x0004EB82 File Offset: 0x0004CD82
		public unsafe RectTransform LockDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LockDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LockDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x0600A02D RID: 41005 RVA: 0x00285B6C File Offset: 0x00283D6C
		// (set) Token: 0x0600A02E RID: 41006 RVA: 0x0004EBA1 File Offset: 0x0004CDA1
		public unsafe Button MainButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_MainButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_MainButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x0600A02F RID: 41007 RVA: 0x00285B9C File Offset: 0x00283D9C
		// (set) Token: 0x0600A030 RID: 41008 RVA: 0x0004EBC0 File Offset: 0x0004CDC0
		public unsafe Button BuyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_BuyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_BuyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x0600A031 RID: 41009 RVA: 0x00285BCC File Offset: 0x00283DCC
		// (set) Token: 0x0600A032 RID: 41010 RVA: 0x0004EBDF File Offset: 0x0004CDDF
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x0600A033 RID: 41011 RVA: 0x00285BFC File Offset: 0x00283DFC
		// (set) Token: 0x0600A034 RID: 41012 RVA: 0x0004EBFE File Offset: 0x0004CDFE
		public unsafe UnityEvent onSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onSelect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x0600A035 RID: 41013 RVA: 0x00285C2C File Offset: 0x00283E2C
		// (set) Token: 0x0600A036 RID: 41014 RVA: 0x0004EC1D File Offset: 0x0004CE1D
		public unsafe UnityEvent onDeselect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onDeselect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onDeselect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x0600A037 RID: 41015 RVA: 0x00285C5C File Offset: 0x00283E5C
		// (set) Token: 0x0600A038 RID: 41016 RVA: 0x0004EC3C File Offset: 0x0004CE3C
		public unsafe UnityEvent onPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onPurchase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x0600A039 RID: 41017 RVA: 0x00285C8C File Offset: 0x00283E8C
		// (set) Token: 0x0600A03A RID: 41018 RVA: 0x0004EC5B File Offset: 0x0004CE5B
		public unsafe bool _purchased_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr__purchased_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr__purchased_k__BackingField)) = value;
			}
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x0600A03B RID: 41019 RVA: 0x00285CB4 File Offset: 0x00283EB4
		// (set) Token: 0x0600A03C RID: 41020 RVA: 0x0004EC76 File Offset: 0x0004CE76
		public unsafe bool selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_selected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_selected)) = value;
			}
		}

		// Token: 0x04006B50 RID: 27472
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04006B51 RID: 27473
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006B52 RID: 27474
		private static readonly IntPtr NativeFieldInfoPtr_Price;

		// Token: 0x04006B53 RID: 27475
		private static readonly IntPtr NativeFieldInfoPtr_RequireLevel;

		// Token: 0x04006B54 RID: 27476
		private static readonly IntPtr NativeFieldInfoPtr_RequiredLevel;

		// Token: 0x04006B55 RID: 27477
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006B56 RID: 27478
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x04006B57 RID: 27479
		private static readonly IntPtr NativeFieldInfoPtr_LevelLabel;

		// Token: 0x04006B58 RID: 27480
		private static readonly IntPtr NativeFieldInfoPtr_LockDisplay;

		// Token: 0x04006B59 RID: 27481
		private static readonly IntPtr NativeFieldInfoPtr_MainButton;

		// Token: 0x04006B5A RID: 27482
		private static readonly IntPtr NativeFieldInfoPtr_BuyButton;

		// Token: 0x04006B5B RID: 27483
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x04006B5C RID: 27484
		private static readonly IntPtr NativeFieldInfoPtr_onSelect;

		// Token: 0x04006B5D RID: 27485
		private static readonly IntPtr NativeFieldInfoPtr_onDeselect;

		// Token: 0x04006B5E RID: 27486
		private static readonly IntPtr NativeFieldInfoPtr_onPurchase;

		// Token: 0x04006B5F RID: 27487
		private static readonly IntPtr NativeFieldInfoPtr__purchased_k__BackingField;

		// Token: 0x04006B60 RID: 27488
		private static readonly IntPtr NativeFieldInfoPtr_selected;

		// Token: 0x04006B61 RID: 27489
		private static readonly IntPtr NativeMethodInfoPtr_get_purchased_Public_get_Boolean_0;

		// Token: 0x04006B62 RID: 27490
		private static readonly IntPtr NativeMethodInfoPtr_set_purchased_Private_set_Void_Boolean_0;

		// Token: 0x04006B63 RID: 27491
		private static readonly IntPtr NativeMethodInfoPtr_get_purchaseable_Private_get_Boolean_0;

		// Token: 0x04006B64 RID: 27492
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006B65 RID: 27493
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04006B66 RID: 27494
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04006B67 RID: 27495
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006B68 RID: 27496
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Private_Void_0;

		// Token: 0x04006B69 RID: 27497
		private static readonly IntPtr NativeMethodInfoPtr_Purchased_Private_Void_0;

		// Token: 0x04006B6A RID: 27498
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePriceColor_Private_Void_0;

		// Token: 0x04006B6B RID: 27499
		private static readonly IntPtr NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0;

		// Token: 0x04006B6C RID: 27500
		private static readonly IntPtr NativeMethodInfoPtr_SetPurchased_Public_Void_Boolean_0;

		// Token: 0x04006B6D RID: 27501
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04006B6E RID: 27502
		private static readonly IntPtr NativeMethodInfoPtr_ParentCategoryClosed_Public_Void_0;

		// Token: 0x04006B6F RID: 27503
		private static readonly IntPtr NativeMethodInfoPtr_SiblingOptionSelected_Public_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B70 RID: 27504
		private static readonly IntPtr NativeMethodInfoPtr_SiblingOptionPurchased_Public_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B71 RID: 27505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
