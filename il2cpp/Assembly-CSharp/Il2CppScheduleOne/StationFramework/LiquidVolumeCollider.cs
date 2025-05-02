using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200058E RID: 1422
	public class LiquidVolumeCollider : MonoBehaviour
	{
		// Token: 0x06007D29 RID: 32041 RVA: 0x002190E0 File Offset: 0x002172E0
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidVolumeCollider()
		{
			Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidVolumeCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr);
			LiquidVolumeCollider.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr, "LiquidContainer");
			LiquidVolumeCollider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr, 100678967);
			LiquidVolumeCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr, 100678968);
		}

		// Token: 0x06007D2A RID: 32042 RVA: 0x0021914C File Offset: 0x0021734C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237917, XrefRangeEnd = 237925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeCollider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D2B RID: 32043 RVA: 0x00219180 File Offset: 0x00217380
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidVolumeCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D2C RID: 32044 RVA: 0x0003B71F File Offset: 0x0003991F
		public LiquidVolumeCollider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025DD RID: 9693
		// (get) Token: 0x06007D2D RID: 32045 RVA: 0x002191BC File Offset: 0x002173BC
		// (set) Token: 0x06007D2E RID: 32046 RVA: 0x0003B728 File Offset: 0x00039928
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeCollider.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeCollider.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400552C RID: 21804
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x0400552D RID: 21805
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400552E RID: 21806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
