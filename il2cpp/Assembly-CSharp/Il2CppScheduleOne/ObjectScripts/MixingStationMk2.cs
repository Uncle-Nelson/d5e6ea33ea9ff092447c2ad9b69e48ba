using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200074E RID: 1870
	public class MixingStationMk2 : MixingStation
	{
		// Token: 0x0600B060 RID: 45152 RVA: 0x002BFEE8 File Offset: 0x002BE0E8
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationMk2()
		{
			Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "MixingStationMk2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr);
			MixingStationMk2.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "Animation");
			MixingStationMk2.NativeFieldInfoPtr_ScreenCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "ScreenCanvas");
			MixingStationMk2.NativeFieldInfoPtr_OutputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "OutputIcon");
			MixingStationMk2.NativeFieldInfoPtr_QuestionMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "QuestionMark");
			MixingStationMk2.NativeFieldInfoPtr_QuantityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "QuantityLabel");
			MixingStationMk2.NativeFieldInfoPtr_ProgressLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "ProgressLabel");
			MixingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.MixingStationMk2Assembly-CSharp.dll_Excuted");
			MixingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.MixingStationMk2Assembly-CSharp.dll_Excuted");
			MixingStationMk2.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684993);
			MixingStationMk2.NativeMethodInfoPtr_MixingStart_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684994);
			MixingStationMk2.NativeMethodInfoPtr_MixingDone_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684995);
			MixingStationMk2.NativeMethodInfoPtr_EnableScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684996);
			MixingStationMk2.NativeMethodInfoPtr_UpdateScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684997);
			MixingStationMk2.NativeMethodInfoPtr_DisableScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684998);
			MixingStationMk2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100684999);
			MixingStationMk2.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100685000);
			MixingStationMk2.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100685001);
			MixingStationMk2.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100685002);
			MixingStationMk2.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr, 100685003);
		}

		// Token: 0x0600B061 RID: 45153 RVA: 0x002C0094 File Offset: 0x002BE294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304452, XrefRangeEnd = 304454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationMk2.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B062 RID: 45154 RVA: 0x002C00D0 File Offset: 0x002BE2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304454, XrefRangeEnd = 304461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MixingStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationMk2.NativeMethodInfoPtr_MixingStart_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B063 RID: 45155 RVA: 0x002C010C File Offset: 0x002BE30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304461, XrefRangeEnd = 304469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MixingDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationMk2.NativeMethodInfoPtr_MixingDone_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B064 RID: 45156 RVA: 0x002C0148 File Offset: 0x002BE348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304483, RefRangeEnd = 304484, XrefRangeStart = 304469, XrefRangeEnd = 304483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationMk2.NativeMethodInfoPtr_EnableScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B065 RID: 45157 RVA: 0x002C017C File Offset: 0x002BE37C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304488, RefRangeEnd = 304490, XrefRangeStart = 304484, XrefRangeEnd = 304488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationMk2.NativeMethodInfoPtr_UpdateScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B066 RID: 45158 RVA: 0x002C01B0 File Offset: 0x002BE3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304490, XrefRangeEnd = 304492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationMk2.NativeMethodInfoPtr_DisableScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B067 RID: 45159 RVA: 0x002C01E4 File Offset: 0x002BE3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationMk2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationMk2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationMk2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B068 RID: 45160 RVA: 0x002C0220 File Offset: 0x002BE420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304492, XrefRangeEnd = 304493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationMk2.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B069 RID: 45161 RVA: 0x002C025C File Offset: 0x002BE45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304493, XrefRangeEnd = 304494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationMk2.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B06A RID: 45162 RVA: 0x002C0298 File Offset: 0x002BE498
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationMk2.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B06B RID: 45163 RVA: 0x002C02D4 File Offset: 0x002BE4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304494, XrefRangeEnd = 304495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationMk2.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B06C RID: 45164 RVA: 0x000569FD File Offset: 0x00054BFD
		public MixingStationMk2(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x0600B06D RID: 45165 RVA: 0x002C0310 File Offset: 0x002BE510
		// (set) Token: 0x0600B06E RID: 45166 RVA: 0x00056A06 File Offset: 0x00054C06
		public unsafe Animation Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x0600B06F RID: 45167 RVA: 0x002C0340 File Offset: 0x002BE540
		// (set) Token: 0x0600B070 RID: 45168 RVA: 0x00056A25 File Offset: 0x00054C25
		public unsafe Canvas ScreenCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_ScreenCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_ScreenCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x0600B071 RID: 45169 RVA: 0x002C0370 File Offset: 0x002BE570
		// (set) Token: 0x0600B072 RID: 45170 RVA: 0x00056A44 File Offset: 0x00054C44
		public unsafe Image OutputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_OutputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_OutputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x0600B073 RID: 45171 RVA: 0x002C03A0 File Offset: 0x002BE5A0
		// (set) Token: 0x0600B074 RID: 45172 RVA: 0x00056A63 File Offset: 0x00054C63
		public unsafe RectTransform QuestionMark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_QuestionMark);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_QuestionMark), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x0600B075 RID: 45173 RVA: 0x002C03D0 File Offset: 0x002BE5D0
		// (set) Token: 0x0600B076 RID: 45174 RVA: 0x00056A82 File Offset: 0x00054C82
		public unsafe TextMeshProUGUI QuantityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_QuantityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_QuantityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036BD RID: 14013
		// (get) Token: 0x0600B077 RID: 45175 RVA: 0x002C0400 File Offset: 0x002BE600
		// (set) Token: 0x0600B078 RID: 45176 RVA: 0x00056AA1 File Offset: 0x00054CA1
		public unsafe TextMeshProUGUI ProgressLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_ProgressLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_ProgressLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036BE RID: 14014
		// (get) Token: 0x0600B079 RID: 45177 RVA: 0x002C0430 File Offset: 0x002BE630
		// (set) Token: 0x0600B07A RID: 45178 RVA: 0x00056AC0 File Offset: 0x00054CC0
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170036BF RID: 14015
		// (get) Token: 0x0600B07B RID: 45179 RVA: 0x002C0458 File Offset: 0x002BE658
		// (set) Token: 0x0600B07C RID: 45180 RVA: 0x00056ADB File Offset: 0x00054CDB
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationMk2.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040076CE RID: 30414
		private static readonly IntPtr NativeFieldInfoPtr_Animation;

		// Token: 0x040076CF RID: 30415
		private static readonly IntPtr NativeFieldInfoPtr_ScreenCanvas;

		// Token: 0x040076D0 RID: 30416
		private static readonly IntPtr NativeFieldInfoPtr_OutputIcon;

		// Token: 0x040076D1 RID: 30417
		private static readonly IntPtr NativeFieldInfoPtr_QuestionMark;

		// Token: 0x040076D2 RID: 30418
		private static readonly IntPtr NativeFieldInfoPtr_QuantityLabel;

		// Token: 0x040076D3 RID: 30419
		private static readonly IntPtr NativeFieldInfoPtr_ProgressLabel;

		// Token: 0x040076D4 RID: 30420
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040076D5 RID: 30421
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040076D6 RID: 30422
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040076D7 RID: 30423
		private static readonly IntPtr NativeMethodInfoPtr_MixingStart_Public_Virtual_Void_0;

		// Token: 0x040076D8 RID: 30424
		private static readonly IntPtr NativeMethodInfoPtr_MixingDone_Public_Virtual_Void_0;

		// Token: 0x040076D9 RID: 30425
		private static readonly IntPtr NativeMethodInfoPtr_EnableScreen_Private_Void_0;

		// Token: 0x040076DA RID: 30426
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScreen_Private_Void_0;

		// Token: 0x040076DB RID: 30427
		private static readonly IntPtr NativeMethodInfoPtr_DisableScreen_Private_Void_0;

		// Token: 0x040076DC RID: 30428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040076DD RID: 30429
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040076DE RID: 30430
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040076DF RID: 30431
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040076E0 RID: 30432
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
