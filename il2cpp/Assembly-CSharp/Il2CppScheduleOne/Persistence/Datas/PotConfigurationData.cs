using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000282 RID: 642
	[Serializable]
	public class PotConfigurationData : SaveData
	{
		// Token: 0x06002FDA RID: 12250 RVA: 0x00108C9C File Offset: 0x00106E9C
		// Note: this type is marked as 'beforefieldinit'.
		static PotConfigurationData()
		{
			Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PotConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr);
			PotConfigurationData.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Seed");
			PotConfigurationData.NativeFieldInfoPtr_Additive1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Additive1");
			PotConfigurationData.NativeFieldInfoPtr_Additive2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Additive2");
			PotConfigurationData.NativeFieldInfoPtr_Additive3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Additive3");
			PotConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Destination");
			PotConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, 100668793);
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x00108D44 File Offset: 0x00106F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130898, RefRangeEnd = 130899, XrefRangeStart = 130892, XrefRangeEnd = 130898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotConfigurationData(ItemFieldData seed, ItemFieldData additive1, ItemFieldData additive2, ItemFieldData additive3, ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(seed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive3);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x000195B5 File Offset: 0x000177B5
		public PotConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06002FDD RID: 12253 RVA: 0x00108DDC File Offset: 0x00106FDC
		// (set) Token: 0x06002FDE RID: 12254 RVA: 0x000195BE File Offset: 0x000177BE
		public unsafe ItemFieldData Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06002FDF RID: 12255 RVA: 0x00108E0C File Offset: 0x0010700C
		// (set) Token: 0x06002FE0 RID: 12256 RVA: 0x000195DD File Offset: 0x000177DD
		public unsafe ItemFieldData Additive1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06002FE1 RID: 12257 RVA: 0x00108E3C File Offset: 0x0010703C
		// (set) Token: 0x06002FE2 RID: 12258 RVA: 0x000195FC File Offset: 0x000177FC
		public unsafe ItemFieldData Additive2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06002FE3 RID: 12259 RVA: 0x00108E6C File Offset: 0x0010706C
		// (set) Token: 0x06002FE4 RID: 12260 RVA: 0x0001961B File Offset: 0x0001781B
		public unsafe ItemFieldData Additive3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x00108E9C File Offset: 0x0010709C
		// (set) Token: 0x06002FE6 RID: 12262 RVA: 0x0001963A File Offset: 0x0001783A
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F71 RID: 8049
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x04001F72 RID: 8050
		private static readonly IntPtr NativeFieldInfoPtr_Additive1;

		// Token: 0x04001F73 RID: 8051
		private static readonly IntPtr NativeFieldInfoPtr_Additive2;

		// Token: 0x04001F74 RID: 8052
		private static readonly IntPtr NativeFieldInfoPtr_Additive3;

		// Token: 0x04001F75 RID: 8053
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F76 RID: 8054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0;
	}
}
