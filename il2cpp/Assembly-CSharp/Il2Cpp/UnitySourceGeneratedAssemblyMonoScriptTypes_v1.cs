using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000049 RID: 73
	public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
	{
		// Token: 0x0600061B RID: 1563 RVA: 0x00082890 File Offset: 0x00080A90
		// Note: this type is marked as 'beforefieldinit'.
		static UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
		{
			Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UnitySourceGeneratedAssemblyMonoScriptTypes_v1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr);
			UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, 100663866);
			UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, 100663867);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000828E8 File Offset: 0x00080AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75770, XrefRangeEnd = 75783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData(pointer);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00082914 File Offset: 0x00080B14
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitySourceGeneratedAssemblyMonoScriptTypes_v1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000059AF File Offset: 0x00003BAF
		public UnitySourceGeneratedAssemblyMonoScriptTypes_v1(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007C3 RID: 1987
		public sealed class MonoScriptData : ValueType
		{
			// Token: 0x0600BACE RID: 47822 RVA: 0x002E498C File Offset: 0x002E2B8C
			// Note: this type is marked as 'beforefieldinit'.
			static MonoScriptData()
			{
				Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, "MonoScriptData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr);
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "FilePathsData");
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TypesData");
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TotalTypes");
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TotalFiles");
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "IsEditorOnly");
			}

			// Token: 0x0600BACF RID: 47823 RVA: 0x0005B6DA File Offset: 0x000598DA
			public MonoScriptData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BAD0 RID: 47824 RVA: 0x0005B6E3 File Offset: 0x000598E3
			public MonoScriptData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr))
			{
			}

			// Token: 0x170039B1 RID: 14769
			// (get) Token: 0x0600BAD1 RID: 47825 RVA: 0x002E4A1C File Offset: 0x002E2C1C
			// (set) Token: 0x0600BAD2 RID: 47826 RVA: 0x0005B6F5 File Offset: 0x000598F5
			public unsafe Il2CppStructArray<byte> FilePathsData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170039B2 RID: 14770
			// (get) Token: 0x0600BAD3 RID: 47827 RVA: 0x002E4A4C File Offset: 0x002E2C4C
			// (set) Token: 0x0600BAD4 RID: 47828 RVA: 0x0005B714 File Offset: 0x00059914
			public unsafe Il2CppStructArray<byte> TypesData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170039B3 RID: 14771
			// (get) Token: 0x0600BAD5 RID: 47829 RVA: 0x002E4A7C File Offset: 0x002E2C7C
			// (set) Token: 0x0600BAD6 RID: 47830 RVA: 0x0005B733 File Offset: 0x00059933
			public unsafe int TotalTypes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes)) = value;
				}
			}

			// Token: 0x170039B4 RID: 14772
			// (get) Token: 0x0600BAD7 RID: 47831 RVA: 0x002E4AA4 File Offset: 0x002E2CA4
			// (set) Token: 0x0600BAD8 RID: 47832 RVA: 0x0005B74E File Offset: 0x0005994E
			public unsafe int TotalFiles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles)) = value;
				}
			}

			// Token: 0x170039B5 RID: 14773
			// (get) Token: 0x0600BAD9 RID: 47833 RVA: 0x002E4ACC File Offset: 0x002E2CCC
			// (set) Token: 0x0600BADA RID: 47834 RVA: 0x0005B769 File Offset: 0x00059969
			public unsafe bool IsEditorOnly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly)) = value;
				}
			}

			// Token: 0x04007DFE RID: 32254
			private static readonly IntPtr NativeFieldInfoPtr_FilePathsData;

			// Token: 0x04007DFF RID: 32255
			private static readonly IntPtr NativeFieldInfoPtr_TypesData;

			// Token: 0x04007E00 RID: 32256
			private static readonly IntPtr NativeFieldInfoPtr_TotalTypes;

			// Token: 0x04007E01 RID: 32257
			private static readonly IntPtr NativeFieldInfoPtr_TotalFiles;

			// Token: 0x04007E02 RID: 32258
			private static readonly IntPtr NativeFieldInfoPtr_IsEditorOnly;
		}
	}
}
