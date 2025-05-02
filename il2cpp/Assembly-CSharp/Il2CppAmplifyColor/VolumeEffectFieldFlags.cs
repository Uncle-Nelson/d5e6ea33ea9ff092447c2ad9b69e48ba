using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppAmplifyColor
{
	// Token: 0x0200079B RID: 1947
	[Serializable]
	public class VolumeEffectFieldFlags : Object
	{
		// Token: 0x0600B836 RID: 47158 RVA: 0x002DB6AC File Offset: 0x002D98AC
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeEffectFieldFlags()
		{
			Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VolumeEffectFieldFlags");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr);
			VolumeEffectFieldFlags.NativeFieldInfoPtr_fieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr, "fieldName");
			VolumeEffectFieldFlags.NativeFieldInfoPtr_fieldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr, "fieldType");
			VolumeEffectFieldFlags.NativeFieldInfoPtr_blendFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr, "blendFlag");
			VolumeEffectFieldFlags.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr, 100685936);
			VolumeEffectFieldFlags.NativeMethodInfoPtr__ctor_Public_Void_VolumeEffectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr, 100685937);
		}

		// Token: 0x0600B837 RID: 47159 RVA: 0x002DB740 File Offset: 0x002D9940
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313737, RefRangeEnd = 313739, XrefRangeStart = 313733, XrefRangeEnd = 313737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectFieldFlags(FieldInfo pi) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFieldFlags.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B838 RID: 47160 RVA: 0x002DB78C File Offset: 0x002D998C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313739, XrefRangeEnd = 313742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectFieldFlags(VolumeEffectField field) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFieldFlags.NativeMethodInfoPtr__ctor_Public_Void_VolumeEffectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B839 RID: 47161 RVA: 0x0005A6B5 File Offset: 0x000588B5
		public VolumeEffectFieldFlags(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x0600B83A RID: 47162 RVA: 0x002DB7D8 File Offset: 0x002D99D8
		// (set) Token: 0x0600B83B RID: 47163 RVA: 0x0005A6BE File Offset: 0x000588BE
		public unsafe string fieldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFieldFlags.NativeFieldInfoPtr_fieldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFieldFlags.NativeFieldInfoPtr_fieldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003912 RID: 14610
		// (get) Token: 0x0600B83C RID: 47164 RVA: 0x002DB800 File Offset: 0x002D9A00
		// (set) Token: 0x0600B83D RID: 47165 RVA: 0x0005A6DD File Offset: 0x000588DD
		public unsafe string fieldType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFieldFlags.NativeFieldInfoPtr_fieldType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFieldFlags.NativeFieldInfoPtr_fieldType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x0600B83E RID: 47166 RVA: 0x002DB828 File Offset: 0x002D9A28
		// (set) Token: 0x0600B83F RID: 47167 RVA: 0x0005A6FC File Offset: 0x000588FC
		public unsafe bool blendFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFieldFlags.NativeFieldInfoPtr_blendFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFieldFlags.NativeFieldInfoPtr_blendFlag)) = value;
			}
		}

		// Token: 0x04007C1F RID: 31775
		private static readonly IntPtr NativeFieldInfoPtr_fieldName;

		// Token: 0x04007C20 RID: 31776
		private static readonly IntPtr NativeFieldInfoPtr_fieldType;

		// Token: 0x04007C21 RID: 31777
		private static readonly IntPtr NativeFieldInfoPtr_blendFlag;

		// Token: 0x04007C22 RID: 31778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_0;

		// Token: 0x04007C23 RID: 31779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VolumeEffectField_0;
	}
}
