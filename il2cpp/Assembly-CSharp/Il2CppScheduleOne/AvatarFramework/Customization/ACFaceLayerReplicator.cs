using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200061E RID: 1566
	public class ACFaceLayerReplicator : ACAssetPathReplicator<FaceLayer>
	{
		// Token: 0x06008A55 RID: 35413 RVA: 0x00042263 File Offset: 0x00040463
		// Note: this type is marked as 'beforefieldinit'.
		static ACFaceLayerReplicator()
		{
			Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACFaceLayerReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr);
			ACFaceLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr, 100680495);
		}

		// Token: 0x06008A56 RID: 35414 RVA: 0x00244608 File Offset: 0x00242808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254439, XrefRangeEnd = 254442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACFaceLayerReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACFaceLayerReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACFaceLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A57 RID: 35415 RVA: 0x0004229C File Offset: 0x0004049C
		public ACFaceLayerReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005DE0 RID: 24032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
