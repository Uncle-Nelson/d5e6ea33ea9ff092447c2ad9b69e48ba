using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F9 RID: 1529
	[Serializable]
	public class FaceLayer : AvatarLayer
	{
		// Token: 0x060086E9 RID: 34537 RVA: 0x000402AD File Offset: 0x0003E4AD
		// Note: this type is marked as 'beforefieldinit'.
		static FaceLayer()
		{
			Il2CppClassPointerStore<FaceLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "FaceLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceLayer>.NativeClassPtr);
			FaceLayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceLayer>.NativeClassPtr, 100680138);
		}

		// Token: 0x060086EA RID: 34538 RVA: 0x0023A73C File Offset: 0x0023893C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88919, RefRangeEnd = 88931, XrefRangeStart = 88919, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FaceLayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceLayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceLayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086EB RID: 34539 RVA: 0x000402E6 File Offset: 0x0003E4E6
		public FaceLayer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005BD0 RID: 23504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
