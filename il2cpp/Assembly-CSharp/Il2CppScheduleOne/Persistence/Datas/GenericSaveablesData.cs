using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000260 RID: 608
	[Serializable]
	public class GenericSaveablesData : SaveData
	{
		// Token: 0x06002F07 RID: 12039 RVA: 0x001067D4 File Offset: 0x001049D4
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSaveablesData()
		{
			Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GenericSaveablesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr);
			GenericSaveablesData.NativeFieldInfoPtr_Saveables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr, "Saveables");
			GenericSaveablesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr, 100668738);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x0010682C File Offset: 0x00104A2C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 130499, RefRangeEnd = 130507, XrefRangeStart = 130499, XrefRangeEnd = 130507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSaveablesData(Il2CppReferenceArray<GenericSaveData> saveables) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveables);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GenericSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x00018DC5 File Offset: 0x00016FC5
		public GenericSaveablesData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06002F0A RID: 12042 RVA: 0x00106878 File Offset: 0x00104A78
		// (set) Token: 0x06002F0B RID: 12043 RVA: 0x00018DCE File Offset: 0x00016FCE
		public unsafe Il2CppReferenceArray<GenericSaveData> Saveables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesData.NativeFieldInfoPtr_Saveables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GenericSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesData.NativeFieldInfoPtr_Saveables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeFieldInfoPtr_Saveables;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GenericSaveData_0;
	}
}
