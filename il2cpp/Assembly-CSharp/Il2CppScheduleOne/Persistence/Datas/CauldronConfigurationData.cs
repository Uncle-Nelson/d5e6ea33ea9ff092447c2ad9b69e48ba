using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000274 RID: 628
	[Serializable]
	public class CauldronConfigurationData : SaveData
	{
		// Token: 0x06002F86 RID: 12166 RVA: 0x00107EC4 File Offset: 0x001060C4
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronConfigurationData()
		{
			Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CauldronConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr);
			CauldronConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr, "Destination");
			CauldronConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr, 100668779);
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x00107F1C File Offset: 0x0010611C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 130499, RefRangeEnd = 130507, XrefRangeStart = 130499, XrefRangeEnd = 130507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronConfigurationData(ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x000192B0 File Offset: 0x000174B0
		public CauldronConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x00107F68 File Offset: 0x00106168
		// (set) Token: 0x06002F8A RID: 12170 RVA: 0x000192B9 File Offset: 0x000174B9
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F4E RID: 8014
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F4F RID: 8015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0;
	}
}
