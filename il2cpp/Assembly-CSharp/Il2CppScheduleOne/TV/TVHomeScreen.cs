using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x0200018D RID: 397
	public class TVHomeScreen : TVApp
	{
		// Token: 0x06002062 RID: 8290 RVA: 0x000D538C File Offset: 0x000D358C
		// Note: this type is marked as 'beforefieldinit'.
		static TVHomeScreen()
		{
			Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "TVHomeScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr);
			TVHomeScreen.NativeFieldInfoPtr_Interface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "Interface");
			TVHomeScreen.NativeFieldInfoPtr_Apps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "Apps");
			TVHomeScreen.NativeFieldInfoPtr_AppButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "AppButtonContainer");
			TVHomeScreen.NativeFieldInfoPtr_PlayerDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "PlayerDisplays");
			TVHomeScreen.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "TimeLabel");
			TVHomeScreen.NativeFieldInfoPtr_AppButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "AppButtonPrefab");
			TVHomeScreen.NativeFieldInfoPtr_skipExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "skipExit");
			TVHomeScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666912);
			TVHomeScreen.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666913);
			TVHomeScreen.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666914);
			TVHomeScreen.NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666915);
			TVHomeScreen.NativeMethodInfoPtr_UpdateTimeLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666916);
			TVHomeScreen.NativeMethodInfoPtr_AppSelected_Private_Void_TVApp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666917);
			TVHomeScreen.NativeMethodInfoPtr_PlayerChange_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666918);
			TVHomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666919);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000D54E8 File Offset: 0x000D36E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108861, XrefRangeEnd = 108919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x000D5524 File Offset: 0x000D3724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108919, XrefRangeEnd = 108921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000D5560 File Offset: 0x000D3760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108921, XrefRangeEnd = 108923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x000D559C File Offset: 0x000D379C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108923, XrefRangeEnd = 108924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000D55D8 File Offset: 0x000D37D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108930, RefRangeEnd = 108932, XrefRangeStart = 108924, XrefRangeEnd = 108930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr_UpdateTimeLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x000D560C File Offset: 0x000D380C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108932, XrefRangeEnd = 108933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppSelected(TVApp app)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(app);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr_AppSelected_Private_Void_TVApp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x000D5650 File Offset: 0x000D3850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108933, XrefRangeEnd = 108949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerChange(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr_PlayerChange_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x000D5694 File Offset: 0x000D3894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TVHomeScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00012407 File Offset: 0x00010607
		public TVHomeScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x000D56D0 File Offset: 0x000D38D0
		// (set) Token: 0x0600206D RID: 8301 RVA: 0x00012410 File Offset: 0x00010610
		public unsafe TVInterface Interface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Interface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Interface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x000D5700 File Offset: 0x000D3900
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x0001242F File Offset: 0x0001062F
		public unsafe Il2CppReferenceArray<TVApp> Apps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Apps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TVApp>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Apps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x000D5730 File Offset: 0x000D3930
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x0001244E File Offset: 0x0001064E
		public unsafe RectTransform AppButtonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x000D5760 File Offset: 0x000D3960
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x0001246D File Offset: 0x0001066D
		public unsafe Il2CppReferenceArray<RectTransform> PlayerDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_PlayerDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_PlayerDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x000D5790 File Offset: 0x000D3990
		// (set) Token: 0x06002075 RID: 8309 RVA: 0x0001248C File Offset: 0x0001068C
		public unsafe TextMeshProUGUI TimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_TimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x000D57C0 File Offset: 0x000D39C0
		// (set) Token: 0x06002077 RID: 8311 RVA: 0x000124AB File Offset: 0x000106AB
		public unsafe GameObject AppButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x000D57F0 File Offset: 0x000D39F0
		// (set) Token: 0x06002079 RID: 8313 RVA: 0x000124CA File Offset: 0x000106CA
		public unsafe bool skipExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_skipExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_skipExit)) = value;
			}
		}

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeFieldInfoPtr_Interface;

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeFieldInfoPtr_Apps;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeFieldInfoPtr_AppButtonContainer;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeFieldInfoPtr_PlayerDisplays;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeFieldInfoPtr_AppButtonPrefab;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeFieldInfoPtr_skipExit;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_Void_0;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeLabel_Private_Void_0;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeMethodInfoPtr_AppSelected_Private_Void_TVApp_0;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeMethodInfoPtr_PlayerChange_Private_Void_Player_0;

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008B9 RID: 2233
		[ObfuscatedName("ScheduleOne.TV.TVHomeScreen+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C33C RID: 49980 RVA: 0x002FA3C8 File Offset: 0x002F85C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr);
				TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr_app = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, "app");
				TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, 100666920);
				TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, 100666921);
			}

			// Token: 0x0600C33D RID: 49981 RVA: 0x002FA444 File Offset: 0x002F8644
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C33E RID: 49982 RVA: 0x002FA480 File Offset: 0x002F8680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108860, XrefRangeEnd = 108861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C33F RID: 49983 RVA: 0x0005F03A File Offset: 0x0005D23A
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CF4 RID: 15604
			// (get) Token: 0x0600C340 RID: 49984 RVA: 0x002FA4B4 File Offset: 0x002F86B4
			// (set) Token: 0x0600C341 RID: 49985 RVA: 0x0005F043 File Offset: 0x0005D243
			public unsafe TVApp app
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr_app);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr_app), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF5 RID: 15605
			// (get) Token: 0x0600C342 RID: 49986 RVA: 0x002FA4E4 File Offset: 0x002F86E4
			// (set) Token: 0x0600C343 RID: 49987 RVA: 0x0005F062 File Offset: 0x0005D262
			public unsafe TVHomeScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVHomeScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400846B RID: 33899
			private static readonly IntPtr NativeFieldInfoPtr_app;

			// Token: 0x0400846C RID: 33900
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400846D RID: 33901
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400846E RID: 33902
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
