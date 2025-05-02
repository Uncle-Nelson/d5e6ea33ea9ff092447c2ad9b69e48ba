using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.StationFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000596 RID: 1430
	public class LiquidMethVisuals : MonoBehaviour
	{
		// Token: 0x06007DCA RID: 32202 RVA: 0x0021AD84 File Offset: 0x00218F84
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMethVisuals()
		{
			Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "LiquidMethVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr);
			LiquidMethVisuals.NativeFieldInfoPtr_StaticLiquidMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, "StaticLiquidMesh");
			LiquidMethVisuals.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, "LiquidContainer");
			LiquidMethVisuals.NativeFieldInfoPtr_PourParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, "PourParticles");
			LiquidMethVisuals.NativeMethodInfoPtr_Setup_Public_Void_LiquidMethDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, 100679023);
			LiquidMethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, 100679024);
		}

		// Token: 0x06007DCB RID: 32203 RVA: 0x0021AE18 File Offset: 0x00219018
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238396, RefRangeEnd = 238399, XrefRangeStart = 238377, XrefRangeEnd = 238396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(LiquidMethDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMethVisuals.NativeMethodInfoPtr_Setup_Public_Void_LiquidMethDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DCC RID: 32204 RVA: 0x0021AE5C File Offset: 0x0021905C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMethVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DCD RID: 32205 RVA: 0x0003BD01 File Offset: 0x00039F01
		public LiquidMethVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x06007DCE RID: 32206 RVA: 0x0021AE98 File Offset: 0x00219098
		// (set) Token: 0x06007DCF RID: 32207 RVA: 0x0003BD0A File Offset: 0x00039F0A
		public unsafe MeshRenderer StaticLiquidMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_StaticLiquidMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_StaticLiquidMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x06007DD0 RID: 32208 RVA: 0x0021AEC8 File Offset: 0x002190C8
		// (set) Token: 0x06007DD1 RID: 32209 RVA: 0x0003BD29 File Offset: 0x00039F29
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x06007DD2 RID: 32210 RVA: 0x0021AEF8 File Offset: 0x002190F8
		// (set) Token: 0x06007DD3 RID: 32211 RVA: 0x0003BD48 File Offset: 0x00039F48
		public unsafe ParticleSystem PourParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_PourParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_PourParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400558B RID: 21899
		private static readonly IntPtr NativeFieldInfoPtr_StaticLiquidMesh;

		// Token: 0x0400558C RID: 21900
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x0400558D RID: 21901
		private static readonly IntPtr NativeFieldInfoPtr_PourParticles;

		// Token: 0x0400558E RID: 21902
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_LiquidMethDefinition_0;

		// Token: 0x0400558F RID: 21903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
