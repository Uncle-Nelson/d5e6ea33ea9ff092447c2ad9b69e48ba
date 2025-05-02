using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026A RID: 618
	[Serializable]
	public class QualityItemData : ItemData
	{
		// Token: 0x06002F45 RID: 12101 RVA: 0x001073E4 File Offset: 0x001055E4
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemData()
		{
			Il2CppClassPointerStore<QualityItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QualityItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemData>.NativeClassPtr);
			QualityItemData.NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemData>.NativeClassPtr, "Quality");
			QualityItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemData>.NativeClassPtr, 100668768);
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x0010743C File Offset: 0x0010563C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130546, RefRangeEnd = 130552, XrefRangeStart = 130546, XrefRangeEnd = 130552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemData(string iD, int quantity, string quality) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x0001902E File Offset: 0x0001722E
		public QualityItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06002F48 RID: 12104 RVA: 0x001074A8 File Offset: 0x001056A8
		// (set) Token: 0x06002F49 RID: 12105 RVA: 0x00019037 File Offset: 0x00017237
		public unsafe string Quality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemData.NativeFieldInfoPtr_Quality);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemData.NativeFieldInfoPtr_Quality), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeFieldInfoPtr_Quality;

		// Token: 0x04001F33 RID: 7987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_0;
	}
}
