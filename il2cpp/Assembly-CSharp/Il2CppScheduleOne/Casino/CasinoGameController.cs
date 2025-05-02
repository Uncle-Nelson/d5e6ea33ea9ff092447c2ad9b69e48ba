using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A2 RID: 1186
	public class CasinoGameController : NetworkBehaviour
	{
		// Token: 0x0600672C RID: 26412 RVA: 0x001CFFF8 File Offset: 0x001CE1F8
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGameController()
		{
			Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGameController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr);
			CasinoGameController.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "FOV");
			CasinoGameController.NativeFieldInfoPtr_CAMERA_LERP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "CAMERA_LERP_TIME");
			CasinoGameController.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "<IsOpen>k__BackingField");
			CasinoGameController.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "Players");
			CasinoGameController.NativeFieldInfoPtr_Interaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "Interaction");
			CasinoGameController.NativeFieldInfoPtr_DefaultCameraTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "DefaultCameraTransforms");
			CasinoGameController.NativeFieldInfoPtr_localDefaultCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "localDefaultCameraTransform");
			CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted");
			CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted");
			CasinoGameController.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676378);
			CasinoGameController.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676379);
			CasinoGameController.NativeMethodInfoPtr_get_LocalPlayerData_Public_get_CasinoGamePlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676380);
			CasinoGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676381);
			CasinoGameController.NativeMethodInfoPtr_OnLocalPlayerRequestJoin_Protected_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676382);
			CasinoGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676383);
			CasinoGameController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676384);
			CasinoGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676385);
			CasinoGameController.NativeMethodInfoPtr_Open_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676386);
			CasinoGameController.NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676387);
			CasinoGameController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676388);
			CasinoGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676389);
			CasinoGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676390);
			CasinoGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676391);
			CasinoGameController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676392);
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x0600672D RID: 26413 RVA: 0x001D0208 File Offset: 0x001CE408
		// (set) Token: 0x0600672E RID: 26414 RVA: 0x001D0244 File Offset: 0x001CE444
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x0600672F RID: 26415 RVA: 0x001D0284 File Offset: 0x001CE484
		public unsafe CasinoGamePlayerData LocalPlayerData
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 208999, RefRangeEnd = 209015, XrefRangeStart = 208993, XrefRangeEnd = 208999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_get_LocalPlayerData_Public_get_CasinoGamePlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr3) : null;
			}
		}

		// Token: 0x06006730 RID: 26416 RVA: 0x001D02C4 File Offset: 0x001CE4C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209037, RefRangeEnd = 209039, XrefRangeStart = 209015, XrefRangeEnd = 209037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006731 RID: 26417 RVA: 0x001D0300 File Offset: 0x001CE500
		[CallerCount(0)]
		public unsafe virtual void OnLocalPlayerRequestJoin(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_OnLocalPlayerRequestJoin_Protected_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006732 RID: 26418 RVA: 0x001D0350 File Offset: 0x001CE550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209040, RefRangeEnd = 209041, XrefRangeStart = 209039, XrefRangeEnd = 209040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006733 RID: 26419 RVA: 0x001D03A0 File Offset: 0x001CE5A0
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006734 RID: 26420 RVA: 0x001D03DC File Offset: 0x001CE5DC
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006735 RID: 26421 RVA: 0x001D0418 File Offset: 0x001CE618
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209111, RefRangeEnd = 209113, XrefRangeStart = 209041, XrefRangeEnd = 209111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Open_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006736 RID: 26422 RVA: 0x001D0454 File Offset: 0x001CE654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209170, RefRangeEnd = 209172, XrefRangeStart = 209113, XrefRangeEnd = 209170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006737 RID: 26423 RVA: 0x001D0490 File Offset: 0x001CE690
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 134906, RefRangeEnd = 134928, XrefRangeStart = 134906, XrefRangeEnd = 134928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGameController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006738 RID: 26424 RVA: 0x001D04CC File Offset: 0x001CE6CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209172, RefRangeEnd = 209173, XrefRangeStart = 209172, XrefRangeEnd = 209172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006739 RID: 26425 RVA: 0x001D0508 File Offset: 0x001CE708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209173, RefRangeEnd = 209174, XrefRangeStart = 209173, XrefRangeEnd = 209173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600673A RID: 26426 RVA: 0x001D0544 File Offset: 0x001CE744
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600673B RID: 26427 RVA: 0x001D0580 File Offset: 0x001CE780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209174, XrefRangeEnd = 209196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600673C RID: 26428 RVA: 0x00030BD6 File Offset: 0x0002EDD6
		public CasinoGameController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x0600673D RID: 26429 RVA: 0x001D05BC File Offset: 0x001CE7BC
		// (set) Token: 0x0600673E RID: 26430 RVA: 0x00030BDF File Offset: 0x0002EDDF
		public unsafe static float FOV
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CasinoGameController.NativeFieldInfoPtr_FOV, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CasinoGameController.NativeFieldInfoPtr_FOV, (void*)(&value));
			}
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x0600673F RID: 26431 RVA: 0x001D05D8 File Offset: 0x001CE7D8
		// (set) Token: 0x06006740 RID: 26432 RVA: 0x00030BED File Offset: 0x0002EDED
		public unsafe static float CAMERA_LERP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CasinoGameController.NativeFieldInfoPtr_CAMERA_LERP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CasinoGameController.NativeFieldInfoPtr_CAMERA_LERP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x06006741 RID: 26433 RVA: 0x001D05F4 File Offset: 0x001CE7F4
		// (set) Token: 0x06006742 RID: 26434 RVA: 0x00030BFB File Offset: 0x0002EDFB
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x06006743 RID: 26435 RVA: 0x001D061C File Offset: 0x001CE81C
		// (set) Token: 0x06006744 RID: 26436 RVA: 0x00030C16 File Offset: 0x0002EE16
		public unsafe CasinoGamePlayers Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x06006745 RID: 26437 RVA: 0x001D064C File Offset: 0x001CE84C
		// (set) Token: 0x06006746 RID: 26438 RVA: 0x00030C35 File Offset: 0x0002EE35
		public unsafe CasinoGameInteraction Interaction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Interaction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGameInteraction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Interaction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x06006747 RID: 26439 RVA: 0x001D067C File Offset: 0x001CE87C
		// (set) Token: 0x06006748 RID: 26440 RVA: 0x00030C54 File Offset: 0x0002EE54
		public unsafe Il2CppReferenceArray<Transform> DefaultCameraTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_DefaultCameraTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_DefaultCameraTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x06006749 RID: 26441 RVA: 0x001D06AC File Offset: 0x001CE8AC
		// (set) Token: 0x0600674A RID: 26442 RVA: 0x00030C73 File Offset: 0x0002EE73
		public unsafe Transform localDefaultCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_localDefaultCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_localDefaultCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x0600674B RID: 26443 RVA: 0x001D06DC File Offset: 0x001CE8DC
		// (set) Token: 0x0600674C RID: 26444 RVA: 0x00030C92 File Offset: 0x0002EE92
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x0600674D RID: 26445 RVA: 0x001D0704 File Offset: 0x001CE904
		// (set) Token: 0x0600674E RID: 26446 RVA: 0x00030CAD File Offset: 0x0002EEAD
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040046A1 RID: 18081
		private static readonly IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x040046A2 RID: 18082
		private static readonly IntPtr NativeFieldInfoPtr_CAMERA_LERP_TIME;

		// Token: 0x040046A3 RID: 18083
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040046A4 RID: 18084
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x040046A5 RID: 18085
		private static readonly IntPtr NativeFieldInfoPtr_Interaction;

		// Token: 0x040046A6 RID: 18086
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCameraTransforms;

		// Token: 0x040046A7 RID: 18087
		private static readonly IntPtr NativeFieldInfoPtr_localDefaultCameraTransform;

		// Token: 0x040046A8 RID: 18088
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040046A9 RID: 18089
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040046AA RID: 18090
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040046AB RID: 18091
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040046AC RID: 18092
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerData_Public_get_CasinoGamePlayerData_0;

		// Token: 0x040046AD RID: 18093
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040046AE RID: 18094
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPlayerRequestJoin_Protected_Virtual_New_Void_Player_0;

		// Token: 0x040046AF RID: 18095
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0;

		// Token: 0x040046B0 RID: 18096
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x040046B1 RID: 18097
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x040046B2 RID: 18098
		private static readonly IntPtr NativeMethodInfoPtr_Open_Protected_Virtual_New_Void_1;

		// Token: 0x040046B3 RID: 18099
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_1;

		// Token: 0x040046B4 RID: 18100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040046B5 RID: 18101
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040046B6 RID: 18102
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040046B7 RID: 18103
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040046B8 RID: 18104
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
