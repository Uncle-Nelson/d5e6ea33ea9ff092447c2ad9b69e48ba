using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200046B RID: 1131
	[Serializable]
	public class StringIntPair : Object
	{
		// Token: 0x060061FA RID: 25082 RVA: 0x001BE35C File Offset: 0x001BC55C
		// Note: this type is marked as 'beforefieldinit'.
		static StringIntPair()
		{
			Il2CppClassPointerStore<StringIntPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "StringIntPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr);
			StringIntPair.NativeFieldInfoPtr_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, "String");
			StringIntPair.NativeFieldInfoPtr_Int = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, "Int");
			StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, 100675732);
			StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, 100675733);
		}

		// Token: 0x060061FB RID: 25083 RVA: 0x001BE3DC File Offset: 0x001BC5DC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 107300, RefRangeEnd = 107309, XrefRangeStart = 107300, XrefRangeEnd = 107309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringIntPair(string str, int i) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061FC RID: 25084 RVA: 0x001BE438 File Offset: 0x001BC638
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringIntPair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061FD RID: 25085 RVA: 0x0002E4EC File Offset: 0x0002C6EC
		public StringIntPair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x060061FE RID: 25086 RVA: 0x001BE474 File Offset: 0x001BC674
		// (set) Token: 0x060061FF RID: 25087 RVA: 0x0002E4F5 File Offset: 0x0002C6F5
		public unsafe string String
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_String);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_String), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x06006200 RID: 25088 RVA: 0x001BE49C File Offset: 0x001BC69C
		// (set) Token: 0x06006201 RID: 25089 RVA: 0x0002E514 File Offset: 0x0002C714
		public unsafe int Int
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_Int);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_Int)) = value;
			}
		}

		// Token: 0x040042CF RID: 17103
		private static readonly IntPtr NativeFieldInfoPtr_String;

		// Token: 0x040042D0 RID: 17104
		private static readonly IntPtr NativeFieldInfoPtr_Int;

		// Token: 0x040042D1 RID: 17105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x040042D2 RID: 17106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
