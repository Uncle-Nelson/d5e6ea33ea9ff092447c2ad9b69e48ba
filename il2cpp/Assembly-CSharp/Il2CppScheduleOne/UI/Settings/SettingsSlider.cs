using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000694 RID: 1684
	public class SettingsSlider : MonoBehaviour
	{
		// Token: 0x0600961D RID: 38429 RVA: 0x00267764 File Offset: 0x00265964
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsSlider()
		{
			Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SettingsSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr);
			SettingsSlider.NativeFieldInfoPtr_VALUE_DISPLAY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "VALUE_DISPLAY_TIME");
			SettingsSlider.NativeFieldInfoPtr_DisplayValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "DisplayValue");
			SettingsSlider.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "slider");
			SettingsSlider.NativeFieldInfoPtr_valueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "valueLabel");
			SettingsSlider.NativeFieldInfoPtr_timeOnValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "timeOnValueChange");
			SettingsSlider.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100681857);
			SettingsSlider.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100681858);
			SettingsSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100681859);
			SettingsSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_New_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100681860);
			SettingsSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100681861);
		}

		// Token: 0x0600961E RID: 38430 RVA: 0x0026785C File Offset: 0x00265A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269587, XrefRangeEnd = 269606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600961F RID: 38431 RVA: 0x00267898 File Offset: 0x00265A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269606, XrefRangeEnd = 269608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009620 RID: 38432 RVA: 0x002678D4 File Offset: 0x00265AD4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 269610, RefRangeEnd = 269616, XrefRangeStart = 269608, XrefRangeEnd = 269610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009621 RID: 38433 RVA: 0x00267920 File Offset: 0x00265B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269616, XrefRangeEnd = 269617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetDisplayValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_New_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009622 RID: 38434 RVA: 0x00267970 File Offset: 0x00265B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009623 RID: 38435 RVA: 0x00048E24 File Offset: 0x00047024
		public SettingsSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E09 RID: 11785
		// (get) Token: 0x06009624 RID: 38436 RVA: 0x002679AC File Offset: 0x00265BAC
		// (set) Token: 0x06009625 RID: 38437 RVA: 0x00048E2D File Offset: 0x0004702D
		public unsafe static float VALUE_DISPLAY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SettingsSlider.NativeFieldInfoPtr_VALUE_DISPLAY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsSlider.NativeFieldInfoPtr_VALUE_DISPLAY_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002E0A RID: 11786
		// (get) Token: 0x06009626 RID: 38438 RVA: 0x002679C8 File Offset: 0x00265BC8
		// (set) Token: 0x06009627 RID: 38439 RVA: 0x00048E3B File Offset: 0x0004703B
		public unsafe bool DisplayValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_DisplayValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_DisplayValue)) = value;
			}
		}

		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x06009628 RID: 38440 RVA: 0x002679F0 File Offset: 0x00265BF0
		// (set) Token: 0x06009629 RID: 38441 RVA: 0x00048E56 File Offset: 0x00047056
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x0600962A RID: 38442 RVA: 0x00267A20 File Offset: 0x00265C20
		// (set) Token: 0x0600962B RID: 38443 RVA: 0x00048E75 File Offset: 0x00047075
		public unsafe TextMeshProUGUI valueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_valueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_valueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E0D RID: 11789
		// (get) Token: 0x0600962C RID: 38444 RVA: 0x00267A50 File Offset: 0x00265C50
		// (set) Token: 0x0600962D RID: 38445 RVA: 0x00048E94 File Offset: 0x00047094
		public unsafe float timeOnValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_timeOnValueChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_timeOnValueChange)) = value;
			}
		}

		// Token: 0x04006535 RID: 25909
		private static readonly IntPtr NativeFieldInfoPtr_VALUE_DISPLAY_TIME;

		// Token: 0x04006536 RID: 25910
		private static readonly IntPtr NativeFieldInfoPtr_DisplayValue;

		// Token: 0x04006537 RID: 25911
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04006538 RID: 25912
		private static readonly IntPtr NativeFieldInfoPtr_valueLabel;

		// Token: 0x04006539 RID: 25913
		private static readonly IntPtr NativeFieldInfoPtr_timeOnValueChange;

		// Token: 0x0400653A RID: 25914
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400653B RID: 25915
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400653C RID: 25916
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Single_0;

		// Token: 0x0400653D RID: 25917
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_New_String_Single_0;

		// Token: 0x0400653E RID: 25918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
