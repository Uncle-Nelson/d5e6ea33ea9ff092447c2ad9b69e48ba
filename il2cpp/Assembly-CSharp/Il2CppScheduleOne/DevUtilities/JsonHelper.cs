using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000457 RID: 1111
	public static class JsonHelper : Object
	{
		// Token: 0x060060A7 RID: 24743 RVA: 0x001B9DA8 File Offset: 0x001B7FA8
		// Note: this type is marked as 'beforefieldinit'.
		static JsonHelper()
		{
			Il2CppClassPointerStore<JsonHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "JsonHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr);
			JsonHelper.NativeMethodInfoPtr_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100675590);
			JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100675591);
			JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100675592);
		}

		// Token: 0x060060A8 RID: 24744 RVA: 0x001B9E14 File Offset: 0x001B8014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199527, XrefRangeEnd = 199528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> FromJson<T>(string json)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.MethodInfoStoreGeneric_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060060A9 RID: 24745 RVA: 0x001B9E50 File Offset: 0x001B8050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199528, XrefRangeEnd = 199544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToJson<T>(Il2CppArrayBase<T> array)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x001B9E8C File Offset: 0x001B808C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199544, XrefRangeEnd = 199550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToJson<T>(Il2CppArrayBase<T> array, bool prettyPrint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x0002DB6F File Offset: 0x0002BD6F
		public JsonHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040041F9 RID: 16889
		private static readonly IntPtr NativeMethodInfoPtr_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0;

		// Token: 0x040041FA RID: 16890
		private static readonly IntPtr NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0;

		// Token: 0x040041FB RID: 16891
		private static readonly IntPtr NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x02000A12 RID: 2578
		[Serializable]
		public class Wrapper<T> : Object
		{
			// Token: 0x0600CED2 RID: 52946 RVA: 0x0031BA54 File Offset: 0x00319C54
			// Note: this type is marked as 'beforefieldinit'.
			static Wrapper()
			{
				Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, "Wrapper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr);
				JsonHelper.Wrapper<T>.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr, "Items");
				JsonHelper.Wrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr, 100675593);
			}

			// Token: 0x0600CED3 RID: 52947 RVA: 0x0031BAE4 File Offset: 0x00319CE4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Wrapper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonHelper.Wrapper<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.Wrapper<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CED4 RID: 52948 RVA: 0x0006497A File Offset: 0x00062B7A
			public Wrapper(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700404F RID: 16463
			// (get) Token: 0x0600CED5 RID: 52949 RVA: 0x0031BB20 File Offset: 0x00319D20
			// (set) Token: 0x0600CED6 RID: 52950 RVA: 0x00064983 File Offset: 0x00062B83
			public unsafe Il2CppArrayBase<T> Items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonHelper.Wrapper<T>.NativeFieldInfoPtr_Items);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonHelper.Wrapper<T>.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B8D RID: 35725
			private static readonly IntPtr NativeFieldInfoPtr_Items;

			// Token: 0x04008B8E RID: 35726
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A13 RID: 2579
		private sealed class MethodInfoStoreGeneric_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0<T>
		{
			// Token: 0x04008B8F RID: 35727
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonHelper.NativeMethodInfoPtr_FromJson_Public_Static_Il2CppArrayBase_1_T_String_0, Il2CppClassPointerStore<JsonHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A14 RID: 2580
		private sealed class MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04008B90 RID: 35728
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<JsonHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A15 RID: 2581
		private sealed class MethodInfoStoreGeneric_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04008B91 RID: 35729
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonHelper.NativeMethodInfoPtr_ToJson_Public_Static_String_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<JsonHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
