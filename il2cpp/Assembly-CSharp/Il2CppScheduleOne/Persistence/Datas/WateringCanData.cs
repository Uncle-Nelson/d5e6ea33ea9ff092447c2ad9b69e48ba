using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026D RID: 621
	[Serializable]
	public class WateringCanData : ItemData
	{
		// Token: 0x06002F58 RID: 12120 RVA: 0x00107720 File Offset: 0x00105920
		// Note: this type is marked as 'beforefieldinit'.
		static WateringCanData()
		{
			Il2CppClassPointerStore<WateringCanData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WateringCanData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr);
			WateringCanData.NativeFieldInfoPtr_CurrentFillAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr, "CurrentFillAmount");
			WateringCanData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr, 100668771);
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x00107778 File Offset: 0x00105978
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130698, RefRangeEnd = 130700, XrefRangeStart = 130698, XrefRangeEnd = 130700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanData(string iD, int quantity, float currentFillLevel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentFillLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x000190D8 File Offset: 0x000172D8
		public WateringCanData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x001077E0 File Offset: 0x001059E0
		// (set) Token: 0x06002F5C RID: 12124 RVA: 0x000190E1 File Offset: 0x000172E1
		public unsafe float CurrentFillAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanData.NativeFieldInfoPtr_CurrentFillAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanData.NativeFieldInfoPtr_CurrentFillAmount)) = value;
			}
		}

		// Token: 0x04001F3A RID: 7994
		private static readonly IntPtr NativeFieldInfoPtr_CurrentFillAmount;

		// Token: 0x04001F3B RID: 7995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0;
	}
}
