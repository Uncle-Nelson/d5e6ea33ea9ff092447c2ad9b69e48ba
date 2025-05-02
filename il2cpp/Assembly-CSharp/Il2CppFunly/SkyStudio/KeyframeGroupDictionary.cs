using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200011F RID: 287
	[Serializable]
	public class KeyframeGroupDictionary : Object
	{
		// Token: 0x06001878 RID: 6264 RVA: 0x000BCAE0 File Offset: 0x000BACE0
		// Note: this type is marked as 'beforefieldinit'.
		static KeyframeGroupDictionary()
		{
			Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "KeyframeGroupDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr);
			KeyframeGroupDictionary.NativeFieldInfoPtr_m_Groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, "m_Groups");
			KeyframeGroupDictionary.NativeFieldInfoPtr_m_ColorGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, "m_ColorGroup");
			KeyframeGroupDictionary.NativeFieldInfoPtr_m_NumberGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, "m_NumberGroup");
			KeyframeGroupDictionary.NativeFieldInfoPtr_m_TextureGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, "m_TextureGroup");
			KeyframeGroupDictionary.NativeFieldInfoPtr_m_SpherePointGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, "m_SpherePointGroup");
			KeyframeGroupDictionary.NativeFieldInfoPtr_m_BoolGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, "m_BoolGroup");
			KeyframeGroupDictionary.NativeMethodInfoPtr_get_Item_Public_get_IKeyframeGroup_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665897);
			KeyframeGroupDictionary.NativeMethodInfoPtr_set_Item_Public_set_Void_String_IKeyframeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665898);
			KeyframeGroupDictionary.NativeMethodInfoPtr_ContainsKey_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665899);
			KeyframeGroupDictionary.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665900);
			KeyframeGroupDictionary.NativeMethodInfoPtr_GetGroup_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665901);
			KeyframeGroupDictionary.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665902);
			KeyframeGroupDictionary.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665903);
			KeyframeGroupDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665904);
			KeyframeGroupDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665905);
			KeyframeGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665906);
		}

		// Token: 0x170008C8 RID: 2248
		public unsafe IKeyframeGroup this[string aKey]
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 95308, RefRangeEnd = 95316, XrefRangeStart = 95304, XrefRangeEnd = 95308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_get_Item_Public_get_IKeyframeGroup_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IKeyframeGroup>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 95320, RefRangeEnd = 95325, XrefRangeStart = 95316, XrefRangeEnd = 95320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_set_Item_Public_set_Void_String_IKeyframeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x000BCCF4 File Offset: 0x000BAEF4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 95329, RefRangeEnd = 95335, XrefRangeStart = 95325, XrefRangeEnd = 95329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_ContainsKey_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x000BCD44 File Offset: 0x000BAF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95335, XrefRangeEnd = 95339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x000BCD78 File Offset: 0x000BAF78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95377, RefRangeEnd = 95378, XrefRangeStart = 95339, XrefRangeEnd = 95377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetGroup<T>(string propertyName) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.MethodInfoStoreGeneric_GetGroup_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x000BCDC4 File Offset: 0x000BAFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95378, XrefRangeEnd = 95446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x000BCDF8 File Offset: 0x000BAFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95446, XrefRangeEnd = 95560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000BCE2C File Offset: 0x000BB02C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95569, RefRangeEnd = 95570, XrefRangeStart = 95560, XrefRangeEnd = 95569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<string> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x000BCE6C File Offset: 0x000BB06C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95569, RefRangeEnd = 95570, XrefRangeStart = 95569, XrefRangeEnd = 95570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x000BCEAC File Offset: 0x000BB0AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95603, RefRangeEnd = 95604, XrefRangeStart = 95570, XrefRangeEnd = 95603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyframeGroupDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0000E136 File Offset: 0x0000C336
		public KeyframeGroupDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x000BCEE8 File Offset: 0x000BB0E8
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x0000E13F File Offset: 0x0000C33F
		public unsafe Dictionary<string, IKeyframeGroup> m_Groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_Groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, IKeyframeGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_Groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x000BCF18 File Offset: 0x000BB118
		// (set) Token: 0x06001887 RID: 6279 RVA: 0x0000E15E File Offset: 0x0000C35E
		public unsafe ColorGroupDictionary m_ColorGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_ColorGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGroupDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_ColorGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x000BCF48 File Offset: 0x000BB148
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x0000E17D File Offset: 0x0000C37D
		public unsafe NumberGroupDictionary m_NumberGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_NumberGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberGroupDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_NumberGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x000BCF78 File Offset: 0x000BB178
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x0000E19C File Offset: 0x0000C39C
		public unsafe TextureGroupDictionary m_TextureGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_TextureGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureGroupDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_TextureGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x000BCFA8 File Offset: 0x000BB1A8
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x0000E1BB File Offset: 0x0000C3BB
		public unsafe SpherePointGroupDictionary m_SpherePointGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_SpherePointGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpherePointGroupDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_SpherePointGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x000BCFD8 File Offset: 0x000BB1D8
		// (set) Token: 0x0600188F RID: 6287 RVA: 0x0000E1DA File Offset: 0x0000C3DA
		public unsafe BoolGroupDictionary m_BoolGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_BoolGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolGroupDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_BoolGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeFieldInfoPtr_m_Groups;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGroup;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeFieldInfoPtr_m_NumberGroup;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeFieldInfoPtr_m_TextureGroup;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeFieldInfoPtr_m_SpherePointGroup;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeFieldInfoPtr_m_BoolGroup;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_IKeyframeGroup_String_0;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_String_IKeyframeGroup_0;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Boolean_String_0;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_GetGroup_Public_T_String_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000857 RID: 2135
		private sealed class MethodInfoStoreGeneric_GetGroup_Public_T_String_0<T>
		{
			// Token: 0x04008264 RID: 33380
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(KeyframeGroupDictionary.NativeMethodInfoPtr_GetGroup_Public_T_String_0, Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
