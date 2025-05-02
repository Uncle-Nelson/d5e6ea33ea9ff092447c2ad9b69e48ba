using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000C9 RID: 201
	public class RandomRotation : MonoBehaviour
	{
		// Token: 0x06000EED RID: 3821 RVA: 0x0009FDAC File Offset: 0x0009DFAC
		// Note: this type is marked as 'beforefieldinit'.
		static RandomRotation()
		{
			Il2CppClassPointerStore<RandomRotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "RandomRotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr);
			RandomRotation.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, "speed");
			RandomRotation.NativeFieldInfoPtr_randomChangeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, "randomChangeInterval");
			RandomRotation.NativeFieldInfoPtr_lastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, "lastTime");
			RandomRotation.NativeFieldInfoPtr_v = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, "v");
			RandomRotation.NativeFieldInfoPtr_randomization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, "randomization");
			RandomRotation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, 100665070);
			RandomRotation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, 100665071);
			RandomRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, 100665072);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0009FE7C File Offset: 0x0009E07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86072, XrefRangeEnd = 86073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomRotation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0009FEB0 File Offset: 0x0009E0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86073, XrefRangeEnd = 86081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomRotation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0009FEE4 File Offset: 0x0009E0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86081, XrefRangeEnd = 86082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomRotation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0000957C File Offset: 0x0000777C
		public RandomRotation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x0009FF20 File Offset: 0x0009E120
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x00009585 File Offset: 0x00007785
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x0009FF48 File Offset: 0x0009E148
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x000095A0 File Offset: 0x000077A0
		public unsafe float randomChangeInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_randomChangeInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_randomChangeInterval)) = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x0009FF70 File Offset: 0x0009E170
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x000095BB File Offset: 0x000077BB
		public unsafe float lastTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_lastTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_lastTime)) = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x0009FF98 File Offset: 0x0009E198
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x000095D6 File Offset: 0x000077D6
		public unsafe Vector3 v
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_v);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_v)) = value;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x0009FFC0 File Offset: 0x0009E1C0
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x000095F1 File Offset: 0x000077F1
		public unsafe float randomization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_randomization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomRotation.NativeFieldInfoPtr_randomization)) = value;
			}
		}

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeFieldInfoPtr_randomChangeInterval;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeFieldInfoPtr_lastTime;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeFieldInfoPtr_v;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeFieldInfoPtr_randomization;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
