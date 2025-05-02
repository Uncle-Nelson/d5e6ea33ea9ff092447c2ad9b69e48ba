using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.UI.Stations;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D9 RID: 1753
	public class ChemistryStationUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DAF RID: 40367 RVA: 0x0027E0C4 File Offset: 0x0027C2C4
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationUIElement()
		{
			Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistryStationUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr);
			ChemistryStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, "<AssignedStation>k__BackingField");
			ChemistryStationUIElement.NativeFieldInfoPtr_RecipeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, "RecipeEntry");
			ChemistryStationUIElement.NativeFieldInfoPtr_NoRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, "NoRecipe");
			ChemistryStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100682636);
			ChemistryStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100682637);
			ChemistryStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100682638);
			ChemistryStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100682639);
			ChemistryStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100682640);
		}

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x06009DB0 RID: 40368 RVA: 0x0027E194 File Offset: 0x0027C394
		// (set) Token: 0x06009DB1 RID: 40369 RVA: 0x0027E1D4 File Offset: 0x0027C3D4
		public unsafe ChemistryStation AssignedStation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DB2 RID: 40370 RVA: 0x0027E218 File Offset: 0x0027C418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279890, RefRangeEnd = 279891, XrefRangeStart = 279880, XrefRangeEnd = 279890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ChemistryStation oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DB3 RID: 40371 RVA: 0x0027E25C File Offset: 0x0027C45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279891, XrefRangeEnd = 279908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DB4 RID: 40372 RVA: 0x0027E298 File Offset: 0x0027C498
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DB5 RID: 40373 RVA: 0x0004D611 File Offset: 0x0004B811
		public ChemistryStationUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x06009DB6 RID: 40374 RVA: 0x0027E2D4 File Offset: 0x0027C4D4
		// (set) Token: 0x06009DB7 RID: 40375 RVA: 0x0004D61A File Offset: 0x0004B81A
		public unsafe ChemistryStation _AssignedStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x06009DB8 RID: 40376 RVA: 0x0027E304 File Offset: 0x0027C504
		// (set) Token: 0x06009DB9 RID: 40377 RVA: 0x0004D639 File Offset: 0x0004B839
		public unsafe StationRecipeEntry RecipeEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_RecipeEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_RecipeEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x06009DBA RID: 40378 RVA: 0x0027E334 File Offset: 0x0027C534
		// (set) Token: 0x06009DBB RID: 40379 RVA: 0x0004D658 File Offset: 0x0004B858
		public unsafe GameObject NoRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_NoRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_NoRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069E0 RID: 27104
		private static readonly IntPtr NativeFieldInfoPtr__AssignedStation_k__BackingField;

		// Token: 0x040069E1 RID: 27105
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntry;

		// Token: 0x040069E2 RID: 27106
		private static readonly IntPtr NativeFieldInfoPtr_NoRecipe;

		// Token: 0x040069E3 RID: 27107
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedStation_Public_get_ChemistryStation_0;

		// Token: 0x040069E4 RID: 27108
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_ChemistryStation_0;

		// Token: 0x040069E5 RID: 27109
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ChemistryStation_0;

		// Token: 0x040069E6 RID: 27110
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069E7 RID: 27111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
