using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200061C RID: 1564
	public class ACAvatarLayerReplicator : ACAssetPathReplicator<AvatarLayer>
	{
		// Token: 0x06008A4C RID: 35404 RVA: 0x000421F9 File Offset: 0x000403F9
		// Note: this type is marked as 'beforefieldinit'.
		static ACAvatarLayerReplicator()
		{
			Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAvatarLayerReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr);
			ACAvatarLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr, 100680492);
		}

		// Token: 0x06008A4D RID: 35405 RVA: 0x002444A4 File Offset: 0x002426A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254426, XrefRangeEnd = 254429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAvatarLayerReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAvatarLayerReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAvatarLayerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A4E RID: 35406 RVA: 0x00042232 File Offset: 0x00040432
		public ACAvatarLayerReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005DDC RID: 24028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
