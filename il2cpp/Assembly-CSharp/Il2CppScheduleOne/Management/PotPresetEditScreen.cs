using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management.Presets;
using Il2CppScheduleOne.Management.Presets.Options;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A1 RID: 929
	public class PotPresetEditScreen : PresetEditScreen
	{
		// Token: 0x060048BE RID: 18622 RVA: 0x001639C8 File Offset: 0x00161BC8
		// Note: this type is marked as 'beforefieldinit'.
		static PotPresetEditScreen()
		{
			Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "PotPresetEditScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr);
			PotPresetEditScreen.NativeFieldInfoPtr_SeedsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, "SeedsUI");
			PotPresetEditScreen.NativeFieldInfoPtr_AdditivesUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, "AdditivesUI");
			PotPresetEditScreen.NativeFieldInfoPtr_castedPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, "castedPreset");
			PotPresetEditScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672310);
			PotPresetEditScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672311);
			PotPresetEditScreen.NativeMethodInfoPtr_Open_Public_Virtual_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672312);
			PotPresetEditScreen.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672313);
			PotPresetEditScreen.NativeMethodInfoPtr_SeedsUIClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672314);
			PotPresetEditScreen.NativeMethodInfoPtr_AdditivesUIClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672315);
			PotPresetEditScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672316);
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x00163AC0 File Offset: 0x00161CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162713, XrefRangeEnd = 162728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPresetEditScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x00163AFC File Offset: 0x00161CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162728, XrefRangeEnd = 162729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPresetEditScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x00163B38 File Offset: 0x00161D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162729, XrefRangeEnd = 162738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open(Preset preset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPresetEditScreen.NativeMethodInfoPtr_Open_Public_Virtual_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x00163B88 File Offset: 0x00161D88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162739, RefRangeEnd = 162741, XrefRangeStart = 162738, XrefRangeEnd = 162739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPresetEditScreen.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x00163BBC File Offset: 0x00161DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162741, XrefRangeEnd = 162748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SeedsUIClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPresetEditScreen.NativeMethodInfoPtr_SeedsUIClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x00163BF0 File Offset: 0x00161DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162748, XrefRangeEnd = 162755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdditivesUIClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPresetEditScreen.NativeMethodInfoPtr_AdditivesUIClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x00163C24 File Offset: 0x00161E24
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotPresetEditScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPresetEditScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x00023125 File Offset: 0x00021325
		public PotPresetEditScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x060048C7 RID: 18631 RVA: 0x00163C60 File Offset: 0x00161E60
		// (set) Token: 0x060048C8 RID: 18632 RVA: 0x0002312E File Offset: 0x0002132E
		public unsafe GenericOptionUI SeedsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_SeedsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericOptionUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_SeedsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x060048C9 RID: 18633 RVA: 0x00163C90 File Offset: 0x00161E90
		// (set) Token: 0x060048CA RID: 18634 RVA: 0x0002314D File Offset: 0x0002134D
		public unsafe GenericOptionUI AdditivesUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_AdditivesUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericOptionUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_AdditivesUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x060048CB RID: 18635 RVA: 0x00163CC0 File Offset: 0x00161EC0
		// (set) Token: 0x060048CC RID: 18636 RVA: 0x0002316C File Offset: 0x0002136C
		public unsafe PotPreset castedPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_castedPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_castedPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003113 RID: 12563
		private static readonly IntPtr NativeFieldInfoPtr_SeedsUI;

		// Token: 0x04003114 RID: 12564
		private static readonly IntPtr NativeFieldInfoPtr_AdditivesUI;

		// Token: 0x04003115 RID: 12565
		private static readonly IntPtr NativeFieldInfoPtr_castedPreset;

		// Token: 0x04003116 RID: 12566
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003117 RID: 12567
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04003118 RID: 12568
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_Preset_0;

		// Token: 0x04003119 RID: 12569
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x0400311A RID: 12570
		private static readonly IntPtr NativeMethodInfoPtr_SeedsUIClicked_Public_Void_0;

		// Token: 0x0400311B RID: 12571
		private static readonly IntPtr NativeMethodInfoPtr_AdditivesUIClicked_Public_Void_0;

		// Token: 0x0400311C RID: 12572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
