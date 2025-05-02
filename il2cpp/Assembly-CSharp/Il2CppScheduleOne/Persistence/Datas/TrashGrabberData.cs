using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026C RID: 620
	[Serializable]
	public class TrashGrabberData : ItemData
	{
		// Token: 0x06002F53 RID: 12115 RVA: 0x0010762C File Offset: 0x0010582C
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGrabberData()
		{
			Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashGrabberData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr);
			TrashGrabberData.NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr, "Content");
			TrashGrabberData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr, 100668770);
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x00107684 File Offset: 0x00105884
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130546, RefRangeEnd = 130552, XrefRangeStart = 130546, XrefRangeEnd = 130552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberData(string iD, int quantity, TrashContentData content) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x000190B0 File Offset: 0x000172B0
		public TrashGrabberData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06002F56 RID: 12118 RVA: 0x001076F0 File Offset: 0x001058F0
		// (set) Token: 0x06002F57 RID: 12119 RVA: 0x000190B9 File Offset: 0x000172B9
		public unsafe TrashContentData Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberData.NativeFieldInfoPtr_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberData.NativeFieldInfoPtr_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F38 RID: 7992
		private static readonly IntPtr NativeFieldInfoPtr_Content;

		// Token: 0x04001F39 RID: 7993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_TrashContentData_0;
	}
}
