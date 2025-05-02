using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005BB RID: 1467
	public class Equippable_TrashGrabber : Equippable_Viewmodel
	{
		// Token: 0x060080A8 RID: 32936 RVA: 0x002260F4 File Offset: 0x002242F4
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_TrashGrabber()
		{
			Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_TrashGrabber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr);
			Equippable_TrashGrabber.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "<Instance>k__BackingField");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashDropSpacing");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashContent");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashContent_Min");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashContent_Max");
			Equippable_TrashGrabber.NativeFieldInfoPtr_GrabAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "GrabAnim");
			Equippable_TrashGrabber.NativeFieldInfoPtr_Bin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "Bin");
			Equippable_TrashGrabber.NativeFieldInfoPtr_BinRaisedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "BinRaisedPosition");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashDropSound");
			Equippable_TrashGrabber.NativeFieldInfoPtr_DropTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "DropTime");
			Equippable_TrashGrabber.NativeFieldInfoPtr_DropForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "DropForce");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashDropOffset");
			Equippable_TrashGrabber.NativeFieldInfoPtr_onPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "onPickup");
			Equippable_TrashGrabber.NativeFieldInfoPtr__currentDropTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "<currentDropTime>k__BackingField");
			Equippable_TrashGrabber.NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "<timeSinceLastDrop>k__BackingField");
			Equippable_TrashGrabber.NativeFieldInfoPtr_trashGrabberInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "trashGrabberInstance");
			Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "defaultBinPosition");
			Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "defaultBinScale");
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_Instance_Public_Static_get_Equippable_TrashGrabber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679439);
			Equippable_TrashGrabber.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Equippable_TrashGrabber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679440);
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_IsEquipped_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679441);
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_currentDropTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679442);
			Equippable_TrashGrabber.NativeMethodInfoPtr_set_currentDropTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679443);
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_timeSinceLastDrop_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679444);
			Equippable_TrashGrabber.NativeMethodInfoPtr_set_timeSinceLastDrop_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679445);
			Equippable_TrashGrabber.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679446);
			Equippable_TrashGrabber.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679447);
			Equippable_TrashGrabber.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679448);
			Equippable_TrashGrabber.NativeMethodInfoPtr_EjectTrash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679449);
			Equippable_TrashGrabber.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679450);
			Equippable_TrashGrabber.NativeMethodInfoPtr_PickupTrash_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679451);
			Equippable_TrashGrabber.NativeMethodInfoPtr_GetCapacity_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679452);
			Equippable_TrashGrabber.NativeMethodInfoPtr_RefreshVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679453);
			Equippable_TrashGrabber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679454);
		}

		// Token: 0x170026EE RID: 9966
		// (get) Token: 0x060080A9 RID: 32937 RVA: 0x002263CC File Offset: 0x002245CC
		// (set) Token: 0x060080AA RID: 32938 RVA: 0x00226400 File Offset: 0x00224600
		public unsafe static Equippable_TrashGrabber Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244762, XrefRangeEnd = 244764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_Instance_Public_Static_get_Equippable_TrashGrabber_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable_TrashGrabber>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244764, XrefRangeEnd = 244768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Equippable_TrashGrabber_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170026EF RID: 9967
		// (get) Token: 0x060080AB RID: 32939 RVA: 0x00226438 File Offset: 0x00224638
		public unsafe static bool IsEquipped
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 244774, RefRangeEnd = 244776, XrefRangeStart = 244768, XrefRangeEnd = 244774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_IsEquipped_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170026F0 RID: 9968
		// (get) Token: 0x060080AC RID: 32940 RVA: 0x00226468 File Offset: 0x00224668
		// (set) Token: 0x060080AD RID: 32941 RVA: 0x002264A4 File Offset: 0x002246A4
		public unsafe float currentDropTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_currentDropTime_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_set_currentDropTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170026F1 RID: 9969
		// (get) Token: 0x060080AE RID: 32942 RVA: 0x002264E4 File Offset: 0x002246E4
		// (set) Token: 0x060080AF RID: 32943 RVA: 0x00226520 File Offset: 0x00224720
		public unsafe float timeSinceLastDrop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_timeSinceLastDrop_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_set_timeSinceLastDrop_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060080B0 RID: 32944 RVA: 0x00226560 File Offset: 0x00224760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244776, XrefRangeEnd = 244811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_TrashGrabber.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080B1 RID: 32945 RVA: 0x002265B0 File Offset: 0x002247B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244811, XrefRangeEnd = 244835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_TrashGrabber.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080B2 RID: 32946 RVA: 0x002265EC File Offset: 0x002247EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244835, XrefRangeEnd = 244863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_TrashGrabber.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080B3 RID: 32947 RVA: 0x00226628 File Offset: 0x00224828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244894, RefRangeEnd = 244895, XrefRangeStart = 244863, XrefRangeEnd = 244894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EjectTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_EjectTrash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080B4 RID: 32948 RVA: 0x0022665C File Offset: 0x0022485C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244895, XrefRangeEnd = 244905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080B5 RID: 32949 RVA: 0x00226690 File Offset: 0x00224890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244910, RefRangeEnd = 244911, XrefRangeStart = 244905, XrefRangeEnd = 244910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PickupTrash(TrashItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_PickupTrash_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080B6 RID: 32950 RVA: 0x002266D4 File Offset: 0x002248D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244912, RefRangeEnd = 244914, XrefRangeStart = 244911, XrefRangeEnd = 244912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_GetCapacity_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060080B7 RID: 32951 RVA: 0x00226710 File Offset: 0x00224910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244928, RefRangeEnd = 244929, XrefRangeStart = 244914, XrefRangeEnd = 244928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_RefreshVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080B8 RID: 32952 RVA: 0x00226744 File Offset: 0x00224944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244929, XrefRangeEnd = 244932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_TrashGrabber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080B9 RID: 32953 RVA: 0x0003D0AB File Offset: 0x0003B2AB
		public Equippable_TrashGrabber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026DC RID: 9948
		// (get) Token: 0x060080BA RID: 32954 RVA: 0x00226780 File Offset: 0x00224980
		// (set) Token: 0x060080BB RID: 32955 RVA: 0x0003D0B4 File Offset: 0x0003B2B4
		public unsafe static Equippable_TrashGrabber _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Equippable_TrashGrabber.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_TrashGrabber>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Equippable_TrashGrabber.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026DD RID: 9949
		// (get) Token: 0x060080BC RID: 32956 RVA: 0x002267A8 File Offset: 0x002249A8
		// (set) Token: 0x060080BD RID: 32957 RVA: 0x0003D0C6 File Offset: 0x0003B2C6
		public unsafe static float TrashDropSpacing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSpacing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSpacing, (void*)(&value));
			}
		}

		// Token: 0x170026DE RID: 9950
		// (get) Token: 0x060080BE RID: 32958 RVA: 0x002267C4 File Offset: 0x002249C4
		// (set) Token: 0x060080BF RID: 32959 RVA: 0x0003D0D4 File Offset: 0x0003B2D4
		public unsafe Transform TrashContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026DF RID: 9951
		// (get) Token: 0x060080C0 RID: 32960 RVA: 0x002267F4 File Offset: 0x002249F4
		// (set) Token: 0x060080C1 RID: 32961 RVA: 0x0003D0F3 File Offset: 0x0003B2F3
		public unsafe Transform TrashContent_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E0 RID: 9952
		// (get) Token: 0x060080C2 RID: 32962 RVA: 0x00226824 File Offset: 0x00224A24
		// (set) Token: 0x060080C3 RID: 32963 RVA: 0x0003D112 File Offset: 0x0003B312
		public unsafe Transform TrashContent_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E1 RID: 9953
		// (get) Token: 0x060080C4 RID: 32964 RVA: 0x00226854 File Offset: 0x00224A54
		// (set) Token: 0x060080C5 RID: 32965 RVA: 0x0003D131 File Offset: 0x0003B331
		public unsafe Animation GrabAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_GrabAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_GrabAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E2 RID: 9954
		// (get) Token: 0x060080C6 RID: 32966 RVA: 0x00226884 File Offset: 0x00224A84
		// (set) Token: 0x060080C7 RID: 32967 RVA: 0x0003D150 File Offset: 0x0003B350
		public unsafe Transform Bin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_Bin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_Bin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E3 RID: 9955
		// (get) Token: 0x060080C8 RID: 32968 RVA: 0x002268B4 File Offset: 0x00224AB4
		// (set) Token: 0x060080C9 RID: 32969 RVA: 0x0003D16F File Offset: 0x0003B36F
		public unsafe Transform BinRaisedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_BinRaisedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_BinRaisedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E4 RID: 9956
		// (get) Token: 0x060080CA RID: 32970 RVA: 0x002268E4 File Offset: 0x00224AE4
		// (set) Token: 0x060080CB RID: 32971 RVA: 0x0003D18E File Offset: 0x0003B38E
		public unsafe AudioSourceController TrashDropSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E5 RID: 9957
		// (get) Token: 0x060080CC RID: 32972 RVA: 0x00226914 File Offset: 0x00224B14
		// (set) Token: 0x060080CD RID: 32973 RVA: 0x0003D1AD File Offset: 0x0003B3AD
		public unsafe float DropTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropTime)) = value;
			}
		}

		// Token: 0x170026E6 RID: 9958
		// (get) Token: 0x060080CE RID: 32974 RVA: 0x0022693C File Offset: 0x00224B3C
		// (set) Token: 0x060080CF RID: 32975 RVA: 0x0003D1C8 File Offset: 0x0003B3C8
		public unsafe float DropForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropForce)) = value;
			}
		}

		// Token: 0x170026E7 RID: 9959
		// (get) Token: 0x060080D0 RID: 32976 RVA: 0x00226964 File Offset: 0x00224B64
		// (set) Token: 0x060080D1 RID: 32977 RVA: 0x0003D1E3 File Offset: 0x0003B3E3
		public unsafe Vector3 TrashDropOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropOffset)) = value;
			}
		}

		// Token: 0x170026E8 RID: 9960
		// (get) Token: 0x060080D2 RID: 32978 RVA: 0x0022698C File Offset: 0x00224B8C
		// (set) Token: 0x060080D3 RID: 32979 RVA: 0x0003D1FE File Offset: 0x0003B3FE
		public unsafe UnityEvent onPickup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_onPickup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_onPickup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E9 RID: 9961
		// (get) Token: 0x060080D4 RID: 32980 RVA: 0x002269BC File Offset: 0x00224BBC
		// (set) Token: 0x060080D5 RID: 32981 RVA: 0x0003D21D File Offset: 0x0003B41D
		public unsafe float _currentDropTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__currentDropTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__currentDropTime_k__BackingField)) = value;
			}
		}

		// Token: 0x170026EA RID: 9962
		// (get) Token: 0x060080D6 RID: 32982 RVA: 0x002269E4 File Offset: 0x00224BE4
		// (set) Token: 0x060080D7 RID: 32983 RVA: 0x0003D238 File Offset: 0x0003B438
		public unsafe float _timeSinceLastDrop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField)) = value;
			}
		}

		// Token: 0x170026EB RID: 9963
		// (get) Token: 0x060080D8 RID: 32984 RVA: 0x00226A0C File Offset: 0x00224C0C
		// (set) Token: 0x060080D9 RID: 32985 RVA: 0x0003D253 File Offset: 0x0003B453
		public unsafe TrashGrabberInstance trashGrabberInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_trashGrabberInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_trashGrabberInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026EC RID: 9964
		// (get) Token: 0x060080DA RID: 32986 RVA: 0x00226A3C File Offset: 0x00224C3C
		// (set) Token: 0x060080DB RID: 32987 RVA: 0x0003D272 File Offset: 0x0003B472
		public unsafe Pose defaultBinPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinPosition)) = value;
			}
		}

		// Token: 0x170026ED RID: 9965
		// (get) Token: 0x060080DC RID: 32988 RVA: 0x00226A64 File Offset: 0x00224C64
		// (set) Token: 0x060080DD RID: 32989 RVA: 0x0003D28D File Offset: 0x0003B48D
		public unsafe Vector3 defaultBinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinScale)) = value;
			}
		}

		// Token: 0x0400579F RID: 22431
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x040057A0 RID: 22432
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropSpacing;

		// Token: 0x040057A1 RID: 22433
		private static readonly IntPtr NativeFieldInfoPtr_TrashContent;

		// Token: 0x040057A2 RID: 22434
		private static readonly IntPtr NativeFieldInfoPtr_TrashContent_Min;

		// Token: 0x040057A3 RID: 22435
		private static readonly IntPtr NativeFieldInfoPtr_TrashContent_Max;

		// Token: 0x040057A4 RID: 22436
		private static readonly IntPtr NativeFieldInfoPtr_GrabAnim;

		// Token: 0x040057A5 RID: 22437
		private static readonly IntPtr NativeFieldInfoPtr_Bin;

		// Token: 0x040057A6 RID: 22438
		private static readonly IntPtr NativeFieldInfoPtr_BinRaisedPosition;

		// Token: 0x040057A7 RID: 22439
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropSound;

		// Token: 0x040057A8 RID: 22440
		private static readonly IntPtr NativeFieldInfoPtr_DropTime;

		// Token: 0x040057A9 RID: 22441
		private static readonly IntPtr NativeFieldInfoPtr_DropForce;

		// Token: 0x040057AA RID: 22442
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropOffset;

		// Token: 0x040057AB RID: 22443
		private static readonly IntPtr NativeFieldInfoPtr_onPickup;

		// Token: 0x040057AC RID: 22444
		private static readonly IntPtr NativeFieldInfoPtr__currentDropTime_k__BackingField;

		// Token: 0x040057AD RID: 22445
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField;

		// Token: 0x040057AE RID: 22446
		private static readonly IntPtr NativeFieldInfoPtr_trashGrabberInstance;

		// Token: 0x040057AF RID: 22447
		private static readonly IntPtr NativeFieldInfoPtr_defaultBinPosition;

		// Token: 0x040057B0 RID: 22448
		private static readonly IntPtr NativeFieldInfoPtr_defaultBinScale;

		// Token: 0x040057B1 RID: 22449
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Equippable_TrashGrabber_0;

		// Token: 0x040057B2 RID: 22450
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Equippable_TrashGrabber_0;

		// Token: 0x040057B3 RID: 22451
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEquipped_Public_Static_get_Boolean_0;

		// Token: 0x040057B4 RID: 22452
		private static readonly IntPtr NativeMethodInfoPtr_get_currentDropTime_Private_get_Single_0;

		// Token: 0x040057B5 RID: 22453
		private static readonly IntPtr NativeMethodInfoPtr_set_currentDropTime_Private_set_Void_Single_0;

		// Token: 0x040057B6 RID: 22454
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceLastDrop_Private_get_Single_0;

		// Token: 0x040057B7 RID: 22455
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSinceLastDrop_Private_set_Void_Single_0;

		// Token: 0x040057B8 RID: 22456
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040057B9 RID: 22457
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040057BA RID: 22458
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040057BB RID: 22459
		private static readonly IntPtr NativeMethodInfoPtr_EjectTrash_Private_Void_0;

		// Token: 0x040057BC RID: 22460
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040057BD RID: 22461
		private static readonly IntPtr NativeMethodInfoPtr_PickupTrash_Public_Void_TrashItem_0;

		// Token: 0x040057BE RID: 22462
		private static readonly IntPtr NativeMethodInfoPtr_GetCapacity_Public_Int32_0;

		// Token: 0x040057BF RID: 22463
		private static readonly IntPtr NativeMethodInfoPtr_RefreshVisuals_Private_Void_0;

		// Token: 0x040057C0 RID: 22464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
