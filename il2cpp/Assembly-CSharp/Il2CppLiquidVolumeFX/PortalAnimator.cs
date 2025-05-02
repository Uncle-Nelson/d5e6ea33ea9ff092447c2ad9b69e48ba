using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000CE RID: 206
	public class PortalAnimator : MonoBehaviour
	{
		// Token: 0x06000F48 RID: 3912 RVA: 0x000A0A6C File Offset: 0x0009EC6C
		// Note: this type is marked as 'beforefieldinit'.
		static PortalAnimator()
		{
			Il2CppClassPointerStore<PortalAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "PortalAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PortalAnimator>.NativeClassPtr);
			PortalAnimator.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalAnimator>.NativeClassPtr, "delay");
			PortalAnimator.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalAnimator>.NativeClassPtr, "duration");
			PortalAnimator.NativeFieldInfoPtr_delayFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalAnimator>.NativeClassPtr, "delayFadeOut");
			PortalAnimator.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalAnimator>.NativeClassPtr, "scale");
			PortalAnimator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalAnimator>.NativeClassPtr, 100665083);
			PortalAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalAnimator>.NativeClassPtr, 100665084);
			PortalAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalAnimator>.NativeClassPtr, 100665085);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x000A0B28 File Offset: 0x0009ED28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86227, XrefRangeEnd = 86233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PortalAnimator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x000A0B5C File Offset: 0x0009ED5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86233, XrefRangeEnd = 86241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PortalAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000A0B90 File Offset: 0x0009ED90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86241, XrefRangeEnd = 86242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PortalAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PortalAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PortalAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00009943 File Offset: 0x00007B43
		public PortalAnimator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x000A0BCC File Offset: 0x0009EDCC
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x0000994C File Offset: 0x00007B4C
		public unsafe float delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PortalAnimator.NativeFieldInfoPtr_delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PortalAnimator.NativeFieldInfoPtr_delay)) = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x000A0BF4 File Offset: 0x0009EDF4
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x00009967 File Offset: 0x00007B67
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PortalAnimator.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PortalAnimator.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x000A0C1C File Offset: 0x0009EE1C
		// (set) Token: 0x06000F52 RID: 3922 RVA: 0x00009982 File Offset: 0x00007B82
		public unsafe float delayFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PortalAnimator.NativeFieldInfoPtr_delayFadeOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PortalAnimator.NativeFieldInfoPtr_delayFadeOut)) = value;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x000A0C44 File Offset: 0x0009EE44
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x0000999D File Offset: 0x00007B9D
		public unsafe Vector3 scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PortalAnimator.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PortalAnimator.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeFieldInfoPtr_delay;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeFieldInfoPtr_delayFadeOut;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
