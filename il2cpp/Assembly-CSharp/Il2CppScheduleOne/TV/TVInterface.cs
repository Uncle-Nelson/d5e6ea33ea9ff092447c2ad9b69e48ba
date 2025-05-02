using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x0200018F RID: 399
	public class TVInterface : MonoBehaviour
	{
		// Token: 0x06002084 RID: 8324 RVA: 0x000D59F8 File Offset: 0x000D3BF8
		// Note: this type is marked as 'beforefieldinit'.
		static TVInterface()
		{
			Il2CppClassPointerStore<TVInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "TVInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVInterface>.NativeClassPtr);
			TVInterface.NativeFieldInfoPtr_OPEN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "OPEN_TIME");
			TVInterface.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "FOV");
			TVInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			TVInterface.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "Players");
			TVInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "Canvas");
			TVInterface.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "CameraPosition");
			TVInterface.NativeFieldInfoPtr_HomeScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "HomeScreen");
			TVInterface.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "TimeLabel");
			TVInterface.NativeFieldInfoPtr_Daylabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "Daylabel");
			TVInterface.NativeFieldInfoPtr_onPlayerAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "onPlayerAdded");
			TVInterface.NativeFieldInfoPtr_onPlayerRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "onPlayerRemoved");
			TVInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666926);
			TVInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666927);
			TVInterface.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666928);
			TVInterface.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666929);
			TVInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666930);
			TVInterface.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666931);
			TVInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666932);
			TVInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666933);
			TVInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666934);
			TVInterface.NativeMethodInfoPtr_CanOpen_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666935);
			TVInterface.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666936);
			TVInterface.NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666937);
			TVInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666938);
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x000D5C08 File Offset: 0x000D3E08
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x000D5C44 File Offset: 0x000D3E44
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x000D5C84 File Offset: 0x000D3E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108965, XrefRangeEnd = 108984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x000D5CB8 File Offset: 0x000D3EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108984, XrefRangeEnd = 108995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x000D5CEC File Offset: 0x000D3EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108995, XrefRangeEnd = 109013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x000D5D20 File Offset: 0x000D3F20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109024, RefRangeEnd = 109025, XrefRangeStart = 109013, XrefRangeEnd = 109024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x000D5D54 File Offset: 0x000D3F54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109086, RefRangeEnd = 109087, XrefRangeStart = 109025, XrefRangeEnd = 109086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x000D5D88 File Offset: 0x000D3F88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109140, RefRangeEnd = 109142, XrefRangeStart = 109087, XrefRangeEnd = 109140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x000D5DBC File Offset: 0x000D3FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109142, XrefRangeEnd = 109144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x000D5E00 File Offset: 0x000D4000
		[CallerCount(0)]
		public unsafe bool CanOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_CanOpen_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x000D5E3C File Offset: 0x000D403C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109144, XrefRangeEnd = 109155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x000D5E80 File Offset: 0x000D4080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109155, XrefRangeEnd = 109164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x000D5EC4 File Offset: 0x000D40C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109164, XrefRangeEnd = 109184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TVInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x0001252C File Offset: 0x0001072C
		public TVInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x000D5F00 File Offset: 0x000D4100
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x00012535 File Offset: 0x00010735
		public unsafe static float OPEN_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TVInterface.NativeFieldInfoPtr_OPEN_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TVInterface.NativeFieldInfoPtr_OPEN_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x000D5F1C File Offset: 0x000D411C
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x00012543 File Offset: 0x00010743
		public unsafe static float FOV
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TVInterface.NativeFieldInfoPtr_FOV, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TVInterface.NativeFieldInfoPtr_FOV, (void*)(&value));
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x000D5F38 File Offset: 0x000D4138
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x00012551 File Offset: 0x00010751
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x000D5F60 File Offset: 0x000D4160
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x0001256C File Offset: 0x0001076C
		public unsafe List<Player> Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x000D5F90 File Offset: 0x000D4190
		// (set) Token: 0x0600209C RID: 8348 RVA: 0x0001258B File Offset: 0x0001078B
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x000D5FC0 File Offset: 0x000D41C0
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x000125AA File Offset: 0x000107AA
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x000D5FF0 File Offset: 0x000D41F0
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x000125C9 File Offset: 0x000107C9
		public unsafe TVHomeScreen HomeScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_HomeScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVHomeScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_HomeScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x000D6020 File Offset: 0x000D4220
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x000125E8 File Offset: 0x000107E8
		public unsafe TextMeshPro TimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_TimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x000D6050 File Offset: 0x000D4250
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x00012607 File Offset: 0x00010807
		public unsafe TextMeshPro Daylabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Daylabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Daylabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x000D6080 File Offset: 0x000D4280
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x00012626 File Offset: 0x00010826
		public unsafe UnityEvent<Player> onPlayerAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_onPlayerAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_onPlayerAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x000D60B0 File Offset: 0x000D42B0
		// (set) Token: 0x060020A8 RID: 8360 RVA: 0x00012645 File Offset: 0x00010845
		public unsafe UnityEvent<Player> onPlayerRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_onPlayerRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_onPlayerRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeFieldInfoPtr_OPEN_TIME;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeFieldInfoPtr_HomeScreen;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeFieldInfoPtr_Daylabel;

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerAdded;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerRemoved;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeMethodInfoPtr_CanOpen_Public_Boolean_0;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
