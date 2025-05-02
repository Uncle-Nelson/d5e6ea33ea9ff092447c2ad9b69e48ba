using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppAmplifyColor
{
	// Token: 0x02000798 RID: 1944
	[Serializable]
	public class VolumeEffectComponent : Il2CppSystem.Object
	{
		// Token: 0x0600B80D RID: 47117 RVA: 0x002DAB30 File Offset: 0x002D8D30
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeEffectComponent()
		{
			Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VolumeEffectComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr);
			VolumeEffectComponent.NativeFieldInfoPtr_componentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, "componentName");
			VolumeEffectComponent.NativeFieldInfoPtr_fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, "fields");
			VolumeEffectComponent.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685898);
			VolumeEffectComponent.NativeMethodInfoPtr_AddField_Public_VolumeEffectField_FieldInfo_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685899);
			VolumeEffectComponent.NativeMethodInfoPtr_AddField_Public_VolumeEffectField_FieldInfo_Component_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685900);
			VolumeEffectComponent.NativeMethodInfoPtr_RemoveEffectField_Public_Void_VolumeEffectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685901);
			VolumeEffectComponent.NativeMethodInfoPtr__ctor_Public_Void_Component_VolumeEffectComponentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685902);
			VolumeEffectComponent.NativeMethodInfoPtr_UpdateComponent_Public_Void_Component_VolumeEffectComponentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685903);
			VolumeEffectComponent.NativeMethodInfoPtr_FindEffectField_Public_VolumeEffectField_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685904);
			VolumeEffectComponent.NativeMethodInfoPtr_ListAcceptableFields_Public_Static_Il2CppReferenceArray_1_FieldInfo_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685905);
			VolumeEffectComponent.NativeMethodInfoPtr_GetFieldNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685906);
		}

		// Token: 0x0600B80E RID: 47118 RVA: 0x002DAC3C File Offset: 0x002D8E3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313136, RefRangeEnd = 313138, XrefRangeStart = 313127, XrefRangeEnd = 313136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponent(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B80F RID: 47119 RVA: 0x002DAC88 File Offset: 0x002D8E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313138, XrefRangeEnd = 313149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectField AddField(FieldInfo pi, Component c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr_AddField_Public_VolumeEffectField_FieldInfo_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffectField>(intPtr3) : null;
		}

		// Token: 0x0600B810 RID: 47120 RVA: 0x002DACEC File Offset: 0x002D8EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313149, XrefRangeEnd = 313163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectField AddField(FieldInfo pi, Component c, int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr_AddField_Public_VolumeEffectField_FieldInfo_Component_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffectField>(intPtr3) : null;
		}

		// Token: 0x0600B811 RID: 47121 RVA: 0x002DAD5C File Offset: 0x002D8F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313163, XrefRangeEnd = 313167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEffectField(VolumeEffectField field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr_RemoveEffectField_Public_Void_VolumeEffectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B812 RID: 47122 RVA: 0x002DADA0 File Offset: 0x002D8FA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313192, RefRangeEnd = 313193, XrefRangeStart = 313167, XrefRangeEnd = 313192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponent(Component c, VolumeEffectComponentFlags compFlags) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compFlags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr__ctor_Public_Void_Component_VolumeEffectComponentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B813 RID: 47123 RVA: 0x002DAE00 File Offset: 0x002D9000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313193, XrefRangeEnd = 313231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateComponent(Component c, VolumeEffectComponentFlags compFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compFlags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr_UpdateComponent_Public_Void_Component_VolumeEffectComponentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B814 RID: 47124 RVA: 0x002DAE54 File Offset: 0x002D9054
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 313239, RefRangeEnd = 313244, XrefRangeStart = 313231, XrefRangeEnd = 313239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectField FindEffectField(string fieldName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr_FindEffectField_Public_VolumeEffectField_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffectField>(intPtr3) : null;
		}

		// Token: 0x0600B815 RID: 47125 RVA: 0x002DAEA4 File Offset: 0x002D90A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313244, XrefRangeEnd = 313275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<FieldInfo> ListAcceptableFields(Component c)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr_ListAcceptableFields_Public_Static_Il2CppReferenceArray_1_FieldInfo_Component_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FieldInfo>>(intPtr3) : null;
		}

		// Token: 0x0600B816 RID: 47126 RVA: 0x002DAEE8 File Offset: 0x002D90E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313275, XrefRangeEnd = 313296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetFieldNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr_GetFieldNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600B817 RID: 47127 RVA: 0x0005A5FF File Offset: 0x000587FF
		public VolumeEffectComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x0600B818 RID: 47128 RVA: 0x002DAF28 File Offset: 0x002D9128
		// (set) Token: 0x0600B819 RID: 47129 RVA: 0x0005A608 File Offset: 0x00058808
		public unsafe string componentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponent.NativeFieldInfoPtr_componentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponent.NativeFieldInfoPtr_componentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x0600B81A RID: 47130 RVA: 0x002DAF50 File Offset: 0x002D9150
		// (set) Token: 0x0600B81B RID: 47131 RVA: 0x0005A627 File Offset: 0x00058827
		public unsafe List<VolumeEffectField> fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponent.NativeFieldInfoPtr_fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VolumeEffectField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponent.NativeFieldInfoPtr_fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C01 RID: 31745
		private static readonly IntPtr NativeFieldInfoPtr_componentName;

		// Token: 0x04007C02 RID: 31746
		private static readonly IntPtr NativeFieldInfoPtr_fields;

		// Token: 0x04007C03 RID: 31747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04007C04 RID: 31748
		private static readonly IntPtr NativeMethodInfoPtr_AddField_Public_VolumeEffectField_FieldInfo_Component_0;

		// Token: 0x04007C05 RID: 31749
		private static readonly IntPtr NativeMethodInfoPtr_AddField_Public_VolumeEffectField_FieldInfo_Component_Int32_0;

		// Token: 0x04007C06 RID: 31750
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEffectField_Public_Void_VolumeEffectField_0;

		// Token: 0x04007C07 RID: 31751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Component_VolumeEffectComponentFlags_0;

		// Token: 0x04007C08 RID: 31752
		private static readonly IntPtr NativeMethodInfoPtr_UpdateComponent_Public_Void_Component_VolumeEffectComponentFlags_0;

		// Token: 0x04007C09 RID: 31753
		private static readonly IntPtr NativeMethodInfoPtr_FindEffectField_Public_VolumeEffectField_String_0;

		// Token: 0x04007C0A RID: 31754
		private static readonly IntPtr NativeMethodInfoPtr_ListAcceptableFields_Public_Static_Il2CppReferenceArray_1_FieldInfo_Component_0;

		// Token: 0x04007C0B RID: 31755
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldNames_Public_Il2CppStringArray_0;

		// Token: 0x02000C0C RID: 3084
		[ObfuscatedName("AmplifyColor.VolumeEffectComponent+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E056 RID: 57430 RVA: 0x0034D2AC File Offset: 0x0034B4AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr);
				VolumeEffectComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr, "<>9");
				VolumeEffectComponent.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr, "<>9__9_0");
				VolumeEffectComponent.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr, "<>9__10_0");
				VolumeEffectComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr, 100685908);
				VolumeEffectComponent.__c.NativeMethodInfoPtr__ListAcceptableFields_b__9_0_Internal_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr, 100685909);
				VolumeEffectComponent.__c.NativeMethodInfoPtr__GetFieldNames_b__10_0_Internal_String_VolumeEffectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr, 100685910);
			}

			// Token: 0x0600E057 RID: 57431 RVA: 0x0034D350 File Offset: 0x0034B550
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E058 RID: 57432 RVA: 0x0034D38C File Offset: 0x0034B58C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313125, XrefRangeEnd = 313127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ListAcceptableFields_b__9_0(FieldInfo f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.__c.NativeMethodInfoPtr__ListAcceptableFields_b__9_0_Internal_Boolean_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E059 RID: 57433 RVA: 0x0034D3DC File Offset: 0x0034B5DC
			[CallerCount(0)]
			public unsafe string _GetFieldNames_b__10_0(VolumeEffectField r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.__c.NativeMethodInfoPtr__GetFieldNames_b__10_0_Internal_String_VolumeEffectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E05A RID: 57434 RVA: 0x0006D5C7 File Offset: 0x0006B7C7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004583 RID: 17795
			// (get) Token: 0x0600E05B RID: 57435 RVA: 0x0034D424 File Offset: 0x0034B624
			// (set) Token: 0x0600E05C RID: 57436 RVA: 0x0006D5D0 File Offset: 0x0006B7D0
			public unsafe static VolumeEffectComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004584 RID: 17796
			// (get) Token: 0x0600E05D RID: 57437 RVA: 0x0034D44C File Offset: 0x0034B64C
			// (set) Token: 0x0600E05E RID: 57438 RVA: 0x0006D5E2 File Offset: 0x0006B7E2
			public unsafe static Func<FieldInfo, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectComponent.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectComponent.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004585 RID: 17797
			// (get) Token: 0x0600E05F RID: 57439 RVA: 0x0034D474 File Offset: 0x0034B674
			// (set) Token: 0x0600E060 RID: 57440 RVA: 0x0006D5F4 File Offset: 0x0006B7F4
			public unsafe static Func<VolumeEffectField, string> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectComponent.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VolumeEffectField, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectComponent.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009649 RID: 38473
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400964A RID: 38474
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400964B RID: 38475
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400964C RID: 38476
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400964D RID: 38477
			private static readonly IntPtr NativeMethodInfoPtr__ListAcceptableFields_b__9_0_Internal_Boolean_FieldInfo_0;

			// Token: 0x0400964E RID: 38478
			private static readonly IntPtr NativeMethodInfoPtr__GetFieldNames_b__10_0_Internal_String_VolumeEffectField_0;
		}

		// Token: 0x02000C0D RID: 3085
		[ObfuscatedName("AmplifyColor.VolumeEffectComponent+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E061 RID: 57441 RVA: 0x0034D49C File Offset: 0x0034B69C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<VolumeEffectComponent.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectComponent.__c__DisplayClass7_0>.NativeClassPtr);
				VolumeEffectComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_fieldFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponent.__c__DisplayClass7_0>.NativeClassPtr, "fieldFlags");
				VolumeEffectComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent.__c__DisplayClass7_0>.NativeClassPtr, 100685911);
				VolumeEffectComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateComponent_b__0_Internal_Boolean_VolumeEffectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent.__c__DisplayClass7_0>.NativeClassPtr, 100685912);
			}

			// Token: 0x0600E062 RID: 57442 RVA: 0x0034D504 File Offset: 0x0034B704
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponent.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E063 RID: 57443 RVA: 0x0034D540 File Offset: 0x0034B740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateComponent_b__0(VolumeEffectField s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateComponent_b__0_Internal_Boolean_VolumeEffectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E064 RID: 57444 RVA: 0x0006D606 File Offset: 0x0006B806
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004586 RID: 17798
			// (get) Token: 0x0600E065 RID: 57445 RVA: 0x0034D590 File Offset: 0x0034B790
			// (set) Token: 0x0600E066 RID: 57446 RVA: 0x0006D60F File Offset: 0x0006B80F
			public unsafe VolumeEffectFieldFlags fieldFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_fieldFlags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectFieldFlags>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_fieldFlags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400964F RID: 38479
			private static readonly IntPtr NativeFieldInfoPtr_fieldFlags;

			// Token: 0x04009650 RID: 38480
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009651 RID: 38481
			private static readonly IntPtr NativeMethodInfoPtr__UpdateComponent_b__0_Internal_Boolean_VolumeEffectField_0;
		}
	}
}
