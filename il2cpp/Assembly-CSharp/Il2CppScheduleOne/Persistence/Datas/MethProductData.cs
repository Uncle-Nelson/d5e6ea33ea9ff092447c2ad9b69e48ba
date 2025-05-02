using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002AA RID: 682
	[Serializable]
	public class MethProductData : ProductData
	{
		// Token: 0x06003144 RID: 12612 RVA: 0x0010CF34 File Offset: 0x0010B134
		// Note: this type is marked as 'beforefieldinit'.
		static MethProductData()
		{
			Il2CppClassPointerStore<MethProductData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MethProductData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethProductData>.NativeClassPtr);
			MethProductData.NativeFieldInfoPtr_AppearanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethProductData>.NativeClassPtr, "AppearanceSettings");
			MethProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethProductData>.NativeClassPtr, 100668835);
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x0010CF8C File Offset: 0x0010B18C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131110, RefRangeEnd = 131113, XrefRangeStart = 131110, XrefRangeEnd = 131113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethProductData(string name, string id, EDrugType drugType, Il2CppStringArray properties, MethAppearanceSettings appearanceSettings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethProductData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearanceSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_MethAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x0001A4CD File Offset: 0x000186CD
		public MethProductData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06003147 RID: 12615 RVA: 0x0010D020 File Offset: 0x0010B220
		// (set) Token: 0x06003148 RID: 12616 RVA: 0x0001A4D6 File Offset: 0x000186D6
		public unsafe MethAppearanceSettings AppearanceSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethProductData.NativeFieldInfoPtr_AppearanceSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethProductData.NativeFieldInfoPtr_AppearanceSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002013 RID: 8211
		private static readonly IntPtr NativeFieldInfoPtr_AppearanceSettings;

		// Token: 0x04002014 RID: 8212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_MethAppearanceSettings_0;
	}
}
