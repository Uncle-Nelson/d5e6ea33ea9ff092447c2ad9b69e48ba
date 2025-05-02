using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000273 RID: 627
	[Serializable]
	public class BrickPressConfigurationData : SaveData
	{
		// Token: 0x06002F81 RID: 12161 RVA: 0x00107DF0 File Offset: 0x00105FF0
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressConfigurationData()
		{
			Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BrickPressConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr);
			BrickPressConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr, "Destination");
			BrickPressConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr, 100668778);
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x00107E48 File Offset: 0x00106048
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 130499, RefRangeEnd = 130507, XrefRangeStart = 130499, XrefRangeEnd = 130507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressConfigurationData(ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x00019288 File Offset: 0x00017488
		public BrickPressConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06002F84 RID: 12164 RVA: 0x00107E94 File Offset: 0x00106094
		// (set) Token: 0x06002F85 RID: 12165 RVA: 0x00019291 File Offset: 0x00017491
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F4C RID: 8012
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F4D RID: 8013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0;
	}
}
