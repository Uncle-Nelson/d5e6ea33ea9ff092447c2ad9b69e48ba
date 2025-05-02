using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200074F RID: 1871
	[Serializable]
	public class MixOperation : Object
	{
		// Token: 0x0600B07D RID: 45181 RVA: 0x002C0480 File Offset: 0x002BE680
		// Note: this type is marked as 'beforefieldinit'.
		static MixOperation()
		{
			Il2CppClassPointerStore<MixOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "MixOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixOperation>.NativeClassPtr);
			MixOperation.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "ProductID");
			MixOperation.NativeFieldInfoPtr_ProductQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "ProductQuality");
			MixOperation.NativeFieldInfoPtr_IngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "IngredientID");
			MixOperation.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "Quantity");
			MixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100685004);
			MixOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100685005);
			MixOperation.NativeMethodInfoPtr_GetOutput_Public_EDrugType_byref_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100685006);
			MixOperation.NativeMethodInfoPtr_IsOutputKnown_Public_Boolean_byref_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100685007);
		}

		// Token: 0x0600B07E RID: 45182 RVA: 0x002C0550 File Offset: 0x002BE750
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304498, RefRangeEnd = 304500, XrefRangeStart = 304495, XrefRangeEnd = 304498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixOperation(string productID, EQuality productQuality, string ingredientID, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B07F RID: 45183 RVA: 0x002C05CC File Offset: 0x002BE7CC
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B080 RID: 45184 RVA: 0x002C0608 File Offset: 0x002BE808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304514, RefRangeEnd = 304516, XrefRangeStart = 304500, XrefRangeEnd = 304514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EDrugType GetOutput(out List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr_GetOutput_Public_EDrugType_byref_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			properties = ((intPtr4 == 0) ? null : new List<Property>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600B081 RID: 45185 RVA: 0x002C0668 File Offset: 0x002BE868
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 304539, RefRangeEnd = 304544, XrefRangeStart = 304516, XrefRangeEnd = 304539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr_IsOutputKnown_Public_Boolean_byref_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			knownProduct = ((intPtr4 == 0) ? null : new ProductDefinition(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600B082 RID: 45186 RVA: 0x00056AF6 File Offset: 0x00054CF6
		public MixOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x0600B083 RID: 45187 RVA: 0x002C06C8 File Offset: 0x002BE8C8
		// (set) Token: 0x0600B084 RID: 45188 RVA: 0x00056AFF File Offset: 0x00054CFF
		public unsafe string ProductID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x0600B085 RID: 45189 RVA: 0x002C06F0 File Offset: 0x002BE8F0
		// (set) Token: 0x0600B086 RID: 45190 RVA: 0x00056B1E File Offset: 0x00054D1E
		public unsafe EQuality ProductQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductQuality)) = value;
			}
		}

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x0600B087 RID: 45191 RVA: 0x002C0718 File Offset: 0x002BE918
		// (set) Token: 0x0600B088 RID: 45192 RVA: 0x00056B39 File Offset: 0x00054D39
		public unsafe string IngredientID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_IngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_IngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x0600B089 RID: 45193 RVA: 0x002C0740 File Offset: 0x002BE940
		// (set) Token: 0x0600B08A RID: 45194 RVA: 0x00056B58 File Offset: 0x00054D58
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x040076E1 RID: 30433
		private static readonly IntPtr NativeFieldInfoPtr_ProductID;

		// Token: 0x040076E2 RID: 30434
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuality;

		// Token: 0x040076E3 RID: 30435
		private static readonly IntPtr NativeFieldInfoPtr_IngredientID;

		// Token: 0x040076E4 RID: 30436
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x040076E5 RID: 30437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_String_Int32_0;

		// Token: 0x040076E6 RID: 30438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040076E7 RID: 30439
		private static readonly IntPtr NativeMethodInfoPtr_GetOutput_Public_EDrugType_byref_List_1_Property_0;

		// Token: 0x040076E8 RID: 30440
		private static readonly IntPtr NativeMethodInfoPtr_IsOutputKnown_Public_Boolean_byref_ProductDefinition_0;
	}
}
