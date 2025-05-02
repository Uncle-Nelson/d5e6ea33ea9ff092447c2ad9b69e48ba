using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027E RID: 638
	[Serializable]
	public class ObjectFieldData : Object
	{
		// Token: 0x06002FC2 RID: 12226 RVA: 0x001088A8 File Offset: 0x00106AA8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectFieldData()
		{
			Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ObjectFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr);
			ObjectFieldData.NativeFieldInfoPtr_ObjectGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr, "ObjectGUID");
			ObjectFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr, 100668789);
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x00108900 File Offset: 0x00106B00
		[CallerCount(177)]
		[CachedScanResults(RefRangeStart = 17913, RefRangeEnd = 18090, XrefRangeStart = 17913, XrefRangeEnd = 18090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectFieldData(string objectGUID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objectGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x000194D7 File Offset: 0x000176D7
		public ObjectFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x0010894C File Offset: 0x00106B4C
		// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x000194E0 File Offset: 0x000176E0
		public unsafe string ObjectGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldData.NativeFieldInfoPtr_ObjectGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldData.NativeFieldInfoPtr_ObjectGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeFieldInfoPtr_ObjectGUID;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
