using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200025E RID: 606
	public class GameData : SaveData
	{
		// Token: 0x06002EF5 RID: 12021 RVA: 0x001064A8 File Offset: 0x001046A8
		// Note: this type is marked as 'beforefieldinit'.
		static GameData()
		{
			Il2CppClassPointerStore<GameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameData>.NativeClassPtr);
			GameData.NativeFieldInfoPtr_OrganisationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameData>.NativeClassPtr, "OrganisationName");
			GameData.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameData>.NativeClassPtr, "Seed");
			GameData.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameData>.NativeClassPtr, "Settings");
			GameData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_GameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameData>.NativeClassPtr, 100668734);
			GameData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameData>.NativeClassPtr, 100668735);
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x0010653C File Offset: 0x0010473C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130546, RefRangeEnd = 130552, XrefRangeStart = 130543, XrefRangeEnd = 130546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameData(string organisationName, int seed, GameSettings settings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(organisationName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_GameSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x001065A8 File Offset: 0x001047A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130557, RefRangeEnd = 130558, XrefRangeStart = 130552, XrefRangeEnd = 130557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x00018D24 File Offset: 0x00016F24
		public GameData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x001065E4 File Offset: 0x001047E4
		// (set) Token: 0x06002EFA RID: 12026 RVA: 0x00018D2D File Offset: 0x00016F2D
		public unsafe string OrganisationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_OrganisationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_OrganisationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x0010660C File Offset: 0x0010480C
		// (set) Token: 0x06002EFC RID: 12028 RVA: 0x00018D4C File Offset: 0x00016F4C
		public unsafe int Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Seed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Seed)) = value;
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x00106634 File Offset: 0x00104834
		// (set) Token: 0x06002EFE RID: 12030 RVA: 0x00018D67 File Offset: 0x00016F67
		public unsafe GameSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeFieldInfoPtr_OrganisationName;

		// Token: 0x04001F0C RID: 7948
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x04001F0D RID: 7949
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x04001F0E RID: 7950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_GameSettings_0;

		// Token: 0x04001F0F RID: 7951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
