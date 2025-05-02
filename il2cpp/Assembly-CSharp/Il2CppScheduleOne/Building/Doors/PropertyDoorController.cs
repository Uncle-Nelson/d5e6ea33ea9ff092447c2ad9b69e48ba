using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Property;

namespace Il2CppScheduleOne.Building.Doors
{
	// Token: 0x020004C6 RID: 1222
	public class PropertyDoorController : DoorController
	{
		// Token: 0x06006AF3 RID: 27379 RVA: 0x001DD350 File Offset: 0x001DB550
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyDoorController()
		{
			Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building.Doors", "PropertyDoorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr);
			PropertyDoorController.NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "WANTED_PLAYER_CLOSE_DISTANCE");
			PropertyDoorController.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "Property");
			PropertyDoorController.NativeFieldInfoPtr_IsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "IsUnlocked");
			PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted");
			PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted");
			PropertyDoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676851);
			PropertyDoorController.NativeMethodInfoPtr_Unlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676852);
			PropertyDoorController.NativeMethodInfoPtr_CheckClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676853);
			PropertyDoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676854);
			PropertyDoorController.NativeMethodInfoPtr_GetNearestWantedPlayer_Private_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676855);
			PropertyDoorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676856);
			PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676857);
			PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676858);
			PropertyDoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676859);
			PropertyDoorController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100676860);
		}

		// Token: 0x06006AF4 RID: 27380 RVA: 0x001DD4AC File Offset: 0x001DB6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215589, XrefRangeEnd = 215605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AF5 RID: 27381 RVA: 0x001DD4E8 File Offset: 0x001DB6E8
		[CallerCount(0)]
		public unsafe void Unlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr_Unlock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AF6 RID: 27382 RVA: 0x001DD51C File Offset: 0x001DB71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215605, XrefRangeEnd = 215615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr_CheckClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AF7 RID: 27383 RVA: 0x001DD550 File Offset: 0x001DB750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215615, XrefRangeEnd = 215641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06006AF8 RID: 27384 RVA: 0x001DD5C0 File Offset: 0x001DB7C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215675, RefRangeEnd = 215677, XrefRangeStart = 215641, XrefRangeEnd = 215675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetNearestWantedPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr_GetNearestWantedPlayer_Private_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x06006AF9 RID: 27385 RVA: 0x001DD600 File Offset: 0x001DB800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215677, XrefRangeEnd = 215678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDoorController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AFA RID: 27386 RVA: 0x001DD63C File Offset: 0x001DB83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215678, XrefRangeEnd = 215679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AFB RID: 27387 RVA: 0x001DD678 File Offset: 0x001DB878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215679, XrefRangeEnd = 215680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AFC RID: 27388 RVA: 0x001DD6B4 File Offset: 0x001DB8B4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AFD RID: 27389 RVA: 0x001DD6F0 File Offset: 0x001DB8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215680, XrefRangeEnd = 215695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AFE RID: 27390 RVA: 0x0003292F File Offset: 0x00030B2F
		public PropertyDoorController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x06006AFF RID: 27391 RVA: 0x001DD72C File Offset: 0x001DB92C
		// (set) Token: 0x06006B00 RID: 27392 RVA: 0x00032938 File Offset: 0x00030B38
		public unsafe static float WANTED_PLAYER_CLOSE_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PropertyDoorController.NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropertyDoorController.NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x06006B01 RID: 27393 RVA: 0x001DD748 File Offset: 0x001DB948
		// (set) Token: 0x06006B02 RID: 27394 RVA: 0x00032946 File Offset: 0x00030B46
		public unsafe Property Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x06006B03 RID: 27395 RVA: 0x001DD778 File Offset: 0x001DB978
		// (set) Token: 0x06006B04 RID: 27396 RVA: 0x00032965 File Offset: 0x00030B65
		public unsafe bool IsUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_IsUnlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_IsUnlocked)) = value;
			}
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x06006B05 RID: 27397 RVA: 0x001DD7A0 File Offset: 0x001DB9A0
		// (set) Token: 0x06006B06 RID: 27398 RVA: 0x00032980 File Offset: 0x00030B80
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x06006B07 RID: 27399 RVA: 0x001DD7C8 File Offset: 0x001DB9C8
		// (set) Token: 0x06006B08 RID: 27400 RVA: 0x0003299B File Offset: 0x00030B9B
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004930 RID: 18736
		private static readonly IntPtr NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE;

		// Token: 0x04004931 RID: 18737
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04004932 RID: 18738
		private static readonly IntPtr NativeFieldInfoPtr_IsUnlocked;

		// Token: 0x04004933 RID: 18739
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004934 RID: 18740
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004935 RID: 18741
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004936 RID: 18742
		private static readonly IntPtr NativeMethodInfoPtr_Unlock_Public_Void_0;

		// Token: 0x04004937 RID: 18743
		private static readonly IntPtr NativeMethodInfoPtr_CheckClose_Private_Void_0;

		// Token: 0x04004938 RID: 18744
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0;

		// Token: 0x04004939 RID: 18745
		private static readonly IntPtr NativeMethodInfoPtr_GetNearestWantedPlayer_Private_Player_0;

		// Token: 0x0400493A RID: 18746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400493B RID: 18747
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400493C RID: 18748
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400493D RID: 18749
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400493E RID: 18750
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
