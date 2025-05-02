using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026E RID: 622
	[Serializable]
	public class WeedData : ProductItemData
	{
		// Token: 0x06002F5D RID: 12125 RVA: 0x000190FC File Offset: 0x000172FC
		// Note: this type is marked as 'beforefieldinit'.
		static WeedData()
		{
			Il2CppClassPointerStore<WeedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WeedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedData>.NativeClassPtr);
			WeedData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedData>.NativeClassPtr, 100668772);
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x00107808 File Offset: 0x00105A08
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130708, RefRangeEnd = 130712, XrefRangeStart = 130708, XrefRangeEnd = 130712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedData(string iD, int quantity, string quality, string packagingID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x00019135 File Offset: 0x00017335
		public WeedData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F3C RID: 7996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0;
	}
}
