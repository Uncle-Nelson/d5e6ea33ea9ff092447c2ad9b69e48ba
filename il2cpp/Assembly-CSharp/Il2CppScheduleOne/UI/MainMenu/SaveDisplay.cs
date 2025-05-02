using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006EC RID: 1772
	public class SaveDisplay : MonoBehaviour
	{
		// Token: 0x06009E98 RID: 40600 RVA: 0x00280F34 File Offset: 0x0027F134
		// Note: this type is marked as 'beforefieldinit'.
		static SaveDisplay()
		{
			Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SaveDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr);
			SaveDisplay.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, "Slots");
			SaveDisplay.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100682753);
			SaveDisplay.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100682754);
			SaveDisplay.NativeMethodInfoPtr_SetDisplayedSave_Public_Void_Int32_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100682755);
			SaveDisplay.NativeMethodInfoPtr_RoundToDecimalPlaces_Private_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100682756);
			SaveDisplay.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100682757);
			SaveDisplay.NativeMethodInfoPtr_GetTimeLabel_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100682758);
			SaveDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100682759);
		}

		// Token: 0x06009E99 RID: 40601 RVA: 0x00281004 File Offset: 0x0027F204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280555, XrefRangeEnd = 280574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E9A RID: 40602 RVA: 0x00281038 File Offset: 0x0027F238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280574, XrefRangeEnd = 280582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E9B RID: 40603 RVA: 0x0028106C File Offset: 0x0027F26C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280653, RefRangeEnd = 280655, XrefRangeStart = 280582, XrefRangeEnd = 280653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedSave(int index, SaveInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_SetDisplayedSave_Public_Void_Int32_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E9C RID: 40604 RVA: 0x002810BC File Offset: 0x0027F2BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280661, RefRangeEnd = 280663, XrefRangeStart = 280655, XrefRangeEnd = 280661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RoundToDecimalPlaces(float value, int decimalPlaces)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimalPlaces;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_RoundToDecimalPlaces_Private_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009E9D RID: 40605 RVA: 0x00281114 File Offset: 0x0027F314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280663, RefRangeEnd = 280665, XrefRangeStart = 280663, XrefRangeEnd = 280663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(double value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009E9E RID: 40606 RVA: 0x00281154 File Offset: 0x0027F354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280672, RefRangeEnd = 280674, XrefRangeStart = 280665, XrefRangeEnd = 280672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTimeLabel(int hours)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hours;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_GetTimeLabel_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x00281198 File Offset: 0x0027F398
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EA0 RID: 40608 RVA: 0x0004DCAC File Offset: 0x0004BEAC
		public SaveDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x06009EA1 RID: 40609 RVA: 0x002811D4 File Offset: 0x0027F3D4
		// (set) Token: 0x06009EA2 RID: 40610 RVA: 0x0004DCB5 File Offset: 0x0004BEB5
		public unsafe Il2CppReferenceArray<RectTransform> Slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveDisplay.NativeFieldInfoPtr_Slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveDisplay.NativeFieldInfoPtr_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A6F RID: 27247
		private static readonly IntPtr NativeFieldInfoPtr_Slots;

		// Token: 0x04006A70 RID: 27248
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04006A71 RID: 27249
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x04006A72 RID: 27250
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedSave_Public_Void_Int32_SaveInfo_0;

		// Token: 0x04006A73 RID: 27251
		private static readonly IntPtr NativeMethodInfoPtr_RoundToDecimalPlaces_Private_Single_Single_Int32_0;

		// Token: 0x04006A74 RID: 27252
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0;

		// Token: 0x04006A75 RID: 27253
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeLabel_Private_String_Int32_0;

		// Token: 0x04006A76 RID: 27254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
