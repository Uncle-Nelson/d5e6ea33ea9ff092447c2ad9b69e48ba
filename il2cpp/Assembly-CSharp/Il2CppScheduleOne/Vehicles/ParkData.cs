using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E4 RID: 1252
	[Serializable]
	public class ParkData : Object
	{
		// Token: 0x06006EAC RID: 28332 RVA: 0x001E97B0 File Offset: 0x001E79B0
		// Note: this type is marked as 'beforefieldinit'.
		static ParkData()
		{
			Il2CppClassPointerStore<ParkData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "ParkData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkData>.NativeClassPtr);
			ParkData.NativeFieldInfoPtr_lotGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkData>.NativeClassPtr, "lotGUID");
			ParkData.NativeFieldInfoPtr_spotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkData>.NativeClassPtr, "spotIndex");
			ParkData.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkData>.NativeClassPtr, "alignment");
			ParkData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkData>.NativeClassPtr, 100677296);
		}

		// Token: 0x06006EAD RID: 28333 RVA: 0x001E9830 File Offset: 0x001E7A30
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x000345D1 File Offset: 0x000327D1
		public ParkData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x06006EAF RID: 28335 RVA: 0x001E986C File Offset: 0x001E7A6C
		// (set) Token: 0x06006EB0 RID: 28336 RVA: 0x000345DA File Offset: 0x000327DA
		public unsafe Guid lotGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_lotGUID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_lotGUID)) = value;
			}
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x06006EB1 RID: 28337 RVA: 0x001E9894 File Offset: 0x001E7A94
		// (set) Token: 0x06006EB2 RID: 28338 RVA: 0x000345F5 File Offset: 0x000327F5
		public unsafe int spotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_spotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_spotIndex)) = value;
			}
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x06006EB3 RID: 28339 RVA: 0x001E98BC File Offset: 0x001E7ABC
		// (set) Token: 0x06006EB4 RID: 28340 RVA: 0x00034610 File Offset: 0x00032810
		public unsafe EParkingAlignment alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_alignment)) = value;
			}
		}

		// Token: 0x04004BBB RID: 19387
		private static readonly IntPtr NativeFieldInfoPtr_lotGUID;

		// Token: 0x04004BBC RID: 19388
		private static readonly IntPtr NativeFieldInfoPtr_spotIndex;

		// Token: 0x04004BBD RID: 19389
		private static readonly IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x04004BBE RID: 19390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
