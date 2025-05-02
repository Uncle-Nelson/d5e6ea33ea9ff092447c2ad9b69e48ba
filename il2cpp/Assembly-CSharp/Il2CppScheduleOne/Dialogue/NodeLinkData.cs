using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000449 RID: 1097
	[Serializable]
	public class NodeLinkData : Object
	{
		// Token: 0x06005FA4 RID: 24484 RVA: 0x001B6FA0 File Offset: 0x001B51A0
		// Note: this type is marked as 'beforefieldinit'.
		static NodeLinkData()
		{
			Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "NodeLinkData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr);
			NodeLinkData.NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, "BaseDialogueOrBranchNodeGuid");
			NodeLinkData.NativeFieldInfoPtr_BaseChoiceOrOptionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, "BaseChoiceOrOptionGUID");
			NodeLinkData.NativeFieldInfoPtr_TargetNodeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, "TargetNodeGuid");
			NodeLinkData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, 100675499);
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x001B7020 File Offset: 0x001B5220
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeLinkData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeLinkData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x0002D1F6 File Offset: 0x0002B3F6
		public NodeLinkData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x06005FA7 RID: 24487 RVA: 0x001B705C File Offset: 0x001B525C
		// (set) Token: 0x06005FA8 RID: 24488 RVA: 0x0002D1FF File Offset: 0x0002B3FF
		public unsafe string BaseDialogueOrBranchNodeGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x06005FA9 RID: 24489 RVA: 0x001B7084 File Offset: 0x001B5284
		// (set) Token: 0x06005FAA RID: 24490 RVA: 0x0002D21E File Offset: 0x0002B41E
		public unsafe string BaseChoiceOrOptionGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseChoiceOrOptionGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseChoiceOrOptionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x06005FAB RID: 24491 RVA: 0x001B70AC File Offset: 0x001B52AC
		// (set) Token: 0x06005FAC RID: 24492 RVA: 0x0002D23D File Offset: 0x0002B43D
		public unsafe string TargetNodeGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_TargetNodeGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_TargetNodeGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400415F RID: 16735
		private static readonly IntPtr NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid;

		// Token: 0x04004160 RID: 16736
		private static readonly IntPtr NativeFieldInfoPtr_BaseChoiceOrOptionGUID;

		// Token: 0x04004161 RID: 16737
		private static readonly IntPtr NativeFieldInfoPtr_TargetNodeGuid;

		// Token: 0x04004162 RID: 16738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
