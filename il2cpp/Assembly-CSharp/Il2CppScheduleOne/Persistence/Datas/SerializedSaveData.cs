using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B4 RID: 692
	[Serializable]
	public class SerializedSaveData : Object
	{
		// Token: 0x060031B7 RID: 12727 RVA: 0x0010E3B4 File Offset: 0x0010C5B4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSaveData()
		{
			Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SerializedSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr);
			SerializedSaveData.NativeFieldInfoPtr__DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "_DataType");
			SerializedSaveData.NativeFieldInfoPtr_DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "DataType");
			SerializedSaveData.NativeFieldInfoPtr__DataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "_DataVersion");
			SerializedSaveData.NativeFieldInfoPtr_DataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "DataVersion");
			SerializedSaveData.NativeMethodInfoPtr_get_Version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, 100668848);
			SerializedSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, 100668849);
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x060031B8 RID: 12728 RVA: 0x0010E45C File Offset: 0x0010C65C
		public unsafe string Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131283, XrefRangeEnd = 131287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSaveData.NativeMethodInfoPtr_get_Version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x0010E494 File Offset: 0x0010C694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131287, XrefRangeEnd = 131292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSaveData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x0001A9F6 File Offset: 0x00018BF6
		public SerializedSaveData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x0010E4D0 File Offset: 0x0010C6D0
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x0001A9FF File Offset: 0x00018BFF
		public unsafe static string _DataType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializedSaveData.NativeFieldInfoPtr__DataType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedSaveData.NativeFieldInfoPtr__DataType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x060031BD RID: 12733 RVA: 0x0010E4F0 File Offset: 0x0010C6F0
		// (set) Token: 0x060031BE RID: 12734 RVA: 0x0001AA11 File Offset: 0x00018C11
		public unsafe string DataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x060031BF RID: 12735 RVA: 0x0010E518 File Offset: 0x0010C718
		// (set) Token: 0x060031C0 RID: 12736 RVA: 0x0001AA30 File Offset: 0x00018C30
		public unsafe static int _DataVersion
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SerializedSaveData.NativeFieldInfoPtr__DataVersion, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedSaveData.NativeFieldInfoPtr__DataVersion, (void*)(&value));
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x060031C1 RID: 12737 RVA: 0x0010E534 File Offset: 0x0010C734
		// (set) Token: 0x060031C2 RID: 12738 RVA: 0x0001AA3E File Offset: 0x00018C3E
		public unsafe int DataVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataVersion)) = value;
			}
		}

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeFieldInfoPtr__DataType;

		// Token: 0x0400204A RID: 8266
		private static readonly IntPtr NativeFieldInfoPtr_DataType;

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeFieldInfoPtr__DataVersion;

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeFieldInfoPtr_DataVersion;

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_String_0;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
