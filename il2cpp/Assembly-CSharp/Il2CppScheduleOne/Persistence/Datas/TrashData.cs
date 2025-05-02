using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BA RID: 698
	[Serializable]
	public class TrashData : SaveData
	{
		// Token: 0x060031EA RID: 12778 RVA: 0x0010EBD0 File Offset: 0x0010CDD0
		// Note: this type is marked as 'beforefieldinit'.
		static TrashData()
		{
			Il2CppClassPointerStore<TrashData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashData>.NativeClassPtr);
			TrashData.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashData>.NativeClassPtr, "Items");
			TrashData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrashItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashData>.NativeClassPtr, 100668857);
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x0010EC28 File Offset: 0x0010CE28
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 130499, RefRangeEnd = 130507, XrefRangeStart = 130499, XrefRangeEnd = 130507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashData(Il2CppReferenceArray<TrashItemData> trash) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trash);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrashItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x0001ABFC File Offset: 0x00018DFC
		public TrashData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x060031ED RID: 12781 RVA: 0x0010EC74 File Offset: 0x0010CE74
		// (set) Token: 0x060031EE RID: 12782 RVA: 0x0001AC05 File Offset: 0x00018E05
		public unsafe Il2CppReferenceArray<TrashItemData> Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashData.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashItemData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashData.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002061 RID: 8289
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04002062 RID: 8290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrashItemData_0;
	}
}
