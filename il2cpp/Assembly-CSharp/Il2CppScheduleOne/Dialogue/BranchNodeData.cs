using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000444 RID: 1092
	[Serializable]
	public class BranchNodeData : Il2CppSystem.Object
	{
		// Token: 0x06005F67 RID: 24423 RVA: 0x001B6530 File Offset: 0x001B4730
		// Note: this type is marked as 'beforefieldinit'.
		static BranchNodeData()
		{
			Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "BranchNodeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr);
			BranchNodeData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "Guid");
			BranchNodeData.NativeFieldInfoPtr_BranchLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "BranchLabel");
			BranchNodeData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "Position");
			BranchNodeData.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "options");
			BranchNodeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, 100675474);
		}

		// Token: 0x06005F68 RID: 24424 RVA: 0x001B65C4 File Offset: 0x001B47C4
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchNodeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchNodeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F69 RID: 24425 RVA: 0x0002CFAB File Offset: 0x0002B1AB
		public BranchNodeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x06005F6A RID: 24426 RVA: 0x001B6600 File Offset: 0x001B4800
		// (set) Token: 0x06005F6B RID: 24427 RVA: 0x0002CFB4 File Offset: 0x0002B1B4
		public unsafe string Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x06005F6C RID: 24428 RVA: 0x001B6628 File Offset: 0x001B4828
		// (set) Token: 0x06005F6D RID: 24429 RVA: 0x0002CFD3 File Offset: 0x0002B1D3
		public unsafe string BranchLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_BranchLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_BranchLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x06005F6E RID: 24430 RVA: 0x001B6650 File Offset: 0x001B4850
		// (set) Token: 0x06005F6F RID: 24431 RVA: 0x0002CFF2 File Offset: 0x0002B1F2
		public unsafe Vector2 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x06005F70 RID: 24432 RVA: 0x001B6678 File Offset: 0x001B4878
		// (set) Token: 0x06005F71 RID: 24433 RVA: 0x0002D00D File Offset: 0x0002B20D
		public unsafe Il2CppReferenceArray<BranchOptionData> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BranchOptionData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400413E RID: 16702
		private static readonly IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x0400413F RID: 16703
		private static readonly IntPtr NativeFieldInfoPtr_BranchLabel;

		// Token: 0x04004140 RID: 16704
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04004141 RID: 16705
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04004142 RID: 16706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
