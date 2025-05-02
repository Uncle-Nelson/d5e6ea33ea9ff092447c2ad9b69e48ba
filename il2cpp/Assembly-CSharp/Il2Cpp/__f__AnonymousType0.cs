using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000002 RID: 2
	[ObfuscatedName("<>f__AnonymousType0`2")]
	public sealed class __f__AnonymousType0<_rb_j__TPar, _dist_j__TPar> : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00071034 File Offset: 0x0006F234
		// Note: this type is marked as 'beforefieldinit'.
		static __f__AnonymousType0()
		{
			Il2CppClassPointerStore<__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "<>f__AnonymousType0`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_rb_j__TPar>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_dist_j__TPar>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>>.NativeClassPtr);
			__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeFieldInfoPtr__rb_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>>.NativeClassPtr, "<rb>i__Field");
			__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeFieldInfoPtr__dist_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>>.NativeClassPtr, "<dist>i__Field");
			__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeMethodInfoPtr_get_rb_Public_get__rb_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>>.NativeClassPtr, 100663297);
			__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeMethodInfoPtr_get_dist_Public_get__dist_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>>.NativeClassPtr, 100663298);
			__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeMethodInfoPtr__ctor_Public_Void__rb_j__TPar__dist_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>>.NativeClassPtr, 100663299);
			__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>>.NativeClassPtr, 100663300);
			__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>>.NativeClassPtr, 100663301);
			__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>>.NativeClassPtr, 100663302);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00071154 File Offset: 0x0006F354
		public unsafe _rb_j__TPar rb
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeMethodInfoPtr_get_rb_Public_get__rb_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<_rb_j__TPar>(intPtr, false, true);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00071190 File Offset: 0x0006F390
		public unsafe _dist_j__TPar dist
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeMethodInfoPtr_get_dist_Public_get__dist_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<_dist_j__TPar>(intPtr, false, true);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000711CC File Offset: 0x0006F3CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70203, RefRangeEnd = 70204, XrefRangeStart = 70201, XrefRangeEnd = 70203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __f__AnonymousType0(_rb_j__TPar rb, _dist_j__TPar dist) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			_rb_j__TPar ptr4;
			if (!typeof(_rb_j__TPar).IsValueType)
			{
				_rb_j__TPar rb_j__TPar = rb;
				if (!(rb_j__TPar is string))
				{
					ref _rb_j__TPar ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(rb_j__TPar as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(rb_j__TPar as string);
				}
			}
			else
			{
				ptr4 = ref rb;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			_dist_j__TPar ptr7;
			if (!typeof(_dist_j__TPar).IsValueType)
			{
				_dist_j__TPar dist_j__TPar = dist;
				if (!(dist_j__TPar is string))
				{
					ref _dist_j__TPar ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(dist_j__TPar as Il2CppObjectBase);
					if (ref ptr6 != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(dist_j__TPar as string);
				}
			}
			else
			{
				ptr7 = ref dist;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeMethodInfoPtr__ctor_Public_Void__rb_j__TPar__dist_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000712C0 File Offset: 0x0006F4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70204, XrefRangeEnd = 70209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00071310 File Offset: 0x0006F510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70209, XrefRangeEnd = 70211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0007134C File Offset: 0x0006F54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70211, XrefRangeEnd = 70223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		public __f__AnonymousType0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00071384 File Offset: 0x0006F584
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000713AC File Offset: 0x0006F5AC
		public unsafe _rb_j__TPar _rb_i__Field
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeFieldInfoPtr__rb_i__Field);
				return IL2CPP.PointerToValueGeneric<_rb_j__TPar>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeFieldInfoPtr__rb_i__Field);
				Type typeFromHandle = typeof(_rb_j__TPar);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00071454 File Offset: 0x0006F654
		// (set) Token: 0x0600000C RID: 12 RVA: 0x0007147C File Offset: 0x0006F67C
		public unsafe _dist_j__TPar _dist_i__Field
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeFieldInfoPtr__dist_i__Field);
				return IL2CPP.PointerToValueGeneric<_dist_j__TPar>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType0<_rb_j__TPar, _dist_j__TPar>.NativeFieldInfoPtr__dist_i__Field);
				Type typeFromHandle = typeof(_dist_j__TPar);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr__rb_i__Field;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr__dist_i__Field;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_get_rb_Public_get__rb_j__TPar_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_dist_Public_get__dist_j__TPar_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void__rb_j__TPar__dist_j__TPar_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
