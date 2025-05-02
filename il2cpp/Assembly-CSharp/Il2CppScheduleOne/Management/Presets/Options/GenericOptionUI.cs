using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Management.Presets.Options
{
	// Token: 0x020003AE RID: 942
	public class GenericOptionUI : MonoBehaviour
	{
		// Token: 0x060049A1 RID: 18849 RVA: 0x00166A04 File Offset: 0x00164C04
		// Note: this type is marked as 'beforefieldinit'.
		static GenericOptionUI()
		{
			Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets.Options", "GenericOptionUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr);
			GenericOptionUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr, "Button");
			GenericOptionUI.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr, "NameLabel");
			GenericOptionUI.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr, "ValueLabel");
			GenericOptionUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr, 100672435);
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x00166A84 File Offset: 0x00164C84
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericOptionUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericOptionUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x00023795 File Offset: 0x00021995
		public GenericOptionUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x060049A4 RID: 18852 RVA: 0x00166AC0 File Offset: 0x00164CC0
		// (set) Token: 0x060049A5 RID: 18853 RVA: 0x0002379E File Offset: 0x0002199E
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x060049A6 RID: 18854 RVA: 0x00166AF0 File Offset: 0x00164CF0
		// (set) Token: 0x060049A7 RID: 18855 RVA: 0x000237BD File Offset: 0x000219BD
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x060049A8 RID: 18856 RVA: 0x00166B20 File Offset: 0x00164D20
		// (set) Token: 0x060049A9 RID: 18857 RVA: 0x000237DC File Offset: 0x000219DC
		public unsafe TextMeshProUGUI ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031A9 RID: 12713
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040031AA RID: 12714
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x040031AB RID: 12715
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x040031AC RID: 12716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
