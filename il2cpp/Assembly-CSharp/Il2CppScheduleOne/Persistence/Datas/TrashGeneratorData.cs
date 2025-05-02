using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BB RID: 699
	public class TrashGeneratorData : SaveData
	{
		// Token: 0x060031EF RID: 12783 RVA: 0x0010ECA4 File Offset: 0x0010CEA4
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGeneratorData()
		{
			Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashGeneratorData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr);
			TrashGeneratorData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr, "GUID");
			TrashGeneratorData.NativeFieldInfoPtr_GeneratedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr, "GeneratedItems");
			TrashGeneratorData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr, 100668858);
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x0010ED10 File Offset: 0x0010CF10
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130739, RefRangeEnd = 130748, XrefRangeStart = 130739, XrefRangeEnd = 130748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGeneratorData(string guid, Il2CppStringArray generatedItems) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generatedItems);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGeneratorData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x0001AC24 File Offset: 0x00018E24
		public TrashGeneratorData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x060031F2 RID: 12786 RVA: 0x0010ED70 File Offset: 0x0010CF70
		// (set) Token: 0x060031F3 RID: 12787 RVA: 0x0001AC2D File Offset: 0x00018E2D
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x060031F4 RID: 12788 RVA: 0x0010ED98 File Offset: 0x0010CF98
		// (set) Token: 0x060031F5 RID: 12789 RVA: 0x0001AC4C File Offset: 0x00018E4C
		public unsafe Il2CppStringArray GeneratedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GeneratedItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GeneratedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002063 RID: 8291
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002064 RID: 8292
		private static readonly IntPtr NativeFieldInfoPtr_GeneratedItems;

		// Token: 0x04002065 RID: 8293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0;
	}
}
