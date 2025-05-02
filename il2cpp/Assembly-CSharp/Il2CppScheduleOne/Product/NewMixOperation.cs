using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A5 RID: 1445
	[Serializable]
	public class NewMixOperation : Object
	{
		// Token: 0x06007E4E RID: 32334 RVA: 0x0021CA3C File Offset: 0x0021AC3C
		// Note: this type is marked as 'beforefieldinit'.
		static NewMixOperation()
		{
			Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "NewMixOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr);
			NewMixOperation.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, "ProductID");
			NewMixOperation.NativeFieldInfoPtr_IngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, "IngredientID");
			NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, 100679092);
			NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, 100679093);
		}

		// Token: 0x06007E4F RID: 32335 RVA: 0x0021CABC File Offset: 0x0021ACBC
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 110734, RefRangeEnd = 110783, XrefRangeStart = 110734, XrefRangeEnd = 110783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixOperation(string productID, string ingredientID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E50 RID: 32336 RVA: 0x0021CB1C File Offset: 0x0021AD1C
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x0003C078 File Offset: 0x0003A278
		public NewMixOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x06007E52 RID: 32338 RVA: 0x0021CB58 File Offset: 0x0021AD58
		// (set) Token: 0x06007E53 RID: 32339 RVA: 0x0003C081 File Offset: 0x0003A281
		public unsafe string ProductID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_ProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x06007E54 RID: 32340 RVA: 0x0021CB80 File Offset: 0x0021AD80
		// (set) Token: 0x06007E55 RID: 32341 RVA: 0x0003C0A0 File Offset: 0x0003A2A0
		public unsafe string IngredientID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_IngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_IngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040055F4 RID: 22004
		private static readonly IntPtr NativeFieldInfoPtr_ProductID;

		// Token: 0x040055F5 RID: 22005
		private static readonly IntPtr NativeFieldInfoPtr_IngredientID;

		// Token: 0x040055F6 RID: 22006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040055F7 RID: 22007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
