using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000535 RID: 1333
	public class DemoBoundary : MonoBehaviour
	{
		// Token: 0x060076C1 RID: 30401 RVA: 0x002041A4 File Offset: 0x002023A4
		// Note: this type is marked as 'beforefieldinit'.
		static DemoBoundary()
		{
			Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "DemoBoundary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr);
			DemoBoundary.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, "Collider");
			DemoBoundary.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100678251);
			DemoBoundary.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100678252);
			DemoBoundary.NativeMethodInfoPtr_UpdateBoundary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100678253);
			DemoBoundary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100678254);
		}

		// Token: 0x060076C2 RID: 30402 RVA: 0x00204238 File Offset: 0x00202438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231235, XrefRangeEnd = 231243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076C3 RID: 30403 RVA: 0x0020426C File Offset: 0x0020246C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231243, XrefRangeEnd = 231246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076C4 RID: 30404 RVA: 0x002042A0 File Offset: 0x002024A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231246, XrefRangeEnd = 231262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBoundary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr_UpdateBoundary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076C5 RID: 30405 RVA: 0x002042D4 File Offset: 0x002024D4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DemoBoundary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076C6 RID: 30406 RVA: 0x00038494 File Offset: 0x00036694
		public DemoBoundary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x060076C7 RID: 30407 RVA: 0x00204310 File Offset: 0x00202510
		// (set) Token: 0x060076C8 RID: 30408 RVA: 0x0003849D File Offset: 0x0003669D
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoBoundary.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoBoundary.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005118 RID: 20760
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04005119 RID: 20761
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400511A RID: 20762
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400511B RID: 20763
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBoundary_Private_Void_0;

		// Token: 0x0400511C RID: 20764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
