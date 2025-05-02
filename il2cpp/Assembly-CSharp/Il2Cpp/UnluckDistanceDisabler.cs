using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000033 RID: 51
	public class UnluckDistanceDisabler : MonoBehaviour
	{
		// Token: 0x06000392 RID: 914 RVA: 0x0007B6E8 File Offset: 0x000798E8
		// Note: this type is marked as 'beforefieldinit'.
		static UnluckDistanceDisabler()
		{
			Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UnluckDistanceDisabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr);
			UnluckDistanceDisabler.NativeFieldInfoPtr__distanceDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, "_distanceDisable");
			UnluckDistanceDisabler.NativeFieldInfoPtr__distanceFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, "_distanceFrom");
			UnluckDistanceDisabler.NativeFieldInfoPtr__distanceFromMainCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, "_distanceFromMainCam");
			UnluckDistanceDisabler.NativeFieldInfoPtr__disableCheckInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, "_disableCheckInterval");
			UnluckDistanceDisabler.NativeFieldInfoPtr__enableCheckInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, "_enableCheckInterval");
			UnluckDistanceDisabler.NativeFieldInfoPtr__disableOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, "_disableOnStart");
			UnluckDistanceDisabler.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, 100663637);
			UnluckDistanceDisabler.NativeMethodInfoPtr_DisableOnStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, 100663638);
			UnluckDistanceDisabler.NativeMethodInfoPtr_CheckDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, 100663639);
			UnluckDistanceDisabler.NativeMethodInfoPtr_CheckEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, 100663640);
			UnluckDistanceDisabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, 100663641);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0007B7F4 File Offset: 0x000799F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73697, XrefRangeEnd = 73712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnluckDistanceDisabler.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0007B828 File Offset: 0x00079A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73712, XrefRangeEnd = 73714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableOnStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnluckDistanceDisabler.NativeMethodInfoPtr_DisableOnStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0007B85C File Offset: 0x00079A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73714, XrefRangeEnd = 73721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnluckDistanceDisabler.NativeMethodInfoPtr_CheckDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0007B890 File Offset: 0x00079A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73721, XrefRangeEnd = 73728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnluckDistanceDisabler.NativeMethodInfoPtr_CheckEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0007B8C4 File Offset: 0x00079AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73728, XrefRangeEnd = 73729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnluckDistanceDisabler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnluckDistanceDisabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000408C File Offset: 0x0000228C
		public UnluckDistanceDisabler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000399 RID: 921 RVA: 0x0007B900 File Offset: 0x00079B00
		// (set) Token: 0x0600039A RID: 922 RVA: 0x00004095 File Offset: 0x00002295
		public unsafe int _distanceDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__distanceDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__distanceDisable)) = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0007B928 File Offset: 0x00079B28
		// (set) Token: 0x0600039C RID: 924 RVA: 0x000040B0 File Offset: 0x000022B0
		public unsafe Transform _distanceFrom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__distanceFrom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__distanceFrom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0007B958 File Offset: 0x00079B58
		// (set) Token: 0x0600039E RID: 926 RVA: 0x000040CF File Offset: 0x000022CF
		public unsafe bool _distanceFromMainCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__distanceFromMainCam);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__distanceFromMainCam)) = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0007B980 File Offset: 0x00079B80
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x000040EA File Offset: 0x000022EA
		public unsafe float _disableCheckInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__disableCheckInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__disableCheckInterval)) = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0007B9A8 File Offset: 0x00079BA8
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00004105 File Offset: 0x00002305
		public unsafe float _enableCheckInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__enableCheckInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__enableCheckInterval)) = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0007B9D0 File Offset: 0x00079BD0
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x00004120 File Offset: 0x00002320
		public unsafe bool _disableOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__disableOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__disableOnStart)) = value;
			}
		}

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr__distanceDisable;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr__distanceFrom;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeFieldInfoPtr__distanceFromMainCam;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeFieldInfoPtr__disableCheckInterval;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeFieldInfoPtr__enableCheckInterval;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeFieldInfoPtr__disableOnStart;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_DisableOnStart_Public_Void_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_CheckDisable_Public_Void_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_CheckEnable_Public_Void_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
