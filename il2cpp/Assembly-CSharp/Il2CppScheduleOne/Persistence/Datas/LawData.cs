using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000270 RID: 624
	public class LawData : SaveData
	{
		// Token: 0x06002F67 RID: 12135 RVA: 0x0010799C File Offset: 0x00105B9C
		// Note: this type is marked as 'beforefieldinit'.
		static LawData()
		{
			Il2CppClassPointerStore<LawData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LawData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawData>.NativeClassPtr);
			LawData.NativeFieldInfoPtr_InternalLawIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawData>.NativeClassPtr, "InternalLawIntensity");
			LawData.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawData>.NativeClassPtr, 100668774);
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x001079F4 File Offset: 0x00105BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130724, RefRangeEnd = 130725, XrefRangeStart = 130723, XrefRangeEnd = 130724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawData(float internalLawIntensity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref internalLawIntensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawData.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x0001917D File Offset: 0x0001737D
		public LawData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06002F6A RID: 12138 RVA: 0x00107A3C File Offset: 0x00105C3C
		// (set) Token: 0x06002F6B RID: 12139 RVA: 0x00019186 File Offset: 0x00017386
		public unsafe float InternalLawIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawData.NativeFieldInfoPtr_InternalLawIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawData.NativeFieldInfoPtr_InternalLawIntensity)) = value;
			}
		}

		// Token: 0x04001F40 RID: 8000
		private static readonly IntPtr NativeFieldInfoPtr_InternalLawIntensity;

		// Token: 0x04001F41 RID: 8001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
