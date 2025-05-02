using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200058D RID: 1421
	public class LiquidLevelVisuals : MonoBehaviour
	{
		// Token: 0x06007D1D RID: 32029 RVA: 0x00218F08 File Offset: 0x00217108
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidLevelVisuals()
		{
			Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidLevelVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr);
			LiquidLevelVisuals.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "Container");
			LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "LiquidSurface");
			LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "LiquidSurface_Min");
			LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "LiquidSurface_Max");
			LiquidLevelVisuals.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, 100678965);
			LiquidLevelVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, 100678966);
		}

		// Token: 0x06007D1E RID: 32030 RVA: 0x00218FB0 File Offset: 0x002171B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237904, XrefRangeEnd = 237917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelVisuals.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D1F RID: 32031 RVA: 0x00218FE4 File Offset: 0x002171E4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidLevelVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D20 RID: 32032 RVA: 0x0003B69A File Offset: 0x0003989A
		public LiquidLevelVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025D9 RID: 9689
		// (get) Token: 0x06007D21 RID: 32033 RVA: 0x00219020 File Offset: 0x00217220
		// (set) Token: 0x06007D22 RID: 32034 RVA: 0x0003B6A3 File Offset: 0x000398A3
		public unsafe LiquidContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025DA RID: 9690
		// (get) Token: 0x06007D23 RID: 32035 RVA: 0x00219050 File Offset: 0x00217250
		// (set) Token: 0x06007D24 RID: 32036 RVA: 0x0003B6C2 File Offset: 0x000398C2
		public unsafe Transform LiquidSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025DB RID: 9691
		// (get) Token: 0x06007D25 RID: 32037 RVA: 0x00219080 File Offset: 0x00217280
		// (set) Token: 0x06007D26 RID: 32038 RVA: 0x0003B6E1 File Offset: 0x000398E1
		public unsafe Transform LiquidSurface_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025DC RID: 9692
		// (get) Token: 0x06007D27 RID: 32039 RVA: 0x002190B0 File Offset: 0x002172B0
		// (set) Token: 0x06007D28 RID: 32040 RVA: 0x0003B700 File Offset: 0x00039900
		public unsafe Transform LiquidSurface_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005526 RID: 21798
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005527 RID: 21799
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSurface;

		// Token: 0x04005528 RID: 21800
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSurface_Min;

		// Token: 0x04005529 RID: 21801
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSurface_Max;

		// Token: 0x0400552A RID: 21802
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400552B RID: 21803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
