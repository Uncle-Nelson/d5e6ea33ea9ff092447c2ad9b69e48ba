using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000278 RID: 632
	[Serializable]
	public class DryingRackConfigurationData : SaveData
	{
		// Token: 0x06002FA0 RID: 12192 RVA: 0x0010831C File Offset: 0x0010651C
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackConfigurationData()
		{
			Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DryingRackConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr);
			DryingRackConfigurationData.NativeFieldInfoPtr_TargetQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr, "TargetQuality");
			DryingRackConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr, "Destination");
			DryingRackConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_QualityFieldData_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr, 100668783);
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x00108388 File Offset: 0x00106588
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130739, RefRangeEnd = 130748, XrefRangeStart = 130739, XrefRangeEnd = 130748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackConfigurationData(QualityFieldData targetquality, ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetquality);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_QualityFieldData_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x000193AD File Offset: 0x000175AD
		public DryingRackConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x001083E8 File Offset: 0x001065E8
		// (set) Token: 0x06002FA4 RID: 12196 RVA: 0x000193B6 File Offset: 0x000175B6
		public unsafe QualityFieldData TargetQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_TargetQuality);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_TargetQuality), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x00108418 File Offset: 0x00106618
		// (set) Token: 0x06002FA6 RID: 12198 RVA: 0x000193D5 File Offset: 0x000175D5
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeFieldInfoPtr_TargetQuality;

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_QualityFieldData_ObjectFieldData_0;
	}
}
