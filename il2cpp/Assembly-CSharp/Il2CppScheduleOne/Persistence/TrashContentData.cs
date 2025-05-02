using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200021D RID: 541
	[Serializable]
	public class TrashContentData : Object
	{
		// Token: 0x06002D1D RID: 11549 RVA: 0x000FFF2C File Offset: 0x000FE12C
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContentData()
		{
			Il2CppClassPointerStore<TrashContentData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "TrashContentData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr);
			TrashContentData.NativeFieldInfoPtr_TrashIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, "TrashIDs");
			TrashContentData.NativeFieldInfoPtr_TrashQuantities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, "TrashQuantities");
			TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, 100668469);
			TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, 100668470);
			TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_List_1_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, 100668471);
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000FFFC0 File Offset: 0x000FE1C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126458, RefRangeEnd = 126460, XrefRangeStart = 126449, XrefRangeEnd = 126458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x000FFFFC File Offset: 0x000FE1FC
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 110734, RefRangeEnd = 110783, XrefRangeStart = 110734, XrefRangeEnd = 110783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData(Il2CppStringArray trashIDs, Il2CppStructArray<int> trashQuantities) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashIDs);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trashQuantities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x0010005C File Offset: 0x000FE25C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126524, RefRangeEnd = 126525, XrefRangeStart = 126460, XrefRangeEnd = 126524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData(List<TrashItem> trashItems) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashItems);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_List_1_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x000183AE File Offset: 0x000165AE
		public TrashContentData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x001000A8 File Offset: 0x000FE2A8
		// (set) Token: 0x06002D23 RID: 11555 RVA: 0x000183B7 File Offset: 0x000165B7
		public unsafe Il2CppStringArray TrashIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06002D24 RID: 11556 RVA: 0x001000D8 File Offset: 0x000FE2D8
		// (set) Token: 0x06002D25 RID: 11557 RVA: 0x000183D6 File Offset: 0x000165D6
		public unsafe Il2CppStructArray<int> TrashQuantities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashQuantities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashQuantities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeFieldInfoPtr_TrashIDs;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeFieldInfoPtr_TrashQuantities;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_TrashItem_0;
	}
}
