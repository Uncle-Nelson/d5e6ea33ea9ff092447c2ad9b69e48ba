using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BD RID: 701
	[Serializable]
	public class VariableData : SaveData
	{
		// Token: 0x06003203 RID: 12803 RVA: 0x0010EFBC File Offset: 0x0010D1BC
		// Note: this type is marked as 'beforefieldinit'.
		static VariableData()
		{
			Il2CppClassPointerStore<VariableData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "VariableData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableData>.NativeClassPtr);
			VariableData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableData>.NativeClassPtr, "Name");
			VariableData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableData>.NativeClassPtr, "Value");
			VariableData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableData>.NativeClassPtr, 100668860);
			VariableData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableData>.NativeClassPtr, 100668861);
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x0010F03C File Offset: 0x0010D23C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130739, RefRangeEnd = 130748, XrefRangeStart = 130739, XrefRangeEnd = 130748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableData(string name, string value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x0010F09C File Offset: 0x0010D29C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131330, RefRangeEnd = 131331, XrefRangeStart = 131322, XrefRangeEnd = 131330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x0001AD07 File Offset: 0x00018F07
		public VariableData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06003207 RID: 12807 RVA: 0x0010F0D8 File Offset: 0x0010D2D8
		// (set) Token: 0x06003208 RID: 12808 RVA: 0x0001AD10 File Offset: 0x00018F10
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06003209 RID: 12809 RVA: 0x0010F100 File Offset: 0x0010D300
		// (set) Token: 0x0600320A RID: 12810 RVA: 0x0001AD2F File Offset: 0x00018F2F
		public unsafe string Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400206C RID: 8300
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400206D RID: 8301
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x0400206E RID: 8302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400206F RID: 8303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
