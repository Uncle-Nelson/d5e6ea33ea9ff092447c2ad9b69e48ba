using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006DA RID: 1754
	public class ChemistUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DBC RID: 40380 RVA: 0x0027E364 File Offset: 0x0027C564
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistUIElement()
		{
			Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr);
			ChemistUIElement.NativeFieldInfoPtr_StationsIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, "StationsIcons");
			ChemistUIElement.NativeFieldInfoPtr__AssignedChemist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, "<AssignedChemist>k__BackingField");
			ChemistUIElement.NativeMethodInfoPtr_get_AssignedChemist_Public_get_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100682641);
			ChemistUIElement.NativeMethodInfoPtr_set_AssignedChemist_Protected_set_Void_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100682642);
			ChemistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100682643);
			ChemistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100682644);
			ChemistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100682645);
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x06009DBD RID: 40381 RVA: 0x0027E420 File Offset: 0x0027C620
		// (set) Token: 0x06009DBE RID: 40382 RVA: 0x0027E460 File Offset: 0x0027C660
		public unsafe Chemist AssignedChemist
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr_get_AssignedChemist_Public_get_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr_set_AssignedChemist_Protected_set_Void_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DBF RID: 40383 RVA: 0x0027E4A4 File Offset: 0x0027C6A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279919, RefRangeEnd = 279920, XrefRangeStart = 279908, XrefRangeEnd = 279919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Chemist chemist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(chemist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DC0 RID: 40384 RVA: 0x0027E4E8 File Offset: 0x0027C6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279920, XrefRangeEnd = 279933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DC1 RID: 40385 RVA: 0x0027E524 File Offset: 0x0027C724
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DC2 RID: 40386 RVA: 0x0004D677 File Offset: 0x0004B877
		public ChemistUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x06009DC3 RID: 40387 RVA: 0x0027E560 File Offset: 0x0027C760
		// (set) Token: 0x06009DC4 RID: 40388 RVA: 0x0004D680 File Offset: 0x0004B880
		public unsafe Il2CppReferenceArray<Image> StationsIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr_StationsIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr_StationsIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x06009DC5 RID: 40389 RVA: 0x0027E590 File Offset: 0x0027C790
		// (set) Token: 0x06009DC6 RID: 40390 RVA: 0x0004D69F File Offset: 0x0004B89F
		public unsafe Chemist _AssignedChemist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr__AssignedChemist_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr__AssignedChemist_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069E8 RID: 27112
		private static readonly IntPtr NativeFieldInfoPtr_StationsIcons;

		// Token: 0x040069E9 RID: 27113
		private static readonly IntPtr NativeFieldInfoPtr__AssignedChemist_k__BackingField;

		// Token: 0x040069EA RID: 27114
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedChemist_Public_get_Chemist_0;

		// Token: 0x040069EB RID: 27115
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedChemist_Protected_set_Void_Chemist_0;

		// Token: 0x040069EC RID: 27116
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Chemist_0;

		// Token: 0x040069ED RID: 27117
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069EE RID: 27118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
