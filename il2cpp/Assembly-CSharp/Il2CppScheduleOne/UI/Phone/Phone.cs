using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006A5 RID: 1701
	public class Phone : PlayerSingleton<Phone>
	{
		// Token: 0x06009808 RID: 38920 RVA: 0x0026D514 File Offset: 0x0026B714
		// Note: this type is marked as 'beforefieldinit'.
		static Phone()
		{
			Il2CppClassPointerStore<Phone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "Phone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Phone>.NativeClassPtr);
			Phone.NativeFieldInfoPtr_ActiveApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "ActiveApp");
			Phone.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<IsOpen>k__BackingField");
			Phone.NativeFieldInfoPtr__isHorizontal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<isHorizontal>k__BackingField");
			Phone.NativeFieldInfoPtr__isOpenable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<isOpenable>k__BackingField");
			Phone.NativeFieldInfoPtr__FlashlightOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<FlashlightOn>k__BackingField");
			Phone.NativeFieldInfoPtr_testData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "testData");
			Phone.NativeFieldInfoPtr_testCalller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "testCalller");
			Phone.NativeFieldInfoPtr_phoneModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "phoneModel");
			Phone.NativeFieldInfoPtr_orientation_Vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "orientation_Vertical");
			Phone.NativeFieldInfoPtr_orientation_Horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "orientation_Horizontal");
			Phone.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "raycaster");
			Phone.NativeFieldInfoPtr_PhoneFlashlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "PhoneFlashlight");
			Phone.NativeFieldInfoPtr_FlashlightToggleSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "FlashlightToggleSound");
			Phone.NativeFieldInfoPtr_rotationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "rotationTime");
			Phone.NativeFieldInfoPtr_LookOffsetMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "LookOffsetMax");
			Phone.NativeFieldInfoPtr_LookOffsetMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "LookOffsetMin");
			Phone.NativeFieldInfoPtr_OpenVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "OpenVerticalOffset");
			Phone.NativeFieldInfoPtr_onPhoneOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "onPhoneOpened");
			Phone.NativeFieldInfoPtr_onPhoneClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "onPhoneClosed");
			Phone.NativeFieldInfoPtr_closeApps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "closeApps");
			Phone.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "eventSystem");
			Phone.NativeFieldInfoPtr_flashlightVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "flashlightVisibility");
			Phone.NativeFieldInfoPtr_rotationCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "rotationCoroutine");
			Phone.NativeFieldInfoPtr_lookOffsetCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "lookOffsetCoroutine");
			Phone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682064);
			Phone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682065);
			Phone.NativeMethodInfoPtr_get_isHorizontal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682066);
			Phone.NativeMethodInfoPtr_set_isHorizontal_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682067);
			Phone.NativeMethodInfoPtr_get_isOpenable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682068);
			Phone.NativeMethodInfoPtr_set_isOpenable_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682069);
			Phone.NativeMethodInfoPtr_get_FlashlightOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682070);
			Phone.NativeMethodInfoPtr_set_FlashlightOn_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682071);
			Phone.NativeMethodInfoPtr_get_ScaledLookOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682072);
			Phone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682073);
			Phone.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682074);
			Phone.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682075);
			Phone.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682076);
			Phone.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682077);
			Phone.NativeMethodInfoPtr_ToggleFlashlight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682078);
			Phone.NativeMethodInfoPtr_SetOpenable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682079);
			Phone.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682080);
			Phone.NativeMethodInfoPtr_SetIsHorizontal_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682081);
			Phone.NativeMethodInfoPtr_SetIsHorizontal_Process_Protected_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682082);
			Phone.NativeMethodInfoPtr_SetLookOffsetMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682083);
			Phone.NativeMethodInfoPtr_RequestCloseApp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682084);
			Phone.NativeMethodInfoPtr_SetLookOffset_Process_Protected_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682085);
			Phone.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_byref_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682086);
			Phone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682087);
		}

		// Token: 0x17002EBD RID: 11965
		// (get) Token: 0x06009809 RID: 38921 RVA: 0x0026D904 File Offset: 0x0026BB04
		// (set) Token: 0x0600980A RID: 38922 RVA: 0x0026D940 File Offset: 0x0026BB40
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002EBE RID: 11966
		// (get) Token: 0x0600980B RID: 38923 RVA: 0x0026D980 File Offset: 0x0026BB80
		// (set) Token: 0x0600980C RID: 38924 RVA: 0x0026D9BC File Offset: 0x0026BBBC
		public unsafe bool isHorizontal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_isHorizontal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_isHorizontal_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002EBF RID: 11967
		// (get) Token: 0x0600980D RID: 38925 RVA: 0x0026D9FC File Offset: 0x0026BBFC
		// (set) Token: 0x0600980E RID: 38926 RVA: 0x0026DA38 File Offset: 0x0026BC38
		public unsafe bool isOpenable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_isOpenable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_isOpenable_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002EC0 RID: 11968
		// (get) Token: 0x0600980F RID: 38927 RVA: 0x0026DA78 File Offset: 0x0026BC78
		// (set) Token: 0x06009810 RID: 38928 RVA: 0x0026DAB4 File Offset: 0x0026BCB4
		public unsafe bool FlashlightOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_FlashlightOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_FlashlightOn_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002EC1 RID: 11969
		// (get) Token: 0x06009811 RID: 38929 RVA: 0x0026DAF4 File Offset: 0x0026BCF4
		public unsafe float ScaledLookOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272070, XrefRangeEnd = 272075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_ScaledLookOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06009812 RID: 38930 RVA: 0x0026DB30 File Offset: 0x0026BD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272075, XrefRangeEnd = 272083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009813 RID: 38931 RVA: 0x0026DB6C File Offset: 0x0026BD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272083, XrefRangeEnd = 272091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009814 RID: 38932 RVA: 0x0026DBB8 File Offset: 0x0026BDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272091, XrefRangeEnd = 272104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009815 RID: 38933 RVA: 0x0026DBF4 File Offset: 0x0026BDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272104, XrefRangeEnd = 272133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009816 RID: 38934 RVA: 0x0026DC30 File Offset: 0x0026BE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272133, XrefRangeEnd = 272140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009817 RID: 38935 RVA: 0x0026DC6C File Offset: 0x0026BE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272140, XrefRangeEnd = 272149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleFlashlight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_ToggleFlashlight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009818 RID: 38936 RVA: 0x0026DCA0 File Offset: 0x0026BEA0
		[CallerCount(0)]
		public unsafe void SetOpenable(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetOpenable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009819 RID: 38937 RVA: 0x0026DCE0 File Offset: 0x0026BEE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 272168, RefRangeEnd = 272171, XrefRangeStart = 272149, XrefRangeEnd = 272168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600981A RID: 38938 RVA: 0x0026DD20 File Offset: 0x0026BF20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 272179, RefRangeEnd = 272181, XrefRangeStart = 272171, XrefRangeEnd = 272179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsHorizontal(bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetIsHorizontal_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600981B RID: 38939 RVA: 0x0026DD60 File Offset: 0x0026BF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272181, XrefRangeEnd = 272186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetIsHorizontal_Process(bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetIsHorizontal_Process_Protected_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600981C RID: 38940 RVA: 0x0026DDAC File Offset: 0x0026BFAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 272199, RefRangeEnd = 272202, XrefRangeStart = 272186, XrefRangeEnd = 272199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLookOffsetMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetLookOffsetMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600981D RID: 38941 RVA: 0x0026DDEC File Offset: 0x0026BFEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272208, RefRangeEnd = 272209, XrefRangeStart = 272202, XrefRangeEnd = 272208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestCloseApp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_RequestCloseApp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600981E RID: 38942 RVA: 0x0026DE20 File Offset: 0x0026C020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272209, XrefRangeEnd = 272214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetLookOffset_Process(float lookOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lookOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetLookOffset_Process_Protected_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600981F RID: 38943 RVA: 0x0026DE6C File Offset: 0x0026C06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272214, XrefRangeEnd = 272231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MouseRaycast(out RaycastResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_byref_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new RaycastResult(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009820 RID: 38944 RVA: 0x0026DECC File Offset: 0x0026C0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272231, XrefRangeEnd = 272234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Phone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Phone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009821 RID: 38945 RVA: 0x00049F62 File Offset: 0x00048162
		public Phone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x06009822 RID: 38946 RVA: 0x0026DF08 File Offset: 0x0026C108
		// (set) Token: 0x06009823 RID: 38947 RVA: 0x00049F6B File Offset: 0x0004816B
		public unsafe static GameObject ActiveApp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Phone.NativeFieldInfoPtr_ActiveApp, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Phone.NativeFieldInfoPtr_ActiveApp, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x06009824 RID: 38948 RVA: 0x0026DF30 File Offset: 0x0026C130
		// (set) Token: 0x06009825 RID: 38949 RVA: 0x00049F7D File Offset: 0x0004817D
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x06009826 RID: 38950 RVA: 0x0026DF58 File Offset: 0x0026C158
		// (set) Token: 0x06009827 RID: 38951 RVA: 0x00049F98 File Offset: 0x00048198
		public unsafe bool _isHorizontal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isHorizontal_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isHorizontal_k__BackingField)) = value;
			}
		}

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x06009828 RID: 38952 RVA: 0x0026DF80 File Offset: 0x0026C180
		// (set) Token: 0x06009829 RID: 38953 RVA: 0x00049FB3 File Offset: 0x000481B3
		public unsafe bool _isOpenable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isOpenable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isOpenable_k__BackingField)) = value;
			}
		}

		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x0600982A RID: 38954 RVA: 0x0026DFA8 File Offset: 0x0026C1A8
		// (set) Token: 0x0600982B RID: 38955 RVA: 0x00049FCE File Offset: 0x000481CE
		public unsafe bool _FlashlightOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__FlashlightOn_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__FlashlightOn_k__BackingField)) = value;
			}
		}

		// Token: 0x17002EAA RID: 11946
		// (get) Token: 0x0600982C RID: 38956 RVA: 0x0026DFD0 File Offset: 0x0026C1D0
		// (set) Token: 0x0600982D RID: 38957 RVA: 0x00049FE9 File Offset: 0x000481E9
		public unsafe PhoneCallData testData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_testData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_testData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EAB RID: 11947
		// (get) Token: 0x0600982E RID: 38958 RVA: 0x0026E000 File Offset: 0x0026C200
		// (set) Token: 0x0600982F RID: 38959 RVA: 0x0004A008 File Offset: 0x00048208
		public unsafe CallerID testCalller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_testCalller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_testCalller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EAC RID: 11948
		// (get) Token: 0x06009830 RID: 38960 RVA: 0x0026E030 File Offset: 0x0026C230
		// (set) Token: 0x06009831 RID: 38961 RVA: 0x0004A027 File Offset: 0x00048227
		public unsafe GameObject phoneModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_phoneModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_phoneModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x06009832 RID: 38962 RVA: 0x0026E060 File Offset: 0x0026C260
		// (set) Token: 0x06009833 RID: 38963 RVA: 0x0004A046 File Offset: 0x00048246
		public unsafe Transform orientation_Vertical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Vertical);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Vertical), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EAE RID: 11950
		// (get) Token: 0x06009834 RID: 38964 RVA: 0x0026E090 File Offset: 0x0026C290
		// (set) Token: 0x06009835 RID: 38965 RVA: 0x0004A065 File Offset: 0x00048265
		public unsafe Transform orientation_Horizontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Horizontal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Horizontal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EAF RID: 11951
		// (get) Token: 0x06009836 RID: 38966 RVA: 0x0026E0C0 File Offset: 0x0026C2C0
		// (set) Token: 0x06009837 RID: 38967 RVA: 0x0004A084 File Offset: 0x00048284
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_raycaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB0 RID: 11952
		// (get) Token: 0x06009838 RID: 38968 RVA: 0x0026E0F0 File Offset: 0x0026C2F0
		// (set) Token: 0x06009839 RID: 38969 RVA: 0x0004A0A3 File Offset: 0x000482A3
		public unsafe GameObject PhoneFlashlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_PhoneFlashlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_PhoneFlashlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB1 RID: 11953
		// (get) Token: 0x0600983A RID: 38970 RVA: 0x0026E120 File Offset: 0x0026C320
		// (set) Token: 0x0600983B RID: 38971 RVA: 0x0004A0C2 File Offset: 0x000482C2
		public unsafe AudioSourceController FlashlightToggleSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_FlashlightToggleSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_FlashlightToggleSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB2 RID: 11954
		// (get) Token: 0x0600983C RID: 38972 RVA: 0x0026E150 File Offset: 0x0026C350
		// (set) Token: 0x0600983D RID: 38973 RVA: 0x0004A0E1 File Offset: 0x000482E1
		public unsafe float rotationTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_rotationTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_rotationTime)) = value;
			}
		}

		// Token: 0x17002EB3 RID: 11955
		// (get) Token: 0x0600983E RID: 38974 RVA: 0x0026E178 File Offset: 0x0026C378
		// (set) Token: 0x0600983F RID: 38975 RVA: 0x0004A0FC File Offset: 0x000482FC
		public unsafe float LookOffsetMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_LookOffsetMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_LookOffsetMax)) = value;
			}
		}

		// Token: 0x17002EB4 RID: 11956
		// (get) Token: 0x06009840 RID: 38976 RVA: 0x0026E1A0 File Offset: 0x0026C3A0
		// (set) Token: 0x06009841 RID: 38977 RVA: 0x0004A117 File Offset: 0x00048317
		public unsafe float LookOffsetMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_LookOffsetMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_LookOffsetMin)) = value;
			}
		}

		// Token: 0x17002EB5 RID: 11957
		// (get) Token: 0x06009842 RID: 38978 RVA: 0x0026E1C8 File Offset: 0x0026C3C8
		// (set) Token: 0x06009843 RID: 38979 RVA: 0x0004A132 File Offset: 0x00048332
		public unsafe float OpenVerticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_OpenVerticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_OpenVerticalOffset)) = value;
			}
		}

		// Token: 0x17002EB6 RID: 11958
		// (get) Token: 0x06009844 RID: 38980 RVA: 0x0026E1F0 File Offset: 0x0026C3F0
		// (set) Token: 0x06009845 RID: 38981 RVA: 0x0004A14D File Offset: 0x0004834D
		public unsafe Action onPhoneOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB7 RID: 11959
		// (get) Token: 0x06009846 RID: 38982 RVA: 0x0026E220 File Offset: 0x0026C420
		// (set) Token: 0x06009847 RID: 38983 RVA: 0x0004A16C File Offset: 0x0004836C
		public unsafe Action onPhoneClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB8 RID: 11960
		// (get) Token: 0x06009848 RID: 38984 RVA: 0x0026E250 File Offset: 0x0026C450
		// (set) Token: 0x06009849 RID: 38985 RVA: 0x0004A18B File Offset: 0x0004838B
		public unsafe Action closeApps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_closeApps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_closeApps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB9 RID: 11961
		// (get) Token: 0x0600984A RID: 38986 RVA: 0x0026E280 File Offset: 0x0026C480
		// (set) Token: 0x0600984B RID: 38987 RVA: 0x0004A1AA File Offset: 0x000483AA
		public unsafe EventSystem eventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_eventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EBA RID: 11962
		// (get) Token: 0x0600984C RID: 38988 RVA: 0x0026E2B0 File Offset: 0x0026C4B0
		// (set) Token: 0x0600984D RID: 38989 RVA: 0x0004A1C9 File Offset: 0x000483C9
		public unsafe VisibilityAttribute flashlightVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_flashlightVisibility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_flashlightVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EBB RID: 11963
		// (get) Token: 0x0600984E RID: 38990 RVA: 0x0026E2E0 File Offset: 0x0026C4E0
		// (set) Token: 0x0600984F RID: 38991 RVA: 0x0004A1E8 File Offset: 0x000483E8
		public unsafe Coroutine rotationCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_rotationCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_rotationCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EBC RID: 11964
		// (get) Token: 0x06009850 RID: 38992 RVA: 0x0026E310 File Offset: 0x0026C510
		// (set) Token: 0x06009851 RID: 38993 RVA: 0x0004A207 File Offset: 0x00048407
		public unsafe Coroutine lookOffsetCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_lookOffsetCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_lookOffsetCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400666B RID: 26219
		private static readonly IntPtr NativeFieldInfoPtr_ActiveApp;

		// Token: 0x0400666C RID: 26220
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400666D RID: 26221
		private static readonly IntPtr NativeFieldInfoPtr__isHorizontal_k__BackingField;

		// Token: 0x0400666E RID: 26222
		private static readonly IntPtr NativeFieldInfoPtr__isOpenable_k__BackingField;

		// Token: 0x0400666F RID: 26223
		private static readonly IntPtr NativeFieldInfoPtr__FlashlightOn_k__BackingField;

		// Token: 0x04006670 RID: 26224
		private static readonly IntPtr NativeFieldInfoPtr_testData;

		// Token: 0x04006671 RID: 26225
		private static readonly IntPtr NativeFieldInfoPtr_testCalller;

		// Token: 0x04006672 RID: 26226
		private static readonly IntPtr NativeFieldInfoPtr_phoneModel;

		// Token: 0x04006673 RID: 26227
		private static readonly IntPtr NativeFieldInfoPtr_orientation_Vertical;

		// Token: 0x04006674 RID: 26228
		private static readonly IntPtr NativeFieldInfoPtr_orientation_Horizontal;

		// Token: 0x04006675 RID: 26229
		private static readonly IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x04006676 RID: 26230
		private static readonly IntPtr NativeFieldInfoPtr_PhoneFlashlight;

		// Token: 0x04006677 RID: 26231
		private static readonly IntPtr NativeFieldInfoPtr_FlashlightToggleSound;

		// Token: 0x04006678 RID: 26232
		private static readonly IntPtr NativeFieldInfoPtr_rotationTime;

		// Token: 0x04006679 RID: 26233
		private static readonly IntPtr NativeFieldInfoPtr_LookOffsetMax;

		// Token: 0x0400667A RID: 26234
		private static readonly IntPtr NativeFieldInfoPtr_LookOffsetMin;

		// Token: 0x0400667B RID: 26235
		private static readonly IntPtr NativeFieldInfoPtr_OpenVerticalOffset;

		// Token: 0x0400667C RID: 26236
		private static readonly IntPtr NativeFieldInfoPtr_onPhoneOpened;

		// Token: 0x0400667D RID: 26237
		private static readonly IntPtr NativeFieldInfoPtr_onPhoneClosed;

		// Token: 0x0400667E RID: 26238
		private static readonly IntPtr NativeFieldInfoPtr_closeApps;

		// Token: 0x0400667F RID: 26239
		private static readonly IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x04006680 RID: 26240
		private static readonly IntPtr NativeFieldInfoPtr_flashlightVisibility;

		// Token: 0x04006681 RID: 26241
		private static readonly IntPtr NativeFieldInfoPtr_rotationCoroutine;

		// Token: 0x04006682 RID: 26242
		private static readonly IntPtr NativeFieldInfoPtr_lookOffsetCoroutine;

		// Token: 0x04006683 RID: 26243
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006684 RID: 26244
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006685 RID: 26245
		private static readonly IntPtr NativeMethodInfoPtr_get_isHorizontal_Public_get_Boolean_0;

		// Token: 0x04006686 RID: 26246
		private static readonly IntPtr NativeMethodInfoPtr_set_isHorizontal_Protected_set_Void_Boolean_0;

		// Token: 0x04006687 RID: 26247
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpenable_Public_get_Boolean_0;

		// Token: 0x04006688 RID: 26248
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpenable_Protected_set_Void_Boolean_0;

		// Token: 0x04006689 RID: 26249
		private static readonly IntPtr NativeMethodInfoPtr_get_FlashlightOn_Public_get_Boolean_0;

		// Token: 0x0400668A RID: 26250
		private static readonly IntPtr NativeMethodInfoPtr_set_FlashlightOn_Protected_set_Void_Boolean_0;

		// Token: 0x0400668B RID: 26251
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaledLookOffset_Public_get_Single_0;

		// Token: 0x0400668C RID: 26252
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400668D RID: 26253
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400668E RID: 26254
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400668F RID: 26255
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006690 RID: 26256
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006691 RID: 26257
		private static readonly IntPtr NativeMethodInfoPtr_ToggleFlashlight_Private_Void_0;

		// Token: 0x04006692 RID: 26258
		private static readonly IntPtr NativeMethodInfoPtr_SetOpenable_Public_Void_Boolean_0;

		// Token: 0x04006693 RID: 26259
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04006694 RID: 26260
		private static readonly IntPtr NativeMethodInfoPtr_SetIsHorizontal_Public_Void_Boolean_0;

		// Token: 0x04006695 RID: 26261
		private static readonly IntPtr NativeMethodInfoPtr_SetIsHorizontal_Process_Protected_IEnumerator_Boolean_0;

		// Token: 0x04006696 RID: 26262
		private static readonly IntPtr NativeMethodInfoPtr_SetLookOffsetMultiplier_Public_Void_Single_0;

		// Token: 0x04006697 RID: 26263
		private static readonly IntPtr NativeMethodInfoPtr_RequestCloseApp_Public_Void_0;

		// Token: 0x04006698 RID: 26264
		private static readonly IntPtr NativeMethodInfoPtr_SetLookOffset_Process_Protected_IEnumerator_Single_0;

		// Token: 0x04006699 RID: 26265
		private static readonly IntPtr NativeMethodInfoPtr_MouseRaycast_Public_Boolean_byref_RaycastResult_0;

		// Token: 0x0400669A RID: 26266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B6C RID: 2924
		[ObfuscatedName("ScheduleOne.UI.Phone.Phone+<SetIsHorizontal_Process>d__46")]
		public sealed class _SetIsHorizontal_Process_d__46 : Il2CppSystem.Object
		{
			// Token: 0x0600DACA RID: 56010 RVA: 0x0033D71C File Offset: 0x0033B91C
			// Note: this type is marked as 'beforefieldinit'.
			static _SetIsHorizontal_Process_d__46()
			{
				Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<SetIsHorizontal_Process>d__46");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr);
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<>1__state");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<>2__current");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<>4__this");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "h");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__adjustedRotationTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<adjustedRotationTime>5__2");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__startRotation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<startRotation>5__3");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__endRotation_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<endRotation>5__4");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<i>5__5");
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682088);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682089);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682090);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682091);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682092);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682093);
			}

			// Token: 0x0600DACB RID: 56011 RVA: 0x0033D860 File Offset: 0x0033BA60
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetIsHorizontal_Process_d__46(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DACC RID: 56012 RVA: 0x0033D8A8 File Offset: 0x0033BAA8
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DACD RID: 56013 RVA: 0x0033D8DC File Offset: 0x0033BADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272007, XrefRangeEnd = 272036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043E5 RID: 17381
			// (get) Token: 0x0600DACE RID: 56014 RVA: 0x0033D918 File Offset: 0x0033BB18
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DACF RID: 56015 RVA: 0x0033D958 File Offset: 0x0033BB58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272036, XrefRangeEnd = 272041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043E6 RID: 17382
			// (get) Token: 0x0600DAD0 RID: 56016 RVA: 0x0033D98C File Offset: 0x0033BB8C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAD1 RID: 56017 RVA: 0x0006A8CA File Offset: 0x00068ACA
			public _SetIsHorizontal_Process_d__46(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043DD RID: 17373
			// (get) Token: 0x0600DAD2 RID: 56018 RVA: 0x0033D9CC File Offset: 0x0033BBCC
			// (set) Token: 0x0600DAD3 RID: 56019 RVA: 0x0006A8D3 File Offset: 0x00068AD3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043DE RID: 17374
			// (get) Token: 0x0600DAD4 RID: 56020 RVA: 0x0033D9F4 File Offset: 0x0033BBF4
			// (set) Token: 0x0600DAD5 RID: 56021 RVA: 0x0006A8EE File Offset: 0x00068AEE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043DF RID: 17375
			// (get) Token: 0x0600DAD6 RID: 56022 RVA: 0x0033DA24 File Offset: 0x0033BC24
			// (set) Token: 0x0600DAD7 RID: 56023 RVA: 0x0006A90D File Offset: 0x00068B0D
			public unsafe Phone __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Phone>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043E0 RID: 17376
			// (get) Token: 0x0600DAD8 RID: 56024 RVA: 0x0033DA54 File Offset: 0x0033BC54
			// (set) Token: 0x0600DAD9 RID: 56025 RVA: 0x0006A92C File Offset: 0x00068B2C
			public unsafe bool h
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr_h);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr_h)) = value;
				}
			}

			// Token: 0x170043E1 RID: 17377
			// (get) Token: 0x0600DADA RID: 56026 RVA: 0x0033DA7C File Offset: 0x0033BC7C
			// (set) Token: 0x0600DADB RID: 56027 RVA: 0x0006A947 File Offset: 0x00068B47
			public unsafe float _adjustedRotationTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__adjustedRotationTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__adjustedRotationTime_5__2)) = value;
				}
			}

			// Token: 0x170043E2 RID: 17378
			// (get) Token: 0x0600DADC RID: 56028 RVA: 0x0033DAA4 File Offset: 0x0033BCA4
			// (set) Token: 0x0600DADD RID: 56029 RVA: 0x0006A962 File Offset: 0x00068B62
			public unsafe Quaternion _startRotation_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__startRotation_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__startRotation_5__3)) = value;
				}
			}

			// Token: 0x170043E3 RID: 17379
			// (get) Token: 0x0600DADE RID: 56030 RVA: 0x0033DACC File Offset: 0x0033BCCC
			// (set) Token: 0x0600DADF RID: 56031 RVA: 0x0006A97D File Offset: 0x00068B7D
			public unsafe Quaternion _endRotation_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__endRotation_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__endRotation_5__4)) = value;
				}
			}

			// Token: 0x170043E4 RID: 17380
			// (get) Token: 0x0600DAE0 RID: 56032 RVA: 0x0033DAF4 File Offset: 0x0033BCF4
			// (set) Token: 0x0600DAE1 RID: 56033 RVA: 0x0006A998 File Offset: 0x00068B98
			public unsafe float _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x040092D4 RID: 37588
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092D5 RID: 37589
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092D6 RID: 37590
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092D7 RID: 37591
			private static readonly IntPtr NativeFieldInfoPtr_h;

			// Token: 0x040092D8 RID: 37592
			private static readonly IntPtr NativeFieldInfoPtr__adjustedRotationTime_5__2;

			// Token: 0x040092D9 RID: 37593
			private static readonly IntPtr NativeFieldInfoPtr__startRotation_5__3;

			// Token: 0x040092DA RID: 37594
			private static readonly IntPtr NativeFieldInfoPtr__endRotation_5__4;

			// Token: 0x040092DB RID: 37595
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x040092DC RID: 37596
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092DD RID: 37597
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092DE RID: 37598
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092DF RID: 37599
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092E0 RID: 37600
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092E1 RID: 37601
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B6D RID: 2925
		[ObfuscatedName("ScheduleOne.UI.Phone.Phone+<SetLookOffset_Process>d__50")]
		public sealed class _SetLookOffset_Process_d__50 : Il2CppSystem.Object
		{
			// Token: 0x0600DAE2 RID: 56034 RVA: 0x0033DB1C File Offset: 0x0033BD1C
			// Note: this type is marked as 'beforefieldinit'.
			static _SetLookOffset_Process_d__50()
			{
				Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<SetLookOffset_Process>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr);
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<>1__state");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<>2__current");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<>4__this");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr_lookOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "lookOffset");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__startOffset_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<startOffset>5__2");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__endOffset_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<endOffset>5__3");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__moveTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<moveTime>5__4");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<i>5__5");
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682094);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682095);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682096);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682097);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682098);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682099);
			}

			// Token: 0x0600DAE3 RID: 56035 RVA: 0x0033DC60 File Offset: 0x0033BE60
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetLookOffset_Process_d__50(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAE4 RID: 56036 RVA: 0x0033DCA8 File Offset: 0x0033BEA8
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAE5 RID: 56037 RVA: 0x0033DCDC File Offset: 0x0033BEDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272041, XrefRangeEnd = 272065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043EF RID: 17391
			// (get) Token: 0x0600DAE6 RID: 56038 RVA: 0x0033DD18 File Offset: 0x0033BF18
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAE7 RID: 56039 RVA: 0x0033DD58 File Offset: 0x0033BF58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272065, XrefRangeEnd = 272070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043F0 RID: 17392
			// (get) Token: 0x0600DAE8 RID: 56040 RVA: 0x0033DD8C File Offset: 0x0033BF8C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAE9 RID: 56041 RVA: 0x0006A9B3 File Offset: 0x00068BB3
			public _SetLookOffset_Process_d__50(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043E7 RID: 17383
			// (get) Token: 0x0600DAEA RID: 56042 RVA: 0x0033DDCC File Offset: 0x0033BFCC
			// (set) Token: 0x0600DAEB RID: 56043 RVA: 0x0006A9BC File Offset: 0x00068BBC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043E8 RID: 17384
			// (get) Token: 0x0600DAEC RID: 56044 RVA: 0x0033DDF4 File Offset: 0x0033BFF4
			// (set) Token: 0x0600DAED RID: 56045 RVA: 0x0006A9D7 File Offset: 0x00068BD7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043E9 RID: 17385
			// (get) Token: 0x0600DAEE RID: 56046 RVA: 0x0033DE24 File Offset: 0x0033C024
			// (set) Token: 0x0600DAEF RID: 56047 RVA: 0x0006A9F6 File Offset: 0x00068BF6
			public unsafe Phone __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Phone>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043EA RID: 17386
			// (get) Token: 0x0600DAF0 RID: 56048 RVA: 0x0033DE54 File Offset: 0x0033C054
			// (set) Token: 0x0600DAF1 RID: 56049 RVA: 0x0006AA15 File Offset: 0x00068C15
			public unsafe float lookOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr_lookOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr_lookOffset)) = value;
				}
			}

			// Token: 0x170043EB RID: 17387
			// (get) Token: 0x0600DAF2 RID: 56050 RVA: 0x0033DE7C File Offset: 0x0033C07C
			// (set) Token: 0x0600DAF3 RID: 56051 RVA: 0x0006AA30 File Offset: 0x00068C30
			public unsafe float _startOffset_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__startOffset_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__startOffset_5__2)) = value;
				}
			}

			// Token: 0x170043EC RID: 17388
			// (get) Token: 0x0600DAF4 RID: 56052 RVA: 0x0033DEA4 File Offset: 0x0033C0A4
			// (set) Token: 0x0600DAF5 RID: 56053 RVA: 0x0006AA4B File Offset: 0x00068C4B
			public unsafe float _endOffset_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__endOffset_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__endOffset_5__3)) = value;
				}
			}

			// Token: 0x170043ED RID: 17389
			// (get) Token: 0x0600DAF6 RID: 56054 RVA: 0x0033DECC File Offset: 0x0033C0CC
			// (set) Token: 0x0600DAF7 RID: 56055 RVA: 0x0006AA66 File Offset: 0x00068C66
			public unsafe float _moveTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__moveTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__moveTime_5__4)) = value;
				}
			}

			// Token: 0x170043EE RID: 17390
			// (get) Token: 0x0600DAF8 RID: 56056 RVA: 0x0033DEF4 File Offset: 0x0033C0F4
			// (set) Token: 0x0600DAF9 RID: 56057 RVA: 0x0006AA81 File Offset: 0x00068C81
			public unsafe float _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x040092E2 RID: 37602
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092E3 RID: 37603
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092E4 RID: 37604
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092E5 RID: 37605
			private static readonly IntPtr NativeFieldInfoPtr_lookOffset;

			// Token: 0x040092E6 RID: 37606
			private static readonly IntPtr NativeFieldInfoPtr__startOffset_5__2;

			// Token: 0x040092E7 RID: 37607
			private static readonly IntPtr NativeFieldInfoPtr__endOffset_5__3;

			// Token: 0x040092E8 RID: 37608
			private static readonly IntPtr NativeFieldInfoPtr__moveTime_5__4;

			// Token: 0x040092E9 RID: 37609
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x040092EA RID: 37610
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092EB RID: 37611
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092EC RID: 37612
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092ED RID: 37613
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092EE RID: 37614
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092EF RID: 37615
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
