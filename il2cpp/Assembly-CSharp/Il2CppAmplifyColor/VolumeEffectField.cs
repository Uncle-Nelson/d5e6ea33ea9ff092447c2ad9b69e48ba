using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppAmplifyColor
{
	// Token: 0x02000797 RID: 1943
	[Serializable]
	public class VolumeEffectField : Il2CppSystem.Object
	{
		// Token: 0x0600B7F7 RID: 47095 RVA: 0x002DA788 File Offset: 0x002D8988
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeEffectField()
		{
			Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VolumeEffectField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr);
			VolumeEffectField.NativeFieldInfoPtr_fieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "fieldName");
			VolumeEffectField.NativeFieldInfoPtr_fieldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "fieldType");
			VolumeEffectField.NativeFieldInfoPtr_valueSingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "valueSingle");
			VolumeEffectField.NativeFieldInfoPtr_valueColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "valueColor");
			VolumeEffectField.NativeFieldInfoPtr_valueBoolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "valueBoolean");
			VolumeEffectField.NativeFieldInfoPtr_valueVector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "valueVector2");
			VolumeEffectField.NativeFieldInfoPtr_valueVector3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "valueVector3");
			VolumeEffectField.NativeFieldInfoPtr_valueVector4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "valueVector4");
			VolumeEffectField.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, 100685894);
			VolumeEffectField.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, 100685895);
			VolumeEffectField.NativeMethodInfoPtr_IsValidType_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, 100685896);
			VolumeEffectField.NativeMethodInfoPtr_UpdateValue_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, 100685897);
		}

		// Token: 0x0600B7F8 RID: 47096 RVA: 0x002DA8A8 File Offset: 0x002D8AA8
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 110734, RefRangeEnd = 110783, XrefRangeStart = 110734, XrefRangeEnd = 110783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectField(string fieldName, string fieldType) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectField.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7F9 RID: 47097 RVA: 0x002DA908 File Offset: 0x002D8B08
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 313077, RefRangeEnd = 313081, XrefRangeStart = 313072, XrefRangeEnd = 313077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectField(FieldInfo pi, Component c) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectField.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7FA RID: 47098 RVA: 0x002DA968 File Offset: 0x002D8B68
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 313099, RefRangeEnd = 313108, XrefRangeStart = 313081, XrefRangeEnd = 313099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidType(string type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectField.NativeMethodInfoPtr_IsValidType_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B7FB RID: 47099 RVA: 0x002DA9AC File Offset: 0x002D8BAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313124, RefRangeEnd = 313125, XrefRangeStart = 313108, XrefRangeEnd = 313124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValue(Il2CppSystem.Object val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectField.NativeMethodInfoPtr_UpdateValue_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7FC RID: 47100 RVA: 0x0005A516 File Offset: 0x00058716
		public VolumeEffectField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x0600B7FD RID: 47101 RVA: 0x002DA9F0 File Offset: 0x002D8BF0
		// (set) Token: 0x0600B7FE RID: 47102 RVA: 0x0005A51F File Offset: 0x0005871F
		public unsafe string fieldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_fieldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_fieldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x0600B7FF RID: 47103 RVA: 0x002DAA18 File Offset: 0x002D8C18
		// (set) Token: 0x0600B800 RID: 47104 RVA: 0x0005A53E File Offset: 0x0005873E
		public unsafe string fieldType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_fieldType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_fieldType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x0600B801 RID: 47105 RVA: 0x002DAA40 File Offset: 0x002D8C40
		// (set) Token: 0x0600B802 RID: 47106 RVA: 0x0005A55D File Offset: 0x0005875D
		public unsafe float valueSingle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueSingle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueSingle)) = value;
			}
		}

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x0600B803 RID: 47107 RVA: 0x002DAA68 File Offset: 0x002D8C68
		// (set) Token: 0x0600B804 RID: 47108 RVA: 0x0005A578 File Offset: 0x00058778
		public unsafe Color valueColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueColor)) = value;
			}
		}

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x0600B805 RID: 47109 RVA: 0x002DAA90 File Offset: 0x002D8C90
		// (set) Token: 0x0600B806 RID: 47110 RVA: 0x0005A593 File Offset: 0x00058793
		public unsafe bool valueBoolean
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueBoolean);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueBoolean)) = value;
			}
		}

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x0600B807 RID: 47111 RVA: 0x002DAAB8 File Offset: 0x002D8CB8
		// (set) Token: 0x0600B808 RID: 47112 RVA: 0x0005A5AE File Offset: 0x000587AE
		public unsafe Vector2 valueVector2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueVector2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueVector2)) = value;
			}
		}

		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x0600B809 RID: 47113 RVA: 0x002DAAE0 File Offset: 0x002D8CE0
		// (set) Token: 0x0600B80A RID: 47114 RVA: 0x0005A5C9 File Offset: 0x000587C9
		public unsafe Vector3 valueVector3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueVector3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueVector3)) = value;
			}
		}

		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x0600B80B RID: 47115 RVA: 0x002DAB08 File Offset: 0x002D8D08
		// (set) Token: 0x0600B80C RID: 47116 RVA: 0x0005A5E4 File Offset: 0x000587E4
		public unsafe Vector4 valueVector4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueVector4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueVector4)) = value;
			}
		}

		// Token: 0x04007BF5 RID: 31733
		private static readonly IntPtr NativeFieldInfoPtr_fieldName;

		// Token: 0x04007BF6 RID: 31734
		private static readonly IntPtr NativeFieldInfoPtr_fieldType;

		// Token: 0x04007BF7 RID: 31735
		private static readonly IntPtr NativeFieldInfoPtr_valueSingle;

		// Token: 0x04007BF8 RID: 31736
		private static readonly IntPtr NativeFieldInfoPtr_valueColor;

		// Token: 0x04007BF9 RID: 31737
		private static readonly IntPtr NativeFieldInfoPtr_valueBoolean;

		// Token: 0x04007BFA RID: 31738
		private static readonly IntPtr NativeFieldInfoPtr_valueVector2;

		// Token: 0x04007BFB RID: 31739
		private static readonly IntPtr NativeFieldInfoPtr_valueVector3;

		// Token: 0x04007BFC RID: 31740
		private static readonly IntPtr NativeFieldInfoPtr_valueVector4;

		// Token: 0x04007BFD RID: 31741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04007BFE RID: 31742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_Component_0;

		// Token: 0x04007BFF RID: 31743
		private static readonly IntPtr NativeMethodInfoPtr_IsValidType_Public_Static_Boolean_String_0;

		// Token: 0x04007C00 RID: 31744
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Public_Void_Object_0;
	}
}
