using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000267 RID: 615
	public class MessagesData : SaveData
	{
		// Token: 0x06002F3A RID: 12090 RVA: 0x00018F82 File Offset: 0x00017182
		// Note: this type is marked as 'beforefieldinit'.
		static MessagesData()
		{
			Il2CppClassPointerStore<MessagesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MessagesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesData>.NativeClassPtr);
			MessagesData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesData>.NativeClassPtr, 100668765);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x00107228 File Offset: 0x00105428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130519, RefRangeEnd = 130520, XrefRangeStart = 130519, XrefRangeEnd = 130520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagesData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x00018FBB File Offset: 0x000171BB
		public MessagesData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F2E RID: 7982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
