using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.Product.Packaging
{
	// Token: 0x020005B6 RID: 1462
	[Serializable]
	public class PackagingDefinition : StorableItemDefinition
	{
		// Token: 0x06008068 RID: 32872 RVA: 0x0022567C File Offset: 0x0022387C
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingDefinition()
		{
			Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product.Packaging", "PackagingDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr);
			PackagingDefinition.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "Quantity");
			PackagingDefinition.NativeFieldInfoPtr_StealthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "StealthLevel");
			PackagingDefinition.NativeFieldInfoPtr_FunctionalPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "FunctionalPackaging");
			PackagingDefinition.NativeFieldInfoPtr_Equippable_Filled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "Equippable_Filled");
			PackagingDefinition.NativeFieldInfoPtr_StoredItem_Filled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "StoredItem_Filled");
			PackagingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, 100679419);
		}

		// Token: 0x06008069 RID: 32873 RVA: 0x00225724 File Offset: 0x00223924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244577, XrefRangeEnd = 244578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x0003CE36 File Offset: 0x0003B036
		public PackagingDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026C7 RID: 9927
		// (get) Token: 0x0600806B RID: 32875 RVA: 0x00225760 File Offset: 0x00223960
		// (set) Token: 0x0600806C RID: 32876 RVA: 0x0003CE3F File Offset: 0x0003B03F
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x170026C8 RID: 9928
		// (get) Token: 0x0600806D RID: 32877 RVA: 0x00225788 File Offset: 0x00223988
		// (set) Token: 0x0600806E RID: 32878 RVA: 0x0003CE5A File Offset: 0x0003B05A
		public unsafe EStealthLevel StealthLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StealthLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StealthLevel)) = value;
			}
		}

		// Token: 0x170026C9 RID: 9929
		// (get) Token: 0x0600806F RID: 32879 RVA: 0x002257B0 File Offset: 0x002239B0
		// (set) Token: 0x06008070 RID: 32880 RVA: 0x0003CE75 File Offset: 0x0003B075
		public unsafe FunctionalPackaging FunctionalPackaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_FunctionalPackaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_FunctionalPackaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026CA RID: 9930
		// (get) Token: 0x06008071 RID: 32881 RVA: 0x002257E0 File Offset: 0x002239E0
		// (set) Token: 0x06008072 RID: 32882 RVA: 0x0003CE94 File Offset: 0x0003B094
		public unsafe Equippable Equippable_Filled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Equippable_Filled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Equippable_Filled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026CB RID: 9931
		// (get) Token: 0x06008073 RID: 32883 RVA: 0x00225810 File Offset: 0x00223A10
		// (set) Token: 0x06008074 RID: 32884 RVA: 0x0003CEB3 File Offset: 0x0003B0B3
		public unsafe StoredItem StoredItem_Filled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StoredItem_Filled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StoredItem_Filled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400577D RID: 22397
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x0400577E RID: 22398
		private static readonly IntPtr NativeFieldInfoPtr_StealthLevel;

		// Token: 0x0400577F RID: 22399
		private static readonly IntPtr NativeFieldInfoPtr_FunctionalPackaging;

		// Token: 0x04005780 RID: 22400
		private static readonly IntPtr NativeFieldInfoPtr_Equippable_Filled;

		// Token: 0x04005781 RID: 22401
		private static readonly IntPtr NativeFieldInfoPtr_StoredItem_Filled;

		// Token: 0x04005782 RID: 22402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
