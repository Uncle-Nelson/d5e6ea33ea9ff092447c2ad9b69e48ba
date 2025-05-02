using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFishySteamworks
{
	// Token: 0x0200078C RID: 1932
	public class BidirectionalDictionary<T1, T2> : Object
	{
		// Token: 0x0600B6FB RID: 46843 RVA: 0x002D65A8 File Offset: 0x002D47A8
		// Note: this type is marked as 'beforefieldinit'.
		static BidirectionalDictionary()
		{
			Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks", "BidirectionalDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr);
			BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t1ToT2Dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, "t1ToT2Dict");
			BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t2ToT1Dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, "t2ToT1Dict");
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_FirstTypes_Public_get_IEnumerable_1_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685769);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_SecondTypes_Public_get_IEnumerable_1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685770);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685771);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685772);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_First_Public_get_Dictionary_2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685773);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Second_Public_get_Dictionary_2_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685774);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Add_Public_Void_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685775);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Add_Public_Void_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685776);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Get_Public_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685777);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Get_Public_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685778);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_T1_byref_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685779);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_T2_byref_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685780);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Contains_Public_Boolean_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685781);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Contains_Public_Boolean_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685782);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Remove_Public_Void_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685783);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Remove_Public_Void_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685784);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Item_Public_get_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685785);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_set_Item_Public_set_Void_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685786);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Item_Public_get_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685787);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_set_Item_Public_set_Void_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685788);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685789);
		}

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x0600B6FC RID: 46844 RVA: 0x002D67F4 File Offset: 0x002D49F4
		public unsafe IEnumerable<T1> FirstTypes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 311982, RefRangeEnd = 311983, XrefRangeStart = 311978, XrefRangeEnd = 311982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_FirstTypes_Public_get_IEnumerable_1_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T1>>(intPtr3) : null;
			}
		}

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x0600B6FD RID: 46845 RVA: 0x002D6834 File Offset: 0x002D4A34
		public unsafe IEnumerable<T2> SecondTypes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311983, XrefRangeEnd = 311989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_SecondTypes_Public_get_IEnumerable_1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T2>>(intPtr3) : null;
			}
		}

		// Token: 0x0600B6FE RID: 46846 RVA: 0x002D6874 File Offset: 0x002D4A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311989, XrefRangeEnd = 311991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x0600B6FF RID: 46847 RVA: 0x002D68B4 File Offset: 0x002D4AB4
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311991, XrefRangeEnd = 311993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x0600B700 RID: 46848 RVA: 0x002D68F0 File Offset: 0x002D4AF0
		public unsafe Dictionary<T1, T2> First
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_First_Public_get_Dictionary_2_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<T1, T2>>(intPtr3) : null;
			}
		}

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x0600B701 RID: 46849 RVA: 0x002D6930 File Offset: 0x002D4B30
		public unsafe Dictionary<T2, T1> Second
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Second_Public_get_Dictionary_2_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<T2, T1>>(intPtr3) : null;
			}
		}

		// Token: 0x0600B702 RID: 46850 RVA: 0x002D6970 File Offset: 0x002D4B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312013, RefRangeEnd = 312014, XrefRangeStart = 311993, XrefRangeEnd = 312013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(T1 key, T2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T2 ptr7;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = value;
				if (!(t2 is string))
				{
					ref T2 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
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
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref value;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Add_Public_Void_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B703 RID: 46851 RVA: 0x002D6A5C File Offset: 0x002D4C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312014, XrefRangeEnd = 312022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(T2 key, T1 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T1 ptr7;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = value;
				if (!(t2 is string))
				{
					ref T1 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
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
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref value;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Add_Public_Void_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B704 RID: 46852 RVA: 0x002D6B48 File Offset: 0x002D4D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312022, XrefRangeEnd = 312024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T2 Get(T1 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Get_Public_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T2>(intPtr, false, true);
		}

		// Token: 0x0600B705 RID: 46853 RVA: 0x002D6BE0 File Offset: 0x002D4DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312024, XrefRangeEnd = 312030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T1 Get(T2 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Get_Public_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T1>(intPtr, false, true);
		}

		// Token: 0x0600B706 RID: 46854 RVA: 0x002D6C78 File Offset: 0x002D4E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312030, XrefRangeEnd = 312036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(T1 key, out T2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr5 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_T1_byref_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T2).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T2>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600B707 RID: 46855 RVA: 0x002D6D60 File Offset: 0x002D4F60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312038, RefRangeEnd = 312040, XrefRangeStart = 312036, XrefRangeEnd = 312038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(T2 key, out T1 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr5 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_T2_byref_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T1).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600B708 RID: 46856 RVA: 0x002D6E48 File Offset: 0x002D5048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312040, XrefRangeEnd = 312042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(T1 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Contains_Public_Boolean_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B709 RID: 46857 RVA: 0x002D6EE0 File Offset: 0x002D50E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312042, XrefRangeEnd = 312046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(T2 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Contains_Public_Boolean_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B70A RID: 46858 RVA: 0x002D6F78 File Offset: 0x002D5178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312050, RefRangeEnd = 312051, XrefRangeStart = 312046, XrefRangeEnd = 312050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(T1 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Remove_Public_Void_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B70B RID: 46859 RVA: 0x002D7008 File Offset: 0x002D5208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312055, RefRangeEnd = 312056, XrefRangeStart = 312051, XrefRangeEnd = 312055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(T2 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Remove_Public_Void_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170038CA RID: 14538
		public unsafe T1 this[T2 key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T2 ptr4;
				if (!typeof(T2).IsValueType)
				{
					T2 t = key;
					if (!(t is string))
					{
						ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Item_Public_get_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T1>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312056, XrefRangeEnd = 312072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T2 ptr4;
				if (!typeof(T2).IsValueType)
				{
					T2 t = key;
					if (!(t is string))
					{
						ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				T1 ptr7;
				if (!typeof(T1).IsValueType)
				{
					T1 t2 = value;
					if (!(t2 is string))
					{
						ref T1 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
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
						ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr7 = ref value;
				}
				*ptr5 = ref ptr7;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_set_Item_Public_set_Void_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170038CB RID: 14539
		public unsafe T2 this[T1 key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T1 ptr4;
				if (!typeof(T1).IsValueType)
				{
					T1 t = key;
					if (!(t is string))
					{
						ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Item_Public_get_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, false, true);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312092, RefRangeEnd = 312093, XrefRangeStart = 312072, XrefRangeEnd = 312092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T1 ptr4;
				if (!typeof(T1).IsValueType)
				{
					T1 t = key;
					if (!(t is string))
					{
						ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				T2 ptr7;
				if (!typeof(T2).IsValueType)
				{
					T2 t2 = value;
					if (!(t2 is string))
					{
						ref T2 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
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
						ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr7 = ref value;
				}
				*ptr5 = ref ptr7;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_set_Item_Public_set_Void_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B710 RID: 46864 RVA: 0x002D73A0 File Offset: 0x002D55A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312111, RefRangeEnd = 312113, XrefRangeStart = 312093, XrefRangeEnd = 312111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BidirectionalDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B711 RID: 46865 RVA: 0x00059EB2 File Offset: 0x000580B2
		public BidirectionalDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x0600B712 RID: 46866 RVA: 0x002D73DC File Offset: 0x002D55DC
		// (set) Token: 0x0600B713 RID: 46867 RVA: 0x00059EBB File Offset: 0x000580BB
		public unsafe Dictionary<T1, T2> t1ToT2Dict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t1ToT2Dict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<T1, T2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t1ToT2Dict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x0600B714 RID: 46868 RVA: 0x002D740C File Offset: 0x002D560C
		// (set) Token: 0x0600B715 RID: 46869 RVA: 0x00059EDA File Offset: 0x000580DA
		public unsafe Dictionary<T2, T1> t2ToT1Dict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t2ToT1Dict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<T2, T1>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t2ToT1Dict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007B38 RID: 31544
		private static readonly IntPtr NativeFieldInfoPtr_t1ToT2Dict;

		// Token: 0x04007B39 RID: 31545
		private static readonly IntPtr NativeFieldInfoPtr_t2ToT1Dict;

		// Token: 0x04007B3A RID: 31546
		private static readonly IntPtr NativeMethodInfoPtr_get_FirstTypes_Public_get_IEnumerable_1_T1_0;

		// Token: 0x04007B3B RID: 31547
		private static readonly IntPtr NativeMethodInfoPtr_get_SecondTypes_Public_get_IEnumerable_1_T2_0;

		// Token: 0x04007B3C RID: 31548
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04007B3D RID: 31549
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04007B3E RID: 31550
		private static readonly IntPtr NativeMethodInfoPtr_get_First_Public_get_Dictionary_2_T1_T2_0;

		// Token: 0x04007B3F RID: 31551
		private static readonly IntPtr NativeMethodInfoPtr_get_Second_Public_get_Dictionary_2_T2_T1_0;

		// Token: 0x04007B40 RID: 31552
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T1_T2_0;

		// Token: 0x04007B41 RID: 31553
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T2_T1_0;

		// Token: 0x04007B42 RID: 31554
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T2_T1_0;

		// Token: 0x04007B43 RID: 31555
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T1_T2_0;

		// Token: 0x04007B44 RID: 31556
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_T1_byref_T2_0;

		// Token: 0x04007B45 RID: 31557
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_T2_byref_T1_0;

		// Token: 0x04007B46 RID: 31558
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_T1_0;

		// Token: 0x04007B47 RID: 31559
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_T2_0;

		// Token: 0x04007B48 RID: 31560
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_T1_0;

		// Token: 0x04007B49 RID: 31561
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_T2_0;

		// Token: 0x04007B4A RID: 31562
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T1_T2_0;

		// Token: 0x04007B4B RID: 31563
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_T2_T1_0;

		// Token: 0x04007B4C RID: 31564
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T2_T1_0;

		// Token: 0x04007B4D RID: 31565
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_T1_T2_0;

		// Token: 0x04007B4E RID: 31566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
