using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000555 RID: 1365
	public class WheelRotator : MonoBehaviour
	{
		// Token: 0x0600782E RID: 30766 RVA: 0x002083EC File Offset: 0x002065EC
		// Note: this type is marked as 'beforefieldinit'.
		static WheelRotator()
		{
			Il2CppClassPointerStore<WheelRotator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "WheelRotator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr);
			WheelRotator.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Radius");
			WheelRotator.NativeFieldInfoPtr_Wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Wheel");
			WheelRotator.NativeFieldInfoPtr_Flip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Flip");
			WheelRotator.NativeFieldInfoPtr_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Controller");
			WheelRotator.NativeFieldInfoPtr_AudioVolumeDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "AudioVolumeDivisor");
			WheelRotator.NativeFieldInfoPtr_RotationAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "RotationAxis");
			WheelRotator.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "lastFramePosition");
			WheelRotator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, 100678404);
			WheelRotator.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, 100678405);
			WheelRotator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, 100678406);
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x002084E4 File Offset: 0x002066E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232499, XrefRangeEnd = 232507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelRotator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007830 RID: 30768 RVA: 0x00208518 File Offset: 0x00206718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232507, XrefRangeEnd = 232521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelRotator.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007831 RID: 30769 RVA: 0x0020854C File Offset: 0x0020674C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232521, XrefRangeEnd = 232535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WheelRotator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelRotator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007832 RID: 30770 RVA: 0x00038F49 File Offset: 0x00037149
		public WheelRotator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002450 RID: 9296
		// (get) Token: 0x06007833 RID: 30771 RVA: 0x00208588 File Offset: 0x00206788
		// (set) Token: 0x06007834 RID: 30772 RVA: 0x00038F52 File Offset: 0x00037152
		public unsafe float Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x06007835 RID: 30773 RVA: 0x002085B0 File Offset: 0x002067B0
		// (set) Token: 0x06007836 RID: 30774 RVA: 0x00038F6D File Offset: 0x0003716D
		public unsafe Transform Wheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Wheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Wheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x06007837 RID: 30775 RVA: 0x002085E0 File Offset: 0x002067E0
		// (set) Token: 0x06007838 RID: 30776 RVA: 0x00038F8C File Offset: 0x0003718C
		public unsafe bool Flip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Flip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Flip)) = value;
			}
		}

		// Token: 0x17002453 RID: 9299
		// (get) Token: 0x06007839 RID: 30777 RVA: 0x00208608 File Offset: 0x00206808
		// (set) Token: 0x0600783A RID: 30778 RVA: 0x00038FA7 File Offset: 0x000371A7
		public unsafe AudioSourceController Controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x0600783B RID: 30779 RVA: 0x00208638 File Offset: 0x00206838
		// (set) Token: 0x0600783C RID: 30780 RVA: 0x00038FC6 File Offset: 0x000371C6
		public unsafe float AudioVolumeDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_AudioVolumeDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_AudioVolumeDivisor)) = value;
			}
		}

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x0600783D RID: 30781 RVA: 0x00208660 File Offset: 0x00206860
		// (set) Token: 0x0600783E RID: 30782 RVA: 0x00038FE1 File Offset: 0x000371E1
		public unsafe Vector3 RotationAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_RotationAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_RotationAxis)) = value;
			}
		}

		// Token: 0x17002456 RID: 9302
		// (get) Token: 0x0600783F RID: 30783 RVA: 0x00208688 File Offset: 0x00206888
		// (set) Token: 0x06007840 RID: 30784 RVA: 0x00038FFC File Offset: 0x000371FC
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x040051EE RID: 20974
		private static readonly IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x040051EF RID: 20975
		private static readonly IntPtr NativeFieldInfoPtr_Wheel;

		// Token: 0x040051F0 RID: 20976
		private static readonly IntPtr NativeFieldInfoPtr_Flip;

		// Token: 0x040051F1 RID: 20977
		private static readonly IntPtr NativeFieldInfoPtr_Controller;

		// Token: 0x040051F2 RID: 20978
		private static readonly IntPtr NativeFieldInfoPtr_AudioVolumeDivisor;

		// Token: 0x040051F3 RID: 20979
		private static readonly IntPtr NativeFieldInfoPtr_RotationAxis;

		// Token: 0x040051F4 RID: 20980
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x040051F5 RID: 20981
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040051F6 RID: 20982
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040051F7 RID: 20983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
