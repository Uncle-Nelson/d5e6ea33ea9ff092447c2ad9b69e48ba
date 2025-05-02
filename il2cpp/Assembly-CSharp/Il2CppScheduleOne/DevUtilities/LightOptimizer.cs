using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000459 RID: 1113
	public class LightOptimizer : MonoBehaviour
	{
		// Token: 0x060060AF RID: 24751 RVA: 0x001B9F1C File Offset: 0x001B811C
		// Note: this type is marked as 'beforefieldinit'.
		static LightOptimizer()
		{
			Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "LightOptimizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr);
			LightOptimizer.NativeFieldInfoPtr_LightsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "LightsEnabled");
			LightOptimizer.NativeFieldInfoPtr_activationZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "activationZones");
			LightOptimizer.NativeFieldInfoPtr_viewPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "viewPoints");
			LightOptimizer.NativeFieldInfoPtr_checkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "checkRange");
			LightOptimizer.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "lights");
			LightOptimizer.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675595);
			LightOptimizer.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675596);
			LightOptimizer.NativeMethodInfoPtr_ApplyLights_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675597);
			LightOptimizer.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675598);
			LightOptimizer.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675599);
			LightOptimizer.NativeMethodInfoPtr_LightsEnabled_True_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675600);
			LightOptimizer.NativeMethodInfoPtr_LightsEnabled_False_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675601);
			LightOptimizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675602);
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x001BA050 File Offset: 0x001B8250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199582, XrefRangeEnd = 199586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x001BA084 File Offset: 0x001B8284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199586, XrefRangeEnd = 199611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x001BA0B8 File Offset: 0x001B82B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199612, RefRangeEnd = 199613, XrefRangeStart = 199611, XrefRangeEnd = 199612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_ApplyLights_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060B3 RID: 24755 RVA: 0x001BA0EC File Offset: 0x001B82EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199613, XrefRangeEnd = 199639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointInCameraView(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060B4 RID: 24756 RVA: 0x001BA138 File Offset: 0x001B8338
		[CallerCount(0)]
		public unsafe bool Is01(float a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060B5 RID: 24757 RVA: 0x001BA184 File Offset: 0x001B8384
		[CallerCount(0)]
		public unsafe void LightsEnabled_True()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_LightsEnabled_True_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060B6 RID: 24758 RVA: 0x001BA1B8 File Offset: 0x001B83B8
		[CallerCount(0)]
		public unsafe void LightsEnabled_False()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_LightsEnabled_False_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060B7 RID: 24759 RVA: 0x001BA1EC File Offset: 0x001B83EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199639, XrefRangeEnd = 199640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightOptimizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060B8 RID: 24760 RVA: 0x0002DBBA File Offset: 0x0002BDBA
		public LightOptimizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x060060B9 RID: 24761 RVA: 0x001BA228 File Offset: 0x001B8428
		// (set) Token: 0x060060BA RID: 24762 RVA: 0x0002DBC3 File Offset: 0x0002BDC3
		public unsafe bool LightsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_LightsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_LightsEnabled)) = value;
			}
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x060060BB RID: 24763 RVA: 0x001BA250 File Offset: 0x001B8450
		// (set) Token: 0x060060BC RID: 24764 RVA: 0x0002DBDE File Offset: 0x0002BDDE
		public unsafe Il2CppReferenceArray<BoxCollider> activationZones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_activationZones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoxCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_activationZones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x060060BD RID: 24765 RVA: 0x001BA280 File Offset: 0x001B8480
		// (set) Token: 0x060060BE RID: 24766 RVA: 0x0002DBFD File Offset: 0x0002BDFD
		public unsafe Il2CppReferenceArray<Transform> viewPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_viewPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_viewPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x060060BF RID: 24767 RVA: 0x001BA2B0 File Offset: 0x001B84B0
		// (set) Token: 0x060060C0 RID: 24768 RVA: 0x0002DC1C File Offset: 0x0002BE1C
		public unsafe float checkRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_checkRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_checkRange)) = value;
			}
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x060060C1 RID: 24769 RVA: 0x001BA2D8 File Offset: 0x001B84D8
		// (set) Token: 0x060060C2 RID: 24770 RVA: 0x0002DC37 File Offset: 0x0002BE37
		public unsafe Il2CppReferenceArray<OptimizedLight> lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041FD RID: 16893
		private static readonly IntPtr NativeFieldInfoPtr_LightsEnabled;

		// Token: 0x040041FE RID: 16894
		private static readonly IntPtr NativeFieldInfoPtr_activationZones;

		// Token: 0x040041FF RID: 16895
		private static readonly IntPtr NativeFieldInfoPtr_viewPoints;

		// Token: 0x04004200 RID: 16896
		private static readonly IntPtr NativeFieldInfoPtr_checkRange;

		// Token: 0x04004201 RID: 16897
		private static readonly IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x04004202 RID: 16898
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04004203 RID: 16899
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04004204 RID: 16900
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLights_Public_Void_0;

		// Token: 0x04004205 RID: 16901
		private static readonly IntPtr NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0;

		// Token: 0x04004206 RID: 16902
		private static readonly IntPtr NativeMethodInfoPtr_Is01_Public_Boolean_Single_0;

		// Token: 0x04004207 RID: 16903
		private static readonly IntPtr NativeMethodInfoPtr_LightsEnabled_True_Public_Void_0;

		// Token: 0x04004208 RID: 16904
		private static readonly IntPtr NativeMethodInfoPtr_LightsEnabled_False_Public_Void_0;

		// Token: 0x04004209 RID: 16905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
