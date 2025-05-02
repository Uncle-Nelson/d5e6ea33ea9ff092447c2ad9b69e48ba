using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x020003FB RID: 1019
	public class ProximityCircle : MonoBehaviour
	{
		// Token: 0x060054F3 RID: 21747 RVA: 0x0018D62C File Offset: 0x0018B82C
		// Note: this type is marked as 'beforefieldinit'.
		static ProximityCircle()
		{
			Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "ProximityCircle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr);
			ProximityCircle.NativeFieldInfoPtr_Circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, "Circle");
			ProximityCircle.NativeFieldInfoPtr_enabledThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, "enabledThisFrame");
			ProximityCircle.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673850);
			ProximityCircle.NativeMethodInfoPtr_SetRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673851);
			ProximityCircle.NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673852);
			ProximityCircle.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673853);
			ProximityCircle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673854);
		}

		// Token: 0x060054F4 RID: 21748 RVA: 0x0018D6E8 File Offset: 0x0018B8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180439, XrefRangeEnd = 180441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x0018D71C File Offset: 0x0018B91C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 180442, RefRangeEnd = 180444, XrefRangeStart = 180441, XrefRangeEnd = 180442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRadius(float rad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rad;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_SetRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054F6 RID: 21750 RVA: 0x0018D75C File Offset: 0x0018B95C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 180447, RefRangeEnd = 180454, XrefRangeStart = 180444, XrefRangeEnd = 180447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054F7 RID: 21751 RVA: 0x0018D79C File Offset: 0x0018B99C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 180455, RefRangeEnd = 180459, XrefRangeStart = 180454, XrefRangeEnd = 180455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054F8 RID: 21752 RVA: 0x0018D7DC File Offset: 0x0018B9DC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProximityCircle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054F9 RID: 21753 RVA: 0x00028CCD File Offset: 0x00026ECD
		public ProximityCircle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x060054FA RID: 21754 RVA: 0x0018D818 File Offset: 0x0018BA18
		// (set) Token: 0x060054FB RID: 21755 RVA: 0x00028CD6 File Offset: 0x00026ED6
		public unsafe DecalProjector Circle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_Circle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_Circle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x060054FC RID: 21756 RVA: 0x0018D848 File Offset: 0x0018BA48
		// (set) Token: 0x060054FD RID: 21757 RVA: 0x00028CF5 File Offset: 0x00026EF5
		public unsafe bool enabledThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_enabledThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_enabledThisFrame)) = value;
			}
		}

		// Token: 0x0400397B RID: 14715
		private static readonly IntPtr NativeFieldInfoPtr_Circle;

		// Token: 0x0400397C RID: 14716
		private static readonly IntPtr NativeFieldInfoPtr_enabledThisFrame;

		// Token: 0x0400397D RID: 14717
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400397E RID: 14718
		private static readonly IntPtr NativeMethodInfoPtr_SetRadius_Public_Void_Single_0;

		// Token: 0x0400397F RID: 14719
		private static readonly IntPtr NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0;

		// Token: 0x04003980 RID: 14720
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x04003981 RID: 14721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
