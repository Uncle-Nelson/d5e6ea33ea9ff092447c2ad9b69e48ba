using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B9 RID: 697
	public class TrashBagData : TrashItemData
	{
		// Token: 0x060031E7 RID: 12775 RVA: 0x0001ABBA File Offset: 0x00018DBA
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBagData()
		{
			Il2CppClassPointerStore<TrashBagData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashBagData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBagData>.NativeClassPtr);
			TrashBagData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagData>.NativeClassPtr, 100668856);
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x0010EB44 File Offset: 0x0010CD44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131317, RefRangeEnd = 131318, XrefRangeStart = 131313, XrefRangeEnd = 131317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBagData(string trashID, string guid, Vector3 position, Quaternion rotation, TrashContentData contents) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBagData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x0001ABF3 File Offset: 0x00018DF3
		public TrashBagData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002060 RID: 8288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_TrashContentData_0;
	}
}
