using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A3 RID: 931
	public class VisibilityController : MonoBehaviour
	{
		// Token: 0x060048ED RID: 18669 RVA: 0x001643BC File Offset: 0x001625BC
		// Note: this type is marked as 'beforefieldinit'.
		static VisibilityController()
		{
			Il2CppClassPointerStore<VisibilityController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "VisibilityController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr);
			VisibilityController.NativeFieldInfoPtr_visibleOnlyInFullscreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, "visibleOnlyInFullscreen");
			VisibilityController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, 100672338);
			VisibilityController.NativeMethodInfoPtr_OnEnterFullScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, 100672339);
			VisibilityController.NativeMethodInfoPtr_OnExitFullScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, 100672340);
			VisibilityController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, 100672341);
		}

		// Token: 0x060048EE RID: 18670 RVA: 0x00164450 File Offset: 0x00162650
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048EF RID: 18671 RVA: 0x00164484 File Offset: 0x00162684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162887, XrefRangeEnd = 162889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnterFullScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityController.NativeMethodInfoPtr_OnEnterFullScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048F0 RID: 18672 RVA: 0x001644B8 File Offset: 0x001626B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162889, XrefRangeEnd = 162891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnExitFullScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityController.NativeMethodInfoPtr_OnExitFullScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x001644EC File Offset: 0x001626EC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 162892, RefRangeEnd = 162908, XrefRangeStart = 162891, XrefRangeEnd = 162892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibilityController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x0002328C File Offset: 0x0002148C
		public VisibilityController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x060048F3 RID: 18675 RVA: 0x00164528 File Offset: 0x00162728
		// (set) Token: 0x060048F4 RID: 18676 RVA: 0x00023295 File Offset: 0x00021495
		public unsafe bool visibleOnlyInFullscreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityController.NativeFieldInfoPtr_visibleOnlyInFullscreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityController.NativeFieldInfoPtr_visibleOnlyInFullscreen)) = value;
			}
		}

		// Token: 0x04003133 RID: 12595
		private static readonly IntPtr NativeFieldInfoPtr_visibleOnlyInFullscreen;

		// Token: 0x04003134 RID: 12596
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003135 RID: 12597
		private static readonly IntPtr NativeMethodInfoPtr_OnEnterFullScreen_Private_Void_0;

		// Token: 0x04003136 RID: 12598
		private static readonly IntPtr NativeMethodInfoPtr_OnExitFullScreen_Private_Void_0;

		// Token: 0x04003137 RID: 12599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
