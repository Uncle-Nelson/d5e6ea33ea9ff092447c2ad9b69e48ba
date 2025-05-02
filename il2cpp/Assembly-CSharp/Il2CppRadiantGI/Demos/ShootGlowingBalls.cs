using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRadiantGI.Demos
{
	// Token: 0x020000C6 RID: 198
	public class ShootGlowingBalls : MonoBehaviour
	{
		// Token: 0x06000EC6 RID: 3782 RVA: 0x0009F774 File Offset: 0x0009D974
		// Note: this type is marked as 'beforefieldinit'.
		static ShootGlowingBalls()
		{
			Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RadiantGI.Demos", "ShootGlowingBalls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr);
			ShootGlowingBalls.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr, "count");
			ShootGlowingBalls.NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr, "center");
			ShootGlowingBalls.NativeFieldInfoPtr_glowingBall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr, "glowingBall");
			ShootGlowingBalls.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr, 100665055);
			ShootGlowingBalls.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr, 100665056);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x0009F808 File Offset: 0x0009DA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85927, XrefRangeEnd = 85959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShootGlowingBalls.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x0009F83C File Offset: 0x0009DA3C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShootGlowingBalls() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShootGlowingBalls>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShootGlowingBalls.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00009416 File Offset: 0x00007616
		public ShootGlowingBalls(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0009F878 File Offset: 0x0009DA78
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x0000941F File Offset: 0x0000761F
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShootGlowingBalls.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShootGlowingBalls.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x0009F8A0 File Offset: 0x0009DAA0
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x0000943A File Offset: 0x0000763A
		public unsafe Transform center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShootGlowingBalls.NativeFieldInfoPtr_center);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShootGlowingBalls.NativeFieldInfoPtr_center), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0009F8D0 File Offset: 0x0009DAD0
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x00009459 File Offset: 0x00007659
		public unsafe GameObject glowingBall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShootGlowingBalls.NativeFieldInfoPtr_glowingBall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShootGlowingBalls.NativeFieldInfoPtr_glowingBall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeFieldInfoPtr_center;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeFieldInfoPtr_glowingBall;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
