using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200059A RID: 1434
	[Serializable]
	public class DrugTypeContainer : Object
	{
		// Token: 0x06007DF5 RID: 32245 RVA: 0x0021B800 File Offset: 0x00219A00
		// Note: this type is marked as 'beforefieldinit'.
		static DrugTypeContainer()
		{
			Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "DrugTypeContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr);
			DrugTypeContainer.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr, "DrugType");
			DrugTypeContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr, 100679047);
		}

		// Token: 0x06007DF6 RID: 32246 RVA: 0x0021B858 File Offset: 0x00219A58
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrugTypeContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrugTypeContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DF7 RID: 32247 RVA: 0x0003BDF6 File Offset: 0x00039FF6
		public DrugTypeContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x06007DF8 RID: 32248 RVA: 0x0021B894 File Offset: 0x00219A94
		// (set) Token: 0x06007DF9 RID: 32249 RVA: 0x0003BDFF File Offset: 0x00039FFF
		public unsafe EDrugType DrugType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrugTypeContainer.NativeFieldInfoPtr_DrugType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrugTypeContainer.NativeFieldInfoPtr_DrugType)) = value;
			}
		}

		// Token: 0x040055A7 RID: 21927
		private static readonly IntPtr NativeFieldInfoPtr_DrugType;

		// Token: 0x040055A8 RID: 21928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
