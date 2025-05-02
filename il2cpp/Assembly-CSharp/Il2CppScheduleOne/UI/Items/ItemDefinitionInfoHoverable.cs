using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000716 RID: 1814
	public class ItemDefinitionInfoHoverable : MonoBehaviour
	{
		// Token: 0x0600A331 RID: 41777 RVA: 0x0028F79C File Offset: 0x0028D99C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemDefinitionInfoHoverable()
		{
			Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemDefinitionInfoHoverable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr);
			ItemDefinitionInfoHoverable.NativeFieldInfoPtr_AssignedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr, "AssignedItem");
			ItemDefinitionInfoHoverable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr, 100683267);
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x0028F7F4 File Offset: 0x0028D9F4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinitionInfoHoverable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemDefinitionInfoHoverable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x0005053E File Offset: 0x0004E73E
		public ItemDefinitionInfoHoverable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x0600A334 RID: 41780 RVA: 0x0028F830 File Offset: 0x0028DA30
		// (set) Token: 0x0600A335 RID: 41781 RVA: 0x00050547 File Offset: 0x0004E747
		public unsafe ItemDefinition AssignedItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinitionInfoHoverable.NativeFieldInfoPtr_AssignedItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinitionInfoHoverable.NativeFieldInfoPtr_AssignedItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D76 RID: 28022
		private static readonly IntPtr NativeFieldInfoPtr_AssignedItem;

		// Token: 0x04006D77 RID: 28023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
