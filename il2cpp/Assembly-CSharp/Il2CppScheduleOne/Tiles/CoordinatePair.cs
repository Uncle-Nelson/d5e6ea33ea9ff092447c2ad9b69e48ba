using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000199 RID: 409
	public class CoordinatePair : Object
	{
		// Token: 0x060021BC RID: 8636 RVA: 0x000DA000 File Offset: 0x000D8200
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinatePair()
		{
			Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "CoordinatePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr);
			CoordinatePair.NativeFieldInfoPtr_coord1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr, "coord1");
			CoordinatePair.NativeFieldInfoPtr_coord2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr, "coord2");
			CoordinatePair.NativeMethodInfoPtr__ctor_Public_Void_Coordinate_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr, 100667110);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x000DA06C File Offset: 0x000D826C
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 110734, RefRangeEnd = 110783, XrefRangeStart = 110731, XrefRangeEnd = 110734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoordinatePair(Coordinate _c1, Coordinate _c2) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_c1);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_c2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoordinatePair.NativeMethodInfoPtr__ctor_Public_Void_Coordinate_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x00012D22 File Offset: 0x00010F22
		public CoordinatePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x000DA0CC File Offset: 0x000D82CC
		// (set) Token: 0x060021C0 RID: 8640 RVA: 0x00012D2B File Offset: 0x00010F2B
		public unsafe Coordinate coord1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinatePair.NativeFieldInfoPtr_coord1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinatePair.NativeFieldInfoPtr_coord1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x000DA0FC File Offset: 0x000D82FC
		// (set) Token: 0x060021C2 RID: 8642 RVA: 0x00012D4A File Offset: 0x00010F4A
		public unsafe Coordinate coord2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinatePair.NativeFieldInfoPtr_coord2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinatePair.NativeFieldInfoPtr_coord2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001675 RID: 5749
		private static readonly IntPtr NativeFieldInfoPtr_coord1;

		// Token: 0x04001676 RID: 5750
		private static readonly IntPtr NativeFieldInfoPtr_coord2;

		// Token: 0x04001677 RID: 5751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Coordinate_Coordinate_0;
	}
}
