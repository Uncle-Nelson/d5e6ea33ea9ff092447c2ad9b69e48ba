using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x0200075C RID: 1884
	[Serializable]
	public class WateringCanDefinition : StorableItemDefinition
	{
		// Token: 0x0600B34B RID: 45899 RVA: 0x002CB9C8 File Offset: 0x002C9BC8
		// Note: this type is marked as 'beforefieldinit'.
		static WateringCanDefinition()
		{
			Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "WateringCanDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr);
			WateringCanDefinition.NativeFieldInfoPtr_Capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr, "Capacity");
			WateringCanDefinition.NativeFieldInfoPtr_FunctionalWateringCanPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr, "FunctionalWateringCanPrefab");
			WateringCanDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr, 100685412);
			WateringCanDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr, 100685413);
		}

		// Token: 0x0600B34C RID: 45900 RVA: 0x002CBA48 File Offset: 0x002C9C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308856, XrefRangeEnd = 308860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WateringCanDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600B34D RID: 45901 RVA: 0x002CBAA0 File Offset: 0x002C9CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B34E RID: 45902 RVA: 0x00057DA0 File Offset: 0x00055FA0
		public WateringCanDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x0600B34F RID: 45903 RVA: 0x002CBADC File Offset: 0x002C9CDC
		// (set) Token: 0x0600B350 RID: 45904 RVA: 0x00057DA9 File Offset: 0x00055FA9
		public unsafe static float Capacity
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WateringCanDefinition.NativeFieldInfoPtr_Capacity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WateringCanDefinition.NativeFieldInfoPtr_Capacity, (void*)(&value));
			}
		}

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x0600B351 RID: 45905 RVA: 0x002CBAF8 File Offset: 0x002C9CF8
		// (set) Token: 0x0600B352 RID: 45906 RVA: 0x00057DB7 File Offset: 0x00055FB7
		public unsafe GameObject FunctionalWateringCanPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanDefinition.NativeFieldInfoPtr_FunctionalWateringCanPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanDefinition.NativeFieldInfoPtr_FunctionalWateringCanPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040078F8 RID: 30968
		private static readonly IntPtr NativeFieldInfoPtr_Capacity;

		// Token: 0x040078F9 RID: 30969
		private static readonly IntPtr NativeFieldInfoPtr_FunctionalWateringCanPrefab;

		// Token: 0x040078FA RID: 30970
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040078FB RID: 30971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
