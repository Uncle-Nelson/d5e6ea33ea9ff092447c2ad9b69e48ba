using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000159 RID: 345
	[Serializable]
	public class CharacterBlendshapeData : Object
	{
		// Token: 0x06001C1D RID: 7197 RVA: 0x000C7D9C File Offset: 0x000C5F9C
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterBlendshapeData()
		{
			Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterBlendshapeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr);
			CharacterBlendshapeData.NativeFieldInfoPtr_blendshapeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr, "blendshapeName");
			CharacterBlendshapeData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr, "type");
			CharacterBlendshapeData.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr, "group");
			CharacterBlendshapeData.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr, "value");
			CharacterBlendshapeData.NativeMethodInfoPtr__ctor_Public_Void_String_CharacterBlendShapeType_CharacterBlendShapeGroup_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr, 100666238);
			CharacterBlendshapeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr, 100666239);
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x000C7E44 File Offset: 0x000C6044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100611, RefRangeEnd = 100613, XrefRangeStart = 100609, XrefRangeEnd = 100611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterBlendshapeData(string name, CharacterBlendShapeType t, CharacterBlendShapeGroup g, float value = 0f) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterBlendshapeData.NativeMethodInfoPtr__ctor_Public_Void_String_CharacterBlendShapeType_CharacterBlendShapeGroup_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x000C7EBC File Offset: 0x000C60BC
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterBlendshapeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterBlendshapeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00010050 File Offset: 0x0000E250
		public CharacterBlendshapeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x000C7EF8 File Offset: 0x000C60F8
		// (set) Token: 0x06001C22 RID: 7202 RVA: 0x00010059 File Offset: 0x0000E259
		public unsafe string blendshapeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_blendshapeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_blendshapeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x000C7F20 File Offset: 0x000C6120
		// (set) Token: 0x06001C24 RID: 7204 RVA: 0x00010078 File Offset: 0x0000E278
		public unsafe CharacterBlendShapeType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x000C7F48 File Offset: 0x000C6148
		// (set) Token: 0x06001C26 RID: 7206 RVA: 0x00010093 File Offset: 0x0000E293
		public unsafe CharacterBlendShapeGroup group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_group);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_group)) = value;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x000C7F70 File Offset: 0x000C6170
		// (set) Token: 0x06001C28 RID: 7208 RVA: 0x000100AE File Offset: 0x0000E2AE
		public unsafe float value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeFieldInfoPtr_blendshapeName;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeFieldInfoPtr_group;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_CharacterBlendShapeType_CharacterBlendShapeGroup_Single_0;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
