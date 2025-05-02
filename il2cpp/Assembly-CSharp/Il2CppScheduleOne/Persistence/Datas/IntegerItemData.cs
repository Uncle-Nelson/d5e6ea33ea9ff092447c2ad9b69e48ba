using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000265 RID: 613
	[Serializable]
	public class IntegerItemData : ItemData
	{
		// Token: 0x06002F2E RID: 12078 RVA: 0x00107028 File Offset: 0x00105228
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemData()
		{
			Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "IntegerItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr);
			IntegerItemData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr, "Value");
			IntegerItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr, 100668763);
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x00107080 File Offset: 0x00105280
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130702, RefRangeEnd = 130704, XrefRangeStart = 130702, XrefRangeEnd = 130704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemData(string iD, int quantity, int value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x00018F1B File Offset: 0x0001711B
		public IntegerItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x001070E8 File Offset: 0x001052E8
		// (set) Token: 0x06002F32 RID: 12082 RVA: 0x00018F24 File Offset: 0x00017124
		public unsafe int Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemData.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemData.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x04001F29 RID: 7977
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001F2A RID: 7978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;
	}
}
