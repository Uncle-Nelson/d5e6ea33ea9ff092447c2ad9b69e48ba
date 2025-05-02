using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000666 RID: 1638
	public class RegionUnlockedCanvas : Singleton<RegionUnlockedCanvas>
	{
		// Token: 0x0600925B RID: 37467 RVA: 0x0025C1E8 File Offset: 0x0025A3E8
		// Note: this type is marked as 'beforefieldinit'.
		static RegionUnlockedCanvas()
		{
			Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "RegionUnlockedCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr);
			RegionUnlockedCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "<IsRunning>k__BackingField");
			RegionUnlockedCanvas.NativeFieldInfoPtr__Order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "<Order>k__BackingField");
			RegionUnlockedCanvas.NativeFieldInfoPtr_OpenCloseAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "OpenCloseAnim");
			RegionUnlockedCanvas.NativeFieldInfoPtr_RegionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "RegionLabel");
			RegionUnlockedCanvas.NativeFieldInfoPtr_RegionDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "RegionDescription");
			RegionUnlockedCanvas.NativeFieldInfoPtr_RegionImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "RegionImage");
			RegionUnlockedCanvas.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "region");
			RegionUnlockedCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681465);
			RegionUnlockedCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681466);
			RegionUnlockedCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681467);
			RegionUnlockedCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681468);
			RegionUnlockedCanvas.NativeMethodInfoPtr_QueueUnlocked_Public_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681469);
			RegionUnlockedCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681470);
			RegionUnlockedCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681471);
			RegionUnlockedCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681472);
		}

		// Token: 0x17002CE0 RID: 11488
		// (get) Token: 0x0600925C RID: 37468 RVA: 0x0025C344 File Offset: 0x0025A544
		// (set) Token: 0x0600925D RID: 37469 RVA: 0x0025C380 File Offset: 0x0025A580
		public unsafe virtual bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002CE1 RID: 11489
		// (get) Token: 0x0600925E RID: 37470 RVA: 0x0025C3C0 File Offset: 0x0025A5C0
		// (set) Token: 0x0600925F RID: 37471 RVA: 0x0025C3FC File Offset: 0x0025A5FC
		public unsafe virtual int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 179025, RefRangeEnd = 179026, XrefRangeStart = 179025, XrefRangeEnd = 179026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009260 RID: 37472 RVA: 0x0025C43C File Offset: 0x0025A63C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264695, RefRangeEnd = 264696, XrefRangeStart = 264689, XrefRangeEnd = 264695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueUnlocked(EMapRegion _region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_QueueUnlocked_Public_Void_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009261 RID: 37473 RVA: 0x0025C47C File Offset: 0x0025A67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264696, XrefRangeEnd = 264784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009262 RID: 37474 RVA: 0x0025C4B0 File Offset: 0x0025A6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264784, XrefRangeEnd = 264787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009263 RID: 37475 RVA: 0x0025C4E4 File Offset: 0x0025A6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264787, XrefRangeEnd = 264790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegionUnlockedCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009264 RID: 37476 RVA: 0x00046CF1 File Offset: 0x00044EF1
		public RegionUnlockedCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CD9 RID: 11481
		// (get) Token: 0x06009265 RID: 37477 RVA: 0x0025C520 File Offset: 0x0025A720
		// (set) Token: 0x06009266 RID: 37478 RVA: 0x00046CFA File Offset: 0x00044EFA
		public unsafe bool _IsRunning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField)) = value;
			}
		}

		// Token: 0x17002CDA RID: 11482
		// (get) Token: 0x06009267 RID: 37479 RVA: 0x0025C548 File Offset: 0x0025A748
		// (set) Token: 0x06009268 RID: 37480 RVA: 0x00046D15 File Offset: 0x00044F15
		public unsafe int _Order_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__Order_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__Order_k__BackingField)) = value;
			}
		}

		// Token: 0x17002CDB RID: 11483
		// (get) Token: 0x06009269 RID: 37481 RVA: 0x0025C570 File Offset: 0x0025A770
		// (set) Token: 0x0600926A RID: 37482 RVA: 0x00046D30 File Offset: 0x00044F30
		public unsafe Animation OpenCloseAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_OpenCloseAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_OpenCloseAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CDC RID: 11484
		// (get) Token: 0x0600926B RID: 37483 RVA: 0x0025C5A0 File Offset: 0x0025A7A0
		// (set) Token: 0x0600926C RID: 37484 RVA: 0x00046D4F File Offset: 0x00044F4F
		public unsafe TextMeshProUGUI RegionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CDD RID: 11485
		// (get) Token: 0x0600926D RID: 37485 RVA: 0x0025C5D0 File Offset: 0x0025A7D0
		// (set) Token: 0x0600926E RID: 37486 RVA: 0x00046D6E File Offset: 0x00044F6E
		public unsafe TextMeshProUGUI RegionDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CDE RID: 11486
		// (get) Token: 0x0600926F RID: 37487 RVA: 0x0025C600 File Offset: 0x0025A800
		// (set) Token: 0x06009270 RID: 37488 RVA: 0x00046D8D File Offset: 0x00044F8D
		public unsafe Image RegionImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CDF RID: 11487
		// (get) Token: 0x06009271 RID: 37489 RVA: 0x0025C630 File Offset: 0x0025A830
		// (set) Token: 0x06009272 RID: 37490 RVA: 0x00046DAC File Offset: 0x00044FAC
		public unsafe EMapRegion region
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_region);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_region)) = value;
			}
		}

		// Token: 0x040062E2 RID: 25314
		private static readonly IntPtr NativeFieldInfoPtr__IsRunning_k__BackingField;

		// Token: 0x040062E3 RID: 25315
		private static readonly IntPtr NativeFieldInfoPtr__Order_k__BackingField;

		// Token: 0x040062E4 RID: 25316
		private static readonly IntPtr NativeFieldInfoPtr_OpenCloseAnim;

		// Token: 0x040062E5 RID: 25317
		private static readonly IntPtr NativeFieldInfoPtr_RegionLabel;

		// Token: 0x040062E6 RID: 25318
		private static readonly IntPtr NativeFieldInfoPtr_RegionDescription;

		// Token: 0x040062E7 RID: 25319
		private static readonly IntPtr NativeFieldInfoPtr_RegionImage;

		// Token: 0x040062E8 RID: 25320
		private static readonly IntPtr NativeFieldInfoPtr_region;

		// Token: 0x040062E9 RID: 25321
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040062EA RID: 25322
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0;

		// Token: 0x040062EB RID: 25323
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040062EC RID: 25324
		private static readonly IntPtr NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0;

		// Token: 0x040062ED RID: 25325
		private static readonly IntPtr NativeMethodInfoPtr_QueueUnlocked_Public_Void_EMapRegion_0;

		// Token: 0x040062EE RID: 25326
		private static readonly IntPtr NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0;

		// Token: 0x040062EF RID: 25327
		private static readonly IntPtr NativeMethodInfoPtr_EndEvent_Public_Void_0;

		// Token: 0x040062F0 RID: 25328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B4F RID: 2895
		[ObfuscatedName("ScheduleOne.UI.RegionUnlockedCanvas+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D99E RID: 55710 RVA: 0x00339FF8 File Offset: 0x003381F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr);
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9");
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9__14_0");
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9__14_1");
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9__14_2");
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100681474);
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100681475);
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_1_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100681476);
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_2_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100681477);
			}

			// Token: 0x0600D99F RID: 55711 RVA: 0x0033A0C4 File Offset: 0x003382C4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9A0 RID: 55712 RVA: 0x0033A100 File Offset: 0x00338300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264679, XrefRangeEnd = 264687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartEvent_b__14_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D9A1 RID: 55713 RVA: 0x0033A150 File Offset: 0x00338350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264687, XrefRangeEnd = 264688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartEvent_b__14_1(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_1_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D9A2 RID: 55714 RVA: 0x0033A1A0 File Offset: 0x003383A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264688, XrefRangeEnd = 264689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartEvent_b__14_2(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_2_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D9A3 RID: 55715 RVA: 0x0006A006 File Offset: 0x00068206
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004385 RID: 17285
			// (get) Token: 0x0600D9A4 RID: 55716 RVA: 0x0033A1F0 File Offset: 0x003383F0
			// (set) Token: 0x0600D9A5 RID: 55717 RVA: 0x0006A00F File Offset: 0x0006820F
			public unsafe static RegionUnlockedCanvas.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegionUnlockedCanvas.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004386 RID: 17286
			// (get) Token: 0x0600D9A6 RID: 55718 RVA: 0x0033A218 File Offset: 0x00338418
			// (set) Token: 0x0600D9A7 RID: 55719 RVA: 0x0006A021 File Offset: 0x00068221
			public unsafe static Func<NPC, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004387 RID: 17287
			// (get) Token: 0x0600D9A8 RID: 55720 RVA: 0x0033A240 File Offset: 0x00338440
			// (set) Token: 0x0600D9A9 RID: 55721 RVA: 0x0006A033 File Offset: 0x00068233
			public unsafe static Func<NPC, bool> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004388 RID: 17288
			// (get) Token: 0x0600D9AA RID: 55722 RVA: 0x0033A268 File Offset: 0x00338468
			// (set) Token: 0x0600D9AB RID: 55723 RVA: 0x0006A045 File Offset: 0x00068245
			public unsafe static Func<NPC, bool> __9__14_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400922B RID: 37419
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400922C RID: 37420
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x0400922D RID: 37421
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x0400922E RID: 37422
			private static readonly IntPtr NativeFieldInfoPtr___9__14_2;

			// Token: 0x0400922F RID: 37423
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009230 RID: 37424
			private static readonly IntPtr NativeMethodInfoPtr__StartEvent_b__14_0_Internal_Boolean_NPC_0;

			// Token: 0x04009231 RID: 37425
			private static readonly IntPtr NativeMethodInfoPtr__StartEvent_b__14_1_Internal_Boolean_NPC_0;

			// Token: 0x04009232 RID: 37426
			private static readonly IntPtr NativeMethodInfoPtr__StartEvent_b__14_2_Internal_Boolean_NPC_0;
		}
	}
}
