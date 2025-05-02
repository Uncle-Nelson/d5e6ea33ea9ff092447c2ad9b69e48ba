using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200028A RID: 650
	public class NPCHealthData : SaveData
	{
		// Token: 0x06003021 RID: 12321 RVA: 0x00109810 File Offset: 0x00107A10
		// Note: this type is marked as 'beforefieldinit'.
		static NPCHealthData()
		{
			Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NPCHealthData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr);
			NPCHealthData.NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, "Health");
			NPCHealthData.NativeFieldInfoPtr_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, "IsDead");
			NPCHealthData.NativeFieldInfoPtr_DaysPassedSinceDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, "DaysPassedSinceDeath");
			NPCHealthData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, 100668802);
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x00109890 File Offset: 0x00107A90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130720, RefRangeEnd = 130721, XrefRangeStart = 130720, XrefRangeEnd = 130721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCHealthData(float health, bool isDead, int daysPassedSinceDeath) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref health;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDead;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daysPassedSinceDeath;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealthData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x000198A2 File Offset: 0x00017AA2
		public NPCHealthData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06003024 RID: 12324 RVA: 0x001098F4 File Offset: 0x00107AF4
		// (set) Token: 0x06003025 RID: 12325 RVA: 0x000198AB File Offset: 0x00017AAB
		public unsafe float Health
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_Health);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_Health)) = value;
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x0010991C File Offset: 0x00107B1C
		// (set) Token: 0x06003027 RID: 12327 RVA: 0x000198C6 File Offset: 0x00017AC6
		public unsafe bool IsDead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_IsDead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_IsDead)) = value;
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06003028 RID: 12328 RVA: 0x00109944 File Offset: 0x00107B44
		// (set) Token: 0x06003029 RID: 12329 RVA: 0x000198E1 File Offset: 0x00017AE1
		public unsafe int DaysPassedSinceDeath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_DaysPassedSinceDeath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_DaysPassedSinceDeath)) = value;
			}
		}

		// Token: 0x04001F91 RID: 8081
		private static readonly IntPtr NativeFieldInfoPtr_Health;

		// Token: 0x04001F92 RID: 8082
		private static readonly IntPtr NativeFieldInfoPtr_IsDead;

		// Token: 0x04001F93 RID: 8083
		private static readonly IntPtr NativeFieldInfoPtr_DaysPassedSinceDeath;

		// Token: 0x04001F94 RID: 8084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_Int32_0;
	}
}
