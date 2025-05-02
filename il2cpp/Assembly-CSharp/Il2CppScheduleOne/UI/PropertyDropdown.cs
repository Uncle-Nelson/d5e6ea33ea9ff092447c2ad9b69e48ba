using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000661 RID: 1633
	public class PropertyDropdown : MonoBehaviour
	{
		// Token: 0x060091D2 RID: 37330 RVA: 0x0025A688 File Offset: 0x00258888
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyDropdown()
		{
			Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PropertyDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr);
			PropertyDropdown.NativeFieldInfoPtr_selectedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "selectedProperty");
			PropertyDropdown.NativeFieldInfoPtr_TMP_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "TMP_dropdown");
			PropertyDropdown.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "dropdown");
			PropertyDropdown.NativeFieldInfoPtr_intToProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "intToProperty");
			PropertyDropdown.NativeFieldInfoPtr_onSelectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "onSelectionChanged");
			PropertyDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100681369);
			PropertyDropdown.NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100681370);
			PropertyDropdown.NativeMethodInfoPtr_ValueChanged_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100681371);
			PropertyDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100681372);
		}

		// Token: 0x060091D3 RID: 37331 RVA: 0x0025A76C File Offset: 0x0025896C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263772, XrefRangeEnd = 263842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D4 RID: 37332 RVA: 0x0025A7A8 File Offset: 0x002589A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263842, XrefRangeEnd = 263871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PropertyAcquired(Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDropdown.NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D5 RID: 37333 RVA: 0x0025A7EC File Offset: 0x002589EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263871, XrefRangeEnd = 263875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(int newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDropdown.NativeMethodInfoPtr_ValueChanged_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D6 RID: 37334 RVA: 0x0025A82C File Offset: 0x00258A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263875, XrefRangeEnd = 263883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDropdown() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D7 RID: 37335 RVA: 0x00046851 File Offset: 0x00044A51
		public PropertyDropdown(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CAF RID: 11439
		// (get) Token: 0x060091D8 RID: 37336 RVA: 0x0025A868 File Offset: 0x00258A68
		// (set) Token: 0x060091D9 RID: 37337 RVA: 0x0004685A File Offset: 0x00044A5A
		public unsafe Property selectedProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_selectedProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_selectedProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB0 RID: 11440
		// (get) Token: 0x060091DA RID: 37338 RVA: 0x0025A898 File Offset: 0x00258A98
		// (set) Token: 0x060091DB RID: 37339 RVA: 0x00046879 File Offset: 0x00044A79
		public unsafe TMP_Dropdown TMP_dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_TMP_dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_TMP_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB1 RID: 11441
		// (get) Token: 0x060091DC RID: 37340 RVA: 0x0025A8C8 File Offset: 0x00258AC8
		// (set) Token: 0x060091DD RID: 37341 RVA: 0x00046898 File Offset: 0x00044A98
		public unsafe Dropdown dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB2 RID: 11442
		// (get) Token: 0x060091DE RID: 37342 RVA: 0x0025A8F8 File Offset: 0x00258AF8
		// (set) Token: 0x060091DF RID: 37343 RVA: 0x000468B7 File Offset: 0x00044AB7
		public unsafe Dictionary<int, Property> intToProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_intToProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Property>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_intToProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB3 RID: 11443
		// (get) Token: 0x060091E0 RID: 37344 RVA: 0x0025A928 File Offset: 0x00258B28
		// (set) Token: 0x060091E1 RID: 37345 RVA: 0x000468D6 File Offset: 0x00044AD6
		public unsafe Action onSelectionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_onSelectionChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_onSelectionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006288 RID: 25224
		private static readonly IntPtr NativeFieldInfoPtr_selectedProperty;

		// Token: 0x04006289 RID: 25225
		private static readonly IntPtr NativeFieldInfoPtr_TMP_dropdown;

		// Token: 0x0400628A RID: 25226
		private static readonly IntPtr NativeFieldInfoPtr_dropdown;

		// Token: 0x0400628B RID: 25227
		private static readonly IntPtr NativeFieldInfoPtr_intToProperty;

		// Token: 0x0400628C RID: 25228
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionChanged;

		// Token: 0x0400628D RID: 25229
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400628E RID: 25230
		private static readonly IntPtr NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0;

		// Token: 0x0400628F RID: 25231
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Private_Void_Int32_0;

		// Token: 0x04006290 RID: 25232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
