using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Properties;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005AE RID: 1454
	[Serializable]
	public class PropertyItemDefinition : StorableItemDefinition
	{
		// Token: 0x06007FE6 RID: 32742 RVA: 0x00223BC8 File Offset: 0x00221DC8
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyItemDefinition()
		{
			Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr);
			PropertyItemDefinition.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, "Properties");
			PropertyItemDefinition.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, 100679353);
			PropertyItemDefinition.NativeMethodInfoPtr_HasProperty_Public_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, 100679354);
			PropertyItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, 100679355);
		}

		// Token: 0x06007FE7 RID: 32743 RVA: 0x00223C48 File Offset: 0x00221E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243641, RefRangeEnd = 243642, XrefRangeStart = 243637, XrefRangeEnd = 243641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyItemDefinition.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_List_1_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FE8 RID: 32744 RVA: 0x00223C98 File Offset: 0x00221E98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243646, RefRangeEnd = 243648, XrefRangeStart = 243642, XrefRangeEnd = 243646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasProperty(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyItemDefinition.NativeMethodInfoPtr_HasProperty_Public_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007FE9 RID: 32745 RVA: 0x00223CE8 File Offset: 0x00221EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243656, RefRangeEnd = 243657, XrefRangeStart = 243648, XrefRangeEnd = 243656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FEA RID: 32746 RVA: 0x0003CA01 File Offset: 0x0003AC01
		public PropertyItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026A4 RID: 9892
		// (get) Token: 0x06007FEB RID: 32747 RVA: 0x00223D24 File Offset: 0x00221F24
		// (set) Token: 0x06007FEC RID: 32748 RVA: 0x0003CA0A File Offset: 0x0003AC0A
		public unsafe List<Property> Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyItemDefinition.NativeFieldInfoPtr_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyItemDefinition.NativeFieldInfoPtr_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005727 RID: 22311
		private static readonly IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x04005728 RID: 22312
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_List_1_Property_0;

		// Token: 0x04005729 RID: 22313
		private static readonly IntPtr NativeMethodInfoPtr_HasProperty_Public_Boolean_Property_0;

		// Token: 0x0400572A RID: 22314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
