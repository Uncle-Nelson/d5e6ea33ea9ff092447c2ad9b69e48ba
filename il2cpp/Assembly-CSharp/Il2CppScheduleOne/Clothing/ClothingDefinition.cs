using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Clothing
{
	// Token: 0x02000499 RID: 1177
	[Serializable]
	public class ClothingDefinition : StorableItemDefinition
	{
		// Token: 0x06006638 RID: 26168 RVA: 0x001CC42C File Offset: 0x001CA62C
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingDefinition()
		{
			Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Clothing", "ClothingDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr);
			ClothingDefinition.NativeFieldInfoPtr_Slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "Slot");
			ClothingDefinition.NativeFieldInfoPtr_ApplicationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "ApplicationType");
			ClothingDefinition.NativeFieldInfoPtr_ClothingAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "ClothingAssetPath");
			ClothingDefinition.NativeFieldInfoPtr_Colorable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "Colorable");
			ClothingDefinition.NativeFieldInfoPtr_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "DefaultColor");
			ClothingDefinition.NativeFieldInfoPtr_SlotsToBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "SlotsToBlock");
			ClothingDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, 100676219);
			ClothingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, 100676220);
		}

		// Token: 0x06006639 RID: 26169 RVA: 0x001CC4FC File Offset: 0x001CA6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206899, XrefRangeEnd = 206903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600663A RID: 26170 RVA: 0x001CC554 File Offset: 0x001CA754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206903, XrefRangeEnd = 206915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600663B RID: 26171 RVA: 0x0003059A File Offset: 0x0002E79A
		public ClothingDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x0600663C RID: 26172 RVA: 0x001CC590 File Offset: 0x001CA790
		// (set) Token: 0x0600663D RID: 26173 RVA: 0x000305A3 File Offset: 0x0002E7A3
		public unsafe EClothingSlot Slot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Slot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Slot)) = value;
			}
		}

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x0600663E RID: 26174 RVA: 0x001CC5B8 File Offset: 0x001CA7B8
		// (set) Token: 0x0600663F RID: 26175 RVA: 0x000305BE File Offset: 0x0002E7BE
		public unsafe EClothingApplicationType ApplicationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ApplicationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ApplicationType)) = value;
			}
		}

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x06006640 RID: 26176 RVA: 0x001CC5E0 File Offset: 0x001CA7E0
		// (set) Token: 0x06006641 RID: 26177 RVA: 0x000305D9 File Offset: 0x0002E7D9
		public unsafe string ClothingAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ClothingAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ClothingAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x06006642 RID: 26178 RVA: 0x001CC608 File Offset: 0x001CA808
		// (set) Token: 0x06006643 RID: 26179 RVA: 0x000305F8 File Offset: 0x0002E7F8
		public unsafe bool Colorable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Colorable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Colorable)) = value;
			}
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x06006644 RID: 26180 RVA: 0x001CC630 File Offset: 0x001CA830
		// (set) Token: 0x06006645 RID: 26181 RVA: 0x00030613 File Offset: 0x0002E813
		public unsafe EClothingColor DefaultColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_DefaultColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_DefaultColor)) = value;
			}
		}

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x06006646 RID: 26182 RVA: 0x001CC658 File Offset: 0x001CA858
		// (set) Token: 0x06006647 RID: 26183 RVA: 0x0003062E File Offset: 0x0002E82E
		public unsafe List<EClothingSlot> SlotsToBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_SlotsToBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EClothingSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_SlotsToBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040045C4 RID: 17860
		private static readonly IntPtr NativeFieldInfoPtr_Slot;

		// Token: 0x040045C5 RID: 17861
		private static readonly IntPtr NativeFieldInfoPtr_ApplicationType;

		// Token: 0x040045C6 RID: 17862
		private static readonly IntPtr NativeFieldInfoPtr_ClothingAssetPath;

		// Token: 0x040045C7 RID: 17863
		private static readonly IntPtr NativeFieldInfoPtr_Colorable;

		// Token: 0x040045C8 RID: 17864
		private static readonly IntPtr NativeFieldInfoPtr_DefaultColor;

		// Token: 0x040045C9 RID: 17865
		private static readonly IntPtr NativeFieldInfoPtr_SlotsToBlock;

		// Token: 0x040045CA RID: 17866
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040045CB RID: 17867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
