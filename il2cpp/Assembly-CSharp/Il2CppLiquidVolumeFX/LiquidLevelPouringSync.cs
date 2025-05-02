using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000D2 RID: 210
	public class LiquidLevelPouringSync : MonoBehaviour
	{
		// Token: 0x06000F96 RID: 3990 RVA: 0x000A152C File Offset: 0x0009F72C
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidLevelPouringSync()
		{
			Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "LiquidLevelPouringSync");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr);
			LiquidLevelPouringSync.NativeFieldInfoPtr_fillSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, "fillSpeed");
			LiquidLevelPouringSync.NativeFieldInfoPtr_sinkFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, "sinkFactor");
			LiquidLevelPouringSync.NativeFieldInfoPtr_lv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, "lv");
			LiquidLevelPouringSync.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, "rb");
			LiquidLevelPouringSync.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, 100665093);
			LiquidLevelPouringSync.NativeMethodInfoPtr_OnParticleCollision_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, 100665094);
			LiquidLevelPouringSync.NativeMethodInfoPtr_UpdateColliderPos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, 100665095);
			LiquidLevelPouringSync.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, 100665096);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x000A15FC File Offset: 0x0009F7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86359, XrefRangeEnd = 86371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelPouringSync.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x000A1630 File Offset: 0x0009F830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86371, XrefRangeEnd = 86374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnParticleCollision(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelPouringSync.NativeMethodInfoPtr_OnParticleCollision_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x000A1674 File Offset: 0x0009F874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86389, RefRangeEnd = 86391, XrefRangeStart = 86374, XrefRangeEnd = 86389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateColliderPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelPouringSync.NativeMethodInfoPtr_UpdateColliderPos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x000A16A8 File Offset: 0x0009F8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86391, XrefRangeEnd = 86392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidLevelPouringSync() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelPouringSync.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00009C95 File Offset: 0x00007E95
		public LiquidLevelPouringSync(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x000A16E4 File Offset: 0x0009F8E4
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x00009C9E File Offset: 0x00007E9E
		public unsafe float fillSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_fillSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_fillSpeed)) = value;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x000A170C File Offset: 0x0009F90C
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x00009CB9 File Offset: 0x00007EB9
		public unsafe float sinkFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_sinkFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_sinkFactor)) = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x000A1734 File Offset: 0x0009F934
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x00009CD4 File Offset: 0x00007ED4
		public unsafe LiquidVolume lv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_lv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_lv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x000A1764 File Offset: 0x0009F964
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x00009CF3 File Offset: 0x00007EF3
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeFieldInfoPtr_fillSpeed;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeFieldInfoPtr_sinkFactor;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeFieldInfoPtr_lv;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_OnParticleCollision_Private_Void_GameObject_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColliderPos_Private_Void_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
