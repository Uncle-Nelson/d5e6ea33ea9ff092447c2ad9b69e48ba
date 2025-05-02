using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000561 RID: 1377
	public class FilledPackaging_Equippable : Equippable_Viewmodel
	{
		// Token: 0x060078EC RID: 30956 RVA: 0x0020A540 File Offset: 0x00208740
		// Note: this type is marked as 'beforefieldinit'.
		static FilledPackaging_Equippable()
		{
			Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FilledPackaging_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr);
			FilledPackaging_Equippable.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr, "Visuals");
			FilledPackaging_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr, 100678458);
			FilledPackaging_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr, 100678459);
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x0020A5AC File Offset: 0x002087AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232898, XrefRangeEnd = 232902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilledPackaging_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x0020A5FC File Offset: 0x002087FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilledPackaging_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackaging_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078EF RID: 30959 RVA: 0x00039669 File Offset: 0x00037869
		public FilledPackaging_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002491 RID: 9361
		// (get) Token: 0x060078F0 RID: 30960 RVA: 0x0020A638 File Offset: 0x00208838
		// (set) Token: 0x060078F1 RID: 30961 RVA: 0x00039672 File Offset: 0x00037872
		public unsafe FilledPackagingVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackaging_Equippable.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackaging_Equippable.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005259 RID: 21081
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x0400525A RID: 21082
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x0400525B RID: 21083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
