using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000652 RID: 1618
	public class PickpocketScreen : Singleton<PickpocketScreen>
	{
		// Token: 0x06009023 RID: 36899 RVA: 0x002558B8 File Offset: 0x00253AB8
		// Note: this type is marked as 'beforefieldinit'.
		static PickpocketScreen()
		{
			Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PickpocketScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr);
			PickpocketScreen.NativeFieldInfoPtr_PICKPOCKET_XP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "PICKPOCKET_XP");
			PickpocketScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			PickpocketScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "<TutorialOpen>k__BackingField");
			PickpocketScreen.NativeFieldInfoPtr_GreenAreaMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "GreenAreaMaxWidth");
			PickpocketScreen.NativeFieldInfoPtr_GreenAreaMinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "GreenAreaMinWidth");
			PickpocketScreen.NativeFieldInfoPtr_SlideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "SlideTime");
			PickpocketScreen.NativeFieldInfoPtr_SlideTimeMaxMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "SlideTimeMaxMultiplier");
			PickpocketScreen.NativeFieldInfoPtr_ValueDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "ValueDivisor");
			PickpocketScreen.NativeFieldInfoPtr_Tolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Tolerance");
			PickpocketScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Canvas");
			PickpocketScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Container");
			PickpocketScreen.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Slots");
			PickpocketScreen.NativeFieldInfoPtr_GreenAreas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "GreenAreas");
			PickpocketScreen.NativeFieldInfoPtr_TutorialAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "TutorialAnimation");
			PickpocketScreen.NativeFieldInfoPtr_TutorialContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "TutorialContainer");
			PickpocketScreen.NativeFieldInfoPtr_SliderContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "SliderContainer");
			PickpocketScreen.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Slider");
			PickpocketScreen.NativeFieldInfoPtr_InputPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "InputPrompt");
			PickpocketScreen.NativeFieldInfoPtr_onFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "onFail");
			PickpocketScreen.NativeFieldInfoPtr_onStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "onStop");
			PickpocketScreen.NativeFieldInfoPtr_onHitGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "onHitGreen");
			PickpocketScreen.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "npc");
			PickpocketScreen.NativeFieldInfoPtr_isSliding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "isSliding");
			PickpocketScreen.NativeFieldInfoPtr_slideDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "slideDirection");
			PickpocketScreen.NativeFieldInfoPtr_sliderPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "sliderPosition");
			PickpocketScreen.NativeFieldInfoPtr_slideTimeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "slideTimeMultiplier");
			PickpocketScreen.NativeFieldInfoPtr_isFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "isFail");
			PickpocketScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681150);
			PickpocketScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681151);
			PickpocketScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681152);
			PickpocketScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681153);
			PickpocketScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681154);
			PickpocketScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681155);
			PickpocketScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681156);
			PickpocketScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681157);
			PickpocketScreen.NativeMethodInfoPtr_StopArrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681158);
			PickpocketScreen.NativeMethodInfoPtr_SetSlotLocked_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681159);
			PickpocketScreen.NativeMethodInfoPtr_GetHoveredSlot_Private_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681160);
			PickpocketScreen.NativeMethodInfoPtr_Fail_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681161);
			PickpocketScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681162);
			PickpocketScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681163);
			PickpocketScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681164);
			PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedPosition_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681165);
			PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedWidth_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681166);
			PickpocketScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681167);
			PickpocketScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681168);
		}

		// Token: 0x17002C38 RID: 11320
		// (get) Token: 0x06009024 RID: 36900 RVA: 0x00255C80 File Offset: 0x00253E80
		// (set) Token: 0x06009025 RID: 36901 RVA: 0x00255CBC File Offset: 0x00253EBC
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002C39 RID: 11321
		// (get) Token: 0x06009026 RID: 36902 RVA: 0x00255CFC File Offset: 0x00253EFC
		// (set) Token: 0x06009027 RID: 36903 RVA: 0x00255D38 File Offset: 0x00253F38
		public unsafe bool TutorialOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009028 RID: 36904 RVA: 0x00255D78 File Offset: 0x00253F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261421, XrefRangeEnd = 261438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickpocketScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009029 RID: 36905 RVA: 0x00255DB4 File Offset: 0x00253FB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261544, RefRangeEnd = 261546, XrefRangeStart = 261438, XrefRangeEnd = 261544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(NPC _npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600902A RID: 36906 RVA: 0x00255DF8 File Offset: 0x00253FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261546, XrefRangeEnd = 261548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600902B RID: 36907 RVA: 0x00255E3C File Offset: 0x0025403C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261548, XrefRangeEnd = 261576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600902C RID: 36908 RVA: 0x00255E70 File Offset: 0x00254070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261597, RefRangeEnd = 261598, XrefRangeStart = 261576, XrefRangeEnd = 261597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopArrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_StopArrow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600902D RID: 36909 RVA: 0x00255EA4 File Offset: 0x002540A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261607, RefRangeEnd = 261608, XrefRangeStart = 261598, XrefRangeEnd = 261607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotLocked(int index, bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_SetSlotLocked_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600902E RID: 36910 RVA: 0x00255EF0 File Offset: 0x002540F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261615, RefRangeEnd = 261618, XrefRangeStart = 261608, XrefRangeEnd = 261615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotUI GetHoveredSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_GetHoveredSlot_Private_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr3) : null;
		}

		// Token: 0x0600902F RID: 36911 RVA: 0x00255F30 File Offset: 0x00254130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261618, XrefRangeEnd = 261625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Fail_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009030 RID: 36912 RVA: 0x00255F64 File Offset: 0x00254164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261680, RefRangeEnd = 261681, XrefRangeStart = 261625, XrefRangeEnd = 261680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009031 RID: 36913 RVA: 0x00255F98 File Offset: 0x00254198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261681, XrefRangeEnd = 261685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009032 RID: 36914 RVA: 0x00255FCC File Offset: 0x002541CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261685, XrefRangeEnd = 261688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009033 RID: 36915 RVA: 0x00256000 File Offset: 0x00254200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261690, RefRangeEnd = 261692, XrefRangeStart = 261688, XrefRangeEnd = 261690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetGreenAreaNormalizedPosition(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedPosition_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009034 RID: 36916 RVA: 0x0025604C File Offset: 0x0025424C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261694, RefRangeEnd = 261696, XrefRangeStart = 261692, XrefRangeEnd = 261694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetGreenAreaNormalizedWidth(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedWidth_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009035 RID: 36917 RVA: 0x00256098 File Offset: 0x00254298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261696, XrefRangeEnd = 261699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PickpocketScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009036 RID: 36918 RVA: 0x002560D4 File Offset: 0x002542D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261699, XrefRangeEnd = 261704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009037 RID: 36919 RVA: 0x000458BD File Offset: 0x00043ABD
		public PickpocketScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C1D RID: 11293
		// (get) Token: 0x06009038 RID: 36920 RVA: 0x00256114 File Offset: 0x00254314
		// (set) Token: 0x06009039 RID: 36921 RVA: 0x000458C6 File Offset: 0x00043AC6
		public unsafe static int PICKPOCKET_XP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PickpocketScreen.NativeFieldInfoPtr_PICKPOCKET_XP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PickpocketScreen.NativeFieldInfoPtr_PICKPOCKET_XP, (void*)(&value));
			}
		}

		// Token: 0x17002C1E RID: 11294
		// (get) Token: 0x0600903A RID: 36922 RVA: 0x00256130 File Offset: 0x00254330
		// (set) Token: 0x0600903B RID: 36923 RVA: 0x000458D4 File Offset: 0x00043AD4
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C1F RID: 11295
		// (get) Token: 0x0600903C RID: 36924 RVA: 0x00256158 File Offset: 0x00254358
		// (set) Token: 0x0600903D RID: 36925 RVA: 0x000458EF File Offset: 0x00043AEF
		public unsafe bool _TutorialOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x0600903E RID: 36926 RVA: 0x00256180 File Offset: 0x00254380
		// (set) Token: 0x0600903F RID: 36927 RVA: 0x0004590A File Offset: 0x00043B0A
		public unsafe float GreenAreaMaxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMaxWidth)) = value;
			}
		}

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x06009040 RID: 36928 RVA: 0x002561A8 File Offset: 0x002543A8
		// (set) Token: 0x06009041 RID: 36929 RVA: 0x00045925 File Offset: 0x00043B25
		public unsafe float GreenAreaMinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMinWidth)) = value;
			}
		}

		// Token: 0x17002C22 RID: 11298
		// (get) Token: 0x06009042 RID: 36930 RVA: 0x002561D0 File Offset: 0x002543D0
		// (set) Token: 0x06009043 RID: 36931 RVA: 0x00045940 File Offset: 0x00043B40
		public unsafe float SlideTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTime)) = value;
			}
		}

		// Token: 0x17002C23 RID: 11299
		// (get) Token: 0x06009044 RID: 36932 RVA: 0x002561F8 File Offset: 0x002543F8
		// (set) Token: 0x06009045 RID: 36933 RVA: 0x0004595B File Offset: 0x00043B5B
		public unsafe float SlideTimeMaxMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTimeMaxMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTimeMaxMultiplier)) = value;
			}
		}

		// Token: 0x17002C24 RID: 11300
		// (get) Token: 0x06009046 RID: 36934 RVA: 0x00256220 File Offset: 0x00254420
		// (set) Token: 0x06009047 RID: 36935 RVA: 0x00045976 File Offset: 0x00043B76
		public unsafe float ValueDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ValueDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ValueDivisor)) = value;
			}
		}

		// Token: 0x17002C25 RID: 11301
		// (get) Token: 0x06009048 RID: 36936 RVA: 0x00256248 File Offset: 0x00254448
		// (set) Token: 0x06009049 RID: 36937 RVA: 0x00045991 File Offset: 0x00043B91
		public unsafe float Tolerance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Tolerance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Tolerance)) = value;
			}
		}

		// Token: 0x17002C26 RID: 11302
		// (get) Token: 0x0600904A RID: 36938 RVA: 0x00256270 File Offset: 0x00254470
		// (set) Token: 0x0600904B RID: 36939 RVA: 0x000459AC File Offset: 0x00043BAC
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C27 RID: 11303
		// (get) Token: 0x0600904C RID: 36940 RVA: 0x002562A0 File Offset: 0x002544A0
		// (set) Token: 0x0600904D RID: 36941 RVA: 0x000459CB File Offset: 0x00043BCB
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C28 RID: 11304
		// (get) Token: 0x0600904E RID: 36942 RVA: 0x002562D0 File Offset: 0x002544D0
		// (set) Token: 0x0600904F RID: 36943 RVA: 0x000459EA File Offset: 0x00043BEA
		public unsafe Il2CppReferenceArray<ItemSlotUI> Slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C29 RID: 11305
		// (get) Token: 0x06009050 RID: 36944 RVA: 0x00256300 File Offset: 0x00254500
		// (set) Token: 0x06009051 RID: 36945 RVA: 0x00045A09 File Offset: 0x00043C09
		public unsafe Il2CppReferenceArray<RectTransform> GreenAreas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C2A RID: 11306
		// (get) Token: 0x06009052 RID: 36946 RVA: 0x00256330 File Offset: 0x00254530
		// (set) Token: 0x06009053 RID: 36947 RVA: 0x00045A28 File Offset: 0x00043C28
		public unsafe Animation TutorialAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C2B RID: 11307
		// (get) Token: 0x06009054 RID: 36948 RVA: 0x00256360 File Offset: 0x00254560
		// (set) Token: 0x06009055 RID: 36949 RVA: 0x00045A47 File Offset: 0x00043C47
		public unsafe RectTransform TutorialContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C2C RID: 11308
		// (get) Token: 0x06009056 RID: 36950 RVA: 0x00256390 File Offset: 0x00254590
		// (set) Token: 0x06009057 RID: 36951 RVA: 0x00045A66 File Offset: 0x00043C66
		public unsafe RectTransform SliderContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SliderContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SliderContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C2D RID: 11309
		// (get) Token: 0x06009058 RID: 36952 RVA: 0x002563C0 File Offset: 0x002545C0
		// (set) Token: 0x06009059 RID: 36953 RVA: 0x00045A85 File Offset: 0x00043C85
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C2E RID: 11310
		// (get) Token: 0x0600905A RID: 36954 RVA: 0x002563F0 File Offset: 0x002545F0
		// (set) Token: 0x0600905B RID: 36955 RVA: 0x00045AA4 File Offset: 0x00043CA4
		public unsafe InputPrompt InputPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_InputPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_InputPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C2F RID: 11311
		// (get) Token: 0x0600905C RID: 36956 RVA: 0x00256420 File Offset: 0x00254620
		// (set) Token: 0x0600905D RID: 36957 RVA: 0x00045AC3 File Offset: 0x00043CC3
		public unsafe UnityEvent onFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onFail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onFail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C30 RID: 11312
		// (get) Token: 0x0600905E RID: 36958 RVA: 0x00256450 File Offset: 0x00254650
		// (set) Token: 0x0600905F RID: 36959 RVA: 0x00045AE2 File Offset: 0x00043CE2
		public unsafe UnityEvent onStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onStop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C31 RID: 11313
		// (get) Token: 0x06009060 RID: 36960 RVA: 0x00256480 File Offset: 0x00254680
		// (set) Token: 0x06009061 RID: 36961 RVA: 0x00045B01 File Offset: 0x00043D01
		public unsafe UnityEvent onHitGreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onHitGreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onHitGreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C32 RID: 11314
		// (get) Token: 0x06009062 RID: 36962 RVA: 0x002564B0 File Offset: 0x002546B0
		// (set) Token: 0x06009063 RID: 36963 RVA: 0x00045B20 File Offset: 0x00043D20
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C33 RID: 11315
		// (get) Token: 0x06009064 RID: 36964 RVA: 0x002564E0 File Offset: 0x002546E0
		// (set) Token: 0x06009065 RID: 36965 RVA: 0x00045B3F File Offset: 0x00043D3F
		public unsafe bool isSliding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isSliding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isSliding)) = value;
			}
		}

		// Token: 0x17002C34 RID: 11316
		// (get) Token: 0x06009066 RID: 36966 RVA: 0x00256508 File Offset: 0x00254708
		// (set) Token: 0x06009067 RID: 36967 RVA: 0x00045B5A File Offset: 0x00043D5A
		public unsafe int slideDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideDirection)) = value;
			}
		}

		// Token: 0x17002C35 RID: 11317
		// (get) Token: 0x06009068 RID: 36968 RVA: 0x00256530 File Offset: 0x00254730
		// (set) Token: 0x06009069 RID: 36969 RVA: 0x00045B75 File Offset: 0x00043D75
		public unsafe float sliderPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_sliderPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_sliderPosition)) = value;
			}
		}

		// Token: 0x17002C36 RID: 11318
		// (get) Token: 0x0600906A RID: 36970 RVA: 0x00256558 File Offset: 0x00254758
		// (set) Token: 0x0600906B RID: 36971 RVA: 0x00045B90 File Offset: 0x00043D90
		public unsafe float slideTimeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideTimeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideTimeMultiplier)) = value;
			}
		}

		// Token: 0x17002C37 RID: 11319
		// (get) Token: 0x0600906C RID: 36972 RVA: 0x00256580 File Offset: 0x00254780
		// (set) Token: 0x0600906D RID: 36973 RVA: 0x00045BAB File Offset: 0x00043DAB
		public unsafe bool isFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isFail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isFail)) = value;
			}
		}

		// Token: 0x0400617E RID: 24958
		private static readonly IntPtr NativeFieldInfoPtr_PICKPOCKET_XP;

		// Token: 0x0400617F RID: 24959
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006180 RID: 24960
		private static readonly IntPtr NativeFieldInfoPtr__TutorialOpen_k__BackingField;

		// Token: 0x04006181 RID: 24961
		private static readonly IntPtr NativeFieldInfoPtr_GreenAreaMaxWidth;

		// Token: 0x04006182 RID: 24962
		private static readonly IntPtr NativeFieldInfoPtr_GreenAreaMinWidth;

		// Token: 0x04006183 RID: 24963
		private static readonly IntPtr NativeFieldInfoPtr_SlideTime;

		// Token: 0x04006184 RID: 24964
		private static readonly IntPtr NativeFieldInfoPtr_SlideTimeMaxMultiplier;

		// Token: 0x04006185 RID: 24965
		private static readonly IntPtr NativeFieldInfoPtr_ValueDivisor;

		// Token: 0x04006186 RID: 24966
		private static readonly IntPtr NativeFieldInfoPtr_Tolerance;

		// Token: 0x04006187 RID: 24967
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006188 RID: 24968
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006189 RID: 24969
		private static readonly IntPtr NativeFieldInfoPtr_Slots;

		// Token: 0x0400618A RID: 24970
		private static readonly IntPtr NativeFieldInfoPtr_GreenAreas;

		// Token: 0x0400618B RID: 24971
		private static readonly IntPtr NativeFieldInfoPtr_TutorialAnimation;

		// Token: 0x0400618C RID: 24972
		private static readonly IntPtr NativeFieldInfoPtr_TutorialContainer;

		// Token: 0x0400618D RID: 24973
		private static readonly IntPtr NativeFieldInfoPtr_SliderContainer;

		// Token: 0x0400618E RID: 24974
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x0400618F RID: 24975
		private static readonly IntPtr NativeFieldInfoPtr_InputPrompt;

		// Token: 0x04006190 RID: 24976
		private static readonly IntPtr NativeFieldInfoPtr_onFail;

		// Token: 0x04006191 RID: 24977
		private static readonly IntPtr NativeFieldInfoPtr_onStop;

		// Token: 0x04006192 RID: 24978
		private static readonly IntPtr NativeFieldInfoPtr_onHitGreen;

		// Token: 0x04006193 RID: 24979
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x04006194 RID: 24980
		private static readonly IntPtr NativeFieldInfoPtr_isSliding;

		// Token: 0x04006195 RID: 24981
		private static readonly IntPtr NativeFieldInfoPtr_slideDirection;

		// Token: 0x04006196 RID: 24982
		private static readonly IntPtr NativeFieldInfoPtr_sliderPosition;

		// Token: 0x04006197 RID: 24983
		private static readonly IntPtr NativeFieldInfoPtr_slideTimeMultiplier;

		// Token: 0x04006198 RID: 24984
		private static readonly IntPtr NativeFieldInfoPtr_isFail;

		// Token: 0x04006199 RID: 24985
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400619A RID: 24986
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400619B RID: 24987
		private static readonly IntPtr NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0;

		// Token: 0x0400619C RID: 24988
		private static readonly IntPtr NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400619D RID: 24989
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400619E RID: 24990
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_NPC_0;

		// Token: 0x0400619F RID: 24991
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040061A0 RID: 24992
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040061A1 RID: 24993
		private static readonly IntPtr NativeMethodInfoPtr_StopArrow_Private_Void_0;

		// Token: 0x040061A2 RID: 24994
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Void_Int32_Boolean_0;

		// Token: 0x040061A3 RID: 24995
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredSlot_Private_ItemSlotUI_0;

		// Token: 0x040061A4 RID: 24996
		private static readonly IntPtr NativeMethodInfoPtr_Fail_Private_Void_0;

		// Token: 0x040061A5 RID: 24997
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040061A6 RID: 24998
		private static readonly IntPtr NativeMethodInfoPtr_OpenTutorial_Private_Void_0;

		// Token: 0x040061A7 RID: 24999
		private static readonly IntPtr NativeMethodInfoPtr_CloseTutorial_Public_Void_0;

		// Token: 0x040061A8 RID: 25000
		private static readonly IntPtr NativeMethodInfoPtr_GetGreenAreaNormalizedPosition_Private_Single_Int32_0;

		// Token: 0x040061A9 RID: 25001
		private static readonly IntPtr NativeMethodInfoPtr_GetGreenAreaNormalizedWidth_Private_Single_Int32_0;

		// Token: 0x040061AA RID: 25002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040061AB RID: 25003
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B39 RID: 2873
		[ObfuscatedName("ScheduleOne.UI.PickpocketScreen+<<Fail>g__FailCoroutine|40_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D852 RID: 55378 RVA: 0x003361F8 File Offset: 0x003343F8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique()
			{
				Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "<<Fail>g__FailCoroutine|40_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>1__state");
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>2__current");
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>4__this");
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681169);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681170);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681171);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681172);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681173);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681174);
			}

			// Token: 0x0600D853 RID: 55379 RVA: 0x003362D8 File Offset: 0x003344D8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D854 RID: 55380 RVA: 0x00336320 File Offset: 0x00334520
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D855 RID: 55381 RVA: 0x00336354 File Offset: 0x00334554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261411, XrefRangeEnd = 261416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004312 RID: 17170
			// (get) Token: 0x0600D856 RID: 55382 RVA: 0x00336390 File Offset: 0x00334590
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D857 RID: 55383 RVA: 0x003363D0 File Offset: 0x003345D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261416, XrefRangeEnd = 261421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004313 RID: 17171
			// (get) Token: 0x0600D858 RID: 55384 RVA: 0x00336404 File Offset: 0x00334604
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D859 RID: 55385 RVA: 0x000695B2 File Offset: 0x000677B2
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700430F RID: 17167
			// (get) Token: 0x0600D85A RID: 55386 RVA: 0x00336444 File Offset: 0x00334644
			// (set) Token: 0x0600D85B RID: 55387 RVA: 0x000695BB File Offset: 0x000677BB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004310 RID: 17168
			// (get) Token: 0x0600D85C RID: 55388 RVA: 0x0033646C File Offset: 0x0033466C
			// (set) Token: 0x0600D85D RID: 55389 RVA: 0x000695D6 File Offset: 0x000677D6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004311 RID: 17169
			// (get) Token: 0x0600D85E RID: 55390 RVA: 0x0033649C File Offset: 0x0033469C
			// (set) Token: 0x0600D85F RID: 55391 RVA: 0x000695F5 File Offset: 0x000677F5
			public unsafe PickpocketScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PickpocketScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009162 RID: 37218
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009163 RID: 37219
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009164 RID: 37220
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009165 RID: 37221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009166 RID: 37222
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009167 RID: 37223
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009168 RID: 37224
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009169 RID: 37225
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400916A RID: 37226
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
