using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Tooltips
{
	// Token: 0x0200067A RID: 1658
	public class TooltipManager : Singleton<TooltipManager>
	{
		// Token: 0x06009405 RID: 37893 RVA: 0x00260DCC File Offset: 0x0025EFCC
		// Note: this type is marked as 'beforefieldinit'.
		static TooltipManager()
		{
			Il2CppClassPointerStore<TooltipManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Tooltips", "TooltipManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr);
			TooltipManager.NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "anchor");
			TooltipManager.NativeFieldInfoPtr_tooltipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "tooltipLabel");
			TooltipManager.NativeFieldInfoPtr_canvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "canvases");
			TooltipManager.NativeFieldInfoPtr_sortedCanvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "sortedCanvases");
			TooltipManager.NativeFieldInfoPtr_raycasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "raycasters");
			TooltipManager.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "eventSystem");
			TooltipManager.NativeFieldInfoPtr_tooltipShownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "tooltipShownThisFrame");
			TooltipManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100681633);
			TooltipManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100681634);
			TooltipManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100681635);
			TooltipManager.NativeMethodInfoPtr_AddCanvas_Public_Void_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100681636);
			TooltipManager.NativeMethodInfoPtr_CheckForTooltipHover_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100681637);
			TooltipManager.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100681638);
			TooltipManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100681639);
		}

		// Token: 0x06009406 RID: 37894 RVA: 0x00260F14 File Offset: 0x0025F114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266351, XrefRangeEnd = 266427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TooltipManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009407 RID: 37895 RVA: 0x00260F50 File Offset: 0x0025F150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266427, XrefRangeEnd = 266428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TooltipManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009408 RID: 37896 RVA: 0x00260F8C File Offset: 0x0025F18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266428, XrefRangeEnd = 266430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TooltipManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009409 RID: 37897 RVA: 0x00260FC8 File Offset: 0x0025F1C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266505, RefRangeEnd = 266506, XrefRangeStart = 266430, XrefRangeEnd = 266505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCanvas(Canvas canvas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr_AddCanvas_Public_Void_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940A RID: 37898 RVA: 0x0026100C File Offset: 0x0025F20C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266549, RefRangeEnd = 266550, XrefRangeStart = 266506, XrefRangeEnd = 266549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForTooltipHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr_CheckForTooltipHover_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940B RID: 37899 RVA: 0x00261040 File Offset: 0x0025F240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266597, RefRangeEnd = 266598, XrefRangeStart = 266550, XrefRangeEnd = 266597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTooltip(string text, Vector2 position, bool worldspace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldspace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940C RID: 37900 RVA: 0x002610A0 File Offset: 0x0025F2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266598, XrefRangeEnd = 266620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TooltipManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940D RID: 37901 RVA: 0x00047CB9 File Offset: 0x00045EB9
		public TooltipManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x0600940E RID: 37902 RVA: 0x002610DC File Offset: 0x0025F2DC
		// (set) Token: 0x0600940F RID: 37903 RVA: 0x00047CC2 File Offset: 0x00045EC2
		public unsafe RectTransform anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_anchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_anchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x06009410 RID: 37904 RVA: 0x0026110C File Offset: 0x0025F30C
		// (set) Token: 0x06009411 RID: 37905 RVA: 0x00047CE1 File Offset: 0x00045EE1
		public unsafe TextMeshProUGUI tooltipLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D69 RID: 11625
		// (get) Token: 0x06009412 RID: 37906 RVA: 0x0026113C File Offset: 0x0025F33C
		// (set) Token: 0x06009413 RID: 37907 RVA: 0x00047D00 File Offset: 0x00045F00
		public unsafe List<Canvas> canvases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_canvases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Canvas>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_canvases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D6A RID: 11626
		// (get) Token: 0x06009414 RID: 37908 RVA: 0x0026116C File Offset: 0x0025F36C
		// (set) Token: 0x06009415 RID: 37909 RVA: 0x00047D1F File Offset: 0x00045F1F
		public unsafe List<Canvas> sortedCanvases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_sortedCanvases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Canvas>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_sortedCanvases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x06009416 RID: 37910 RVA: 0x0026119C File Offset: 0x0025F39C
		// (set) Token: 0x06009417 RID: 37911 RVA: 0x00047D3E File Offset: 0x00045F3E
		public unsafe List<GraphicRaycaster> raycasters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_raycasters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GraphicRaycaster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_raycasters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x06009418 RID: 37912 RVA: 0x002611CC File Offset: 0x0025F3CC
		// (set) Token: 0x06009419 RID: 37913 RVA: 0x00047D5D File Offset: 0x00045F5D
		public unsafe EventSystem eventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_eventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x0600941A RID: 37914 RVA: 0x002611FC File Offset: 0x0025F3FC
		// (set) Token: 0x0600941B RID: 37915 RVA: 0x00047D7C File Offset: 0x00045F7C
		public unsafe bool tooltipShownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipShownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipShownThisFrame)) = value;
			}
		}

		// Token: 0x040063E0 RID: 25568
		private static readonly IntPtr NativeFieldInfoPtr_anchor;

		// Token: 0x040063E1 RID: 25569
		private static readonly IntPtr NativeFieldInfoPtr_tooltipLabel;

		// Token: 0x040063E2 RID: 25570
		private static readonly IntPtr NativeFieldInfoPtr_canvases;

		// Token: 0x040063E3 RID: 25571
		private static readonly IntPtr NativeFieldInfoPtr_sortedCanvases;

		// Token: 0x040063E4 RID: 25572
		private static readonly IntPtr NativeFieldInfoPtr_raycasters;

		// Token: 0x040063E5 RID: 25573
		private static readonly IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x040063E6 RID: 25574
		private static readonly IntPtr NativeFieldInfoPtr_tooltipShownThisFrame;

		// Token: 0x040063E7 RID: 25575
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040063E8 RID: 25576
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040063E9 RID: 25577
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040063EA RID: 25578
		private static readonly IntPtr NativeMethodInfoPtr_AddCanvas_Public_Void_Canvas_0;

		// Token: 0x040063EB RID: 25579
		private static readonly IntPtr NativeMethodInfoPtr_CheckForTooltipHover_Private_Void_0;

		// Token: 0x040063EC RID: 25580
		private static readonly IntPtr NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Vector2_Boolean_0;

		// Token: 0x040063ED RID: 25581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B59 RID: 2905
		[ObfuscatedName("ScheduleOne.UI.Tooltips.TooltipManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA18 RID: 55832 RVA: 0x0033B6C8 File Offset: 0x003398C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr);
				TooltipManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9");
				TooltipManager.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__7_0");
				TooltipManager.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__7_1");
				TooltipManager.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__7_2");
				TooltipManager.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__10_0");
				TooltipManager.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__10_1");
				TooltipManager.__c.NativeFieldInfoPtr___9__10_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__10_2");
				TooltipManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100681641);
				TooltipManager.__c.NativeMethodInfoPtr__Awake_b__7_0_Internal_Boolean_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100681642);
				TooltipManager.__c.NativeMethodInfoPtr__Awake_b__7_1_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100681643);
				TooltipManager.__c.NativeMethodInfoPtr__Awake_b__7_2_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100681644);
				TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__10_0_Internal_Boolean_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100681645);
				TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__10_1_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100681646);
				TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__10_2_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100681647);
			}

			// Token: 0x0600DA19 RID: 55833 RVA: 0x0033B80C File Offset: 0x00339A0C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA1A RID: 55834 RVA: 0x0033B848 File Offset: 0x00339A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266333, XrefRangeEnd = 266341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__7_0(Canvas canvas)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__Awake_b__7_0_Internal_Boolean_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA1B RID: 55835 RVA: 0x0033B898 File Offset: 0x00339A98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266341, XrefRangeEnd = 266343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Awake_b__7_1(Canvas canvas)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__Awake_b__7_1_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA1C RID: 55836 RVA: 0x0033B8E8 File Offset: 0x00339AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266343, XrefRangeEnd = 266346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Awake_b__7_2(Canvas canvas)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__Awake_b__7_2_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA1D RID: 55837 RVA: 0x0033B938 File Offset: 0x00339B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266346, XrefRangeEnd = 266351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddCanvas_b__10_0(Canvas c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__10_0_Internal_Boolean_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA1E RID: 55838 RVA: 0x0033B988 File Offset: 0x00339B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddCanvas_b__10_1(Canvas c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__10_1_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA1F RID: 55839 RVA: 0x0033B9D8 File Offset: 0x00339BD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddCanvas_b__10_2(Canvas c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__10_2_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA20 RID: 55840 RVA: 0x0006A393 File Offset: 0x00068593
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043AB RID: 17323
			// (get) Token: 0x0600DA21 RID: 55841 RVA: 0x0033BA28 File Offset: 0x00339C28
			// (set) Token: 0x0600DA22 RID: 55842 RVA: 0x0006A39C File Offset: 0x0006859C
			public unsafe static TooltipManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TooltipManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043AC RID: 17324
			// (get) Token: 0x0600DA23 RID: 55843 RVA: 0x0033BA50 File Offset: 0x00339C50
			// (set) Token: 0x0600DA24 RID: 55844 RVA: 0x0006A3AE File Offset: 0x000685AE
			public unsafe static Func<Canvas, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043AD RID: 17325
			// (get) Token: 0x0600DA25 RID: 55845 RVA: 0x0033BA78 File Offset: 0x00339C78
			// (set) Token: 0x0600DA26 RID: 55846 RVA: 0x0006A3C0 File Offset: 0x000685C0
			public unsafe static Func<Canvas, int> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043AE RID: 17326
			// (get) Token: 0x0600DA27 RID: 55847 RVA: 0x0033BAA0 File Offset: 0x00339CA0
			// (set) Token: 0x0600DA28 RID: 55848 RVA: 0x0006A3D2 File Offset: 0x000685D2
			public unsafe static Func<Canvas, int> __9__7_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043AF RID: 17327
			// (get) Token: 0x0600DA29 RID: 55849 RVA: 0x0033BAC8 File Offset: 0x00339CC8
			// (set) Token: 0x0600DA2A RID: 55850 RVA: 0x0006A3E4 File Offset: 0x000685E4
			public unsafe static Func<Canvas, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B0 RID: 17328
			// (get) Token: 0x0600DA2B RID: 55851 RVA: 0x0033BAF0 File Offset: 0x00339CF0
			// (set) Token: 0x0600DA2C RID: 55852 RVA: 0x0006A3F6 File Offset: 0x000685F6
			public unsafe static Func<Canvas, int> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B1 RID: 17329
			// (get) Token: 0x0600DA2D RID: 55853 RVA: 0x0033BB18 File Offset: 0x00339D18
			// (set) Token: 0x0600DA2E RID: 55854 RVA: 0x0006A408 File Offset: 0x00068608
			public unsafe static Func<Canvas, int> __9__10_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__10_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009272 RID: 37490
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009273 RID: 37491
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04009274 RID: 37492
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04009275 RID: 37493
			private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

			// Token: 0x04009276 RID: 37494
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04009277 RID: 37495
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x04009278 RID: 37496
			private static readonly IntPtr NativeFieldInfoPtr___9__10_2;

			// Token: 0x04009279 RID: 37497
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400927A RID: 37498
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__7_0_Internal_Boolean_Canvas_0;

			// Token: 0x0400927B RID: 37499
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__7_1_Internal_Int32_Canvas_0;

			// Token: 0x0400927C RID: 37500
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__7_2_Internal_Int32_Canvas_0;

			// Token: 0x0400927D RID: 37501
			private static readonly IntPtr NativeMethodInfoPtr__AddCanvas_b__10_0_Internal_Boolean_Canvas_0;

			// Token: 0x0400927E RID: 37502
			private static readonly IntPtr NativeMethodInfoPtr__AddCanvas_b__10_1_Internal_Int32_Canvas_0;

			// Token: 0x0400927F RID: 37503
			private static readonly IntPtr NativeMethodInfoPtr__AddCanvas_b__10_2_Internal_Int32_Canvas_0;
		}
	}
}
