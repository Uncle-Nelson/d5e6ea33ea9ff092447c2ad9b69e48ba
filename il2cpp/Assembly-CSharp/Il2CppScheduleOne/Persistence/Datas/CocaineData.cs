using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000264 RID: 612
	[Serializable]
	public class CocaineData : ProductItemData
	{
		// Token: 0x06002F2B RID: 12075 RVA: 0x00018ED9 File Offset: 0x000170D9
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineData()
		{
			Il2CppClassPointerStore<CocaineData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CocaineData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineData>.NativeClassPtr);
			CocaineData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineData>.NativeClassPtr, 100668762);
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x00106FA8 File Offset: 0x001051A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130708, RefRangeEnd = 130712, XrefRangeStart = 130704, XrefRangeEnd = 130708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineData(string iD, int quantity, string quality, string packagingID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x00018F12 File Offset: 0x00017112
		public CocaineData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F28 RID: 7976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0;
	}
}
