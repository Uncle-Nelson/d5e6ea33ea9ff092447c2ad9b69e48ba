using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000286 RID: 646
	[Serializable]
	public class MetaData : SaveData
	{
		// Token: 0x06002FF6 RID: 12278 RVA: 0x00109134 File Offset: 0x00107334
		// Note: this type is marked as 'beforefieldinit'.
		static MetaData()
		{
			Il2CppClassPointerStore<MetaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MetaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaData>.NativeClassPtr);
			MetaData.NativeFieldInfoPtr_CreationDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "CreationDate");
			MetaData.NativeFieldInfoPtr_LastPlayedDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "LastPlayedDate");
			MetaData.NativeFieldInfoPtr_CreationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "CreationVersion");
			MetaData.NativeFieldInfoPtr_LastSaveVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "LastSaveVersion");
			MetaData.NativeFieldInfoPtr_PlayTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "PlayTutorial");
			MetaData.NativeMethodInfoPtr__ctor_Public_Void_DateTimeData_DateTimeData_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaData>.NativeClassPtr, 100668797);
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x001091DC File Offset: 0x001073DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130904, RefRangeEnd = 130908, XrefRangeStart = 130899, XrefRangeEnd = 130904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaData(DateTimeData creationDate, DateTimeData lastPlayedDate, string creationVersion, string lastSaveVersion, bool playTutorial) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(creationDate);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastPlayedDate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(creationVersion);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastSaveVersion);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playTutorial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaData.NativeMethodInfoPtr__ctor_Public_Void_DateTimeData_DateTimeData_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x000196CD File Offset: 0x000178CD
		public MetaData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06002FF9 RID: 12281 RVA: 0x0010926C File Offset: 0x0010746C
		// (set) Token: 0x06002FFA RID: 12282 RVA: 0x000196D6 File Offset: 0x000178D6
		public unsafe DateTimeData CreationDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationDate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationDate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06002FFB RID: 12283 RVA: 0x0010929C File Offset: 0x0010749C
		// (set) Token: 0x06002FFC RID: 12284 RVA: 0x000196F5 File Offset: 0x000178F5
		public unsafe DateTimeData LastPlayedDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastPlayedDate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastPlayedDate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06002FFD RID: 12285 RVA: 0x001092CC File Offset: 0x001074CC
		// (set) Token: 0x06002FFE RID: 12286 RVA: 0x00019714 File Offset: 0x00017914
		public unsafe string CreationVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06002FFF RID: 12287 RVA: 0x001092F4 File Offset: 0x001074F4
		// (set) Token: 0x06003000 RID: 12288 RVA: 0x00019733 File Offset: 0x00017933
		public unsafe string LastSaveVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastSaveVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastSaveVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06003001 RID: 12289 RVA: 0x0010931C File Offset: 0x0010751C
		// (set) Token: 0x06003002 RID: 12290 RVA: 0x00019752 File Offset: 0x00017952
		public unsafe bool PlayTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_PlayTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_PlayTutorial)) = value;
			}
		}

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeFieldInfoPtr_CreationDate;

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeFieldInfoPtr_LastPlayedDate;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeFieldInfoPtr_CreationVersion;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeFieldInfoPtr_LastSaveVersion;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeFieldInfoPtr_PlayTutorial;

		// Token: 0x04001F82 RID: 8066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTimeData_DateTimeData_String_String_Boolean_0;
	}
}
