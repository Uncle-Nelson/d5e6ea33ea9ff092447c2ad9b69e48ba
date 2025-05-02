using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000261 RID: 609
	[Serializable]
	public class GenericSaveData : SaveData
	{
		// Token: 0x06002F0C RID: 12044 RVA: 0x001068A8 File Offset: 0x00104AA8
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSaveData()
		{
			Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GenericSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr);
			GenericSaveData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "GUID");
			GenericSaveData.NativeFieldInfoPtr_boolValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "boolValues");
			GenericSaveData.NativeFieldInfoPtr_floatValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "floatValues");
			GenericSaveData.NativeFieldInfoPtr_intValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "intValues");
			GenericSaveData.NativeFieldInfoPtr_stringValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "stringValues");
			GenericSaveData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668739);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668740);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668741);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668742);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668743);
			GenericSaveData.NativeMethodInfoPtr_GetBool_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668744);
			GenericSaveData.NativeMethodInfoPtr_GetFloat_Public_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668745);
			GenericSaveData.NativeMethodInfoPtr_GetInt_Public_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668746);
			GenericSaveData.NativeMethodInfoPtr_GetString_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668747);
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x001069F0 File Offset: 0x00104BF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130597, RefRangeEnd = 130599, XrefRangeStart = 130564, XrefRangeEnd = 130597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSaveData(string guid) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x00106A3C File Offset: 0x00104C3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130607, RefRangeEnd = 130609, XrefRangeStart = 130599, XrefRangeEnd = 130607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x00106A8C File Offset: 0x00104C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130609, XrefRangeEnd = 130617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x00106ADC File Offset: 0x00104CDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130625, RefRangeEnd = 130627, XrefRangeStart = 130617, XrefRangeEnd = 130625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x00106B2C File Offset: 0x00104D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130627, XrefRangeEnd = 130636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x00106B80 File Offset: 0x00104D80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130650, RefRangeEnd = 130652, XrefRangeStart = 130636, XrefRangeEnd = 130650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBool(string key, bool defaultValue = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetBool_Public_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x00106BDC File Offset: 0x00104DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130652, XrefRangeEnd = 130666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFloat(string key, float defaultValue = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetFloat_Public_Single_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x00106C38 File Offset: 0x00104E38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130680, RefRangeEnd = 130682, XrefRangeStart = 130666, XrefRangeEnd = 130680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInt(string key, int defaultValue = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetInt_Public_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x00106C94 File Offset: 0x00104E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130682, XrefRangeEnd = 130696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(string key, string defaultValue = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetString_Public_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x00018DED File Offset: 0x00016FED
		public GenericSaveData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06002F17 RID: 12055 RVA: 0x00106CF0 File Offset: 0x00104EF0
		// (set) Token: 0x06002F18 RID: 12056 RVA: 0x00018DF6 File Offset: 0x00016FF6
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x00106D18 File Offset: 0x00104F18
		// (set) Token: 0x06002F1A RID: 12058 RVA: 0x00018E15 File Offset: 0x00017015
		public unsafe List<GenericSaveData.BoolValue> boolValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_boolValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.BoolValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_boolValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x00106D48 File Offset: 0x00104F48
		// (set) Token: 0x06002F1C RID: 12060 RVA: 0x00018E34 File Offset: 0x00017034
		public unsafe List<GenericSaveData.FloatValue> floatValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_floatValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.FloatValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_floatValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x00106D78 File Offset: 0x00104F78
		// (set) Token: 0x06002F1E RID: 12062 RVA: 0x00018E53 File Offset: 0x00017053
		public unsafe List<GenericSaveData.IntValue> intValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_intValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.IntValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_intValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06002F1F RID: 12063 RVA: 0x00106DA8 File Offset: 0x00104FA8
		// (set) Token: 0x06002F20 RID: 12064 RVA: 0x00018E72 File Offset: 0x00017072
		public unsafe List<GenericSaveData.StringValue> stringValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_stringValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.StringValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_stringValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeFieldInfoPtr_boolValues;

		// Token: 0x04001F18 RID: 7960
		private static readonly IntPtr NativeFieldInfoPtr_floatValues;

		// Token: 0x04001F19 RID: 7961
		private static readonly IntPtr NativeFieldInfoPtr_intValues;

		// Token: 0x04001F1A RID: 7962
		private static readonly IntPtr NativeFieldInfoPtr_stringValues;

		// Token: 0x04001F1B RID: 7963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001F1C RID: 7964
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Boolean_0;

		// Token: 0x04001F1D RID: 7965
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Single_0;

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Int32_0;

		// Token: 0x04001F1F RID: 7967
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_String_0;

		// Token: 0x04001F20 RID: 7968
		private static readonly IntPtr NativeMethodInfoPtr_GetBool_Public_Boolean_String_Boolean_0;

		// Token: 0x04001F21 RID: 7969
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_String_Single_0;

		// Token: 0x04001F22 RID: 7970
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_String_Int32_0;

		// Token: 0x04001F23 RID: 7971
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_String_String_String_0;

		// Token: 0x02000912 RID: 2322
		[Serializable]
		public class BoolValue : Object
		{
			// Token: 0x0600C605 RID: 50693 RVA: 0x00302134 File Offset: 0x00300334
			// Note: this type is marked as 'beforefieldinit'.
			static BoolValue()
			{
				Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "BoolValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr);
				GenericSaveData.BoolValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr, "key");
				GenericSaveData.BoolValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr, "value");
				GenericSaveData.BoolValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr, 100668748);
			}

			// Token: 0x0600C606 RID: 50694 RVA: 0x0030219C File Offset: 0x0030039C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BoolValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.BoolValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C607 RID: 50695 RVA: 0x00060625 File Offset: 0x0005E825
			public BoolValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DBB RID: 15803
			// (get) Token: 0x0600C608 RID: 50696 RVA: 0x003021D8 File Offset: 0x003003D8
			// (set) Token: 0x0600C609 RID: 50697 RVA: 0x0006062E File Offset: 0x0005E82E
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DBC RID: 15804
			// (get) Token: 0x0600C60A RID: 50698 RVA: 0x00302200 File Offset: 0x00300400
			// (set) Token: 0x0600C60B RID: 50699 RVA: 0x0006064D File Offset: 0x0005E84D
			public unsafe bool value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x0400861B RID: 34331
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400861C RID: 34332
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400861D RID: 34333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000913 RID: 2323
		[Serializable]
		public class FloatValue : Object
		{
			// Token: 0x0600C60C RID: 50700 RVA: 0x00302228 File Offset: 0x00300428
			// Note: this type is marked as 'beforefieldinit'.
			static FloatValue()
			{
				Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "FloatValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr);
				GenericSaveData.FloatValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr, "key");
				GenericSaveData.FloatValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr, "value");
				GenericSaveData.FloatValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr, 100668749);
			}

			// Token: 0x0600C60D RID: 50701 RVA: 0x00302290 File Offset: 0x00300490
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.FloatValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C60E RID: 50702 RVA: 0x00060668 File Offset: 0x0005E868
			public FloatValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DBD RID: 15805
			// (get) Token: 0x0600C60F RID: 50703 RVA: 0x003022CC File Offset: 0x003004CC
			// (set) Token: 0x0600C610 RID: 50704 RVA: 0x00060671 File Offset: 0x0005E871
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DBE RID: 15806
			// (get) Token: 0x0600C611 RID: 50705 RVA: 0x003022F4 File Offset: 0x003004F4
			// (set) Token: 0x0600C612 RID: 50706 RVA: 0x00060690 File Offset: 0x0005E890
			public unsafe float value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x0400861E RID: 34334
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400861F RID: 34335
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04008620 RID: 34336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000914 RID: 2324
		[Serializable]
		public class IntValue : Object
		{
			// Token: 0x0600C613 RID: 50707 RVA: 0x0030231C File Offset: 0x0030051C
			// Note: this type is marked as 'beforefieldinit'.
			static IntValue()
			{
				Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "IntValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr);
				GenericSaveData.IntValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr, "key");
				GenericSaveData.IntValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr, "value");
				GenericSaveData.IntValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr, 100668750);
			}

			// Token: 0x0600C614 RID: 50708 RVA: 0x00302384 File Offset: 0x00300584
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.IntValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C615 RID: 50709 RVA: 0x000606AB File Offset: 0x0005E8AB
			public IntValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DBF RID: 15807
			// (get) Token: 0x0600C616 RID: 50710 RVA: 0x003023C0 File Offset: 0x003005C0
			// (set) Token: 0x0600C617 RID: 50711 RVA: 0x000606B4 File Offset: 0x0005E8B4
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DC0 RID: 15808
			// (get) Token: 0x0600C618 RID: 50712 RVA: 0x003023E8 File Offset: 0x003005E8
			// (set) Token: 0x0600C619 RID: 50713 RVA: 0x000606D3 File Offset: 0x0005E8D3
			public unsafe int value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x04008621 RID: 34337
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008622 RID: 34338
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04008623 RID: 34339
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000915 RID: 2325
		[Serializable]
		public class StringValue : Object
		{
			// Token: 0x0600C61A RID: 50714 RVA: 0x00302410 File Offset: 0x00300610
			// Note: this type is marked as 'beforefieldinit'.
			static StringValue()
			{
				Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "StringValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr);
				GenericSaveData.StringValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr, "key");
				GenericSaveData.StringValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr, "value");
				GenericSaveData.StringValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr, 100668751);
			}

			// Token: 0x0600C61B RID: 50715 RVA: 0x00302478 File Offset: 0x00300678
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.StringValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C61C RID: 50716 RVA: 0x000606EE File Offset: 0x0005E8EE
			public StringValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DC1 RID: 15809
			// (get) Token: 0x0600C61D RID: 50717 RVA: 0x003024B4 File Offset: 0x003006B4
			// (set) Token: 0x0600C61E RID: 50718 RVA: 0x000606F7 File Offset: 0x0005E8F7
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DC2 RID: 15810
			// (get) Token: 0x0600C61F RID: 50719 RVA: 0x003024DC File Offset: 0x003006DC
			// (set) Token: 0x0600C620 RID: 50720 RVA: 0x00060716 File Offset: 0x0005E916
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008624 RID: 34340
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008625 RID: 34341
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04008626 RID: 34342
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000916 RID: 2326
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x0600C621 RID: 50721 RVA: 0x00302504 File Offset: 0x00300704
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass14_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr, 100668752);
				GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__GetBool_b__0_Internal_Boolean_BoolValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr, 100668753);
			}

			// Token: 0x0600C622 RID: 50722 RVA: 0x0030256C File Offset: 0x0030076C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C623 RID: 50723 RVA: 0x003025A8 File Offset: 0x003007A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBool_b__0(GenericSaveData.BoolValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__GetBool_b__0_Internal_Boolean_BoolValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C624 RID: 50724 RVA: 0x00060735 File Offset: 0x0005E935
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DC3 RID: 15811
			// (get) Token: 0x0600C625 RID: 50725 RVA: 0x003025F8 File Offset: 0x003007F8
			// (set) Token: 0x0600C626 RID: 50726 RVA: 0x0006073E File Offset: 0x0005E93E
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass14_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass14_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008627 RID: 34343
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008628 RID: 34344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008629 RID: 34345
			private static readonly IntPtr NativeMethodInfoPtr__GetBool_b__0_Internal_Boolean_BoolValue_0;
		}

		// Token: 0x02000917 RID: 2327
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x0600C627 RID: 50727 RVA: 0x00302620 File Offset: 0x00300820
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass15_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr, 100668754);
				GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__GetFloat_b__0_Internal_Boolean_FloatValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr, 100668755);
			}

			// Token: 0x0600C628 RID: 50728 RVA: 0x00302688 File Offset: 0x00300888
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C629 RID: 50729 RVA: 0x003026C4 File Offset: 0x003008C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFloat_b__0(GenericSaveData.FloatValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__GetFloat_b__0_Internal_Boolean_FloatValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C62A RID: 50730 RVA: 0x0006075D File Offset: 0x0005E95D
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DC4 RID: 15812
			// (get) Token: 0x0600C62B RID: 50731 RVA: 0x00302714 File Offset: 0x00300914
			// (set) Token: 0x0600C62C RID: 50732 RVA: 0x00060766 File Offset: 0x0005E966
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass15_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass15_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400862A RID: 34346
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400862B RID: 34347
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400862C RID: 34348
			private static readonly IntPtr NativeMethodInfoPtr__GetFloat_b__0_Internal_Boolean_FloatValue_0;
		}

		// Token: 0x02000918 RID: 2328
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Object
		{
			// Token: 0x0600C62D RID: 50733 RVA: 0x0030273C File Offset: 0x0030093C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass16_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr, 100668756);
				GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__GetInt_b__0_Internal_Boolean_IntValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr, 100668757);
			}

			// Token: 0x0600C62E RID: 50734 RVA: 0x003027A4 File Offset: 0x003009A4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C62F RID: 50735 RVA: 0x003027E0 File Offset: 0x003009E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetInt_b__0(GenericSaveData.IntValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__GetInt_b__0_Internal_Boolean_IntValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C630 RID: 50736 RVA: 0x00060785 File Offset: 0x0005E985
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DC5 RID: 15813
			// (get) Token: 0x0600C631 RID: 50737 RVA: 0x00302830 File Offset: 0x00300A30
			// (set) Token: 0x0600C632 RID: 50738 RVA: 0x0006078E File Offset: 0x0005E98E
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass16_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass16_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400862D RID: 34349
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400862E RID: 34350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400862F RID: 34351
			private static readonly IntPtr NativeMethodInfoPtr__GetInt_b__0_Internal_Boolean_IntValue_0;
		}

		// Token: 0x02000919 RID: 2329
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600C633 RID: 50739 RVA: 0x00302858 File Offset: 0x00300A58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass17_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr, 100668758);
				GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__GetString_b__0_Internal_Boolean_StringValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr, 100668759);
			}

			// Token: 0x0600C634 RID: 50740 RVA: 0x003028C0 File Offset: 0x00300AC0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C635 RID: 50741 RVA: 0x003028FC File Offset: 0x00300AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetString_b__0(GenericSaveData.StringValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__GetString_b__0_Internal_Boolean_StringValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C636 RID: 50742 RVA: 0x000607AD File Offset: 0x0005E9AD
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DC6 RID: 15814
			// (get) Token: 0x0600C637 RID: 50743 RVA: 0x0030294C File Offset: 0x00300B4C
			// (set) Token: 0x0600C638 RID: 50744 RVA: 0x000607B6 File Offset: 0x0005E9B6
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass17_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass17_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008630 RID: 34352
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008631 RID: 34353
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008632 RID: 34354
			private static readonly IntPtr NativeMethodInfoPtr__GetString_b__0_Internal_Boolean_StringValue_0;
		}
	}
}
