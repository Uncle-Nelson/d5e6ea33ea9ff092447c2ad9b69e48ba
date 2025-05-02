using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000277 RID: 631
	[Serializable]
	public class CleanerConfigurationData : SaveData
	{
		// Token: 0x06002F99 RID: 12185 RVA: 0x001081F0 File Offset: 0x001063F0
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerConfigurationData()
		{
			Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CleanerConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr);
			CleanerConfigurationData.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr, "Bed");
			CleanerConfigurationData.NativeFieldInfoPtr_Bins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr, "Bins");
			CleanerConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr, 100668782);
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x0010825C File Offset: 0x0010645C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130739, RefRangeEnd = 130748, XrefRangeStart = 130739, XrefRangeEnd = 130748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerConfigurationData(ObjectFieldData bed, ObjectListFieldData bins) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bins);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x00019366 File Offset: 0x00017566
		public CleanerConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x001082BC File Offset: 0x001064BC
		// (set) Token: 0x06002F9D RID: 12189 RVA: 0x0001936F File Offset: 0x0001756F
		public unsafe ObjectFieldData Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigurationData.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigurationData.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x001082EC File Offset: 0x001064EC
		// (set) Token: 0x06002F9F RID: 12191 RVA: 0x0001938E File Offset: 0x0001758E
		public unsafe ObjectListFieldData Bins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigurationData.NativeFieldInfoPtr_Bins);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigurationData.NativeFieldInfoPtr_Bins), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeFieldInfoPtr_Bins;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0;
	}
}
