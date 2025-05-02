using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000589 RID: 1417
	public class IngredientModule : ItemModule
	{
		// Token: 0x06007CC7 RID: 31943 RVA: 0x00217EBC File Offset: 0x002160BC
		// Note: this type is marked as 'beforefieldinit'.
		static IngredientModule()
		{
			Il2CppClassPointerStore<IngredientModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "IngredientModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr);
			IngredientModule.NativeFieldInfoPtr_Pieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr, "Pieces");
			IngredientModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr, 100678929);
			IngredientModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr, 100678930);
		}

		// Token: 0x06007CC8 RID: 31944 RVA: 0x00217F28 File Offset: 0x00216128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237705, XrefRangeEnd = 237713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActivateModule(StationItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IngredientModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CC9 RID: 31945 RVA: 0x00217F78 File Offset: 0x00216178
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IngredientModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CCA RID: 31946 RVA: 0x0003B3CB File Offset: 0x000395CB
		public IngredientModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025BC RID: 9660
		// (get) Token: 0x06007CCB RID: 31947 RVA: 0x00217FB4 File Offset: 0x002161B4
		// (set) Token: 0x06007CCC RID: 31948 RVA: 0x0003B3D4 File Offset: 0x000395D4
		public unsafe Il2CppReferenceArray<IngredientPiece> Pieces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientModule.NativeFieldInfoPtr_Pieces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IngredientPiece>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientModule.NativeFieldInfoPtr_Pieces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040054F0 RID: 21744
		private static readonly IntPtr NativeFieldInfoPtr_Pieces;

		// Token: 0x040054F1 RID: 21745
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0;

		// Token: 0x040054F2 RID: 21746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
