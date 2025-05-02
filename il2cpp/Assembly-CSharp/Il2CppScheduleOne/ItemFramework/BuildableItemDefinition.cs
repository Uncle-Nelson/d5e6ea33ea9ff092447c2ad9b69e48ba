using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D1 RID: 1489
	[Serializable]
	public class BuildableItemDefinition : StorableItemDefinition
	{
		// Token: 0x06008329 RID: 33577 RVA: 0x0022E0CC File Offset: 0x0022C2CC
		// Note: this type is marked as 'beforefieldinit'.
		static BuildableItemDefinition()
		{
			Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "BuildableItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr);
			BuildableItemDefinition.NativeFieldInfoPtr_BuiltItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr, "BuiltItem");
			BuildableItemDefinition.NativeFieldInfoPtr_BuildSoundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr, "BuildSoundType");
			BuildableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr, 100679705);
		}

		// Token: 0x0600832A RID: 33578 RVA: 0x0022E138 File Offset: 0x0022C338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600832B RID: 33579 RVA: 0x0003E57D File Offset: 0x0003C77D
		public BuildableItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027B6 RID: 10166
		// (get) Token: 0x0600832C RID: 33580 RVA: 0x0022E174 File Offset: 0x0022C374
		// (set) Token: 0x0600832D RID: 33581 RVA: 0x0003E586 File Offset: 0x0003C786
		public unsafe BuildableItem BuiltItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuiltItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuiltItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B7 RID: 10167
		// (get) Token: 0x0600832E RID: 33582 RVA: 0x0022E1A4 File Offset: 0x0022C3A4
		// (set) Token: 0x0600832F RID: 33583 RVA: 0x0003E5A5 File Offset: 0x0003C7A5
		public unsafe BuildableItemDefinition.EBuildSoundType BuildSoundType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuildSoundType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuildSoundType)) = value;
			}
		}

		// Token: 0x04005940 RID: 22848
		private static readonly IntPtr NativeFieldInfoPtr_BuiltItem;

		// Token: 0x04005941 RID: 22849
		private static readonly IntPtr NativeFieldInfoPtr_BuildSoundType;

		// Token: 0x04005942 RID: 22850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AE6 RID: 2790
		[OriginalName("Assembly-CSharp.dll", "", "EBuildSoundType")]
		public enum EBuildSoundType
		{
			// Token: 0x04008F81 RID: 36737
			Cardboard,
			// Token: 0x04008F82 RID: 36738
			Wood,
			// Token: 0x04008F83 RID: 36739
			Metal
		}
	}
}
