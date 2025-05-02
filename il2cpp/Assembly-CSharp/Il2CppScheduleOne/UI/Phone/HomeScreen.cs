using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006A4 RID: 1700
	public class HomeScreen : PlayerSingleton<HomeScreen>
	{
		// Token: 0x060097EA RID: 38890 RVA: 0x0026CE70 File Offset: 0x0026B070
		// Note: this type is marked as 'beforefieldinit'.
		static HomeScreen()
		{
			Il2CppClassPointerStore<HomeScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "HomeScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr);
			HomeScreen.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "<isOpen>k__BackingField");
			HomeScreen.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "canvas");
			HomeScreen.NativeFieldInfoPtr_timeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "timeText");
			HomeScreen.NativeFieldInfoPtr_appIconContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "appIconContainer");
			HomeScreen.NativeFieldInfoPtr_appIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "appIconPrefab");
			HomeScreen.NativeFieldInfoPtr_appIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "appIcons");
			HomeScreen.NativeFieldInfoPtr_delayedSetOpenRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "delayedSetOpenRoutine");
			HomeScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682044);
			HomeScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682045);
			HomeScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682046);
			HomeScreen.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682047);
			HomeScreen.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682048);
			HomeScreen.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682049);
			HomeScreen.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682050);
			HomeScreen.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682051);
			HomeScreen.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682052);
			HomeScreen.NativeMethodInfoPtr_SetCanvasActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682053);
			HomeScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682054);
			HomeScreen.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682055);
			HomeScreen.NativeMethodInfoPtr_GenerateAppIcon_Public_Button_App_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682056);
			HomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682057);
		}

		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x060097EB RID: 38891 RVA: 0x0026D044 File Offset: 0x0026B244
		// (set) Token: 0x060097EC RID: 38892 RVA: 0x0026D080 File Offset: 0x0026B280
		public unsafe bool isOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060097ED RID: 38893 RVA: 0x0026D0C0 File Offset: 0x0026B2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271803, XrefRangeEnd = 271809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097EE RID: 38894 RVA: 0x0026D0FC File Offset: 0x0026B2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271809, XrefRangeEnd = 271852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097EF RID: 38895 RVA: 0x0026D148 File Offset: 0x0026B348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271852, XrefRangeEnd = 271871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097F0 RID: 38896 RVA: 0x0026D184 File Offset: 0x0026B384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271871, XrefRangeEnd = 271873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097F1 RID: 38897 RVA: 0x0026D1B8 File Offset: 0x0026B3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271873, XrefRangeEnd = 271880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097F2 RID: 38898 RVA: 0x0026D1EC File Offset: 0x0026B3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271880, XrefRangeEnd = 271885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060097F3 RID: 38899 RVA: 0x0026D248 File Offset: 0x0026B448
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271888, RefRangeEnd = 271889, XrefRangeStart = 271885, XrefRangeEnd = 271888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097F4 RID: 38900 RVA: 0x0026D288 File Offset: 0x0026B488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271889, XrefRangeEnd = 271892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanvasActive(bool a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_SetCanvasActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097F5 RID: 38901 RVA: 0x0026D2C8 File Offset: 0x0026B4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271892, XrefRangeEnd = 271918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097F6 RID: 38902 RVA: 0x0026D304 File Offset: 0x0026B504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271918, XrefRangeEnd = 271959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097F7 RID: 38903 RVA: 0x0026D340 File Offset: 0x0026B540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271996, RefRangeEnd = 271997, XrefRangeStart = 271959, XrefRangeEnd = 271996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Button GenerateAppIcon<T>(App<T> prog) where T : PlayerSingleton<T>
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prog);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.MethodInfoStoreGeneric_GenerateAppIcon_Public_Button_App_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Button>(intPtr3) : null;
		}

		// Token: 0x060097F8 RID: 38904 RVA: 0x0026D390 File Offset: 0x0026B590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271997, XrefRangeEnd = 272007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HomeScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097F9 RID: 38905 RVA: 0x00049E84 File Offset: 0x00048084
		public HomeScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E9D RID: 11933
		// (get) Token: 0x060097FA RID: 38906 RVA: 0x0026D3CC File Offset: 0x0026B5CC
		// (set) Token: 0x060097FB RID: 38907 RVA: 0x00049E8D File Offset: 0x0004808D
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E9E RID: 11934
		// (get) Token: 0x060097FC RID: 38908 RVA: 0x0026D3F4 File Offset: 0x0026B5F4
		// (set) Token: 0x060097FD RID: 38909 RVA: 0x00049EA8 File Offset: 0x000480A8
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E9F RID: 11935
		// (get) Token: 0x060097FE RID: 38910 RVA: 0x0026D424 File Offset: 0x0026B624
		// (set) Token: 0x060097FF RID: 38911 RVA: 0x00049EC7 File Offset: 0x000480C7
		public unsafe Text timeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_timeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_timeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x06009800 RID: 38912 RVA: 0x0026D454 File Offset: 0x0026B654
		// (set) Token: 0x06009801 RID: 38913 RVA: 0x00049EE6 File Offset: 0x000480E6
		public unsafe RectTransform appIconContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x06009802 RID: 38914 RVA: 0x0026D484 File Offset: 0x0026B684
		// (set) Token: 0x06009803 RID: 38915 RVA: 0x00049F05 File Offset: 0x00048105
		public unsafe GameObject appIconPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x06009804 RID: 38916 RVA: 0x0026D4B4 File Offset: 0x0026B6B4
		// (set) Token: 0x06009805 RID: 38917 RVA: 0x00049F24 File Offset: 0x00048124
		public unsafe List<Button> appIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x06009806 RID: 38918 RVA: 0x0026D4E4 File Offset: 0x0026B6E4
		// (set) Token: 0x06009807 RID: 38919 RVA: 0x00049F43 File Offset: 0x00048143
		public unsafe Coroutine delayedSetOpenRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_delayedSetOpenRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_delayedSetOpenRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006656 RID: 26198
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006657 RID: 26199
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006658 RID: 26200
		private static readonly IntPtr NativeFieldInfoPtr_timeText;

		// Token: 0x04006659 RID: 26201
		private static readonly IntPtr NativeFieldInfoPtr_appIconContainer;

		// Token: 0x0400665A RID: 26202
		private static readonly IntPtr NativeFieldInfoPtr_appIconPrefab;

		// Token: 0x0400665B RID: 26203
		private static readonly IntPtr NativeFieldInfoPtr_appIcons;

		// Token: 0x0400665C RID: 26204
		private static readonly IntPtr NativeFieldInfoPtr_delayedSetOpenRoutine;

		// Token: 0x0400665D RID: 26205
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x0400665E RID: 26206
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400665F RID: 26207
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006660 RID: 26208
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006661 RID: 26209
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006662 RID: 26210
		private static readonly IntPtr NativeMethodInfoPtr_PhoneOpened_Protected_Void_0;

		// Token: 0x04006663 RID: 26211
		private static readonly IntPtr NativeMethodInfoPtr_PhoneClosed_Protected_Void_0;

		// Token: 0x04006664 RID: 26212
		private static readonly IntPtr NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0;

		// Token: 0x04006665 RID: 26213
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04006666 RID: 26214
		private static readonly IntPtr NativeMethodInfoPtr_SetCanvasActive_Public_Void_Boolean_0;

		// Token: 0x04006667 RID: 26215
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006668 RID: 26216
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04006669 RID: 26217
		private static readonly IntPtr NativeMethodInfoPtr_GenerateAppIcon_Public_Button_App_1_T_0;

		// Token: 0x0400666A RID: 26218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B6A RID: 2922
		[ObfuscatedName("ScheduleOne.UI.Phone.HomeScreen+<DelayedSetCanvasActive>d__15")]
		public sealed class _DelayedSetCanvasActive_d__15 : Il2CppSystem.Object
		{
			// Token: 0x0600DAB7 RID: 55991 RVA: 0x0033D37C File Offset: 0x0033B57C
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedSetCanvasActive_d__15()
			{
				Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "<DelayedSetCanvasActive>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "<>1__state");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "<>2__current");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "delay");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "<>4__this");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "active");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682058);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682059);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682060);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682061);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682062);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682063);
			}

			// Token: 0x0600DAB8 RID: 55992 RVA: 0x0033D484 File Offset: 0x0033B684
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedSetCanvasActive_d__15(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAB9 RID: 55993 RVA: 0x0033D4CC File Offset: 0x0033B6CC
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DABA RID: 55994 RVA: 0x0033D500 File Offset: 0x0033B700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271793, XrefRangeEnd = 271798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043DB RID: 17371
			// (get) Token: 0x0600DABB RID: 55995 RVA: 0x0033D53C File Offset: 0x0033B73C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DABC RID: 55996 RVA: 0x0033D57C File Offset: 0x0033B77C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271798, XrefRangeEnd = 271803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043DC RID: 17372
			// (get) Token: 0x0600DABD RID: 55997 RVA: 0x0033D5B0 File Offset: 0x0033B7B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DABE RID: 55998 RVA: 0x0006A832 File Offset: 0x00068A32
			public _DelayedSetCanvasActive_d__15(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D6 RID: 17366
			// (get) Token: 0x0600DABF RID: 55999 RVA: 0x0033D5F0 File Offset: 0x0033B7F0
			// (set) Token: 0x0600DAC0 RID: 56000 RVA: 0x0006A83B File Offset: 0x00068A3B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043D7 RID: 17367
			// (get) Token: 0x0600DAC1 RID: 56001 RVA: 0x0033D618 File Offset: 0x0033B818
			// (set) Token: 0x0600DAC2 RID: 56002 RVA: 0x0006A856 File Offset: 0x00068A56
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D8 RID: 17368
			// (get) Token: 0x0600DAC3 RID: 56003 RVA: 0x0033D648 File Offset: 0x0033B848
			// (set) Token: 0x0600DAC4 RID: 56004 RVA: 0x0006A875 File Offset: 0x00068A75
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x170043D9 RID: 17369
			// (get) Token: 0x0600DAC5 RID: 56005 RVA: 0x0033D670 File Offset: 0x0033B870
			// (set) Token: 0x0600DAC6 RID: 56006 RVA: 0x0006A890 File Offset: 0x00068A90
			public unsafe HomeScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HomeScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043DA RID: 17370
			// (get) Token: 0x0600DAC7 RID: 56007 RVA: 0x0033D6A0 File Offset: 0x0033B8A0
			// (set) Token: 0x0600DAC8 RID: 56008 RVA: 0x0006A8AF File Offset: 0x00068AAF
			public unsafe bool active
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x040092C8 RID: 37576
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092C9 RID: 37577
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092CA RID: 37578
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x040092CB RID: 37579
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092CC RID: 37580
			private static readonly IntPtr NativeFieldInfoPtr_active;

			// Token: 0x040092CD RID: 37581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092CE RID: 37582
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092CF RID: 37583
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092D0 RID: 37584
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092D1 RID: 37585
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092D2 RID: 37586
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B6B RID: 2923
		private sealed class MethodInfoStoreGeneric_GenerateAppIcon_Public_Button_App_1_T_0<T>
		{
			// Token: 0x040092D3 RID: 37587
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HomeScreen.NativeMethodInfoPtr_GenerateAppIcon_Public_Button_App_1_T_0, Il2CppClassPointerStore<HomeScreen>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
