using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000039 RID: 57
	public class FlockScare : MonoBehaviour
	{
		// Token: 0x060004BB RID: 1211 RVA: 0x0007E2E4 File Offset: 0x0007C4E4
		// Note: this type is marked as 'beforefieldinit'.
		static FlockScare()
		{
			Il2CppClassPointerStore<FlockScare>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlockScare");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlockScare>.NativeClassPtr);
			FlockScare.NativeFieldInfoPtr_landingSpotControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "landingSpotControllers");
			FlockScare.NativeFieldInfoPtr_scareInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "scareInterval");
			FlockScare.NativeFieldInfoPtr_distanceToScare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "distanceToScare");
			FlockScare.NativeFieldInfoPtr_checkEveryNthLandingSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "checkEveryNthLandingSpot");
			FlockScare.NativeFieldInfoPtr_InvokeAmounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "InvokeAmounts");
			FlockScare.NativeFieldInfoPtr_lsc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "lsc");
			FlockScare.NativeFieldInfoPtr_ls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "ls");
			FlockScare.NativeFieldInfoPtr_currentController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "currentController");
			FlockScare.NativeMethodInfoPtr_CheckProximityToLandingSpots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, 100663688);
			FlockScare.NativeMethodInfoPtr_IterateLandingSpots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, 100663689);
			FlockScare.NativeMethodInfoPtr_CheckDistanceToLandingSpot_Private_Boolean_LandingSpotController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, 100663690);
			FlockScare.NativeMethodInfoPtr_Invoker_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, 100663691);
			FlockScare.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, 100663692);
			FlockScare.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, 100663693);
			FlockScare.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, 100663694);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0007E440 File Offset: 0x0007C640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74307, XrefRangeEnd = 74329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProximityToLandingSpots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockScare.NativeMethodInfoPtr_CheckProximityToLandingSpots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0007E474 File Offset: 0x0007C674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74329, XrefRangeEnd = 74332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateLandingSpots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockScare.NativeMethodInfoPtr_IterateLandingSpots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0007E4A8 File Offset: 0x0007C6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74332, XrefRangeEnd = 74344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckDistanceToLandingSpot(LandingSpotController lc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockScare.NativeMethodInfoPtr_CheckDistanceToLandingSpot_Private_Boolean_LandingSpotController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0007E4F8 File Offset: 0x0007C6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74344, XrefRangeEnd = 74347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockScare.NativeMethodInfoPtr_Invoker_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0007E52C File Offset: 0x0007C72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74347, XrefRangeEnd = 74353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockScare.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0007E560 File Offset: 0x0007C760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74353, XrefRangeEnd = 74356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockScare.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0007E594 File Offset: 0x0007C794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74356, XrefRangeEnd = 74357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlockScare() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlockScare>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockScare.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00004D60 File Offset: 0x00002F60
		public FlockScare(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0007E5D0 File Offset: 0x0007C7D0
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00004D69 File Offset: 0x00002F69
		public unsafe Il2CppReferenceArray<LandingSpotController> landingSpotControllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_landingSpotControllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LandingSpotController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_landingSpotControllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0007E600 File Offset: 0x0007C800
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00004D88 File Offset: 0x00002F88
		public unsafe float scareInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_scareInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_scareInterval)) = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0007E628 File Offset: 0x0007C828
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00004DA3 File Offset: 0x00002FA3
		public unsafe float distanceToScare
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_distanceToScare);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_distanceToScare)) = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0007E650 File Offset: 0x0007C850
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00004DBE File Offset: 0x00002FBE
		public unsafe int checkEveryNthLandingSpot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_checkEveryNthLandingSpot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_checkEveryNthLandingSpot)) = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x0007E678 File Offset: 0x0007C878
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00004DD9 File Offset: 0x00002FD9
		public unsafe int InvokeAmounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_InvokeAmounts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_InvokeAmounts)) = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0007E6A0 File Offset: 0x0007C8A0
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00004DF4 File Offset: 0x00002FF4
		public unsafe int lsc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_lsc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_lsc)) = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0007E6C8 File Offset: 0x0007C8C8
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00004E0F File Offset: 0x0000300F
		public unsafe int ls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_ls);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_ls)) = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x0007E6F0 File Offset: 0x0007C8F0
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00004E2A File Offset: 0x0000302A
		public unsafe LandingSpotController currentController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_currentController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpotController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_currentController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr_landingSpotControllers;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr_scareInterval;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_distanceToScare;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr_checkEveryNthLandingSpot;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr_InvokeAmounts;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr_lsc;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr_ls;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr_currentController;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_CheckProximityToLandingSpots_Private_Void_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_IterateLandingSpots_Private_Void_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_CheckDistanceToLandingSpot_Private_Boolean_LandingSpotController_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_Invoker_Private_Void_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
