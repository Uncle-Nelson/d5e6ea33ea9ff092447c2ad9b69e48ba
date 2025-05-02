using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000285 RID: 645
	[Serializable]
	public class StationRecipeFieldData : Object
	{
		// Token: 0x06002FF1 RID: 12273 RVA: 0x00109068 File Offset: 0x00107268
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeFieldData()
		{
			Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "StationRecipeFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr);
			StationRecipeFieldData.NativeFieldInfoPtr_RecipeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr, "RecipeID");
			StationRecipeFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr, 100668796);
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x001090C0 File Offset: 0x001072C0
		[CallerCount(177)]
		[CachedScanResults(RefRangeStart = 17913, RefRangeEnd = 18090, XrefRangeStart = 17913, XrefRangeEnd = 18090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeFieldData(string recipeID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(recipeID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x000196A5 File Offset: 0x000178A5
		public StationRecipeFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x0010910C File Offset: 0x0010730C
		// (set) Token: 0x06002FF5 RID: 12277 RVA: 0x000196AE File Offset: 0x000178AE
		public unsafe string RecipeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldData.NativeFieldInfoPtr_RecipeID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldData.NativeFieldInfoPtr_RecipeID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeFieldInfoPtr_RecipeID;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
