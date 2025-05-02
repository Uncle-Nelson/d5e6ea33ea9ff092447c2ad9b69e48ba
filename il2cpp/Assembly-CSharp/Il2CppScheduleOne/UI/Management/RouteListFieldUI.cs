using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006CD RID: 1741
	public class RouteListFieldUI : MonoBehaviour
	{
		// Token: 0x06009C60 RID: 40032 RVA: 0x00279E98 File Offset: 0x00278098
		// Note: this type is marked as 'beforefieldinit'.
		static RouteListFieldUI()
		{
			Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "RouteListFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr);
			RouteListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			RouteListFieldUI.NativeFieldInfoPtr_FieldText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "FieldText");
			RouteListFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "FieldLabel");
			RouteListFieldUI.NativeFieldInfoPtr_RouteEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "RouteEntries");
			RouteListFieldUI.NativeFieldInfoPtr_MultiEditBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "MultiEditBlocker");
			RouteListFieldUI.NativeFieldInfoPtr_AddButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "AddButton");
			RouteListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_RouteListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682493);
			RouteListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_RouteListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682494);
			RouteListFieldUI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682495);
			RouteListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_RouteListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682496);
			RouteListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682497);
			RouteListFieldUI.NativeMethodInfoPtr_EntryDeleteClicked_Private_Void_RouteEntryUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682498);
			RouteListFieldUI.NativeMethodInfoPtr_AddClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682499);
			RouteListFieldUI.NativeMethodInfoPtr_RouteChanged_Private_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682500);
			RouteListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682501);
		}

		// Token: 0x1700302B RID: 12331
		// (get) Token: 0x06009C61 RID: 40033 RVA: 0x00279FF4 File Offset: 0x002781F4
		// (set) Token: 0x06009C62 RID: 40034 RVA: 0x0027A034 File Offset: 0x00278234
		public unsafe List<RouteListField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_RouteListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RouteListField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_RouteListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009C63 RID: 40035 RVA: 0x0027A078 File Offset: 0x00278278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277632, XrefRangeEnd = 277654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C64 RID: 40036 RVA: 0x0027A0AC File Offset: 0x002782AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277683, RefRangeEnd = 277684, XrefRangeStart = 277654, XrefRangeEnd = 277683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<RouteListField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_RouteListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C65 RID: 40037 RVA: 0x0027A0F0 File Offset: 0x002782F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277765, RefRangeEnd = 277766, XrefRangeStart = 277684, XrefRangeEnd = 277765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(List<AdvancedTransitRoute> newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C66 RID: 40038 RVA: 0x0027A134 File Offset: 0x00278334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277766, XrefRangeEnd = 277772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryDeleteClicked(RouteEntryUI entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_EntryDeleteClicked_Private_Void_RouteEntryUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C67 RID: 40039 RVA: 0x0027A178 File Offset: 0x00278378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277772, XrefRangeEnd = 277781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_AddClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C68 RID: 40040 RVA: 0x0027A1AC File Offset: 0x002783AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277781, XrefRangeEnd = 277786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RouteChanged(ITransitEntity newEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEntity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_RouteChanged_Private_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C69 RID: 40041 RVA: 0x0027A1F0 File Offset: 0x002783F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277786, XrefRangeEnd = 277798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C6A RID: 40042 RVA: 0x0004CA70 File Offset: 0x0004AC70
		public RouteListFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x06009C6B RID: 40043 RVA: 0x0027A22C File Offset: 0x0027842C
		// (set) Token: 0x06009C6C RID: 40044 RVA: 0x0004CA79 File Offset: 0x0004AC79
		public unsafe List<RouteListField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RouteListField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x06009C6D RID: 40045 RVA: 0x0027A25C File Offset: 0x0027845C
		// (set) Token: 0x06009C6E RID: 40046 RVA: 0x0004CA98 File Offset: 0x0004AC98
		public unsafe string FieldText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x06009C6F RID: 40047 RVA: 0x0027A284 File Offset: 0x00278484
		// (set) Token: 0x06009C70 RID: 40048 RVA: 0x0004CAB7 File Offset: 0x0004ACB7
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x06009C71 RID: 40049 RVA: 0x0027A2B4 File Offset: 0x002784B4
		// (set) Token: 0x06009C72 RID: 40050 RVA: 0x0004CAD6 File Offset: 0x0004ACD6
		public unsafe Il2CppReferenceArray<RouteEntryUI> RouteEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_RouteEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RouteEntryUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_RouteEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x06009C73 RID: 40051 RVA: 0x0027A2E4 File Offset: 0x002784E4
		// (set) Token: 0x06009C74 RID: 40052 RVA: 0x0004CAF5 File Offset: 0x0004ACF5
		public unsafe RectTransform MultiEditBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_MultiEditBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_MultiEditBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700302A RID: 12330
		// (get) Token: 0x06009C75 RID: 40053 RVA: 0x0027A314 File Offset: 0x00278514
		// (set) Token: 0x06009C76 RID: 40054 RVA: 0x0004CB14 File Offset: 0x0004AD14
		public unsafe Button AddButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_AddButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_AddButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400690B RID: 26891
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x0400690C RID: 26892
		private static readonly IntPtr NativeFieldInfoPtr_FieldText;

		// Token: 0x0400690D RID: 26893
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x0400690E RID: 26894
		private static readonly IntPtr NativeFieldInfoPtr_RouteEntries;

		// Token: 0x0400690F RID: 26895
		private static readonly IntPtr NativeFieldInfoPtr_MultiEditBlocker;

		// Token: 0x04006910 RID: 26896
		private static readonly IntPtr NativeFieldInfoPtr_AddButton;

		// Token: 0x04006911 RID: 26897
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_RouteListField_0;

		// Token: 0x04006912 RID: 26898
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_RouteListField_0;

		// Token: 0x04006913 RID: 26899
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006914 RID: 26900
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_RouteListField_0;

		// Token: 0x04006915 RID: 26901
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_List_1_AdvancedTransitRoute_0;

		// Token: 0x04006916 RID: 26902
		private static readonly IntPtr NativeMethodInfoPtr_EntryDeleteClicked_Private_Void_RouteEntryUI_0;

		// Token: 0x04006917 RID: 26903
		private static readonly IntPtr NativeMethodInfoPtr_AddClicked_Private_Void_0;

		// Token: 0x04006918 RID: 26904
		private static readonly IntPtr NativeMethodInfoPtr_RouteChanged_Private_Void_ITransitEntity_0;

		// Token: 0x04006919 RID: 26905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B8F RID: 2959
		[ObfuscatedName("ScheduleOne.UI.Management.RouteListFieldUI+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBFE RID: 56318 RVA: 0x00340B30 File Offset: 0x0033ED30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr);
				RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, "entry");
				RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, 100682502);
				RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, 100682503);
			}

			// Token: 0x0600DBFF RID: 56319 RVA: 0x00340BAC File Offset: 0x0033EDAC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC00 RID: 56320 RVA: 0x00340BE8 File Offset: 0x0033EDE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277591, XrefRangeEnd = 277632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC01 RID: 56321 RVA: 0x0006B2D8 File Offset: 0x000694D8
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004435 RID: 17461
			// (get) Token: 0x0600DC02 RID: 56322 RVA: 0x00340C1C File Offset: 0x0033EE1C
			// (set) Token: 0x0600DC03 RID: 56323 RVA: 0x0006B2E1 File Offset: 0x000694E1
			public unsafe RouteEntryUI entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteEntryUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004436 RID: 17462
			// (get) Token: 0x0600DC04 RID: 56324 RVA: 0x00340C4C File Offset: 0x0033EE4C
			// (set) Token: 0x0600DC05 RID: 56325 RVA: 0x0006B300 File Offset: 0x00069500
			public unsafe RouteListFieldUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteListFieldUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400937D RID: 37757
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x0400937E RID: 37758
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400937F RID: 37759
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009380 RID: 37760
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
