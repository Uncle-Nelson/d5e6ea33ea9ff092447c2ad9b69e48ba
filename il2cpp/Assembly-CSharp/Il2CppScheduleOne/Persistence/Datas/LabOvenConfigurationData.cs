using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027A RID: 634
	[Serializable]
	public class LabOvenConfigurationData : SaveData
	{
		// Token: 0x06002FAC RID: 12204 RVA: 0x00108514 File Offset: 0x00106714
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenConfigurationData()
		{
			Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LabOvenConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr);
			LabOvenConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr, "Destination");
			LabOvenConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr, 100668785);
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x0010856C File Offset: 0x0010676C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 130499, RefRangeEnd = 130507, XrefRangeStart = 130499, XrefRangeEnd = 130507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenConfigurationData(ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x0001941C File Offset: 0x0001761C
		public LabOvenConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x001085B8 File Offset: 0x001067B8
		// (set) Token: 0x06002FB0 RID: 12208 RVA: 0x00019425 File Offset: 0x00017625
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0;
	}
}
