using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x0200068C RID: 1676
	public class IntefaceScaleSlider : SettingsSlider
	{
		// Token: 0x060095DD RID: 38365 RVA: 0x00266968 File Offset: 0x00264B68
		// Note: this type is marked as 'beforefieldinit'.
		static IntefaceScaleSlider()
		{
			Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "IntefaceScaleSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr);
			IntefaceScaleSlider.NativeFieldInfoPtr_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, "MULTIPLIER");
			IntefaceScaleSlider.NativeFieldInfoPtr_MinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, "MinScale");
			IntefaceScaleSlider.NativeFieldInfoPtr_MaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, "MaxScale");
			IntefaceScaleSlider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100681817);
			IntefaceScaleSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100681818);
			IntefaceScaleSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100681819);
			IntefaceScaleSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100681820);
		}

		// Token: 0x060095DE RID: 38366 RVA: 0x00266A24 File Offset: 0x00264C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269256, XrefRangeEnd = 269263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntefaceScaleSlider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095DF RID: 38367 RVA: 0x00266A60 File Offset: 0x00264C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269263, XrefRangeEnd = 269273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntefaceScaleSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095E0 RID: 38368 RVA: 0x00266AAC File Offset: 0x00264CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269273, XrefRangeEnd = 269278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetDisplayValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntefaceScaleSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060095E1 RID: 38369 RVA: 0x00266AFC File Offset: 0x00264CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntefaceScaleSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntefaceScaleSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095E2 RID: 38370 RVA: 0x00048D47 File Offset: 0x00046F47
		public IntefaceScaleSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x060095E3 RID: 38371 RVA: 0x00266B38 File Offset: 0x00264D38
		// (set) Token: 0x060095E4 RID: 38372 RVA: 0x00048D50 File Offset: 0x00046F50
		public unsafe static float MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntefaceScaleSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntefaceScaleSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002E03 RID: 11779
		// (get) Token: 0x060095E5 RID: 38373 RVA: 0x00266B54 File Offset: 0x00264D54
		// (set) Token: 0x060095E6 RID: 38374 RVA: 0x00048D5E File Offset: 0x00046F5E
		public unsafe static float MinScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntefaceScaleSlider.NativeFieldInfoPtr_MinScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntefaceScaleSlider.NativeFieldInfoPtr_MinScale, (void*)(&value));
			}
		}

		// Token: 0x17002E04 RID: 11780
		// (get) Token: 0x060095E7 RID: 38375 RVA: 0x00266B70 File Offset: 0x00264D70
		// (set) Token: 0x060095E8 RID: 38376 RVA: 0x00048D6C File Offset: 0x00046F6C
		public unsafe static float MaxScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntefaceScaleSlider.NativeFieldInfoPtr_MaxScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntefaceScaleSlider.NativeFieldInfoPtr_MaxScale, (void*)(&value));
			}
		}

		// Token: 0x0400650C RID: 25868
		private static readonly IntPtr NativeFieldInfoPtr_MULTIPLIER;

		// Token: 0x0400650D RID: 25869
		private static readonly IntPtr NativeFieldInfoPtr_MinScale;

		// Token: 0x0400650E RID: 25870
		private static readonly IntPtr NativeFieldInfoPtr_MaxScale;

		// Token: 0x0400650F RID: 25871
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04006510 RID: 25872
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x04006511 RID: 25873
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_String_Single_0;

		// Token: 0x04006512 RID: 25874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
