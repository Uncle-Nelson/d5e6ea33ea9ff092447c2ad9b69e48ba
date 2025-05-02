using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000556 RID: 1366
	public class FunctionalSeed : MonoBehaviour
	{
		// Token: 0x06007841 RID: 30785 RVA: 0x002086B0 File Offset: 0x002068B0
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalSeed()
		{
			Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "FunctionalSeed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr);
			FunctionalSeed.NativeFieldInfoPtr_onSeedExitVial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "onSeedExitVial");
			FunctionalSeed.NativeFieldInfoPtr_Vial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "Vial");
			FunctionalSeed.NativeFieldInfoPtr_SeedBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "SeedBlocker");
			FunctionalSeed.NativeFieldInfoPtr_Cap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "Cap");
			FunctionalSeed.NativeFieldInfoPtr_SeedCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "SeedCollider");
			FunctionalSeed.NativeFieldInfoPtr_SeedRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "SeedRigidbody");
			FunctionalSeed.NativeFieldInfoPtr_TrashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "TrashPrefab");
			FunctionalSeed.NativeMethodInfoPtr_TriggerExit_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, 100678407);
			FunctionalSeed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, 100678408);
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x00208794 File Offset: 0x00206994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232535, XrefRangeEnd = 232539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalSeed.NativeMethodInfoPtr_TriggerExit_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x002087D8 File Offset: 0x002069D8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalSeed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalSeed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x00039017 File Offset: 0x00037217
		public FunctionalSeed(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002457 RID: 9303
		// (get) Token: 0x06007845 RID: 30789 RVA: 0x00208814 File Offset: 0x00206A14
		// (set) Token: 0x06007846 RID: 30790 RVA: 0x00039020 File Offset: 0x00037220
		public unsafe Action onSeedExitVial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_onSeedExitVial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_onSeedExitVial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002458 RID: 9304
		// (get) Token: 0x06007847 RID: 30791 RVA: 0x00208844 File Offset: 0x00206A44
		// (set) Token: 0x06007848 RID: 30792 RVA: 0x0003903F File Offset: 0x0003723F
		public unsafe Draggable Vial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Vial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Vial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002459 RID: 9305
		// (get) Token: 0x06007849 RID: 30793 RVA: 0x00208874 File Offset: 0x00206A74
		// (set) Token: 0x0600784A RID: 30794 RVA: 0x0003905E File Offset: 0x0003725E
		public unsafe Collider SeedBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700245A RID: 9306
		// (get) Token: 0x0600784B RID: 30795 RVA: 0x002088A4 File Offset: 0x00206AA4
		// (set) Token: 0x0600784C RID: 30796 RVA: 0x0003907D File Offset: 0x0003727D
		public unsafe VialCap Cap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Cap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VialCap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Cap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700245B RID: 9307
		// (get) Token: 0x0600784D RID: 30797 RVA: 0x002088D4 File Offset: 0x00206AD4
		// (set) Token: 0x0600784E RID: 30798 RVA: 0x0003909C File Offset: 0x0003729C
		public unsafe Collider SeedCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700245C RID: 9308
		// (get) Token: 0x0600784F RID: 30799 RVA: 0x00208904 File Offset: 0x00206B04
		// (set) Token: 0x06007850 RID: 30800 RVA: 0x000390BB File Offset: 0x000372BB
		public unsafe Rigidbody SeedRigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedRigidbody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedRigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700245D RID: 9309
		// (get) Token: 0x06007851 RID: 30801 RVA: 0x00208934 File Offset: 0x00206B34
		// (set) Token: 0x06007852 RID: 30802 RVA: 0x000390DA File Offset: 0x000372DA
		public unsafe TrashItem TrashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_TrashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_TrashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051F8 RID: 20984
		private static readonly IntPtr NativeFieldInfoPtr_onSeedExitVial;

		// Token: 0x040051F9 RID: 20985
		private static readonly IntPtr NativeFieldInfoPtr_Vial;

		// Token: 0x040051FA RID: 20986
		private static readonly IntPtr NativeFieldInfoPtr_SeedBlocker;

		// Token: 0x040051FB RID: 20987
		private static readonly IntPtr NativeFieldInfoPtr_Cap;

		// Token: 0x040051FC RID: 20988
		private static readonly IntPtr NativeFieldInfoPtr_SeedCollider;

		// Token: 0x040051FD RID: 20989
		private static readonly IntPtr NativeFieldInfoPtr_SeedRigidbody;

		// Token: 0x040051FE RID: 20990
		private static readonly IntPtr NativeFieldInfoPtr_TrashPrefab;

		// Token: 0x040051FF RID: 20991
		private static readonly IntPtr NativeMethodInfoPtr_TriggerExit_Public_Void_Collider_0;

		// Token: 0x04005200 RID: 20992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
