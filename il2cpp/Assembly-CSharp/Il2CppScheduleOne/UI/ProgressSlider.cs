using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200065F RID: 1631
	public class ProgressSlider : Singleton<ProgressSlider>
	{
		// Token: 0x060091B7 RID: 37303 RVA: 0x0025A0F8 File Offset: 0x002582F8
		// Note: this type is marked as 'beforefieldinit'.
		static ProgressSlider()
		{
			Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ProgressSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr);
			ProgressSlider.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "Container");
			ProgressSlider.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "Label");
			ProgressSlider.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "Slider");
			ProgressSlider.NativeFieldInfoPtr_SliderFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "SliderFill");
			ProgressSlider.NativeFieldInfoPtr_progressSetThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "progressSetThisFrame");
			ProgressSlider.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100681358);
			ProgressSlider.NativeMethodInfoPtr_ShowProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100681359);
			ProgressSlider.NativeMethodInfoPtr_Configure_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100681360);
			ProgressSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100681361);
		}

		// Token: 0x060091B8 RID: 37304 RVA: 0x0025A1DC File Offset: 0x002583DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263660, XrefRangeEnd = 263662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091B9 RID: 37305 RVA: 0x0025A210 File Offset: 0x00258410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263663, RefRangeEnd = 263664, XrefRangeStart = 263662, XrefRangeEnd = 263663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr_ShowProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091BA RID: 37306 RVA: 0x0025A250 File Offset: 0x00258450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263664, RefRangeEnd = 263666, XrefRangeStart = 263664, XrefRangeEnd = 263664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(string label, Color sliderFillColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sliderFillColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr_Configure_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091BB RID: 37307 RVA: 0x0025A2A0 File Offset: 0x002584A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263666, XrefRangeEnd = 263669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProgressSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091BC RID: 37308 RVA: 0x00046789 File Offset: 0x00044989
		public ProgressSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CA9 RID: 11433
		// (get) Token: 0x060091BD RID: 37309 RVA: 0x0025A2DC File Offset: 0x002584DC
		// (set) Token: 0x060091BE RID: 37310 RVA: 0x00046792 File Offset: 0x00044992
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CAA RID: 11434
		// (get) Token: 0x060091BF RID: 37311 RVA: 0x0025A30C File Offset: 0x0025850C
		// (set) Token: 0x060091C0 RID: 37312 RVA: 0x000467B1 File Offset: 0x000449B1
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CAB RID: 11435
		// (get) Token: 0x060091C1 RID: 37313 RVA: 0x0025A33C File Offset: 0x0025853C
		// (set) Token: 0x060091C2 RID: 37314 RVA: 0x000467D0 File Offset: 0x000449D0
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CAC RID: 11436
		// (get) Token: 0x060091C3 RID: 37315 RVA: 0x0025A36C File Offset: 0x0025856C
		// (set) Token: 0x060091C4 RID: 37316 RVA: 0x000467EF File Offset: 0x000449EF
		public unsafe Image SliderFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_SliderFill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_SliderFill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CAD RID: 11437
		// (get) Token: 0x060091C5 RID: 37317 RVA: 0x0025A39C File Offset: 0x0025859C
		// (set) Token: 0x060091C6 RID: 37318 RVA: 0x0004680E File Offset: 0x00044A0E
		public unsafe bool progressSetThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_progressSetThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_progressSetThisFrame)) = value;
			}
		}

		// Token: 0x04006277 RID: 25207
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006278 RID: 25208
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006279 RID: 25209
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x0400627A RID: 25210
		private static readonly IntPtr NativeFieldInfoPtr_SliderFill;

		// Token: 0x0400627B RID: 25211
		private static readonly IntPtr NativeFieldInfoPtr_progressSetThisFrame;

		// Token: 0x0400627C RID: 25212
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400627D RID: 25213
		private static readonly IntPtr NativeMethodInfoPtr_ShowProgress_Public_Void_Single_0;

		// Token: 0x0400627E RID: 25214
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_String_Color_0;

		// Token: 0x0400627F RID: 25215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
