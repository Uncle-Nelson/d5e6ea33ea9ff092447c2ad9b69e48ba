using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppSystem;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x020006FE RID: 1790
	public class CharacterCreatorField<T> : BaseCharacterCreatorField
	{
		// Token: 0x0600A0A1 RID: 41121 RVA: 0x00287020 File Offset: 0x00285220
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorField()
		{
			Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorField`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr);
			CharacterCreatorField<T>.NativeFieldInfoPtr__value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, "<value>k__BackingField");
			CharacterCreatorField<T>.NativeFieldInfoPtr_selectedClothingDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, "selectedClothingDefinition");
			CharacterCreatorField<T>.NativeMethodInfoPtr_get_value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100682943);
			CharacterCreatorField<T>.NativeMethodInfoPtr_set_value_Protected_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100682944);
			CharacterCreatorField<T>.NativeMethodInfoPtr_ReadValue_Public_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100682945);
			CharacterCreatorField<T>.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100682946);
			CharacterCreatorField<T>.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100682947);
			CharacterCreatorField<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100682948);
		}

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x0600A0A2 RID: 41122 RVA: 0x0028712C File Offset: 0x0028532C
		// (set) Token: 0x0600A0A3 RID: 41123 RVA: 0x00287168 File Offset: 0x00285368
		public unsafe T value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorField<T>.NativeMethodInfoPtr_get_value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorField<T>.NativeMethodInfoPtr_set_value_Protected_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A0A4 RID: 41124 RVA: 0x002871F8 File Offset: 0x002853F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282825, XrefRangeEnd = 282830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T ReadValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorField<T>.NativeMethodInfoPtr_ReadValue_Public_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600A0A5 RID: 41125 RVA: 0x0028723C File Offset: 0x0028543C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282830, XrefRangeEnd = 282840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteValue(bool applyValue = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref applyValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorField<T>.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0A6 RID: 41126 RVA: 0x00287288 File Offset: 0x00285488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282841, RefRangeEnd = 282842, XrefRangeStart = 282840, XrefRangeEnd = 282841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorField<T>.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0A7 RID: 41127 RVA: 0x002872C4 File Offset: 0x002854C4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19447, RefRangeEnd = 19461, XrefRangeStart = 19447, XrefRangeEnd = 19461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorField() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorField<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0A8 RID: 41128 RVA: 0x0004F036 File Offset: 0x0004D236
		public CharacterCreatorField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x0600A0A9 RID: 41129 RVA: 0x00287300 File Offset: 0x00285500
		// (set) Token: 0x0600A0AA RID: 41130 RVA: 0x00287328 File Offset: 0x00285528
		public unsafe T _value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr__value_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr__value_k__BackingField);
				Type typeFromHandle = typeof(T);
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

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x0600A0AB RID: 41131 RVA: 0x002873D0 File Offset: 0x002855D0
		// (set) Token: 0x0600A0AC RID: 41132 RVA: 0x0004F03F File Offset: 0x0004D23F
		public unsafe ClothingDefinition selectedClothingDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr_selectedClothingDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr_selectedClothingDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BB0 RID: 27568
		private static readonly IntPtr NativeFieldInfoPtr__value_k__BackingField;

		// Token: 0x04006BB1 RID: 27569
		private static readonly IntPtr NativeFieldInfoPtr_selectedClothingDefinition;

		// Token: 0x04006BB2 RID: 27570
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_T_0;

		// Token: 0x04006BB3 RID: 27571
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Protected_set_Void_T_0;

		// Token: 0x04006BB4 RID: 27572
		private static readonly IntPtr NativeMethodInfoPtr_ReadValue_Public_Virtual_New_T_0;

		// Token: 0x04006BB5 RID: 27573
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006BB6 RID: 27574
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x04006BB7 RID: 27575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
