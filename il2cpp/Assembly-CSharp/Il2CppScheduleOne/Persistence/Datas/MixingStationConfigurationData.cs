using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027B RID: 635
	[Serializable]
	public class MixingStationConfigurationData : SaveData
	{
		// Token: 0x06002FB1 RID: 12209 RVA: 0x001085E8 File Offset: 0x001067E8
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationConfigurationData()
		{
			Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MixingStationConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr);
			MixingStationConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr, "Destination");
			MixingStationConfigurationData.NativeFieldInfoPtr_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr, "Threshold");
			MixingStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_NumberFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr, 100668786);
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x00108654 File Offset: 0x00106854
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130739, RefRangeEnd = 130748, XrefRangeStart = 130739, XrefRangeEnd = 130748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationConfigurationData(ObjectFieldData destination, NumberFieldData threshold) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(threshold);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_NumberFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x00019444 File Offset: 0x00017644
		public MixingStationConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06002FB4 RID: 12212 RVA: 0x001086B4 File Offset: 0x001068B4
		// (set) Token: 0x06002FB5 RID: 12213 RVA: 0x0001944D File Offset: 0x0001764D
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06002FB6 RID: 12214 RVA: 0x001086E4 File Offset: 0x001068E4
		// (set) Token: 0x06002FB7 RID: 12215 RVA: 0x0001946C File Offset: 0x0001766C
		public unsafe NumberFieldData Threshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Threshold);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Threshold), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeFieldInfoPtr_Threshold;

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_NumberFieldData_0;
	}
}
