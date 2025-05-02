using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000283 RID: 643
	[Serializable]
	public class QualityFieldData : Object
	{
		// Token: 0x06002FE7 RID: 12263 RVA: 0x00108ECC File Offset: 0x001070CC
		// Note: this type is marked as 'beforefieldinit'.
		static QualityFieldData()
		{
			Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QualityFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr);
			QualityFieldData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr, "Value");
			QualityFieldData.NativeMethodInfoPtr__ctor_Public_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr, 100668794);
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x00108F24 File Offset: 0x00107124
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityFieldData(EQuality value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldData.NativeMethodInfoPtr__ctor_Public_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x00019659 File Offset: 0x00017859
		public QualityFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06002FEA RID: 12266 RVA: 0x00108F6C File Offset: 0x0010716C
		// (set) Token: 0x06002FEB RID: 12267 RVA: 0x00019662 File Offset: 0x00017862
		public unsafe EQuality Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldData.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldData.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x04001F77 RID: 8055
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EQuality_0;
	}
}
