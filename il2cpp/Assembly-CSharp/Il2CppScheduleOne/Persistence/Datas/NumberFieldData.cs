using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027D RID: 637
	[Serializable]
	public class NumberFieldData : Object
	{
		// Token: 0x06002FBD RID: 12221 RVA: 0x001087E0 File Offset: 0x001069E0
		// Note: this type is marked as 'beforefieldinit'.
		static NumberFieldData()
		{
			Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NumberFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr);
			NumberFieldData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr, "Value");
			NumberFieldData.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr, 100668788);
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x00108838 File Offset: 0x00106A38
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 130749, RefRangeEnd = 130892, XrefRangeStart = 130748, XrefRangeEnd = 130749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFieldData(float value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldData.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x000194B3 File Offset: 0x000176B3
		public NumberFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06002FC0 RID: 12224 RVA: 0x00108880 File Offset: 0x00106A80
		// (set) Token: 0x06002FC1 RID: 12225 RVA: 0x000194BC File Offset: 0x000176BC
		public unsafe float Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldData.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldData.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
