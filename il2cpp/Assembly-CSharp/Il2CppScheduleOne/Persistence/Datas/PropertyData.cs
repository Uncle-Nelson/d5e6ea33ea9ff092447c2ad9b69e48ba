using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002AE RID: 686
	[Serializable]
	public class PropertyData : SaveData
	{
		// Token: 0x06003170 RID: 12656 RVA: 0x0010D700 File Offset: 0x0010B900
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyData()
		{
			Il2CppClassPointerStore<PropertyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PropertyData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyData>.NativeClassPtr);
			PropertyData.NativeFieldInfoPtr_PropertyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "PropertyCode");
			PropertyData.NativeFieldInfoPtr_IsOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "IsOwned");
			PropertyData.NativeFieldInfoPtr_SwitchStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "SwitchStates");
			PropertyData.NativeFieldInfoPtr_ToggleableStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "ToggleableStates");
			PropertyData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, 100668839);
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x0010D794 File Offset: 0x0010B994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131133, RefRangeEnd = 131134, XrefRangeStart = 131129, XrefRangeEnd = 131133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyData(string propertyCode, bool isOwned, Il2CppStructArray<bool> switchStates, Il2CppStructArray<bool> toggleableStates) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOwned;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(switchStates);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toggleableStates);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x0001A6D9 File Offset: 0x000188D9
		public PropertyData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06003173 RID: 12659 RVA: 0x0010D814 File Offset: 0x0010BA14
		// (set) Token: 0x06003174 RID: 12660 RVA: 0x0001A6E2 File Offset: 0x000188E2
		public unsafe string PropertyCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_PropertyCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_PropertyCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06003175 RID: 12661 RVA: 0x0010D83C File Offset: 0x0010BA3C
		// (set) Token: 0x06003176 RID: 12662 RVA: 0x0001A701 File Offset: 0x00018901
		public unsafe bool IsOwned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_IsOwned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_IsOwned)) = value;
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06003177 RID: 12663 RVA: 0x0010D864 File Offset: 0x0010BA64
		// (set) Token: 0x06003178 RID: 12664 RVA: 0x0001A71C File Offset: 0x0001891C
		public unsafe Il2CppStructArray<bool> SwitchStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_SwitchStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_SwitchStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06003179 RID: 12665 RVA: 0x0010D894 File Offset: 0x0010BA94
		// (set) Token: 0x0600317A RID: 12666 RVA: 0x0001A73B File Offset: 0x0001893B
		public unsafe Il2CppStructArray<bool> ToggleableStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_ToggleableStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_ToggleableStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeFieldInfoPtr_PropertyCode;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeFieldInfoPtr_IsOwned;

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeFieldInfoPtr_SwitchStates;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeFieldInfoPtr_ToggleableStates;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_0;
	}
}
