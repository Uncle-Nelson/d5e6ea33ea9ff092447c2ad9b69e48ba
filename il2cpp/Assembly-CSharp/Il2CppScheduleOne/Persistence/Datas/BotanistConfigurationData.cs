using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000272 RID: 626
	[Serializable]
	public class BotanistConfigurationData : SaveData
	{
		// Token: 0x06002F78 RID: 12152 RVA: 0x00107C70 File Offset: 0x00105E70
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistConfigurationData()
		{
			Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BotanistConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr);
			BotanistConfigurationData.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, "Bed");
			BotanistConfigurationData.NativeFieldInfoPtr_Supplies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, "Supplies");
			BotanistConfigurationData.NativeFieldInfoPtr_Pots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, "Pots");
			BotanistConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectFieldData_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, 100668777);
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x00107CF0 File Offset: 0x00105EF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130734, RefRangeEnd = 130736, XrefRangeStart = 130730, XrefRangeEnd = 130734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistConfigurationData(ObjectFieldData bed, ObjectFieldData supplies, ObjectListFieldData pots) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(supplies);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectFieldData_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x00019222 File Offset: 0x00017422
		public BotanistConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06002F7B RID: 12155 RVA: 0x00107D60 File Offset: 0x00105F60
		// (set) Token: 0x06002F7C RID: 12156 RVA: 0x0001922B File Offset: 0x0001742B
		public unsafe ObjectFieldData Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06002F7D RID: 12157 RVA: 0x00107D90 File Offset: 0x00105F90
		// (set) Token: 0x06002F7E RID: 12158 RVA: 0x0001924A File Offset: 0x0001744A
		public unsafe ObjectFieldData Supplies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Supplies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Supplies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06002F7F RID: 12159 RVA: 0x00107DC0 File Offset: 0x00105FC0
		// (set) Token: 0x06002F80 RID: 12160 RVA: 0x00019269 File Offset: 0x00017469
		public unsafe ObjectListFieldData Pots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Pots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Pots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F48 RID: 8008
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04001F49 RID: 8009
		private static readonly IntPtr NativeFieldInfoPtr_Supplies;

		// Token: 0x04001F4A RID: 8010
		private static readonly IntPtr NativeFieldInfoPtr_Pots;

		// Token: 0x04001F4B RID: 8011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectFieldData_ObjectListFieldData_0;
	}
}
