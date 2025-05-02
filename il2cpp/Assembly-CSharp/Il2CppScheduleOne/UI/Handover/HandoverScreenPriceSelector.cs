using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Handover
{
	// Token: 0x020006F5 RID: 1781
	public class HandoverScreenPriceSelector : MonoBehaviour
	{
		// Token: 0x06009F93 RID: 40851 RVA: 0x00283D28 File Offset: 0x00281F28
		// Note: this type is marked as 'beforefieldinit'.
		static HandoverScreenPriceSelector()
		{
			Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Handover", "HandoverScreenPriceSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr);
			HandoverScreenPriceSelector.NativeFieldInfoPtr_MinPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "MinPrice");
			HandoverScreenPriceSelector.NativeFieldInfoPtr_MaxPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "MaxPrice");
			HandoverScreenPriceSelector.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "InputField");
			HandoverScreenPriceSelector.NativeFieldInfoPtr__Price_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "<Price>k__BackingField");
			HandoverScreenPriceSelector.NativeFieldInfoPtr_onPriceChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "onPriceChanged");
			HandoverScreenPriceSelector.NativeMethodInfoPtr_get_Price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100682828);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_set_Price_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100682829);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_SetPrice_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100682830);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_RefreshPrice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100682831);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_OnPriceInputChanged_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100682832);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100682833);
			HandoverScreenPriceSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100682834);
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x06009F94 RID: 40852 RVA: 0x00283E48 File Offset: 0x00282048
		// (set) Token: 0x06009F95 RID: 40853 RVA: 0x00283E84 File Offset: 0x00282084
		public unsafe float Price
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59852, RefRangeEnd = 59853, XrefRangeStart = 59852, XrefRangeEnd = 59853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_get_Price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_set_Price_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009F96 RID: 40854 RVA: 0x00283EC4 File Offset: 0x002820C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281777, RefRangeEnd = 281779, XrefRangeStart = 281774, XrefRangeEnd = 281777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPrice(float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_SetPrice_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F97 RID: 40855 RVA: 0x00283F04 File Offset: 0x00282104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281779, XrefRangeEnd = 281782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_RefreshPrice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F98 RID: 40856 RVA: 0x00283F38 File Offset: 0x00282138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281782, XrefRangeEnd = 281785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPriceInputChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_OnPriceInputChanged_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F99 RID: 40857 RVA: 0x00283F7C File Offset: 0x0028217C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281785, XrefRangeEnd = 281786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAmount(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F9A RID: 40858 RVA: 0x00283FBC File Offset: 0x002821BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandoverScreenPriceSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F9B RID: 40859 RVA: 0x0004E664 File Offset: 0x0004C864
		public HandoverScreenPriceSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x06009F9C RID: 40860 RVA: 0x00283FF8 File Offset: 0x002821F8
		// (set) Token: 0x06009F9D RID: 40861 RVA: 0x0004E66D File Offset: 0x0004C86D
		public unsafe static float MinPrice
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HandoverScreenPriceSelector.NativeFieldInfoPtr_MinPrice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HandoverScreenPriceSelector.NativeFieldInfoPtr_MinPrice, (void*)(&value));
			}
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x06009F9E RID: 40862 RVA: 0x00284014 File Offset: 0x00282214
		// (set) Token: 0x06009F9F RID: 40863 RVA: 0x0004E67B File Offset: 0x0004C87B
		public unsafe static float MaxPrice
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HandoverScreenPriceSelector.NativeFieldInfoPtr_MaxPrice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HandoverScreenPriceSelector.NativeFieldInfoPtr_MaxPrice, (void*)(&value));
			}
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x06009FA0 RID: 40864 RVA: 0x00284030 File Offset: 0x00282230
		// (set) Token: 0x06009FA1 RID: 40865 RVA: 0x0004E689 File Offset: 0x0004C889
		public unsafe InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x06009FA2 RID: 40866 RVA: 0x00284060 File Offset: 0x00282260
		// (set) Token: 0x06009FA3 RID: 40867 RVA: 0x0004E6A8 File Offset: 0x0004C8A8
		public unsafe float _Price_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr__Price_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr__Price_k__BackingField)) = value;
			}
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x06009FA4 RID: 40868 RVA: 0x00284088 File Offset: 0x00282288
		// (set) Token: 0x06009FA5 RID: 40869 RVA: 0x0004E6C3 File Offset: 0x0004C8C3
		public unsafe UnityEvent onPriceChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr_onPriceChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr_onPriceChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B07 RID: 27399
		private static readonly IntPtr NativeFieldInfoPtr_MinPrice;

		// Token: 0x04006B08 RID: 27400
		private static readonly IntPtr NativeFieldInfoPtr_MaxPrice;

		// Token: 0x04006B09 RID: 27401
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x04006B0A RID: 27402
		private static readonly IntPtr NativeFieldInfoPtr__Price_k__BackingField;

		// Token: 0x04006B0B RID: 27403
		private static readonly IntPtr NativeFieldInfoPtr_onPriceChanged;

		// Token: 0x04006B0C RID: 27404
		private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Single_0;

		// Token: 0x04006B0D RID: 27405
		private static readonly IntPtr NativeMethodInfoPtr_set_Price_Private_set_Void_Single_0;

		// Token: 0x04006B0E RID: 27406
		private static readonly IntPtr NativeMethodInfoPtr_SetPrice_Public_Void_Single_0;

		// Token: 0x04006B0F RID: 27407
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPrice_Public_Void_0;

		// Token: 0x04006B10 RID: 27408
		private static readonly IntPtr NativeMethodInfoPtr_OnPriceInputChanged_Public_Void_String_0;

		// Token: 0x04006B11 RID: 27409
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0;

		// Token: 0x04006B12 RID: 27410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
