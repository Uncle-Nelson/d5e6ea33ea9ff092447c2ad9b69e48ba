using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A3 RID: 1443
	[Serializable]
	public class MixRecipeData : Object
	{
		// Token: 0x06007E2B RID: 32299 RVA: 0x0021C478 File Offset: 0x0021A678
		// Note: this type is marked as 'beforefieldinit'.
		static MixRecipeData()
		{
			Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MixRecipeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr);
			MixRecipeData.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, "Product");
			MixRecipeData.NativeFieldInfoPtr_Mixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, "Mixer");
			MixRecipeData.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, "Output");
			MixRecipeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, 100679076);
		}

		// Token: 0x06007E2C RID: 32300 RVA: 0x0021C4F8 File Offset: 0x0021A6F8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 17405, RefRangeEnd = 17413, XrefRangeStart = 17405, XrefRangeEnd = 17413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixRecipeData(string product, string mixer, string output) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mixer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixRecipeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E2D RID: 32301 RVA: 0x0003BEFA File Offset: 0x0003A0FA
		public MixRecipeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x06007E2E RID: 32302 RVA: 0x0021C568 File Offset: 0x0021A768
		// (set) Token: 0x06007E2F RID: 32303 RVA: 0x0003BF03 File Offset: 0x0003A103
		public unsafe string Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Product);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Product), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x06007E30 RID: 32304 RVA: 0x0021C590 File Offset: 0x0021A790
		// (set) Token: 0x06007E31 RID: 32305 RVA: 0x0003BF22 File Offset: 0x0003A122
		public unsafe string Mixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Mixer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Mixer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x06007E32 RID: 32306 RVA: 0x0021C5B8 File Offset: 0x0021A7B8
		// (set) Token: 0x06007E33 RID: 32307 RVA: 0x0003BF41 File Offset: 0x0003A141
		public unsafe string Output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Output);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Output), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040055E1 RID: 21985
		private static readonly IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x040055E2 RID: 21986
		private static readonly IntPtr NativeFieldInfoPtr_Mixer;

		// Token: 0x040055E3 RID: 21987
		private static readonly IntPtr NativeFieldInfoPtr_Output;

		// Token: 0x040055E4 RID: 21988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;
	}
}
