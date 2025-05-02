using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000445 RID: 1093
	[Serializable]
	public class BranchOptionData : Object
	{
		// Token: 0x06005F72 RID: 24434 RVA: 0x001B66A8 File Offset: 0x001B48A8
		// Note: this type is marked as 'beforefieldinit'.
		static BranchOptionData()
		{
			Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "BranchOptionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr);
			BranchOptionData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr, "Guid");
			BranchOptionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr, 100675475);
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x001B6700 File Offset: 0x001B4900
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchOptionData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchOptionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F74 RID: 24436 RVA: 0x0002D02C File Offset: 0x0002B22C
		public BranchOptionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x06005F75 RID: 24437 RVA: 0x001B673C File Offset: 0x001B493C
		// (set) Token: 0x06005F76 RID: 24438 RVA: 0x0002D035 File Offset: 0x0002B235
		public unsafe string Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchOptionData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchOptionData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004143 RID: 16707
		private static readonly IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x04004144 RID: 16708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
