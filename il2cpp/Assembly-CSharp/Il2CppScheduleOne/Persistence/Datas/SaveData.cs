using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B3 RID: 691
	[Serializable]
	public class SaveData : Object
	{
		// Token: 0x060031AC RID: 12716 RVA: 0x0010E1C0 File Offset: 0x0010C3C0
		// Note: this type is marked as 'beforefieldinit'.
		static SaveData()
		{
			Il2CppClassPointerStore<SaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveData>.NativeClassPtr);
			SaveData.NativeFieldInfoPtr_DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "DataType");
			SaveData.NativeFieldInfoPtr_DataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "DataVersion");
			SaveData.NativeFieldInfoPtr_GameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "GameVersion");
			SaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100668845);
			SaveData.NativeMethodInfoPtr_GetDataVersion_Protected_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100668846);
			SaveData.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100668847);
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x0010E268 File Offset: 0x0010C468
		[CallerCount(104)]
		[CachedScanResults(RefRangeStart = 131167, RefRangeEnd = 131271, XrefRangeStart = 131153, XrefRangeEnd = 131167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x0010E2A4 File Offset: 0x0010C4A4
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 31227, RefRangeEnd = 31292, XrefRangeStart = 31227, XrefRangeEnd = 31292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetDataVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveData.NativeMethodInfoPtr_GetDataVersion_Protected_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x0010E2EC File Offset: 0x0010C4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131271, XrefRangeEnd = 131283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetJson(bool prettyPrint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveData.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x0001A994 File Offset: 0x00018B94
		public SaveData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x0010E33C File Offset: 0x0010C53C
		// (set) Token: 0x060031B2 RID: 12722 RVA: 0x0001A99D File Offset: 0x00018B9D
		public unsafe string DataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x060031B3 RID: 12723 RVA: 0x0010E364 File Offset: 0x0010C564
		// (set) Token: 0x060031B4 RID: 12724 RVA: 0x0001A9BC File Offset: 0x00018BBC
		public unsafe int DataVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataVersion)) = value;
			}
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x0010E38C File Offset: 0x0010C58C
		// (set) Token: 0x060031B6 RID: 12726 RVA: 0x0001A9D7 File Offset: 0x00018BD7
		public unsafe string GameVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_GameVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_GameVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeFieldInfoPtr_DataType;

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeFieldInfoPtr_DataVersion;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeFieldInfoPtr_GameVersion;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeMethodInfoPtr_GetDataVersion_Protected_Virtual_New_Int32_0;

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0;
	}
}
