using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200061A RID: 1562
	public class ACAccessoryReplicator : ACAssetPathReplicator<Accessory>
	{
		// Token: 0x06008A42 RID: 35394 RVA: 0x0004218F File Offset: 0x0004038F
		// Note: this type is marked as 'beforefieldinit'.
		static ACAccessoryReplicator()
		{
			Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAccessoryReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr);
			ACAccessoryReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr, 100680488);
		}

		// Token: 0x06008A43 RID: 35395 RVA: 0x002442B4 File Offset: 0x002424B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254411, XrefRangeEnd = 254414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAccessoryReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAccessoryReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAccessoryReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A44 RID: 35396 RVA: 0x000421C8 File Offset: 0x000403C8
		public ACAccessoryReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005DD7 RID: 24023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
