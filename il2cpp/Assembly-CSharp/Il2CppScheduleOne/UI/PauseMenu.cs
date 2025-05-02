using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.MainMenu;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064F RID: 1615
	public class PauseMenu : Singleton<PauseMenu>
	{
		// Token: 0x06008F53 RID: 36691 RVA: 0x002531BC File Offset: 0x002513BC
		// Note: this type is marked as 'beforefieldinit'.
		static PauseMenu()
		{
			Il2CppClassPointerStore<PauseMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PauseMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr);
			PauseMenu.NativeFieldInfoPtr__IsPaused_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "<IsPaused>k__BackingField");
			PauseMenu.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "Canvas");
			PauseMenu.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "Container");
			PauseMenu.NativeFieldInfoPtr_Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "Screen");
			PauseMenu.NativeFieldInfoPtr_FeedbackForm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "FeedbackForm");
			PauseMenu.NativeFieldInfoPtr_noActiveUIElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "noActiveUIElements");
			PauseMenu.NativeFieldInfoPtr_justPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "justPaused");
			PauseMenu.NativeFieldInfoPtr_justResumed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "justResumed");
			PauseMenu.NativeFieldInfoPtr_couldLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "couldLook");
			PauseMenu.NativeFieldInfoPtr_lockedMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "lockedMouse");
			PauseMenu.NativeFieldInfoPtr_crosshairVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "crosshairVisible");
			PauseMenu.NativeFieldInfoPtr_hudVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "hudVisible");
			PauseMenu.NativeFieldInfoPtr_onPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "onPause");
			PauseMenu.NativeFieldInfoPtr_onResume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "onResume");
			PauseMenu.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681075);
			PauseMenu.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681076);
			PauseMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681077);
			PauseMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681078);
			PauseMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681079);
			PauseMenu.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681080);
			PauseMenu.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681081);
			PauseMenu.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681082);
			PauseMenu.NativeMethodInfoPtr_Resume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681083);
			PauseMenu.NativeMethodInfoPtr_StuckButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681084);
			PauseMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681085);
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x06008F54 RID: 36692 RVA: 0x002533E0 File Offset: 0x002515E0
		// (set) Token: 0x06008F55 RID: 36693 RVA: 0x0025341C File Offset: 0x0025161C
		public unsafe bool IsPaused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008F56 RID: 36694 RVA: 0x0025345C File Offset: 0x0025165C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260390, XrefRangeEnd = 260403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PauseMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F57 RID: 36695 RVA: 0x00253498 File Offset: 0x00251698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260403, XrefRangeEnd = 260410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PauseMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F58 RID: 36696 RVA: 0x002534D4 File Offset: 0x002516D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260410, XrefRangeEnd = 260415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F59 RID: 36697 RVA: 0x00253518 File Offset: 0x00251718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260415, XrefRangeEnd = 260418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F5A RID: 36698 RVA: 0x0025354C File Offset: 0x0025174C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260418, XrefRangeEnd = 260426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F5B RID: 36699 RVA: 0x00253580 File Offset: 0x00251780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260488, RefRangeEnd = 260489, XrefRangeStart = 260426, XrefRangeEnd = 260488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F5C RID: 36700 RVA: 0x002535B4 File Offset: 0x002517B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260545, RefRangeEnd = 260546, XrefRangeStart = 260489, XrefRangeEnd = 260545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Resume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F5D RID: 36701 RVA: 0x002535E8 File Offset: 0x002517E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260546, XrefRangeEnd = 260553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StuckButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_StuckButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F5E RID: 36702 RVA: 0x0025361C File Offset: 0x0025181C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260553, XrefRangeEnd = 260556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PauseMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F5F RID: 36703 RVA: 0x00045135 File Offset: 0x00043335
		public PauseMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x06008F60 RID: 36704 RVA: 0x00253658 File Offset: 0x00251858
		// (set) Token: 0x06008F61 RID: 36705 RVA: 0x0004513E File Offset: 0x0004333E
		public unsafe bool _IsPaused_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr__IsPaused_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr__IsPaused_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x06008F62 RID: 36706 RVA: 0x00253680 File Offset: 0x00251880
		// (set) Token: 0x06008F63 RID: 36707 RVA: 0x00045159 File Offset: 0x00043359
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x06008F64 RID: 36708 RVA: 0x002536B0 File Offset: 0x002518B0
		// (set) Token: 0x06008F65 RID: 36709 RVA: 0x00045178 File Offset: 0x00043378
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x06008F66 RID: 36710 RVA: 0x002536E0 File Offset: 0x002518E0
		// (set) Token: 0x06008F67 RID: 36711 RVA: 0x00045197 File Offset: 0x00043397
		public unsafe MainMenuScreen Screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x06008F68 RID: 36712 RVA: 0x00253710 File Offset: 0x00251910
		// (set) Token: 0x06008F69 RID: 36713 RVA: 0x000451B6 File Offset: 0x000433B6
		public unsafe FeedbackForm FeedbackForm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_FeedbackForm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeedbackForm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_FeedbackForm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x06008F6A RID: 36714 RVA: 0x00253740 File Offset: 0x00251940
		// (set) Token: 0x06008F6B RID: 36715 RVA: 0x000451D5 File Offset: 0x000433D5
		public unsafe bool noActiveUIElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_noActiveUIElements);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_noActiveUIElements)) = value;
			}
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x06008F6C RID: 36716 RVA: 0x00253768 File Offset: 0x00251968
		// (set) Token: 0x06008F6D RID: 36717 RVA: 0x000451F0 File Offset: 0x000433F0
		public unsafe bool justPaused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_justPaused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_justPaused)) = value;
			}
		}

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x06008F6E RID: 36718 RVA: 0x00253790 File Offset: 0x00251990
		// (set) Token: 0x06008F6F RID: 36719 RVA: 0x0004520B File Offset: 0x0004340B
		public unsafe bool justResumed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_justResumed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_justResumed)) = value;
			}
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x06008F70 RID: 36720 RVA: 0x002537B8 File Offset: 0x002519B8
		// (set) Token: 0x06008F71 RID: 36721 RVA: 0x00045226 File Offset: 0x00043426
		public unsafe bool couldLook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_couldLook);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_couldLook)) = value;
			}
		}

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x06008F72 RID: 36722 RVA: 0x002537E0 File Offset: 0x002519E0
		// (set) Token: 0x06008F73 RID: 36723 RVA: 0x00045241 File Offset: 0x00043441
		public unsafe bool lockedMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_lockedMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_lockedMouse)) = value;
			}
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x06008F74 RID: 36724 RVA: 0x00253808 File Offset: 0x00251A08
		// (set) Token: 0x06008F75 RID: 36725 RVA: 0x0004525C File Offset: 0x0004345C
		public unsafe bool crosshairVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_crosshairVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_crosshairVisible)) = value;
			}
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x06008F76 RID: 36726 RVA: 0x00253830 File Offset: 0x00251A30
		// (set) Token: 0x06008F77 RID: 36727 RVA: 0x00045277 File Offset: 0x00043477
		public unsafe bool hudVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_hudVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_hudVisible)) = value;
			}
		}

		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x06008F78 RID: 36728 RVA: 0x00253858 File Offset: 0x00251A58
		// (set) Token: 0x06008F79 RID: 36729 RVA: 0x00045292 File Offset: 0x00043492
		public unsafe UnityEvent onPause
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onPause);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onPause), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x06008F7A RID: 36730 RVA: 0x00253888 File Offset: 0x00251A88
		// (set) Token: 0x06008F7B RID: 36731 RVA: 0x000452B1 File Offset: 0x000434B1
		public unsafe UnityEvent onResume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onResume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onResume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040060F7 RID: 24823
		private static readonly IntPtr NativeFieldInfoPtr__IsPaused_k__BackingField;

		// Token: 0x040060F8 RID: 24824
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040060F9 RID: 24825
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040060FA RID: 24826
		private static readonly IntPtr NativeFieldInfoPtr_Screen;

		// Token: 0x040060FB RID: 24827
		private static readonly IntPtr NativeFieldInfoPtr_FeedbackForm;

		// Token: 0x040060FC RID: 24828
		private static readonly IntPtr NativeFieldInfoPtr_noActiveUIElements;

		// Token: 0x040060FD RID: 24829
		private static readonly IntPtr NativeFieldInfoPtr_justPaused;

		// Token: 0x040060FE RID: 24830
		private static readonly IntPtr NativeFieldInfoPtr_justResumed;

		// Token: 0x040060FF RID: 24831
		private static readonly IntPtr NativeFieldInfoPtr_couldLook;

		// Token: 0x04006100 RID: 24832
		private static readonly IntPtr NativeFieldInfoPtr_lockedMouse;

		// Token: 0x04006101 RID: 24833
		private static readonly IntPtr NativeFieldInfoPtr_crosshairVisible;

		// Token: 0x04006102 RID: 24834
		private static readonly IntPtr NativeFieldInfoPtr_hudVisible;

		// Token: 0x04006103 RID: 24835
		private static readonly IntPtr NativeFieldInfoPtr_onPause;

		// Token: 0x04006104 RID: 24836
		private static readonly IntPtr NativeFieldInfoPtr_onResume;

		// Token: 0x04006105 RID: 24837
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x04006106 RID: 24838
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0;

		// Token: 0x04006107 RID: 24839
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006108 RID: 24840
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006109 RID: 24841
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400610A RID: 24842
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400610B RID: 24843
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400610C RID: 24844
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x0400610D RID: 24845
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Void_0;

		// Token: 0x0400610E RID: 24846
		private static readonly IntPtr NativeMethodInfoPtr_StuckButtonClicked_Public_Void_0;

		// Token: 0x0400610F RID: 24847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
