using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Levelling;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000665 RID: 1637
	public class RankUpCanvas : MonoBehaviour
	{
		// Token: 0x0600922C RID: 37420 RVA: 0x0025B9BC File Offset: 0x00259BBC
		// Note: this type is marked as 'beforefieldinit'.
		static RankUpCanvas()
		{
			Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "RankUpCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr);
			RankUpCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "<IsRunning>k__BackingField");
			RankUpCanvas.NativeFieldInfoPtr__Order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "<Order>k__BackingField");
			RankUpCanvas.NativeFieldInfoPtr_OpenCloseAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "OpenCloseAnim");
			RankUpCanvas.NativeFieldInfoPtr_RankUpAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "RankUpAnim");
			RankUpCanvas.NativeFieldInfoPtr_OldRankLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "OldRankLabel");
			RankUpCanvas.NativeFieldInfoPtr_NewRankLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "NewRankLabel");
			RankUpCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "Canvas");
			RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "UnlockedItemsContainer");
			RankUpCanvas.NativeFieldInfoPtr_UnlockedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "UnlockedItems");
			RankUpCanvas.NativeFieldInfoPtr_ExtraUnlocksLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ExtraUnlocksLabel");
			RankUpCanvas.NativeFieldInfoPtr_SoundEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "SoundEffect");
			RankUpCanvas.NativeFieldInfoPtr_ProgressSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ProgressSlider");
			RankUpCanvas.NativeFieldInfoPtr_ProgressLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ProgressLabel");
			RankUpCanvas.NativeFieldInfoPtr_BlipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "BlipSound");
			RankUpCanvas.NativeFieldInfoPtr_ClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ClickSound");
			RankUpCanvas.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "coroutine");
			RankUpCanvas.NativeFieldInfoPtr_queuedRankUps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "queuedRankUps");
			RankUpCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681445);
			RankUpCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681446);
			RankUpCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681447);
			RankUpCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681448);
			RankUpCanvas.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681449);
			RankUpCanvas.NativeMethodInfoPtr_QueuePostSleepEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681450);
			RankUpCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681451);
			RankUpCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681452);
			RankUpCanvas.NativeMethodInfoPtr_RankUp_Public_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681453);
			RankUpCanvas.NativeMethodInfoPtr_PlayRankupAnimation_Private_Void_FullRank_FullRank_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681454);
			RankUpCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681455);
		}

		// Token: 0x17002CD7 RID: 11479
		// (get) Token: 0x0600922D RID: 37421 RVA: 0x0025BC1C File Offset: 0x00259E1C
		// (set) Token: 0x0600922E RID: 37422 RVA: 0x0025BC58 File Offset: 0x00259E58
		public unsafe virtual bool IsRunning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002CD8 RID: 11480
		// (get) Token: 0x0600922F RID: 37423 RVA: 0x0025BC98 File Offset: 0x00259E98
		// (set) Token: 0x06009230 RID: 37424 RVA: 0x0025BCD4 File Offset: 0x00259ED4
		public unsafe virtual int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29963, RefRangeEnd = 29964, XrefRangeStart = 29963, XrefRangeEnd = 29964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009231 RID: 37425 RVA: 0x0025BD14 File Offset: 0x00259F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264476, XrefRangeEnd = 264508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009232 RID: 37426 RVA: 0x0025BD48 File Offset: 0x00259F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264508, XrefRangeEnd = 264514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueuePostSleepEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_QueuePostSleepEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009233 RID: 37427 RVA: 0x0025BD7C File Offset: 0x00259F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264514, XrefRangeEnd = 264597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009234 RID: 37428 RVA: 0x0025BDB0 File Offset: 0x00259FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264597, XrefRangeEnd = 264606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009235 RID: 37429 RVA: 0x0025BDE4 File Offset: 0x00259FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264606, XrefRangeEnd = 264615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RankUp(FullRank oldRank, FullRank newRank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldRank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_RankUp_Public_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009236 RID: 37430 RVA: 0x0025BE30 File Offset: 0x0025A030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264670, RefRangeEnd = 264671, XrefRangeStart = 264615, XrefRangeEnd = 264670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayRankupAnimation(FullRank oldRank, FullRank newRank, bool playSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldRank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playSound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_PlayRankupAnimation_Private_Void_FullRank_FullRank_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009237 RID: 37431 RVA: 0x0025BE8C File Offset: 0x0025A08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264671, XrefRangeEnd = 264679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankUpCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009238 RID: 37432 RVA: 0x00046AE1 File Offset: 0x00044CE1
		public RankUpCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CC6 RID: 11462
		// (get) Token: 0x06009239 RID: 37433 RVA: 0x0025BEC8 File Offset: 0x0025A0C8
		// (set) Token: 0x0600923A RID: 37434 RVA: 0x00046AEA File Offset: 0x00044CEA
		public unsafe bool _IsRunning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField)) = value;
			}
		}

		// Token: 0x17002CC7 RID: 11463
		// (get) Token: 0x0600923B RID: 37435 RVA: 0x0025BEF0 File Offset: 0x0025A0F0
		// (set) Token: 0x0600923C RID: 37436 RVA: 0x00046B05 File Offset: 0x00044D05
		public unsafe int _Order_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__Order_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__Order_k__BackingField)) = value;
			}
		}

		// Token: 0x17002CC8 RID: 11464
		// (get) Token: 0x0600923D RID: 37437 RVA: 0x0025BF18 File Offset: 0x0025A118
		// (set) Token: 0x0600923E RID: 37438 RVA: 0x00046B20 File Offset: 0x00044D20
		public unsafe Animation OpenCloseAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OpenCloseAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OpenCloseAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CC9 RID: 11465
		// (get) Token: 0x0600923F RID: 37439 RVA: 0x0025BF48 File Offset: 0x0025A148
		// (set) Token: 0x06009240 RID: 37440 RVA: 0x00046B3F File Offset: 0x00044D3F
		public unsafe Animation RankUpAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_RankUpAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_RankUpAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCA RID: 11466
		// (get) Token: 0x06009241 RID: 37441 RVA: 0x0025BF78 File Offset: 0x0025A178
		// (set) Token: 0x06009242 RID: 37442 RVA: 0x00046B5E File Offset: 0x00044D5E
		public unsafe TextMeshProUGUI OldRankLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OldRankLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OldRankLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCB RID: 11467
		// (get) Token: 0x06009243 RID: 37443 RVA: 0x0025BFA8 File Offset: 0x0025A1A8
		// (set) Token: 0x06009244 RID: 37444 RVA: 0x00046B7D File Offset: 0x00044D7D
		public unsafe TextMeshProUGUI NewRankLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_NewRankLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_NewRankLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCC RID: 11468
		// (get) Token: 0x06009245 RID: 37445 RVA: 0x0025BFD8 File Offset: 0x0025A1D8
		// (set) Token: 0x06009246 RID: 37446 RVA: 0x00046B9C File Offset: 0x00044D9C
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x06009247 RID: 37447 RVA: 0x0025C008 File Offset: 0x0025A208
		// (set) Token: 0x06009248 RID: 37448 RVA: 0x00046BBB File Offset: 0x00044DBB
		public unsafe GameObject UnlockedItemsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCE RID: 11470
		// (get) Token: 0x06009249 RID: 37449 RVA: 0x0025C038 File Offset: 0x0025A238
		// (set) Token: 0x0600924A RID: 37450 RVA: 0x00046BDA File Offset: 0x00044DDA
		public unsafe Il2CppReferenceArray<RectTransform> UnlockedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCF RID: 11471
		// (get) Token: 0x0600924B RID: 37451 RVA: 0x0025C068 File Offset: 0x0025A268
		// (set) Token: 0x0600924C RID: 37452 RVA: 0x00046BF9 File Offset: 0x00044DF9
		public unsafe TextMeshProUGUI ExtraUnlocksLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ExtraUnlocksLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ExtraUnlocksLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CD0 RID: 11472
		// (get) Token: 0x0600924D RID: 37453 RVA: 0x0025C098 File Offset: 0x0025A298
		// (set) Token: 0x0600924E RID: 37454 RVA: 0x00046C18 File Offset: 0x00044E18
		public unsafe AudioSourceController SoundEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_SoundEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_SoundEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CD1 RID: 11473
		// (get) Token: 0x0600924F RID: 37455 RVA: 0x0025C0C8 File Offset: 0x0025A2C8
		// (set) Token: 0x06009250 RID: 37456 RVA: 0x00046C37 File Offset: 0x00044E37
		public unsafe Slider ProgressSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CD2 RID: 11474
		// (get) Token: 0x06009251 RID: 37457 RVA: 0x0025C0F8 File Offset: 0x0025A2F8
		// (set) Token: 0x06009252 RID: 37458 RVA: 0x00046C56 File Offset: 0x00044E56
		public unsafe TextMeshProUGUI ProgressLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x06009253 RID: 37459 RVA: 0x0025C128 File Offset: 0x0025A328
		// (set) Token: 0x06009254 RID: 37460 RVA: 0x00046C75 File Offset: 0x00044E75
		public unsafe AudioSourceController BlipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_BlipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_BlipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CD4 RID: 11476
		// (get) Token: 0x06009255 RID: 37461 RVA: 0x0025C158 File Offset: 0x0025A358
		// (set) Token: 0x06009256 RID: 37462 RVA: 0x00046C94 File Offset: 0x00044E94
		public unsafe AudioSourceController ClickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ClickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ClickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CD5 RID: 11477
		// (get) Token: 0x06009257 RID: 37463 RVA: 0x0025C188 File Offset: 0x0025A388
		// (set) Token: 0x06009258 RID: 37464 RVA: 0x00046CB3 File Offset: 0x00044EB3
		public unsafe Coroutine coroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_coroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CD6 RID: 11478
		// (get) Token: 0x06009259 RID: 37465 RVA: 0x0025C1B8 File Offset: 0x0025A3B8
		// (set) Token: 0x0600925A RID: 37466 RVA: 0x00046CD2 File Offset: 0x00044ED2
		public unsafe List<Tuple<FullRank, FullRank>> queuedRankUps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_queuedRankUps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tuple<FullRank, FullRank>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_queuedRankUps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040062C6 RID: 25286
		private static readonly IntPtr NativeFieldInfoPtr__IsRunning_k__BackingField;

		// Token: 0x040062C7 RID: 25287
		private static readonly IntPtr NativeFieldInfoPtr__Order_k__BackingField;

		// Token: 0x040062C8 RID: 25288
		private static readonly IntPtr NativeFieldInfoPtr_OpenCloseAnim;

		// Token: 0x040062C9 RID: 25289
		private static readonly IntPtr NativeFieldInfoPtr_RankUpAnim;

		// Token: 0x040062CA RID: 25290
		private static readonly IntPtr NativeFieldInfoPtr_OldRankLabel;

		// Token: 0x040062CB RID: 25291
		private static readonly IntPtr NativeFieldInfoPtr_NewRankLabel;

		// Token: 0x040062CC RID: 25292
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040062CD RID: 25293
		private static readonly IntPtr NativeFieldInfoPtr_UnlockedItemsContainer;

		// Token: 0x040062CE RID: 25294
		private static readonly IntPtr NativeFieldInfoPtr_UnlockedItems;

		// Token: 0x040062CF RID: 25295
		private static readonly IntPtr NativeFieldInfoPtr_ExtraUnlocksLabel;

		// Token: 0x040062D0 RID: 25296
		private static readonly IntPtr NativeFieldInfoPtr_SoundEffect;

		// Token: 0x040062D1 RID: 25297
		private static readonly IntPtr NativeFieldInfoPtr_ProgressSlider;

		// Token: 0x040062D2 RID: 25298
		private static readonly IntPtr NativeFieldInfoPtr_ProgressLabel;

		// Token: 0x040062D3 RID: 25299
		private static readonly IntPtr NativeFieldInfoPtr_BlipSound;

		// Token: 0x040062D4 RID: 25300
		private static readonly IntPtr NativeFieldInfoPtr_ClickSound;

		// Token: 0x040062D5 RID: 25301
		private static readonly IntPtr NativeFieldInfoPtr_coroutine;

		// Token: 0x040062D6 RID: 25302
		private static readonly IntPtr NativeFieldInfoPtr_queuedRankUps;

		// Token: 0x040062D7 RID: 25303
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040062D8 RID: 25304
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0;

		// Token: 0x040062D9 RID: 25305
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040062DA RID: 25306
		private static readonly IntPtr NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0;

		// Token: 0x040062DB RID: 25307
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040062DC RID: 25308
		private static readonly IntPtr NativeMethodInfoPtr_QueuePostSleepEvent_Private_Void_0;

		// Token: 0x040062DD RID: 25309
		private static readonly IntPtr NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0;

		// Token: 0x040062DE RID: 25310
		private static readonly IntPtr NativeMethodInfoPtr_EndEvent_Public_Void_0;

		// Token: 0x040062DF RID: 25311
		private static readonly IntPtr NativeMethodInfoPtr_RankUp_Public_Void_FullRank_FullRank_0;

		// Token: 0x040062E0 RID: 25312
		private static readonly IntPtr NativeMethodInfoPtr_PlayRankupAnimation_Private_Void_FullRank_FullRank_Boolean_0;

		// Token: 0x040062E1 RID: 25313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B4E RID: 2894
		[ObfuscatedName("ScheduleOne.UI.RankUpCanvas+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D996 RID: 55702 RVA: 0x00339EA0 File Offset: 0x003380A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr);
				RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr_progressDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, "progressDisplays");
				RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				RankUpCanvas.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, 100681456);
				RankUpCanvas.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, 100681457);
			}

			// Token: 0x0600D997 RID: 55703 RVA: 0x00339F1C File Offset: 0x0033811C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D998 RID: 55704 RVA: 0x00339F58 File Offset: 0x00338158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264471, XrefRangeEnd = 264476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D999 RID: 55705 RVA: 0x00069FBF File Offset: 0x000681BF
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004383 RID: 17283
			// (get) Token: 0x0600D99A RID: 55706 RVA: 0x00339F98 File Offset: 0x00338198
			// (set) Token: 0x0600D99B RID: 55707 RVA: 0x00069FC8 File Offset: 0x000681C8
			public unsafe List<Tuple<FullRank, int, int>> progressDisplays
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr_progressDisplays);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tuple<FullRank, int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr_progressDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004384 RID: 17284
			// (get) Token: 0x0600D99C RID: 55708 RVA: 0x00339FC8 File Offset: 0x003381C8
			// (set) Token: 0x0600D99D RID: 55709 RVA: 0x00069FE7 File Offset: 0x000681E7
			public unsafe RankUpCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankUpCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009227 RID: 37415
			private static readonly IntPtr NativeFieldInfoPtr_progressDisplays;

			// Token: 0x04009228 RID: 37416
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009229 RID: 37417
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400922A RID: 37418
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C79 RID: 3193
			[ObfuscatedName("ScheduleOne.UI.RankUpCanvas+<>c__DisplayClass25_0+<<StartEvent>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E5CD RID: 58829 RVA: 0x0035D1E8 File Offset: 0x0035B3E8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique()
				{
					Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, "<<StartEvent>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>1__state");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>2__current");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>4__this");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__rankSoundPlayed_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<rankSoundPlayed>5__2");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>7__wrap2");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__progress_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<progress>5__4");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__oldRank_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<oldRank>5__5");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__newRank_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<newRank>5__6");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__startXP_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<startXP>5__7");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__endXP_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<endXP>5__8");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__lerpTime_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<lerpTime>5__9");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__xpForRank_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<xpForRank>5__10");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipSpacing_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<blipSpacing>5__11");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipTime_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<blipTime>5__12");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__i_5__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<i>5__13");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681458);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681459);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681460);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681461);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681462);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681463);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681464);
				}

				// Token: 0x0600E5CE RID: 58830 RVA: 0x0035D3CC File Offset: 0x0035B5CC
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E5CF RID: 58831 RVA: 0x0035D414 File Offset: 0x0035B614
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 264366, RefRangeEnd = 264367, XrefRangeStart = 264361, XrefRangeEnd = 264366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E5D0 RID: 58832 RVA: 0x0035D448 File Offset: 0x0035B648
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264367, XrefRangeEnd = 264463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E5D1 RID: 58833 RVA: 0x0035D484 File Offset: 0x0035B684
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264463, XrefRangeEnd = 264466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __m__Finally1()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004788 RID: 18312
				// (get) Token: 0x0600E5D2 RID: 58834 RVA: 0x0035D4B8 File Offset: 0x0035B6B8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E5D3 RID: 58835 RVA: 0x0035D4F8 File Offset: 0x0035B6F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264466, XrefRangeEnd = 264471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004789 RID: 18313
				// (get) Token: 0x0600E5D4 RID: 58836 RVA: 0x0035D52C File Offset: 0x0035B72C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E5D5 RID: 58837 RVA: 0x00070198 File Offset: 0x0006E398
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004779 RID: 18297
				// (get) Token: 0x0600E5D6 RID: 58838 RVA: 0x0035D56C File Offset: 0x0035B76C
				// (set) Token: 0x0600E5D7 RID: 58839 RVA: 0x000701A1 File Offset: 0x0006E3A1
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700477A RID: 18298
				// (get) Token: 0x0600E5D8 RID: 58840 RVA: 0x0035D594 File Offset: 0x0035B794
				// (set) Token: 0x0600E5D9 RID: 58841 RVA: 0x000701BC File Offset: 0x0006E3BC
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700477B RID: 18299
				// (get) Token: 0x0600E5DA RID: 58842 RVA: 0x0035D5C4 File Offset: 0x0035B7C4
				// (set) Token: 0x0600E5DB RID: 58843 RVA: 0x000701DB File Offset: 0x0006E3DB
				public unsafe RankUpCanvas.__c__DisplayClass25_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankUpCanvas.__c__DisplayClass25_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700477C RID: 18300
				// (get) Token: 0x0600E5DC RID: 58844 RVA: 0x0035D5F4 File Offset: 0x0035B7F4
				// (set) Token: 0x0600E5DD RID: 58845 RVA: 0x000701FA File Offset: 0x0006E3FA
				public unsafe bool _rankSoundPlayed_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__rankSoundPlayed_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__rankSoundPlayed_5__2)) = value;
					}
				}

				// Token: 0x1700477D RID: 18301
				// (get) Token: 0x0600E5DE RID: 58846 RVA: 0x0035D61C File Offset: 0x0035B81C
				// (set) Token: 0x0600E5DF RID: 58847 RVA: 0x00070215 File Offset: 0x0006E415
				public List<Tuple<FullRank, int, int>>.Enumerator __7__wrap2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___7__wrap2);
						return new List<Tuple<FullRank, int, int>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Tuple<FullRank, int, int>>.Enumerator>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Tuple<FullRank, int, int>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x1700477E RID: 18302
				// (get) Token: 0x0600E5E0 RID: 58848 RVA: 0x0035D64C File Offset: 0x0035B84C
				// (set) Token: 0x0600E5E1 RID: 58849 RVA: 0x00070243 File Offset: 0x0006E443
				public unsafe Tuple<FullRank, int, int> _progress_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__progress_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tuple<FullRank, int, int>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__progress_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700477F RID: 18303
				// (get) Token: 0x0600E5E2 RID: 58850 RVA: 0x0035D67C File Offset: 0x0035B87C
				// (set) Token: 0x0600E5E3 RID: 58851 RVA: 0x00070262 File Offset: 0x0006E462
				public unsafe FullRank _oldRank_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__oldRank_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__oldRank_5__5)) = value;
					}
				}

				// Token: 0x17004780 RID: 18304
				// (get) Token: 0x0600E5E4 RID: 58852 RVA: 0x0035D6A4 File Offset: 0x0035B8A4
				// (set) Token: 0x0600E5E5 RID: 58853 RVA: 0x0007027D File Offset: 0x0006E47D
				public unsafe FullRank _newRank_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__newRank_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__newRank_5__6)) = value;
					}
				}

				// Token: 0x17004781 RID: 18305
				// (get) Token: 0x0600E5E6 RID: 58854 RVA: 0x0035D6CC File Offset: 0x0035B8CC
				// (set) Token: 0x0600E5E7 RID: 58855 RVA: 0x00070298 File Offset: 0x0006E498
				public unsafe int _startXP_5__7
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__startXP_5__7);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__startXP_5__7)) = value;
					}
				}

				// Token: 0x17004782 RID: 18306
				// (get) Token: 0x0600E5E8 RID: 58856 RVA: 0x0035D6F4 File Offset: 0x0035B8F4
				// (set) Token: 0x0600E5E9 RID: 58857 RVA: 0x000702B3 File Offset: 0x0006E4B3
				public unsafe int _endXP_5__8
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__endXP_5__8);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__endXP_5__8)) = value;
					}
				}

				// Token: 0x17004783 RID: 18307
				// (get) Token: 0x0600E5EA RID: 58858 RVA: 0x0035D71C File Offset: 0x0035B91C
				// (set) Token: 0x0600E5EB RID: 58859 RVA: 0x000702CE File Offset: 0x0006E4CE
				public unsafe float _lerpTime_5__9
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__lerpTime_5__9);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__lerpTime_5__9)) = value;
					}
				}

				// Token: 0x17004784 RID: 18308
				// (get) Token: 0x0600E5EC RID: 58860 RVA: 0x0035D744 File Offset: 0x0035B944
				// (set) Token: 0x0600E5ED RID: 58861 RVA: 0x000702E9 File Offset: 0x0006E4E9
				public unsafe int _xpForRank_5__10
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__xpForRank_5__10);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__xpForRank_5__10)) = value;
					}
				}

				// Token: 0x17004785 RID: 18309
				// (get) Token: 0x0600E5EE RID: 58862 RVA: 0x0035D76C File Offset: 0x0035B96C
				// (set) Token: 0x0600E5EF RID: 58863 RVA: 0x00070304 File Offset: 0x0006E504
				public unsafe float _blipSpacing_5__11
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipSpacing_5__11);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipSpacing_5__11)) = value;
					}
				}

				// Token: 0x17004786 RID: 18310
				// (get) Token: 0x0600E5F0 RID: 58864 RVA: 0x0035D794 File Offset: 0x0035B994
				// (set) Token: 0x0600E5F1 RID: 58865 RVA: 0x0007031F File Offset: 0x0006E51F
				public unsafe float _blipTime_5__12
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipTime_5__12);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipTime_5__12)) = value;
					}
				}

				// Token: 0x17004787 RID: 18311
				// (get) Token: 0x0600E5F2 RID: 58866 RVA: 0x0035D7BC File Offset: 0x0035B9BC
				// (set) Token: 0x0600E5F3 RID: 58867 RVA: 0x0007033A File Offset: 0x0006E53A
				public unsafe float _i_5__13
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__i_5__13);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__i_5__13)) = value;
					}
				}

				// Token: 0x040099A4 RID: 39332
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040099A5 RID: 39333
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040099A6 RID: 39334
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040099A7 RID: 39335
				private static readonly IntPtr NativeFieldInfoPtr__rankSoundPlayed_5__2;

				// Token: 0x040099A8 RID: 39336
				private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

				// Token: 0x040099A9 RID: 39337
				private static readonly IntPtr NativeFieldInfoPtr__progress_5__4;

				// Token: 0x040099AA RID: 39338
				private static readonly IntPtr NativeFieldInfoPtr__oldRank_5__5;

				// Token: 0x040099AB RID: 39339
				private static readonly IntPtr NativeFieldInfoPtr__newRank_5__6;

				// Token: 0x040099AC RID: 39340
				private static readonly IntPtr NativeFieldInfoPtr__startXP_5__7;

				// Token: 0x040099AD RID: 39341
				private static readonly IntPtr NativeFieldInfoPtr__endXP_5__8;

				// Token: 0x040099AE RID: 39342
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__9;

				// Token: 0x040099AF RID: 39343
				private static readonly IntPtr NativeFieldInfoPtr__xpForRank_5__10;

				// Token: 0x040099B0 RID: 39344
				private static readonly IntPtr NativeFieldInfoPtr__blipSpacing_5__11;

				// Token: 0x040099B1 RID: 39345
				private static readonly IntPtr NativeFieldInfoPtr__blipTime_5__12;

				// Token: 0x040099B2 RID: 39346
				private static readonly IntPtr NativeFieldInfoPtr__i_5__13;

				// Token: 0x040099B3 RID: 39347
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040099B4 RID: 39348
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099B5 RID: 39349
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040099B6 RID: 39350
				private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

				// Token: 0x040099B7 RID: 39351
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040099B8 RID: 39352
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099B9 RID: 39353
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
