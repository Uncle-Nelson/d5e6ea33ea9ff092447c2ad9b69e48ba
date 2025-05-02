using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Clothing;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000263 RID: 611
	[Serializable]
	public class ClothingData : ItemData
	{
		// Token: 0x06002F26 RID: 12070 RVA: 0x00106EC0 File Offset: 0x001050C0
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingData()
		{
			Il2CppClassPointerStore<ClothingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ClothingData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingData>.NativeClassPtr);
			ClothingData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingData>.NativeClassPtr, "Color");
			ClothingData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingData>.NativeClassPtr, 100668761);
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x00106F18 File Offset: 0x00105118
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130702, RefRangeEnd = 130704, XrefRangeStart = 130700, XrefRangeEnd = 130702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingData(string iD, int quantity, EClothingColor color) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x00018EB5 File Offset: 0x000170B5
		public ClothingData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06002F29 RID: 12073 RVA: 0x00106F80 File Offset: 0x00105180
		// (set) Token: 0x06002F2A RID: 12074 RVA: 0x00018EBE File Offset: 0x000170BE
		public unsafe EClothingColor Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingData.NativeFieldInfoPtr_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingData.NativeFieldInfoPtr_Color)) = value;
			}
		}

		// Token: 0x04001F26 RID: 7974
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04001F27 RID: 7975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EClothingColor_0;
	}
}
